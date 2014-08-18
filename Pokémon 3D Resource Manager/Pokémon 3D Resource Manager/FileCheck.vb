﻿Imports System.Net
Imports System.IO

Public Class FileCheck
    Private client As WebClient = New WebClient()
    Public ApplicationDirectory As String = Pokémon3D.My.Application.Info.DirectoryPath
    Public LauncherDirectory As String = Pokémon3D.My.Application.Info.DirectoryPath
    Public P3DDirectory As String = ApplicationDirectory + "\Pokemon"
    Public ApplicationVersion As String = Pokémon3D.My.Application.Info.Version.ToString
    Public ApplicationSelfCheckVersion As String = "True"
    Public ResourcesCheckVersion As String = "True"

    Public Resourcetype As String
    Public ResourceName As String
    Public ResourceCategory As String
    Public ResourceAuthor As String
    Public ResourceCurrentVersion As String
    Public ResourceLatestVersion As String
    Public ResourceDependency As String
    Public ResourceCompatible As String
    Public ResourceInstalled As String
    Public ResourceDescription As String
    Public ResourceFolderName As String
    Public ResourceURL As String
    Public ResourceExt As String

    Private Sub FileCheck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckRequiredDLL()
        GetSetting()
        If ApplicationSelfCheckVersion = "True" Then
            CheckApplicationVersion("False")
        End If
        If ResourcesCheckVersion = "True" Then
            GetSupportedResources()
        Else
            SupportedResources()
        End If
        Resources_Remove.Enabled = False
        Resources_Update.Enabled = False
        Resources_ContentCategory.Text = ResourceCategory
        Resources_Author.Text = ResourceAuthor
        Resources_CurrentVersion.Text = ResourceCurrentVersion
        Resources_LatestVersion.Text = ResourceLatestVersion
        Resources_Dependency.Text = ResourceDependency
        Resources_Compatible.Text = ResourceCompatible
        Resources_Installed.Text = ResourceInstalled
        Resources_Description.Text = ResourceDescription
    End Sub

