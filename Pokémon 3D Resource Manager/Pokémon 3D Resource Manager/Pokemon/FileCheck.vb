Imports System.Net

Public Class FileCheck
    Private Sub FileCheck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AppSettings.CheckSetting()
    End Sub

    Private Sub InstalledContents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles InstalledContents.SelectedIndexChanged
        Dim str1 = InstalledContents.GetItemText(InstalledContents.SelectedItem)
        ShowInfo(str1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath()
        ShowLog("Game Directory Points to: " + TextBox1.Text)
        AppSettings.ChangeSetting(TextBox1.Text)
    End Sub

    Public Sub ShowLog(ByVal strlog As String)
        If (Log.TextLength = 0) Then
            Log.Text = "> " + strlog
        Else
            Log.AppendText(vbNewLine + "> " + strlog)
        End If
    End Sub

    Public Sub ShowInfo(ByVal Selectindex As String)
        Dim info As String = System.IO.File.ReadAllText(TextBox1.Text & "\Pokemon\ContentPacks\" + Selectindex + "\info.dat")
        InfoTextBox.Text = info
        VersionInfo.Text = Functions.GetSplit(InfoTextBox.Text, 0, "jianmingyong")
    End Sub

    Public Sub Getdirectory(ByVal Directory As String)
        TextBox1.SelectedText = Directory
        ResourceCheck(Directory)
    End Sub

    Public Sub ResourceCheck(ByVal Directory As String)
        If (Not System.IO.File.Exists(Directory & "\Pokemon\Pokemon.exe")) Then
            PlaySystemSound()
            MsgBox("Error: Pokémon 3D Application file does not exist." + vbNewLine + "Please locate the Pokémon3D launcher folder in the setting.")
            ShowLog("Error: Pokémon 3D Application file does not exist.")
            ShowLog("Please locate the Pokémon3D launcher folder in the setting.")
        Else
            ShowLog("Pokémon3D Launcher Found.")
        End If
        InstalledContents.Items.Clear()
        If (System.IO.Directory.Exists(Directory & "\Pokemon\ContentPacks\")) Then
            If (System.IO.Directory.Exists(Directory & "\Pokemon\ContentPacks\Pokémon Universal 3D")) Then
                InstalledContents.Items.Add("Pokémon Universal 3D")
                ShowLog("Found Pokémon Universal 3D")
            End If
            If (System.IO.Directory.Exists(Directory & "\Pokemon\ContentPacks\HGSS Music Pack HD")) Then
                InstalledContents.Items.Add("HGSS Music Pack HD")
                ShowLog("Found HGSS Music Pack HD")
            End If
        End If
    End Sub

    Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound( _
            System.Media.SystemSounds.Asterisk)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim client As WebClient = New WebClient()
        Dim DownloadedContent As String = client.DownloadString("https://raw.githubusercontent.com/jianmingyong/Pokemon-3D-Content-Pack-Sources/master/version.txt")
        If (DownloadedContent.Contains(InstalledContents.Text) And Not InstalledContents.Text = "") Then
            Dim TrimContent As String = Functions.GetSplit(DownloadedContent.Substring(DownloadedContent.IndexOf(InstalledContents.Text)), 1, "=")
            Dim newversion As String = TrimContent.Remove(0, 1)
            Dim oldversion As String = VersionInfo.Text
            NewVersionInfo.Text = newversion
            ShowLog("Comparing Version for " + InstalledContents.Text)
            ShowLog("Local File: " + oldversion.Remove(oldversion.Length.ToString - 1))
            ShowLog("Server File: " + newversion)
            If (oldversion = newversion) Then
                MsgBox("No new update available.")
            Else
                MsgBox("There is update available for this Content Packs / GameModes.")
            End If
        Else
            NewVersionInfo.Text = "Could not retrive from server"
            ShowLog("Could not retrive from server")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If (System.IO.File.Exists(TextBox1.Text.ToString & "\Pokémon3D.exe")) Then
            Shell(TextBox1.Text.ToString & "\Pokémon3D.exe", AppWinStyle.NormalFocus)
            Close()
        End If
    End Sub
End Class