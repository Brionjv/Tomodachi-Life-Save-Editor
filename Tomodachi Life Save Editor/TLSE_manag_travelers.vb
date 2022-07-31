Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_manag_travelers
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Traveler_1 As String
    Dim Traveler_2 As String
    Dim Traveler_3 As String
    Dim Traveler_4 As String
    Dim Traveler_5 As String
    Dim Traveler_6 As String
    Dim Traveler_7 As String
    Dim Traveler_8 As String
    Dim Traveler_9 As String
    Dim Traveler_10 As String
    Dim Traveler_11 As String
    Dim Traveler_12 As String
    Dim Traveler_13 As String
    Dim Traveler_14 As String
    Dim Traveler_15 As String
    Dim Traveler_16 As String
    Dim Traveler_17 As String
    Dim Traveler_18 As String
    Dim Traveler_19 As String
    Dim Traveler_20 As String
    Dim Traveler_21 As String
    Dim Traveler_22 As String
    Dim Traveler_23 As String
    Dim Traveler_24 As String
    Dim Traveler_25 As String
    Dim Traveler_26 As String
    Dim Traveler_27 As String
    Dim Traveler_28 As String
    Dim Traveler_29 As String
    Dim Traveler_30 As String
    Dim Traveler_31 As String
    Dim Traveler_32 As String
    Dim Traveler_33 As String
    Dim Traveler_34 As String
    Dim Traveler_35 As String
    Dim Traveler_36 As String
    Dim Traveler_37 As String
    Dim Traveler_38 As String
    Dim Traveler_39 As String
    Dim Traveler_40 As String
    Dim Traveler_41 As String
    Dim Traveler_42 As String
    Dim Traveler_43 As String
    Dim Traveler_44 As String
    Dim Traveler_45 As String
    Dim Traveler_46 As String
    Dim Traveler_47 As String
    Dim Traveler_48 As String
    Dim Traveler_49 As String
    Dim Traveler_50 As String
    Dim Miidetected As String
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

    'end form menu
    Private Sub TLSE_manag_travelers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub TLSE_manag_travelers_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub Menu_text_miimanagement_Click(sender As Object, e As EventArgs) Handles Menu_text_miimanagement.Click
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

    Public Sub Readmiiname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H318B0
                Select_mii.Items.Item(0) = "Traveler 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H324D8
                Select_mii.Items.Item(1) = "Traveler 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H33100
                Select_mii.Items.Item(2) = "Traveler 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H33D28
                Select_mii.Items.Item(3) = "Traveler 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H34950
                Select_mii.Items.Item(4) = "Traveler 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H35578
                Select_mii.Items.Item(5) = "Traveler 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H361A0
                Select_mii.Items.Item(6) = "Traveler 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H36DC8
                Select_mii.Items.Item(7) = "Traveler 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H379F0
                Select_mii.Items.Item(8) = "Traveler 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H38618
                Select_mii.Items.Item(9) = "Traveler 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39240
                Select_mii.Items.Item(10) = "Traveler 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39E68
                Select_mii.Items.Item(11) = "Traveler 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3AA90
                Select_mii.Items.Item(12) = "Traveler 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3B6B8
                Select_mii.Items.Item(13) = "Traveler 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C2E0
                Select_mii.Items.Item(14) = "Traveler 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3CF08
                Select_mii.Items.Item(15) = "Traveler 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DB30
                Select_mii.Items.Item(16) = "Traveler 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3E758
                Select_mii.Items.Item(17) = "Traveler 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3F380
                Select_mii.Items.Item(18) = "Traveler 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3FFA8
                Select_mii.Items.Item(19) = "Traveler 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40BD0
                Select_mii.Items.Item(20) = "Traveler 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H417F8
                Select_mii.Items.Item(21) = "Traveler 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H42420
                Select_mii.Items.Item(22) = "Traveler 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43048
                Select_mii.Items.Item(23) = "Traveler 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43C70
                Select_mii.Items.Item(24) = "Traveler 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H44898
                Select_mii.Items.Item(25) = "Traveler 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H454C0
                Select_mii.Items.Item(26) = "Traveler 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H460E8
                Select_mii.Items.Item(27) = "Traveler 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46D10
                Select_mii.Items.Item(28) = "Traveler 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H47938
                Select_mii.Items.Item(29) = "Traveler 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H48560
                Select_mii.Items.Item(30) = "Traveler 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49188
                Select_mii.Items.Item(31) = "Traveler 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49DB0
                Select_mii.Items.Item(32) = "Traveler 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4A9D8
                Select_mii.Items.Item(33) = "Traveler 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4B600
                Select_mii.Items.Item(34) = "Traveler 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4C228
                Select_mii.Items.Item(35) = "Traveler 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4CE50
                Select_mii.Items.Item(36) = "Traveler 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4DA78
                Select_mii.Items.Item(37) = "Traveler 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E6A0
                Select_mii.Items.Item(38) = "Traveler 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F2C8
                Select_mii.Items.Item(39) = "Traveler 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4FEF0
                Select_mii.Items.Item(40) = "Traveler 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H50B18
                Select_mii.Items.Item(41) = "Traveler 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H51740
                Select_mii.Items.Item(42) = "Traveler 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H52368
                Select_mii.Items.Item(43) = "Traveler 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H52F90
                Select_mii.Items.Item(44) = "Traveler 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53BB8
                Select_mii.Items.Item(45) = "Traveler 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H547E0
                Select_mii.Items.Item(46) = "Traveler 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55408
                Select_mii.Items.Item(47) = "Traveler 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56030
                Select_mii.Items.Item(48) = "Traveler 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56C58
                Select_mii.Items.Item(49) = "Traveler 50 : " & Reader.ReadUnicodeString(10)
            Else
                Reader.Position = &H392C0
                Select_mii.Items.Item(0) = "Traveler 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39EE8
                Select_mii.Items.Item(1) = "Traveler 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3AB10
                Select_mii.Items.Item(2) = "Traveler 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3B738
                Select_mii.Items.Item(3) = "Traveler 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C360
                Select_mii.Items.Item(4) = "Traveler 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3CF88
                Select_mii.Items.Item(5) = "Traveler 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DBB0
                Select_mii.Items.Item(6) = "Traveler 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3E7D8
                Select_mii.Items.Item(7) = "Traveler 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3F400
                Select_mii.Items.Item(8) = "Traveler 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40028
                Select_mii.Items.Item(9) = "Traveler 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40C50
                Select_mii.Items.Item(10) = "Traveler 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H41878
                Select_mii.Items.Item(11) = "Traveler 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H424A0
                Select_mii.Items.Item(12) = "Traveler 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H430C8
                Select_mii.Items.Item(13) = "Traveler 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43CF0
                Select_mii.Items.Item(14) = "Traveler 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H44918
                Select_mii.Items.Item(15) = "Traveler 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H45540
                Select_mii.Items.Item(16) = "Traveler 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46168
                Select_mii.Items.Item(17) = "Traveler 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46D90
                Select_mii.Items.Item(18) = "Traveler 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H479B8
                Select_mii.Items.Item(19) = "Traveler 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H485E0
                Select_mii.Items.Item(20) = "Traveler 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49208
                Select_mii.Items.Item(21) = "Traveler 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49E30
                Select_mii.Items.Item(22) = "Traveler 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4AA58
                Select_mii.Items.Item(23) = "Traveler 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4B680
                Select_mii.Items.Item(24) = "Traveler 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4C2A8
                Select_mii.Items.Item(25) = "Traveler 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4CED0
                Select_mii.Items.Item(26) = "Traveler 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4DAF8
                Select_mii.Items.Item(27) = "Traveler 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E720
                Select_mii.Items.Item(28) = "Traveler 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F348
                Select_mii.Items.Item(29) = "Traveler 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4FF70
                Select_mii.Items.Item(30) = "Traveler 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H50B98
                Select_mii.Items.Item(31) = "Traveler 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H517C0
                Select_mii.Items.Item(32) = "Traveler 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H523E8
                Select_mii.Items.Item(33) = "Traveler 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53010
                Select_mii.Items.Item(34) = "Traveler 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53C38
                Select_mii.Items.Item(35) = "Traveler 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H54860
                Select_mii.Items.Item(36) = "Traveler 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55488
                Select_mii.Items.Item(37) = "Traveler 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H560B0
                Select_mii.Items.Item(38) = "Traveler 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56CD8
                Select_mii.Items.Item(39) = "Traveler 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H57900
                Select_mii.Items.Item(40) = "Traveler 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H58528
                Select_mii.Items.Item(41) = "Traveler 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H59150
                Select_mii.Items.Item(42) = "Traveler 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H59D78
                Select_mii.Items.Item(43) = "Traveler 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5A9A0
                Select_mii.Items.Item(44) = "Traveler 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5B5C8
                Select_mii.Items.Item(45) = "Traveler 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5C1F0
                Select_mii.Items.Item(46) = "Traveler 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5CE18
                Select_mii.Items.Item(47) = "Traveler 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5DA40
                Select_mii.Items.Item(48) = "Traveler 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5E668
                Select_mii.Items.Item(49) = "Traveler 50 : " & Reader.ReadUnicodeString(10)
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

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        Readmiidata()
    End Sub

    Public Sub Readmiidata()
        Settravelers()
        Try
            Dim ReadMiiData As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                    ReadMiiData.Position = Traveler_1
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                    ReadMiiData.Position = Traveler_2
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                    ReadMiiData.Position = Traveler_3
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                    ReadMiiData.Position = Traveler_4
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                    ReadMiiData.Position = Traveler_5
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                    ReadMiiData.Position = Traveler_6
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                    ReadMiiData.Position = Traveler_7
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                    ReadMiiData.Position = Traveler_8
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                    ReadMiiData.Position = Traveler_9
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                    ReadMiiData.Position = Traveler_10
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                    ReadMiiData.Position = Traveler_11
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                    ReadMiiData.Position = Traveler_12
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                    ReadMiiData.Position = Traveler_13
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                    ReadMiiData.Position = Traveler_14
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                    ReadMiiData.Position = Traveler_15
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                    ReadMiiData.Position = Traveler_16
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                    ReadMiiData.Position = Traveler_17
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                    ReadMiiData.Position = Traveler_18
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                    ReadMiiData.Position = Traveler_19
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                    ReadMiiData.Position = Traveler_20
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                    ReadMiiData.Position = Traveler_21
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                    ReadMiiData.Position = Traveler_22
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                    ReadMiiData.Position = Traveler_23
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                    ReadMiiData.Position = Traveler_24
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                    ReadMiiData.Position = Traveler_25
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                    ReadMiiData.Position = Traveler_26
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                    ReadMiiData.Position = Traveler_27
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                    ReadMiiData.Position = Traveler_28
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                    ReadMiiData.Position = Traveler_29
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                    ReadMiiData.Position = Traveler_30
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                    ReadMiiData.Position = Traveler_31
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                    ReadMiiData.Position = Traveler_32
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                    ReadMiiData.Position = Traveler_33
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                    ReadMiiData.Position = Traveler_34
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                    ReadMiiData.Position = Traveler_35
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                    ReadMiiData.Position = Traveler_36
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                    ReadMiiData.Position = Traveler_37
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                    ReadMiiData.Position = Traveler_38
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                    ReadMiiData.Position = Traveler_39
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                    ReadMiiData.Position = Traveler_40
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                    ReadMiiData.Position = Traveler_41
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                    ReadMiiData.Position = Traveler_42
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                    ReadMiiData.Position = Traveler_43
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                    ReadMiiData.Position = Traveler_44
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                    ReadMiiData.Position = Traveler_45
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                    ReadMiiData.Position = Traveler_46
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                    ReadMiiData.Position = Traveler_47
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                    ReadMiiData.Position = Traveler_48
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                    ReadMiiData.Position = Traveler_49
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                    ReadMiiData.Position = Traveler_50
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HB58)
                End If
            Else
                If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                    ReadMiiData.Position = Traveler_1
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                    ReadMiiData.Position = Traveler_2
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                    ReadMiiData.Position = Traveler_3
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                    ReadMiiData.Position = Traveler_4
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                    ReadMiiData.Position = Traveler_5
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                    ReadMiiData.Position = Traveler_6
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                    ReadMiiData.Position = Traveler_7
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                    ReadMiiData.Position = Traveler_8
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                    ReadMiiData.Position = Traveler_9
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                    ReadMiiData.Position = Traveler_10
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                    ReadMiiData.Position = Traveler_11
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                    ReadMiiData.Position = Traveler_12
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                    ReadMiiData.Position = Traveler_13
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                    ReadMiiData.Position = Traveler_14
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                    ReadMiiData.Position = Traveler_15
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                    ReadMiiData.Position = Traveler_16
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                    ReadMiiData.Position = Traveler_17
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                    ReadMiiData.Position = Traveler_18
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                    ReadMiiData.Position = Traveler_19
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                    ReadMiiData.Position = Traveler_20
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                    ReadMiiData.Position = Traveler_21
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                    ReadMiiData.Position = Traveler_22
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                    ReadMiiData.Position = Traveler_23
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                    ReadMiiData.Position = Traveler_24
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                    ReadMiiData.Position = Traveler_25
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                    ReadMiiData.Position = Traveler_26
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                    ReadMiiData.Position = Traveler_27
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                    ReadMiiData.Position = Traveler_28
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                    ReadMiiData.Position = Traveler_29
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                    ReadMiiData.Position = Traveler_30
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                    ReadMiiData.Position = Traveler_31
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                    ReadMiiData.Position = Traveler_32
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                    ReadMiiData.Position = Traveler_33
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                    ReadMiiData.Position = Traveler_34
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                    ReadMiiData.Position = Traveler_35
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                    ReadMiiData.Position = Traveler_36
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                    ReadMiiData.Position = Traveler_37
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                    ReadMiiData.Position = Traveler_38
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                    ReadMiiData.Position = Traveler_39
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                    ReadMiiData.Position = Traveler_40
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                    ReadMiiData.Position = Traveler_41
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                    ReadMiiData.Position = Traveler_42
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                    ReadMiiData.Position = Traveler_43
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                    ReadMiiData.Position = Traveler_44
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                    ReadMiiData.Position = Traveler_45
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                    ReadMiiData.Position = Traveler_46
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                    ReadMiiData.Position = Traveler_47
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                    ReadMiiData.Position = Traveler_48
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                    ReadMiiData.Position = Traveler_49
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
                If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                    ReadMiiData.Position = Traveler_50
                    Text_extract_Mii.Text = ReadMiiData.ReadHexString(&HC28)
                End If
            End If

        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this Mii, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub Settravelers()
        If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
            Traveler_1 = &H390E0
            Traveler_2 = &H39D08
            Traveler_3 = &H3A930
            Traveler_4 = &H3B558
            Traveler_5 = &H3C180
            Traveler_6 = &H3CDA8
            Traveler_7 = &H3D9D0
            Traveler_8 = &H3E5F8
            Traveler_9 = &H3F220
            Traveler_10 = &H3FE48
            Traveler_11 = &H40A70
            Traveler_12 = &H41698
            Traveler_13 = &H422C0
            Traveler_14 = &H42EE8
            Traveler_15 = &H43B10
            Traveler_16 = &H44738
            Traveler_17 = &H45360
            Traveler_18 = &H45F88
            Traveler_19 = &H46BB0
            Traveler_20 = &H477D8
            Traveler_21 = &H48400
            Traveler_22 = &H49028
            Traveler_23 = &H49C50
            Traveler_24 = &H4A878
            Traveler_25 = &H4B4A0
            Traveler_26 = &H4C0C8
            Traveler_27 = &H4CCF0
            Traveler_28 = &H4D918
            Traveler_29 = &H4E540
            Traveler_30 = &H4F168
            Traveler_31 = &H4FD90
            Traveler_32 = &H509B8
            Traveler_33 = &H515E0
            Traveler_34 = &H52208
            Traveler_35 = &H52E30
            Traveler_36 = &H53A58
            Traveler_37 = &H54680
            Traveler_38 = &H552A8
            Traveler_39 = &H55ED0
            Traveler_40 = &H56AF8
            Traveler_41 = &H57720
            Traveler_42 = &H58348
            Traveler_43 = &H58F70
            Traveler_44 = &H59B98
            Traveler_45 = &H5A7C0
            Traveler_46 = &H5B3E8
            Traveler_47 = &H5C010
            Traveler_48 = &H5CC38
            Traveler_49 = &H5D860
            Traveler_50 = &H5E488
        End If
        If Filever_text.Text = "JP" Then
            Traveler_1 = &H316D0
            Traveler_2 = &H32228
            Traveler_3 = &H32D80
            Traveler_4 = &H338D8
            Traveler_5 = &H34430
            Traveler_6 = &H34F88
            Traveler_7 = &H35AE0
            Traveler_8 = &H36638
            Traveler_9 = &H37190
            Traveler_10 = &H37CE8
            Traveler_11 = &H38840
            Traveler_12 = &H39398
            Traveler_13 = &H39EF0
            Traveler_14 = &H3AA48
            Traveler_15 = &H3B5A0
            Traveler_16 = &H3C0F8
            Traveler_17 = &H3CC50
            Traveler_18 = &H3D7A8
            Traveler_19 = &H3E300
            Traveler_20 = &H3EE58
            Traveler_21 = &H3F9B0
            Traveler_22 = &H40508
            Traveler_23 = &H41060
            Traveler_24 = &H41BB8
            Traveler_25 = &H42710
            Traveler_26 = &H43268
            Traveler_27 = &H43DC0
            Traveler_28 = &H44918
            Traveler_29 = &H45470
            Traveler_30 = &H45FC8
            Traveler_31 = &H46B20
            Traveler_32 = &H47678
            Traveler_33 = &H481D0
            Traveler_34 = &H48D28
            Traveler_35 = &H49880
            Traveler_36 = &H4A3D8
            Traveler_37 = &H4AF30
            Traveler_38 = &H4BA88
            Traveler_39 = &H4C5E0
            Traveler_40 = &H4D138
            Traveler_41 = &H4DC90
            Traveler_42 = &H4E7E8
            Traveler_43 = &H4F340
            Traveler_44 = &H4FE98
            Traveler_45 = &H509F0
            Traveler_46 = &H51548
            Traveler_47 = &H520A0
            Traveler_48 = &H52BF8
            Traveler_49 = &H53750
            Traveler_50 = &H542A8
        End If
    End Sub

    Private Sub Text_extractmii_Click(sender As Object, e As EventArgs) Handles Text_extractmii.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            If Filever_text.Text = "JP" Then
                SaveFileDialog1.Filter = "Tomodachi Life JTraveler|*.TLJTRAVELER"
                SaveFileDialog1.FileName = Select_mii.Text.Replace(":", "") & "_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                    Writer1.Close()
                    Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                    Writer.WriteHexString(Text_extract_Mii.Text)
                    TLSE_dialog.Text_TLSE_dialog.Text = "This Traveler has been successfully extracted"
                    TLSE_dialog.ShowDialog()
                End If
            Else
                SaveFileDialog1.Filter = "Tomodachi Life Traveler|*.TLTRAVELER"
                SaveFileDialog1.FileName = Select_mii.Text.Replace(":", "") & "_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                    Writer1.Close()
                    Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                    Writer.WriteHexString(Text_extract_Mii.Text)
                    TLSE_dialog.Text_TLSE_dialog.Text = "This Traveler has been successfully extracted"
                    TLSE_dialog.ShowDialog()
                End If
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Extraction of this Traveler has failed, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Text_restoremii_Click(sender As Object, e As EventArgs) Handles Text_restoremii.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "This Mii will be replace" & vbNewLine & "Do you want continue ?"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Ce mii va être remplacé" & vbNewLine & "Voulez vous continuer ?"
        End If
        TLSE_dialog.Panel_Cancel.Visible = True
        TLSE_dialog.Panel_OK.Visible = True
        TLSE_dialog.ShowDialog()
        If TLSE_dialog.DialogResult = DialogResult.OK Then
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Did you want to replace with Mii files or .TLTRAVELER files ?"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Voulez vous remplacer avec des fichiers Mii ou des fichiers .TLTRAVELER ?"
            End If
            TLSE_dialog.Cancel_Button.Text = "Mii files"
            TLSE_dialog.Panel_Cancel.Visible = True
            TLSE_dialog.OK_Button.Text = ".TLTRAVELER"
            TLSE_dialog.Panel_OK.Visible = True
            TLSE_dialog.ShowDialog()
            Dim open As New OpenFileDialog
            If TLSE_dialog.DialogResult = DialogResult.OK Then
                If Filever_text.Text = "JP" Then
                    open.Filter = "Tomodachi Life jtraveler files|*.TLJTRAVELER"
                Else
                    open.Filter = "Tomodachi Life traveler files|*.TLTRAVELER"
                End If
                open.Title = "Open compatible files"
                open.ShowDialog()
                TLMII = open.FileName
                ReadTLtraveler()
                RestoreTraveler()
            ElseIf TLSE_dialog.DialogResult = DialogResult.Cancel Then
                If Filever_text.Text = "JP" Then
                    open.Filter = "Mii files|*.CFSD;*MIITOPIAMIIA;*TLTRAVELER;*FFSD"
                Else
                    open.Filter = "Mii files|*.CFSD;*MIITOPIAMIIA;*TLJTRAVELER;*FFSD"
                End If
                open.Title = "Open compatible files"
                open.ShowDialog()
                TLMII = open.FileName
                ReadTLmii()
                RestoreMii()
            End If
        End If
    End Sub

    Public Sub ReadTLtraveler()
        Try
            Dim ReadTLMii As New PackageIO.Reader(TLMII, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                ReadTLMii.Position = &H0
                Text_restore_Mii.Text = ReadTLMii.ReadHexString(&HB58)
            Else
                ReadTLMii.Position = &H0
                Text_restore_Mii.Text = ReadTLMii.ReadHexString(&HC28)
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read a Mii in this file"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub ReadTLmii()
        Try
            Dim ReadTLMii As New PackageIO.Reader(TLMII, PackageIO.Endian.Little)
            ReadTLMii.Position = &H0
            Text_restore_Mii.Text = ReadTLMii.ReadHexString(&H60)
            ReadTLMii.Position = &H1A
            Text_restore_miiname.Text = ReadTLMii.ReadUnicodeString(10)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read a Mii in this file"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub RestoreTraveler()
        Try
            Dim WriteMii As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                WriteMii.Position = Traveler_1
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_1 + &HB50)
                    WriteMii.WriteHexString(&H1)
                Else
                    WriteMii.Position = (Traveler_1 + &HC20)
                    WriteMii.WriteHexString(&H1)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                WriteMii.Position = Traveler_2
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_2 + &HB50)
                    WriteMii.WriteHexString(&H2)
                Else
                    WriteMii.Position = (Traveler_2 + &HC20)
                    WriteMii.WriteHexString(&H2)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                WriteMii.Position = Traveler_3
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_3 + &HB50)
                    WriteMii.WriteHexString(&H3)
                Else
                    WriteMii.Position = (Traveler_3 + &HC20)
                    WriteMii.WriteHexString(&H3)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                WriteMii.Position = Traveler_4
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_4 + &HB50)
                    WriteMii.WriteHexString(&H4)
                Else
                    WriteMii.Position = (Traveler_4 + &HC20)
                    WriteMii.WriteHexString(&H4)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                WriteMii.Position = Traveler_5
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_5 + &HB50)
                    WriteMii.WriteHexString(&H5)
                Else
                    WriteMii.Position = (Traveler_5 + &HC20)
                    WriteMii.WriteHexString(&H5)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                WriteMii.Position = Traveler_6
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_6 + &HB50)
                    WriteMii.WriteHexString(&H6)
                Else
                    WriteMii.Position = (Traveler_6 + &HC20)
                    WriteMii.WriteHexString(&H6)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                WriteMii.Position = Traveler_7
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_7 + &HB50)
                    WriteMii.WriteHexString(&H7)
                Else
                    WriteMii.Position = (Traveler_7 + &HC20)
                    WriteMii.WriteHexString(&H7)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                WriteMii.Position = Traveler_8
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_8 + &HB50)
                    WriteMii.WriteHexString(&H8)
                Else
                    WriteMii.Position = (Traveler_8 + &HC20)
                    WriteMii.WriteHexString(&H8)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                WriteMii.Position = Traveler_9
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_9 + &HB50)
                    WriteMii.WriteHexString(&H9)
                Else
                    WriteMii.Position = (Traveler_9 + &HC20)
                    WriteMii.WriteHexString(&H9)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                WriteMii.Position = Traveler_10
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_10 + &HB50)
                    WriteMii.WriteHexString(&HA)
                Else
                    WriteMii.Position = (Traveler_10 + &HC20)
                    WriteMii.WriteHexString(&HA)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                WriteMii.Position = Traveler_11
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_11 + &HB50)
                    WriteMii.WriteHexString(&HB)
                Else
                    WriteMii.Position = (Traveler_11 + &HC20)
                    WriteMii.WriteHexString(&HB)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                WriteMii.Position = Traveler_12
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_12 + &HB50)
                    WriteMii.WriteHexString(&HC)
                Else
                    WriteMii.Position = (Traveler_12 + &HC20)
                    WriteMii.WriteHexString(&HC)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                WriteMii.Position = Traveler_13
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_13 + &HB50)
                    WriteMii.WriteHexString(&HD)
                Else
                    WriteMii.Position = (Traveler_13 + &HC20)
                    WriteMii.WriteHexString(&HD)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                WriteMii.Position = Traveler_14
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_14 + &HB50)
                    WriteMii.WriteHexString(&HE)
                Else
                    WriteMii.Position = (Traveler_14 + &HC20)
                    WriteMii.WriteHexString(&HE)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                WriteMii.Position = Traveler_15
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_15 + &HB50)
                    WriteMii.WriteHexString(&HF)
                Else
                    WriteMii.Position = (Traveler_15 + &HC20)
                    WriteMii.WriteHexString(&HF)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                WriteMii.Position = Traveler_16
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_16 + &HB50)
                    WriteMii.WriteHexString(&H10)
                Else
                    WriteMii.Position = (Traveler_16 + &HC20)
                    WriteMii.WriteHexString(&H10)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                WriteMii.Position = Traveler_17
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_17 + &HB50)
                    WriteMii.WriteHexString(&H11)
                Else
                    WriteMii.Position = (Traveler_17 + &HC20)
                    WriteMii.WriteHexString(&H11)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                WriteMii.Position = Traveler_18
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_18 + &HB50)
                    WriteMii.WriteHexString(&H12)
                Else
                    WriteMii.Position = (Traveler_18 + &HC20)
                    WriteMii.WriteHexString(&H12)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                WriteMii.Position = Traveler_19
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_19 + &HB50)
                    WriteMii.WriteHexString(&H13)
                Else
                    WriteMii.Position = (Traveler_19 + &HC20)
                    WriteMii.WriteHexString(&H13)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                WriteMii.Position = Traveler_20
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_20 + &HB50)
                    WriteMii.WriteHexString(&H14)
                Else
                    WriteMii.Position = (Traveler_20 + &HC20)
                    WriteMii.WriteHexString(&H14)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                WriteMii.Position = Traveler_21
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_21 + &HB50)
                    WriteMii.WriteHexString(&H15)
                Else
                    WriteMii.Position = (Traveler_21 + &HC20)
                    WriteMii.WriteHexString(&H15)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                WriteMii.Position = Traveler_22
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_22 + &HB50)
                    WriteMii.WriteHexString(&H16)
                Else
                    WriteMii.Position = (Traveler_22 + &HC20)
                    WriteMii.WriteHexString(&H16)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                WriteMii.Position = Traveler_23
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_23 + &HB50)
                    WriteMii.WriteHexString(&H17)
                Else
                    WriteMii.Position = (Traveler_23 + &HC20)
                    WriteMii.WriteHexString(&H17)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                WriteMii.Position = Traveler_24
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_24 + &HB50)
                    WriteMii.WriteHexString(&H18)
                Else
                    WriteMii.Position = (Traveler_24 + &HC20)
                    WriteMii.WriteHexString(&H18)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                WriteMii.Position = Traveler_25
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_25 + &HB50)
                    WriteMii.WriteHexString(&H19)
                Else
                    WriteMii.Position = (Traveler_25 + &HC20)
                    WriteMii.WriteHexString(&H19)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                WriteMii.Position = Traveler_26
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_26 + &HB50)
                    WriteMii.WriteHexString(&H1A)
                Else
                    WriteMii.Position = (Traveler_26 + &HC20)
                    WriteMii.WriteHexString(&H1A)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                WriteMii.Position = Traveler_27
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_27 + &HB50)
                    WriteMii.WriteHexString(&H1B)
                Else
                    WriteMii.Position = (Traveler_27 + &HC20)
                    WriteMii.WriteHexString(&H1B)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                WriteMii.Position = Traveler_28
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_28 + &HB50)
                    WriteMii.WriteHexString(&H1C)
                Else
                    WriteMii.Position = (Traveler_28 + &HC20)
                    WriteMii.WriteHexString(&H1C)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                WriteMii.Position = Traveler_29
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_29 + &HB50)
                    WriteMii.WriteHexString(&H1D)
                Else
                    WriteMii.Position = (Traveler_29 + &HC20)
                    WriteMii.WriteHexString(&H1D)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                WriteMii.Position = Traveler_30
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_30 + &HB50)
                    WriteMii.WriteHexString(&H1E)
                Else
                    WriteMii.Position = (Traveler_30 + &HC20)
                    WriteMii.WriteHexString(&H1E)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                WriteMii.Position = Traveler_31
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_31 + &HB50)
                    WriteMii.WriteHexString(&H1F)
                Else
                    WriteMii.Position = (Traveler_31 + &HC20)
                    WriteMii.WriteHexString(&H1F)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                WriteMii.Position = Traveler_32
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_32 + &HB50)
                    WriteMii.WriteHexString(&H20)
                Else
                    WriteMii.Position = (Traveler_32 + &HC20)
                    WriteMii.WriteHexString(&H20)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                WriteMii.Position = Traveler_33
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_33 + &HB50)
                    WriteMii.WriteHexString(&H21)
                Else
                    WriteMii.Position = (Traveler_33 + &HC20)
                    WriteMii.WriteHexString(&H21)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                WriteMii.Position = Traveler_34
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_34 + &HB50)
                    WriteMii.WriteHexString(&H22)
                Else
                    WriteMii.Position = (Traveler_34 + &HC20)
                    WriteMii.WriteHexString(&H22)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                WriteMii.Position = Traveler_35
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_35 + &HB50)
                    WriteMii.WriteHexString(&H23)
                Else
                    WriteMii.Position = (Traveler_35 + &HC20)
                    WriteMii.WriteHexString(&H23)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                WriteMii.Position = Traveler_36
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_36 + &HB50)
                    WriteMii.WriteHexString(&H24)
                Else
                    WriteMii.Position = (Traveler_36 + &HC20)
                    WriteMii.WriteHexString(&H24)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                WriteMii.Position = Traveler_37
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_37 + &HB50)
                    WriteMii.WriteHexString(&H25)
                Else
                    WriteMii.Position = (Traveler_37 + &HC20)
                    WriteMii.WriteHexString(&H25)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                WriteMii.Position = Traveler_38
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_38 + &HB50)
                    WriteMii.WriteHexString(&H26)
                Else
                    WriteMii.Position = (Traveler_38 + &HC20)
                    WriteMii.WriteHexString(&H26)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                WriteMii.Position = Traveler_39
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_39 + &HB50)
                    WriteMii.WriteHexString(&H27)
                Else
                    WriteMii.Position = (Traveler_39 + &HC20)
                    WriteMii.WriteHexString(&H27)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                WriteMii.Position = Traveler_40
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_40 + &HB50)
                    WriteMii.WriteHexString(&H28)
                Else
                    WriteMii.Position = (Traveler_40 + &HC20)
                    WriteMii.WriteHexString(&H28)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                WriteMii.Position = Traveler_41
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_41 + &HB50)
                    WriteMii.WriteHexString(&H29)
                Else
                    WriteMii.Position = (Traveler_41 + &HC20)
                    WriteMii.WriteHexString(&H29)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                WriteMii.Position = Traveler_42
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_42 + &HB50)
                    WriteMii.WriteHexString(&H2A)
                Else
                    WriteMii.Position = (Traveler_42 + &HC20)
                    WriteMii.WriteHexString(&H2A)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                WriteMii.Position = Traveler_43
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_43 + &HB50)
                    WriteMii.WriteHexString(&H2B)
                Else
                    WriteMii.Position = (Traveler_43 + &HC20)
                    WriteMii.WriteHexString(&H2B)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                WriteMii.Position = Traveler_44
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_44 + &HB50)
                    WriteMii.WriteHexString(&H2C)
                Else
                    WriteMii.Position = (Traveler_44 + &HC20)
                    WriteMii.WriteHexString(&H2C)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                WriteMii.Position = Traveler_45
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_45 + &HB50)
                    WriteMii.WriteHexString(&H2D)
                Else
                    WriteMii.Position = (Traveler_45 + &HC20)
                    WriteMii.WriteHexString(&H2D)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                WriteMii.Position = Traveler_46
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_46 + &HB50)
                    WriteMii.WriteHexString(&H2E)
                Else
                    WriteMii.Position = (Traveler_46 + &HC20)
                    WriteMii.WriteHexString(&H2E)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                WriteMii.Position = Traveler_47
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_47 + &HB50)
                    WriteMii.WriteHexString(&H2F)
                Else
                    WriteMii.Position = (Traveler_47 + &HC20)
                    WriteMii.WriteHexString(&H2F)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                WriteMii.Position = Traveler_48
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_48 + &HB50)
                    WriteMii.WriteHexString(&H30)
                Else
                    WriteMii.Position = (Traveler_48 + &HC20)
                    WriteMii.WriteHexString(&H30)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                WriteMii.Position = Traveler_49
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_49 + &HB50)
                    WriteMii.WriteHexString(&H31)
                Else
                    WriteMii.Position = (Traveler_49 + &HC20)
                    WriteMii.WriteHexString(&H31)
                End If
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                WriteMii.Position = Traveler_50
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                If Filever_text.Text = "JP" Then
                    WriteMii.Position = (Traveler_50 + &HB50)
                    WriteMii.WriteHexString(&H32)
                Else
                    WriteMii.Position = (Traveler_50 + &HC20)
                    WriteMii.WriteHexString(&H32)
                End If
            End If
            TLSE_dialog.Text_TLSE_dialog.Text = "This Traveler has been successfully replace"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to replace this Travelers"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub RestoreMii()
        Try
            Dim WriteMii As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                WriteMii.Position = Traveler_1
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_1 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_1 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                WriteMii.Position = Traveler_2
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_2 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_2 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                WriteMii.Position = Traveler_3
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_3 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_3 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                WriteMii.Position = Traveler_4
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_4 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_4 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                WriteMii.Position = Traveler_5
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_5 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_5 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                WriteMii.Position = Traveler_6
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_6 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_6 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                WriteMii.Position = Traveler_7
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_7 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_7 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                WriteMii.Position = Traveler_8
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_8 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_8 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                WriteMii.Position = Traveler_9
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_9 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_9 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                WriteMii.Position = Traveler_10
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_10 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_10 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                WriteMii.Position = Traveler_11
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_11 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_11 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                WriteMii.Position = Traveler_12
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_12 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_12 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                WriteMii.Position = Traveler_13
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_13 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_13 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                WriteMii.Position = Traveler_14
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_14 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_14 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                WriteMii.Position = Traveler_15
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_15 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_15 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                WriteMii.Position = Traveler_16
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_16 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_16 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                WriteMii.Position = Traveler_17
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_17 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_17 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                WriteMii.Position = Traveler_18
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_18 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_18 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                WriteMii.Position = Traveler_19
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_19 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_19 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                WriteMii.Position = Traveler_20
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_20 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_20 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                WriteMii.Position = Traveler_21
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_21 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_21 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                WriteMii.Position = Traveler_22
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_22 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_22 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                WriteMii.Position = Traveler_23
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_23 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_23 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                WriteMii.Position = Traveler_24
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_24 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_24 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                WriteMii.Position = Traveler_25
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_25 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_25 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                WriteMii.Position = Traveler_26
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_26 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_26 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                WriteMii.Position = Traveler_27
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_27 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_27 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                WriteMii.Position = Traveler_28
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_28 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_28 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                WriteMii.Position = Traveler_29
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_29 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_29 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                WriteMii.Position = Traveler_30
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_30 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_30 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                WriteMii.Position = Traveler_31
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_31 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_31 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                WriteMii.Position = Traveler_32
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_32 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_32 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                WriteMii.Position = Traveler_33
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_33 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_33 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                WriteMii.Position = Traveler_34
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_34 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_34 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                WriteMii.Position = Traveler_35
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_35 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_35 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                WriteMii.Position = Traveler_36
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_36 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_36 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                WriteMii.Position = Traveler_37
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_37 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_37 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                WriteMii.Position = Traveler_38
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_38 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_38 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                WriteMii.Position = Traveler_39
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_39 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_39 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                WriteMii.Position = Traveler_40
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_40 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_40 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                WriteMii.Position = Traveler_41
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_41 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_41 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                WriteMii.Position = Traveler_42
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_42 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_42 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                WriteMii.Position = Traveler_43
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_43 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_43 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                WriteMii.Position = Traveler_44
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_44 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_44 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                WriteMii.Position = Traveler_45
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_45 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_45 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                WriteMii.Position = Traveler_46
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_46 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_46 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                WriteMii.Position = Traveler_47
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_47 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_47 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                WriteMii.Position = Traveler_48
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_48 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_48 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                WriteMii.Position = Traveler_49
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_49 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_49 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                WriteMii.Position = Traveler_50
                WriteMii.WriteHexString(Text_restore_Mii.Text)
                WriteMii.Position = (Traveler_50 + &H1E0)
                WriteMii.WriteHexString("0000000000000000000000000000000000000000")
                WriteMii.Position = (Traveler_50 + &H1E0)
                WriteMii.WriteUnicodeString(Text_restore_miiname.Text)
            End If
            TLSE_dialog.Text_TLSE_dialog.Text = "This Traveler has been successfully replace"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to replace this Travelers"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub
End Class