#Region "Init CheckList"
    Private Sub CheckRequiredDLL()
        If Not File.Exists(ApplicationDirectory + "\unrar.dll") Then
            Functions.ReturnError("Application required file: unrar.dll does not exist in " + ApplicationDirectory + "\unrar.dll")
            Close()
        End If
        If Not File.Exists(ApplicationDirectory + "\unrar64.dll") Then
            Functions.ReturnError("Application required file: unrar64.dll does not exist in " + ApplicationDirectory + "\unrar64.dll")
            Close()
        End If
    End Sub

    Private Sub GetSetting()
        If Not File.Exists(ApplicationDirectory + "\Settings.dat") Then
            AddLog("Setting File Not Found.")
            AddLog("Application attempt to generate a new one")
            Dim Settingstr1 As String = "[Setting]"
            Dim Settingstr2 As String = "P3D Launcher Directory = " + LauncherDirectory
            Dim Settingstr3 As String = "P3D Gamefiles Directory = " + P3DDirectory
            Dim Settingstr4 As String = "Application Check Update = " + ApplicationSelfCheckVersion
            Dim Settingstr5 As String = "ContentPacks Check Update = " + ResourcesCheckVersion
            Dim Settingstr6 As String = "Version = " + ApplicationVersion
            File.WriteAllText(ApplicationDirectory + "\Settings.dat", Settingstr1 + vbNewLine + Settingstr2 + vbNewLine + Settingstr3 + vbNewLine + Settingstr4 + vbNewLine + Settingstr5 + vbNewLine + Settingstr6)
            AddLog("Setting File Created at: " + ApplicationDirectory + "\Settings.dat")
            CheckSetting()
        Else
            AddLog("Setting File is found.")
            AddLog("Application attempt to check the setting required")
            Dim Settingstr2 As String = Functions.GetTextFromLine(ApplicationDirectory + "\Settings.dat", 2)
            Dim Settingstr3 As String = Functions.GetTextFromLine(ApplicationDirectory + "\Settings.dat", 3)
            Dim Settingstr4 As String = Functions.GetTextFromLine(ApplicationDirectory + "\Settings.dat", 4)
            Dim Settingstr5 As String = Functions.GetTextFromLine(ApplicationDirectory + "\Settings.dat", 5)
            If Not Settingstr2 = Nothing Then
                LauncherDirectory = Settingstr2.Remove(0, 25)
            End If
            If Not Settingstr3 = Nothing Then
                P3DDirectory = Settingstr3.Remove(0, 26)
            End If
            If Not Settingstr4 = Nothing Then
                ApplicationSelfCheckVersion = Settingstr4.Remove(0, 27)
            End If
            If Not Settingstr5 = Nothing Then
                ResourcesCheckVersion = Settingstr5.Remove(0, 25)
            End If
            AddLog("Validate Setting at Line 2.")
            If Directory.Exists(LauncherDirectory) Then
                Setting_LauncherDirectory.Text = LauncherDirectory
            Else
                Functions.ReturnError(LauncherDirectory + " Does not exist.")
                AddLog("Return Default Directory")
                LauncherDirectory = ApplicationDirectory
                Setting_LauncherDirectory.Text = LauncherDirectory
            End If
            AddLog("Validate Setting at Line 3.")
            If Directory.Exists(P3DDirectory) Then
                Setting_GamefilesDirectory.Text = P3DDirectory
            Else
                Functions.ReturnError(P3DDirectory + " Does not exist.")
                AddLog("Return Default Directory")
                P3DDirectory = LauncherDirectory + "\Pokemon"
                Setting_GamefilesDirectory.Text = P3DDirectory
            End If
            AddLog("Validate Setting at Line 4.")
            If ApplicationSelfCheckVersion = "True" Then
                Setting_ApplicationCheckForUpdate.Checked = True
            ElseIf ApplicationSelfCheckVersion = "False" Then
                Setting_ApplicationCheckForUpdate.Checked = False
            Else
                Functions.ReturnError("Invalid Boolean: " + ApplicationSelfCheckVersion)
                AddLog("Return Default: True")
                ApplicationSelfCheckVersion = "True"
                Setting_ApplicationCheckForUpdate.Checked = True
            End If
            AddLog("Validate Setting at Line 5.")
            If ResourcesCheckVersion = "True" Then
                Setting_CheckResourcesUpdate.Checked = True
            ElseIf ResourcesCheckVersion = "False" Then
                Setting_CheckResourcesUpdate.Checked = False
            Else
                Functions.ReturnError("Invalid Boolean: " + ResourcesCheckVersion)
                AddLog("Return Default: True")
                ResourcesCheckVersion = "True"
                Setting_CheckResourcesUpdate.Checked = True
            End If
            AddLog("Validate End.")
            SaveSetting()
        End If
    End Sub

    Private Sub CheckSetting()
        AddLog("Validate Setting at Line 2.")
        If Directory.Exists(LauncherDirectory) Then
            Setting_LauncherDirectory.Text = LauncherDirectory
        Else
            Functions.ReturnError(LauncherDirectory + " Does not exist.")
            AddLog("Return Default Directory")
            LauncherDirectory = ApplicationDirectory
            Setting_LauncherDirectory.Text = LauncherDirectory
        End If
        AddLog("Validate Setting at Line 3.")
        If Directory.Exists(P3DDirectory) Then
            Setting_GamefilesDirectory.Text = P3DDirectory
        Else
            Functions.ReturnError(P3DDirectory + " Does not exist.")
            AddLog("Return Default Directory")
            P3DDirectory = LauncherDirectory + "\Pokemon"
            Setting_GamefilesDirectory.Text = P3DDirectory
        End If
        AddLog("Validate Setting at Line 4.")
        If ApplicationSelfCheckVersion = "True" Then
            Setting_ApplicationCheckForUpdate.Checked = True
        ElseIf ApplicationSelfCheckVersion = "False" Then
            Setting_ApplicationCheckForUpdate.Checked = False
        Else
            Functions.ReturnError("Invalid Boolean: " + ApplicationSelfCheckVersion)
            AddLog("Return Default: True")
            ApplicationSelfCheckVersion = "True"
            Setting_ApplicationCheckForUpdate.Checked = True
        End If
        AddLog("Validate Setting at Line 5.")
        If ResourcesCheckVersion = "True" Then
            Setting_CheckResourcesUpdate.Checked = True
        ElseIf ResourcesCheckVersion = "False" Then
            Setting_CheckResourcesUpdate.Checked = False
        Else
            Functions.ReturnError("Invalid Boolean: " + ResourcesCheckVersion)
            AddLog("Return Default: True")
            ResourcesCheckVersion = "True"
            Setting_CheckResourcesUpdate.Checked = True
        End If
        AddLog("Validate End.")
    End Sub

    Private Sub SaveSetting()
        Dim Settingstr1 As String = "[Setting]"
        Dim Settingstr2 As String = "P3D Launcher Directory = " + LauncherDirectory
        Dim Settingstr3 As String = "P3D Gamefiles Directory = " + P3DDirectory
        Dim Settingstr4 As String = "Application Check Update = " + ApplicationSelfCheckVersion
        Dim Settingstr5 As String = "Resources Check Update = " + ResourcesCheckVersion
        Dim Settingstr6 As String = "Version = " + ApplicationVersion
        File.WriteAllText(ApplicationDirectory + "\Settings.dat", Settingstr1 + vbNewLine + Settingstr2 + vbNewLine + Settingstr3 + vbNewLine + Settingstr4 + vbNewLine + Settingstr5 + vbNewLine + Settingstr6)
        AddLog("Application Save Settings.")
    End Sub

    Private Sub CheckApplicationVersion(ByVal Warning As String)
        Try
            AddLog("Get Application Version:")
            Dim ServerVersion As String = client.DownloadString("https://raw.githubusercontent.com/jianmingyong/Pokemon-3D-Resource-Manager/master/Server%20Files/Application%20Version.txt")
            If Not ServerVersion = Nothing And ServerVersion = ApplicationVersion Then
                AddLog("Newest Version: " + ServerVersion)
                AddLog("Current Version: " + ApplicationVersion)
                If Warning = "False" Then
                    AddLog("You are running the latest version of this application.")
                Else
                    Functions.ReturnError("You are running the latest version of this application.")
                End If
            ElseIf Not ServerVersion = Nothing And Not ServerVersion = ApplicationVersion Then
                AddLog("Newest Version: " + ServerVersion)
                AddLog("Current Version: " + ApplicationVersion)
                Functions.ReturnError("There is an update to this application.")
                Process.Start(ApplicationDirectory + "\Pokémon 3D Resource Manager Updater.exe")
                Application.Exit()
            Else
            Functions.ReturnError("Application could not check for update. Your internet or the server is not working.")
            End If
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
    End Sub
