Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_travelers_status
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Miidetected As String
    Dim accessrelationship As String

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

    Private Sub TLSE_travelers_status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
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

    Private Sub Icon_arrowexp_right_MouseDown(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_right.MouseDown
        If valu_happiness.Value < 99 Then
            Timer_arrowexp_right.Start()
        End If
    End Sub

    Private Sub Timer_arrowexp_right_Tick(sender As Object, e As EventArgs) Handles Timer_arrowexp_right.Tick
        If valu_happiness.Value < 99 Then
            valu_happiness.Value = valu_happiness.Value + 1
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
        If valu_happiness.Value > 0 Then
            Timer_arrowexp_left.Start()
        End If
    End Sub

    Private Sub Timer_arrowexp_left_Tick(sender As Object, e As EventArgs) Handles Timer_arrowexp_left.Tick
        If valu_happiness.Value > 0 Then
            valu_happiness.Value = valu_happiness.Value - 1
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
        valu_happiness.Value = valu_happiness.Minimum
    End Sub

    Private Sub Icon_arrowexp_maxleft_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_maxleft.MouseMove
        Icon_arrowexp_maxleft.Image = My.Resources.icon_arrowexp_maxlefton
    End Sub

    Private Sub Icon_arrowexp_maxleft_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxleft.MouseLeave
        Icon_arrowexp_maxleft.Image = My.Resources.icon_arrowexp_maxleft
    End Sub

    Private Sub Icon_arrowexp_maxright_Click(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxright.Click
        valu_happiness.Value = valu_happiness.Maximum
    End Sub

    Private Sub Icon_arrowexp_maxright_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_maxright.MouseMove
        Icon_arrowexp_maxright.Image = My.Resources.icon_arrowexp_maxrighton
    End Sub

    Private Sub Icon_arrowexp_maxright_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxright.MouseLeave
        Icon_arrowexp_maxright.Image = My.Resources.icon_arrowexp_maxright
    End Sub

    Private Sub valu_happiness_ValueChanged(sender As Object, e As EventArgs) Handles valu_happiness.ValueChanged
        If valu_happiness.Value = 0 Then
            Icon_happiness.Image = My.Resources.expt0
        End If
        If valu_happiness.Value = 1 Then
            Icon_happiness.Image = My.Resources.expt1
        End If
        If valu_happiness.Value = 2 Then
            Icon_happiness.Image = My.Resources.expt2
        End If
        If valu_happiness.Value = 3 Then
            Icon_happiness.Image = My.Resources.expt3
        End If
        If valu_happiness.Value = 4 Then
            Icon_happiness.Image = My.Resources.expt4
        End If
        If valu_happiness.Value = 5 Then
            Icon_happiness.Image = My.Resources.expt5
        End If
        If valu_happiness.Value = 6 Then
            Icon_happiness.Image = My.Resources.expt6
        End If
        If valu_happiness.Value = 7 Then
            Icon_happiness.Image = My.Resources.expt7
        End If
        If valu_happiness.Value = 8 Then
            Icon_happiness.Image = My.Resources.expt8
        End If
        If valu_happiness.Value = 9 Then
            Icon_happiness.Image = My.Resources.expt9
        End If
        If valu_happiness.Value = 10 Then
            Icon_happiness.Image = My.Resources.expt10
        End If
        If valu_happiness.Value = 11 Then
            Icon_happiness.Image = My.Resources.expt11
        End If
        If valu_happiness.Value = 12 Then
            Icon_happiness.Image = My.Resources.expt12
        End If
        If valu_happiness.Value = 13 Then
            Icon_happiness.Image = My.Resources.expt13
        End If
        If valu_happiness.Value = 14 Then
            Icon_happiness.Image = My.Resources.expt14
        End If
        If valu_happiness.Value = 15 Then
            Icon_happiness.Image = My.Resources.expt15
        End If
        If valu_happiness.Value = 16 Then
            Icon_happiness.Image = My.Resources.expt16
        End If
        If valu_happiness.Value = 17 Then
            Icon_happiness.Image = My.Resources.expt17
        End If
        If valu_happiness.Value = 18 Then
            Icon_happiness.Image = My.Resources.expt18
        End If
        If valu_happiness.Value = 19 Then
            Icon_happiness.Image = My.Resources.expt19
        End If
        If valu_happiness.Value = 20 Then
            Icon_happiness.Image = My.Resources.expt20
        End If
        If valu_happiness.Value = 21 Then
            Icon_happiness.Image = My.Resources.expt21
        End If
        If valu_happiness.Value = 22 Then
            Icon_happiness.Image = My.Resources.expt22
        End If
        If valu_happiness.Value = 23 Then
            Icon_happiness.Image = My.Resources.expt23
        End If
        If valu_happiness.Value = 24 Then
            Icon_happiness.Image = My.Resources.expt24
        End If
        If valu_happiness.Value = 25 Then
            Icon_happiness.Image = My.Resources.expt25
        End If
        If valu_happiness.Value = 26 Then
            Icon_happiness.Image = My.Resources.expt26
        End If
        If valu_happiness.Value = 27 Then
            Icon_happiness.Image = My.Resources.expt27
        End If
        If valu_happiness.Value = 28 Then
            Icon_happiness.Image = My.Resources.expt28
        End If
        If valu_happiness.Value = 29 Then
            Icon_happiness.Image = My.Resources.expt29
        End If
        If valu_happiness.Value = 30 Then
            Icon_happiness.Image = My.Resources.expt30
        End If
        If valu_happiness.Value = 31 Then
            Icon_happiness.Image = My.Resources.expt31
        End If
        If valu_happiness.Value = 32 Then
            Icon_happiness.Image = My.Resources.expt32
        End If
        If valu_happiness.Value = 33 Then
            Icon_happiness.Image = My.Resources.expt33
        End If
        If valu_happiness.Value = 34 Then
            Icon_happiness.Image = My.Resources.expt34
        End If
        If valu_happiness.Value = 35 Then
            Icon_happiness.Image = My.Resources.expt35
        End If
        If valu_happiness.Value = 36 Then
            Icon_happiness.Image = My.Resources.expt36
        End If
        If valu_happiness.Value = 37 Then
            Icon_happiness.Image = My.Resources.expt37
        End If
        If valu_happiness.Value = 38 Then
            Icon_happiness.Image = My.Resources.expt38
        End If
        If valu_happiness.Value = 39 Then
            Icon_happiness.Image = My.Resources.expt39
        End If
        If valu_happiness.Value = 40 Then
            Icon_happiness.Image = My.Resources.expt40
        End If
        If valu_happiness.Value = 41 Then
            Icon_happiness.Image = My.Resources.expt41
        End If
        If valu_happiness.Value = 42 Then
            Icon_happiness.Image = My.Resources.expt42
        End If
        If valu_happiness.Value = 43 Then
            Icon_happiness.Image = My.Resources.expt43
        End If
        If valu_happiness.Value = 44 Then
            Icon_happiness.Image = My.Resources.expt44
        End If
        If valu_happiness.Value = 45 Then
            Icon_happiness.Image = My.Resources.expt45
        End If
        If valu_happiness.Value = 46 Then
            Icon_happiness.Image = My.Resources.expt46
        End If
        If valu_happiness.Value = 47 Then
            Icon_happiness.Image = My.Resources.expt47
        End If
        If valu_happiness.Value = 48 Then
            Icon_happiness.Image = My.Resources.expt48
        End If
        If valu_happiness.Value = 49 Then
            Icon_happiness.Image = My.Resources.expt49
        End If
        If valu_happiness.Value = 50 Then
            Icon_happiness.Image = My.Resources.expt50
        End If
        If valu_happiness.Value = 51 Then
            Icon_happiness.Image = My.Resources.expt51
        End If
        If valu_happiness.Value = 52 Then
            Icon_happiness.Image = My.Resources.expt52
        End If
        If valu_happiness.Value = 53 Then
            Icon_happiness.Image = My.Resources.expt53
        End If
        If valu_happiness.Value = 54 Then
            Icon_happiness.Image = My.Resources.expt54
        End If
        If valu_happiness.Value = 55 Then
            Icon_happiness.Image = My.Resources.expt55
        End If
        If valu_happiness.Value = 56 Then
            Icon_happiness.Image = My.Resources.expt56
        End If
        If valu_happiness.Value = 57 Then
            Icon_happiness.Image = My.Resources.expt57
        End If
        If valu_happiness.Value = 58 Then
            Icon_happiness.Image = My.Resources.expt58
        End If
        If valu_happiness.Value = 59 Then
            Icon_happiness.Image = My.Resources.expt59
        End If
        If valu_happiness.Value = 60 Then
            Icon_happiness.Image = My.Resources.expt60
        End If
        If valu_happiness.Value = 61 Then
            Icon_happiness.Image = My.Resources.expt61
        End If
        If valu_happiness.Value = 62 Then
            Icon_happiness.Image = My.Resources.expt62
        End If
        If valu_happiness.Value = 63 Then
            Icon_happiness.Image = My.Resources.expt63
        End If
        If valu_happiness.Value = 64 Then
            Icon_happiness.Image = My.Resources.expt64
        End If
        If valu_happiness.Value = 65 Then
            Icon_happiness.Image = My.Resources.expt65
        End If
        If valu_happiness.Value = 66 Then
            Icon_happiness.Image = My.Resources.expt66
        End If
        If valu_happiness.Value = 67 Then
            Icon_happiness.Image = My.Resources.expt67
        End If
        If valu_happiness.Value = 68 Then
            Icon_happiness.Image = My.Resources.expt68
        End If
        If valu_happiness.Value = 69 Then
            Icon_happiness.Image = My.Resources.expt69
        End If
        If valu_happiness.Value = 70 Then
            Icon_happiness.Image = My.Resources.expt70
        End If
        If valu_happiness.Value = 71 Then
            Icon_happiness.Image = My.Resources.expt71
        End If
        If valu_happiness.Value = 72 Then
            Icon_happiness.Image = My.Resources.expt72
        End If
        If valu_happiness.Value = 73 Then
            Icon_happiness.Image = My.Resources.expt73
        End If
        If valu_happiness.Value = 74 Then
            Icon_happiness.Image = My.Resources.expt74
        End If
        If valu_happiness.Value = 75 Then
            Icon_happiness.Image = My.Resources.expt75
        End If
        If valu_happiness.Value = 76 Then
            Icon_happiness.Image = My.Resources.expt76
        End If
        If valu_happiness.Value = 77 Then
            Icon_happiness.Image = My.Resources.expt77
        End If
        If valu_happiness.Value = 78 Then
            Icon_happiness.Image = My.Resources.expt78
        End If
        If valu_happiness.Value = 79 Then
            Icon_happiness.Image = My.Resources.expt79
        End If
        If valu_happiness.Value = 80 Then
            Icon_happiness.Image = My.Resources.expt80
        End If
        If valu_happiness.Value = 81 Then
            Icon_happiness.Image = My.Resources.expt81
        End If
        If valu_happiness.Value = 82 Then
            Icon_happiness.Image = My.Resources.expt82
        End If
        If valu_happiness.Value = 83 Then
            Icon_happiness.Image = My.Resources.expt83
        End If
        If valu_happiness.Value = 84 Then
            Icon_happiness.Image = My.Resources.expt84
        End If
        If valu_happiness.Value = 85 Then
            Icon_happiness.Image = My.Resources.expt85
        End If
        If valu_happiness.Value = 86 Then
            Icon_happiness.Image = My.Resources.expt86
        End If
        If valu_happiness.Value = 87 Then
            Icon_happiness.Image = My.Resources.expt87
        End If
        If valu_happiness.Value = 88 Then
            Icon_happiness.Image = My.Resources.expt88
        End If
        If valu_happiness.Value = 89 Then
            Icon_happiness.Image = My.Resources.expt89
        End If
        If valu_happiness.Value = 90 Then
            Icon_happiness.Image = My.Resources.expt90
        End If
        If valu_happiness.Value = 91 Then
            Icon_happiness.Image = My.Resources.expt91
        End If
        If valu_happiness.Value = 92 Then
            Icon_happiness.Image = My.Resources.expt92
        End If
        If valu_happiness.Value = 93 Then
            Icon_happiness.Image = My.Resources.expt93
        End If
        If valu_happiness.Value = 94 Then
            Icon_happiness.Image = My.Resources.expt94
        End If
        If valu_happiness.Value = 95 Then
            Icon_happiness.Image = My.Resources.expt95
        End If
        If valu_happiness.Value = 96 Then
            Icon_happiness.Image = My.Resources.expt96
        End If
        If valu_happiness.Value = 97 Then
            Icon_happiness.Image = My.Resources.expt97
        End If
        If valu_happiness.Value = 98 Then
            Icon_happiness.Image = My.Resources.expt98
        End If
        If valu_happiness.Value = 99 Then
            Icon_happiness.Image = My.Resources.expt99
        End If
    End Sub

    Private Sub valu_onisland_ValueChanged(sender As Object, e As EventArgs) Handles valu_onisland.ValueChanged
        If valu_onisland.Value = 0 Then
            Select_onisland.SelectedItem = Select_onisland.Items.Item(0)
        ElseIf valu_onisland.Value = 1 Then
            Select_onisland.SelectedItem = Select_onisland.Items.Item(1)
        End If
    End Sub

    Private Sub valu_pitchtent_ValueChanged(sender As Object, e As EventArgs) Handles valu_pitchtent.ValueChanged
        If valu_pitchtent.Value = 0 Then
            Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(0)
        ElseIf valu_pitchtent.Value = 1 Then
            Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(1)
        End If
    End Sub

    Private Sub valu_permissionpitch_ValueChanged(sender As Object, e As EventArgs) Handles valu_permissionpitch.ValueChanged
        If valu_permissionpitch.Value = 0 Then
            Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(0)
        ElseIf valu_permissionpitch.Value = 1 Then
            Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(1)
        End If
    End Sub

    Private Sub valu_departport_ValueChanged(sender As Object, e As EventArgs) Handles valu_departport.ValueChanged
        If valu_departport.Value = 0 Then
            Select_departport.SelectedItem = Select_departport.Items.Item(0)
        ElseIf valu_departport.Value = 1 Then
            Select_departport.SelectedItem = Select_departport.Items.Item(1)
        End If
    End Sub

    Private Sub valu_visibleport_ValueChanged(sender As Object, e As EventArgs) Handles valu_visibleport.ValueChanged
        If valu_visibleport.Value = 0 Then
            Select_visibleport.SelectedItem = Select_visibleport.Items.Item(0)
        ElseIf valu_visibleport.Value = 1 Then
            Select_visibleport.SelectedItem = Select_visibleport.Items.Item(1)
        End If
    End Sub

    Private Sub valu_newicon_ValueChanged(sender As Object, e As EventArgs) Handles valu_newicon.ValueChanged
        If valu_newicon.Value = 0 Then
            Select_newicon.SelectedItem = Select_newicon.Items.Item(0)
        ElseIf valu_newicon.Value = 1 Then
            Select_newicon.SelectedItem = Select_newicon.Items.Item(1)
        End If
    End Sub

    Private Sub valu_wandering_ValueChanged(sender As Object, e As EventArgs) Handles valu_wandering.ValueChanged
        If valu_wandering.Value = 0 Then
            Select_wandering.SelectedItem = Select_wandering.Items.Item(0)
        ElseIf valu_wandering.Value = 1 Then
            Select_wandering.SelectedItem = Select_wandering.Items.Item(1)
        End If
    End Sub

    Private Sub valu_startconversation_ValueChanged(sender As Object, e As EventArgs) Handles valu_startconversation.ValueChanged
        If valu_startconversation.Value = 0 Then
            Select_startconversation.SelectedItem = Select_startconversation.Items.Item(0)
        ElseIf valu_startconversation.Value = 1 Then
            Select_startconversation.SelectedItem = Select_startconversation.Items.Item(1)
        End If
    End Sub

    Private Sub valu_justarrive_ValueChanged(sender As Object, e As EventArgs) Handles valu_justarrive.ValueChanged
        If valu_justarrive.Value = 0 Then
            Select_justarrive.SelectedItem = Select_justarrive.Items.Item(0)
        ElseIf valu_justarrive.Value = 1 Then
            Select_justarrive.SelectedItem = Select_justarrive.Items.Item(1)
        End If
    End Sub

    Private Sub Select_onisland_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_onisland.SelectedIndexChanged
        If Select_onisland.SelectedItem = Select_onisland.Items.Item(0) Then
            valu_onisland.Value = 0
        ElseIf Select_onisland.SelectedItem = Select_onisland.Items.Item(1) Then
            valu_onisland.Value = 1
        End If
    End Sub

    Private Sub Select_pitchtent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_pitchtent.SelectedIndexChanged
        If Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(0) Then
            valu_pitchtent.Value = 0
        ElseIf Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(1) Then
            valu_pitchtent.Value = 1
        End If
    End Sub

    Private Sub Select_permissionpitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_permissionpitch.SelectedIndexChanged
        If Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(0) Then
            valu_permissionpitch.Value = 0
        ElseIf Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(1) Then
            valu_permissionpitch.Value = 1
        End If
    End Sub

    Private Sub Select_departport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_departport.SelectedIndexChanged
        If Select_departport.SelectedItem = Select_departport.Items.Item(0) Then
            valu_departport.Value = 0
        ElseIf Select_departport.SelectedItem = Select_departport.Items.Item(1) Then
            valu_departport.Value = 1
        End If
    End Sub

    Private Sub Select_visibleport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_visibleport.SelectedIndexChanged
        If Select_visibleport.SelectedItem = Select_visibleport.Items.Item(0) Then
            valu_visibleport.Value = 0
        ElseIf Select_visibleport.SelectedItem = Select_visibleport.Items.Item(1) Then
            valu_visibleport.Value = 1
        End If
    End Sub

    Private Sub Select_newicon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_newicon.SelectedIndexChanged
        If Select_newicon.SelectedItem = Select_newicon.Items.Item(0) Then
            valu_newicon.Value = 0
        ElseIf Select_newicon.SelectedItem = Select_newicon.Items.Item(1) Then
            valu_newicon.Value = 1
        End If
    End Sub

    Private Sub Select_wandering_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_wandering.SelectedIndexChanged
        If Select_wandering.SelectedItem = Select_wandering.Items.Item(0) Then
            valu_wandering.Value = 0
        ElseIf Select_wandering.SelectedItem = Select_wandering.Items.Item(1) Then
            valu_wandering.Value = 1
        End If
    End Sub

    Private Sub Select_startconversation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_startconversation.SelectedIndexChanged
        If Select_startconversation.SelectedItem = Select_startconversation.Items.Item(0) Then
            valu_startconversation.Value = 0
        ElseIf Select_startconversation.SelectedItem = Select_startconversation.Items.Item(1) Then
            valu_startconversation.Value = 1
        End If
    End Sub

    Private Sub Select_justarrive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_justarrive.SelectedIndexChanged
        If Select_justarrive.SelectedItem = Select_justarrive.Items.Item(0) Then
            valu_justarrive.Value = 0
        ElseIf Select_justarrive.SelectedItem = Select_justarrive.Items.Item(1) Then
            valu_justarrive.Value = 1
        End If
    End Sub

    Private Sub Button_wandering_Click(sender As Object, e As EventArgs) Handles Button_wandering.Click
        valu_lastdatetraveler.Value = valu_lastsavedate.Value
        valu_onisland.Value = 1
        valu_pitchtent.Value = 1
        valu_permissionpitch.Value = 2
        valu_departport.Value = 0
        valu_visibleport.Value = 0
        valu_newicon.Value = 0
        valu_wandering.Value = 1
        valu_startconversation.Value = 0
        valu_justarrive.Value = 0
    End Sub
End Class