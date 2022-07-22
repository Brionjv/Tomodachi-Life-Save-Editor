Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_miiprofile
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

    Private Sub TLSE_miiprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'Savefileregion()
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

    Private Sub Text_spesymb_firstname_cancel_Click(sender As Object, e As EventArgs) Handles Text_spesymb_firstname_cancel.Click
        Panel_addsymb_firstname.Visible = False
    End Sub

    Private Sub Addsymbol_firstname_Click(sender As Object, e As EventArgs) Handles Addsymbol_firstname.Click
        Panel_addsymb_firstname.Visible = True
        Text_spesymb_add_firstname_n.Visible = True
        Text_spesymb_add_firstname_pn.Visible = False
    End Sub

    Private Sub Addsymbol_pronun_firstname_Click(sender As Object, e As EventArgs) Handles Addsymbol_pronun_firstname.Click
        Panel_addsymb_firstname.Visible = True
        Text_spesymb_add_firstname_n.Visible = False
        Text_spesymb_add_firstname_pn.Visible = True
    End Sub

    Private Sub Select_spesymb_firstname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_spesymb_firstname.SelectedIndexChanged
        If Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(0) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(1) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(2) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(3) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(4) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(5) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(6) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(7) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(8) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(9) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(10) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(11) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(12) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(13) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(14) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(15) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(16) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(17) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(18) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(19) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(20) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(21) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(22) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(23) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(24) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(25) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(26) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(27) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(28) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(29) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(30) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(31) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(32) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(33) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(34) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(35) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(36) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(37) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(38) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(39) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(40) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(41) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(42) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(43) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(44) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(45) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(46) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(47) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(48) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(49) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(50) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(51) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(52) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(53) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(54) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(55) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(56) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(57) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(58) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(59) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(60) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(61) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(62) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(63) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(64) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(65) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(66) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(67) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(68) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(69) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(70) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(71) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(72) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(73) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(74) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(75) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(76) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(77) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(78) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(79) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(80) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(81) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(82) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(83) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(84) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(85) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(86) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(87) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(88) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(89) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(90) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(91) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(92) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(93) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(94) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(95) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(96) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(97) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(98) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(99) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(100) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(101) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(102) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(103) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(104) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(105) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(106) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(107) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(108) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(109) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(110) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(111) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(112) Then
            Text_spesymb_firstname.Text = ""
        ElseIf Select_spesymb_firstname.SelectedItem = Select_spesymb_firstname.Items.Item(113) Then
            Text_spesymb_firstname.Text = ""
        End If
    End Sub

    Private Sub Text_spesymb_add_firstname_pn_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_firstname_pn.Click
        If Text_edit_pronun_firstname.TextLength < 20 Then
            Text_edit_pronun_firstname.Text = Text_edit_pronun_firstname.Text & Text_spesymb_firstname.Text
            Panel_addsymb_firstname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_firstname.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_add_firstname_n_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_firstname_n.Click
        If Text_firstname.TextLength < 10 Then
            Text_firstname.Text = Text_firstname.Text & Text_spesymb_firstname.Text
            Panel_addsymb_firstname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_firstname.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_lastname_cancel_Click(sender As Object, e As EventArgs) Handles Text_spesymb_lastname_cancel.Click
        Panel_addsymb_lastname.Visible = False
    End Sub

    Private Sub Addsymbol_lastname_Click(sender As Object, e As EventArgs) Handles Addsymbol_lastname.Click
        Panel_addsymb_lastname.Visible = True
        Text_spesymb_add_lastname_n.Visible = True
        Text_spesymb_add_lastname_pn.Visible = False
    End Sub

    Private Sub Addsymbol_pronun_lastname_Click(sender As Object, e As EventArgs) Handles Addsymbol_pronun_lastname.Click
        Panel_addsymb_lastname.Visible = True
        Text_spesymb_add_lastname_n.Visible = False
        Text_spesymb_add_lastname_pn.Visible = True
    End Sub

    Private Sub Select_spesymb_lastname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_spesymb_lastname.SelectedIndexChanged
        If Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(0) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(1) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(2) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(3) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(4) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(5) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(6) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(7) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(8) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(9) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(10) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(11) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(12) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(13) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(14) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(15) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(16) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(17) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(18) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(19) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(20) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(21) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(22) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(23) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(24) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(25) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(26) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(27) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(28) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(29) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(30) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(31) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(32) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(33) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(34) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(35) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(36) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(37) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(38) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(39) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(40) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(41) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(42) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(43) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(44) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(45) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(46) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(47) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(48) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(49) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(50) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(51) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(52) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(53) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(54) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(55) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(56) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(57) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(58) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(59) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(60) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(61) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(62) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(63) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(64) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(65) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(66) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(67) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(68) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(69) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(70) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(71) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(72) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(73) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(74) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(75) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(76) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(77) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(78) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(79) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(80) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(81) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(82) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(83) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(84) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(85) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(86) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(87) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(88) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(89) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(90) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(91) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(92) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(93) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(94) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(95) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(96) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(97) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(98) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(99) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(100) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(101) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(102) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(103) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(104) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(105) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(106) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(107) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(108) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(109) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(110) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(111) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(112) Then
            Text_spesymb_lastname.Text = ""
        ElseIf Select_spesymb_lastname.SelectedItem = Select_spesymb_lastname.Items.Item(113) Then
            Text_spesymb_lastname.Text = ""
        End If
    End Sub

    Private Sub Text_spesymb_add_lastname_pn_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_lastname_pn.Click
        If Text_edit_pronun_lastname.TextLength < 20 Then
            Text_edit_pronun_lastname.Text = Text_edit_pronun_lastname.Text & Text_spesymb_lastname.Text
            Panel_addsymb_lastname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_lastname.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_add_lastname_n_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_lastname_n.Click
        If Text_lastname.TextLength < 10 Then
            Text_lastname.Text = Text_lastname.Text & Text_spesymb_lastname.Text
            Panel_addsymb_lastname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_lastname.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_nickname_cancel_Click(sender As Object, e As EventArgs) Handles Text_spesymb_nickname_cancel.Click
        Panel_addsymb_nickname.Visible = False
    End Sub

    Private Sub Addsymbol_nickname_Click(sender As Object, e As EventArgs) Handles Addsymbol_nickname.Click
        Panel_addsymb_nickname.Visible = True
        Text_spesymb_add_nickname_n.Visible = True
        Text_spesymb_add_nickname_pn.Visible = False
    End Sub

    Private Sub Addsymbol_pronun_nickname_Click(sender As Object, e As EventArgs) Handles Addsymbol_pronun_nickname.Click
        Panel_addsymb_nickname.Visible = True
        Text_spesymb_add_nickname_n.Visible = False
        Text_spesymb_add_nickname_pn.Visible = True
    End Sub

    Private Sub Select_spesymb_nickname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_spesymb_nickname.SelectedIndexChanged
        If Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(0) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(1) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(2) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(3) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(4) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(5) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(6) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(7) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(8) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(9) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(10) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(11) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(12) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(13) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(14) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(15) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(16) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(17) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(18) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(19) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(20) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(21) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(22) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(23) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(24) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(25) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(26) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(27) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(28) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(29) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(30) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(31) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(32) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(33) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(34) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(35) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(36) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(37) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(38) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(39) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(40) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(41) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(42) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(43) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(44) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(45) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(46) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(47) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(48) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(49) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(50) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(51) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(52) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(53) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(54) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(55) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(56) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(57) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(58) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(59) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(60) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(61) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(62) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(63) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(64) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(65) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(66) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(67) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(68) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(69) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(70) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(71) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(72) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(73) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(74) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(75) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(76) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(77) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(78) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(79) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(80) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(81) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(82) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(83) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(84) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(85) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(86) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(87) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(88) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(89) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(90) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(91) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(92) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(93) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(94) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(95) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(96) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(97) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(98) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(99) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(100) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(101) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(102) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(103) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(104) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(105) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(106) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(107) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(108) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(109) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(110) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(111) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(112) Then
            Text_spesymb_nickname.Text = ""
        ElseIf Select_spesymb_nickname.SelectedItem = Select_spesymb_nickname.Items.Item(113) Then
            Text_spesymb_nickname.Text = ""
        End If
    End Sub

    Private Sub Text_spesymb_add_nickname_pn_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_nickname_pn.Click
        If Text_edit_pronun_nickname.TextLength < 20 Then
            Text_edit_pronun_nickname.Text = Text_edit_pronun_nickname.Text & Text_spesymb_nickname.Text
            Panel_addsymb_nickname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_nickname.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_add_nickname_n_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_nickname_n.Click
        If Text_nickname.TextLength < 10 Then
            Text_nickname.Text = Text_nickname.Text & Text_spesymb_nickname.Text
            Panel_addsymb_nickname.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_nickname.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_creator_cancel_Click(sender As Object, e As EventArgs) Handles Text_spesymb_creator_cancel.Click
        Panel_addsymb_creator.Visible = False
    End Sub

    Private Sub Addsymbol_creator_Click(sender As Object, e As EventArgs) Handles Addsymbol_creator.Click
        Panel_addsymb_creator.Visible = True
        Text_spesymb_add_creator_n.Visible = True
    End Sub

    Private Sub Select_spesymb_creator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_spesymb_creator.SelectedIndexChanged
        If Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(0) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(1) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(2) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(3) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(4) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(5) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(6) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(7) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(8) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(9) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(10) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(11) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(12) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(13) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(14) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(15) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(16) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(17) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(18) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(19) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(20) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(21) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(22) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(23) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(24) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(25) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(26) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(27) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(28) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(29) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(30) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(31) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(32) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(33) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(34) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(35) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(36) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(37) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(38) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(39) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(40) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(41) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(42) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(43) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(44) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(45) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(46) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(47) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(48) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(49) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(50) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(51) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(52) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(53) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(54) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(55) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(56) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(57) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(58) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(59) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(60) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(61) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(62) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(63) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(64) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(65) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(66) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(67) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(68) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(69) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(70) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(71) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(72) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(73) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(74) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(75) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(76) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(77) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(78) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(79) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(80) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(81) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(82) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(83) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(84) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(85) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(86) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(87) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(88) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(89) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(90) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(91) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(92) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(93) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(94) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(95) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(96) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(97) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(98) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(99) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(100) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(101) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(102) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(103) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(104) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(105) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(106) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(107) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(108) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(109) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(110) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(111) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(112) Then
            Text_spesymb_creator.Text = ""
        ElseIf Select_spesymb_creator.SelectedItem = Select_spesymb_creator.Items.Item(113) Then
            Text_spesymb_creator.Text = ""
        End If
    End Sub

    Private Sub Text_spesymb_add_creator_n_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_creator_n.Click
        If Text_creator.TextLength < 10 Then
            Text_creator.Text = Text_creator.Text & Text_spesymb_creator.Text
            Panel_addsymb_creator.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb_creator.Visible = False
        End If
    End Sub

    Private Sub Icon_valid_firstname_Click(sender As Object, e As EventArgs) Handles Icon_valid_firstname.Click
        Panel_edit_pronun_firstname.Visible = False
        Text_pronun_firstname.Text = Text_edit_pronun_firstname.Text
        AdvH_firstnamepronun.Visible = False
        Addsymbol_pronun_firstname.Visible = False
    End Sub

    Private Sub Icon_pronun_firstname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.Click
        Text_edit_pronun_firstname.Text = Text_pronun_firstname.Text
        Panel_edit_pronun_firstname.Visible = True
        If Setting_Advhelp.Checked = True Then
            AdvH_firstnamepronun.Visible = True
        End If
        If Setting_spesymb.Checked = True Then
            Addsymbol_pronun_firstname.Visible = True
        End If
    End Sub

    Private Sub Icon_pronun_firstname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseMove
        Text_pronun_firstname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit first name pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du prénom"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseLeave
        Text_pronun_firstname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_valid_lastname_Click(sender As Object, e As EventArgs) Handles Icon_valid_lastname.Click
        Panel_edit_pronun_lastname.Visible = False
        Text_pronun_lastname.Text = Text_edit_pronun_lastname.Text
        AdvH_lastnamepronun.Visible = False
        Addsymbol_pronun_lastname.Visible = False
    End Sub

    Private Sub Icon_pronun_lastname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.Click
        Text_edit_pronun_lastname.Text = Text_pronun_lastname.Text
        Panel_edit_pronun_lastname.Visible = True
        If Setting_Advhelp.Checked = True Then
            AdvH_lastnamepronun.Visible = True
        End If
        If Setting_spesymb.Checked = True Then
            Addsymbol_pronun_lastname.Visible = True
        End If
    End Sub

    Private Sub Icon_pronun_lastname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseMove
        Text_pronun_lastname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit last name pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du nom"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_lastname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseLeave
        Text_pronun_lastname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_valid_nickname_Click(sender As Object, e As EventArgs) Handles Icon_valid_nickname.Click
        Panel_edit_pronun_nickname.Visible = False
        Text_pronun_nickname.Text = Text_edit_pronun_nickname.Text
        AdvH_nicknamepronun.Visible = False
        Addsymbol_pronun_nickname.Visible = False
    End Sub

    Private Sub Icon_pronun_nickname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.Click
        Text_edit_pronun_nickname.Text = Text_pronun_nickname.Text
        Panel_edit_pronun_nickname.Visible = True
        If Setting_Advhelp.Checked = True Then
            AdvH_nicknamepronun.Visible = True
        End If
        If Setting_spesymb.Checked = True Then
            Addsymbol_pronun_nickname.Visible = True
        End If
    End Sub

    Private Sub Icon_pronun_nickname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseMove
        Text_pronun_nickname.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit nickname pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du surnom"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_nickname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseLeave
        Text_pronun_nickname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub valu_sharing_ValueChanged(sender As Object, e As EventArgs) Handles valu_sharing.ValueChanged
        Try
            ConvertB_sharing.Text = Convert.ToString(Convert.ToUInt32(valu_sharing.Value), 2).PadLeft(8, "0")
            Binary_skincolor.Text = ConvertB_sharing.Text.Substring(0, 3)
            Binary_faceshap.Text = ConvertB_sharing.Text.Substring(3, 4)
            Binary_sharing.Text = ConvertB_sharing.Text.Substring(7, 1)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to convert sharing to binary"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub ConvertB_sharing_TextChanged(sender As Object, e As EventArgs) Handles ConvertB_sharing.TextChanged
        Try
            valu_sharing.Value = Convert.ToUInt32(Convert.ToString(ConvertB_sharing.Text), 2)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to convert binary sharing to hex"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub Mergebinarysharing()
        Try
            ConvertB_sharing.Text = Binary_skincolor.Text + Binary_faceshap.Text + Binary_sharing.Text 'merge binary features
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to update convert binary sharing"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Select_sharing_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_sharing.SelectedIndexChanged
        If Select_sharing.SelectedItem = Select_sharing.Items.Item(0) Then
            Binary_sharing.Text = "0"
        ElseIf Select_sharing.SelectedItem = Select_sharing.Items.Item(1) Then
            Binary_sharing.Text = "1"
        End If
    End Sub

    Private Sub Text_valuesharing_TextChanged(sender As Object, e As EventArgs) Handles Binary_sharing.TextChanged
        If Binary_sharing.Text = "0" Then
            Select_sharing.SelectedItem = Select_sharing.Items.Item(0)
        ElseIf Binary_sharing.Text = "1" Then
            Select_sharing.SelectedItem = Select_sharing.Items.Item(1)
        End If
    End Sub

    Private Sub valu_copying_ValueChanged(sender As Object, e As EventArgs) Handles valu_copying.ValueChanged
        Try
            ConvertB_copying.Text = Convert.ToString(Convert.ToUInt32(valu_copying.Value), 2).PadLeft(8, "0")
            Binary_cp_unknow.Text = ConvertB_copying.Text.Substring(0, 7)
            Binary_copying.Text = ConvertB_copying.Text.Substring(7, 1)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to convert babies born to binary"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub ConvertB_copying_TextChanged(sender As Object, e As EventArgs) Handles ConvertB_copying.TextChanged
        Try
            valu_copying.Value = Convert.ToUInt32(Convert.ToString(ConvertB_copying.Text), 2)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to convert binary babies born to hex"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub Mergebinarycopying()
        Try
            ConvertB_copying.Text = Binary_cp_unknow.Text + Binary_copying.Text 'merge binary features
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to update convert binary babies born"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Binary_copying_TextChanged(sender As Object, e As EventArgs) Handles Binary_copying.TextChanged
        If Binary_copying.Text = 0 Then
            Select_copying.SelectedItem = Select_copying.Items.Item(0)
        End If
        If Binary_copying.Text = 1 Then
            Select_copying.SelectedItem = Select_copying.Items.Item(1)
        End If
    End Sub

    Private Sub Select_copying_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_copying.SelectedIndexChanged
        If Select_copying.SelectedItem = Select_copying.Items.Item(0) Then
            Binary_copying.Text = 0
        ElseIf Select_copying.SelectedItem = Select_copying.Items.Item(1) Then
            Binary_copying.Text = 1
        End If
    End Sub


End Class