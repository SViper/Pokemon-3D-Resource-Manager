Imports System.Windows.Forms
Imports System.Net
Imports Ionic.Zip
Imports System.IO
Imports Pokémon3D

Public Class Updater

    '<!-- Main -->
    Public client As WebClient = New WebClient()
    Public ApplicationDirectory As String = Pokémon3D.My.Application.Info.DirectoryPath
    Public ApplicationVersion As String = Pokémon3D.My.Application.Info.Version.ToString
    Public ApplicationLatestVersion As String

    '<!-- Main Setting -->
    Public LauncherDirectory As String = Pokémon3D.My.Application.Info.DirectoryPath
    Public P3DDirectory As String = LauncherDirectory + "\Pokemon"
    Public ApplicationSelfCheckVersion As String = "True"
    Public ResourcesCheckVersion As String = "True"

    '<!-- Resource Details -->
    Public ResourceList As String

    '<!-- Resource Details -->
    Public ResourceName As String
    Public ResourceType As String
    Public ResourceCategory As String
    Public ResourceAuthor As String
    Public ResourceCurrentVersion As String
    Public ResourceLatestVersion As String
    Public ResourceDependency As String
    Public ResourceCompatible As String
    Public ResourceDescription As String
    Public ResourceURL As String
    Public ResourceExtention As String

    Public ResourceInstalled As String

    '<!-- Resource Additional Options -->
    Public DownloadLocation As String
    Public UninstallLocation As String
    Public DeleteFiles As String
    Public CustomOption As String

    '<!-- P3D Version -->
    Public CurrentP3DVersion As String
    Public LatestP3DVersion As String

    '<!-- Downloader -->
    Public SW As Stopwatch
    Public DownloadStatus As String
    Public CurrentBytes As Double
    Public TotalBytes As Double
    Public FileLocation As String

    Private Sub Downloader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists(ApplicationDirectory + "\Settings.dat") Then
            Functions.ReturnMessage("Please run Pokémon 3D Resource Manager.exe")
            Close()
        Else
            Try
                Dim Settingstr2 As String = Functions.GetTextFromLine(ApplicationDirectory + "\Settings.dat", 2)
                Dim Settingstr3 As String = Functions.GetTextFromLine(ApplicationDirectory + "\Settings.dat", 3)
                If Not Settingstr2 = Nothing Then
                    LauncherDirectory = Settingstr2.Remove(0, 25)
                End If
                If Not Settingstr3 = Nothing Then
                    P3DDirectory = Settingstr3.Remove(0, 26)
                End If
                ApplicationLatestVersion = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Application%20Version.txt")
                If File.Exists(LauncherDirectory + "\ID.dat") Then
                    CurrentP3DVersion = File.ReadAllText(LauncherDirectory + "\ID.dat")
                End If
                LatestP3DVersion = Functions.GetSplit(client.DownloadString("http://pokemon3d.net/launcher/versions_info.dat"), 0, "|")
                If ApplicationLatestVersion = Nothing Or LatestP3DVersion = Nothing Then
                    Functions.ReturnMessage("Could not retrive latest version from server. Please try again later.")
                    Functions.Run(ApplicationDirectory + "\Pokémon 3D Resource Manager.exe", Nothing, True)
                    Exit Sub
                End If
                If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And ApplicationLatestVersion = ApplicationVersion And LatestP3DVersion = CurrentP3DVersion Then
                    Functions.ReturnMessage("There is no update available.")
                    Functions.Run(ApplicationDirectory + "\Pokémon 3D Resource Manager.exe", Nothing, True)
                    Exit Sub
                End If
                If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And Not ApplicationLatestVersion = ApplicationVersion And LatestP3DVersion = CurrentP3DVersion Then
                    ResourceName = "Pokémon 3D Resource Manager"
                    ResourceType = "Application"
                    ResourceCategory = "Application"
                    ResourceAuthor = "jianmingyong"
                    ResourceCurrentVersion = ApplicationVersion
                    ResourceLatestVersion = ApplicationLatestVersion
                    ResourceDependency = "Pokémon 3D Resource Manager"
                    ResourceCompatible = "True"
                    ResourceDescription = "Update Pokémon 3D Resource Manager"
                    ResourceURL = "https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Pok%C3%A9mon%203D%20Resource%20Manager.zip"
                    ResourceExtention = "zip"
                    ResourceInstalled = "True"
                    DownloadLocation = ApplicationDirectory
                End If
                If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And ApplicationLatestVersion = ApplicationVersion And Not LatestP3DVersion = CurrentP3DVersion Then
                    ResourceName = "Pokémon 3D"
                    ResourceType = "Application"
                    ResourceCategory = "Application"
                    ResourceAuthor = "Nilllzz"
                    ResourceCurrentVersion = CurrentP3DVersion
                    ResourceLatestVersion = LatestP3DVersion
                    ResourceDependency = "Pokémon 3D"
                    ResourceCompatible = "True"
                    ResourceDescription = "Update Pokémon 3D"
                    ResourceURL = Functions.GetSplit(client.DownloadString("http://pokemon3d.net/launcher/versions_info.dat"), 2, "|")
                    ResourceExtention = "zip"
                    ResourceInstalled = "True"
                    DownloadLocation = LauncherDirectory
                End If
                If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And Not ApplicationLatestVersion = ApplicationVersion And Not LatestP3DVersion = CurrentP3DVersion Then
                    ResourceName = "Pokémon 3D Resource Manager"
                    ResourceType = "Application"
                    ResourceCategory = "Application"
                    ResourceAuthor = "jianmingyong"
                    ResourceCurrentVersion = ApplicationVersion
                    ResourceLatestVersion = ApplicationLatestVersion
                    ResourceDependency = "Pokémon 3D Resource Manager"
                    ResourceCompatible = "True"
                    ResourceDescription = "Update Pokémon 3D Resource Manager"
                    ResourceURL = "https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Pok%C3%A9mon%203D%20Resource%20Manager.zip"
                    ResourceExtention = "zip"
                    ResourceInstalled = "True"
                    DownloadLocation = ApplicationDirectory
                End If
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
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        Try
            If Not Directory.Exists(ApplicationDirectory + "\Cache\DownloadData") Then
                Directory.CreateDirectory(ApplicationDirectory + "\Cache\DownloadData")
            End If
            client.DownloadFile("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Ionic.Zip.dll", ApplicationDirectory + "\Ionic.Zip.dll")
            client.DownloadFileAsync(New Uri(ResourceURL), ApplicationDirectory + "\Cache\DownloadData" + "\" + ResourceName + "." + ResourceExtention)
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
            If File.Exists(ApplicationDirectory + "\Cache\DownloadData" + "\" + ResourceName + "." + ResourceExtention) Then
                File.Delete(ApplicationDirectory + "\Cache\DownloadData" + "\" + ResourceName + "." + ResourceExtention)
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
                StatusText.AppendText(vbNewLine + "Download Complete." + vbNewLine + "Moving files to " + DownloadLocation)
                File.Move(ApplicationDirectory + "\Cache\DownloadData" + "\" + ResourceName + "." + ResourceExtention, DownloadLocation + "\" + ResourceName + "." + ResourceExtention)
                FileLocation = DownloadLocation
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                Application.Exit()
                Exit Sub
            End Try
            Extract()
        ElseIf Not DownloadStatus = "Cancel" Then
            Functions.ReturnMessage("Download Failed! Please try again later.")
            Try
                If File.Exists(ApplicationDirectory + "\Cache\DownloadData" + "\" + ResourceName + "." + ResourceExtention) Then
                    System.IO.File.Delete(ApplicationDirectory + "\Cache\DownloadData" + "\" + ResourceName + "." + ResourceExtention)
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
        If (ResourceExtention = "zip") And ZipFile.IsZipFile(FileLocation + "\" + ResourceName + "." + ResourceExtention) = True Then
            Try
                Using zip As ZipFile = ZipFile.Read(FileLocation + "\" + ResourceName + "." + ResourceExtention)
                    Dim e As ZipEntry
                    For Each e In zip
                        StatusText.Focus()
                        e.Extract(FileLocation, ExtractExistingFileAction.OverwriteSilently)
                        StatusText.AppendText(vbNewLine + e.FileName.ToString)
                        Application.DoEvents()
                    Next
                End Using
                File.Delete(FileLocation + "\" + ResourceName + "." + ResourceExtention)
                StatusText.AppendText(vbNewLine + "Extracting Completed!")
                If ResourceName = "Pokémon 3D" Then
                    File.WriteAllText(LauncherDirectory + "\ID.dat", LatestP3DVersion)
                End If
                If DeleteFiles = Nothing Then
                    Functions.ReturnMessage("Download and Extracted Completed!")
                ElseIf Not DeleteFiles = Nothing Then
                    Dim CurrentIndex As Integer = 0
                    Do While Not Functions.GetSplit(DeleteFiles, CurrentIndex, ",") = Nothing
                        If File.Exists(ApplicationDirectory + "\" + Functions.GetSplit(DeleteFiles, CurrentIndex, ",")) Then
                            Try
                                File.Delete(ApplicationDirectory + "\" + Functions.GetSplit(DeleteFiles, CurrentIndex, ","))
                            Catch ex As Exception
                                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                            End Try
                        End If
                        If Directory.Exists(ApplicationDirectory + "\" + Functions.GetSplit(DeleteFiles, CurrentIndex, ",")) Then
                            Try
                                Directory.Delete(ApplicationDirectory + "\" + Functions.GetSplit(DeleteFiles, CurrentIndex, ","))
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
        Functions.Run(ApplicationDirectory + "\Pokémon 3D Resource Manager.exe", Nothing, True)
    End Sub

End Class