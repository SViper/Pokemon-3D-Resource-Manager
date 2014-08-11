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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TextName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.VersionInfo = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.Label()
        Me.ContentName = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.Label()
        Me.NewVersionInfo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Status = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.AutoSize = True
        Me.OK_Button.Location = New System.Drawing.Point(276, 208)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Download"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(357, 208)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
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
        Me.GroupBox1.Size = New System.Drawing.Size(405, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.VersionInfo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ContentName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NewVersionInfo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(390, 75)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'VersionInfo
        '
        Me.VersionInfo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.VersionInfo.AutoSize = True
        Me.VersionInfo.Location = New System.Drawing.Point(100, 29)
        Me.VersionInfo.Name = "VersionInfo"
        Me.VersionInfo.Size = New System.Drawing.Size(39, 13)
        Me.VersionInfo.TabIndex = 7
        Me.VersionInfo.Text = "Label1"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.AutoSize = True
        Me.TextBox3.Location = New System.Drawing.Point(9, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(78, 13)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "Content Name:"
        '
        'ContentName
        '
        Me.ContentName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ContentName.AutoSize = True
        Me.ContentName.Location = New System.Drawing.Point(100, 5)
        Me.ContentName.Name = "ContentName"
        Me.ContentName.Size = New System.Drawing.Size(39, 13)
        Me.ContentName.TabIndex = 3
        Me.ContentName.Text = "Label1"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.AutoSize = True
        Me.TextBox2.Location = New System.Drawing.Point(9, 56)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 13)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Server Version:"
        '
        'NewVersionInfo
        '
        Me.NewVersionInfo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NewVersionInfo.AutoSize = True
        Me.NewVersionInfo.Location = New System.Drawing.Point(100, 55)
        Me.NewVersionInfo.Name = "NewVersionInfo"
        Me.NewVersionInfo.Size = New System.Drawing.Size(39, 13)
        Me.NewVersionInfo.TabIndex = 7
        Me.NewVersionInfo.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Location = New System.Drawing.Point(11, 31)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 13)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Local Version:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 237)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(417, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(21, 131)
        Me.Status.Margin = New System.Windows.Forms.Padding(3)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(40, 13)
        Me.Status.TabIndex = 4
        Me.Status.Text = "Status:"
        '
        'StatusText
        '
        Me.StatusText.Location = New System.Drawing.Point(24, 150)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.Size = New System.Drawing.Size(396, 52)
        Me.StatusText.TabIndex = 5
        Me.StatusText.Text = ""
        '
        'Downloader
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(444, 272)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(450, 300)
        Me.MinimumSize = New System.Drawing.Size(450, 300)
        Me.Name = "Downloader"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update / Reinstall"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TextName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ContentName As System.Windows.Forms.Label
    Friend WithEvents NewVersionInfo As System.Windows.Forms.Label
    Friend WithEvents VersionInfo As System.Windows.Forms.Label
    Friend WithEvents StatusText As System.Windows.Forms.RichTextBox

End Class
