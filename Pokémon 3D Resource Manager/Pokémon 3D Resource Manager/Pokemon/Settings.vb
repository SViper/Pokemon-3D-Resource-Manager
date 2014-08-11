Public Class AppSettings

    Public Shared Sub GetSetting(ByVal Status As String, ByVal Setting As String)
        If (Status = "True" And Not Setting = "") Then
            FileCheck.ShowLog("Get Application Settings.")
            Dim Setting3 As String = Functions.GetSplit(Setting, 2, "=")
            Dim Directory As String = Setting3.Remove(0, 1)
            FileCheck.Getdirectory(Directory)
        Else
            ChangeSetting(Pokémon3D.My.Application.Info.DirectoryPath)
        End If
    End Sub

    Public Shared Sub ChangeSetting(ByVal directory As String)
        Dim Setting1 As String = "[Setting]" + vbNewLine
        Dim Setting2 As String = "Version = v0.49.1" + vbNewLine
        Dim Setting3 As String = "Game Directory = " + directory
        FileCheck.ResourceCheck(directory)
        SaveSetting(Setting1 + Setting2 + Setting3)
    End Sub

    Public Shared Sub SaveSetting(ByVal Setting As String)
        System.IO.File.WriteAllText(Pokémon3D.My.Application.Info.DirectoryPath & "\Pokémon3DResourceManagerSetting.dat", Setting)
        FileCheck.ShowLog("Saved Application Settings.")
    End Sub

    Public Shared Sub CheckSetting()
        If (System.IO.File.Exists(Pokémon3D.My.Application.Info.DirectoryPath & "\Pokémon3DResourceManagerSetting.dat")) Then
            Dim Str1 As String = System.IO.File.ReadAllText(Pokémon3D.My.Application.Info.DirectoryPath & "\Pokémon3DResourceManagerSetting.dat")
            Dim Status As String = ""
            If (Not Str1.Contains("[Setting]")) Then
                Status = "False"
            End If
            If (Not Str1.Contains("Version = ")) Then
                Status = "False"
            End If
            If (Not Str1.Contains("Game Directory = ")) Then
                Status = "False"
            End If
            If (Status = "False") Then
                FileCheck.ShowLog("Failed to retrive settings.")
            Else
                Status = "True"
            End If
            GetSetting(Status, Str1)
        Else
            GetSetting("False", "")
        End If
    End Sub
End Class
