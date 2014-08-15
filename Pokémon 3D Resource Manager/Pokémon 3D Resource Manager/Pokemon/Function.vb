Imports System.IO

Public Class Functions

    Public Shared Sub ReturnError(ByVal Message As String)
        FileCheck.PlaySystemSound()
        MsgBox(Message)
        FileCheck.AddLog(Message)
    End Sub

    Public Shared Function GetTextFromLine(ByVal Directory As String, ByVal Line As Integer)
        Dim CurrentReadLine As Integer = 1
        If File.Exists(Directory) Then
            For Each CurrentText In File.ReadAllLines(Directory)
                If CurrentReadLine = Line Then
                    Return CurrentText.ToString
                Else
                    CurrentReadLine = CurrentReadLine + 1
                End If
            Next
        End If
        Return Nothing
    End Function

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
End Class
