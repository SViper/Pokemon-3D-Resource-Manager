Imports System.Windows.Forms
Imports System.IO

Public Class Uninstall

    Private Sub Uninstall_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Are you sure you want to remove " + Main.ResourceName
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Directory.Exists(Main.P3DDirectory + "\" + Main.ResourceType + "\" + Main.ResourceName) And Main.UninstallLocation = Nothing Then
            Try
                Directory.Delete(Main.P3DDirectory + "\" + Main.ResourceType + "\" + Main.ResourceName, True)
            Catch ex As Exception
                Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
            End Try
        ElseIf Not Main.UninstallLocation = Nothing Then
            Dim CurrentIndex As Integer = 0
            Do While Not Functions.GetSplit(Main.UninstallLocation, CurrentIndex, ",") = Nothing
                If File.Exists(Main.P3DDirectory + "\" + Functions.GetSplit(Main.UninstallLocation, CurrentIndex, ",")) Then
                    Try
                        File.Delete(Main.P3DDirectory + "\" + Functions.GetSplit(Main.UninstallLocation, CurrentIndex, ","))
                    Catch ex As Exception
                        Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                    End Try
                End If
                If Directory.Exists(Main.P3DDirectory + "\" + Functions.GetSplit(Main.UninstallLocation, CurrentIndex, ",")) Then
                    Try
                        Directory.Delete(Main.P3DDirectory + "\" + Functions.GetSplit(Main.UninstallLocation, CurrentIndex, ","))
                    Catch ex As Exception
                        Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
                    End Try
                End If
                CurrentIndex = CurrentIndex + 1
            Loop
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

End Class
