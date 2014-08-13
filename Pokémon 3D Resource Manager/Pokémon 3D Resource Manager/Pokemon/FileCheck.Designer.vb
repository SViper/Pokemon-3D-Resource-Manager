<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileCheck
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileCheck))
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InstalledContentPacksName = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ContentPacks = New System.Windows.Forms.TabPage()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ContentPackRemoveButton = New System.Windows.Forms.Button()
        Me.ContentPackUpdateButton = New System.Windows.Forms.Button()
        Me.OpenP3DGame = New System.Windows.Forms.Button()
        Me.ContentPackNewVersionInfo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContentPackCheckForUpdateButton = New System.Windows.Forms.Button()
        Me.ContentPackVersionInfo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContentPackInfo = New System.Windows.Forms.RichTextBox()
        Me.GameModes = New System.Windows.Forms.TabPage()
        Me.OpenP3DGame1 = New System.Windows.Forms.Button()
        Me.GameModeUpdateButton = New System.Windows.Forms.Button()
        Me.GameModeRemoveButton = New System.Windows.Forms.Button()
        Me.GameModeCheckForUpdateButton = New System.Windows.Forms.Button()
        Me.GameModeNewVersionInfo = New System.Windows.Forms.Label()
        Me.GameModeVersionInfo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GameModeInfo = New System.Windows.Forms.RichTextBox()
        Me.GameModeRefreshButton = New System.Windows.Forms.Button()
        Me.InstalledGameModesName = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.Setting_CheckGameModesUpdate = New System.Windows.Forms.CheckBox()
        Me.Setting_CheckContentPacksUpdate = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Setting_ApplicationCheckForUpdate = New System.Windows.Forms.CheckBox()
        Me.Setting_SearchGamefilesDirectory = New System.Windows.Forms.Button()
        Me.Setting_GamefilesDirectory = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Setting_SearchLauncherDirectory = New System.Windows.Forms.Button()
        Me.Setting_LauncherDirectory = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Logger = New System.Windows.Forms.TabPage()
        Me.About = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Setting_ApplicationCheckForUpdateButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.ContentPacks.SuspendLayout()
        Me.GameModes.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.Logger.SuspendLayout()
        Me.About.SuspendLayout()
        Me.SuspendLayout()
        '
        'Log
        '
        Me.Log.AcceptsTab = True
        Me.Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log.BackColor = System.Drawing.SystemColors.Window
        Me.Log.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Log.Location = New System.Drawing.Point(6, 6)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Log.Size = New System.Drawing.Size(540, 303)
        Me.Log.TabIndex = 0
        Me.Log.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Installed ContentPacks:"
        '
        'InstalledContentPacksName
        '
        Me.InstalledContentPacksName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstalledContentPacksName.FormattingEnabled = True
        Me.InstalledContentPacksName.Location = New System.Drawing.Point(9, 29)
        Me.InstalledContentPacksName.Name = "InstalledContentPacksName"
        Me.InstalledContentPacksName.Size = New System.Drawing.Size(456, 21)
        Me.InstalledContentPacksName.Sorted = True
        Me.InstalledContentPacksName.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.ContentPacks)
        Me.TabControl1.Controls.Add(Me.GameModes)
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.Logger)
        Me.TabControl1.Controls.Add(Me.About)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 341)
        Me.TabControl1.TabIndex = 4
        '
        'ContentPacks
        '
        Me.ContentPacks.Controls.Add(Me.RefreshButton)
        Me.ContentPacks.Controls.Add(Me.ContentPackRemoveButton)
        Me.ContentPacks.Controls.Add(Me.ContentPackUpdateButton)
        Me.ContentPacks.Controls.Add(Me.OpenP3DGame)
        Me.ContentPacks.Controls.Add(Me.ContentPackNewVersionInfo)
        Me.ContentPacks.Controls.Add(Me.Label5)
        Me.ContentPacks.Controls.Add(Me.ContentPackCheckForUpdateButton)
        Me.ContentPacks.Controls.Add(Me.ContentPackVersionInfo)
        Me.ContentPacks.Controls.Add(Me.Label4)
        Me.ContentPacks.Controls.Add(Me.Label3)
        Me.ContentPacks.Controls.Add(Me.ContentPackInfo)
        Me.ContentPacks.Controls.Add(Me.Label1)
        Me.ContentPacks.Controls.Add(Me.InstalledContentPacksName)
        Me.ContentPacks.Location = New System.Drawing.Point(4, 22)
        Me.ContentPacks.Name = "ContentPacks"
        Me.ContentPacks.Padding = New System.Windows.Forms.Padding(3)
        Me.ContentPacks.Size = New System.Drawing.Size(552, 315)
        Me.ContentPacks.TabIndex = 0
        Me.ContentPacks.Text = "ContentPacks"
        Me.ContentPacks.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(471, 27)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 15
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'ContentPackRemoveButton
        '
        Me.ContentPackRemoveButton.Location = New System.Drawing.Point(135, 286)
        Me.ContentPackRemoveButton.Name = "ContentPackRemoveButton"
        Me.ContentPackRemoveButton.Size = New System.Drawing.Size(125, 23)
        Me.ContentPackRemoveButton.TabIndex = 14
        Me.ContentPackRemoveButton.Text = "Uninstall / Remove"
        Me.ContentPackRemoveButton.UseVisualStyleBackColor = True
        '
        'ContentPackUpdateButton
        '
        Me.ContentPackUpdateButton.Location = New System.Drawing.Point(266, 286)
        Me.ContentPackUpdateButton.Name = "ContentPackUpdateButton"
        Me.ContentPackUpdateButton.Size = New System.Drawing.Size(125, 23)
        Me.ContentPackUpdateButton.TabIndex = 13
        Me.ContentPackUpdateButton.Text = "Reinstall / Update"
        Me.ContentPackUpdateButton.UseVisualStyleBackColor = True
        '
        'OpenP3DGame
        '
        Me.OpenP3DGame.Location = New System.Drawing.Point(421, 286)
        Me.OpenP3DGame.Name = "OpenP3DGame"
        Me.OpenP3DGame.Size = New System.Drawing.Size(125, 23)
        Me.OpenP3DGame.TabIndex = 12
        Me.OpenP3DGame.Text = "Open Pokémon 3D "
        Me.OpenP3DGame.UseVisualStyleBackColor = True
        '
        'ContentPackNewVersionInfo
        '
        Me.ContentPackNewVersionInfo.AutoSize = True
        Me.ContentPackNewVersionInfo.Location = New System.Drawing.Point(104, 238)
        Me.ContentPackNewVersionInfo.Name = "ContentPackNewVersionInfo"
        Me.ContentPackNewVersionInfo.Size = New System.Drawing.Size(25, 13)
        Me.ContentPackNewVersionInfo.TabIndex = 11
        Me.ContentPackNewVersionInfo.Text = "Null"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Latest Version Info:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ContentPackCheckForUpdateButton
        '
        Me.ContentPackCheckForUpdateButton.Location = New System.Drawing.Point(9, 286)
        Me.ContentPackCheckForUpdateButton.Name = "ContentPackCheckForUpdateButton"
        Me.ContentPackCheckForUpdateButton.Size = New System.Drawing.Size(120, 23)
        Me.ContentPackCheckForUpdateButton.TabIndex = 9
        Me.ContentPackCheckForUpdateButton.Text = "Check For update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ContentPackCheckForUpdateButton.UseVisualStyleBackColor = True
        '
        'ContentPackVersionInfo
        '
        Me.ContentPackVersionInfo.AutoSize = True
        Me.ContentPackVersionInfo.Location = New System.Drawing.Point(104, 225)
        Me.ContentPackVersionInfo.Name = "ContentPackVersionInfo"
        Me.ContentPackVersionInfo.Size = New System.Drawing.Size(25, 13)
        Me.ContentPackVersionInfo.TabIndex = 8
        Me.ContentPackVersionInfo.Text = "Null"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Local Version Info:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Status:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ContentPackInfo
        '
        Me.ContentPackInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContentPackInfo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ContentPackInfo.Location = New System.Drawing.Point(9, 56)
        Me.ContentPackInfo.Name = "ContentPackInfo"
        Me.ContentPackInfo.ReadOnly = True
        Me.ContentPackInfo.Size = New System.Drawing.Size(537, 147)
        Me.ContentPackInfo.TabIndex = 4
        Me.ContentPackInfo.Text = ""
        '
        'GameModes
        '
        Me.GameModes.Controls.Add(Me.OpenP3DGame1)
        Me.GameModes.Controls.Add(Me.GameModeUpdateButton)
        Me.GameModes.Controls.Add(Me.GameModeRemoveButton)
        Me.GameModes.Controls.Add(Me.GameModeCheckForUpdateButton)
        Me.GameModes.Controls.Add(Me.GameModeNewVersionInfo)
        Me.GameModes.Controls.Add(Me.GameModeVersionInfo)
        Me.GameModes.Controls.Add(Me.Label9)
        Me.GameModes.Controls.Add(Me.Label8)
        Me.GameModes.Controls.Add(Me.Label7)
        Me.GameModes.Controls.Add(Me.GameModeInfo)
        Me.GameModes.Controls.Add(Me.GameModeRefreshButton)
        Me.GameModes.Controls.Add(Me.InstalledGameModesName)
        Me.GameModes.Controls.Add(Me.Label6)
        Me.GameModes.Location = New System.Drawing.Point(4, 22)
        Me.GameModes.Name = "GameModes"
        Me.GameModes.Size = New System.Drawing.Size(552, 315)
        Me.GameModes.TabIndex = 4
        Me.GameModes.Text = "GameModes"
        Me.GameModes.UseVisualStyleBackColor = True
        '
        'OpenP3DGame1
        '
        Me.OpenP3DGame1.Location = New System.Drawing.Point(421, 286)
        Me.OpenP3DGame1.Name = "OpenP3DGame1"
        Me.OpenP3DGame1.Size = New System.Drawing.Size(125, 23)
        Me.OpenP3DGame1.TabIndex = 26
        Me.OpenP3DGame1.Text = "Open Pokémon 3D "
        Me.OpenP3DGame1.UseVisualStyleBackColor = True
        '
        'GameModeUpdateButton
        '
        Me.GameModeUpdateButton.Location = New System.Drawing.Point(266, 286)
        Me.GameModeUpdateButton.Name = "GameModeUpdateButton"
        Me.GameModeUpdateButton.Size = New System.Drawing.Size(125, 23)
        Me.GameModeUpdateButton.TabIndex = 25
        Me.GameModeUpdateButton.Text = "Reinstall / Update"
        Me.GameModeUpdateButton.UseVisualStyleBackColor = True
        '
        'GameModeRemoveButton
        '
        Me.GameModeRemoveButton.Location = New System.Drawing.Point(135, 286)
        Me.GameModeRemoveButton.Name = "GameModeRemoveButton"
        Me.GameModeRemoveButton.Size = New System.Drawing.Size(125, 23)
        Me.GameModeRemoveButton.TabIndex = 24
        Me.GameModeRemoveButton.Text = "Uninstall / Remove"
        Me.GameModeRemoveButton.UseVisualStyleBackColor = True
        '
        'GameModeCheckForUpdateButton
        '
        Me.GameModeCheckForUpdateButton.Location = New System.Drawing.Point(9, 286)
        Me.GameModeCheckForUpdateButton.Name = "GameModeCheckForUpdateButton"
        Me.GameModeCheckForUpdateButton.Size = New System.Drawing.Size(120, 23)
        Me.GameModeCheckForUpdateButton.TabIndex = 23
        Me.GameModeCheckForUpdateButton.Text = "Check For update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.GameModeCheckForUpdateButton.UseVisualStyleBackColor = True
        '
        'GameModeNewVersionInfo
        '
        Me.GameModeNewVersionInfo.AutoSize = True
        Me.GameModeNewVersionInfo.Location = New System.Drawing.Point(104, 238)
        Me.GameModeNewVersionInfo.Name = "GameModeNewVersionInfo"
        Me.GameModeNewVersionInfo.Size = New System.Drawing.Size(25, 13)
        Me.GameModeNewVersionInfo.TabIndex = 22
        Me.GameModeNewVersionInfo.Text = "Null"
        '
        'GameModeVersionInfo
        '
        Me.GameModeVersionInfo.AutoSize = True
        Me.GameModeVersionInfo.Location = New System.Drawing.Point(104, 225)
        Me.GameModeVersionInfo.Name = "GameModeVersionInfo"
        Me.GameModeVersionInfo.Size = New System.Drawing.Size(25, 13)
        Me.GameModeVersionInfo.TabIndex = 21
        Me.GameModeVersionInfo.Text = "Null"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Latest Version Info:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Local Version Info:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Status:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GameModeInfo
        '
        Me.GameModeInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameModeInfo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameModeInfo.Location = New System.Drawing.Point(9, 56)
        Me.GameModeInfo.Name = "GameModeInfo"
        Me.GameModeInfo.ReadOnly = True
        Me.GameModeInfo.Size = New System.Drawing.Size(537, 147)
        Me.GameModeInfo.TabIndex = 17
        Me.GameModeInfo.Text = ""
        '
        'GameModeRefreshButton
        '
        Me.GameModeRefreshButton.Location = New System.Drawing.Point(471, 27)
        Me.GameModeRefreshButton.Name = "GameModeRefreshButton"
        Me.GameModeRefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.GameModeRefreshButton.TabIndex = 16
        Me.GameModeRefreshButton.Text = "Refresh"
        Me.GameModeRefreshButton.UseVisualStyleBackColor = True
        '
        'InstalledGameModesName
        '
        Me.InstalledGameModesName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstalledGameModesName.FormattingEnabled = True
        Me.InstalledGameModesName.Location = New System.Drawing.Point(9, 29)
        Me.InstalledGameModesName.Name = "InstalledGameModesName"
        Me.InstalledGameModesName.Size = New System.Drawing.Size(456, 21)
        Me.InstalledGameModesName.Sorted = True
        Me.InstalledGameModesName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Installed GameModes:"
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.Setting_ApplicationCheckForUpdateButton)
        Me.Settings.Controls.Add(Me.Setting_CheckGameModesUpdate)
        Me.Settings.Controls.Add(Me.Setting_CheckContentPacksUpdate)
        Me.Settings.Controls.Add(Me.Label11)
        Me.Settings.Controls.Add(Me.Setting_ApplicationCheckForUpdate)
        Me.Settings.Controls.Add(Me.Setting_SearchGamefilesDirectory)
        Me.Settings.Controls.Add(Me.Setting_GamefilesDirectory)
        Me.Settings.Controls.Add(Me.Label10)
        Me.Settings.Controls.Add(Me.Setting_SearchLauncherDirectory)
        Me.Settings.Controls.Add(Me.Setting_LauncherDirectory)
        Me.Settings.Controls.Add(Me.Label2)
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(552, 315)
        Me.Settings.TabIndex = 2
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'Setting_CheckGameModesUpdate
        '
        Me.Setting_CheckGameModesUpdate.AutoSize = True
        Me.Setting_CheckGameModesUpdate.Location = New System.Drawing.Point(9, 161)
        Me.Setting_CheckGameModesUpdate.Name = "Setting_CheckGameModesUpdate"
        Me.Setting_CheckGameModesUpdate.Size = New System.Drawing.Size(191, 17)
        Me.Setting_CheckGameModesUpdate.TabIndex = 9
        Me.Setting_CheckGameModesUpdate.Text = "Check For Update for GameModes"
        Me.Setting_CheckGameModesUpdate.UseVisualStyleBackColor = True
        '
        'Setting_CheckContentPacksUpdate
        '
        Me.Setting_CheckContentPacksUpdate.AutoSize = True
        Me.Setting_CheckContentPacksUpdate.Location = New System.Drawing.Point(9, 138)
        Me.Setting_CheckContentPacksUpdate.Name = "Setting_CheckContentPacksUpdate"
        Me.Setting_CheckContentPacksUpdate.Size = New System.Drawing.Size(198, 17)
        Me.Setting_CheckContentPacksUpdate.TabIndex = 8
        Me.Setting_CheckContentPacksUpdate.Text = "Check For Update for ContentPacks"
        Me.Setting_CheckContentPacksUpdate.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 96)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Others:"
        '
        'Setting_ApplicationCheckForUpdate
        '
        Me.Setting_ApplicationCheckForUpdate.AutoSize = True
        Me.Setting_ApplicationCheckForUpdate.Location = New System.Drawing.Point(9, 115)
        Me.Setting_ApplicationCheckForUpdate.Name = "Setting_ApplicationCheckForUpdate"
        Me.Setting_ApplicationCheckForUpdate.Size = New System.Drawing.Size(227, 17)
        Me.Setting_ApplicationCheckForUpdate.TabIndex = 6
        Me.Setting_ApplicationCheckForUpdate.Text = "Application Check For Updates on Launch"
        Me.Setting_ApplicationCheckForUpdate.UseVisualStyleBackColor = True
        '
        'Setting_SearchGamefilesDirectory
        '
        Me.Setting_SearchGamefilesDirectory.Location = New System.Drawing.Point(471, 67)
        Me.Setting_SearchGamefilesDirectory.Name = "Setting_SearchGamefilesDirectory"
        Me.Setting_SearchGamefilesDirectory.Size = New System.Drawing.Size(75, 23)
        Me.Setting_SearchGamefilesDirectory.TabIndex = 5
        Me.Setting_SearchGamefilesDirectory.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Setting_SearchGamefilesDirectory.UseVisualStyleBackColor = True
        '
        'Setting_GamefilesDirectory
        '
        Me.Setting_GamefilesDirectory.Location = New System.Drawing.Point(9, 70)
        Me.Setting_GamefilesDirectory.Name = "Setting_GamefilesDirectory"
        Me.Setting_GamefilesDirectory.ReadOnly = True
        Me.Setting_GamefilesDirectory.Size = New System.Drawing.Size(456, 20)
        Me.Setting_GamefilesDirectory.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "P3D Gamefiles Directory:"
        '
        'Setting_SearchLauncherDirectory
        '
        Me.Setting_SearchLauncherDirectory.Location = New System.Drawing.Point(471, 22)
        Me.Setting_SearchLauncherDirectory.Name = "Setting_SearchLauncherDirectory"
        Me.Setting_SearchLauncherDirectory.Size = New System.Drawing.Size(75, 23)
        Me.Setting_SearchLauncherDirectory.TabIndex = 2
        Me.Setting_SearchLauncherDirectory.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Setting_SearchLauncherDirectory.UseVisualStyleBackColor = True
        '
        'Setting_LauncherDirectory
        '
        Me.Setting_LauncherDirectory.Location = New System.Drawing.Point(9, 25)
        Me.Setting_LauncherDirectory.Name = "Setting_LauncherDirectory"
        Me.Setting_LauncherDirectory.ReadOnly = True
        Me.Setting_LauncherDirectory.Size = New System.Drawing.Size(456, 20)
        Me.Setting_LauncherDirectory.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "P3D Launcher Directory:"
        '
        'Logger
        '
        Me.Logger.Controls.Add(Me.Log)
        Me.Logger.Location = New System.Drawing.Point(4, 22)
        Me.Logger.Name = "Logger"
        Me.Logger.Padding = New System.Windows.Forms.Padding(3)
        Me.Logger.Size = New System.Drawing.Size(552, 315)
        Me.Logger.TabIndex = 1
        Me.Logger.Text = "Logger"
        Me.Logger.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.Controls.Add(Me.RichTextBox1)
        Me.About.Location = New System.Drawing.Point(4, 22)
        Me.About.Name = "About"
        Me.About.Padding = New System.Windows.Forms.Padding(3)
        Me.About.Size = New System.Drawing.Size(552, 315)
        Me.About.TabIndex = 3
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 6)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(543, 303)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Setting_ApplicationCheckForUpdateButton
        '
        Me.Setting_ApplicationCheckForUpdateButton.Location = New System.Drawing.Point(346, 286)
        Me.Setting_ApplicationCheckForUpdateButton.Name = "Setting_ApplicationCheckForUpdateButton"
        Me.Setting_ApplicationCheckForUpdateButton.Size = New System.Drawing.Size(200, 23)
        Me.Setting_ApplicationCheckForUpdateButton.TabIndex = 10
        Me.Setting_ApplicationCheckForUpdateButton.Text = "Application Check For Updates"
        Me.Setting_ApplicationCheckForUpdateButton.UseVisualStyleBackColor = True
        '
        'FileCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FileCheck"
        Me.Text = "Pokémon 3D Resource Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.ContentPacks.ResumeLayout(False)
        Me.ContentPacks.PerformLayout()
        Me.GameModes.ResumeLayout(False)
        Me.GameModes.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.Logger.ResumeLayout(False)
        Me.About.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InstalledContentPacksName As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ContentPacks As System.Windows.Forms.TabPage
    Friend WithEvents Logger As System.Windows.Forms.TabPage
    Friend WithEvents Settings As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Setting_LauncherDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Setting_SearchLauncherDirectory As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Public WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents ContentPackInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContentPackVersionInfo As System.Windows.Forms.Label
    Friend WithEvents ContentPackCheckForUpdateButton As System.Windows.Forms.Button
    Friend WithEvents ContentPackNewVersionInfo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenP3DGame As System.Windows.Forms.Button
    Friend WithEvents About As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContentPackUpdateButton As System.Windows.Forms.Button
    Friend WithEvents ContentPackRemoveButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents GameModes As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InstalledGameModesName As System.Windows.Forms.ComboBox
    Friend WithEvents GameModeRefreshButton As System.Windows.Forms.Button
    Friend WithEvents GameModeInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenP3DGame1 As System.Windows.Forms.Button
    Friend WithEvents GameModeUpdateButton As System.Windows.Forms.Button
    Friend WithEvents GameModeRemoveButton As System.Windows.Forms.Button
    Friend WithEvents GameModeCheckForUpdateButton As System.Windows.Forms.Button
    Friend WithEvents GameModeNewVersionInfo As System.Windows.Forms.Label
    Friend WithEvents GameModeVersionInfo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Setting_GamefilesDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Setting_SearchGamefilesDirectory As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Setting_ApplicationCheckForUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Setting_CheckContentPacksUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Setting_CheckGameModesUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Setting_ApplicationCheckForUpdateButton As System.Windows.Forms.Button

End Class