#End Region

#Region "SettingTab"
    Private Sub Setting_SearchLauncherDirectory_Click(sender As System.Object, e As System.EventArgs) Handles Setting_SearchLauncherDirectory.Click
        FolderBrowserDialog1.ShowDialog()
        Setting_LauncherDirectory.Text = FolderBrowserDialog1.SelectedPath()
        LauncherDirectory = FolderBrowserDialog1.SelectedPath()
        CheckSetting()
        SaveSetting()
    End Sub

    Private Sub Setting_SearchGamefilesDirectory_Click(sender As System.Object, e As System.EventArgs) Handles Setting_SearchGamefilesDirectory.Click
        FolderBrowserDialog1.ShowDialog()
        Setting_GamefilesDirectory.Text = FolderBrowserDialog1.SelectedPath()
        P3DDirectory = FolderBrowserDialog1.SelectedPath()
        CheckSetting()
        SaveSetting()
    End Sub

    Private Sub Setting_ApplicationCheckForUpdate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Setting_ApplicationCheckForUpdate.Click
        If Setting_ApplicationCheckForUpdate.Checked = True Then
            ApplicationSelfCheckVersion = "True"
        ElseIf Setting_ApplicationCheckForUpdate.Checked = False Then
            ApplicationSelfCheckVersion = "False"
        End If
        CheckSetting()
        SaveSetting()
    End Sub

    Private Sub Setting_CheckContentPacksUpdate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Setting_CheckResourcesUpdate.Click
        If Setting_CheckResourcesUpdate.Checked = True Then
            ResourcesCheckVersion = "True"
        ElseIf Setting_CheckResourcesUpdate.Checked = False Then
            ResourcesCheckVersion = "False"
        End If
        CheckSetting()
        SaveSetting()
    End Sub

    Private Sub Setting_ApplicationCheckForUpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles Setting_ApplicationCheckForUpdateButton.Click
        CheckApplicationVersion("True")
    End Sub

    Private Sub Setting_ResourceDataBase_Click(sender As System.Object, e As System.EventArgs) Handles Setting_ResourceDataBase.Click
        Try
            Process.Start("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/blob/master/Server%20Files/Resources.txt")
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Logger"
    Public Sub AddLog(ByVal Message As String)
        If (Logger_Log.TextLength = 0) Then
            Logger_Log.Text = "> " + Message
        Else
            Logger_Log.AppendText(vbNewLine + "> " + Message)
        End If
    End Sub
