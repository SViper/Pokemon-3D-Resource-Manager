Imports System.Windows.Forms
Imports System.Net
Imports Ionic.Zip
Imports System.IO

Public Class Updater

    Dim SW As Stopwatch
    Public client As WebClient = New WebClient
    Public DownloadStatus As String
    Public CurrentBytes As Double
    Public TotalBytes As Double

    Private Sub Downloader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ServerVersion As String = client.DownloadString("https://raw.githubusercontent.com/jianmingyong/Pokemon-3D-Resource-Manager/master/Server%20Files/Application%20Version.txt")
        Dim Settingstr5 As String = Functions.GetTextFromLine(P3DUpdater.My.Application.Info.DirectoryPath + "\Settings.dat", 6)
        Resources_CurrentVersion.Text = Settingstr5.Remove(0, 10)
        Resources_LatestVersion.Text = ServerVersion
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
            client.DownloadFileAsync(New Uri("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Pok%C3%A9mon%203D%20Resource%20Manager.zip"), P3DUpdater.My.Application.Info.DirectoryPath + "\Update.zip")
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
        Try
            Threading.Thread.Sleep(1000)
            If File.Exists(P3DUpdater.My.Application.Info.DirectoryPath + "\Update.zip") Then
                System.IO.File.Delete(P3DUpdater.My.Application.Info.DirectoryPath + "\Update.zip")
            End If
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
        Shell(P3DUpdater.My.Application.Info.DirectoryPath + "\Pokémon 3D Resource Manager.exe", AppWinStyle.NormalFocus)
        Application.Exit()
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
            Extract()
        Else
            Functions.ReturnError("Download Failed! Please try again later.")
            System.IO.File.Delete(P3DUpdater.My.Application.Info.DirectoryPath + "\Update.zip")
            Me.Close()
        End If
    End Sub

    Private Sub Extract()
        Cancel_Button.Enabled = False
        StatusText.AppendText(vbNewLine + "Extracting Files...")
        Try
            Using zip As ZipFile = ZipFile.Read(P3DUpdater.My.Application.Info.DirectoryPath + "\Update.zip")
                Dim e As ZipEntry
                For Each e In zip
                    StatusText.Focus()
                    e.Extract(P3DUpdater.My.Application.Info.DirectoryPath, ExtractExistingFileAction.OverwriteSilently)
                    StatusText.AppendText(vbNewLine + e.FileName.ToString)
                    Application.DoEvents()
                Next
            End Using
            System.IO.File.Delete(P3DUpdater.My.Application.Info.DirectoryPath + "\Update.zip")
            StatusText.AppendText(vbNewLine + "Extracting Completed!")
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
            Functions.ReturnError("Update Failed!")
            System.IO.File.Delete(P3DUpdater.My.Application.Info.DirectoryPath + "\Update.zip")
            Application.Exit()
            Exit Sub
        End Try
        Functions.ReturnError("Update Completed!")
        Shell(P3DUpdater.My.Application.Info.DirectoryPath + "\Pokémon 3D Resource Manager.exe", AppWinStyle.NormalFocus)
        Application.Exit()
    End Sub

End Class