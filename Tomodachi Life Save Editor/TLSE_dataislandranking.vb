Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_dataislandranking
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Islandranking_1 As String
    Dim Islandranking_2 As String
    Dim Islandranking_3 As String
    Dim Islandranking_4 As String
    Dim Islandranking_5 As String
    Dim Islandranking_6 As String
    Dim Islandranking_7 As String
    Dim Islandranking_8 As String
    Dim Islandranking_9 As String
    Dim Islandranking_10 As String
    Dim Islandranking_11 As String
    Dim Islandranking_12 As String
    Dim Islandranking_13 As String
    Dim Islandranking_14 As String
    Dim Islandranking_15 As String
    Dim Islandranking_16 As String
    Dim Islandranking_17 As String
    Dim Islandranking_18 As String
    Dim Islandranking_19 As String
    Dim Islandranking_20 As String
    Dim Islandranking_21 As String
    Dim Islandranking_22 As String
    Dim Islandranking_23 As String
    Dim Islandranking_24 As String
    Dim Islandranking_25 As String
    Dim Islandranking_26 As String
    Dim Islandranking_27 As String
    Dim Islandranking_28 As String
    Dim Islandranking_29 As String
    Dim Islandranking_30 As String
    Dim Islandranking_31 As String
    Dim Islandranking_32 As String
    Dim Islandranking_33 As String
    Dim Islandranking_34 As String
    Dim Islandranking_35 As String
    Dim Islandranking_36 As String
    Dim Islandranking_37 As String
    Dim Islandranking_38 As String
    Dim Islandranking_39 As String
    Dim Islandranking_40 As String
    Dim Islandranking_41 As String
    Dim Islandranking_42 As String
    Dim Islandranking_43 As String
    Dim Islandranking_44 As String
    Dim Islandranking_45 As String
    Dim Islandranking_46 As String
    Dim Islandranking_47 As String
    Dim Islandranking_48 As String
    Dim Islandranking_49 As String
    Dim Islandranking_50 As String
    Dim Islandranking_51 As String
    Dim Islandranking_52 As String
    Dim Islandranking_53 As String
    Dim Islandranking_54 As String
    Dim Islandranking_55 As String
    Dim Islandranking_56 As String
    Dim Islandranking_57 As String
    Dim Islandranking_58 As String
    Dim Islandranking_59 As String
    Dim Islandranking_60 As String
    Dim Islandranking_61 As String
    Dim Islandranking_62 As String
    Dim Islandranking_63 As String
    Dim Islandranking_64 As String
    Dim Islandranking_65 As String
    Dim Islandranking_66 As String
    Dim Islandranking_67 As String
    Dim Islandranking_68 As String
    Dim Islandranking_69 As String
    Dim Islandranking_70 As String
    Dim Islandranking_71 As String
    Dim Islandranking_72 As String
    Dim Islandranking_73 As String
    Dim Islandranking_74 As String
    Dim Islandranking_75 As String
    Dim Islandranking_76 As String
    Dim Islandranking_77 As String
    Dim Islandranking_78 As String
    Dim Islandranking_79 As String
    Dim Islandranking_80 As String
    Dim Islandranking_81 As String
    Dim Islandranking_82 As String
    Dim Islandranking_83 As String
    Dim Islandranking_84 As String
    Dim Islandranking_85 As String
    Dim Islandranking_86 As String
    Dim Islandranking_87 As String
    Dim Islandranking_88 As String
    Dim Islandranking_89 As String
    Dim Islandranking_90 As String
    Dim Islandranking_91 As String
    Dim Islandranking_92 As String
    Dim Islandranking_93 As String
    Dim Islandranking_94 As String
    Dim Islandranking_95 As String
    Dim Islandranking_96 As String
    Dim Islandranking_97 As String
    Dim Islandranking_98 As String
    Dim Islandranking_99 As String
    Dim Islandranking_100 As String
    Dim Islandrankingdetected As String
    Dim TLMII As String

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

    Private Sub TLSE_dataislandranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Switchfilever()
        Readislandrankname()
        Islandrankdetected()
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

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_datamanagement.Visible = True
        Me.Close()
    End Sub

    Public Sub Readislandrankname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H147270
                Select_islandranking.Items.Item(0) = "Island rank 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1472A0
                Select_islandranking.Items.Item(1) = "Island rank 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1472D0
                Select_islandranking.Items.Item(2) = "Island rank 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147300
                Select_islandranking.Items.Item(3) = "Island rank 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147330
                Select_islandranking.Items.Item(4) = "Island rank 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147360
                Select_islandranking.Items.Item(5) = "Island rank 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147390
                Select_islandranking.Items.Item(6) = "Island rank 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1473C0
                Select_islandranking.Items.Item(7) = "Island rank 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1473F0
                Select_islandranking.Items.Item(8) = "Island rank 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147420
                Select_islandranking.Items.Item(9) = "Island rank 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147450
                Select_islandranking.Items.Item(10) = "Island rank 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147480
                Select_islandranking.Items.Item(11) = "Island rank 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1474B0
                Select_islandranking.Items.Item(12) = "Island rank 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1474E0
                Select_islandranking.Items.Item(13) = "Island rank 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147510
                Select_islandranking.Items.Item(14) = "Island rank 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147540
                Select_islandranking.Items.Item(15) = "Island rank 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147570
                Select_islandranking.Items.Item(16) = "Island rank 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1475A0
                Select_islandranking.Items.Item(17) = "Island rank 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1475D0
                Select_islandranking.Items.Item(18) = "Island rank 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147600
                Select_islandranking.Items.Item(19) = "Island rank 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147630
                Select_islandranking.Items.Item(20) = "Island rank 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147660
                Select_islandranking.Items.Item(21) = "Island rank 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147690
                Select_islandranking.Items.Item(22) = "Island rank 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1476C0
                Select_islandranking.Items.Item(23) = "Island rank 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1476F0
                Select_islandranking.Items.Item(24) = "Island rank 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147720
                Select_islandranking.Items.Item(25) = "Island rank 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147750
                Select_islandranking.Items.Item(26) = "Island rank 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147780
                Select_islandranking.Items.Item(27) = "Island rank 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1477B0
                Select_islandranking.Items.Item(28) = "Island rank 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1477E0
                Select_islandranking.Items.Item(29) = "Island rank 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147810
                Select_islandranking.Items.Item(30) = "Island rank 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147840
                Select_islandranking.Items.Item(31) = "Island rank 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147870
                Select_islandranking.Items.Item(32) = "Island rank 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1478A0
                Select_islandranking.Items.Item(33) = "Island rank 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1478D0
                Select_islandranking.Items.Item(34) = "Island rank 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147900
                Select_islandranking.Items.Item(35) = "Island rank 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147930
                Select_islandranking.Items.Item(36) = "Island rank 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147960
                Select_islandranking.Items.Item(37) = "Island rank 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147990
                Select_islandranking.Items.Item(38) = "Island rank 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1479C0
                Select_islandranking.Items.Item(39) = "Island rank 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1479F0
                Select_islandranking.Items.Item(40) = "Island rank 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147A20
                Select_islandranking.Items.Item(41) = "Island rank 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147A50
                Select_islandranking.Items.Item(42) = "Island rank 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147A80
                Select_islandranking.Items.Item(43) = "Island rank 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147AB0
                Select_islandranking.Items.Item(44) = "Island rank 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147AE0
                Select_islandranking.Items.Item(45) = "Island rank 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147B10
                Select_islandranking.Items.Item(46) = "Island rank 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147B40
                Select_islandranking.Items.Item(47) = "Island rank 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147B70
                Select_islandranking.Items.Item(48) = "Island rank 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147BA0
                Select_islandranking.Items.Item(49) = "Island rank 50 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147BD0
                Select_islandranking.Items.Item(50) = "Island rank 51 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147C00
                Select_islandranking.Items.Item(51) = "Island rank 52 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147C30
                Select_islandranking.Items.Item(52) = "Island rank 53 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147C60
                Select_islandranking.Items.Item(53) = "Island rank 54 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147C90
                Select_islandranking.Items.Item(54) = "Island rank 55 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147CC0
                Select_islandranking.Items.Item(55) = "Island rank 56 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147CF0
                Select_islandranking.Items.Item(56) = "Island rank 57 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147D20
                Select_islandranking.Items.Item(57) = "Island rank 58 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147D50
                Select_islandranking.Items.Item(58) = "Island rank 59 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147D80
                Select_islandranking.Items.Item(59) = "Island rank 60 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147DB0
                Select_islandranking.Items.Item(60) = "Island rank 61 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147DE0
                Select_islandranking.Items.Item(61) = "Island rank 62 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147E10
                Select_islandranking.Items.Item(62) = "Island rank 63 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147E40
                Select_islandranking.Items.Item(63) = "Island rank 64 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147E70
                Select_islandranking.Items.Item(64) = "Island rank 65 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147EA0
                Select_islandranking.Items.Item(65) = "Island rank 66 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147ED0
                Select_islandranking.Items.Item(66) = "Island rank 67 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147F00
                Select_islandranking.Items.Item(67) = "Island rank 68 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147F30
                Select_islandranking.Items.Item(68) = "Island rank 69 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147F60
                Select_islandranking.Items.Item(69) = "Island rank 70 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147F90
                Select_islandranking.Items.Item(70) = "Island rank 71 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147FC0
                Select_islandranking.Items.Item(71) = "Island rank 72 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H147FF0
                Select_islandranking.Items.Item(72) = "Island rank 73 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148020
                Select_islandranking.Items.Item(73) = "Island rank 74 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148050
                Select_islandranking.Items.Item(74) = "Island rank 75 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148080
                Select_islandranking.Items.Item(75) = "Island rank 76 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1480B0
                Select_islandranking.Items.Item(76) = "Island rank 77 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1480E0
                Select_islandranking.Items.Item(77) = "Island rank 78 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148110
                Select_islandranking.Items.Item(78) = "Island rank 79 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148140
                Select_islandranking.Items.Item(79) = "Island rank 80 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148170
                Select_islandranking.Items.Item(80) = "Island rank 81 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1481A0
                Select_islandranking.Items.Item(81) = "Island rank 82 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1481D0
                Select_islandranking.Items.Item(82) = "Island rank 83 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148200
                Select_islandranking.Items.Item(83) = "Island rank 84 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148230
                Select_islandranking.Items.Item(84) = "Island rank 85 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148260
                Select_islandranking.Items.Item(85) = "Island rank 86 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148290
                Select_islandranking.Items.Item(86) = "Island rank 87 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1482C0
                Select_islandranking.Items.Item(87) = "Island rank 88 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1482F0
                Select_islandranking.Items.Item(88) = "Island rank 89 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148320
                Select_islandranking.Items.Item(89) = "Island rank 90 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148350
                Select_islandranking.Items.Item(90) = "Island rank 91 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148380
                Select_islandranking.Items.Item(91) = "Island rank 92 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1483B0
                Select_islandranking.Items.Item(92) = "Island rank 93 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1483E0
                Select_islandranking.Items.Item(93) = "Island rank 94 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148410
                Select_islandranking.Items.Item(94) = "Island rank 95 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148440
                Select_islandranking.Items.Item(95) = "Island rank 96 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148470
                Select_islandranking.Items.Item(96) = "Island rank 97 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1484A0
                Select_islandranking.Items.Item(97) = "Island rank 98 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1484D0
                Select_islandranking.Items.Item(98) = "Island rank 99 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148500
                Select_islandranking.Items.Item(99) = "Island rank 100 : " & Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "KR" Then
                Reader.Position = &H1EB080
                Select_islandranking.Items.Item(0) = "Island rank 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB0B0
                Select_islandranking.Items.Item(1) = "Island rank 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB0E0
                Select_islandranking.Items.Item(2) = "Island rank 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB110
                Select_islandranking.Items.Item(3) = "Island rank 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB140
                Select_islandranking.Items.Item(4) = "Island rank 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB170
                Select_islandranking.Items.Item(5) = "Island rank 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB1A0
                Select_islandranking.Items.Item(6) = "Island rank 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB1D0
                Select_islandranking.Items.Item(7) = "Island rank 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB200
                Select_islandranking.Items.Item(8) = "Island rank 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB230
                Select_islandranking.Items.Item(9) = "Island rank 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB260
                Select_islandranking.Items.Item(10) = "Island rank 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB290
                Select_islandranking.Items.Item(11) = "Island rank 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB2C0
                Select_islandranking.Items.Item(12) = "Island rank 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB2F0
                Select_islandranking.Items.Item(13) = "Island rank 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB320
                Select_islandranking.Items.Item(14) = "Island rank 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB350
                Select_islandranking.Items.Item(15) = "Island rank 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB380
                Select_islandranking.Items.Item(16) = "Island rank 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB3B0
                Select_islandranking.Items.Item(17) = "Island rank 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB3E0
                Select_islandranking.Items.Item(18) = "Island rank 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB410
                Select_islandranking.Items.Item(19) = "Island rank 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB440
                Select_islandranking.Items.Item(20) = "Island rank 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB470
                Select_islandranking.Items.Item(21) = "Island rank 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB4A0
                Select_islandranking.Items.Item(22) = "Island rank 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB4D0
                Select_islandranking.Items.Item(23) = "Island rank 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB500
                Select_islandranking.Items.Item(24) = "Island rank 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB530
                Select_islandranking.Items.Item(25) = "Island rank 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB560
                Select_islandranking.Items.Item(26) = "Island rank 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB590
                Select_islandranking.Items.Item(27) = "Island rank 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB5C0
                Select_islandranking.Items.Item(28) = "Island rank 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB5F0
                Select_islandranking.Items.Item(29) = "Island rank 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB620
                Select_islandranking.Items.Item(30) = "Island rank 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB650
                Select_islandranking.Items.Item(31) = "Island rank 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB680
                Select_islandranking.Items.Item(32) = "Island rank 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB6B0
                Select_islandranking.Items.Item(33) = "Island rank 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB6E0
                Select_islandranking.Items.Item(34) = "Island rank 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB710
                Select_islandranking.Items.Item(35) = "Island rank 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB740
                Select_islandranking.Items.Item(36) = "Island rank 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB770
                Select_islandranking.Items.Item(37) = "Island rank 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB7A0
                Select_islandranking.Items.Item(38) = "Island rank 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB7D0
                Select_islandranking.Items.Item(39) = "Island rank 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB800
                Select_islandranking.Items.Item(40) = "Island rank 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB830
                Select_islandranking.Items.Item(41) = "Island rank 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB860
                Select_islandranking.Items.Item(42) = "Island rank 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB890
                Select_islandranking.Items.Item(43) = "Island rank 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB8C0
                Select_islandranking.Items.Item(44) = "Island rank 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB8F0
                Select_islandranking.Items.Item(45) = "Island rank 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB920
                Select_islandranking.Items.Item(46) = "Island rank 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB950
                Select_islandranking.Items.Item(47) = "Island rank 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB980
                Select_islandranking.Items.Item(48) = "Island rank 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB9B0
                Select_islandranking.Items.Item(49) = "Island rank 50 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EB9E0
                Select_islandranking.Items.Item(50) = "Island rank 51 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBA10
                Select_islandranking.Items.Item(51) = "Island rank 52 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBA40
                Select_islandranking.Items.Item(52) = "Island rank 53 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBA70
                Select_islandranking.Items.Item(53) = "Island rank 54 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBAA0
                Select_islandranking.Items.Item(54) = "Island rank 55 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBAD0
                Select_islandranking.Items.Item(55) = "Island rank 56 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBB00
                Select_islandranking.Items.Item(56) = "Island rank 57 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBB30
                Select_islandranking.Items.Item(57) = "Island rank 58 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBB60
                Select_islandranking.Items.Item(58) = "Island rank 59 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBB90
                Select_islandranking.Items.Item(59) = "Island rank 60 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBBC0
                Select_islandranking.Items.Item(60) = "Island rank 61 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBBF0
                Select_islandranking.Items.Item(61) = "Island rank 62 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBC20
                Select_islandranking.Items.Item(62) = "Island rank 63 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBC50
                Select_islandranking.Items.Item(63) = "Island rank 64 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBC80
                Select_islandranking.Items.Item(64) = "Island rank 65 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBCB0
                Select_islandranking.Items.Item(65) = "Island rank 66 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBCE0
                Select_islandranking.Items.Item(66) = "Island rank 67 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBD10
                Select_islandranking.Items.Item(67) = "Island rank 68 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBD40
                Select_islandranking.Items.Item(68) = "Island rank 69 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBD70
                Select_islandranking.Items.Item(69) = "Island rank 70 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBDA0
                Select_islandranking.Items.Item(70) = "Island rank 71 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBDD0
                Select_islandranking.Items.Item(71) = "Island rank 72 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBE00
                Select_islandranking.Items.Item(72) = "Island rank 73 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBE30
                Select_islandranking.Items.Item(73) = "Island rank 74 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBE60
                Select_islandranking.Items.Item(74) = "Island rank 75 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBE90
                Select_islandranking.Items.Item(75) = "Island rank 76 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBEC0
                Select_islandranking.Items.Item(76) = "Island rank 77 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBEF0
                Select_islandranking.Items.Item(77) = "Island rank 78 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBF20
                Select_islandranking.Items.Item(78) = "Island rank 79 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBF50
                Select_islandranking.Items.Item(79) = "Island rank 80 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBF80
                Select_islandranking.Items.Item(80) = "Island rank 81 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBFB0
                Select_islandranking.Items.Item(81) = "Island rank 82 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EBFE0
                Select_islandranking.Items.Item(82) = "Island rank 83 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC010
                Select_islandranking.Items.Item(83) = "Island rank 84 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC040
                Select_islandranking.Items.Item(84) = "Island rank 85 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC070
                Select_islandranking.Items.Item(85) = "Island rank 86 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC0A0
                Select_islandranking.Items.Item(86) = "Island rank 87 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC0D0
                Select_islandranking.Items.Item(87) = "Island rank 88 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC100
                Select_islandranking.Items.Item(88) = "Island rank 89 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC130
                Select_islandranking.Items.Item(89) = "Island rank 90 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC160
                Select_islandranking.Items.Item(90) = "Island rank 91 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC190
                Select_islandranking.Items.Item(91) = "Island rank 92 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC1C0
                Select_islandranking.Items.Item(92) = "Island rank 93 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC1F0
                Select_islandranking.Items.Item(93) = "Island rank 94 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC220
                Select_islandranking.Items.Item(94) = "Island rank 95 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC250
                Select_islandranking.Items.Item(95) = "Island rank 96 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC280
                Select_islandranking.Items.Item(96) = "Island rank 97 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC2B0
                Select_islandranking.Items.Item(97) = "Island rank 98 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC2E0
                Select_islandranking.Items.Item(98) = "Island rank 99 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EC310
                Select_islandranking.Items.Item(99) = "Island rank 100 : " & Reader.ReadUnicodeString(10)
            Else
                Reader.Position = &H1DFCD0
                Select_islandranking.Items.Item(0) = "Island rank 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFD00
                Select_islandranking.Items.Item(1) = "Island rank 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFD30
                Select_islandranking.Items.Item(2) = "Island rank 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFD60
                Select_islandranking.Items.Item(3) = "Island rank 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFD90
                Select_islandranking.Items.Item(4) = "Island rank 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFDC0
                Select_islandranking.Items.Item(5) = "Island rank 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFDF0
                Select_islandranking.Items.Item(6) = "Island rank 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFE20
                Select_islandranking.Items.Item(7) = "Island rank 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFE50
                Select_islandranking.Items.Item(8) = "Island rank 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFE80
                Select_islandranking.Items.Item(9) = "Island rank 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFEB0
                Select_islandranking.Items.Item(10) = "Island rank 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFEE0
                Select_islandranking.Items.Item(11) = "Island rank 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFF10
                Select_islandranking.Items.Item(12) = "Island rank 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFF40
                Select_islandranking.Items.Item(13) = "Island rank 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFF70
                Select_islandranking.Items.Item(14) = "Island rank 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFFA0
                Select_islandranking.Items.Item(15) = "Island rank 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DFFD0
                Select_islandranking.Items.Item(16) = "Island rank 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0000
                Select_islandranking.Items.Item(17) = "Island rank 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0030
                Select_islandranking.Items.Item(18) = "Island rank 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0060
                Select_islandranking.Items.Item(19) = "Island rank 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0090
                Select_islandranking.Items.Item(20) = "Island rank 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E00C0
                Select_islandranking.Items.Item(21) = "Island rank 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E00F0
                Select_islandranking.Items.Item(22) = "Island rank 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0120
                Select_islandranking.Items.Item(23) = "Island rank 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0150
                Select_islandranking.Items.Item(24) = "Island rank 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0180
                Select_islandranking.Items.Item(25) = "Island rank 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E01B0
                Select_islandranking.Items.Item(26) = "Island rank 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E01E0
                Select_islandranking.Items.Item(27) = "Island rank 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0210
                Select_islandranking.Items.Item(28) = "Island rank 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0240
                Select_islandranking.Items.Item(29) = "Island rank 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0270
                Select_islandranking.Items.Item(30) = "Island rank 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E02A0
                Select_islandranking.Items.Item(31) = "Island rank 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E02D0
                Select_islandranking.Items.Item(32) = "Island rank 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0300
                Select_islandranking.Items.Item(33) = "Island rank 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0330
                Select_islandranking.Items.Item(34) = "Island rank 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0360
                Select_islandranking.Items.Item(35) = "Island rank 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0390
                Select_islandranking.Items.Item(36) = "Island rank 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E03C0
                Select_islandranking.Items.Item(37) = "Island rank 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E03F0
                Select_islandranking.Items.Item(38) = "Island rank 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0420
                Select_islandranking.Items.Item(39) = "Island rank 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0450
                Select_islandranking.Items.Item(40) = "Island rank 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0480
                Select_islandranking.Items.Item(41) = "Island rank 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E04B0
                Select_islandranking.Items.Item(42) = "Island rank 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E04E0
                Select_islandranking.Items.Item(43) = "Island rank 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0510
                Select_islandranking.Items.Item(44) = "Island rank 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0540
                Select_islandranking.Items.Item(45) = "Island rank 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0570
                Select_islandranking.Items.Item(46) = "Island rank 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E05A0
                Select_islandranking.Items.Item(47) = "Island rank 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E05D0
                Select_islandranking.Items.Item(48) = "Island rank 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0600
                Select_islandranking.Items.Item(49) = "Island rank 50 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0630
                Select_islandranking.Items.Item(50) = "Island rank 51 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0660
                Select_islandranking.Items.Item(51) = "Island rank 52 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0690
                Select_islandranking.Items.Item(52) = "Island rank 53 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E06C0
                Select_islandranking.Items.Item(53) = "Island rank 54 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E06F0
                Select_islandranking.Items.Item(54) = "Island rank 55 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0720
                Select_islandranking.Items.Item(55) = "Island rank 56 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0750
                Select_islandranking.Items.Item(56) = "Island rank 57 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0780
                Select_islandranking.Items.Item(57) = "Island rank 58 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E07B0
                Select_islandranking.Items.Item(58) = "Island rank 59 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E07E0
                Select_islandranking.Items.Item(59) = "Island rank 60 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0810
                Select_islandranking.Items.Item(60) = "Island rank 61 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0840
                Select_islandranking.Items.Item(61) = "Island rank 62 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0870
                Select_islandranking.Items.Item(62) = "Island rank 63 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E08A0
                Select_islandranking.Items.Item(63) = "Island rank 64 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E08D0
                Select_islandranking.Items.Item(64) = "Island rank 65 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0900
                Select_islandranking.Items.Item(65) = "Island rank 66 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0930
                Select_islandranking.Items.Item(66) = "Island rank 67 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0960
                Select_islandranking.Items.Item(67) = "Island rank 68 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0990
                Select_islandranking.Items.Item(68) = "Island rank 69 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E09C0
                Select_islandranking.Items.Item(69) = "Island rank 70 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E09F0
                Select_islandranking.Items.Item(70) = "Island rank 71 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0A20
                Select_islandranking.Items.Item(71) = "Island rank 72 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0A50
                Select_islandranking.Items.Item(72) = "Island rank 73 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0A80
                Select_islandranking.Items.Item(73) = "Island rank 74 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0AB0
                Select_islandranking.Items.Item(74) = "Island rank 75 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0AE0
                Select_islandranking.Items.Item(75) = "Island rank 76 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0B10
                Select_islandranking.Items.Item(76) = "Island rank 77 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0B40
                Select_islandranking.Items.Item(77) = "Island rank 78 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0B70
                Select_islandranking.Items.Item(78) = "Island rank 79 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0BA0
                Select_islandranking.Items.Item(79) = "Island rank 80 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0BD0
                Select_islandranking.Items.Item(80) = "Island rank 81 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0C00
                Select_islandranking.Items.Item(81) = "Island rank 82 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0C30
                Select_islandranking.Items.Item(82) = "Island rank 83 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0C60
                Select_islandranking.Items.Item(83) = "Island rank 84 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0C90
                Select_islandranking.Items.Item(84) = "Island rank 85 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0CC0
                Select_islandranking.Items.Item(85) = "Island rank 86 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0CF0
                Select_islandranking.Items.Item(86) = "Island rank 87 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0D20
                Select_islandranking.Items.Item(87) = "Island rank 88 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0D50
                Select_islandranking.Items.Item(88) = "Island rank 89 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0D80
                Select_islandranking.Items.Item(89) = "Island rank 90 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0DB0
                Select_islandranking.Items.Item(90) = "Island rank 91 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0DE0
                Select_islandranking.Items.Item(91) = "Island rank 92 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0E10
                Select_islandranking.Items.Item(92) = "Island rank 93 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0E40
                Select_islandranking.Items.Item(93) = "Island rank 94 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0E70
                Select_islandranking.Items.Item(94) = "Island rank 95 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0EA0
                Select_islandranking.Items.Item(95) = "Island rank 96 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0ED0
                Select_islandranking.Items.Item(96) = "Island rank 97 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0F00
                Select_islandranking.Items.Item(97) = "Island rank 98 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0F30
                Select_islandranking.Items.Item(98) = "Island rank 99 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E0F60
                Select_islandranking.Items.Item(99) = "Island rank 100 : " & Reader.ReadUnicodeString(10)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read island ranking names"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture des noms des îles a échoué"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub Islandrankdetected()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H147288
                Islandrankingdetected = Reader.ReadByte
                Reader.Position = &H1472B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1472E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147318
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147348
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147378
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1473A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1473D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147408
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147438
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147468
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147498
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1474C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1474F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147528
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147558
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147588
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1475B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1475E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147618
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147648
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147678
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1476A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1476D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147708
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147738
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147768
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147798
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1477C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1477F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147828
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147858
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147888
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1478B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1478E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147918
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147948
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147978
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1479A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1479D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147A08
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147A38
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147A68
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147A98
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147AC8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147AF8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147B28
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147B58
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147B88
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147BB8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147BE8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147C18
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147C48
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147C78
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147CA8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147CD8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147D08
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147D38
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147D68
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147D98
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147DC8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147DF8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147E28
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147E58
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147E88
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147EB8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147EE8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147F18
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147F48
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147F78
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147FA8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H147FD8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148008
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148038
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148068
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148098
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1480C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1480F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148128
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148158
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148188
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1481B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1481E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148218
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148248
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148278
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1482A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1482D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148308
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148338
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148368
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148398
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1483C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1483F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148428
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148458
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148488
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1484B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1484E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H148518
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
            ElseIf Filever_text.Text = "KR" Then
                Reader.Position = &H1EB098
                Islandrankingdetected = Reader.ReadByte
                Reader.Position = &H1EB0C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB0F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB128
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB158
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB188
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB1B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB1E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB218
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB248
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB278
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB2A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB2D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB308
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB338
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB368
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB398
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB3C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB3F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB428
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB458
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB488
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB4B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB4E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB518
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB548
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB578
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB5A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB5D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB608
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB638
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB668
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB698
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB6C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB6F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB728
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB758
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB788
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB7B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB7E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB818
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB848
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB878
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB8A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB8D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB908
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB938
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB968
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB998
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB9C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EB9F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBA28
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBA58
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBA88
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBAB8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBAE8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBB18
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBB48
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBB78
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBBA8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBBD8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBC08
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBC38
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBC68
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBC98
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBCC8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBCF8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBD28
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBD58
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBD88
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBDB8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBDE8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBE18
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBE48
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBE78
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBEA8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBED8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBF08
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBF38
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBF68
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBF98
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBFC8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EBFF8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC028
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC058
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC088
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC0B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC0E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC118
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC148
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC178
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC1A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC1D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC208
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC238
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC268
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC298
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC2C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC2F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1EC328
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
            Else
                Reader.Position = &H1DFCE8
                Islandrankingdetected = Reader.ReadByte
                Reader.Position = &H1DFD18
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFD48
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFD78
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFDA8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFDD8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFE08
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFE38
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFE68
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFE98
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFEC8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFEF8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFF28
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFF58
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFF88
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFFB8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1DFFE8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0018
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0048
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0078
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E00A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E00D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0108
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0138
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0168
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0198
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E01C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E01F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0228
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0258
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0288
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E02B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E02E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0318
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0348
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0378
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E03A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E03D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0408
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0438
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0468
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0498
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E04C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E04F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0528
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0558
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0588
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E05B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E05E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0618
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0648
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0678
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E06A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E06D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0708
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0738
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0768
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0798
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E07C8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E07F8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0828
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0858
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0888
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E08B8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E08E8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0918
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0948
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0978
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E09A8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E09D8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0A08
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0A38
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0A68
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0A98
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0AC8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0AF8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0B28
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0B58
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0B88
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0BB8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0BE8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0C18
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0C48
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0C78
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0CA8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0CD8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0D08
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0D38
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0D68
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0D98
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0DC8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0DF8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0E28
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0E58
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0E88
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0EB8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0EE8
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0F18
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0F48
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
                Reader.Position = &H1E0F78
                Islandrankingdetected = Islandrankingdetected + Reader.ReadByte
            End If
            Text_miidetected.Text = "X " + Islandrankingdetected
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to detect island ranking in this save file"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Échec de la détection des îles dans ce fichier de sauvegarde"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub Setislandranking()
        Try
            If Filever_text.Text = "JP" Then
                Islandranking_1 = &H147260
                Islandranking_2 = &H147290
                Islandranking_3 = &H1472C0
                Islandranking_4 = &H1472F0
                Islandranking_5 = &H147320
                Islandranking_6 = &H147350
                Islandranking_7 = &H147380
                Islandranking_8 = &H1473B0
                Islandranking_9 = &H1473E0
                Islandranking_10 = &H147410
                Islandranking_11 = &H147440
                Islandranking_12 = &H147470
                Islandranking_13 = &H1474A0
                Islandranking_14 = &H1474D0
                Islandranking_15 = &H147500
                Islandranking_16 = &H147530
                Islandranking_17 = &H147560
                Islandranking_18 = &H147590
                Islandranking_19 = &H1475C0
                Islandranking_20 = &H1475F0
                Islandranking_21 = &H147620
                Islandranking_22 = &H147650
                Islandranking_23 = &H147680
                Islandranking_24 = &H1476B0
                Islandranking_25 = &H1476E0
                Islandranking_26 = &H147710
                Islandranking_27 = &H147740
                Islandranking_28 = &H147770
                Islandranking_29 = &H1477A0
                Islandranking_30 = &H1477D0
                Islandranking_31 = &H147800
                Islandranking_32 = &H147830
                Islandranking_33 = &H147860
                Islandranking_34 = &H147890
                Islandranking_35 = &H1478C0
                Islandranking_36 = &H1478F0
                Islandranking_37 = &H147920
                Islandranking_38 = &H147950
                Islandranking_39 = &H147980
                Islandranking_40 = &H1479B0
                Islandranking_41 = &H1479E0
                Islandranking_42 = &H147A10
                Islandranking_43 = &H147A40
                Islandranking_44 = &H147A70
                Islandranking_45 = &H147AA0
                Islandranking_46 = &H147AD0
                Islandranking_47 = &H147B00
                Islandranking_48 = &H147B30
                Islandranking_49 = &H147B60
                Islandranking_50 = &H147B90
                Islandranking_51 = &H147BC0
                Islandranking_52 = &H147BF0
                Islandranking_53 = &H147C20
                Islandranking_54 = &H147C50
                Islandranking_55 = &H147C80
                Islandranking_56 = &H147CB0
                Islandranking_57 = &H147CE0
                Islandranking_58 = &H147D10
                Islandranking_59 = &H147D40
                Islandranking_60 = &H147D70
                Islandranking_61 = &H147DA0
                Islandranking_62 = &H147DD0
                Islandranking_63 = &H147E00
                Islandranking_64 = &H147E30
                Islandranking_65 = &H147E60
                Islandranking_66 = &H147E90
                Islandranking_67 = &H147EC0
                Islandranking_68 = &H147EF0
                Islandranking_69 = &H147F20
                Islandranking_70 = &H147F50
                Islandranking_71 = &H147F80
                Islandranking_72 = &H147FB0
                Islandranking_73 = &H147FE0
                Islandranking_74 = &H148010
                Islandranking_75 = &H148040
                Islandranking_76 = &H148070
                Islandranking_77 = &H1480A0
                Islandranking_78 = &H1480D0
                Islandranking_79 = &H148100
                Islandranking_80 = &H148130
                Islandranking_81 = &H148160
                Islandranking_82 = &H148190
                Islandranking_83 = &H1481C0
                Islandranking_84 = &H1481F0
                Islandranking_85 = &H148220
                Islandranking_86 = &H148250
                Islandranking_87 = &H148280
                Islandranking_88 = &H1482B0
                Islandranking_89 = &H1482E0
                Islandranking_90 = &H148310
                Islandranking_91 = &H148340
                Islandranking_92 = &H148370
                Islandranking_93 = &H1483A0
                Islandranking_94 = &H1483D0
                Islandranking_95 = &H148400
                Islandranking_96 = &H148430
                Islandranking_97 = &H148460
                Islandranking_98 = &H148490
                Islandranking_99 = &H1484C0
                Islandranking_100 = &H1484F0
            ElseIf Filever_text.Text = "KR" Then
                Islandranking_1 = &H1EB070
                Islandranking_2 = &H1EB0A0
                Islandranking_3 = &H1EB0D0
                Islandranking_4 = &H1EB100
                Islandranking_5 = &H1EB130
                Islandranking_6 = &H1EB160
                Islandranking_7 = &H1EB190
                Islandranking_8 = &H1EB1C0
                Islandranking_9 = &H1EB1F0
                Islandranking_10 = &H1EB220
                Islandranking_11 = &H1EB250
                Islandranking_12 = &H1EB280
                Islandranking_13 = &H1EB2B0
                Islandranking_14 = &H1EB2E0
                Islandranking_15 = &H1EB310
                Islandranking_16 = &H1EB340
                Islandranking_17 = &H1EB370
                Islandranking_18 = &H1EB3A0
                Islandranking_19 = &H1EB3D0
                Islandranking_20 = &H1EB400
                Islandranking_21 = &H1EB430
                Islandranking_22 = &H1EB460
                Islandranking_23 = &H1EB490
                Islandranking_24 = &H1EB4C0
                Islandranking_25 = &H1EB4F0
                Islandranking_26 = &H1EB520
                Islandranking_27 = &H1EB550
                Islandranking_28 = &H1EB580
                Islandranking_29 = &H1EB5B0
                Islandranking_30 = &H1EB5E0
                Islandranking_31 = &H1EB610
                Islandranking_32 = &H1EB640
                Islandranking_33 = &H1EB670
                Islandranking_34 = &H1EB6A0
                Islandranking_35 = &H1EB6D0
                Islandranking_36 = &H1EB700
                Islandranking_37 = &H1EB730
                Islandranking_38 = &H1EB760
                Islandranking_39 = &H1EB790
                Islandranking_40 = &H1EB7C0
                Islandranking_41 = &H1EB7F0
                Islandranking_42 = &H1EB820
                Islandranking_43 = &H1EB850
                Islandranking_44 = &H1EB880
                Islandranking_45 = &H1EB8B0
                Islandranking_46 = &H1EB8E0
                Islandranking_47 = &H1EB910
                Islandranking_48 = &H1EB940
                Islandranking_49 = &H1EB970
                Islandranking_50 = &H1EB9A0
                Islandranking_51 = &H1EB9D0
                Islandranking_52 = &H1EBA00
                Islandranking_53 = &H1EBA30
                Islandranking_54 = &H1EBA60
                Islandranking_55 = &H1EBA90
                Islandranking_56 = &H1EBAC0
                Islandranking_57 = &H1EBAF0
                Islandranking_58 = &H1EBB20
                Islandranking_59 = &H1EBB50
                Islandranking_60 = &H1EBB80
                Islandranking_61 = &H1EBBB0
                Islandranking_62 = &H1EBBE0
                Islandranking_63 = &H1EBC10
                Islandranking_64 = &H1EBC40
                Islandranking_65 = &H1EBC70
                Islandranking_66 = &H1EBCA0
                Islandranking_67 = &H1EBCD0
                Islandranking_68 = &H1EBD00
                Islandranking_69 = &H1EBD30
                Islandranking_70 = &H1EBD60
                Islandranking_71 = &H1EBD90
                Islandranking_72 = &H1EBDC0
                Islandranking_73 = &H1EBDF0
                Islandranking_74 = &H1EBE20
                Islandranking_75 = &H1EBE50
                Islandranking_76 = &H1EBE80
                Islandranking_77 = &H1EBEB0
                Islandranking_78 = &H1EBEE0
                Islandranking_79 = &H1EBF10
                Islandranking_80 = &H1EBF40
                Islandranking_81 = &H1EBF70
                Islandranking_82 = &H1EBFA0
                Islandranking_83 = &H1EBFD0
                Islandranking_84 = &H1EC000
                Islandranking_85 = &H1EC030
                Islandranking_86 = &H1EC060
                Islandranking_87 = &H1EC090
                Islandranking_88 = &H1EC0C0
                Islandranking_89 = &H1EC0F0
                Islandranking_90 = &H1EC120
                Islandranking_91 = &H1EC150
                Islandranking_92 = &H1EC180
                Islandranking_93 = &H1EC1B0
                Islandranking_94 = &H1EC1E0
                Islandranking_95 = &H1EC210
                Islandranking_96 = &H1EC240
                Islandranking_97 = &H1EC270
                Islandranking_98 = &H1EC2A0
                Islandranking_99 = &H1EC2D0
                Islandranking_100 = &H1EC300
            Else
                Islandranking_1 = &H1DFCC0
                Islandranking_2 = &H1DFCF0
                Islandranking_3 = &H1DFD20
                Islandranking_4 = &H1DFD50
                Islandranking_5 = &H1DFD80
                Islandranking_6 = &H1DFDB0
                Islandranking_7 = &H1DFDE0
                Islandranking_8 = &H1DFE10
                Islandranking_9 = &H1DFE40
                Islandranking_10 = &H1DFE70
                Islandranking_11 = &H1DFEA0
                Islandranking_12 = &H1DFED0
                Islandranking_13 = &H1DFF00
                Islandranking_14 = &H1DFF30
                Islandranking_15 = &H1DFF60
                Islandranking_16 = &H1DFF90
                Islandranking_17 = &H1DFFC0
                Islandranking_18 = &H1DFFF0
                Islandranking_19 = &H1E0020
                Islandranking_20 = &H1E0050
                Islandranking_21 = &H1E0080
                Islandranking_22 = &H1E00B0
                Islandranking_23 = &H1E00E0
                Islandranking_24 = &H1E0110
                Islandranking_25 = &H1E0140
                Islandranking_26 = &H1E0170
                Islandranking_27 = &H1E01A0
                Islandranking_28 = &H1E01D0
                Islandranking_29 = &H1E0200
                Islandranking_30 = &H1E0230
                Islandranking_31 = &H1E0260
                Islandranking_32 = &H1E0290
                Islandranking_33 = &H1E02C0
                Islandranking_34 = &H1E02F0
                Islandranking_35 = &H1E0320
                Islandranking_36 = &H1E0350
                Islandranking_37 = &H1E0380
                Islandranking_38 = &H1E03B0
                Islandranking_39 = &H1E03E0
                Islandranking_40 = &H1E0410
                Islandranking_41 = &H1E0440
                Islandranking_42 = &H1E0470
                Islandranking_43 = &H1E04A0
                Islandranking_44 = &H1E04D0
                Islandranking_45 = &H1E0500
                Islandranking_46 = &H1E0530
                Islandranking_47 = &H1E0560
                Islandranking_48 = &H1E0590
                Islandranking_49 = &H1E05C0
                Islandranking_50 = &H1E05F0
                Islandranking_51 = &H1E0620
                Islandranking_52 = &H1E0650
                Islandranking_53 = &H1E0680
                Islandranking_54 = &H1E06B0
                Islandranking_55 = &H1E06E0
                Islandranking_56 = &H1E0710
                Islandranking_57 = &H1E0740
                Islandranking_58 = &H1E0770
                Islandranking_59 = &H1E07A0
                Islandranking_60 = &H1E07D0
                Islandranking_61 = &H1E0800
                Islandranking_62 = &H1E0830
                Islandranking_63 = &H1E0860
                Islandranking_64 = &H1E0890
                Islandranking_65 = &H1E08C0
                Islandranking_66 = &H1E08F0
                Islandranking_67 = &H1E0920
                Islandranking_68 = &H1E0950
                Islandranking_69 = &H1E0980
                Islandranking_70 = &H1E09B0
                Islandranking_71 = &H1E09E0
                Islandranking_72 = &H1E0A10
                Islandranking_73 = &H1E0A40
                Islandranking_74 = &H1E0A70
                Islandranking_75 = &H1E0AA0
                Islandranking_76 = &H1E0AD0
                Islandranking_77 = &H1E0B00
                Islandranking_78 = &H1E0B30
                Islandranking_79 = &H1E0B60
                Islandranking_80 = &H1E0B90
                Islandranking_81 = &H1E0BC0
                Islandranking_82 = &H1E0BF0
                Islandranking_83 = &H1E0C20
                Islandranking_84 = &H1E0C50
                Islandranking_85 = &H1E0C80
                Islandranking_86 = &H1E0CB0
                Islandranking_87 = &H1E0CE0
                Islandranking_88 = &H1E0D10
                Islandranking_89 = &H1E0D40
                Islandranking_90 = &H1E0D70
                Islandranking_91 = &H1E0DA0
                Islandranking_92 = &H1E0DD0
                Islandranking_93 = &H1E0E00
                Islandranking_94 = &H1E0E30
                Islandranking_95 = &H1E0E60
                Islandranking_96 = &H1E0E90
                Islandranking_97 = &H1E0EC0
                Islandranking_98 = &H1E0EF0
                Islandranking_99 = &H1E0F20
                Islandranking_100 = &H1E0F50
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Readislandranking()
        Setislandranking()
        Try
            Dim ReadIslandrankingData As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(0) Then
                ReadIslandrankingData.Position = Islandranking_1
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(1) Then
                ReadIslandrankingData.Position = Islandranking_2
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(2) Then
                ReadIslandrankingData.Position = Islandranking_3
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(3) Then
                ReadIslandrankingData.Position = Islandranking_4
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(4) Then
                ReadIslandrankingData.Position = Islandranking_5
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(5) Then
                ReadIslandrankingData.Position = Islandranking_6
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(6) Then
                ReadIslandrankingData.Position = Islandranking_7
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(7) Then
                ReadIslandrankingData.Position = Islandranking_8
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(8) Then
                ReadIslandrankingData.Position = Islandranking_9
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(9) Then
                ReadIslandrankingData.Position = Islandranking_10
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(10) Then
                ReadIslandrankingData.Position = Islandranking_11
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(11) Then
                ReadIslandrankingData.Position = Islandranking_12
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(12) Then
                ReadIslandrankingData.Position = Islandranking_13
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(13) Then
                ReadIslandrankingData.Position = Islandranking_14
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(14) Then
                ReadIslandrankingData.Position = Islandranking_15
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(15) Then
                ReadIslandrankingData.Position = Islandranking_16
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(16) Then
                ReadIslandrankingData.Position = Islandranking_17
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(17) Then
                ReadIslandrankingData.Position = Islandranking_18
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(18) Then
                ReadIslandrankingData.Position = Islandranking_19
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(19) Then
                ReadIslandrankingData.Position = Islandranking_20
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(20) Then
                ReadIslandrankingData.Position = Islandranking_21
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(21) Then
                ReadIslandrankingData.Position = Islandranking_22
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(22) Then
                ReadIslandrankingData.Position = Islandranking_23
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(23) Then
                ReadIslandrankingData.Position = Islandranking_24
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(24) Then
                ReadIslandrankingData.Position = Islandranking_25
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(25) Then
                ReadIslandrankingData.Position = Islandranking_26
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(26) Then
                ReadIslandrankingData.Position = Islandranking_27
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(27) Then
                ReadIslandrankingData.Position = Islandranking_28
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(28) Then
                ReadIslandrankingData.Position = Islandranking_29
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(29) Then
                ReadIslandrankingData.Position = Islandranking_30
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(30) Then
                ReadIslandrankingData.Position = Islandranking_31
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(31) Then
                ReadIslandrankingData.Position = Islandranking_32
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(32) Then
                ReadIslandrankingData.Position = Islandranking_33
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(33) Then
                ReadIslandrankingData.Position = Islandranking_34
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(34) Then
                ReadIslandrankingData.Position = Islandranking_35
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(35) Then
                ReadIslandrankingData.Position = Islandranking_36
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(36) Then
                ReadIslandrankingData.Position = Islandranking_37
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(37) Then
                ReadIslandrankingData.Position = Islandranking_38
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(38) Then
                ReadIslandrankingData.Position = Islandranking_39
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(39) Then
                ReadIslandrankingData.Position = Islandranking_40
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(40) Then
                ReadIslandrankingData.Position = Islandranking_41
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(41) Then
                ReadIslandrankingData.Position = Islandranking_42
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(42) Then
                ReadIslandrankingData.Position = Islandranking_43
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(43) Then
                ReadIslandrankingData.Position = Islandranking_44
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(44) Then
                ReadIslandrankingData.Position = Islandranking_45
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(45) Then
                ReadIslandrankingData.Position = Islandranking_46
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(46) Then
                ReadIslandrankingData.Position = Islandranking_47
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(47) Then
                ReadIslandrankingData.Position = Islandranking_48
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(48) Then
                ReadIslandrankingData.Position = Islandranking_49
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(49) Then
                ReadIslandrankingData.Position = Islandranking_50
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(50) Then
                ReadIslandrankingData.Position = Islandranking_51
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(51) Then
                ReadIslandrankingData.Position = Islandranking_52
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(52) Then
                ReadIslandrankingData.Position = Islandranking_53
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(53) Then
                ReadIslandrankingData.Position = Islandranking_54
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(54) Then
                ReadIslandrankingData.Position = Islandranking_55
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(55) Then
                ReadIslandrankingData.Position = Islandranking_56
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(56) Then
                ReadIslandrankingData.Position = Islandranking_57
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(57) Then
                ReadIslandrankingData.Position = Islandranking_58
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(58) Then
                ReadIslandrankingData.Position = Islandranking_59
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(59) Then
                ReadIslandrankingData.Position = Islandranking_60
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(60) Then
                ReadIslandrankingData.Position = Islandranking_61
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(61) Then
                ReadIslandrankingData.Position = Islandranking_62
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(62) Then
                ReadIslandrankingData.Position = Islandranking_63
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(63) Then
                ReadIslandrankingData.Position = Islandranking_64
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(64) Then
                ReadIslandrankingData.Position = Islandranking_65
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(65) Then
                ReadIslandrankingData.Position = Islandranking_66
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(66) Then
                ReadIslandrankingData.Position = Islandranking_67
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(67) Then
                ReadIslandrankingData.Position = Islandranking_68
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(68) Then
                ReadIslandrankingData.Position = Islandranking_69
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(69) Then
                ReadIslandrankingData.Position = Islandranking_70
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(70) Then
                ReadIslandrankingData.Position = Islandranking_71
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(71) Then
                ReadIslandrankingData.Position = Islandranking_72
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(72) Then
                ReadIslandrankingData.Position = Islandranking_73
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(73) Then
                ReadIslandrankingData.Position = Islandranking_74
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(74) Then
                ReadIslandrankingData.Position = Islandranking_75
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(75) Then
                ReadIslandrankingData.Position = Islandranking_76
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(76) Then
                ReadIslandrankingData.Position = Islandranking_77
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(77) Then
                ReadIslandrankingData.Position = Islandranking_78
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(78) Then
                ReadIslandrankingData.Position = Islandranking_79
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(79) Then
                ReadIslandrankingData.Position = Islandranking_80
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(80) Then
                ReadIslandrankingData.Position = Islandranking_81
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(81) Then
                ReadIslandrankingData.Position = Islandranking_82
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(82) Then
                ReadIslandrankingData.Position = Islandranking_83
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(83) Then
                ReadIslandrankingData.Position = Islandranking_84
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(84) Then
                ReadIslandrankingData.Position = Islandranking_85
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(85) Then
                ReadIslandrankingData.Position = Islandranking_86
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(86) Then
                ReadIslandrankingData.Position = Islandranking_87
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(87) Then
                ReadIslandrankingData.Position = Islandranking_88
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(88) Then
                ReadIslandrankingData.Position = Islandranking_89
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(89) Then
                ReadIslandrankingData.Position = Islandranking_90
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(90) Then
                ReadIslandrankingData.Position = Islandranking_91
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(91) Then
                ReadIslandrankingData.Position = Islandranking_92
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(92) Then
                ReadIslandrankingData.Position = Islandranking_93
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(93) Then
                ReadIslandrankingData.Position = Islandranking_94
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(94) Then
                ReadIslandrankingData.Position = Islandranking_95
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(95) Then
                ReadIslandrankingData.Position = Islandranking_96
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(96) Then
                ReadIslandrankingData.Position = Islandranking_97
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(97) Then
                ReadIslandrankingData.Position = Islandranking_98
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(98) Then
                ReadIslandrankingData.Position = Islandranking_99
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(99) Then
                ReadIslandrankingData.Position = Islandranking_100
                Text_extract_islandranking.Text = ReadIslandrankingData.ReadHexString(&H30)
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this Islandranking, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Select_islandranking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_islandranking.SelectedIndexChanged
        Readislandranking()
    End Sub

    Private Sub Text_extractmii_Click(sender As Object, e As EventArgs) Handles Text_extractmii.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Tomodachi Life Island Ranking|*.tlislandranking"
            SaveFileDialog1.FileName = Select_islandranking.Text.Replace(":", "") & "_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_extract_islandranking.Text)
                TLSE_dialog.Text_TLSE_dialog.Text = "This island has been successfully extracted"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Extraction of this island has failed, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Text_restoremii_Click(sender As Object, e As EventArgs) Handles Text_restoremii.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "This island rank will be replace" & vbNewLine & "Do you want continue ?"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Cette île va être remplacé" & vbNewLine & "Voulez vous continuer ?"
        End If
        TLSE_dialog.Panel_Cancel.Visible = True
        TLSE_dialog.Panel_OK.Visible = True
        TLSE_dialog.ShowDialog()
        If TLSE_dialog.DialogResult = DialogResult.OK Then
            Dim open As New OpenFileDialog
            open.Filter = "Tomodachi Life Island Ranking|*.tlislandranking"
            open.Title = "Open Tomodachi Life Island Ranking files"
            open.ShowDialog()
            TLMII = open.FileName
            ReadTLIslandranking()
            RestoreIslandranking()
        End If
    End Sub

    Public Sub ReadTLIslandranking()
        Try
            Dim ReadTLIslandranking As New PackageIO.Reader(TLMII, PackageIO.Endian.Little)
            ReadTLIslandranking.Position = &H0
            Text_restore_islandranking.Text = ReadTLIslandranking.ReadHexString(&H30)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read a Islandranking in this file"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub
    Public Sub RestoreIslandranking()
        Try
            Dim WriteIslandranking As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(0) Then
                WriteIslandranking.Position = Islandranking_1
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(1) Then
                WriteIslandranking.Position = Islandranking_2
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(2) Then
                WriteIslandranking.Position = Islandranking_3
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(3) Then
                WriteIslandranking.Position = Islandranking_4
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(4) Then
                WriteIslandranking.Position = Islandranking_5
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(5) Then
                WriteIslandranking.Position = Islandranking_6
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(6) Then
                WriteIslandranking.Position = Islandranking_7
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(7) Then
                WriteIslandranking.Position = Islandranking_8
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(8) Then
                WriteIslandranking.Position = Islandranking_9
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(9) Then
                WriteIslandranking.Position = Islandranking_10
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(10) Then
                WriteIslandranking.Position = Islandranking_11
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(11) Then
                WriteIslandranking.Position = Islandranking_12
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(12) Then
                WriteIslandranking.Position = Islandranking_13
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(13) Then
                WriteIslandranking.Position = Islandranking_14
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(14) Then
                WriteIslandranking.Position = Islandranking_15
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(15) Then
                WriteIslandranking.Position = Islandranking_16
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(16) Then
                WriteIslandranking.Position = Islandranking_17
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(17) Then
                WriteIslandranking.Position = Islandranking_18
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(18) Then
                WriteIslandranking.Position = Islandranking_19
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(19) Then
                WriteIslandranking.Position = Islandranking_20
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(20) Then
                WriteIslandranking.Position = Islandranking_21
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(21) Then
                WriteIslandranking.Position = Islandranking_22
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(22) Then
                WriteIslandranking.Position = Islandranking_23
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(23) Then
                WriteIslandranking.Position = Islandranking_24
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(24) Then
                WriteIslandranking.Position = Islandranking_25
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(25) Then
                WriteIslandranking.Position = Islandranking_26
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(26) Then
                WriteIslandranking.Position = Islandranking_27
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(27) Then
                WriteIslandranking.Position = Islandranking_28
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(28) Then
                WriteIslandranking.Position = Islandranking_29
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(29) Then
                WriteIslandranking.Position = Islandranking_30
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(30) Then
                WriteIslandranking.Position = Islandranking_31
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(31) Then
                WriteIslandranking.Position = Islandranking_32
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(32) Then
                WriteIslandranking.Position = Islandranking_33
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(33) Then
                WriteIslandranking.Position = Islandranking_34
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(34) Then
                WriteIslandranking.Position = Islandranking_35
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(35) Then
                WriteIslandranking.Position = Islandranking_36
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(36) Then
                WriteIslandranking.Position = Islandranking_37
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(37) Then
                WriteIslandranking.Position = Islandranking_38
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(38) Then
                WriteIslandranking.Position = Islandranking_39
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(39) Then
                WriteIslandranking.Position = Islandranking_40
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(40) Then
                WriteIslandranking.Position = Islandranking_41
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(41) Then
                WriteIslandranking.Position = Islandranking_42
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(42) Then
                WriteIslandranking.Position = Islandranking_43
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(43) Then
                WriteIslandranking.Position = Islandranking_44
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(44) Then
                WriteIslandranking.Position = Islandranking_45
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(45) Then
                WriteIslandranking.Position = Islandranking_46
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(46) Then
                WriteIslandranking.Position = Islandranking_47
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(47) Then
                WriteIslandranking.Position = Islandranking_48
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(48) Then
                WriteIslandranking.Position = Islandranking_49
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(49) Then
                WriteIslandranking.Position = Islandranking_50
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(50) Then
                WriteIslandranking.Position = Islandranking_51
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(51) Then
                WriteIslandranking.Position = Islandranking_52
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(52) Then
                WriteIslandranking.Position = Islandranking_53
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(53) Then
                WriteIslandranking.Position = Islandranking_54
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(54) Then
                WriteIslandranking.Position = Islandranking_55
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(55) Then
                WriteIslandranking.Position = Islandranking_56
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(56) Then
                WriteIslandranking.Position = Islandranking_57
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(57) Then
                WriteIslandranking.Position = Islandranking_58
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(58) Then
                WriteIslandranking.Position = Islandranking_59
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(59) Then
                WriteIslandranking.Position = Islandranking_60
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(60) Then
                WriteIslandranking.Position = Islandranking_61
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(61) Then
                WriteIslandranking.Position = Islandranking_62
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(62) Then
                WriteIslandranking.Position = Islandranking_63
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(63) Then
                WriteIslandranking.Position = Islandranking_64
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(64) Then
                WriteIslandranking.Position = Islandranking_65
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(65) Then
                WriteIslandranking.Position = Islandranking_66
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(66) Then
                WriteIslandranking.Position = Islandranking_67
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(67) Then
                WriteIslandranking.Position = Islandranking_68
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(68) Then
                WriteIslandranking.Position = Islandranking_69
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(69) Then
                WriteIslandranking.Position = Islandranking_70
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(70) Then
                WriteIslandranking.Position = Islandranking_71
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(71) Then
                WriteIslandranking.Position = Islandranking_72
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(72) Then
                WriteIslandranking.Position = Islandranking_73
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(73) Then
                WriteIslandranking.Position = Islandranking_74
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(74) Then
                WriteIslandranking.Position = Islandranking_75
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(75) Then
                WriteIslandranking.Position = Islandranking_76
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(76) Then
                WriteIslandranking.Position = Islandranking_77
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(77) Then
                WriteIslandranking.Position = Islandranking_78
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(78) Then
                WriteIslandranking.Position = Islandranking_79
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(79) Then
                WriteIslandranking.Position = Islandranking_80
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(80) Then
                WriteIslandranking.Position = Islandranking_81
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(81) Then
                WriteIslandranking.Position = Islandranking_82
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(82) Then
                WriteIslandranking.Position = Islandranking_83
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(83) Then
                WriteIslandranking.Position = Islandranking_84
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(84) Then
                WriteIslandranking.Position = Islandranking_85
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(85) Then
                WriteIslandranking.Position = Islandranking_86
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(86) Then
                WriteIslandranking.Position = Islandranking_87
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(87) Then
                WriteIslandranking.Position = Islandranking_88
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(88) Then
                WriteIslandranking.Position = Islandranking_89
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(89) Then
                WriteIslandranking.Position = Islandranking_90
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(90) Then
                WriteIslandranking.Position = Islandranking_91
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(91) Then
                WriteIslandranking.Position = Islandranking_92
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(92) Then
                WriteIslandranking.Position = Islandranking_93
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(93) Then
                WriteIslandranking.Position = Islandranking_94
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(94) Then
                WriteIslandranking.Position = Islandranking_95
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(95) Then
                WriteIslandranking.Position = Islandranking_96
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(96) Then
                WriteIslandranking.Position = Islandranking_97
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(97) Then
                WriteIslandranking.Position = Islandranking_98
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(98) Then
                WriteIslandranking.Position = Islandranking_99
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            If Select_islandranking.SelectedItem = Select_islandranking.Items.Item(99) Then
                WriteIslandranking.Position = Islandranking_100
                WriteIslandranking.WriteHexString(Text_restore_islandranking.Text)
            End If
            TLSE_dialog.Text_TLSE_dialog.Text = "This Islandranking has been successfully replace" & vbNewLine & "You need to rename this Islandranking in Tomodachi Life or in Tomodachi Life Save Editor"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to replace this Islandranking"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

End Class