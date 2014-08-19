Imports System.IO

Public Class Functions

    Public Shared Sub ReturnError(ByVal Message As String, ByVal Helplink As String, ByVal Callstack As String)
        PlaySystemSound()
        Dim CoreArchitecture As String
        If Environment.Is64BitOperatingSystem = True Then
            CoreArchitecture = "64 Bit"
        Else
            CoreArchitecture = "32 Bit"
        End If
        Dim ErrorLog As String =
            "[CODE]" + vbNewLine +
            "Pokémon 3D Resource Manager Crash Log v" + FileCheck.ApplicationVersion + vbNewLine +
            "--------------------------------------------------" + vbNewLine +
            vbNewLine +
            "System specifications:" + vbNewLine +
            vbNewLine +
            "Operating system: " + My.Computer.Info.OSFullName + "[" + My.Computer.Info.OSVersion + "]" + vbNewLine +
            "Core architecture: " + CoreArchitecture + vbNewLine +
            "System time: " + My.Computer.Clock.LocalTime + vbNewLine +
            "System language: " + System.Globalization.CultureInfo.CurrentCulture.EnglishName.ToString + vbNewLine +
            "Physical memory: " + Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1073741824, 2).ToString + " GB / " + Math.Round(My.Computer.Info.TotalPhysicalMemory / 1073741824, 2).ToString + " GB" + vbNewLine +
            "Logical processors: " + Environment.ProcessorCount.ToString + vbNewLine +
            vbNewLine +
            "--------------------------------------------------" + vbNewLine +
            vbNewLine +
            "Error information:" + vbNewLine +
            vbNewLine +
            "Message: " + Message + vbNewLine +
            "HelpLink:" + Helplink + vbNewLine +
            vbNewLine +
            "--------------------------------------------------" + vbNewLine +
            vbNewLine +
            "CallStack: " + vbNewLine +
            Callstack + vbNewLine +
            vbNewLine +
            "--------------------------------------------------" + vbNewLine +
            vbNewLine +
            "You should report this error if it is reproduceable or you could not solve it by yourself." + vbNewLine +
            vbNewLine +
            "Go to: http://pokemon3d.net/forum/threads/8234/ to report this crash there." + vbNewLine +
            "Alternatively, if you have a GitHub account, you may report this crash at https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/issues/new/" + vbNewLine +
            "[/CODE]"
        If Not Directory.Exists(FileCheck.ApplicationDirectory + "\CrashLogs") Then
            Directory.CreateDirectory(FileCheck.ApplicationDirectory + "\CrashLogs")
        End If
        File.WriteAllText(FileCheck.ApplicationDirectory + "\CrashLogs\Crash_" + (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds.ToString + ".dat", ErrorLog)
        MsgBox(Message + vbNewLine + "Error Log saved at: " + FileCheck.ApplicationDirectory + "\CrashLogs\Crash_" + (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds.ToString + ".dat")
        FileCheck.AddLog(Message + vbNewLine + "Error Log saved at: " + FileCheck.ApplicationDirectory + "\CrashLogs\Crash_" + (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds.ToString + ".dat")
    End Sub

    Public Shared Sub ReturnMessage(ByVal Message As String)
        PlaySystemSound()
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

    Public Shared Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound( _
            System.Media.SystemSounds.Asterisk)
    End Sub
End Class