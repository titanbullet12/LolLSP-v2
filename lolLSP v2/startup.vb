Imports System.IO.Compression
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class startup

    ' Code by Titan_Bullet. \u\titan_bullet on reddit. August 2014. Made for reddit.
    Dim Opened As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.FileSystem.CreateDirectory("C:\Riot Games\Titan_Bullet")
        My.Computer.FileSystem.CreateDirectory("C:\Riot Games\Titan_Bullet\check")
        My.Computer.FileSystem.CreateDirectory("C:\Riot Games\Titan_Bullet\SWF")
        My.Computer.FileSystem.CreateDirectory("C:\Riot Games\Titan_Bullet\Backup")
        My.Computer.FileSystem.CreateDirectory("C:\Riot Games\Titan_Bullet\Downloads")
        My.Computer.FileSystem.CreateDirectory("C:\Riot Games\Titan_Bullet\Backup\currentbackup")

        ' This checks if this form has loaded before
        If IO.File.Exists("C:\Riot Games\Titan_Bullet\check\opened.txt") Then Opened = True Else Opened = False
        'If it is opened,then it loads the form "main"
        If Opened = True Then MAIN.Show()
        ' This creates the file opened.txt
        IO.File.Create("C:\Riot Games\Titan_Bullet\check\opened.txt")
        MAIN.Show()
        Me.Close()




    End Sub


End Class
