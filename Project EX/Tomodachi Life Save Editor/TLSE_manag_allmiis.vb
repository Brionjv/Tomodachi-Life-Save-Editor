Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_manag_allmiis
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Mii_1 As String
    Dim Miidetected As String
    Dim TLAMII As String

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red_tl
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close_tl
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseDown, TLSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TLSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseUp, TLSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TLSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseMove, TLSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Minimizebutton_Click(sender As Object, e As EventArgs) Handles Minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimizebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Minimizebutton.MouseMove
        Minimizebutton.Image = My.Resources.minimize_gray
    End Sub

    Private Sub Minimizebutton_MouseLeave(sender As Object, e As EventArgs) Handles Minimizebutton.MouseLeave
        Minimizebutton.Image = My.Resources.minimize
    End Sub

    'form menu
    Private Sub Icon_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu.MouseMove
        Icon_menu.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu.MouseLeave
        Icon_menu.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_Click(sender As Object, e As EventArgs) Handles Icon_menu.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        Me.Close()
    End Sub

    Private Sub TLSE_manag_allmiis_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ReadAllMii()
        DetectMiiregistered()
    End Sub

    Private Sub TLSE_manag_allmiis_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Setting_Advhelp.Checked = My.Settings.Para_AdvH
            Setting_ckupdate.Checked = My.Settings.Para_chkupdate
            Setting_hidden.Checked = My.Settings.Para_hidden
            Setting_music.Checked = My.Settings.Para_music
            Setting_filepath.Checked = My.Settings.Para_path
            Setting_spesymb.Checked = My.Settings.Para_spesymb
            Select_language.SelectedItem = My.Settings.Para_language
            Select_music.SelectedItem = My.Settings.Para_selmusic
        Catch ex As Exception
        End Try
        TLSE_filepath.Text = TLSE_hub.TLSE_filepath.Text
        Filever_text.Text = TLSE_hub.Filever_text.Text
        savedataArc = TLSE_filepath.Text
    End Sub

    Public Sub ReadAllMii()
        If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
            Mii_1 = &H1C70
            Text_extract_allMii.MaxLength = &H27D80
        End If
        If Filever_text.Text = "JP" Then
            Mii_1 = &H1C40
            Text_extract_allMii.MaxLength = &H22C40
        End If
        Try
            Dim ReadMiiData As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            ReadMiiData.Position = Mii_1
            Text_extract_allMii.Text = ReadMiiData.ReadHexString(Text_extract_allMii.MaxLength)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read all Miis, retry or report this issue" & vbNewLine & "Make sure you have opened a save file"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub DetectMiiregistered()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = &H22C8
                Miidetected = Reader.ReadByte
                Reader.Position = &H22C8 + &H660
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 2)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 3)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 4)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 5)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 6)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 7)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 8)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 9)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 10)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 11)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 12)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 13)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 14)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 15)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 16)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 17)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 18)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 19)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 20)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 21)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 22)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 23)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 24)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 25)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 26)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 27)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 28)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 29)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 30)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 31)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 32)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 33)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 34)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 35)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 36)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 37)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 38)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 39)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 40)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 41)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 42)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 43)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 44)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 45)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 46)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 47)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 48)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 49)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 50)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 51)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 52)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 53)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 54)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 55)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 56)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 57)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 58)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 59)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 60)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 61)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 62)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 63)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 64)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 65)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 66)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 67)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 68)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 69)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 70)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 71)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 72)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 73)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 74)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 75)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 76)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 77)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 78)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 79)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 80)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 81)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 82)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 83)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 84)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 85)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 86)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 87)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 88)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 89)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 90)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 91)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 92)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 93)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 94)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 95)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 96)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 97)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 98)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 99)
                Miidetected = Miidetected + Reader.ReadByte
                valu_lastmii.Value = Miidetected
            End If
            If Filever_text.Text = "JP" Then
                Reader.Position = &H21C8
                Miidetected = Reader.ReadByte
                Reader.Position = &H21C8 + &H590
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 2)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 3)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 4)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 5)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 6)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 7)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 8)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 9)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 10)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 11)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 12)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 13)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 14)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 15)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 16)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 17)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 18)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 19)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 20)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 21)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 22)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 23)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 24)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 25)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 26)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 27)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 28)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 29)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 30)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 31)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 32)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 33)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 34)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 35)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 36)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 37)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 38)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 39)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 40)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 41)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 42)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 43)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 44)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 45)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 46)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 47)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 48)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 49)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 50)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 51)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 52)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 53)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 54)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 55)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 56)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 57)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 58)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 59)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 60)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 61)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 62)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 63)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 64)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 65)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 66)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 67)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 68)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 69)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 70)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 71)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 72)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 73)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 74)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 75)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 76)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 77)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 78)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 79)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 80)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 81)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 82)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 83)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 84)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 85)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 86)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 87)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 88)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 89)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 90)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 91)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 92)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 93)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 94)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 95)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 96)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 97)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 98)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 99)
                Miidetected = Miidetected + Reader.ReadByte
                valu_lastmii.Value = Miidetected
            End If
            Text_miidetected.Text = "X " + Miidetected
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to detect Mii in this save file"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Échec de la détection des Mii dans ce fichier de sauvegarde"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Text_extract_Click(sender As Object, e As EventArgs) Handles Text_extract.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Tomodachi Life All Mii|*.TLAMii"
            SaveFileDialog1.FileName = "All Miis(" & Filever_text.Text & ")" & "_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_extract_allMii.Text)
                TLSE_dialog.Text_TLSE_dialog.Text = "All Miis in your save file has been successfully extracted"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Miis extraction has failed, retry or report this issue" & vbNewLine & "Make sure you have opened a save file"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Menu_text_ext_miimanagement_Click(sender As Object, e As EventArgs) Handles Menu_text_ext_miimanagement.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_miimanagement.Visible = True
        Me.Close()
    End Sub

    Private Sub Text_restore_Click(sender As Object, e As EventArgs) Handles Text_restore.Click
        Try
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "All miis in your save file will be replace by all miis in .TLAMII file" & vbNewLine & "Do you want continue ?"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Tous vos Mii vont être remplacer par les Mii du fichier .TLAMII" & vbNewLine & "Voulez vous continuer ?"
            End If
            TLSE_dialog.Panel_Cancel.Visible = True
            TLSE_dialog.Panel_OK.Visible = True
            TLSE_dialog.ShowDialog()
            If TLSE_dialog.DialogResult = DialogResult.OK Then
                Dim open As New OpenFileDialog
                open.Filter = "Tomodachi Life All Miis|*.TLAMII"
                open.Title = "Open a Tomodachi Life all Miis file"
                open.ShowDialog()
                TLAMII = open.FileName
                If FileLen(TLAMII) = &H27D80 Then
                    If Filever_text.Text = "JP" Then
                        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                            TLSE_dialog.Text_TLSE_dialog.Text = "Invalid .TLAMII file, choose a .TLAMII file corresponding to your save file region or a valid file"
                        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                            TLSE_dialog.Text_TLSE_dialog.Text = "Fichier .TLAMII invalide, choisissez un fichier .TLAMII correspondant à la même région de votre sauvagarde"
                        End If
                        TLSE_dialog.ShowDialog()
                    Else
                        ReadTLAMII()
                        WriteTLAMII()
                    End If
                End If
                If FileLen(TLAMII) = &H22C40 Then
                    If Filever_text.Text = "JP" Then
                        ReadTLAMII()
                        WriteTLAMII()
                    Else
                        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                            TLSE_dialog.Text_TLSE_dialog.Text = "Invalid .TLAMII file, choose a .TLAMII file corresponding to your save file region or a valid file"
                        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                            TLSE_dialog.Text_TLSE_dialog.Text = "Fichier .TLAMII invalide, choisissez un fichier .TLAMII correspondant à la même région de votre sauvagarde"
                        End If
                        TLSE_dialog.ShowDialog()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ReadTLAMII()
        Try
            Dim ReadMiiData As New PackageIO.Reader(TLAMII, PackageIO.Endian.Little)
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                ReadMiiData.Position = &H0
                Text_restore_allMii.Text = ReadMiiData.ReadHexString(&H27D80)
            End If
            If Filever_text.Text = "JP" Then
                ReadMiiData.Position = &H0
                Text_restore_allMii.Text = ReadMiiData.ReadHexString(&H22C40)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this file, report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Échec de la lecture de ce fichier, signalez cette erreur"
            End If
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub WriteTLAMII()
        Try
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Mii_1 = &H1C70
            End If
            If Filever_text.Text = "JP" Then
                Mii_1 = &H1C40
            End If
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writer.Position = Mii_1
            Writer.WriteHexString(Text_restore_allMii.Text)
            TLSE_dialog.Text_TLSE_dialog.Text = "All Miis has been successfully replaced" & vbNewLine & "You will back to main menu"
            TLSE_dialog.ShowDialog()
            If TLSE_logo_update.Visible = True Then
                TLSE_hub.TLSE_logo_update.Visible = True
            End If
            TLSE_hub.Show()
            TLSE_hub.Filever_text.Text = Filever_text.Text
            TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
            Me.Close()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to replace all miis, report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Le remplacement des Mii a échoué, signalez cette erreur"
            End If
            TLSE_dialog.ShowDialog()
        End Try
    End Sub
End Class