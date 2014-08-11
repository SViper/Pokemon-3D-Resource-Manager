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
        Me.InstalledContent = New System.Windows.Forms.TabPage()
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
        Me.InstalledGameModes = New System.Windows.Forms.TabPage()
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
        Me.SettingSearchButton = New System.Windows.Forms.Button()
        Me.GameDirectory = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Logger = New System.Windows.Forms.TabPage()
        Me.About = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.InstalledContent.SuspendLayout()
        Me.InstalledGameModes.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.InstalledContent)
        Me.TabControl1.Controls.Add(Me.InstalledGameModes)
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.Logger)
        Me.TabControl1.Controls.Add(Me.About)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 341)
        Me.TabControl1.TabIndex = 4
        '
        'InstalledContent
        '
        Me.InstalledContent.Controls.Add(Me.RefreshButton)
        Me.InstalledContent.Controls.Add(Me.ContentPackRemoveButton)
        Me.InstalledContent.Controls.Add(Me.ContentPackUpdateButton)
        Me.InstalledContent.Controls.Add(Me.OpenP3DGame)
        Me.InstalledContent.Controls.Add(Me.ContentPackNewVersionInfo)
        Me.InstalledContent.Controls.Add(Me.Label5)
        Me.InstalledContent.Controls.Add(Me.ContentPackCheckForUpdateButton)
        Me.InstalledContent.Controls.Add(Me.ContentPackVersionInfo)
        Me.InstalledContent.Controls.Add(Me.Label4)
        Me.InstalledContent.Controls.Add(Me.Label3)
        Me.InstalledContent.Controls.Add(Me.ContentPackInfo)
        Me.InstalledContent.Controls.Add(Me.Label1)
        Me.InstalledContent.Controls.Add(Me.InstalledContentPacksName)
        Me.InstalledContent.Location = New System.Drawing.Point(4, 22)
        Me.InstalledContent.Name = "InstalledContent"
        Me.InstalledContent.Padding = New System.Windows.Forms.Padding(3)
        Me.InstalledContent.Size = New System.Drawing.Size(552, 315)
        Me.InstalledContent.TabIndex = 0
        Me.InstalledContent.Text = "Installed ContentPacks"
        Me.InstalledContent.UseVisualStyleBackColor = True
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
        'InstalledGameModes
        '
        Me.InstalledGameModes.Controls.Add(Me.OpenP3DGame1)
        Me.InstalledGameModes.Controls.Add(Me.GameModeUpdateButton)
        Me.InstalledGameModes.Controls.Add(Me.GameModeRemoveButton)
        Me.InstalledGameModes.Controls.Add(Me.GameModeCheckForUpdateButton)
        Me.InstalledGameModes.Controls.Add(Me.GameModeNewVersionInfo)
        Me.InstalledGameModes.Controls.Add(Me.GameModeVersionInfo)
        Me.InstalledGameModes.Controls.Add(Me.Label9)
        Me.InstalledGameModes.Controls.Add(Me.Label8)
        Me.InstalledGameModes.Controls.Add(Me.Label7)
        Me.InstalledGameModes.Controls.Add(Me.GameModeInfo)
        Me.InstalledGameModes.Controls.Add(Me.GameModeRefreshButton)
        Me.InstalledGameModes.Controls.Add(Me.InstalledGameModesName)
        Me.InstalledGameModes.Controls.Add(Me.Label6)
        Me.InstalledGameModes.Location = New System.Drawing.Point(4, 22)
        Me.InstalledGameModes.Name = "InstalledGameModes"
        Me.InstalledGameModes.Size = New System.Drawing.Size(552, 315)
        Me.InstalledGameModes.TabIndex = 4
        Me.InstalledGameModes.Text = "Installed GameModes"
        Me.InstalledGameModes.UseVisualStyleBackColor = True
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
        Me.Settings.Controls.Add(Me.SettingSearchButton)
        Me.Settings.Controls.Add(Me.GameDirectory)
        Me.Settings.Controls.Add(Me.Label2)
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(552, 315)
        Me.Settings.TabIndex = 2
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'SettingSearchButton
        '
        Me.SettingSearchButton.Location = New System.Drawing.Point(416, 16)
        Me.SettingSearchButton.Name = "SettingSearchButton"
        Me.SettingSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SettingSearchButton.TabIndex = 2
        Me.SettingSearchButton.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SettingSearchButton.UseVisualStyleBackColor = True
        '
        'GameDirectory
        '
        Me.GameDirectory.Location = New System.Drawing.Point(9, 19)
        Me.GameDirectory.Name = "GameDirectory"
        Me.GameDirectory.ReadOnly = True
        Me.GameDirectory.Size = New System.Drawing.Size(401, 20)
        Me.GameDirectory.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Game Directory:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.InstalledContent.ResumeLayout(False)
        Me.InstalledContent.PerformLayout()
        Me.InstalledGameModes.ResumeLayout(False)
        Me.InstalledGameModes.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.Logger.ResumeLayout(False)
        Me.About.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InstalledContentPacksName As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InstalledContent As System.Windows.Forms.TabPage
    Friend WithEvents Logger As System.Windows.Forms.TabPage
    Friend WithEvents Settings As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GameDirectory As System.Windows.Forms.TextBox
    Friend WithEvents SettingSearchButton As System.Windows.Forms.Button
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
    Friend WithEvents InstalledGameModes As System.Windows.Forms.TabPage
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

End Class
