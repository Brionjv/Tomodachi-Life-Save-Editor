Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_miimanagement
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Mii_1 As String
    Dim Mii_2 As String
    Dim Mii_3 As String
    Dim Mii_4 As String
    Dim Mii_5 As String
    Dim Mii_6 As String
    Dim Mii_7 As String
    Dim Mii_8 As String
    Dim Mii_9 As String
    Dim Mii_10 As String
    Dim Mii_11 As String
    Dim Mii_12 As String
    Dim Mii_13 As String
    Dim Mii_14 As String
    Dim Mii_15 As String
    Dim Mii_16 As String
    Dim Mii_17 As String
    Dim Mii_18 As String
    Dim Mii_19 As String
    Dim Mii_20 As String
    Dim Mii_21 As String
    Dim Mii_22 As String
    Dim Mii_23 As String
    Dim Mii_24 As String
    Dim Mii_25 As String
    Dim Mii_26 As String
    Dim Mii_27 As String
    Dim Mii_28 As String
    Dim Mii_29 As String
    Dim Mii_30 As String
    Dim Mii_31 As String
    Dim Mii_32 As String
    Dim Mii_33 As String
    Dim Mii_34 As String
    Dim Mii_35 As String
    Dim Mii_36 As String
    Dim Mii_37 As String
    Dim Mii_38 As String
    Dim Mii_39 As String
    Dim Mii_40 As String
    Dim Mii_41 As String
    Dim Mii_42 As String
    Dim Mii_43 As String
    Dim Mii_44 As String
    Dim Mii_45 As String
    Dim Mii_46 As String
    Dim Mii_47 As String
    Dim Mii_48 As String
    Dim Mii_49 As String
    Dim Mii_50 As String
    Dim Mii_51 As String
    Dim Mii_52 As String
    Dim Mii_53 As String
    Dim Mii_54 As String
    Dim Mii_55 As String
    Dim Mii_56 As String
    Dim Mii_57 As String
    Dim Mii_58 As String
    Dim Mii_59 As String
    Dim Mii_60 As String
    Dim Mii_61 As String
    Dim Mii_62 As String
    Dim Mii_63 As String
    Dim Mii_64 As String
    Dim Mii_65 As String
    Dim Mii_66 As String
    Dim Mii_67 As String
    Dim Mii_68 As String
    Dim Mii_69 As String
    Dim Mii_70 As String
    Dim Mii_71 As String
    Dim Mii_72 As String
    Dim Mii_73 As String
    Dim Mii_74 As String
    Dim Mii_75 As String
    Dim Mii_76 As String
    Dim Mii_77 As String
    Dim Mii_78 As String
    Dim Mii_79 As String
    Dim Mii_80 As String
    Dim Mii_81 As String
    Dim Mii_82 As String
    Dim Mii_83 As String
    Dim Mii_84 As String
    Dim Mii_85 As String
    Dim Mii_86 As String
    Dim Mii_87 As String
    Dim Mii_88 As String
    Dim Mii_89 As String
    Dim Mii_90 As String
    Dim Mii_91 As String
    Dim Mii_92 As String
    Dim Mii_93 As String
    Dim Mii_94 As String
    Dim Mii_95 As String
    Dim Mii_96 As String
    Dim Mii_97 As String
    Dim Mii_98 As String
    Dim Mii_99 As String
    Dim Mii_100 As String
    Dim Miidetected As String

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

    Private Sub Icon_menu_extract_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_extract.MouseMove
        Icon_menu_extract.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_extract_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_extract.MouseLeave
        Icon_menu_extract.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_extract_Click(sender As Object, e As EventArgs) Handles Icon_menu_extract.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        Me.Close()
    End Sub

    Private Sub Icon_menu_restore_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_restore.MouseMove
        Icon_menu_restore.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_restore_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_restore.MouseLeave
        Icon_menu_restore.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_restore_Click(sender As Object, e As EventArgs) Handles Icon_menu_restore.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        Me.Close()
    End Sub

    'end form menu
    Private Sub TLSE_miimanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Select_fea_management.SelectedItem = Select_fea_management.Items.Item(0)
    End Sub

    Private Sub TLSE_miimanagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DetectMiiregistered()
    End Sub

    Public Sub Hidepanels()
        Panel_management.Visible = False
        Panel_management_extract.Visible = False
        Panel_management_restore.Visible = False
    End Sub

    Private Sub Text_extract_Click(sender As Object, e As EventArgs) Handles Text_extract.Click
        Hidepanels()
        Panel_management_extract.Visible = True
    End Sub

    Private Sub Text_restore_Click(sender As Object, e As EventArgs) Handles Text_restore.Click
        Hidepanels()
        Panel_management_restore.Visible = True
    End Sub

    Private Sub Menu_text_res_miimanagement_Click(sender As Object, e As EventArgs) Handles Menu_text_res_miimanagement.Click, Menuflow_res_miimanagement.Click
        Hidepanels()
        Panel_management.Visible = True
    End Sub

    Private Sub Menu_text_ext_miimanagement_Click(sender As Object, e As EventArgs) Handles Menu_text_ext_miimanagement.Click, Menuflow_ext_miimanagement.Click
        Hidepanels()
        Panel_management.Visible = True
    End Sub

    Public Sub Hidefeaextract()
        Panel_extract_Mii.Visible = False
        Panel_extract_allmii.Visible = False
    End Sub
    Public Sub Readmiiname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
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

    Private Sub Text_extractmii_Click(sender As Object, e As EventArgs) Handles Text_extractmii.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Tomodachi Life Mii|*.TLMii"
            SaveFileDialog1.FileName = Select_mii.Text & "_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_extract_Mii.Text)
                TLSE_dialog.Text_TLSE_dialog.Text = "This Mii has been successfully extracted"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Extraction of this Mii has failed, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        Readmiidata()
    End Sub

    Public Sub Readmiidata()
        If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
            Mii_1 = &H1C70
            Mii_2 = &H22D0
            Mii_3 = &H2930
            Mii_4 = &H2F90
            Mii_5 = &H35F0
            Mii_6 = &H3C50
            Mii_7 = &H42B0
            Mii_8 = &H4910
            Mii_9 = &H4F70
            Mii_10 = &H55D0
            Mii_11 = &H5C30
            Mii_12 = &H6290
            Mii_13 = &H68F0
            Mii_14 = &H6F50
            Mii_15 = &H75B0
            Mii_16 = &H7C10
            Mii_17 = &H8270
            Mii_18 = &H88D0
            Mii_19 = &H8F30
            Mii_20 = &H9590
            Mii_21 = &H9BF0
            Mii_22 = &HA250
            Mii_23 = &HA8B0
            Mii_24 = &HAF10
            Mii_25 = &HB570
            Mii_26 = &HBBD0
            Mii_27 = &HC230
            Mii_28 = &HC890
            Mii_29 = &HCEF0
            Mii_30 = &HD550
            Mii_31 = &HDBB0
            Mii_32 = &HE210
            Mii_33 = &HE870
            Mii_34 = &HEED0
            Mii_35 = &HF530
            Mii_36 = &HFB90
            Mii_37 = &H101F0
            Mii_38 = &H10850
            Mii_39 = &H10EB0
            Mii_40 = &H11510
            Mii_41 = &H11B70
            Mii_42 = &H121D0
            Mii_43 = &H12830
            Mii_44 = &H12E90
            Mii_45 = &H134F0
            Mii_46 = &H13B50
            Mii_47 = &H141B0
            Mii_48 = &H14810
            Mii_49 = &H14E70
            Mii_50 = &H154D0
            Mii_51 = &H15B30
            Mii_52 = &H16190
            Mii_53 = &H167F0
            Mii_54 = &H16E50
            Mii_55 = &H174B0
            Mii_56 = &H17B10
            Mii_57 = &H18170
            Mii_58 = &H187D0
            Mii_59 = &H18E30
            Mii_60 = &H19490
            Mii_61 = &H19AF0
            Mii_62 = &H1A150
            Mii_63 = &H1A7B0
            Mii_64 = &H1AE10
            Mii_65 = &H1B470
            Mii_66 = &H1BAD0
            Mii_67 = &H1C130
            Mii_68 = &H1C790
            Mii_69 = &H1CDF0
            Mii_70 = &H1D450
            Mii_71 = &H1DAB0
            Mii_72 = &H1E110
            Mii_73 = &H1E770
            Mii_74 = &H1EDD0
            Mii_75 = &H1F430
            Mii_76 = &H1FA90
            Mii_77 = &H200F0
            Mii_78 = &H20750
            Mii_79 = &H20DB0
            Mii_80 = &H21410
            Mii_81 = &H21A70
            Mii_82 = &H220D0
            Mii_83 = &H22730
            Mii_84 = &H22D90
            Mii_85 = &H233F0
            Mii_86 = &H23A50
            Mii_87 = &H240B0
            Mii_88 = &H24710
            Mii_89 = &H24D70
            Mii_90 = &H253D0
            Mii_91 = &H25A30
            Mii_92 = &H26090
            Mii_93 = &H266F0
            Mii_94 = &H26D50
            Mii_95 = &H273B0
            Mii_96 = &H27A10
            Mii_97 = &H28070
            Mii_98 = &H286D0
            Mii_99 = &H28D30
            Mii_100 = &H29390
        End If
        If Filever_text.Text = "JP" Then
            Mii_1 = &H1C40
            Mii_2 = &H21D0
            Mii_3 = &H2760
            Mii_4 = &H2CF0
            Mii_5 = &H3280
            Mii_6 = &H3810
            Mii_7 = &H3DA0
            Mii_8 = &H4330
            Mii_9 = &H48C0
            Mii_10 = &H4E50
            Mii_11 = &H53E0
            Mii_12 = &H5970
            Mii_13 = &H5F00
            Mii_14 = &H6490
            Mii_15 = &H6A20
            Mii_16 = &H6FB0
            Mii_17 = &H7540
            Mii_18 = &H7AD0
            Mii_19 = &H8060
            Mii_20 = &H85F0
            Mii_21 = &H8B80
            Mii_22 = &H9110
            Mii_23 = &H96A0
            Mii_24 = &H9C30
            Mii_25 = &HA1C0
            Mii_26 = &HA750
            Mii_27 = &HACE0
            Mii_28 = &HB270
            Mii_29 = &HB800
            Mii_30 = &HBD90
            Mii_31 = &HC320
            Mii_32 = &HC8B0
            Mii_33 = &HCE40
            Mii_34 = &HD3D0
            Mii_35 = &HD960
            Mii_36 = &HDEF0
            Mii_37 = &HE480
            Mii_38 = &HEA10
            Mii_39 = &HEFA0
            Mii_40 = &HF530
            Mii_41 = &HFAC0
            Mii_42 = &H10050
            Mii_43 = &H105E0
            Mii_44 = &H10B70
            Mii_45 = &H11100
            Mii_46 = &H11690
            Mii_47 = &H11C20
            Mii_48 = &H121B0
            Mii_49 = &H12740
            Mii_50 = &H12CD0
            Mii_51 = &H13260
            Mii_52 = &H137F0
            Mii_53 = &H13D80
            Mii_54 = &H14310
            Mii_55 = &H148A0
            Mii_56 = &H14E30
            Mii_57 = &H153C0
            Mii_58 = &H15950
            Mii_59 = &H15EE0
            Mii_60 = &H16470
            Mii_61 = &H16A00
            Mii_62 = &H16F90
            Mii_63 = &H17520
            Mii_64 = &H17AB0
            Mii_65 = &H18040
            Mii_66 = &H185D0
            Mii_67 = &H18B60
            Mii_68 = &H190F0
            Mii_69 = &H19680
            Mii_70 = &H19C10
            Mii_71 = &H1A1A0
            Mii_72 = &H1A730
            Mii_73 = &H1ACC0
            Mii_74 = &H1B250
            Mii_75 = &H1B7E0
            Mii_76 = &H1BD70
            Mii_77 = &H1C300
            Mii_78 = &H1C890
            Mii_79 = &H1CE20
            Mii_80 = &H1D3B0
            Mii_81 = &H1D940
            Mii_82 = &H1DED0
            Mii_83 = &H1E460
            Mii_84 = &H1E9F0
            Mii_85 = &H1EF80
            Mii_86 = &H1F510
            Mii_87 = &H1FAA0
            Mii_88 = &H20030
            Mii_89 = &H205C0
            Mii_90 = &H20B50
            Mii_91 = &H210E0
            Mii_92 = &H21670
            Mii_93 = &H21C00
            Mii_94 = &H22190
            Mii_95 = &H22720
            Mii_96 = &H22CB0
            Mii_97 = &H23240
            Mii_98 = &H237D0
            Mii_99 = &H23D60
            Mii_100 = &H242F0
        End If
        Try
            Dim ReadMiiData As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                ReadMiiData.Position = Mii_1
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                ReadMiiData.Position = Mii_2
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                ReadMiiData.Position = Mii_3
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                ReadMiiData.Position = Mii_4
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                ReadMiiData.Position = Mii_5
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                ReadMiiData.Position = Mii_6
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                ReadMiiData.Position = Mii_7
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                ReadMiiData.Position = Mii_8
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                ReadMiiData.Position = Mii_9
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                ReadMiiData.Position = Mii_10
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                ReadMiiData.Position = Mii_11
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                ReadMiiData.Position = Mii_12
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                ReadMiiData.Position = Mii_13
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                ReadMiiData.Position = Mii_14
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                ReadMiiData.Position = Mii_15
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                ReadMiiData.Position = Mii_16
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                ReadMiiData.Position = Mii_17
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                ReadMiiData.Position = Mii_18
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                ReadMiiData.Position = Mii_19
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                ReadMiiData.Position = Mii_20
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                ReadMiiData.Position = Mii_21
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                ReadMiiData.Position = Mii_22
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                ReadMiiData.Position = Mii_23
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                ReadMiiData.Position = Mii_24
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                ReadMiiData.Position = Mii_25
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                ReadMiiData.Position = Mii_26
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                ReadMiiData.Position = Mii_27
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                ReadMiiData.Position = Mii_28
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                ReadMiiData.Position = Mii_29
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                ReadMiiData.Position = Mii_30
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                ReadMiiData.Position = Mii_31
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                ReadMiiData.Position = Mii_32
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                ReadMiiData.Position = Mii_33
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                ReadMiiData.Position = Mii_34
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                ReadMiiData.Position = Mii_35
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                ReadMiiData.Position = Mii_36
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                ReadMiiData.Position = Mii_37
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                ReadMiiData.Position = Mii_38
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                ReadMiiData.Position = Mii_39
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                ReadMiiData.Position = Mii_40
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                ReadMiiData.Position = Mii_41
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                ReadMiiData.Position = Mii_42
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                ReadMiiData.Position = Mii_43
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                ReadMiiData.Position = Mii_44
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                ReadMiiData.Position = Mii_45
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                ReadMiiData.Position = Mii_46
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                ReadMiiData.Position = Mii_47
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                ReadMiiData.Position = Mii_48
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                ReadMiiData.Position = Mii_49
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                ReadMiiData.Position = Mii_50
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                ReadMiiData.Position = Mii_51
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                ReadMiiData.Position = Mii_52
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                ReadMiiData.Position = Mii_53
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                ReadMiiData.Position = Mii_54
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                ReadMiiData.Position = Mii_55
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                ReadMiiData.Position = Mii_56
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                ReadMiiData.Position = Mii_57
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                ReadMiiData.Position = Mii_58
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                ReadMiiData.Position = Mii_59
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                ReadMiiData.Position = Mii_60
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                ReadMiiData.Position = Mii_61
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                ReadMiiData.Position = Mii_62
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                ReadMiiData.Position = Mii_63
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                ReadMiiData.Position = Mii_64
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                ReadMiiData.Position = Mii_65
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                ReadMiiData.Position = Mii_66
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                ReadMiiData.Position = Mii_67
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                ReadMiiData.Position = Mii_68
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                ReadMiiData.Position = Mii_69
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                ReadMiiData.Position = Mii_70
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                ReadMiiData.Position = Mii_71
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                ReadMiiData.Position = Mii_72
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                ReadMiiData.Position = Mii_73
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                ReadMiiData.Position = Mii_74
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                ReadMiiData.Position = Mii_75
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                ReadMiiData.Position = Mii_76
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                ReadMiiData.Position = Mii_77
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                ReadMiiData.Position = Mii_78
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                ReadMiiData.Position = Mii_79
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                ReadMiiData.Position = Mii_80
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                ReadMiiData.Position = Mii_81
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                ReadMiiData.Position = Mii_82
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                ReadMiiData.Position = Mii_83
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                ReadMiiData.Position = Mii_84
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                ReadMiiData.Position = Mii_85
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                ReadMiiData.Position = Mii_86
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                ReadMiiData.Position = Mii_87
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                ReadMiiData.Position = Mii_88
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                ReadMiiData.Position = Mii_89
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                ReadMiiData.Position = Mii_90
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                ReadMiiData.Position = Mii_91
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                ReadMiiData.Position = Mii_92
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                ReadMiiData.Position = Mii_93
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                ReadMiiData.Position = Mii_94
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                ReadMiiData.Position = Mii_95
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                ReadMiiData.Position = Mii_96
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                ReadMiiData.Position = Mii_97
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                ReadMiiData.Position = Mii_98
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                ReadMiiData.Position = Mii_99
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                ReadMiiData.Position = Mii_100
                Text_extract_Mii.Text = ReadMiiData.ReadHexString(&H60)
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this Mii, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
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
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read all Miis, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Select_fea_management_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_fea_management.SelectedIndexChanged
        If Select_fea_management.SelectedItem = Select_fea_management.Items.Item(0) Then
            Hidefeaextract()
            Panel_extract_Mii.Visible = True
            Text_note_fea_management.Text = "Extract a Mii : like regular .mii format but for Tomodachi Life (you can't use .mii file)"
        End If
        If Select_fea_management.SelectedItem = Select_fea_management.Items.Item(1) Then
            Hidefeaextract()
            Panel_extract_allmii.Visible = True
            Text_note_fea_management.Text = "Extract all Miis to a file : used to export all Miis to an other save file"
            ReadAllMii()
        End If
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


End Class