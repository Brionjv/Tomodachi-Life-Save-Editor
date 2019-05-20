Imports PackageIO
Imports System.IO

Public Class TL_SaveEditor
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String

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

    Private Sub hideselectmenu()
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
        hideselectmenu()
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
        hideselectmenu()
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
        hideselectmenu()
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
        hideselectmenu()
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
        hideselectmenu()
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
        hideselectmenu()
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
        hideselectmenu()
    End Sub

    Private Sub Menu_text_itemsedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_itemsedit.MouseMove, Menu_text_itemsedit.MouseMove
        Menu_itemsedit.BackgroundImage = My.Resources.bg_menu_selected
    End Sub

    Private Sub Menu_text_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseLeave, Menu_text_itemsedit.MouseLeave
        Menu_itemsedit.BackgroundImage = Nothing
    End Sub
    'end menu animation block

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
        Catch ex As Exception
        End Try
    End Sub

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
            Text_description.Text = "Click to edit appartments renovation"
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
        hiddenthings()
    End Sub

    Public Sub hiddenthings()
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
        End If
    End Sub

    Private Sub Setting_spesymb_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_spesymb.CheckedChanged
        If Setting_spesymb.Checked = True Then
            Panel_bspesymb.Visible = True
            Addsymbol_islandname.Visible = True
        ElseIf Setting_spesymb.Checked = False Then
            Panel_bspesymb.Visible = False
            Addsymbol_islandname.Visible = False
            Addsymbol_pronun_island.Visible = False
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
End Class
