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
    Dim accessappartMii As String
    Dim spaceappartMii As String
    Dim accessrelationship As String
    Dim Pagh1 As String
    Dim Pagh2 As String
    Dim Pagh3 As String
    Dim Pagh4 As String
    Dim Pagh5 As String
    Dim Pagh6 As String
    Dim Pagh7 As String
    Dim Pagh8 As String
    Dim Pagh9 As String
    Dim Pagh10 As String
    Dim Pagh11 As String
    Dim Pagh12 As String
    Dim Pagh13 As String
    Dim Tmusc As String
    Dim Accesspagh As String
    Dim ValPagh1 As String
    Dim ValPagh2 As String
    Dim ValPagh3 As String
    Dim ValPagh4 As String
    Dim ValPagh5 As String
    Dim ValPagh6 As String
    Dim ValPagh7 As String
    Dim ValPagh8 As String
    Dim ValPagh9 As String
    Dim ValPagh10 As String
    Dim ValPagh11 As String
    Dim ValPagh12 As String
    Dim ValPagh13 As String
    Dim Typesong As String

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
            Check_resetstpspp.Text = "Reset Tomodachi Life Streetpass / Spotpass"
            Check_timetravel.Text = "Remove time travel penality"
            Check_resetmiiapart.Text = "Reset Mii apartments"
            Check_resetnewsflash.Text = "Reset News flash"
            Check_resetitems.Text = "Reset all items"
            Check_resetrelationship.Text = "Reset all Mii's relationship"
            Text_title_editsongs.Text = "Concert Hall"
            Text_save_editsongs.Text = "Save"
            Check_setalltummy.Text = "Set all Mii's tummy to :"
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
            Check_resetstpspp.Text = "Réinitialiser Streetpass / Spotpass de Tomodachi Life"
            Check_timetravel.Text = "Retirer la pénalité de voyage dans le temps"
            Check_resetmiiapart.Text = "Réinitialiser les appartements des Mii"
            Check_resetnewsflash.Text = "Réinitialiser les Flash info"
            Check_resetitems.Text = "Réinitialiser tout les objets"
            Check_resetrelationship.Text = "Réinitialiser toutes les relations des Mii"
            Text_title_editsongs.Text = "Salle de Concert"
            Text_save_editsongs.Text = "Enregistrer"
            Check_setalltummy.Text = "Mettre l'estomac des Mii :"
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
            Menu_concertedit.Visible = True
        ElseIf Filever_text.Text = "EU" Then
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Menu_concertedit.Visible = True
        ElseIf Filever_text.Text = "JP" Then
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
            Icon_pronun_islandname.Visible = False
            Icon_tour.Image = My.Resources.touri
            Icon_part.Image = My.Resources.parti
            Icon_tour.Enabled = False
            Icon_part.Enabled = False
            Menu_concertedit.Visible = False
        ElseIf Filever_text.Text = "KR" Then
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Menu_concertedit.Visible = False
        ElseIf Filever_text.Text = "" Then
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Menu_concertedit.Visible = True
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
        Panel_itemsedit.Visible = False
        Panel_concertedit.Visible = False
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
        hidepanels()
        Hideselectmenu()
        Panel_itemsedit.Visible = True
    End Sub

    Private Sub Menu_text_itemsedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_itemsedit.MouseMove, Menu_text_itemsedit.MouseMove
        Menu_itemsedit.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseLeave, Menu_text_itemsedit.MouseLeave
        Menu_itemsedit.BackgroundImage = Nothing
    End Sub

    Private Sub Menu_text_concertedit_Click(sender As Object, e As EventArgs) Handles Menu_concertedit.Click, Menu_text_concertedit.Click
        hidepanels()
        Hideselectmenu()
        Panel_concertedit.Visible = True
    End Sub

    Private Sub Menu_text_concertedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_concertedit.MouseMove, Menu_text_concertedit.MouseMove
        Menu_concertedit.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_concertedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_concertedit.MouseLeave, Menu_text_concertedit.MouseLeave
        Menu_concertedit.BackgroundImage = Nothing
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
            TLSE_dialog.Text_TLSE_dialog.Text = "Warning :" & vbNewLine & "Some values can corrupt save file but this feature can be edited as you want" & vbNewLine & vbNewLine & "If your save is corrupted after has been restored, restore previous save file from ''Backup'' folder"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Avertissement :" & vbNewLine & "Certaines valeurs peuvent corrompre le fichier de sauvegarde, mais cette fonctionnalité peut être modifiée à votre guise " & vbNewLine & vbNewLine & " Si votre sauvegarde est corrompue après avoir été restaurée, restaurez le fichier de sauvegarde précédent à partir du dossier ''Backup'' "
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
            Warning_islandaddress.Visible = False
            AdvH_timetravel.Visible = True
            AdvH_resetstpspp.Visible = True
            AdvH_resetmiiapart.Visible = True
            AdvH_resetnewsflash.Visible = True
            AdvH_resetitems.Visible = True
            AdvH_resetrelationship.Visible = True
            AdvH_header.Visible = True
            AdvH_selectsongs.Visible = True
            AdvH_titlesong.Visible = True
            AdvH_typesong.Visible = True
            AdvH_plusminussong.Visible = True
            AdvH_editsonglign.Visible = True
            AdvH_savesong.Visible = True
            AdvH_setalltummy.Visible = True
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
            Warning_islandaddress.Visible = True
            AdvH_timetravel.Visible = False
            AdvH_resetstpspp.Visible = False
            AdvH_resetmiiapart.Visible = False
            AdvH_resetnewsflash.Visible = False
            AdvH_resetitems.Visible = False
            AdvH_resetrelationship.Visible = False
            AdvH_header.Visible = False
            AdvH_selectsongs.Visible = False
            AdvH_titlesong.Visible = False
            AdvH_typesong.Visible = False
            AdvH_plusminussong.Visible = False
            AdvH_editsonglign.Visible = False
            AdvH_savesong.Visible = False
            AdvH_setalltummy.Visible = False
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
            Text_description.Text = "Click to download and try 3DS Save Editors Library (Collection of save editors)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer 3DS Save Editors Library (Collection d'éditeurs de sauvegarde)"
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
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit here island's address" & vbNewLine & vbNewLine & "Some values can corrupt your save file, if he's corrupted retry with other values or restore an older save file in 'Backup' folder"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer ici l'addresse de l'île" & vbNewLine & vbNewLine & "Certaines valeurs peuvent corrompre votre sauvegarde, si c'est le cas réessayez avec d'autres valeurs ou restaurez une ancienne sauvegarde depuis le dossier 'Backup'"
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
                TextBox_fpath.Text = savedataArc
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
        Try
            Checkheader()
        Catch ex As Exception
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
            Timer_done.Interval = Timer_done.Interval + 800
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
        Checkheader()
        If Text_header.Text <> "11000000" Then
            hidepanels()
            Panel_repairsave.Visible = True
        End If
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
        End Try
        Try
            For i As Integer = 0 To 19
                Writer.Position = IslandName + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IslandName
            Writer.WriteUnicodeString(Text_islandname.Text)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Island name', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Nom de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
            Try
                For i As Integer = 0 To 39
                    Writer.Position = IslandPronun + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = IslandPronun
                Writer.WriteUnicodeString(Text_pronun_islandname.Text)
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Island name pronunciation', please report this issue"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Prononciation du nom de l'île', veuillez signaler ce problème"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
        Try
            Writer.Position = Problemsolved
            Writer.WriteUInt16(valu_problemsolved.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Problems solved', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Soucis résolus', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
            valu_problemsolved.BackColor = Color.Red
        End Try
        Try
            Writer.Position = Weddings
            Writer.WriteUInt16(valu_weddings.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Weddings', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Marriages', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Childrenborn
            Writer.WriteUInt16(valu_childrenborn.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Children born', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Nouveau né', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Travelreceived
            Writer.WriteUInt16(valu_travelersreceived.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Travelers received', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Voyageurs reçus', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = StreetPassencount
            Writer.WriteUInt16(valu_streetpassencounters.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'StreetPass encounters', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'StreetPass reçus', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Travelsent
            Writer.WriteUInt16(valu_travelerssent.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Travelers sent', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Voyageurs envoyés', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Eventfountain
            Writer.WriteUInt32(valu_eventfountain.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Event fountain', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Évènement fontaine', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Lastsavedate
            Writer.WriteUInt32(valu_lastdatesave.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Last date save', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Dernière date sauvegarde', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Islandaddres_1
            Writer.WriteUInt32(valu_islandaddress_p1.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Islandaddres_2
            Writer.WriteUInt32(valu_islandaddress_p2.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Islandaddres_3
            Writer.WriteUInt32(valu_islandaddress_p3.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writer.Position = Islandaddres_4
            Writer.WriteUInt32(valu_islandaddress_p4.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Island's address', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Adresse de l'île', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Writer.Close()
        Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        Try
            ws.Position = appart
            ws.WriteByte(valu_appart.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building Mii apartments', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment appartements Mii', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = mair
            ws.WriteByte(valu_mair.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building town hall', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment mairie', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = info
            ws.WriteByte(valu_info.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building Mii news', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment infos Mii', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = classem
            ws.WriteByte(valu_classem.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building rankings board', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment classements', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = vetem
            ws.WriteByte(valu_vetem.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building clothing', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment vêtements', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = chap
            ws.WriteByte(valu_chap.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building hats', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment chapeaux', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = epicer
            ws.WriteByte(valu_epicer.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building food mart', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment épicerie', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = deco
            ws.WriteByte(valu_deco.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building interiors', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment déco d'intérieur', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = broc
            ws.WriteByte(valu_broc.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building pawn shop', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment brocante', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = magimport
            ws.WriteByte(valu_magimport.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building import wear', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment magasin d'import', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = fontai
            ws.WriteByte(valu_font.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building fountain', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment fontaine', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = mais
            ws.WriteByte(valu_mais.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building Mii homes', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment maisons Mii', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = port
            ws.WriteByte(valu_port.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building port', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment port', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = tervague
            ws.WriteByte(valu_tervague.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building campground', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment terrain vague', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = conc
            ws.WriteByte(valu_conc.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building concert hall', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment salle de concert', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = test
            ws.WriteByte(valu_test.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building compatibility tester', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment testeur de compatibilité', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = stud
            ws.WriteByte(valu_stud.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building photo studio', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment studio photo', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = plage
            ws.WriteByte(valu_plage.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building beach', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment plage', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = parc1
            ws.WriteByte(valu_parc1.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building park', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment parc', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = cafe
            ws.WriteByte(valu_cafe.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building café', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment café', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = parc
            ws.WriteByte(valu_parc.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building amusement park', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment parc d'attractions', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = tour
            ws.WriteByte(valu_tour.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building observation tower', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment tour d'observation', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = part
            ws.WriteByte(valu_part.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Building 3DS image share', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Bâtiment partage d'images 3DS', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Appartrenov
            ws.WriteByte(valu_appartrenov.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Apartments renovation', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Rénovation appartements', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankvitality
            ws.WriteByte(valu_rank_vitality.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking vitality', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements forme générale', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankpopularity
            ws.WriteByte(valu_rank_popularity.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking popularity', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements popularité', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankboycharm
            ws.WriteByte(valu_rank_boycharm.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking boy charm', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements garçons populaires', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankgirlcharm
            ws.WriteByte(valu_rank_girlcharm.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking girl charm', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements filles populaires', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankpampered
            ws.WriteByte(valu_rank_pampered.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking pampered', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements Mii préférés', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankfriendship
            ws.WriteByte(valu_rank_friendship.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking friendship', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements amitié', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankromance
            ws.WriteByte(valu_rank_romance.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking romance', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements relations amoureuses', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Rankisland
            ws.WriteByte(valu_rank_island.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking island', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements qualité de vie', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Ranktravelers
            ws.WriteByte(valu_rank_traveler.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking travelers', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements Mii voyageurs', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            ws.Position = Ranksplurge
            ws.WriteByte(valu_rank_splurge.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Ranking splurge', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Classements Mii dépensiers', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Removetimetravel()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Remove time travel penality', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Retirer la pénalité de voyage dans le temps', veuillez signaler ce problème"
            End If
        End Try
        Try
            Resetstreetspotpass()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Reset Tomodachi Life Streetpass / Spotpass', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Réinitialiser StreetPass / Spotpass de Tomodachi Life', veuillez signaler ce problème"
            End If
        End Try
        Try
            resetmiiapart()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Reset Mii apartments', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Réinitialiser les appartements des Mii', veuillez signaler ce problème"
            End If
        End Try
        Try
            Resetnewsflash()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Reset news flash', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Réinitialiser les infos Mii', veuillez signaler ce problème"
            End If
        End Try
        Try
            Resetallitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Reset all items', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Réinitialiser tout les objets', veuillez signaler ce problème"
            End If
        End Try
        Try
            Resetallrela()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Reset Mii relationship', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Réinitialiser les relations des Mii', veuillez signaler ce problème"
            End If
        End Try
        Try
            settummyfullempt()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Set Mii's tummy to', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Mettre l'estomac des Mii', veuillez signaler ce problème"
            End If
        End Try
        Try
            writefoodsitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit foods', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets nourritures', veuillez signaler ce problème"
            End If
        End Try
        done()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_done.Text = "File saved !"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_done.Text = "Fichier sauvegardé !"
        End If
    End Sub
    'end save savedataArc

    'animation manual block
    Public Sub hidemanualpanels()
        Panel_extractsave.Visible = False
        Panel_restoresave.Visible = False
        Panel_extractsave_1.Visible = False
        Panel_restoresave_1.Visible = False
        Panel_citratomo.Visible = False
    End Sub

    Public Sub hidemanualmenu()
        Text_extractsave.BorderStyle = BorderStyle.None
        Text_restoresave.BorderStyle = BorderStyle.None
        Text_extractsave_1.BorderStyle = BorderStyle.None
        Text_restoresave_1.BorderStyle = BorderStyle.None
        Text_citratomo.BorderStyle = BorderStyle.None
        Text_extractsave.BackColor = Color.Transparent
        Text_restoresave.BackColor = Color.Transparent
        Text_extractsave_1.BackColor = Color.Transparent
        Text_restoresave_1.BackColor = Color.Transparent
        Text_citratomo.BackColor = Color.Transparent
    End Sub

    Private Sub Panel_extractsave_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_extractsave.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_extractsave_1_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_1.MouseMove
        Info_image.Image = My.Resources.JKSM_launch
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_1_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_1.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_2_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_2.MouseMove
        Info_image.Image = My.Resources.JKSM_titles
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_2_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_2.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_3_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_3.MouseMove
        Info_image.Image = My.Resources.JKSM_tomodachi
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_3_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_3.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_4_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_4.MouseMove
        Info_image.Image = My.Resources.JKSM_savedata
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_4_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_4.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_5_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_5.MouseMove
        Info_image.Image = My.Resources.JKSM_newfolder
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_5_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_5.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_6_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_6.MouseMove
        Info_image.Image = My.Resources.JKSM_backup
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_6_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_6.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Text_HtuTLSEold_Click(sender As Object, e As EventArgs) Handles Text_HtuTLSEold.Click
        Process.Start("https://www.youtube.com/watch?v=EIpuxMg9SVE")
    End Sub

    Private Sub Panel_restoresave_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_restoresave.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_restoresave_1_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_1.MouseMove
        Info_image.Image = My.Resources.JKSM_launch
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_1_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_1.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_2_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_2.MouseMove
        Info_image.Image = My.Resources.JKSM_titles
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_2_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_2.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_3_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_3.MouseMove
        Info_image.Image = My.Resources.JKSM_tomodachi
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_3_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_3.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_4_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_4.MouseMove
        Info_image.Image = My.Resources.JKSM_savedata
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_4_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_4.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_5_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_5.MouseMove
        Info_image.Image = My.Resources.JKSM_backup
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_5_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_5.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Text_citratomo_Click(sender As Object, e As EventArgs) Handles Text_citratomo.Click
        hidemanualpanels()
        Panel_citratomo.Visible = True
        hidemanualmenu()
        Text_citratomo.BorderStyle = BorderStyle.FixedSingle
        Text_citratomo.BackColor = Color.Orange
    End Sub

    Private Sub Text_extractsave_Click(sender As Object, e As EventArgs) Handles Text_extractsave.Click
        hidemanualpanels()
        Panel_extractsave.Visible = True
        hidemanualmenu()
        Text_extractsave.BorderStyle = BorderStyle.FixedSingle
        Text_extractsave.BackColor = Color.Orange
    End Sub

    Private Sub Text_restoresave_Click(sender As Object, e As EventArgs) Handles Text_restoresave.Click
        hidemanualpanels()
        Panel_restoresave.Visible = True
        hidemanualmenu()
        Text_restoresave.BorderStyle = BorderStyle.FixedSingle
        Text_restoresave.BackColor = Color.Orange
    End Sub

    Private Sub Text_extractsave_1_Click(sender As Object, e As EventArgs) Handles Text_extractsave_1.Click
        hidemanualpanels()
        Panel_extractsave_1.Visible = True
        hidemanualmenu()
        Text_extractsave_1.BorderStyle = BorderStyle.FixedSingle
        Text_extractsave_1.BackColor = Color.Orange
    End Sub

    Private Sub Text_restoresave_1_Click(sender As Object, e As EventArgs) Handles Text_restoresave_1.Click
        hidemanualpanels()
        Panel_restoresave_1.Visible = True
        hidemanualmenu()
        Text_restoresave_1.BorderStyle = BorderStyle.FixedSingle
        Text_restoresave_1.BackColor = Color.Orange
    End Sub

    Private Sub Panel_extractsave_1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_extractsave_1.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_extractsave_1_1_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_1_1.MouseMove
        Info_image.Image = My.Resources.CKPT_launch
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_1_1_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_1_1.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_1_2_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_1_2.MouseMove
        Info_image.Image = My.Resources.CKPT_selecttomodachi
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_1_2_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_1_2.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_1_3_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_1_3.MouseMove
        Info_image.Image = My.Resources.CKPT_confirmgame
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_1_3_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_1_3.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_1_4_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_1_4.MouseMove
        Info_image.Image = My.Resources.CKPT_backup
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_1_4_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_1_4.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_1_5_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_1_5.MouseMove
        Info_image.Image = My.Resources.CKPT_bakfolder
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_1_5_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_1_5.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Panel_restoresave_1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_restoresave_1.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_restoresave_1_1_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_1_1.MouseMove
        Info_image.Image = My.Resources.CKPT_launch
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_1_1_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_1_1.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_1_2_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_1_2.MouseMove
        Info_image.Image = My.Resources.CKPT_selecttomodachi
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_1_2_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_1_2.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_1_3_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_1_3.MouseMove
        Info_image.Image = My.Resources.CKPT_confirmgame
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_1_3_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_1_3.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_1_4_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_1_4.MouseMove
        Info_image.Image = My.Resources.CKPT_restore
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_1_4_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_1_4.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Panel_citratomo_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_citratomo.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_citratomo_2_MouseMove(sender As Object, e As EventArgs) Handles Info_citratomo_2.MouseMove
        Info_image.Image = My.Resources.Cit_opensaveloc
        Info_image.Visible = True
    End Sub

    Private Sub Info_citratomo_2_MouseLeave(sender As Object, e As EventArgs) Handles Info_citratomo_2.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Text_citratomo_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_citratomo.MouseMove
        Text_citratomo.BackColor = Color.Orange
    End Sub

    Private Sub Text_citratomo_MouseLeave(sender As Object, e As EventArgs) Handles Text_citratomo.MouseLeave
        If Panel_citratomo.Visible = True Then
            Text_citratomo.BackColor = Color.Orange
        Else
            Text_citratomo.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Text_extractsave_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_extractsave.MouseMove
        Text_extractsave.BackColor = Color.Orange
    End Sub

    Private Sub Text_extractsave_MouseLeave(sender As Object, e As EventArgs) Handles Text_extractsave.MouseLeave
        If Panel_extractsave.Visible = True Then
            Text_extractsave.BackColor = Color.Orange
        Else
            Text_extractsave.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Text_restoresave_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_restoresave.MouseMove
        Text_restoresave.BackColor = Color.Orange
    End Sub

    Private Sub Text_restoresave_MouseLeave(sender As Object, e As EventArgs) Handles Text_restoresave.MouseLeave
        If Panel_restoresave.Visible = True Then
            Text_restoresave.BackColor = Color.Orange
        Else
            Text_restoresave.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Text_extractsave_1_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_extractsave_1.MouseMove
        Text_extractsave_1.BackColor = Color.Orange
    End Sub

    Private Sub Text_extractsave_1_MouseLeave(sender As Object, e As EventArgs) Handles Text_extractsave_1.MouseLeave
        If Panel_extractsave_1.Visible = True Then
            Text_extractsave_1.BackColor = Color.Orange
        Else
            Text_extractsave_1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Text_restoresave_1_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_restoresave_1.MouseMove
        Text_restoresave_1.BackColor = Color.Orange
    End Sub

    Private Sub Text_restoresave_1_MouseLeave(sender As Object, e As EventArgs) Handles Text_restoresave_1.MouseLeave
        If Panel_restoresave_1.Visible = True Then
            Text_restoresave_1.BackColor = Color.Orange
        Else
            Text_restoresave_1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Text_htuTLSEold_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_HtuTLSEold.MouseMove
        Text_HtuTLSEold.BackColor = Color.Orange
    End Sub

    Private Sub Text_htuTLSEold_MouseLeave(sender As Object, e As EventArgs) Handles Text_HtuTLSEold.MouseLeave
        Text_HtuTLSEold.BackColor = Color.Transparent
    End Sub
    'end animation manual block

    'extras animation block
    Private Sub Check_timetravel_SizeChanged(sender As Object, e As EventArgs) Handles Check_timetravel.SizeChanged
        AdvH_timetravel.Location = New Point(Check_timetravel.Location.X + Check_timetravel.Width + 5, Check_timetravel.Location.Y + (Check_timetravel.Height / 2) - 10)
    End Sub

    Private Sub Check_resetstpspp_SizeChanged(sender As Object, e As EventArgs) Handles Check_resetstpspp.SizeChanged
        AdvH_resetstpspp.Location = New Point(Check_resetstpspp.Location.X + Check_resetstpspp.Width + 5, Check_resetstpspp.Location.Y + (Check_resetstpspp.Height / 2) - 10)
    End Sub

    Private Sub Check_resetmiiapart_SizeChanged(sender As Object, e As EventArgs) Handles Check_resetmiiapart.SizeChanged
        AdvH_resetmiiapart.Location = New Point(Check_resetmiiapart.Location.X + Check_resetmiiapart.Width + 5, Check_resetmiiapart.Location.Y + (Check_resetmiiapart.Height / 2) - 10)
    End Sub

    Private Sub Check_resetnewsflash_SizeChanged(sender As Object, e As EventArgs) Handles Check_resetnewsflash.SizeChanged
        AdvH_resetnewsflash.Location = New Point(Check_resetnewsflash.Location.X + Check_resetnewsflash.Width + 5, Check_resetnewsflash.Location.Y + (Check_resetnewsflash.Height / 2) - 10)
    End Sub

    Private Sub Check_resetitems_SizeChanged(sender As Object, e As EventArgs) Handles Check_resetitems.SizeChanged
        AdvH_resetitems.Location = New Point(Check_resetitems.Location.X + Check_resetitems.Width + 5, Check_resetitems.Location.Y + (Check_resetitems.Height / 2) - 10)
    End Sub

    Private Sub Check_resetrelationship_SizeChanged(sender As Object, e As EventArgs) Handles Check_resetrelationship.SizeChanged
        AdvH_resetrelationship.Location = New Point(Check_resetrelationship.Location.X + Check_resetrelationship.Width + 5, Check_resetrelationship.Location.Y + (Check_resetrelationship.Height / 2) - 10)
    End Sub

    Private Sub AdvH_timetravel_Click(sender As Object, e As EventArgs) Handles AdvH_timetravel.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Check_timetravel.Location.X + (Check_timetravel.Width / 2), Check_timetravel.Location.Y + (Check_timetravel.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can set as orange to remove time travel penality" & vbNewLine & vbNewLine & "- You need to save in Tomodachi Life with time travel penality" & vbNewLine & "- Load your save file in Tomodachi Life Save Editor" & vbNewLine & "- Set as orange Remove time travel penality" & vbNewLine & "- Click on save on top, and restore your save file"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez mettre en orange pour retirer la pénalité de voyage dans le temps" & vbNewLine & vbNewLine & "- Vous devez sauvegarder dans Tomodachi Life avec la pénalité de voyage dans le temps" & vbNewLine & "- Ouvrez votre sauvegarde dans Tomodachi Life Save Editor" & vbNewLine & "- Mettre en orange Retirer la pénalité de voyage dans le temps" & vbNewLine & "- Cliquez sur Enregistrer en haut, et restaurez votre fichier de sauvegarde"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 6
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_resetstpspp_Click(sender As Object, e As EventArgs) Handles AdvH_resetstpspp.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Check_resetstpspp.Location.X + (Check_resetstpspp.Width / 2), Check_resetstpspp.Location.Y + (Check_resetstpspp.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can set as orange to reset Tomodachi Life " & vbNewLine & vbNewLine & "Tomodachi Life will ask you to activate StreetPass and SpotPass again"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez mettre en orange pour réinitialiser StreetPass / SpotPass de Tomodachi Life" & vbNewLine & vbNewLine & "Tomodachi Life vous demandera de nouveau d'activer StreetPass et SpotPass"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 6
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_resetmiiapart_Click(sender As Object, e As EventArgs) Handles AdvH_resetmiiapart.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Check_resetmiiapart.Location.X + (Check_resetmiiapart.Width / 2), Check_resetmiiapart.Location.Y + (Check_resetmiiapart.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can set as orange to reset Mii apartments" & vbNewLine & vbNewLine & "All Mii apartments will be set by default (Mii 1 will have apartment 101, Mii 2 will have apartment 102, ...)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez mettre en orange pour réinitialiser les appartements des Mii" & vbNewLine & vbNewLine & "Tous les appartements des Mii vont être mis par défaut (Mii 1 va avoir l'appartement 101, Mii 2 va avoir l'appartement 102, ...)"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 2
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_resetnewsflash_Click(sender As Object, e As EventArgs) Handles AdvH_resetnewsflash.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Check_resetnewsflash.Location.X + (Check_resetnewsflash.Width / 2), Check_resetnewsflash.Location.Y + (Check_resetnewsflash.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can set as orange to reset News flash" & vbNewLine & vbNewLine & "You will see another time news flash about features unlocked"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez mettre en orange pour réinitialiser les Infos Mii" & vbNewLine & vbNewLine & "Vous pourrez revoir les infos mii des fonctionnalités débloqués"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 2
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_resetitems_Click(sender As Object, e As EventArgs) Handles AdvH_resetitems.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Check_resetitems.Location.X + (Check_resetitems.Width / 2), Check_resetitems.Location.Y + (Check_resetitems.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can set as orange to reset items" & vbNewLine & vbNewLine & "All items in your inventory will be deleted"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez mettre en orange pour réinitialiser les objets" & vbNewLine & vbNewLine & "Tout les objets dans votre inventaire vont être supprimés"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 2
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_resetrelationship_Click(sender As Object, e As EventArgs) Handles AdvH_resetrelationship.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Check_resetrelationship.Location.X + (Check_resetrelationship.Width / 2), Check_resetrelationship.Location.Y + (Check_resetrelationship.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can set as orange to reset Mii relationship" & vbNewLine & vbNewLine & "All Mii relationship will be set as 'unknow'"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez mettre en orange pour réinitialiser les relations des Mii" & vbNewLine & vbNewLine & "Toutes les relations des Mii vont être mis en tant que 'inconnu'"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 2
        TLSE_dialog.ShowDialog()
    End Sub

    Public Sub Removetimetravel()
        Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
            If Check_timetravel.Checked = True Then
                ws.Position = &H1E4C70
                ws.WriteByte(0)
            End If
        ElseIf Filever_text.Text = "JP" Then
            If Check_timetravel.Checked = True Then
                ws.Position = &H14BD40
                ws.WriteByte(0)
            End If
        ElseIf Filever_text.Text = "KR" Then
            If Check_timetravel.Checked = True Then
                ws.Position = &H1F0020
                ws.WriteByte(0)
            End If
        End If
    End Sub

    Public Sub Resetstreetspotpass()
        Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
            If Check_resetstpspp.Checked = True Then
                ws.Position = &H1E4C71
                ws.WriteByte(0)
            End If
        ElseIf Filever_text.Text = "JP" Then
            If Check_resetstpspp.Checked = True Then
                ws.Position = &H14BD41
                ws.WriteByte(0)
            End If
        ElseIf Filever_text.Text = "KR" Then
            If Check_resetstpspp.Checked = True Then
                ws.Position = &H1F0021
                ws.WriteByte(0)
            End If
        End If
    End Sub

    Public Sub resetmiiapart()
        Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        If Check_resetmiiapart.Checked = True Then
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                fs.Position = &H22A8
                fs.WriteByte(0)
                fs.Position = &H22A8 + &H660
                fs.WriteByte(1)
                fs.Position = &H22A8 + (&H660 * 2)
                fs.WriteByte(2)
                fs.Position = &H22A8 + (&H660 * 3)
                fs.WriteByte(3)
                fs.Position = &H22A8 + (&H660 * 4)
                fs.WriteByte(4)
                fs.Position = &H22A8 + (&H660 * 5)
                fs.WriteByte(5)
                fs.Position = &H22A8 + (&H660 * 6)
                fs.WriteByte(6)
                fs.Position = &H22A8 + (&H660 * 7)
                fs.WriteByte(7)
                fs.Position = &H22A8 + (&H660 * 8)
                fs.WriteByte(8)
                fs.Position = &H22A8 + (&H660 * 9)
                fs.WriteByte(9)
                fs.Position = &H22A8 + (&H660 * 10)
                fs.WriteByte(10)
                fs.Position = &H22A8 + (&H660 * 11)
                fs.WriteByte(11)
                fs.Position = &H22A8 + (&H660 * 12)
                fs.WriteByte(12)
                fs.Position = &H22A8 + (&H660 * 13)
                fs.WriteByte(13)
                fs.Position = &H22A8 + (&H660 * 14)
                fs.WriteByte(14)
                fs.Position = &H22A8 + (&H660 * 15)
                fs.WriteByte(15)
                fs.Position = &H22A8 + (&H660 * 16)
                fs.WriteByte(16)
                fs.Position = &H22A8 + (&H660 * 17)
                fs.WriteByte(17)
                fs.Position = &H22A8 + (&H660 * 18)
                fs.WriteByte(18)
                fs.Position = &H22A8 + (&H660 * 19)
                fs.WriteByte(19)
                fs.Position = &H22A8 + (&H660 * 20)
                fs.WriteByte(20)
                fs.Position = &H22A8 + (&H660 * 21)
                fs.WriteByte(21)
                fs.Position = &H22A8 + (&H660 * 22)
                fs.WriteByte(22)
                fs.Position = &H22A8 + (&H660 * 23)
                fs.WriteByte(23)
                fs.Position = &H22A8 + (&H660 * 24)
                fs.WriteByte(24)
                fs.Position = &H22A8 + (&H660 * 25)
                fs.WriteByte(25)
                fs.Position = &H22A8 + (&H660 * 26)
                fs.WriteByte(26)
                fs.Position = &H22A8 + (&H660 * 27)
                fs.WriteByte(27)
                fs.Position = &H22A8 + (&H660 * 28)
                fs.WriteByte(28)
                fs.Position = &H22A8 + (&H660 * 29)
                fs.WriteByte(29)
                fs.Position = &H22A8 + (&H660 * 30)
                fs.WriteByte(30)
                fs.Position = &H22A8 + (&H660 * 31)
                fs.WriteByte(31)
                fs.Position = &H22A8 + (&H660 * 32)
                fs.WriteByte(32)
                fs.Position = &H22A8 + (&H660 * 33)
                fs.WriteByte(33)
                fs.Position = &H22A8 + (&H660 * 34)
                fs.WriteByte(34)
                fs.Position = &H22A8 + (&H660 * 35)
                fs.WriteByte(35)
                fs.Position = &H22A8 + (&H660 * 36)
                fs.WriteByte(36)
                fs.Position = &H22A8 + (&H660 * 37)
                fs.WriteByte(37)
                fs.Position = &H22A8 + (&H660 * 38)
                fs.WriteByte(38)
                fs.Position = &H22A8 + (&H660 * 39)
                fs.WriteByte(39)
                fs.Position = &H22A8 + (&H660 * 40)
                fs.WriteByte(40)
                fs.Position = &H22A8 + (&H660 * 41)
                fs.WriteByte(41)
                fs.Position = &H22A8 + (&H660 * 42)
                fs.WriteByte(42)
                fs.Position = &H22A8 + (&H660 * 43)
                fs.WriteByte(43)
                fs.Position = &H22A8 + (&H660 * 44)
                fs.WriteByte(44)
                fs.Position = &H22A8 + (&H660 * 45)
                fs.WriteByte(45)
                fs.Position = &H22A8 + (&H660 * 46)
                fs.WriteByte(46)
                fs.Position = &H22A8 + (&H660 * 47)
                fs.WriteByte(47)
                fs.Position = &H22A8 + (&H660 * 48)
                fs.WriteByte(48)
                fs.Position = &H22A8 + (&H660 * 49)
                fs.WriteByte(49)
                fs.Position = &H22A8 + (&H660 * 50)
                fs.WriteByte(50)
                fs.Position = &H22A8 + (&H660 * 51)
                fs.WriteByte(51)
                fs.Position = &H22A8 + (&H660 * 52)
                fs.WriteByte(52)
                fs.Position = &H22A8 + (&H660 * 53)
                fs.WriteByte(53)
                fs.Position = &H22A8 + (&H660 * 54)
                fs.WriteByte(54)
                fs.Position = &H22A8 + (&H660 * 55)
                fs.WriteByte(55)
                fs.Position = &H22A8 + (&H660 * 56)
                fs.WriteByte(56)
                fs.Position = &H22A8 + (&H660 * 57)
                fs.WriteByte(57)
                fs.Position = &H22A8 + (&H660 * 58)
                fs.WriteByte(58)
                fs.Position = &H22A8 + (&H660 * 59)
                fs.WriteByte(59)
                fs.Position = &H22A8 + (&H660 * 60)
                fs.WriteByte(60)
                fs.Position = &H22A8 + (&H660 * 61)
                fs.WriteByte(61)
                fs.Position = &H22A8 + (&H660 * 62)
                fs.WriteByte(62)
                fs.Position = &H22A8 + (&H660 * 63)
                fs.WriteByte(63)
                fs.Position = &H22A8 + (&H660 * 64)
                fs.WriteByte(64)
                fs.Position = &H22A8 + (&H660 * 65)
                fs.WriteByte(65)
                fs.Position = &H22A8 + (&H660 * 66)
                fs.WriteByte(66)
                fs.Position = &H22A8 + (&H660 * 67)
                fs.WriteByte(67)
                fs.Position = &H22A8 + (&H660 * 68)
                fs.WriteByte(68)
                fs.Position = &H22A8 + (&H660 * 69)
                fs.WriteByte(69)
                fs.Position = &H22A8 + (&H660 * 70)
                fs.WriteByte(70)
                fs.Position = &H22A8 + (&H660 * 71)
                fs.WriteByte(71)
                fs.Position = &H22A8 + (&H660 * 72)
                fs.WriteByte(72)
                fs.Position = &H22A8 + (&H660 * 73)
                fs.WriteByte(73)
                fs.Position = &H22A8 + (&H660 * 74)
                fs.WriteByte(74)
                fs.Position = &H22A8 + (&H660 * 75)
                fs.WriteByte(75)
                fs.Position = &H22A8 + (&H660 * 76)
                fs.WriteByte(76)
                fs.Position = &H22A8 + (&H660 * 77)
                fs.WriteByte(77)
                fs.Position = &H22A8 + (&H660 * 78)
                fs.WriteByte(78)
                fs.Position = &H22A8 + (&H660 * 79)
                fs.WriteByte(79)
                fs.Position = &H22A8 + (&H660 * 80)
                fs.WriteByte(80)
                fs.Position = &H22A8 + (&H660 * 81)
                fs.WriteByte(81)
                fs.Position = &H22A8 + (&H660 * 82)
                fs.WriteByte(82)
                fs.Position = &H22A8 + (&H660 * 83)
                fs.WriteByte(83)
                fs.Position = &H22A8 + (&H660 * 84)
                fs.WriteByte(84)
                fs.Position = &H22A8 + (&H660 * 85)
                fs.WriteByte(85)
                fs.Position = &H22A8 + (&H660 * 86)
                fs.WriteByte(86)
                fs.Position = &H22A8 + (&H660 * 87)
                fs.WriteByte(87)
                fs.Position = &H22A8 + (&H660 * 88)
                fs.WriteByte(88)
                fs.Position = &H22A8 + (&H660 * 89)
                fs.WriteByte(89)
                fs.Position = &H22A8 + (&H660 * 90)
                fs.WriteByte(90)
                fs.Position = &H22A8 + (&H660 * 91)
                fs.WriteByte(91)
                fs.Position = &H22A8 + (&H660 * 92)
                fs.WriteByte(92)
                fs.Position = &H22A8 + (&H660 * 93)
                fs.WriteByte(93)
                fs.Position = &H22A8 + (&H660 * 94)
                fs.WriteByte(94)
                fs.Position = &H22A8 + (&H660 * 95)
                fs.WriteByte(95)
                fs.Position = &H22A8 + (&H660 * 96)
                fs.WriteByte(96)
                fs.Position = &H22A8 + (&H660 * 97)
                fs.WriteByte(97)
                fs.Position = &H22A8 + (&H660 * 98)
                fs.WriteByte(98)
                fs.Position = &H22A8 + (&H660 * 99)
                fs.WriteByte(99)
                fs.Close()
            ElseIf Filever_text.Text = "JP" Then
                fs.Position = &H21A8
                fs.WriteByte(0)
                fs.Position = &H21A8 + &H590
                fs.WriteByte(1)
                fs.Position = &H21A8 + (&H590 * 2)
                fs.WriteByte(2)
                fs.Position = &H21A8 + (&H590 * 3)
                fs.WriteByte(3)
                fs.Position = &H21A8 + (&H590 * 4)
                fs.WriteByte(4)
                fs.Position = &H21A8 + (&H590 * 5)
                fs.WriteByte(5)
                fs.Position = &H21A8 + (&H590 * 6)
                fs.WriteByte(6)
                fs.Position = &H21A8 + (&H590 * 7)
                fs.WriteByte(7)
                fs.Position = &H21A8 + (&H590 * 8)
                fs.WriteByte(8)
                fs.Position = &H21A8 + (&H590 * 9)
                fs.WriteByte(9)
                fs.Position = &H21A8 + (&H590 * 10)
                fs.WriteByte(10)
                fs.Position = &H21A8 + (&H590 * 11)
                fs.WriteByte(11)
                fs.Position = &H21A8 + (&H590 * 12)
                fs.WriteByte(12)
                fs.Position = &H21A8 + (&H590 * 13)
                fs.WriteByte(13)
                fs.Position = &H21A8 + (&H590 * 14)
                fs.WriteByte(14)
                fs.Position = &H21A8 + (&H590 * 15)
                fs.WriteByte(15)
                fs.Position = &H21A8 + (&H590 * 16)
                fs.WriteByte(16)
                fs.Position = &H21A8 + (&H590 * 17)
                fs.WriteByte(17)
                fs.Position = &H21A8 + (&H590 * 18)
                fs.WriteByte(18)
                fs.Position = &H21A8 + (&H590 * 19)
                fs.WriteByte(19)
                fs.Position = &H21A8 + (&H590 * 20)
                fs.WriteByte(20)
                fs.Position = &H21A8 + (&H590 * 21)
                fs.WriteByte(21)
                fs.Position = &H21A8 + (&H590 * 22)
                fs.WriteByte(22)
                fs.Position = &H21A8 + (&H590 * 23)
                fs.WriteByte(23)
                fs.Position = &H21A8 + (&H590 * 24)
                fs.WriteByte(24)
                fs.Position = &H21A8 + (&H590 * 25)
                fs.WriteByte(25)
                fs.Position = &H21A8 + (&H590 * 26)
                fs.WriteByte(26)
                fs.Position = &H21A8 + (&H590 * 27)
                fs.WriteByte(27)
                fs.Position = &H21A8 + (&H590 * 28)
                fs.WriteByte(28)
                fs.Position = &H21A8 + (&H590 * 29)
                fs.WriteByte(29)
                fs.Position = &H21A8 + (&H590 * 30)
                fs.WriteByte(30)
                fs.Position = &H21A8 + (&H590 * 31)
                fs.WriteByte(31)
                fs.Position = &H21A8 + (&H590 * 32)
                fs.WriteByte(32)
                fs.Position = &H21A8 + (&H590 * 33)
                fs.WriteByte(33)
                fs.Position = &H21A8 + (&H590 * 34)
                fs.WriteByte(34)
                fs.Position = &H21A8 + (&H590 * 35)
                fs.WriteByte(35)
                fs.Position = &H21A8 + (&H590 * 36)
                fs.WriteByte(36)
                fs.Position = &H21A8 + (&H590 * 37)
                fs.WriteByte(37)
                fs.Position = &H21A8 + (&H590 * 38)
                fs.WriteByte(38)
                fs.Position = &H21A8 + (&H590 * 39)
                fs.WriteByte(39)
                fs.Position = &H21A8 + (&H590 * 40)
                fs.WriteByte(40)
                fs.Position = &H21A8 + (&H590 * 41)
                fs.WriteByte(41)
                fs.Position = &H21A8 + (&H590 * 42)
                fs.WriteByte(42)
                fs.Position = &H21A8 + (&H590 * 43)
                fs.WriteByte(43)
                fs.Position = &H21A8 + (&H590 * 44)
                fs.WriteByte(44)
                fs.Position = &H21A8 + (&H590 * 45)
                fs.WriteByte(45)
                fs.Position = &H21A8 + (&H590 * 46)
                fs.WriteByte(46)
                fs.Position = &H21A8 + (&H590 * 47)
                fs.WriteByte(47)
                fs.Position = &H21A8 + (&H590 * 48)
                fs.WriteByte(48)
                fs.Position = &H21A8 + (&H590 * 49)
                fs.WriteByte(49)
                fs.Position = &H21A8 + (&H590 * 50)
                fs.WriteByte(50)
                fs.Position = &H21A8 + (&H590 * 51)
                fs.WriteByte(51)
                fs.Position = &H21A8 + (&H590 * 52)
                fs.WriteByte(52)
                fs.Position = &H21A8 + (&H590 * 53)
                fs.WriteByte(53)
                fs.Position = &H21A8 + (&H590 * 54)
                fs.WriteByte(54)
                fs.Position = &H21A8 + (&H590 * 55)
                fs.WriteByte(55)
                fs.Position = &H21A8 + (&H590 * 56)
                fs.WriteByte(56)
                fs.Position = &H21A8 + (&H590 * 57)
                fs.WriteByte(57)
                fs.Position = &H21A8 + (&H590 * 58)
                fs.WriteByte(58)
                fs.Position = &H21A8 + (&H590 * 59)
                fs.WriteByte(59)
                fs.Position = &H21A8 + (&H590 * 60)
                fs.WriteByte(60)
                fs.Position = &H21A8 + (&H590 * 61)
                fs.WriteByte(61)
                fs.Position = &H21A8 + (&H590 * 62)
                fs.WriteByte(62)
                fs.Position = &H21A8 + (&H590 * 63)
                fs.WriteByte(63)
                fs.Position = &H21A8 + (&H590 * 64)
                fs.WriteByte(64)
                fs.Position = &H21A8 + (&H590 * 65)
                fs.WriteByte(65)
                fs.Position = &H21A8 + (&H590 * 66)
                fs.WriteByte(66)
                fs.Position = &H21A8 + (&H590 * 67)
                fs.WriteByte(67)
                fs.Position = &H21A8 + (&H590 * 68)
                fs.WriteByte(68)
                fs.Position = &H21A8 + (&H590 * 69)
                fs.WriteByte(69)
                fs.Position = &H21A8 + (&H590 * 70)
                fs.WriteByte(70)
                fs.Position = &H21A8 + (&H590 * 71)
                fs.WriteByte(71)
                fs.Position = &H21A8 + (&H590 * 72)
                fs.WriteByte(72)
                fs.Position = &H21A8 + (&H590 * 73)
                fs.WriteByte(73)
                fs.Position = &H21A8 + (&H590 * 74)
                fs.WriteByte(74)
                fs.Position = &H21A8 + (&H590 * 75)
                fs.WriteByte(75)
                fs.Position = &H21A8 + (&H590 * 76)
                fs.WriteByte(76)
                fs.Position = &H21A8 + (&H590 * 77)
                fs.WriteByte(77)
                fs.Position = &H21A8 + (&H590 * 78)
                fs.WriteByte(78)
                fs.Position = &H21A8 + (&H590 * 79)
                fs.WriteByte(79)
                fs.Position = &H21A8 + (&H590 * 80)
                fs.WriteByte(80)
                fs.Position = &H21A8 + (&H590 * 81)
                fs.WriteByte(81)
                fs.Position = &H21A8 + (&H590 * 82)
                fs.WriteByte(82)
                fs.Position = &H21A8 + (&H590 * 83)
                fs.WriteByte(83)
                fs.Position = &H21A8 + (&H590 * 84)
                fs.WriteByte(84)
                fs.Position = &H21A8 + (&H590 * 85)
                fs.WriteByte(85)
                fs.Position = &H21A8 + (&H590 * 86)
                fs.WriteByte(86)
                fs.Position = &H21A8 + (&H590 * 87)
                fs.WriteByte(87)
                fs.Position = &H21A8 + (&H590 * 88)
                fs.WriteByte(88)
                fs.Position = &H21A8 + (&H590 * 89)
                fs.WriteByte(89)
                fs.Position = &H21A8 + (&H590 * 90)
                fs.WriteByte(90)
                fs.Position = &H21A8 + (&H590 * 91)
                fs.WriteByte(91)
                fs.Position = &H21A8 + (&H590 * 92)
                fs.WriteByte(92)
                fs.Position = &H21A8 + (&H590 * 93)
                fs.WriteByte(93)
                fs.Position = &H21A8 + (&H590 * 94)
                fs.WriteByte(94)
                fs.Position = &H21A8 + (&H590 * 95)
                fs.WriteByte(95)
                fs.Position = &H21A8 + (&H590 * 96)
                fs.WriteByte(96)
                fs.Position = &H21A8 + (&H590 * 97)
                fs.WriteByte(97)
                fs.Position = &H21A8 + (&H590 * 98)
                fs.WriteByte(98)
                fs.Position = &H21A8 + (&H590 * 99)
                fs.WriteByte(99)
                fs.Close()
            End If
        End If
    End Sub

    Public Sub Resetnewsflash()
        Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
        If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
            If Check_resetnewsflash.Checked = True Then
                For i As Integer = 0 To 4
                    Writer.Position = &H1E4C48 + i
                    Writer.WriteInt8(0)
                Next
            End If
        ElseIf Filever_text.Text = "JP" Then
            If Check_resetnewsflash.Checked = True Then
                For i As Integer = 0 To 4
                    Writer.Position = &H14BD18 + i
                    Writer.WriteInt8(0)
                Next
            End If
        ElseIf Filever_text.Text = "KR" Then
            If Check_resetnewsflash.Checked = True Then
                For i As Integer = 0 To 4
                    Writer.Position = &H1EFFF8 + i
                    Writer.WriteInt8(0)
                Next
            End If
        End If
    End Sub

    Public Sub Resetallitems()
        If Check_resetitems.Checked = True Then
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            For i As Integer = 0 To &H1A47
                fs.Position = &H30 + i
                fs.WriteByte(253)
            Next
        End If
    End Sub

    Public Sub Resetallrela()
        If Check_resetrelationship.Checked = True Then
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                accessrelationship = &H299F0
            ElseIf Filever_text.Text = "JP" Then
                accessrelationship = &H24880
            End If
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + &H100
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + &H100
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 2)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 2)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 3)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 3)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 4)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 4)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 5)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 5)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 6)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 6)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 7)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 7)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 8)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 8)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 9)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 9)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 10)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 10)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 11)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 11)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 12)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 12)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 13)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 13)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 14)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 14)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 15)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 15)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 16)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 16)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 17)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 17)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 18)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 18)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 19)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 19)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 20)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 20)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 21)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 21)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 22)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 22)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 23)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 23)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 24)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 24)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 25)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 25)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 26)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 26)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 27)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 27)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 28)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 28)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 29)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 29)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 30)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 30)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 31)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 31)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 32)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 32)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 33)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 33)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 34)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 34)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 35)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 35)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 36)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 36)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 37)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 37)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 38)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 38)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 39)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 39)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 40)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 40)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 41)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 41)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 42)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 42)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 43)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 43)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 44)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 44)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 45)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 45)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 46)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 46)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 47)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 47)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 48)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 48)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 49)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 49)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 50)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 50)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 51)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 51)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 52)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 52)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 53)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 53)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 54)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 54)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 55)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 55)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 56)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 56)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 57)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 57)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 58)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 58)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 59)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 59)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 60)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 60)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 61)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 61)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 62)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 62)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 63)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 63)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 64)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 64)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 65)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 65)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 66)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 66)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 67)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 67)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 68)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 68)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 69)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 69)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 70)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 70)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 71)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 71)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 72)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 72)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 73)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 73)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 74)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 74)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 75)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 75)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 76)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 76)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 77)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 77)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 78)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 78)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 79)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 79)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 80)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 80)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 81)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 81)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 82)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 82)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 83)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 83)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 84)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 84)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 85)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 85)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 86)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 86)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 87)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 87)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 88)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 88)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 89)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 89)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 90)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 90)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 91)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 91)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 92)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 92)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 93)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 93)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 94)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 94)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 95)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 95)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 96)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 96)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 97)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 97)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 98)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 98)
                fs.WriteByte(0)
            Next
            For i As Integer = 0 To &H63
                fs.Position = accessrelationship + i + (&H100 * 99)
                fs.WriteByte(100)
            Next
            For i As Integer = 0 To &H63
                fs.Position = (accessrelationship + &H64) + i + (&H100 * 99)
                fs.WriteByte(0)
            Next
        End If
    End Sub

    Private Sub Check_timetravel_MouseLeave(sender As Object, e As EventArgs) Handles Check_timetravel.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_timetravel_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_timetravel.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to remove time travel penality"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour retirer la pénalité de voyage dans le temps"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetstpspp_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetstpspp.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetstpspp_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetstpspp.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset Tomodachi Life Streetpass/Spotpass"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser Streetpass/Spotpass de Tomodachi Life"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetmiiapart_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetmiiapart.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetmiiapart_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetmiiapart.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset Mii apartments"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser les appartements des Mii"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetnewsflash_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetnewsflash.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetnewsflasht_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetnewsflash.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset News flash"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser les infos Mii"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetitems_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetitems.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetitems_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetitems.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset all items"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser tout les objets"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetrelationship_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetrelationship.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetrelationship_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetrelationship.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset Mii's relationship"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser les relations des Mii"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub valu_setalltummy_ValueChanged(sender As Object, e As EventArgs) Handles valu_setalltummy.ValueChanged
        If valu_setalltummy.Value = 0 Then
            Icon_setalltummy.Image = My.Resources.icon_checktummy_empty
        ElseIf valu_setalltummy.Value = 1 Then
            Icon_setalltummy.Image = My.Resources.icon_checktummy_full
        End If
    End Sub

    Private Sub Icon_setalltummy_Click(sender As Object, e As EventArgs) Handles Icon_setalltummy.Click
        If valu_setalltummy.Value = 0 Then
            valu_setalltummy.Value = 1
        ElseIf valu_setalltummy.Value = 1 Then
            valu_setalltummy.Value = 0
        End If
    End Sub

    Private Sub AdvH_setalltummy_Click(sender As Object, e As EventArgs) Handles AdvH_setalltummy.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Check_setalltummy.Location.X + (Check_setalltummy.Width / 2), Check_setalltummy.Location.Y + (Check_setalltummy.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can set as orange to set Mii's tummy to empty or full"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez mettre en orange pour mettre l'estomac des Mii vide ou rempli"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 2
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_setalltummy.Location.X + (Icon_setalltummy.Width / 2), Icon_setalltummy.Location.Y + (Icon_setalltummy.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Click here to set as empty or full"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Cliquez ici pour mettre vide ou rempli"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 2
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub Icon_setalltummy_MouseMove(sender As Object, e As EventArgs) Handles Icon_setalltummy.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to set as empty or full"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour mettre vide ou plein"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_setalltummy_MouseLeave(sender As Object, e As EventArgs) Handles Icon_setalltummy.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_setalltummy_MouseMove(sender As Object, e As EventArgs) Handles Check_setalltummy.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to set all Mii's tummy to empty or full"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour mettre l'estomac des Mii vide ou plein"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_setalltummy_MouseLeave(sender As Object, e As EventArgs) Handles Check_setalltummy.MouseLeave
        Panel_description.Visible = False
    End Sub

    Public Sub settummyfullempt()
        Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        If Check_setalltummy.Checked = True Then
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                ws.Position = &H2293
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + &H660
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 2)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 3)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 4)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 5)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 6)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 7)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 8)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 9)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 10)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 11)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 12)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 13)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 14)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 15)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 16)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 17)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 18)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 19)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 20)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 21)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 22)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 23)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 24)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 25)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 26)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 27)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 28)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 29)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 30)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 31)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 32)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 33)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 34)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 35)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 36)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 37)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 38)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 39)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 40)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 41)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 42)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 43)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 44)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 45)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 46)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 47)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 48)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 49)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 50)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 51)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 52)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 53)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 54)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 55)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 56)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 57)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 58)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 59)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 60)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 61)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 62)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 63)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 64)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 65)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 66)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 67)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 68)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 69)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 70)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 71)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 72)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 73)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 74)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 75)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 76)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 77)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 78)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 79)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 80)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 81)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 82)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 83)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 84)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 85)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 86)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 87)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 88)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 89)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 90)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 91)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 92)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 93)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 94)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 95)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 96)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 97)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 98)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2293 + (&H660 * 99)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Close()
            ElseIf Filever_text.Text = "JP" Then
                ws.Position = &H2193
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + &H590
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 2)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 3)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 4)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 5)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 6)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 7)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 8)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 9)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 10)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 11)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 12)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 13)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 14)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 15)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 16)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 17)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 18)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 19)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 20)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 21)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 22)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 23)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 24)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 25)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 26)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 27)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 28)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 29)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 30)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 31)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 32)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 33)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 34)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 35)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 36)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 37)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 38)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 39)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 40)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 41)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 42)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 43)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 44)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 45)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 46)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 47)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 48)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 49)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 50)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 51)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 52)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 53)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 54)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 55)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 56)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 57)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 58)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 59)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 60)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 61)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 62)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 63)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 64)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 65)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 66)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 67)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 68)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 69)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 70)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 71)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 72)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 73)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 74)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 75)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 76)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 77)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 78)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 79)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 80)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 81)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 82)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 83)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 84)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 85)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 86)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 87)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 88)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 89)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 90)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 91)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 92)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 93)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 94)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 95)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 96)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 97)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 98)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Position = &H2193 + (&H590 * 99)
                If valu_setalltummy.Value = 0 Then
                    ws.WriteByte(0)
                ElseIf valu_setalltummy.Value = 1 Then
                    ws.WriteByte(64)
                End If
                ws.Close()
            End If
        End If
    End Sub
    'end extras animation block

    'repair save file block
    Public Sub Checkheader()
        Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
        Reader.Position = &H0
        Text_header.Text = Reader.ReadHexString(4)
    End Sub

    Private Sub Text_header_TextChanged(sender As Object, e As EventArgs) Handles Text_header.TextChanged
        If Text_header.Text = "11000000" Then
            Text_header.BackColor = DefaultBackColor
            Icon_header.visible = False
        Else
            Text_header.BackColor = Color.Red
            Icon_header.visible = True
        End If
    End Sub

    Private Sub Icon_header_Click(sender As Object, e As EventArgs) Handles Icon_header.Click
        Text_header.Text = "11000000"
        Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
        Try
            Writer.Position = &H0
            Writer.WriteHexString(Text_header.Text)
            done()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Header', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'écriture de cette fonctionnalité a échoué : 'Header', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub AdvH_header_Click(sender As Object, e As EventArgs) Handles AdvH_header.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Text_header.Location.X + (Text_header.Width / 2), Text_header.Location.Y + (Text_header.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "This is your header" & vbNewLine & vbNewLine & "If back color is red, you need to fix him before restore your save file"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Ceci est votre header" & vbNewLine & vbNewLine & "Si le fond est rouge, vous aurez besoin de le corriger avant de restaurer votre sauvegarde"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 3
        TLSE_dialog.ShowDialog()
    End Sub
    'end repair save file block

    'concert edit block
    Private Sub Select_songs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_songs.SelectedIndexChanged
        If Select_songs.SelectedItem = Select_songs.Items.Item(0) Then
            Accesspagh = &H0
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(1) Then
            Accesspagh = &H5C4
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(2) Then
            Accesspagh = &H5C4 * 2
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(3) Then
            Accesspagh = &H5C4 * 3
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(4) Then
            Accesspagh = &H5C4 * 4
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(5) Then
            Accesspagh = &H5C4 * 5
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(6) Then
            Accesspagh = &H5C4 * 6
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(7) Then
            Accesspagh = &H5C4 * 7
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(8) Then
            Accesspagh = &H5C4 * 8
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(9) Then
            Accesspagh = &H5C4 * 9
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(10) Then
            Accesspagh = &H5C4 * 10
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(11) Then
            Accesspagh = &H5C4 * 11
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(12) Then
            Accesspagh = &H5C4 * 12
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(13) Then
            Accesspagh = &H5C4 * 13
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(14) Then
            Accesspagh = &H5C4 * 14
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(15) Then
            Accesspagh = &H5C4 * 15
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(16) Then
            Accesspagh = &H5C4 * 16
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(17) Then
            Accesspagh = &H5C4 * 17
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(18) Then
            Accesspagh = &H5C4 * 18
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(19) Then
            Accesspagh = &H5C4 * 19
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(20) Then
            Accesspagh = &H5C4 * 20
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(21) Then
            Accesspagh = &H5C4 * 21
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(22) Then
            Accesspagh = &H5C4 * 22
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(23) Then
            Accesspagh = &H5C4 * 23
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(24) Then
            Accesspagh = &H5C4 * 24
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(25) Then
            Accesspagh = &H5C4 * 25
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(26) Then
            Accesspagh = &H5C4 * 26
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(27) Then
            Accesspagh = &H5C4 * 27
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(28) Then
            Accesspagh = &H5C4 * 28
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(29) Then
            Accesspagh = &H5C4 * 29
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(30) Then
            Accesspagh = &H5C4 * 30
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(31) Then
            Accesspagh = &H5C4 * 31
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(32) Then
            Accesspagh = &H5C4 * 32
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(33) Then
            Accesspagh = &H5C4 * 33
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(34) Then
            Accesspagh = &H5C4 * 34
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(35) Then
            Accesspagh = &H5C4 * 35
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(36) Then
            Accesspagh = &H5C4 * 36
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(37) Then
            Accesspagh = &H5C4 * 37
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(38) Then
            Accesspagh = &H5C4 * 38
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(39) Then
            Accesspagh = &H5C4 * 39
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(40) Then
            Accesspagh = &H5C4 * 40
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(41) Then
            Accesspagh = &H5C4 * 41
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(42) Then
            Accesspagh = &H5C4 * 42
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(43) Then
            Accesspagh = &H5C4 * 43
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(44) Then
            Accesspagh = &H5C4 * 44
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(45) Then
            Accesspagh = &H5C4 * 45
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(46) Then
            Accesspagh = &H5C4 * 46
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(47) Then
            Accesspagh = &H5C4 * 47
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(48) Then
            Accesspagh = &H5C4 * 48
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(49) Then
            Accesspagh = &H5C4 * 49
        End If
        readmusic()
    End Sub

    Public Sub readmusic()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H17B6E4 + Accesspagh
            ValPagh1 = Reader.Position
            valu_pagh_1.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh
            Pagh1 = Reader.Position
            Text_pagh_1.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + &H68
            ValPagh2 = Reader.Position
            valu_pagh_2.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + &H68
            Pagh2 = Reader.Position
            Text_pagh_2.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 2)
            ValPagh3 = Reader.Position
            valu_pagh_3.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 2)
            Pagh3 = Reader.Position
            Text_pagh_3.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 3)
            ValPagh4 = Reader.Position
            valu_pagh_4.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 3)
            Pagh4 = Reader.Position
            Text_pagh_4.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 4)
            ValPagh5 = Reader.Position
            valu_pagh_5.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 4)
            Pagh5 = Reader.Position
            Text_pagh_5.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 5)
            ValPagh6 = Reader.Position
            valu_pagh_6.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 5)
            Pagh6 = Reader.Position
            Text_pagh_6.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 6)
            ValPagh7 = Reader.Position
            valu_pagh_7.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 6)
            Pagh7 = Reader.Position
            Text_pagh_7.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 7)
            ValPagh8 = Reader.Position
            valu_pagh_8.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 7)
            Pagh8 = Reader.Position
            Text_pagh_8.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 8)
            ValPagh9 = Reader.Position
            valu_pagh_9.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 8)
            Pagh9 = Reader.Position
            Text_pagh_9.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 9)
            ValPagh10 = Reader.Position
            valu_pagh_10.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 9)
            Pagh10 = Reader.Position
            Text_pagh_10.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 10)
            ValPagh11 = Reader.Position
            valu_pagh_11.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 10)
            Pagh11 = Reader.Position
            Text_pagh_11.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 11)
            ValPagh12 = Reader.Position
            valu_pagh_12.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 11)
            Pagh12 = Reader.Position
            Text_pagh_12.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 12)
            ValPagh13 = Reader.Position
            valu_pagh_13.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 12)
            Pagh13 = Reader.Position
            Text_pagh_13.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17BC2C + Accesspagh
            Tmusc = Reader.Position
            Text_titlesong.Text = Reader.ReadUnicodeString(32)
            Reader.Position = &H17BC71 + Accesspagh
            Typesong = Reader.Position
            valu_typesong.Value = Reader.ReadByte
        Catch ex As Exception
            If Text_menu_save.Visible = True Then
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this music, please report this issue"
                    TLSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette musique a échoué, veuilleez signaler cet erreur"
                    TLSE_dialog.ShowDialog()
                End If
            Else
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Open a save file first and retry"
                    TLSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Ouvrez une sauvegarde avant et réessayez"
                    TLSE_dialog.ShowDialog()
                End If
            End If

        End Try
    End Sub

    Private Sub valu_pagh_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_1.ValueChanged
        If valu_pagh_1.Value = 14 Then
            Text_pagh_1.Enabled = True
        Else
            Text_pagh_1.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_2.ValueChanged
        If valu_pagh_2.Value = 14 Then
            Text_pagh_2.Enabled = True
        Else
            Text_pagh_2.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_3.ValueChanged
        If valu_pagh_3.Value = 14 Then
            Text_pagh_3.Enabled = True
        Else
            Text_pagh_3.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_4.ValueChanged
        If valu_pagh_4.Value = 14 Then
            Text_pagh_4.Enabled = True
        Else
            Text_pagh_4.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_5.ValueChanged
        If valu_pagh_5.Value = 14 Then
            Text_pagh_5.Enabled = True
        Else
            Text_pagh_5.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_6.ValueChanged
        If valu_pagh_6.Value = 14 Then
            Text_pagh_6.Enabled = True
        Else
            Text_pagh_6.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_7.ValueChanged
        If valu_pagh_7.Value = 14 Then
            Text_pagh_7.Enabled = True
        Else
            Text_pagh_7.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_8.ValueChanged
        If valu_pagh_8.Value = 14 Then
            Text_pagh_8.Enabled = True
        Else
            Text_pagh_8.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_9.ValueChanged
        If valu_pagh_9.Value = 14 Then
            Text_pagh_9.Enabled = True
        Else
            Text_pagh_9.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_10.ValueChanged
        If valu_pagh_10.Value = 14 Then
            Text_pagh_10.Enabled = True
        Else
            Text_pagh_10.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_11.ValueChanged
        If valu_pagh_11.Value = 14 Then
            Text_pagh_11.Enabled = True
        Else
            Text_pagh_11.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_12.ValueChanged
        If valu_pagh_12.Value = 14 Then
            Text_pagh_12.Enabled = True
        Else
            Text_pagh_12.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_13.ValueChanged
        If valu_pagh_13.Value = 14 Then
            Text_pagh_13.Enabled = True
        Else
            Text_pagh_13.Enabled = False
        End If
    End Sub

    Private Sub Text_save_editsongs_Click(sender As Object, e As EventArgs) Handles Text_save_editsongs.Click
        Try
            'package.IO
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            If valu_pagh_1.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh1 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh1
                Writer.WriteUnicodeString(Text_pagh_1.Text)
            End If
            If valu_pagh_2.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh2 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh2
                Writer.WriteUnicodeString(Text_pagh_2.Text)
            End If
            If valu_pagh_3.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh3 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh3
                Writer.WriteUnicodeString(Text_pagh_3.Text)
            End If
            If valu_pagh_4.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh4 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh4
                Writer.WriteUnicodeString(Text_pagh_4.Text)
            End If
            If valu_pagh_5.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh5 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh5
                Writer.WriteUnicodeString(Text_pagh_5.Text)
            End If
            If valu_pagh_6.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh6 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh6
                Writer.WriteUnicodeString(Text_pagh_6.Text)
            End If
            If valu_pagh_7.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh7 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh7
                Writer.WriteUnicodeString(Text_pagh_7.Text)
            End If
            If valu_pagh_8.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh8 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh8
                Writer.WriteUnicodeString(Text_pagh_8.Text)
            End If
            If valu_pagh_9.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh9 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh9
                Writer.WriteUnicodeString(Text_pagh_9.Text)
            End If
            If valu_pagh_10.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh10 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh10
                Writer.WriteUnicodeString(Text_pagh_10.Text)
            End If
            If valu_pagh_11.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh11 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh11
                Writer.WriteUnicodeString(Text_pagh_11.Text)
            End If
            If valu_pagh_12.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh12 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh12
                Writer.WriteUnicodeString(Text_pagh_12.Text)
            End If
            If valu_pagh_13.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh13 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh13
                Writer.WriteUnicodeString(Text_pagh_13.Text)
            End If
            For i As Integer = 0 To 63
                Writer.Position = Tmusc + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Tmusc
            Writer.WriteUnicodeString(Text_titlesong.Text)
            'end package.IO
            'filestream save songs
            Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            ws.Position = ValPagh1
            ws.WriteByte(valu_pagh_1.Value)
            ws.Position = ValPagh2
            ws.WriteByte(valu_pagh_2.Value)
            ws.Position = ValPagh3
            ws.WriteByte(valu_pagh_3.Value)
            ws.Position = ValPagh4
            ws.WriteByte(valu_pagh_4.Value)
            ws.Position = ValPagh5
            ws.WriteByte(valu_pagh_5.Value)
            ws.Position = ValPagh6
            ws.WriteByte(valu_pagh_6.Value)
            ws.Position = ValPagh7
            ws.WriteByte(valu_pagh_7.Value)
            ws.Position = ValPagh8
            ws.WriteByte(valu_pagh_8.Value)
            ws.Position = ValPagh9
            ws.WriteByte(valu_pagh_9.Value)
            ws.Position = ValPagh10
            ws.WriteByte(valu_pagh_10.Value)
            ws.Position = ValPagh11
            ws.WriteByte(valu_pagh_11.Value)
            ws.Position = ValPagh12
            ws.WriteByte(valu_pagh_12.Value)
            ws.Position = ValPagh13
            ws.WriteByte(valu_pagh_13.Value)
            ws.Position = Typesong
            ws.WriteByte(valu_typesong.Value)
            'end filestream save songs
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Editing of this song has been saved"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Les modifications de cette musique ont été enregistrées"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            If Text_menu_save.Visible = True Then
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to edit this song, please report this issue"
                    TLSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "L'édition de cette musique a échoué, veuillez signalez cet erreur"
                    TLSE_dialog.ShowDialog()
                End If
            Else
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Open a save file first and retry"
                    TLSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Ouvrez une sauvegarde avant et réessayez"
                    TLSE_dialog.ShowDialog()
                End If
            End If
        End Try
    End Sub

    Private Sub valu_typesong_ValueChanged(sender As Object, e As EventArgs) Handles valu_typesong.ValueChanged
        If valu_typesong.Value = 0 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_metal
        ElseIf valu_typesong.Value = 1 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_pop
        ElseIf valu_typesong.Value = 2 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_rockroll
        ElseIf valu_typesong.Value = 3 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_rap
        ElseIf valu_typesong.Value = 4 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_ballad
        ElseIf valu_typesong.Value = 5 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_opera
        ElseIf valu_typesong.Value = 6 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_techno
        ElseIf valu_typesong.Value = 7 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_musical
        End If
    End Sub

    Private Sub Icon_crthall_music_Click(sender As Object, e As EventArgs) Handles Icon_crthall_music.Click
        If valu_typesong.Value >= 7 Then
            valu_typesong.Value = 0
        Else
            valu_typesong.Value = valu_typesong.Value + 1
        End If
        Locklignpagh()
        If valu_typesong.Value = 0 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
        ElseIf valu_typesong.Value = 1 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
        ElseIf valu_typesong.Value = 2 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
        ElseIf valu_typesong.Value = 3 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
            valu_pagh_12.Value = 14
            valu_pagh_13.Value = 14
        ElseIf valu_typesong.Value = 4 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
            valu_pagh_12.Value = 14
            valu_pagh_13.Value = 14
        ElseIf valu_typesong.Value = 5 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
        ElseIf valu_typesong.Value = 6 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
        ElseIf valu_typesong.Value = 7 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
        End If
    End Sub

    Private Sub Icon_crthall_music_MouseMove(sender As Object, e As EventArgs) Handles Icon_crthall_music.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to change song's type"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour changer le type de la chansons"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_crthall_music_MouseLeave(sender As Object, e As EventArgs) Handles Icon_crthall_music.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Plus_pagh_1_Click(sender As Object, e As EventArgs) Handles Plus_pagh_1.Click
        valu_pagh_1.Value = 14
    End Sub

    Private Sub Minus_pagh_1_Click(sender As Object, e As EventArgs) Handles Minus_pagh_1.Click
        Text_pagh_1.Text = ""
        valu_pagh_1.Value = 0
    End Sub

    Private Sub Plus_pagh_2_Click(sender As Object, e As EventArgs) Handles Plus_pagh_2.Click
        valu_pagh_2.Value = 14
    End Sub

    Private Sub Minus_pagh_2_Click(sender As Object, e As EventArgs) Handles Minus_pagh_2.Click
        Text_pagh_2.Text = ""
        valu_pagh_2.Value = 0
    End Sub

    Private Sub Plus_pagh_3_Click(sender As Object, e As EventArgs) Handles Plus_pagh_3.Click
        valu_pagh_3.Value = 14
    End Sub

    Private Sub Minus_pagh_3_Click(sender As Object, e As EventArgs) Handles Minus_pagh_3.Click
        Text_pagh_3.Text = ""
        valu_pagh_3.Value = 0
    End Sub

    Private Sub Plus_pagh_4_Click(sender As Object, e As EventArgs) Handles Plus_pagh_4.Click
        valu_pagh_4.Value = 14
    End Sub

    Private Sub Minus_pagh_4_Click(sender As Object, e As EventArgs) Handles Minus_pagh_4.Click
        Text_pagh_4.Text = ""
        valu_pagh_4.Value = 0
    End Sub

    Private Sub Plus_pagh_5_Click(sender As Object, e As EventArgs) Handles Plus_pagh_5.Click
        valu_pagh_5.Value = 14
    End Sub

    Private Sub Minus_pagh_5_Click(sender As Object, e As EventArgs) Handles Minus_pagh_5.Click
        Text_pagh_5.Text = ""
        valu_pagh_5.Value = 0
    End Sub

    Private Sub Plus_pagh_6_Click(sender As Object, e As EventArgs) Handles Plus_pagh_6.Click
        valu_pagh_6.Value = 14
    End Sub

    Private Sub Minus_pagh_6_Click(sender As Object, e As EventArgs) Handles Minus_pagh_6.Click
        Text_pagh_6.Text = ""
        valu_pagh_6.Value = 0
    End Sub

    Private Sub Plus_pagh_7_Click(sender As Object, e As EventArgs) Handles Plus_pagh_7.Click
        valu_pagh_7.Value = 14
    End Sub

    Private Sub Minus_pagh_7_Click(sender As Object, e As EventArgs) Handles Minus_pagh_7.Click
        Text_pagh_7.Text = ""
        valu_pagh_7.Value = 0
    End Sub

    Private Sub Plus_pagh_8_Click(sender As Object, e As EventArgs) Handles Plus_pagh_8.Click
        valu_pagh_8.Value = 14
    End Sub

    Private Sub Minus_pagh_8_Click(sender As Object, e As EventArgs) Handles Minus_pagh_8.Click
        Text_pagh_8.Text = ""
        valu_pagh_8.Value = 0
    End Sub

    Private Sub Plus_pagh_9_Click(sender As Object, e As EventArgs) Handles Plus_pagh_9.Click
        valu_pagh_9.Value = 14
    End Sub

    Private Sub Minus_pagh_9_Click(sender As Object, e As EventArgs) Handles Minus_pagh_9.Click
        Text_pagh_9.Text = ""
        valu_pagh_9.Value = 0
    End Sub

    Private Sub Plus_pagh_10_Click(sender As Object, e As EventArgs) Handles Plus_pagh_10.Click
        valu_pagh_10.Value = 14
    End Sub

    Private Sub Minus_pagh_10_Click(sender As Object, e As EventArgs) Handles Minus_pagh_10.Click
        Text_pagh_10.Text = ""
        valu_pagh_10.Value = 0
    End Sub

    Private Sub Plus_pagh_11_Click(sender As Object, e As EventArgs) Handles Plus_pagh_11.Click
        valu_pagh_11.Value = 14
    End Sub

    Private Sub Minus_pagh_11_Click(sender As Object, e As EventArgs) Handles Minus_pagh_11.Click
        Text_pagh_11.Text = ""
        valu_pagh_11.Value = 0
    End Sub

    Private Sub Plus_pagh_12_Click(sender As Object, e As EventArgs) Handles Plus_pagh_12.Click
        valu_pagh_12.Value = 14
    End Sub

    Private Sub Minus_pagh_12_Click(sender As Object, e As EventArgs) Handles Minus_pagh_12.Click
        Text_pagh_12.Text = ""
        valu_pagh_12.Value = 0
    End Sub

    Private Sub Plus_pagh_13_Click(sender As Object, e As EventArgs) Handles Plus_pagh_13.Click
        valu_pagh_13.Value = 14
    End Sub

    Private Sub Minus_pagh_13_Click(sender As Object, e As EventArgs) Handles Minus_pagh_13.Click
        Text_pagh_13.Text = ""
        valu_pagh_13.Value = 0
    End Sub

    Public Sub Locklignpagh()
        valu_pagh_1.Value = 0
        valu_pagh_2.Value = 0
        valu_pagh_3.Value = 0
        valu_pagh_4.Value = 0
        valu_pagh_5.Value = 0
        valu_pagh_6.Value = 0
        valu_pagh_7.Value = 0
        valu_pagh_8.Value = 0
        valu_pagh_9.Value = 0
        valu_pagh_10.Value = 0
        valu_pagh_11.Value = 0
        valu_pagh_12.Value = 0
        valu_pagh_13.Value = 0
    End Sub
    'end concert edit block

    ' advance help concert edit
    Private Sub AdvH_selectsongs_Click(sender As Object, e As EventArgs) Handles AdvH_selectsongs.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Select_songs.Location.X + (Select_songs.Width / 2), Select_songs.Location.Y + (Select_songs.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can select a song you want to edit"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "vous pouvez sélectionner une chanson que vous voulez éditer"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_titlesong_Click(sender As Object, e As EventArgs) Handles AdvH_titlesong.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Text_titlesong.Location.X + (Text_titlesong.Width / 2), Text_titlesong.Location.Y + (Text_titlesong.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "This is your song's title"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Ceci est le title de votre chanson"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 5
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_typesong_Click(sender As Object, e As EventArgs) Handles AdvH_typesong.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Icon_crthall_music.Location.X + (Icon_crthall_music.Width / 2), Icon_crthall_music.Location.Y + (Icon_crthall_music.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click here to changes your song's type"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer ici pour changer le type de votre chanson"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 3
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_plusminussong_Click(sender As Object, e As EventArgs) Handles AdvH_plusminussong.Click
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_right
        TLSE_dialog.Icon_reference_panel.Location = New Point(Plus_pagh_7.Location.X - (TLSE_dialog.Icon_reference_panel.Width - 6), Plus_pagh_7.Location.Y + (Plus_pagh_7.Height / 2))
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can click on 'More' symbols to add a line to your song"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez cliquer sur les symboles 'plus' pour ajouter une ligne à votre chanson"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
        TLSE_dialog.Icon_reference_panel.Location = New Point(Minus_pagh_7.Location.X + (Minus_pagh_7.Width / 2), Minus_pagh_7.Location.Y + (Minus_pagh_7.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "And on 'Less' symbols to delete a line on your song"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Et sur les symboles 'Moins' pour supprimer une ligne à votre chanson"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 4
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_editsonglign_Click(sender As Object, e As EventArgs) Handles AdvH_editsonglign.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Panel_editsongslign.Location.X + (Panel_editsongslign.Width / 2), Panel_editsongslign.Location.Y + (Panel_editsongslign.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "You can edit your songs here, you can add or delete line to do weird songs"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Vous pouvez éditer vos chansons ici, vous pouvez ajouter ou supprimer des lignes pour faire des chansons bizarre"
        End If
        TLSE_dialog.valu_pandialogpos.Value = 1
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub AdvH_savesong_Click(sender As Object, e As EventArgs) Handles AdvH_savesong.Click
        TLSE_dialog.Icon_reference_panel.Location = New Point(Button_save.Location.X + (Button_save.Width / 2), Button_save.Location.Y + (Button_save.Height / 2))
        TLSE_dialog.Icon_reference_panel.Image = My.Resources.TLSE_arrow_left
        TLSE_dialog.Icon_reference_panel.Visible = True
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Click here to save changes in your songs" & vbNewLine & vbNewLine & "If you have an error : make sure your save file is not in a specific location (like Onedrive folder)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Cliquez ici pour enregistrer les changements dans vos chansons" & vbNewLine & vbNewLine & "Si vous avez une erreur : soyez sûr que votre fichier de sauvegarde ne se trouve pas dans un endroit spécifique (comme le dossier Onedrive)"
        End If
        TLSE_dialog.ShowDialog()
    End Sub
    ' end advance help concert edit

    ' items edit animation block
    Private Sub valu_itemsediticon_foods_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_foods.ValueChanged
        If valu_itemsediticon_foods.Value = 0 Then
            Icon_itemsedit_foods.Image = My.Resources.Icon_unfoods
            Check_delete_foods.Enabled = True
        ElseIf valu_itemsediticon_foods.Value = 1 Then
            Icon_itemsedit_foods.Image = My.Resources.Icon_unfoods_act
            Check_delete_foods.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_clothes_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_clothes.ValueChanged
        If valu_itemsediticon_clothes.Value = 0 Then
            Icon_itemsedit_clothes.Image = My.Resources.Icon_unclothes
            Check_delete_clothes.Enabled = True
        ElseIf valu_itemsediticon_clothes.Value = 1 Then
            Icon_itemsedit_clothes.Image = My.Resources.Icon_unclothes_act
            Check_delete_clothes.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_ssclothes_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_ssclothes.ValueChanged
        If valu_itemsediticon_ssclothes.Value = 0 Then
            Icon_itemsedit_ssclothes.Image = My.Resources.Icon_unclothesstsp
            Check_delete_ssclothes.Enabled = True
        ElseIf valu_itemsediticon_ssclothes.Value = 1 Then
            Icon_itemsedit_ssclothes.Image = My.Resources.Icon_unclothesstsp_act
            Check_delete_ssclothes.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_hats_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_hats.ValueChanged
        If valu_itemsediticon_hats.Value = 0 Then
            Icon_itemsedit_hats.Image = My.Resources.Icon_unhats
            Check_delete_hats.Enabled = True
        ElseIf valu_itemsediticon_hats.Value = 1 Then
            Icon_itemsedit_hats.Image = My.Resources.Icon_unhats_act
            Check_delete_hats.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_sshats_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_sshats.ValueChanged
        If valu_itemsediticon_sshats.Value = 0 Then
            Icon_itemsedit_sshats.Image = My.Resources.Icon_unhatsstsp
            Check_delete_sshats.Enabled = True
        ElseIf valu_itemsediticon_sshats.Value = 1 Then
            Icon_itemsedit_sshats.Image = My.Resources.Icon_unhatsstsp_act
            Check_delete_sshats.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_interiors_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_interiors.ValueChanged
        If valu_itemsediticon_interiors.Value = 0 Then
            Icon_itemsedit_interiors.Image = My.Resources.Icon_uninteriors
            Check_delete_interiors.Enabled = True
        ElseIf valu_itemsediticon_interiors.Value = 1 Then
            Icon_itemsedit_interiors.Image = My.Resources.Icon_uninteriors_act
            Check_delete_interiors.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_goodsitems_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_goodsitems.ValueChanged
        If valu_itemsediticon_goodsitems.Value = 0 Then
            Icon_itemsedit_goodsitems.Image = My.Resources.Icon_ungoods
            Check_delete_goodsitems.Enabled = True
        ElseIf valu_itemsediticon_goodsitems.Value = 1 Then
            Icon_itemsedit_goodsitems.Image = My.Resources.Icon_ungoods_act
            Check_delete_goodsitems.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_treasures_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_treasures.ValueChanged
        If valu_itemsediticon_treasures.Value = 0 Then
            Icon_itemsedit_treasures.Image = My.Resources.Icon_untreasures
            Check_delete_treasures.Enabled = True
        ElseIf valu_itemsediticon_treasures.Value = 1 Then
            Icon_itemsedit_treasures.Image = My.Resources.Icon_untreasures_act
            Check_delete_treasures.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_spefoods_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_spefoods.ValueChanged
        If valu_itemsediticon_spefoods.Value = 0 Then
            Icon_itemsedit_spefoods.Image = My.Resources.Icon_unfoodsspe
            Check_delete_spefoods.Enabled = True
        ElseIf valu_itemsediticon_spefoods.Value = 1 Then
            Icon_itemsedit_spefoods.Image = My.Resources.Icon_unfoodsspe_act
            Check_delete_spefoods.Enabled = False
        End If
    End Sub

    Private Sub Icon_itemsedit_foods_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_foods.Click
        If valu_itemsediticon_foods.Value = 0 Then
            valu_itemsediticon_foods.Value = 1
        ElseIf valu_itemsediticon_foods.Value = 1 Then
            valu_itemsediticon_foods.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_clothes_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_clothes.Click
        If valu_itemsediticon_clothes.Value = 0 Then
            valu_itemsediticon_clothes.Value = 1
        ElseIf valu_itemsediticon_clothes.Value = 1 Then
            valu_itemsediticon_clothes.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_ssclothes_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_ssclothes.Click
        If valu_itemsediticon_ssclothes.Value = 0 Then
            valu_itemsediticon_ssclothes.Value = 1
        ElseIf valu_itemsediticon_ssclothes.Value = 1 Then
            valu_itemsediticon_ssclothes.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_hats_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_hats.Click
        If valu_itemsediticon_hats.Value = 0 Then
            valu_itemsediticon_hats.Value = 1
        ElseIf valu_itemsediticon_hats.Value = 1 Then
            valu_itemsediticon_hats.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_sshats_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_sshats.Click
        If valu_itemsediticon_sshats.Value = 0 Then
            valu_itemsediticon_sshats.Value = 1
        ElseIf valu_itemsediticon_sshats.Value = 1 Then
            valu_itemsediticon_sshats.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_interiors_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_interiors.Click
        If valu_itemsediticon_interiors.Value = 0 Then
            valu_itemsediticon_interiors.Value = 1
        ElseIf valu_itemsediticon_interiors.Value = 1 Then
            valu_itemsediticon_interiors.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_goodsitems_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_goodsitems.Click
        If valu_itemsediticon_goodsitems.Value = 0 Then
            valu_itemsediticon_goodsitems.Value = 1
        ElseIf valu_itemsediticon_goodsitems.Value = 1 Then
            valu_itemsediticon_goodsitems.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_treasures_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_treasures.Click
        If valu_itemsediticon_treasures.Value = 0 Then
            valu_itemsediticon_treasures.Value = 1
        ElseIf valu_itemsediticon_treasures.Value = 1 Then
            valu_itemsediticon_treasures.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_spefoods_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_spefoods.Click
        If valu_itemsediticon_spefoods.Value = 0 Then
            valu_itemsediticon_spefoods.Value = 1
        ElseIf valu_itemsediticon_spefoods.Value = 1 Then
            valu_itemsediticon_spefoods.Value = 0
        End If
    End Sub

    Private Sub Check_delete_foods_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_foods.CheckedChanged
        If Check_delete_foods.Checked = True Then
            Icon_itemsedit_foods.Enabled = False
            valu_itemsedit_foods.Enabled = False
            valu_itemsedit_foods.Maximum = 255
            valu_itemsedit_foods.Value = 253
        Else
            Icon_itemsedit_foods.Enabled = True
            valu_itemsedit_foods.Enabled = True
            valu_itemsedit_foods.Maximum = 99
            valu_itemsedit_foods.Value = 99
        End If
    End Sub

    Private Sub Check_delete_clothes_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_clothes.CheckedChanged
        If Check_delete_clothes.Checked = True Then
            Icon_itemsedit_clothes.Enabled = False
            valu_itemsedit_clothes.Enabled = False
            valu_itemsedit_clothes.Maximum = 255
            valu_itemsedit_clothes.Value = 253
        Else
            Icon_itemsedit_clothes.Enabled = True
            valu_itemsedit_clothes.Enabled = True
            valu_itemsedit_clothes.Maximum = 99
            valu_itemsedit_clothes.Value = 99
        End If
    End Sub

    Private Sub Check_delete_ssclothes_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_ssclothes.CheckedChanged
        If Check_delete_ssclothes.Checked = True Then
            Icon_itemsedit_ssclothes.Enabled = False
            valu_itemsedit_ssclothes.Enabled = False
            valu_itemsedit_ssclothes.Maximum = 255
            valu_itemsedit_ssclothes.Value = 253
        Else
            Icon_itemsedit_ssclothes.Enabled = True
            valu_itemsedit_ssclothes.Enabled = True
            valu_itemsedit_ssclothes.Maximum = 99
            valu_itemsedit_ssclothes.Value = 99
        End If
    End Sub

    Private Sub Check_delete_hats_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_hats.CheckedChanged
        If Check_delete_hats.Checked = True Then
            Icon_itemsedit_hats.Enabled = False
            valu_itemsedit_hats.Enabled = False
            valu_itemsedit_hats.Maximum = 255
            valu_itemsedit_hats.Value = 253
        Else
            Icon_itemsedit_hats.Enabled = True
            valu_itemsedit_hats.Enabled = True
            valu_itemsedit_hats.Maximum = 99
            valu_itemsedit_hats.Value = 99
        End If
    End Sub

    Private Sub Check_delete_sshats_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_sshats.CheckedChanged
        If Check_delete_sshats.Checked = True Then
            Icon_itemsedit_sshats.Enabled = False
            valu_itemsedit_sshats.Enabled = False
            valu_itemsedit_sshats.Maximum = 255
            valu_itemsedit_sshats.Value = 253
        Else
            Icon_itemsedit_sshats.Enabled = True
            valu_itemsedit_sshats.Enabled = True
            valu_itemsedit_sshats.Maximum = 99
            valu_itemsedit_sshats.Value = 99
        End If
    End Sub

    Private Sub Check_delete_interiors_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_interiors.CheckedChanged
        If Check_delete_interiors.Checked = True Then
            Icon_itemsedit_interiors.Enabled = False
            valu_itemsedit_interiors.Enabled = False
            valu_itemsedit_interiors.Maximum = 255
            valu_itemsedit_interiors.Value = 253
        Else
            Icon_itemsedit_interiors.Enabled = True
            valu_itemsedit_interiors.Enabled = True
            valu_itemsedit_interiors.Maximum = 99
            valu_itemsedit_interiors.Value = 99
        End If
    End Sub

    Private Sub Check_delete_goodsitems_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_goodsitems.CheckedChanged
        If Check_delete_goodsitems.Checked = True Then
            Icon_itemsedit_goodsitems.Enabled = False
            valu_itemsedit_goodsitems.Enabled = False
            valu_itemsedit_goodsitems.Maximum = 255
            valu_itemsedit_goodsitems.Value = 253
        Else
            Icon_itemsedit_goodsitems.Enabled = True
            valu_itemsedit_goodsitems.Enabled = True
            valu_itemsedit_goodsitems.Maximum = 99
            valu_itemsedit_goodsitems.Value = 99
        End If
    End Sub

    Private Sub Check_delete_treasures_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_treasures.CheckedChanged
        If Check_delete_treasures.Checked = True Then
            Icon_itemsedit_treasures.Enabled = False
            valu_itemsedit_treasures.Enabled = False
            valu_itemsedit_treasures.Maximum = 255
            valu_itemsedit_treasures.Value = 253
        Else
            Icon_itemsedit_treasures.Enabled = True
            valu_itemsedit_treasures.Enabled = True
            valu_itemsedit_treasures.Maximum = 99
            valu_itemsedit_treasures.Value = 99
        End If
    End Sub

    Private Sub Check_delete_spefoods_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_spefoods.CheckedChanged
        If Check_delete_spefoods.Checked = True Then
            Icon_itemsedit_spefoods.Enabled = False
            valu_itemsedit_spefoods.Enabled = False
            valu_itemsedit_spefoods.Maximum = 255
            valu_itemsedit_spefoods.Value = 253
        Else
            Icon_itemsedit_spefoods.Enabled = True
            valu_itemsedit_spefoods.Enabled = True
            valu_itemsedit_spefoods.Maximum = 99
            valu_itemsedit_spefoods.Value = 99
        End If
    End Sub

    Public Sub writefoodsitems()
        If valu_itemsediticon_foods.Value = 1 Or Check_delete_foods.Checked = True Then
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            If Filever_text.Text = "US" Then
                For i As Integer = 0 To 230
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
            If Filever_text.Text = "EU" Then
                For i As Integer = 0 To 230
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
            If Filever_text.Text = "JP" Then
                For i As Integer = 0 To 229
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
            If Filever_text.Text = "KR" Then
                For i As Integer = 0 To 254
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
        End If
    End Sub
    ' end items edit animation block
End Class
