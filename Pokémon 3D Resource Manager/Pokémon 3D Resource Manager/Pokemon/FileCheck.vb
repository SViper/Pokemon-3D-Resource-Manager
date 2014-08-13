Imports System.Net
Imports System.IO

Public Class FileCheck
    Private client As WebClient = New WebClient()

    Private Sub FileCheck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AppSettings.CheckSetting()
    End Sub

#Region "Init CheckList"
    ' Imports'
    ' System.IO

    ' Variable '
    Private ApplicationDirectory As String = Pokémon3D.My.Application.Info.DirectoryPath
    Private P3DDirectory As String = ApplicationDirectory + "\Pokemon"
    Private ApplicationVersion As String = Pokémon3D.My.Application.Info.Version.ToString
    Private ApplicationSelfCheckVersion As String = "True"

    Private Sub CheckSetting()
        If (Not File.Exists(ApplicationDirectory + "\Settings.dat")) Then
            ShowLog("Setting File Not Found.")
            ShowLog("Application attempt to generate a new one")
            Dim Settingstr1 As String = "[Setting]"
            Dim Settingstr2 As String = "P3D Launcher Directory = " + ApplicationDirectory
            Dim Settingstr3 As String = "P3D Content Directory = " + P3DDirectory
            Dim Settingstr4 As String = "Application Check Update = " + ApplicationSelfCheckVersion
            File.WriteAllText(ApplicationDirectory + "\Settings.dat", Settingstr1 + vbNewLine + Settingstr2 + vbNewLine + Settingstr3 + vbNewLine + Settingstr4)
            ShowLog("Setting File Created at: " + ApplicationDirectory + "\Settings.dat")
        Else
            ShowLog("Setting File is found.")
            ShowLog("Application attempt to check the setting required")
            Dim SettingMain As String = File.ReadAllText(ApplicationDirectory + "\Settings.dat")
        End If
    End Sub
