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
        Me.InstalledContents = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.InstalledContent = New System.Windows.Forms.TabPage()
        Me.NewVersionInfo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VersionInfo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InfoTextBox = New System.Windows.Forms.RichTextBox()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Logger = New System.Windows.Forms.TabPage()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.InstalledContent.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.Logger.SuspendLayout()
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
        Me.Log.Size = New System.Drawing.Size(485, 290)
        Me.Log.TabIndex = 0
        Me.Log.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Installed Content Packs / GameMode:"
        '
        'InstalledContents
        '
        Me.InstalledContents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstalledContents.FormattingEnabled = True
        Me.InstalledContents.Location = New System.Drawing.Point(9, 29)
        Me.InstalledContents.Name = "InstalledContents"
        Me.InstalledContents.Size = New System.Drawing.Size(482, 21)
        Me.InstalledContents.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.InstalledContent)
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.Logger)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(505, 328)
        Me.TabControl1.TabIndex = 4
        '
        'InstalledContent
        '
        Me.InstalledContent.Controls.Add(Me.Button3)
        Me.InstalledContent.Controls.Add(Me.NewVersionInfo)
        Me.InstalledContent.Controls.Add(Me.Label5)
        Me.InstalledContent.Controls.Add(Me.Button2)
        Me.InstalledContent.Controls.Add(Me.VersionInfo)
        Me.InstalledContent.Controls.Add(Me.Label4)
        Me.InstalledContent.Controls.Add(Me.Label3)
        Me.InstalledContent.Controls.Add(Me.InfoTextBox)
        Me.InstalledContent.Controls.Add(Me.Label1)
        Me.InstalledContent.Controls.Add(Me.InstalledContents)
        Me.InstalledContent.Location = New System.Drawing.Point(4, 22)
        Me.InstalledContent.Name = "InstalledContent"
        Me.InstalledContent.Padding = New System.Windows.Forms.Padding(3)
        Me.InstalledContent.Size = New System.Drawing.Size(497, 302)
        Me.InstalledContent.TabIndex = 0
        Me.InstalledContent.Text = "Installed Content"
        Me.InstalledContent.UseVisualStyleBackColor = True
        '
        'NewVersionInfo
        '
        Me.NewVersionInfo.AutoSize = True
        Me.NewVersionInfo.Location = New System.Drawing.Point(104, 238)
        Me.NewVersionInfo.Name = "NewVersionInfo"
        Me.NewVersionInfo.Size = New System.Drawing.Size(25, 13)
        Me.NewVersionInfo.TabIndex = 11
        Me.NewVersionInfo.Text = "Null"
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Check For update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VersionInfo
        '
        Me.VersionInfo.AutoSize = True
        Me.VersionInfo.Location = New System.Drawing.Point(104, 225)
        Me.VersionInfo.Name = "VersionInfo"
        Me.VersionInfo.Size = New System.Drawing.Size(25, 13)
        Me.VersionInfo.TabIndex = 8
        Me.VersionInfo.Text = "Null"
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
        'InfoTextBox
        '
        Me.InfoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.InfoTextBox.Location = New System.Drawing.Point(9, 56)
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.ReadOnly = True
        Me.InfoTextBox.Size = New System.Drawing.Size(482, 150)
        Me.InfoTextBox.TabIndex = 4
        Me.InfoTextBox.Text = ""
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.Button1)
        Me.Settings.Controls.Add(Me.TextBox1)
        Me.Settings.Controls.Add(Me.Label2)
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(497, 302)
        Me.Settings.TabIndex = 2
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(416, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(401, 20)
        Me.TextBox1.TabIndex = 1
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
        Me.Logger.Size = New System.Drawing.Size(497, 302)
        Me.Logger.TabIndex = 1
        Me.Logger.Text = "Logger"
        Me.Logger.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(366, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Open Pokémon 3D "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FileCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 349)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FileCheck"
        Me.Text = "Pokémon 3D Resource Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.InstalledContent.ResumeLayout(False)
        Me.InstalledContent.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.Logger.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InstalledContents As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InstalledContent As System.Windows.Forms.TabPage
    Friend WithEvents Logger As System.Windows.Forms.TabPage
    Friend WithEvents Settings As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Public WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents InfoTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VersionInfo As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NewVersionInfo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
