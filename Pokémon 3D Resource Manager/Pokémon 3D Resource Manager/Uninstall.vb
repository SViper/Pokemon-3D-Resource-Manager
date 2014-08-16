Imports System.Windows.Forms
Imports System.IO

Public Class Uninstall

    Private Sub Uninstall_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Are you sure you want to remove " + FileCheck.ResourceName
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Directory.Exists(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName) Then
            Try
                Directory.Delete(FileCheck.P3DDirectory + "\" + FileCheck.Resourcetype + "\" + FileCheck.ResourceFolderName, True)
            Catch ex As Exception
                Functions.ReturnError(ex.Message)
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

End Class
