Imports System.IO
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

    Private Sub Text_menu_concertedit_Click(sender As Object, e As EventArgs) Handles Text_menu_concertedit.Click

    End Sub

    Private Sub Text_menu_concertedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_concertedit.MouseMove
        Menu_concertedit.BackgroundImage = My.Resources.bbl_concertedit_act
    End Sub

    Private Sub Text_menu_concertedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_concertedit.MouseLeave
        Menu_concertedit.BackgroundImage = My.Resources.bbl_concertedit
    End Sub

    Private Sub Text_menu_extras_Click(sender As Object, e As EventArgs) Handles Text_menu_extras.Click

    End Sub

    Private Sub Text_menu_extras_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_extras.MouseMove
        Menu_extras.BackgroundImage = My.Resources.bbl_extras_act
    End Sub

    Private Sub Text_menu_extras_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_extras.MouseLeave
        Menu_extras.BackgroundImage = My.Resources.bbl_extras
    End Sub

    Private Sub Text_menu_islandedit_Click(sender As Object, e As EventArgs) Handles Text_menu_islandedit.Click

    End Sub

    Private Sub Text_menu_islandedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_islandedit.MouseMove
        Menu_islandedit.BackgroundImage = My.Resources.bbl_islandedit_act
    End Sub

    Private Sub Text_menu_islandedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_islandedit.MouseLeave
        Menu_islandedit.BackgroundImage = My.Resources.bbl_islandedit
    End Sub

    Private Sub Text_menu_itemsedit_Click(sender As Object, e As EventArgs) Handles Text_menu_itemsedit.Click

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

    End Sub

    Private Sub Text_menu_miimanagement_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_miimanagement.MouseMove
        Menu_miimanagement.BackgroundImage = My.Resources.bbl_miimanagement_act
    End Sub

    Private Sub Text_menu_miimanagement_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_miimanagement.MouseLeave
        Menu_miimanagement.BackgroundImage = My.Resources.bbl_miimanagement
    End Sub

    Private Sub Text_menu_repairsave_Click(sender As Object, e As EventArgs) Handles Text_menu_repairsave.Click

    End Sub

    Private Sub Text_menu_repairsave_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_repairsave.MouseMove
        Menu_repairsave.BackgroundImage = My.Resources.bbl_repairsave_act
    End Sub

    Private Sub Text_menu_repairsave_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_repairsave.MouseLeave
        Menu_repairsave.BackgroundImage = My.Resources.bbl_repairsave
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

    End Sub

    Private Sub Text_menu_travelersedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_travelersedit.MouseMove
        Menu_travelersedit.BackgroundImage = My.Resources.bbl_travelersedit_act
    End Sub

    Private Sub Text_menu_travelersedit_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_travelersedit.MouseLeave
        Menu_travelersedit.BackgroundImage = My.Resources.bbl_travelersedit
    End Sub

    Private Sub Text_menu_interactions_Click(sender As Object, e As EventArgs) Handles Text_menu_interactions.Click

    End Sub

    Private Sub Text_menu_interactions_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_interactions.MouseMove
        Menu_interactions.BackgroundImage = My.Resources.bbl_interaction_act
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

    Private Sub Text_menu_interactions_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_interactions.MouseLeave
        Menu_interactions.BackgroundImage = My.Resources.bbl_interaction
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

    Public Sub Hidemenu()
        TLSE_menu.Visible = False
        TLSE_menu_Miiedition.Visible = False
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
            Select_music.SelectedItem = My.Settings.Para_selmusic
        Catch ex As Exception
        End Try
        TLSE_language()
    End Sub

    Public Sub TLSE_language()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_menu_open.Text = "Open"
            Title_filever.Text = "Save file region :"
            Text_menu_travelersedit.Text = "Travelers edition" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Edit travelers in your island"
            Text_menu_extras.Text = "Extras" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit your island configurations"
            Text_menu_babiesedit.Text = "Babies edition" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit babies In your island"
            Text_menu_miiedit.Text = "Mii edition" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit Mii In your island"
            Text_menu_islandedit.Text = "Island edition" & vbNewLine & "_____________" & vbNewLine & vbNewLine & "Edit your island informations"
            Text_menu_miimanagement.Text = "Mii management" & vbNewLine & "____________________" & vbNewLine & vbNewLine & "Import And export Mii in your island"
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
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Tomodachi-Life-Save-Editor/master/Version_EX.txt")
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
    End Sub
End Class