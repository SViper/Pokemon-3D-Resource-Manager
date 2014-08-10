Imports System.Net

Public Class FileCheck
    Private Sub FileCheck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AppSettings.CheckSetting()
    End Sub

    Private Sub InstalledContents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles InstalledContents.SelectedIndexChanged
        Dim str1 = InstalledContents.GetItemText(InstalledContents.SelectedItem)
        NewVersionInfo.ResetText()
        Button2.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
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
        InstalledContents.ResetText()
        InfoTextBox.Clear()
        VersionInfo.ResetText()
        NewVersionInfo.ResetText()
        Dim client As WebClient = New WebClient()
        Dim DownloadedContent As String = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Supported%20Files.txt")
        ShowLog("Get Supported Content From Server" + vbNewLine + DownloadedContent)
        Dim CurrentIndex As Integer = 0
        Dim SupportedContentPack As String = DownloadedContent
        Do While CurrentIndex < SupportedContentPack.LastIndexOf("|")
            If (System.IO.Directory.Exists(Directory & "\Pokemon\ContentPacks\")) Then
                Dim CurrentContentPack As String = Functions.GetSplit(SupportedContentPack, CurrentIndex, "|")
                If (System.IO.Directory.Exists(Directory & "\Pokemon\ContentPacks\" & CurrentContentPack) And Not InstalledContents.Items.Contains(CurrentContentPack)) Then
                    InstalledContents.Items.Add(CurrentContentPack)
                    ShowLog("Found " + CurrentContentPack)
                End If
                CurrentIndex = CurrentIndex + 1
            Else
                Exit Do
            End If
        Loop
        Button2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub

    Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound( _
            System.Media.SystemSounds.Asterisk)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim client As WebClient = New WebClient()
        Dim DownloadedContent As String = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Resource%20Files.txt")
        ShowLog("Get Version From Server" + vbNewLine + DownloadedContent)
        If (DownloadedContent.Contains(InstalledContents.Text)) Then
            Dim newversion As String = Functions.GetSplit(DownloadedContent.Substring(DownloadedContent.IndexOf(InstalledContents.Text)), 1, "|")
            Dim oldversion As String = VersionInfo.Text.Remove(VersionInfo.Text.Length.ToString - 1)
            NewVersionInfo.Text = newversion
            ShowLog("Comparing Version for " + InstalledContents.Text)
            ShowLog("Local File: " + oldversion)
            ShowLog("Server File: " + newversion)
            If (oldversion = newversion) Then
                PlaySystemSound()
                MsgBox("No new update available.")
            Else
                PlaySystemSound()
                MsgBox("There is update available for this Content Packs / GameModes.")
            End If
        Else
            PlaySystemSound()
            MsgBox("Could not retrive from server.")
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PlaySystemSound()
        Uninstall.UninstallContentname(InstalledContents.Text)
        If (Uninstall.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            My.Computer.FileSystem.DeleteDirectory(TextBox1.Text & "\Pokemon\ContentPacks\" & InstalledContents.Text, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
            ResourceCheck(TextBox1.Text)
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ResourceCheck(TextBox1.Text)
    End Sub
End Class