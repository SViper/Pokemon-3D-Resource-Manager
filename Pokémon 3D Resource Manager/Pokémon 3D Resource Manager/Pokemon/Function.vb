Public Class Functions

    Public Shared Sub ReturnError(ByVal e As String)
        FileCheck.PlaySystemSound()
        MsgBox(e)
        FileCheck.ShowLog(e)
    End Sub

    Public Shared Function GetSplit(ByVal fullString As String, ByVal valueIndex As Int32, ByVal seperator As String) As String
        If (valueIndex = 0) Then
            Return fullString.Remove(fullString.IndexOf(seperator))
        End If
        Dim num2 As Integer = (valueIndex - 1)
        Dim num1 As Integer = 0
        Do While (num1 <= num2)
            fullString = fullString.Remove(0, (fullString.IndexOf(seperator) + 1))
            num1 = (num1 + 1)
        Loop
        If (fullString.Contains(seperator)) Then
            Do While (fullString.Contains(seperator))
                fullString = fullString.Remove(fullString.IndexOf(seperator))
            Loop
        End If
        Return fullString
    End Function

    Public Shared Sub LogError(ByVal e As String)
        FileCheck.PlaySystemSound()
        MsgBox(e)
        FileCheck.ShowLog(e)
    End Sub
End Class
