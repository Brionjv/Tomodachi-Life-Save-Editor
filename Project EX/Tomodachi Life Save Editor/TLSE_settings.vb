Public Class TLSE_settings
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

    Private Sub Menu_settings_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_settings.MouseMove, Menu_text_settings.MouseMove
        Menu_settings.BackgroundImage = My.Resources.menu_settings_on
        Menu_text_settings.ForeColor = Color.White
    End Sub

    Private Sub Menu_settings_MouseLeave(sender As Object, e As EventArgs) Handles Menu_settings.MouseLeave, Menu_text_settings.MouseLeave
        Menu_settings.BackgroundImage = My.Resources.menu_settings_off
        Menu_text_settings.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    Private Sub Menu_text_settings_Click(sender As Object, e As EventArgs) Handles Menu_text_settings.Click, Menu_settings.Click
        Hidesettings()
        Settings_settings.Visible = True
    End Sub

    Private Sub Menu_changelog_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_changelog.MouseMove, Menu_text_changelog.MouseMove
        Menu_changelog.BackgroundImage = My.Resources.menu_settings_on
        Menu_text_changelog.ForeColor = Color.White
    End Sub

    Private Sub Menu_changelog_MouseLeave(sender As Object, e As EventArgs) Handles Menu_changelog.MouseLeave, Menu_text_changelog.MouseLeave
        Menu_changelog.BackgroundImage = My.Resources.menu_settings_off
        Menu_text_changelog.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    Private Sub Menu_text_changelog_Click(sender As Object, e As EventArgs) Handles Menu_text_changelog.Click, Menu_changelog.Click
        Hidesettings()
        Settings_changelog.Visible = True
    End Sub

    Private Sub Menu_credits_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_credits.MouseMove, Menu_text_credits.MouseMove
        Menu_credits.BackgroundImage = My.Resources.menu_settings_on
        Menu_text_credits.ForeColor = Color.White
    End Sub

    Private Sub Menu_credits_MouseLeave(sender As Object, e As EventArgs) Handles Menu_credits.MouseLeave, Menu_text_credits.MouseLeave
        Menu_credits.BackgroundImage = My.Resources.menu_settings_off
        Menu_text_credits.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    Private Sub Menu_text_credits_Click(sender As Object, e As EventArgs) Handles Menu_text_credits.Click, Menu_credits.Click
        Hidesettings()
        Settings_credits.Visible = True
    End Sub

    Private Sub Menu_links_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_links.MouseMove, Menu_text_links.MouseMove
        Menu_links.BackgroundImage = My.Resources.menu_settings_on
        Menu_text_links.ForeColor = Color.White
    End Sub

    Private Sub Menu_links_MouseLeave(sender As Object, e As EventArgs) Handles Menu_links.MouseLeave, Menu_text_links.MouseLeave
        Menu_links.BackgroundImage = My.Resources.menu_settings_off
        Menu_text_links.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    Private Sub Setting_music_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_music.CheckedChanged
        If Setting_music.Checked = True Then
            Setting_music.FlatAppearance.BorderColor = Color.White
            Setting_music.ForeColor = Color.White
            Panel_bgmusic.Visible = True
        End If
        If Setting_music.Checked = False Then
            Setting_music.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Setting_music.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_bgmusic.Visible = False
        End If
    End Sub

    Private Sub Setting_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_hidden.CheckedChanged
        If Setting_hidden.Checked = True Then
            Setting_hidden.FlatAppearance.BorderColor = Color.White
            Setting_hidden.ForeColor = Color.White
            Panel_hiddenthings.Visible = True
        End If
        If Setting_hidden.Checked = False Then
            Setting_hidden.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Setting_hidden.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_hiddenthings.Visible = False
        End If
    End Sub

    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            Setting_filepath.FlatAppearance.BorderColor = Color.White
            Setting_filepath.ForeColor = Color.White
            Panel_filepath.Visible = True
        End If
        If Setting_filepath.Checked = False Then
            Setting_filepath.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Setting_filepath.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_filepath.Visible = False
        End If
    End Sub

    Private Sub Setting_ckupdate_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_ckupdate.CheckedChanged
        If Setting_ckupdate.Checked = True Then
            Setting_ckupdate.FlatAppearance.BorderColor = Color.White
            Setting_ckupdate.ForeColor = Color.White
            Panel_chkupdate.Visible = True
        End If
        If Setting_ckupdate.Checked = False Then
            Setting_ckupdate.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Setting_ckupdate.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_chkupdate.Visible = False
        End If
    End Sub

    Private Sub Setting_Advhelp_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_Advhelp.CheckedChanged
        If Setting_Advhelp.Checked = True Then
            Setting_Advhelp.FlatAppearance.BorderColor = Color.White
            Setting_Advhelp.ForeColor = Color.White
            Panel_Advhelp.Visible = True
        End If
        If Setting_Advhelp.Checked = False Then
            Setting_Advhelp.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Setting_Advhelp.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_Advhelp.Visible = False
        End If
    End Sub

    Private Sub Setting_spesymb_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_spesymb.CheckedChanged
        If Setting_spesymb.Checked = True Then
            Setting_spesymb.FlatAppearance.BorderColor = Color.White
            Setting_spesymb.ForeColor = Color.White
            Panel_bspesymb.Visible = True
        End If
        If Setting_spesymb.Checked = False Then
            Setting_spesymb.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Setting_spesymb.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_bspesymb.Visible = False
        End If
    End Sub

    Public Sub Hidesettings()
        Settings_settings.Visible = False
        Settings_changelog.Visible = False
        Settings_credits.Visible = False
        Settings_links.Visible = False
    End Sub

    Private Sub Menu_text_links_Click(sender As Object, e As EventArgs) Handles Menu_text_links.Click, Menu_links.Click
        Hidesettings()
        Settings_links.Visible = True
    End Sub
End Class