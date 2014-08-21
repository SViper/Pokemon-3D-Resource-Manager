<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downloader))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TextName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Resources_Description = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Status = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.AutoSize = True
        Me.OK_Button.Location = New System.Drawing.Point(476, 408)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Download"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(582, 408)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TextName
        '
        Me.TextName.AutoSize = True
        Me.TextName.Location = New System.Drawing.Point(12, 9)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(106, 13)
        Me.TextName.TabIndex = 1
        Me.TextName.Text = "Download the lastest"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 144)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(661, 125)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.1145!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.8855!))
        Me.TableLayoutPanel2.Controls.Add(Me.Resources_Description, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 96)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(655, 26)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'Resources_Description
        '
        Me.Resources_Description.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Description.AutoSize = True
        Me.Resources_Description.Location = New System.Drawing.Point(101, 6)
        Me.Resources_Description.Name = "Resources_Description"
        Me.Resources_Description.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Description.TabIndex = 32
        Me.Resources_Description.Text = "Label7"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Description:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Resources_Installed, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Resources_Compatible, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Resources_Dependency, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Resources_ContentCategory, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Resources_Author, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Resources_CurrentVersion, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Resources_LatestVersion, 1, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(655, 87)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'Resources_Installed
        '
        Me.Resources_Installed.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Installed.AutoSize = True
        Me.Resources_Installed.Location = New System.Drawing.Point(418, 46)
        Me.Resources_Installed.Name = "Resources_Installed"
        Me.Resources_Installed.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Installed.TabIndex = 31
        Me.Resources_Installed.Text = "Label7"
        '
        'Resources_Compatible
        '
        Me.Resources_Compatible.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Compatible.AutoSize = True
        Me.Resources_Compatible.Location = New System.Drawing.Point(418, 25)
        Me.Resources_Compatible.Name = "Resources_Compatible"
        Me.Resources_Compatible.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Compatible.TabIndex = 30
        Me.Resources_Compatible.Text = "Label7"
        '
        'Resources_Dependency
        '
        Me.Resources_Dependency.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Dependency.AutoSize = True
        Me.Resources_Dependency.Location = New System.Drawing.Point(418, 4)
        Me.Resources_Dependency.Name = "Resources_Dependency"
        Me.Resources_Dependency.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Dependency.TabIndex = 29
        Me.Resources_Dependency.Text = "Label7"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 4)
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
        Me.Label14.Location = New System.Drawing.Point(341, 4)
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
        Me.Label15.Location = New System.Drawing.Point(350, 25)
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
        Me.Label5.Location = New System.Drawing.Point(54, 25)
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
        Me.Label13.Location = New System.Drawing.Point(13, 46)
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
        Me.Label6.Location = New System.Drawing.Point(363, 46)
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
        Me.Label12.Location = New System.Drawing.Point(18, 68)
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
        Me.Resources_ContentCategory.Location = New System.Drawing.Point(101, 4)
        Me.Resources_ContentCategory.Name = "Resources_ContentCategory"
        Me.Resources_ContentCategory.Size = New System.Drawing.Size(39, 13)
        Me.Resources_ContentCategory.TabIndex = 25
        Me.Resources_ContentCategory.Text = "Label7"
        '
        'Resources_Author
        '
        Me.Resources_Author.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_Author.AutoSize = True
        Me.Resources_Author.Location = New System.Drawing.Point(101, 25)
        Me.Resources_Author.Name = "Resources_Author"
        Me.Resources_Author.Size = New System.Drawing.Size(39, 13)
        Me.Resources_Author.TabIndex = 26
        Me.Resources_Author.Text = "Label7"
        '
        'Resources_CurrentVersion
        '
        Me.Resources_CurrentVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_CurrentVersion.AutoSize = True
        Me.Resources_CurrentVersion.Location = New System.Drawing.Point(101, 46)
        Me.Resources_CurrentVersion.Name = "Resources_CurrentVersion"
        Me.Resources_CurrentVersion.Size = New System.Drawing.Size(39, 13)
        Me.Resources_CurrentVersion.TabIndex = 27
        Me.Resources_CurrentVersion.Text = "Label7"
        '
        'Resources_LatestVersion
        '
        Me.Resources_LatestVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Resources_LatestVersion.AutoSize = True
        Me.Resources_LatestVersion.Location = New System.Drawing.Point(101, 68)
        Me.Resources_LatestVersion.Name = "Resources_LatestVersion"
        Me.Resources_LatestVersion.Size = New System.Drawing.Size(39, 13)
        Me.Resources_LatestVersion.TabIndex = 28
        Me.Resources_LatestVersion.Text = "Label7"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 437)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(670, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(12, 172)
        Me.Status.Margin = New System.Windows.Forms.Padding(3)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(40, 13)
        Me.Status.TabIndex = 4
        Me.Status.Text = "Status:"
        '
        'StatusText
        '
        Me.StatusText.DetectUrls = False
        Me.StatusText.Location = New System.Drawing.Point(12, 191)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.StatusText.Size = New System.Drawing.Size(670, 211)
        Me.StatusText.TabIndex = 5
        Me.StatusText.Text = ""
        '
        'Downloader
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(694, 472)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "Downloader"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update / Reinstall"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TextName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents StatusText As System.Windows.Forms.RichTextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Resources_Description As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Resources_Installed As System.Windows.Forms.Label
    Friend WithEvents Resources_Compatible As System.Windows.Forms.Label
    Friend WithEvents Resources_Dependency As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Resources_ContentCategory As System.Windows.Forms.Label
    Friend WithEvents Resources_Author As System.Windows.Forms.Label
    Friend WithEvents Resources_CurrentVersion As System.Windows.Forms.Label
    Friend WithEvents Resources_LatestVersion As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
