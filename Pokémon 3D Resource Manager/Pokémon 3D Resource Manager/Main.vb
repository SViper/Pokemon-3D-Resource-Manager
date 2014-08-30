Imports System.Net
Imports System.IO

Public Class Main
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


    Private Sub FileCheck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckRequiredDLL()
        GetSetting()
        If ApplicationSelfCheckVersion = "True" Then
            CheckApplicationVersion()
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
        If AllResources_Supported.Items.Count.ToString > 0 Then
            AllResources_Supported.SetSelected(0, True)
        End If
    End Sub

#Region "Init CheckList"
    Private Sub CheckRequiredDLL()
        If Not File.Exists(ApplicationDirectory + "\unrar.dll") Then
            Functions.ReturnMessage("Application required file: unrar.dll does not exist in " + ApplicationDirectory + "\unrar.dll")
            Close()
            Exit Sub
        End If
        If Not File.Exists(ApplicationDirectory + "\unrar64.dll") Then
            Functions.ReturnMessage("Application required file: unrar64.dll does not exist in " + ApplicationDirectory + "\unrar64.dll")
            Close()
            Exit Sub
        End If
        If Not File.Exists(ApplicationDirectory + "\UnRARNET.dll") Then
            Functions.ReturnMessage("Application required file: UnRARNET.dll does not exist in " + ApplicationDirectory + "\UnRARNET.dll")
            Close()
            Exit Sub
        End If
        If Not File.Exists(ApplicationDirectory + "\Ionic.Zip.dll") Then
            Functions.ReturnMessage("Application required file: Ionic.Zip.dll does not exist in " + ApplicationDirectory + "\Ionic.Zip.dll")
            Close()
            Exit Sub
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
            Try
                File.WriteAllText(ApplicationDirectory + "\Settings.dat", Settingstr1 + vbNewLine + Settingstr2 + vbNewLine + Settingstr3 + vbNewLine + Settingstr4 + vbNewLine + Settingstr5 + vbNewLine + Settingstr6)
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            End Try
            AddLog("Setting File Created at: " + ApplicationDirectory + "\Settings.dat")
            Setting_ApplicationCheckForUpdate.Checked = True
            Setting_CheckResourcesUpdate.Checked = True
            MsgBox("Please configure the application settings on the setting tab after this.", MsgBoxStyle.Information, "Pre-Setup")
            TabControl1.SelectTab(1)
            Exit Sub
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
            CheckSetting()
            SaveSetting()
        End If
    End Sub

    Private Sub CheckSetting()
        AddLog("Validate Setting at Line 2.")
        If Directory.Exists(LauncherDirectory) Then
            Setting_LauncherDirectory.Text = LauncherDirectory
        Else
            Functions.ReturnMessage(LauncherDirectory + " Does not exist.")
            AddLog("Return Default Directory")
            LauncherDirectory = ApplicationDirectory
            Setting_LauncherDirectory.Text = LauncherDirectory
        End If
        AddLog("Validate Setting at Line 3.")
        If Directory.Exists(P3DDirectory) Then
            Setting_GamefilesDirectory.Text = P3DDirectory
        Else
            Functions.ReturnMessage(P3DDirectory + " Does not exist.")
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
            Functions.ReturnMessage("Invalid Boolean: " + ApplicationSelfCheckVersion)
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
            Functions.ReturnMessage("Invalid Boolean: " + ResourcesCheckVersion)
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
        Try
            File.WriteAllText(ApplicationDirectory + "\Settings.dat", Settingstr1 + vbNewLine + Settingstr2 + vbNewLine + Settingstr3 + vbNewLine + Settingstr4 + vbNewLine + Settingstr5 + vbNewLine + Settingstr6)
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
        AddLog("Application Save Settings.")
    End Sub

    Private Sub CheckApplicationVersion(Optional ByVal Warning As Boolean = False)
        Try
            AddLog("Get Application Version:")
            ApplicationLatestVersion = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Application%20Version.txt")
            AddLog("Get P3D Latest Version:")
            If File.Exists(LauncherDirectory + "\ID.dat") Then
                CurrentP3DVersion = File.ReadAllText(LauncherDirectory + "\ID.dat")
            End If
            LatestP3DVersion = Functions.GetSplit(client.DownloadString("http://pokemon3d.net/launcher/versions_info.dat"), 0, "|")
            If ApplicationLatestVersion = Nothing Or LatestP3DVersion = Nothing Then
                Functions.ReturnMessage("Could not retrive latest version from server. Please try again later.")
                Exit Sub
            End If
            If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And ApplicationLatestVersion = ApplicationVersion And LatestP3DVersion = CurrentP3DVersion Then
                AddLog("Application Newest Version: " + ApplicationLatestVersion)
                AddLog("Application Current Version: " + ApplicationVersion)
                AddLog("Pokémon 3D Newest Version: " + LatestP3DVersion)
                AddLog("Pokémon 3D Current Version: " + CurrentP3DVersion)
                If Warning = False Then
                    AddLog("There is no update available.")
                Else
                    Functions.ReturnMessage("There is no update available.")
                End If
                Exit Sub
            End If
            If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And Not ApplicationLatestVersion = ApplicationVersion And LatestP3DVersion = CurrentP3DVersion Then
                AddLog("Application Newest Version: " + ApplicationLatestVersion)
                AddLog("Application Current Version: " + ApplicationVersion)
                AddLog("Pokémon 3D Newest Version: " + LatestP3DVersion)
                AddLog("Pokémon 3D Current Version: " + CurrentP3DVersion)
                Functions.ReturnMessage("There is an update available for this application.")
                client.DownloadFile("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Pok%C3%A9mon%203D%20Resource%20Manager%20Updater.exe", ApplicationDirectory + "\Pokémon 3D Resource Manager Updater.exe")
                Functions.Run(ApplicationDirectory + "\Pokémon 3D Resource Manager Updater.exe", Nothing, True)
                Exit Sub
            End If
            If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And ApplicationLatestVersion = ApplicationVersion And Not LatestP3DVersion = CurrentP3DVersion Then
                AddLog("Application Newest Version: " + ApplicationLatestVersion)
                AddLog("Application Current Version: " + ApplicationVersion)
                AddLog("Pokémon 3D Newest Version: " + LatestP3DVersion)
                AddLog("Pokémon 3D Current Version: " + CurrentP3DVersion)
                Functions.ReturnMessage("There is an update available for Pokémon 3D.")
                client.DownloadFile("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Pok%C3%A9mon%203D%20Resource%20Manager%20Updater.exe", ApplicationDirectory + "\Pokémon 3D Resource Manager Updater.exe")
                Functions.Run(ApplicationDirectory + "\Pokémon 3D Resource Manager Updater.exe", Nothing, True)
                Exit Sub
            End If
            If Not ApplicationLatestVersion = Nothing And Not LatestP3DVersion = Nothing And Not ApplicationLatestVersion = ApplicationVersion And Not LatestP3DVersion = CurrentP3DVersion Then
                AddLog("Application Newest Version: " + ApplicationLatestVersion)
                AddLog("Application Current Version: " + ApplicationVersion)
                AddLog("Pokémon 3D Newest Version: " + LatestP3DVersion)
                AddLog("Pokémon 3D Current Version: " + CurrentP3DVersion)
                Functions.ReturnMessage("There is an update available for this application as well as Pokémon 3D.")
                client.DownloadFile("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Updater/Pok%C3%A9mon%203D%20Resource%20Manager%20Updater.exe", ApplicationDirectory + "\Pokémon 3D Resource Manager Updater.exe")
                Functions.Run(ApplicationDirectory + "\Pokémon 3D Resource Manager Updater.exe", Nothing, True)
                Exit Sub
            End If
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
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

    Private Sub Setting_CheckResourcesUpdate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Setting_CheckResourcesUpdate.Click
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
        Functions.Run("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/blob/master/Server%20Files/Resources.txt")
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
        If System.IO.File.Exists(LauncherDirectory + "\Pokémon3D.exe") Then
            Functions.Run(LauncherDirectory + "\Pokémon3D.exe", Nothing, True)
        Else
            Functions.ReturnMessage(LauncherDirectory + "\Pokémon3D.exe does not exist.")
        End If
    End Sub
