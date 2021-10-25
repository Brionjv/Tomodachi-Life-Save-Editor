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
        TLSE_settings.Show()
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
        TLSE_relationships.Show()
        Me.Close()
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
End Class