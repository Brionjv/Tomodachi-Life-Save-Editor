Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_miiinventory
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Miidetected As String
    Dim Miieconomy As String
    Dim Equippedhat As String
    Dim Equippedclothe As String
    Dim Equippedinterior As String
    Dim gift_1 As String
    Dim gift_2 As String
    Dim gift_3 As String
    Dim gift_4 As String
    Dim gift_5 As String
    Dim gift_6 As String
    Dim gift_7 As String
    Dim gift_8 As String
    Dim unlockinteriors As String
    Dim unlockspefoods As String
    Dim unlockgoods As String

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red_tl
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close_tl
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_title.MouseDown, TLSE_header.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TLSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_title.MouseUp, TLSE_header.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TLSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_title.MouseMove, TLSE_header.MouseMove
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

    Private Sub TLSE_miiinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Switchfilever()
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

    Public Sub Switchfilever()
        If Filever_text.Text = "EU" Then
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
        End If
        If Filever_text.Text = "US" Then
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
        End If
        If Filever_text.Text = "JP" Then
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
        End If
        If Filever_text.Text = "KR" Then
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
        End If
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

    Private Sub TLSE_miiinventory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        DetectMiiregistered()
    End Sub

    Public Sub Hidegifts()
        Gifs1_FFFF.Visible = False
        Gifs1_0000.Visible = False
        Gifs1_0100.Visible = False
        Gifs1_0200.Visible = False
        Gifs1_0300.Visible = False
        Gifs1_0400.Visible = False
        Gifs1_0500.Visible = False
        Gifs1_0600.Visible = False
        Gifs1_0700.Visible = False
        Gifs1_0800.Visible = False
        Gifs1_0900.Visible = False
        Gifs1_0a00.Visible = False
        Gifs1_0b00.Visible = False
        Gifs1_0c00.Visible = False
        Gifs1_0d00.Visible = False
        Gifs1_0e00.Visible = False
        Gifs1_0f00.Visible = False
        Gifs1_1000.Visible = False
        Gifs1_1100.Visible = False
        Gifs1_1200.Visible = False
        Gifs1_1300.Visible = False
        Gifs1_1400.Visible = False
        Gifs1_1500.Visible = False
        Gifs1_1600.Visible = False
        Gifs1_1700.Visible = False
        Gifs1_1800.Visible = False
        Gifs1_1900.Visible = False
        Gifs1_1a00.Visible = False
        Gifs1_1b00.Visible = False
        Gifs2_FFFF.Visible = False
        Gifs2_0000.Visible = False
        Gifs2_0100.Visible = False
        Gifs2_0200.Visible = False
        Gifs2_0300.Visible = False
        Gifs2_0400.Visible = False
        Gifs2_0500.Visible = False
        Gifs2_0600.Visible = False
        Gifs2_0700.Visible = False
        Gifs2_0800.Visible = False
        Gifs2_0900.Visible = False
        Gifs2_0a00.Visible = False
        Gifs2_0b00.Visible = False
        Gifs2_0c00.Visible = False
        Gifs2_0d00.Visible = False
        Gifs2_0e00.Visible = False
        Gifs2_0f00.Visible = False
        Gifs2_1000.Visible = False
        Gifs2_1100.Visible = False
        Gifs2_1200.Visible = False
        Gifs2_1300.Visible = False
        Gifs2_1400.Visible = False
        Gifs2_1500.Visible = False
        Gifs2_1600.Visible = False
        Gifs2_1700.Visible = False
        Gifs2_1800.Visible = False
        Gifs2_1900.Visible = False
        Gifs2_1a00.Visible = False
        Gifs2_1b00.Visible = False
        Gifs3_FFFF.Visible = False
        Gifs3_0000.Visible = False
        Gifs3_0100.Visible = False
        Gifs3_0200.Visible = False
        Gifs3_0300.Visible = False
        Gifs3_0400.Visible = False
        Gifs3_0500.Visible = False
        Gifs3_0600.Visible = False
        Gifs3_0700.Visible = False
        Gifs3_0800.Visible = False
        Gifs3_0900.Visible = False
        Gifs3_0a00.Visible = False
        Gifs3_0b00.Visible = False
        Gifs3_0c00.Visible = False
        Gifs3_0d00.Visible = False
        Gifs3_0e00.Visible = False
        Gifs3_0f00.Visible = False
        Gifs3_1000.Visible = False
        Gifs3_1100.Visible = False
        Gifs3_1200.Visible = False
        Gifs3_1300.Visible = False
        Gifs3_1400.Visible = False
        Gifs3_1500.Visible = False
        Gifs3_1600.Visible = False
        Gifs3_1700.Visible = False
        Gifs3_1800.Visible = False
        Gifs3_1900.Visible = False
        Gifs3_1a00.Visible = False
        Gifs3_1b00.Visible = False
        Gifs4_FFFF.Visible = False
        Gifs4_0000.Visible = False
        Gifs4_0100.Visible = False
        Gifs4_0200.Visible = False
        Gifs4_0300.Visible = False
        Gifs4_0400.Visible = False
        Gifs4_0500.Visible = False
        Gifs4_0600.Visible = False
        Gifs4_0700.Visible = False
        Gifs4_0800.Visible = False
        Gifs4_0900.Visible = False
        Gifs4_0a00.Visible = False
        Gifs4_0b00.Visible = False
        Gifs4_0c00.Visible = False
        Gifs4_0d00.Visible = False
        Gifs4_0e00.Visible = False
        Gifs4_0f00.Visible = False
        Gifs4_1000.Visible = False
        Gifs4_1100.Visible = False
        Gifs4_1200.Visible = False
        Gifs4_1300.Visible = False
        Gifs4_1400.Visible = False
        Gifs4_1500.Visible = False
        Gifs4_1600.Visible = False
        Gifs4_1700.Visible = False
        Gifs4_1800.Visible = False
        Gifs4_1900.Visible = False
        Gifs4_1a00.Visible = False
        Gifs4_1b00.Visible = False
        Gifs5_FFFF.Visible = False
        Gifs5_0000.Visible = False
        Gifs5_0100.Visible = False
        Gifs5_0200.Visible = False
        Gifs5_0300.Visible = False
        Gifs5_0400.Visible = False
        Gifs5_0500.Visible = False
        Gifs5_0600.Visible = False
        Gifs5_0700.Visible = False
        Gifs5_0800.Visible = False
        Gifs5_0900.Visible = False
        Gifs5_0a00.Visible = False
        Gifs5_0b00.Visible = False
        Gifs5_0c00.Visible = False
        Gifs5_0d00.Visible = False
        Gifs5_0e00.Visible = False
        Gifs5_0f00.Visible = False
        Gifs5_1000.Visible = False
        Gifs5_1100.Visible = False
        Gifs5_1200.Visible = False
        Gifs5_1300.Visible = False
        Gifs5_1400.Visible = False
        Gifs5_1500.Visible = False
        Gifs5_1600.Visible = False
        Gifs5_1700.Visible = False
        Gifs5_1800.Visible = False
        Gifs5_1900.Visible = False
        Gifs5_1a00.Visible = False
        Gifs5_1b00.Visible = False
        Gifs6_FFFF.Visible = False
        Gifs6_0000.Visible = False
        Gifs6_0100.Visible = False
        Gifs6_0200.Visible = False
        Gifs6_0300.Visible = False
        Gifs6_0400.Visible = False
        Gifs6_0500.Visible = False
        Gifs6_0600.Visible = False
        Gifs6_0700.Visible = False
        Gifs6_0800.Visible = False
        Gifs6_0900.Visible = False
        Gifs6_0a00.Visible = False
        Gifs6_0b00.Visible = False
        Gifs6_0c00.Visible = False
        Gifs6_0d00.Visible = False
        Gifs6_0e00.Visible = False
        Gifs6_0f00.Visible = False
        Gifs6_1000.Visible = False
        Gifs6_1100.Visible = False
        Gifs6_1200.Visible = False
        Gifs6_1300.Visible = False
        Gifs6_1400.Visible = False
        Gifs6_1500.Visible = False
        Gifs6_1600.Visible = False
        Gifs6_1700.Visible = False
        Gifs6_1800.Visible = False
        Gifs6_1900.Visible = False
        Gifs6_1a00.Visible = False
        Gifs6_1b00.Visible = False
        Gifs7_FFFF.Visible = False
        Gifs7_0000.Visible = False
        Gifs7_0100.Visible = False
        Gifs7_0200.Visible = False
        Gifs7_0300.Visible = False
        Gifs7_0400.Visible = False
        Gifs7_0500.Visible = False
        Gifs7_0600.Visible = False
        Gifs7_0700.Visible = False
        Gifs7_0800.Visible = False
        Gifs7_0900.Visible = False
        Gifs7_0a00.Visible = False
        Gifs7_0b00.Visible = False
        Gifs7_0c00.Visible = False
        Gifs7_0d00.Visible = False
        Gifs7_0e00.Visible = False
        Gifs7_0f00.Visible = False
        Gifs7_1000.Visible = False
        Gifs7_1100.Visible = False
        Gifs7_1200.Visible = False
        Gifs7_1300.Visible = False
        Gifs7_1400.Visible = False
        Gifs7_1500.Visible = False
        Gifs7_1600.Visible = False
        Gifs7_1700.Visible = False
        Gifs7_1800.Visible = False
        Gifs7_1900.Visible = False
        Gifs7_1a00.Visible = False
        Gifs7_1b00.Visible = False
        Gifs8_FFFF.Visible = False
        Gifs8_0000.Visible = False
        Gifs8_0100.Visible = False
        Gifs8_0200.Visible = False
        Gifs8_0300.Visible = False
        Gifs8_0400.Visible = False
        Gifs8_0500.Visible = False
        Gifs8_0600.Visible = False
        Gifs8_0700.Visible = False
        Gifs8_0800.Visible = False
        Gifs8_0900.Visible = False
        Gifs8_0a00.Visible = False
        Gifs8_0b00.Visible = False
        Gifs8_0c00.Visible = False
        Gifs8_0d00.Visible = False
        Gifs8_0e00.Visible = False
        Gifs8_0f00.Visible = False
        Gifs8_1000.Visible = False
        Gifs8_1100.Visible = False
        Gifs8_1200.Visible = False
        Gifs8_1300.Visible = False
        Gifs8_1400.Visible = False
        Gifs8_1500.Visible = False
        Gifs8_1600.Visible = False
        Gifs8_1700.Visible = False
        Gifs8_1800.Visible = False
        Gifs8_1900.Visible = False
        Gifs8_1a00.Visible = False
        Gifs8_1b00.Visible = False
    End Sub

    Private Sub Icon_itemmii_1_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_1.Click
        Hidegifts()
        Gifs1_FFFF.Visible = True
        Gifs1_0000.Visible = True
        Gifs1_0100.Visible = True
        Gifs1_0200.Visible = True
        Gifs1_0300.Visible = True
        Gifs1_0400.Visible = True
        Gifs1_0500.Visible = True
        Gifs1_0600.Visible = True
        Gifs1_0700.Visible = True
        Gifs1_0800.Visible = True
        Gifs1_0900.Visible = True
        Gifs1_0a00.Visible = True
        Gifs1_0b00.Visible = True
        Gifs1_0c00.Visible = True
        Gifs1_0d00.Visible = True
        Gifs1_0e00.Visible = True
        Gifs1_0f00.Visible = True
        Gifs1_1000.Visible = True
        Gifs1_1100.Visible = True
        Gifs1_1200.Visible = True
        Gifs1_1300.Visible = True
        Gifs1_1400.Visible = True
        Gifs1_1500.Visible = True
        Gifs1_1600.Visible = True
        Gifs1_1700.Visible = True
        Gifs1_1800.Visible = True
        Gifs1_1900.Visible = True
        Gifs1_1a00.Visible = True
        Gifs1_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Icon_itemmii_2_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_2.Click
        Hidegifts()
        Gifs2_FFFF.Visible = True
        Gifs2_0000.Visible = True
        Gifs2_0100.Visible = True
        Gifs2_0200.Visible = True
        Gifs2_0300.Visible = True
        Gifs2_0400.Visible = True
        Gifs2_0500.Visible = True
        Gifs2_0600.Visible = True
        Gifs2_0700.Visible = True
        Gifs2_0800.Visible = True
        Gifs2_0900.Visible = True
        Gifs2_0a00.Visible = True
        Gifs2_0b00.Visible = True
        Gifs2_0c00.Visible = True
        Gifs2_0d00.Visible = True
        Gifs2_0e00.Visible = True
        Gifs2_0f00.Visible = True
        Gifs2_1000.Visible = True
        Gifs2_1100.Visible = True
        Gifs2_1200.Visible = True
        Gifs2_1300.Visible = True
        Gifs2_1400.Visible = True
        Gifs2_1500.Visible = True
        Gifs2_1600.Visible = True
        Gifs2_1700.Visible = True
        Gifs2_1800.Visible = True
        Gifs2_1900.Visible = True
        Gifs2_1a00.Visible = True
        Gifs2_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Icon_itemmii_3_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_3.Click
        Hidegifts()
        Gifs3_FFFF.Visible = True
        Gifs3_0000.Visible = True
        Gifs3_0100.Visible = True
        Gifs3_0200.Visible = True
        Gifs3_0300.Visible = True
        Gifs3_0400.Visible = True
        Gifs3_0500.Visible = True
        Gifs3_0600.Visible = True
        Gifs3_0700.Visible = True
        Gifs3_0800.Visible = True
        Gifs3_0900.Visible = True
        Gifs3_0a00.Visible = True
        Gifs3_0b00.Visible = True
        Gifs3_0c00.Visible = True
        Gifs3_0d00.Visible = True
        Gifs3_0e00.Visible = True
        Gifs3_0f00.Visible = True
        Gifs3_1000.Visible = True
        Gifs3_1100.Visible = True
        Gifs3_1200.Visible = True
        Gifs3_1300.Visible = True
        Gifs3_1400.Visible = True
        Gifs3_1500.Visible = True
        Gifs3_1600.Visible = True
        Gifs3_1700.Visible = True
        Gifs3_1800.Visible = True
        Gifs3_1900.Visible = True
        Gifs3_1a00.Visible = True
        Gifs3_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Icon_itemmii_4_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_4.Click
        Hidegifts()
        Gifs4_FFFF.Visible = True
        Gifs4_0000.Visible = True
        Gifs4_0100.Visible = True
        Gifs4_0200.Visible = True
        Gifs4_0300.Visible = True
        Gifs4_0400.Visible = True
        Gifs4_0500.Visible = True
        Gifs4_0600.Visible = True
        Gifs4_0700.Visible = True
        Gifs4_0800.Visible = True
        Gifs4_0900.Visible = True
        Gifs4_0a00.Visible = True
        Gifs4_0b00.Visible = True
        Gifs4_0c00.Visible = True
        Gifs4_0d00.Visible = True
        Gifs4_0e00.Visible = True
        Gifs4_0f00.Visible = True
        Gifs4_1000.Visible = True
        Gifs4_1100.Visible = True
        Gifs4_1200.Visible = True
        Gifs4_1300.Visible = True
        Gifs4_1400.Visible = True
        Gifs4_1500.Visible = True
        Gifs4_1600.Visible = True
        Gifs4_1700.Visible = True
        Gifs4_1800.Visible = True
        Gifs4_1900.Visible = True
        Gifs4_1a00.Visible = True
        Gifs4_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Icon_itemmii_5_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_5.Click
        Hidegifts()
        Gifs5_FFFF.Visible = True
        Gifs5_0000.Visible = True
        Gifs5_0100.Visible = True
        Gifs5_0200.Visible = True
        Gifs5_0300.Visible = True
        Gifs5_0400.Visible = True
        Gifs5_0500.Visible = True
        Gifs5_0600.Visible = True
        Gifs5_0700.Visible = True
        Gifs5_0800.Visible = True
        Gifs5_0900.Visible = True
        Gifs5_0a00.Visible = True
        Gifs5_0b00.Visible = True
        Gifs5_0c00.Visible = True
        Gifs5_0d00.Visible = True
        Gifs5_0e00.Visible = True
        Gifs5_0f00.Visible = True
        Gifs5_1000.Visible = True
        Gifs5_1100.Visible = True
        Gifs5_1200.Visible = True
        Gifs5_1300.Visible = True
        Gifs5_1400.Visible = True
        Gifs5_1500.Visible = True
        Gifs5_1600.Visible = True
        Gifs5_1700.Visible = True
        Gifs5_1800.Visible = True
        Gifs5_1900.Visible = True
        Gifs5_1a00.Visible = True
        Gifs5_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Icon_itemmii_6_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_6.Click
        Hidegifts()
        Gifs6_FFFF.Visible = True
        Gifs6_0000.Visible = True
        Gifs6_0100.Visible = True
        Gifs6_0200.Visible = True
        Gifs6_0300.Visible = True
        Gifs6_0400.Visible = True
        Gifs6_0500.Visible = True
        Gifs6_0600.Visible = True
        Gifs6_0700.Visible = True
        Gifs6_0800.Visible = True
        Gifs6_0900.Visible = True
        Gifs6_0a00.Visible = True
        Gifs6_0b00.Visible = True
        Gifs6_0c00.Visible = True
        Gifs6_0d00.Visible = True
        Gifs6_0e00.Visible = True
        Gifs6_0f00.Visible = True
        Gifs6_1000.Visible = True
        Gifs6_1100.Visible = True
        Gifs6_1200.Visible = True
        Gifs6_1300.Visible = True
        Gifs6_1400.Visible = True
        Gifs6_1500.Visible = True
        Gifs6_1600.Visible = True
        Gifs6_1700.Visible = True
        Gifs6_1800.Visible = True
        Gifs6_1900.Visible = True
        Gifs6_1a00.Visible = True
        Gifs6_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Icon_itemmii_7_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_7.Click
        Hidegifts()
        Gifs7_FFFF.Visible = True
        Gifs7_0000.Visible = True
        Gifs7_0100.Visible = True
        Gifs7_0200.Visible = True
        Gifs7_0300.Visible = True
        Gifs7_0400.Visible = True
        Gifs7_0500.Visible = True
        Gifs7_0600.Visible = True
        Gifs7_0700.Visible = True
        Gifs7_0800.Visible = True
        Gifs7_0900.Visible = True
        Gifs7_0a00.Visible = True
        Gifs7_0b00.Visible = True
        Gifs7_0c00.Visible = True
        Gifs7_0d00.Visible = True
        Gifs7_0e00.Visible = True
        Gifs7_0f00.Visible = True
        Gifs7_1000.Visible = True
        Gifs7_1100.Visible = True
        Gifs7_1200.Visible = True
        Gifs7_1300.Visible = True
        Gifs7_1400.Visible = True
        Gifs7_1500.Visible = True
        Gifs7_1600.Visible = True
        Gifs7_1700.Visible = True
        Gifs7_1800.Visible = True
        Gifs7_1900.Visible = True
        Gifs7_1a00.Visible = True
        Gifs7_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Icon_itemmii_8_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_8.Click
        Hidegifts()
        Gifs8_FFFF.Visible = True
        Gifs8_0000.Visible = True
        Gifs8_0100.Visible = True
        Gifs8_0200.Visible = True
        Gifs8_0300.Visible = True
        Gifs8_0400.Visible = True
        Gifs8_0500.Visible = True
        Gifs8_0600.Visible = True
        Gifs8_0700.Visible = True
        Gifs8_0800.Visible = True
        Gifs8_0900.Visible = True
        Gifs8_0a00.Visible = True
        Gifs8_0b00.Visible = True
        Gifs8_0c00.Visible = True
        Gifs8_0d00.Visible = True
        Gifs8_0e00.Visible = True
        Gifs8_0f00.Visible = True
        Gifs8_1000.Visible = True
        Gifs8_1100.Visible = True
        Gifs8_1200.Visible = True
        Gifs8_1300.Visible = True
        Gifs8_1400.Visible = True
        Gifs8_1500.Visible = True
        Gifs8_1600.Visible = True
        Gifs8_1700.Visible = True
        Gifs8_1800.Visible = True
        Gifs8_1900.Visible = True
        Gifs8_1a00.Visible = True
        Gifs8_1b00.Visible = True
        Panel_edit_gifs.Visible = True
    End Sub

    Private Sub Gifs1_0000_Click(sender As Object, e As EventArgs) Handles Gifs1_0000.Click
        valu_itemmii_1.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0100_Click(sender As Object, e As EventArgs) Handles Gifs1_0100.Click
        valu_itemmii_1.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0200_Click(sender As Object, e As EventArgs) Handles Gifs1_0200.Click
        valu_itemmii_1.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0300_Click(sender As Object, e As EventArgs) Handles Gifs1_0300.Click
        valu_itemmii_1.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0400_Click(sender As Object, e As EventArgs) Handles Gifs1_0400.Click
        valu_itemmii_1.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0500_Click(sender As Object, e As EventArgs) Handles Gifs1_0500.Click
        valu_itemmii_1.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0600_Click(sender As Object, e As EventArgs) Handles Gifs1_0600.Click
        valu_itemmii_1.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0700_Click(sender As Object, e As EventArgs) Handles Gifs1_0700.Click
        valu_itemmii_1.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0800_Click(sender As Object, e As EventArgs) Handles Gifs1_0800.Click
        valu_itemmii_1.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0900_Click(sender As Object, e As EventArgs) Handles Gifs1_0900.Click
        valu_itemmii_1.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0a00_Click(sender As Object, e As EventArgs) Handles Gifs1_0a00.Click
        valu_itemmii_1.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0b00_Click(sender As Object, e As EventArgs) Handles Gifs1_0b00.Click
        valu_itemmii_1.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0c00_Click(sender As Object, e As EventArgs) Handles Gifs1_0c00.Click
        valu_itemmii_1.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0d00_Click(sender As Object, e As EventArgs) Handles Gifs1_0d00.Click
        valu_itemmii_1.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0e00_Click(sender As Object, e As EventArgs) Handles Gifs1_0e00.Click
        valu_itemmii_1.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_0f00_Click(sender As Object, e As EventArgs) Handles Gifs1_0f00.Click
        valu_itemmii_1.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1000_Click(sender As Object, e As EventArgs) Handles Gifs1_1000.Click
        valu_itemmii_1.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1100_Click(sender As Object, e As EventArgs) Handles Gifs1_1100.Click
        valu_itemmii_1.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1200_Click(sender As Object, e As EventArgs) Handles Gifs1_1200.Click
        valu_itemmii_1.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1300_Click(sender As Object, e As EventArgs) Handles Gifs1_1300.Click
        valu_itemmii_1.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1400_Click(sender As Object, e As EventArgs) Handles Gifs1_1400.Click
        valu_itemmii_1.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1500_Click(sender As Object, e As EventArgs) Handles Gifs1_1500.Click
        valu_itemmii_1.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1600_Click(sender As Object, e As EventArgs) Handles Gifs1_1600.Click
        valu_itemmii_1.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1700_Click(sender As Object, e As EventArgs) Handles Gifs1_1700.Click
        valu_itemmii_1.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1800_Click(sender As Object, e As EventArgs) Handles Gifs1_1800.Click
        valu_itemmii_1.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1900_Click(sender As Object, e As EventArgs) Handles Gifs1_1900.Click
        valu_itemmii_1.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1a00_Click(sender As Object, e As EventArgs) Handles Gifs1_1a00.Click
        valu_itemmii_1.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_1b00_Click(sender As Object, e As EventArgs) Handles Gifs1_1b00.Click
        valu_itemmii_1.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs1_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs1_FFFF.Click
        valu_itemmii_1.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0000_Click(sender As Object, e As EventArgs) Handles Gifs2_0000.Click
        valu_itemmii_2.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0100_Click(sender As Object, e As EventArgs) Handles Gifs2_0100.Click
        valu_itemmii_2.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0200_Click(sender As Object, e As EventArgs) Handles Gifs2_0200.Click
        valu_itemmii_2.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0300_Click(sender As Object, e As EventArgs) Handles Gifs2_0300.Click
        valu_itemmii_2.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0400_Click(sender As Object, e As EventArgs) Handles Gifs2_0400.Click
        valu_itemmii_2.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0500_Click(sender As Object, e As EventArgs) Handles Gifs2_0500.Click
        valu_itemmii_2.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0600_Click(sender As Object, e As EventArgs) Handles Gifs2_0600.Click
        valu_itemmii_2.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0700_Click(sender As Object, e As EventArgs) Handles Gifs2_0700.Click
        valu_itemmii_2.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0800_Click(sender As Object, e As EventArgs) Handles Gifs2_0800.Click
        valu_itemmii_2.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0900_Click(sender As Object, e As EventArgs) Handles Gifs2_0900.Click
        valu_itemmii_2.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0a00_Click(sender As Object, e As EventArgs) Handles Gifs2_0a00.Click
        valu_itemmii_2.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0b00_Click(sender As Object, e As EventArgs) Handles Gifs2_0b00.Click
        valu_itemmii_2.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0c00_Click(sender As Object, e As EventArgs) Handles Gifs2_0c00.Click
        valu_itemmii_2.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0d00_Click(sender As Object, e As EventArgs) Handles Gifs2_0d00.Click
        valu_itemmii_2.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0e00_Click(sender As Object, e As EventArgs) Handles Gifs2_0e00.Click
        valu_itemmii_2.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_0f00_Click(sender As Object, e As EventArgs) Handles Gifs2_0f00.Click
        valu_itemmii_2.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1000_Click(sender As Object, e As EventArgs) Handles Gifs2_1000.Click
        valu_itemmii_2.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1100_Click(sender As Object, e As EventArgs) Handles Gifs2_1100.Click
        valu_itemmii_2.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1200_Click(sender As Object, e As EventArgs) Handles Gifs2_1200.Click
        valu_itemmii_2.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1300_Click(sender As Object, e As EventArgs) Handles Gifs2_1300.Click
        valu_itemmii_2.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1400_Click(sender As Object, e As EventArgs) Handles Gifs2_1400.Click
        valu_itemmii_2.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1500_Click(sender As Object, e As EventArgs) Handles Gifs2_1500.Click
        valu_itemmii_2.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1600_Click(sender As Object, e As EventArgs) Handles Gifs2_1600.Click
        valu_itemmii_2.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1700_Click(sender As Object, e As EventArgs) Handles Gifs2_1700.Click
        valu_itemmii_2.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1800_Click(sender As Object, e As EventArgs) Handles Gifs2_1800.Click
        valu_itemmii_2.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1900_Click(sender As Object, e As EventArgs) Handles Gifs2_1900.Click
        valu_itemmii_2.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1a00_Click(sender As Object, e As EventArgs) Handles Gifs2_1a00.Click
        valu_itemmii_2.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_1b00_Click(sender As Object, e As EventArgs) Handles Gifs2_1b00.Click
        valu_itemmii_2.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs2_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs2_FFFF.Click
        valu_itemmii_2.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0000_Click(sender As Object, e As EventArgs) Handles Gifs3_0000.Click
        valu_itemmii_3.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0100_Click(sender As Object, e As EventArgs) Handles Gifs3_0100.Click
        valu_itemmii_3.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0200_Click(sender As Object, e As EventArgs) Handles Gifs3_0200.Click
        valu_itemmii_3.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0300_Click(sender As Object, e As EventArgs) Handles Gifs3_0300.Click
        valu_itemmii_3.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0400_Click(sender As Object, e As EventArgs) Handles Gifs3_0400.Click
        valu_itemmii_3.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0500_Click(sender As Object, e As EventArgs) Handles Gifs3_0500.Click
        valu_itemmii_3.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0600_Click(sender As Object, e As EventArgs) Handles Gifs3_0600.Click
        valu_itemmii_3.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0700_Click(sender As Object, e As EventArgs) Handles Gifs3_0700.Click
        valu_itemmii_3.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0800_Click(sender As Object, e As EventArgs) Handles Gifs3_0800.Click
        valu_itemmii_3.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0900_Click(sender As Object, e As EventArgs) Handles Gifs3_0900.Click
        valu_itemmii_3.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0a00_Click(sender As Object, e As EventArgs) Handles Gifs3_0a00.Click
        valu_itemmii_3.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0b00_Click(sender As Object, e As EventArgs) Handles Gifs3_0b00.Click
        valu_itemmii_3.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0c00_Click(sender As Object, e As EventArgs) Handles Gifs3_0c00.Click
        valu_itemmii_3.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0d00_Click(sender As Object, e As EventArgs) Handles Gifs3_0d00.Click
        valu_itemmii_3.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0e00_Click(sender As Object, e As EventArgs) Handles Gifs3_0e00.Click
        valu_itemmii_3.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_0f00_Click(sender As Object, e As EventArgs) Handles Gifs3_0f00.Click
        valu_itemmii_3.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1000_Click(sender As Object, e As EventArgs) Handles Gifs3_1000.Click
        valu_itemmii_3.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1100_Click(sender As Object, e As EventArgs) Handles Gifs3_1100.Click
        valu_itemmii_3.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1200_Click(sender As Object, e As EventArgs) Handles Gifs3_1200.Click
        valu_itemmii_3.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1300_Click(sender As Object, e As EventArgs) Handles Gifs3_1300.Click
        valu_itemmii_3.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1400_Click(sender As Object, e As EventArgs) Handles Gifs3_1400.Click
        valu_itemmii_3.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1500_Click(sender As Object, e As EventArgs) Handles Gifs3_1500.Click
        valu_itemmii_3.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1600_Click(sender As Object, e As EventArgs) Handles Gifs3_1600.Click
        valu_itemmii_3.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1700_Click(sender As Object, e As EventArgs) Handles Gifs3_1700.Click
        valu_itemmii_3.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1800_Click(sender As Object, e As EventArgs) Handles Gifs3_1800.Click
        valu_itemmii_3.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1900_Click(sender As Object, e As EventArgs) Handles Gifs3_1900.Click
        valu_itemmii_3.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1a00_Click(sender As Object, e As EventArgs) Handles Gifs3_1a00.Click
        valu_itemmii_3.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_1b00_Click(sender As Object, e As EventArgs) Handles Gifs3_1b00.Click
        valu_itemmii_3.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs3_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs3_FFFF.Click
        valu_itemmii_3.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0000_Click(sender As Object, e As EventArgs) Handles Gifs4_0000.Click
        valu_itemmii_4.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0100_Click(sender As Object, e As EventArgs) Handles Gifs4_0100.Click
        valu_itemmii_4.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0200_Click(sender As Object, e As EventArgs) Handles Gifs4_0200.Click
        valu_itemmii_4.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0300_Click(sender As Object, e As EventArgs) Handles Gifs4_0300.Click
        valu_itemmii_4.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0400_Click(sender As Object, e As EventArgs) Handles Gifs4_0400.Click
        valu_itemmii_4.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0500_Click(sender As Object, e As EventArgs) Handles Gifs4_0500.Click
        valu_itemmii_4.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0600_Click(sender As Object, e As EventArgs) Handles Gifs4_0600.Click
        valu_itemmii_4.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0700_Click(sender As Object, e As EventArgs) Handles Gifs4_0700.Click
        valu_itemmii_4.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0800_Click(sender As Object, e As EventArgs) Handles Gifs4_0800.Click
        valu_itemmii_4.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0900_Click(sender As Object, e As EventArgs) Handles Gifs4_0900.Click
        valu_itemmii_4.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0a00_Click(sender As Object, e As EventArgs) Handles Gifs4_0a00.Click
        valu_itemmii_4.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0b00_Click(sender As Object, e As EventArgs) Handles Gifs4_0b00.Click
        valu_itemmii_4.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0c00_Click(sender As Object, e As EventArgs) Handles Gifs4_0c00.Click
        valu_itemmii_4.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0d00_Click(sender As Object, e As EventArgs) Handles Gifs4_0d00.Click
        valu_itemmii_4.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0e00_Click(sender As Object, e As EventArgs) Handles Gifs4_0e00.Click
        valu_itemmii_4.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_0f00_Click(sender As Object, e As EventArgs) Handles Gifs4_0f00.Click
        valu_itemmii_4.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1000_Click(sender As Object, e As EventArgs) Handles Gifs4_1000.Click
        valu_itemmii_4.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1100_Click(sender As Object, e As EventArgs) Handles Gifs4_1100.Click
        valu_itemmii_4.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1200_Click(sender As Object, e As EventArgs) Handles Gifs4_1200.Click
        valu_itemmii_4.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1300_Click(sender As Object, e As EventArgs) Handles Gifs4_1300.Click
        valu_itemmii_4.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1400_Click(sender As Object, e As EventArgs) Handles Gifs4_1400.Click
        valu_itemmii_4.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1500_Click(sender As Object, e As EventArgs) Handles Gifs4_1500.Click
        valu_itemmii_4.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1600_Click(sender As Object, e As EventArgs) Handles Gifs4_1600.Click
        valu_itemmii_4.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1700_Click(sender As Object, e As EventArgs) Handles Gifs4_1700.Click
        valu_itemmii_4.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1800_Click(sender As Object, e As EventArgs) Handles Gifs4_1800.Click
        valu_itemmii_4.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1900_Click(sender As Object, e As EventArgs) Handles Gifs4_1900.Click
        valu_itemmii_4.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1a00_Click(sender As Object, e As EventArgs) Handles Gifs4_1a00.Click
        valu_itemmii_4.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_1b00_Click(sender As Object, e As EventArgs) Handles Gifs4_1b00.Click
        valu_itemmii_4.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs4_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs4_FFFF.Click
        valu_itemmii_4.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0000_Click(sender As Object, e As EventArgs) Handles Gifs5_0000.Click
        valu_itemmii_5.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0100_Click(sender As Object, e As EventArgs) Handles Gifs5_0100.Click
        valu_itemmii_5.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0200_Click(sender As Object, e As EventArgs) Handles Gifs5_0200.Click
        valu_itemmii_5.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0300_Click(sender As Object, e As EventArgs) Handles Gifs5_0300.Click
        valu_itemmii_5.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0400_Click(sender As Object, e As EventArgs) Handles Gifs5_0400.Click
        valu_itemmii_5.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0500_Click(sender As Object, e As EventArgs) Handles Gifs5_0500.Click
        valu_itemmii_5.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0600_Click(sender As Object, e As EventArgs) Handles Gifs5_0600.Click
        valu_itemmii_5.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0700_Click(sender As Object, e As EventArgs) Handles Gifs5_0700.Click
        valu_itemmii_5.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0800_Click(sender As Object, e As EventArgs) Handles Gifs5_0800.Click
        valu_itemmii_5.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0900_Click(sender As Object, e As EventArgs) Handles Gifs5_0900.Click
        valu_itemmii_5.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0a00_Click(sender As Object, e As EventArgs) Handles Gifs5_0a00.Click
        valu_itemmii_5.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0b00_Click(sender As Object, e As EventArgs) Handles Gifs5_0b00.Click
        valu_itemmii_5.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0c00_Click(sender As Object, e As EventArgs) Handles Gifs5_0c00.Click
        valu_itemmii_5.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0d00_Click(sender As Object, e As EventArgs) Handles Gifs5_0d00.Click
        valu_itemmii_5.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0e00_Click(sender As Object, e As EventArgs) Handles Gifs5_0e00.Click
        valu_itemmii_5.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_0f00_Click(sender As Object, e As EventArgs) Handles Gifs5_0f00.Click
        valu_itemmii_5.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1000_Click(sender As Object, e As EventArgs) Handles Gifs5_1000.Click
        valu_itemmii_5.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1100_Click(sender As Object, e As EventArgs) Handles Gifs5_1100.Click
        valu_itemmii_5.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1200_Click(sender As Object, e As EventArgs) Handles Gifs5_1200.Click
        valu_itemmii_5.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1300_Click(sender As Object, e As EventArgs) Handles Gifs5_1300.Click
        valu_itemmii_5.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1400_Click(sender As Object, e As EventArgs) Handles Gifs5_1400.Click
        valu_itemmii_5.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1500_Click(sender As Object, e As EventArgs) Handles Gifs5_1500.Click
        valu_itemmii_5.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1600_Click(sender As Object, e As EventArgs) Handles Gifs5_1600.Click
        valu_itemmii_5.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1700_Click(sender As Object, e As EventArgs) Handles Gifs5_1700.Click
        valu_itemmii_5.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1800_Click(sender As Object, e As EventArgs) Handles Gifs5_1800.Click
        valu_itemmii_5.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1900_Click(sender As Object, e As EventArgs) Handles Gifs5_1900.Click
        valu_itemmii_5.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1a00_Click(sender As Object, e As EventArgs) Handles Gifs5_1a00.Click
        valu_itemmii_5.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_1b00_Click(sender As Object, e As EventArgs) Handles Gifs5_1b00.Click
        valu_itemmii_5.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs5_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs5_FFFF.Click
        valu_itemmii_5.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0000_Click(sender As Object, e As EventArgs) Handles Gifs6_0000.Click
        valu_itemmii_6.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0100_Click(sender As Object, e As EventArgs) Handles Gifs6_0100.Click
        valu_itemmii_6.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0200_Click(sender As Object, e As EventArgs) Handles Gifs6_0200.Click
        valu_itemmii_6.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0300_Click(sender As Object, e As EventArgs) Handles Gifs6_0300.Click
        valu_itemmii_6.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0400_Click(sender As Object, e As EventArgs) Handles Gifs6_0400.Click
        valu_itemmii_6.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0500_Click(sender As Object, e As EventArgs) Handles Gifs6_0500.Click
        valu_itemmii_6.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0600_Click(sender As Object, e As EventArgs) Handles Gifs6_0600.Click
        valu_itemmii_6.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0700_Click(sender As Object, e As EventArgs) Handles Gifs6_0700.Click
        valu_itemmii_6.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0800_Click(sender As Object, e As EventArgs) Handles Gifs6_0800.Click
        valu_itemmii_6.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0900_Click(sender As Object, e As EventArgs) Handles Gifs6_0900.Click
        valu_itemmii_6.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0a00_Click(sender As Object, e As EventArgs) Handles Gifs6_0a00.Click
        valu_itemmii_6.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0b00_Click(sender As Object, e As EventArgs) Handles Gifs6_0b00.Click
        valu_itemmii_6.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0c00_Click(sender As Object, e As EventArgs) Handles Gifs6_0c00.Click
        valu_itemmii_6.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0d00_Click(sender As Object, e As EventArgs) Handles Gifs6_0d00.Click
        valu_itemmii_6.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0e00_Click(sender As Object, e As EventArgs) Handles Gifs6_0e00.Click
        valu_itemmii_6.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_0f00_Click(sender As Object, e As EventArgs) Handles Gifs6_0f00.Click
        valu_itemmii_6.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1000_Click(sender As Object, e As EventArgs) Handles Gifs6_1000.Click
        valu_itemmii_6.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1100_Click(sender As Object, e As EventArgs) Handles Gifs6_1100.Click
        valu_itemmii_6.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1200_Click(sender As Object, e As EventArgs) Handles Gifs6_1200.Click
        valu_itemmii_6.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1300_Click(sender As Object, e As EventArgs) Handles Gifs6_1300.Click
        valu_itemmii_6.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1400_Click(sender As Object, e As EventArgs) Handles Gifs6_1400.Click
        valu_itemmii_6.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1500_Click(sender As Object, e As EventArgs) Handles Gifs6_1500.Click
        valu_itemmii_6.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1600_Click(sender As Object, e As EventArgs) Handles Gifs6_1600.Click
        valu_itemmii_6.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1700_Click(sender As Object, e As EventArgs) Handles Gifs6_1700.Click
        valu_itemmii_6.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1800_Click(sender As Object, e As EventArgs) Handles Gifs6_1800.Click
        valu_itemmii_6.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1900_Click(sender As Object, e As EventArgs) Handles Gifs6_1900.Click
        valu_itemmii_6.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1a00_Click(sender As Object, e As EventArgs) Handles Gifs6_1a00.Click
        valu_itemmii_6.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_1b00_Click(sender As Object, e As EventArgs) Handles Gifs6_1b00.Click
        valu_itemmii_6.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs6_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs6_FFFF.Click
        valu_itemmii_6.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0000_Click(sender As Object, e As EventArgs) Handles Gifs7_0000.Click
        valu_itemmii_7.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0100_Click(sender As Object, e As EventArgs) Handles Gifs7_0100.Click
        valu_itemmii_7.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0200_Click(sender As Object, e As EventArgs) Handles Gifs7_0200.Click
        valu_itemmii_7.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0300_Click(sender As Object, e As EventArgs) Handles Gifs7_0300.Click
        valu_itemmii_7.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0400_Click(sender As Object, e As EventArgs) Handles Gifs7_0400.Click
        valu_itemmii_7.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0500_Click(sender As Object, e As EventArgs) Handles Gifs7_0500.Click
        valu_itemmii_7.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0600_Click(sender As Object, e As EventArgs) Handles Gifs7_0600.Click
        valu_itemmii_7.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0700_Click(sender As Object, e As EventArgs) Handles Gifs7_0700.Click
        valu_itemmii_7.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0800_Click(sender As Object, e As EventArgs) Handles Gifs7_0800.Click
        valu_itemmii_7.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0900_Click(sender As Object, e As EventArgs) Handles Gifs7_0900.Click
        valu_itemmii_7.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0a00_Click(sender As Object, e As EventArgs) Handles Gifs7_0a00.Click
        valu_itemmii_7.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0b00_Click(sender As Object, e As EventArgs) Handles Gifs7_0b00.Click
        valu_itemmii_7.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0c00_Click(sender As Object, e As EventArgs) Handles Gifs7_0c00.Click
        valu_itemmii_7.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0d00_Click(sender As Object, e As EventArgs) Handles Gifs7_0d00.Click
        valu_itemmii_7.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0e00_Click(sender As Object, e As EventArgs) Handles Gifs7_0e00.Click
        valu_itemmii_7.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_0f00_Click(sender As Object, e As EventArgs) Handles Gifs7_0f00.Click
        valu_itemmii_7.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1000_Click(sender As Object, e As EventArgs) Handles Gifs7_1000.Click
        valu_itemmii_7.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1100_Click(sender As Object, e As EventArgs) Handles Gifs7_1100.Click
        valu_itemmii_7.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1200_Click(sender As Object, e As EventArgs) Handles Gifs7_1200.Click
        valu_itemmii_7.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1300_Click(sender As Object, e As EventArgs) Handles Gifs7_1300.Click
        valu_itemmii_7.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1400_Click(sender As Object, e As EventArgs) Handles Gifs7_1400.Click
        valu_itemmii_7.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1500_Click(sender As Object, e As EventArgs) Handles Gifs7_1500.Click
        valu_itemmii_7.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1600_Click(sender As Object, e As EventArgs) Handles Gifs7_1600.Click
        valu_itemmii_7.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1700_Click(sender As Object, e As EventArgs) Handles Gifs7_1700.Click
        valu_itemmii_7.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1800_Click(sender As Object, e As EventArgs) Handles Gifs7_1800.Click
        valu_itemmii_7.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1900_Click(sender As Object, e As EventArgs) Handles Gifs7_1900.Click
        valu_itemmii_7.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1a00_Click(sender As Object, e As EventArgs) Handles Gifs7_1a00.Click
        valu_itemmii_7.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_1b00_Click(sender As Object, e As EventArgs) Handles Gifs7_1b00.Click
        valu_itemmii_7.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs7_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs7_FFFF.Click
        valu_itemmii_7.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0000_Click(sender As Object, e As EventArgs) Handles Gifs8_0000.Click
        valu_itemmii_8.Value = &H0
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0100_Click(sender As Object, e As EventArgs) Handles Gifs8_0100.Click
        valu_itemmii_8.Value = &H1
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0200_Click(sender As Object, e As EventArgs) Handles Gifs8_0200.Click
        valu_itemmii_8.Value = &H2
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0300_Click(sender As Object, e As EventArgs) Handles Gifs8_0300.Click
        valu_itemmii_8.Value = &H3
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0400_Click(sender As Object, e As EventArgs) Handles Gifs8_0400.Click
        valu_itemmii_8.Value = &H4
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0500_Click(sender As Object, e As EventArgs) Handles Gifs8_0500.Click
        valu_itemmii_8.Value = &H5
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0600_Click(sender As Object, e As EventArgs) Handles Gifs8_0600.Click
        valu_itemmii_8.Value = &H6
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0700_Click(sender As Object, e As EventArgs) Handles Gifs8_0700.Click
        valu_itemmii_8.Value = &H7
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0800_Click(sender As Object, e As EventArgs) Handles Gifs8_0800.Click
        valu_itemmii_8.Value = &H8
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0900_Click(sender As Object, e As EventArgs) Handles Gifs8_0900.Click
        valu_itemmii_8.Value = &H9
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0a00_Click(sender As Object, e As EventArgs) Handles Gifs8_0a00.Click
        valu_itemmii_8.Value = &HA
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0b00_Click(sender As Object, e As EventArgs) Handles Gifs8_0b00.Click
        valu_itemmii_8.Value = &HB
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0c00_Click(sender As Object, e As EventArgs) Handles Gifs8_0c00.Click
        valu_itemmii_8.Value = &HC
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0d00_Click(sender As Object, e As EventArgs) Handles Gifs8_0d00.Click
        valu_itemmii_8.Value = &HD
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0e00_Click(sender As Object, e As EventArgs) Handles Gifs8_0e00.Click
        valu_itemmii_8.Value = &HE
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_0f00_Click(sender As Object, e As EventArgs) Handles Gifs8_0f00.Click
        valu_itemmii_8.Value = &HF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1000_Click(sender As Object, e As EventArgs) Handles Gifs8_1000.Click
        valu_itemmii_8.Value = &H10
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1100_Click(sender As Object, e As EventArgs) Handles Gifs8_1100.Click
        valu_itemmii_8.Value = &H11
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1200_Click(sender As Object, e As EventArgs) Handles Gifs8_1200.Click
        valu_itemmii_8.Value = &H12
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1300_Click(sender As Object, e As EventArgs) Handles Gifs8_1300.Click
        valu_itemmii_8.Value = &H13
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1400_Click(sender As Object, e As EventArgs) Handles Gifs8_1400.Click
        valu_itemmii_8.Value = &H14
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1500_Click(sender As Object, e As EventArgs) Handles Gifs8_1500.Click
        valu_itemmii_8.Value = &H15
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1600_Click(sender As Object, e As EventArgs) Handles Gifs8_1600.Click
        valu_itemmii_8.Value = &H16
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1700_Click(sender As Object, e As EventArgs) Handles Gifs8_1700.Click
        valu_itemmii_8.Value = &H17
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1800_Click(sender As Object, e As EventArgs) Handles Gifs8_1800.Click
        valu_itemmii_8.Value = &H18
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1900_Click(sender As Object, e As EventArgs) Handles Gifs8_1900.Click
        valu_itemmii_8.Value = &H19
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1a00_Click(sender As Object, e As EventArgs) Handles Gifs8_1a00.Click
        valu_itemmii_8.Value = &H1A
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_1b00_Click(sender As Object, e As EventArgs) Handles Gifs8_1b00.Click
        valu_itemmii_8.Value = &H1B
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub Gifs8_FFFF_Click(sender As Object, e As EventArgs) Handles Gifs8_FFFF.Click
        valu_itemmii_8.Value = &HFFFF
        Panel_edit_gifs.Visible = False
    End Sub

    Private Sub valu_itemmii_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_1.ValueChanged
        If valu_itemmii_1.Value = &H0 Then
            Icon_itemmii_1.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_1.Value = &H1 Then
            Icon_itemmii_1.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_1.Value = &H2 Then
            Icon_itemmii_1.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_1.Value = &H3 Then
            Icon_itemmii_1.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_1.Value = &H4 Then
            Icon_itemmii_1.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_1.Value = &H5 Then
            Icon_itemmii_1.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_1.Value = &H6 Then
            Icon_itemmii_1.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_1.Value = &H7 Then
            Icon_itemmii_1.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_1.Value = &H8 Then
            Icon_itemmii_1.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_1.Value = &H9 Then
            Icon_itemmii_1.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_1.Value = &HA Then
            Icon_itemmii_1.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_1.Value = &HB Then
            Icon_itemmii_1.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_1.Value = &HC Then
            Icon_itemmii_1.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_1.Value = &HD Then
            Icon_itemmii_1.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_1.Value = &HE Then
            Icon_itemmii_1.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_1.Value = &HF Then
            Icon_itemmii_1.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_1.Value = &H10 Then
            Icon_itemmii_1.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_1.Value = &H11 Then
            Icon_itemmii_1.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_1.Value = &H12 Then
            Icon_itemmii_1.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_1.Value = &H13 Then
            Icon_itemmii_1.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_1.Value = &H14 Then
            Icon_itemmii_1.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_1.Value = &H15 Then
            Icon_itemmii_1.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_1.Value = &H16 Then
            Icon_itemmii_1.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_1.Value = &H17 Then
            Icon_itemmii_1.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_1.Value = &H18 Then
            Icon_itemmii_1.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_1.Value = &H19 Then
            Icon_itemmii_1.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_1.Value = &H1A Then
            Icon_itemmii_1.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_1.Value = &H1B Then
            Icon_itemmii_1.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_1.Value = &HFFFF Then
            Icon_itemmii_1.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Private Sub valu_itemmii_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_2.ValueChanged
        If valu_itemmii_2.Value = &H0 Then
            Icon_itemmii_2.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_2.Value = &H1 Then
            Icon_itemmii_2.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_2.Value = &H2 Then
            Icon_itemmii_2.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_2.Value = &H3 Then
            Icon_itemmii_2.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_2.Value = &H4 Then
            Icon_itemmii_2.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_2.Value = &H5 Then
            Icon_itemmii_2.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_2.Value = &H6 Then
            Icon_itemmii_2.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_2.Value = &H7 Then
            Icon_itemmii_2.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_2.Value = &H8 Then
            Icon_itemmii_2.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_2.Value = &H9 Then
            Icon_itemmii_2.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_2.Value = &HA Then
            Icon_itemmii_2.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_2.Value = &HB Then
            Icon_itemmii_2.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_2.Value = &HC Then
            Icon_itemmii_2.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_2.Value = &HD Then
            Icon_itemmii_2.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_2.Value = &HE Then
            Icon_itemmii_2.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_2.Value = &HF Then
            Icon_itemmii_2.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_2.Value = &H10 Then
            Icon_itemmii_2.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_2.Value = &H11 Then
            Icon_itemmii_2.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_2.Value = &H12 Then
            Icon_itemmii_2.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_2.Value = &H13 Then
            Icon_itemmii_2.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_2.Value = &H14 Then
            Icon_itemmii_2.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_2.Value = &H15 Then
            Icon_itemmii_2.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_2.Value = &H16 Then
            Icon_itemmii_2.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_2.Value = &H17 Then
            Icon_itemmii_2.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_2.Value = &H18 Then
            Icon_itemmii_2.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_2.Value = &H19 Then
            Icon_itemmii_2.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_2.Value = &H1A Then
            Icon_itemmii_2.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_2.Value = &H1B Then
            Icon_itemmii_2.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_2.Value = &HFFFF Then
            Icon_itemmii_2.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Private Sub valu_itemmii_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_3.ValueChanged
        If valu_itemmii_3.Value = &H0 Then
            Icon_itemmii_3.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_3.Value = &H1 Then
            Icon_itemmii_3.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_3.Value = &H2 Then
            Icon_itemmii_3.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_3.Value = &H3 Then
            Icon_itemmii_3.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_3.Value = &H4 Then
            Icon_itemmii_3.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_3.Value = &H5 Then
            Icon_itemmii_3.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_3.Value = &H6 Then
            Icon_itemmii_3.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_3.Value = &H7 Then
            Icon_itemmii_3.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_3.Value = &H8 Then
            Icon_itemmii_3.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_3.Value = &H9 Then
            Icon_itemmii_3.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_3.Value = &HA Then
            Icon_itemmii_3.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_3.Value = &HB Then
            Icon_itemmii_3.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_3.Value = &HC Then
            Icon_itemmii_3.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_3.Value = &HD Then
            Icon_itemmii_3.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_3.Value = &HE Then
            Icon_itemmii_3.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_3.Value = &HF Then
            Icon_itemmii_3.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_3.Value = &H10 Then
            Icon_itemmii_3.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_3.Value = &H11 Then
            Icon_itemmii_3.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_3.Value = &H12 Then
            Icon_itemmii_3.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_3.Value = &H13 Then
            Icon_itemmii_3.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_3.Value = &H14 Then
            Icon_itemmii_3.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_3.Value = &H15 Then
            Icon_itemmii_3.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_3.Value = &H16 Then
            Icon_itemmii_3.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_3.Value = &H17 Then
            Icon_itemmii_3.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_3.Value = &H18 Then
            Icon_itemmii_3.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_3.Value = &H19 Then
            Icon_itemmii_3.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_3.Value = &H1A Then
            Icon_itemmii_3.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_3.Value = &H1B Then
            Icon_itemmii_3.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_3.Value = &HFFFF Then
            Icon_itemmii_3.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Private Sub valu_itemmii_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_4.ValueChanged
        If valu_itemmii_4.Value = &H0 Then
            Icon_itemmii_4.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_4.Value = &H1 Then
            Icon_itemmii_4.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_4.Value = &H2 Then
            Icon_itemmii_4.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_4.Value = &H3 Then
            Icon_itemmii_4.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_4.Value = &H4 Then
            Icon_itemmii_4.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_4.Value = &H5 Then
            Icon_itemmii_4.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_4.Value = &H6 Then
            Icon_itemmii_4.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_4.Value = &H7 Then
            Icon_itemmii_4.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_4.Value = &H8 Then
            Icon_itemmii_4.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_4.Value = &H9 Then
            Icon_itemmii_4.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_4.Value = &HA Then
            Icon_itemmii_4.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_4.Value = &HB Then
            Icon_itemmii_4.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_4.Value = &HC Then
            Icon_itemmii_4.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_4.Value = &HD Then
            Icon_itemmii_4.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_4.Value = &HE Then
            Icon_itemmii_4.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_4.Value = &HF Then
            Icon_itemmii_4.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_4.Value = &H10 Then
            Icon_itemmii_4.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_4.Value = &H11 Then
            Icon_itemmii_4.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_4.Value = &H12 Then
            Icon_itemmii_4.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_4.Value = &H13 Then
            Icon_itemmii_4.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_4.Value = &H14 Then
            Icon_itemmii_4.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_4.Value = &H15 Then
            Icon_itemmii_4.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_4.Value = &H16 Then
            Icon_itemmii_4.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_4.Value = &H17 Then
            Icon_itemmii_4.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_4.Value = &H18 Then
            Icon_itemmii_4.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_4.Value = &H19 Then
            Icon_itemmii_4.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_4.Value = &H1A Then
            Icon_itemmii_4.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_4.Value = &H1B Then
            Icon_itemmii_4.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_4.Value = &HFFFF Then
            Icon_itemmii_4.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Private Sub valu_itemmii_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_5.ValueChanged
        If valu_itemmii_5.Value = &H0 Then
            Icon_itemmii_5.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_5.Value = &H1 Then
            Icon_itemmii_5.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_5.Value = &H2 Then
            Icon_itemmii_5.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_5.Value = &H3 Then
            Icon_itemmii_5.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_5.Value = &H4 Then
            Icon_itemmii_5.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_5.Value = &H5 Then
            Icon_itemmii_5.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_5.Value = &H6 Then
            Icon_itemmii_5.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_5.Value = &H7 Then
            Icon_itemmii_5.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_5.Value = &H8 Then
            Icon_itemmii_5.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_5.Value = &H9 Then
            Icon_itemmii_5.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_5.Value = &HA Then
            Icon_itemmii_5.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_5.Value = &HB Then
            Icon_itemmii_5.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_5.Value = &HC Then
            Icon_itemmii_5.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_5.Value = &HD Then
            Icon_itemmii_5.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_5.Value = &HE Then
            Icon_itemmii_5.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_5.Value = &HF Then
            Icon_itemmii_5.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_5.Value = &H10 Then
            Icon_itemmii_5.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_5.Value = &H11 Then
            Icon_itemmii_5.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_5.Value = &H12 Then
            Icon_itemmii_5.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_5.Value = &H13 Then
            Icon_itemmii_5.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_5.Value = &H14 Then
            Icon_itemmii_5.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_5.Value = &H15 Then
            Icon_itemmii_5.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_5.Value = &H16 Then
            Icon_itemmii_5.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_5.Value = &H17 Then
            Icon_itemmii_5.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_5.Value = &H18 Then
            Icon_itemmii_5.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_5.Value = &H19 Then
            Icon_itemmii_5.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_5.Value = &H1A Then
            Icon_itemmii_5.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_5.Value = &H1B Then
            Icon_itemmii_5.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_5.Value = &HFFFF Then
            Icon_itemmii_5.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Private Sub valu_itemmii_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_6.ValueChanged
        If valu_itemmii_6.Value = &H0 Then
            Icon_itemmii_6.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_6.Value = &H1 Then
            Icon_itemmii_6.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_6.Value = &H2 Then
            Icon_itemmii_6.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_6.Value = &H3 Then
            Icon_itemmii_6.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_6.Value = &H4 Then
            Icon_itemmii_6.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_6.Value = &H5 Then
            Icon_itemmii_6.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_6.Value = &H6 Then
            Icon_itemmii_6.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_6.Value = &H7 Then
            Icon_itemmii_6.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_6.Value = &H8 Then
            Icon_itemmii_6.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_6.Value = &H9 Then
            Icon_itemmii_6.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_6.Value = &HA Then
            Icon_itemmii_6.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_6.Value = &HB Then
            Icon_itemmii_6.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_6.Value = &HC Then
            Icon_itemmii_6.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_6.Value = &HD Then
            Icon_itemmii_6.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_6.Value = &HE Then
            Icon_itemmii_6.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_6.Value = &HF Then
            Icon_itemmii_6.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_6.Value = &H10 Then
            Icon_itemmii_6.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_6.Value = &H11 Then
            Icon_itemmii_6.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_6.Value = &H12 Then
            Icon_itemmii_6.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_6.Value = &H13 Then
            Icon_itemmii_6.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_6.Value = &H14 Then
            Icon_itemmii_6.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_6.Value = &H15 Then
            Icon_itemmii_6.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_6.Value = &H16 Then
            Icon_itemmii_6.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_6.Value = &H17 Then
            Icon_itemmii_6.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_6.Value = &H18 Then
            Icon_itemmii_6.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_6.Value = &H19 Then
            Icon_itemmii_6.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_6.Value = &H1A Then
            Icon_itemmii_6.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_6.Value = &H1B Then
            Icon_itemmii_6.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_6.Value = &HFFFF Then
            Icon_itemmii_6.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Private Sub valu_itemmii_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_7.ValueChanged
        If valu_itemmii_7.Value = &H0 Then
            Icon_itemmii_7.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_7.Value = &H1 Then
            Icon_itemmii_7.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_7.Value = &H2 Then
            Icon_itemmii_7.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_7.Value = &H3 Then
            Icon_itemmii_7.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_7.Value = &H4 Then
            Icon_itemmii_7.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_7.Value = &H5 Then
            Icon_itemmii_7.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_7.Value = &H6 Then
            Icon_itemmii_7.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_7.Value = &H7 Then
            Icon_itemmii_7.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_7.Value = &H8 Then
            Icon_itemmii_7.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_7.Value = &H9 Then
            Icon_itemmii_7.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_7.Value = &HA Then
            Icon_itemmii_7.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_7.Value = &HB Then
            Icon_itemmii_7.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_7.Value = &HC Then
            Icon_itemmii_7.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_7.Value = &HD Then
            Icon_itemmii_7.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_7.Value = &HE Then
            Icon_itemmii_7.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_7.Value = &HF Then
            Icon_itemmii_7.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_7.Value = &H10 Then
            Icon_itemmii_7.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_7.Value = &H11 Then
            Icon_itemmii_7.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_7.Value = &H12 Then
            Icon_itemmii_7.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_7.Value = &H13 Then
            Icon_itemmii_7.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_7.Value = &H14 Then
            Icon_itemmii_7.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_7.Value = &H15 Then
            Icon_itemmii_7.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_7.Value = &H16 Then
            Icon_itemmii_7.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_7.Value = &H17 Then
            Icon_itemmii_7.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_7.Value = &H18 Then
            Icon_itemmii_7.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_7.Value = &H19 Then
            Icon_itemmii_7.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_7.Value = &H1A Then
            Icon_itemmii_7.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_7.Value = &H1B Then
            Icon_itemmii_7.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_7.Value = &HFFFF Then
            Icon_itemmii_7.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Private Sub valu_itemmii_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_8.ValueChanged
        If valu_itemmii_8.Value = &H0 Then
            Icon_itemmii_8.Image = My.Resources.gif_0000
        ElseIf valu_itemmii_8.Value = &H1 Then
            Icon_itemmii_8.Image = My.Resources.gif_0100
        ElseIf valu_itemmii_8.Value = &H2 Then
            Icon_itemmii_8.Image = My.Resources.gif_0200
        ElseIf valu_itemmii_8.Value = &H3 Then
            Icon_itemmii_8.Image = My.Resources.gif_0300
        ElseIf valu_itemmii_8.Value = &H4 Then
            Icon_itemmii_8.Image = My.Resources.gif_0400
        ElseIf valu_itemmii_8.Value = &H5 Then
            Icon_itemmii_8.Image = My.Resources.gif_0500
        ElseIf valu_itemmii_8.Value = &H6 Then
            Icon_itemmii_8.Image = My.Resources.gif_0600
        ElseIf valu_itemmii_8.Value = &H7 Then
            Icon_itemmii_8.Image = My.Resources.gif_0700
        ElseIf valu_itemmii_8.Value = &H8 Then
            Icon_itemmii_8.Image = My.Resources.gif_0800
        ElseIf valu_itemmii_8.Value = &H9 Then
            Icon_itemmii_8.Image = My.Resources.gif_0900
        ElseIf valu_itemmii_8.Value = &HA Then
            Icon_itemmii_8.Image = My.Resources.gif_0a00
        ElseIf valu_itemmii_8.Value = &HB Then
            Icon_itemmii_8.Image = My.Resources.gif_0b00
        ElseIf valu_itemmii_8.Value = &HC Then
            Icon_itemmii_8.Image = My.Resources.gif_0c00
        ElseIf valu_itemmii_8.Value = &HD Then
            Icon_itemmii_8.Image = My.Resources.gif_0d00
        ElseIf valu_itemmii_8.Value = &HE Then
            Icon_itemmii_8.Image = My.Resources.gif_0e00
        ElseIf valu_itemmii_8.Value = &HF Then
            Icon_itemmii_8.Image = My.Resources.gif_0f00
        ElseIf valu_itemmii_8.Value = &H10 Then
            Icon_itemmii_8.Image = My.Resources.gif_1000
        ElseIf valu_itemmii_8.Value = &H11 Then
            Icon_itemmii_8.Image = My.Resources.gif_1100
        ElseIf valu_itemmii_8.Value = &H12 Then
            Icon_itemmii_8.Image = My.Resources.gif_1200
        ElseIf valu_itemmii_8.Value = &H13 Then
            Icon_itemmii_8.Image = My.Resources.gif_1300
        ElseIf valu_itemmii_8.Value = &H14 Then
            Icon_itemmii_8.Image = My.Resources.gif_1400
        ElseIf valu_itemmii_8.Value = &H15 Then
            Icon_itemmii_8.Image = My.Resources.gif_1500
        ElseIf valu_itemmii_8.Value = &H16 Then
            Icon_itemmii_8.Image = My.Resources.gif_1600
        ElseIf valu_itemmii_8.Value = &H17 Then
            Icon_itemmii_8.Image = My.Resources.gif_1700
        ElseIf valu_itemmii_8.Value = &H18 Then
            Icon_itemmii_8.Image = My.Resources.gif_1800
        ElseIf valu_itemmii_8.Value = &H19 Then
            Icon_itemmii_8.Image = My.Resources.gif_1900
        ElseIf valu_itemmii_8.Value = &H1A Then
            Icon_itemmii_8.Image = My.Resources.gif_1a00
        ElseIf valu_itemmii_8.Value = &H1B Then
            Icon_itemmii_8.Image = My.Resources.gif_1b00
        ElseIf valu_itemmii_8.Value = &HFFFF Then
            Icon_itemmii_8.Image = My.Resources.gif_FFFF
        End If
    End Sub

    Public Sub Savefileregion()
        If Filever_text.Text = "JP" Then
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Miieconomy = &H1E28
                Equippedhat = &H1D14
                Equippedclothe = &H1D12
                Equippedinterior = &H1E20
                gift_1 = &H2158
                gift_2 = &H215A
                gift_3 = &H215C
                gift_4 = &H215E
                gift_5 = &H2160
                gift_6 = &H2162
                gift_7 = &H2164
                gift_8 = &H2166
                unlockinteriors = &H1E59
                unlockspefoods = &H1E68
                unlockgoods = &H1E50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Miieconomy = &H23B8
                Equippedhat = &H22A4
                Equippedclothe = &H22A2
                Equippedinterior = &H23B0
                gift_1 = &H26E8
                gift_2 = &H26EA
                gift_3 = &H26EC
                gift_4 = &H26EE
                gift_5 = &H26F0
                gift_6 = &H26F2
                gift_7 = &H26F4
                gift_8 = &H26F6
                unlockinteriors = &H23E9
                unlockspefoods = &H23F8
                unlockgoods = &H23E0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Miieconomy = &H2948
                Equippedhat = &H2834
                Equippedclothe = &H2832
                Equippedinterior = &H2940
                gift_1 = &H2C78
                gift_2 = &H2C7A
                gift_3 = &H2C7C
                gift_4 = &H2C7E
                gift_5 = &H2C80
                gift_6 = &H2C82
                gift_7 = &H2C84
                gift_8 = &H2C86
                unlockinteriors = &H2979
                unlockspefoods = &H2988
                unlockgoods = &H2970
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Miieconomy = &H2ED8
                Equippedhat = &H2DC4
                Equippedclothe = &H2DC2
                Equippedinterior = &H2ED0
                gift_1 = &H3208
                gift_2 = &H320A
                gift_3 = &H320C
                gift_4 = &H320E
                gift_5 = &H3210
                gift_6 = &H3212
                gift_7 = &H3214
                gift_8 = &H3216
                unlockinteriors = &H2F09
                unlockspefoods = &H2F18
                unlockgoods = &H2F00
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Miieconomy = &H3468
                Equippedhat = &H3354
                Equippedclothe = &H3352
                Equippedinterior = &H3460
                gift_1 = &H3798
                gift_2 = &H379A
                gift_3 = &H379C
                gift_4 = &H379E
                gift_5 = &H37A0
                gift_6 = &H37A2
                gift_7 = &H37A4
                gift_8 = &H37A6
                unlockinteriors = &H3499
                unlockspefoods = &H34A8
                unlockgoods = &H3490
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Miieconomy = &H39F8
                Equippedhat = &H38E4
                Equippedclothe = &H38E2
                Equippedinterior = &H39F0
                gift_1 = &H3D28
                gift_2 = &H3D2A
                gift_3 = &H3D2C
                gift_4 = &H3D2E
                gift_5 = &H3D30
                gift_6 = &H3D32
                gift_7 = &H3D34
                gift_8 = &H3D36
                unlockinteriors = &H3A29
                unlockspefoods = &H3A38
                unlockgoods = &H3A20
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Miieconomy = &H3F88
                Equippedhat = &H3E74
                Equippedclothe = &H3E72
                Equippedinterior = &H3F80
                gift_1 = &H42B8
                gift_2 = &H42BA
                gift_3 = &H42BC
                gift_4 = &H42BE
                gift_5 = &H42C0
                gift_6 = &H42C2
                gift_7 = &H42C4
                gift_8 = &H42C6
                unlockinteriors = &H3FB9
                unlockspefoods = &H3FC8
                unlockgoods = &H3FB0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Miieconomy = &H4518
                Equippedhat = &H4404
                Equippedclothe = &H4402
                Equippedinterior = &H4510
                gift_1 = &H4848
                gift_2 = &H484A
                gift_3 = &H484C
                gift_4 = &H484E
                gift_5 = &H4850
                gift_6 = &H4852
                gift_7 = &H4854
                gift_8 = &H4856
                unlockinteriors = &H4549
                unlockspefoods = &H4558
                unlockgoods = &H4540
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Miieconomy = &H4AA8
                Equippedhat = &H4994
                Equippedclothe = &H4992
                Equippedinterior = &H4AA0
                gift_1 = &H4DD8
                gift_2 = &H4DDA
                gift_3 = &H4DDC
                gift_4 = &H4DDE
                gift_5 = &H4DE0
                gift_6 = &H4DE2
                gift_7 = &H4DE4
                gift_8 = &H4DE6
                unlockinteriors = &H4AD9
                unlockspefoods = &H4AE8
                unlockgoods = &H4AD0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Miieconomy = &H5038
                Equippedhat = &H4F24
                Equippedclothe = &H4F22
                Equippedinterior = &H5030
                gift_1 = &H5368
                gift_2 = &H536A
                gift_3 = &H536C
                gift_4 = &H536E
                gift_5 = &H5370
                gift_6 = &H5372
                gift_7 = &H5374
                gift_8 = &H5376
                unlockinteriors = &H5069
                unlockspefoods = &H5078
                unlockgoods = &H5060
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Miieconomy = &H55C8
                Equippedhat = &H54B4
                Equippedclothe = &H54B2
                Equippedinterior = &H55C0
                gift_1 = &H58F8
                gift_2 = &H58FA
                gift_3 = &H58FC
                gift_4 = &H58FE
                gift_5 = &H5900
                gift_6 = &H5902
                gift_7 = &H5904
                gift_8 = &H5906
                unlockinteriors = &H55F9
                unlockspefoods = &H5608
                unlockgoods = &H55F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Miieconomy = &H5B58
                Equippedhat = &H5A44
                Equippedclothe = &H5A42
                Equippedinterior = &H5B50
                gift_1 = &H5E88
                gift_2 = &H5E8A
                gift_3 = &H5E8C
                gift_4 = &H5E8E
                gift_5 = &H5E90
                gift_6 = &H5E92
                gift_7 = &H5E94
                gift_8 = &H5E96
                unlockinteriors = &H5B89
                unlockspefoods = &H5B98
                unlockgoods = &H5B80
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Miieconomy = &H60E8
                Equippedhat = &H5FD4
                Equippedclothe = &H5FD2
                Equippedinterior = &H60E0
                gift_1 = &H6418
                gift_2 = &H641A
                gift_3 = &H641C
                gift_4 = &H641E
                gift_5 = &H6420
                gift_6 = &H6422
                gift_7 = &H6424
                gift_8 = &H6426
                unlockinteriors = &H6119
                unlockspefoods = &H6128
                unlockgoods = &H6110
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Miieconomy = &H6678
                Equippedhat = &H6564
                Equippedclothe = &H6562
                Equippedinterior = &H6670
                gift_1 = &H69A8
                gift_2 = &H69AA
                gift_3 = &H69AC
                gift_4 = &H69AE
                gift_5 = &H69B0
                gift_6 = &H69B2
                gift_7 = &H69B4
                gift_8 = &H69B6
                unlockinteriors = &H66A9
                unlockspefoods = &H66B8
                unlockgoods = &H66A0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Miieconomy = &H6C08
                Equippedhat = &H6AF4
                Equippedclothe = &H6AF2
                Equippedinterior = &H6C00
                gift_1 = &H6F38
                gift_2 = &H6F3A
                gift_3 = &H6F3C
                gift_4 = &H6F3E
                gift_5 = &H6F40
                gift_6 = &H6F42
                gift_7 = &H6F44
                gift_8 = &H6F46
                unlockinteriors = &H6C39
                unlockspefoods = &H6C48
                unlockgoods = &H6C30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Miieconomy = &H7198
                Equippedhat = &H7084
                Equippedclothe = &H7082
                Equippedinterior = &H7190
                gift_1 = &H74C8
                gift_2 = &H74CA
                gift_3 = &H74CC
                gift_4 = &H74CE
                gift_5 = &H74D0
                gift_6 = &H74D2
                gift_7 = &H74D4
                gift_8 = &H74D6
                unlockinteriors = &H71C9
                unlockspefoods = &H71D8
                unlockgoods = &H71C0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Miieconomy = &H7728
                Equippedhat = &H7614
                Equippedclothe = &H7612
                Equippedinterior = &H7720
                gift_1 = &H7A58
                gift_2 = &H7A5A
                gift_3 = &H7A5C
                gift_4 = &H7A5E
                gift_5 = &H7A60
                gift_6 = &H7A62
                gift_7 = &H7A64
                gift_8 = &H7A66
                unlockinteriors = &H7759
                unlockspefoods = &H7768
                unlockgoods = &H7750
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Miieconomy = &H7CB8
                Equippedhat = &H7BA4
                Equippedclothe = &H7BA2
                Equippedinterior = &H7CB0
                gift_1 = &H7FE8
                gift_2 = &H7FEA
                gift_3 = &H7FEC
                gift_4 = &H7FEE
                gift_5 = &H7FF0
                gift_6 = &H7FF2
                gift_7 = &H7FF4
                gift_8 = &H7FF6
                unlockinteriors = &H7CE9
                unlockspefoods = &H7CF8
                unlockgoods = &H7CE0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Miieconomy = &H8248
                Equippedhat = &H8134
                Equippedclothe = &H8132
                Equippedinterior = &H8240
                gift_1 = &H8578
                gift_2 = &H857A
                gift_3 = &H857C
                gift_4 = &H857E
                gift_5 = &H8580
                gift_6 = &H8582
                gift_7 = &H8584
                gift_8 = &H8586
                unlockinteriors = &H8279
                unlockspefoods = &H8288
                unlockgoods = &H8270
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Miieconomy = &H87D8
                Equippedhat = &H86C4
                Equippedclothe = &H86C2
                Equippedinterior = &H87D0
                gift_1 = &H8B08
                gift_2 = &H8B0A
                gift_3 = &H8B0C
                gift_4 = &H8B0E
                gift_5 = &H8B10
                gift_6 = &H8B12
                gift_7 = &H8B14
                gift_8 = &H8B16
                unlockinteriors = &H8809
                unlockspefoods = &H8818
                unlockgoods = &H8800
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Miieconomy = &H8D68
                Equippedhat = &H8C54
                Equippedclothe = &H8C52
                Equippedinterior = &H8D60
                gift_1 = &H9098
                gift_2 = &H909A
                gift_3 = &H909C
                gift_4 = &H909E
                gift_5 = &H90A0
                gift_6 = &H90A2
                gift_7 = &H90A4
                gift_8 = &H90A6
                unlockinteriors = &H8D99
                unlockspefoods = &H8DA8
                unlockgoods = &H8D90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Miieconomy = &H92F8
                Equippedhat = &H91E4
                Equippedclothe = &H91E2
                Equippedinterior = &H92F0
                gift_1 = &H9628
                gift_2 = &H962A
                gift_3 = &H962C
                gift_4 = &H962E
                gift_5 = &H9630
                gift_6 = &H9632
                gift_7 = &H9634
                gift_8 = &H9636
                unlockinteriors = &H9329
                unlockspefoods = &H9338
                unlockgoods = &H9320
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Miieconomy = &H9888
                Equippedhat = &H9774
                Equippedclothe = &H9772
                Equippedinterior = &H9880
                gift_1 = &H9BB8
                gift_2 = &H9BBA
                gift_3 = &H9BBC
                gift_4 = &H9BBE
                gift_5 = &H9BC0
                gift_6 = &H9BC2
                gift_7 = &H9BC4
                gift_8 = &H9BC6
                unlockinteriors = &H98B9
                unlockspefoods = &H98C8
                unlockgoods = &H98B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Miieconomy = &H9E18
                Equippedhat = &H9D04
                Equippedclothe = &H9D02
                Equippedinterior = &H9E10
                gift_1 = &HA148
                gift_2 = &HA14A
                gift_3 = &HA14C
                gift_4 = &HA14E
                gift_5 = &HA150
                gift_6 = &HA152
                gift_7 = &HA154
                gift_8 = &HA156
                unlockinteriors = &H9E49
                unlockspefoods = &H9E58
                unlockgoods = &H9E40
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Miieconomy = &HA3A8
                Equippedhat = &HA294
                Equippedclothe = &HA292
                Equippedinterior = &HA3A0
                gift_1 = &HA6D8
                gift_2 = &HA6DA
                gift_3 = &HA6DC
                gift_4 = &HA6DE
                gift_5 = &HA6E0
                gift_6 = &HA6E2
                gift_7 = &HA6E4
                gift_8 = &HA6E6
                unlockinteriors = &HA3D9
                unlockspefoods = &HA3E8
                unlockgoods = &HA3D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Miieconomy = &HA938
                Equippedhat = &HA824
                Equippedclothe = &HA822
                Equippedinterior = &HA930
                gift_1 = &HAC68
                gift_2 = &HAC6A
                gift_3 = &HAC6C
                gift_4 = &HAC6E
                gift_5 = &HAC70
                gift_6 = &HAC72
                gift_7 = &HAC74
                gift_8 = &HAC76
                unlockinteriors = &HA969
                unlockspefoods = &HA978
                unlockgoods = &HA960
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Miieconomy = &HAEC8
                Equippedhat = &HADB4
                Equippedclothe = &HADB2
                Equippedinterior = &HAEC0
                gift_1 = &HB1F8
                gift_2 = &HB1FA
                gift_3 = &HB1FC
                gift_4 = &HB1FE
                gift_5 = &HB200
                gift_6 = &HB202
                gift_7 = &HB204
                gift_8 = &HB206
                unlockinteriors = &HAEF9
                unlockspefoods = &HAF08
                unlockgoods = &HAEF0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Miieconomy = &HB458
                Equippedhat = &HB344
                Equippedclothe = &HB342
                Equippedinterior = &HB450
                gift_1 = &HB788
                gift_2 = &HB78A
                gift_3 = &HB78C
                gift_4 = &HB78E
                gift_5 = &HB790
                gift_6 = &HB792
                gift_7 = &HB794
                gift_8 = &HB796
                unlockinteriors = &HB489
                unlockspefoods = &HB498
                unlockgoods = &HB480
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Miieconomy = &HB9E8
                Equippedhat = &HB8D4
                Equippedclothe = &HB8D2
                Equippedinterior = &HB9E0
                gift_1 = &HBD18
                gift_2 = &HBD1A
                gift_3 = &HBD1C
                gift_4 = &HBD1E
                gift_5 = &HBD20
                gift_6 = &HBD22
                gift_7 = &HBD24
                gift_8 = &HBD26
                unlockinteriors = &HBA19
                unlockspefoods = &HBA28
                unlockgoods = &HBA10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Miieconomy = &HBF78
                Equippedhat = &HBE64
                Equippedclothe = &HBE62
                Equippedinterior = &HBF70
                gift_1 = &HC2A8
                gift_2 = &HC2AA
                gift_3 = &HC2AC
                gift_4 = &HC2AE
                gift_5 = &HC2B0
                gift_6 = &HC2B2
                gift_7 = &HC2B4
                gift_8 = &HC2B6
                unlockinteriors = &HBFA9
                unlockspefoods = &HBFB8
                unlockgoods = &HBFA0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Miieconomy = &HC508
                Equippedhat = &HC3F4
                Equippedclothe = &HC3F2
                Equippedinterior = &HC500
                gift_1 = &HC838
                gift_2 = &HC83A
                gift_3 = &HC83C
                gift_4 = &HC83E
                gift_5 = &HC840
                gift_6 = &HC842
                gift_7 = &HC844
                gift_8 = &HC846
                unlockinteriors = &HC539
                unlockspefoods = &HC548
                unlockgoods = &HC530
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Miieconomy = &HCA98
                Equippedhat = &HC984
                Equippedclothe = &HC982
                Equippedinterior = &HCA90
                gift_1 = &HCDC8
                gift_2 = &HCDCA
                gift_3 = &HCDCC
                gift_4 = &HCDCE
                gift_5 = &HCDD0
                gift_6 = &HCDD2
                gift_7 = &HCDD4
                gift_8 = &HCDD6
                unlockinteriors = &HCAC9
                unlockspefoods = &HCAD8
                unlockgoods = &HCAC0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Miieconomy = &HD028
                Equippedhat = &HCF14
                Equippedclothe = &HCF12
                Equippedinterior = &HD020
                gift_1 = &HD358
                gift_2 = &HD35A
                gift_3 = &HD35C
                gift_4 = &HD35E
                gift_5 = &HD360
                gift_6 = &HD362
                gift_7 = &HD364
                gift_8 = &HD366
                unlockinteriors = &HD059
                unlockspefoods = &HD068
                unlockgoods = &HD050
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Miieconomy = &HD5B8
                Equippedhat = &HD4A4
                Equippedclothe = &HD4A2
                Equippedinterior = &HD5B0
                gift_1 = &HD8E8
                gift_2 = &HD8EA
                gift_3 = &HD8EC
                gift_4 = &HD8EE
                gift_5 = &HD8F0
                gift_6 = &HD8F2
                gift_7 = &HD8F4
                gift_8 = &HD8F6
                unlockinteriors = &HD5E9
                unlockspefoods = &HD5F8
                unlockgoods = &HD5E0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Miieconomy = &HDB48
                Equippedhat = &HDA34
                Equippedclothe = &HDA32
                Equippedinterior = &HDB40
                gift_1 = &HDE78
                gift_2 = &HDE7A
                gift_3 = &HDE7C
                gift_4 = &HDE7E
                gift_5 = &HDE80
                gift_6 = &HDE82
                gift_7 = &HDE84
                gift_8 = &HDE86
                unlockinteriors = &HDB79
                unlockspefoods = &HDB88
                unlockgoods = &HDB70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Miieconomy = &HE0D8
                Equippedhat = &HDFC4
                Equippedclothe = &HDFC2
                Equippedinterior = &HE0D0
                gift_1 = &HE408
                gift_2 = &HE40A
                gift_3 = &HE40C
                gift_4 = &HE40E
                gift_5 = &HE410
                gift_6 = &HE412
                gift_7 = &HE414
                gift_8 = &HE416
                unlockinteriors = &HE109
                unlockspefoods = &HE118
                unlockgoods = &HE100
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Miieconomy = &HE668
                Equippedhat = &HE554
                Equippedclothe = &HE552
                Equippedinterior = &HE660
                gift_1 = &HE998
                gift_2 = &HE99A
                gift_3 = &HE99C
                gift_4 = &HE99E
                gift_5 = &HE9A0
                gift_6 = &HE9A2
                gift_7 = &HE9A4
                gift_8 = &HE9A6
                unlockinteriors = &HE699
                unlockspefoods = &HE6A8
                unlockgoods = &HE690
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Miieconomy = &HEBF8
                Equippedhat = &HEAE4
                Equippedclothe = &HEAE2
                Equippedinterior = &HEBF0
                gift_1 = &HEF28
                gift_2 = &HEF2A
                gift_3 = &HEF2C
                gift_4 = &HEF2E
                gift_5 = &HEF30
                gift_6 = &HEF32
                gift_7 = &HEF34
                gift_8 = &HEF36
                unlockinteriors = &HEC29
                unlockspefoods = &HEC38
                unlockgoods = &HEC20
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Miieconomy = &HF188
                Equippedhat = &HF074
                Equippedclothe = &HF072
                Equippedinterior = &HF180
                gift_1 = &HF4B8
                gift_2 = &HF4BA
                gift_3 = &HF4BC
                gift_4 = &HF4BE
                gift_5 = &HF4C0
                gift_6 = &HF4C2
                gift_7 = &HF4C4
                gift_8 = &HF4C6
                unlockinteriors = &HF1B9
                unlockspefoods = &HF1C8
                unlockgoods = &HF1B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Miieconomy = &HF718
                Equippedhat = &HF604
                Equippedclothe = &HF602
                Equippedinterior = &HF710
                gift_1 = &HFA48
                gift_2 = &HFA4A
                gift_3 = &HFA4C
                gift_4 = &HFA4E
                gift_5 = &HFA50
                gift_6 = &HFA52
                gift_7 = &HFA54
                gift_8 = &HFA56
                unlockinteriors = &HF749
                unlockspefoods = &HF758
                unlockgoods = &HF740
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Miieconomy = &HFCA8
                Equippedhat = &HFB94
                Equippedclothe = &HFB92
                Equippedinterior = &HFCA0
                gift_1 = &HFFD8
                gift_2 = &HFFDA
                gift_3 = &HFFDC
                gift_4 = &HFFDE
                gift_5 = &HFFE0
                gift_6 = &HFFE2
                gift_7 = &HFFE4
                gift_8 = &HFFE6
                unlockinteriors = &HFCD9
                unlockspefoods = &HFCE8
                unlockgoods = &HFCD0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Miieconomy = &H10238
                Equippedhat = &H10124
                Equippedclothe = &H10122
                Equippedinterior = &H10230
                gift_1 = &H10568
                gift_2 = &H1056A
                gift_3 = &H1056C
                gift_4 = &H1056E
                gift_5 = &H10570
                gift_6 = &H10572
                gift_7 = &H10574
                gift_8 = &H10576
                unlockinteriors = &H10269
                unlockspefoods = &H10278
                unlockgoods = &H10260
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Miieconomy = &H107C8
                Equippedhat = &H106B4
                Equippedclothe = &H106B2
                Equippedinterior = &H107C0
                gift_1 = &H10AF8
                gift_2 = &H10AFA
                gift_3 = &H10AFC
                gift_4 = &H10AFE
                gift_5 = &H10B00
                gift_6 = &H10B02
                gift_7 = &H10B04
                gift_8 = &H10B06
                unlockinteriors = &H107F9
                unlockspefoods = &H10808
                unlockgoods = &H107F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Miieconomy = &H10D58
                Equippedhat = &H10C44
                Equippedclothe = &H10C42
                Equippedinterior = &H10D50
                gift_1 = &H11088
                gift_2 = &H1108A
                gift_3 = &H1108C
                gift_4 = &H1108E
                gift_5 = &H11090
                gift_6 = &H11092
                gift_7 = &H11094
                gift_8 = &H11096
                unlockinteriors = &H10D89
                unlockspefoods = &H10D98
                unlockgoods = &H10D80
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Miieconomy = &H112E8
                Equippedhat = &H111D4
                Equippedclothe = &H111D2
                Equippedinterior = &H112E0
                gift_1 = &H11618
                gift_2 = &H1161A
                gift_3 = &H1161C
                gift_4 = &H1161E
                gift_5 = &H11620
                gift_6 = &H11622
                gift_7 = &H11624
                gift_8 = &H11626
                unlockinteriors = &H11319
                unlockspefoods = &H11328
                unlockgoods = &H11310
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Miieconomy = &H11878
                Equippedhat = &H11764
                Equippedclothe = &H11762
                Equippedinterior = &H11870
                gift_1 = &H11BA8
                gift_2 = &H11BAA
                gift_3 = &H11BAC
                gift_4 = &H11BAE
                gift_5 = &H11BB0
                gift_6 = &H11BB2
                gift_7 = &H11BB4
                gift_8 = &H11BB6
                unlockinteriors = &H118A9
                unlockspefoods = &H118B8
                unlockgoods = &H118A0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Miieconomy = &H11E08
                Equippedhat = &H11CF4
                Equippedclothe = &H11CF2
                Equippedinterior = &H11E00
                gift_1 = &H12138
                gift_2 = &H1213A
                gift_3 = &H1213C
                gift_4 = &H1213E
                gift_5 = &H12140
                gift_6 = &H12142
                gift_7 = &H12144
                gift_8 = &H12146
                unlockinteriors = &H11E39
                unlockspefoods = &H11E48
                unlockgoods = &H11E30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Miieconomy = &H12398
                Equippedhat = &H12284
                Equippedclothe = &H12282
                Equippedinterior = &H12390
                gift_1 = &H126C8
                gift_2 = &H126CA
                gift_3 = &H126CC
                gift_4 = &H126CE
                gift_5 = &H126D0
                gift_6 = &H126D2
                gift_7 = &H126D4
                gift_8 = &H126D6
                unlockinteriors = &H123C9
                unlockspefoods = &H123D8
                unlockgoods = &H123C0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Miieconomy = &H12928
                Equippedhat = &H12814
                Equippedclothe = &H12812
                Equippedinterior = &H12920
                gift_1 = &H12C58
                gift_2 = &H12C5A
                gift_3 = &H12C5C
                gift_4 = &H12C5E
                gift_5 = &H12C60
                gift_6 = &H12C62
                gift_7 = &H12C64
                gift_8 = &H12C66
                unlockinteriors = &H12959
                unlockspefoods = &H12968
                unlockgoods = &H12950
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Miieconomy = &H12EB8
                Equippedhat = &H12DA4
                Equippedclothe = &H12DA2
                Equippedinterior = &H12EB0
                gift_1 = &H131E8
                gift_2 = &H131EA
                gift_3 = &H131EC
                gift_4 = &H131EE
                gift_5 = &H131F0
                gift_6 = &H131F2
                gift_7 = &H131F4
                gift_8 = &H131F6
                unlockinteriors = &H12EE9
                unlockspefoods = &H12EF8
                unlockgoods = &H12EE0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Miieconomy = &H13448
                Equippedhat = &H13334
                Equippedclothe = &H13332
                Equippedinterior = &H13440
                gift_1 = &H13778
                gift_2 = &H1377A
                gift_3 = &H1377C
                gift_4 = &H1377E
                gift_5 = &H13780
                gift_6 = &H13782
                gift_7 = &H13784
                gift_8 = &H13786
                unlockinteriors = &H13479
                unlockspefoods = &H13488
                unlockgoods = &H13470
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Miieconomy = &H139D8
                Equippedhat = &H138C4
                Equippedclothe = &H138C2
                Equippedinterior = &H139D0
                gift_1 = &H13D08
                gift_2 = &H13D0A
                gift_3 = &H13D0C
                gift_4 = &H13D0E
                gift_5 = &H13D10
                gift_6 = &H13D12
                gift_7 = &H13D14
                gift_8 = &H13D16
                unlockinteriors = &H13A09
                unlockspefoods = &H13A18
                unlockgoods = &H13A00
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Miieconomy = &H13F68
                Equippedhat = &H13E54
                Equippedclothe = &H13E52
                Equippedinterior = &H13F60
                gift_1 = &H14298
                gift_2 = &H1429A
                gift_3 = &H1429C
                gift_4 = &H1429E
                gift_5 = &H142A0
                gift_6 = &H142A2
                gift_7 = &H142A4
                gift_8 = &H142A6
                unlockinteriors = &H13F99
                unlockspefoods = &H13FA8
                unlockgoods = &H13F90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Miieconomy = &H144F8
                Equippedhat = &H143E4
                Equippedclothe = &H143E2
                Equippedinterior = &H144F0
                gift_1 = &H14828
                gift_2 = &H1482A
                gift_3 = &H1482C
                gift_4 = &H1482E
                gift_5 = &H14830
                gift_6 = &H14832
                gift_7 = &H14834
                gift_8 = &H14836
                unlockinteriors = &H14529
                unlockspefoods = &H14538
                unlockgoods = &H14520
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Miieconomy = &H14A88
                Equippedhat = &H14974
                Equippedclothe = &H14972
                Equippedinterior = &H14A80
                gift_1 = &H14DB8
                gift_2 = &H14DBA
                gift_3 = &H14DBC
                gift_4 = &H14DBE
                gift_5 = &H14DC0
                gift_6 = &H14DC2
                gift_7 = &H14DC4
                gift_8 = &H14DC6
                unlockinteriors = &H14AB9
                unlockspefoods = &H14AC8
                unlockgoods = &H14AB0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Miieconomy = &H15018
                Equippedhat = &H14F04
                Equippedclothe = &H14F02
                Equippedinterior = &H15010
                gift_1 = &H15348
                gift_2 = &H1534A
                gift_3 = &H1534C
                gift_4 = &H1534E
                gift_5 = &H15350
                gift_6 = &H15352
                gift_7 = &H15354
                gift_8 = &H15356
                unlockinteriors = &H15049
                unlockspefoods = &H15058
                unlockgoods = &H15040
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Miieconomy = &H155A8
                Equippedhat = &H15494
                Equippedclothe = &H15492
                Equippedinterior = &H155A0
                gift_1 = &H158D8
                gift_2 = &H158DA
                gift_3 = &H158DC
                gift_4 = &H158DE
                gift_5 = &H158E0
                gift_6 = &H158E2
                gift_7 = &H158E4
                gift_8 = &H158E6
                unlockinteriors = &H155D9
                unlockspefoods = &H155E8
                unlockgoods = &H155D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Miieconomy = &H15B38
                Equippedhat = &H15A24
                Equippedclothe = &H15A22
                Equippedinterior = &H15B30
                gift_1 = &H15E68
                gift_2 = &H15E6A
                gift_3 = &H15E6C
                gift_4 = &H15E6E
                gift_5 = &H15E70
                gift_6 = &H15E72
                gift_7 = &H15E74
                gift_8 = &H15E76
                unlockinteriors = &H15B69
                unlockspefoods = &H15B78
                unlockgoods = &H15B60
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Miieconomy = &H160C8
                Equippedhat = &H15FB4
                Equippedclothe = &H15FB2
                Equippedinterior = &H160C0
                gift_1 = &H163F8
                gift_2 = &H163FA
                gift_3 = &H163FC
                gift_4 = &H163FE
                gift_5 = &H16400
                gift_6 = &H16402
                gift_7 = &H16404
                gift_8 = &H16406
                unlockinteriors = &H160F9
                unlockspefoods = &H16108
                unlockgoods = &H160F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Miieconomy = &H16658
                Equippedhat = &H16544
                Equippedclothe = &H16542
                Equippedinterior = &H16650
                gift_1 = &H16988
                gift_2 = &H1698A
                gift_3 = &H1698C
                gift_4 = &H1698E
                gift_5 = &H16990
                gift_6 = &H16992
                gift_7 = &H16994
                gift_8 = &H16996
                unlockinteriors = &H16689
                unlockspefoods = &H16698
                unlockgoods = &H16680
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Miieconomy = &H16BE8
                Equippedhat = &H16AD4
                Equippedclothe = &H16AD2
                Equippedinterior = &H16BE0
                gift_1 = &H16F18
                gift_2 = &H16F1A
                gift_3 = &H16F1C
                gift_4 = &H16F1E
                gift_5 = &H16F20
                gift_6 = &H16F22
                gift_7 = &H16F24
                gift_8 = &H16F26
                unlockinteriors = &H16C19
                unlockspefoods = &H16C28
                unlockgoods = &H16C10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Miieconomy = &H17178
                Equippedhat = &H17064
                Equippedclothe = &H17062
                Equippedinterior = &H17170
                gift_1 = &H174A8
                gift_2 = &H174AA
                gift_3 = &H174AC
                gift_4 = &H174AE
                gift_5 = &H174B0
                gift_6 = &H174B2
                gift_7 = &H174B4
                gift_8 = &H174B6
                unlockinteriors = &H171A9
                unlockspefoods = &H171B8
                unlockgoods = &H171A0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Miieconomy = &H17708
                Equippedhat = &H175F4
                Equippedclothe = &H175F2
                Equippedinterior = &H17700
                gift_1 = &H17A38
                gift_2 = &H17A3A
                gift_3 = &H17A3C
                gift_4 = &H17A3E
                gift_5 = &H17A40
                gift_6 = &H17A42
                gift_7 = &H17A44
                gift_8 = &H17A46
                unlockinteriors = &H17739
                unlockspefoods = &H17748
                unlockgoods = &H17730
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Miieconomy = &H17C98
                Equippedhat = &H17B84
                Equippedclothe = &H17B82
                Equippedinterior = &H17C90
                gift_1 = &H17FC8
                gift_2 = &H17FCA
                gift_3 = &H17FCC
                gift_4 = &H17FCE
                gift_5 = &H17FD0
                gift_6 = &H17FD2
                gift_7 = &H17FD4
                gift_8 = &H17FD6
                unlockinteriors = &H17CC9
                unlockspefoods = &H17CD8
                unlockgoods = &H17CC0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Miieconomy = &H18228
                Equippedhat = &H18114
                Equippedclothe = &H18112
                Equippedinterior = &H18220
                gift_1 = &H18558
                gift_2 = &H1855A
                gift_3 = &H1855C
                gift_4 = &H1855E
                gift_5 = &H18560
                gift_6 = &H18562
                gift_7 = &H18564
                gift_8 = &H18566
                unlockinteriors = &H18259
                unlockspefoods = &H18268
                unlockgoods = &H18250
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Miieconomy = &H187B8
                Equippedhat = &H186A4
                Equippedclothe = &H186A2
                Equippedinterior = &H187B0
                gift_1 = &H18AE8
                gift_2 = &H18AEA
                gift_3 = &H18AEC
                gift_4 = &H18AEE
                gift_5 = &H18AF0
                gift_6 = &H18AF2
                gift_7 = &H18AF4
                gift_8 = &H18AF6
                unlockinteriors = &H187E9
                unlockspefoods = &H187F8
                unlockgoods = &H187E0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Miieconomy = &H18D48
                Equippedhat = &H18C34
                Equippedclothe = &H18C32
                Equippedinterior = &H18D40
                gift_1 = &H19078
                gift_2 = &H1907A
                gift_3 = &H1907C
                gift_4 = &H1907E
                gift_5 = &H19080
                gift_6 = &H19082
                gift_7 = &H19084
                gift_8 = &H19086
                unlockinteriors = &H18D79
                unlockspefoods = &H18D88
                unlockgoods = &H18D70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Miieconomy = &H192D8
                Equippedhat = &H191C4
                Equippedclothe = &H191C2
                Equippedinterior = &H192D0
                gift_1 = &H19608
                gift_2 = &H1960A
                gift_3 = &H1960C
                gift_4 = &H1960E
                gift_5 = &H19610
                gift_6 = &H19612
                gift_7 = &H19614
                gift_8 = &H19616
                unlockinteriors = &H19309
                unlockspefoods = &H19318
                unlockgoods = &H19300
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Miieconomy = &H19868
                Equippedhat = &H19754
                Equippedclothe = &H19752
                Equippedinterior = &H19860
                gift_1 = &H19B98
                gift_2 = &H19B9A
                gift_3 = &H19B9C
                gift_4 = &H19B9E
                gift_5 = &H19BA0
                gift_6 = &H19BA2
                gift_7 = &H19BA4
                gift_8 = &H19BA6
                unlockinteriors = &H19899
                unlockspefoods = &H198A8
                unlockgoods = &H19890
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Miieconomy = &H19DF8
                Equippedhat = &H19CE4
                Equippedclothe = &H19CE2
                Equippedinterior = &H19DF0
                gift_1 = &H1A128
                gift_2 = &H1A12A
                gift_3 = &H1A12C
                gift_4 = &H1A12E
                gift_5 = &H1A130
                gift_6 = &H1A132
                gift_7 = &H1A134
                gift_8 = &H1A136
                unlockinteriors = &H19E29
                unlockspefoods = &H19E38
                unlockgoods = &H19E20
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Miieconomy = &H1A388
                Equippedhat = &H1A274
                Equippedclothe = &H1A272
                Equippedinterior = &H1A380
                gift_1 = &H1A6B8
                gift_2 = &H1A6BA
                gift_3 = &H1A6BC
                gift_4 = &H1A6BE
                gift_5 = &H1A6C0
                gift_6 = &H1A6C2
                gift_7 = &H1A6C4
                gift_8 = &H1A6C6
                unlockinteriors = &H1A3B9
                unlockspefoods = &H1A3C8
                unlockgoods = &H1A3B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Miieconomy = &H1A918
                Equippedhat = &H1A804
                Equippedclothe = &H1A802
                Equippedinterior = &H1A910
                gift_1 = &H1AC48
                gift_2 = &H1AC4A
                gift_3 = &H1AC4C
                gift_4 = &H1AC4E
                gift_5 = &H1AC50
                gift_6 = &H1AC52
                gift_7 = &H1AC54
                gift_8 = &H1AC56
                unlockinteriors = &H1A949
                unlockspefoods = &H1A958
                unlockgoods = &H1A940
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Miieconomy = &H1AEA8
                Equippedhat = &H1AD94
                Equippedclothe = &H1AD92
                Equippedinterior = &H1AEA0
                gift_1 = &H1B1D8
                gift_2 = &H1B1DA
                gift_3 = &H1B1DC
                gift_4 = &H1B1DE
                gift_5 = &H1B1E0
                gift_6 = &H1B1E2
                gift_7 = &H1B1E4
                gift_8 = &H1B1E6
                unlockinteriors = &H1AED9
                unlockspefoods = &H1AEE8
                unlockgoods = &H1AED0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Miieconomy = &H1B438
                Equippedhat = &H1B324
                Equippedclothe = &H1B322
                Equippedinterior = &H1B430
                gift_1 = &H1B768
                gift_2 = &H1B76A
                gift_3 = &H1B76C
                gift_4 = &H1B76E
                gift_5 = &H1B770
                gift_6 = &H1B772
                gift_7 = &H1B774
                gift_8 = &H1B776
                unlockinteriors = &H1B469
                unlockspefoods = &H1B478
                unlockgoods = &H1B460
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Miieconomy = &H1B9C8
                Equippedhat = &H1B8B4
                Equippedclothe = &H1B8B2
                Equippedinterior = &H1B9C0
                gift_1 = &H1BCF8
                gift_2 = &H1BCFA
                gift_3 = &H1BCFC
                gift_4 = &H1BCFE
                gift_5 = &H1BD00
                gift_6 = &H1BD02
                gift_7 = &H1BD04
                gift_8 = &H1BD06
                unlockinteriors = &H1B9F9
                unlockspefoods = &H1BA08
                unlockgoods = &H1B9F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Miieconomy = &H1BF58
                Equippedhat = &H1BE44
                Equippedclothe = &H1BE42
                Equippedinterior = &H1BF50
                gift_1 = &H1C288
                gift_2 = &H1C28A
                gift_3 = &H1C28C
                gift_4 = &H1C28E
                gift_5 = &H1C290
                gift_6 = &H1C292
                gift_7 = &H1C294
                gift_8 = &H1C296
                unlockinteriors = &H1BF89
                unlockspefoods = &H1BF98
                unlockgoods = &H1BF80
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Miieconomy = &H1C4E8
                Equippedhat = &H1C3D4
                Equippedclothe = &H1C3D2
                Equippedinterior = &H1C4E0
                gift_1 = &H1C818
                gift_2 = &H1C81A
                gift_3 = &H1C81C
                gift_4 = &H1C81E
                gift_5 = &H1C820
                gift_6 = &H1C822
                gift_7 = &H1C824
                gift_8 = &H1C826
                unlockinteriors = &H1C519
                unlockspefoods = &H1C528
                unlockgoods = &H1C510
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Miieconomy = &H1CA78
                Equippedhat = &H1C964
                Equippedclothe = &H1C962
                Equippedinterior = &H1CA70
                gift_1 = &H1CDA8
                gift_2 = &H1CDAA
                gift_3 = &H1CDAC
                gift_4 = &H1CDAE
                gift_5 = &H1CDB0
                gift_6 = &H1CDB2
                gift_7 = &H1CDB4
                gift_8 = &H1CDB6
                unlockinteriors = &H1CAA9
                unlockspefoods = &H1CAB8
                unlockgoods = &H1CAA0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Miieconomy = &H1D008
                Equippedhat = &H1CEF4
                Equippedclothe = &H1CEF2
                Equippedinterior = &H1D000
                gift_1 = &H1D338
                gift_2 = &H1D33A
                gift_3 = &H1D33C
                gift_4 = &H1D33E
                gift_5 = &H1D340
                gift_6 = &H1D342
                gift_7 = &H1D344
                gift_8 = &H1D346
                unlockinteriors = &H1D039
                unlockspefoods = &H1D048
                unlockgoods = &H1D030
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Miieconomy = &H1D598
                Equippedhat = &H1D484
                Equippedclothe = &H1D482
                Equippedinterior = &H1D590
                gift_1 = &H1D8C8
                gift_2 = &H1D8CA
                gift_3 = &H1D8CC
                gift_4 = &H1D8CE
                gift_5 = &H1D8D0
                gift_6 = &H1D8D2
                gift_7 = &H1D8D4
                gift_8 = &H1D8D6
                unlockinteriors = &H1D5C9
                unlockspefoods = &H1D5D8
                unlockgoods = &H1D5C0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Miieconomy = &H1DB28
                Equippedhat = &H1DA14
                Equippedclothe = &H1DA12
                Equippedinterior = &H1DB20
                gift_1 = &H1DE58
                gift_2 = &H1DE5A
                gift_3 = &H1DE5C
                gift_4 = &H1DE5E
                gift_5 = &H1DE60
                gift_6 = &H1DE62
                gift_7 = &H1DE64
                gift_8 = &H1DE66
                unlockinteriors = &H1DB59
                unlockspefoods = &H1DB68
                unlockgoods = &H1DB50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Miieconomy = &H1E0B8
                Equippedhat = &H1DFA4
                Equippedclothe = &H1DFA2
                Equippedinterior = &H1E0B0
                gift_1 = &H1E3E8
                gift_2 = &H1E3EA
                gift_3 = &H1E3EC
                gift_4 = &H1E3EE
                gift_5 = &H1E3F0
                gift_6 = &H1E3F2
                gift_7 = &H1E3F4
                gift_8 = &H1E3F6
                unlockinteriors = &H1E0E9
                unlockspefoods = &H1E0F8
                unlockgoods = &H1E0E0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Miieconomy = &H1E648
                Equippedhat = &H1E534
                Equippedclothe = &H1E532
                Equippedinterior = &H1E640
                gift_1 = &H1E978
                gift_2 = &H1E97A
                gift_3 = &H1E97C
                gift_4 = &H1E97E
                gift_5 = &H1E980
                gift_6 = &H1E982
                gift_7 = &H1E984
                gift_8 = &H1E986
                unlockinteriors = &H1E679
                unlockspefoods = &H1E688
                unlockgoods = &H1E670
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Miieconomy = &H1EBD8
                Equippedhat = &H1EAC4
                Equippedclothe = &H1EAC2
                Equippedinterior = &H1EBD0
                gift_1 = &H1EF08
                gift_2 = &H1EF0A
                gift_3 = &H1EF0C
                gift_4 = &H1EF0E
                gift_5 = &H1EF10
                gift_6 = &H1EF12
                gift_7 = &H1EF14
                gift_8 = &H1EF16
                unlockinteriors = &H1EC09
                unlockspefoods = &H1EC18
                unlockgoods = &H1EC00
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Miieconomy = &H1F168
                Equippedhat = &H1F054
                Equippedclothe = &H1F052
                Equippedinterior = &H1F160
                gift_1 = &H1F498
                gift_2 = &H1F49A
                gift_3 = &H1F49C
                gift_4 = &H1F49E
                gift_5 = &H1F4A0
                gift_6 = &H1F4A2
                gift_7 = &H1F4A4
                gift_8 = &H1F4A6
                unlockinteriors = &H1F199
                unlockspefoods = &H1F1A8
                unlockgoods = &H1F190
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Miieconomy = &H1F6F8
                Equippedhat = &H1F5E4
                Equippedclothe = &H1F5E2
                Equippedinterior = &H1F6F0
                gift_1 = &H1FA28
                gift_2 = &H1FA2A
                gift_3 = &H1FA2C
                gift_4 = &H1FA2E
                gift_5 = &H1FA30
                gift_6 = &H1FA32
                gift_7 = &H1FA34
                gift_8 = &H1FA36
                unlockinteriors = &H1F729
                unlockspefoods = &H1F738
                unlockgoods = &H1F720
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Miieconomy = &H1FC88
                Equippedhat = &H1FB74
                Equippedclothe = &H1FB72
                Equippedinterior = &H1FC80
                gift_1 = &H1FFB8
                gift_2 = &H1FFBA
                gift_3 = &H1FFBC
                gift_4 = &H1FFBE
                gift_5 = &H1FFC0
                gift_6 = &H1FFC2
                gift_7 = &H1FFC4
                gift_8 = &H1FFC6
                unlockinteriors = &H1FCB9
                unlockspefoods = &H1FCC8
                unlockgoods = &H1FCB0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Miieconomy = &H20218
                Equippedhat = &H20104
                Equippedclothe = &H20102
                Equippedinterior = &H20210
                gift_1 = &H20548
                gift_2 = &H2054A
                gift_3 = &H2054C
                gift_4 = &H2054E
                gift_5 = &H20550
                gift_6 = &H20552
                gift_7 = &H20554
                gift_8 = &H20556
                unlockinteriors = &H20249
                unlockspefoods = &H20258
                unlockgoods = &H20240
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Miieconomy = &H207A8
                Equippedhat = &H20694
                Equippedclothe = &H20692
                Equippedinterior = &H207A0
                gift_1 = &H20AD8
                gift_2 = &H20ADA
                gift_3 = &H20ADC
                gift_4 = &H20ADE
                gift_5 = &H20AE0
                gift_6 = &H20AE2
                gift_7 = &H20AE4
                gift_8 = &H20AE6
                unlockinteriors = &H207D9
                unlockspefoods = &H207E8
                unlockgoods = &H207D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Miieconomy = &H20D38
                Equippedhat = &H20C24
                Equippedclothe = &H20C22
                Equippedinterior = &H20D30
                gift_1 = &H21068
                gift_2 = &H2106A
                gift_3 = &H2106C
                gift_4 = &H2106E
                gift_5 = &H21070
                gift_6 = &H21072
                gift_7 = &H21074
                gift_8 = &H21076
                unlockinteriors = &H20D69
                unlockspefoods = &H20D78
                unlockgoods = &H20D60
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Miieconomy = &H212C8
                Equippedhat = &H211B4
                Equippedclothe = &H211B2
                Equippedinterior = &H212C0
                gift_1 = &H215F8
                gift_2 = &H215FA
                gift_3 = &H215FC
                gift_4 = &H215FE
                gift_5 = &H21600
                gift_6 = &H21602
                gift_7 = &H21604
                gift_8 = &H21606
                unlockinteriors = &H212F9
                unlockspefoods = &H21308
                unlockgoods = &H212F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Miieconomy = &H21858
                Equippedhat = &H21744
                Equippedclothe = &H21742
                Equippedinterior = &H21850
                gift_1 = &H21B88
                gift_2 = &H21B8A
                gift_3 = &H21B8C
                gift_4 = &H21B8E
                gift_5 = &H21B90
                gift_6 = &H21B92
                gift_7 = &H21B94
                gift_8 = &H21B96
                unlockinteriors = &H21889
                unlockspefoods = &H21898
                unlockgoods = &H21880
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Miieconomy = &H21DE8
                Equippedhat = &H21CD4
                Equippedclothe = &H21CD2
                Equippedinterior = &H21DE0
                gift_1 = &H22118
                gift_2 = &H2211A
                gift_3 = &H2211C
                gift_4 = &H2211E
                gift_5 = &H22120
                gift_6 = &H22122
                gift_7 = &H22124
                gift_8 = &H22126
                unlockinteriors = &H21E19
                unlockspefoods = &H21E28
                unlockgoods = &H21E10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Miieconomy = &H22378
                Equippedhat = &H22264
                Equippedclothe = &H22262
                Equippedinterior = &H22370
                gift_1 = &H226A8
                gift_2 = &H226AA
                gift_3 = &H226AC
                gift_4 = &H226AE
                gift_5 = &H226B0
                gift_6 = &H226B2
                gift_7 = &H226B4
                gift_8 = &H226B6
                unlockinteriors = &H223A9
                unlockspefoods = &H223B8
                unlockgoods = &H223A0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Miieconomy = &H22908
                Equippedhat = &H227F4
                Equippedclothe = &H227F2
                Equippedinterior = &H22900
                gift_1 = &H22C38
                gift_2 = &H22C3A
                gift_3 = &H22C3C
                gift_4 = &H22C3E
                gift_5 = &H22C40
                gift_6 = &H22C42
                gift_7 = &H22C44
                gift_8 = &H22C46
                unlockinteriors = &H22939
                unlockspefoods = &H22948
                unlockgoods = &H22930
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Miieconomy = &H22E98
                Equippedhat = &H22D84
                Equippedclothe = &H22D82
                Equippedinterior = &H22E90
                gift_1 = &H231C8
                gift_2 = &H231CA
                gift_3 = &H231CC
                gift_4 = &H231CE
                gift_5 = &H231D0
                gift_6 = &H231D2
                gift_7 = &H231D4
                gift_8 = &H231D6
                unlockinteriors = &H22EC9
                unlockspefoods = &H22ED8
                unlockgoods = &H22EC0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Miieconomy = &H23428
                Equippedhat = &H23314
                Equippedclothe = &H23312
                Equippedinterior = &H23420
                gift_1 = &H23758
                gift_2 = &H2375A
                gift_3 = &H2375C
                gift_4 = &H2375E
                gift_5 = &H23760
                gift_6 = &H23762
                gift_7 = &H23764
                gift_8 = &H23766
                unlockinteriors = &H23459
                unlockspefoods = &H23468
                unlockgoods = &H23450
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Miieconomy = &H239B8
                Equippedhat = &H238A4
                Equippedclothe = &H238A2
                Equippedinterior = &H239B0
                gift_1 = &H23CE8
                gift_2 = &H23CEA
                gift_3 = &H23CEC
                gift_4 = &H23CEE
                gift_5 = &H23CF0
                gift_6 = &H23CF2
                gift_7 = &H23CF4
                gift_8 = &H23CF6
                unlockinteriors = &H239E9
                unlockspefoods = &H239F8
                unlockgoods = &H239E0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Miieconomy = &H23F48
                Equippedhat = &H23E34
                Equippedclothe = &H23E32
                Equippedinterior = &H23F40
                gift_1 = &H24278
                gift_2 = &H2427A
                gift_3 = &H2427C
                gift_4 = &H2427E
                gift_5 = &H24280
                gift_6 = &H24282
                gift_7 = &H24284
                gift_8 = &H24286
                unlockinteriors = &H23F79
                unlockspefoods = &H23F88
                unlockgoods = &H23F70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Miieconomy = &H244D8
                Equippedhat = &H243C4
                Equippedclothe = &H243C2
                Equippedinterior = &H244D0
                gift_1 = &H24808
                gift_2 = &H2480A
                gift_3 = &H2480C
                gift_4 = &H2480E
                gift_5 = &H24810
                gift_6 = &H24812
                gift_7 = &H24814
                gift_8 = &H24816
                unlockinteriors = &H24509
                unlockspefoods = &H24518
                unlockgoods = &H24500
            End If
        Else
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Miieconomy = &H1F28
                Equippedhat = &H1D44
                Equippedclothe = &H1D42
                Equippedinterior = &H1F20
                gift_1 = &H2258
                gift_2 = &H225A
                gift_3 = &H225C
                gift_4 = &H225E
                gift_5 = &H2260
                gift_6 = &H2262
                gift_7 = &H2264
                gift_8 = &H2266
                unlockinteriors = &H1F59
                unlockspefoods = &H1F68
                unlockgoods = &H1F50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Miieconomy = &H2588
                Equippedhat = &H23A4
                Equippedclothe = &H23A2
                Equippedinterior = &H2580
                gift_1 = &H28B8
                gift_2 = &H28BA
                gift_3 = &H28BC
                gift_4 = &H28BE
                gift_5 = &H28C0
                gift_6 = &H28C2
                gift_7 = &H28C4
                gift_8 = &H28C6
                unlockinteriors = &H25B9
                unlockspefoods = &H25C8
                unlockgoods = &H25B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Miieconomy = &H2BE8
                Equippedhat = &H2A04
                Equippedclothe = &H2A02
                Equippedinterior = &H2BE0
                gift_1 = &H2F18
                gift_2 = &H2F1A
                gift_3 = &H2F1C
                gift_4 = &H2F1E
                gift_5 = &H2F20
                gift_6 = &H2F22
                gift_7 = &H2F24
                gift_8 = &H2F26
                unlockinteriors = &H2C19
                unlockspefoods = &H2C28
                unlockgoods = &H2C10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Miieconomy = &H3248
                Equippedhat = &H3064
                Equippedclothe = &H3062
                Equippedinterior = &H3240
                gift_1 = &H3578
                gift_2 = &H357A
                gift_3 = &H357C
                gift_4 = &H357E
                gift_5 = &H3580
                gift_6 = &H3582
                gift_7 = &H3584
                gift_8 = &H3586
                unlockinteriors = &H3279
                unlockspefoods = &H3288
                unlockgoods = &H3270
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Miieconomy = &H38A8
                Equippedhat = &H36C4
                Equippedclothe = &H36C2
                Equippedinterior = &H38A0
                gift_1 = &H3BD8
                gift_2 = &H3BDA
                gift_3 = &H3BDC
                gift_4 = &H3BDE
                gift_5 = &H3BE0
                gift_6 = &H3BE2
                gift_7 = &H3BE4
                gift_8 = &H3BE6
                unlockinteriors = &H38D9
                unlockspefoods = &H38E8
                unlockgoods = &H38D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Miieconomy = &H3F08
                Equippedhat = &H3D24
                Equippedclothe = &H3D22
                Equippedinterior = &H3F00
                gift_1 = &H4238
                gift_2 = &H423A
                gift_3 = &H423C
                gift_4 = &H423E
                gift_5 = &H4240
                gift_6 = &H4242
                gift_7 = &H4244
                gift_8 = &H4246
                unlockinteriors = &H3F39
                unlockspefoods = &H3F48
                unlockgoods = &H3F30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Miieconomy = &H4568
                Equippedhat = &H4384
                Equippedclothe = &H4382
                Equippedinterior = &H4560
                gift_1 = &H4898
                gift_2 = &H489A
                gift_3 = &H489C
                gift_4 = &H489E
                gift_5 = &H48A0
                gift_6 = &H48A2
                gift_7 = &H48A4
                gift_8 = &H48A6
                unlockinteriors = &H4599
                unlockspefoods = &H45A8
                unlockgoods = &H4590
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Miieconomy = &H4BC8
                Equippedhat = &H49E4
                Equippedclothe = &H49E2
                Equippedinterior = &H4BC0
                gift_1 = &H4EF8
                gift_2 = &H4EFA
                gift_3 = &H4EFC
                gift_4 = &H4EFE
                gift_5 = &H4F00
                gift_6 = &H4F02
                gift_7 = &H4F04
                gift_8 = &H4F06
                unlockinteriors = &H4BF9
                unlockspefoods = &H4C08
                unlockgoods = &H4BF0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Miieconomy = &H5228
                Equippedhat = &H5044
                Equippedclothe = &H5042
                Equippedinterior = &H5220
                gift_1 = &H5558
                gift_2 = &H555A
                gift_3 = &H555C
                gift_4 = &H555E
                gift_5 = &H5560
                gift_6 = &H5562
                gift_7 = &H5564
                gift_8 = &H5566
                unlockinteriors = &H5259
                unlockspefoods = &H5268
                unlockgoods = &H5250
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Miieconomy = &H5888
                Equippedhat = &H56A4
                Equippedclothe = &H56A2
                Equippedinterior = &H5880
                gift_1 = &H5BB8
                gift_2 = &H5BBA
                gift_3 = &H5BBC
                gift_4 = &H5BBE
                gift_5 = &H5BC0
                gift_6 = &H5BC2
                gift_7 = &H5BC4
                gift_8 = &H5BC6
                unlockinteriors = &H58B9
                unlockspefoods = &H58C8
                unlockgoods = &H58B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Miieconomy = &H5EE8
                Equippedhat = &H5D04
                Equippedclothe = &H5D02
                Equippedinterior = &H5EE0
                gift_1 = &H6218
                gift_2 = &H621A
                gift_3 = &H621C
                gift_4 = &H621E
                gift_5 = &H6220
                gift_6 = &H6222
                gift_7 = &H6224
                gift_8 = &H6226
                unlockinteriors = &H5F19
                unlockspefoods = &H5F28
                unlockgoods = &H5F10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Miieconomy = &H6548
                Equippedhat = &H6364
                Equippedclothe = &H6362
                Equippedinterior = &H6540
                gift_1 = &H6878
                gift_2 = &H687A
                gift_3 = &H687C
                gift_4 = &H687E
                gift_5 = &H6880
                gift_6 = &H6882
                gift_7 = &H6884
                gift_8 = &H6886
                unlockinteriors = &H6579
                unlockspefoods = &H6588
                unlockgoods = &H6570
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Miieconomy = &H6BA8
                Equippedhat = &H69C4
                Equippedclothe = &H69C2
                Equippedinterior = &H6BA0
                gift_1 = &H6ED8
                gift_2 = &H6EDA
                gift_3 = &H6EDC
                gift_4 = &H6EDE
                gift_5 = &H6EE0
                gift_6 = &H6EE2
                gift_7 = &H6EE4
                gift_8 = &H6EE6
                unlockinteriors = &H6BD9
                unlockspefoods = &H6BE8
                unlockgoods = &H6BD0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Miieconomy = &H7208
                Equippedhat = &H7024
                Equippedclothe = &H7022
                Equippedinterior = &H7200
                gift_1 = &H7538
                gift_2 = &H753A
                gift_3 = &H753C
                gift_4 = &H753E
                gift_5 = &H7540
                gift_6 = &H7542
                gift_7 = &H7544
                gift_8 = &H7546
                unlockinteriors = &H7239
                unlockspefoods = &H7248
                unlockgoods = &H7230
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Miieconomy = &H7868
                Equippedhat = &H7684
                Equippedclothe = &H7682
                Equippedinterior = &H7860
                gift_1 = &H7B98
                gift_2 = &H7B9A
                gift_3 = &H7B9C
                gift_4 = &H7B9E
                gift_5 = &H7BA0
                gift_6 = &H7BA2
                gift_7 = &H7BA4
                gift_8 = &H7BA6
                unlockinteriors = &H7899
                unlockspefoods = &H78A8
                unlockgoods = &H7890
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Miieconomy = &H7EC8
                Equippedhat = &H7CE4
                Equippedclothe = &H7CE2
                Equippedinterior = &H7EC0
                gift_1 = &H81F8
                gift_2 = &H81FA
                gift_3 = &H81FC
                gift_4 = &H81FE
                gift_5 = &H8200
                gift_6 = &H8202
                gift_7 = &H8204
                gift_8 = &H8206
                unlockinteriors = &H7EF9
                unlockspefoods = &H7F08
                unlockgoods = &H7EF0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Miieconomy = &H8528
                Equippedhat = &H8344
                Equippedclothe = &H8342
                Equippedinterior = &H8520
                gift_1 = &H8858
                gift_2 = &H885A
                gift_3 = &H885C
                gift_4 = &H885E
                gift_5 = &H8860
                gift_6 = &H8862
                gift_7 = &H8864
                gift_8 = &H8866
                unlockinteriors = &H8559
                unlockspefoods = &H8568
                unlockgoods = &H8550
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Miieconomy = &H8B88
                Equippedhat = &H89A4
                Equippedclothe = &H89A2
                Equippedinterior = &H8B80
                gift_1 = &H8EB8
                gift_2 = &H8EBA
                gift_3 = &H8EBC
                gift_4 = &H8EBE
                gift_5 = &H8EC0
                gift_6 = &H8EC2
                gift_7 = &H8EC4
                gift_8 = &H8EC6
                unlockinteriors = &H8BB9
                unlockspefoods = &H8BC8
                unlockgoods = &H8BB0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Miieconomy = &H91E8
                Equippedhat = &H9004
                Equippedclothe = &H9002
                Equippedinterior = &H91E0
                gift_1 = &H9518
                gift_2 = &H951A
                gift_3 = &H951C
                gift_4 = &H951E
                gift_5 = &H9520
                gift_6 = &H9522
                gift_7 = &H9524
                gift_8 = &H9526
                unlockinteriors = &H9219
                unlockspefoods = &H9228
                unlockgoods = &H9210
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Miieconomy = &H9848
                Equippedhat = &H9664
                Equippedclothe = &H9662
                Equippedinterior = &H9840
                gift_1 = &H9B78
                gift_2 = &H9B7A
                gift_3 = &H9B7C
                gift_4 = &H9B7E
                gift_5 = &H9B80
                gift_6 = &H9B82
                gift_7 = &H9B84
                gift_8 = &H9B86
                unlockinteriors = &H9879
                unlockspefoods = &H9888
                unlockgoods = &H9870
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Miieconomy = &H9EA8
                Equippedhat = &H9CC4
                Equippedclothe = &H9CC2
                Equippedinterior = &H9EA0
                gift_1 = &HA1D8
                gift_2 = &HA1DA
                gift_3 = &HA1DC
                gift_4 = &HA1DE
                gift_5 = &HA1E0
                gift_6 = &HA1E2
                gift_7 = &HA1E4
                gift_8 = &HA1E6
                unlockinteriors = &H9ED9
                unlockspefoods = &H9EE8
                unlockgoods = &H9ED0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Miieconomy = &HA508
                Equippedhat = &HA324
                Equippedclothe = &HA322
                Equippedinterior = &HA500
                gift_1 = &HA838
                gift_2 = &HA83A
                gift_3 = &HA83C
                gift_4 = &HA83E
                gift_5 = &HA840
                gift_6 = &HA842
                gift_7 = &HA844
                gift_8 = &HA846
                unlockinteriors = &HA539
                unlockspefoods = &HA548
                unlockgoods = &HA530
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Miieconomy = &HAB68
                Equippedhat = &HA984
                Equippedclothe = &HA982
                Equippedinterior = &HAB60
                gift_1 = &HAE98
                gift_2 = &HAE9A
                gift_3 = &HAE9C
                gift_4 = &HAE9E
                gift_5 = &HAEA0
                gift_6 = &HAEA2
                gift_7 = &HAEA4
                gift_8 = &HAEA6
                unlockinteriors = &HAB99
                unlockspefoods = &HABA8
                unlockgoods = &HAB90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Miieconomy = &HB1C8
                Equippedhat = &HAFE4
                Equippedclothe = &HAFE2
                Equippedinterior = &HB1C0
                gift_1 = &HB4F8
                gift_2 = &HB4FA
                gift_3 = &HB4FC
                gift_4 = &HB4FE
                gift_5 = &HB500
                gift_6 = &HB502
                gift_7 = &HB504
                gift_8 = &HB506
                unlockinteriors = &HB1F9
                unlockspefoods = &HB208
                unlockgoods = &HB1F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Miieconomy = &HB828
                Equippedhat = &HB644
                Equippedclothe = &HB642
                Equippedinterior = &HB820
                gift_1 = &HBB58
                gift_2 = &HBB5A
                gift_3 = &HBB5C
                gift_4 = &HBB5E
                gift_5 = &HBB60
                gift_6 = &HBB62
                gift_7 = &HBB64
                gift_8 = &HBB66
                unlockinteriors = &HB859
                unlockspefoods = &HB868
                unlockgoods = &HB850
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Miieconomy = &HBE88
                Equippedhat = &HBCA4
                Equippedclothe = &HBCA2
                Equippedinterior = &HBE80
                gift_1 = &HC1B8
                gift_2 = &HC1BA
                gift_3 = &HC1BC
                gift_4 = &HC1BE
                gift_5 = &HC1C0
                gift_6 = &HC1C2
                gift_7 = &HC1C4
                gift_8 = &HC1C6
                unlockinteriors = &HBEB9
                unlockspefoods = &HBEC8
                unlockgoods = &HBEB0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Miieconomy = &HC4E8
                Equippedhat = &HC304
                Equippedclothe = &HC302
                Equippedinterior = &HC4E0
                gift_1 = &HC818
                gift_2 = &HC81A
                gift_3 = &HC81C
                gift_4 = &HC81E
                gift_5 = &HC820
                gift_6 = &HC822
                gift_7 = &HC824
                gift_8 = &HC826
                unlockinteriors = &HC519
                unlockspefoods = &HC528
                unlockgoods = &HC510
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Miieconomy = &HCB48
                Equippedhat = &HC964
                Equippedclothe = &HC962
                Equippedinterior = &HCB40
                gift_1 = &HCE78
                gift_2 = &HCE7A
                gift_3 = &HCE7C
                gift_4 = &HCE7E
                gift_5 = &HCE80
                gift_6 = &HCE82
                gift_7 = &HCE84
                gift_8 = &HCE86
                unlockinteriors = &HCB79
                unlockspefoods = &HCB88
                unlockgoods = &HCB70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Miieconomy = &HD1A8
                Equippedhat = &HCFC4
                Equippedclothe = &HCFC2
                Equippedinterior = &HD1A0
                gift_1 = &HD4D8
                gift_2 = &HD4DA
                gift_3 = &HD4DC
                gift_4 = &HD4DE
                gift_5 = &HD4E0
                gift_6 = &HD4E2
                gift_7 = &HD4E4
                gift_8 = &HD4E6
                unlockinteriors = &HD1D9
                unlockspefoods = &HD1E8
                unlockgoods = &HD1D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Miieconomy = &HD808
                Equippedhat = &HD624
                Equippedclothe = &HD622
                Equippedinterior = &HD800
                gift_1 = &HDB38
                gift_2 = &HDB3A
                gift_3 = &HDB3C
                gift_4 = &HDB3E
                gift_5 = &HDB40
                gift_6 = &HDB42
                gift_7 = &HDB44
                gift_8 = &HDB46
                unlockinteriors = &HD839
                unlockspefoods = &HD848
                unlockgoods = &HD830
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Miieconomy = &HDE68
                Equippedhat = &HDC84
                Equippedclothe = &HDC82
                Equippedinterior = &HDE60
                gift_1 = &HE198
                gift_2 = &HE19A
                gift_3 = &HE19C
                gift_4 = &HE19E
                gift_5 = &HE1A0
                gift_6 = &HE1A2
                gift_7 = &HE1A4
                gift_8 = &HE1A6
                unlockinteriors = &HDE99
                unlockspefoods = &HDEA8
                unlockgoods = &HDE90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Miieconomy = &HE4C8
                Equippedhat = &HE2E4
                Equippedclothe = &HE2E2
                Equippedinterior = &HE4C0
                gift_1 = &HE7F8
                gift_2 = &HE7FA
                gift_3 = &HE7FC
                gift_4 = &HE7FE
                gift_5 = &HE800
                gift_6 = &HE802
                gift_7 = &HE804
                gift_8 = &HE806
                unlockinteriors = &HE4F9
                unlockspefoods = &HE508
                unlockgoods = &HE4F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Miieconomy = &HEB28
                Equippedhat = &HE944
                Equippedclothe = &HE942
                Equippedinterior = &HEB20
                gift_1 = &HEE58
                gift_2 = &HEE5A
                gift_3 = &HEE5C
                gift_4 = &HEE5E
                gift_5 = &HEE60
                gift_6 = &HEE62
                gift_7 = &HEE64
                gift_8 = &HEE66
                unlockinteriors = &HEB59
                unlockspefoods = &HEB68
                unlockgoods = &HEB50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Miieconomy = &HF188
                Equippedhat = &HEFA4
                Equippedclothe = &HEFA2
                Equippedinterior = &HF180
                gift_1 = &HF4B8
                gift_2 = &HF4BA
                gift_3 = &HF4BC
                gift_4 = &HF4BE
                gift_5 = &HF4C0
                gift_6 = &HF4C2
                gift_7 = &HF4C4
                gift_8 = &HF4C6
                unlockinteriors = &HF1B9
                unlockspefoods = &HF1C8
                unlockgoods = &HF1B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Miieconomy = &HF7E8
                Equippedhat = &HF604
                Equippedclothe = &HF602
                Equippedinterior = &HF7E0
                gift_1 = &HFB18
                gift_2 = &HFB1A
                gift_3 = &HFB1C
                gift_4 = &HFB1E
                gift_5 = &HFB20
                gift_6 = &HFB22
                gift_7 = &HFB24
                gift_8 = &HFB26
                unlockinteriors = &HF819
                unlockspefoods = &HF828
                unlockgoods = &HF810
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Miieconomy = &HFE48
                Equippedhat = &HFC64
                Equippedclothe = &HFC62
                Equippedinterior = &HFE40
                gift_1 = &H10178
                gift_2 = &H1017A
                gift_3 = &H1017C
                gift_4 = &H1017E
                gift_5 = &H10180
                gift_6 = &H10182
                gift_7 = &H10184
                gift_8 = &H10186
                unlockinteriors = &HFE79
                unlockspefoods = &HFE88
                unlockgoods = &HFE70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Miieconomy = &H104A8
                Equippedhat = &H102C4
                Equippedclothe = &H102C2
                Equippedinterior = &H104A0
                gift_1 = &H107D8
                gift_2 = &H107DA
                gift_3 = &H107DC
                gift_4 = &H107DE
                gift_5 = &H107E0
                gift_6 = &H107E2
                gift_7 = &H107E4
                gift_8 = &H107E6
                unlockinteriors = &H104D9
                unlockspefoods = &H104E8
                unlockgoods = &H104D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Miieconomy = &H10B08
                Equippedhat = &H10924
                Equippedclothe = &H10922
                Equippedinterior = &H10B00
                gift_1 = &H10E38
                gift_2 = &H10E3A
                gift_3 = &H10E3C
                gift_4 = &H10E3E
                gift_5 = &H10E40
                gift_6 = &H10E42
                gift_7 = &H10E44
                gift_8 = &H10E46
                unlockinteriors = &H10B39
                unlockspefoods = &H10B48
                unlockgoods = &H10B30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Miieconomy = &H11168
                Equippedhat = &H10F84
                Equippedclothe = &H10F82
                Equippedinterior = &H11160
                gift_1 = &H11498
                gift_2 = &H1149A
                gift_3 = &H1149C
                gift_4 = &H1149E
                gift_5 = &H114A0
                gift_6 = &H114A2
                gift_7 = &H114A4
                gift_8 = &H114A6
                unlockinteriors = &H11199
                unlockspefoods = &H111A8
                unlockgoods = &H11190
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Miieconomy = &H117C8
                Equippedhat = &H115E4
                Equippedclothe = &H115E2
                Equippedinterior = &H117C0
                gift_1 = &H11AF8
                gift_2 = &H11AFA
                gift_3 = &H11AFC
                gift_4 = &H11AFE
                gift_5 = &H11B00
                gift_6 = &H11B02
                gift_7 = &H11B04
                gift_8 = &H11B06
                unlockinteriors = &H117F9
                unlockspefoods = &H11808
                unlockgoods = &H117F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Miieconomy = &H11E28
                Equippedhat = &H11C44
                Equippedclothe = &H11C42
                Equippedinterior = &H11E20
                gift_1 = &H12158
                gift_2 = &H1215A
                gift_3 = &H1215C
                gift_4 = &H1215E
                gift_5 = &H12160
                gift_6 = &H12162
                gift_7 = &H12164
                gift_8 = &H12166
                unlockinteriors = &H11E59
                unlockspefoods = &H11E68
                unlockgoods = &H11E50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Miieconomy = &H12488
                Equippedhat = &H122A4
                Equippedclothe = &H122A2
                Equippedinterior = &H12480
                gift_1 = &H127B8
                gift_2 = &H127BA
                gift_3 = &H127BC
                gift_4 = &H127BE
                gift_5 = &H127C0
                gift_6 = &H127C2
                gift_7 = &H127C4
                gift_8 = &H127C6
                unlockinteriors = &H124B9
                unlockspefoods = &H124C8
                unlockgoods = &H124B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Miieconomy = &H12AE8
                Equippedhat = &H12904
                Equippedclothe = &H12902
                Equippedinterior = &H12AE0
                gift_1 = &H12E18
                gift_2 = &H12E1A
                gift_3 = &H12E1C
                gift_4 = &H12E1E
                gift_5 = &H12E20
                gift_6 = &H12E22
                gift_7 = &H12E24
                gift_8 = &H12E26
                unlockinteriors = &H12B19
                unlockspefoods = &H12B28
                unlockgoods = &H12B10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Miieconomy = &H13148
                Equippedhat = &H12F64
                Equippedclothe = &H12F62
                Equippedinterior = &H13140
                gift_1 = &H13478
                gift_2 = &H1347A
                gift_3 = &H1347C
                gift_4 = &H1347E
                gift_5 = &H13480
                gift_6 = &H13482
                gift_7 = &H13484
                gift_8 = &H13486
                unlockinteriors = &H13179
                unlockspefoods = &H13188
                unlockgoods = &H13170
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Miieconomy = &H137A8
                Equippedhat = &H135C4
                Equippedclothe = &H135C2
                Equippedinterior = &H137A0
                gift_1 = &H13AD8
                gift_2 = &H13ADA
                gift_3 = &H13ADC
                gift_4 = &H13ADE
                gift_5 = &H13AE0
                gift_6 = &H13AE2
                gift_7 = &H13AE4
                gift_8 = &H13AE6
                unlockinteriors = &H137D9
                unlockspefoods = &H137E8
                unlockgoods = &H137D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Miieconomy = &H13E08
                Equippedhat = &H13C24
                Equippedclothe = &H13C22
                Equippedinterior = &H13E00
                gift_1 = &H14138
                gift_2 = &H1413A
                gift_3 = &H1413C
                gift_4 = &H1413E
                gift_5 = &H14140
                gift_6 = &H14142
                gift_7 = &H14144
                gift_8 = &H14146
                unlockinteriors = &H13E39
                unlockspefoods = &H13E48
                unlockgoods = &H13E30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Miieconomy = &H14468
                Equippedhat = &H14284
                Equippedclothe = &H14282
                Equippedinterior = &H14460
                gift_1 = &H14798
                gift_2 = &H1479A
                gift_3 = &H1479C
                gift_4 = &H1479E
                gift_5 = &H147A0
                gift_6 = &H147A2
                gift_7 = &H147A4
                gift_8 = &H147A6
                unlockinteriors = &H14499
                unlockspefoods = &H144A8
                unlockgoods = &H14490
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Miieconomy = &H14AC8
                Equippedhat = &H148E4
                Equippedclothe = &H148E2
                Equippedinterior = &H14AC0
                gift_1 = &H14DF8
                gift_2 = &H14DFA
                gift_3 = &H14DFC
                gift_4 = &H14DFE
                gift_5 = &H14E00
                gift_6 = &H14E02
                gift_7 = &H14E04
                gift_8 = &H14E06
                unlockinteriors = &H14AF9
                unlockspefoods = &H14B08
                unlockgoods = &H14AF0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Miieconomy = &H15128
                Equippedhat = &H14F44
                Equippedclothe = &H14F42
                Equippedinterior = &H15120
                gift_1 = &H15458
                gift_2 = &H1545A
                gift_3 = &H1545C
                gift_4 = &H1545E
                gift_5 = &H15460
                gift_6 = &H15462
                gift_7 = &H15464
                gift_8 = &H15466
                unlockinteriors = &H15159
                unlockspefoods = &H15168
                unlockgoods = &H15150
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Miieconomy = &H15788
                Equippedhat = &H155A4
                Equippedclothe = &H155A2
                Equippedinterior = &H15780
                gift_1 = &H15AB8
                gift_2 = &H15ABA
                gift_3 = &H15ABC
                gift_4 = &H15ABE
                gift_5 = &H15AC0
                gift_6 = &H15AC2
                gift_7 = &H15AC4
                gift_8 = &H15AC6
                unlockinteriors = &H157B9
                unlockspefoods = &H157C8
                unlockgoods = &H157B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Miieconomy = &H15DE8
                Equippedhat = &H15C04
                Equippedclothe = &H15C02
                Equippedinterior = &H15DE0
                gift_1 = &H16118
                gift_2 = &H1611A
                gift_3 = &H1611C
                gift_4 = &H1611E
                gift_5 = &H16120
                gift_6 = &H16122
                gift_7 = &H16124
                gift_8 = &H16126
                unlockinteriors = &H15E19
                unlockspefoods = &H15E28
                unlockgoods = &H15E10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Miieconomy = &H16448
                Equippedhat = &H16264
                Equippedclothe = &H16262
                Equippedinterior = &H16440
                gift_1 = &H16778
                gift_2 = &H1677A
                gift_3 = &H1677C
                gift_4 = &H1677E
                gift_5 = &H16780
                gift_6 = &H16782
                gift_7 = &H16784
                gift_8 = &H16786
                unlockinteriors = &H16479
                unlockspefoods = &H16488
                unlockgoods = &H16470
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Miieconomy = &H16AA8
                Equippedhat = &H168C4
                Equippedclothe = &H168C2
                Equippedinterior = &H16AA0
                gift_1 = &H16DD8
                gift_2 = &H16DDA
                gift_3 = &H16DDC
                gift_4 = &H16DDE
                gift_5 = &H16DE0
                gift_6 = &H16DE2
                gift_7 = &H16DE4
                gift_8 = &H16DE6
                unlockinteriors = &H16AD9
                unlockspefoods = &H16AE8
                unlockgoods = &H16AD0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Miieconomy = &H17108
                Equippedhat = &H16F24
                Equippedclothe = &H16F22
                Equippedinterior = &H17100
                gift_1 = &H17438
                gift_2 = &H1743A
                gift_3 = &H1743C
                gift_4 = &H1743E
                gift_5 = &H17440
                gift_6 = &H17442
                gift_7 = &H17444
                gift_8 = &H17446
                unlockinteriors = &H17139
                unlockspefoods = &H17148
                unlockgoods = &H17130
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Miieconomy = &H17768
                Equippedhat = &H17584
                Equippedclothe = &H17582
                Equippedinterior = &H17760
                gift_1 = &H17A98
                gift_2 = &H17A9A
                gift_3 = &H17A9C
                gift_4 = &H17A9E
                gift_5 = &H17AA0
                gift_6 = &H17AA2
                gift_7 = &H17AA4
                gift_8 = &H17AA6
                unlockinteriors = &H17799
                unlockspefoods = &H177A8
                unlockgoods = &H17790
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Miieconomy = &H17DC8
                Equippedhat = &H17BE4
                Equippedclothe = &H17BE2
                Equippedinterior = &H17DC0
                gift_1 = &H180F8
                gift_2 = &H180FA
                gift_3 = &H180FC
                gift_4 = &H180FE
                gift_5 = &H18100
                gift_6 = &H18102
                gift_7 = &H18104
                gift_8 = &H18106
                unlockinteriors = &H17DF9
                unlockspefoods = &H17E08
                unlockgoods = &H17DF0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Miieconomy = &H18428
                Equippedhat = &H18244
                Equippedclothe = &H18242
                Equippedinterior = &H18420
                gift_1 = &H18758
                gift_2 = &H1875A
                gift_3 = &H1875C
                gift_4 = &H1875E
                gift_5 = &H18760
                gift_6 = &H18762
                gift_7 = &H18764
                gift_8 = &H18766
                unlockinteriors = &H18459
                unlockspefoods = &H18468
                unlockgoods = &H18450
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Miieconomy = &H18A88
                Equippedhat = &H188A4
                Equippedclothe = &H188A2
                Equippedinterior = &H18A80
                gift_1 = &H18DB8
                gift_2 = &H18DBA
                gift_3 = &H18DBC
                gift_4 = &H18DBE
                gift_5 = &H18DC0
                gift_6 = &H18DC2
                gift_7 = &H18DC4
                gift_8 = &H18DC6
                unlockinteriors = &H18AB9
                unlockspefoods = &H18AC8
                unlockgoods = &H18AB0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Miieconomy = &H190E8
                Equippedhat = &H18F04
                Equippedclothe = &H18F02
                Equippedinterior = &H190E0
                gift_1 = &H19418
                gift_2 = &H1941A
                gift_3 = &H1941C
                gift_4 = &H1941E
                gift_5 = &H19420
                gift_6 = &H19422
                gift_7 = &H19424
                gift_8 = &H19426
                unlockinteriors = &H19119
                unlockspefoods = &H19128
                unlockgoods = &H19110
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Miieconomy = &H19748
                Equippedhat = &H19564
                Equippedclothe = &H19562
                Equippedinterior = &H19740
                gift_1 = &H19A78
                gift_2 = &H19A7A
                gift_3 = &H19A7C
                gift_4 = &H19A7E
                gift_5 = &H19A80
                gift_6 = &H19A82
                gift_7 = &H19A84
                gift_8 = &H19A86
                unlockinteriors = &H19779
                unlockspefoods = &H19788
                unlockgoods = &H19770
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Miieconomy = &H19DA8
                Equippedhat = &H19BC4
                Equippedclothe = &H19BC2
                Equippedinterior = &H19DA0
                gift_1 = &H1A0D8
                gift_2 = &H1A0DA
                gift_3 = &H1A0DC
                gift_4 = &H1A0DE
                gift_5 = &H1A0E0
                gift_6 = &H1A0E2
                gift_7 = &H1A0E4
                gift_8 = &H1A0E6
                unlockinteriors = &H19DD9
                unlockspefoods = &H19DE8
                unlockgoods = &H19DD0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Miieconomy = &H1A408
                Equippedhat = &H1A224
                Equippedclothe = &H1A222
                Equippedinterior = &H1A400
                gift_1 = &H1A738
                gift_2 = &H1A73A
                gift_3 = &H1A73C
                gift_4 = &H1A73E
                gift_5 = &H1A740
                gift_6 = &H1A742
                gift_7 = &H1A744
                gift_8 = &H1A746
                unlockinteriors = &H1A439
                unlockspefoods = &H1A448
                unlockgoods = &H1A430
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Miieconomy = &H1AA68
                Equippedhat = &H1A884
                Equippedclothe = &H1A882
                Equippedinterior = &H1AA60
                gift_1 = &H1AD98
                gift_2 = &H1AD9A
                gift_3 = &H1AD9C
                gift_4 = &H1AD9E
                gift_5 = &H1ADA0
                gift_6 = &H1ADA2
                gift_7 = &H1ADA4
                gift_8 = &H1ADA6
                unlockinteriors = &H1AA99
                unlockspefoods = &H1AAA8
                unlockgoods = &H1AA90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Miieconomy = &H1B0C8
                Equippedhat = &H1AEE4
                Equippedclothe = &H1AEE2
                Equippedinterior = &H1B0C0
                gift_1 = &H1B3F8
                gift_2 = &H1B3FA
                gift_3 = &H1B3FC
                gift_4 = &H1B3FE
                gift_5 = &H1B400
                gift_6 = &H1B402
                gift_7 = &H1B404
                gift_8 = &H1B406
                unlockinteriors = &H1B0F9
                unlockspefoods = &H1B108
                unlockgoods = &H1B0F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Miieconomy = &H1B728
                Equippedhat = &H1B544
                Equippedclothe = &H1B542
                Equippedinterior = &H1B720
                gift_1 = &H1BA58
                gift_2 = &H1BA5A
                gift_3 = &H1BA5C
                gift_4 = &H1BA5E
                gift_5 = &H1BA60
                gift_6 = &H1BA62
                gift_7 = &H1BA64
                gift_8 = &H1BA66
                unlockinteriors = &H1B759
                unlockspefoods = &H1B768
                unlockgoods = &H1B750
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Miieconomy = &H1BD88
                Equippedhat = &H1BBA4
                Equippedclothe = &H1BBA2
                Equippedinterior = &H1BD80
                gift_1 = &H1C0B8
                gift_2 = &H1C0BA
                gift_3 = &H1C0BC
                gift_4 = &H1C0BE
                gift_5 = &H1C0C0
                gift_6 = &H1C0C2
                gift_7 = &H1C0C4
                gift_8 = &H1C0C6
                unlockinteriors = &H1BDB9
                unlockspefoods = &H1BDC8
                unlockgoods = &H1BDB0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Miieconomy = &H1C3E8
                Equippedhat = &H1C204
                Equippedclothe = &H1C202
                Equippedinterior = &H1C3E0
                gift_1 = &H1C718
                gift_2 = &H1C71A
                gift_3 = &H1C71C
                gift_4 = &H1C71E
                gift_5 = &H1C720
                gift_6 = &H1C722
                gift_7 = &H1C724
                gift_8 = &H1C726
                unlockinteriors = &H1C419
                unlockspefoods = &H1C428
                unlockgoods = &H1C410
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Miieconomy = &H1CA48
                Equippedhat = &H1C864
                Equippedclothe = &H1C862
                Equippedinterior = &H1CA40
                gift_1 = &H1CD78
                gift_2 = &H1CD7A
                gift_3 = &H1CD7C
                gift_4 = &H1CD7E
                gift_5 = &H1CD80
                gift_6 = &H1CD82
                gift_7 = &H1CD84
                gift_8 = &H1CD86
                unlockinteriors = &H1CA79
                unlockspefoods = &H1CA88
                unlockgoods = &H1CA70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Miieconomy = &H1D0A8
                Equippedhat = &H1CEC4
                Equippedclothe = &H1CEC2
                Equippedinterior = &H1D0A0
                gift_1 = &H1D3D8
                gift_2 = &H1D3DA
                gift_3 = &H1D3DC
                gift_4 = &H1D3DE
                gift_5 = &H1D3E0
                gift_6 = &H1D3E2
                gift_7 = &H1D3E4
                gift_8 = &H1D3E6
                unlockinteriors = &H1D0D9
                unlockspefoods = &H1D0E8
                unlockgoods = &H1D0D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Miieconomy = &H1D708
                Equippedhat = &H1D524
                Equippedclothe = &H1D522
                Equippedinterior = &H1D700
                gift_1 = &H1DA38
                gift_2 = &H1DA3A
                gift_3 = &H1DA3C
                gift_4 = &H1DA3E
                gift_5 = &H1DA40
                gift_6 = &H1DA42
                gift_7 = &H1DA44
                gift_8 = &H1DA46
                unlockinteriors = &H1D739
                unlockspefoods = &H1D748
                unlockgoods = &H1D730
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Miieconomy = &H1DD68
                Equippedhat = &H1DB84
                Equippedclothe = &H1DB82
                Equippedinterior = &H1DD60
                gift_1 = &H1E098
                gift_2 = &H1E09A
                gift_3 = &H1E09C
                gift_4 = &H1E09E
                gift_5 = &H1E0A0
                gift_6 = &H1E0A2
                gift_7 = &H1E0A4
                gift_8 = &H1E0A6
                unlockinteriors = &H1DD99
                unlockspefoods = &H1DDA8
                unlockgoods = &H1DD90
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Miieconomy = &H1E3C8
                Equippedhat = &H1E1E4
                Equippedclothe = &H1E1E2
                Equippedinterior = &H1E3C0
                gift_1 = &H1E6F8
                gift_2 = &H1E6FA
                gift_3 = &H1E6FC
                gift_4 = &H1E6FE
                gift_5 = &H1E700
                gift_6 = &H1E702
                gift_7 = &H1E704
                gift_8 = &H1E706
                unlockinteriors = &H1E3F9
                unlockspefoods = &H1E408
                unlockgoods = &H1E3F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Miieconomy = &H1EA28
                Equippedhat = &H1E844
                Equippedclothe = &H1E842
                Equippedinterior = &H1EA20
                gift_1 = &H1ED58
                gift_2 = &H1ED5A
                gift_3 = &H1ED5C
                gift_4 = &H1ED5E
                gift_5 = &H1ED60
                gift_6 = &H1ED62
                gift_7 = &H1ED64
                gift_8 = &H1ED66
                unlockinteriors = &H1EA59
                unlockspefoods = &H1EA68
                unlockgoods = &H1EA50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Miieconomy = &H1F088
                Equippedhat = &H1EEA4
                Equippedclothe = &H1EEA2
                Equippedinterior = &H1F080
                gift_1 = &H1F3B8
                gift_2 = &H1F3BA
                gift_3 = &H1F3BC
                gift_4 = &H1F3BE
                gift_5 = &H1F3C0
                gift_6 = &H1F3C2
                gift_7 = &H1F3C4
                gift_8 = &H1F3C6
                unlockinteriors = &H1F0B9
                unlockspefoods = &H1F0C8
                unlockgoods = &H1F0B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Miieconomy = &H1F6E8
                Equippedhat = &H1F504
                Equippedclothe = &H1F502
                Equippedinterior = &H1F6E0
                gift_1 = &H1FA18
                gift_2 = &H1FA1A
                gift_3 = &H1FA1C
                gift_4 = &H1FA1E
                gift_5 = &H1FA20
                gift_6 = &H1FA22
                gift_7 = &H1FA24
                gift_8 = &H1FA26
                unlockinteriors = &H1F719
                unlockspefoods = &H1F728
                unlockgoods = &H1F710
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Miieconomy = &H1FD48
                Equippedhat = &H1FB64
                Equippedclothe = &H1FB62
                Equippedinterior = &H1FD40
                gift_1 = &H20078
                gift_2 = &H2007A
                gift_3 = &H2007C
                gift_4 = &H2007E
                gift_5 = &H20080
                gift_6 = &H20082
                gift_7 = &H20084
                gift_8 = &H20086
                unlockinteriors = &H1FD79
                unlockspefoods = &H1FD88
                unlockgoods = &H1FD70
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Miieconomy = &H203A8
                Equippedhat = &H201C4
                Equippedclothe = &H201C2
                Equippedinterior = &H203A0
                gift_1 = &H206D8
                gift_2 = &H206DA
                gift_3 = &H206DC
                gift_4 = &H206DE
                gift_5 = &H206E0
                gift_6 = &H206E2
                gift_7 = &H206E4
                gift_8 = &H206E6
                unlockinteriors = &H203D9
                unlockspefoods = &H203E8
                unlockgoods = &H203D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Miieconomy = &H20A08
                Equippedhat = &H20824
                Equippedclothe = &H20822
                Equippedinterior = &H20A00
                gift_1 = &H20D38
                gift_2 = &H20D3A
                gift_3 = &H20D3C
                gift_4 = &H20D3E
                gift_5 = &H20D40
                gift_6 = &H20D42
                gift_7 = &H20D44
                gift_8 = &H20D46
                unlockinteriors = &H20A39
                unlockspefoods = &H20A48
                unlockgoods = &H20A30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Miieconomy = &H21068
                Equippedhat = &H20E84
                Equippedclothe = &H20E82
                Equippedinterior = &H21060
                gift_1 = &H21398
                gift_2 = &H2139A
                gift_3 = &H2139C
                gift_4 = &H2139E
                gift_5 = &H213A0
                gift_6 = &H213A2
                gift_7 = &H213A4
                gift_8 = &H213A6
                unlockinteriors = &H21099
                unlockspefoods = &H210A8
                unlockgoods = &H21090
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Miieconomy = &H216C8
                Equippedhat = &H214E4
                Equippedclothe = &H214E2
                Equippedinterior = &H216C0
                gift_1 = &H219F8
                gift_2 = &H219FA
                gift_3 = &H219FC
                gift_4 = &H219FE
                gift_5 = &H21A00
                gift_6 = &H21A02
                gift_7 = &H21A04
                gift_8 = &H21A06
                unlockinteriors = &H216F9
                unlockspefoods = &H21708
                unlockgoods = &H216F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Miieconomy = &H21D28
                Equippedhat = &H21B44
                Equippedclothe = &H21B42
                Equippedinterior = &H21D20
                gift_1 = &H22058
                gift_2 = &H2205A
                gift_3 = &H2205C
                gift_4 = &H2205E
                gift_5 = &H22060
                gift_6 = &H22062
                gift_7 = &H22064
                gift_8 = &H22066
                unlockinteriors = &H21D59
                unlockspefoods = &H21D68
                unlockgoods = &H21D50
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Miieconomy = &H22388
                Equippedhat = &H221A4
                Equippedclothe = &H221A2
                Equippedinterior = &H22380
                gift_1 = &H226B8
                gift_2 = &H226BA
                gift_3 = &H226BC
                gift_4 = &H226BE
                gift_5 = &H226C0
                gift_6 = &H226C2
                gift_7 = &H226C4
                gift_8 = &H226C6
                unlockinteriors = &H223B9
                unlockspefoods = &H223C8
                unlockgoods = &H223B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Miieconomy = &H229E8
                Equippedhat = &H22804
                Equippedclothe = &H22802
                Equippedinterior = &H229E0
                gift_1 = &H22D18
                gift_2 = &H22D1A
                gift_3 = &H22D1C
                gift_4 = &H22D1E
                gift_5 = &H22D20
                gift_6 = &H22D22
                gift_7 = &H22D24
                gift_8 = &H22D26
                unlockinteriors = &H22A19
                unlockspefoods = &H22A28
                unlockgoods = &H22A10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Miieconomy = &H23048
                Equippedhat = &H22E64
                Equippedclothe = &H22E62
                Equippedinterior = &H23040
                gift_1 = &H23378
                gift_2 = &H2337A
                gift_3 = &H2337C
                gift_4 = &H2337E
                gift_5 = &H23380
                gift_6 = &H23382
                gift_7 = &H23384
                gift_8 = &H23386
                unlockinteriors = &H23079
                unlockspefoods = &H23088
                unlockgoods = &H23070
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Miieconomy = &H236A8
                Equippedhat = &H234C4
                Equippedclothe = &H234C2
                Equippedinterior = &H236A0
                gift_1 = &H239D8
                gift_2 = &H239DA
                gift_3 = &H239DC
                gift_4 = &H239DE
                gift_5 = &H239E0
                gift_6 = &H239E2
                gift_7 = &H239E4
                gift_8 = &H239E6
                unlockinteriors = &H236D9
                unlockspefoods = &H236E8
                unlockgoods = &H236D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Miieconomy = &H23D08
                Equippedhat = &H23B24
                Equippedclothe = &H23B22
                Equippedinterior = &H23D00
                gift_1 = &H24038
                gift_2 = &H2403A
                gift_3 = &H2403C
                gift_4 = &H2403E
                gift_5 = &H24040
                gift_6 = &H24042
                gift_7 = &H24044
                gift_8 = &H24046
                unlockinteriors = &H23D39
                unlockspefoods = &H23D48
                unlockgoods = &H23D30
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Miieconomy = &H24368
                Equippedhat = &H24184
                Equippedclothe = &H24182
                Equippedinterior = &H24360
                gift_1 = &H24698
                gift_2 = &H2469A
                gift_3 = &H2469C
                gift_4 = &H2469E
                gift_5 = &H246A0
                gift_6 = &H246A2
                gift_7 = &H246A4
                gift_8 = &H246A6
                unlockinteriors = &H24399
                unlockspefoods = &H243A8
                unlockgoods = &H24390
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Miieconomy = &H249C8
                Equippedhat = &H247E4
                Equippedclothe = &H247E2
                Equippedinterior = &H249C0
                gift_1 = &H24CF8
                gift_2 = &H24CFA
                gift_3 = &H24CFC
                gift_4 = &H24CFE
                gift_5 = &H24D00
                gift_6 = &H24D02
                gift_7 = &H24D04
                gift_8 = &H24D06
                unlockinteriors = &H249F9
                unlockspefoods = &H24A08
                unlockgoods = &H249F0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Miieconomy = &H25028
                Equippedhat = &H24E44
                Equippedclothe = &H24E42
                Equippedinterior = &H25020
                gift_1 = &H25358
                gift_2 = &H2535A
                gift_3 = &H2535C
                gift_4 = &H2535E
                gift_5 = &H25360
                gift_6 = &H25362
                gift_7 = &H25364
                gift_8 = &H25366
                unlockinteriors = &H25059
                unlockspefoods = &H25068
                unlockgoods = &H25050
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Miieconomy = &H25688
                Equippedhat = &H254A4
                Equippedclothe = &H254A2
                Equippedinterior = &H25680
                gift_1 = &H259B8
                gift_2 = &H259BA
                gift_3 = &H259BC
                gift_4 = &H259BE
                gift_5 = &H259C0
                gift_6 = &H259C2
                gift_7 = &H259C4
                gift_8 = &H259C6
                unlockinteriors = &H256B9
                unlockspefoods = &H256C8
                unlockgoods = &H256B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Miieconomy = &H25CE8
                Equippedhat = &H25B04
                Equippedclothe = &H25B02
                Equippedinterior = &H25CE0
                gift_1 = &H26018
                gift_2 = &H2601A
                gift_3 = &H2601C
                gift_4 = &H2601E
                gift_5 = &H26020
                gift_6 = &H26022
                gift_7 = &H26024
                gift_8 = &H26026
                unlockinteriors = &H25D19
                unlockspefoods = &H25D28
                unlockgoods = &H25D10
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Miieconomy = &H26348
                Equippedhat = &H26164
                Equippedclothe = &H26162
                Equippedinterior = &H26340
                gift_1 = &H26678
                gift_2 = &H2667A
                gift_3 = &H2667C
                gift_4 = &H2667E
                gift_5 = &H26680
                gift_6 = &H26682
                gift_7 = &H26684
                gift_8 = &H26686
                unlockinteriors = &H26379
                unlockspefoods = &H26388
                unlockgoods = &H26370
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Miieconomy = &H269A8
                Equippedhat = &H267C4
                Equippedclothe = &H267C2
                Equippedinterior = &H269A0
                gift_1 = &H26CD8
                gift_2 = &H26CDA
                gift_3 = &H26CDC
                gift_4 = &H26CDE
                gift_5 = &H26CE0
                gift_6 = &H26CE2
                gift_7 = &H26CE4
                gift_8 = &H26CE6
                unlockinteriors = &H269D9
                unlockspefoods = &H269E8
                unlockgoods = &H269D0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Miieconomy = &H27008
                Equippedhat = &H26E24
                Equippedclothe = &H26E22
                Equippedinterior = &H27000
                gift_1 = &H27338
                gift_2 = &H2733A
                gift_3 = &H2733C
                gift_4 = &H2733E
                gift_5 = &H27340
                gift_6 = &H27342
                gift_7 = &H27344
                gift_8 = &H27346
                unlockinteriors = &H27039
                unlockspefoods = &H27048
                unlockgoods = &H27030
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Miieconomy = &H27668
                Equippedhat = &H27484
                Equippedclothe = &H27482
                Equippedinterior = &H27660
                gift_1 = &H27998
                gift_2 = &H2799A
                gift_3 = &H2799C
                gift_4 = &H2799E
                gift_5 = &H279A0
                gift_6 = &H279A2
                gift_7 = &H279A4
                gift_8 = &H279A6
                unlockinteriors = &H27699
                unlockspefoods = &H276A8
                unlockgoods = &H27690
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Miieconomy = &H27CC8
                Equippedhat = &H27AE4
                Equippedclothe = &H27AE2
                Equippedinterior = &H27CC0
                gift_1 = &H27FF8
                gift_2 = &H27FFA
                gift_3 = &H27FFC
                gift_4 = &H27FFE
                gift_5 = &H28000
                gift_6 = &H28002
                gift_7 = &H28004
                gift_8 = &H28006
                unlockinteriors = &H27CF9
                unlockspefoods = &H27D08
                unlockgoods = &H27CF0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Miieconomy = &H28328
                Equippedhat = &H28144
                Equippedclothe = &H28142
                Equippedinterior = &H28320
                gift_1 = &H28658
                gift_2 = &H2865A
                gift_3 = &H2865C
                gift_4 = &H2865E
                gift_5 = &H28660
                gift_6 = &H28662
                gift_7 = &H28664
                gift_8 = &H28666
                unlockinteriors = &H28359
                unlockspefoods = &H28368
                unlockgoods = &H28350
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Miieconomy = &H28988
                Equippedhat = &H287A4
                Equippedclothe = &H287A2
                Equippedinterior = &H28980
                gift_1 = &H28CB8
                gift_2 = &H28CBA
                gift_3 = &H28CBC
                gift_4 = &H28CBE
                gift_5 = &H28CC0
                gift_6 = &H28CC2
                gift_7 = &H28CC4
                gift_8 = &H28CC6
                unlockinteriors = &H289B9
                unlockspefoods = &H289C8
                unlockgoods = &H289B0
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Miieconomy = &H28FE8
                Equippedhat = &H28E04
                Equippedclothe = &H28E02
                Equippedinterior = &H28FE0
                gift_1 = &H29318
                gift_2 = &H2931A
                gift_3 = &H2931C
                gift_4 = &H2931E
                gift_5 = &H29320
                gift_6 = &H29322
                gift_7 = &H29324
                gift_8 = &H29326
                unlockinteriors = &H29019
                unlockspefoods = &H29028
                unlockgoods = &H29010
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Miieconomy = &H29648
                Equippedhat = &H29464
                Equippedclothe = &H29462
                Equippedinterior = &H29640
                gift_1 = &H29978
                gift_2 = &H2997A
                gift_3 = &H2997C
                gift_4 = &H2997E
                gift_5 = &H29980
                gift_6 = &H29982
                gift_7 = &H29984
                gift_8 = &H29986
                unlockinteriors = &H29679
                unlockspefoods = &H29688
                unlockgoods = &H29670
            End If
        End If
    End Sub

    Public Sub Readmiiinventory()
        Try
            Dim Readdata As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Readdata.Position = Miieconomy
            valu_economy.Value = Readdata.ReadUInt32
            Readdata.Position = Equippedhat
            valu_switch_hats.Value = Readdata.ReadUInt16
            Readdata.Position = Equippedclothe
            valu_switch_clothes.Value = Readdata.ReadUInt16
            Readdata.Position = Equippedinterior
            valu_switch_interiors.Value = Readdata.ReadUInt16
            Readdata.Position = gift_1
            valu_itemmii_1.Value = Readdata.ReadUInt16
            Readdata.Position = gift_2
            valu_itemmii_2.Value = Readdata.ReadUInt16
            Readdata.Position = gift_3
            valu_itemmii_3.Value = Readdata.ReadUInt16
            Readdata.Position = gift_4
            valu_itemmii_4.Value = Readdata.ReadUInt16
            Readdata.Position = gift_5
            valu_itemmii_5.Value = Readdata.ReadUInt16
            Readdata.Position = gift_6
            valu_itemmii_6.Value = Readdata.ReadUInt16
            Readdata.Position = gift_7
            valu_itemmii_7.Value = Readdata.ReadUInt16
            Readdata.Position = gift_8
            valu_itemmii_8.Value = Readdata.ReadUInt16
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read mii inventory"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        Savefileregion()
        Readmiiinventory()
        Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(0)
        Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(0)
        Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(0)
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Writemiiinventory()
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_Miiedition.Visible = True
        Me.Close()
    End Sub

    Public Sub Writemiiinventory()
        Try
            Dim Writedata As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            'Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            Writedata.Position = Miieconomy
            Writedata.WriteUInt32(valu_economy.Value)
            Writedata.Position = Equippedhat
            Writedata.WriteUInt16(valu_switch_hats.Value)
            Writedata.Position = Equippedclothe
            Writedata.WriteUInt16(valu_switch_clothes.Value)
            Writedata.Position = Equippedinterior
            Writedata.WriteUInt16(valu_switch_interiors.Value)
            Writedata.Position = gift_1
            Writedata.WriteUInt16(valu_itemmii_1.Value)
            Writedata.Position = gift_2
            Writedata.WriteUInt16(valu_itemmii_2.Value)
            Writedata.Position = gift_3
            Writedata.WriteUInt16(valu_itemmii_3.Value)
            Writedata.Position = gift_4
            Writedata.WriteUInt16(valu_itemmii_4.Value)
            Writedata.Position = gift_5
            Writedata.WriteUInt16(valu_itemmii_5.Value)
            Writedata.Position = gift_6
            Writedata.WriteUInt16(valu_itemmii_6.Value)
            Writedata.Position = gift_7
            Writedata.WriteUInt16(valu_itemmii_7.Value)
            Writedata.Position = gift_8
            Writedata.WriteUInt16(valu_itemmii_8.Value)
            If Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(1) Then
                Writedata.Position = unlockgoods
                Writedata.WriteUInt16(65535)
            ElseIf Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(2) Then
                Writedata.Position = unlockgoods
                Writedata.WriteUInt16(0)
            End If
            If Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(1) Then
                Writedata.Position = unlockinteriors
                Writedata.WriteHexString("FFFFFFFFFFFFFFFFFFFFFFFF3F")
            ElseIf Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(2) Then
                Writedata.Position = unlockinteriors
                Writedata.WriteHexString("00000000000000000000000000")
            End If
            If Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(1) Then
                Writedata.Position = unlockspefoods
                Writedata.WriteHexString("FFFFFFFFFFFF")
            ElseIf Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(2) Then
                Writedata.Position = unlockspefoods
                Writedata.WriteHexString("000000000000")
            End If
            Writedata.Flush()
            'fs.Flush()
            TLSE_dialog.Text_TLSE_dialog.Text = "Mii inventory has been successfully edited"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to write Mii inventory"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub
End Class