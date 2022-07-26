Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_creaislandranking
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String

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
        addsymbol()
    End Sub

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_datacreation.Visible = True
        Me.Close()
    End Sub

    Private Sub Warning_islandaddress_Click(sender As Object, e As EventArgs) Handles Warning_islandaddress.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Warning : Edit in hexadecimal and enter max characters"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Attention : Editez en hexadécimal et entrez un maximum de caractères"
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Private Sub Text_spesymb_islandname_cancel_Click(sender As Object, e As EventArgs) Handles Text_spesymb_islandname_cancel.Click
        Panel_addsymb_islandname.Visible = False
    End Sub

    Private Sub Addsymbol_islandname_Click(sender As Object, e As EventArgs) Handles Addsymbol_islandname.Click
        Panel_addsymb_islandname.Visible = True
        Text_spesymb_add_islandname_n.Visible = True
        Text_spesymb_add_islandname_pn.Visible = False
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

    Private Sub Fea_yrislandinfo_Click(sender As Object, e As EventArgs) Handles Fea_yrislandinfo.Click
        Try
            Dim Readdata As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Readdata.Position = &H20
            Text_islandaddress.Text = Readdata.ReadHexString(16)
            If Filever_text.Text = "JP" Then
                Readdata.Position = &H14BCBC
                Text_islandname.Text = Readdata.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "KR" Then
                Readdata.Position = &H1EFF7C
                Text_islandname.Text = Readdata.ReadUnicodeString(10)
            Else
                Readdata.Position = &H1E4BCC
                Text_islandname.Text = Readdata.ReadUnicodeString(10)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read your island informations"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Échec de la lecture des informations de votre île"
            End If
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Tomodachi Life island ranking|*.tlislandranking"
            SaveFileDialog1.FileName = Text_islandname.Text & "_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_dataislandranking.Text)
                Writer.Position = &H0
                Writer.WriteHexString(Text_islandaddress.Text)
                Writer.Position = &H10
                Writer.WriteUnicodeString(Text_islandname.Text)
                Writer.Position = &H26
                Writer.WriteUInt16(valu_starisland.Value)
                TLSE_dialog.Text_TLSE_dialog.Text = "Tomodachi Life island ranking file has been successfully created"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to create Tomodachi Life island ranking file"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub addsymbol()
        If Setting_spesymb.Checked = True Then
            Panel_bspesymb.Visible = True
            Addsymbol_islandname.Visible = True
        End If
    End Sub
End Class