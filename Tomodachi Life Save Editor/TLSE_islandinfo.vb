Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_islandinfo
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Money As String
    Dim IslandName As String
    Dim IslandPronun As String
    Dim Problemsolved As String
    Dim Weddings As String
    Dim Childrenborn As String
    Dim Travelreceived As String
    Dim StreetPassencount As String
    Dim Travelsent As String
    Dim Islandaddress As String
    Dim itemsent As String
    Dim itemcolor As String

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

    Private Sub TLSE_islandinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Savefileregion()
        Switchfilever()
        addsymbol()
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

    Private Sub Icon_problemsolved_Click(sender As Object, e As EventArgs) Handles Icon_problemsolved.Click
        valu_problemsolved.Value = valu_problemsolved.Maximum
    End Sub

    Private Sub Icon_streetpassencounters_Click(sender As Object, e As EventArgs) Handles Icon_streetpassencounters.Click
        valu_streetpassencounters.Value = valu_streetpassencounters.Maximum
    End Sub

    Private Sub Icon_weddings_Click(sender As Object, e As EventArgs) Handles Icon_weddings.Click
        valu_weddings.Value = valu_weddings.Maximum
    End Sub

    Private Sub Icon_childrenborn_Click(sender As Object, e As EventArgs) Handles Icon_childrenborn.Click
        valu_childrenborn.Value = valu_childrenborn.Maximum
    End Sub

    Private Sub Icon_travelersreceived_Click(sender As Object, e As EventArgs) Handles Icon_travelersreceived.Click
        valu_travelersreceived.Value = valu_travelersreceived.Maximum
    End Sub

    Private Sub Icon_travelerssent_Click(sender As Object, e As EventArgs) Handles Icon_travelerssent.Click
        valu_travelerssent.Value = valu_travelerssent.Maximum
    End Sub

    Private Sub Icon_money_Click(sender As Object, e As EventArgs) Handles Icon_money.Click
        valu_money.Value = valu_money.Maximum
    End Sub

    Private Sub Text_spesymb_islandname_cancel_Click(sender As Object, e As EventArgs) Handles Text_spesymb_islandname_cancel.Click
        Panel_addsymb_islandname.Visible = False
    End Sub

    Private Sub Addsymbol_islandname_Click(sender As Object, e As EventArgs) Handles Addsymbol_islandname.Click
        Panel_addsymb_islandname.Visible = True
        Text_spesymb_add_islandname_n.Visible = True
        Text_spesymb_add_islandname_pn.Visible = False
    End Sub

    Private Sub Addsymbol_pronun_island_Click(sender As Object, e As EventArgs) Handles Addsymbol_pronun_island.Click
        Panel_addsymb_islandname.Visible = True
        Text_spesymb_add_islandname_n.Visible = False
        Text_spesymb_add_islandname_pn.Visible = True
    End Sub

    Private Sub Select_spesymb_islandname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_spesymb_islandname.SelectedIndexChanged
        If Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(0) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(1) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(2) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(3) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(4) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(5) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(6) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(7) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(8) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(9) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(10) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(11) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(12) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(13) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(14) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(15) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(16) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(17) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(18) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(19) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(20) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(21) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(22) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(23) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(24) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(25) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(26) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(27) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(28) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(29) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(30) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(31) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(32) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(33) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(34) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(35) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(36) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(37) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(38) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(39) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(40) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(41) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(42) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(43) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(44) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(45) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(46) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(47) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(48) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(49) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(50) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(51) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(52) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(53) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(54) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(55) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(56) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(57) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(58) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(59) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(60) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(61) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(62) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(63) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(64) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(65) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(66) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(67) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(68) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(69) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(70) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(71) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(72) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(73) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(74) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(75) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(76) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(77) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(78) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(79) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(80) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(81) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(82) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(83) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(84) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(85) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(86) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(87) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(88) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(89) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(90) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(91) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(92) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(93) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(94) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(95) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(96) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(97) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(98) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(99) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(100) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(101) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(102) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(103) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(104) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(105) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(106) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(107) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(108) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(109) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(110) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(111) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(112) Then
            Text_spesymb_islandname.Text = ""
        ElseIf Select_spesymb_islandname.SelectedItem = Select_spesymb_islandname.Items.Item(113) Then
            Text_spesymb_islandname.Text = ""
        End If
    End Sub

    Private Sub Text_spesymb_add_islandname_pn_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_islandname_pn.Click
        If Text_pronun_island.TextLength < 20 Then
            Text_pronun_island.Text = Text_pronun_island.Text & Text_spesymb_islandname.Text
            Panel_addsymb_islandname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_islandname.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_add_islandname_n_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_islandname_n.Click
        If Text_islandname.TextLength < 10 Then
            Text_islandname.Text = Text_islandname.Text & Text_spesymb_islandname.Text
            Panel_addsymb_islandname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_islandname.Visible = False
        End If
    End Sub

    Private Sub Warning_islandaddress_Click(sender As Object, e As EventArgs) Handles Warning_islandaddress.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Some values can corrupt save file but this feature can be edited as you want" & vbNewLine & vbNewLine & "If your save is corrupted after has been restored, restore previous save file from ''Backup'' folder" & vbNewLine & vbNewLine & "Warning : Edit in hexadecimal and enter max characters"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Certaines valeurs peuvent corrompre le fichier de sauvegarde, mais cette fonctionnalité peut être modifiée à votre guise " & vbNewLine & vbNewLine & " Si votre sauvegarde est corrompue après avoir été restaurée, restaurez le fichier de sauvegarde précédent à partir du dossier ''Backup''" & vbNewLine & vbNewLine & "Attention : Editez en hexadécimal et entrez un maximum de caractères"
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Private Sub Warning_islandname_Click(sender As Object, e As EventArgs) Handles Warning_islandname.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "If you add a special symbol, island name will be '???' in the data of a crossed Mii via StreetPass"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Si vous ajoutez un symbole spécial, le nom de votre île sera '???' dans les donnés d'un Mii croisé via StreetPass"
        End If
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub Icon_islandn_pronun_val_Click(sender As Object, e As EventArgs) Handles Icon_islandn_pronun_val.Click
        Panel_edit_pronun_island.Visible = False
        Text_pronun_islandname.Text = Text_pronun_island.Text
        AdvH_islandnamepronun.Visible = False
        Addsymbol_pronun_island.Visible = False
    End Sub

    Private Sub Icon_pronun_islandname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.Click
        Text_pronun_island.Text = Text_pronun_islandname.Text
        Panel_edit_pronun_island.Visible = True
        If Setting_Advhelp.Checked = True Then
            AdvH_islandnamepronun.Visible = True
        End If
        If Setting_spesymb.Checked = True Then
            Addsymbol_pronun_island.Visible = True
        End If
    End Sub

    Private Sub Icon_pronun_islandname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseMove
        Text_pronun_islandname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit island's name pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du nom de l'île"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_islandname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseLeave
        Text_pronun_islandname.Visible = False
        Panel_description.Visible = False
    End Sub

    Public Sub Savefileregion()
        If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
            Money = &H1E4BB8
            IslandName = &H1E4BCC
            IslandPronun = &H1E4BF6
            Problemsolved = &H1E4BC6
            Weddings = &H1E4BC0
            Childrenborn = &H1E4BC2
            Travelreceived = &H1E4BBE
            StreetPassencount = &H1E4BBC
            Travelsent = &H1E4BC4
            Islandaddress = &H20
            itemcolor = &H1E4BEA
            itemsent = &H1E4BE8
        ElseIf Filever_text.Text = "JP" Then
            Money = &H14BCA8
            IslandName = &H14BCBC
            Problemsolved = &H14BCB6
            Weddings = &H14BCB0
            Childrenborn = &H14BCB2
            Travelreceived = &H14BCAE
            StreetPassencount = &H14BCAC
            Travelsent = &H14BCB4
            Islandaddress = &H20
            itemcolor = &H14BCD8
            itemsent = &H14BCD6
            Icon_pronun_islandname.Visible = False
        ElseIf Filever_text.Text = "KR" Then
            Money = &H1EFF68
            IslandName = &H1EFF7C
            IslandPronun = &H1EFFA6
            Problemsolved = &H1EFF76
            Weddings = &H1EFF70
            Childrenborn = &H1EFF72
            Travelreceived = &H1EFF6E
            StreetPassencount = &H1EFF6C
            Travelsent = &H1EFF74
            Islandaddress = &H20
            itemcolor = &H1EFF9A
            itemsent = &H1EFF98
        End If
    End Sub

    Private Sub Warning_itemsent_Click(sender As Object, e As EventArgs) Handles Warning_itemsent.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Item not listed, if you edit with a wrong value save file will be corrupted"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Objet non listé, si vous éditez avec une mauvaise valeur la sauvegarde sera corrompu"
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Private Sub Warning_itemcolor_Click(sender As Object, e As EventArgs) Handles Warning_itemcolor.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Edit only with a valid color or save file will be corrupted (item can have only 5 colors for example => if have 5 colors, don't select color n°6)"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Éditez seulement avec une couleur valide sinon la sauvegarde sera corrompu (un objet peu avoir 5 couleurs par exemple => si il a 5 couleurs, ne pas sélectionner la couleur n°6"
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Private Sub TLSE_islandinfo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Readislandinfo()
    End Sub

    Public Sub Readislandinfo()
        Try
            Dim Readdata As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Readdata.Position = Money
            valu_money.Value = Readdata.ReadUInt32
            Readdata.Position = IslandName
            Text_islandname.Text = Readdata.ReadUnicodeString(10)
            If Filever_text.Text = "JP" Then
            Else
                Readdata.Position = IslandPronun
                Text_pronun_islandname.Text = Readdata.ReadUnicodeString(20)
            End If
            Readdata.Position = Problemsolved
            valu_problemsolved.Value = Readdata.ReadUInt16
            Readdata.Position = Weddings
            valu_weddings.Value = Readdata.ReadUInt16
            Readdata.Position = Childrenborn
            valu_childrenborn.Value = Readdata.ReadUInt16
            Readdata.Position = Travelreceived
            valu_travelersreceived.Value = Readdata.ReadUInt16
            Readdata.Position = StreetPassencount
            valu_streetpassencounters.Value = Readdata.ReadUInt16
            Readdata.Position = Travelsent
            valu_travelerssent.Value = Readdata.ReadUInt16
            Readdata.Position = Islandaddress
            Text_islandaddress.Text = Readdata.ReadHexString(16)
            Readdata.Position = itemsent
            valu_itemsent.Value = Readdata.ReadUInt16
            Readdata.Position = itemcolor
            valu_itemcolor.Value = Readdata.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read island informations"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture des informations de l'île a échoué"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub Hideitemcolor()
        Icon_itemcolor_1.Image = My.Resources.icon_colorvariation_empty
        Icon_itemcolor_2.Image = My.Resources.icon_colorvariation_empty
        Icon_itemcolor_3.Image = My.Resources.icon_colorvariation_empty
        Icon_itemcolor_4.Image = My.Resources.icon_colorvariation_empty
        Icon_itemcolor_5.Image = My.Resources.icon_colorvariation_empty
        Icon_itemcolor_6.Image = My.Resources.icon_colorvariation_empty
        Icon_itemcolor_7.Image = My.Resources.icon_colorvariation_empty
        Icon_itemcolor_8.Image = My.Resources.icon_colorvariation_empty
    End Sub

    Private Sub valu_itemcolor_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemcolor.ValueChanged
        Hideitemcolor()
        If valu_itemcolor.Value = &H80 Then
            Icon_itemcolor_1.Image = My.Resources.icon_colorvariation_selected
        ElseIf valu_itemcolor.Value = &H40 Then
            Icon_itemcolor_2.Image = My.Resources.icon_colorvariation_selected
        ElseIf valu_itemcolor.Value = &H20 Then
            Icon_itemcolor_3.Image = My.Resources.icon_colorvariation_selected
        ElseIf valu_itemcolor.Value = &H10 Then
            Icon_itemcolor_4.Image = My.Resources.icon_colorvariation_selected
        ElseIf valu_itemcolor.Value = &H8 Then
            Icon_itemcolor_5.Image = My.Resources.icon_colorvariation_selected
        ElseIf valu_itemcolor.Value = &H4 Then
            Icon_itemcolor_6.Image = My.Resources.icon_colorvariation_selected
        ElseIf valu_itemcolor.Value = &H2 Then
            Icon_itemcolor_7.Image = My.Resources.icon_colorvariation_selected
        ElseIf valu_itemcolor.Value = &H1 Then
            Icon_itemcolor_8.Image = My.Resources.icon_colorvariation_selected
        End If
    End Sub

    Private Sub Icon_itemcolor_1_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_1.Click
        valu_itemcolor.Value = &H80
    End Sub

    Private Sub Icon_itemcolor_2_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_2.Click
        valu_itemcolor.Value = &H40
    End Sub

    Private Sub Icon_itemcolor_3_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_3.Click
        valu_itemcolor.Value = &H20
    End Sub

    Private Sub Icon_itemcolor_4_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_4.Click
        valu_itemcolor.Value = &H10
    End Sub

    Private Sub Icon_itemcolor_5_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_5.Click
        valu_itemcolor.Value = &H8
    End Sub

    Private Sub Icon_itemcolor_6_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_6.Click
        valu_itemcolor.Value = &H4
    End Sub

    Private Sub Icon_itemcolor_7_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_7.Click
        valu_itemcolor.Value = &H2
    End Sub

    Private Sub Icon_itemcolor_8_Click(sender As Object, e As EventArgs) Handles Icon_itemcolor_8.Click
        valu_itemcolor.Value = &H1
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Writeislandinfo()
    End Sub

    Public Sub Writeislandinfo()
        Try
            Dim Writedata As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writedata.Position = Money
            Writedata.WriteUInt32(valu_money.Value)
            For i As Integer = 0 To 19
                Writedata.Position = IslandName + i
                Writedata.WriteInt8(0)
            Next
            Writedata.Position = IslandName
            Writedata.WriteUnicodeString(Text_islandname.Text)
            If Filever_text.Text = "JP" Then
            Else
                For i As Integer = 0 To 39
                    Writedata.Position = IslandPronun + i
                    Writedata.WriteInt8(0)
                Next
                Writedata.Position = IslandPronun
                Writedata.WriteUnicodeString(Text_pronun_islandname.Text)
            End If
            Writedata.Position = Problemsolved
            Writedata.WriteUInt16(valu_problemsolved.Value)
            Writedata.Position = Weddings
            Writedata.WriteUInt16(valu_weddings.Value)
            Writedata.Position = Childrenborn
            Writedata.WriteUInt16(valu_childrenborn.Value)
            Writedata.Position = Travelreceived
            Writedata.WriteUInt16(valu_travelersreceived.Value)
            Writedata.Position = StreetPassencount
            Writedata.WriteUInt16(valu_streetpassencounters.Value)
            Writedata.Position = Travelsent
            Writedata.WriteUInt16(valu_travelerssent.Value)
            Writedata.Position = Islandaddress
            Writedata.WriteHexString(Text_islandaddress.Text)
            Writedata.Position = itemsent
            Writedata.WriteUInt16(valu_itemsent.Value)
            Writedata.Flush()
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = itemcolor
            fs.WriteByte(valu_itemcolor.Value)
            fs.Flush()
            TLSE_dialog.Text_TLSE_dialog.Text = "Island informations has been successfully edited"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to write island informations"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_islandedit.Visible = True
        Me.Close()
    End Sub

    Public Sub addsymbol()
        If Setting_spesymb.Checked = True Then
            Panel_bspesymb.Visible = True
            Addsymbol_islandname.Visible = True
        End If
    End Sub
End Class