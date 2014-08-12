﻿Imports System.Windows.Forms
Imports System.Net
Imports RARNET
Imports Ionic.Zip

Public Class Downloader

    Private client As WebClient = New WebClient
    Private DownloadStatus As String
    Private ContentType As String
    Private DownloadLocation As String
    Private DownloadURL As String
    Private DownloadFileName As String
    Dim d As Decompressor

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim DownloadedContent As String = ""
            If (Me.ContentType = "ContentPacks") Then
                DownloadedContent = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/Content%20Pack%20Resource%20Files.txt")

            ElseIf (Me.ContentType = "GameModes") Then
                DownloadedContent = client.DownloadString("https://github.com/jianmingyong/Pokemon-3D-Resource-Manager/raw/master/Server%20Files/GameMode%20Resource%20Files.txt")
            End If
            If (DownloadedContent.Contains(ContentName.Text)) Then
                Me.DownloadURL = Functions.GetSplit(DownloadedContent.Substring(DownloadedContent.IndexOf(ContentName.Text)), 2, "|")
                Me.DownloadFileName = Functions.GetSplit(DownloadedContent.Substring(DownloadedContent.IndexOf(ContentName.Text)), 3, "|")
                AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
                AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                Try
                    client.DownloadFileAsync(New Uri(Me.DownloadURL), Me.DownloadLocation + Me.DownloadFileName)
                    OK_Button.Enabled = False
                    Cancel_Button.Enabled = False
                    Threading.Thread.Sleep(500)
                    Cancel_Button.Enabled = True
                Catch ex As Exception
                    FileCheck.PlaySystemSound()
                    MsgBox(ex.Message.ToString)
                    FileCheck.ShowLog(ex.Message.ToString)
                End Try
            Else
                FileCheck.PlaySystemSound()
                MsgBox("Could not retrive from server.")
                FileCheck.ShowLog("Could not retrive from server")
            End If
        Catch ex As Exception
            FileCheck.PlaySystemSound()
            MsgBox(ex.Message.ToString)
            FileCheck.ShowLog(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.client.CancelAsync()
        Me.DownloadStatus = "Cancel"
        Me.Close()
    End Sub

    Public Sub DownloadContentname(ByVal str1 As String, ByVal str2 As String, ByVal str3 As String, ByVal str4 As String, ByVal str5 As String)
        TextName.Text = "Download the latest " + str1 + " Files for " + str2 + "?"
        ContentName.Text = str2
        VersionInfo.Text = str3
        NewVersionInfo.Text = str4
        Me.ContentType = str1
        If (Me.ContentType = "ContentPacks") Then
            Me.DownloadLocation = str5 + "\Pokemon\ContentPacks\"
        ElseIf (Me.ContentType = "GameModes") Then
            Me.DownloadLocation = str5 + "\Pokemon\GameModes\"
        End If
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        StatusText.Text = "Downloading: " + Math.Round((bytesIn / 1048576), 2).ToString + " MB / " + Math.Round((totalBytes / 1048576), 2).ToString + " MB ( " + Math.Round(percentage, 2).ToString + " % )"
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        If (Not Me.DownloadStatus = "Cancel") Then
            Status.Text = "Status: Download Completed."
            extractfile()
        End If
    End Sub

    Private Sub extractfile()
        Me.Cursor = Cursors.WaitCursor
        StatusText.AppendText(vbNewLine + "Extracting Files...")
        If (Me.DownloadFileName.Contains(".rar") Or Me.DownloadFileName.Contains(".RAR")) Then
            Try
                d = New Decompressor(Me.DownloadLocation + Me.DownloadFileName)
                For Each r As Decompressor.RAREntry In d.RARFiles
                    d.UnPack(r.FileName.ToString(), Me.DownloadLocation)
                    StatusText.AppendText(vbNewLine + r.FileName.ToString)
                Next
                System.IO.File.Delete(Me.DownloadLocation + Me.DownloadFileName)
                StatusText.AppendText(vbNewLine + "Extracting Completed!")
            Catch ex As Exception
                FileCheck.PlaySystemSound()
                MsgBox(ex.Message)
                StatusText.AppendText(vbNewLine + ex.Message.ToString)
                FileCheck.ShowLog(ex.Message.ToString)
            End Try
        ElseIf (Me.DownloadFileName.Contains(".zip") Or Me.DownloadFileName.Contains(".ZIP")) Then
            Try
                Using zip As ZipFile = ZipFile.Read(DownloadLocation + Me.DownloadFileName)
                    Dim e As ZipEntry
                    For Each e In zip
                        e.Extract(Me.DownloadLocation, ExtractExistingFileAction.OverwriteSilently)
                        StatusText.AppendText(vbNewLine + e.FileName.ToString)
                    Next
                End Using
                System.IO.File.Delete(Me.DownloadLocation + Me.DownloadFileName)
                StatusText.AppendText(vbNewLine + "Extracting Completed!")
            Catch ex As Exception
                FileCheck.PlaySystemSound()
                MsgBox(ex.Message)
                StatusText.AppendText(vbNewLine + ex.Message.ToString)
                FileCheck.ShowLog(ex.Message.ToString)
            End Try
        Else
            MsgBox("The File Extraction class does not support this file." + vbNewLine + "Extract Failed.")
            StatusText.AppendText(vbNewLine + "The File Extraction class does not support this file." + vbNewLine + "Extract Failed.")
            FileCheck.ShowLog("The File Extraction class does not support this file." + vbNewLine + "Extract Failed.")
        End If
        Me.Cursor = Cursors.Default
        OK_Button.Enabled = True
        Cancel_Button.Enabled = True
    End Sub

End Class
