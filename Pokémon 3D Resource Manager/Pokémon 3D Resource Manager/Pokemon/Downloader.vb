Imports System.Windows.Forms
Imports System.Net
Imports RARNET
Imports Ionic.Zip
Imports System.IO

Public Class Downloader

    Public client As WebClient = New WebClient
    Public DownloadStatus As String
    Dim d As Decompressor
    Dim SW As Stopwatch

    Private Sub Downloader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Resources_ContentCategory.Text = FileCheck.ResourceCategory
        Resources_Author.Text = FileCheck.ResourceAuthor
        Resources_CurrentVersion.Text = FileCheck.ResourceCurrentVersion
        Resources_LatestVersion.Text = FileCheck.ResourceLatestVersion
        Resources_Dependency.Text = FileCheck.ResourceDependency
        Resources_Compatible.Text = FileCheck.ResourceCompatible
        Resources_Installed.Text = FileCheck.ResourceInstalled
        Resources_Description.Text = FileCheck.ResourceDescription
        TextName.Text = "Download the latest version of " + FileCheck.ResourceName + "?"
        DownloadStatus = "True"
        OK_Button.Enabled = True
        Cancel_Button.Enabled = True
        StatusText.Text = ""
        ProgressBar1.Value = 0
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        Try
            client.DownloadFileAsync(New Uri(FileCheck.ResourceURL), FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt)
            SW = Stopwatch.StartNew
            OK_Button.Enabled = False
            Cancel_Button.Enabled = True
            StatusText.Text = "Preparing to start Download..." + vbNewLine + "Please wait for a while. Some download links takes time to load." + vbNewLine + "If it does not start after few minutes, cancel it and try again." + vbNewLine + "If you have tried many times and noting works, report this bug at: http://pokemon3d.net/forum/threads/8234/"
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.client.CancelAsync()
        Me.DownloadStatus = "Cancel"
        Me.Close()
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        StatusText.Text = "Downloading: " + Math.Round((bytesIn / 1048576), 2).ToString + " MB / " + Math.Round((totalBytes / 1048576), 2).ToString + " MB ( " + Math.Round(percentage, 2).ToString + " % ) " + Math.Round(bytesIn / SW.ElapsedMilliseconds, 2).ToString + " KB/Sec"
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        Application.DoEvents()
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        If e.Cancelled = False Then
            If Directory.Exists(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName) Then
                System.IO.Directory.Delete(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName, True)
            End If
            Extract()
        End If
    End Sub

    Private Sub Extract()
        StatusText.AppendText(vbNewLine + "Extracting Files...")
        If (FileCheck.ResourceExt = "rar" Or FileCheck.ResourceExt = "RAR") Then
            Try
                d = New Decompressor(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt)
                For Each r As Decompressor.RAREntry In d.RARFiles
                    StatusText.Focus()
                    d.UnPack(r.FileName.ToString(), FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype)
                    StatusText.AppendText(vbNewLine + r.FileName.ToString)
                    Application.DoEvents()
                Next
                System.IO.File.Delete(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt)
                StatusText.AppendText(vbNewLine + "Extracting Completed!")
            Catch ex As Exception
                Functions.ReturnError(ex.Message)
            End Try
        ElseIf (FileCheck.ResourceExt = "zip" Or FileCheck.ResourceExt = "ZIP") Then
            Try
                Using zip As ZipFile = ZipFile.Read(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt)
                    Dim e As ZipEntry
                    For Each e In zip
                        StatusText.Focus()
                        e.Extract(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype, ExtractExistingFileAction.OverwriteSilently)
                        StatusText.AppendText(vbNewLine + e.FileName.ToString)
                        Application.DoEvents()
                    Next
                End Using
                System.IO.File.Delete(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt)
                StatusText.AppendText(vbNewLine + "Extracting Completed!")
            Catch ex As Exception
                Functions.ReturnError(ex.Message)
            End Try
        Else
            Functions.ReturnError("The File Extraction class does not support this file." + vbNewLine + "Extract Failed.")
        End If
        FileCheck.PlaySystemSound()
        MsgBox("Download Completed!")
        Me.Close()
    End Sub

End Class
