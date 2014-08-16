Imports System.Windows.Forms
Imports System.Net
Imports RARNET
Imports Ionic.Zip
Imports System.IO

Public Class Downloader

    Dim d As Decompressor
    Dim SW As Stopwatch
    Public client As WebClient = New WebClient
    Public DownloadStatus As String
    Public CurrentBytes As Double
    Public TotalBytes As Double


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
            StatusText.Text = "Preparing to start Download..." + vbNewLine + "Please wait for a while. Some download links takes time to load." + vbNewLine + "If it does not start after few minutes, cancel it and try again." + vbNewLine + "If you have tried many times and nothing works, report this bug at: http://pokemon3d.net/forum/threads/8234/"
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.client.CancelAsync()
        Me.DownloadStatus = "Cancel"
        Try
            Threading.Thread.Sleep(1000)
            If File.Exists(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt) Then
                System.IO.File.Delete(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt)
            End If
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        CurrentBytes = Double.Parse(e.BytesReceived, Globalization.NumberStyles.AllowDecimalPoint)
        TotalBytes = Double.Parse(e.TotalBytesToReceive, Globalization.NumberStyles.AllowDecimalPoint)
        Dim percentage As String = Math.Round(CurrentBytes / TotalBytes * 100, 2)
        Dim CurrentKiloBytes As String = Math.Round(CurrentBytes / 1024, 2)
        Dim TotalKiloBytes As String = Math.Round(TotalBytes / 1024, 2)
        Dim CurrentMegaBytes As String = Math.Round(CurrentBytes / 1048576, 2)
        Dim TotalMegaBytes As String = Math.Round(TotalBytes / 1048576, 2)
        Dim CurrentGigaBytes As String = Math.Round(CurrentBytes / 1073741824, 2)
        Dim TotalGigaBytes As String = Math.Round(TotalBytes / 1073741824, 2)
        If TotalBytes <= 1024 Then
            StatusText.Text = "Downloading: " + CurrentBytes + " B / " + TotalBytes + " B ( " + percentage + " % ) " +
            vbNewLine + "Download Speed: " + Math.Round(CurrentBytes / SW.ElapsedMilliseconds, 2).ToString + " KB/Sec"
        ElseIf TotalBytes <= 1048576 Then
            StatusText.Text = "Downloading: " + CurrentKiloBytes + " KB / " + TotalKiloBytes + " KB ( " + percentage + " % ) " +
            vbNewLine + "Download Speed: " + Math.Round(CurrentBytes / SW.ElapsedMilliseconds, 2).ToString + " KB/Sec"
        ElseIf TotalBytes <= 1073741824 Then
            StatusText.Text = "Downloading: " + CurrentMegaBytes + " MB / " + TotalMegaBytes + " MB ( " + percentage + " % ) " +
            vbNewLine + "Download Speed: " + Math.Round(CurrentBytes / SW.ElapsedMilliseconds, 2).ToString + " KB/Sec"
        ElseIf TotalBytes <= 1099511627776 Then
            StatusText.Text = "Downloading: " + CurrentGigaBytes + " GB / " + TotalGigaBytes + " GB ( " + percentage + " % ) " +
            vbNewLine + "Download Speed: " + Math.Round(CurrentBytes / SW.ElapsedMilliseconds, 2).ToString + " KB/Sec"
        End If
        ProgressBar1.Value = percentage
        Application.DoEvents()
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        If CurrentBytes = TotalBytes Then
            If Directory.Exists(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName) Then
                System.IO.Directory.Delete(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName, True)
            End If
            Extract()
        Else
            Functions.ReturnError("Download Failed! Please try again later.")
            System.IO.File.Delete(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName + "." + FileCheck.ResourceExt)
            Me.Close()
        End If
    End Sub

    Private Sub Extract()
        Cancel_Button.Enabled = False
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
        Functions.ReturnError("Download and Extracted Completed!")
        Me.Close()
    End Sub

End Class