#End Region

#Region "Open P3D Game"
    Private Sub Resources_OpenP3D_Click(sender As System.Object, e As System.EventArgs) Handles Resources_OpenP3D.Click
        If (System.IO.File.Exists(LauncherDirectory + "\Pokémon3D.exe")) Then
            Shell(LauncherDirectory + "\Pokémon3D.exe", AppWinStyle.NormalFocus)
            Application.Exit()
        Else
            Functions.ReturnError(LauncherDirectory + "\Pokémon3D.exe does not exist.")
        End If
    End Sub

    Private Sub GameModes_OpenP3D_Click(sender As System.Object, e As System.EventArgs)
        If (System.IO.File.Exists(LauncherDirectory + "\Pokémon3D.exe")) Then
            Shell(LauncherDirectory + "\Pokémon3D.exe", AppWinStyle.NormalFocus)
            Application.Exit()
        Else
            Functions.ReturnError(LauncherDirectory + "\Pokémon3D.exe does not exist.")
        End If
    End Sub
#End Region

#Region "Resources Init"
    Private Sub GetSupportedResources()
        Try
            AddLog("Download String From Server")
            Dim DownloadString As String = client.DownloadString("https://raw.githubusercontent.com/jianmingyong/Pokemon-3D-Resource-Manager/master/Server%20Files/Resources.txt")
            AddLog("Checking for Cache Folder")
            If Not Directory.Exists(ApplicationDirectory + "\Cache") Then
                Directory.CreateDirectory(ApplicationDirectory + "\Cache")
                AddLog("Cache Folder created at: " + ApplicationDirectory + "\Cache")
            End If
            If File.Exists(ApplicationDirectory + "\Cache\ContentPacks.txt") Then
                File.Delete(ApplicationDirectory + "\Cache\ContentPacks.txt")
            End If
            File.WriteAllText(ApplicationDirectory + "\Cache\ContentPacks.txt", DownloadString, System.Text.Encoding.UTF8)
            AddLog("Save all text into the Cache for offline use.")
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
        SupportedResources()
    End Sub

    Private Sub SupportedResources()
        AddLog("Get Supported ContentPacks from Cache.")
        Dim CurrentIndex As Integer = 2
        Try
            If Not AllResources_Supported.Items.Count = 0 Then
                AllResources_Supported.Items.Clear()
            End If
            Do While Not CurrentIndex > File.ReadAllLines(ApplicationDirectory + "\Cache\ContentPacks.txt").Length
                AllResources_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 0, "|"))
                CurrentIndex = CurrentIndex + 1
            Loop
        Catch ex As Exception
            Functions.ReturnError(ex.Message)
        End Try
    End Sub

    Private Sub GetResourcesDetail()
        Dim CurrentIndex As Integer = AllResources_Supported.SelectedIndex + 2
        AddLog("Get Resource Detail from Cache")
        ResourceName = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 0, "|")
        ResourceCategory = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 1, "|")
        ResourceAuthor = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 2, "|")
        ResourceLatestVersion = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 3, "|")
        ResourceDependency = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 4, "|")
        ResourceCompatible = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 5, "|")
        ResourceDescription = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 6, "|")
        ResourceFolderName = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 7, "|")
        ResourceExt = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 8, "|")
        ResourceURL = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ContentPacks.txt", CurrentIndex), 9, "|")
        If Not ResourceCategory = "GameModes" Then
            Resourcetype = "ContentPacks"
        ElseIf ResourceCategory = "GameModes" Then
            Resourcetype = "GameModes"
        End If
        If Resourcetype = "ContentPacks" And File.Exists(P3DDirectory + "\" + Resourcetype + "\" + ResourceFolderName + "\info.dat") Then
            ResourceCurrentVersion = Functions.GetTextFromLine(P3DDirectory + "\" + Resourcetype + "\" + ResourceFolderName + "\info.dat", 1)
            ResourceInstalled = "True"
            Resources_Remove.Enabled = True
        ElseIf Resourcetype = "GameModes" And File.Exists(P3DDirectory + "\" + Resourcetype + "\" + ResourceFolderName + "\GameMode.dat") Then
            ResourceCurrentVersion = Functions.GetSplit(Functions.GetTextFromLine(P3DDirectory + "\" + Resourcetype + "\" + ResourceFolderName + "\GameMode.dat", 3), 1, "|")
            ResourceInstalled = "True"
            Resources_Remove.Enabled = True
        Else
            ResourceCurrentVersion = "Not Installed"
            ResourceInstalled = "False"
            Resources_Remove.Enabled = False
        End If
        If ResourceURL = Nothing Then
            Resources_Update.Enabled = False
        Else
            Resources_Update.Enabled = True
        End If
        Resources_ContentCategory.Text = ResourceCategory
        Resources_Author.Text = ResourceAuthor
        Resources_CurrentVersion.Text = ResourceCurrentVersion
        Resources_LatestVersion.Text = ResourceLatestVersion
        Resources_Dependency.Text = ResourceDependency
        Resources_Compatible.Text = ResourceCompatible
        Resources_Installed.Text = ResourceInstalled
        Resources_Description.Text = ResourceDescription
    End Sub

    Private Sub Resources_CheckForUpdate_Click(sender As System.Object, e As System.EventArgs) Handles Resources_CheckForUpdate.Click
        GetSupportedResources()
    End Sub

    Private Sub AllResources_Supported_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AllResources_Supported.SelectedIndexChanged
        GetResourcesDetail()
    End Sub

    Private Sub Resources_Remove_Click(sender As System.Object, e As System.EventArgs) Handles Resources_Remove.Click
        PlaySystemSound()
        Uninstall.ShowDialog()
        GetResourcesDetail()
    End Sub

    Private Sub Resources_Update_Click(sender As System.Object, e As System.EventArgs) Handles Resources_Update.Click
        Downloader.ShowDialog()
        GetResourcesDetail()
    End Sub
#End Region

#Region "Other"
    Public Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound( _
            System.Media.SystemSounds.Asterisk)
    End Sub
#End Region

End Class