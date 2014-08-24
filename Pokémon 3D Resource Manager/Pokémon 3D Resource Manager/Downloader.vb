Imports System.Windows.Forms
Imports System.Net
Imports RARNET
Imports Ionic.Zip
Imports System.IO

Public Class Downloader

    Public d As Decompressor
    Public SW As Stopwatch
    Public client As WebClient = New WebClient

    Public DownloadStatus As String
    Public CurrentBytes As Double
    Public TotalBytes As Double
    Public FileLocation As String


    Private Sub Downloader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Resources_ContentCategory.Text = Main.ResourceCategory
        Resources_Author.Text = Main.ResourceAuthor
        Resources_CurrentVersion.Text = Main.ResourceCurrentVersion
        Resources_LatestVersion.Text = Main.ResourceLatestVersion
        Resources_Dependency.Text = Main.ResourceDependency
        Resources_Compatible.Text = Main.ResourceCompatible
        Resources_Installed.Text = Main.ResourceInstalled
        Resources_Description.Text = Main.ResourceDescription
        TextName.Text = "Download the latest version of " + Main.ResourceName + "?"
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
            If Not Directory.Exists(Main.ApplicationDirectory + "\Cache\DownloadData") Then
                Directory.CreateDirectory(Main.ApplicationDirectory + "\Cache\DownloadData")
            End If
            client.DownloadFileAsync(New Uri(Main.ResourceURL), Main.ApplicationDirectory + "\Cache\DownloadData" + "\" + Main.ResourceName + "." + Main.ResourceExtention)
            SW = Stopwatch.StartNew
            OK_Button.Enabled = False
            Cancel_Button.Enabled = True
            StatusText.Text = "Preparing to start Download..." + vbNewLine + "Please wait for a while. Some download links takes time to load." + vbNewLine + "If it does not start after few minutes, cancel it and try again." + vbNewLine + "If you have tried many times and nothing works, report this bug at: http://pokemon3d.net/forum/threads/8234/"
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.client.CancelAsync()
        Me.DownloadStatus = "Cancel"
        Try
            Threading.Thread.Sleep(1000)
            If File.Exists(Main.ApplicationDirectory + "\Cache\DownloadData" + "\" + Main.ResourceName + "." + Main.ResourceExtention) Then
                File.Delete(Main.ApplicationDirectory + "\Cache\DownloadData" + "\" + Main.ResourceName + "." + Main.ResourceExtention)
            End If
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
        Me.Close()
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            CurrentBytes = Double.Parse(e.BytesReceived)
            TotalBytes = Double.Parse(e.TotalBytesToReceive)
            Dim percentage As String = Math.Round(CurrentBytes / TotalBytes * 100, 2)
            Dim CurrentKiloBytes As String = Math.Round(CurrentBytes / 1024, 2)
            Dim TotalKiloBytes As String = Math.Round(TotalBytes / 1024, 2)
            Dim CurrentMegaBytes As String = Math.Round(CurrentBytes / 1048576, 2)
            Dim TotalMegaBytes As String = Math.Round(TotalBytes / 1048576, 2)
            Dim CurrentGigaBytes As String = Math.Round(CurrentBytes / 1073741824, 2)
            Dim TotalGigaBytes As String = Math.Round(TotalBytes / 1073741824, 2)
            If TotalBytes <= 1024 Then
                StatusText.Text = "Downloading: " + CurrentBytes.ToString + " B / " + TotalBytes.ToString + " B ( " + percentage + " % ) " +
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
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            Application.Exit()
            Exit Sub
        End Try
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        If CurrentBytes = TotalBytes Then
            Try
                If Directory.Exists(Main.P3DDirectory + "\" + Main.ResourceType + "\" + Main.ResourceName) Then
                    System.IO.Directory.Delete(Main.P3DDirectory + "\" + Main.ResourceType + "\" + Main.ResourceName, True)
                End If
                If Main.DownloadLocation = Nothing Then
                    StatusText.AppendText(vbNewLine + "Download Complete." + vbNewLine + "Moving files to " + Main.P3DDirectory + "\" + Main.ResourceType + "\" + Main.ResourceName + "." + Main.ResourceExtention)
                    File.Move(Main.ApplicationDirectory + "\Cache\DownloadData" + "\" + Main.ResourceName + "." + Main.ResourceExtention, Main.P3DDirectory + "\" + Main.ResourceType + "\" + Main.ResourceName + "." + Main.ResourceExtention)
                    FileLocation = Main.P3DDirectory + "\" + Main.ResourceType
                ElseIf Not Main.DownloadLocation = Nothing Then
                    StatusText.AppendText(vbNewLine + "Download Complete." + vbNewLine + "Moving files to " + Main.P3DDirectory + "\" + Main.DownloadLocation)
                    File.Move(Main.ApplicationDirectory + "\Cache\DownloadData" + "\" + Main.ResourceName + "." + Main.ResourceExtention, Main.P3DDirectory + "\" + Main.DownloadLocation)
                    FileLocation = Main.P3DDirectory + "\" + Main.DownloadLocation.Remove(Main.DownloadLocation.Length - Main.ResourceExtention.Length - 1 - Main.ResourceName.Length)
                End If
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                Application.Exit()
                Exit Sub
            End Try
            Extract()
        ElseIf Not DownloadStatus = "Cancel" Then
            Functions.ReturnMessage("Download Failed! Please try again later.")
            Try
                If File.Exists(Main.ApplicationDirectory + "\Cache\DownloadData" + "\" + Main.ResourceName + "." + Main.ResourceExtention) Then
                    System.IO.File.Delete(Main.ApplicationDirectory + "\Cache\DownloadData" + "\" + Main.ResourceName + "." + Main.ResourceExtention)
                End If
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            End Try
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Extract()
        Cancel_Button.Enabled = False
        StatusText.AppendText(vbNewLine + "Extracting Files...")
        If Main.ResourceExtention = "rar" Then
            Try
                d = New Decompressor(FileLocation + "\" + Main.ResourceName + "." + Main.ResourceExtention)
                If Main.DownloadLocation = Nothing Then
                    For Each r As Decompressor.RAREntry In d.RARFiles
                        StatusText.Focus()
                        d.UnPack(r.FileName.ToString(), FileLocation)
                        StatusText.AppendText(vbNewLine + r.FileName.ToString)
                        Application.DoEvents()
                    Next
                ElseIf Not Main.DownloadLocation = Nothing Then
                    For Each r As Decompressor.RAREntry In d.RARFiles
                        StatusText.Focus()
                        d.UnPack(r.FileName.ToString(), FileLocation)
                        StatusText.AppendText(vbNewLine + r.FileName.ToString)
                        Application.DoEvents()
                    Next
                End If
                File.Delete(FileLocation + "\" + Main.ResourceName + "." + Main.ResourceExtention)
                StatusText.AppendText(vbNewLine + "Extracting Completed!")
                If Main.DeleteFiles = Nothing Then
                    Functions.ReturnMessage("Download and Extracted Completed!")
                ElseIf Not Main.DeleteFiles = Nothing Then
                    Dim CurrentIndex As Integer = 0
                    Do While Not Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ",") = Nothing
                        If File.Exists(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ",")) Then
                            Try
                                File.Delete(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ","))
                            Catch ex As Exception
                                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                            End Try
                        End If
                        If Directory.Exists(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ",")) Then
                            Try
                                Directory.Delete(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ","))
                            Catch ex As Exception
                                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                            End Try
                        End If
                        CurrentIndex = CurrentIndex + 1
                    Loop
                End If
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            End Try
        ElseIf (Main.ResourceExtention = "zip") And ZipFile.IsZipFile(Main.P3DDirectory + "\" + Main.ResourceType + "\" + Main.ResourceName + "." + Main.ResourceExtention) = True Then
            Try
                Using zip As ZipFile = ZipFile.Read(FileLocation + "\" + Main.ResourceName + "." + Main.ResourceExtention)
                    Dim e As ZipEntry
                    If Main.DownloadLocation = Nothing Then
                        For Each e In zip
                            StatusText.Focus()
                            e.Extract(FileLocation, ExtractExistingFileAction.OverwriteSilently)
                            StatusText.AppendText(vbNewLine + e.FileName.ToString)
                            Application.DoEvents()
                        Next
                    ElseIf Not Main.DownloadLocation = Nothing Then
                        For Each e In zip
                            StatusText.Focus()
                            e.Extract(FileLocation, ExtractExistingFileAction.OverwriteSilently)
                            StatusText.AppendText(vbNewLine + e.FileName.ToString)
                            Application.DoEvents()
                        Next
                    End If
                End Using
                File.Delete(FileLocation + "\" + Main.ResourceName + "." + Main.ResourceExtention)
                StatusText.AppendText(vbNewLine + "Extracting Completed!")
                If Main.DeleteFiles = Nothing Then
                    Functions.ReturnMessage("Download and Extracted Completed!")
                ElseIf Not Main.DeleteFiles = Nothing Then
                    Dim CurrentIndex As Integer = 0
                    Do While Not Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ",") = Nothing
                        If File.Exists(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ",")) Then
                            Try
                                File.Delete(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ","))
                            Catch ex As Exception
                                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                            End Try
                        End If
                        If Directory.Exists(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ",")) Then
                            Try
                                Directory.Delete(Main.P3DDirectory + "\" + Functions.GetSplit(Main.DeleteFiles, CurrentIndex, ","))
                            Catch ex As Exception
                                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                            End Try
                        End If
                        CurrentIndex = CurrentIndex + 1
                    Loop
                End If
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            End Try
        Else
            Functions.ReturnMessage("The File Extraction class does not support this file." + vbNewLine + "Extract Failed.")
        End If
        Me.Close()
    End Sub

End Class
