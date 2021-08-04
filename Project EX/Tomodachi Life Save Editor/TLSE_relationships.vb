﻿Public Class TLSE_relationships
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    'form settings
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
    'end form settings

    'form menu
    Private Sub Icon_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu.MouseMove
        Icon_menu.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu.MouseLeave
        Icon_menu.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_Click(sender As Object, e As EventArgs) Handles Icon_menu.Click
        TLSE_hub.Show()
        Me.Close()
    End Sub
    'end form menu

    Private Sub Panfriends1_arrow_right_Click(sender As Object, e As EventArgs) Handles Panfriends1_arrow_right.Click
        hidefriendlistpan()
        Panel_friendlist_2.Visible = True
    End Sub

    Private Sub Panfriends2_arrow_left_Click(sender As Object, e As EventArgs) Handles Panfriends2_arrow_left.Click
        hidefriendlistpan()
        Panel_friendlist_1.Visible = True
    End Sub

    Private Sub Panfriends2_arrow_right_Click(sender As Object, e As EventArgs) Handles Panfriends2_arrow_right.Click
        hidefriendlistpan()
        Panel_friendlist_3.Visible = True
    End Sub

    Private Sub Panfriends3_arrow_left_Click(sender As Object, e As EventArgs) Handles Panfriends3_arrow_left.Click
        hidefriendlistpan()
        Panel_friendlist_2.Visible = True
    End Sub

    Private Sub Panfriends3_arrow_right_Click(sender As Object, e As EventArgs) Handles Panfriends3_arrow_right.Click
        hidefriendlistpan()
        Panel_friendlist_4.Visible = True
    End Sub

    Private Sub Panfriends4_arrow_left_Click(sender As Object, e As EventArgs) Handles Panfriends4_arrow_left.Click
        hidefriendlistpan()
        Panel_friendlist_3.Visible = True
    End Sub

    Public Sub hidefriendlistpan()
        Panel_friendlist_1.Visible = False
        Panel_friendlist_2.Visible = False
        Panel_friendlist_3.Visible = False
        Panel_friendlist_4.Visible = False
    End Sub

    Private Sub Panfriends1_arrow_right_MouseMove(sender As Object, e As MouseEventArgs) Handles Panfriends1_arrow_right.MouseMove
        Panfriends1_arrow_right.Image = My.Resources.icon_navi_rightact
    End Sub

    Private Sub Panfriends1_arrow_right_MouseLeave(sender As Object, e As EventArgs) Handles Panfriends1_arrow_right.MouseLeave
        Panfriends1_arrow_right.Image = My.Resources.icon_navi_right
    End Sub

    Private Sub Panfriends2_arrow_left_MouseMove(sender As Object, e As MouseEventArgs) Handles Panfriends2_arrow_left.MouseMove
        Panfriends2_arrow_left.Image = My.Resources.icon_navi_leftact
    End Sub

    Private Sub Panfriends2_arrow_left_MouseLeave(sender As Object, e As EventArgs) Handles Panfriends2_arrow_left.MouseLeave
        Panfriends2_arrow_left.Image = My.Resources.icon_navi_left
    End Sub

    Private Sub Panfriends2_arrow_right_MouseMove(sender As Object, e As MouseEventArgs) Handles Panfriends2_arrow_right.MouseMove
        Panfriends2_arrow_right.Image = My.Resources.icon_navi_rightact
    End Sub

    Private Sub Panfriends2_arrow_right_MouseLeave(sender As Object, e As EventArgs) Handles Panfriends2_arrow_right.MouseLeave
        Panfriends2_arrow_right.Image = My.Resources.icon_navi_right
    End Sub

    Private Sub Panfriends3_arrow_left_MouseMove(sender As Object, e As MouseEventArgs) Handles Panfriends3_arrow_left.MouseMove
        Panfriends3_arrow_left.Image = My.Resources.icon_navi_leftact
    End Sub

    Private Sub Panfriends3_arrow_left_MouseLeave(sender As Object, e As EventArgs) Handles Panfriends3_arrow_left.MouseLeave
        Panfriends3_arrow_left.Image = My.Resources.icon_navi_left
    End Sub

    Private Sub Panfriends3_arrow_right_MouseMove(sender As Object, e As MouseEventArgs) Handles Panfriends3_arrow_right.MouseMove
        Panfriends3_arrow_right.Image = My.Resources.icon_navi_rightact
    End Sub

    Private Sub Panfriends3_arrow_right_MouseLeave(sender As Object, e As EventArgs) Handles Panfriends3_arrow_right.MouseLeave
        Panfriends3_arrow_right.Image = My.Resources.icon_navi_right
    End Sub

    Private Sub Panfriends4_arrow_left_MouseMove(sender As Object, e As MouseEventArgs) Handles Panfriends4_arrow_left.MouseMove
        Panfriends4_arrow_left.Image = My.Resources.icon_navi_leftact
    End Sub

    Private Sub Panfriends4_arrow_left_MouseLeave(sender As Object, e As EventArgs) Handles Panfriends4_arrow_left.MouseLeave
        Panfriends4_arrow_left.Image = My.Resources.icon_navi_left
    End Sub

    Private Sub Select_friend_rela_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_1.SelectedIndexChanged
        If Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(0) Then
            valu_selfriend_rela_1.Value = 0
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(1) Then
            valu_selfriend_rela_1.Value = 1
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(2) Then
            valu_selfriend_rela_1.Value = 2
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(3) Then
            valu_selfriend_rela_1.Value = 3
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(4) Then
            valu_selfriend_rela_1.Value = 4
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(5) Then
            valu_selfriend_rela_1.Value = 6
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(6) Then
            valu_selfriend_rela_1.Value = 7
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(7) Then
            valu_selfriend_rela_1.Value = 8
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(8) Then
            valu_selfriend_rela_1.Value = 9
        ElseIf Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(9) Then
            valu_selfriend_rela_1.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_2.SelectedIndexChanged
        If Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(0) Then
            valu_selfriend_rela_2.Value = 0
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(1) Then
            valu_selfriend_rela_2.Value = 1
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(2) Then
            valu_selfriend_rela_2.Value = 2
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(3) Then
            valu_selfriend_rela_2.Value = 3
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(4) Then
            valu_selfriend_rela_2.Value = 4
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(5) Then
            valu_selfriend_rela_2.Value = 6
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(6) Then
            valu_selfriend_rela_2.Value = 7
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(7) Then
            valu_selfriend_rela_2.Value = 8
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(8) Then
            valu_selfriend_rela_2.Value = 9
        ElseIf Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(9) Then
            valu_selfriend_rela_2.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_3.SelectedIndexChanged
        If Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(0) Then
            valu_selfriend_rela_3.Value = 0
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(1) Then
            valu_selfriend_rela_3.Value = 1
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(2) Then
            valu_selfriend_rela_3.Value = 2
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(3) Then
            valu_selfriend_rela_3.Value = 3
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(4) Then
            valu_selfriend_rela_3.Value = 4
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(5) Then
            valu_selfriend_rela_3.Value = 6
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(6) Then
            valu_selfriend_rela_3.Value = 7
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(7) Then
            valu_selfriend_rela_3.Value = 8
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(8) Then
            valu_selfriend_rela_3.Value = 9
        ElseIf Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(9) Then
            valu_selfriend_rela_3.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_4.SelectedIndexChanged
        If Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(0) Then
            valu_selfriend_rela_4.Value = 0
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(1) Then
            valu_selfriend_rela_4.Value = 1
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(2) Then
            valu_selfriend_rela_4.Value = 2
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(3) Then
            valu_selfriend_rela_4.Value = 3
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(4) Then
            valu_selfriend_rela_4.Value = 4
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(5) Then
            valu_selfriend_rela_4.Value = 6
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(6) Then
            valu_selfriend_rela_4.Value = 7
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(7) Then
            valu_selfriend_rela_4.Value = 8
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(8) Then
            valu_selfriend_rela_4.Value = 9
        ElseIf Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(9) Then
            valu_selfriend_rela_4.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_5.SelectedIndexChanged
        If Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(0) Then
            valu_selfriend_rela_5.Value = 0
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(1) Then
            valu_selfriend_rela_5.Value = 1
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(2) Then
            valu_selfriend_rela_5.Value = 2
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(3) Then
            valu_selfriend_rela_5.Value = 3
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(4) Then
            valu_selfriend_rela_5.Value = 4
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(5) Then
            valu_selfriend_rela_5.Value = 6
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(6) Then
            valu_selfriend_rela_5.Value = 7
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(7) Then
            valu_selfriend_rela_5.Value = 8
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(8) Then
            valu_selfriend_rela_5.Value = 9
        ElseIf Select_friend_rela_5.SelectedItem = Select_friend_rela_5.Items.Item(9) Then
            valu_selfriend_rela_5.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_6.SelectedIndexChanged
        If Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(0) Then
            valu_selfriend_rela_6.Value = 0
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(1) Then
            valu_selfriend_rela_6.Value = 1
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(2) Then
            valu_selfriend_rela_6.Value = 2
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(3) Then
            valu_selfriend_rela_6.Value = 3
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(4) Then
            valu_selfriend_rela_6.Value = 4
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(5) Then
            valu_selfriend_rela_6.Value = 6
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(6) Then
            valu_selfriend_rela_6.Value = 7
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(7) Then
            valu_selfriend_rela_6.Value = 8
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(8) Then
            valu_selfriend_rela_6.Value = 9
        ElseIf Select_friend_rela_6.SelectedItem = Select_friend_rela_6.Items.Item(9) Then
            valu_selfriend_rela_6.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_7.SelectedIndexChanged
        If Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(0) Then
            valu_selfriend_rela_7.Value = 0
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(1) Then
            valu_selfriend_rela_7.Value = 1
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(2) Then
            valu_selfriend_rela_7.Value = 2
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(3) Then
            valu_selfriend_rela_7.Value = 3
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(4) Then
            valu_selfriend_rela_7.Value = 4
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(5) Then
            valu_selfriend_rela_7.Value = 6
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(6) Then
            valu_selfriend_rela_7.Value = 7
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(7) Then
            valu_selfriend_rela_7.Value = 8
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(8) Then
            valu_selfriend_rela_7.Value = 9
        ElseIf Select_friend_rela_7.SelectedItem = Select_friend_rela_7.Items.Item(9) Then
            valu_selfriend_rela_7.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_8.SelectedIndexChanged
        If Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(0) Then
            valu_selfriend_rela_8.Value = 0
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(1) Then
            valu_selfriend_rela_8.Value = 1
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(2) Then
            valu_selfriend_rela_8.Value = 2
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(3) Then
            valu_selfriend_rela_8.Value = 3
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(4) Then
            valu_selfriend_rela_8.Value = 4
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(5) Then
            valu_selfriend_rela_8.Value = 6
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(6) Then
            valu_selfriend_rela_8.Value = 7
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(7) Then
            valu_selfriend_rela_8.Value = 8
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(8) Then
            valu_selfriend_rela_8.Value = 9
        ElseIf Select_friend_rela_8.SelectedItem = Select_friend_rela_8.Items.Item(9) Then
            valu_selfriend_rela_8.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_9.SelectedIndexChanged
        If Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(0) Then
            valu_selfriend_rela_9.Value = 0
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(1) Then
            valu_selfriend_rela_9.Value = 1
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(2) Then
            valu_selfriend_rela_9.Value = 2
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(3) Then
            valu_selfriend_rela_9.Value = 3
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(4) Then
            valu_selfriend_rela_9.Value = 4
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(5) Then
            valu_selfriend_rela_9.Value = 6
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(6) Then
            valu_selfriend_rela_9.Value = 7
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(7) Then
            valu_selfriend_rela_9.Value = 8
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(8) Then
            valu_selfriend_rela_9.Value = 9
        ElseIf Select_friend_rela_9.SelectedItem = Select_friend_rela_9.Items.Item(9) Then
            valu_selfriend_rela_9.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_10.SelectedIndexChanged
        If Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(0) Then
            valu_selfriend_rela_10.Value = 0
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(1) Then
            valu_selfriend_rela_10.Value = 1
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(2) Then
            valu_selfriend_rela_10.Value = 2
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(3) Then
            valu_selfriend_rela_10.Value = 3
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(4) Then
            valu_selfriend_rela_10.Value = 4
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(5) Then
            valu_selfriend_rela_10.Value = 6
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(6) Then
            valu_selfriend_rela_10.Value = 7
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(7) Then
            valu_selfriend_rela_10.Value = 8
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(8) Then
            valu_selfriend_rela_10.Value = 9
        ElseIf Select_friend_rela_10.SelectedItem = Select_friend_rela_10.Items.Item(9) Then
            valu_selfriend_rela_10.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_11.SelectedIndexChanged
        If Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(0) Then
            valu_selfriend_rela_11.Value = 0
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(1) Then
            valu_selfriend_rela_11.Value = 1
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(2) Then
            valu_selfriend_rela_11.Value = 2
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(3) Then
            valu_selfriend_rela_11.Value = 3
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(4) Then
            valu_selfriend_rela_11.Value = 4
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(5) Then
            valu_selfriend_rela_11.Value = 6
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(6) Then
            valu_selfriend_rela_11.Value = 7
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(7) Then
            valu_selfriend_rela_11.Value = 8
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(8) Then
            valu_selfriend_rela_11.Value = 9
        ElseIf Select_friend_rela_11.SelectedItem = Select_friend_rela_11.Items.Item(9) Then
            valu_selfriend_rela_11.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_12.SelectedIndexChanged
        If Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(0) Then
            valu_selfriend_rela_12.Value = 0
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(1) Then
            valu_selfriend_rela_12.Value = 1
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(2) Then
            valu_selfriend_rela_12.Value = 2
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(3) Then
            valu_selfriend_rela_12.Value = 3
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(4) Then
            valu_selfriend_rela_12.Value = 4
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(5) Then
            valu_selfriend_rela_12.Value = 6
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(6) Then
            valu_selfriend_rela_12.Value = 7
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(7) Then
            valu_selfriend_rela_12.Value = 8
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(8) Then
            valu_selfriend_rela_12.Value = 9
        ElseIf Select_friend_rela_12.SelectedItem = Select_friend_rela_12.Items.Item(9) Then
            valu_selfriend_rela_12.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_13.SelectedIndexChanged
        If Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(0) Then
            valu_selfriend_rela_13.Value = 0
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(1) Then
            valu_selfriend_rela_13.Value = 1
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(2) Then
            valu_selfriend_rela_13.Value = 2
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(3) Then
            valu_selfriend_rela_13.Value = 3
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(4) Then
            valu_selfriend_rela_13.Value = 4
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(5) Then
            valu_selfriend_rela_13.Value = 6
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(6) Then
            valu_selfriend_rela_13.Value = 7
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(7) Then
            valu_selfriend_rela_13.Value = 8
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(8) Then
            valu_selfriend_rela_13.Value = 9
        ElseIf Select_friend_rela_13.SelectedItem = Select_friend_rela_13.Items.Item(9) Then
            valu_selfriend_rela_13.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_14.SelectedIndexChanged
        If Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(0) Then
            valu_selfriend_rela_14.Value = 0
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(1) Then
            valu_selfriend_rela_14.Value = 1
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(2) Then
            valu_selfriend_rela_14.Value = 2
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(3) Then
            valu_selfriend_rela_14.Value = 3
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(4) Then
            valu_selfriend_rela_14.Value = 4
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(5) Then
            valu_selfriend_rela_14.Value = 6
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(6) Then
            valu_selfriend_rela_14.Value = 7
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(7) Then
            valu_selfriend_rela_14.Value = 8
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(8) Then
            valu_selfriend_rela_14.Value = 9
        ElseIf Select_friend_rela_14.SelectedItem = Select_friend_rela_14.Items.Item(9) Then
            valu_selfriend_rela_14.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_15.SelectedIndexChanged
        If Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(0) Then
            valu_selfriend_rela_15.Value = 0
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(1) Then
            valu_selfriend_rela_15.Value = 1
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(2) Then
            valu_selfriend_rela_15.Value = 2
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(3) Then
            valu_selfriend_rela_15.Value = 3
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(4) Then
            valu_selfriend_rela_15.Value = 4
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(5) Then
            valu_selfriend_rela_15.Value = 6
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(6) Then
            valu_selfriend_rela_15.Value = 7
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(7) Then
            valu_selfriend_rela_15.Value = 8
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(8) Then
            valu_selfriend_rela_15.Value = 9
        ElseIf Select_friend_rela_15.SelectedItem = Select_friend_rela_15.Items.Item(9) Then
            valu_selfriend_rela_15.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_16.SelectedIndexChanged
        If Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(0) Then
            valu_selfriend_rela_16.Value = 0
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(1) Then
            valu_selfriend_rela_16.Value = 1
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(2) Then
            valu_selfriend_rela_16.Value = 2
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(3) Then
            valu_selfriend_rela_16.Value = 3
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(4) Then
            valu_selfriend_rela_16.Value = 4
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(5) Then
            valu_selfriend_rela_16.Value = 6
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(6) Then
            valu_selfriend_rela_16.Value = 7
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(7) Then
            valu_selfriend_rela_16.Value = 8
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(8) Then
            valu_selfriend_rela_16.Value = 9
        ElseIf Select_friend_rela_16.SelectedItem = Select_friend_rela_16.Items.Item(9) Then
            valu_selfriend_rela_16.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_17.SelectedIndexChanged
        If Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(0) Then
            valu_selfriend_rela_17.Value = 0
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(1) Then
            valu_selfriend_rela_17.Value = 1
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(2) Then
            valu_selfriend_rela_17.Value = 2
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(3) Then
            valu_selfriend_rela_17.Value = 3
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(4) Then
            valu_selfriend_rela_17.Value = 4
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(5) Then
            valu_selfriend_rela_17.Value = 6
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(6) Then
            valu_selfriend_rela_17.Value = 7
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(7) Then
            valu_selfriend_rela_17.Value = 8
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(8) Then
            valu_selfriend_rela_17.Value = 9
        ElseIf Select_friend_rela_17.SelectedItem = Select_friend_rela_17.Items.Item(9) Then
            valu_selfriend_rela_17.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_18.SelectedIndexChanged
        If Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(0) Then
            valu_selfriend_rela_18.Value = 0
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(1) Then
            valu_selfriend_rela_18.Value = 1
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(2) Then
            valu_selfriend_rela_18.Value = 2
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(3) Then
            valu_selfriend_rela_18.Value = 3
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(4) Then
            valu_selfriend_rela_18.Value = 4
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(5) Then
            valu_selfriend_rela_18.Value = 6
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(6) Then
            valu_selfriend_rela_18.Value = 7
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(7) Then
            valu_selfriend_rela_18.Value = 8
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(8) Then
            valu_selfriend_rela_18.Value = 9
        ElseIf Select_friend_rela_18.SelectedItem = Select_friend_rela_18.Items.Item(9) Then
            valu_selfriend_rela_18.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_19.SelectedIndexChanged
        If Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(0) Then
            valu_selfriend_rela_19.Value = 0
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(1) Then
            valu_selfriend_rela_19.Value = 1
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(2) Then
            valu_selfriend_rela_19.Value = 2
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(3) Then
            valu_selfriend_rela_19.Value = 3
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(4) Then
            valu_selfriend_rela_19.Value = 4
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(5) Then
            valu_selfriend_rela_19.Value = 6
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(6) Then
            valu_selfriend_rela_19.Value = 7
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(7) Then
            valu_selfriend_rela_19.Value = 8
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(8) Then
            valu_selfriend_rela_19.Value = 9
        ElseIf Select_friend_rela_19.SelectedItem = Select_friend_rela_19.Items.Item(9) Then
            valu_selfriend_rela_19.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_20.SelectedIndexChanged
        If Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(0) Then
            valu_selfriend_rela_20.Value = 0
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(1) Then
            valu_selfriend_rela_20.Value = 1
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(2) Then
            valu_selfriend_rela_20.Value = 2
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(3) Then
            valu_selfriend_rela_20.Value = 3
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(4) Then
            valu_selfriend_rela_20.Value = 4
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(5) Then
            valu_selfriend_rela_20.Value = 6
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(6) Then
            valu_selfriend_rela_20.Value = 7
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(7) Then
            valu_selfriend_rela_20.Value = 8
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(8) Then
            valu_selfriend_rela_20.Value = 9
        ElseIf Select_friend_rela_20.SelectedItem = Select_friend_rela_20.Items.Item(9) Then
            valu_selfriend_rela_20.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_21.SelectedIndexChanged
        If Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(0) Then
            valu_selfriend_rela_21.Value = 0
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(1) Then
            valu_selfriend_rela_21.Value = 1
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(2) Then
            valu_selfriend_rela_21.Value = 2
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(3) Then
            valu_selfriend_rela_21.Value = 3
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(4) Then
            valu_selfriend_rela_21.Value = 4
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(5) Then
            valu_selfriend_rela_21.Value = 6
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(6) Then
            valu_selfriend_rela_21.Value = 7
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(7) Then
            valu_selfriend_rela_21.Value = 8
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(8) Then
            valu_selfriend_rela_21.Value = 9
        ElseIf Select_friend_rela_21.SelectedItem = Select_friend_rela_21.Items.Item(9) Then
            valu_selfriend_rela_21.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_22_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_22.SelectedIndexChanged
        If Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(0) Then
            valu_selfriend_rela_22.Value = 0
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(1) Then
            valu_selfriend_rela_22.Value = 1
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(2) Then
            valu_selfriend_rela_22.Value = 2
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(3) Then
            valu_selfriend_rela_22.Value = 3
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(4) Then
            valu_selfriend_rela_22.Value = 4
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(5) Then
            valu_selfriend_rela_22.Value = 6
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(6) Then
            valu_selfriend_rela_22.Value = 7
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(7) Then
            valu_selfriend_rela_22.Value = 8
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(8) Then
            valu_selfriend_rela_22.Value = 9
        ElseIf Select_friend_rela_22.SelectedItem = Select_friend_rela_22.Items.Item(9) Then
            valu_selfriend_rela_22.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_23_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_23.SelectedIndexChanged
        If Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(0) Then
            valu_selfriend_rela_23.Value = 0
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(1) Then
            valu_selfriend_rela_23.Value = 1
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(2) Then
            valu_selfriend_rela_23.Value = 2
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(3) Then
            valu_selfriend_rela_23.Value = 3
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(4) Then
            valu_selfriend_rela_23.Value = 4
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(5) Then
            valu_selfriend_rela_23.Value = 6
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(6) Then
            valu_selfriend_rela_23.Value = 7
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(7) Then
            valu_selfriend_rela_23.Value = 8
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(8) Then
            valu_selfriend_rela_23.Value = 9
        ElseIf Select_friend_rela_23.SelectedItem = Select_friend_rela_23.Items.Item(9) Then
            valu_selfriend_rela_23.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_24_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_24.SelectedIndexChanged
        If Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(0) Then
            valu_selfriend_rela_24.Value = 0
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(1) Then
            valu_selfriend_rela_24.Value = 1
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(2) Then
            valu_selfriend_rela_24.Value = 2
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(3) Then
            valu_selfriend_rela_24.Value = 3
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(4) Then
            valu_selfriend_rela_24.Value = 4
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(5) Then
            valu_selfriend_rela_24.Value = 6
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(6) Then
            valu_selfriend_rela_24.Value = 7
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(7) Then
            valu_selfriend_rela_24.Value = 8
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(8) Then
            valu_selfriend_rela_24.Value = 9
        ElseIf Select_friend_rela_24.SelectedItem = Select_friend_rela_24.Items.Item(9) Then
            valu_selfriend_rela_24.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_25_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_25.SelectedIndexChanged
        If Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(0) Then
            valu_selfriend_rela_25.Value = 0
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(1) Then
            valu_selfriend_rela_25.Value = 1
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(2) Then
            valu_selfriend_rela_25.Value = 2
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(3) Then
            valu_selfriend_rela_25.Value = 3
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(4) Then
            valu_selfriend_rela_25.Value = 4
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(5) Then
            valu_selfriend_rela_25.Value = 6
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(6) Then
            valu_selfriend_rela_25.Value = 7
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(7) Then
            valu_selfriend_rela_25.Value = 8
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(8) Then
            valu_selfriend_rela_25.Value = 9
        ElseIf Select_friend_rela_25.SelectedItem = Select_friend_rela_25.Items.Item(9) Then
            valu_selfriend_rela_25.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_26_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_26.SelectedIndexChanged
        If Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(0) Then
            valu_selfriend_rela_26.Value = 0
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(1) Then
            valu_selfriend_rela_26.Value = 1
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(2) Then
            valu_selfriend_rela_26.Value = 2
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(3) Then
            valu_selfriend_rela_26.Value = 3
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(4) Then
            valu_selfriend_rela_26.Value = 4
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(5) Then
            valu_selfriend_rela_26.Value = 6
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(6) Then
            valu_selfriend_rela_26.Value = 7
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(7) Then
            valu_selfriend_rela_26.Value = 8
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(8) Then
            valu_selfriend_rela_26.Value = 9
        ElseIf Select_friend_rela_26.SelectedItem = Select_friend_rela_26.Items.Item(9) Then
            valu_selfriend_rela_26.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_27_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_27.SelectedIndexChanged
        If Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(0) Then
            valu_selfriend_rela_27.Value = 0
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(1) Then
            valu_selfriend_rela_27.Value = 1
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(2) Then
            valu_selfriend_rela_27.Value = 2
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(3) Then
            valu_selfriend_rela_27.Value = 3
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(4) Then
            valu_selfriend_rela_27.Value = 4
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(5) Then
            valu_selfriend_rela_27.Value = 6
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(6) Then
            valu_selfriend_rela_27.Value = 7
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(7) Then
            valu_selfriend_rela_27.Value = 8
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(8) Then
            valu_selfriend_rela_27.Value = 9
        ElseIf Select_friend_rela_27.SelectedItem = Select_friend_rela_27.Items.Item(9) Then
            valu_selfriend_rela_27.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_28_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_28.SelectedIndexChanged
        If Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(0) Then
            valu_selfriend_rela_28.Value = 0
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(1) Then
            valu_selfriend_rela_28.Value = 1
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(2) Then
            valu_selfriend_rela_28.Value = 2
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(3) Then
            valu_selfriend_rela_28.Value = 3
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(4) Then
            valu_selfriend_rela_28.Value = 4
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(5) Then
            valu_selfriend_rela_28.Value = 6
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(6) Then
            valu_selfriend_rela_28.Value = 7
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(7) Then
            valu_selfriend_rela_28.Value = 8
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(8) Then
            valu_selfriend_rela_28.Value = 9
        ElseIf Select_friend_rela_28.SelectedItem = Select_friend_rela_28.Items.Item(9) Then
            valu_selfriend_rela_28.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_29_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_29.SelectedIndexChanged
        If Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(0) Then
            valu_selfriend_rela_29.Value = 0
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(1) Then
            valu_selfriend_rela_29.Value = 1
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(2) Then
            valu_selfriend_rela_29.Value = 2
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(3) Then
            valu_selfriend_rela_29.Value = 3
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(4) Then
            valu_selfriend_rela_29.Value = 4
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(5) Then
            valu_selfriend_rela_29.Value = 6
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(6) Then
            valu_selfriend_rela_29.Value = 7
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(7) Then
            valu_selfriend_rela_29.Value = 8
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(8) Then
            valu_selfriend_rela_29.Value = 9
        ElseIf Select_friend_rela_29.SelectedItem = Select_friend_rela_29.Items.Item(9) Then
            valu_selfriend_rela_29.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_30_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_30.SelectedIndexChanged
        If Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(0) Then
            valu_selfriend_rela_30.Value = 0
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(1) Then
            valu_selfriend_rela_30.Value = 1
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(2) Then
            valu_selfriend_rela_30.Value = 2
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(3) Then
            valu_selfriend_rela_30.Value = 3
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(4) Then
            valu_selfriend_rela_30.Value = 4
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(5) Then
            valu_selfriend_rela_30.Value = 6
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(6) Then
            valu_selfriend_rela_30.Value = 7
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(7) Then
            valu_selfriend_rela_30.Value = 8
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(8) Then
            valu_selfriend_rela_30.Value = 9
        ElseIf Select_friend_rela_30.SelectedItem = Select_friend_rela_30.Items.Item(9) Then
            valu_selfriend_rela_30.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_31_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_31.SelectedIndexChanged
        If Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(0) Then
            valu_selfriend_rela_31.Value = 0
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(1) Then
            valu_selfriend_rela_31.Value = 1
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(2) Then
            valu_selfriend_rela_31.Value = 2
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(3) Then
            valu_selfriend_rela_31.Value = 3
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(4) Then
            valu_selfriend_rela_31.Value = 4
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(5) Then
            valu_selfriend_rela_31.Value = 6
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(6) Then
            valu_selfriend_rela_31.Value = 7
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(7) Then
            valu_selfriend_rela_31.Value = 8
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(8) Then
            valu_selfriend_rela_31.Value = 9
        ElseIf Select_friend_rela_31.SelectedItem = Select_friend_rela_31.Items.Item(9) Then
            valu_selfriend_rela_31.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_32_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_32.SelectedIndexChanged
        If Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(0) Then
            valu_selfriend_rela_32.Value = 0
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(1) Then
            valu_selfriend_rela_32.Value = 1
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(2) Then
            valu_selfriend_rela_32.Value = 2
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(3) Then
            valu_selfriend_rela_32.Value = 3
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(4) Then
            valu_selfriend_rela_32.Value = 4
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(5) Then
            valu_selfriend_rela_32.Value = 6
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(6) Then
            valu_selfriend_rela_32.Value = 7
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(7) Then
            valu_selfriend_rela_32.Value = 8
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(8) Then
            valu_selfriend_rela_32.Value = 9
        ElseIf Select_friend_rela_32.SelectedItem = Select_friend_rela_32.Items.Item(9) Then
            valu_selfriend_rela_32.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_33_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_33.SelectedIndexChanged
        If Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(0) Then
            valu_selfriend_rela_33.Value = 0
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(1) Then
            valu_selfriend_rela_33.Value = 1
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(2) Then
            valu_selfriend_rela_33.Value = 2
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(3) Then
            valu_selfriend_rela_33.Value = 3
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(4) Then
            valu_selfriend_rela_33.Value = 4
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(5) Then
            valu_selfriend_rela_33.Value = 6
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(6) Then
            valu_selfriend_rela_33.Value = 7
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(7) Then
            valu_selfriend_rela_33.Value = 8
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(8) Then
            valu_selfriend_rela_33.Value = 9
        ElseIf Select_friend_rela_33.SelectedItem = Select_friend_rela_33.Items.Item(9) Then
            valu_selfriend_rela_33.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_34_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_34.SelectedIndexChanged
        If Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(0) Then
            valu_selfriend_rela_34.Value = 0
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(1) Then
            valu_selfriend_rela_34.Value = 1
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(2) Then
            valu_selfriend_rela_34.Value = 2
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(3) Then
            valu_selfriend_rela_34.Value = 3
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(4) Then
            valu_selfriend_rela_34.Value = 4
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(5) Then
            valu_selfriend_rela_34.Value = 6
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(6) Then
            valu_selfriend_rela_34.Value = 7
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(7) Then
            valu_selfriend_rela_34.Value = 8
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(8) Then
            valu_selfriend_rela_34.Value = 9
        ElseIf Select_friend_rela_34.SelectedItem = Select_friend_rela_34.Items.Item(9) Then
            valu_selfriend_rela_34.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_35_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_35.SelectedIndexChanged
        If Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(0) Then
            valu_selfriend_rela_35.Value = 0
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(1) Then
            valu_selfriend_rela_35.Value = 1
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(2) Then
            valu_selfriend_rela_35.Value = 2
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(3) Then
            valu_selfriend_rela_35.Value = 3
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(4) Then
            valu_selfriend_rela_35.Value = 4
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(5) Then
            valu_selfriend_rela_35.Value = 6
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(6) Then
            valu_selfriend_rela_35.Value = 7
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(7) Then
            valu_selfriend_rela_35.Value = 8
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(8) Then
            valu_selfriend_rela_35.Value = 9
        ElseIf Select_friend_rela_35.SelectedItem = Select_friend_rela_35.Items.Item(9) Then
            valu_selfriend_rela_35.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_36_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_36.SelectedIndexChanged
        If Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(0) Then
            valu_selfriend_rela_36.Value = 0
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(1) Then
            valu_selfriend_rela_36.Value = 1
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(2) Then
            valu_selfriend_rela_36.Value = 2
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(3) Then
            valu_selfriend_rela_36.Value = 3
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(4) Then
            valu_selfriend_rela_36.Value = 4
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(5) Then
            valu_selfriend_rela_36.Value = 6
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(6) Then
            valu_selfriend_rela_36.Value = 7
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(7) Then
            valu_selfriend_rela_36.Value = 8
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(8) Then
            valu_selfriend_rela_36.Value = 9
        ElseIf Select_friend_rela_36.SelectedItem = Select_friend_rela_36.Items.Item(9) Then
            valu_selfriend_rela_36.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_37_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_37.SelectedIndexChanged
        If Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(0) Then
            valu_selfriend_rela_37.Value = 0
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(1) Then
            valu_selfriend_rela_37.Value = 1
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(2) Then
            valu_selfriend_rela_37.Value = 2
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(3) Then
            valu_selfriend_rela_37.Value = 3
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(4) Then
            valu_selfriend_rela_37.Value = 4
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(5) Then
            valu_selfriend_rela_37.Value = 6
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(6) Then
            valu_selfriend_rela_37.Value = 7
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(7) Then
            valu_selfriend_rela_37.Value = 8
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(8) Then
            valu_selfriend_rela_37.Value = 9
        ElseIf Select_friend_rela_37.SelectedItem = Select_friend_rela_37.Items.Item(9) Then
            valu_selfriend_rela_37.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_38_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_38.SelectedIndexChanged
        If Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(0) Then
            valu_selfriend_rela_38.Value = 0
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(1) Then
            valu_selfriend_rela_38.Value = 1
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(2) Then
            valu_selfriend_rela_38.Value = 2
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(3) Then
            valu_selfriend_rela_38.Value = 3
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(4) Then
            valu_selfriend_rela_38.Value = 4
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(5) Then
            valu_selfriend_rela_38.Value = 6
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(6) Then
            valu_selfriend_rela_38.Value = 7
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(7) Then
            valu_selfriend_rela_38.Value = 8
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(8) Then
            valu_selfriend_rela_38.Value = 9
        ElseIf Select_friend_rela_38.SelectedItem = Select_friend_rela_38.Items.Item(9) Then
            valu_selfriend_rela_38.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_39_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_39.SelectedIndexChanged
        If Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(0) Then
            valu_selfriend_rela_39.Value = 0
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(1) Then
            valu_selfriend_rela_39.Value = 1
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(2) Then
            valu_selfriend_rela_39.Value = 2
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(3) Then
            valu_selfriend_rela_39.Value = 3
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(4) Then
            valu_selfriend_rela_39.Value = 4
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(5) Then
            valu_selfriend_rela_39.Value = 6
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(6) Then
            valu_selfriend_rela_39.Value = 7
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(7) Then
            valu_selfriend_rela_39.Value = 8
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(8) Then
            valu_selfriend_rela_39.Value = 9
        ElseIf Select_friend_rela_39.SelectedItem = Select_friend_rela_39.Items.Item(9) Then
            valu_selfriend_rela_39.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_40_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_40.SelectedIndexChanged
        If Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(0) Then
            valu_selfriend_rela_40.Value = 0
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(1) Then
            valu_selfriend_rela_40.Value = 1
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(2) Then
            valu_selfriend_rela_40.Value = 2
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(3) Then
            valu_selfriend_rela_40.Value = 3
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(4) Then
            valu_selfriend_rela_40.Value = 4
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(5) Then
            valu_selfriend_rela_40.Value = 6
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(6) Then
            valu_selfriend_rela_40.Value = 7
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(7) Then
            valu_selfriend_rela_40.Value = 8
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(8) Then
            valu_selfriend_rela_40.Value = 9
        ElseIf Select_friend_rela_40.SelectedItem = Select_friend_rela_40.Items.Item(9) Then
            valu_selfriend_rela_40.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_41_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_41.SelectedIndexChanged
        If Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(0) Then
            valu_selfriend_rela_41.Value = 0
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(1) Then
            valu_selfriend_rela_41.Value = 1
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(2) Then
            valu_selfriend_rela_41.Value = 2
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(3) Then
            valu_selfriend_rela_41.Value = 3
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(4) Then
            valu_selfriend_rela_41.Value = 4
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(5) Then
            valu_selfriend_rela_41.Value = 6
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(6) Then
            valu_selfriend_rela_41.Value = 7
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(7) Then
            valu_selfriend_rela_41.Value = 8
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(8) Then
            valu_selfriend_rela_41.Value = 9
        ElseIf Select_friend_rela_41.SelectedItem = Select_friend_rela_41.Items.Item(9) Then
            valu_selfriend_rela_41.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_42_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_42.SelectedIndexChanged
        If Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(0) Then
            valu_selfriend_rela_42.Value = 0
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(1) Then
            valu_selfriend_rela_42.Value = 1
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(2) Then
            valu_selfriend_rela_42.Value = 2
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(3) Then
            valu_selfriend_rela_42.Value = 3
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(4) Then
            valu_selfriend_rela_42.Value = 4
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(5) Then
            valu_selfriend_rela_42.Value = 6
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(6) Then
            valu_selfriend_rela_42.Value = 7
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(7) Then
            valu_selfriend_rela_42.Value = 8
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(8) Then
            valu_selfriend_rela_42.Value = 9
        ElseIf Select_friend_rela_42.SelectedItem = Select_friend_rela_42.Items.Item(9) Then
            valu_selfriend_rela_42.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_43_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_43.SelectedIndexChanged
        If Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(0) Then
            valu_selfriend_rela_43.Value = 0
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(1) Then
            valu_selfriend_rela_43.Value = 1
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(2) Then
            valu_selfriend_rela_43.Value = 2
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(3) Then
            valu_selfriend_rela_43.Value = 3
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(4) Then
            valu_selfriend_rela_43.Value = 4
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(5) Then
            valu_selfriend_rela_43.Value = 6
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(6) Then
            valu_selfriend_rela_43.Value = 7
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(7) Then
            valu_selfriend_rela_43.Value = 8
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(8) Then
            valu_selfriend_rela_43.Value = 9
        ElseIf Select_friend_rela_43.SelectedItem = Select_friend_rela_43.Items.Item(9) Then
            valu_selfriend_rela_43.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_44_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_44.SelectedIndexChanged
        If Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(0) Then
            valu_selfriend_rela_44.Value = 0
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(1) Then
            valu_selfriend_rela_44.Value = 1
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(2) Then
            valu_selfriend_rela_44.Value = 2
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(3) Then
            valu_selfriend_rela_44.Value = 3
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(4) Then
            valu_selfriend_rela_44.Value = 4
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(5) Then
            valu_selfriend_rela_44.Value = 6
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(6) Then
            valu_selfriend_rela_44.Value = 7
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(7) Then
            valu_selfriend_rela_44.Value = 8
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(8) Then
            valu_selfriend_rela_44.Value = 9
        ElseIf Select_friend_rela_44.SelectedItem = Select_friend_rela_44.Items.Item(9) Then
            valu_selfriend_rela_44.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_45_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_45.SelectedIndexChanged
        If Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(0) Then
            valu_selfriend_rela_45.Value = 0
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(1) Then
            valu_selfriend_rela_45.Value = 1
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(2) Then
            valu_selfriend_rela_45.Value = 2
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(3) Then
            valu_selfriend_rela_45.Value = 3
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(4) Then
            valu_selfriend_rela_45.Value = 4
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(5) Then
            valu_selfriend_rela_45.Value = 6
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(6) Then
            valu_selfriend_rela_45.Value = 7
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(7) Then
            valu_selfriend_rela_45.Value = 8
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(8) Then
            valu_selfriend_rela_45.Value = 9
        ElseIf Select_friend_rela_45.SelectedItem = Select_friend_rela_45.Items.Item(9) Then
            valu_selfriend_rela_45.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_46_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_46.SelectedIndexChanged
        If Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(0) Then
            valu_selfriend_rela_46.Value = 0
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(1) Then
            valu_selfriend_rela_46.Value = 1
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(2) Then
            valu_selfriend_rela_46.Value = 2
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(3) Then
            valu_selfriend_rela_46.Value = 3
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(4) Then
            valu_selfriend_rela_46.Value = 4
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(5) Then
            valu_selfriend_rela_46.Value = 6
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(6) Then
            valu_selfriend_rela_46.Value = 7
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(7) Then
            valu_selfriend_rela_46.Value = 8
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(8) Then
            valu_selfriend_rela_46.Value = 9
        ElseIf Select_friend_rela_46.SelectedItem = Select_friend_rela_46.Items.Item(9) Then
            valu_selfriend_rela_46.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_47_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_47.SelectedIndexChanged
        If Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(0) Then
            valu_selfriend_rela_47.Value = 0
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(1) Then
            valu_selfriend_rela_47.Value = 1
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(2) Then
            valu_selfriend_rela_47.Value = 2
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(3) Then
            valu_selfriend_rela_47.Value = 3
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(4) Then
            valu_selfriend_rela_47.Value = 4
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(5) Then
            valu_selfriend_rela_47.Value = 6
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(6) Then
            valu_selfriend_rela_47.Value = 7
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(7) Then
            valu_selfriend_rela_47.Value = 8
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(8) Then
            valu_selfriend_rela_47.Value = 9
        ElseIf Select_friend_rela_47.SelectedItem = Select_friend_rela_47.Items.Item(9) Then
            valu_selfriend_rela_47.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_48_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_48.SelectedIndexChanged
        If Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(0) Then
            valu_selfriend_rela_48.Value = 0
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(1) Then
            valu_selfriend_rela_48.Value = 1
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(2) Then
            valu_selfriend_rela_48.Value = 2
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(3) Then
            valu_selfriend_rela_48.Value = 3
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(4) Then
            valu_selfriend_rela_48.Value = 4
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(5) Then
            valu_selfriend_rela_48.Value = 6
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(6) Then
            valu_selfriend_rela_48.Value = 7
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(7) Then
            valu_selfriend_rela_48.Value = 8
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(8) Then
            valu_selfriend_rela_48.Value = 9
        ElseIf Select_friend_rela_48.SelectedItem = Select_friend_rela_48.Items.Item(9) Then
            valu_selfriend_rela_48.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_49_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_49.SelectedIndexChanged
        If Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(0) Then
            valu_selfriend_rela_49.Value = 0
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(1) Then
            valu_selfriend_rela_49.Value = 1
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(2) Then
            valu_selfriend_rela_49.Value = 2
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(3) Then
            valu_selfriend_rela_49.Value = 3
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(4) Then
            valu_selfriend_rela_49.Value = 4
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(5) Then
            valu_selfriend_rela_49.Value = 6
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(6) Then
            valu_selfriend_rela_49.Value = 7
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(7) Then
            valu_selfriend_rela_49.Value = 8
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(8) Then
            valu_selfriend_rela_49.Value = 9
        ElseIf Select_friend_rela_49.SelectedItem = Select_friend_rela_49.Items.Item(9) Then
            valu_selfriend_rela_49.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_50_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_50.SelectedIndexChanged
        If Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(0) Then
            valu_selfriend_rela_50.Value = 0
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(1) Then
            valu_selfriend_rela_50.Value = 1
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(2) Then
            valu_selfriend_rela_50.Value = 2
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(3) Then
            valu_selfriend_rela_50.Value = 3
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(4) Then
            valu_selfriend_rela_50.Value = 4
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(5) Then
            valu_selfriend_rela_50.Value = 6
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(6) Then
            valu_selfriend_rela_50.Value = 7
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(7) Then
            valu_selfriend_rela_50.Value = 8
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(8) Then
            valu_selfriend_rela_50.Value = 9
        ElseIf Select_friend_rela_50.SelectedItem = Select_friend_rela_50.Items.Item(9) Then
            valu_selfriend_rela_50.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_51_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_51.SelectedIndexChanged
        If Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(0) Then
            valu_selfriend_rela_51.Value = 0
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(1) Then
            valu_selfriend_rela_51.Value = 1
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(2) Then
            valu_selfriend_rela_51.Value = 2
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(3) Then
            valu_selfriend_rela_51.Value = 3
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(4) Then
            valu_selfriend_rela_51.Value = 4
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(5) Then
            valu_selfriend_rela_51.Value = 6
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(6) Then
            valu_selfriend_rela_51.Value = 7
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(7) Then
            valu_selfriend_rela_51.Value = 8
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(8) Then
            valu_selfriend_rela_51.Value = 9
        ElseIf Select_friend_rela_51.SelectedItem = Select_friend_rela_51.Items.Item(9) Then
            valu_selfriend_rela_51.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_52_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_52.SelectedIndexChanged
        If Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(0) Then
            valu_selfriend_rela_52.Value = 0
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(1) Then
            valu_selfriend_rela_52.Value = 1
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(2) Then
            valu_selfriend_rela_52.Value = 2
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(3) Then
            valu_selfriend_rela_52.Value = 3
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(4) Then
            valu_selfriend_rela_52.Value = 4
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(5) Then
            valu_selfriend_rela_52.Value = 6
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(6) Then
            valu_selfriend_rela_52.Value = 7
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(7) Then
            valu_selfriend_rela_52.Value = 8
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(8) Then
            valu_selfriend_rela_52.Value = 9
        ElseIf Select_friend_rela_52.SelectedItem = Select_friend_rela_52.Items.Item(9) Then
            valu_selfriend_rela_52.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_53_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_53.SelectedIndexChanged
        If Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(0) Then
            valu_selfriend_rela_53.Value = 0
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(1) Then
            valu_selfriend_rela_53.Value = 1
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(2) Then
            valu_selfriend_rela_53.Value = 2
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(3) Then
            valu_selfriend_rela_53.Value = 3
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(4) Then
            valu_selfriend_rela_53.Value = 4
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(5) Then
            valu_selfriend_rela_53.Value = 6
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(6) Then
            valu_selfriend_rela_53.Value = 7
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(7) Then
            valu_selfriend_rela_53.Value = 8
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(8) Then
            valu_selfriend_rela_53.Value = 9
        ElseIf Select_friend_rela_53.SelectedItem = Select_friend_rela_53.Items.Item(9) Then
            valu_selfriend_rela_53.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_54_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_54.SelectedIndexChanged
        If Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(0) Then
            valu_selfriend_rela_54.Value = 0
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(1) Then
            valu_selfriend_rela_54.Value = 1
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(2) Then
            valu_selfriend_rela_54.Value = 2
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(3) Then
            valu_selfriend_rela_54.Value = 3
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(4) Then
            valu_selfriend_rela_54.Value = 4
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(5) Then
            valu_selfriend_rela_54.Value = 6
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(6) Then
            valu_selfriend_rela_54.Value = 7
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(7) Then
            valu_selfriend_rela_54.Value = 8
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(8) Then
            valu_selfriend_rela_54.Value = 9
        ElseIf Select_friend_rela_54.SelectedItem = Select_friend_rela_54.Items.Item(9) Then
            valu_selfriend_rela_54.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_55_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_55.SelectedIndexChanged
        If Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(0) Then
            valu_selfriend_rela_55.Value = 0
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(1) Then
            valu_selfriend_rela_55.Value = 1
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(2) Then
            valu_selfriend_rela_55.Value = 2
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(3) Then
            valu_selfriend_rela_55.Value = 3
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(4) Then
            valu_selfriend_rela_55.Value = 4
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(5) Then
            valu_selfriend_rela_55.Value = 6
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(6) Then
            valu_selfriend_rela_55.Value = 7
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(7) Then
            valu_selfriend_rela_55.Value = 8
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(8) Then
            valu_selfriend_rela_55.Value = 9
        ElseIf Select_friend_rela_55.SelectedItem = Select_friend_rela_55.Items.Item(9) Then
            valu_selfriend_rela_55.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_56_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_56.SelectedIndexChanged
        If Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(0) Then
            valu_selfriend_rela_56.Value = 0
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(1) Then
            valu_selfriend_rela_56.Value = 1
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(2) Then
            valu_selfriend_rela_56.Value = 2
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(3) Then
            valu_selfriend_rela_56.Value = 3
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(4) Then
            valu_selfriend_rela_56.Value = 4
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(5) Then
            valu_selfriend_rela_56.Value = 6
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(6) Then
            valu_selfriend_rela_56.Value = 7
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(7) Then
            valu_selfriend_rela_56.Value = 8
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(8) Then
            valu_selfriend_rela_56.Value = 9
        ElseIf Select_friend_rela_56.SelectedItem = Select_friend_rela_56.Items.Item(9) Then
            valu_selfriend_rela_56.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_57_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_57.SelectedIndexChanged
        If Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(0) Then
            valu_selfriend_rela_57.Value = 0
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(1) Then
            valu_selfriend_rela_57.Value = 1
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(2) Then
            valu_selfriend_rela_57.Value = 2
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(3) Then
            valu_selfriend_rela_57.Value = 3
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(4) Then
            valu_selfriend_rela_57.Value = 4
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(5) Then
            valu_selfriend_rela_57.Value = 6
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(6) Then
            valu_selfriend_rela_57.Value = 7
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(7) Then
            valu_selfriend_rela_57.Value = 8
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(8) Then
            valu_selfriend_rela_57.Value = 9
        ElseIf Select_friend_rela_57.SelectedItem = Select_friend_rela_57.Items.Item(9) Then
            valu_selfriend_rela_57.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_58_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_58.SelectedIndexChanged
        If Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(0) Then
            valu_selfriend_rela_58.Value = 0
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(1) Then
            valu_selfriend_rela_58.Value = 1
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(2) Then
            valu_selfriend_rela_58.Value = 2
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(3) Then
            valu_selfriend_rela_58.Value = 3
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(4) Then
            valu_selfriend_rela_58.Value = 4
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(5) Then
            valu_selfriend_rela_58.Value = 6
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(6) Then
            valu_selfriend_rela_58.Value = 7
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(7) Then
            valu_selfriend_rela_58.Value = 8
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(8) Then
            valu_selfriend_rela_58.Value = 9
        ElseIf Select_friend_rela_58.SelectedItem = Select_friend_rela_58.Items.Item(9) Then
            valu_selfriend_rela_58.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_59_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_59.SelectedIndexChanged
        If Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(0) Then
            valu_selfriend_rela_59.Value = 0
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(1) Then
            valu_selfriend_rela_59.Value = 1
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(2) Then
            valu_selfriend_rela_59.Value = 2
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(3) Then
            valu_selfriend_rela_59.Value = 3
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(4) Then
            valu_selfriend_rela_59.Value = 4
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(5) Then
            valu_selfriend_rela_59.Value = 6
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(6) Then
            valu_selfriend_rela_59.Value = 7
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(7) Then
            valu_selfriend_rela_59.Value = 8
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(8) Then
            valu_selfriend_rela_59.Value = 9
        ElseIf Select_friend_rela_59.SelectedItem = Select_friend_rela_59.Items.Item(9) Then
            valu_selfriend_rela_59.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_60_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_60.SelectedIndexChanged
        If Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(0) Then
            valu_selfriend_rela_60.Value = 0
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(1) Then
            valu_selfriend_rela_60.Value = 1
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(2) Then
            valu_selfriend_rela_60.Value = 2
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(3) Then
            valu_selfriend_rela_60.Value = 3
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(4) Then
            valu_selfriend_rela_60.Value = 4
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(5) Then
            valu_selfriend_rela_60.Value = 6
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(6) Then
            valu_selfriend_rela_60.Value = 7
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(7) Then
            valu_selfriend_rela_60.Value = 8
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(8) Then
            valu_selfriend_rela_60.Value = 9
        ElseIf Select_friend_rela_60.SelectedItem = Select_friend_rela_60.Items.Item(9) Then
            valu_selfriend_rela_60.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_61_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_61.SelectedIndexChanged
        If Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(0) Then
            valu_selfriend_rela_61.Value = 0
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(1) Then
            valu_selfriend_rela_61.Value = 1
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(2) Then
            valu_selfriend_rela_61.Value = 2
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(3) Then
            valu_selfriend_rela_61.Value = 3
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(4) Then
            valu_selfriend_rela_61.Value = 4
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(5) Then
            valu_selfriend_rela_61.Value = 6
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(6) Then
            valu_selfriend_rela_61.Value = 7
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(7) Then
            valu_selfriend_rela_61.Value = 8
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(8) Then
            valu_selfriend_rela_61.Value = 9
        ElseIf Select_friend_rela_61.SelectedItem = Select_friend_rela_61.Items.Item(9) Then
            valu_selfriend_rela_61.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_62_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_62.SelectedIndexChanged
        If Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(0) Then
            valu_selfriend_rela_62.Value = 0
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(1) Then
            valu_selfriend_rela_62.Value = 1
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(2) Then
            valu_selfriend_rela_62.Value = 2
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(3) Then
            valu_selfriend_rela_62.Value = 3
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(4) Then
            valu_selfriend_rela_62.Value = 4
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(5) Then
            valu_selfriend_rela_62.Value = 6
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(6) Then
            valu_selfriend_rela_62.Value = 7
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(7) Then
            valu_selfriend_rela_62.Value = 8
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(8) Then
            valu_selfriend_rela_62.Value = 9
        ElseIf Select_friend_rela_62.SelectedItem = Select_friend_rela_62.Items.Item(9) Then
            valu_selfriend_rela_62.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_63_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_63.SelectedIndexChanged
        If Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(0) Then
            valu_selfriend_rela_63.Value = 0
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(1) Then
            valu_selfriend_rela_63.Value = 1
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(2) Then
            valu_selfriend_rela_63.Value = 2
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(3) Then
            valu_selfriend_rela_63.Value = 3
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(4) Then
            valu_selfriend_rela_63.Value = 4
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(5) Then
            valu_selfriend_rela_63.Value = 6
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(6) Then
            valu_selfriend_rela_63.Value = 7
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(7) Then
            valu_selfriend_rela_63.Value = 8
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(8) Then
            valu_selfriend_rela_63.Value = 9
        ElseIf Select_friend_rela_63.SelectedItem = Select_friend_rela_63.Items.Item(9) Then
            valu_selfriend_rela_63.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_64_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_64.SelectedIndexChanged
        If Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(0) Then
            valu_selfriend_rela_64.Value = 0
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(1) Then
            valu_selfriend_rela_64.Value = 1
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(2) Then
            valu_selfriend_rela_64.Value = 2
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(3) Then
            valu_selfriend_rela_64.Value = 3
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(4) Then
            valu_selfriend_rela_64.Value = 4
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(5) Then
            valu_selfriend_rela_64.Value = 6
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(6) Then
            valu_selfriend_rela_64.Value = 7
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(7) Then
            valu_selfriend_rela_64.Value = 8
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(8) Then
            valu_selfriend_rela_64.Value = 9
        ElseIf Select_friend_rela_64.SelectedItem = Select_friend_rela_64.Items.Item(9) Then
            valu_selfriend_rela_64.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_65_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_65.SelectedIndexChanged
        If Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(0) Then
            valu_selfriend_rela_65.Value = 0
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(1) Then
            valu_selfriend_rela_65.Value = 1
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(2) Then
            valu_selfriend_rela_65.Value = 2
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(3) Then
            valu_selfriend_rela_65.Value = 3
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(4) Then
            valu_selfriend_rela_65.Value = 4
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(5) Then
            valu_selfriend_rela_65.Value = 6
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(6) Then
            valu_selfriend_rela_65.Value = 7
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(7) Then
            valu_selfriend_rela_65.Value = 8
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(8) Then
            valu_selfriend_rela_65.Value = 9
        ElseIf Select_friend_rela_65.SelectedItem = Select_friend_rela_65.Items.Item(9) Then
            valu_selfriend_rela_65.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_66_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_66.SelectedIndexChanged
        If Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(0) Then
            valu_selfriend_rela_66.Value = 0
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(1) Then
            valu_selfriend_rela_66.Value = 1
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(2) Then
            valu_selfriend_rela_66.Value = 2
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(3) Then
            valu_selfriend_rela_66.Value = 3
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(4) Then
            valu_selfriend_rela_66.Value = 4
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(5) Then
            valu_selfriend_rela_66.Value = 6
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(6) Then
            valu_selfriend_rela_66.Value = 7
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(7) Then
            valu_selfriend_rela_66.Value = 8
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(8) Then
            valu_selfriend_rela_66.Value = 9
        ElseIf Select_friend_rela_66.SelectedItem = Select_friend_rela_66.Items.Item(9) Then
            valu_selfriend_rela_66.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_67_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_67.SelectedIndexChanged
        If Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(0) Then
            valu_selfriend_rela_67.Value = 0
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(1) Then
            valu_selfriend_rela_67.Value = 1
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(2) Then
            valu_selfriend_rela_67.Value = 2
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(3) Then
            valu_selfriend_rela_67.Value = 3
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(4) Then
            valu_selfriend_rela_67.Value = 4
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(5) Then
            valu_selfriend_rela_67.Value = 6
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(6) Then
            valu_selfriend_rela_67.Value = 7
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(7) Then
            valu_selfriend_rela_67.Value = 8
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(8) Then
            valu_selfriend_rela_67.Value = 9
        ElseIf Select_friend_rela_67.SelectedItem = Select_friend_rela_67.Items.Item(9) Then
            valu_selfriend_rela_67.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_68_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_68.SelectedIndexChanged
        If Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(0) Then
            valu_selfriend_rela_68.Value = 0
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(1) Then
            valu_selfriend_rela_68.Value = 1
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(2) Then
            valu_selfriend_rela_68.Value = 2
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(3) Then
            valu_selfriend_rela_68.Value = 3
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(4) Then
            valu_selfriend_rela_68.Value = 4
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(5) Then
            valu_selfriend_rela_68.Value = 6
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(6) Then
            valu_selfriend_rela_68.Value = 7
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(7) Then
            valu_selfriend_rela_68.Value = 8
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(8) Then
            valu_selfriend_rela_68.Value = 9
        ElseIf Select_friend_rela_68.SelectedItem = Select_friend_rela_68.Items.Item(9) Then
            valu_selfriend_rela_68.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_69_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_69.SelectedIndexChanged
        If Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(0) Then
            valu_selfriend_rela_69.Value = 0
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(1) Then
            valu_selfriend_rela_69.Value = 1
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(2) Then
            valu_selfriend_rela_69.Value = 2
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(3) Then
            valu_selfriend_rela_69.Value = 3
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(4) Then
            valu_selfriend_rela_69.Value = 4
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(5) Then
            valu_selfriend_rela_69.Value = 6
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(6) Then
            valu_selfriend_rela_69.Value = 7
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(7) Then
            valu_selfriend_rela_69.Value = 8
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(8) Then
            valu_selfriend_rela_69.Value = 9
        ElseIf Select_friend_rela_69.SelectedItem = Select_friend_rela_69.Items.Item(9) Then
            valu_selfriend_rela_69.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_70_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_70.SelectedIndexChanged
        If Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(0) Then
            valu_selfriend_rela_70.Value = 0
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(1) Then
            valu_selfriend_rela_70.Value = 1
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(2) Then
            valu_selfriend_rela_70.Value = 2
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(3) Then
            valu_selfriend_rela_70.Value = 3
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(4) Then
            valu_selfriend_rela_70.Value = 4
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(5) Then
            valu_selfriend_rela_70.Value = 6
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(6) Then
            valu_selfriend_rela_70.Value = 7
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(7) Then
            valu_selfriend_rela_70.Value = 8
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(8) Then
            valu_selfriend_rela_70.Value = 9
        ElseIf Select_friend_rela_70.SelectedItem = Select_friend_rela_70.Items.Item(9) Then
            valu_selfriend_rela_70.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_71_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_71.SelectedIndexChanged
        If Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(0) Then
            valu_selfriend_rela_71.Value = 0
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(1) Then
            valu_selfriend_rela_71.Value = 1
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(2) Then
            valu_selfriend_rela_71.Value = 2
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(3) Then
            valu_selfriend_rela_71.Value = 3
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(4) Then
            valu_selfriend_rela_71.Value = 4
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(5) Then
            valu_selfriend_rela_71.Value = 6
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(6) Then
            valu_selfriend_rela_71.Value = 7
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(7) Then
            valu_selfriend_rela_71.Value = 8
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(8) Then
            valu_selfriend_rela_71.Value = 9
        ElseIf Select_friend_rela_71.SelectedItem = Select_friend_rela_71.Items.Item(9) Then
            valu_selfriend_rela_71.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_72_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_72.SelectedIndexChanged
        If Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(0) Then
            valu_selfriend_rela_72.Value = 0
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(1) Then
            valu_selfriend_rela_72.Value = 1
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(2) Then
            valu_selfriend_rela_72.Value = 2
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(3) Then
            valu_selfriend_rela_72.Value = 3
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(4) Then
            valu_selfriend_rela_72.Value = 4
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(5) Then
            valu_selfriend_rela_72.Value = 6
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(6) Then
            valu_selfriend_rela_72.Value = 7
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(7) Then
            valu_selfriend_rela_72.Value = 8
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(8) Then
            valu_selfriend_rela_72.Value = 9
        ElseIf Select_friend_rela_72.SelectedItem = Select_friend_rela_72.Items.Item(9) Then
            valu_selfriend_rela_72.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_73_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_73.SelectedIndexChanged
        If Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(0) Then
            valu_selfriend_rela_73.Value = 0
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(1) Then
            valu_selfriend_rela_73.Value = 1
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(2) Then
            valu_selfriend_rela_73.Value = 2
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(3) Then
            valu_selfriend_rela_73.Value = 3
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(4) Then
            valu_selfriend_rela_73.Value = 4
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(5) Then
            valu_selfriend_rela_73.Value = 6
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(6) Then
            valu_selfriend_rela_73.Value = 7
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(7) Then
            valu_selfriend_rela_73.Value = 8
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(8) Then
            valu_selfriend_rela_73.Value = 9
        ElseIf Select_friend_rela_73.SelectedItem = Select_friend_rela_73.Items.Item(9) Then
            valu_selfriend_rela_73.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_74_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_74.SelectedIndexChanged
        If Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(0) Then
            valu_selfriend_rela_74.Value = 0
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(1) Then
            valu_selfriend_rela_74.Value = 1
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(2) Then
            valu_selfriend_rela_74.Value = 2
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(3) Then
            valu_selfriend_rela_74.Value = 3
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(4) Then
            valu_selfriend_rela_74.Value = 4
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(5) Then
            valu_selfriend_rela_74.Value = 6
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(6) Then
            valu_selfriend_rela_74.Value = 7
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(7) Then
            valu_selfriend_rela_74.Value = 8
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(8) Then
            valu_selfriend_rela_74.Value = 9
        ElseIf Select_friend_rela_74.SelectedItem = Select_friend_rela_74.Items.Item(9) Then
            valu_selfriend_rela_74.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_75_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_75.SelectedIndexChanged
        If Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(0) Then
            valu_selfriend_rela_75.Value = 0
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(1) Then
            valu_selfriend_rela_75.Value = 1
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(2) Then
            valu_selfriend_rela_75.Value = 2
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(3) Then
            valu_selfriend_rela_75.Value = 3
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(4) Then
            valu_selfriend_rela_75.Value = 4
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(5) Then
            valu_selfriend_rela_75.Value = 6
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(6) Then
            valu_selfriend_rela_75.Value = 7
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(7) Then
            valu_selfriend_rela_75.Value = 8
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(8) Then
            valu_selfriend_rela_75.Value = 9
        ElseIf Select_friend_rela_75.SelectedItem = Select_friend_rela_75.Items.Item(9) Then
            valu_selfriend_rela_75.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_76_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_76.SelectedIndexChanged
        If Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(0) Then
            valu_selfriend_rela_76.Value = 0
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(1) Then
            valu_selfriend_rela_76.Value = 1
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(2) Then
            valu_selfriend_rela_76.Value = 2
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(3) Then
            valu_selfriend_rela_76.Value = 3
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(4) Then
            valu_selfriend_rela_76.Value = 4
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(5) Then
            valu_selfriend_rela_76.Value = 6
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(6) Then
            valu_selfriend_rela_76.Value = 7
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(7) Then
            valu_selfriend_rela_76.Value = 8
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(8) Then
            valu_selfriend_rela_76.Value = 9
        ElseIf Select_friend_rela_76.SelectedItem = Select_friend_rela_76.Items.Item(9) Then
            valu_selfriend_rela_76.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_77_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_77.SelectedIndexChanged
        If Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(0) Then
            valu_selfriend_rela_77.Value = 0
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(1) Then
            valu_selfriend_rela_77.Value = 1
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(2) Then
            valu_selfriend_rela_77.Value = 2
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(3) Then
            valu_selfriend_rela_77.Value = 3
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(4) Then
            valu_selfriend_rela_77.Value = 4
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(5) Then
            valu_selfriend_rela_77.Value = 6
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(6) Then
            valu_selfriend_rela_77.Value = 7
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(7) Then
            valu_selfriend_rela_77.Value = 8
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(8) Then
            valu_selfriend_rela_77.Value = 9
        ElseIf Select_friend_rela_77.SelectedItem = Select_friend_rela_77.Items.Item(9) Then
            valu_selfriend_rela_77.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_78_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_78.SelectedIndexChanged
        If Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(0) Then
            valu_selfriend_rela_78.Value = 0
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(1) Then
            valu_selfriend_rela_78.Value = 1
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(2) Then
            valu_selfriend_rela_78.Value = 2
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(3) Then
            valu_selfriend_rela_78.Value = 3
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(4) Then
            valu_selfriend_rela_78.Value = 4
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(5) Then
            valu_selfriend_rela_78.Value = 6
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(6) Then
            valu_selfriend_rela_78.Value = 7
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(7) Then
            valu_selfriend_rela_78.Value = 8
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(8) Then
            valu_selfriend_rela_78.Value = 9
        ElseIf Select_friend_rela_78.SelectedItem = Select_friend_rela_78.Items.Item(9) Then
            valu_selfriend_rela_78.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_79_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_79.SelectedIndexChanged
        If Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(0) Then
            valu_selfriend_rela_79.Value = 0
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(1) Then
            valu_selfriend_rela_79.Value = 1
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(2) Then
            valu_selfriend_rela_79.Value = 2
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(3) Then
            valu_selfriend_rela_79.Value = 3
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(4) Then
            valu_selfriend_rela_79.Value = 4
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(5) Then
            valu_selfriend_rela_79.Value = 6
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(6) Then
            valu_selfriend_rela_79.Value = 7
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(7) Then
            valu_selfriend_rela_79.Value = 8
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(8) Then
            valu_selfriend_rela_79.Value = 9
        ElseIf Select_friend_rela_79.SelectedItem = Select_friend_rela_79.Items.Item(9) Then
            valu_selfriend_rela_79.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_80_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_80.SelectedIndexChanged
        If Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(0) Then
            valu_selfriend_rela_80.Value = 0
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(1) Then
            valu_selfriend_rela_80.Value = 1
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(2) Then
            valu_selfriend_rela_80.Value = 2
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(3) Then
            valu_selfriend_rela_80.Value = 3
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(4) Then
            valu_selfriend_rela_80.Value = 4
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(5) Then
            valu_selfriend_rela_80.Value = 6
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(6) Then
            valu_selfriend_rela_80.Value = 7
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(7) Then
            valu_selfriend_rela_80.Value = 8
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(8) Then
            valu_selfriend_rela_80.Value = 9
        ElseIf Select_friend_rela_80.SelectedItem = Select_friend_rela_80.Items.Item(9) Then
            valu_selfriend_rela_80.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_81_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_81.SelectedIndexChanged
        If Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(0) Then
            valu_selfriend_rela_81.Value = 0
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(1) Then
            valu_selfriend_rela_81.Value = 1
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(2) Then
            valu_selfriend_rela_81.Value = 2
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(3) Then
            valu_selfriend_rela_81.Value = 3
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(4) Then
            valu_selfriend_rela_81.Value = 4
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(5) Then
            valu_selfriend_rela_81.Value = 6
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(6) Then
            valu_selfriend_rela_81.Value = 7
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(7) Then
            valu_selfriend_rela_81.Value = 8
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(8) Then
            valu_selfriend_rela_81.Value = 9
        ElseIf Select_friend_rela_81.SelectedItem = Select_friend_rela_81.Items.Item(9) Then
            valu_selfriend_rela_81.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_82_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_82.SelectedIndexChanged
        If Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(0) Then
            valu_selfriend_rela_82.Value = 0
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(1) Then
            valu_selfriend_rela_82.Value = 1
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(2) Then
            valu_selfriend_rela_82.Value = 2
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(3) Then
            valu_selfriend_rela_82.Value = 3
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(4) Then
            valu_selfriend_rela_82.Value = 4
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(5) Then
            valu_selfriend_rela_82.Value = 6
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(6) Then
            valu_selfriend_rela_82.Value = 7
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(7) Then
            valu_selfriend_rela_82.Value = 8
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(8) Then
            valu_selfriend_rela_82.Value = 9
        ElseIf Select_friend_rela_82.SelectedItem = Select_friend_rela_82.Items.Item(9) Then
            valu_selfriend_rela_82.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_83_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_83.SelectedIndexChanged
        If Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(0) Then
            valu_selfriend_rela_83.Value = 0
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(1) Then
            valu_selfriend_rela_83.Value = 1
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(2) Then
            valu_selfriend_rela_83.Value = 2
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(3) Then
            valu_selfriend_rela_83.Value = 3
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(4) Then
            valu_selfriend_rela_83.Value = 4
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(5) Then
            valu_selfriend_rela_83.Value = 6
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(6) Then
            valu_selfriend_rela_83.Value = 7
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(7) Then
            valu_selfriend_rela_83.Value = 8
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(8) Then
            valu_selfriend_rela_83.Value = 9
        ElseIf Select_friend_rela_83.SelectedItem = Select_friend_rela_83.Items.Item(9) Then
            valu_selfriend_rela_83.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_84_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_84.SelectedIndexChanged
        If Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(0) Then
            valu_selfriend_rela_84.Value = 0
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(1) Then
            valu_selfriend_rela_84.Value = 1
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(2) Then
            valu_selfriend_rela_84.Value = 2
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(3) Then
            valu_selfriend_rela_84.Value = 3
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(4) Then
            valu_selfriend_rela_84.Value = 4
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(5) Then
            valu_selfriend_rela_84.Value = 6
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(6) Then
            valu_selfriend_rela_84.Value = 7
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(7) Then
            valu_selfriend_rela_84.Value = 8
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(8) Then
            valu_selfriend_rela_84.Value = 9
        ElseIf Select_friend_rela_84.SelectedItem = Select_friend_rela_84.Items.Item(9) Then
            valu_selfriend_rela_84.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_85_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_85.SelectedIndexChanged
        If Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(0) Then
            valu_selfriend_rela_85.Value = 0
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(1) Then
            valu_selfriend_rela_85.Value = 1
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(2) Then
            valu_selfriend_rela_85.Value = 2
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(3) Then
            valu_selfriend_rela_85.Value = 3
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(4) Then
            valu_selfriend_rela_85.Value = 4
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(5) Then
            valu_selfriend_rela_85.Value = 6
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(6) Then
            valu_selfriend_rela_85.Value = 7
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(7) Then
            valu_selfriend_rela_85.Value = 8
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(8) Then
            valu_selfriend_rela_85.Value = 9
        ElseIf Select_friend_rela_85.SelectedItem = Select_friend_rela_85.Items.Item(9) Then
            valu_selfriend_rela_85.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_86_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_86.SelectedIndexChanged
        If Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(0) Then
            valu_selfriend_rela_86.Value = 0
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(1) Then
            valu_selfriend_rela_86.Value = 1
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(2) Then
            valu_selfriend_rela_86.Value = 2
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(3) Then
            valu_selfriend_rela_86.Value = 3
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(4) Then
            valu_selfriend_rela_86.Value = 4
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(5) Then
            valu_selfriend_rela_86.Value = 6
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(6) Then
            valu_selfriend_rela_86.Value = 7
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(7) Then
            valu_selfriend_rela_86.Value = 8
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(8) Then
            valu_selfriend_rela_86.Value = 9
        ElseIf Select_friend_rela_86.SelectedItem = Select_friend_rela_86.Items.Item(9) Then
            valu_selfriend_rela_86.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_87_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_87.SelectedIndexChanged
        If Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(0) Then
            valu_selfriend_rela_87.Value = 0
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(1) Then
            valu_selfriend_rela_87.Value = 1
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(2) Then
            valu_selfriend_rela_87.Value = 2
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(3) Then
            valu_selfriend_rela_87.Value = 3
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(4) Then
            valu_selfriend_rela_87.Value = 4
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(5) Then
            valu_selfriend_rela_87.Value = 6
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(6) Then
            valu_selfriend_rela_87.Value = 7
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(7) Then
            valu_selfriend_rela_87.Value = 8
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(8) Then
            valu_selfriend_rela_87.Value = 9
        ElseIf Select_friend_rela_87.SelectedItem = Select_friend_rela_87.Items.Item(9) Then
            valu_selfriend_rela_87.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_88_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_88.SelectedIndexChanged
        If Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(0) Then
            valu_selfriend_rela_88.Value = 0
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(1) Then
            valu_selfriend_rela_88.Value = 1
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(2) Then
            valu_selfriend_rela_88.Value = 2
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(3) Then
            valu_selfriend_rela_88.Value = 3
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(4) Then
            valu_selfriend_rela_88.Value = 4
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(5) Then
            valu_selfriend_rela_88.Value = 6
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(6) Then
            valu_selfriend_rela_88.Value = 7
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(7) Then
            valu_selfriend_rela_88.Value = 8
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(8) Then
            valu_selfriend_rela_88.Value = 9
        ElseIf Select_friend_rela_88.SelectedItem = Select_friend_rela_88.Items.Item(9) Then
            valu_selfriend_rela_88.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_89_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_89.SelectedIndexChanged
        If Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(0) Then
            valu_selfriend_rela_89.Value = 0
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(1) Then
            valu_selfriend_rela_89.Value = 1
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(2) Then
            valu_selfriend_rela_89.Value = 2
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(3) Then
            valu_selfriend_rela_89.Value = 3
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(4) Then
            valu_selfriend_rela_89.Value = 4
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(5) Then
            valu_selfriend_rela_89.Value = 6
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(6) Then
            valu_selfriend_rela_89.Value = 7
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(7) Then
            valu_selfriend_rela_89.Value = 8
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(8) Then
            valu_selfriend_rela_89.Value = 9
        ElseIf Select_friend_rela_89.SelectedItem = Select_friend_rela_89.Items.Item(9) Then
            valu_selfriend_rela_89.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_90_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_90.SelectedIndexChanged
        If Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(0) Then
            valu_selfriend_rela_90.Value = 0
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(1) Then
            valu_selfriend_rela_90.Value = 1
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(2) Then
            valu_selfriend_rela_90.Value = 2
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(3) Then
            valu_selfriend_rela_90.Value = 3
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(4) Then
            valu_selfriend_rela_90.Value = 4
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(5) Then
            valu_selfriend_rela_90.Value = 6
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(6) Then
            valu_selfriend_rela_90.Value = 7
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(7) Then
            valu_selfriend_rela_90.Value = 8
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(8) Then
            valu_selfriend_rela_90.Value = 9
        ElseIf Select_friend_rela_90.SelectedItem = Select_friend_rela_90.Items.Item(9) Then
            valu_selfriend_rela_90.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_91_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_91.SelectedIndexChanged
        If Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(0) Then
            valu_selfriend_rela_91.Value = 0
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(1) Then
            valu_selfriend_rela_91.Value = 1
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(2) Then
            valu_selfriend_rela_91.Value = 2
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(3) Then
            valu_selfriend_rela_91.Value = 3
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(4) Then
            valu_selfriend_rela_91.Value = 4
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(5) Then
            valu_selfriend_rela_91.Value = 6
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(6) Then
            valu_selfriend_rela_91.Value = 7
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(7) Then
            valu_selfriend_rela_91.Value = 8
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(8) Then
            valu_selfriend_rela_91.Value = 9
        ElseIf Select_friend_rela_91.SelectedItem = Select_friend_rela_91.Items.Item(9) Then
            valu_selfriend_rela_91.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_92_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_92.SelectedIndexChanged
        If Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(0) Then
            valu_selfriend_rela_92.Value = 0
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(1) Then
            valu_selfriend_rela_92.Value = 1
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(2) Then
            valu_selfriend_rela_92.Value = 2
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(3) Then
            valu_selfriend_rela_92.Value = 3
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(4) Then
            valu_selfriend_rela_92.Value = 4
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(5) Then
            valu_selfriend_rela_92.Value = 6
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(6) Then
            valu_selfriend_rela_92.Value = 7
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(7) Then
            valu_selfriend_rela_92.Value = 8
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(8) Then
            valu_selfriend_rela_92.Value = 9
        ElseIf Select_friend_rela_92.SelectedItem = Select_friend_rela_92.Items.Item(9) Then
            valu_selfriend_rela_92.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_93_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_93.SelectedIndexChanged
        If Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(0) Then
            valu_selfriend_rela_93.Value = 0
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(1) Then
            valu_selfriend_rela_93.Value = 1
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(2) Then
            valu_selfriend_rela_93.Value = 2
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(3) Then
            valu_selfriend_rela_93.Value = 3
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(4) Then
            valu_selfriend_rela_93.Value = 4
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(5) Then
            valu_selfriend_rela_93.Value = 6
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(6) Then
            valu_selfriend_rela_93.Value = 7
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(7) Then
            valu_selfriend_rela_93.Value = 8
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(8) Then
            valu_selfriend_rela_93.Value = 9
        ElseIf Select_friend_rela_93.SelectedItem = Select_friend_rela_93.Items.Item(9) Then
            valu_selfriend_rela_93.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_94_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_94.SelectedIndexChanged
        If Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(0) Then
            valu_selfriend_rela_94.Value = 0
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(1) Then
            valu_selfriend_rela_94.Value = 1
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(2) Then
            valu_selfriend_rela_94.Value = 2
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(3) Then
            valu_selfriend_rela_94.Value = 3
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(4) Then
            valu_selfriend_rela_94.Value = 4
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(5) Then
            valu_selfriend_rela_94.Value = 6
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(6) Then
            valu_selfriend_rela_94.Value = 7
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(7) Then
            valu_selfriend_rela_94.Value = 8
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(8) Then
            valu_selfriend_rela_94.Value = 9
        ElseIf Select_friend_rela_94.SelectedItem = Select_friend_rela_94.Items.Item(9) Then
            valu_selfriend_rela_94.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_95_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_95.SelectedIndexChanged
        If Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(0) Then
            valu_selfriend_rela_95.Value = 0
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(1) Then
            valu_selfriend_rela_95.Value = 1
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(2) Then
            valu_selfriend_rela_95.Value = 2
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(3) Then
            valu_selfriend_rela_95.Value = 3
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(4) Then
            valu_selfriend_rela_95.Value = 4
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(5) Then
            valu_selfriend_rela_95.Value = 6
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(6) Then
            valu_selfriend_rela_95.Value = 7
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(7) Then
            valu_selfriend_rela_95.Value = 8
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(8) Then
            valu_selfriend_rela_95.Value = 9
        ElseIf Select_friend_rela_95.SelectedItem = Select_friend_rela_95.Items.Item(9) Then
            valu_selfriend_rela_95.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_96_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_96.SelectedIndexChanged
        If Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(0) Then
            valu_selfriend_rela_96.Value = 0
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(1) Then
            valu_selfriend_rela_96.Value = 1
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(2) Then
            valu_selfriend_rela_96.Value = 2
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(3) Then
            valu_selfriend_rela_96.Value = 3
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(4) Then
            valu_selfriend_rela_96.Value = 4
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(5) Then
            valu_selfriend_rela_96.Value = 6
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(6) Then
            valu_selfriend_rela_96.Value = 7
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(7) Then
            valu_selfriend_rela_96.Value = 8
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(8) Then
            valu_selfriend_rela_96.Value = 9
        ElseIf Select_friend_rela_96.SelectedItem = Select_friend_rela_96.Items.Item(9) Then
            valu_selfriend_rela_96.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_97_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_97.SelectedIndexChanged
        If Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(0) Then
            valu_selfriend_rela_97.Value = 0
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(1) Then
            valu_selfriend_rela_97.Value = 1
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(2) Then
            valu_selfriend_rela_97.Value = 2
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(3) Then
            valu_selfriend_rela_97.Value = 3
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(4) Then
            valu_selfriend_rela_97.Value = 4
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(5) Then
            valu_selfriend_rela_97.Value = 6
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(6) Then
            valu_selfriend_rela_97.Value = 7
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(7) Then
            valu_selfriend_rela_97.Value = 8
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(8) Then
            valu_selfriend_rela_97.Value = 9
        ElseIf Select_friend_rela_97.SelectedItem = Select_friend_rela_97.Items.Item(9) Then
            valu_selfriend_rela_97.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_98_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_98.SelectedIndexChanged
        If Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(0) Then
            valu_selfriend_rela_98.Value = 0
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(1) Then
            valu_selfriend_rela_98.Value = 1
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(2) Then
            valu_selfriend_rela_98.Value = 2
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(3) Then
            valu_selfriend_rela_98.Value = 3
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(4) Then
            valu_selfriend_rela_98.Value = 4
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(5) Then
            valu_selfriend_rela_98.Value = 6
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(6) Then
            valu_selfriend_rela_98.Value = 7
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(7) Then
            valu_selfriend_rela_98.Value = 8
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(8) Then
            valu_selfriend_rela_98.Value = 9
        ElseIf Select_friend_rela_98.SelectedItem = Select_friend_rela_98.Items.Item(9) Then
            valu_selfriend_rela_98.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_99_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_99.SelectedIndexChanged
        If Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(0) Then
            valu_selfriend_rela_99.Value = 0
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(1) Then
            valu_selfriend_rela_99.Value = 1
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(2) Then
            valu_selfriend_rela_99.Value = 2
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(3) Then
            valu_selfriend_rela_99.Value = 3
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(4) Then
            valu_selfriend_rela_99.Value = 4
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(5) Then
            valu_selfriend_rela_99.Value = 6
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(6) Then
            valu_selfriend_rela_99.Value = 7
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(7) Then
            valu_selfriend_rela_99.Value = 8
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(8) Then
            valu_selfriend_rela_99.Value = 9
        ElseIf Select_friend_rela_99.SelectedItem = Select_friend_rela_99.Items.Item(9) Then
            valu_selfriend_rela_99.Value = 12
        End If
    End Sub

    Private Sub Select_friend_rela_100_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_friend_rela_100.SelectedIndexChanged
        If Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(0) Then
            valu_selfriend_rela_100.Value = 0
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(1) Then
            valu_selfriend_rela_100.Value = 1
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(2) Then
            valu_selfriend_rela_100.Value = 2
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(3) Then
            valu_selfriend_rela_100.Value = 3
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(4) Then
            valu_selfriend_rela_100.Value = 4
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(5) Then
            valu_selfriend_rela_100.Value = 6
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(6) Then
            valu_selfriend_rela_100.Value = 7
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(7) Then
            valu_selfriend_rela_100.Value = 8
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(8) Then
            valu_selfriend_rela_100.Value = 9
        ElseIf Select_friend_rela_100.SelectedItem = Select_friend_rela_100.Items.Item(9) Then
            valu_selfriend_rela_100.Value = 12
        End If
    End Sub

    Private Sub valu_selfriend_rela_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_1.ValueChanged
        If ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_2.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_3.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_4.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_5.Value = 2 Or valu_selfriend_rela_5.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_5.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_6.Value = 2 Or valu_selfriend_rela_6.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_6.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_7.Value = 2 Or valu_selfriend_rela_7.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_7.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_8.Value = 2 Or valu_selfriend_rela_8.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_8.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_9.Value = 2 Or valu_selfriend_rela_9.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_9.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_10.Value = 2 Or valu_selfriend_rela_10.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_10.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_11.Value = 2 Or valu_selfriend_rela_11.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_11.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_12.Value = 2 Or valu_selfriend_rela_12.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_12.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_13.Value = 2 Or valu_selfriend_rela_13.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_13.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_14.Value = 2 Or valu_selfriend_rela_14.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_14.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_15.Value = 2 Or valu_selfriend_rela_15.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_15.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_16.Value = 2 Or valu_selfriend_rela_16.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_16.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_17.Value = 2 Or valu_selfriend_rela_17.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_17.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_18.Value = 2 Or valu_selfriend_rela_18.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_18.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_19.Value = 2 Or valu_selfriend_rela_19.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_19.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_20.Value = 2 Or valu_selfriend_rela_20.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_20.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_21.Value = 2 Or valu_selfriend_rela_21.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_21.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_22.Value = 2 Or valu_selfriend_rela_22.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_22.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_23.Value = 2 Or valu_selfriend_rela_23.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_23.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_24.Value = 2 Or valu_selfriend_rela_24.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_24.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_25.Value = 2 Or valu_selfriend_rela_25.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_25.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_26.Value = 2 Or valu_selfriend_rela_26.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_26.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_27.Value = 2 Or valu_selfriend_rela_27.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_27.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_28.Value = 2 Or valu_selfriend_rela_28.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_28.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_29.Value = 2 Or valu_selfriend_rela_29.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_29.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_30.Value = 2 Or valu_selfriend_rela_30.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_30.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_31.Value = 2 Or valu_selfriend_rela_31.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_31.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_32.Value = 2 Or valu_selfriend_rela_32.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_32.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_33.Value = 2 Or valu_selfriend_rela_33.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_33.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_34.Value = 2 Or valu_selfriend_rela_34.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_34.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_35.Value = 2 Or valu_selfriend_rela_35.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_35.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_36.Value = 2 Or valu_selfriend_rela_36.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_36.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_37.Value = 2 Or valu_selfriend_rela_37.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_37.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_38.Value = 2 Or valu_selfriend_rela_38.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_38.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_39.Value = 2 Or valu_selfriend_rela_39.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_39.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_40.Value = 2 Or valu_selfriend_rela_40.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_40.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_41.Value = 2 Or valu_selfriend_rela_41.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_41.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_42.Value = 2 Or valu_selfriend_rela_42.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_42.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_43.Value = 2 Or valu_selfriend_rela_43.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_43.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_44.Value = 2 Or valu_selfriend_rela_44.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_44.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_45.Value = 2 Or valu_selfriend_rela_45.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_45.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_46.Value = 2 Or valu_selfriend_rela_46.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_46.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_47.Value = 2 Or valu_selfriend_rela_47.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_47.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_48.Value = 2 Or valu_selfriend_rela_48.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_48.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_49.Value = 2 Or valu_selfriend_rela_49.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_49.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_50.Value = 2 Or valu_selfriend_rela_50.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_50.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_51.Value = 2 Or valu_selfriend_rela_51.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_51.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_52.Value = 2 Or valu_selfriend_rela_52.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_52.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_53.Value = 2 Or valu_selfriend_rela_53.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_53.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_54.Value = 2 Or valu_selfriend_rela_54.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_54.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_55.Value = 2 Or valu_selfriend_rela_55.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_55.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_56.Value = 2 Or valu_selfriend_rela_56.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_56.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_57.Value = 2 Or valu_selfriend_rela_57.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_57.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_58.Value = 2 Or valu_selfriend_rela_58.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_58.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_59.Value = 2 Or valu_selfriend_rela_59.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_59.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_60.Value = 2 Or valu_selfriend_rela_60.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_60.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_61.Value = 2 Or valu_selfriend_rela_61.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_61.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_62.Value = 2 Or valu_selfriend_rela_62.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_62.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_63.Value = 2 Or valu_selfriend_rela_63.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_63.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_64.Value = 2 Or valu_selfriend_rela_64.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_64.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_65.Value = 2 Or valu_selfriend_rela_65.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_65.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_66.Value = 2 Or valu_selfriend_rela_66.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_66.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_67.Value = 2 Or valu_selfriend_rela_67.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_67.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_68.Value = 2 Or valu_selfriend_rela_68.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_68.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_69.Value = 2 Or valu_selfriend_rela_69.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_69.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_70.Value = 2 Or valu_selfriend_rela_70.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_70.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_71.Value = 2 Or valu_selfriend_rela_71.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_71.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_72.Value = 2 Or valu_selfriend_rela_72.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_72.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_73.Value = 2 Or valu_selfriend_rela_73.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_73.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_74.Value = 2 Or valu_selfriend_rela_74.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_74.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_75.Value = 2 Or valu_selfriend_rela_75.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_75.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_76.Value = 2 Or valu_selfriend_rela_76.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_76.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_77.Value = 2 Or valu_selfriend_rela_77.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_77.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_78.Value = 2 Or valu_selfriend_rela_78.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_78.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_79.Value = 2 Or valu_selfriend_rela_79.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_79.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_80.Value = 2 Or valu_selfriend_rela_80.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_80.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_81.Value = 2 Or valu_selfriend_rela_81.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_81.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_82.Value = 2 Or valu_selfriend_rela_82.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_82.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_83.Value = 2 Or valu_selfriend_rela_83.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_83.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_84.Value = 2 Or valu_selfriend_rela_84.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_84.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_85.Value = 2 Or valu_selfriend_rela_85.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_85.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_86.Value = 2 Or valu_selfriend_rela_86.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_86.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_87.Value = 2 Or valu_selfriend_rela_87.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_87.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_88.Value = 2 Or valu_selfriend_rela_88.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_88.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_89.Value = 2 Or valu_selfriend_rela_89.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_89.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_90.Value = 2 Or valu_selfriend_rela_90.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_90.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_91.Value = 2 Or valu_selfriend_rela_91.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_91.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_92.Value = 2 Or valu_selfriend_rela_92.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_92.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_93.Value = 2 Or valu_selfriend_rela_93.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_93.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_94.Value = 2 Or valu_selfriend_rela_94.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_94.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_95.Value = 2 Or valu_selfriend_rela_95.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_95.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_96.Value = 2 Or valu_selfriend_rela_96.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_96.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_97.Value = 2 Or valu_selfriend_rela_97.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_97.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_98.Value = 2 Or valu_selfriend_rela_98.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_98.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_99.Value = 2 Or valu_selfriend_rela_99.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_99.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4) And (valu_selfriend_rela_100.Value = 2 Or valu_selfriend_rela_100.Value = 4)) Or (valu_selfriend_rela_1.Value = 12 And valu_selfriend_rela_100.Value = 12) Then
            Select_friend_rela_1.BackColor = Color.Red
        Else
            Select_friend_rela_1.BackColor = Color.White
        End If
        If valu_selfriend_rela_1.Value = 0 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(0)
        ElseIf valu_selfriend_rela_1.Value = 1 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(1)
        ElseIf valu_selfriend_rela_1.Value = 2 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(2)
        ElseIf valu_selfriend_rela_1.Value = 3 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(3)
        ElseIf valu_selfriend_rela_1.Value = 4 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(4)
        ElseIf valu_selfriend_rela_1.Value = 6 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(5)
        ElseIf valu_selfriend_rela_1.Value = 7 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(6)
        ElseIf valu_selfriend_rela_1.Value = 8 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(7)
        ElseIf valu_selfriend_rela_1.Value = 9 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(8)
        ElseIf valu_selfriend_rela_1.Value = 12 Then
            Select_friend_rela_1.SelectedItem = Select_friend_rela_1.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_2.ValueChanged
        If ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_1.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_3.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_4.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_5.Value = 2 Or valu_selfriend_rela_5.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_5.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_6.Value = 2 Or valu_selfriend_rela_6.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_6.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_7.Value = 2 Or valu_selfriend_rela_7.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_7.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_8.Value = 2 Or valu_selfriend_rela_8.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_8.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_9.Value = 2 Or valu_selfriend_rela_9.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_9.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_10.Value = 2 Or valu_selfriend_rela_10.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_10.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_11.Value = 2 Or valu_selfriend_rela_11.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_11.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_12.Value = 2 Or valu_selfriend_rela_12.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_12.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_13.Value = 2 Or valu_selfriend_rela_13.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_13.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_14.Value = 2 Or valu_selfriend_rela_14.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_14.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_15.Value = 2 Or valu_selfriend_rela_15.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_15.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_16.Value = 2 Or valu_selfriend_rela_16.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_16.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_17.Value = 2 Or valu_selfriend_rela_17.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_17.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_18.Value = 2 Or valu_selfriend_rela_18.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_18.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_19.Value = 2 Or valu_selfriend_rela_19.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_19.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_20.Value = 2 Or valu_selfriend_rela_20.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_20.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_21.Value = 2 Or valu_selfriend_rela_21.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_21.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_22.Value = 2 Or valu_selfriend_rela_22.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_22.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_23.Value = 2 Or valu_selfriend_rela_23.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_23.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_24.Value = 2 Or valu_selfriend_rela_24.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_24.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_25.Value = 2 Or valu_selfriend_rela_25.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_25.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_26.Value = 2 Or valu_selfriend_rela_26.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_26.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_27.Value = 2 Or valu_selfriend_rela_27.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_27.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_28.Value = 2 Or valu_selfriend_rela_28.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_28.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_29.Value = 2 Or valu_selfriend_rela_29.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_29.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_30.Value = 2 Or valu_selfriend_rela_30.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_30.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_31.Value = 2 Or valu_selfriend_rela_31.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_31.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_32.Value = 2 Or valu_selfriend_rela_32.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_32.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_33.Value = 2 Or valu_selfriend_rela_33.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_33.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_34.Value = 2 Or valu_selfriend_rela_34.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_34.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_35.Value = 2 Or valu_selfriend_rela_35.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_35.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_36.Value = 2 Or valu_selfriend_rela_36.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_36.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_37.Value = 2 Or valu_selfriend_rela_37.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_37.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_38.Value = 2 Or valu_selfriend_rela_38.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_38.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_39.Value = 2 Or valu_selfriend_rela_39.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_39.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_40.Value = 2 Or valu_selfriend_rela_40.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_40.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_41.Value = 2 Or valu_selfriend_rela_41.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_41.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_42.Value = 2 Or valu_selfriend_rela_42.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_42.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_43.Value = 2 Or valu_selfriend_rela_43.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_43.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_44.Value = 2 Or valu_selfriend_rela_44.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_44.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_45.Value = 2 Or valu_selfriend_rela_45.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_45.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_46.Value = 2 Or valu_selfriend_rela_46.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_46.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_47.Value = 2 Or valu_selfriend_rela_47.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_47.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_48.Value = 2 Or valu_selfriend_rela_48.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_48.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_49.Value = 2 Or valu_selfriend_rela_49.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_49.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_50.Value = 2 Or valu_selfriend_rela_50.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_50.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_51.Value = 2 Or valu_selfriend_rela_51.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_51.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_52.Value = 2 Or valu_selfriend_rela_52.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_52.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_53.Value = 2 Or valu_selfriend_rela_53.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_53.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_54.Value = 2 Or valu_selfriend_rela_54.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_54.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_55.Value = 2 Or valu_selfriend_rela_55.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_55.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_56.Value = 2 Or valu_selfriend_rela_56.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_56.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_57.Value = 2 Or valu_selfriend_rela_57.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_57.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_58.Value = 2 Or valu_selfriend_rela_58.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_58.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_59.Value = 2 Or valu_selfriend_rela_59.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_59.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_60.Value = 2 Or valu_selfriend_rela_60.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_60.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_61.Value = 2 Or valu_selfriend_rela_61.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_61.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_62.Value = 2 Or valu_selfriend_rela_62.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_62.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_63.Value = 2 Or valu_selfriend_rela_63.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_63.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_64.Value = 2 Or valu_selfriend_rela_64.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_64.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_65.Value = 2 Or valu_selfriend_rela_65.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_65.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_66.Value = 2 Or valu_selfriend_rela_66.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_66.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_67.Value = 2 Or valu_selfriend_rela_67.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_67.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_68.Value = 2 Or valu_selfriend_rela_68.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_68.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_69.Value = 2 Or valu_selfriend_rela_69.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_69.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_70.Value = 2 Or valu_selfriend_rela_70.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_70.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_71.Value = 2 Or valu_selfriend_rela_71.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_71.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_72.Value = 2 Or valu_selfriend_rela_72.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_72.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_73.Value = 2 Or valu_selfriend_rela_73.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_73.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_74.Value = 2 Or valu_selfriend_rela_74.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_74.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_75.Value = 2 Or valu_selfriend_rela_75.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_75.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_76.Value = 2 Or valu_selfriend_rela_76.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_76.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_77.Value = 2 Or valu_selfriend_rela_77.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_77.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_78.Value = 2 Or valu_selfriend_rela_78.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_78.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_79.Value = 2 Or valu_selfriend_rela_79.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_79.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_80.Value = 2 Or valu_selfriend_rela_80.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_80.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_81.Value = 2 Or valu_selfriend_rela_81.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_81.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_82.Value = 2 Or valu_selfriend_rela_82.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_82.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_83.Value = 2 Or valu_selfriend_rela_83.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_83.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_84.Value = 2 Or valu_selfriend_rela_84.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_84.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_85.Value = 2 Or valu_selfriend_rela_85.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_85.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_86.Value = 2 Or valu_selfriend_rela_86.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_86.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_87.Value = 2 Or valu_selfriend_rela_87.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_87.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_88.Value = 2 Or valu_selfriend_rela_88.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_88.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_89.Value = 2 Or valu_selfriend_rela_89.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_89.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_90.Value = 2 Or valu_selfriend_rela_90.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_90.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_91.Value = 2 Or valu_selfriend_rela_91.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_91.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_92.Value = 2 Or valu_selfriend_rela_92.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_92.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_93.Value = 2 Or valu_selfriend_rela_93.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_93.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_94.Value = 2 Or valu_selfriend_rela_94.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_94.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_95.Value = 2 Or valu_selfriend_rela_95.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_95.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_96.Value = 2 Or valu_selfriend_rela_96.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_96.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_97.Value = 2 Or valu_selfriend_rela_97.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_97.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_98.Value = 2 Or valu_selfriend_rela_98.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_98.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_99.Value = 2 Or valu_selfriend_rela_99.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_99.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4) And (valu_selfriend_rela_100.Value = 2 Or valu_selfriend_rela_100.Value = 4)) Or (valu_selfriend_rela_2.Value = 12 And valu_selfriend_rela_100.Value = 12) Then
            Select_friend_rela_2.BackColor = Color.Red
        Else
            Select_friend_rela_2.BackColor = Color.White
        End If
        If valu_selfriend_rela_2.Value = 0 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(0)
        ElseIf valu_selfriend_rela_2.Value = 1 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(1)
        ElseIf valu_selfriend_rela_2.Value = 2 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(2)
        ElseIf valu_selfriend_rela_2.Value = 3 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(3)
        ElseIf valu_selfriend_rela_2.Value = 4 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(4)
        ElseIf valu_selfriend_rela_2.Value = 6 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(5)
        ElseIf valu_selfriend_rela_2.Value = 7 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(6)
        ElseIf valu_selfriend_rela_2.Value = 8 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(7)
        ElseIf valu_selfriend_rela_2.Value = 9 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(8)
        ElseIf valu_selfriend_rela_2.Value = 12 Then
            Select_friend_rela_2.SelectedItem = Select_friend_rela_2.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_3.ValueChanged
        If ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_1.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_2.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_4.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_5.Value = 2 Or valu_selfriend_rela_5.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_5.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_6.Value = 2 Or valu_selfriend_rela_6.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_6.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_7.Value = 2 Or valu_selfriend_rela_7.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_7.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_8.Value = 2 Or valu_selfriend_rela_8.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_8.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_9.Value = 2 Or valu_selfriend_rela_9.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_9.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_10.Value = 2 Or valu_selfriend_rela_10.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_10.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_11.Value = 2 Or valu_selfriend_rela_11.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_11.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_12.Value = 2 Or valu_selfriend_rela_12.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_12.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_13.Value = 2 Or valu_selfriend_rela_13.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_13.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_14.Value = 2 Or valu_selfriend_rela_14.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_14.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_15.Value = 2 Or valu_selfriend_rela_15.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_15.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_16.Value = 2 Or valu_selfriend_rela_16.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_16.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_17.Value = 2 Or valu_selfriend_rela_17.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_17.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_18.Value = 2 Or valu_selfriend_rela_18.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_18.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_19.Value = 2 Or valu_selfriend_rela_19.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_19.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_20.Value = 2 Or valu_selfriend_rela_20.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_20.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_21.Value = 2 Or valu_selfriend_rela_21.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_21.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_22.Value = 2 Or valu_selfriend_rela_22.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_22.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_23.Value = 2 Or valu_selfriend_rela_23.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_23.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_24.Value = 2 Or valu_selfriend_rela_24.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_24.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_25.Value = 2 Or valu_selfriend_rela_25.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_25.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_26.Value = 2 Or valu_selfriend_rela_26.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_26.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_27.Value = 2 Or valu_selfriend_rela_27.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_27.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_28.Value = 2 Or valu_selfriend_rela_28.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_28.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_29.Value = 2 Or valu_selfriend_rela_29.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_29.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_30.Value = 2 Or valu_selfriend_rela_30.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_30.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_31.Value = 2 Or valu_selfriend_rela_31.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_31.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_32.Value = 2 Or valu_selfriend_rela_32.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_32.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_33.Value = 2 Or valu_selfriend_rela_33.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_33.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_34.Value = 2 Or valu_selfriend_rela_34.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_34.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_35.Value = 2 Or valu_selfriend_rela_35.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_35.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_36.Value = 2 Or valu_selfriend_rela_36.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_36.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_37.Value = 2 Or valu_selfriend_rela_37.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_37.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_38.Value = 2 Or valu_selfriend_rela_38.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_38.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_39.Value = 2 Or valu_selfriend_rela_39.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_39.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_40.Value = 2 Or valu_selfriend_rela_40.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_40.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_41.Value = 2 Or valu_selfriend_rela_41.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_41.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_42.Value = 2 Or valu_selfriend_rela_42.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_42.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_43.Value = 2 Or valu_selfriend_rela_43.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_43.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_44.Value = 2 Or valu_selfriend_rela_44.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_44.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_45.Value = 2 Or valu_selfriend_rela_45.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_45.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_46.Value = 2 Or valu_selfriend_rela_46.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_46.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_47.Value = 2 Or valu_selfriend_rela_47.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_47.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_48.Value = 2 Or valu_selfriend_rela_48.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_48.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_49.Value = 2 Or valu_selfriend_rela_49.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_49.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_50.Value = 2 Or valu_selfriend_rela_50.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_50.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_51.Value = 2 Or valu_selfriend_rela_51.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_51.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_52.Value = 2 Or valu_selfriend_rela_52.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_52.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_53.Value = 2 Or valu_selfriend_rela_53.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_53.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_54.Value = 2 Or valu_selfriend_rela_54.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_54.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_55.Value = 2 Or valu_selfriend_rela_55.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_55.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_56.Value = 2 Or valu_selfriend_rela_56.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_56.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_57.Value = 2 Or valu_selfriend_rela_57.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_57.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_58.Value = 2 Or valu_selfriend_rela_58.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_58.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_59.Value = 2 Or valu_selfriend_rela_59.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_59.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_60.Value = 2 Or valu_selfriend_rela_60.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_60.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_61.Value = 2 Or valu_selfriend_rela_61.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_61.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_62.Value = 2 Or valu_selfriend_rela_62.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_62.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_63.Value = 2 Or valu_selfriend_rela_63.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_63.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_64.Value = 2 Or valu_selfriend_rela_64.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_64.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_65.Value = 2 Or valu_selfriend_rela_65.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_65.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_66.Value = 2 Or valu_selfriend_rela_66.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_66.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_67.Value = 2 Or valu_selfriend_rela_67.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_67.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_68.Value = 2 Or valu_selfriend_rela_68.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_68.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_69.Value = 2 Or valu_selfriend_rela_69.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_69.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_70.Value = 2 Or valu_selfriend_rela_70.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_70.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_71.Value = 2 Or valu_selfriend_rela_71.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_71.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_72.Value = 2 Or valu_selfriend_rela_72.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_72.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_73.Value = 2 Or valu_selfriend_rela_73.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_73.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_74.Value = 2 Or valu_selfriend_rela_74.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_74.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_75.Value = 2 Or valu_selfriend_rela_75.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_75.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_76.Value = 2 Or valu_selfriend_rela_76.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_76.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_77.Value = 2 Or valu_selfriend_rela_77.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_77.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_78.Value = 2 Or valu_selfriend_rela_78.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_78.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_79.Value = 2 Or valu_selfriend_rela_79.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_79.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_80.Value = 2 Or valu_selfriend_rela_80.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_80.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_81.Value = 2 Or valu_selfriend_rela_81.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_81.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_82.Value = 2 Or valu_selfriend_rela_82.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_82.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_83.Value = 2 Or valu_selfriend_rela_83.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_83.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_84.Value = 2 Or valu_selfriend_rela_84.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_84.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_85.Value = 2 Or valu_selfriend_rela_85.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_85.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_86.Value = 2 Or valu_selfriend_rela_86.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_86.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_87.Value = 2 Or valu_selfriend_rela_87.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_87.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_88.Value = 2 Or valu_selfriend_rela_88.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_88.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_89.Value = 2 Or valu_selfriend_rela_89.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_89.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_90.Value = 2 Or valu_selfriend_rela_90.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_90.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_91.Value = 2 Or valu_selfriend_rela_91.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_91.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_92.Value = 2 Or valu_selfriend_rela_92.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_92.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_93.Value = 2 Or valu_selfriend_rela_93.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_93.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_94.Value = 2 Or valu_selfriend_rela_94.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_94.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_95.Value = 2 Or valu_selfriend_rela_95.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_95.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_96.Value = 2 Or valu_selfriend_rela_96.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_96.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_97.Value = 2 Or valu_selfriend_rela_97.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_97.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_98.Value = 2 Or valu_selfriend_rela_98.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_98.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_99.Value = 2 Or valu_selfriend_rela_99.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_99.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4) And (valu_selfriend_rela_100.Value = 2 Or valu_selfriend_rela_100.Value = 4)) Or (valu_selfriend_rela_3.Value = 12 And valu_selfriend_rela_100.Value = 12) Then
            Select_friend_rela_3.BackColor = Color.Red
        Else
            Select_friend_rela_3.BackColor = Color.White
        End If
        If valu_selfriend_rela_3.Value = 0 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(0)
        ElseIf valu_selfriend_rela_3.Value = 1 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(1)
        ElseIf valu_selfriend_rela_3.Value = 2 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(2)
        ElseIf valu_selfriend_rela_3.Value = 3 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(3)
        ElseIf valu_selfriend_rela_3.Value = 4 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(4)
        ElseIf valu_selfriend_rela_3.Value = 6 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(5)
        ElseIf valu_selfriend_rela_3.Value = 7 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(6)
        ElseIf valu_selfriend_rela_3.Value = 8 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(7)
        ElseIf valu_selfriend_rela_3.Value = 9 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(8)
        ElseIf valu_selfriend_rela_3.Value = 12 Then
            Select_friend_rela_3.SelectedItem = Select_friend_rela_3.Items.Item(9)
        End If
    End Sub

    Private Sub valu_selfriend_rela_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_selfriend_rela_4.ValueChanged
        If ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_1.Value = 2 Or valu_selfriend_rela_1.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_1.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_2.Value = 2 Or valu_selfriend_rela_2.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_2.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_3.Value = 2 Or valu_selfriend_rela_3.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_3.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_5.Value = 2 Or valu_selfriend_rela_5.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_5.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_6.Value = 2 Or valu_selfriend_rela_6.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_6.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_7.Value = 2 Or valu_selfriend_rela_7.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_7.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_8.Value = 2 Or valu_selfriend_rela_8.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_8.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_9.Value = 2 Or valu_selfriend_rela_9.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_9.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_10.Value = 2 Or valu_selfriend_rela_10.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_10.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_11.Value = 2 Or valu_selfriend_rela_11.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_11.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_12.Value = 2 Or valu_selfriend_rela_12.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_12.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_13.Value = 2 Or valu_selfriend_rela_13.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_13.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_14.Value = 2 Or valu_selfriend_rela_14.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_14.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_15.Value = 2 Or valu_selfriend_rela_15.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_15.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_16.Value = 2 Or valu_selfriend_rela_16.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_16.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_17.Value = 2 Or valu_selfriend_rela_17.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_17.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_18.Value = 2 Or valu_selfriend_rela_18.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_18.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_19.Value = 2 Or valu_selfriend_rela_19.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_19.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_20.Value = 2 Or valu_selfriend_rela_20.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_20.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_21.Value = 2 Or valu_selfriend_rela_21.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_21.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_22.Value = 2 Or valu_selfriend_rela_22.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_22.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_23.Value = 2 Or valu_selfriend_rela_23.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_23.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_24.Value = 2 Or valu_selfriend_rela_24.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_24.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_25.Value = 2 Or valu_selfriend_rela_25.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_25.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_26.Value = 2 Or valu_selfriend_rela_26.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_26.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_27.Value = 2 Or valu_selfriend_rela_27.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_27.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_28.Value = 2 Or valu_selfriend_rela_28.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_28.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_29.Value = 2 Or valu_selfriend_rela_29.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_29.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_30.Value = 2 Or valu_selfriend_rela_30.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_30.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_31.Value = 2 Or valu_selfriend_rela_31.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_31.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_32.Value = 2 Or valu_selfriend_rela_32.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_32.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_33.Value = 2 Or valu_selfriend_rela_33.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_33.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_34.Value = 2 Or valu_selfriend_rela_34.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_34.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_35.Value = 2 Or valu_selfriend_rela_35.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_35.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_36.Value = 2 Or valu_selfriend_rela_36.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_36.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_37.Value = 2 Or valu_selfriend_rela_37.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_37.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_38.Value = 2 Or valu_selfriend_rela_38.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_38.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_39.Value = 2 Or valu_selfriend_rela_39.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_39.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_40.Value = 2 Or valu_selfriend_rela_40.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_40.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_41.Value = 2 Or valu_selfriend_rela_41.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_41.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_42.Value = 2 Or valu_selfriend_rela_42.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_42.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_43.Value = 2 Or valu_selfriend_rela_43.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_43.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_44.Value = 2 Or valu_selfriend_rela_44.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_44.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_45.Value = 2 Or valu_selfriend_rela_45.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_45.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_46.Value = 2 Or valu_selfriend_rela_46.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_46.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_47.Value = 2 Or valu_selfriend_rela_47.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_47.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_48.Value = 2 Or valu_selfriend_rela_48.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_48.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_49.Value = 2 Or valu_selfriend_rela_49.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_49.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_50.Value = 2 Or valu_selfriend_rela_50.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_50.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_51.Value = 2 Or valu_selfriend_rela_51.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_51.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_52.Value = 2 Or valu_selfriend_rela_52.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_52.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_53.Value = 2 Or valu_selfriend_rela_53.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_53.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_54.Value = 2 Or valu_selfriend_rela_54.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_54.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_55.Value = 2 Or valu_selfriend_rela_55.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_55.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_56.Value = 2 Or valu_selfriend_rela_56.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_56.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_57.Value = 2 Or valu_selfriend_rela_57.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_57.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_58.Value = 2 Or valu_selfriend_rela_58.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_58.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_59.Value = 2 Or valu_selfriend_rela_59.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_59.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_60.Value = 2 Or valu_selfriend_rela_60.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_60.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_61.Value = 2 Or valu_selfriend_rela_61.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_61.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_62.Value = 2 Or valu_selfriend_rela_62.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_62.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_63.Value = 2 Or valu_selfriend_rela_63.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_63.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_64.Value = 2 Or valu_selfriend_rela_64.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_64.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_65.Value = 2 Or valu_selfriend_rela_65.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_65.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_66.Value = 2 Or valu_selfriend_rela_66.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_66.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_67.Value = 2 Or valu_selfriend_rela_67.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_67.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_68.Value = 2 Or valu_selfriend_rela_68.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_68.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_69.Value = 2 Or valu_selfriend_rela_69.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_69.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_70.Value = 2 Or valu_selfriend_rela_70.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_70.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_71.Value = 2 Or valu_selfriend_rela_71.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_71.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_72.Value = 2 Or valu_selfriend_rela_72.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_72.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_73.Value = 2 Or valu_selfriend_rela_73.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_73.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_74.Value = 2 Or valu_selfriend_rela_74.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_74.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_75.Value = 2 Or valu_selfriend_rela_75.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_75.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_76.Value = 2 Or valu_selfriend_rela_76.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_76.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_77.Value = 2 Or valu_selfriend_rela_77.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_77.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_78.Value = 2 Or valu_selfriend_rela_78.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_78.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_79.Value = 2 Or valu_selfriend_rela_79.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_79.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_80.Value = 2 Or valu_selfriend_rela_80.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_80.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_81.Value = 2 Or valu_selfriend_rela_81.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_81.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_82.Value = 2 Or valu_selfriend_rela_82.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_82.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_83.Value = 2 Or valu_selfriend_rela_83.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_83.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_84.Value = 2 Or valu_selfriend_rela_84.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_84.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_85.Value = 2 Or valu_selfriend_rela_85.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_85.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_86.Value = 2 Or valu_selfriend_rela_86.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_86.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_87.Value = 2 Or valu_selfriend_rela_87.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_87.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_88.Value = 2 Or valu_selfriend_rela_88.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_88.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_89.Value = 2 Or valu_selfriend_rela_89.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_89.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_90.Value = 2 Or valu_selfriend_rela_90.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_90.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_91.Value = 2 Or valu_selfriend_rela_91.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_91.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_92.Value = 2 Or valu_selfriend_rela_92.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_92.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_93.Value = 2 Or valu_selfriend_rela_93.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_93.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_94.Value = 2 Or valu_selfriend_rela_94.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_94.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_95.Value = 2 Or valu_selfriend_rela_95.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_95.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_96.Value = 2 Or valu_selfriend_rela_96.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_96.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_97.Value = 2 Or valu_selfriend_rela_97.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_97.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_98.Value = 2 Or valu_selfriend_rela_98.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_98.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_99.Value = 2 Or valu_selfriend_rela_99.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_99.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        ElseIf ((valu_selfriend_rela_4.Value = 2 Or valu_selfriend_rela_4.Value = 4) And (valu_selfriend_rela_100.Value = 2 Or valu_selfriend_rela_100.Value = 4)) Or (valu_selfriend_rela_4.Value = 12 And valu_selfriend_rela_100.Value = 12) Then
            Select_friend_rela_4.BackColor = Color.Red
        Else
            Select_friend_rela_4.BackColor = Color.White
        End If
        If valu_selfriend_rela_4.Value = 0 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(0)
        ElseIf valu_selfriend_rela_4.Value = 1 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(1)
        ElseIf valu_selfriend_rela_4.Value = 2 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(2)
        ElseIf valu_selfriend_rela_4.Value = 3 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(3)
        ElseIf valu_selfriend_rela_4.Value = 4 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(4)
        ElseIf valu_selfriend_rela_4.Value = 6 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(5)
        ElseIf valu_selfriend_rela_4.Value = 7 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(6)
        ElseIf valu_selfriend_rela_4.Value = 8 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(7)
        ElseIf valu_selfriend_rela_4.Value = 9 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(8)
        ElseIf valu_selfriend_rela_4.Value = 12 Then
            Select_friend_rela_4.SelectedItem = Select_friend_rela_4.Items.Item(9)
        End If
    End Sub
End Class