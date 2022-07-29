Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_miistatus
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Miidetected As String
    Dim Miilevel As String
    Dim Miiexperience As String
    Dim Haircolor As String
    Dim Pampered As String
    Dim Splurge As String
    Dim CatchphraseJ1 As String
    Dim CatchphraseJ2 As String
    Dim Catchphrase1 As String
    Dim Catchphrase2 As String
    Dim Catchphrase3 As String
    Dim Catchphrase4 As String
    Dim Catchphrase5 As String
    Dim Gesture_1 As String
    Dim Gesture_2 As String
    Dim Gesture_3 As String
    Dim Gesture_4 As String
    Dim Gesture_5 As String
    Dim Gesturej_2 As String

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

    Private Sub TLSE_miistatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Readmiiname()
    End Sub

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_Miiedition.Visible = True
        Me.Close()
    End Sub

    Public Sub Readmiiname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H1C5A
                Select_mii.Items.Item(0) = "Mii 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H21EA
                Select_mii.Items.Item(1) = "Mii 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H277A
                Select_mii.Items.Item(2) = "Mii 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2D0A
                Select_mii.Items.Item(3) = "Mii 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H329A
                Select_mii.Items.Item(4) = "Mii 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H382A
                Select_mii.Items.Item(5) = "Mii 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DBA
                Select_mii.Items.Item(6) = "Mii 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H434A
                Select_mii.Items.Item(7) = "Mii 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H48DA
                Select_mii.Items.Item(8) = "Mii 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E6A
                Select_mii.Items.Item(9) = "Mii 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53FA
                Select_mii.Items.Item(10) = "Mii 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H598A
                Select_mii.Items.Item(11) = "Mii 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5F1A
                Select_mii.Items.Item(12) = "Mii 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H64AA
                Select_mii.Items.Item(13) = "Mii 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H6A3A
                Select_mii.Items.Item(14) = "Mii 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H6FCA
                Select_mii.Items.Item(15) = "Mii 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H755A
                Select_mii.Items.Item(16) = "Mii 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H7AEA
                Select_mii.Items.Item(17) = "Mii 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H807A
                Select_mii.Items.Item(18) = "Mii 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H860A
                Select_mii.Items.Item(19) = "Mii 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H8B9A
                Select_mii.Items.Item(20) = "Mii 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H912A
                Select_mii.Items.Item(21) = "Mii 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H96BA
                Select_mii.Items.Item(22) = "Mii 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H9C4A
                Select_mii.Items.Item(23) = "Mii 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA1DA
                Select_mii.Items.Item(24) = "Mii 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA76A
                Select_mii.Items.Item(25) = "Mii 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HACFA
                Select_mii.Items.Item(26) = "Mii 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HB28A
                Select_mii.Items.Item(27) = "Mii 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HB81A
                Select_mii.Items.Item(28) = "Mii 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HBDAA
                Select_mii.Items.Item(29) = "Mii 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC33A
                Select_mii.Items.Item(30) = "Mii 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC8CA
                Select_mii.Items.Item(31) = "Mii 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HCE5A
                Select_mii.Items.Item(32) = "Mii 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HD3EA
                Select_mii.Items.Item(33) = "Mii 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HD97A
                Select_mii.Items.Item(34) = "Mii 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HDF0A
                Select_mii.Items.Item(35) = "Mii 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HE49A
                Select_mii.Items.Item(36) = "Mii 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HEA2A
                Select_mii.Items.Item(37) = "Mii 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HEFBA
                Select_mii.Items.Item(38) = "Mii 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HF54A
                Select_mii.Items.Item(39) = "Mii 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HFADA
                Select_mii.Items.Item(40) = "Mii 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1006A
                Select_mii.Items.Item(41) = "Mii 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H105FA
                Select_mii.Items.Item(42) = "Mii 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10B8A
                Select_mii.Items.Item(43) = "Mii 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1111A
                Select_mii.Items.Item(44) = "Mii 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H116AA
                Select_mii.Items.Item(45) = "Mii 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11C3A
                Select_mii.Items.Item(46) = "Mii 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H121CA
                Select_mii.Items.Item(47) = "Mii 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1275A
                Select_mii.Items.Item(48) = "Mii 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H12CEA
                Select_mii.Items.Item(49) = "Mii 50 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1327A
                Select_mii.Items.Item(50) = "Mii 51 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1380A
                Select_mii.Items.Item(51) = "Mii 52 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H13D9A
                Select_mii.Items.Item(52) = "Mii 53 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1432A
                Select_mii.Items.Item(53) = "Mii 54 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148BA
                Select_mii.Items.Item(54) = "Mii 55 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H14E4A
                Select_mii.Items.Item(55) = "Mii 56 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H153DA
                Select_mii.Items.Item(56) = "Mii 57 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1596A
                Select_mii.Items.Item(57) = "Mii 58 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H15EFA
                Select_mii.Items.Item(58) = "Mii 59 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1648A
                Select_mii.Items.Item(59) = "Mii 60 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H16A1A
                Select_mii.Items.Item(60) = "Mii 61 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H16FAA
                Select_mii.Items.Item(61) = "Mii 62 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1753A
                Select_mii.Items.Item(62) = "Mii 63 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H17ACA
                Select_mii.Items.Item(63) = "Mii 64 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1805A
                Select_mii.Items.Item(64) = "Mii 65 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H185EA
                Select_mii.Items.Item(65) = "Mii 66 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H18B7A
                Select_mii.Items.Item(66) = "Mii 67 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1910A
                Select_mii.Items.Item(67) = "Mii 68 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1969A
                Select_mii.Items.Item(68) = "Mii 69 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19C2A
                Select_mii.Items.Item(69) = "Mii 70 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A1BA
                Select_mii.Items.Item(70) = "Mii 71 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A74A
                Select_mii.Items.Item(71) = "Mii 72 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1ACDA
                Select_mii.Items.Item(72) = "Mii 73 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B26A
                Select_mii.Items.Item(73) = "Mii 74 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B7FA
                Select_mii.Items.Item(74) = "Mii 75 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BD8A
                Select_mii.Items.Item(75) = "Mii 76 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C31A
                Select_mii.Items.Item(76) = "Mii 77 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C8AA
                Select_mii.Items.Item(77) = "Mii 78 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1CE3A
                Select_mii.Items.Item(78) = "Mii 79 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1D3CA
                Select_mii.Items.Item(79) = "Mii 80 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1D95A
                Select_mii.Items.Item(80) = "Mii 81 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DEEA
                Select_mii.Items.Item(81) = "Mii 82 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E47A
                Select_mii.Items.Item(82) = "Mii 83 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EA0A
                Select_mii.Items.Item(83) = "Mii 84 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EF9A
                Select_mii.Items.Item(84) = "Mii 85 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1F52A
                Select_mii.Items.Item(85) = "Mii 86 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1FABA
                Select_mii.Items.Item(86) = "Mii 87 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2004A
                Select_mii.Items.Item(87) = "Mii 88 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H205DA
                Select_mii.Items.Item(88) = "Mii 89 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H20B6A
                Select_mii.Items.Item(89) = "Mii 90 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H210FA
                Select_mii.Items.Item(90) = "Mii 91 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2168A
                Select_mii.Items.Item(91) = "Mii 92 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H21C1A
                Select_mii.Items.Item(92) = "Mii 93 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H221AA
                Select_mii.Items.Item(93) = "Mii 94 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2273A
                Select_mii.Items.Item(94) = "Mii 95 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H22CCA
                Select_mii.Items.Item(95) = "Mii 96 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2325A
                Select_mii.Items.Item(96) = "Mii 97 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H237EA
                Select_mii.Items.Item(97) = "Mii 98 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H23D7A
                Select_mii.Items.Item(98) = "Mii 99 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2430A
                Select_mii.Items.Item(99) = "Mii 100 : " & Reader.ReadUnicodeString(10)
            Else
                Reader.Position = &H1C8A
                Select_mii.Items.Item(0) = "Mii 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H22EA
                Select_mii.Items.Item(1) = "Mii 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H294A
                Select_mii.Items.Item(2) = "Mii 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2FAA
                Select_mii.Items.Item(3) = "Mii 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H360A
                Select_mii.Items.Item(4) = "Mii 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C6A
                Select_mii.Items.Item(5) = "Mii 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H42CA
                Select_mii.Items.Item(6) = "Mii 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H492A
                Select_mii.Items.Item(7) = "Mii 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F8A
                Select_mii.Items.Item(8) = "Mii 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55EA
                Select_mii.Items.Item(9) = "Mii 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5C4A
                Select_mii.Items.Item(10) = "Mii 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H62AA
                Select_mii.Items.Item(11) = "Mii 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H690A
                Select_mii.Items.Item(12) = "Mii 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H6F6A
                Select_mii.Items.Item(13) = "Mii 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H75CA
                Select_mii.Items.Item(14) = "Mii 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H7C2A
                Select_mii.Items.Item(15) = "Mii 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H828A
                Select_mii.Items.Item(16) = "Mii 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H88EA
                Select_mii.Items.Item(17) = "Mii 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H8F4A
                Select_mii.Items.Item(18) = "Mii 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H95AA
                Select_mii.Items.Item(19) = "Mii 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H9C0A
                Select_mii.Items.Item(20) = "Mii 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA26A
                Select_mii.Items.Item(21) = "Mii 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA8CA
                Select_mii.Items.Item(22) = "Mii 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HAF2A
                Select_mii.Items.Item(23) = "Mii 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HB58A
                Select_mii.Items.Item(24) = "Mii 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HBBEA
                Select_mii.Items.Item(25) = "Mii 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC24A
                Select_mii.Items.Item(26) = "Mii 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC8AA
                Select_mii.Items.Item(27) = "Mii 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HCF0A
                Select_mii.Items.Item(28) = "Mii 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HD56A
                Select_mii.Items.Item(29) = "Mii 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HDBCA
                Select_mii.Items.Item(30) = "Mii 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HE22A
                Select_mii.Items.Item(31) = "Mii 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HE88A
                Select_mii.Items.Item(32) = "Mii 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HEEEA
                Select_mii.Items.Item(33) = "Mii 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HF54A
                Select_mii.Items.Item(34) = "Mii 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HFBAA
                Select_mii.Items.Item(35) = "Mii 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1020A
                Select_mii.Items.Item(36) = "Mii 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1086A
                Select_mii.Items.Item(37) = "Mii 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10ECA
                Select_mii.Items.Item(38) = "Mii 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1152A
                Select_mii.Items.Item(39) = "Mii 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11B8A
                Select_mii.Items.Item(40) = "Mii 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H121EA
                Select_mii.Items.Item(41) = "Mii 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1284A
                Select_mii.Items.Item(42) = "Mii 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H12EAA
                Select_mii.Items.Item(43) = "Mii 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1350A
                Select_mii.Items.Item(44) = "Mii 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H13B6A
                Select_mii.Items.Item(45) = "Mii 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H141CA
                Select_mii.Items.Item(46) = "Mii 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1482A
                Select_mii.Items.Item(47) = "Mii 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H14E8A
                Select_mii.Items.Item(48) = "Mii 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H154EA
                Select_mii.Items.Item(49) = "Mii 50 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H15B4A
                Select_mii.Items.Item(50) = "Mii 51 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H161AA
                Select_mii.Items.Item(51) = "Mii 52 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1680A
                Select_mii.Items.Item(52) = "Mii 53 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H16E6A
                Select_mii.Items.Item(53) = "Mii 54 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H174CA
                Select_mii.Items.Item(54) = "Mii 55 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H17B2A
                Select_mii.Items.Item(55) = "Mii 56 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1818A
                Select_mii.Items.Item(56) = "Mii 57 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H187EA
                Select_mii.Items.Item(57) = "Mii 58 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H18E4A
                Select_mii.Items.Item(58) = "Mii 59 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H194AA
                Select_mii.Items.Item(59) = "Mii 60 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19B0A
                Select_mii.Items.Item(60) = "Mii 61 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A16A
                Select_mii.Items.Item(61) = "Mii 62 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A7CA
                Select_mii.Items.Item(62) = "Mii 63 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AE2A
                Select_mii.Items.Item(63) = "Mii 64 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B48A
                Select_mii.Items.Item(64) = "Mii 65 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BAEA
                Select_mii.Items.Item(65) = "Mii 66 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C14A
                Select_mii.Items.Item(66) = "Mii 67 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C7AA
                Select_mii.Items.Item(67) = "Mii 68 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1CE0A
                Select_mii.Items.Item(68) = "Mii 69 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1D46A
                Select_mii.Items.Item(69) = "Mii 70 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DACA
                Select_mii.Items.Item(70) = "Mii 71 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E12A
                Select_mii.Items.Item(71) = "Mii 72 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E78A
                Select_mii.Items.Item(72) = "Mii 73 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EDEA
                Select_mii.Items.Item(73) = "Mii 74 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1F44A
                Select_mii.Items.Item(74) = "Mii 75 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1FAAA
                Select_mii.Items.Item(75) = "Mii 76 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2010A
                Select_mii.Items.Item(76) = "Mii 77 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2076A
                Select_mii.Items.Item(77) = "Mii 78 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H20DCA
                Select_mii.Items.Item(78) = "Mii 79 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2142A
                Select_mii.Items.Item(79) = "Mii 80 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H21A8A
                Select_mii.Items.Item(80) = "Mii 81 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H220EA
                Select_mii.Items.Item(81) = "Mii 82 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2274A
                Select_mii.Items.Item(82) = "Mii 83 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H22DAA
                Select_mii.Items.Item(83) = "Mii 84 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2340A
                Select_mii.Items.Item(84) = "Mii 85 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H23A6A
                Select_mii.Items.Item(85) = "Mii 86 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H240CA
                Select_mii.Items.Item(86) = "Mii 87 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2472A
                Select_mii.Items.Item(87) = "Mii 88 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H24D8A
                Select_mii.Items.Item(88) = "Mii 89 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H253EA
                Select_mii.Items.Item(89) = "Mii 90 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H25A4A
                Select_mii.Items.Item(90) = "Mii 91 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H260AA
                Select_mii.Items.Item(91) = "Mii 92 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2670A
                Select_mii.Items.Item(92) = "Mii 93 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H26D6A
                Select_mii.Items.Item(93) = "Mii 94 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H273CA
                Select_mii.Items.Item(94) = "Mii 95 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H27A2A
                Select_mii.Items.Item(95) = "Mii 96 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2808A
                Select_mii.Items.Item(96) = "Mii 97 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H286EA
                Select_mii.Items.Item(97) = "Mii 98 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H28D4A
                Select_mii.Items.Item(98) = "Mii 99 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H293AA
                Select_mii.Items.Item(99) = "Mii 100 : " & Reader.ReadUnicodeString(10)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read Mii names"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture des noms des Mii a échoué"
                TLSE_dialog.ShowDialog()
            End If
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

    Private Sub TLSE_miistatus_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DetectMiiregistered()
    End Sub

    Private Sub Button_close_hcoloredit_Click(sender As Object, e As EventArgs) Handles Button_close_hcoloredit.Click
        Panel_edit_haircolor.Visible = False
    End Sub

    Private Sub Icon_haircolor_Click(sender As Object, e As EventArgs) Handles Icon_haircolor.Click
        Panel_edit_haircolor.Visible = True
    End Sub

    Private Sub Icon_haircolor_MouseMove(sender As Object, e As EventArgs) Handles Icon_haircolor.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit hair color"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la couleur des cheveux"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_haircolor_MouseLeave(sender As Object, e As EventArgs) Handles Icon_haircolor.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub color_1_Click(sender As Object, e As EventArgs) Handles color_1.Click
        unselectcolor()
        color_1.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 128
    End Sub

    Private Sub color_2_Click(sender As Object, e As EventArgs) Handles color_2.Click
        unselectcolor()
        color_2.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 130
    End Sub

    Private Sub color_3_Click(sender As Object, e As EventArgs) Handles color_3.Click
        unselectcolor()
        color_3.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 132
    End Sub

    Private Sub color_4_Click(sender As Object, e As EventArgs) Handles color_4.Click
        unselectcolor()
        color_4.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 134
    End Sub

    Private Sub color_5_Click(sender As Object, e As EventArgs) Handles color_5.Click
        unselectcolor()
        color_5.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 136
    End Sub

    Private Sub color_6_Click(sender As Object, e As EventArgs) Handles color_6.Click
        unselectcolor()
        color_6.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 138
    End Sub

    Private Sub color_7_Click(sender As Object, e As EventArgs) Handles color_7.Click
        unselectcolor()
        color_7.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 140
    End Sub

    Private Sub color_8_Click(sender As Object, e As EventArgs) Handles color_8.Click
        unselectcolor()
        color_8.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 142
    End Sub

    Private Sub color_9_Click(sender As Object, e As EventArgs) Handles color_9.Click
        unselectcolor()
        color_9.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 144
    End Sub

    Private Sub color_10_Click(sender As Object, e As EventArgs) Handles color_10.Click
        unselectcolor()
        color_10.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 146
    End Sub

    Private Sub color_11_Click(sender As Object, e As EventArgs) Handles color_11.Click
        unselectcolor()
        color_11.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 148
    End Sub

    Private Sub color_12_Click(sender As Object, e As EventArgs) Handles color_12.Click
        unselectcolor()
        color_12.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 150
    End Sub

    Private Sub color_13_Click(sender As Object, e As EventArgs) Handles color_13.Click
        unselectcolor()
        color_13.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 152
    End Sub

    Private Sub color_14_Click(sender As Object, e As EventArgs) Handles color_14.Click
        unselectcolor()
        color_14.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 154
    End Sub

    Private Sub color_15_Click(sender As Object, e As EventArgs) Handles color_15.Click
        unselectcolor()
        color_15.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 156
    End Sub

    Private Sub color_16_Click(sender As Object, e As EventArgs) Handles color_16.Click
        unselectcolor()
        color_16.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 158
    End Sub

    Private Sub color_17_Click(sender As Object, e As EventArgs) Handles color_17.Click
        unselectcolor()
        color_17.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 160
    End Sub

    Private Sub color_18_Click(sender As Object, e As EventArgs) Handles color_18.Click
        unselectcolor()
        color_18.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 162
    End Sub

    Private Sub color_19_Click(sender As Object, e As EventArgs) Handles color_19.Click
        unselectcolor()
        color_19.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 164
    End Sub

    Private Sub color_20_Click(sender As Object, e As EventArgs) Handles color_20.Click
        unselectcolor()
        color_20.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 166
    End Sub

    Private Sub color_21_Click(sender As Object, e As EventArgs) Handles color_21.Click
        unselectcolor()
        color_21.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 168
    End Sub

    Private Sub color_22_Click(sender As Object, e As EventArgs) Handles color_22.Click
        unselectcolor()
        color_22.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 170
    End Sub

    Private Sub color_23_Click(sender As Object, e As EventArgs) Handles color_23.Click
        unselectcolor()
        color_23.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 172
    End Sub

    Private Sub color_24_Click(sender As Object, e As EventArgs) Handles color_24.Click
        unselectcolor()
        color_24.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 174
    End Sub

    Private Sub color_25_Click(sender As Object, e As EventArgs) Handles color_25.Click
        unselectcolor()
        color_25.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 176
    End Sub

    Private Sub color_26_Click(sender As Object, e As EventArgs) Handles color_26.Click
        unselectcolor()
        color_26.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 178
    End Sub

    Private Sub color_27_Click(sender As Object, e As EventArgs) Handles color_27.Click
        unselectcolor()
        color_27.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 180
    End Sub

    Private Sub color_28_Click(sender As Object, e As EventArgs) Handles color_28.Click
        unselectcolor()
        color_28.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 182
    End Sub

    Private Sub color_29_Click(sender As Object, e As EventArgs) Handles color_29.Click
        unselectcolor()
        color_29.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 184
    End Sub

    Private Sub color_30_Click(sender As Object, e As EventArgs) Handles color_30.Click
        unselectcolor()
        color_30.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 186
    End Sub

    Private Sub color_31_Click(sender As Object, e As EventArgs) Handles color_31.Click
        unselectcolor()
        color_31.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 188
    End Sub

    Private Sub color_32_Click(sender As Object, e As EventArgs) Handles color_32.Click
        unselectcolor()
        color_32.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 190
    End Sub

    Private Sub color_empty_Click(sender As Object, e As EventArgs) Handles color_empty.Click
        unselectcolor()
        color_empty.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 1
    End Sub

    Private Sub valu_haircolor_ValueChanged(sender As Object, e As EventArgs) Handles valu_haircolor.ValueChanged
        Select Case valu_haircolor.Value
            Case 128, 129
                Icon_haircolor.Image = My.Resources.HC80
            Case 130, 131
                Icon_haircolor.Image = My.Resources.HC82
            Case 132, 133
                Icon_haircolor.Image = My.Resources.HC84
            Case 134, 135
                Icon_haircolor.Image = My.Resources.HC86
            Case 136, 137
                Icon_haircolor.Image = My.Resources.HC88
            Case 138, 139
                Icon_haircolor.Image = My.Resources.HC8A
            Case 140, 141
                Icon_haircolor.Image = My.Resources.HC8C
            Case 142, 143
                Icon_haircolor.Image = My.Resources.HC8E
            Case 144, 145
                Icon_haircolor.Image = My.Resources.HC90
            Case 146, 147
                Icon_haircolor.Image = My.Resources.HC92
            Case 148, 149
                Icon_haircolor.Image = My.Resources.HC94
            Case 150, 151
                Icon_haircolor.Image = My.Resources.HC96
            Case 152, 153
                Icon_haircolor.Image = My.Resources.HC98
            Case 154, 155
                Icon_haircolor.Image = My.Resources.HC9A
            Case 156, 157
                Icon_haircolor.Image = My.Resources.HC9C
            Case 158, 159
                Icon_haircolor.Image = My.Resources.HC9E
            Case 160, 161
                Icon_haircolor.Image = My.Resources.HCA0
            Case 162, 163
                Icon_haircolor.Image = My.Resources.HCA2
            Case 164, 165
                Icon_haircolor.Image = My.Resources.HCA4
            Case 166, 167
                Icon_haircolor.Image = My.Resources.HCA6
            Case 168, 169
                Icon_haircolor.Image = My.Resources.HCA8
            Case 170, 171
                Icon_haircolor.Image = My.Resources.HCAA
            Case 172, 173
                Icon_haircolor.Image = My.Resources.HCAC
            Case 174, 175
                Icon_haircolor.Image = My.Resources.HCAE
            Case 176, 177
                Icon_haircolor.Image = My.Resources.HCB0
            Case 178, 179
                Icon_haircolor.Image = My.Resources.HCB2
            Case 180, 181
                Icon_haircolor.Image = My.Resources.HCB4
            Case 182, 183
                Icon_haircolor.Image = My.Resources.HCB6
            Case 184, 185
                Icon_haircolor.Image = My.Resources.HCB8
            Case 186, 187
                Icon_haircolor.Image = My.Resources.HCBA
            Case 188, 189
                Icon_haircolor.Image = My.Resources.HCBC
            Case 190, 191
                Icon_haircolor.Image = My.Resources.HCBE
            Case Else
                Icon_haircolor.Image = My.Resources.HCdefault
        End Select
    End Sub

    Public Sub Unselectcolor()
        color_1.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_empty.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Icon_ranking_pampered_Click(sender As Object, e As EventArgs) Handles Icon_ranking_pampered.Click
        valu_ranking_pampered.Value = valu_ranking_pampered.Maximum
    End Sub

    Private Sub Icon_ranking_splurge_Click(sender As Object, e As EventArgs) Handles Icon_ranking_splurge.Click
        valu_ranking_splurge.Value = valu_ranking_splurge.Maximum
    End Sub

    Private Sub valu_experience_ValueChanged(sender As Object, e As EventArgs) Handles valu_experience.ValueChanged
        If valu_experience.Value = 0 Then
            Icon_experience.Image = My.Resources.exp0
        End If
        If valu_experience.Value = 1 Then
            Icon_experience.Image = My.Resources.exp1
        End If
        If valu_experience.Value = 2 Then
            Icon_experience.Image = My.Resources.exp2
        End If
        If valu_experience.Value = 3 Then
            Icon_experience.Image = My.Resources.exp3
        End If
        If valu_experience.Value = 4 Then
            Icon_experience.Image = My.Resources.exp4
        End If
        If valu_experience.Value = 5 Then
            Icon_experience.Image = My.Resources.exp5
        End If
        If valu_experience.Value = 6 Then
            Icon_experience.Image = My.Resources.exp6
        End If
        If valu_experience.Value = 7 Then
            Icon_experience.Image = My.Resources.exp7
        End If
        If valu_experience.Value = 8 Then
            Icon_experience.Image = My.Resources.exp8
        End If
        If valu_experience.Value = 9 Then
            Icon_experience.Image = My.Resources.exp9
        End If
        If valu_experience.Value = 10 Then
            Icon_experience.Image = My.Resources.exp10
        End If
        If valu_experience.Value = 11 Then
            Icon_experience.Image = My.Resources.exp11
        End If
        If valu_experience.Value = 12 Then
            Icon_experience.Image = My.Resources.exp12
        End If
        If valu_experience.Value = 13 Then
            Icon_experience.Image = My.Resources.exp13
        End If
        If valu_experience.Value = 14 Then
            Icon_experience.Image = My.Resources.exp14
        End If
        If valu_experience.Value = 15 Then
            Icon_experience.Image = My.Resources.exp15
        End If
        If valu_experience.Value = 16 Then
            Icon_experience.Image = My.Resources.exp16
        End If
        If valu_experience.Value = 17 Then
            Icon_experience.Image = My.Resources.exp17
        End If
        If valu_experience.Value = 18 Then
            Icon_experience.Image = My.Resources.exp18
        End If
        If valu_experience.Value = 19 Then
            Icon_experience.Image = My.Resources.exp19
        End If
        If valu_experience.Value = 20 Then
            Icon_experience.Image = My.Resources.exp20
        End If
        If valu_experience.Value = 21 Then
            Icon_experience.Image = My.Resources.exp21
        End If
        If valu_experience.Value = 22 Then
            Icon_experience.Image = My.Resources.exp22
        End If
        If valu_experience.Value = 23 Then
            Icon_experience.Image = My.Resources.exp23
        End If
        If valu_experience.Value = 24 Then
            Icon_experience.Image = My.Resources.exp24
        End If
        If valu_experience.Value = 25 Then
            Icon_experience.Image = My.Resources.exp25
        End If
        If valu_experience.Value = 26 Then
            Icon_experience.Image = My.Resources.exp26
        End If
        If valu_experience.Value = 27 Then
            Icon_experience.Image = My.Resources.exp27
        End If
        If valu_experience.Value = 28 Then
            Icon_experience.Image = My.Resources.exp28
        End If
        If valu_experience.Value = 29 Then
            Icon_experience.Image = My.Resources.exp29
        End If
        If valu_experience.Value = 30 Then
            Icon_experience.Image = My.Resources.exp30
        End If
        If valu_experience.Value = 31 Then
            Icon_experience.Image = My.Resources.exp31
        End If
        If valu_experience.Value = 32 Then
            Icon_experience.Image = My.Resources.exp32
        End If
        If valu_experience.Value = 33 Then
            Icon_experience.Image = My.Resources.exp33
        End If
        If valu_experience.Value = 34 Then
            Icon_experience.Image = My.Resources.exp34
        End If
        If valu_experience.Value = 35 Then
            Icon_experience.Image = My.Resources.exp35
        End If
        If valu_experience.Value = 36 Then
            Icon_experience.Image = My.Resources.exp36
        End If
        If valu_experience.Value = 37 Then
            Icon_experience.Image = My.Resources.exp37
        End If
        If valu_experience.Value = 38 Then
            Icon_experience.Image = My.Resources.exp38
        End If
        If valu_experience.Value = 39 Then
            Icon_experience.Image = My.Resources.exp39
        End If
        If valu_experience.Value = 40 Then
            Icon_experience.Image = My.Resources.exp40
        End If
        If valu_experience.Value = 41 Then
            Icon_experience.Image = My.Resources.exp41
        End If
        If valu_experience.Value = 42 Then
            Icon_experience.Image = My.Resources.exp42
        End If
        If valu_experience.Value = 43 Then
            Icon_experience.Image = My.Resources.exp43
        End If
        If valu_experience.Value = 44 Then
            Icon_experience.Image = My.Resources.exp44
        End If
        If valu_experience.Value = 45 Then
            Icon_experience.Image = My.Resources.exp45
        End If
        If valu_experience.Value = 46 Then
            Icon_experience.Image = My.Resources.exp46
        End If
        If valu_experience.Value = 47 Then
            Icon_experience.Image = My.Resources.exp47
        End If
        If valu_experience.Value = 48 Then
            Icon_experience.Image = My.Resources.exp48
        End If
        If valu_experience.Value = 49 Then
            Icon_experience.Image = My.Resources.exp49
        End If
        If valu_experience.Value = 50 Then
            Icon_experience.Image = My.Resources.exp50
        End If
        If valu_experience.Value = 51 Then
            Icon_experience.Image = My.Resources.exp51
        End If
        If valu_experience.Value = 52 Then
            Icon_experience.Image = My.Resources.exp52
        End If
        If valu_experience.Value = 53 Then
            Icon_experience.Image = My.Resources.exp53
        End If
        If valu_experience.Value = 54 Then
            Icon_experience.Image = My.Resources.exp54
        End If
        If valu_experience.Value = 55 Then
            Icon_experience.Image = My.Resources.exp55
        End If
        If valu_experience.Value = 56 Then
            Icon_experience.Image = My.Resources.exp56
        End If
        If valu_experience.Value = 57 Then
            Icon_experience.Image = My.Resources.exp57
        End If
        If valu_experience.Value = 58 Then
            Icon_experience.Image = My.Resources.exp58
        End If
        If valu_experience.Value = 59 Then
            Icon_experience.Image = My.Resources.exp59
        End If
        If valu_experience.Value = 60 Then
            Icon_experience.Image = My.Resources.exp60
        End If
        If valu_experience.Value = 61 Then
            Icon_experience.Image = My.Resources.exp61
        End If
        If valu_experience.Value = 62 Then
            Icon_experience.Image = My.Resources.exp62
        End If
        If valu_experience.Value = 63 Then
            Icon_experience.Image = My.Resources.exp63
        End If
        If valu_experience.Value = 64 Then
            Icon_experience.Image = My.Resources.exp64
        End If
        If valu_experience.Value = 65 Then
            Icon_experience.Image = My.Resources.exp65
        End If
        If valu_experience.Value = 66 Then
            Icon_experience.Image = My.Resources.exp66
        End If
        If valu_experience.Value = 67 Then
            Icon_experience.Image = My.Resources.exp67
        End If
        If valu_experience.Value = 68 Then
            Icon_experience.Image = My.Resources.exp68
        End If
        If valu_experience.Value = 69 Then
            Icon_experience.Image = My.Resources.exp69
        End If
        If valu_experience.Value = 70 Then
            Icon_experience.Image = My.Resources.exp70
        End If
        If valu_experience.Value = 71 Then
            Icon_experience.Image = My.Resources.exp71
        End If
        If valu_experience.Value = 72 Then
            Icon_experience.Image = My.Resources.exp72
        End If
        If valu_experience.Value = 73 Then
            Icon_experience.Image = My.Resources.exp73
        End If
        If valu_experience.Value = 74 Then
            Icon_experience.Image = My.Resources.exp74
        End If
        If valu_experience.Value = 75 Then
            Icon_experience.Image = My.Resources.exp75
        End If
        If valu_experience.Value = 76 Then
            Icon_experience.Image = My.Resources.exp76
        End If
        If valu_experience.Value = 77 Then
            Icon_experience.Image = My.Resources.exp77
        End If
        If valu_experience.Value = 78 Then
            Icon_experience.Image = My.Resources.exp78
        End If
        If valu_experience.Value = 79 Then
            Icon_experience.Image = My.Resources.exp79
        End If
        If valu_experience.Value = 80 Then
            Icon_experience.Image = My.Resources.exp80
        End If
        If valu_experience.Value = 81 Then
            Icon_experience.Image = My.Resources.exp81
        End If
        If valu_experience.Value = 82 Then
            Icon_experience.Image = My.Resources.exp82
        End If
        If valu_experience.Value = 83 Then
            Icon_experience.Image = My.Resources.exp83
        End If
        If valu_experience.Value = 84 Then
            Icon_experience.Image = My.Resources.exp84
        End If
        If valu_experience.Value = 85 Then
            Icon_experience.Image = My.Resources.exp85
        End If
        If valu_experience.Value = 86 Then
            Icon_experience.Image = My.Resources.exp86
        End If
        If valu_experience.Value = 87 Then
            Icon_experience.Image = My.Resources.exp87
        End If
        If valu_experience.Value = 88 Then
            Icon_experience.Image = My.Resources.exp88
        End If
        If valu_experience.Value = 89 Then
            Icon_experience.Image = My.Resources.exp89
        End If
        If valu_experience.Value = 90 Then
            Icon_experience.Image = My.Resources.exp90
        End If
        If valu_experience.Value = 91 Then
            Icon_experience.Image = My.Resources.exp91
        End If
        If valu_experience.Value = 92 Then
            Icon_experience.Image = My.Resources.exp92
        End If
        If valu_experience.Value = 93 Then
            Icon_experience.Image = My.Resources.exp93
        End If
        If valu_experience.Value = 94 Then
            Icon_experience.Image = My.Resources.exp94
        End If
        If valu_experience.Value = 95 Then
            Icon_experience.Image = My.Resources.exp95
        End If
        If valu_experience.Value = 96 Then
            Icon_experience.Image = My.Resources.exp96
        End If
        If valu_experience.Value = 97 Then
            Icon_experience.Image = My.Resources.exp97
        End If
        If valu_experience.Value = 98 Then
            Icon_experience.Image = My.Resources.exp98
        End If
        If valu_experience.Value = 99 Then
            Icon_experience.Image = My.Resources.exp99
        End If
    End Sub

    Private Sub Icon_arrowexp_right_MouseDown(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_right.MouseDown
        If valu_experience.Value < 99 Then
            Timer_arrowexp_right.Start()
        End If
    End Sub

    Private Sub Timer_arrowexp_right_Tick(sender As Object, e As EventArgs) Handles Timer_arrowexp_right.Tick
        If valu_experience.Value < 99 Then
            valu_experience.Value = valu_experience.Value + 1
            Timer_arrowexp_right.Start()
        End If
    End Sub

    Private Sub Icon_arrowexp_right_MouseUp(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_right.MouseUp
        Timer_arrowexp_right.Stop()
    End Sub

    Private Sub Icon_arrowexp_right_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_right.MouseMove
        Icon_arrowexp_right.Image = My.Resources.icon_arrowexp_righton
    End Sub

    Private Sub Icon_arrowexp_right_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_right.MouseLeave
        Icon_arrowexp_right.Image = My.Resources.icon_arrowexp_right
    End Sub

    Private Sub Icon_arrowexp_left_MouseDown(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_left.MouseDown
        If valu_experience.Value > 0 Then
            Timer_arrowexp_left.Start()
        End If
    End Sub

    Private Sub Timer_arrowexp_left_Tick(sender As Object, e As EventArgs) Handles Timer_arrowexp_left.Tick
        If valu_experience.Value > 0 Then
            valu_experience.Value = valu_experience.Value - 1
            Timer_arrowexp_left.Start()
        End If
    End Sub

    Private Sub Icon_arrowexp_left_MouseUp(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_left.MouseUp
        Timer_arrowexp_left.Stop()
    End Sub

    Private Sub Icon_arrowexp_left_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_left.MouseMove
        Icon_arrowexp_left.Image = My.Resources.icon_arrowexp_lefton
    End Sub

    Private Sub Icon_arrowexp_left_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_left.MouseLeave
        Icon_arrowexp_left.Image = My.Resources.icon_arrowexp_left
    End Sub

    Private Sub Icon_arrowexp_maxleft_Click(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxleft.Click
        valu_experience.Value = valu_experience.Minimum
    End Sub

    Private Sub Icon_arrowexp_maxleft_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_maxleft.MouseMove
        Icon_arrowexp_maxleft.Image = My.Resources.icon_arrowexp_maxlefton
    End Sub

    Private Sub Icon_arrowexp_maxleft_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxleft.MouseLeave
        Icon_arrowexp_maxleft.Image = My.Resources.icon_arrowexp_maxleft
    End Sub

    Private Sub Icon_arrowexp_maxright_Click(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxright.Click
        valu_experience.Value = valu_experience.Maximum
    End Sub

    Private Sub Icon_arrowexp_maxright_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_maxright.MouseMove
        Icon_arrowexp_maxright.Image = My.Resources.icon_arrowexp_maxrighton
    End Sub

    Private Sub Icon_arrowexp_maxright_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxright.MouseLeave
        Icon_arrowexp_maxright.Image = My.Resources.icon_arrowexp_maxright
    End Sub

    Public Sub Savefileregion()
        If Filever_text.Text = "JP" Then
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Miilevel = &H1E23
                Miiexperience = &H1E22
                Haircolor = &H1CE3
                Pampered = &H1E24
                Splurge = &H21B0
                CatchphraseJ1 = &H1CE4
                CatchphraseJ2 = &H1CF0
                Catchphrase2 = &H1D94
                Catchphrase3 = &H1DB6
                Catchphrase4 = &H1DD8
                Catchphrase5 = &H1DFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Miilevel = &H23B3
                Miiexperience = &H23B2
                Haircolor = &H2273
                Pampered = &H23B4
                Splurge = &H2740
                CatchphraseJ1 = &H2274
                CatchphraseJ2 = &H2280
                Catchphrase2 = &H2324
                Catchphrase3 = &H2346
                Catchphrase4 = &H2368
                Catchphrase5 = &H238A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Miilevel = &H2943
                Miiexperience = &H2942
                Haircolor = &H2803
                Pampered = &H2944
                Splurge = &H2CD0
                CatchphraseJ1 = &H2804
                CatchphraseJ2 = &H2810
                Catchphrase2 = &H28B4
                Catchphrase3 = &H28D6
                Catchphrase4 = &H28F8
                Catchphrase5 = &H291A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Miilevel = &H2ED3
                Miiexperience = &H2ED2
                Haircolor = &H2D93
                Pampered = &H2ED4
                Splurge = &H3260
                CatchphraseJ1 = &H2D94
                CatchphraseJ2 = &H2DA0
                Catchphrase2 = &H2E44
                Catchphrase3 = &H2E66
                Catchphrase4 = &H2E88
                Catchphrase5 = &H2EAA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Miilevel = &H3463
                Miiexperience = &H3462
                Haircolor = &H3323
                Pampered = &H3464
                Splurge = &H37F0
                CatchphraseJ1 = &H3324
                CatchphraseJ2 = &H3330
                Catchphrase2 = &H33D4
                Catchphrase3 = &H33F6
                Catchphrase4 = &H3418
                Catchphrase5 = &H343A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Miilevel = &H39F3
                Miiexperience = &H39F2
                Haircolor = &H38B3
                Pampered = &H39F4
                Splurge = &H3D80
                CatchphraseJ1 = &H38B4
                CatchphraseJ2 = &H38C0
                Catchphrase2 = &H3964
                Catchphrase3 = &H3986
                Catchphrase4 = &H39A8
                Catchphrase5 = &H39CA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Miilevel = &H3F83
                Miiexperience = &H3F82
                Haircolor = &H3E43
                Pampered = &H3F84
                Splurge = &H4310
                CatchphraseJ1 = &H3E44
                CatchphraseJ2 = &H3E50
                Catchphrase2 = &H3EF4
                Catchphrase3 = &H3F16
                Catchphrase4 = &H3F38
                Catchphrase5 = &H3F5A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Miilevel = &H4513
                Miiexperience = &H4512
                Haircolor = &H43D3
                Pampered = &H4514
                Splurge = &H48A0
                CatchphraseJ1 = &H43D4
                CatchphraseJ2 = &H43E0
                Catchphrase2 = &H4484
                Catchphrase3 = &H44A6
                Catchphrase4 = &H44C8
                Catchphrase5 = &H44EA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Miilevel = &H4AA3
                Miiexperience = &H4AA2
                Haircolor = &H4963
                Pampered = &H4AA4
                Splurge = &H4E30
                CatchphraseJ1 = &H4964
                CatchphraseJ2 = &H4970
                Catchphrase2 = &H4A14
                Catchphrase3 = &H4A36
                Catchphrase4 = &H4A58
                Catchphrase5 = &H4A7A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Miilevel = &H5033
                Miiexperience = &H5032
                Haircolor = &H4EF3
                Pampered = &H5034
                Splurge = &H53C0
                CatchphraseJ1 = &H4EF4
                CatchphraseJ2 = &H4F00
                Catchphrase2 = &H4FA4
                Catchphrase3 = &H4FC6
                Catchphrase4 = &H4FE8
                Catchphrase5 = &H500A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Miilevel = &H55C3
                Miiexperience = &H55C2
                Haircolor = &H5483
                Pampered = &H55C4
                Splurge = &H5950
                CatchphraseJ1 = &H5484
                CatchphraseJ2 = &H5490
                Catchphrase2 = &H5534
                Catchphrase3 = &H5556
                Catchphrase4 = &H5578
                Catchphrase5 = &H559A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Miilevel = &H5B53
                Miiexperience = &H5B52
                Haircolor = &H5A13
                Pampered = &H5B54
                Splurge = &H5EE0
                CatchphraseJ1 = &H5A14
                CatchphraseJ2 = &H5A20
                Catchphrase2 = &H5AC4
                Catchphrase3 = &H5AE6
                Catchphrase4 = &H5B08
                Catchphrase5 = &H5B2A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Miilevel = &H60E3
                Miiexperience = &H60E2
                Haircolor = &H5FA3
                Pampered = &H60E4
                Splurge = &H6470
                CatchphraseJ1 = &H5FA4
                CatchphraseJ2 = &H5FB0
                Catchphrase2 = &H6054
                Catchphrase3 = &H6076
                Catchphrase4 = &H6098
                Catchphrase5 = &H60BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Miilevel = &H6673
                Miiexperience = &H6672
                Haircolor = &H6533
                Pampered = &H6674
                Splurge = &H6A00
                CatchphraseJ1 = &H6534
                CatchphraseJ2 = &H6540
                Catchphrase2 = &H65E4
                Catchphrase3 = &H6606
                Catchphrase4 = &H6628
                Catchphrase5 = &H664A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Miilevel = &H6C03
                Miiexperience = &H6C02
                Haircolor = &H6AC3
                Pampered = &H6C04
                Splurge = &H6F90
                CatchphraseJ1 = &H6AC4
                CatchphraseJ2 = &H6AD0
                Catchphrase2 = &H6B74
                Catchphrase3 = &H6B96
                Catchphrase4 = &H6BB8
                Catchphrase5 = &H6BDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Miilevel = &H7193
                Miiexperience = &H7192
                Haircolor = &H7053
                Pampered = &H7194
                Splurge = &H7520
                CatchphraseJ1 = &H7054
                CatchphraseJ2 = &H7060
                Catchphrase2 = &H7104
                Catchphrase3 = &H7126
                Catchphrase4 = &H7148
                Catchphrase5 = &H716A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Miilevel = &H7723
                Miiexperience = &H7722
                Haircolor = &H75E3
                Pampered = &H7724
                Splurge = &H7AB0
                CatchphraseJ1 = &H75E4
                CatchphraseJ2 = &H75F0
                Catchphrase2 = &H7694
                Catchphrase3 = &H76B6
                Catchphrase4 = &H76D8
                Catchphrase5 = &H76FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Miilevel = &H7CB3
                Miiexperience = &H7CB2
                Haircolor = &H7B73
                Pampered = &H7CB4
                Splurge = &H8040
                CatchphraseJ1 = &H7B74
                CatchphraseJ2 = &H7B80
                Catchphrase2 = &H7C24
                Catchphrase3 = &H7C46
                Catchphrase4 = &H7C68
                Catchphrase5 = &H7C8A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Miilevel = &H8243
                Miiexperience = &H8242
                Haircolor = &H8103
                Pampered = &H8244
                Splurge = &H85D0
                CatchphraseJ1 = &H8104
                CatchphraseJ2 = &H8110
                Catchphrase2 = &H81B4
                Catchphrase3 = &H81D6
                Catchphrase4 = &H81F8
                Catchphrase5 = &H821A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Miilevel = &H87D3
                Miiexperience = &H87D2
                Haircolor = &H8693
                Pampered = &H87D4
                Splurge = &H8B60
                CatchphraseJ1 = &H8694
                CatchphraseJ2 = &H86A0
                Catchphrase2 = &H8744
                Catchphrase3 = &H8766
                Catchphrase4 = &H8788
                Catchphrase5 = &H87AA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Miilevel = &H8D63
                Miiexperience = &H8D62
                Haircolor = &H8C23
                Pampered = &H8D64
                Splurge = &H90F0
                CatchphraseJ1 = &H8C24
                CatchphraseJ2 = &H8C30
                Catchphrase2 = &H8CD4
                Catchphrase3 = &H8CF6
                Catchphrase4 = &H8D18
                Catchphrase5 = &H8D3A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Miilevel = &H92F3
                Miiexperience = &H92F2
                Haircolor = &H91B3
                Pampered = &H92F4
                Splurge = &H9680
                CatchphraseJ1 = &H91B4
                CatchphraseJ2 = &H91C0
                Catchphrase2 = &H9264
                Catchphrase3 = &H9286
                Catchphrase4 = &H92A8
                Catchphrase5 = &H92CA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Miilevel = &H9883
                Miiexperience = &H9882
                Haircolor = &H9743
                Pampered = &H9884
                Splurge = &H9C10
                CatchphraseJ1 = &H9744
                CatchphraseJ2 = &H9750
                Catchphrase2 = &H97F4
                Catchphrase3 = &H9816
                Catchphrase4 = &H9838
                Catchphrase5 = &H985A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Miilevel = &H9E13
                Miiexperience = &H9E12
                Haircolor = &H9CD3
                Pampered = &H9E14
                Splurge = &HA1A0
                CatchphraseJ1 = &H9CD4
                CatchphraseJ2 = &H9CE0
                Catchphrase2 = &H9D84
                Catchphrase3 = &H9DA6
                Catchphrase4 = &H9DC8
                Catchphrase5 = &H9DEA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Miilevel = &HA3A3
                Miiexperience = &HA3A2
                Haircolor = &HA263
                Pampered = &HA3A4
                Splurge = &HA730
                CatchphraseJ1 = &HA264
                CatchphraseJ2 = &HA270
                Catchphrase2 = &HA314
                Catchphrase3 = &HA336
                Catchphrase4 = &HA358
                Catchphrase5 = &HA37A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Miilevel = &HA933
                Miiexperience = &HA932
                Haircolor = &HA7F3
                Pampered = &HA934
                Splurge = &HACC0
                CatchphraseJ1 = &HA7F4
                CatchphraseJ2 = &HA800
                Catchphrase2 = &HA8A4
                Catchphrase3 = &HA8C6
                Catchphrase4 = &HA8E8
                Catchphrase5 = &HA90A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Miilevel = &HAEC3
                Miiexperience = &HAEC2
                Haircolor = &HAD83
                Pampered = &HAEC4
                Splurge = &HB250
                CatchphraseJ1 = &HAD84
                CatchphraseJ2 = &HAD90
                Catchphrase2 = &HAE34
                Catchphrase3 = &HAE56
                Catchphrase4 = &HAE78
                Catchphrase5 = &HAE9A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Miilevel = &HB453
                Miiexperience = &HB452
                Haircolor = &HB313
                Pampered = &HB454
                Splurge = &HB7E0
                CatchphraseJ1 = &HB314
                CatchphraseJ2 = &HB320
                Catchphrase2 = &HB3C4
                Catchphrase3 = &HB3E6
                Catchphrase4 = &HB408
                Catchphrase5 = &HB42A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Miilevel = &HB9E3
                Miiexperience = &HB9E2
                Haircolor = &HB8A3
                Pampered = &HB9E4
                Splurge = &HBD70
                CatchphraseJ1 = &HB8A4
                CatchphraseJ2 = &HB8B0
                Catchphrase2 = &HB954
                Catchphrase3 = &HB976
                Catchphrase4 = &HB998
                Catchphrase5 = &HB9BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Miilevel = &HBF73
                Miiexperience = &HBF72
                Haircolor = &HBE33
                Pampered = &HBF74
                Splurge = &HC300
                CatchphraseJ1 = &HBE34
                CatchphraseJ2 = &HBE40
                Catchphrase2 = &HBEE4
                Catchphrase3 = &HBF06
                Catchphrase4 = &HBF28
                Catchphrase5 = &HBF4A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Miilevel = &HC503
                Miiexperience = &HC502
                Haircolor = &HC3C3
                Pampered = &HC504
                Splurge = &HC890
                CatchphraseJ1 = &HC3C4
                CatchphraseJ2 = &HC3D0
                Catchphrase2 = &HC474
                Catchphrase3 = &HC496
                Catchphrase4 = &HC4B8
                Catchphrase5 = &HC4DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Miilevel = &HCA93
                Miiexperience = &HCA92
                Haircolor = &HC953
                Pampered = &HCA94
                Splurge = &HCE20
                CatchphraseJ1 = &HC954
                CatchphraseJ2 = &HC960
                Catchphrase2 = &HCA04
                Catchphrase3 = &HCA26
                Catchphrase4 = &HCA48
                Catchphrase5 = &HCA6A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Miilevel = &HD023
                Miiexperience = &HD022
                Haircolor = &HCEE3
                Pampered = &HD024
                Splurge = &HD3B0
                CatchphraseJ1 = &HCEE4
                CatchphraseJ2 = &HCEF0
                Catchphrase2 = &HCF94
                Catchphrase3 = &HCFB6
                Catchphrase4 = &HCFD8
                Catchphrase5 = &HCFFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Miilevel = &HD5B3
                Miiexperience = &HD5B2
                Haircolor = &HD473
                Pampered = &HD5B4
                Splurge = &HD940
                CatchphraseJ1 = &HD474
                CatchphraseJ2 = &HD480
                Catchphrase2 = &HD524
                Catchphrase3 = &HD546
                Catchphrase4 = &HD568
                Catchphrase5 = &HD58A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Miilevel = &HDB43
                Miiexperience = &HDB42
                Haircolor = &HDA03
                Pampered = &HDB44
                Splurge = &HDED0
                CatchphraseJ1 = &HDA04
                CatchphraseJ2 = &HDA10
                Catchphrase2 = &HDAB4
                Catchphrase3 = &HDAD6
                Catchphrase4 = &HDAF8
                Catchphrase5 = &HDB1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Miilevel = &HE0D3
                Miiexperience = &HE0D2
                Haircolor = &HDF93
                Pampered = &HE0D4
                Splurge = &HE460
                CatchphraseJ1 = &HDF94
                CatchphraseJ2 = &HDFA0
                Catchphrase2 = &HE044
                Catchphrase3 = &HE066
                Catchphrase4 = &HE088
                Catchphrase5 = &HE0AA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Miilevel = &HE663
                Miiexperience = &HE662
                Haircolor = &HE523
                Pampered = &HE664
                Splurge = &HE9F0
                CatchphraseJ1 = &HE524
                CatchphraseJ2 = &HE530
                Catchphrase2 = &HE5D4
                Catchphrase3 = &HE5F6
                Catchphrase4 = &HE618
                Catchphrase5 = &HE63A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Miilevel = &HEBF3
                Miiexperience = &HEBF2
                Haircolor = &HEAB3
                Pampered = &HEBF4
                Splurge = &HEF80
                CatchphraseJ1 = &HEAB4
                CatchphraseJ2 = &HEAC0
                Catchphrase2 = &HEB64
                Catchphrase3 = &HEB86
                Catchphrase4 = &HEBA8
                Catchphrase5 = &HEBCA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Miilevel = &HF183
                Miiexperience = &HF182
                Haircolor = &HF043
                Pampered = &HF184
                Splurge = &HF510
                CatchphraseJ1 = &HF044
                CatchphraseJ2 = &HF050
                Catchphrase2 = &HF0F4
                Catchphrase3 = &HF116
                Catchphrase4 = &HF138
                Catchphrase5 = &HF15A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Miilevel = &HF713
                Miiexperience = &HF712
                Haircolor = &HF5D3
                Pampered = &HF714
                Splurge = &HFAA0
                CatchphraseJ1 = &HF5D4
                CatchphraseJ2 = &HF5E0
                Catchphrase2 = &HF684
                Catchphrase3 = &HF6A6
                Catchphrase4 = &HF6C8
                Catchphrase5 = &HF6EA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Miilevel = &HFCA3
                Miiexperience = &HFCA2
                Haircolor = &HFB63
                Pampered = &HFCA4
                Splurge = &H10030
                CatchphraseJ1 = &HFB64
                CatchphraseJ2 = &HFB70
                Catchphrase2 = &HFC14
                Catchphrase3 = &HFC36
                Catchphrase4 = &HFC58
                Catchphrase5 = &HFC7A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Miilevel = &H10233
                Miiexperience = &H10232
                Haircolor = &H100F3
                Pampered = &H10234
                Splurge = &H105C0
                CatchphraseJ1 = &H100F4
                CatchphraseJ2 = &H10100
                Catchphrase2 = &H101A4
                Catchphrase3 = &H101C6
                Catchphrase4 = &H101E8
                Catchphrase5 = &H1020A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Miilevel = &H107C3
                Miiexperience = &H107C2
                Haircolor = &H10683
                Pampered = &H107C4
                Splurge = &H10B50
                CatchphraseJ1 = &H10684
                CatchphraseJ2 = &H10690
                Catchphrase2 = &H10734
                Catchphrase3 = &H10756
                Catchphrase4 = &H10778
                Catchphrase5 = &H1079A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Miilevel = &H10D53
                Miiexperience = &H10D52
                Haircolor = &H10C13
                Pampered = &H10D54
                Splurge = &H110E0
                CatchphraseJ1 = &H10C14
                CatchphraseJ2 = &H10C20
                Catchphrase2 = &H10CC4
                Catchphrase3 = &H10CE6
                Catchphrase4 = &H10D08
                Catchphrase5 = &H10D2A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Miilevel = &H112E3
                Miiexperience = &H112E2
                Haircolor = &H111A3
                Pampered = &H112E4
                Splurge = &H11670
                CatchphraseJ1 = &H111A4
                CatchphraseJ2 = &H111B0
                Catchphrase2 = &H11254
                Catchphrase3 = &H11276
                Catchphrase4 = &H11298
                Catchphrase5 = &H112BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Miilevel = &H11873
                Miiexperience = &H11872
                Haircolor = &H11733
                Pampered = &H11874
                Splurge = &H11C00
                CatchphraseJ1 = &H11734
                CatchphraseJ2 = &H11740
                Catchphrase2 = &H117E4
                Catchphrase3 = &H11806
                Catchphrase4 = &H11828
                Catchphrase5 = &H1184A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Miilevel = &H11E03
                Miiexperience = &H11E02
                Haircolor = &H11CC3
                Pampered = &H11E04
                Splurge = &H12190
                CatchphraseJ1 = &H11CC4
                CatchphraseJ2 = &H11CD0
                Catchphrase2 = &H11D74
                Catchphrase3 = &H11D96
                Catchphrase4 = &H11DB8
                Catchphrase5 = &H11DDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Miilevel = &H12393
                Miiexperience = &H12392
                Haircolor = &H12253
                Pampered = &H12394
                Splurge = &H12720
                CatchphraseJ1 = &H12254
                CatchphraseJ2 = &H12260
                Catchphrase2 = &H12304
                Catchphrase3 = &H12326
                Catchphrase4 = &H12348
                Catchphrase5 = &H1236A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Miilevel = &H12923
                Miiexperience = &H12922
                Haircolor = &H127E3
                Pampered = &H12924
                Splurge = &H12CB0
                CatchphraseJ1 = &H127E4
                CatchphraseJ2 = &H127F0
                Catchphrase2 = &H12894
                Catchphrase3 = &H128B6
                Catchphrase4 = &H128D8
                Catchphrase5 = &H128FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Miilevel = &H12EB3
                Miiexperience = &H12EB2
                Haircolor = &H12D73
                Pampered = &H12EB4
                Splurge = &H13240
                CatchphraseJ1 = &H12D74
                CatchphraseJ2 = &H12D80
                Catchphrase2 = &H12E24
                Catchphrase3 = &H12E46
                Catchphrase4 = &H12E68
                Catchphrase5 = &H12E8A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Miilevel = &H13443
                Miiexperience = &H13442
                Haircolor = &H13303
                Pampered = &H13444
                Splurge = &H137D0
                CatchphraseJ1 = &H13304
                CatchphraseJ2 = &H13310
                Catchphrase2 = &H133B4
                Catchphrase3 = &H133D6
                Catchphrase4 = &H133F8
                Catchphrase5 = &H1341A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Miilevel = &H139D3
                Miiexperience = &H139D2
                Haircolor = &H13893
                Pampered = &H139D4
                Splurge = &H13D60
                CatchphraseJ1 = &H13894
                CatchphraseJ2 = &H138A0
                Catchphrase2 = &H13944
                Catchphrase3 = &H13966
                Catchphrase4 = &H13988
                Catchphrase5 = &H139AA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Miilevel = &H13F63
                Miiexperience = &H13F62
                Haircolor = &H13E23
                Pampered = &H13F64
                Splurge = &H142F0
                CatchphraseJ1 = &H13E24
                CatchphraseJ2 = &H13E30
                Catchphrase2 = &H13ED4
                Catchphrase3 = &H13EF6
                Catchphrase4 = &H13F18
                Catchphrase5 = &H13F3A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Miilevel = &H144F3
                Miiexperience = &H144F2
                Haircolor = &H143B3
                Pampered = &H144F4
                Splurge = &H14880
                CatchphraseJ1 = &H143B4
                CatchphraseJ2 = &H143C0
                Catchphrase2 = &H14464
                Catchphrase3 = &H14486
                Catchphrase4 = &H144A8
                Catchphrase5 = &H144CA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Miilevel = &H14A83
                Miiexperience = &H14A82
                Haircolor = &H14943
                Pampered = &H14A84
                Splurge = &H14E10
                CatchphraseJ1 = &H14944
                CatchphraseJ2 = &H14950
                Catchphrase2 = &H149F4
                Catchphrase3 = &H14A16
                Catchphrase4 = &H14A38
                Catchphrase5 = &H14A5A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Miilevel = &H15013
                Miiexperience = &H15012
                Haircolor = &H14ED3
                Pampered = &H15014
                Splurge = &H153A0
                CatchphraseJ1 = &H14ED4
                CatchphraseJ2 = &H14EE0
                Catchphrase2 = &H14F84
                Catchphrase3 = &H14FA6
                Catchphrase4 = &H14FC8
                Catchphrase5 = &H14FEA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Miilevel = &H155A3
                Miiexperience = &H155A2
                Haircolor = &H15463
                Pampered = &H155A4
                Splurge = &H15930
                CatchphraseJ1 = &H15464
                CatchphraseJ2 = &H15470
                Catchphrase2 = &H15514
                Catchphrase3 = &H15536
                Catchphrase4 = &H15558
                Catchphrase5 = &H1557A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Miilevel = &H15B33
                Miiexperience = &H15B32
                Haircolor = &H159F3
                Pampered = &H15B34
                Splurge = &H15EC0
                CatchphraseJ1 = &H159F4
                CatchphraseJ2 = &H15A00
                Catchphrase2 = &H15AA4
                Catchphrase3 = &H15AC6
                Catchphrase4 = &H15AE8
                Catchphrase5 = &H15B0A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Miilevel = &H160C3
                Miiexperience = &H160C2
                Haircolor = &H15F83
                Pampered = &H160C4
                Splurge = &H16450
                CatchphraseJ1 = &H15F84
                CatchphraseJ2 = &H15F90
                Catchphrase2 = &H16034
                Catchphrase3 = &H16056
                Catchphrase4 = &H16078
                Catchphrase5 = &H1609A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Miilevel = &H16653
                Miiexperience = &H16652
                Haircolor = &H16513
                Pampered = &H16654
                Splurge = &H169E0
                CatchphraseJ1 = &H16514
                CatchphraseJ2 = &H16520
                Catchphrase2 = &H165C4
                Catchphrase3 = &H165E6
                Catchphrase4 = &H16608
                Catchphrase5 = &H1662A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Miilevel = &H16BE3
                Miiexperience = &H16BE2
                Haircolor = &H16AA3
                Pampered = &H16BE4
                Splurge = &H16F70
                CatchphraseJ1 = &H16AA4
                CatchphraseJ2 = &H16AB0
                Catchphrase2 = &H16B54
                Catchphrase3 = &H16B76
                Catchphrase4 = &H16B98
                Catchphrase5 = &H16BBA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Miilevel = &H17173
                Miiexperience = &H17172
                Haircolor = &H17033
                Pampered = &H17174
                Splurge = &H17500
                CatchphraseJ1 = &H17034
                CatchphraseJ2 = &H17040
                Catchphrase2 = &H170E4
                Catchphrase3 = &H17106
                Catchphrase4 = &H17128
                Catchphrase5 = &H1714A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Miilevel = &H17703
                Miiexperience = &H17702
                Haircolor = &H175C3
                Pampered = &H17704
                Splurge = &H17A90
                CatchphraseJ1 = &H175C4
                CatchphraseJ2 = &H175D0
                Catchphrase2 = &H17674
                Catchphrase3 = &H17696
                Catchphrase4 = &H176B8
                Catchphrase5 = &H176DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Miilevel = &H17C93
                Miiexperience = &H17C92
                Haircolor = &H17B53
                Pampered = &H17C94
                Splurge = &H18020
                CatchphraseJ1 = &H17B54
                CatchphraseJ2 = &H17B60
                Catchphrase2 = &H17C04
                Catchphrase3 = &H17C26
                Catchphrase4 = &H17C48
                Catchphrase5 = &H17C6A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Miilevel = &H18223
                Miiexperience = &H18222
                Haircolor = &H180E3
                Pampered = &H18224
                Splurge = &H185B0
                CatchphraseJ1 = &H180E4
                CatchphraseJ2 = &H180F0
                Catchphrase2 = &H18194
                Catchphrase3 = &H181B6
                Catchphrase4 = &H181D8
                Catchphrase5 = &H181FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Miilevel = &H187B3
                Miiexperience = &H187B2
                Haircolor = &H18673
                Pampered = &H187B4
                Splurge = &H18B40
                CatchphraseJ1 = &H18674
                CatchphraseJ2 = &H18680
                Catchphrase2 = &H18724
                Catchphrase3 = &H18746
                Catchphrase4 = &H18768
                Catchphrase5 = &H1878A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Miilevel = &H18D43
                Miiexperience = &H18D42
                Haircolor = &H18C03
                Pampered = &H18D44
                Splurge = &H190D0
                CatchphraseJ1 = &H18C04
                CatchphraseJ2 = &H18C10
                Catchphrase2 = &H18CB4
                Catchphrase3 = &H18CD6
                Catchphrase4 = &H18CF8
                Catchphrase5 = &H18D1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Miilevel = &H192D3
                Miiexperience = &H192D2
                Haircolor = &H19193
                Pampered = &H192D4
                Splurge = &H19660
                CatchphraseJ1 = &H19194
                CatchphraseJ2 = &H191A0
                Catchphrase2 = &H19244
                Catchphrase3 = &H19266
                Catchphrase4 = &H19288
                Catchphrase5 = &H192AA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Miilevel = &H19863
                Miiexperience = &H19862
                Haircolor = &H19723
                Pampered = &H19864
                Splurge = &H19BF0
                CatchphraseJ1 = &H19724
                CatchphraseJ2 = &H19730
                Catchphrase2 = &H197D4
                Catchphrase3 = &H197F6
                Catchphrase4 = &H19818
                Catchphrase5 = &H1983A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Miilevel = &H19DF3
                Miiexperience = &H19DF2
                Haircolor = &H19CB3
                Pampered = &H19DF4
                Splurge = &H1A180
                CatchphraseJ1 = &H19CB4
                CatchphraseJ2 = &H19CC0
                Catchphrase2 = &H19D64
                Catchphrase3 = &H19D86
                Catchphrase4 = &H19DA8
                Catchphrase5 = &H19DCA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Miilevel = &H1A383
                Miiexperience = &H1A382
                Haircolor = &H1A243
                Pampered = &H1A384
                Splurge = &H1A710
                CatchphraseJ1 = &H1A244
                CatchphraseJ2 = &H1A250
                Catchphrase2 = &H1A2F4
                Catchphrase3 = &H1A316
                Catchphrase4 = &H1A338
                Catchphrase5 = &H1A35A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Miilevel = &H1A913
                Miiexperience = &H1A912
                Haircolor = &H1A7D3
                Pampered = &H1A914
                Splurge = &H1ACA0
                CatchphraseJ1 = &H1A7D4
                CatchphraseJ2 = &H1A7E0
                Catchphrase2 = &H1A884
                Catchphrase3 = &H1A8A6
                Catchphrase4 = &H1A8C8
                Catchphrase5 = &H1A8EA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Miilevel = &H1AEA3
                Miiexperience = &H1AEA2
                Haircolor = &H1AD63
                Pampered = &H1AEA4
                Splurge = &H1B230
                CatchphraseJ1 = &H1AD64
                CatchphraseJ2 = &H1AD70
                Catchphrase2 = &H1AE14
                Catchphrase3 = &H1AE36
                Catchphrase4 = &H1AE58
                Catchphrase5 = &H1AE7A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Miilevel = &H1B433
                Miiexperience = &H1B432
                Haircolor = &H1B2F3
                Pampered = &H1B434
                Splurge = &H1B7C0
                CatchphraseJ1 = &H1B2F4
                CatchphraseJ2 = &H1B300
                Catchphrase2 = &H1B3A4
                Catchphrase3 = &H1B3C6
                Catchphrase4 = &H1B3E8
                Catchphrase5 = &H1B40A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Miilevel = &H1B9C3
                Miiexperience = &H1B9C2
                Haircolor = &H1B883
                Pampered = &H1B9C4
                Splurge = &H1BD50
                CatchphraseJ1 = &H1B884
                CatchphraseJ2 = &H1B890
                Catchphrase2 = &H1B934
                Catchphrase3 = &H1B956
                Catchphrase4 = &H1B978
                Catchphrase5 = &H1B99A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Miilevel = &H1BF53
                Miiexperience = &H1BF52
                Haircolor = &H1BE13
                Pampered = &H1BF54
                Splurge = &H1C2E0
                CatchphraseJ1 = &H1BE14
                CatchphraseJ2 = &H1BE20
                Catchphrase2 = &H1BEC4
                Catchphrase3 = &H1BEE6
                Catchphrase4 = &H1BF08
                Catchphrase5 = &H1BF2A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Miilevel = &H1C4E3
                Miiexperience = &H1C4E2
                Haircolor = &H1C3A3
                Pampered = &H1C4E4
                Splurge = &H1C870
                CatchphraseJ1 = &H1C3A4
                CatchphraseJ2 = &H1C3B0
                Catchphrase2 = &H1C454
                Catchphrase3 = &H1C476
                Catchphrase4 = &H1C498
                Catchphrase5 = &H1C4BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Miilevel = &H1CA73
                Miiexperience = &H1CA72
                Haircolor = &H1C933
                Pampered = &H1CA74
                Splurge = &H1CE00
                CatchphraseJ1 = &H1C934
                CatchphraseJ2 = &H1C940
                Catchphrase2 = &H1C9E4
                Catchphrase3 = &H1CA06
                Catchphrase4 = &H1CA28
                Catchphrase5 = &H1CA4A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Miilevel = &H1D003
                Miiexperience = &H1D002
                Haircolor = &H1CEC3
                Pampered = &H1D004
                Splurge = &H1D390
                CatchphraseJ1 = &H1CEC4
                CatchphraseJ2 = &H1CED0
                Catchphrase2 = &H1CF74
                Catchphrase3 = &H1CF96
                Catchphrase4 = &H1CFB8
                Catchphrase5 = &H1CFDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Miilevel = &H1D593
                Miiexperience = &H1D592
                Haircolor = &H1D453
                Pampered = &H1D594
                Splurge = &H1D920
                CatchphraseJ1 = &H1D454
                CatchphraseJ2 = &H1D460
                Catchphrase2 = &H1D504
                Catchphrase3 = &H1D526
                Catchphrase4 = &H1D548
                Catchphrase5 = &H1D56A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Miilevel = &H1DB23
                Miiexperience = &H1DB22
                Haircolor = &H1D9E3
                Pampered = &H1DB24
                Splurge = &H1DEB0
                CatchphraseJ1 = &H1D9E4
                CatchphraseJ2 = &H1D9F0
                Catchphrase2 = &H1DA94
                Catchphrase3 = &H1DAB6
                Catchphrase4 = &H1DAD8
                Catchphrase5 = &H1DAFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Miilevel = &H1E0B3
                Miiexperience = &H1E0B2
                Haircolor = &H1DF73
                Pampered = &H1E0B4
                Splurge = &H1E440
                CatchphraseJ1 = &H1DF74
                CatchphraseJ2 = &H1DF80
                Catchphrase2 = &H1E024
                Catchphrase3 = &H1E046
                Catchphrase4 = &H1E068
                Catchphrase5 = &H1E08A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Miilevel = &H1E643
                Miiexperience = &H1E642
                Haircolor = &H1E503
                Pampered = &H1E644
                Splurge = &H1E9D0
                CatchphraseJ1 = &H1E504
                CatchphraseJ2 = &H1E510
                Catchphrase2 = &H1E5B4
                Catchphrase3 = &H1E5D6
                Catchphrase4 = &H1E5F8
                Catchphrase5 = &H1E61A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Miilevel = &H1EBD3
                Miiexperience = &H1EBD2
                Haircolor = &H1EA93
                Pampered = &H1EBD4
                Splurge = &H1EF60
                CatchphraseJ1 = &H1EA94
                CatchphraseJ2 = &H1EAA0
                Catchphrase2 = &H1EB44
                Catchphrase3 = &H1EB66
                Catchphrase4 = &H1EB88
                Catchphrase5 = &H1EBAA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Miilevel = &H1F163
                Miiexperience = &H1F162
                Haircolor = &H1F023
                Pampered = &H1F164
                Splurge = &H1F4F0
                CatchphraseJ1 = &H1F024
                CatchphraseJ2 = &H1F030
                Catchphrase2 = &H1F0D4
                Catchphrase3 = &H1F0F6
                Catchphrase4 = &H1F118
                Catchphrase5 = &H1F13A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Miilevel = &H1F6F3
                Miiexperience = &H1F6F2
                Haircolor = &H1F5B3
                Pampered = &H1F6F4
                Splurge = &H1FA80
                CatchphraseJ1 = &H1F5B4
                CatchphraseJ2 = &H1F5C0
                Catchphrase2 = &H1F664
                Catchphrase3 = &H1F686
                Catchphrase4 = &H1F6A8
                Catchphrase5 = &H1F6CA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Miilevel = &H1FC83
                Miiexperience = &H1FC82
                Haircolor = &H1FB43
                Pampered = &H1FC84
                Splurge = &H20010
                CatchphraseJ1 = &H1FB44
                CatchphraseJ2 = &H1FB50
                Catchphrase2 = &H1FBF4
                Catchphrase3 = &H1FC16
                Catchphrase4 = &H1FC38
                Catchphrase5 = &H1FC5A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Miilevel = &H20213
                Miiexperience = &H20212
                Haircolor = &H200D3
                Pampered = &H20214
                Splurge = &H205A0
                CatchphraseJ1 = &H200D4
                CatchphraseJ2 = &H200E0
                Catchphrase2 = &H20184
                Catchphrase3 = &H201A6
                Catchphrase4 = &H201C8
                Catchphrase5 = &H201EA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Miilevel = &H207A3
                Miiexperience = &H207A2
                Haircolor = &H20663
                Pampered = &H207A4
                Splurge = &H20B30
                CatchphraseJ1 = &H20664
                CatchphraseJ2 = &H20670
                Catchphrase2 = &H20714
                Catchphrase3 = &H20736
                Catchphrase4 = &H20758
                Catchphrase5 = &H2077A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Miilevel = &H20D33
                Miiexperience = &H20D32
                Haircolor = &H20BF3
                Pampered = &H20D34
                Splurge = &H210C0
                CatchphraseJ1 = &H20BF4
                CatchphraseJ2 = &H20C00
                Catchphrase2 = &H20CA4
                Catchphrase3 = &H20CC6
                Catchphrase4 = &H20CE8
                Catchphrase5 = &H20D0A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Miilevel = &H212C3
                Miiexperience = &H212C2
                Haircolor = &H21183
                Pampered = &H212C4
                Splurge = &H21650
                CatchphraseJ1 = &H21184
                CatchphraseJ2 = &H21190
                Catchphrase2 = &H21234
                Catchphrase3 = &H21256
                Catchphrase4 = &H21278
                Catchphrase5 = &H2129A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Miilevel = &H21853
                Miiexperience = &H21852
                Haircolor = &H21713
                Pampered = &H21854
                Splurge = &H21BE0
                CatchphraseJ1 = &H21714
                CatchphraseJ2 = &H21720
                Catchphrase2 = &H217C4
                Catchphrase3 = &H217E6
                Catchphrase4 = &H21808
                Catchphrase5 = &H2182A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Miilevel = &H21DE3
                Miiexperience = &H21DE2
                Haircolor = &H21CA3
                Pampered = &H21DE4
                Splurge = &H22170
                CatchphraseJ1 = &H21CA4
                CatchphraseJ2 = &H21CB0
                Catchphrase2 = &H21D54
                Catchphrase3 = &H21D76
                Catchphrase4 = &H21D98
                Catchphrase5 = &H21DBA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Miilevel = &H22373
                Miiexperience = &H22372
                Haircolor = &H22233
                Pampered = &H22374
                Splurge = &H22700
                CatchphraseJ1 = &H22234
                CatchphraseJ2 = &H22240
                Catchphrase2 = &H222E4
                Catchphrase3 = &H22306
                Catchphrase4 = &H22328
                Catchphrase5 = &H2234A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Miilevel = &H22903
                Miiexperience = &H22902
                Haircolor = &H227C3
                Pampered = &H22904
                Splurge = &H22C90
                CatchphraseJ1 = &H227C4
                CatchphraseJ2 = &H227D0
                Catchphrase2 = &H22874
                Catchphrase3 = &H22896
                Catchphrase4 = &H228B8
                Catchphrase5 = &H228DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Miilevel = &H22E93
                Miiexperience = &H22E92
                Haircolor = &H22D53
                Pampered = &H22E94
                Splurge = &H23220
                CatchphraseJ1 = &H22D54
                CatchphraseJ2 = &H22D60
                Catchphrase2 = &H22E04
                Catchphrase3 = &H22E26
                Catchphrase4 = &H22E48
                Catchphrase5 = &H22E6A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Miilevel = &H23423
                Miiexperience = &H23422
                Haircolor = &H232E3
                Pampered = &H23424
                Splurge = &H237B0
                CatchphraseJ1 = &H232E4
                CatchphraseJ2 = &H232F0
                Catchphrase2 = &H23394
                Catchphrase3 = &H233B6
                Catchphrase4 = &H233D8
                Catchphrase5 = &H233FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Miilevel = &H239B3
                Miiexperience = &H239B2
                Haircolor = &H23873
                Pampered = &H239B4
                Splurge = &H23D40
                CatchphraseJ1 = &H23874
                CatchphraseJ2 = &H23880
                Catchphrase2 = &H23924
                Catchphrase3 = &H23946
                Catchphrase4 = &H23968
                Catchphrase5 = &H2398A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Miilevel = &H23F43
                Miiexperience = &H23F42
                Haircolor = &H23E03
                Pampered = &H23F44
                Splurge = &H242D0
                CatchphraseJ1 = &H23E04
                CatchphraseJ2 = &H23E10
                Catchphrase2 = &H23EB4
                Catchphrase3 = &H23ED6
                Catchphrase4 = &H23EF8
                Catchphrase5 = &H23F1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Miilevel = &H244D3
                Miiexperience = &H244D2
                Haircolor = &H24393
                Pampered = &H244D4
                Splurge = &H24860
                CatchphraseJ1 = &H24394
                CatchphraseJ2 = &H243A0
                Catchphrase2 = &H24444
                Catchphrase3 = &H24466
                Catchphrase4 = &H24488
                Catchphrase5 = &H244AA
            End If
        Else
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Miilevel = &H1F23
                Miiexperience = &H1F22
                Haircolor = &H1D13
                Pampered = &H1F24
                Splurge = &H22B0
                Catchphrase1 = &H1D20
                Catchphrase2 = &H1DC4
                Catchphrase3 = &H1DE6
                Catchphrase4 = &H1E08
                Catchphrase5 = &H1E2A
                Gesture_1 = &H1F16
                Gesture_2 = &H1F17
                Gesture_3 = &H1F18
                Gesture_4 = &H1F19
                Gesture_5 = &H1F1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Miilevel = &H2583
                Miiexperience = &H2582
                Haircolor = &H2373
                Pampered = &H2584
                Splurge = &H2910
                Catchphrase1 = &H2380
                Catchphrase2 = &H2424
                Catchphrase3 = &H2446
                Catchphrase4 = &H2468
                Catchphrase5 = &H248A
                Gesture_1 = &H2576
                Gesture_2 = &H2577
                Gesture_3 = &H2578
                Gesture_4 = &H2579
                Gesture_5 = &H257A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Miilevel = &H2BE3
                Miiexperience = &H2BE2
                Haircolor = &H29D3
                Pampered = &H2BE4
                Splurge = &H2F70
                Catchphrase1 = &H29E0
                Catchphrase2 = &H2A84
                Catchphrase3 = &H2AA6
                Catchphrase4 = &H2AC8
                Catchphrase5 = &H2AEA
                Gesture_1 = &H2BD6
                Gesture_2 = &H2BD7
                Gesture_3 = &H2BD8
                Gesture_4 = &H2BD9
                Gesture_5 = &H2BDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Miilevel = &H3243
                Miiexperience = &H3242
                Haircolor = &H3033
                Pampered = &H3244
                Splurge = &H35D0
                Catchphrase1 = &H3040
                Catchphrase2 = &H30E4
                Catchphrase3 = &H3106
                Catchphrase4 = &H3128
                Catchphrase5 = &H314A
                Gesture_1 = &H3236
                Gesture_2 = &H3237
                Gesture_3 = &H3238
                Gesture_4 = &H3239
                Gesture_5 = &H323A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Miilevel = &H38A3
                Miiexperience = &H38A2
                Haircolor = &H3693
                Pampered = &H38A4
                Splurge = &H3C30
                Catchphrase1 = &H36A0
                Catchphrase2 = &H3744
                Catchphrase3 = &H3766
                Catchphrase4 = &H3788
                Catchphrase5 = &H37AA
                Gesture_1 = &H3896
                Gesture_2 = &H3897
                Gesture_3 = &H3898
                Gesture_4 = &H3899
                Gesture_5 = &H389A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Miilevel = &H3F03
                Miiexperience = &H3F02
                Haircolor = &H3CF3
                Pampered = &H3F04
                Splurge = &H4290
                Catchphrase1 = &H3D00
                Catchphrase2 = &H3DA4
                Catchphrase3 = &H3DC6
                Catchphrase4 = &H3DE8
                Catchphrase5 = &H3E0A
                Gesture_1 = &H3EF6
                Gesture_2 = &H3EF7
                Gesture_3 = &H3EF8
                Gesture_4 = &H3EF9
                Gesture_5 = &H3EFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Miilevel = &H4563
                Miiexperience = &H4562
                Haircolor = &H4353
                Pampered = &H4564
                Splurge = &H48F0
                Catchphrase1 = &H4360
                Catchphrase2 = &H4404
                Catchphrase3 = &H4426
                Catchphrase4 = &H4448
                Catchphrase5 = &H446A
                Gesture_1 = &H4556
                Gesture_2 = &H4557
                Gesture_3 = &H4558
                Gesture_4 = &H4559
                Gesture_5 = &H455A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Miilevel = &H4BC3
                Miiexperience = &H4BC2
                Haircolor = &H49B3
                Pampered = &H4BC4
                Splurge = &H4F50
                Catchphrase1 = &H49C0
                Catchphrase2 = &H4A64
                Catchphrase3 = &H4A86
                Catchphrase4 = &H4AA8
                Catchphrase5 = &H4ACA
                Gesture_1 = &H4BB6
                Gesture_2 = &H4BB7
                Gesture_3 = &H4BB8
                Gesture_4 = &H4BB9
                Gesture_5 = &H4BBA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Miilevel = &H5223
                Miiexperience = &H5222
                Haircolor = &H5013
                Pampered = &H5224
                Splurge = &H55B0
                Catchphrase1 = &H5020
                Catchphrase2 = &H50C4
                Catchphrase3 = &H50E6
                Catchphrase4 = &H5108
                Catchphrase5 = &H512A
                Gesture_1 = &H5216
                Gesture_2 = &H5217
                Gesture_3 = &H5218
                Gesture_4 = &H5219
                Gesture_5 = &H521A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Miilevel = &H5883
                Miiexperience = &H5882
                Haircolor = &H5673
                Pampered = &H5884
                Splurge = &H5C10
                Catchphrase1 = &H5680
                Catchphrase2 = &H5724
                Catchphrase3 = &H5746
                Catchphrase4 = &H5768
                Catchphrase5 = &H578A
                Gesture_1 = &H5876
                Gesture_2 = &H5877
                Gesture_3 = &H5878
                Gesture_4 = &H5879
                Gesture_5 = &H587A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Miilevel = &H5EE3
                Miiexperience = &H5EE2
                Haircolor = &H5CD3
                Pampered = &H5EE4
                Splurge = &H6270
                Catchphrase1 = &H5CE0
                Catchphrase2 = &H5D84
                Catchphrase3 = &H5DA6
                Catchphrase4 = &H5DC8
                Catchphrase5 = &H5DEA
                Gesture_1 = &H5ED6
                Gesture_2 = &H5ED7
                Gesture_3 = &H5ED8
                Gesture_4 = &H5ED9
                Gesture_5 = &H5EDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Miilevel = &H6543
                Miiexperience = &H6542
                Haircolor = &H6333
                Pampered = &H6544
                Splurge = &H68D0
                Catchphrase1 = &H6340
                Catchphrase2 = &H63E4
                Catchphrase3 = &H6406
                Catchphrase4 = &H6428
                Catchphrase5 = &H644A
                Gesture_1 = &H6536
                Gesture_2 = &H6537
                Gesture_3 = &H6538
                Gesture_4 = &H6539
                Gesture_5 = &H653A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Miilevel = &H6BA3
                Miiexperience = &H6BA2
                Haircolor = &H6993
                Pampered = &H6BA4
                Splurge = &H6F30
                Catchphrase1 = &H69A0
                Catchphrase2 = &H6A44
                Catchphrase3 = &H6A66
                Catchphrase4 = &H6A88
                Catchphrase5 = &H6AAA
                Gesture_1 = &H6B96
                Gesture_2 = &H6B97
                Gesture_3 = &H6B98
                Gesture_4 = &H6B99
                Gesture_5 = &H6B9A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Miilevel = &H7203
                Miiexperience = &H7202
                Haircolor = &H6FF3
                Pampered = &H7204
                Splurge = &H7590
                Catchphrase1 = &H7000
                Catchphrase2 = &H70A4
                Catchphrase3 = &H70C6
                Catchphrase4 = &H70E8
                Catchphrase5 = &H710A
                Gesture_1 = &H71F6
                Gesture_2 = &H71F7
                Gesture_3 = &H71F8
                Gesture_4 = &H71F9
                Gesture_5 = &H71FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Miilevel = &H7863
                Miiexperience = &H7862
                Haircolor = &H7653
                Pampered = &H7864
                Splurge = &H7BF0
                Catchphrase1 = &H7660
                Catchphrase2 = &H7704
                Catchphrase3 = &H7726
                Catchphrase4 = &H7748
                Catchphrase5 = &H776A
                Gesture_1 = &H7856
                Gesture_2 = &H7857
                Gesture_3 = &H7858
                Gesture_4 = &H7859
                Gesture_5 = &H785A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Miilevel = &H7EC3
                Miiexperience = &H7EC2
                Haircolor = &H7CB3
                Pampered = &H7EC4
                Splurge = &H8250
                Catchphrase1 = &H7CC0
                Catchphrase2 = &H7D64
                Catchphrase3 = &H7D86
                Catchphrase4 = &H7DA8
                Catchphrase5 = &H7DCA
                Gesture_1 = &H7EB6
                Gesture_2 = &H7EB7
                Gesture_3 = &H7EB8
                Gesture_4 = &H7EB9
                Gesture_5 = &H7EBA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Miilevel = &H8523
                Miiexperience = &H8522
                Haircolor = &H8313
                Pampered = &H8524
                Splurge = &H88B0
                Catchphrase1 = &H8320
                Catchphrase2 = &H83C4
                Catchphrase3 = &H83E6
                Catchphrase4 = &H8408
                Catchphrase5 = &H842A
                Gesture_1 = &H8516
                Gesture_2 = &H8517
                Gesture_3 = &H8518
                Gesture_4 = &H8519
                Gesture_5 = &H851A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Miilevel = &H8B83
                Miiexperience = &H8B82
                Haircolor = &H8973
                Pampered = &H8B84
                Splurge = &H8F10
                Catchphrase1 = &H8980
                Catchphrase2 = &H8A24
                Catchphrase3 = &H8A46
                Catchphrase4 = &H8A68
                Catchphrase5 = &H8A8A
                Gesture_1 = &H8B76
                Gesture_2 = &H8B77
                Gesture_3 = &H8B78
                Gesture_4 = &H8B79
                Gesture_5 = &H8B7A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Miilevel = &H91E3
                Miiexperience = &H91E2
                Haircolor = &H8FD3
                Pampered = &H91E4
                Splurge = &H9570
                Catchphrase1 = &H8FE0
                Catchphrase2 = &H9084
                Catchphrase3 = &H90A6
                Catchphrase4 = &H90C8
                Catchphrase5 = &H90EA
                Gesture_1 = &H91D6
                Gesture_2 = &H91D7
                Gesture_3 = &H91D8
                Gesture_4 = &H91D9
                Gesture_5 = &H91DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Miilevel = &H9843
                Miiexperience = &H9842
                Haircolor = &H9633
                Pampered = &H9844
                Splurge = &H9BD0
                Catchphrase1 = &H9640
                Catchphrase2 = &H96E4
                Catchphrase3 = &H9706
                Catchphrase4 = &H9728
                Catchphrase5 = &H974A
                Gesture_1 = &H9836
                Gesture_2 = &H9837
                Gesture_3 = &H9838
                Gesture_4 = &H9839
                Gesture_5 = &H983A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Miilevel = &H9EA3
                Miiexperience = &H9EA2
                Haircolor = &H9C93
                Pampered = &H9EA4
                Splurge = &HA230
                Catchphrase1 = &H9CA0
                Catchphrase2 = &H9D44
                Catchphrase3 = &H9D66
                Catchphrase4 = &H9D88
                Catchphrase5 = &H9DAA
                Gesture_1 = &H9E96
                Gesture_2 = &H9E97
                Gesture_3 = &H9E98
                Gesture_4 = &H9E99
                Gesture_5 = &H9E9A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Miilevel = &HA503
                Miiexperience = &HA502
                Haircolor = &HA2F3
                Pampered = &HA504
                Splurge = &HA890
                Catchphrase1 = &HA300
                Catchphrase2 = &HA3A4
                Catchphrase3 = &HA3C6
                Catchphrase4 = &HA3E8
                Catchphrase5 = &HA40A
                Gesture_1 = &HA4F6
                Gesture_2 = &HA4F7
                Gesture_3 = &HA4F8
                Gesture_4 = &HA4F9
                Gesture_5 = &HA4FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Miilevel = &HAB63
                Miiexperience = &HAB62
                Haircolor = &HA953
                Pampered = &HAB64
                Splurge = &HAEF0
                Catchphrase1 = &HA960
                Catchphrase2 = &HAA04
                Catchphrase3 = &HAA26
                Catchphrase4 = &HAA48
                Catchphrase5 = &HAA6A
                Gesture_1 = &HAB56
                Gesture_2 = &HAB57
                Gesture_3 = &HAB58
                Gesture_4 = &HAB59
                Gesture_5 = &HAB5A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Miilevel = &HB1C3
                Miiexperience = &HB1C2
                Haircolor = &HAFB3
                Pampered = &HB1C4
                Splurge = &HB550
                Catchphrase1 = &HAFC0
                Catchphrase2 = &HB064
                Catchphrase3 = &HB086
                Catchphrase4 = &HB0A8
                Catchphrase5 = &HB0CA
                Gesture_1 = &HB1B6
                Gesture_2 = &HB1B7
                Gesture_3 = &HB1B8
                Gesture_4 = &HB1B9
                Gesture_5 = &HB1BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Miilevel = &HB823
                Miiexperience = &HB822
                Haircolor = &HB613
                Pampered = &HB824
                Splurge = &HBBB0
                Catchphrase1 = &HB620
                Catchphrase2 = &HB6C4
                Catchphrase3 = &HB6E6
                Catchphrase4 = &HB708
                Catchphrase5 = &HB72A
                Gesture_1 = &HB816
                Gesture_2 = &HB817
                Gesture_3 = &HB818
                Gesture_4 = &HB819
                Gesture_5 = &HB81A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Miilevel = &HBE83
                Miiexperience = &HBE82
                Haircolor = &HBC73
                Pampered = &HBE84
                Splurge = &HC210
                Catchphrase1 = &HBC80
                Catchphrase2 = &HBD24
                Catchphrase3 = &HBD46
                Catchphrase4 = &HBD68
                Catchphrase5 = &HBD8A
                Gesture_1 = &HBE76
                Gesture_2 = &HBE77
                Gesture_3 = &HBE78
                Gesture_4 = &HBE79
                Gesture_5 = &HBE7A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Miilevel = &HC4E3
                Miiexperience = &HC4E2
                Haircolor = &HC2D3
                Pampered = &HC4E4
                Splurge = &HC870
                Catchphrase1 = &HC2E0
                Catchphrase2 = &HC384
                Catchphrase3 = &HC3A6
                Catchphrase4 = &HC3C8
                Catchphrase5 = &HC3EA
                Gesture_1 = &HC4D6
                Gesture_2 = &HC4D7
                Gesture_3 = &HC4D8
                Gesture_4 = &HC4D9
                Gesture_5 = &HC4DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Miilevel = &HCB43
                Miiexperience = &HCB42
                Haircolor = &HC933
                Pampered = &HCB44
                Splurge = &HCED0
                Catchphrase1 = &HC940
                Catchphrase2 = &HC9E4
                Catchphrase3 = &HCA06
                Catchphrase4 = &HCA28
                Catchphrase5 = &HCA4A
                Gesture_1 = &HCB36
                Gesture_2 = &HCB37
                Gesture_3 = &HCB38
                Gesture_4 = &HCB39
                Gesture_5 = &HCB3A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Miilevel = &HD1A3
                Miiexperience = &HD1A2
                Haircolor = &HCF93
                Pampered = &HD1A4
                Splurge = &HD530
                Catchphrase1 = &HCFA0
                Catchphrase2 = &HD044
                Catchphrase3 = &HD066
                Catchphrase4 = &HD088
                Catchphrase5 = &HD0AA
                Gesture_1 = &HD196
                Gesture_2 = &HD197
                Gesture_3 = &HD198
                Gesture_4 = &HD199
                Gesture_5 = &HD19A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Miilevel = &HD803
                Miiexperience = &HD802
                Haircolor = &HD5F3
                Pampered = &HD804
                Splurge = &HDB90
                Catchphrase1 = &HD600
                Catchphrase2 = &HD6A4
                Catchphrase3 = &HD6C6
                Catchphrase4 = &HD6E8
                Catchphrase5 = &HD70A
                Gesture_1 = &HD7F6
                Gesture_2 = &HD7F7
                Gesture_3 = &HD7F8
                Gesture_4 = &HD7F9
                Gesture_5 = &HD7FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Miilevel = &HDE63
                Miiexperience = &HDE62
                Haircolor = &HDC53
                Pampered = &HDE64
                Splurge = &HE1F0
                Catchphrase1 = &HDC60
                Catchphrase2 = &HDD04
                Catchphrase3 = &HDD26
                Catchphrase4 = &HDD48
                Catchphrase5 = &HDD6A
                Gesture_1 = &HDE56
                Gesture_2 = &HDE57
                Gesture_3 = &HDE58
                Gesture_4 = &HDE59
                Gesture_5 = &HDE5A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Miilevel = &HE4C3
                Miiexperience = &HE4C2
                Haircolor = &HE2B3
                Pampered = &HE4C4
                Splurge = &HE850
                Catchphrase1 = &HE2C0
                Catchphrase2 = &HE364
                Catchphrase3 = &HE386
                Catchphrase4 = &HE3A8
                Catchphrase5 = &HE3CA
                Gesture_1 = &HE4B6
                Gesture_2 = &HE4B7
                Gesture_3 = &HE4B8
                Gesture_4 = &HE4B9
                Gesture_5 = &HE4BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Miilevel = &HEB23
                Miiexperience = &HEB22
                Haircolor = &HE913
                Pampered = &HEB24
                Splurge = &HEEB0
                Catchphrase1 = &HE920
                Catchphrase2 = &HE9C4
                Catchphrase3 = &HE9E6
                Catchphrase4 = &HEA08
                Catchphrase5 = &HEA2A
                Gesture_1 = &HEB16
                Gesture_2 = &HEB17
                Gesture_3 = &HEB18
                Gesture_4 = &HEB19
                Gesture_5 = &HEB1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Miilevel = &HF183
                Miiexperience = &HF182
                Haircolor = &HEF73
                Pampered = &HF184
                Splurge = &HF510
                Catchphrase1 = &HEF80
                Catchphrase2 = &HF024
                Catchphrase3 = &HF046
                Catchphrase4 = &HF068
                Catchphrase5 = &HF08A
                Gesture_1 = &HF176
                Gesture_2 = &HF177
                Gesture_3 = &HF178
                Gesture_4 = &HF179
                Gesture_5 = &HF17A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Miilevel = &HF7E3
                Miiexperience = &HF7E2
                Haircolor = &HF5D3
                Pampered = &HF7E4
                Splurge = &HFB70
                Catchphrase1 = &HF5E0
                Catchphrase2 = &HF684
                Catchphrase3 = &HF6A6
                Catchphrase4 = &HF6C8
                Catchphrase5 = &HF6EA
                Gesture_1 = &HF7D6
                Gesture_2 = &HF7D7
                Gesture_3 = &HF7D8
                Gesture_4 = &HF7D9
                Gesture_5 = &HF7DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Miilevel = &HFE43
                Miiexperience = &HFE42
                Haircolor = &HFC33
                Pampered = &HFE44
                Splurge = &H101D0
                Catchphrase1 = &HFC40
                Catchphrase2 = &HFCE4
                Catchphrase3 = &HFD06
                Catchphrase4 = &HFD28
                Catchphrase5 = &HFD4A
                Gesture_1 = &HFE36
                Gesture_2 = &HFE37
                Gesture_3 = &HFE38
                Gesture_4 = &HFE39
                Gesture_5 = &HFE3A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Miilevel = &H104A3
                Miiexperience = &H104A2
                Haircolor = &H10293
                Pampered = &H104A4
                Splurge = &H10830
                Catchphrase1 = &H102A0
                Catchphrase2 = &H10344
                Catchphrase3 = &H10366
                Catchphrase4 = &H10388
                Catchphrase5 = &H103AA
                Gesture_1 = &H10496
                Gesture_2 = &H10497
                Gesture_3 = &H10498
                Gesture_4 = &H10499
                Gesture_5 = &H1049A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Miilevel = &H10B03
                Miiexperience = &H10B02
                Haircolor = &H108F3
                Pampered = &H10B04
                Splurge = &H10E90
                Catchphrase1 = &H10900
                Catchphrase2 = &H109A4
                Catchphrase3 = &H109C6
                Catchphrase4 = &H109E8
                Catchphrase5 = &H10A0A
                Gesture_1 = &H10AF6
                Gesture_2 = &H10AF7
                Gesture_3 = &H10AF8
                Gesture_4 = &H10AF9
                Gesture_5 = &H10AFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Miilevel = &H11163
                Miiexperience = &H11162
                Haircolor = &H10F53
                Pampered = &H11164
                Splurge = &H114F0
                Catchphrase1 = &H10F60
                Catchphrase2 = &H11004
                Catchphrase3 = &H11026
                Catchphrase4 = &H11048
                Catchphrase5 = &H1106A
                Gesture_1 = &H11156
                Gesture_2 = &H11157
                Gesture_3 = &H11158
                Gesture_4 = &H11159
                Gesture_5 = &H1115A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Miilevel = &H117C3
                Miiexperience = &H117C2
                Haircolor = &H115B3
                Pampered = &H117C4
                Splurge = &H11B50
                Catchphrase1 = &H115C0
                Catchphrase2 = &H11664
                Catchphrase3 = &H11686
                Catchphrase4 = &H116A8
                Catchphrase5 = &H116CA
                Gesture_1 = &H117B6
                Gesture_2 = &H117B7
                Gesture_3 = &H117B8
                Gesture_4 = &H117B9
                Gesture_5 = &H117BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Miilevel = &H11E23
                Miiexperience = &H11E22
                Haircolor = &H11C13
                Pampered = &H11E24
                Splurge = &H121B0
                Catchphrase1 = &H11C20
                Catchphrase2 = &H11CC4
                Catchphrase3 = &H11CE6
                Catchphrase4 = &H11D08
                Catchphrase5 = &H11D2A
                Gesture_1 = &H11E16
                Gesture_2 = &H11E17
                Gesture_3 = &H11E18
                Gesture_4 = &H11E19
                Gesture_5 = &H11E1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Miilevel = &H12483
                Miiexperience = &H12482
                Haircolor = &H12273
                Pampered = &H12484
                Splurge = &H12810
                Catchphrase1 = &H12280
                Catchphrase2 = &H12324
                Catchphrase3 = &H12346
                Catchphrase4 = &H12368
                Catchphrase5 = &H1238A
                Gesture_1 = &H12476
                Gesture_2 = &H12477
                Gesture_3 = &H12478
                Gesture_4 = &H12479
                Gesture_5 = &H1247A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Miilevel = &H12AE3
                Miiexperience = &H12AE2
                Haircolor = &H128D3
                Pampered = &H12AE4
                Splurge = &H12E70
                Catchphrase1 = &H128E0
                Catchphrase2 = &H12984
                Catchphrase3 = &H129A6
                Catchphrase4 = &H129C8
                Catchphrase5 = &H129EA
                Gesture_1 = &H12AD6
                Gesture_2 = &H12AD7
                Gesture_3 = &H12AD8
                Gesture_4 = &H12AD9
                Gesture_5 = &H12ADA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Miilevel = &H13143
                Miiexperience = &H13142
                Haircolor = &H12F33
                Pampered = &H13144
                Splurge = &H134D0
                Catchphrase1 = &H12F40
                Catchphrase2 = &H12FE4
                Catchphrase3 = &H13006
                Catchphrase4 = &H13028
                Catchphrase5 = &H1304A
                Gesture_1 = &H13136
                Gesture_2 = &H13137
                Gesture_3 = &H13138
                Gesture_4 = &H13139
                Gesture_5 = &H1313A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Miilevel = &H137A3
                Miiexperience = &H137A2
                Haircolor = &H13593
                Pampered = &H137A4
                Splurge = &H13B30
                Catchphrase1 = &H135A0
                Catchphrase2 = &H13644
                Catchphrase3 = &H13666
                Catchphrase4 = &H13688
                Catchphrase5 = &H136AA
                Gesture_1 = &H13796
                Gesture_2 = &H13797
                Gesture_3 = &H13798
                Gesture_4 = &H13799
                Gesture_5 = &H1379A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Miilevel = &H13E03
                Miiexperience = &H13E02
                Haircolor = &H13BF3
                Pampered = &H13E04
                Splurge = &H14190
                Catchphrase1 = &H13C00
                Catchphrase2 = &H13CA4
                Catchphrase3 = &H13CC6
                Catchphrase4 = &H13CE8
                Catchphrase5 = &H13D0A
                Gesture_1 = &H13DF6
                Gesture_2 = &H13DF7
                Gesture_3 = &H13DF8
                Gesture_4 = &H13DF9
                Gesture_5 = &H13DFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Miilevel = &H14463
                Miiexperience = &H14462
                Haircolor = &H14253
                Pampered = &H14464
                Splurge = &H147F0
                Catchphrase1 = &H14260
                Catchphrase2 = &H14304
                Catchphrase3 = &H14326
                Catchphrase4 = &H14348
                Catchphrase5 = &H1436A
                Gesture_1 = &H14456
                Gesture_2 = &H14457
                Gesture_3 = &H14458
                Gesture_4 = &H14459
                Gesture_5 = &H1445A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Miilevel = &H14AC3
                Miiexperience = &H14AC2
                Haircolor = &H148B3
                Pampered = &H14AC4
                Splurge = &H14E50
                Catchphrase1 = &H148C0
                Catchphrase2 = &H14964
                Catchphrase3 = &H14986
                Catchphrase4 = &H149A8
                Catchphrase5 = &H149CA
                Gesture_1 = &H14AB6
                Gesture_2 = &H14AB7
                Gesture_3 = &H14AB8
                Gesture_4 = &H14AB9
                Gesture_5 = &H14ABA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Miilevel = &H15123
                Miiexperience = &H15122
                Haircolor = &H14F13
                Pampered = &H15124
                Splurge = &H154B0
                Catchphrase1 = &H14F20
                Catchphrase2 = &H14FC4
                Catchphrase3 = &H14FE6
                Catchphrase4 = &H15008
                Catchphrase5 = &H1502A
                Gesture_1 = &H15116
                Gesture_2 = &H15117
                Gesture_3 = &H15118
                Gesture_4 = &H15119
                Gesture_5 = &H1511A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Miilevel = &H15783
                Miiexperience = &H15782
                Haircolor = &H15573
                Pampered = &H15784
                Splurge = &H15B10
                Catchphrase1 = &H15580
                Catchphrase2 = &H15624
                Catchphrase3 = &H15646
                Catchphrase4 = &H15668
                Catchphrase5 = &H1568A
                Gesture_1 = &H15776
                Gesture_2 = &H15777
                Gesture_3 = &H15778
                Gesture_4 = &H15779
                Gesture_5 = &H1577A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Miilevel = &H15DE3
                Miiexperience = &H15DE2
                Haircolor = &H15BD3
                Pampered = &H15DE4
                Splurge = &H16170
                Catchphrase1 = &H15BE0
                Catchphrase2 = &H15C84
                Catchphrase3 = &H15CA6
                Catchphrase4 = &H15CC8
                Catchphrase5 = &H15CEA
                Gesture_1 = &H15DD6
                Gesture_2 = &H15DD7
                Gesture_3 = &H15DD8
                Gesture_4 = &H15DD9
                Gesture_5 = &H15DDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Miilevel = &H16443
                Miiexperience = &H16442
                Haircolor = &H16233
                Pampered = &H16444
                Splurge = &H167D0
                Catchphrase1 = &H16240
                Catchphrase2 = &H162E4
                Catchphrase3 = &H16306
                Catchphrase4 = &H16328
                Catchphrase5 = &H1634A
                Gesture_1 = &H16436
                Gesture_2 = &H16437
                Gesture_3 = &H16438
                Gesture_4 = &H16439
                Gesture_5 = &H1643A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Miilevel = &H16AA3
                Miiexperience = &H16AA2
                Haircolor = &H16893
                Pampered = &H16AA4
                Splurge = &H16E30
                Catchphrase1 = &H168A0
                Catchphrase2 = &H16944
                Catchphrase3 = &H16966
                Catchphrase4 = &H16988
                Catchphrase5 = &H169AA
                Gesture_1 = &H16A96
                Gesture_2 = &H16A97
                Gesture_3 = &H16A98
                Gesture_4 = &H16A99
                Gesture_5 = &H16A9A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Miilevel = &H17103
                Miiexperience = &H17102
                Haircolor = &H16EF3
                Pampered = &H17104
                Splurge = &H17490
                Catchphrase1 = &H16F00
                Catchphrase2 = &H16FA4
                Catchphrase3 = &H16FC6
                Catchphrase4 = &H16FE8
                Catchphrase5 = &H1700A
                Gesture_1 = &H170F6
                Gesture_2 = &H170F7
                Gesture_3 = &H170F8
                Gesture_4 = &H170F9
                Gesture_5 = &H170FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Miilevel = &H17763
                Miiexperience = &H17762
                Haircolor = &H17553
                Pampered = &H17764
                Splurge = &H17AF0
                Catchphrase1 = &H17560
                Catchphrase2 = &H17604
                Catchphrase3 = &H17626
                Catchphrase4 = &H17648
                Catchphrase5 = &H1766A
                Gesture_1 = &H17756
                Gesture_2 = &H17757
                Gesture_3 = &H17758
                Gesture_4 = &H17759
                Gesture_5 = &H1775A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Miilevel = &H17DC3
                Miiexperience = &H17DC2
                Haircolor = &H17BB3
                Pampered = &H17DC4
                Splurge = &H18150
                Catchphrase1 = &H17BC0
                Catchphrase2 = &H17C64
                Catchphrase3 = &H17C86
                Catchphrase4 = &H17CA8
                Catchphrase5 = &H17CCA
                Gesture_1 = &H17DB6
                Gesture_2 = &H17DB7
                Gesture_3 = &H17DB8
                Gesture_4 = &H17DB9
                Gesture_5 = &H17DBA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Miilevel = &H18423
                Miiexperience = &H18422
                Haircolor = &H18213
                Pampered = &H18424
                Splurge = &H187B0
                Catchphrase1 = &H18220
                Catchphrase2 = &H182C4
                Catchphrase3 = &H182E6
                Catchphrase4 = &H18308
                Catchphrase5 = &H1832A
                Gesture_1 = &H18416
                Gesture_2 = &H18417
                Gesture_3 = &H18418
                Gesture_4 = &H18419
                Gesture_5 = &H1841A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Miilevel = &H18A83
                Miiexperience = &H18A82
                Haircolor = &H18873
                Pampered = &H18A84
                Splurge = &H18E10
                Catchphrase1 = &H18880
                Catchphrase2 = &H18924
                Catchphrase3 = &H18946
                Catchphrase4 = &H18968
                Catchphrase5 = &H1898A
                Gesture_1 = &H18A76
                Gesture_2 = &H18A77
                Gesture_3 = &H18A78
                Gesture_4 = &H18A79
                Gesture_5 = &H18A7A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Miilevel = &H190E3
                Miiexperience = &H190E2
                Haircolor = &H18ED3
                Pampered = &H190E4
                Splurge = &H19470
                Catchphrase1 = &H18EE0
                Catchphrase2 = &H18F84
                Catchphrase3 = &H18FA6
                Catchphrase4 = &H18FC8
                Catchphrase5 = &H18FEA
                Gesture_1 = &H190D6
                Gesture_2 = &H190D7
                Gesture_3 = &H190D8
                Gesture_4 = &H190D9
                Gesture_5 = &H190DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Miilevel = &H19743
                Miiexperience = &H19742
                Haircolor = &H19533
                Pampered = &H19744
                Splurge = &H19AD0
                Catchphrase1 = &H19540
                Catchphrase2 = &H195E4
                Catchphrase3 = &H19606
                Catchphrase4 = &H19628
                Catchphrase5 = &H1964A
                Gesture_1 = &H19736
                Gesture_2 = &H19737
                Gesture_3 = &H19738
                Gesture_4 = &H19739
                Gesture_5 = &H1973A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Miilevel = &H19DA3
                Miiexperience = &H19DA2
                Haircolor = &H19B93
                Pampered = &H19DA4
                Splurge = &H1A130
                Catchphrase1 = &H19BA0
                Catchphrase2 = &H19C44
                Catchphrase3 = &H19C66
                Catchphrase4 = &H19C88
                Catchphrase5 = &H19CAA
                Gesture_1 = &H19D96
                Gesture_2 = &H19D97
                Gesture_3 = &H19D98
                Gesture_4 = &H19D99
                Gesture_5 = &H19D9A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Miilevel = &H1A403
                Miiexperience = &H1A402
                Haircolor = &H1A1F3
                Pampered = &H1A404
                Splurge = &H1A790
                Catchphrase1 = &H1A200
                Catchphrase2 = &H1A2A4
                Catchphrase3 = &H1A2C6
                Catchphrase4 = &H1A2E8
                Catchphrase5 = &H1A30A
                Gesture_1 = &H1A3F6
                Gesture_2 = &H1A3F7
                Gesture_3 = &H1A3F8
                Gesture_4 = &H1A3F9
                Gesture_5 = &H1A3FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Miilevel = &H1AA63
                Miiexperience = &H1AA62
                Haircolor = &H1A853
                Pampered = &H1AA64
                Splurge = &H1ADF0
                Catchphrase1 = &H1A860
                Catchphrase2 = &H1A904
                Catchphrase3 = &H1A926
                Catchphrase4 = &H1A948
                Catchphrase5 = &H1A96A
                Gesture_1 = &H1AA56
                Gesture_2 = &H1AA57
                Gesture_3 = &H1AA58
                Gesture_4 = &H1AA59
                Gesture_5 = &H1AA5A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Miilevel = &H1B0C3
                Miiexperience = &H1B0C2
                Haircolor = &H1AEB3
                Pampered = &H1B0C4
                Splurge = &H1B450
                Catchphrase1 = &H1AEC0
                Catchphrase2 = &H1AF64
                Catchphrase3 = &H1AF86
                Catchphrase4 = &H1AFA8
                Catchphrase5 = &H1AFCA
                Gesture_1 = &H1B0B6
                Gesture_2 = &H1B0B7
                Gesture_3 = &H1B0B8
                Gesture_4 = &H1B0B9
                Gesture_5 = &H1B0BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Miilevel = &H1B723
                Miiexperience = &H1B722
                Haircolor = &H1B513
                Pampered = &H1B724
                Splurge = &H1BAB0
                Catchphrase1 = &H1B520
                Catchphrase2 = &H1B5C4
                Catchphrase3 = &H1B5E6
                Catchphrase4 = &H1B608
                Catchphrase5 = &H1B62A
                Gesture_1 = &H1B716
                Gesture_2 = &H1B717
                Gesture_3 = &H1B718
                Gesture_4 = &H1B719
                Gesture_5 = &H1B71A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Miilevel = &H1BD83
                Miiexperience = &H1BD82
                Haircolor = &H1BB73
                Pampered = &H1BD84
                Splurge = &H1C110
                Catchphrase1 = &H1BB80
                Catchphrase2 = &H1BC24
                Catchphrase3 = &H1BC46
                Catchphrase4 = &H1BC68
                Catchphrase5 = &H1BC8A
                Gesture_1 = &H1BD76
                Gesture_2 = &H1BD77
                Gesture_3 = &H1BD78
                Gesture_4 = &H1BD79
                Gesture_5 = &H1BD7A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Miilevel = &H1C3E3
                Miiexperience = &H1C3E2
                Haircolor = &H1C1D3
                Pampered = &H1C3E4
                Splurge = &H1C770
                Catchphrase1 = &H1C1E0
                Catchphrase2 = &H1C284
                Catchphrase3 = &H1C2A6
                Catchphrase4 = &H1C2C8
                Catchphrase5 = &H1C2EA
                Gesture_1 = &H1C3D6
                Gesture_2 = &H1C3D7
                Gesture_3 = &H1C3D8
                Gesture_4 = &H1C3D9
                Gesture_5 = &H1C3DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Miilevel = &H1CA43
                Miiexperience = &H1CA42
                Haircolor = &H1C833
                Pampered = &H1CA44
                Splurge = &H1CDD0
                Catchphrase1 = &H1C840
                Catchphrase2 = &H1C8E4
                Catchphrase3 = &H1C906
                Catchphrase4 = &H1C928
                Catchphrase5 = &H1C94A
                Gesture_1 = &H1CA36
                Gesture_2 = &H1CA37
                Gesture_3 = &H1CA38
                Gesture_4 = &H1CA39
                Gesture_5 = &H1CA3A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Miilevel = &H1D0A3
                Miiexperience = &H1D0A2
                Haircolor = &H1CE93
                Pampered = &H1D0A4
                Splurge = &H1D430
                Catchphrase1 = &H1CEA0
                Catchphrase2 = &H1CF44
                Catchphrase3 = &H1CF66
                Catchphrase4 = &H1CF88
                Catchphrase5 = &H1CFAA
                Gesture_1 = &H1D096
                Gesture_2 = &H1D097
                Gesture_3 = &H1D098
                Gesture_4 = &H1D099
                Gesture_5 = &H1D09A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Miilevel = &H1D703
                Miiexperience = &H1D702
                Haircolor = &H1D4F3
                Pampered = &H1D704
                Splurge = &H1DA90
                Catchphrase1 = &H1D500
                Catchphrase2 = &H1D5A4
                Catchphrase3 = &H1D5C6
                Catchphrase4 = &H1D5E8
                Catchphrase5 = &H1D60A
                Gesture_1 = &H1D6F6
                Gesture_2 = &H1D6F7
                Gesture_3 = &H1D6F8
                Gesture_4 = &H1D6F9
                Gesture_5 = &H1D6FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Miilevel = &H1DD63
                Miiexperience = &H1DD62
                Haircolor = &H1DB53
                Pampered = &H1DD64
                Splurge = &H1E0F0
                Catchphrase1 = &H1DB60
                Catchphrase2 = &H1DC04
                Catchphrase3 = &H1DC26
                Catchphrase4 = &H1DC48
                Catchphrase5 = &H1DC6A
                Gesture_1 = &H1DD56
                Gesture_2 = &H1DD57
                Gesture_3 = &H1DD58
                Gesture_4 = &H1DD59
                Gesture_5 = &H1DD5A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Miilevel = &H1E3C3
                Miiexperience = &H1E3C2
                Haircolor = &H1E1B3
                Pampered = &H1E3C4
                Splurge = &H1E750
                Catchphrase1 = &H1E1C0
                Catchphrase2 = &H1E264
                Catchphrase3 = &H1E286
                Catchphrase4 = &H1E2A8
                Catchphrase5 = &H1E2CA
                Gesture_1 = &H1E3B6
                Gesture_2 = &H1E3B7
                Gesture_3 = &H1E3B8
                Gesture_4 = &H1E3B9
                Gesture_5 = &H1E3BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Miilevel = &H1EA23
                Miiexperience = &H1EA22
                Haircolor = &H1E813
                Pampered = &H1EA24
                Splurge = &H1EDB0
                Catchphrase1 = &H1E820
                Catchphrase2 = &H1E8C4
                Catchphrase3 = &H1E8E6
                Catchphrase4 = &H1E908
                Catchphrase5 = &H1E92A
                Gesture_1 = &H1EA16
                Gesture_2 = &H1EA17
                Gesture_3 = &H1EA18
                Gesture_4 = &H1EA19
                Gesture_5 = &H1EA1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Miilevel = &H1F083
                Miiexperience = &H1F082
                Haircolor = &H1EE73
                Pampered = &H1F084
                Splurge = &H1F410
                Catchphrase1 = &H1EE80
                Catchphrase2 = &H1EF24
                Catchphrase3 = &H1EF46
                Catchphrase4 = &H1EF68
                Catchphrase5 = &H1EF8A
                Gesture_1 = &H1F076
                Gesture_2 = &H1F077
                Gesture_3 = &H1F078
                Gesture_4 = &H1F079
                Gesture_5 = &H1F07A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Miilevel = &H1F6E3
                Miiexperience = &H1F6E2
                Haircolor = &H1F4D3
                Pampered = &H1F6E4
                Splurge = &H1FA70
                Catchphrase1 = &H1F4E0
                Catchphrase2 = &H1F584
                Catchphrase3 = &H1F5A6
                Catchphrase4 = &H1F5C8
                Catchphrase5 = &H1F5EA
                Gesture_1 = &H1F6D6
                Gesture_2 = &H1F6D7
                Gesture_3 = &H1F6D8
                Gesture_4 = &H1F6D9
                Gesture_5 = &H1F6DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Miilevel = &H1FD43
                Miiexperience = &H1FD42
                Haircolor = &H1FB33
                Pampered = &H1FD44
                Splurge = &H200D0
                Catchphrase1 = &H1FB40
                Catchphrase2 = &H1FBE4
                Catchphrase3 = &H1FC06
                Catchphrase4 = &H1FC28
                Catchphrase5 = &H1FC4A
                Gesture_1 = &H1FD36
                Gesture_2 = &H1FD37
                Gesture_3 = &H1FD38
                Gesture_4 = &H1FD39
                Gesture_5 = &H1FD3A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Miilevel = &H203A3
                Miiexperience = &H203A2
                Haircolor = &H20193
                Pampered = &H203A4
                Splurge = &H20730
                Catchphrase1 = &H201A0
                Catchphrase2 = &H20244
                Catchphrase3 = &H20266
                Catchphrase4 = &H20288
                Catchphrase5 = &H202AA
                Gesture_1 = &H20396
                Gesture_2 = &H20397
                Gesture_3 = &H20398
                Gesture_4 = &H20399
                Gesture_5 = &H2039A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Miilevel = &H20A03
                Miiexperience = &H20A02
                Haircolor = &H207F3
                Pampered = &H20A04
                Splurge = &H20D90
                Catchphrase1 = &H20800
                Catchphrase2 = &H208A4
                Catchphrase3 = &H208C6
                Catchphrase4 = &H208E8
                Catchphrase5 = &H2090A
                Gesture_1 = &H209F6
                Gesture_2 = &H209F7
                Gesture_3 = &H209F8
                Gesture_4 = &H209F9
                Gesture_5 = &H209FA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Miilevel = &H21063
                Miiexperience = &H21062
                Haircolor = &H20E53
                Pampered = &H21064
                Splurge = &H213F0
                Catchphrase1 = &H20E60
                Catchphrase2 = &H20F04
                Catchphrase3 = &H20F26
                Catchphrase4 = &H20F48
                Catchphrase5 = &H20F6A
                Gesture_1 = &H21056
                Gesture_2 = &H21057
                Gesture_3 = &H21058
                Gesture_4 = &H21059
                Gesture_5 = &H2105A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Miilevel = &H216C3
                Miiexperience = &H216C2
                Haircolor = &H214B3
                Pampered = &H216C4
                Splurge = &H21A50
                Catchphrase1 = &H214C0
                Catchphrase2 = &H21564
                Catchphrase3 = &H21586
                Catchphrase4 = &H215A8
                Catchphrase5 = &H215CA
                Gesture_1 = &H216B6
                Gesture_2 = &H216B7
                Gesture_3 = &H216B8
                Gesture_4 = &H216B9
                Gesture_5 = &H216BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Miilevel = &H21D23
                Miiexperience = &H21D22
                Haircolor = &H21B13
                Pampered = &H21D24
                Splurge = &H220B0
                Catchphrase1 = &H21B20
                Catchphrase2 = &H21BC4
                Catchphrase3 = &H21BE6
                Catchphrase4 = &H21C08
                Catchphrase5 = &H21C2A
                Gesture_1 = &H21D16
                Gesture_2 = &H21D17
                Gesture_3 = &H21D18
                Gesture_4 = &H21D19
                Gesture_5 = &H21D1A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Miilevel = &H22383
                Miiexperience = &H22382
                Haircolor = &H22173
                Pampered = &H22384
                Splurge = &H22710
                Catchphrase1 = &H22180
                Catchphrase2 = &H22224
                Catchphrase3 = &H22246
                Catchphrase4 = &H22268
                Catchphrase5 = &H2228A
                Gesture_1 = &H22376
                Gesture_2 = &H22377
                Gesture_3 = &H22378
                Gesture_4 = &H22379
                Gesture_5 = &H2237A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Miilevel = &H229E3
                Miiexperience = &H229E2
                Haircolor = &H227D3
                Pampered = &H229E4
                Splurge = &H22D70
                Catchphrase1 = &H227E0
                Catchphrase2 = &H22884
                Catchphrase3 = &H228A6
                Catchphrase4 = &H228C8
                Catchphrase5 = &H228EA
                Gesture_1 = &H229D6
                Gesture_2 = &H229D7
                Gesture_3 = &H229D8
                Gesture_4 = &H229D9
                Gesture_5 = &H229DA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Miilevel = &H23043
                Miiexperience = &H23042
                Haircolor = &H22E33
                Pampered = &H23044
                Splurge = &H233D0
                Catchphrase1 = &H22E40
                Catchphrase2 = &H22EE4
                Catchphrase3 = &H22F06
                Catchphrase4 = &H22F28
                Catchphrase5 = &H22F4A
                Gesture_1 = &H23036
                Gesture_2 = &H23037
                Gesture_3 = &H23038
                Gesture_4 = &H23039
                Gesture_5 = &H2303A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Miilevel = &H236A3
                Miiexperience = &H236A2
                Haircolor = &H23493
                Pampered = &H236A4
                Splurge = &H23A30
                Catchphrase1 = &H234A0
                Catchphrase2 = &H23544
                Catchphrase3 = &H23566
                Catchphrase4 = &H23588
                Catchphrase5 = &H235AA
                Gesture_1 = &H23696
                Gesture_2 = &H23697
                Gesture_3 = &H23698
                Gesture_4 = &H23699
                Gesture_5 = &H2369A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Miilevel = &H23D03
                Miiexperience = &H23D02
                Haircolor = &H23AF3
                Pampered = &H23D04
                Splurge = &H24090
                Catchphrase1 = &H23B00
                Catchphrase2 = &H23BA4
                Catchphrase3 = &H23BC6
                Catchphrase4 = &H23BE8
                Catchphrase5 = &H23C0A
                Gesture_1 = &H23CF6
                Gesture_2 = &H23CF7
                Gesture_3 = &H23CF8
                Gesture_4 = &H23CF9
                Gesture_5 = &H23CFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Miilevel = &H24363
                Miiexperience = &H24362
                Haircolor = &H24153
                Pampered = &H24364
                Splurge = &H246F0
                Catchphrase1 = &H24160
                Catchphrase2 = &H24204
                Catchphrase3 = &H24226
                Catchphrase4 = &H24248
                Catchphrase5 = &H2426A
                Gesture_1 = &H24356
                Gesture_2 = &H24357
                Gesture_3 = &H24358
                Gesture_4 = &H24359
                Gesture_5 = &H2435A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Miilevel = &H249C3
                Miiexperience = &H249C2
                Haircolor = &H247B3
                Pampered = &H249C4
                Splurge = &H24D50
                Catchphrase1 = &H247C0
                Catchphrase2 = &H24864
                Catchphrase3 = &H24886
                Catchphrase4 = &H248A8
                Catchphrase5 = &H248CA
                Gesture_1 = &H249B6
                Gesture_2 = &H249B7
                Gesture_3 = &H249B8
                Gesture_4 = &H249B9
                Gesture_5 = &H249BA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Miilevel = &H25023
                Miiexperience = &H25022
                Haircolor = &H24E13
                Pampered = &H25024
                Splurge = &H253B0
                Catchphrase1 = &H24E20
                Catchphrase2 = &H24EC4
                Catchphrase3 = &H24EE6
                Catchphrase4 = &H24F08
                Catchphrase5 = &H24F2A
                Gesture_1 = &H25016
                Gesture_2 = &H25017
                Gesture_3 = &H25018
                Gesture_4 = &H25019
                Gesture_5 = &H2501A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Miilevel = &H25683
                Miiexperience = &H25682
                Haircolor = &H25473
                Pampered = &H25684
                Splurge = &H25A10
                Catchphrase1 = &H25480
                Catchphrase2 = &H25524
                Catchphrase3 = &H25546
                Catchphrase4 = &H25568
                Catchphrase5 = &H2558A
                Gesture_1 = &H25676
                Gesture_2 = &H25677
                Gesture_3 = &H25678
                Gesture_4 = &H25679
                Gesture_5 = &H2567A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Miilevel = &H25CE3
                Miiexperience = &H25CE2
                Haircolor = &H25AD3
                Pampered = &H25CE4
                Splurge = &H26070
                Catchphrase1 = &H25AE0
                Catchphrase2 = &H25B84
                Catchphrase3 = &H25BA6
                Catchphrase4 = &H25BC8
                Catchphrase5 = &H25BEA
                Gesture_1 = &H25CD6
                Gesture_2 = &H25CD7
                Gesture_3 = &H25CD8
                Gesture_4 = &H25CD9
                Gesture_5 = &H25CDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Miilevel = &H26343
                Miiexperience = &H26342
                Haircolor = &H26133
                Pampered = &H26344
                Splurge = &H266D0
                Catchphrase1 = &H26140
                Catchphrase2 = &H261E4
                Catchphrase3 = &H26206
                Catchphrase4 = &H26228
                Catchphrase5 = &H2624A
                Gesture_1 = &H26336
                Gesture_2 = &H26337
                Gesture_3 = &H26338
                Gesture_4 = &H26339
                Gesture_5 = &H2633A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Miilevel = &H269A3
                Miiexperience = &H269A2
                Haircolor = &H26793
                Pampered = &H269A4
                Splurge = &H26D30
                Catchphrase1 = &H267A0
                Catchphrase2 = &H26844
                Catchphrase3 = &H26866
                Catchphrase4 = &H26888
                Catchphrase5 = &H268AA
                Gesture_1 = &H26996
                Gesture_2 = &H26997
                Gesture_3 = &H26998
                Gesture_4 = &H26999
                Gesture_5 = &H2699A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Miilevel = &H27003
                Miiexperience = &H27002
                Haircolor = &H26DF3
                Pampered = &H27004
                Splurge = &H27390
                Catchphrase1 = &H26E00
                Catchphrase2 = &H26EA4
                Catchphrase3 = &H26EC6
                Catchphrase4 = &H26EE8
                Catchphrase5 = &H26F0A
                Gesture_1 = &H26FF6
                Gesture_2 = &H26FF7
                Gesture_3 = &H26FF8
                Gesture_4 = &H26FF9
                Gesture_5 = &H26FFA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Miilevel = &H27663
                Miiexperience = &H27662
                Haircolor = &H27453
                Pampered = &H27664
                Splurge = &H279F0
                Catchphrase1 = &H27460
                Catchphrase2 = &H27504
                Catchphrase3 = &H27526
                Catchphrase4 = &H27548
                Catchphrase5 = &H2756A
                Gesture_1 = &H27656
                Gesture_2 = &H27657
                Gesture_3 = &H27658
                Gesture_4 = &H27659
                Gesture_5 = &H2765A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Miilevel = &H27CC3
                Miiexperience = &H27CC2
                Haircolor = &H27AB3
                Pampered = &H27CC4
                Splurge = &H28050
                Catchphrase1 = &H27AC0
                Catchphrase2 = &H27B64
                Catchphrase3 = &H27B86
                Catchphrase4 = &H27BA8
                Catchphrase5 = &H27BCA
                Gesture_1 = &H27CB6
                Gesture_2 = &H27CB7
                Gesture_3 = &H27CB8
                Gesture_4 = &H27CB9
                Gesture_5 = &H27CBA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Miilevel = &H28323
                Miiexperience = &H28322
                Haircolor = &H28113
                Pampered = &H28324
                Splurge = &H286B0
                Catchphrase1 = &H28120
                Catchphrase2 = &H281C4
                Catchphrase3 = &H281E6
                Catchphrase4 = &H28208
                Catchphrase5 = &H2822A
                Gesture_1 = &H28316
                Gesture_2 = &H28317
                Gesture_3 = &H28318
                Gesture_4 = &H28319
                Gesture_5 = &H2831A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Miilevel = &H28983
                Miiexperience = &H28982
                Haircolor = &H28773
                Pampered = &H28984
                Splurge = &H28D10
                Catchphrase1 = &H28780
                Catchphrase2 = &H28824
                Catchphrase3 = &H28846
                Catchphrase4 = &H28868
                Catchphrase5 = &H2888A
                Gesture_1 = &H28976
                Gesture_2 = &H28977
                Gesture_3 = &H28978
                Gesture_4 = &H28979
                Gesture_5 = &H2897A
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Miilevel = &H28FE3
                Miiexperience = &H28FE2
                Haircolor = &H28DD3
                Pampered = &H28FE4
                Splurge = &H29370
                Catchphrase1 = &H28DE0
                Catchphrase2 = &H28E84
                Catchphrase3 = &H28EA6
                Catchphrase4 = &H28EC8
                Catchphrase5 = &H28EEA
                Gesture_1 = &H28FD6
                Gesture_2 = &H28FD7
                Gesture_3 = &H28FD8
                Gesture_4 = &H28FD9
                Gesture_5 = &H28FDA
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Miilevel = &H29643
                Miiexperience = &H29642
                Haircolor = &H29433
                Pampered = &H29644
                Splurge = &H299D0
                Catchphrase1 = &H29440
                Catchphrase2 = &H294E4
                Catchphrase3 = &H29506
                Catchphrase4 = &H29528
                Catchphrase5 = &H2954A
                Gesture_1 = &H29636
                Gesture_2 = &H29637
                Gesture_3 = &H29638
                Gesture_4 = &H29639
                Gesture_5 = &H2963A
            End If
        End If
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        Savefileregion()
        Readmiistatus()
    End Sub

    Public Sub Readmiistatus()
        Try
            Dim Readdata As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Readdata.Position = CatchphraseJ1
                Text_cathph_J1.Text = Readdata.ReadUnicodeString(4)
                Readdata.Position = CatchphraseJ2
                Text_cathph_J2.Text = Readdata.ReadUnicodeString(16)
            Else
                Readdata.Position = Catchphrase1
                Text_cathph_01.Text = Readdata.ReadUnicodeString(16)
                Readdata.Position = Gesture_1
                valu_gesture_1.Value = Readdata.ReadByte
                Readdata.Position = Gesture_2
                valu_gesture_2.Value = Readdata.ReadByte
                Readdata.Position = Gesture_3
                valu_gesture_3.Value = Readdata.ReadByte
                Readdata.Position = Gesture_4
                valu_gesture_4.Value = Readdata.ReadByte
                Readdata.Position = Gesture_5
                valu_gesture_5.Value = Readdata.ReadByte
            End If
            Readdata.Position = Miilevel
            valu_level.Value = Readdata.ReadByte
            Readdata.Position = Miiexperience
            valu_experience.Value = Readdata.ReadByte
            Readdata.Position = Haircolor
            valu_haircolor.Value = Readdata.ReadByte
            Readdata.Position = Pampered
            valu_ranking_pampered.Value = Readdata.ReadUInt32
            Readdata.Position = Splurge
            valu_ranking_splurge.Value = Readdata.ReadUInt32
            Readdata.Position = Catchphrase2
            Text_cathph_02.Text = Readdata.ReadUnicodeString(16)
            Readdata.Position = Catchphrase3
            Text_cathph_03.Text = Readdata.ReadUnicodeString(16)
            Readdata.Position = Catchphrase4
            Text_cathph_04.Text = Readdata.ReadUnicodeString(16)
            Readdata.Position = Catchphrase5
            Text_cathph_05.Text = Readdata.ReadUnicodeString(16)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read voice and personnality"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub valu_level_ValueChanged(sender As Object, e As EventArgs) Handles valu_level.ValueChanged
        Select Case valu_level.Value
            Case 0 To 11
                Text_starslevel.Text = "X 0"
            Case 12 To 23
                Text_starslevel.Text = "X 1"
            Case 24 To 35
                Text_starslevel.Text = "X 2"
            Case 36 To 47
                Text_starslevel.Text = "X 3"
            Case 48 To 59
                Text_starslevel.Text = "X 4"
            Case 60 To 71
                Text_starslevel.Text = "X 5"
            Case 72 To 83
                Text_starslevel.Text = "X 6"
            Case 84 To 95
                Text_starslevel.Text = "X 7"
            Case 96 To 99
                Text_starslevel.Text = "X 8"
        End Select
    End Sub
End Class