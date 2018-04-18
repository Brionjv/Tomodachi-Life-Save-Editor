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

    Private Sub unselectcolor()
        color_1.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_empty.BorderStyle = BorderStyle.None
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
        Select_music.SelectedItem = Select_music.Items.Item(0)
        Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(0)
        Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(0)
        Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(0)
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

    Private Sub Icon_miiedit_music_Click(sender As Object, e As EventArgs) Handles Icon_miiedit_music.Click
        Panel_cathphrase.Visible = False
        Panel_mii_musics.Visible = True
        Panel_mii_inventory.Visible = False
    End Sub

    Private Sub Icon_cathphrase_Click(sender As Object, e As EventArgs) Handles Icon_cathphrase.Click
        Panel_cathphrase.Visible = True
        Panel_mii_musics.Visible = False
        Panel_mii_inventory.Visible = False
    End Sub

    Private Sub Icon_inventory_Click(sender As Object, e As EventArgs) Handles Icon_inventory.Click
        Panel_cathphrase.Visible = False
        Panel_mii_musics.Visible = False
        Panel_mii_inventory.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.Click
        Text_edit_firstname.Text = Text_pronun_firstname.Text
        Panel_edit_firstname.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseMove
        Text_pronun_firstname.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseLeave
        Text_pronun_firstname.Visible = False
    End Sub

    Private Sub Icon_valid_firstname_Click(sender As Object, e As EventArgs) Handles Icon_valid_firstname.Click
        Text_pronun_firstname.Text = Text_edit_firstname.Text
        Panel_edit_firstname.Visible = False
    End Sub

    Private Sub Icon_pronun_lastname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.Click
        Text_edit_lastname.Text = Text_pronun_lastname.Text
        Panel_edit_lastname.Visible = True
    End Sub

    Private Sub Icon_pronun_lastname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseMove
        Text_pronun_lastname.Visible = True
    End Sub

    Private Sub Icon_pronun_lastname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseLeave
        Text_pronun_lastname.Visible = False
    End Sub

    Private Sub Icon_valid_lastname_Click(sender As Object, e As EventArgs) Handles Icon_valid_lastname.Click
        Text_pronun_lastname.Text = Text_edit_lastname.Text
        Panel_edit_lastname.Visible = False
    End Sub

    Private Sub Icon_pronun_nickname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseMove
        Text_pronun_nickname.Visible = True
    End Sub

    Private Sub Icon_pronun_nickname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseLeave
        Text_pronun_nickname.Visible = False
    End Sub

    Private Sub Button_close_hcoloredit_Click(sender As Object, e As EventArgs) Handles Button_close_hcoloredit.Click
        Panel_edit_haircolor.Visible = False
    End Sub

    Private Sub Icon_haircolor_Click(sender As Object, e As EventArgs) Handles Icon_haircolor.Click
        Panel_edit_haircolor.Visible = True
    End Sub

    Private Sub color_1_Click(sender As Object, e As EventArgs) Handles color_1.Click
        unselectcolor()
        color_1.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 128
    End Sub

    Private Sub color_2_Click(sender As Object, e As EventArgs) Handles color_2.Click
        unselectcolor()
        color_2.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 130
    End Sub

    Private Sub color_3_Click(sender As Object, e As EventArgs) Handles color_3.Click
        unselectcolor()
        color_3.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 132
    End Sub

    Private Sub color_4_Click(sender As Object, e As EventArgs) Handles color_4.Click
        unselectcolor()
        color_4.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 134
    End Sub

    Private Sub color_5_Click(sender As Object, e As EventArgs) Handles color_5.Click
        unselectcolor()
        color_5.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 136
    End Sub

    Private Sub color_6_Click(sender As Object, e As EventArgs) Handles color_6.Click
        unselectcolor()
        color_6.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 138
    End Sub

    Private Sub color_7_Click(sender As Object, e As EventArgs) Handles color_7.Click
        unselectcolor()
        color_7.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 140
    End Sub

    Private Sub color_8_Click(sender As Object, e As EventArgs) Handles color_8.Click
        unselectcolor()
        color_8.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 142
    End Sub

    Private Sub color_9_Click(sender As Object, e As EventArgs) Handles color_9.Click
        unselectcolor()
        color_9.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 144
    End Sub

    Private Sub color_10_Click(sender As Object, e As EventArgs) Handles color_10.Click
        unselectcolor()
        color_10.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 146
    End Sub

    Private Sub color_11_Click(sender As Object, e As EventArgs) Handles color_11.Click
        unselectcolor()
        color_11.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 148
    End Sub

    Private Sub color_12_Click(sender As Object, e As EventArgs) Handles color_12.Click
        unselectcolor()
        color_12.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 150
    End Sub

    Private Sub color_13_Click(sender As Object, e As EventArgs) Handles color_13.Click
        unselectcolor()
        color_13.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 152
    End Sub

    Private Sub color_14_Click(sender As Object, e As EventArgs) Handles color_14.Click
        unselectcolor()
        color_14.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 154
    End Sub

    Private Sub color_15_Click(sender As Object, e As EventArgs) Handles color_15.Click
        unselectcolor()
        color_15.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 156
    End Sub

    Private Sub color_16_Click(sender As Object, e As EventArgs) Handles color_16.Click
        unselectcolor()
        color_16.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 158
    End Sub

    Private Sub color_17_Click(sender As Object, e As EventArgs) Handles color_17.Click
        unselectcolor()
        color_17.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 160
    End Sub

    Private Sub color_18_Click(sender As Object, e As EventArgs) Handles color_18.Click
        unselectcolor()
        color_18.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 162
    End Sub

    Private Sub color_19_Click(sender As Object, e As EventArgs) Handles color_19.Click
        unselectcolor()
        color_19.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 164
    End Sub

    Private Sub color_20_Click(sender As Object, e As EventArgs) Handles color_20.Click
        unselectcolor()
        color_20.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 166
    End Sub

    Private Sub color_21_Click(sender As Object, e As EventArgs) Handles color_21.Click
        unselectcolor()
        color_21.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 168
    End Sub

    Private Sub color_22_Click(sender As Object, e As EventArgs) Handles color_22.Click
        unselectcolor()
        color_22.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 170
    End Sub

    Private Sub color_23_Click(sender As Object, e As EventArgs) Handles color_23.Click
        unselectcolor()
        color_23.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 172
    End Sub

    Private Sub color_24_Click(sender As Object, e As EventArgs) Handles color_24.Click
        unselectcolor()
        color_24.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 174
    End Sub

    Private Sub color_25_Click(sender As Object, e As EventArgs) Handles color_25.Click
        unselectcolor()
        color_25.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 176
    End Sub

    Private Sub color_26_Click(sender As Object, e As EventArgs) Handles color_26.Click
        unselectcolor()
        color_26.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 178
    End Sub

    Private Sub color_27_Click(sender As Object, e As EventArgs) Handles color_27.Click
        unselectcolor()
        color_27.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 180
    End Sub

    Private Sub color_28_Click(sender As Object, e As EventArgs) Handles color_28.Click
        unselectcolor()
        color_28.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 182
    End Sub

    Private Sub color_29_Click(sender As Object, e As EventArgs) Handles color_29.Click
        unselectcolor()
        color_29.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 184
    End Sub

    Private Sub color_30_Click(sender As Object, e As EventArgs) Handles color_30.Click
        unselectcolor()
        color_30.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 186
    End Sub

    Private Sub color_31_Click(sender As Object, e As EventArgs) Handles color_31.Click
        unselectcolor()
        color_31.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 188
    End Sub

    Private Sub color_32_Click(sender As Object, e As EventArgs) Handles color_32.Click
        unselectcolor()
        color_32.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 190
    End Sub

    Private Sub color_empty_Click(sender As Object, e As EventArgs) Handles color_empty.Click
        unselectcolor()
        color_empty.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 1
    End Sub

    Private Sub valu_haircolor_ValueChanged(sender As Object, e As EventArgs) Handles valu_haircolor.ValueChanged
        Select Case valu_haircolor.Value
            Case 128, 129
                Icon_haircolor.Image = My.Resources.HC80
            Case 130, 131
                Icon_haircolor.Image = My.Resources.HC82
            Case 132, 133
                Icon_haircolor.Image = My.Resources.HC84
            Case 134, 135
                Icon_haircolor.Image = My.Resources.HC86
            Case 136, 137
                Icon_haircolor.Image = My.Resources.HC88
            Case 138, 139
                Icon_haircolor.Image = My.Resources.HC8A
            Case 140, 141
                Icon_haircolor.Image = My.Resources.HC8C
            Case 142, 143
                Icon_haircolor.Image = My.Resources.HC8E
            Case 144, 145
                Icon_haircolor.Image = My.Resources.HC90
            Case 146, 147
                Icon_haircolor.Image = My.Resources.HC92
            Case 148, 149
                Icon_haircolor.Image = My.Resources.HC94
            Case 150, 151
                Icon_haircolor.Image = My.Resources.HC96
            Case 152, 153
                Icon_haircolor.Image = My.Resources.HC98
            Case 154, 155
                Icon_haircolor.Image = My.Resources.HC9A
            Case 156, 157
                Icon_haircolor.Image = My.Resources.HC9C
            Case 158, 159
                Icon_haircolor.Image = My.Resources.HC9E
            Case 160, 161
                Icon_haircolor.Image = My.Resources.HCA0
            Case 162, 163
                Icon_haircolor.Image = My.Resources.HCA2
            Case 164, 165
                Icon_haircolor.Image = My.Resources.HCA4
            Case 166, 167
                Icon_haircolor.Image = My.Resources.HCA6
            Case 168, 169
                Icon_haircolor.Image = My.Resources.HCA8
            Case 170, 171
                Icon_haircolor.Image = My.Resources.HCAA
            Case 172, 173
                Icon_haircolor.Image = My.Resources.HCAC
            Case 174, 175
                Icon_haircolor.Image = My.Resources.HCAE
            Case 176, 177
                Icon_haircolor.Image = My.Resources.HCB0
            Case 178, 179
                Icon_haircolor.Image = My.Resources.HCB2
            Case 180, 181
                Icon_haircolor.Image = My.Resources.HCB4
            Case 182, 183
                Icon_haircolor.Image = My.Resources.HCB6
            Case 184, 185
                Icon_haircolor.Image = My.Resources.HCB8
            Case 186, 187
                Icon_haircolor.Image = My.Resources.HCBA
            Case 188, 189
                Icon_haircolor.Image = My.Resources.HCBC
            Case 190, 191
                Icon_haircolor.Image = My.Resources.HCBE
            Case Else
                Icon_haircolor.Image = My.Resources.HCdefault
        End Select
    End Sub

    Private Sub Icon_fullness_Click(sender As Object, e As EventArgs) Handles Icon_fullness.Click
        Panel_edit_fullness.Visible = True
    End Sub

    Private Sub Icon_edit_full_00_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_00.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 0
    End Sub

    Private Sub Icon_edit_full_25_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_25.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 25
    End Sub

    Private Sub Icon_edit_full_50_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_50.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 50
    End Sub

    Private Sub Icon_edit_full_100_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_100.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 100
    End Sub

    Private Sub valu_fullness_ValueChanged(sender As Object, e As EventArgs) Handles valu_fullness.ValueChanged
        If valu_fullness.Value = 0 Then
            Icon_fullness.Image = My.Resources.fullness_00
        ElseIf valu_fullness.Value = 25 Then
            Icon_fullness.Image = My.Resources.fullness_25
        ElseIf valu_fullness.Value = 50 Then
            Icon_fullness.Image = My.Resources.fullness_50
        ElseIf valu_fullness.Value = 100 Then
            Icon_fullness.Image = My.Resources.fullness_100
        End If
    End Sub
End Class
