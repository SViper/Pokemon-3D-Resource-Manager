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
        Me.Logger_Log = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Resources1 = New System.Windows.Forms.TabPage()
        Me.Resources_Supported = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Resources_Description = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Resources_Installed = New System.Windows.Forms.Label()
        Me.Resources_Compatible = New System.Windows.Forms.Label()
        Me.Resources_Dependency = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Resources_ContentCategory = New System.Windows.Forms.Label()
        Me.Resources_Author = New System.Windows.Forms.Label()
        Me.Resources_CurrentVersion = New System.Windows.Forms.Label()
        Me.Resources_LatestVersion = New System.Windows.Forms.Label()
        Me.Resources_Remove = New System.Windows.Forms.Button()
        Me.Resources_Update = New System.Windows.Forms.Button()
        Me.Resources_OpenP3D = New System.Windows.Forms.Button()
        Me.Resources_CheckForUpdate = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.Setting_ResourceDataBase = New System.Windows.Forms.Button()
        Me.Setting_ApplicationCheckForUpdateButton = New System.Windows.Forms.Button()
        Me.Setting_CheckResourcesUpdate = New System.Windows.Forms.CheckBox()
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
        Me.TabControl1.SuspendLayout()
        Me.Resources1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.Logger.SuspendLayout()
        Me.About.SuspendLayout()
        Me.SuspendLayout()
        '
        'Logger_Log
        '
        Me.Logger_Log.AcceptsTab = True
        Me.Logger_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logger_Log.BackColor = System.Drawing.SystemColors.Window
        Me.Logger_Log.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Logger_Log.Location = New System.Drawing.Point(6, 6)
        Me.Logger_Log.Name = "Logger_Log"
        Me.Logger_Log.ReadOnly = True
        Me.Logger_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Logger_Log.Size = New System.Drawing.Size(540, 318)
        Me.Logger_Log.TabIndex = 0
        Me.Logger_Log.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Supported Resources:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Resources1)
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.Logger)
        Me.TabControl1.Controls.Add(Me.About)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 356)
        Me.TabControl1.TabIndex = 4
        '
        'Resources1
        '
        Me.Resources1.Controls.Add(Me.Resources_Supported)
        Me.Resources1.Controls.Add(Me.Panel1)
        Me.Resources1.Controls.Add(Me.Resources_Remove)
        Me.Resources1.Controls.Add(Me.Resources_Update)
        Me.Resources1.Controls.Add(Me.Resources_OpenP3D)
        Me.Resources1.Controls.Add(Me.Resources_CheckForUpdate)
        Me.Resources1.Controls.Add(Me.Label1)
        Me.Resources1.Location = New System.Drawing.Point(4, 22)
        Me.Resources1.Name = "Resources1"
        Me.Resources1.Padding = New System.Windows.Forms.Padding(3)
        Me.Resources1.Size = New System.Drawing.Size(552, 330)
        Me.Resources1.TabIndex = 0
        Me.Resources1.Text = "Resources"
        Me.Resources1.UseVisualStyleBackColor = True
        '
        'Resources_Supported
        '
        Me.Resources_Supported.FormattingEnabled = True
        Me.Resources_Supported.Location = New System.Drawing.Point(9, 29)
        Me.Resources_Supported.Name = "Resources_Supported"
        Me.Resources_Supported.Size = New System.Drawing.Size(534, 134)
        Me.Resources_Supported.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(9, 189)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 106)
        Me.Panel1.TabIndex = 19
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Resources_Description, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 82)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(531, 21)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'Resources_Description
        '
        Me.Resources_Description.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Description.AutoSize = True
        Me.Resources_Description.Location = New System.Drawing.Point(109, 4)
        Me.Resources_Description.Name = "Resources_Description"
        Me.Resources_Description.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Description.TabIndex = 32
        Me.Resources_Description.Text = "Label7"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Description:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Resources_Installed, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Resources_Compatible, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Resources_Dependency, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Resources_ContentCategory, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Resources_Author, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Resources_CurrentVersion, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Resources_LatestVersion, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(531, 76)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'Resources_Installed
        '
        Me.Resources_Installed.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Installed.AutoSize = True
        Me.Resources_Installed.Location = New System.Drawing.Point(374, 41)
        Me.Resources_Installed.Name = "Resources_Installed"
        Me.Resources_Installed.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Installed.TabIndex = 31
        Me.Resources_Installed.Text = "Label7"
        '
        'Resources_Compatible
        '
        Me.Resources_Compatible.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Compatible.AutoSize = True
        Me.Resources_Compatible.Location = New System.Drawing.Point(374, 22)
        Me.Resources_Compatible.Name = "Resources_Compatible"
        Me.Resources_Compatible.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Compatible.TabIndex = 30
        Me.Resources_Compatible.Text = "Label7"
        '
        'Resources_Dependency
        '
        Me.Resources_Dependency.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Dependency.AutoSize = True
        Me.Resources_Dependency.Location = New System.Drawing.Point(374, 3)
        Me.Resources_Dependency.Name = "Resources_Dependency"
        Me.Resources_Dependency.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Dependency.TabIndex = 29
        Me.Resources_Dependency.Text = "Label7"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Content Category:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 3)
        Me.Label14.Margin = New System.Windows.Forms.Padding(3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Dependency:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(306, 22)
        Me.Label15.Margin = New System.Windows.Forms.Padding(3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Compatible:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Author:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 41)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Current Version:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Installed:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 60)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Latest Version:"
        '
        'Resources_ContentCategory
        '
        Me.Resources_ContentCategory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_ContentCategory.AutoSize = True
        Me.Resources_ContentCategory.Location = New System.Drawing.Point(109, 3)
        Me.Resources_ContentCategory.Name = "Resources_ContentCategory"
        Me.Resources_ContentCategory.Size = New System.Drawing.Size(39, 13)
        Me.Resources_ContentCategory.TabIndex = 25
        Me.Resources_ContentCategory.Text = "Label7"
        '
        'Resources_Author
        '
        Me.Resources_Author.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Author.AutoSize = True
        Me.Resources_Author.Location = New System.Drawing.Point(109, 22)
        Me.Resources_Author.Name = "Resources_Author"
        Me.Resources_Author.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Author.TabIndex = 26
        Me.Resources_Author.Text = "Label7"
        '
        'Resources_CurrentVersion
        '
        Me.Resources_CurrentVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_CurrentVersion.AutoSize = True
        Me.Resources_CurrentVersion.Location = New System.Drawing.Point(109, 41)
        Me.Resources_CurrentVersion.Name = "Resources_CurrentVersion"
        Me.Resources_CurrentVersion.Size = New System.Drawing.Size(39, 13)
        Me.Resources_CurrentVersion.TabIndex = 27
        Me.Resources_CurrentVersion.Text = "Label7"
        '
        'Resources_LatestVersion
        '
        Me.Resources_LatestVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_LatestVersion.AutoSize = True
        Me.Resources_LatestVersion.Location = New System.Drawing.Point(109, 60)
        Me.Resources_LatestVersion.Name = "Resources_LatestVersion"
        Me.Resources_LatestVersion.Size = New System.Drawing.Size(39, 13)
        Me.Resources_LatestVersion.TabIndex = 28
        Me.Resources_LatestVersion.Text = "Label7"
        '
        'Resources_Remove
        '
        Me.Resources_Remove.Location = New System.Drawing.Point(135, 301)
        Me.Resources_Remove.Name = "Resources_Remove"
        Me.Resources_Remove.Size = New System.Drawing.Size(125, 23)
        Me.Resources_Remove.TabIndex = 14
        Me.Resources_Remove.Text = "Uninstall / Remove"
        Me.Resources_Remove.UseVisualStyleBackColor = True
        '
        'Resources_Update
        '
        Me.Resources_Update.Location = New System.Drawing.Point(266, 301)
        Me.Resources_Update.Name = "Resources_Update"
        Me.Resources_Update.Size = New System.Drawing.Size(125, 23)
        Me.Resources_Update.TabIndex = 13
        Me.Resources_Update.Text = "Install / Update"
        Me.Resources_Update.UseVisualStyleBackColor = True
        '
        'Resources_OpenP3D
        '
        Me.Resources_OpenP3D.Location = New System.Drawing.Point(421, 301)
        Me.Resources_OpenP3D.Name = "Resources_OpenP3D"
        Me.Resources_OpenP3D.Size = New System.Drawing.Size(125, 23)
        Me.Resources_OpenP3D.TabIndex = 12
        Me.Resources_OpenP3D.Text = "Open Pokémon 3D "
        Me.Resources_OpenP3D.UseVisualStyleBackColor = True
        '
        'Resources_CheckForUpdate
        '
        Me.Resources_CheckForUpdate.Location = New System.Drawing.Point(9, 301)
        Me.Resources_CheckForUpdate.Name = "Resources_CheckForUpdate"
        Me.Resources_CheckForUpdate.Size = New System.Drawing.Size(120, 23)
        Me.Resources_CheckForUpdate.TabIndex = 9
        Me.Resources_CheckForUpdate.Text = "Check For update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Resources_CheckForUpdate.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.Setting_ResourceDataBase)
        Me.Settings.Controls.Add(Me.Setting_ApplicationCheckForUpdateButton)
        Me.Settings.Controls.Add(Me.Setting_CheckResourcesUpdate)
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
        Me.Settings.Size = New System.Drawing.Size(552, 330)
        Me.Settings.TabIndex = 2
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'Setting_ResourceDataBase
        '
        Me.Setting_ResourceDataBase.Location = New System.Drawing.Point(6, 301)
        Me.Setting_ResourceDataBase.Name = "Setting_ResourceDataBase"
        Me.Setting_ResourceDataBase.Size = New System.Drawing.Size(150, 23)
        Me.Setting_ResourceDataBase.TabIndex = 11
        Me.Setting_ResourceDataBase.Text = "Resource DataBase"
        Me.Setting_ResourceDataBase.UseVisualStyleBackColor = True
        '
        'Setting_ApplicationCheckForUpdateButton
        '
        Me.Setting_ApplicationCheckForUpdateButton.Location = New System.Drawing.Point(346, 301)
        Me.Setting_ApplicationCheckForUpdateButton.Name = "Setting_ApplicationCheckForUpdateButton"
        Me.Setting_ApplicationCheckForUpdateButton.Size = New System.Drawing.Size(200, 23)
        Me.Setting_ApplicationCheckForUpdateButton.TabIndex = 10
        Me.Setting_ApplicationCheckForUpdateButton.Text = "Application Check For Updates"
        Me.Setting_ApplicationCheckForUpdateButton.UseVisualStyleBackColor = True
        '
        'Setting_CheckResourcesUpdate
        '
        Me.Setting_CheckResourcesUpdate.AutoSize = True
        Me.Setting_CheckResourcesUpdate.Location = New System.Drawing.Point(9, 138)
        Me.Setting_CheckResourcesUpdate.Name = "Setting_CheckResourcesUpdate"
        Me.Setting_CheckResourcesUpdate.Size = New System.Drawing.Size(236, 17)
        Me.Setting_CheckResourcesUpdate.TabIndex = 8
        Me.Setting_CheckResourcesUpdate.Text = "Check For Update for Resources on Launch"
        Me.Setting_CheckResourcesUpdate.UseVisualStyleBackColor = True
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
        Me.Logger.Controls.Add(Me.Logger_Log)
        Me.Logger.Location = New System.Drawing.Point(4, 22)
        Me.Logger.Name = "Logger"
        Me.Logger.Padding = New System.Windows.Forms.Padding(3)
        Me.Logger.Size = New System.Drawing.Size(552, 330)
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
        Me.About.Size = New System.Drawing.Size(552, 330)
        Me.About.TabIndex = 3
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Window
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
        Me.ClientSize = New System.Drawing.Size(584, 377)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 415)
        Me.MinimumSize = New System.Drawing.Size(600, 415)
        Me.Name = "FileCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokémon 3D Resource Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.Resources1.ResumeLayout(False)
        Me.Resources1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.Logger.ResumeLayout(False)
        Me.About.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Resources1 As System.Windows.Forms.TabPage
    Friend WithEvents Logger As System.Windows.Forms.TabPage
    Friend WithEvents Settings As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Setting_LauncherDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Setting_SearchLauncherDirectory As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Public WithEvents Logger_Log As System.Windows.Forms.RichTextBox
    Friend WithEvents Resources_CheckForUpdate As System.Windows.Forms.Button
    Friend WithEvents Resources_OpenP3D As System.Windows.Forms.Button
    Friend WithEvents About As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Resources_Update As System.Windows.Forms.Button
    Friend WithEvents Resources_Remove As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Setting_GamefilesDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Setting_SearchGamefilesDirectory As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Setting_ApplicationCheckForUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Setting_CheckResourcesUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Setting_ApplicationCheckForUpdateButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Resources_ContentCategory As System.Windows.Forms.Label
    Friend WithEvents Resources_Author As System.Windows.Forms.Label
    Friend WithEvents Resources_CurrentVersion As System.Windows.Forms.Label
    Friend WithEvents Resources_Description As System.Windows.Forms.Label
    Friend WithEvents Resources_Installed As System.Windows.Forms.Label
    Friend WithEvents Resources_Compatible As System.Windows.Forms.Label
    Friend WithEvents Resources_Dependency As System.Windows.Forms.Label
    Friend WithEvents Resources_LatestVersion As System.Windows.Forms.Label
    Friend WithEvents Resources_Supported As System.Windows.Forms.ListBox
    Friend WithEvents Setting_ResourceDataBase As System.Windows.Forms.Button

End Class
