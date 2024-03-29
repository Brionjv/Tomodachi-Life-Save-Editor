﻿Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_hub
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

    Private Sub Text_menu_babiesedit_Click(sender As Object, e As EventArgs) Handles Text_menu_babiesedit.Click

    End Sub

    Private Sub Text_menu_babiesedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_babiesedit.MouseMove
        Menu_babiesedit.BackgroundImage = My.Resources.bbl_babyedit_act
    End Sub

    Private Sub Text_menu_babiesedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_babiesedit.MouseLeave
        Menu_babiesedit.BackgroundImage = My.Resources.bbl_babyedit
    End Sub

    Private Sub Text_menu_datasmanagement_Click(sender As Object, e As EventArgs) Handles Text_menu_datasmanagement.Click
        Hidemenu()
        TLSE_menu_datamanagement.Visible = True
    End Sub

    Private Sub Text_menu_datasmanagement_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_datasmanagement.MouseMove
        Menu_datasmanagement.BackgroundImage = My.Resources.bbl_datasmanagement_act
    End Sub

    Private Sub Text_menu_datasmanagement_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_datasmanagement.MouseLeave
        Menu_datasmanagement.BackgroundImage = My.Resources.bbl_datasmanagement
    End Sub

    Private Sub Text_menu_issueslegend_Click(sender As Object, e As EventArgs) Handles Text_menu_issueslegend.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_issueslegends.TLSE_logo_update.Visible = True
        End If
        TLSE_issueslegends.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_issueslegend_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_issueslegend.MouseMove
        Menu_issueslegend.BackgroundImage = My.Resources.bbl_issuelegend_act
        Icon_menu_issueslegend.Image = My.Resources.bbl_issuelegend_mov_act
    End Sub

    Private Sub Text_menu_issueslegend_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_issueslegend.MouseLeave
        Menu_issueslegend.BackgroundImage = My.Resources.bbl_issuelegend
        Icon_menu_issueslegend.Image = My.Resources.bbl_issuelegend_mov
    End Sub


    Private Sub Text_menu_concertedit_Click(sender As Object, e As EventArgs) Handles Text_menu_concertedit.Click
        If Filever_text.Text = "JP" Then
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "This feature is not available in your region"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Cette fonctionnalité n'est pas disponible dans votre région"
            End If
            TLSE_dialog.ShowDialog()
        Else
            If TLSE_logo_update.Visible = True Then
                TLSE_concertedit.TLSE_logo_update.Visible = True
            End If
            TLSE_concertedit.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Text_menu_concertedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_concertedit.MouseMove
        Menu_concertedit.BackgroundImage = My.Resources.bbl_concertedit_act
    End Sub

    Private Sub Text_menu_concertedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_concertedit.MouseLeave
        Menu_concertedit.BackgroundImage = My.Resources.bbl_concertedit
    End Sub

    Private Sub Text_menu_extras_Click(sender As Object, e As EventArgs) Handles Text_menu_extras.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_extras.TLSE_logo_update.Visible = True
        End If
        TLSE_extras.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_extras_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_extras.MouseMove
        Menu_extras.BackgroundImage = My.Resources.bbl_extras_act
    End Sub

    Private Sub Text_menu_extras_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_extras.MouseLeave
        Menu_extras.BackgroundImage = My.Resources.bbl_extras
    End Sub

    Private Sub Text_menu_islandedit_Click(sender As Object, e As EventArgs) Handles Text_menu_islandedit.Click
        Hidemenu()
        TLSE_menu_islandedit.Visible = True
    End Sub

    Private Sub Text_menu_islandedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_islandedit.MouseMove
        Menu_islandedit.BackgroundImage = My.Resources.bbl_islandedit_act
    End Sub

    Private Sub Text_menu_islandedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_islandedit.MouseLeave
        Menu_islandedit.BackgroundImage = My.Resources.bbl_islandedit
    End Sub

    Private Sub Text_menu_islandinfo_Click(sender As Object, e As EventArgs) Handles Text_menu_islandinfo.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_islandinfo.TLSE_logo_update.Visible = True
        End If
        TLSE_islandinfo.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_islandinfo_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_islandinfo.MouseMove
        Menu_islandinfo.BackgroundImage = My.Resources.bbl_islandinfo_act
    End Sub

    Private Sub Text_menu_islandinfo_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_islandinfo.MouseLeave
        Menu_islandinfo.BackgroundImage = My.Resources.bbl_islandinfo
    End Sub

    Private Sub Text_menu_dataislandranking_Click(sender As Object, e As EventArgs) Handles Text_menu_dataislandranking.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_dataislandranking.TLSE_logo_update.Visible = True
        End If
        TLSE_dataislandranking.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_dataislandranking_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_dataislandranking.MouseMove
        Menu_dataislandranking.BackgroundImage = My.Resources.bbl_dataislandranking_act
    End Sub

    Private Sub Text_menu_dataislandranking_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_dataislandranking.MouseLeave
        Menu_dataislandranking.BackgroundImage = My.Resources.bbl_dataislandranking
    End Sub

    Private Sub Text_menu_dataMiiexchange_Click(sender As Object, e As EventArgs) Handles Text_menu_datamiiexchange.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_datamiiexchange.TLSE_logo_update.Visible = True
        End If
        TLSE_datamiiexchange.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_dataMiiexchange_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_datamiiexchange.MouseMove
        Menu_datamiiexchange.BackgroundImage = My.Resources.bbl_datamiiexchange_act
    End Sub

    Private Sub Text_menu_dataMiiexchange_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_datamiiexchange.MouseLeave
        Menu_datamiiexchange.BackgroundImage = My.Resources.bbl_datamiiexchange
    End Sub

    Private Sub Text_menu_islandsettings_Click(sender As Object, e As EventArgs) Handles Text_menu_islandsettings.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_islandsettings.TLSE_logo_update.Visible = True
        End If
        TLSE_islandsettings.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_islandsettings_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_islandsettings.MouseMove
        Menu_islandsettings.BackgroundImage = My.Resources.bbl_islandsettings_act
    End Sub

    Private Sub Text_menu_islandsettings_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_islandsettings.MouseLeave
        Menu_islandsettings.BackgroundImage = My.Resources.bbl_islandsettings
    End Sub

    Private Sub Text_menu_savefilesettings_Click(sender As Object, e As EventArgs) Handles Text_menu_savefilesettings.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_savefilesettings.TLSE_logo_update.Visible = True
        End If
        TLSE_savefilesettings.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_savefilesettings_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_savefilesettings.MouseMove
        Menu_savefilesettings.BackgroundImage = My.Resources.bbl_savefilesettings_act
    End Sub

    Private Sub Text_menu_savefilesettings_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_savefilesettings.MouseLeave
        Menu_savefilesettings.BackgroundImage = My.Resources.bbl_savefilesettings
    End Sub

    Private Sub Text_menu_itemsedit_Click(sender As Object, e As EventArgs) Handles Text_menu_itemsedit.Click
        Hidemenu()
        TLSE_menu_Itemsedition.Visible = True
    End Sub

    Private Sub Text_menu_itemsedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_itemsedit.MouseMove
        Menu_itemsedit.BackgroundImage = My.Resources.bbl_itemsedit_act
    End Sub

    Private Sub Text_menu_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_itemsedit.MouseLeave
        Menu_itemsedit.BackgroundImage = My.Resources.bbl_itemsedit
    End Sub

    Private Sub Text_menu_manual_Click(sender As Object, e As EventArgs) Handles Text_menu_manual.Click

    End Sub

    Private Sub Text_menu_manual_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_manual.MouseMove
        Menu_manual.BackgroundImage = My.Resources.bbl_manual_act
    End Sub

    Private Sub Text_menu_manual_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_manual.MouseLeave
        Menu_manual.BackgroundImage = My.Resources.bbl_manual
    End Sub

    Private Sub Text_menu_miiedit_Click(sender As Object, e As EventArgs) Handles Text_menu_miiedit.Click
        Hidemenu()
        TLSE_menu_Miiedition.Visible = True
    End Sub

    Private Sub Text_menu_miiedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_miiedit.MouseMove
        Menu_miiedit.BackgroundImage = My.Resources.bbl_miiedit_act
    End Sub

    Private Sub Text_menu_miiedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_miiedit.MouseLeave
        Menu_miiedit.BackgroundImage = My.Resources.bbl_miiedit
    End Sub

    Private Sub Text_menu_miimanagement_Click(sender As Object, e As EventArgs) Handles Text_menu_miimanagement.Click
        Hidemenu()
        TLSE_menu_miimanagement.Visible = True
    End Sub

    Private Sub Text_menu_miimanagement_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_miimanagement.MouseMove
        Menu_miimanagement.BackgroundImage = My.Resources.bbl_miimanagement_act
    End Sub

    Private Sub Text_menu_miimanagement_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_miimanagement.MouseLeave
        Menu_miimanagement.BackgroundImage = My.Resources.bbl_miimanagement
    End Sub

    Private Sub Text_menu_repairsave_Click(sender As Object, e As EventArgs) Handles Text_menu_repairsave.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_repairsave.TLSE_logo_update.Visible = True
        End If
        TLSE_repairsave.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_repairsave_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_repairsave.MouseMove
        Menu_repairsave.BackgroundImage = My.Resources.bbl_repairsave_act
    End Sub

    Private Sub Text_menu_repairsave_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_repairsave.MouseLeave
        Menu_repairsave.BackgroundImage = My.Resources.bbl_repairsave
    End Sub

    Private Sub Text_menu_creaislandranking_Click(sender As Object, e As EventArgs) Handles Text_menu_creaislandranking.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_creaislandranking.TLSE_logo_update.Visible = True
        End If
        TLSE_creaislandranking.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_creaislandranking_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_creaislandranking.MouseMove
        Menu_creaislandranking.BackgroundImage = My.Resources.bbl_dataislandranking_act
    End Sub

    Private Sub Text_menu_creaislandranking_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_creaislandranking.MouseLeave
        Menu_creaislandranking.BackgroundImage = My.Resources.bbl_dataislandranking
    End Sub

    Private Sub Text_menu_settings_Click(sender As Object, e As EventArgs) Handles Text_menu_settings.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_settings.TLSE_logo_update.Visible = True
        End If
        TLSE_settings.Show()
        TLSE_settings.Filever_text.Text = Filever_text.Text
        TLSE_settings.TLSE_filepath.Text = TLSE_filepath.Text
        Me.Close()
    End Sub

    Private Sub Text_menu_settings_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_settings.MouseMove
        Menu_settings.BackgroundImage = My.Resources.bbl_settings_act
    End Sub

    Private Sub Text_menu_settings_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_settings.MouseLeave
        Menu_settings.BackgroundImage = My.Resources.bbl_settings
    End Sub

    Private Sub Text_menu_travelersedit_Click(sender As Object, e As EventArgs) Handles Text_menu_travelersedit.Click
        Hidemenu()
        TLSE_menu_travelersedit.Visible = True
    End Sub

    Private Sub Text_menu_travelersedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_travelersedit.MouseMove
        Menu_travelersedit.BackgroundImage = My.Resources.bbl_travelersedit_act
    End Sub

    Private Sub Text_menu_travelersedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_travelersedit.MouseLeave
        Menu_travelersedit.BackgroundImage = My.Resources.bbl_travelersedit
    End Sub

    Private Sub Text_menu_interactions_Click(sender As Object, e As EventArgs) Handles Text_menu_interactions.Click
        If Filever_text.Text = "JP" Or Filever_text.Text = "KR" Then
            TLSE_dialog.Text_TLSE_dialog.Text = "This section is not available in your region game"
            TLSE_dialog.ShowDialog()
        Else
            If TLSE_logo_update.Visible = True Then
                TLSE_interactions.TLSE_logo_update.Visible = True
            End If
            TLSE_interactions.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Text_menu_interactions_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_interactions.MouseMove
        Menu_interactions.BackgroundImage = My.Resources.bbl_interaction_act
    End Sub

    Private Sub Text_menu_interactions_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_interactions.MouseLeave
        Menu_interactions.BackgroundImage = My.Resources.bbl_interaction
    End Sub

    Private Sub Text_menu_islandconfig_Click(sender As Object, e As EventArgs) Handles Text_menu_islandconfig.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_islandconfig.TLSE_logo_update.Visible = True
        End If
        TLSE_islandconfig.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_islandconfig_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_islandconfig.MouseMove
        Menu_islandconfig.BackgroundImage = My.Resources.bbl_islandconfig_act
    End Sub

    Private Sub Text_menu_islandconfig_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_islandconfig.MouseLeave
        Menu_islandconfig.BackgroundImage = My.Resources.bbl_islandconfig
    End Sub

    Private Sub Text_menu_relationships_Click(sender As Object, e As EventArgs) Handles Text_menu_relationships.Click
        If Filever_text.Text = "JP" Then
            If TLSE_logo_update.Visible = True Then
                TLSE_Jrelationships.TLSE_logo_update.Visible = True
            End If
            TLSE_Jrelationships.Show()
            Me.Close()
        Else
            If TLSE_logo_update.Visible = True Then
                TLSE_relationships.TLSE_logo_update.Visible = True
            End If
            TLSE_relationships.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Text_menu_relationships_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_relationships.MouseMove
        Menu_relationships.BackgroundImage = My.Resources.bbl_relationship_act
    End Sub

    Private Sub Text_menu_relationships_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_relationships.MouseLeave
        Menu_relationships.BackgroundImage = My.Resources.bbl_relationship
    End Sub

    Private Sub Text_menu_appareance_Click(sender As Object, e As EventArgs) Handles Text_menu_appareance.Click
        'If TLSE_logo_update.Visible = True Then
        'TLSE_appareance.TLSE_logo_update.Visible = True
        'End If
        'TLSE_appareance.Show()
        ' Me.Close()
    End Sub

    Private Sub Text_menu_appareance_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_appareance.MouseMove
        Menu_appareance.BackgroundImage = My.Resources.bbl_appareance_act
    End Sub

    Private Sub Text_menu_appareance_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_appareance.MouseLeave
        Menu_appareance.BackgroundImage = My.Resources.bbl_appareance
    End Sub

    Private Sub Text_menu_miiprofile_Click(sender As Object, e As EventArgs) Handles Text_menu_miiprofile.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_miiprofile.TLSE_logo_update.Visible = True
        End If
        TLSE_miiprofile.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_miiprofile_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_miiprofile.MouseMove
        Menu_miiprofile.BackgroundImage = My.Resources.bbl_miiprofile_act
    End Sub

    Private Sub Text_menu_miiprofile_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_miiprofile.MouseLeave
        Menu_miiprofile.BackgroundImage = My.Resources.bbl_miiprofile
    End Sub

    Private Sub Text_menu_miifoods_Click(sender As Object, e As EventArgs) Handles Text_menu_miifoods.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_miifoods.TLSE_logo_update.Visible = True
        End If
        TLSE_miifoods.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_miifoods_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_miifoods.MouseMove
        Menu_miifoods.BackgroundImage = My.Resources.bbl_miifoods_act
    End Sub

    Private Sub Text_menu_miifoods_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_miifoods.MouseLeave
        Menu_miifoods.BackgroundImage = My.Resources.bbl_miifoods
    End Sub

    Private Sub Text_menu_miiinventory_Click(sender As Object, e As EventArgs) Handles Text_menu_miiinventory.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_miiinventory.TLSE_logo_update.Visible = True
        End If
        TLSE_miiinventory.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_miiinventory_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_miiinventory.MouseMove
        Menu_miiinventory.BackgroundImage = My.Resources.bbl_miiinventory_act
    End Sub

    Private Sub Text_menu_miiinventory_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_miiinventory.MouseLeave
        Menu_miiinventory.BackgroundImage = My.Resources.bbl_miiinventory
    End Sub

    Private Sub Text_menu_miistatus_Click(sender As Object, e As EventArgs) Handles Text_menu_miistatus.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_miistatus.TLSE_logo_update.Visible = True
        End If
        TLSE_miistatus.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_miistatus_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_miistatus.MouseMove
        Menu_miistatus.BackgroundImage = My.Resources.bbl_miistatus_act
    End Sub

    Private Sub Text_menu_miistatus_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_miistatus.MouseLeave
        Menu_miistatus.BackgroundImage = My.Resources.bbl_miistatus
    End Sub

    Private Sub Text_menu_voicepersonnality_Click(sender As Object, e As EventArgs) Handles Text_menu_voicepersonnality.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_voicepersonnality.TLSE_logo_update.Visible = True
        End If
        TLSE_voicepersonnality.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_voicepersonnality_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_voicepersonnality.MouseMove
        Menu_voicepersonnality.BackgroundImage = My.Resources.bbl_voicepersonnality_act
    End Sub

    Private Sub Text_menu_voicepersonnality_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_voicepersonnality.MouseLeave
        Menu_voicepersonnality.BackgroundImage = My.Resources.bbl_voicepersonnality
    End Sub


    Private Sub Icon_menu_miiedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_miiedit.MouseMove
        Icon_menu_miiedit.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_miiedit_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_miiedit.MouseLeave
        Icon_menu_miiedit.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_miiedit_Click(sender As Object, e As EventArgs) Handles Icon_menu_miiedit.Click
        Hidemenu()
        TLSE_menu.Visible = True
    End Sub

    Private Sub Icon_menu_islandedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_islandedit.MouseMove
        Icon_menu_islandedit.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_islandedit_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_islandedit.MouseLeave
        Icon_menu_islandedit.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_islandedit_Click(sender As Object, e As EventArgs) Handles Icon_menu_islandedit.Click
        Hidemenu()
        TLSE_menu.Visible = True
    End Sub

    Private Sub Icon_menu_datamanagement_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_datamanagement.MouseMove
        Icon_menu_datamanagement.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_datamanagement_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_datamanagement.MouseLeave
        Icon_menu_datamanagement.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_datamanagement_Click(sender As Object, e As EventArgs) Handles Icon_menu_datamanagement.Click
        Hidemenu()
        TLSE_menu.Visible = True
    End Sub

    Private Sub Icon_menu_itemsedit_Click(sender As Object, e As EventArgs) Handles Icon_menu_itemsedit.Click
        Hidemenu()
        TLSE_menu.Visible = True
    End Sub

    Private Sub Icon_menu_itemsedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_itemsedit.MouseMove
        Icon_menu_itemsedit.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_itemsedit.MouseLeave
        Icon_menu_itemsedit.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Text_menu_itemsprovenance_Click(sender As Object, e As EventArgs) Handles Text_menu_itemsprovenance.Click
        If Filever_text.Text = "EU" Then
            If TLSE_logo_update.Visible = True Then
                TLSE_itemsprovenance.TLSE_logo_update.Visible = True
            End If
            TLSE_itemsprovenance.Show()
            Me.Close()
        Else
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "This feature is not available in your region, see issue #31"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Cette fonctionnalité n'est pas disponible dans votre région, voir issue #31"
            End If
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Private Sub Text_menu_itemsprovenance_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_itemsprovenance.MouseMove
        Menu_itemsprovenance.BackgroundImage = My.Resources.bbl_itemsprovenance_act
    End Sub

    Private Sub Text_menu_itemsprovenance_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_itemsprovenance.MouseLeave
        Menu_itemsprovenance.BackgroundImage = My.Resources.bbl_itemsprovenance
    End Sub

    Private Sub Icon_menu_miimanagement_Click(sender As Object, e As EventArgs) Handles Icon_menu_miimanagement.Click
        Hidemenu()
        TLSE_menu.Visible = True
    End Sub

    Private Sub Icon_menu_miimanagement_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_miimanagement.MouseMove
        Icon_menu_miimanagement.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_miimanagement_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_miimanagement.MouseLeave
        Icon_menu_miimanagement.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_datacreation_Click(sender As Object, e As EventArgs) Handles Icon_menu_datacreation.Click
        Hidemenu()
        TLSE_menu.Visible = True
    End Sub

    Private Sub Icon_menu_datacreation_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_datacreation.MouseMove
        Icon_menu_datacreation.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_datacreation_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_datacreation.MouseLeave
        Icon_menu_datacreation.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Text_menu_datacreation_Click(sender As Object, e As EventArgs) Handles Text_menu_datacreation.Click
        Hidemenu()
        TLSE_menu_datacreation.Visible = True
    End Sub

    Private Sub Text_menu_datacreation_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_datacreation.MouseMove
        Menu_datacreation.BackgroundImage = My.Resources.bbl_datasedition_act
    End Sub

    Private Sub Text_menu_datacreation_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_datacreation.MouseLeave
        Menu_datacreation.BackgroundImage = My.Resources.bbl_datasedition
    End Sub

    Private Sub Icon_menu_travelersedit_Click(sender As Object, e As EventArgs) Handles Icon_menu_travelersedit.Click
        Hidemenu()
        TLSE_menu.Visible = True
    End Sub

    Private Sub Icon_menu_travelersedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu_travelersedit.MouseMove
        Icon_menu_travelersedit.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_travelersedit_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu_travelersedit.MouseLeave
        Icon_menu_travelersedit.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Text_menu_allmiis_Click(sender As Object, e As EventArgs) Handles Text_menu_allmiis.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_manag_allmiis.TLSE_logo_update.Visible = True
        End If
        TLSE_manag_allmiis.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_allmiis_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_allmiis.MouseMove
        Menu_allmiis.BackgroundImage = My.Resources.bbl_manag_allmii_act
    End Sub

    Private Sub Text_menu_allmiis_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_allmiis.MouseLeave
        Menu_allmiis.BackgroundImage = My.Resources.bbl_manag_allmii
    End Sub

    Private Sub Text_menu_mii_Click(sender As Object, e As EventArgs) Handles Text_menu_mii.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_manag_mii.TLSE_logo_update.Visible = True
        End If
        TLSE_manag_mii.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_mii_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_mii.MouseMove
        Menu_mii.BackgroundImage = My.Resources.bbl_manag_mii_act
    End Sub

    Private Sub Text_menu_mii_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_mii.MouseLeave
        Menu_mii.BackgroundImage = My.Resources.bbl_manag_mii
    End Sub

    Private Sub Text_menu_items_Click(sender As Object, e As EventArgs) Handles Text_menu_items.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_itemsedit.TLSE_logo_update.Visible = True
        End If
        TLSE_itemsedit.Show()
        Me.Close()
    End Sub

    Private Sub Text_menu_items_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_items.MouseMove
        Menu_items.BackgroundImage = My.Resources.bbl_items_act
    End Sub

    Private Sub Text_menu_litems_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_items.MouseLeave
        Menu_items.BackgroundImage = My.Resources.bbl_items
    End Sub

    Private Sub Text_menu_travelers_Click(sender As Object, e As EventArgs) Handles Text_menu_travelers.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_manag_travelers.TLSE_logo_update.Visible = True
        End If
        TLSE_manag_travelers.Show()
        Me.Close()
    End Sub
    Private Sub Text_menu_travelers_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_travelers.MouseMove
        Menu_travelers.BackgroundImage = My.Resources.bbl_manag_travelers_act
    End Sub

    Private Sub Text_menu_travelers_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_travelers.MouseLeave
        Menu_travelers.BackgroundImage = My.Resources.bbl_manag_travelers
    End Sub

    Private Sub Text_menu_travelersstatus_Click(sender As Object, e As EventArgs) Handles Text_menu_travelersstatus.Click
        If Filever_text.Text = "JP" Then
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "This feature is not available in your region"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Cette fonctionnalité n'est pas disponible dans votre région"
            End If
            TLSE_dialog.ShowDialog()
        Else
            If TLSE_logo_update.Visible = True Then
                TLSE_travelers_status.TLSE_logo_update.Visible = True
            End If
            TLSE_travelers_status.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Text_menu_travelersstatus_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_travelersstatus.MouseMove
        Menu_travelersstatus.BackgroundImage = My.Resources.bbl_travelers_status_act
    End Sub

    Private Sub Text_menu_travelersstatus_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_travelersstatus.MouseLeave
        Menu_travelersstatus.BackgroundImage = My.Resources.bbl_travelers_status
    End Sub

    Public Sub Hidemenu()
        TLSE_menu.Visible = False
        TLSE_menu_Miiedition.Visible = False
        TLSE_menu_Itemsedition.Visible = False
        TLSE_menu_miimanagement.Visible = False
        TLSE_menu_travelersedit.Visible = False
        TLSE_menu_islandedit.Visible = False
        TLSE_menu_datamanagement.Visible = False
        TLSE_menu_datacreation.Visible = False
    End Sub

    Private Sub TLSE_hub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Setting_Advhelp.Checked = My.Settings.Para_AdvH
            Setting_ckupdate.Checked = My.Settings.Para_chkupdate
            Setting_hidden.Checked = My.Settings.Para_hidden
            Setting_music.Checked = My.Settings.Para_music
            Setting_filepath.Checked = My.Settings.Para_path
            Setting_spesymb.Checked = My.Settings.Para_spesymb
            Select_language.SelectedItem = My.Settings.Para_language
            If Select_language.SelectedItem = Nothing Then
                Select_language.SelectedItem = Select_language.Items.Item(0)
            End If
            Select_music.SelectedItem = My.Settings.Para_selmusic
            text_issues.Text = My.Settings.Para_issue
        Catch ex As Exception
        End Try
        'TLSE_language()
        Switchfilever()
    End Sub

    Public Sub TLSE_language()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_menu_open.Text = "Open"
            Title_filever.Text = "Save file region :"
            Text_menu_travelersedit.Text = "Travelers edition" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Edit travelers in your island"
            Text_menu_extras.Text = "Extras" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit your island configurations"
            Text_menu_babiesedit.Text = "Babies edition" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit babies in your island"
            Text_menu_miiedit.Text = "Mii edition" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit Mii in your island"
            Text_menu_islandedit.Text = "Island edition" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit your island informations"
            Text_menu_miimanagement.Text = "Mii management" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Import and export Mii in your island"
            Text_menu_itemsedit.Text = "Items edition" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Edit items in your inventory or in shops"
            Text_menu_concertedit.Text = "Concerts edition" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit concerts your island"
            Text_menu_settings.Text = "Settings" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Access to Tomodachi Life Save Editor settings"
            Text_menu_manual.Text = "Manual" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Access to Tomodachi Life Save Editor manual"
            Text_menu_repairsave.Text = "Repair save" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Repair your save file"
            Text_menu_relationships.Text = "Relationships" & vbNewLine & "__________________" & vbNewLine & vbNewLine & "Edit Mii 's relationships"
            Text_menu_interactions.Text = "Interactions" & vbNewLine & "__________________" & vbNewLine & vbNewLine & "Edit Mii 's interactions"
            Menuflow_text_miiediton.Text = "Mii edition"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_menu_open.Text = "Ouvrir"
            Title_filever.Text = "Région de la" & vbNewLine & "sauvegarde :"
            Text_menu_travelersedit.Text = "Édition voyageurs" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Éditer les voyageurs de votre île"
            Text_menu_extras.Text = "Extras" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Éditer les configurations de votre île"
            Text_menu_babiesedit.Text = "Édition bébés" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Éditer les bébés de votre île"
            Text_menu_miiedit.Text = "Édition Mii" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Éditer les Mii de votre île"
            Text_menu_islandedit.Text = "Édition île" & vbNewLine & "__________________" & vbNewLine & vbNewLine & "Éditer les informations de votre île"
            Text_menu_miimanagement.Text = "Management Mii" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Importer et exporter les Mii de votre île"
            Text_menu_itemsedit.Text = "Édition objets" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Éditer les objets dans votre inventaire ou dans les magasins"
            Text_menu_concertedit.Text = "Édition concerts" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Éditer les concerts dans votre île"
            Text_menu_settings.Text = "Paramètres" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Accéder aux paramètres de Tomodachi Life Save Editor"
            Text_menu_manual.Text = "Manuel" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Accéder au manuel de Tomodachi Life Save Editor"
            Text_menu_repairsave.Text = "Réparation sauvegarde" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Réparer votre fichier de sauvegarde"
            Text_menu_relationships.Text = "Relations" & vbNewLine & "__________________" & vbNewLine & vbNewLine & "Éditer les relations des Mii"
            Text_menu_interactions.Text = "Intéractions" & vbNewLine & "__________________" & vbNewLine & vbNewLine & "Éditer les intéractions des Mii"
            Menuflow_text_miiediton.Text = "Édition Mii"
        End If
    End Sub

    Private Sub Setting_ckupdate_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_ckupdate.CheckedChanged
        If Setting_ckupdate.Checked = True Then
            Panel_chkupdate.Visible = True
        End If
        If Setting_ckupdate.Checked = False Then
            Panel_chkupdate.Visible = False
        End If
    End Sub

    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            TLSE_filepath.Visible = True
            Panel_filepath.Visible = True
        End If
        If Setting_filepath.Checked = False Then
            TLSE_filepath.Visible = False
            Panel_filepath.Visible = False
        End If
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Try
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Tomodachi Life Save Editor will make a backup of your save file in case" & vbNewLine & "If you are troubles, you can restore your older save file in 'Backup' folder in save editor location"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Tomodachi Life Save Editor va faire une copie de votre sauvegarde au cas où" & vbNewLine & "Si vous avez un problème, vous pouvez restaurer votre ancien fichier de sauvegarde dans le dossier 'Backup' à l'emplacement de l'éditeur de sauvegarde"
            End If
            TLSE_dialog.ShowDialog()
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
            TLSE_filepath.Text = savedataArc
            Makebackup()
            Switchfilever()
        Catch ex As Exception
        End Try
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
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Checkupdates()
        If Setting_ckupdate.Checked = False Then
            Try
                Dim MAJ As New WebClient
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Tomodachi-Life-Save-Editor/master/Version.txt")
                If TLSE_version.Text = lastupdate Then
                    TLSE_logo.Visible = True
                    TLSE_logo_update.Visible = False
                Else
                    TLSE_logo.Visible = False
                    TLSE_logo_update.Visible = True
                    If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                        TLSE_dialog.Text_TLSE_dialog.Text = "An update is available" & vbNewLine & vbNewLine & "Click on Tomodachi Life Save Editor icon" & vbNewLine & "to download new version"
                        TLSE_dialog.ShowDialog()
                    End If
                    If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                        TLSE_dialog.Text_TLSE_dialog.Text = "Une mise à jour est disponible" & vbNewLine & vbNewLine & "Cliquez sur l'îcone de Tomodachi Life Save Editor" & vbNewLine & "pour télécharger la nouvelle version"
                        TLSE_dialog.ShowDialog()
                    End If
                End If

            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "An error has occurred when checking updates" & vbNewLine & "Check if you are connected to internet"
                    TLSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Une erreur est survenue lors de la vérification des mises à jour" & vbNewLine & "Vérifiez que vous êtes connecté à internet"
                    TLSE_dialog.ShowDialog()
                End If
            End Try
        End If
    End Sub

    Private Sub TLSE_hub_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If TLSE_logo_update.Visible = False Then
            If Setting_ckupdate.Checked = False Then
                Checkupdates()
            End If
        End If
        Checkissues()
        Switchfilever()
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Public Sub Checkissues()
        Try
            Dim MAJ As New WebClient
            Dim lastissues As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Tomodachi-Life-Save-Editor/master/Issues.txt")
            If text_issues.Text = lastissues Then
                Icon_menu_issueslegend.Visible = False
            Else
                Icon_menu_issueslegend.Visible = True
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "An error has occurred when checking know issues" & vbNewLine & "Check if you are connected to internet"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Une erreur est survenue lors de la vérification des problèmes connus" & vbNewLine & "Vérifiez que vous êtes connecté à internet"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub text_issues_Click(sender As Object, e As EventArgs) Handles text_issues.Click
        My.Settings.Para_issue = Nothing
    End Sub

    Public Sub Switchfilever()
        If Filever_text.Text = "EU" Then
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
        End If
        If Filever_text.Text = "US" Then
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
        End If
        If Filever_text.Text = "JP" Then
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
        End If
        If Filever_text.Text = "KR" Then
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
        End If
    End Sub


End Class