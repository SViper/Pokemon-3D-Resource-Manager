Imports System.Windows.Forms
Imports System.Net
Imports System.IO

Public Class CheckForUpdate

    Public CurrentResource As Integer
    Public TotalResource As Integer
    Public Percentage As Integer
    Public ResourceList As String
    Public ResourceName As String
    Public DownloadURL As String
    Public DownloadString As String

    Private Sub CheckForUpdate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Run()
    End Sub

    Private Sub Run()
        Try
            AddLog("Download Resource String From Server")
            ResourceList = Main.client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/ResourcesList.dat")
            AddLog("Checking for Cache Folder")
            If Not Directory.Exists(Main.ApplicationDirectory + "\Cache") Then
                Directory.CreateDirectory(Main.ApplicationDirectory + "\Cache")
                AddLog("Cache Folder created at: " + Main.ApplicationDirectory + "\Cache")
            End If
            If File.Exists(Main.ApplicationDirectory + "\Cache\ResourcesList.dat") Then
                File.Delete(Main.ApplicationDirectory + "\Cache\ResourcesList.dat")
            End If
            File.WriteAllText(Main.ApplicationDirectory + "\Cache\ResourcesList.dat", ResourceList, System.Text.Encoding.UTF8)
            AddLog("Save all text into the Cache for offline use.")
            CurrentResource = 1
            TotalResource = File.ReadAllLines(Main.ApplicationDirectory + "\Cache\ResourcesList.dat").Length - 1
            ProgressBar1.Value = 0
            AddLog("Download Resource File From Server")
            If Directory.Exists(Main.ApplicationDirectory + "\Cache\Resources") Then
                Directory.Delete(Main.ApplicationDirectory + "\Cache\Resources", True)
            End If
            Directory.CreateDirectory(Main.ApplicationDirectory + "\Cache\Resources")
            AddLog("Cache Folder created at: " + Main.ApplicationDirectory + "\Cache\Resources")
            Do While Not CurrentResource > TotalResource
                StatusText.Focus()
                DownloadURL = Functions.GetSplit(Functions.GetTextFromLine(Main.ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentResource + 1), 1, "|")
                ResourceName = Functions.GetSplit(Functions.GetTextFromLine(Main.ApplicationDirectory + "\Cache\ResourcesList.dat", CurrentResource + 1), 0, "|")
                AddLog("Downloading " + ResourceName)
                DownloadString = Main.client.DownloadString(DownloadURL)
                File.WriteAllText(Main.ApplicationDirectory + "\Cache\Resources\" + ResourceName + ".dat", DownloadString, System.Text.Encoding.UTF8)
                Percentage = Math.Round(CurrentResource / TotalResource * 100).ToString
                ProgressBar1.Value = Percentage
                CurrentResource = CurrentResource + 1
                Application.DoEvents()
            Loop
        Catch ex As Exception
            Functions.ReturnError(ex.Message, ex.HelpLink, ex.StackTrace)
        End Try
        Close()
    End Sub

#Region "Logger"
    Public Sub AddLog(ByVal Message As String)
        If (StatusText.TextLength = 0) Then
            StatusText.Text = "> " + Message
        Else
            StatusText.AppendText(vbNewLine + "> " + Message)
        End If
    End Sub
#End Region

End Class
