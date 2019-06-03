Imports PackageIO
Imports System.IO
Imports System.Net

Public Class TL_SaveEditor
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
    Dim Eventfountain As String
    Dim Appartrenov As String
    Dim Lastsavedate As String
    Dim Rankvitality As String
    Dim Rankpopularity As String
    Dim Rankboycharm As String
    Dim Rankgirlcharm As String
    Dim Rankpampered As String
    Dim Rankfriendship As String
    Dim Rankromance As String
    Dim Rankisland As String
    Dim Ranktravelers As String
    Dim Ranksplurge As String
    Dim Islandaddres_1 As String
    Dim Islandaddres_2 As String
    Dim Islandaddres_3 As String
    Dim Islandaddres_4 As String
    Dim appart As String
    Dim mair As String
    Dim info As String
    Dim classem As String
    Dim vetem As String
    Dim chap As String
    Dim epicer As String
    Dim deco As String
    Dim broc As String
    Dim magimport As String
    Dim fontai As String
    Dim mais As String
    Dim port As String
    Dim tervague As String
    Dim conc As String
    Dim test As String
    Dim stud As String
    Dim plage As String
    Dim parc1 As String
    Dim cafe As String
    Dim parc As String
    Dim tour As String
    Dim part As String

    'form setting
    Private Sub TL_SaveEditor_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.Parasetting_ckupdate = Setting_ckupdate.Checked
        My.Settings.Parasetting_filepath = Setting_filepath.Checked
        My.Settings.Parasetting_hidden = Setting_hidden.Checked
        My.Settings.Parasetting_language = Select_language.SelectedItem
        My.Settings.Parasetting_music = Setting_music.Checked
        My.Settings.Parasetting_musicsel = Select_music.SelectedItem
        'My.Settings.Parasetting_foodslang = Select_foods_language.SelectedItem
        My.Settings.Parasetting_advH = Setting_Advhelp.Checked
        My.Settings.Parasetting_specharc3ds = Setting_spesymb.Checked
    End Sub

    Private Sub TL_SaveEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_spesymb.SelectedItem = Select_spesymb.Items.Item(0)
        Select_music.SelectedItem = Select_music.Items.Item(0)
        Try
            Setting_ckupdate.Checked = My.Settings.Parasetting_ckupdate
            Setting_filepath.Checked = My.Settings.Parasetting_filepath
            Setting_hidden.Checked = My.Settings.Parasetting_hidden
            Select_language.SelectedItem = My.Settings.Parasetting_language
            Setting_music.Checked = My.Settings.Parasetting_music
            Select_music.SelectedItem = My.Settings.Parasetting_musicsel
            Setting_Advhelp.Checked = My.Settings.Parasetting_advH
            Setting_spesymb.Checked = My.Settings.Parasetting_specharc3ds
        Catch ex As Exception
        End Try
        Selectlanguage()
    End Sub

    Public Sub Checkupdates()
        If Setting_ckupdate.Checked = False Then
            Try
                Dim MAJ As New WebClient
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Tomodachi-Life-Save-Editor/master/Version.txt")
                If Text_TLSE_version.Text = lastupdate Then
                    TLSE_logo.Visible = True
                    TLSE_logo_update.Visible = False
                Else
                    TLSE_logo.Visible = False
                    TLSE_logo_update.Visible = True
                    If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                        TLSE_dialog.Text_TLSE_dialog.Text = "An update is available" & vbNewLine & vbNewLine & "Click on Tomodachi Life Save Editor icon" & vbNewLine & "to download new version"
                        TLSE_dialog.Icon_reference.Location = New Point(TLSE_logo.Width / 2, TLSE_logo.Height / 2)
                        TLSE_dialog.Icon_reference.Image = My.Resources.TLSE_arrow_left
                        TLSE_dialog.Icon_reference.Visible = True
                        TLSE_dialog.ShowDialog()
                    End If
                    If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                        TLSE_dialog.Text_TLSE_dialog.Text = "Une mise à jour est disponible" & vbNewLine & vbNewLine & "Cliquez sur l'îcone de Tomodachi Life Save Editor" & vbNewLine & "pour télécharger la nouvelle version"
                        TLSE_dialog.Icon_reference.Location = New Point(TLSE_logo.Width / 2, TLSE_logo.Height / 2)
                        TLSE_dialog.Icon_reference.Image = My.Resources.TLSE_arrow_left
                        TLSE_dialog.Icon_reference.Visible = True
                        TLSE_dialog.ShowDialog()
                    End If
                End If
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "An error has occurred when checking updates"
                    TLSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Une erreur est survenue lors de la vérification des mises à jour"
                    TLSE_dialog.ShowDialog()
                End If
            End Try
        End If
    End Sub

    Private Sub TL_SaveEditor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Checkupdates()
    End Sub

    Public Sub Selectlanguage()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_menu_open.Text = "Open"
            Text_menu_save.Text = "Save"
            Title_filever.Text = "Save file region :"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Island edit"
            Menu_text_itemsedit.Text = "Items edit"
            Menu_text_manual.Text = "Manual"
            Menu_text_miiedit.Text = "Mii edit"
            Menu_text_repair.Text = "Repair save file"
            Menu_text_settings.Text = "Settings"
            Text_spesymb_add_pn.Text = "Add"
            Text_spesymb_add_n.Text = "Add"
            Text_spesymb_cancel.Text = "Cancel"
            Title_islandname.Text = "Island's name"
            Title_problemsolved.Text = "Problems solved"
            Title_streetpassencounters.Text = "StreetPass encounters"
            Title_weddings.Text = "Weddings"
            Title_childrenborn.Text = "Children born"
            Title_travelersreceived.Text = "Travelers received"
            Title_travelerssent.Text = "Travelers sent"
            Title_rankingboard.Text = "Rankings board"
            Title_eventfountain.Text = "Event fountain"
            Title_appartrenov.Text = "Apartments renovation"
            Title_lastdatesave.Text = "Last save date"
            Title_islandaddress.Text = "Island's address"
            Setting_music.Text = "Active background music"
            Setting_hidden.Text = "Show hidden things"
            Setting_filepath.Text = "Show file path"
            Setting_ckupdate.Text = "Unactive check updates"
            Text_language.Text = "Language :"
            Setting_Advhelp.Text = "Show advance help"
            Setting_spesymb.Text = "Active special symbol"
            Settings_settings.Text = "Settings"
            Settings_changelog.Text = "Changelog"
            Settings_credits.Text = "Credits"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_menu_open.Text = "Ouvrir"
            Text_menu_save.Text = "Enregistrer"
            Title_filever.Text = "Région de la " & vbNewLine & "sauvegarde :"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Édition île"
            Menu_text_itemsedit.Text = "Édition objets"
            Menu_text_manual.Text = "Manuel"
            Menu_text_miiedit.Text = "Édition Mii"
            Menu_text_repair.Text = "Réparation sauvegarde"
            Menu_text_settings.Text = "Paramètres"
            Text_spesymb_add_pn.Text = "Ajouter"
            Text_spesymb_add_n.Text = "Ajouter"
            Text_spesymb_cancel.Text = "annuler"
            Title_islandname.Text = "Nom de l'île"
            Title_problemsolved.Text = "Problèmes résolus"
            Title_streetpassencounters.Text = "Rencontres StreetPass"
            Title_weddings.Text = "Marriages"
            Title_childrenborn.Text = "Nouveau né"
            Title_travelersreceived.Text = "Voyageurs reçus"
            Title_travelerssent.Text = "Voyageurs envoyés"
            Title_rankingboard.Text = "Classements"
            Title_eventfountain.Text = "Évènement fontaine"
            Title_appartrenov.Text = "Rénovation appartements"
            Title_lastdatesave.Text = "Dernière date sauvegarde"
            Title_islandaddress.Text = "Adresse de l'île"
            Setting_music.Text = "Activer la musique de fond"
            Setting_hidden.Text = "Afficher les choses cachées"
            Setting_filepath.Text = "Afficher le chemin du fichier"
            Setting_ckupdate.Text = "Désactiver la vérification des mises à jour"
            Text_language.Text = "Langage :"
            Setting_Advhelp.Text = "Afficher l'aide avancée"
            Setting_spesymb.Text = "Activer les symboles spéciaux"
            Settings_settings.Text = "Paramètres"
            Settings_changelog.Text = "Changelog"
            Settings_credits.Text = "Crédits"
        End If
    End Sub

    Private Sub Select_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_language.SelectedIndexChanged
        Selectlanguage()
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Public Sub switchfilever()
        If Filever_text.Text = "US" Then
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
        ElseIf Filever_text.Text = "EU" Then
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
        ElseIf Filever_text.Text = "JP" Then
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
            Icon_pronun_islandname.Visible = False
            Icon_tour.Image = My.Resources.touri
            Icon_part.Image = My.Resources.parti
            Icon_tour.Enabled = False
            Icon_part.Enabled = False
        ElseIf Filever_text.Text = "KR" Then
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
        ElseIf Filever_text.Text = "" Then
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
        End If
    End Sub
    'end form setting

    'header menu block
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
    'end header menu block

    'menu animation block
    Private Sub Text_menu_open_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_open.MouseMove, Text_menu_save.MouseMove
        Panel_menu_opensave.BackgroundImage = My.Resources.buttontop_largex2_act
    End Sub

    Private Sub Text_menu_open_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_open.MouseLeave, Text_menu_save.MouseLeave
        Panel_menu_opensave.BackgroundImage = My.Resources.buttontop_largex2
    End Sub

    Private Sub hidepanels()
        Panel_islandedit.Visible = False
        Panel_extras.Visible = False
        Panel_settings.Visible = False
        Panel_miiedit.Visible = False
        Panel_repairsave.Visible = False
        Panel_manual.Visible = False
    End Sub

    Private Sub Hideselectmenu()
        Menu_islandedit.BackgroundImage = Nothing
        Menu_miiedit.BackgroundImage = Nothing
        Menu_extras.BackgroundImage = Nothing
        Menu_itemsedit.BackgroundImage = Nothing
        Menu_Repair.BackgroundImage = Nothing
        Menu_manual.BackgroundImage = Nothing
        Menu_settings.BackgroundImage = Nothing
    End Sub

    Private Sub Menu_text_settings_Click(sender As Object, e As EventArgs) Handles Menu_settings.Click, Menu_text_settings.Click
        hidepanels()
        Hideselectmenu()
        Panel_settings.Visible = True
    End Sub

    Private Sub Menu_text_settings_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_settings.MouseMove, Menu_text_settings.MouseMove
        Menu_settings.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_settings_MouseLeave(sender As Object, e As EventArgs) Handles Menu_settings.MouseLeave, Menu_text_settings.MouseLeave
        If Panel_settings.Visible = True Then
            Menu_settings.BackgroundImage = My.Resources.bg_menu_selected
        Else
            Menu_settings.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Menu_text_islandedit_Click(sender As Object, e As EventArgs) Handles Menu_islandedit.Click, Menu_text_islandedit.Click
        hidepanels()
        Hideselectmenu()
        Panel_islandedit.Visible = True
    End Sub

    Private Sub Menu_text_islandedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_islandedit.MouseMove, Menu_text_islandedit.MouseMove
        Menu_islandedit.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_islandedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_islandedit.MouseLeave, Menu_text_islandedit.MouseLeave
        If Panel_islandedit.Visible = True Then
            Menu_islandedit.BackgroundImage = My.Resources.bg_menu_selected
        Else
            Menu_islandedit.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Menu_text_extras_Click(sender As Object, e As EventArgs) Handles Menu_extras.Click, Menu_text_extras.Click
        hidepanels()
        Hideselectmenu()
        Panel_extras.Visible = True
    End Sub

    Private Sub Menu_text_extras_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_extras.MouseMove, Menu_text_extras.MouseMove
        Menu_extras.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_extras_MouseLeave(sender As Object, e As EventArgs) Handles Menu_extras.MouseLeave, Menu_text_extras.MouseLeave
        If Panel_extras.Visible = True Then
            Menu_extras.BackgroundImage = My.Resources.bg_menu_selected
        Else
            Menu_extras.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Menu_text_repair_Click(sender As Object, e As EventArgs) Handles Menu_Repair.Click, Menu_text_repair.Click
        hidepanels()
        Hideselectmenu()
        Panel_repairsave.Visible = True
    End Sub

    Private Sub Menu_text_repair_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_Repair.MouseMove, Menu_text_repair.MouseMove
        Menu_Repair.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_repair_MouseLeave(sender As Object, e As EventArgs) Handles Menu_Repair.MouseLeave, Menu_text_repair.MouseLeave
        If Panel_repairsave.Visible = True Then
            Menu_Repair.BackgroundImage = My.Resources.bg_menu_selected
        Else
            Menu_Repair.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Menu_text_manual_Click(sender As Object, e As EventArgs) Handles Menu_manual.Click, Menu_text_manual.Click
        hidepanels()
        Hideselectmenu()
        Panel_manual.Visible = True
    End Sub

    Private Sub Menu_text_manual_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_manual.MouseMove, Menu_text_manual.MouseMove
        Menu_manual.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_manual_MouseLeave(sender As Object, e As EventArgs) Handles Menu_manual.MouseLeave, Menu_text_manual.MouseLeave
        If Panel_manual.Visible = True Then
            Menu_manual.BackgroundImage = My.Resources.bg_menu_selected
        Else
            Menu_manual.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Menu_text_miiedit_Click(sender As Object, e As EventArgs) Handles Menu_miiedit.Click, Menu_text_miiedit.Click
        hidepanels()
        Hideselectmenu()
        Panel_miiedit.Visible = True
    End Sub

    Private Sub Menu_text_miiedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_miiedit.MouseMove, Menu_text_miiedit.MouseMove
        Menu_miiedit.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_miiedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_miiedit.MouseLeave, Menu_text_miiedit.MouseLeave
        If Panel_miiedit.Visible = True Then
            Menu_miiedit.BackgroundImage = My.Resources.bg_menu_selected
        Else
            Menu_miiedit.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Menu_text_itemsedit_Click(sender As Object, e As EventArgs) Handles Menu_itemsedit.Click, Menu_text_itemsedit.Click
        Hideselectmenu()
    End Sub

    Private Sub Menu_text_itemsedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_itemsedit.MouseMove, Menu_text_itemsedit.MouseMove
        Menu_itemsedit.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseLeave, Menu_text_itemsedit.MouseLeave
        Menu_itemsedit.BackgroundImage = Nothing
    End Sub
    'end menu animation block

    'edit island animation block
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
            Text_description.Text = "Click to edit island's pronunciation name"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la prononciation du nom de l'île"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_pronun_islandname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseLeave
        Text_pronun_islandname.Visible = False
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_appart_Click(sender As Object, e As EventArgs) Handles Icon_appart.Click
        If valu_appart.Value < 2 Then
            valu_appart.Value = valu_appart.Value + 1
        ElseIf valu_appart.Value = 2 Then
            valu_appart.Value = 0
        End If
    End Sub

    Private Sub Icon_broc_Click(sender As Object, e As EventArgs) Handles Icon_broc.Click
        If valu_broc.Value < 2 Then
            valu_broc.Value = valu_broc.Value + 1
        ElseIf valu_broc.Value = 2 Then
            valu_broc.Value = 0
        End If
    End Sub

    Private Sub Icon_cafe_Click(sender As Object, e As EventArgs) Handles Icon_cafe.Click
        If valu_cafe.Value < 2 Then
            valu_cafe.Value = valu_cafe.Value + 1
        ElseIf valu_cafe.Value = 2 Then
            valu_cafe.Value = 0
        End If
    End Sub

    Private Sub Icon_chap_Click(sender As Object, e As EventArgs) Handles Icon_chap.Click
        If valu_chap.Value < 2 Then
            valu_chap.Value = valu_chap.Value + 1
        ElseIf valu_chap.Value = 2 Then
            valu_chap.Value = 0
        End If
    End Sub

    Private Sub Icon_classem_Click(sender As Object, e As EventArgs) Handles Icon_classem.Click
        If valu_classem.Value < 2 Then
            valu_classem.Value = valu_classem.Value + 1
        ElseIf valu_classem.Value = 2 Then
            valu_classem.Value = 0
        End If
    End Sub

    Private Sub Icon_conc_Click(sender As Object, e As EventArgs) Handles Icon_conc.Click
        If valu_conc.Value < 2 Then
            valu_conc.Value = valu_conc.Value + 1
        ElseIf valu_conc.Value = 2 Then
            valu_conc.Value = 0
        End If
    End Sub

    Private Sub Icon_deco_Click(sender As Object, e As EventArgs) Handles Icon_deco.Click
        If valu_deco.Value < 2 Then
            valu_deco.Value = valu_deco.Value + 1
        ElseIf valu_deco.Value = 2 Then
            valu_deco.Value = 0
        End If
    End Sub

    Private Sub Icon_epicer_Click(sender As Object, e As EventArgs) Handles Icon_epicer.Click
        If valu_epicer.Value < 2 Then
            valu_epicer.Value = valu_epicer.Value + 1
        ElseIf valu_epicer.Value = 2 Then
            valu_epicer.Value = 0
        End If
    End Sub

    Private Sub Icon_font_Click(sender As Object, e As EventArgs) Handles Icon_font.Click
        If valu_font.Value < 2 Then
            valu_font.Value = valu_font.Value + 1
        ElseIf valu_font.Value = 2 Then
            valu_font.Value = 0
        End If
    End Sub

    Private Sub Icon_info_Click(sender As Object, e As EventArgs) Handles Icon_info.Click
        If valu_info.Value < 2 Then
            valu_info.Value = valu_info.Value + 1
        ElseIf valu_info.Value = 2 Then
            valu_info.Value = 0
        End If
    End Sub

    Private Sub Icon_magimport_Click(sender As Object, e As EventArgs) Handles Icon_magimport.Click
        If valu_magimport.Value < 2 Then
            valu_magimport.Value = valu_magimport.Value + 1
        ElseIf valu_magimport.Value = 2 Then
            valu_magimport.Value = 0
        End If
    End Sub

    Private Sub Icon_mair_Click(sender As Object, e As EventArgs) Handles Icon_mair.Click
        If valu_mair.Value < 2 Then
            valu_mair.Value = valu_mair.Value + 1
        ElseIf valu_mair.Value = 2 Then
            valu_mair.Value = 0
        End If
    End Sub

    Private Sub Icon_mais_Click(sender As Object, e As EventArgs) Handles Icon_mais.Click
        If valu_mais.Value < 2 Then
            valu_mais.Value = valu_mais.Value + 1
        ElseIf valu_mais.Value = 2 Then
            valu_mais.Value = 0
        End If
    End Sub

    Private Sub Icon_parc_Click(sender As Object, e As EventArgs) Handles Icon_parc.Click
        If valu_parc.Value < 2 Then
            valu_parc.Value = valu_parc.Value + 1
        ElseIf valu_parc.Value = 2 Then
            valu_parc.Value = 0
        End If
    End Sub

    Private Sub Icon_parc1_Click(sender As Object, e As EventArgs) Handles Icon_parc1.Click
        If valu_parc1.Value < 2 Then
            valu_parc1.Value = valu_parc1.Value + 1
        ElseIf valu_parc1.Value = 2 Then
            valu_parc1.Value = 0
        End If
    End Sub

    Private Sub Icon_part_Click(sender As Object, e As EventArgs) Handles Icon_part.Click
        If valu_part.Value < 2 Then
            valu_part.Value = valu_part.Value + 1
        ElseIf valu_part.Value = 2 Then
            valu_part.Value = 0
        End If
    End Sub

    Private Sub Icon_plage_Click(sender As Object, e As EventArgs) Handles Icon_plage.Click
        If valu_plage.Value < 2 Then
            valu_plage.Value = valu_plage.Value + 1
        ElseIf valu_plage.Value = 2 Then
            valu_plage.Value = 0
        End If
    End Sub

    Private Sub Icon_port_Click(sender As Object, e As EventArgs) Handles Icon_port.Click
        If valu_port.Value < 2 Then
            valu_port.Value = valu_port.Value + 1
        ElseIf valu_port.Value = 2 Then
            valu_port.Value = 0
        End If
    End Sub

    Private Sub Icon_stud_Click(sender As Object, e As EventArgs) Handles Icon_stud.Click
        If valu_stud.Value < 2 Then
            valu_stud.Value = valu_stud.Value + 1
        ElseIf valu_stud.Value = 2 Then
            valu_stud.Value = 0
        End If
    End Sub

    Private Sub Icon_tervague_Click(sender As Object, e As EventArgs) Handles Icon_tervague.Click
        If valu_tervague.Value < 2 Then
            valu_tervague.Value = valu_tervague.Value + 1
        ElseIf valu_tervague.Value = 2 Then
            valu_tervague.Value = 0
        End If
    End Sub

    Private Sub Icon_test_Click(sender As Object, e As EventArgs) Handles Icon_test.Click
        If valu_test.Value < 2 Then
            valu_test.Value = valu_test.Value + 1
        ElseIf valu_test.Value = 2 Then
            valu_test.Value = 0
        End If
    End Sub

    Private Sub Icon_tour_Click(sender As Object, e As EventArgs) Handles Icon_tour.Click
        If valu_tour.Value < 2 Then
            valu_tour.Value = valu_tour.Value + 1
        ElseIf valu_tour.Value = 2 Then
            valu_tour.Value = 0
        End If
    End Sub

    Private Sub Icon_vetem_Click(sender As Object, e As EventArgs) Handles Icon_vetem.Click
        If valu_vetem.Value < 2 Then
            valu_vetem.Value = valu_vetem.Value + 1
        ElseIf valu_vetem.Value = 2 Then
            valu_vetem.Value = 0
        End If
    End Sub

    Private Sub valu_appart_ValueChanged(sender As Object, e As EventArgs) Handles valu_appart.ValueChanged
        If valu_appart.Value = 0 Then
            Icon_appart.Image = Nothing
        ElseIf valu_appart.Value = 1 Then
            Icon_appart.Image = My.Resources.appart
        ElseIf valu_appart.Value = 2 Then
            Icon_appart.Image = My.Resources.appartn
        End If
    End Sub

    Private Sub valu_broc_ValueChanged(sender As Object, e As EventArgs) Handles valu_broc.ValueChanged
        If valu_broc.Value = 0 Then
            Icon_broc.Image = Nothing
        ElseIf valu_broc.Value = 1 Then
            Icon_broc.Image = My.Resources.broc
        ElseIf valu_broc.Value = 2 Then
            Icon_broc.Image = My.Resources.brocn
        End If
    End Sub

    Private Sub valu_cafe_ValueChanged(sender As Object, e As EventArgs) Handles valu_cafe.ValueChanged
        If valu_cafe.Value = 0 Then
            Icon_cafe.Image = Nothing
        ElseIf valu_cafe.Value = 1 Then
            Icon_cafe.Image = My.Resources.cafe
        ElseIf valu_cafe.Value = 2 Then
            Icon_cafe.Image = My.Resources.cafen
        End If
    End Sub

    Private Sub valu_chap_ValueChanged(sender As Object, e As EventArgs) Handles valu_chap.ValueChanged
        If valu_chap.Value = 0 Then
            Icon_chap.Image = Nothing
        ElseIf valu_chap.Value = 1 Then
            Icon_chap.Image = My.Resources.chap
        ElseIf valu_chap.Value = 2 Then
            Icon_chap.Image = My.Resources.chapn
        End If
    End Sub

    Private Sub valu_classem_ValueChanged(sender As Object, e As EventArgs) Handles valu_classem.ValueChanged
        If valu_classem.Value = 0 Then
            Icon_classem.Image = Nothing
        ElseIf valu_classem.Value = 1 Then
            Icon_classem.Image = My.Resources.classem
        ElseIf valu_classem.Value = 2 Then
            Icon_classem.Image = My.Resources.classn
        End If
    End Sub

    Private Sub valu_conc_ValueChanged(sender As Object, e As EventArgs) Handles valu_conc.ValueChanged
        If valu_conc.Value = 0 Then
            Icon_conc.Image = Nothing
        ElseIf valu_conc.Value = 1 Then
            Icon_conc.Image = My.Resources.conc
        ElseIf valu_conc.Value = 2 Then
            Icon_conc.Image = My.Resources.concn
        End If
    End Sub

    Private Sub valu_deco_ValueChanged(sender As Object, e As EventArgs) Handles valu_deco.ValueChanged
        If valu_deco.Value = 0 Then
            Icon_deco.Image = Nothing
        ElseIf valu_deco.Value = 1 Then
            Icon_deco.Image = My.Resources.deco
        ElseIf valu_deco.Value = 2 Then
            Icon_deco.Image = My.Resources.decon
        End If
    End Sub

    Private Sub valu_epicer_ValueChanged(sender As Object, e As EventArgs) Handles valu_epicer.ValueChanged
        If valu_epicer.Value = 0 Then
            Icon_epicer.Image = Nothing
        ElseIf valu_epicer.Value = 1 Then
            Icon_epicer.Image = My.Resources.epicer
        ElseIf valu_epicer.Value = 2 Then
            Icon_epicer.Image = My.Resources.epicern
        End If
    End Sub

    Private Sub valu_font_ValueChanged(sender As Object, e As EventArgs) Handles valu_font.ValueChanged
        If valu_font.Value = 0 Then
            Icon_font.Image = Nothing
        ElseIf valu_font.Value = 1 Then
            Icon_font.Image = My.Resources.font
        ElseIf valu_font.Value = 2 Then
            Icon_font.Image = My.Resources.fontn
        End If
    End Sub

    Private Sub valu_info_ValueChanged(sender As Object, e As EventArgs) Handles valu_info.ValueChanged
        If valu_info.Value = 0 Then
            Icon_info.Image = Nothing
        ElseIf valu_info.Value = 1 Then
            Icon_info.Image = My.Resources.info
        ElseIf valu_info.Value = 2 Then
            Icon_info.Image = My.Resources.infon
        End If
    End Sub

    Private Sub valu_magimport_ValueChanged(sender As Object, e As EventArgs) Handles valu_magimport.ValueChanged
        If valu_magimport.Value = 0 Then
            Icon_magimport.Image = Nothing
        ElseIf valu_magimport.Value = 1 Then
            Icon_magimport.Image = My.Resources.magimport
        ElseIf valu_magimport.Value = 2 Then
            Icon_magimport.Image = My.Resources.magimportn
        End If
    End Sub

    Private Sub valu_mair_ValueChanged(sender As Object, e As EventArgs) Handles valu_mair.ValueChanged
        If valu_mair.Value = 0 Then
            Icon_mair.Image = Nothing
        ElseIf valu_mair.Value = 1 Then
            Icon_mair.Image = My.Resources.mair
        ElseIf valu_mair.Value = 2 Then
            Icon_mair.Image = My.Resources.mairn
        End If
    End Sub

    Private Sub valu_mais_ValueChanged(sender As Object, e As EventArgs) Handles valu_mais.ValueChanged
        If valu_mais.Value = 0 Then
            Icon_mais.Image = Nothing
        ElseIf valu_mais.Value = 1 Then
            Icon_mais.Image = My.Resources.mais
        ElseIf valu_mais.Value = 2 Then
            Icon_mais.Image = My.Resources.maisn
        End If
    End Sub

    Private Sub valu_parc_ValueChanged(sender As Object, e As EventArgs) Handles valu_parc.ValueChanged
        If valu_parc.Value = 0 Then
            Icon_parc.Image = Nothing
        ElseIf valu_parc.Value = 1 Then
            Icon_parc.Image = My.Resources.parc
        ElseIf valu_parc.Value = 2 Then
            Icon_parc.Image = My.Resources.parcn
        End If
    End Sub

    Private Sub valu_parc1_ValueChanged(sender As Object, e As EventArgs) Handles valu_parc1.ValueChanged
        If valu_parc1.Value = 0 Then
            Icon_parc1.Image = Nothing
        ElseIf valu_parc1.Value = 1 Then
            Icon_parc1.Image = My.Resources.parc1
        ElseIf valu_parc1.Value = 2 Then
            Icon_parc1.Image = My.Resources.parc1n
        End If
    End Sub

    Private Sub valu_part_ValueChanged(sender As Object, e As EventArgs) Handles valu_part.ValueChanged
        If valu_part.Value = 0 Then
            Icon_part.Image = Nothing
        ElseIf valu_part.Value = 1 Then
            Icon_part.Image = My.Resources.part
        ElseIf valu_part.Value = 2 Then
            Icon_part.Image = My.Resources.partn
        End If
    End Sub

    Private Sub valu_plage_ValueChanged(sender As Object, e As EventArgs) Handles valu_plage.ValueChanged
        If valu_plage.Value = 0 Then
            Icon_plage.Image = Nothing
        ElseIf valu_plage.Value = 1 Then
            Icon_plage.Image = My.Resources.plage
        ElseIf valu_plage.Value = 2 Then
            Icon_plage.Image = My.Resources.plagen
        End If
    End Sub

    Private Sub valu_port_ValueChanged(sender As Object, e As EventArgs) Handles valu_port.ValueChanged
        If valu_port.Value = 0 Then
            Icon_port.Image = Nothing
        ElseIf valu_port.Value = 1 Then
            Icon_port.Image = My.Resources.port
        ElseIf valu_port.Value = 2 Then
            Icon_port.Image = My.Resources.portn
        End If
    End Sub

    Private Sub valu_stud_ValueChanged(sender As Object, e As EventArgs) Handles valu_stud.ValueChanged
        If valu_stud.Value = 0 Then
            Icon_stud.Image = Nothing
        ElseIf valu_stud.Value = 1 Then
            Icon_stud.Image = My.Resources.stud
        ElseIf valu_stud.Value = 2 Then
            Icon_stud.Image = My.Resources.studn
        End If
    End Sub

    Private Sub valu_tervague_ValueChanged(sender As Object, e As EventArgs) Handles valu_tervague.ValueChanged
        If valu_tervague.Value = 0 Then
            Icon_tervague.Image = Nothing
        ElseIf valu_tervague.Value = 1 Then
            Icon_tervague.Image = My.Resources.tervague
        ElseIf valu_tervague.Value = 2 Then
            Icon_tervague.Image = My.Resources.tervaguen
        End If
    End Sub

    Private Sub valu_test_ValueChanged(sender As Object, e As EventArgs) Handles valu_test.ValueChanged
        If valu_test.Value = 0 Then
            Icon_test.Image = Nothing
        ElseIf valu_test.Value = 1 Then
            Icon_test.Image = My.Resources.test
        ElseIf valu_test.Value = 2 Then
            Icon_test.Image = My.Resources.testn
        End If
    End Sub

    Private Sub valu_tour_ValueChanged(sender As Object, e As EventArgs) Handles valu_tour.ValueChanged
        If valu_tour.Value = 0 Then
            Icon_tour.Image = Nothing
        ElseIf valu_tour.Value = 1 Then
            Icon_tour.Image = My.Resources.tour
        ElseIf valu_tour.Value = 2 Then
            Icon_tour.Image = My.Resources.tourn
        End If
    End Sub

    Private Sub valu_vetem_ValueChanged(sender As Object, e As EventArgs) Handles valu_vetem.ValueChanged
        If valu_vetem.Value = 0 Then
            Icon_vetem.Image = Nothing
        ElseIf valu_vetem.Value = 1 Then
            Icon_vetem.Image = My.Resources.vet
        ElseIf valu_vetem.Value = 2 Then
            Icon_vetem.Image = My.Resources.vetn
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

    Private Sub Icon_appartrenov_Click(sender As Object, e As EventArgs) Handles Icon_appartrenov.Click
        valu_appartrenov.Value = (valu_appartrenov.Value + 1)
    End Sub

    Private Sub valu_appartrenov_ValueChanged(sender As Object, e As EventArgs) Handles valu_appartrenov.ValueChanged
        If valu_appartrenov.Value > 3 Then
            valu_appartrenov.Value = 0
        End If
        If valu_appartrenov.Value = 0 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_00
        ElseIf valu_appartrenov.Value = 1 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_01
        ElseIf valu_appartrenov.Value = 2 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_02
        ElseIf valu_appartrenov.Value = 3 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_03
        End If
    End Sub

    Private Sub Icon_appartrenov_MouseMove(sender As Object, e As EventArgs) Handles Icon_appartrenov.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to edit apartments renovation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour éditer la rénovation des appartements"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_appartrenov_MouseLeave(sender As Object, e As EventArgs) Handles Icon_appartrenov.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_eventfountain_Click(sender As Object, e As EventArgs) Handles Icon_eventfountain.Click
        valu_eventfountain.Value = 0
        done()
    End Sub

    Private Sub Icon_eventfountain_MouseMove(sender As Object, e As EventArgs) Handles Icon_eventfountain.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to reactivate an event in fountain "
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour réactiver un évènement dans fontaine"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_eventfountain_MouseLeave(sender As Object, e As EventArgs) Handles Icon_eventfountain.MouseLeave
        If Timer_done.Enabled = True Then
            Panel_description.Visible = False
            Icon_description.Visible = True
        Else
            Panel_description.Visible = False
        End If
    End Sub

    Private Sub Icon_rank_vitality_Click(sender As Object, e As EventArgs) Handles Icon_rank_vitality.Click
        If valu_rank_vitality.Value = 2 Then
            valu_rank_vitality.Value = 0
        Else
            valu_rank_vitality.Value = valu_rank_vitality.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_popularity_Click(sender As Object, e As EventArgs) Handles Icon_rank_popularity.Click
        If valu_rank_popularity.Value = 2 Then
            valu_rank_popularity.Value = 0
        Else
            valu_rank_popularity.Value = valu_rank_popularity.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_boycharm_Click(sender As Object, e As EventArgs) Handles Icon_rank_boycharm.Click
        If valu_rank_boycharm.Value = 2 Then
            valu_rank_boycharm.Value = 0
        Else
            valu_rank_boycharm.Value = valu_rank_boycharm.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_girlcharm_Click(sender As Object, e As EventArgs) Handles Icon_rank_girlcharm.Click
        If valu_rank_girlcharm.Value = 2 Then
            valu_rank_girlcharm.Value = 0
        Else
            valu_rank_girlcharm.Value = valu_rank_girlcharm.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_pampered_Click(sender As Object, e As EventArgs) Handles Icon_rank_pampered.Click
        If valu_rank_pampered.Value = 2 Then
            valu_rank_pampered.Value = 0
        Else
            valu_rank_pampered.Value = valu_rank_pampered.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_friendship_Click(sender As Object, e As EventArgs) Handles Icon_rank_friendship.Click
        If valu_rank_friendship.Value = 2 Then
            valu_rank_friendship.Value = 0
        Else
            valu_rank_friendship.Value = valu_rank_friendship.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_romance_Click(sender As Object, e As EventArgs) Handles Icon_rank_romance.Click
        If valu_rank_romance.Value = 2 Then
            valu_rank_romance.Value = 0
        Else
            valu_rank_romance.Value = valu_rank_romance.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_island_Click(sender As Object, e As EventArgs) Handles Icon_rank_island.Click
        If valu_rank_island.Value = 2 Then
            valu_rank_island.Value = 0
        Else
            valu_rank_island.Value = valu_rank_island.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_traveler_Click(sender As Object, e As EventArgs) Handles Icon_rank_traveler.Click
        If valu_rank_traveler.Value = 2 Then
            valu_rank_traveler.Value = 0
        Else
            valu_rank_traveler.Value = valu_rank_traveler.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_splurge_Click(sender As Object, e As EventArgs) Handles Icon_rank_splurge.Click
        If valu_rank_splurge.Value = 2 Then
            valu_rank_splurge.Value = 0
        Else
            valu_rank_splurge.Value = valu_rank_splurge.Value + 1
        End If
    End Sub

    Private Sub valu_rank_vitality_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_vitality.ValueChanged
        If valu_rank_vitality.Value = 0 Then
            Icon_rank_vitality.Image = My.Resources.ranking_vitalityi
        ElseIf valu_rank_vitality.Value = 1 Then
            Icon_rank_vitality.Image = My.Resources.ranking_vitality
        ElseIf valu_rank_vitality.Value = 2 Then
            Icon_rank_vitality.Image = My.Resources.ranking_vitalityn
        End If
    End Sub

    Private Sub valu_rank_popularity_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_popularity.ValueChanged
        If valu_rank_popularity.Value = 0 Then
            Icon_rank_popularity.Image = My.Resources.ranking_popularityi
        ElseIf valu_rank_popularity.Value = 1 Then
            Icon_rank_popularity.Image = My.Resources.ranking_popularity
        ElseIf valu_rank_popularity.Value = 2 Then
            Icon_rank_popularity.Image = My.Resources.ranking_popularityn
        End If
    End Sub

    Private Sub valu_rank_boycharm_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_boycharm.ValueChanged
        If valu_rank_boycharm.Value = 0 Then
            Icon_rank_boycharm.Image = My.Resources.ranking_boycharmi
        ElseIf valu_rank_boycharm.Value = 1 Then
            Icon_rank_boycharm.Image = My.Resources.ranking_boycharm
        ElseIf valu_rank_boycharm.Value = 2 Then
            Icon_rank_boycharm.Image = My.Resources.ranking_boycharmn
        End If
    End Sub

    Private Sub valu_rank_girlcharm_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_girlcharm.ValueChanged
        If valu_rank_girlcharm.Value = 0 Then
            Icon_rank_girlcharm.Image = My.Resources.ranking_girlcharmi
        ElseIf valu_rank_girlcharm.Value = 1 Then
            Icon_rank_girlcharm.Image = My.Resources.ranking_girlcharm
        ElseIf valu_rank_girlcharm.Value = 2 Then
            Icon_rank_girlcharm.Image = My.Resources.ranking_girlcharmn
        End If
    End Sub

    Private Sub valu_rank_pampered_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_pampered.ValueChanged
        If valu_rank_pampered.Value = 0 Then
            Icon_rank_pampered.Image = My.Resources.ranking_pamperedi
        ElseIf valu_rank_pampered.Value = 1 Then
            Icon_rank_pampered.Image = My.Resources.ranking_pampered
        ElseIf valu_rank_pampered.Value = 2 Then
            Icon_rank_pampered.Image = My.Resources.ranking_pamperedn
        End If
    End Sub

    Private Sub valu_rank_friendship_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_friendship.ValueChanged
        If valu_rank_friendship.Value = 0 Then
            Icon_rank_friendship.Image = My.Resources.ranking_friendshipi
        ElseIf valu_rank_friendship.Value = 1 Then
            Icon_rank_friendship.Image = My.Resources.ranking_friendship
        ElseIf valu_rank_friendship.Value = 2 Then
            Icon_rank_friendship.Image = My.Resources.ranking_friendshipn
        End If
    End Sub

    Private Sub valu_rank_romance_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_romance.ValueChanged
        If valu_rank_romance.Value = 0 Then
            Icon_rank_romance.Image = My.Resources.ranking_romancei
        ElseIf valu_rank_romance.Value = 1 Then
            Icon_rank_romance.Image = My.Resources.ranking_romance
        ElseIf valu_rank_romance.Value = 2 Then
            Icon_rank_romance.Image = My.Resources.ranking_romancen
        End If
    End Sub

    Private Sub valu_rank_island_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_island.ValueChanged
        If valu_rank_island.Value = 0 Then
            Icon_rank_island.Image = My.Resources.ranking_islandi
        ElseIf valu_rank_island.Value = 1 Then
            Icon_rank_island.Image = My.Resources.ranking_island
        ElseIf valu_rank_island.Value = 2 Then
            Icon_rank_island.Image = My.Resources.ranking_islandn
        End If
    End Sub

    Private Sub valu_rank_traveler_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_traveler.ValueChanged
        If valu_rank_traveler.Value = 0 Then
            Icon_rank_traveler.Image = My.Resources.ranking_traveleri
        ElseIf valu_rank_traveler.Value = 1 Then
            Icon_rank_traveler.Image = My.Resources.ranking_traveler
        ElseIf valu_rank_traveler.Value = 2 Then
            Icon_rank_traveler.Image = My.Resources.ranking_travelern
        End If
    End Sub

    Private Sub valu_rank_splurge_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_splurge.ValueChanged
        If valu_rank_splurge.Value = 0 Then
            Icon_rank_splurge.Image = My.Resources.ranking_splurgei
        ElseIf valu_rank_splurge.Value = 1 Then
            Icon_rank_splurge.Image = My.Resources.ranking_splurge
        ElseIf valu_rank_splurge.Value = 2 Then
            Icon_rank_splurge.Image = My.Resources.ranking_splurgen
        End If
    End Sub

    Private Sub Text_spesymb_cancel_Click(sender As Object, e As EventArgs) Handles Text_spesymb_cancel.Click
        Panel_addsymb.Visible = False
    End Sub

    Private Sub Addsymbol_islandname_Click(sender As Object, e As EventArgs) Handles Addsymbol_islandname.Click
        Panel_addsymb.Visible = True
        Text_spesymb_add_n.Visible = True
        Text_spesymb_add_pn.Visible = False
    End Sub

    Private Sub Addsymbol_pronun_island_Click(sender As Object, e As EventArgs) Handles Addsymbol_pronun_island.Click
        Panel_addsymb.Visible = True
        Text_spesymb_add_n.Visible = False
        Text_spesymb_add_pn.Visible = True
    End Sub

    Private Sub Select_spesymb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_spesymb.SelectedIndexChanged
        If Select_spesymb.SelectedItem = Select_spesymb.Items.Item(0) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(1) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(2) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(3) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(4) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(5) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(6) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(7) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(8) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(9) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(10) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(11) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(12) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(13) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(14) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(15) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(16) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(17) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(18) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(19) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(20) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(21) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(22) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(23) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(24) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(25) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(26) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(27) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(28) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(29) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(30) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(31) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(32) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(33) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(34) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(35) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(36) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(37) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(38) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(39) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(40) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(41) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(42) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(43) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(44) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(45) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(46) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(47) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(48) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(49) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(50) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(51) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(52) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(53) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(54) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(55) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(56) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(57) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(58) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(59) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(60) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(61) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(62) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(63) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(64) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(65) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(66) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(67) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(68) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(69) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(70) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(71) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(72) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(73) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(74) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(75) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(76) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(77) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(78) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(79) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(80) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(81) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(82) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(83) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(84) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(85) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(86) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(87) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(88) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(89) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(90) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(91) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(92) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(93) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(94) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(95) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(96) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(97) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(98) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(99) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(100) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(101) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(102) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(103) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(104) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(105) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(106) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(107) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(108) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(109) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(110) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(111) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(112) Then
            Text_spesymb.Text = ""
        ElseIf Select_spesymb.SelectedItem = Select_spesymb.Items.Item(113) Then
            Text_spesymb.Text = ""
        End If
    End Sub

    Private Sub Text_spesymb_add_pn_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_pn.Click
        If Text_pronun_island.TextLength < 20 Then
            Text_pronun_island.Text = Text_pronun_island.Text & Text_spesymb.Text
            Panel_addsymb.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb.Visible = False
        End If
    End Sub

    Private Sub Text_spesymb_add_Click(sender As Object, e As EventArgs) Handles Text_spesymb_add_n.Click
        If Text_islandname.TextLength < 10 Then
            Text_islandname.Text = Text_islandname.Text & Text_spesymb.Text
            Panel_addsymb.Visible = False
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Maximum character reached"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Caractère maximum atteint"
            End If
            TLSE_dialog.ShowDialog()
            Panel_addsymb.Visible = False
        End If
    End Sub

    Private Sub Warning_islandaddress_Click(sender As Object, e As EventArgs) Handles Warning_islandaddress.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Warning :" & vbNewLine & "Some values can corrupt save file but this feature can be edited as you want" & vbNewLine & vbNewLine & "If your save is corrupted after has been restored, restore previous save file from ''bak'' folder"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Avertissement :" & vbNewLine & "Certaines valeurs peuvent corrompre le fichier de sauvegarde, mais cette fonctionnalité peut être modifiée à votre guise " & vbNewLine & vbNewLine & " Si votre sauvegarde est corrompue après avoir été restaurée, restaurez le fichier de sauvegarde précédent à partir du dossier '' bak '' "
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
    'end edit island animation block

    'settings animation
    Private Sub Setting_music_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_music.CheckedChanged
        startmusic()
    End Sub

    Private Sub Select_music_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_music.SelectedIndexChanged
        startmusic()
    End Sub

    Public Sub startmusic()
        Panel_bgmusic.Visible = True
        If Select_music.SelectedItem = Select_music.Items.Item(0) Then
            AudioTomodachi = My.Resources.sound1
        ElseIf Select_music.SelectedItem = Select_music.Items.Item(1) Then
            AudioTomodachi = My.Resources.sound2
        ElseIf Select_music.SelectedItem = Select_music.Items.Item(2) Then
            AudioTomodachi = My.Resources.sound3
        End If
        If Setting_music.Checked = True Then
            My.Computer.Audio.Play(AudioTomodachi, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
            Panel_bgmusic.Visible = False
        End If
    End Sub

    Private Sub Setting_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_hidden.CheckedChanged
        Hiddenthings()
    End Sub

    Public Sub Hiddenthings()
        If Setting_hidden.Checked = True Then
            Panel_hiddenthings.Visible = True
            valu_vetem.Visible = True
            valu_deco.Visible = True
            valu_tour.Visible = True
            valu_parc1.Visible = True
            valu_info.Visible = True
            valu_parc.Visible = True
            valu_mais.Visible = True
            valu_mair.Visible = True
            valu_appart.Visible = True
            valu_broc.Visible = True
            valu_chap.Visible = True
            valu_font.Visible = True
            valu_conc.Visible = True
            valu_classem.Visible = True
            valu_test.Visible = True
            valu_stud.Visible = True
            valu_cafe.Visible = True
            valu_epicer.Visible = True
            valu_magimport.Visible = True
            valu_plage.Visible = True
            valu_tervague.Visible = True
            valu_port.Visible = True
            valu_part.Visible = True
            valu_eventfountain.Visible = True
            valu_appartrenov.Visible = True
            valu_rank_vitality.Visible = True
            valu_rank_popularity.Visible = True
            valu_rank_boycharm.Visible = True
            valu_rank_girlcharm.Visible = True
            valu_rank_pampered.Visible = True
            valu_rank_friendship.Visible = True
            valu_rank_romance.Visible = True
            valu_rank_island.Visible = True
            valu_rank_traveler.Visible = True
            valu_rank_splurge.Visible = True
        Else
            Panel_hiddenthings.Visible = False
            valu_vetem.Visible = False
            valu_deco.Visible = False
            valu_tour.Visible = False
            valu_parc1.Visible = False
            valu_info.Visible = False
            valu_parc.Visible = False
            valu_mais.Visible = False
            valu_mair.Visible = False
            valu_appart.Visible = False
            valu_broc.Visible = False
            valu_chap.Visible = False
            valu_font.Visible = False
            valu_conc.Visible = False
            valu_classem.Visible = False
            valu_test.Visible = False
            valu_stud.Visible = False
            valu_cafe.Visible = False
            valu_epicer.Visible = False
            valu_magimport.Visible = False
            valu_plage.Visible = False
            valu_tervague.Visible = False
            valu_port.Visible = False
            valu_part.Visible = False
            valu_eventfountain.Visible = False
            valu_appartrenov.Visible = False
            valu_rank_vitality.Visible = False
            valu_rank_popularity.Visible = False
            valu_rank_boycharm.Visible = False
            valu_rank_girlcharm.Visible = False
            valu_rank_pampered.Visible = False
            valu_rank_friendship.Visible = False
            valu_rank_romance.Visible = False
            valu_rank_island.Visible = False
            valu_rank_traveler.Visible = False
            valu_rank_splurge.Visible = False
        End If
    End Sub

    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            Panel_filepath.Visible = True
        Else
            Panel_filepath.Visible = False
        End If
    End Sub

    Private Sub Setting_ckupdate_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_ckupdate.CheckedChanged
        If Setting_ckupdate.Checked = True Then
            Panel_chkupdate.Visible = True
        Else
            Panel_chkupdate.Visible = False
        End If
    End Sub

    Private Sub Setting_Advhelp_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_Advhelp.CheckedChanged
        If Setting_Advhelp.Checked = True Then
            Panel_Advhelp.Visible = True
            AdvH_islandname.Visible = True
            AdvH_problemssolved.Visible = True
            AdvH_streetencounters.Visible = True
            AdvH_weddings.Visible = True
            AdvH_childborn.Visible = True
            AdvH_travelersreceived.Visible = True
            AdvH_travelerssent.Visible = True
            AdvH_islandbuild.Visible = True
            AdvH_money.Visible = True
            AdvH_eventfountain.Visible = True
            AdvH_apartrenov.Visible = True
            AdvH_rankboard.Visible = True
            AdvH_islandaddress.Visible = True
            AdvH_lastdatesave.Visible = True
            Warning_islandname.Visible = False
        ElseIf Setting_Advhelp.Checked = False Then
            Panel_Advhelp.Visible = False
            AdvH_islandname.Visible = False
            AdvH_problemssolved.Visible = False
            AdvH_streetencounters.Visible = False
            AdvH_weddings.Visible = False
            AdvH_childborn.Visible = False
            AdvH_travelersreceived.Visible = False
            AdvH_travelerssent.Visible = False
            AdvH_islandbuild.Visible = False
            AdvH_money.Visible = False
            AdvH_eventfountain.Visible = False
            AdvH_apartrenov.Visible = False
            AdvH_rankboard.Visible = False
            AdvH_islandaddress.Visible = False
            AdvH_lastdatesave.Visible = False
            AdvH_islandnamepronun.Visible = False
            If Setting_spesymb.Checked = True Then
                Warning_islandname.Visible = True
            Else
                Warning_islandname.Visible = False
            End If

        End If
    End Sub

    Private Sub Setting_spesymb_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_spesymb.CheckedChanged
        If Setting_spesymb.Checked = True Then
            Panel_bspesymb.Visible = True
            Addsymbol_islandname.Visible = True
            If Setting_Advhelp.Checked = False Then
                Warning_islandname.Visible = True
            End If
        ElseIf Setting_spesymb.Checked = False Then
            Panel_bspesymb.Visible = False
            Addsymbol_islandname.Visible = False
            Addsymbol_pronun_island.Visible = False
            Warning_islandname.Visible = False
        End If
    End Sub

    Private Sub Panel_filepath_MouseMove(sender As Object, e As EventArgs) Handles Panel_filepath.MouseMove
        Panel_filepath.BackgroundImage = My.Resources.buttontop_single_act
        TextBox_fpath.Visible = True
    End Sub

    Private Sub Panel_filepath_MouseLeave(sender As Object, e As EventArgs) Handles Panel_filepath.MouseLeave
        Panel_filepath.BackgroundImage = My.Resources.buttontop_single
        TextBox_fpath.Visible = False
    End Sub

    Private Sub Panel_description_VisibleChanged(sender As Object, e As EventArgs) Handles Panel_description.VisibleChanged
        If Panel_description.Visible = True Then
            If Filever_text.Text = "JP" Or Filever_text.Text = "KR" Then
                Icon_description.Image = My.Resources.icon_tomojp
            Else
                Icon_description.Image = My.Resources.icon_tomoeu
            End If
            Icon_description.Visible = True
        Else
            Icon_description.Visible = False
        End If
    End Sub

    Private Sub Panel_done_VisibleChanged(sender As Object, e As EventArgs) Handles Panel_done.VisibleChanged
        If Panel_done.Visible = True Then
            If Filever_text.Text = "JP" Or Filever_text.Text = "KR" Then
                Icon_description.Image = My.Resources.icon_tomojp
            Else
                Icon_description.Image = My.Resources.icon_tomoeu
            End If
            Icon_description.Visible = True
        Else
            Icon_description.Visible = False
        End If
    End Sub

    Public Sub done()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_done.Text = "It's done !"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_done.Text = "C'est fait !"
        End If
        Panel_done.Visible = True
        Timer_done.Start
    End Sub

    Private Sub Timer_done_Tick(sender As Object, e As EventArgs) Handles Timer_done.Tick
        Timer_done.Stop()
        Panel_done.Visible = False
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to access to Tomodachi Life Save Editor page (Github)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to access to Tomodachi Life Save Editor page (gbatemp.net)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Miitopia Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Chibi Robo zip Lash Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Paper Mario Sticker Star Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Ironfall Invasion Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try 3ds Nintendogs + cats Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Mario Party Island Tour Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
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
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try 3DS Save Editors Library"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer 3DS Save Editors Library"
        End If
        Panel_description.Visible = True
    End Sub
    'end setting animation

    ' Advance help island edit
    Private Sub AdvH_islandname_Click(sender As Object, e As EventArgs) Handles AdvH_islandname.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_islandname.Location.X + (Panel_islandname.Width / 2), Panel_islandname.Location.Y + (Panel_islandname.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit your island name here" & vbNewLine & vbNewLine & "If you add a special symbol, island name will be '???' in the data of a crossed Mii via StreetPass"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer le nom de votre île ici" & vbNewLine & vbNewLine & "si vous ajoutez un symbole spécial, le nom de votre île sera '???' dans les donnés d'un Mii croisé via StreetPass"
        End If
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_pronun_islandname.Location.X + (Icon_pronun_islandname.Width / 2), Icon_pronun_islandname.Location.Y + (Icon_pronun_islandname.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to edit island name pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour éditer la prononciation du nom de l'île"
        End If
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_islandnamepronun_Click(sender As Object, e As EventArgs) Handles AdvH_islandnamepronun.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_edit_pronun_island.Location.X + (Panel_edit_pronun_island.Width / 2), Panel_edit_pronun_island.Location.Y + (Panel_edit_pronun_island.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit your island name pronunciation here" & vbNewLine & vbNewLine & "Special symbols can be added but they are won't pronounced"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer la prononciation du nom de votre île ici" & vbNewLine & vbNewLine & "si vous ajoutez des symboles spéciaux mais ils seront pas prononcés"
        End If
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_edit_pronun_island.Location.X + (Panel_edit_pronun_island.Width / 2) + 80, Panel_edit_pronun_island.Location.Y + (Panel_edit_pronun_island.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to validate island name pronunciation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour valider la prononciation du nom de l'île"
        End If
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_problemssolved_Click(sender As Object, e As EventArgs) Handles AdvH_problemssolved.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_problemsolved.Location.X + (Panel_problemsolved.Width / 2), Panel_problemsolved.Location.Y + (Panel_problemsolved.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit your problems solved on your island here"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer les problèmes résolus sur votre île ici"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_problemsolved.Location.X + (Icon_problemsolved.Width / 2), Icon_problemsolved.Location.Y + (Icon_problemsolved.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to set 'problems solved' value to maximum"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour mettre la valeur de 'problèmes résolus' au maximum"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_streetencounters_Click(sender As Object, e As EventArgs) Handles AdvH_streetencounters.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_streetpassencounters.Location.X + (Panel_streetpassencounters.Width / 2), Panel_streetpassencounters.Location.Y + (Panel_streetpassencounters.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit StreetPass encounters number here"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer le nombre de StreetPass reçus ici"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_streetpassencounters.Location.X + (Icon_streetpassencounters.Width / 2), Icon_streetpassencounters.Location.Y + (Icon_streetpassencounters.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to set 'StreetPass encounters' value to maximum"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour mettre la valeur de 'StreetPass reçus' au maximum"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_weddings_Click(sender As Object, e As EventArgs) Handles AdvH_weddings.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_weddings.Location.X + (Panel_weddings.Width / 2), Panel_weddings.Location.Y + (Panel_weddings.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit Weddings number here"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer le nombre de Marriage ici"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_weddings.Location.X + (Icon_weddings.Width / 2), Icon_weddings.Location.Y + (Icon_weddings.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to set 'Weddings' value to maximum"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour mettre la valeur de 'Marriage' au maximum"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_childborn_Click(sender As Object, e As EventArgs) Handles AdvH_childborn.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_childrenborn.Location.X + (Panel_childrenborn.Width / 2), Panel_childrenborn.Location.Y + (Panel_childrenborn.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit Children born number here"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer le nombre de Nouveau né ici"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_childrenborn.Location.X + (Icon_childrenborn.Width / 2), Icon_childrenborn.Location.Y + (Icon_childrenborn.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to set 'Children born' value to maximum"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour mettre la valeur de 'Nouveau né' au maximum"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_travelersreceived_Click(sender As Object, e As EventArgs) Handles AdvH_travelersreceived.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_travelersreceived.Location.X + (Panel_travelersreceived.Width / 2), Panel_travelersreceived.Location.Y + (Panel_travelersreceived.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit Travelers received number here"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer le nombre de Voyageurs reçus ici"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_travelersreceived.Location.X + (Icon_travelersreceived.Width / 2), Icon_travelersreceived.Location.Y + (Icon_travelersreceived.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to set 'Travelers received' value to maximum"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour mettre la valeur de 'Voyageurs reçus' au maximum"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_travelerssent_Click(sender As Object, e As EventArgs) Handles AdvH_travelerssent.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_travelerssent.Location.X + (Panel_travelerssent.Width / 2), Panel_travelerssent.Location.Y + (Panel_travelerssent.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit Travelers sent number here"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer le nombre de Voyageurs envoyés ici"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_travelerssent.Location.X + (Icon_travelerssent.Width / 2), Icon_travelerssent.Location.Y + (Icon_travelerssent.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to set 'Travelers sent' value to maximum"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour mettre la valeur de 'Voyageurs envoyés' au maximum"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_rankboard_Click(sender As Object, e As EventArgs) Handles AdvH_rankboard.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_rankboard.Location.X + (Panel_rankboard.Width / 2), Panel_rankboard.Location.Y + (Panel_rankboard.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        TLSE_dialog.Icon_reference.Image = My.Resources.info_rankingboard
        TLSE_dialog.Icon_reference.Location = New Point(395, 335)
        TLSE_dialog.Icon_reference.BackgroundImage = My.Resources.bg_dialog
        TLSE_dialog.Icon_reference.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Click on icons to edit ranking board"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Cliquez sur les icônes pour éditer le tableau des classements"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 6
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_lastdatesave_Click(sender As Object, e As EventArgs) Handles AdvH_lastdatesave.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_lastdatesave.Location.X + (Panel_lastdatesave.Width / 2), Panel_lastdatesave.Location.Y + (Panel_lastdatesave.Height / 2) - 8)
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "This feature is not editable" & vbNewLine & vbNewLine & "This value is used to patch Mii interactions and to reuse travelers"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Cette fonctionnalité n'est pas éditable" & vbNewLine & vbNewLine & "Cette valeur est utilisé pour patcher les interactions des Mii et pour réutiliser les voyageurs"
        End If
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_islandbuild_Click(sender As Object, e As EventArgs) Handles AdvH_islandbuild.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_islandbuilding.Location.X + (Panel_islandbuilding.Width / 2), Panel_islandbuilding.Location.Y + (Panel_islandbuilding.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        TLSE_dialog.Icon_reference.Image = My.Resources.info_islandbuilding
        TLSE_dialog.Icon_reference.Location = New Point(395, 335)
        TLSE_dialog.Icon_reference.BackgroundImage = My.Resources.bg_dialog
        TLSE_dialog.Icon_reference.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Click on icons to edit Island's building"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Cliquez sur les icônes pour éditer les bâtiments de l'île"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 6
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_money_Click(sender As Object, e As EventArgs) Handles AdvH_money.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_money.Location.X + (Panel_money.Width / 2), Panel_money.Location.Y + (Panel_money.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit money here"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer l'argent ici"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 3
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_money.Location.X + 10, Panel_money.Location.Y + (Panel_money.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to set Money value to maximum"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour mettre la valeur de l'Argent au maximum"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 3
        TLSE_dialog.ShowDialog()

    End Sub

    Private Sub AdvH_eventfountain_Click(sender As Object, e As EventArgs) Handles AdvH_eventfountain.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_eventfountain.Location.X + (Icon_eventfountain.Width / 2), Icon_eventfountain.Location.Y + (Icon_eventfountain.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to active an event in fountain"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour activer un évènement dans la fontaine"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 3
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_apartrenov_Click(sender As Object, e As EventArgs) Handles AdvH_apartrenov.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_appartrenov.Location.X + (Icon_appartrenov.Width / 2), Icon_appartrenov.Location.Y + (Icon_appartrenov.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to edit apartments renovation"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour la rénovation des appartements"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 3
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_islandaddress_Click(sender As Object, e As EventArgs) Handles AdvH_islandaddress.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(481, 485)
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit here island's address" & vbNewLine & vbNewLine & "Some values can corrupt your save file, if he's corrupted retry with other values or restore an older save file in 'backup' folder"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer ici l'addresse de l'île" & vbNewLine & vbNewLine & "Certaines valeurs peuvent corrompre votre sauvegarde, si c'est le cas réessayez avec d'autres valeurs ou restaurez une ancienne sauvegarde depuis le dossier 'backup'"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 5
        TLSE_dialog.ShowDialog()
    End Sub
    ' end Advance help island edit

    'read savedataArc
    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Try
            Dim open As New OpenFileDialog
            open.Filter = "Text files|*.txt"
            open.Title = "Open save savedataArc.txt"
            open.ShowDialog()
            savedataArc = open.FileName
            If FileLen(savedataArc) = &H1E4C98 Then
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "EUR or USA save file detected" & vbNewLine & "Choose a save file region corresponding to your game region"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Sauvegarde EUR ou USA détecté" & vbNewLine & "Choisissez une région de sauvegarde correspondant à la région de votre jeux"
                End If
                TLSE_dialog.Panel_Cancel.Visible = True
                TLSE_dialog.Panel_OK.Visible = True
                TLSE_dialog.OK_Button.Text = "EUR"
                TLSE_dialog.Cancel_Button.Text = "USA"
                TLSE_dialog.ShowDialog()
                If TLSE_dialog.DialogResult = DialogResult.OK Then
                    Filever_text.Text = "EU"
                ElseIf TLSE_dialog.DialogResult = DialogResult.Cancel Then
                    Filever_text.Text = "US"
                End If
            ElseIf FileLen(savedataArc) = &H1F0048 Then
                Filever_text.Text = "KR"

            ElseIf FileLen(savedataArc) = &H14BD68 Then
                Filever_text.Text = "JP"
            Else
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Invalid Tomodachi Life save file"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Sauvegarde de Tomodachi Life invalide"
                End If
                TLSE_dialog.ShowDialog()
                Filever_text.Text = ""
            End If
            switchfilever()
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "JP" Or Filever_text.Text = "KR" Then
                Savefileregion()
                ReadsavedataArc()
                Makebackup()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ReadsavedataArc()
        Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
        Try
            Reader.Position = Money
            valu_money.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Money', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Argent', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_money.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = IslandName
            Text_islandname.Text = Reader.ReadUnicodeString(10)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Island name', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Nom de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Text_islandname.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
            Try
                Reader.Position = IslandPronun
                Text_pronun_islandname.Text = Reader.ReadUnicodeString(20)
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Island name pronunciation', please report this issue"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Prononciation du nom de l'île', veuillez signaler ce problème"
                End If
                TLSE_dialog.ShowDialog()
                Text_pronun_islandname.BackColor = Color.Red
                Text_menu_open.BackColor = Color.Red
            End Try
        End If
        Try
            Reader.Position = Problemsolved
            valu_problemsolved.Value = Reader.ReadUInt16
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Problems solved', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Soucis résolus', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_problemsolved.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Weddings
            valu_weddings.Value = Reader.ReadUInt16
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Weddings', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Marriages', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_weddings.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Childrenborn
            valu_childrenborn.Value = Reader.ReadUInt16
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Children born', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Nouveau né', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_childrenborn.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Travelreceived
            valu_travelersreceived.Value = Reader.ReadUInt16
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Travelers received', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Voyageurs reçus', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_travelersreceived.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = StreetPassencount
            valu_streetpassencounters.Value = Reader.ReadUInt16
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'StreetPass encounters', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'StreetPass reçus', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_streetpassencounters.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Travelsent
            valu_travelerssent.Value = Reader.ReadUInt16
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Travelers sent', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Voyageurs envoyés', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_travelerssent.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Eventfountain
            valu_eventfountain.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Event fountain', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Évènement fontaine', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_eventfountain.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Appartrenov
            valu_appartrenov.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Apartments renovation', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Rénovation appartements', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_appartrenov.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Lastsavedate
            valu_lastdatesave.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Last date save', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Dernière date sauvegarde', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_lastdatesave.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankvitality
            valu_rank_vitality.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking vitality', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements forme générale', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_vitality.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankpopularity
            valu_rank_popularity.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking popularity', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements popularité', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_popularity.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankboycharm
            valu_rank_boycharm.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking boy charm', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements garçons populaires', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_boycharm.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankgirlcharm
            valu_rank_girlcharm.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking girl charm', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements filles populaires', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_girlcharm.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankpampered
            valu_rank_pampered.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking pampered', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements Mii préférés', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_pampered.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankfriendship
            valu_rank_friendship.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking friendship', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements amitié', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_friendship.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankromance
            valu_rank_romance.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking romance', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements relations amoureuses', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_romance.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Rankisland
            valu_rank_island.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking island', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements qualité de vie', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_island.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Ranktravelers
            valu_rank_traveler.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking travelers', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements Mii voyageurs', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_traveler.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Ranksplurge
            valu_rank_splurge.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Ranking splurge', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Classements Mii dépensiers', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_rank_splurge.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Islandaddres_1
            valu_islandaddress_p1.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_islandaddress_p1.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Islandaddres_2
            valu_islandaddress_p2.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_islandaddress_p2.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Islandaddres_3
            valu_islandaddress_p3.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_islandaddress_p3.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = Islandaddres_4
            valu_islandaddress_p4.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_islandaddress_p4.BackColor = Color.Red
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = appart
            valu_appart.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building Mii apartments', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment appartements Mii', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_appart.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = mair
            valu_mair.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building town hall', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment mairie', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_mair.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = info
            valu_info.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building Mii news', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment infos Mii', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_info.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = classem
            valu_classem.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building rankings board', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment classements', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_classem.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = vetem
            valu_vetem.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building clothing', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment vêtements', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_vetem.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = chap
            valu_chap.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building hats', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment chapeaux', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_chap.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = epicer
            valu_epicer.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building food mart', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment épicerie', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_epicer.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = deco
            valu_deco.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building interiors', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment déco d'intérieur', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_deco.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = broc
            valu_broc.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building pawn shop', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment brocante', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_broc.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = magimport
            valu_magimport.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building import wear', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment magasin d'import', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_magimport.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = fontai
            valu_font.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building fountain', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment fontaine', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_font.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = mais
            valu_mais.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building Mii homes', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment maisons Mii', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_mais.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = port
            valu_port.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building port', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment port', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_port.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = tervague
            valu_tervague.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building campground', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment terrain vague', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_tervague.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = conc
            valu_conc.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building concert hall', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment salle de concert', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_conc.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = test
            valu_test.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building compatibility tester', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment testeur de compatibilité', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_test.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = stud
            valu_stud.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building photo studio', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment studio photo', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_stud.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = plage
            valu_plage.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building beach', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment plage', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_plage.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = parc1
            valu_parc1.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building park', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment parc', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_parc1.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = cafe
            valu_cafe.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building café', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment café', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_cafe.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = parc
            valu_parc.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building amusement park', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment parc d'attractions', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_parc.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = tour
            valu_tour.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building observation tower', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment tour d'observation', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_tour.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        Try
            Reader.Position = part
            valu_part.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Reading of this feature has failed : 'Building 3DS image share', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette fonctionnalité a échoué : 'Bâtiment partage d'images 3DS', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            Icon_part.Image = My.Resources.icon_issue
            Text_menu_open.BackColor = Color.Red
        End Try
        If Text_menu_open.BackColor = Color.Red Then
            Text_menu_save.Visible = False
            Text_menu_open.Enabled = False
        Else
            Text_menu_save.Visible = True
        End If
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
            Eventfountain = &H1E4AF8
            Appartrenov = &H1E4C79
            Lastsavedate = &H10
            Rankvitality = &H1E4C3E
            Rankpopularity = &H1E4C3F
            Rankboycharm = &H1E4C42
            Rankgirlcharm = &H1E4C43
            Rankpampered = &H1E4C44
            Rankfriendship = &H1E4C40
            Rankromance = &H1E4C41
            Rankisland = &H1E4C47
            Ranktravelers = &H1E4C46
            Ranksplurge = &H1E4C45
            Islandaddres_1 = &H20
            Islandaddres_2 = &H24
            Islandaddres_3 = &H28
            Islandaddres_4 = &H2C
            appart = &H1E4C20
            mair = &H1E4C21
            info = &H1E4C22
            classem = &H1E4C23
            vetem = &H1E4C24
            chap = &H1E4C25
            epicer = &H1E4C26
            deco = &H1E4C27
            broc = &H1E4C28
            magimport = &H1E4C29
            fontai = &H1E4C2A
            mais = &H1E4C2B
            port = &H1E4C2C
            tervague = &H1E4C2D
            conc = &H1E4C2E
            test = &H1E4C2F
            stud = &H1E4C30
            plage = &H1E4C31
            parc1 = &H1E4C32
            cafe = &H1E4C33
            parc = &H1E4C34
            tour = &H1E4C35
            part = &H1E4C36
        ElseIf Filever_text.Text = "JP" Then
            Money = &H14BCA8
            IslandName = &H14BCBC
            Problemsolved = &H14BCB6
            Weddings = &H14BCB0
            Childrenborn = &H14BCB2
            Travelreceived = &H14BCAE
            StreetPassencount = &H14BCAC
            Travelsent = &H14BCB4
            Eventfountain = &H14BBE8
            Appartrenov = &H14BD49
            Lastsavedate = &H10
            Rankvitality = &H14BD0E
            Rankpopularity = &H14BD0F
            Rankboycharm = &H14BD12
            Rankgirlcharm = &H14BD13
            Rankpampered = &H14BD14
            Rankfriendship = &H14BD10
            Rankromance = &H14BD11
            Rankisland = &H14BD17
            Ranktravelers = &H14BD16
            Ranksplurge = &H14BD15
            Islandaddres_1 = &H20
            Islandaddres_2 = &H24
            Islandaddres_3 = &H28
            Islandaddres_4 = &H2C
            appart = &H14BCF0
            mair = &H14BCF1
            info = &H14BCF2
            classem = &H14BCF3
            vetem = &H14BCF4
            chap = &H14BCF5
            epicer = &H14BCF6
            deco = &H14BCF7
            broc = &H14BCF8
            magimport = &H14BCF9
            fontai = &H14BCFA
            mais = &H14BCFB
            port = &H14BCFC
            tervague = &H14BCFD
            conc = &H14BCFE
            test = &H14BCFF
            stud = &H14BD00
            plage = &H14BD01
            parc1 = &H14BD02
            cafe = &H14BD03
            parc = &H14BD04
            tour = &H14BD05
            part = &H14BD06
        ElseIf Filever_text.Text = "KR" Then
            Money = &H1EFF68
            IslandName = &H1EFF7C
            Problemsolved = &H1EFF76
            Weddings = &H1EFF70
            Childrenborn = &H1EFF72
            Travelreceived = &H1EFF6E
            StreetPassencount = &H1EFF6C
            Travelsent = &H1EFF74
            Eventfountain = &H1EFEA8
            Appartrenov = &H1F0029
            Lastsavedate = &H10
            Rankvitality = &H1EFFEE
            Rankpopularity = &H1EFFEF
            Rankboycharm = &H1EFFF2
            Rankgirlcharm = &H1EFFF3
            Rankpampered = &H1EFFF4
            Rankfriendship = &H1EFFF0
            Rankromance = &H1EFFF1
            Rankisland = &H1EFFF7
            Ranktravelers = &H1EFFF6
            Ranksplurge = &H1EFFF5
            Islandaddres_1 = &H20
            Islandaddres_2 = &H24
            Islandaddres_3 = &H28
            Islandaddres_4 = &H2C
            appart = &H1EFFD0
            mair = &H1EFFD1
            info = &H1EFFD2
            classem = &H1EFFD3
            vetem = &H1EFFD4
            chap = &H1EFFD5
            epicer = &H1EFFD6
            deco = &H1EFFD7
            broc = &H1EFFD8
            magimport = &H1EFFD9
            fontai = &H1EFFDA
            mais = &H1EFFDB
            port = &H1EFFDC
            tervague = &H1EFFDD
            conc = &H1EFFDE
            test = &H1EFFDF
            stud = &H1EFFE0
            plage = &H1EFFE1
            parc1 = &H1EFFE2
            cafe = &H1EFFE3
            parc = &H1EFFE4
            tour = &H1EFFE5
            part = &H1EFFE6
        End If
    End Sub

    Public Sub Makebackup()
        Try
            If Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\Backup\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\Backup\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\Backup\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "KR" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\Backup\KOR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            Timer_done.Interval = Timer_done.Interval + 500
            done()
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                Text_done.Text = "Backup done !"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                Text_done.Text = "Backup fait !"
            End If
        Catch ex As Exception
        End Try
    End Sub
    'end read savedataArc

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        WritesavedataArc()
    End Sub

    Public Sub WritesavedataArc()
        Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
        Try
            Writer.Position = Money
            Writer.WriteUInt32(valu_money.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Money', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'écriture de cette fonctionnalité a échoué : 'Argent', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_money.BackColor = Color.Orange
        End Try
    End Sub
    'save savedataArc
End Class
