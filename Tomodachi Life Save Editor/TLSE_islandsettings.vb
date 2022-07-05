Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_islandsettings
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim babiesborn As String
    Dim streetpassactiv As String
    Dim spotpassactiv As String

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
        'Savefileregion()
    End Sub

    Private Sub valu_babiesborn_ValueChanged(sender As Object, e As EventArgs) Handles valu_babiesborn.ValueChanged
        Try
            ConvertB_babiesborn.Text = Convert.ToString(Convert.ToUInt32(valu_babiesborn.Value), 2).PadLeft(8, "0")
            Binary_babiesborn.Text = ConvertB_babiesborn.Text.Substring(0, 2)
            Binary_unknow1.Text = ConvertB_babiesborn.Text.Substring(2, 2)
            Binary_unknow2.Text = ConvertB_babiesborn.Text.Substring(4, 2)
            Binary_unknow3.Text = ConvertB_babiesborn.Text.Substring(6, 2)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to convert babies born to binary"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub ConvertB_babiesborn_TextChanged(sender As Object, e As EventArgs) Handles ConvertB_babiesborn.TextChanged
        Try
            valu_babiesborn.Value = Convert.ToUInt32(Convert.ToString(ConvertB_babiesborn.Text), 2)
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to convert binary babies born hex"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub Mergebinarybabiesborn()
        Try
            ConvertB_babiesborn.Text = Binary_babiesborn.Text + Binary_unknow1.Text + Binary_unknow2.Text + Binary_unknow3.Text 'merge binary features
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to update convert binary babies born"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Binary_babiesborn_TextChanged(sender As Object, e As EventArgs) Handles Binary_babiesborn.TextChanged
        If Binary_babiesborn.Text = "00" Then
            Select_babiesborn.SelectedItem = Select_babiesborn.Items.Item(0)
        ElseIf Binary_babiesborn.Text = "01" Then
            Select_babiesborn.SelectedItem = Select_babiesborn.Items.Item(1)
        End If
    End Sub

    Private Sub Binary_unknow1_TextChanged(sender As Object, e As EventArgs) Handles Binary_unknow1.TextChanged
        If Binary_unknow1.Text = "00" Then
            Select_unknow1.SelectedItem = Select_unknow1.Items.Item(0)
        ElseIf Binary_unknow1.Text = "01" Then
            Select_unknow1.SelectedItem = Select_unknow1.Items.Item(1)
        End If
    End Sub

    Private Sub Binary_unknow2_TextChanged(sender As Object, e As EventArgs) Handles Binary_unknow2.TextChanged
        If Binary_unknow2.Text = "00" Then
            Select_unknow2.SelectedItem = Select_unknow2.Items.Item(0)
        ElseIf Binary_unknow2.Text = "01" Then
            Select_unknow2.SelectedItem = Select_unknow2.Items.Item(1)
        End If
    End Sub

    Private Sub Binary_unknow3_TextChanged(sender As Object, e As EventArgs) Handles Binary_unknow3.TextChanged
        If Binary_unknow3.Text = "00" Then
            Select_unknow3.SelectedItem = Select_unknow3.Items.Item(0)
        ElseIf Binary_unknow3.Text = "01" Then
            Select_unknow3.SelectedItem = Select_unknow3.Items.Item(1)
        End If
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Mergebinarybabiesborn()
    End Sub

    Private Sub Select_babiesborn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_babiesborn.SelectedIndexChanged
        If Select_babiesborn.SelectedItem = Select_babiesborn.Items.Item(0) Then
            Binary_babiesborn.Text = "00"
        ElseIf Select_babiesborn.SelectedItem = Select_babiesborn.Items.Item(1) Then
            Binary_babiesborn.Text = "01"
        End If
    End Sub

    Private Sub Select_unknow1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_unknow1.SelectedIndexChanged
        If Select_unknow1.SelectedItem = Select_unknow1.Items.Item(0) Then
            Binary_unknow1.Text = "00"
        ElseIf Select_unknow1.SelectedItem = Select_unknow1.Items.Item(1) Then
            Binary_unknow1.Text = "01"
        End If
    End Sub

    Private Sub Select_unknow2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_unknow2.SelectedIndexChanged
        If Select_unknow2.SelectedItem = Select_unknow2.Items.Item(0) Then
            Binary_unknow2.Text = "00"
        ElseIf Select_unknow2.SelectedItem = Select_unknow2.Items.Item(1) Then
            Binary_unknow2.Text = "01"
        End If
    End Sub

    Private Sub Select_unknow3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_unknow3.SelectedIndexChanged
        If Select_unknow3.SelectedItem = Select_unknow3.Items.Item(0) Then
            Binary_unknow3.Text = "00"
        ElseIf Select_unknow3.SelectedItem = Select_unknow3.Items.Item(1) Then
            Binary_unknow3.Text = "01"
        End If
    End Sub

    Private Sub valu_streetpassactiv_ValueChanged(sender As Object, e As EventArgs) Handles valu_streetpassactiv.ValueChanged
        If valu_streetpassactiv.Value = 0 Then
            Select_streetpassactiv.SelectedItem = Select_streetpassactiv.Items.Item(0)
        ElseIf valu_streetpassactiv.Value = 1 Then
            Select_streetpassactiv.SelectedItem = Select_streetpassactiv.Items.Item(1)
        End If
    End Sub

    Private Sub Select_streetpassactiv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_streetpassactiv.SelectedIndexChanged
        If Select_streetpassactiv.SelectedItem = Select_streetpassactiv.Items.Item(0) Then
            valu_streetpassactiv.Value = 0
        ElseIf Select_streetpassactiv.SelectedItem = Select_streetpassactiv.Items.Item(1) Then
            valu_streetpassactiv.Value = 1
        End If
    End Sub

    Private Sub valu_spotpassactiv_ValueChanged(sender As Object, e As EventArgs) Handles valu_spotpassactiv.ValueChanged
        If valu_spotpassactiv.Value = 0 Then
            Select_spotpassactiv.SelectedItem = Select_spotpassactiv.Items.Item(0)
        ElseIf valu_spotpassactiv.Value = 1 Then
            Select_spotpassactiv.SelectedItem = Select_spotpassactiv.Items.Item(1)
        End If
    End Sub

    Private Sub Select_spotpassactiv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_spotpassactiv.SelectedIndexChanged
        If Select_spotpassactiv.SelectedItem = Select_spotpassactiv.Items.Item(0) Then
            valu_spotpassactiv.Value = 0
        ElseIf Select_spotpassactiv.SelectedItem = Select_spotpassactiv.Items.Item(1) Then
            valu_spotpassactiv.Value = 1
        End If
    End Sub

End Class