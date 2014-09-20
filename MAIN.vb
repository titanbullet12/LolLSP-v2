Imports System
Imports System.IO
Imports System.Text
Public Class MAIN


    Dim loginSDownloaded As Boolean
    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub champ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles champ.SelectedIndexChanged

    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Label3.Visible = True
        ' This is to prevent bugs
        If champ.Text = "" Then Me.Close()
        ' Checks if the swf is downloaded
        If IO.File.Exists("C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\login.swf") Then loginSDownloaded = True
        If loginSDownloaded = False Then
            IO.Directory.CreateDirectory("C:\Riot Games\Titan_Bullet\SWF\" & champ.Text)
            My.Computer.Network.DownloadFile(
    "http://lollsp.byethost11.com/swf/" & champ.Text & "/login.swf",
    "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\login.swf")
            My.Computer.Network.DownloadFile(
    "http://lollsp.byethost11.com/swf/" & champ.Text & "/LoginScreenIntro.mp3",
    "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\loginScreenIntro.mp3")
            My.Computer.Network.DownloadFile(
    "http://lollsp.byethost11.com/swf/" & champ.Text & "/LoginScreenLoop.mp3",
    "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\loginScreenLoop.mp3")
        End If

        ' Declarings!
        Dim LoginS As String = "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text
        Dim themepath As String = "C:\Riot Games\League of Legends\RADS\projects\lol_air_client\releases\0.0.1.110\deploy\mod\lgn\themes\loginEsportsSeason2014finals"
        Dim MusicPath As String = themepath & "\music"

        ' Deletes any previous Backup
    'Delete all files from the Directory
        Directory.Delete(themepath, True)
        IO.Directory.CreateDirectory(MusicPath)
        IO.Directory.CreateDirectory(themepath & "\flv")
        IO.Directory.CreateDirectory(themepath & "\png")
        
        My.Computer.FileSystem.CopyFile(LoginS & "\login.swf",
    themepath & "\cs_bg_champions.png",
    FileIO.UIOption.OnlyErrorDialogs,
    FileIO.UICancelOption.ThrowException)
        My.Computer.FileSystem.CopyFile(LoginS & "\LoginScreenLoop.mp3",
    themepath & "\music\LoginScreenLoop.mp3",
    FileIO.UIOption.OnlyErrorDialogs,
    FileIO.UICancelOption.ThrowException)
        My.Computer.FileSystem.CopyFile(LoginS & "\LoginScreenIntro.mp3",
    themepath & "\music\LoginScreenintro.mp3",
    FileIO.UIOption.OnlyErrorDialogs,
    FileIO.UICancelOption.ThrowException)
        MsgBox("Enjoy! lolLSP will now close.")
        Me.Close()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://github.com/titanbullet12/lolLSP")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        custommode.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        aboutme.Show()
    End Sub

    Private Sub LinkLabel1_Clicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.reddit.com/user/titan_bullet/")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Current version: 2")
        Process.Start("https://github.com/titanbullet12/lolLSP")

    End Sub
End Class