Public Class TLSE_settings
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    'form settings
    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        My.Settings.Para_AdvH = Settings_Advhelp.Checked
        My.Settings.Para_chkupdate = Settings_ckupdate.Checked
        My.Settings.Para_hidden = Settings_hidden.Checked
        My.Settings.Para_music = Settings_music.Checked
        My.Settings.Para_path = Settings_filepath.Checked
        My.Settings.Para_spesymb = Settings_spesymb.Checked
        My.Settings.Para_language = Selects_language.SelectedItem
        My.Settings.Para_selmusic = Selects_music.SelectedItem
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
        My.Settings.Para_AdvH = Settings_Advhelp.Checked
        My.Settings.Para_chkupdate = Settings_ckupdate.Checked
        My.Settings.Para_hidden = Settings_hidden.Checked
        My.Settings.Para_music = Settings_music.Checked
        My.Settings.Para_path = Settings_filepath.Checked
        My.Settings.Para_spesymb = Settings_spesymb.Checked
        My.Settings.Para_language = Selects_language.SelectedItem
        My.Settings.Para_selmusic = Selects_music.SelectedItem
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
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

    Private Sub Settings_music_CheckedChanged(sender As Object, e As EventArgs) Handles Settings_music.CheckedChanged
        If Settings_music.Checked = True Then
            Settings_music.FlatAppearance.BorderColor = Color.White
            Settings_music.ForeColor = Color.White
            Panel_bgmusic.Visible = True
        End If
        If Settings_music.Checked = False Then
            Settings_music.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Settings_music.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_bgmusic.Visible = False
        End If
    End Sub

    Private Sub Settings_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Settings_hidden.CheckedChanged
        If Settings_hidden.Checked = True Then
            Settings_hidden.FlatAppearance.BorderColor = Color.White
            Settings_hidden.ForeColor = Color.White
            Panel_hiddenthings.Visible = True
        End If
        If Settings_hidden.Checked = False Then
            Settings_hidden.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Settings_hidden.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_hiddenthings.Visible = False
        End If
    End Sub

    Private Sub Settings_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Settings_filepath.CheckedChanged
        If Settings_filepath.Checked = True Then
            Settings_filepath.FlatAppearance.BorderColor = Color.White
            Settings_filepath.ForeColor = Color.White
            Panel_filepath.Visible = True
            TLSE_filepath.Visible = True
        End If
        If Settings_filepath.Checked = False Then
            Settings_filepath.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Settings_filepath.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_filepath.Visible = False
            TLSE_filepath.Visible = False
        End If
    End Sub

    Private Sub Settings_ckupdate_CheckedChanged(sender As Object, e As EventArgs) Handles Settings_ckupdate.CheckedChanged
        If Settings_ckupdate.Checked = True Then
            Settings_ckupdate.FlatAppearance.BorderColor = Color.White
            Settings_ckupdate.ForeColor = Color.White
            Panel_chkupdate.Visible = True
        End If
        If Settings_ckupdate.Checked = False Then
            Settings_ckupdate.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Settings_ckupdate.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_chkupdate.Visible = False
        End If
    End Sub

    Private Sub Settings_Advhelp_CheckedChanged(sender As Object, e As EventArgs) Handles Settings_Advhelp.CheckedChanged
        If Settings_Advhelp.Checked = True Then
            Settings_Advhelp.FlatAppearance.BorderColor = Color.White
            Settings_Advhelp.ForeColor = Color.White
            Panel_Advhelp.Visible = True
        End If
        If Settings_Advhelp.Checked = False Then
            Settings_Advhelp.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Settings_Advhelp.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Panel_Advhelp.Visible = False
        End If
    End Sub

    Private Sub Settings_spesymb_CheckedChanged(sender As Object, e As EventArgs) Handles Settings_spesymb.CheckedChanged
        If Settings_spesymb.Checked = True Then
            Settings_spesymb.FlatAppearance.BorderColor = Color.White
            Settings_spesymb.ForeColor = Color.White
            Panel_bspesymb.Visible = True
        End If
        If Settings_spesymb.Checked = False Then
            Settings_spesymb.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 0)
            Settings_spesymb.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
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

    Private Sub TLSE_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Selects_language.SelectedItem = Selects_language.Items.Item(0)
        Selects_music.SelectedItem = Select_music.Items.Item(0)
        Try
            Settings_Advhelp.Checked = My.Settings.Para_AdvH
            Settings_ckupdate.Checked = My.Settings.Para_chkupdate
            Settings_hidden.Checked = My.Settings.Para_hidden
            Settings_music.Checked = My.Settings.Para_music
            Settings_filepath.Checked = My.Settings.Para_path
            Settings_spesymb.Checked = My.Settings.Para_spesymb
            Selects_language.SelectedItem = My.Settings.Para_language
            Selects_music.SelectedItem = My.Settings.Para_selmusic
        Catch ex As Exception
        End Try
        TLSE_language()
    End Sub

    Public Sub TLSE_language()
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Menu_text_settings.Text = "Settings"
            Menu_text_changelog.Text = "Changelog"
            Menu_text_credits.Text = "Credits"
            Menu_text_links.Text = "Links"
            Text_language.Text = "Language"
            Settings_music.Text = "Active background music"
            Settings_hidden.Text = "Show hidden things"
            Settings_filepath.Text = "Show file path"
            Settings_ckupdate.Text = "Unactive check updates"
            Settings_Advhelp.Text = "Show advance help"
            Settings_spesymb.Text = "Active special symbol"
            Text_othersaveedit.Text = "Other save editors"
        End If
        If Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Menu_text_settings.Text = "Paramètres"
            Menu_text_changelog.Text = "Changelog"
            Menu_text_credits.Text = "Crédits"
            Menu_text_links.Text = "Liens"
            Text_language.Text = "Langage"
            Settings_music.Text = "Activer la musique de fond"
            Settings_hidden.Text = "Afficher les choses cachés"
            Settings_filepath.Text = "Afficher le chemin du fichier"
            Settings_ckupdate.Text = "Désactiver la vérifications des mises à jour"
            Settings_Advhelp.Text = "Afficher l'aide avancée"
            Settings_spesymb.Text = "Activer les symboles spéciaux"
            Text_othersaveedit.Text = "Autre éditeurs de sauvegarde"
        End If
    End Sub

    Private Sub Selects_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Selects_language.SelectedIndexChanged
        TLSE_language()
    End Sub

    Private Sub Icon_TLSE_git_Click(sender As Object, e As EventArgs) Handles Icon_TLSE_git.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor")
    End Sub

    Private Sub Icon_TLSE_git_MouseLeave(sender As Object, e As EventArgs) Handles Icon_TLSE_git.MouseLeave
        Icon_TLSE_git.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_TLSE_git_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_TLSE_git.MouseMove
        Icon_TLSE_git.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to access to Tomodachi Life Save Editor page (Github)"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour accéder à la page de Tomodachi Life Save Editor (Github)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_TLSE_gbt_Click(sender As Object, e As EventArgs) Handles Icon_TLSE_gbt.Click
        Process.Start("https://gbatemp.net/threads/wip-tomodachi-life-save-editor.399006/")
    End Sub

    Private Sub Icon_TLSE_gbt_MouseLeave(sender As Object, e As EventArgs) Handles Icon_TLSE_gbt.MouseLeave
        Icon_TLSE_gbt.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_TLSE_gbt_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_TLSE_gbt.MouseMove
        Icon_TLSE_gbt.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to access to Tomodachi Life Save Editor page (gbatemp.net)"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour accéder à la page de Tomodachi Life Save Editor (gbatemp.net)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_MiitopiaSE_Click(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor/releases")
    End Sub

    Private Sub Icon_MiitopiaSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseLeave
        Icon_MiitopiaSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MiitopiaSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseMove
        Icon_MiitopiaSE.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Miitopia Save Editor"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Miitopia Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_ChibiRoboZLSE_Click(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.Click
        Process.Start("https://github.com/Brionjv/Chibi-Robo-ZL-Save-Editor/releases")
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseLeave
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseMove
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Chibi Robo zip Lash Save Editor"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Chibi Robo zip Lash Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_PaparMarioSSSE_Click(sender As Object, e As EventArgs) Handles Icon_PaparMarioSSSE.Click
        Process.Start("https://github.com/Brionjv/Paper-Mario-SS-Save-Editor/releases")
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_PaparMarioSSSE.MouseLeave
        Icon_PaparMarioSSSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_PaparMarioSSSE.MouseMove
        Icon_PaparMarioSSSE.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Paper Mario Sticker Star Save Editor"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Paper Mario Sticker Star Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_IronfallISE_Click(sender As Object, e As EventArgs) Handles Icon_IronfallISE.Click
        Process.Start("https://github.com/Brionjv/Ironfall-Invasion-Save-Editor/releases")
    End Sub

    Private Sub Icon_IronfallISE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_IronfallISE.MouseLeave
        Icon_IronfallISE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_IronfallISE_MouseMove(sender As Object, e As EventArgs) Handles Icon_IronfallISE.MouseMove
        Icon_IronfallISE.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Ironfall Invasion Save Editor"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Ironfall Invasion Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_NintendogscatSE_Click(sender As Object, e As EventArgs) Handles Icon_nintendogscatSE.Click
        Process.Start("https://github.com/Brionjv/3ds-Nintendogs-cats-Save-Editor/releases")
    End Sub

    Private Sub Icon_NintendogscatSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_nintendogscatSE.MouseLeave
        Icon_nintendogscatSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_NintendogscatSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_nintendogscatSE.MouseMove
        Icon_nintendogscatSE.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try 3ds Nintendogs + cats Save Editor"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer 3ds Nintendogs + cats Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_MarioPartyITSE_Click(sender As Object, e As EventArgs) Handles Icon_MarioPartyITSE.Click
        Process.Start("https://github.com/Brionjv/Mario-Party-IT-Save-Editor/releases")
    End Sub

    Private Sub Icon_MarioPartyITSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MarioPartyITSE.MouseLeave
        Icon_MarioPartyITSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MarioPartyITSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_MarioPartyITSE.MouseMove
        Icon_MarioPartyITSE.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Mario Party Island Tour Save Editor"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Mario Party Island Tour Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_3dsSEL_Click(sender As Object, e As EventArgs) Handles Icon_3dsSEL.Click
        Process.Start("https://github.com/Brionjv/3DS-Save-Editors-Library/releases")
    End Sub

    Private Sub Icon_3dsSEL_MouseLeave(sender As Object, e As EventArgs) Handles Icon_3dsSEL.MouseLeave
        Icon_3dsSEL.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_3dsSEL_MouseMove(sender As Object, e As EventArgs) Handles Icon_3dsSEL.MouseMove
        Icon_3dsSEL.BorderStyle = BorderStyle.FixedSingle
        If Selects_language.SelectedItem = Selects_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try 3DS Save Editors Library (Collection of little save editors)"
        ElseIf Selects_language.SelectedItem = Selects_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer 3DS Save Editors Library (Collection de petit éditeurs de sauvegarde)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Text_othersaveedit_Click(sender As Object, e As EventArgs) Handles Text_othersaveedit.Click
        Process.Start("https://github.com/Brionjv?tab=repositories")
    End Sub

End Class