<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckForUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckForUpdate))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Status = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 233)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(503, 25)
        Me.ProgressBar1.TabIndex = 3
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(8, 8)
        Me.Status.Margin = New System.Windows.Forms.Padding(3)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(40, 13)
        Me.Status.TabIndex = 4
        Me.Status.Text = "Status:"
        '
        'StatusText
        '
        Me.StatusText.DetectUrls = False
        Me.StatusText.Location = New System.Drawing.Point(8, 27)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.StatusText.Size = New System.Drawing.Size(503, 200)
        Me.StatusText.TabIndex = 5
        Me.StatusText.Text = ""
        '
        'CheckForUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 272)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 500)
        Me.MinimizeBox = False
        Me.Name = "CheckForUpdate"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Checking For Update..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents StatusText As System.Windows.Forms.RichTextBox

End Class