#End Region

    Private Sub InstalledContents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles InstalledContentPacksName.SelectedIndexChanged
        Dim str1 = InstalledContentPacksName.GetItemText(InstalledContentPacksName.SelectedItem)
        ContentPackNewVersionInfo.ResetText()
        ContentPackCheckForUpdateButton.Enabled = True
        ContentPackUpdateButton.Enabled = True
        ContentPackRemoveButton.Enabled = True
        ShowInfo(str1, "Content Pack")
    End Sub

    Private Sub InstalledGameModesName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles InstalledGameModesName.SelectedIndexChanged
        Dim str1 = InstalledGameModesName.GetItemText(InstalledGameModesName.SelectedItem)
        GameModeNewVersionInfo.ResetText()
        GameModeCheckForUpdateButton.Enabled = True
        GameModeUpdateButton.Enabled = True
        GameModeRemoveButton.Enabled = True
        ShowInfo(str1, "GameMode")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles SettingSearchButton.Click
        FolderBrowserDialog1.ShowDialog()
        GameDirectory.Text = FolderBrowserDialog1.SelectedPath()
        ShowLog("Game Directory Points to: " + GameDirectory.Text)
        AppSettings.ChangeSetting(GameDirectory.Text)
    End Sub

    Public Sub ShowLog(ByVal strlog As String)
        If (Log.TextLength = 0) Then
            Log.Text = "> " + strlog
        Else
            Log.AppendText(vbNewLine + "> " + strlog)
        End If
    End Sub

    Public Sub ShowInfo(ByVal Selectitem As String, ByVal Resource As String)
        If (Resource.ToString = "Content Pack" And System.IO.File.Exists(GameDirectory.Text & "\Pokemon\ContentPacks\" + Selectitem + "\info.dat")) Then
            Dim info As String = System.IO.File.ReadAllText(GameDirectory.Text & "\Pokemon\ContentPacks\" + Selectitem + "\info.dat")
            ContentPackInfo.Text = info
            ContentPackVersionInfo.Text = Functions.GetSplit(ContentPackInfo.Text, 0, "jianmingyong")
            ContentPackVersionInfo.Text = ContentPackVersionInfo.Text.Remove(ContentPackVersionInfo.Text.Length - 1)
        ElseIf (Resource.ToString = "GameMode" And System.IO.File.Exists(GameDirectory.Text & "\Pokemon\GameModes\" + Selectitem + "\GameMode.dat")) Then
            Dim info As String = System.IO.File.ReadAllText(GameDirectory.Text & "\Pokemon\GameModes\" + Selectitem + "\GameMode.dat")
            GameModeInfo.Text = info
            Dim getstringofversion As String = GameModeInfo.Text.Substring(GameModeInfo.Text.IndexOf("Version|"))
            GameModeVersionInfo.Text = getstringofversion.Remove(getstringofversion.IndexOf("Author"))
            GameModeVersionInfo.Text = GameModeVersionInfo.Text.Remove(0, 8)
            GameModeVersionInfo.Text = GameModeVersionInfo.Text.Remove(GameModeVersionInfo.Text.Length - 1)
        ElseIf (Resource.ToString = "Content Pack" And Not System.IO.File.Exists(GameDirectory.Text & "\Pokemon\ContentPacks\" + Selectitem + "\info.dat")) Then
            ContentPackInfo.Text = "The ContentPackd info file does not exist"
        ElseIf (Resource.ToString = "GameMode" And Not System.IO.File.Exists(GameDirectory.Text & "\Pokemon\GameModes\" + Selectitem + "\GameMode.dat")) Then
            ContentPackInfo.Text = "The GameModes info file does not exist"
        End If
    End Sub

    Public Sub Getdirectory(ByVal Directory As String)
        GameDirectory.SelectedText = Directory
        ResourceCheck(Directory)
    End Sub

    Private Sub Reset()
        InstalledContentPacksName.Items.Clear()
        InstalledContentPacksName.ResetText()
        ContentPackInfo.Clear()
        ContentPackVersionInfo.ResetText()
        ContentPackNewVersionInfo.ResetText()
        InstalledGameModesName.Items.Clear()
        InstalledGameModesName.ResetText()
        GameModeInfo.Clear()
        GameModeVersionInfo.ResetText()
        GameModeNewVersionInfo.ResetText()
        ContentPackCheckForUpdateButton.Enabled = False
        ContentPackUpdateButton.Enabled = False
        ContentPackRemoveButton.Enabled = False
        GameModeCheckForUpdateButton.Enabled = False
        GameModeUpdateButton.Enabled = False
        GameModeRemoveButton.Enabled = False
    End Sub

    Public Sub ResourceCheck(ByVal Directory As String)
        Reset()
        If (Not System.IO.File.Exists(Directory & "\Pokemon\Pokemon.exe")) Then
            Functions.LogError("Error: Pokémon 3D Application file does not exist." + vbNewLine + "Please locate the Pokémon3D launcher folder in the setting.")
        ElseIf (Not System.IO.File.Exists(Pokémon3D.My.Application.Info.DirectoryPath & "\unrar.dll")) Then
            Functions.LogError("Error: unrar.dll does not exist in the application Folder." + vbNewLine + "Extraction for RAR Files will fail.")
        ElseIf (Not System.IO.File.Exists(Pokémon3D.My.Application.Info.DirectoryPath & "\unrar64.dll")) Then
            Functions.LogError("Error: unrar.dll does not exist in the application Folder." + vbNewLine + "Extraction for RAR Files will fail.")
        End If
        Try
            Dim DownloadedContent As String = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Supported%20Files.txt")
            ShowLog("Get Supported Content From Server" + vbNewLine + DownloadedContent)
            Dim CurrentIndex As Integer = 1
            Dim SupportedContentPack As String = ""
            Dim SupportedGameMode As String = ""
            Do While Not SupportedContentPack.Contains("EndContentPacks")
                SupportedContentPack = Functions.GetSplit(DownloadedContent, CurrentIndex, "|")
                If (System.IO.Directory.Exists(Directory & "\Pokemon\ContentPacks\") And Not SupportedContentPack.Contains("EndContentPacks") And Not InstalledContentPacksName.Items.Contains(SupportedContentPack)) Then
                        InstalledContentPacksName.Items.Add(SupportedContentPack)
                        ShowLog("Found " + SupportedContentPack)
                    CurrentIndex = CurrentIndex + 1
                Else
                    Exit Do
                End If
            Loop
            CurrentIndex = 1
            Dim splitSupportedGameMode As String = ""
            Do While Not splitSupportedGameMode.Contains("EndGameMode")
                SupportedGameMode = DownloadedContent.Substring(DownloadedContent.IndexOf("GameMode"))
                splitSupportedGameMode = Functions.GetSplit(SupportedGameMode, CurrentIndex, "|")
                If (System.IO.Directory.Exists(Directory & "\Pokemon\GameModes\") And Not splitSupportedGameMode.Contains("EndGameMode") And Not InstalledGameModesName.Items.Contains(splitSupportedGameMode)) Then
                        InstalledGameModesName.Items.Add(splitSupportedGameMode)
                        ShowLog("Found " + splitSupportedGameMode)
                    CurrentIndex = CurrentIndex + 1
                Else
                    Exit Do
                End If
            Loop
        Catch ex As Exception
            Functions.LogError(ex.Message)
        End Try
    End Sub

    Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound( _
            System.Media.SystemSounds.Asterisk)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles ContentPackCheckForUpdateButton.Click
        Try
            Dim DownloadedContent As String = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Content%20Pack%20Resource%20Files.txt")
            ShowLog("Get Version From Server" + vbNewLine + DownloadedContent)
            If (DownloadedContent.Contains(InstalledContentPacksName.SelectedItem)) Then
                Dim newversion As String = Functions.GetSplit(DownloadedContent.Substring(DownloadedContent.IndexOf(InstalledContentPacksName.SelectedItem)), 1, "|")
                Dim oldversion As String = ContentPackVersionInfo.Text
                ContentPackNewVersionInfo.Text = newversion
                ShowLog("Comparing Version for " + InstalledContentPacksName.Text)
                ShowLog("Local File: " + oldversion)
                ShowLog("Server File: " + newversion)
                If (oldversion = newversion) Then
                    PlaySystemSound()
                    MsgBox("No new update available.")
                Else
                    PlaySystemSound()
                    MsgBox("There is update available for this Content Pack.")
                End If
            Else
                PlaySystemSound()
                MsgBox("Could not retrive from server.")
                ContentPackNewVersionInfo.Text = "Could not retrive from server"
                ShowLog("Could not retrive from server")
            End If
        Catch ex As Exception
            PlaySystemSound()
            MsgBox(ex.Message.ToString)
            ShowLog(ex.Message.ToString)
        End Try
    End Sub

    Private Sub GameModeCheckForUpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles GameModeCheckForUpdateButton.Click
        Try
            Dim DownloadedContent As String = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/GameMode%20Resource%20Files.txt")
            ShowLog("Get Version From Server" + vbNewLine + DownloadedContent)
            If (DownloadedContent.Contains(InstalledGameModesName.SelectedItem)) Then
                Dim newversion As String = Functions.GetSplit(DownloadedContent.Substring(DownloadedContent.IndexOf(InstalledGameModesName.SelectedItem)), 1, "|")
                Dim oldversion As String = GameModeVersionInfo.Text
                GameModeNewVersionInfo.Text = newversion
                ShowLog("Comparing Version for " + InstalledGameModesName.SelectedItem)
                ShowLog("Local File: " + oldversion)
                ShowLog("Server File: " + newversion)
                If (oldversion = newversion) Then
                    PlaySystemSound()
                    MsgBox("No new update available.")
                Else
                    PlaySystemSound()
                    MsgBox("There is update available for this GameMode.")
                End If
            Else
                PlaySystemSound()
                MsgBox("Could not retrive from server.")
                ContentPackNewVersionInfo.Text = "Could not retrive from server"
                ShowLog("Could not retrive from server")
            End If
        Catch ex As Exception
            Functions.LogError(ex.Message)
        End Try
    End Sub

#Region "Open P3D Game"
    Private Sub OpenP3DGame_Click(sender As System.Object, e As System.EventArgs) Handles OpenP3DGame.Click
        If (System.IO.File.Exists(GameDirectory.Text.ToString & "\Pokémon3D.exe")) Then
            Shell(GameDirectory.Text.ToString & "\Pokémon3D.exe", AppWinStyle.NormalFocus)
            Close()
        Else
            PlaySystemSound()
            MsgBox("You do not have Pokémon3D.exe installed or you have renamed the launcher.")
            ShowLog("You do not have Pokémon3D.exe installed or you have renamed the launcher.")
        End If
    End Sub

    Private Sub OpenP3DGame1_Click(sender As System.Object, e As System.EventArgs) Handles OpenP3DGame1.Click
        If (System.IO.File.Exists(GameDirectory.Text.ToString & "\Pokémon3D.exe")) Then
            Shell(GameDirectory.Text.ToString & "\Pokémon3D.exe", AppWinStyle.NormalFocus)
            Close()
        Else
            PlaySystemSound()
            MsgBox("You do not have Pokémon3D.exe installed or you have renamed the launcher.")
            ShowLog("You do not have Pokémon3D.exe installed or you have renamed the launcher.")
        End If
    End Sub
#End Region

#Region "Remove Button"
    Private Sub ContentPackRemoveButton_Click(sender As System.Object, e As System.EventArgs) Handles ContentPackRemoveButton.Click
        PlaySystemSound()
        Uninstall.UninstallContentname(InstalledContentPacksName.SelectedItem)
        If (Uninstall.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Try
                My.Computer.FileSystem.DeleteDirectory(GameDirectory.Text & "\Pokemon\ContentPacks\" & InstalledContentPacksName.SelectedItem, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
                ResourceCheck(GameDirectory.Text)
            Catch ex As Exception
                Functions.LogError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GameModeRemoveButton_Click(sender As System.Object, e As System.EventArgs) Handles GameModeRemoveButton.Click
        PlaySystemSound()
        Uninstall.UninstallContentname(InstalledGameModesName.SelectedItem)
        If (Uninstall.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Try
                My.Computer.FileSystem.DeleteDirectory(GameDirectory.Text & "\Pokemon\GameModes\" & InstalledGameModesName.SelectedItem, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
                ResourceCheck(GameDirectory.Text)
            Catch ex As Exception
                Functions.LogError(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region "Refresh Button"
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles RefreshButton.Click
        ResourceCheck(GameDirectory.Text)
    End Sub

    Private Sub GameModeRefreshButton_Click(sender As System.Object, e As System.EventArgs) Handles GameModeRefreshButton.Click
        ResourceCheck(GameDirectory.Text)
    End Sub
#End Region

    Private Sub ContentPackUpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles ContentPackUpdateButton.Click
        Downloader.DownloadContentname("ContentPacks", InstalledContentPacksName.SelectedItem, ContentPackVersionInfo.Text, ContentPackNewVersionInfo.Text, GameDirectory.Text)
        Downloader.Show()
    End Sub

    Private Sub GameModeUpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles GameModeUpdateButton.Click
        Downloader.DownloadContentname("GameModes", InstalledGameModesName.SelectedItem, GameModeVersionInfo.Text, GameModeNewVersionInfo.Text, GameDirectory.Text)
        Downloader.Show()
    End Sub
End Class
