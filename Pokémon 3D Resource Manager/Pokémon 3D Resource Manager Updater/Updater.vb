Imports System.Windows.Forms
Imports System.Net
Imports Ionic.Zip
Imports System.IO
Imports Pokémon3D

Public Class Updater

    Public client As WebClient = New WebClient()

    Public ApplicationDirectory As String = Pokémon3D.My.Application.Info.DirectoryPath

    Public LauncherDirectory As String = Pokémon3D.My.Application.Info.DirectoryPath
    Public P3DDirectory As String = LauncherDirectory + "\Pokemon"

    Public ApplicationVersion As String = Pokémon3D.My.Application.Info.Version.ToString
    Public ApplicationLatestVersion As String

    Public ResourceType As String = "Application"
    Public ResourceName As String = "Pokémon 3D Resource Manager"
    Public ResourceCategory As String = "Tools"
    Public ResourceAuthor As String = "jianmingyong"
    Public ResourceCurrentVersion As String = ApplicationVersion
    Public ResourceLatestVersion As String = ApplicationLatestVersion
    Public ResourceDependency As String = "Pokémon 3D Resource Manager.exe"
    Public ResourceCompatible As String = "True"
    Public ResourceInstalled As String = "True (" + ApplicationVersion + ")"
    Public ResourceDescription As String = "Application Update"
    Public ResourceFolderName As String = "Pokémon 3D Resource Manager"
    Public ResourceURL As String = "https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Pok%C3%A9mon%203D%20Resource%20Manager.zip"
    Public ResourceExt As String = "zip"
    Public ResourceDownloadOption As String = Nothing

    Public SW As Stopwatch
    Public DownloadStatus As String
    Public CurrentBytes As Double
    Public TotalBytes As Double

    Private Sub Downloader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists(Pokémon3D.My.Application.Info.DirectoryPath + "\Settings.dat") Then
            Functions.ReturnMessage("Please run Pokémon 3D Resource Manager.exe")
            Close()
        Else
            Try
                ApplicationLatestVersion = client.DownloadString("https://raw.githubusercontent.com/jianmingyong/Pokemon-3D-Resource-Manager/master/Server%20Files/Application%20Version.txt")
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            End Try
            If Not ApplicationLatestVersion = Nothing And ApplicationLatestVersion = ApplicationVersion Then
                Functions.ReturnMessage("You are running the latest version of this application.")
                Functions.Run(ApplicationDirectory + "\Pokémon 3D Resource Manager.exe", Nothing, True)
            ElseIf Not ApplicationLatestVersion = Nothing And Not ApplicationLatestVersion = ApplicationVersion Then
                Resources_ContentCategory.Text = ResourceCategory
                Resources_Author.Text = ResourceAuthor
                Resources_CurrentVersion.Text = ResourceCurrentVersion
                Resources_LatestVersion.Text = ResourceLatestVersion
                Resources_Dependency.Text = ResourceDependency
                Resources_Compatible.Text = ResourceCompatible
                Resources_Installed.Text = ResourceInstalled
                Resources_Description.Text = ResourceDescription
                DownloadStatus = "True"
                OK_Button.Enabled = True
                Cancel_Button.Enabled = True
                StatusText.Text = ""
                ProgressBar1.Value = 0
            Else
                Functions.ReturnMessage("Application could not check for update. Your internet or the server is not working.")
            End If
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        Try
            client.DownloadFileAsync(New Uri(ResourceURL), ApplicationDirectory + "\" + ResourceFolderName + "." + ResourceExt)
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
            If File.Exists(Pokémon3D.My.Application.Info.DirectoryPath + "\Update.zip") Then
                System.IO.File.Delete(Pokémon3D.My.Application.Info.DirectoryPath + "\Update.zip")
            End If
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
        Shell(Pokémon3D.My.Application.Info.DirectoryPath + "\Pokémon 3D Resource Manager.exe", AppWinStyle.NormalFocus)
        Close()
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
            Functions.ReturnMessage("Download Failed! Please try again later.")
            System.IO.File.Delete(Pokémon3D.My.Application.Info.DirectoryPath + "\Update.zip")
            Me.Close()
        End If
    End Sub

    Private Sub Extract()
        Cancel_Button.Enabled = False
        StatusText.AppendText(vbNewLine + "Extracting Files...")
        Try
            Using zip As ZipFile = ZipFile.Read(Pokémon3D.My.Application.Info.DirectoryPath + "\Update.zip")
                Dim e As ZipEntry
                For Each e In zip
                    StatusText.Focus()
                    e.Extract(Pokémon3D.My.Application.Info.DirectoryPath, ExtractExistingFileAction.OverwriteSilently)
                    StatusText.AppendText(vbNewLine + e.FileName.ToString)
                    Application.DoEvents()
                Next
            End Using
            System.IO.File.Delete(Pokémon3D.My.Application.Info.DirectoryPath + "\Update.zip")
            StatusText.AppendText(vbNewLine + "Extracting Completed!")
            Functions.ReturnMessage("Update Completed!")
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            Functions.ReturnMessage("Update Failed!")
            System.IO.File.Delete(Pokémon3D.My.Application.Info.DirectoryPath + "\Update.zip")
            Close()
        End Try
        Shell(Pokémon3D.My.Application.Info.DirectoryPath + "\Pokémon 3D Resource Manager.exe", AppWinStyle.NormalFocus)
        Close()
    End Sub

End Class