#End Region

#Region "Resources Init"
    Private Sub GetSupportedResources()
        Try
            AddLog("Download Resource String From Server")
            ResourceList = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/ResourcesList.dat")
            AddLog("Checking for Cache Folder")
            If Not Directory.Exists(ApplicationDirectory + "\Cache") Then
                Directory.CreateDirectory(ApplicationDirectory + "\Cache")
                AddLog("Cache Folder created at: " + ApplicationDirectory + "\Cache")
            End If
            File.WriteAllText(ApplicationDirectory + "\Cache\ResourcesList.dat", ResourceList, System.Text.Encoding.UTF8)
            AddLog("Save all text into the Cache for offline use.")
            Dim CurrentResource As Integer = 1
            Dim TotalResource As Integer = File.ReadAllLines(ApplicationDirectory + "\Cache\ResourcesList.dat").Length - 1
            AddLog("Download Resource File From Server")
            If Directory.Exists(ApplicationDirectory + "\Cache\Resources") Then
                Directory.Delete(ApplicationDirectory + "\Cache\Resources", True)
            End If
            Directory.CreateDirectory(ApplicationDirectory + "\Cache\Resources")
            AddLog("Cache Folder created at: " + ApplicationDirectory + "\Cache\Resources")
            Do While Not CurrentResource > TotalResource
                Dim DownloadURL As String = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentResource + 1), 1, "|")
                ResourceName = Functions.GetFileNameByURL(DownloadURL)
                AddLog("Downloading " + ResourceName)
                Dim DownloadString As String = client.DownloadString(DownloadURL)
                File.WriteAllText(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", DownloadString, System.Text.Encoding.UTF8)
                CurrentResource = CurrentResource + 1
                Application.DoEvents()
            Loop
            SupportedResources()
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
    End Sub

    Private Sub SupportedResources()
        AddLog("Get Supported Resources from Cache.")
        Dim CurrentIndex As Integer = 1
        If Not AllResources_Supported.Items.Count = 0 Then
            AllResources_Supported.Items.Clear()
            AllContentPacks_Supported.Items.Clear()
            AllGameModes_Supported.Items.Clear()
            InstalledContentPacks_Supported.Items.Clear()
            InstalledGameModes_Supported.Items.Clear()
            ResourceUpdate_Supported.Items.Clear()
        End If
        Try
            Do While Not CurrentIndex > File.ReadAllLines(ApplicationDirectory + "\Cache\ResourcesList.dat").Length
                If Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex).ToString.StartsWith("<!--") Then
                    CurrentIndex = CurrentIndex + 1
                Else
                    ResourceName = Functions.GetFileNameByURL(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 1, "|"))
                    ResourceType = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 3), 1, "|")
                    If ResourceType = "ContentPacks" Then
                        ResourceCurrentVersion = Functions.GetTextFromLine(P3DDirectory + "\ContentPacks\" + Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 2), 1, "|") + "\info.dat", 1)
                    ElseIf ResourceType = "GameModes" Then
                        ResourceCurrentVersion = Functions.GetSplit(Functions.GetTextFromLine(P3DDirectory + "\GameModes\" + Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 2), 1, "|") + "\GameMode.dat", 3), 1, "|")
                    End If
                    ResourceLatestVersion = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 6), 1, "|")
                    AllResources_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|"))
                    If ResourceType = "ContentPacks" Then
                        AllContentPacks_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|"))
                    End If
                    If ResourceType = "GameModes" Then
                        AllGameModes_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|"))
                    End If
                    If ResourceType = "ContentPacks" And File.Exists(P3DDirectory + "\ContentPacks\" + Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 2), 1, "|") + "\info.dat") Then
                        InstalledContentPacks_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|"))
                    End If
                    If ResourceType = "GameModes" And File.Exists(P3DDirectory + "\GameModes\" + Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 2), 1, "|") + "\GameMode.dat") Then
                        InstalledGameModes_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|"))
                    End If
                    If ResourceType = "ContentPacks" And File.Exists(P3DDirectory + "\ContentPacks\" + Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 2), 1, "|") + "\info.dat") And Not ResourceCurrentVersion = ResourceLatestVersion Then
                        ResourceUpdate_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|"))
                    End If
                    If ResourceType = "GameModes" And File.Exists(P3DDirectory + "\GameModes\" + Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", 2), 1, "|") + "\GameMode.dat") And Not ResourceCurrentVersion = ResourceLatestVersion Then
                        ResourceUpdate_Supported.Items.Add(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|"))
                    End If
                    CurrentIndex = CurrentIndex + 1
                End If
            Loop
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
    End Sub

    Private Sub GetResourcesDetail(ByVal Name As String)
        Try
            AddLog("Get Resource Detail from Cache")
            Dim CurrentIndex As Integer = 2
            Do While Not Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 0, "|") = Name
                CurrentIndex = CurrentIndex + 1
            Loop
            Name = Functions.GetFileNameByURL(Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentIndex), 1, "|"))
            ResourceName = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 2), 1, "|")
            ResourceType = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 3), 1, "|")
            ResourceCategory = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 4), 1, "|")
            ResourceAuthor = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 5), 1, "|")
            ResourceLatestVersion = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 6), 1, "|")
            ResourceDependency = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 7), 1, "|")
            ResourceCompatible = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 8), 1, "|")
            ResourceDescription = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 9), 1, "|")
            ResourceURL = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 10), 1, "|")
            ResourceExtention = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 11), 1, "|")
            DownloadLocation = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 13), 1, "|")
            UninstallLocation = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 14), 1, "|")
            DeleteFiles = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 15), 1, "|")
            CustomOption = Functions.GetSplit(Functions.GetTextFromLine(ApplicationDirectory + "\Cache\Resources\" + Name + ".dat", 16), 1, "|")
            If ResourceType = "ContentPacks" And File.Exists(P3DDirectory + "\ContentPacks\" + ResourceName + "\info.dat") Then
                ResourceCurrentVersion = Functions.GetTextFromLine(P3DDirectory + "\ContentPacks\" + ResourceName + "\info.dat", 1)
                ResourceInstalled = "True"
                Resources_Remove.Enabled = True
            ElseIf ResourceType = "GameModes" And File.Exists(P3DDirectory + "\GameModes\" + ResourceName + "\GameMode.dat") Then
                ResourceCurrentVersion = Functions.GetSplit(Functions.GetTextFromLine(P3DDirectory + "\GameModes\" + ResourceName + "\GameMode.dat", 3), 1, "|")
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
            If File.Exists(LauncherDirectory + "\ID.dat") Then
                ResourceCompatible = "True"
            Else
                ResourceCompatible = "Limited or False"
            End If
            Resources_ContentCategory.Text = ResourceCategory
            Resources_Author.Text = ResourceAuthor
            Resources_CurrentVersion.Text = ResourceCurrentVersion
            Resources_LatestVersion.Text = ResourceLatestVersion
            Resources_Dependency.Text = ResourceDependency
            Resources_Compatible.Text = ResourceCompatible
            Resources_Installed.Text = ResourceInstalled
            Resources_Description.Text = ResourceDescription
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
    End Sub

    Private Sub Resources_CheckForUpdate_Click(sender As System.Object, e As System.EventArgs) Handles Resources_CheckForUpdate.Click
        GetSupportedResources()
    End Sub

    Private Sub AllResources_Supported_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AllResources_Supported.SelectedIndexChanged
        GetResourcesDetail(AllResources_Supported.SelectedItem.ToString)
    End Sub

    Private Sub AllContentPacks_Supported_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AllContentPacks_Supported.SelectedIndexChanged
        GetResourcesDetail(AllContentPacks_Supported.SelectedItem.ToString)
    End Sub

    Private Sub InstalledContentPacks_Supported_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles InstalledContentPacks_Supported.SelectedIndexChanged
        GetResourcesDetail(InstalledContentPacks_Supported.SelectedItem.ToString)
    End Sub

    Private Sub AllGameModes_Supported_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AllGameModes_Supported.SelectedIndexChanged
        GetResourcesDetail(AllGameModes_Supported.SelectedItem.ToString)
    End Sub

    Private Sub InstalledGameModes_Supported_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles InstalledGameModes_Supported.SelectedIndexChanged
        GetResourcesDetail(InstalledGameModes_Supported.SelectedItem.ToString)
    End Sub

    Private Sub ResourceUpdate_Supported_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ResourceUpdate_Supported.SelectedIndexChanged
        GetResourcesDetail(ResourceUpdate_Supported.SelectedItem.ToString)
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        ResourceName = Nothing
        ResourceType = Nothing
        ResourceCategory = Nothing
        ResourceAuthor = Nothing
        ResourceCurrentVersion = Nothing
        ResourceLatestVersion = Nothing
        ResourceDependency = Nothing
        ResourceCompatible = Nothing
        ResourceDescription = Nothing
        ResourceURL = Nothing
        ResourceExtention = Nothing
        ResourceInstalled = Nothing
        DownloadLocation = Nothing
        UninstallLocation = Nothing
        DeleteFiles = Nothing
        CustomOption = Nothing
        Resources_ContentCategory.Text = ResourceCategory
        Resources_Author.Text = ResourceAuthor
        Resources_CurrentVersion.Text = ResourceCurrentVersion
        Resources_LatestVersion.Text = ResourceLatestVersion
        Resources_Dependency.Text = ResourceDependency
        Resources_Compatible.Text = ResourceCompatible
        Resources_Installed.Text = ResourceInstalled
        Resources_Description.Text = ResourceDescription
        Resources_Update.Enabled = False
        Resources_Remove.Enabled = False
        If AllResources_Supported.Items.Count.ToString > 0 Then
            AllResources_Supported.SetSelected(0, True)
        End If
        If AllContentPacks_Supported.Items.Count.ToString > 0 Then
            AllContentPacks_Supported.SetSelected(0, True)
        End If
        If AllGameModes_Supported.Items.Count.ToString > 0 Then
            AllGameModes_Supported.SetSelected(0, True)
        End If
        If InstalledContentPacks_Supported.Items.Count.ToString > 0 Then
            InstalledContentPacks_Supported.SetSelected(0, True)
        End If
        If InstalledGameModes_Supported.Items.Count.ToString > 0 Then
            InstalledGameModes_Supported.SetSelected(0, True)
        End If
        If ResourceUpdate_Supported.Items.Count.ToString > 0 Then
            ResourceUpdate_Supported.SetSelected(0, True)
        End If
    End Sub

    Private Sub Resources_Remove_Click(sender As System.Object, e As System.EventArgs) Handles Resources_Remove.Click
        Functions.PlaySystemSound()
        Uninstall.ShowDialog()
        ResourceName = Nothing
        ResourceType = Nothing
        ResourceCategory = Nothing
        ResourceAuthor = Nothing
        ResourceCurrentVersion = Nothing
        ResourceLatestVersion = Nothing
        ResourceDependency = Nothing
        ResourceCompatible = Nothing
        ResourceDescription = Nothing
        ResourceURL = Nothing
        ResourceExtention = Nothing
        ResourceInstalled = Nothing
        DownloadLocation = Nothing
        UninstallLocation = Nothing
        DeleteFiles = Nothing
        CustomOption = Nothing
        Resources_ContentCategory.Text = ResourceCategory
        Resources_Author.Text = ResourceAuthor
        Resources_CurrentVersion.Text = ResourceCurrentVersion
        Resources_LatestVersion.Text = ResourceLatestVersion
        Resources_Dependency.Text = ResourceDependency
        Resources_Compatible.Text = ResourceCompatible
        Resources_Installed.Text = ResourceInstalled
        Resources_Description.Text = ResourceDescription
        Resources_Update.Enabled = False
        Resources_Remove.Enabled = False
        SupportedResources()
    End Sub

    Private Sub Resources_Update_Click(sender As System.Object, e As System.EventArgs) Handles Resources_Update.Click
        Downloader.ShowDialog()
        ResourceName = Nothing
        ResourceType = Nothing
        ResourceCategory = Nothing
        ResourceAuthor = Nothing
        ResourceCurrentVersion = Nothing
        ResourceLatestVersion = Nothing
        ResourceDependency = Nothing
        ResourceCompatible = Nothing
        ResourceDescription = Nothing
        ResourceURL = Nothing
        ResourceExtention = Nothing
        ResourceInstalled = Nothing
        DownloadLocation = Nothing
        UninstallLocation = Nothing
        DeleteFiles = Nothing
        CustomOption = Nothing
        Resources_ContentCategory.Text = ResourceCategory
        Resources_Author.Text = ResourceAuthor
        Resources_CurrentVersion.Text = ResourceCurrentVersion
        Resources_LatestVersion.Text = ResourceLatestVersion
        Resources_Dependency.Text = ResourceDependency
        Resources_Compatible.Text = ResourceCompatible
        Resources_Installed.Text = ResourceInstalled
        Resources_Description.Text = ResourceDescription
        Resources_Update.Enabled = False
        Resources_Remove.Enabled = False
    End Sub
#End Region

End Class