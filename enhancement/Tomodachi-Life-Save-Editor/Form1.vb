Imports System.Net
Public Class TL_SaveEditor
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim fdialog As New Form2

    Private Sub hidepanels()
        Panel_islandedit.Visible = False
        Panel_extras.Visible = False
        Panel_settings.Visible = False
        Panel_miiedit.Visible = False
    End Sub

    Public Sub Checkupdates()
        Try
            Dim MAJ As New WebClient
            Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Tomodachi-Life-Save-Editor/master/Version.txt")
            If Text_TLSE_version.Text = lastupdate Then
                TLSE_logo.Visible = True
                TLSE_logo_update.Visible = False
            Else
                TLSE_logo.Visible = False
                TLSE_logo_update.Visible = True
                fdialog.Text_fdialog.Text = "An update is avalible, click on Tomodachi Life Save Editor icon to download new version"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            fdialog.Text_fdialog.Text = "An error has occured when checking updates"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
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

    Private Sub Filever_text_Click(sender As Object, e As EventArgs) Handles Filever_text.Click
        If Filever_text.Text = "US" Then
            Filever_text.Text = "EU"
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
        ElseIf Filever_text.Text = "EU" Then
            Filever_text.Text = "JP"
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
        ElseIf Filever_text.Text = "JP" Then
            Filever_text.Text = "KR"
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
        ElseIf Filever_text.Text = "KR" Then
            Filever_text.Text = "US"
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
        End If
    End Sub

    Private Sub Info_islandbuild_MouseMove(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseMove
        Icon_info_building.Visible = True
    End Sub

    Private Sub Info_islandbuild_MouseLeave(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseLeave
        Icon_info_building.Visible = False
    End Sub

    Private Sub Icon_pronun_islandname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseMove
        Text_pronun_islandname.Visible = True
    End Sub

    Private Sub Icon_pronun_islandname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseLeave
        Text_pronun_islandname.Visible = False
    End Sub

    Private Sub Icon_islandn_pronun_val_Click(sender As Object, e As EventArgs) Handles Icon_islandn_pronun_val.Click
        Panel_edit_pronun_island.Visible = False
        Text_pronun_islandname.Text = Text_pronun_island.Text
    End Sub

    Private Sub Icon_pronun_islandname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.Click
        Panel_edit_pronun_island.Visible = True
        Text_pronun_island.Text = Text_pronun_islandname.Text
    End Sub

    Private Sub Icon_appartrenov_Click(sender As Object, e As EventArgs) Handles Icon_appartrenov.Click
        value_appartrenov.Value = (value_appartrenov.Value + 1)
    End Sub

    Private Sub valu__appartrenov_ValueChanged(sender As Object, e As EventArgs) Handles value_appartrenov.ValueChanged
        If value_appartrenov.Value > 3 Then
            value_appartrenov.Value = 0
        End If
        If value_appartrenov.Value = 0 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_00
        ElseIf value_appartrenov.Value = 1 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_01
        ElseIf value_appartrenov.Value = 2 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_02
        ElseIf value_appartrenov.Value = 3 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_03
        End If
    End Sub

    Private Sub Icon_eventfountain_Click(sender As Object, e As EventArgs) Handles Icon_eventfountain.Click
        value_eventfountain.Value = 0
    End Sub

    Private Sub Text_menu_button_Click(sender As Object, e As EventArgs) Handles Text_menu_button.Click
        If Menu_panel.Visible = False Then
            Menu_panel.Visible = True
        ElseIf Menu_panel.Visible = True Then
            Menu_panel.Visible = False
        End If
    End Sub

    Private Sub Menu_islandedit_Click(sender As Object, e As EventArgs) Handles Menu_islandedit.Click, Menu_text_islandedit.Click
        hidepanels()
        Panel_islandedit.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_islandedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_islandedit.MouseMove, Menu_text_islandedit.MouseMove
        Menu_islandedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_islandedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_islandedit.MouseLeave, Menu_text_islandedit.MouseLeave
        Menu_islandedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_extras_Click(sender As Object, e As EventArgs) Handles Menu_extras.Click, Menu_text_extras.Click
        hidepanels()
        Panel_extras.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_extras_MouseMove(sender As Object, e As EventArgs) Handles Menu_extras.MouseMove, Menu_text_extras.MouseMove
        Menu_extras.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_extras_MouseLeave(sender As Object, e As EventArgs) Handles Menu_extras.MouseLeave, Menu_text_extras.MouseLeave
        Menu_extras.BorderStyle = BorderStyle.None
    End Sub

    Private Sub TL_SaveEditor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Checkupdates()
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub Menu_settings_Click(sender As Object, e As EventArgs) Handles Menu_settings.Click, Menu_text_settings.Click
        hidepanels()
        Panel_settings.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_settings_MouseMove(sender As Object, e As EventArgs) Handles Menu_settings.MouseMove, Menu_text_settings.MouseMove
        Menu_settings.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_settings_MouseLeave(sender As Object, e As EventArgs) Handles Menu_settings.MouseLeave, Menu_text_settings.MouseLeave
        Menu_settings.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_itemsedit_Click(sender As Object, e As EventArgs) Handles Menu_itemsedit.Click, Menu_text_itemsedit.Click
        Menu_panel.Visible = False
        Me.Hide()
        'mettre un ecran de chargement (trop de ressources vont être utilisés)
        Items_edit.ShowDialog()
    End Sub

    Private Sub Menu_itemsedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseMove, Menu_text_itemsedit.MouseMove
        Menu_itemsedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseLeave, Menu_text_itemsedit.MouseLeave
        Menu_itemsedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_miiedit_Click(sender As Object, e As EventArgs) Handles Menu_miiedit.Click, Menu_text_miiedit.Click
        hidepanels()
        Panel_miiedit.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_miiedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_miiedit.MouseMove, Menu_text_miiedit.MouseMove
        Menu_miiedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_miiedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_miiedit.MouseLeave, Menu_text_miiedit.MouseLeave
        Menu_miiedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Select_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_language.SelectedIndexChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_menu_button.Text = "Menu"
            Text_menu_opensave.Text = "Open"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Island edit"
            Menu_text_miiedit.Text = "Mii edit"
            Menu_text_repair.Text = "Repair save file"
            Menu_text_settings.Text = "Settings"
            Menu_text_itemsedit.Text = "Items edit"
            Title_appartrenov.Text = "Apartments renovation"
            Title_childrenborn.Text = "Children born"
            Title_eventfountain.Text = "Event fountain"
            Title_islandname.Text = "Island's name"
            Title_problemsolved.Text = "Problems solved"
            Title_streetpassencounters.Text = "Streetpass encounters"
            Title_travelersreceived.Text = "Travelers received"
            Title_travelerssent.Text = "Travelers sent"
            Title_weddings.Text = "Weddings"
            Check_resetstpspp.Text = "Reset Tomodachi Life Streetpass / Spotpass"
            Check_timetravel.Text = "Remove time travel penality"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_menu_button.Text = "Menu"
            Text_menu_opensave.Text = "Ouvrir"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Édition île"
            Menu_text_miiedit.Text = "Édition Mii"
            Menu_text_repair.Text = "Réparation sauvegarde"
            Menu_text_settings.Text = "Paramètres"
            Menu_text_itemsedit.Text = "Édition objets"
            Title_appartrenov.Text = "Rénovation appartements"
            Title_childrenborn.Text = "Nouveau né"
            Title_eventfountain.Text = "Évènement fontaine"
            Title_islandname.Text = "Nom de l'île"
            Title_problemsolved.Text = "Problèmes résolus"
            Title_streetpassencounters.Text = "Streetpass reçus"
            Title_travelersreceived.Text = "Voyageurs reçus"
            Title_travelerssent.Text = "Voyageurs envoyés"
            Title_weddings.Text = "Mariages"
            Check_resetstpspp.Text = "Réinitialiser Streetpass / Spotpass de Tomodachi Life"
            Check_timetravel.Text = "Retirer la pénalité de voyage dans le temps"
        End If
    End Sub

    Private Sub Icon_appart_Click(sender As Object, e As EventArgs) Handles Icon_appart.Click
        If value_appart.Value < 2 Then
            value_appart.Value = value_appart.Value + 1
        ElseIf value_appart.Value = 2 Then
            value_appart.Value = 0
        End If
    End Sub

    Private Sub Icon_broc_Click(sender As Object, e As EventArgs) Handles Icon_broc.Click
        If value_broc.Value < 2 Then
            value_broc.Value = value_broc.Value + 1
        ElseIf value_broc.Value = 2 Then
            value_broc.Value = 0
        End If
    End Sub

    Private Sub Icon_cafe_Click(sender As Object, e As EventArgs) Handles Icon_cafe.Click
        If value_cafe.Value < 2 Then
            value_cafe.Value = value_cafe.Value + 1
        ElseIf value_cafe.Value = 2 Then
            value_cafe.Value = 0
        End If
    End Sub

    Private Sub Icon_chap_Click(sender As Object, e As EventArgs) Handles Icon_chap.Click
        If value_chap.Value < 2 Then
            value_chap.Value = value_chap.Value + 1
        ElseIf value_chap.Value = 2 Then
            value_chap.Value = 0
        End If
    End Sub

    Private Sub Icon_classem_Click(sender As Object, e As EventArgs) Handles Icon_classem.Click
        If value_classem.Value < 2 Then
            value_classem.Value = value_classem.Value + 1
        ElseIf value_classem.Value = 2 Then
            value_classem.Value = 0
        End If
    End Sub

    Private Sub Icon_conc_Click(sender As Object, e As EventArgs) Handles Icon_conc.Click
        If value_conc.Value < 2 Then
            value_conc.Value = value_conc.Value + 1
        ElseIf value_conc.Value = 2 Then
            value_conc.Value = 0
        End If
    End Sub

    Private Sub Icon_deco_Click(sender As Object, e As EventArgs) Handles Icon_deco.Click
        If value_deco.Value < 2 Then
            value_deco.Value = value_deco.Value + 1
        ElseIf value_deco.Value = 2 Then
            value_deco.Value = 0
        End If
    End Sub

    Private Sub Icon_epicer_Click(sender As Object, e As EventArgs) Handles Icon_epicer.Click
        If value_epicer.Value < 2 Then
            value_epicer.Value = value_epicer.Value + 1
        ElseIf value_epicer.Value = 2 Then
            value_epicer.Value = 0
        End If
    End Sub

    Private Sub Icon_font_Click(sender As Object, e As EventArgs) Handles Icon_font.Click
        If value_font.Value < 2 Then
            value_font.Value = value_font.Value + 1
        ElseIf value_font.Value = 2 Then
            value_font.Value = 0
        End If
    End Sub

    Private Sub Icon_info_Click(sender As Object, e As EventArgs) Handles Icon_info.Click
        If value_info.Value < 2 Then
            value_info.Value = value_info.Value + 1
        ElseIf value_info.Value = 2 Then
            value_info.Value = 0
        End If
    End Sub

    Private Sub Icon_magimport_Click(sender As Object, e As EventArgs) Handles Icon_magimport.Click
        If value_magimport.Value < 2 Then
            value_magimport.Value = value_magimport.Value + 1
        ElseIf value_magimport.Value = 2 Then
            value_magimport.Value = 0
        End If
    End Sub

    Private Sub Icon_mair_Click(sender As Object, e As EventArgs) Handles Icon_mair.Click
        If value_mair.Value < 2 Then
            value_mair.Value = value_mair.Value + 1
        ElseIf value_mair.Value = 2 Then
            value_mair.Value = 0
        End If
    End Sub

    Private Sub Icon_mais_Click(sender As Object, e As EventArgs) Handles Icon_mais.Click
        If value_mais.Value < 2 Then
            value_mais.Value = value_mais.Value + 1
        ElseIf value_mais.Value = 2 Then
            value_mais.Value = 0
        End If
    End Sub

    Private Sub Icon_parc_Click(sender As Object, e As EventArgs) Handles Icon_parc.Click
        If value_parc.Value < 2 Then
            value_parc.Value = value_parc.Value + 1
        ElseIf value_parc.Value = 2 Then
            value_parc.Value = 0
        End If
    End Sub

    Private Sub Icon_parc1_Click(sender As Object, e As EventArgs) Handles Icon_parc1.Click
        If value_parc1.Value < 2 Then
            value_parc1.Value = value_parc1.Value + 1
        ElseIf value_parc1.Value = 2 Then
            value_parc1.Value = 0
        End If
    End Sub

    Private Sub Icon_part_Click(sender As Object, e As EventArgs) Handles Icon_part.Click
        If value_part.Value < 2 Then
            value_part.Value = value_part.Value + 1
        ElseIf value_part.Value = 2 Then
            value_part.Value = 0
        End If
    End Sub

    Private Sub Icon_plage_Click(sender As Object, e As EventArgs) Handles Icon_plage.Click
        If value_plage.Value < 2 Then
            value_plage.Value = value_plage.Value + 1
        ElseIf value_plage.Value = 2 Then
            value_plage.Value = 0
        End If
    End Sub

    Private Sub Icon_port_Click(sender As Object, e As EventArgs) Handles Icon_port.Click
        If value_port.Value < 2 Then
            value_port.Value = value_port.Value + 1
        ElseIf value_port.Value = 2 Then
            value_port.Value = 0
        End If
    End Sub

    Private Sub Icon_stud_Click(sender As Object, e As EventArgs) Handles Icon_stud.Click
        If value_stud.Value < 2 Then
            value_stud.Value = value_stud.Value + 1
        ElseIf value_stud.Value = 2 Then
            value_stud.Value = 0
        End If
    End Sub

    Private Sub Icon_tervague_Click(sender As Object, e As EventArgs) Handles Icon_tervague.Click
        If value_tervague.Value < 2 Then
            value_tervague.Value = value_tervague.Value + 1
        ElseIf value_tervague.Value = 2 Then
            value_tervague.Value = 0
        End If
    End Sub

    Private Sub Icon_test_Click(sender As Object, e As EventArgs) Handles Icon_test.Click
        If value_test.Value < 2 Then
            value_test.Value = value_test.Value + 1
        ElseIf value_test.Value = 2 Then
            value_test.Value = 0
        End If
    End Sub

    Private Sub Icon_tour_Click(sender As Object, e As EventArgs) Handles Icon_tour.Click
        If value_tour.Value < 2 Then
            value_tour.Value = value_tour.Value + 1
        ElseIf value_tour.Value = 2 Then
            value_tour.Value = 0
        End If
    End Sub

    Private Sub Icon_vetem_Click(sender As Object, e As EventArgs) Handles Icon_vetem.Click
        If value_vetem.Value < 2 Then
            value_vetem.Value = value_vetem.Value + 1
        ElseIf value_vetem.Value = 2 Then
            value_vetem.Value = 0
        End If
    End Sub

    Private Sub value_appart_ValueChanged(sender As Object, e As EventArgs) Handles value_appart.ValueChanged
        If value_appart.Value = 0 Then
            Icon_appart.Image = Nothing
        ElseIf value_appart.Value = 1 Then
            Icon_appart.Image = My.Resources.appart
        ElseIf value_appart.Value = 2 Then
            Icon_appart.Image = My.Resources.appartn
        End If
    End Sub

    Private Sub value_broc_ValueChanged(sender As Object, e As EventArgs) Handles value_broc.ValueChanged
        If value_broc.Value = 0 Then
            Icon_broc.Image = Nothing
        ElseIf value_broc.Value = 1 Then
            Icon_broc.Image = My.Resources.broc
        ElseIf value_broc.Value = 2 Then
            Icon_broc.Image = My.Resources.brocn
        End If
    End Sub

    Private Sub value_cafe_ValueChanged(sender As Object, e As EventArgs) Handles value_cafe.ValueChanged
        If value_cafe.Value = 0 Then
            Icon_cafe.Image = Nothing
        ElseIf value_cafe.Value = 1 Then
            Icon_cafe.Image = My.Resources.cafe
        ElseIf value_cafe.Value = 2 Then
            Icon_cafe.Image = My.Resources.cafen
        End If
    End Sub

    Private Sub value_chap_ValueChanged(sender As Object, e As EventArgs) Handles value_chap.ValueChanged
        If value_chap.Value = 0 Then
            Icon_chap.Image = Nothing
        ElseIf value_chap.Value = 1 Then
            Icon_chap.Image = My.Resources.chap
        ElseIf value_chap.Value = 2 Then
            Icon_chap.Image = My.Resources.chapn
        End If
    End Sub

    Private Sub value_classem_ValueChanged(sender As Object, e As EventArgs) Handles value_classem.ValueChanged
        If value_classem.Value = 0 Then
            Icon_classem.Image = Nothing
        ElseIf value_classem.Value = 1 Then
            Icon_classem.Image = My.Resources.classem
        ElseIf value_classem.Value = 2 Then
            Icon_classem.Image = My.Resources.classn
        End If
    End Sub

    Private Sub value_conc_ValueChanged(sender As Object, e As EventArgs) Handles value_conc.ValueChanged
        If value_conc.Value = 0 Then
            Icon_conc.Image = Nothing
        ElseIf value_conc.Value = 1 Then
            Icon_conc.Image = My.Resources.conc
        ElseIf value_conc.Value = 2 Then
            Icon_conc.Image = My.Resources.concn
        End If
    End Sub

    Private Sub value_deco_ValueChanged(sender As Object, e As EventArgs) Handles value_deco.ValueChanged
        If value_deco.Value = 0 Then
            Icon_deco.Image = Nothing
        ElseIf value_deco.Value = 1 Then
            Icon_deco.Image = My.Resources.deco
        ElseIf value_deco.Value = 2 Then
            Icon_deco.Image = My.Resources.decon
        End If
    End Sub

    Private Sub value_epicer_ValueChanged(sender As Object, e As EventArgs) Handles value_epicer.ValueChanged
        If value_epicer.Value = 0 Then
            Icon_epicer.Image = Nothing
        ElseIf value_epicer.Value = 1 Then
            Icon_epicer.Image = My.Resources.epicer
        ElseIf value_epicer.Value = 2 Then
            Icon_epicer.Image = My.Resources.epicern
        End If
    End Sub

    Private Sub value_font_ValueChanged(sender As Object, e As EventArgs) Handles value_font.ValueChanged
        If value_font.Value = 0 Then
            Icon_font.Image = Nothing
        ElseIf value_font.Value = 1 Then
            Icon_font.Image = My.Resources.font
        ElseIf value_font.Value = 2 Then
            Icon_font.Image = My.Resources.fontn
        End If
    End Sub

    Private Sub value_info_ValueChanged(sender As Object, e As EventArgs) Handles value_info.ValueChanged
        If value_info.Value = 0 Then
            Icon_info.Image = Nothing
        ElseIf value_info.Value = 1 Then
            Icon_info.Image = My.Resources.info
        ElseIf value_info.Value = 2 Then
            Icon_info.Image = My.Resources.infon
        End If
    End Sub

    Private Sub value_magimport_ValueChanged(sender As Object, e As EventArgs) Handles value_magimport.ValueChanged
        If value_magimport.Value = 0 Then
            Icon_magimport.Image = Nothing
        ElseIf value_magimport.Value = 1 Then
            Icon_magimport.Image = My.Resources.magimport
        ElseIf value_magimport.Value = 2 Then
            Icon_magimport.Image = My.Resources.magimportn
        End If
    End Sub

    Private Sub value_mair_ValueChanged(sender As Object, e As EventArgs) Handles value_mair.ValueChanged
        If value_mair.Value = 0 Then
            Icon_mair.Image = Nothing
        ElseIf value_mair.Value = 1 Then
            Icon_mair.Image = My.Resources.mair
        ElseIf value_mair.Value = 2 Then
            Icon_mair.Image = My.Resources.mairn
        End If
    End Sub

    Private Sub value_mais_ValueChanged(sender As Object, e As EventArgs) Handles value_mais.ValueChanged
        If value_mais.Value = 0 Then
            Icon_mais.Image = Nothing
        ElseIf value_mais.Value = 1 Then
            Icon_mais.Image = My.Resources.mais
        ElseIf value_mais.Value = 2 Then
            Icon_mais.Image = My.Resources.maisn
        End If
    End Sub

    Private Sub value_parc_ValueChanged(sender As Object, e As EventArgs) Handles value_parc.ValueChanged
        If value_parc.Value = 0 Then
            Icon_parc.Image = Nothing
        ElseIf value_parc.Value = 1 Then
            Icon_parc.Image = My.Resources.parc
        ElseIf value_parc.Value = 2 Then
            Icon_parc.Image = My.Resources.parcn
        End If
    End Sub

    Private Sub value_parc1_ValueChanged(sender As Object, e As EventArgs) Handles value_parc1.ValueChanged
        If value_parc1.Value = 0 Then
            Icon_parc1.Image = Nothing
        ElseIf value_parc1.Value = 1 Then
            Icon_parc1.Image = My.Resources.parc1
        ElseIf value_parc1.Value = 2 Then
            Icon_parc1.Image = My.Resources.parc1n
        End If
    End Sub

    Private Sub value_part_ValueChanged(sender As Object, e As EventArgs) Handles value_part.ValueChanged
        If value_part.Value = 0 Then
            Icon_part.Image = Nothing
        ElseIf value_part.Value = 1 Then
            Icon_part.Image = My.Resources.part
        ElseIf value_part.Value = 2 Then
            Icon_part.Image = My.Resources.partn
        End If
    End Sub

    Private Sub value_plage_ValueChanged(sender As Object, e As EventArgs) Handles value_plage.ValueChanged
        If value_plage.Value = 0 Then
            Icon_plage.Image = Nothing
        ElseIf value_plage.Value = 1 Then
            Icon_plage.Image = My.Resources.plage
        ElseIf value_plage.Value = 2 Then
            Icon_plage.Image = My.Resources.plagen
        End If
    End Sub

    Private Sub value_port_ValueChanged(sender As Object, e As EventArgs) Handles value_port.ValueChanged
        If value_port.Value = 0 Then
            Icon_port.Image = Nothing
        ElseIf value_port.Value = 1 Then
            Icon_port.Image = My.Resources.port
        ElseIf value_port.Value = 2 Then
            Icon_port.Image = My.Resources.portn
        End If
    End Sub

    Private Sub value_stud_ValueChanged(sender As Object, e As EventArgs) Handles value_stud.ValueChanged
        If value_stud.Value = 0 Then
            Icon_stud.Image = Nothing
        ElseIf value_stud.Value = 1 Then
            Icon_stud.Image = My.Resources.stud
        ElseIf value_stud.Value = 2 Then
            Icon_stud.Image = My.Resources.studn
        End If
    End Sub

    Private Sub value_tervague_ValueChanged(sender As Object, e As EventArgs) Handles value_tervague.ValueChanged
        If value_tervague.Value = 0 Then
            Icon_tervague.Image = Nothing
        ElseIf value_tervague.Value = 1 Then
            Icon_tervague.Image = My.Resources.tervague
        ElseIf value_tervague.Value = 2 Then
            Icon_tervague.Image = My.Resources.tervaguen
        End If
    End Sub

    Private Sub value_test_ValueChanged(sender As Object, e As EventArgs) Handles value_test.ValueChanged
        If value_test.Value = 0 Then
            Icon_test.Image = Nothing
        ElseIf value_test.Value = 1 Then
            Icon_test.Image = My.Resources.test
        ElseIf value_test.Value = 2 Then
            Icon_test.Image = My.Resources.testn
        End If
    End Sub

    Private Sub value_tour_ValueChanged(sender As Object, e As EventArgs) Handles value_tour.ValueChanged
        If value_tour.Value = 0 Then
            Icon_tour.Image = Nothing
        ElseIf value_tour.Value = 1 Then
            Icon_tour.Image = My.Resources.tour
        ElseIf value_tour.Value = 2 Then
            Icon_tour.Image = My.Resources.tourn
        End If
    End Sub

    Private Sub value_vetem_ValueChanged(sender As Object, e As EventArgs) Handles value_vetem.ValueChanged
        If value_vetem.Value = 0 Then
            Icon_vetem.Image = Nothing
        ElseIf value_vetem.Value = 1 Then
            Icon_vetem.Image = My.Resources.vet
        ElseIf value_vetem.Value = 2 Then
            Icon_vetem.Image = My.Resources.vetn
        End If
    End Sub

    Private Sub Menu_width_Click(sender As Object, e As EventArgs) Handles Menu_width.Click
        If Menu_panel.Width = 34 Then
            Menu_panel.Width = 150
            Menu_width.Location = New Point(116, 0)
        Else
            Menu_panel.Width = 34
            Menu_width.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub TL_SaveEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_language.SelectedItem = Select_language.Items.Item(0)
        Select_music.SelectedItem = Select_music.Items.Item(0)
    End Sub

    Private Sub Setting_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_hidden.CheckedChanged
        If Setting_hidden.Checked = True Then
            Hidden_things.Visible = True
            value_appartrenov.Visible = True
            value_eventfountain.Visible = True
            value_appart.Visible = True
            value_broc.Visible = True
            value_cafe.Visible = True
            value_chap.Visible = True
            value_classem.Visible = True
            value_conc.Visible = True
            value_deco.Visible = True
            value_epicer.Visible = True
            value_font.Visible = True
            value_info.Visible = True
            value_magimport.Visible = True
            value_mair.Visible = True
            value_mais.Visible = True
            value_parc.Visible = True
            value_parc1.Visible = True
            value_part.Visible = True
            value_plage.Visible = True
            value_port.Visible = True
            value_stud.Visible = True
            value_tervague.Visible = True
            value_test.Visible = True
            value_tour.Visible = True
            value_vetem.Visible = True
        Else
            Hidden_things.Visible = False
            value_appartrenov.Visible = False
            value_eventfountain.Visible = False
            value_appart.Visible = False
            value_broc.Visible = False
            value_cafe.Visible = False
            value_chap.Visible = False
            value_classem.Visible = False
            value_conc.Visible = False
            value_deco.Visible = False
            value_epicer.Visible = False
            value_font.Visible = False
            value_info.Visible = False
            value_magimport.Visible = False
            value_mair.Visible = False
            value_mais.Visible = False
            value_parc.Visible = False
            value_parc1.Visible = False
            value_part.Visible = False
            value_plage.Visible = False
            value_port.Visible = False
            value_stud.Visible = False
            value_tervague.Visible = False
            value_test.Visible = False
            value_tour.Visible = False
            value_vetem.Visible = False
        End If
    End Sub

    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            File_path.Visible = True
        Else
            File_path.Visible = False
        End If
    End Sub

    Private Sub Info_islandbuild_MouseMove(sender As Object, e As MouseEventArgs) Handles Info_islandbuild.MouseMove

    End Sub
End Class
