﻿Imports PackageIO
Public Class Form1
    Dim filepath As String
    Dim money As String
    Dim IslN As String
    Dim Islp As String
    Dim Mii1L As String
    Dim Mii1P As String
    Dim Mii1N As String
    Dim Mii1S As String
    Dim Mii1C As String
    Dim Mii1PP As String
    Dim Mii1NP As String
    Dim Mii1SP As String
    Dim Mii1R As String
    Dim soucis As String
    Dim vrecu As String
    Dim weddi As String
    Dim born As String
    Dim vsent As String
    Dim stpass As String
    Dim bull1 As String
    Dim bull2 As String
    Dim bull3 As String
    Dim bull4 As String
    Dim fdialog As New Form3
    Dim bull5 As String
    Dim antiTT As String
    Dim objet1 As String
    Dim objet2 As String
    Dim objet3 As String
    Dim objet4 As String
    Dim objet5 As String
    Dim objet6 As String
    Dim objet7 As String
    Dim objet8 As String
    Dim exp As String
    Dim econom As String
    Dim fullness As String
    Dim eat As String
    Dim interieur As String
    Dim interieur1 As String
    Dim Sfoods As String
    Dim objdiv As String
    Dim appart As String
    Dim mair As String
    Dim info As String
    Dim classem As String
    Dim vet As String
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox11.Text = "EN"
        ComboBox12.SelectedItem = ComboBox12.Items.Item(0)
        ComboBox11.Text = My.Settings.Langue
        ComboBox12.Text = My.Settings.Sauve
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.Langue = ComboBox11.Text
        My.Settings.Sauve = ComboBox12.Text
        My.Settings.Save()
    End Sub
    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged
        If ComboBox11.Text = "FR" Then
            Button1.Text = "Ouvrir"
            Button2.Text = "Enregistrer"
            Button5.Text = "Ouvrir"
            Button6.Text = "Enregistrer"
            TabPage1.Text = "Principale"
            TabPage4.Text = "Édition Mii"
            TabPage3.Text = "Trésors / Nourritures"
            TabPage2.Text = "Réparation sauvegarde"
            GroupBox2.Text = "Problèmes résolus"
            GroupBox7.Text = "StreetPass reçus"
            GroupBox3.Text = "Mariages"
            GroupBox6.Text = "Nouveau né"
            GroupBox4.Text = "Voyageurs reçus"
            GroupBox5.Text = "Voyageurs envoyés"
            GroupBox101.Text = "Nom de l'île"
            GroupBox1.Text = "Argent"
            Label6.Text = "Prénom"
            Label8.Text = "Nom"
            Label8.Location = New Point(306, 42)
            Label10.Text = "Niv."
            Label9.Text = "Surnom"
            Label2.Text = "Créateur"
            Button3.Text = "Enreg. change. Mii"
            Button7.Text = "Enreg. change. Mii"
            Label5.Text = "Expression favorite"
            ComboBox2.Items.Item(0) = "Aucune parenté"
            ComboBox2.Items.Item(1) = "Moi-même"
            ComboBox2.Items.Item(2) = "Conjoint"
            ComboBox2.Items.Item(3) = "Parent"
            ComboBox2.Items.Item(4) = "Enfant"
            ComboBox2.Items.Item(5) = "Frère/sœur"
            ComboBox2.Items.Item(6) = "Famille"
            CheckBox15.Text = "Tous les vêtements Streetpass/Spotpass débloqués"
            CheckBox8.Text = "Tous les produits spéciaux débloqués"
            CheckBox17.Text = "Tous les chapeaux Streetpass/Spotpass débloqués"
            CheckBox9.Text = "Tous les chapeaux débloqués"
            CheckBox1.Text = "Tous les intérieurs débloqués"
            CheckBox2.Text = "Tous les objets divers débloqués"
            CheckBox5.Text = "Tous les trésors débloqués"
            CheckBox3.Text = "Tous les nourritures débloqués"
            CheckBox6.Text = "Tous les vêtements débloqués"
            CheckBox10.Text = "Si ''US tous les chapeaux débloqués'' a été utilisé"
            CheckBox11.Text = "Si ''US tous les produits spéciaux débloqués'' a été utilisé"
            CheckBox13.Text = "Si ''EU tous les chapeaux débloqués'' a été utilisé"
            CheckBox12.Text = "Si ''EU tous les produits spéciaux débloqués'' a été utilisé"
            GroupBox10.Text = "Réparation sauvegarde EU/JP"
            GroupBox11.Text = "Réparation sauvegarde US/JP"
            CheckBox14.Text = "Retirer pénalité de voyage dans le temps"
            Label3.Location = New Point(335, 13)
            Label13.Text = "Estomac"
            RadioButton2.Text = "il a pas mangé"
            ComboBox12.Items.Item(0) = "Sauvegarde US"
            ComboBox12.Items.Item(1) = "Sauvegarde EU"
            ComboBox12.Items.Item(2) = "Sauvegarde JP"
            Button4.Text = "Inventaire"
            TabPage6.Text = "Débloquer par nombres"
            TabPage7.Text = "Débloquer par catalogue magasin"
            TabPage8.Text = "Supprimer des éléments"
            TabPage9.Text = "Batiments île"
            CheckBox20.Text = "Tous les vêtements Streetpass/Spotpass débloqués"
            CheckBox19.Text = "Tous les chapeaux Streetpass/Spotpass débloqués"
            CheckBox18.Text = "Tous les chapeaux débloqués"
            CheckBox16.Text = "Tous les intérieurs débloqués"
            CheckBox7.Text = "Tous les nourritures débloqués"
            CheckBox4.Text = "Tous les vêtements débloqués"
            CheckBox22.Text = "Tous les vêtements Streetpass/Spotpass supprimés"
            CheckBox21.Text = "Tous les chapeaux Streetpass/Spotpass supprimés"
            CheckBox23.Text = "Tous les produits spéciaux supprimés"
            CheckBox24.Text = "Tous les chapeaux supprimés"
            CheckBox25.Text = "Tous les intérieurs supprimés"
            CheckBox26.Text = "Tous les objets divers supprimés"
            CheckBox27.Text = "Tous les trésors supprimés"
            CheckBox28.Text = "Tous les nourritures supprimés"
            CheckBox29.Text = "Tous les vêtements supprimés"
            CheckBox30.Text = "Réinitialiser StreetPass/Spotpass de Tomodachi Life"
            Label27.Location = New Point(396, 11)
        End If
        If ComboBox11.Text = "EN" Then
            Button1.Text = "Open"
            Button2.Text = "Save"
            Button5.Text = "Open"
            Button6.Text = "Save"
            TabPage1.Text = "Main"
            TabPage4.Text = "Mii Edit"
            TabPage3.Text = "Treasures / Foods"
            TabPage2.Text = "Repair save file"
            GroupBox2.Text = "Problems solved"
            GroupBox7.Text = "StreetPass encounters"
            GroupBox3.Text = "Weddings"
            GroupBox6.Text = "Children born"
            GroupBox4.Text = "Travelers received"
            GroupBox5.Text = "Travelers sent"
            GroupBox101.Text = "Island's name"
            GroupBox1.Text = "Money"
            Label6.Text = "First Name"
            Label8.Text = "Last Name"
            Label8.Location = New Point(296, 42)
            Label10.Text = "Lv."
            Label9.Text = "Nickname"
            Label2.Text = "Creator"
            Button3.Text = "Changes Mii save"
            Button7.Text = "Changes Mii save"
            Label5.Text = "Catchphrase"
            ComboBox2.Items.Item(0) = "Not related"
            ComboBox2.Items.Item(1) = "Self"
            ComboBox2.Items.Item(2) = "Spouse"
            ComboBox2.Items.Item(3) = "Parent"
            ComboBox2.Items.Item(4) = "Child"
            ComboBox2.Items.Item(5) = "Sibling"
            ComboBox2.Items.Item(6) = "Other relative"
            CheckBox15.Text = "All Streetpass/Spotpass Clothing and colors Unlocked"
            CheckBox8.Text = "All Special Foods Unlocked"
            CheckBox17.Text = "All Streetpass/Spotpass Headgears Unlocked"
            CheckBox9.Text = "All Headgears and colors Unlocked"
            CheckBox1.Text = "All Interiors Unlocked"
            CheckBox2.Text = "All Goods items Unlocked"
            CheckBox5.Text = "All Treasures Unlocked"
            CheckBox3.Text = "All Foods Unlocked"
            CheckBox6.Text = "All Clothing and colors Unlocked"
            CheckBox10.Text = "IF ''US All Headgears and Colors Unlocked'' was used"
            CheckBox11.Text = "IF ''US All Special Foods Unlocked'' was used"
            CheckBox13.Text = "IF ''EU All Headgears and Colors Unlocked'' was used"
            CheckBox12.Text = "IF ''EU All Special Foods Unlocked'' was used"
            GroupBox10.Text = "Repair EU/JP Save File"
            GroupBox11.Text = "Repair US/JP Save File"
            CheckBox14.Text = "Remove Time travel penality"
            Label3.Location = New Point(286, 13)
            Label13.Text = "Fullness"
            RadioButton2.Text = "He didn't eat"
            ComboBox12.Items.Item(0) = "US Save file"
            ComboBox12.Items.Item(1) = "EU Save file"
            ComboBox12.Items.Item(2) = "JP Save file"
            Button4.Text = "Inventory"
            TabPage6.Text = "Unlock by numbers"
            TabPage7.Text = "Unlock by shop catalog"
            TabPage8.Text = "Delete items"
            TabPage9.Text = "Island's buildings"
            CheckBox20.Text = "All Streetpass/Spotpass Clothing and colors Unlocked"
            CheckBox19.Text = "All Streetpass/Spotpass Headgears Unlocked"
            CheckBox18.Text = "All Headgears and colors Unlocked"
            CheckBox16.Text = "All Interiors Unlocked"
            CheckBox7.Text = "All Foods Unlocked"
            CheckBox4.Text = "All Clothing and colors Unlocked"
            CheckBox22.Text = "All Streetpass/Spotpass Clothing and colors deleted"
            CheckBox21.Text = "All Streetpass/Spotpass Headgears deleted"
            CheckBox23.Text = "All Special Foods deleted"
            CheckBox24.Text = "All Headgears and colors deleted"
            CheckBox25.Text = "All Interiors deleted"
            CheckBox26.Text = "All Goods items deleted"
            CheckBox27.Text = "All Treasures deleted"
            CheckBox28.Text = "All Foods deleted"
            CheckBox29.Text = "All Clothing and colors deleted"
            CheckBox30.Text = "Reset Tomodachi Life StreetPass/SpotPass"
            Label27.Location = New Point(362, 11)
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox6_MouseMove(sender As Object, e As EventArgs) Handles PictureBox6.MouseMove
        Label12.Visible = True
        Label12.Text = Label11.Text
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Island's name pronunciation"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer la prononciation du nom de l'île"
        End If
        Label17.Visible = True
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        Label12.Visible = False
        Label17.Visible = False
    End Sub

    Private Sub ComboBox12_MouseMove(sender As Object, e As EventArgs) Handles ComboBox12.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Change save file version"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Changer la version de la sauvegarde"
        End If
        Label17.Visible = True
    End Sub


    Private Sub ComboBox12_MouseLeave(sender As Object, e As EventArgs) Handles ComboBox12.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub ComboBox11_MouseMove(sender As Object, e As EventArgs) Handles ComboBox11.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Change Tomodachi Life Save Editor language"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Changer la langue de Tomodachi Life Save Editor"
        End If
        Label17.Visible = True
    End Sub

    Private Sub ComboBox11_MouseLeave(sender As Object, e As EventArgs) Handles ComboBox11.MouseLeave
        Label17.Visible = False
    End Sub


    Private Sub PictureBox32_MouseMove(sender As Object, e As EventArgs) Handles PictureBox32.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Mii's experience"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer l'expérience des Mii"
        End If
        Label17.Visible = True
    End Sub

    Private Sub PictureBox32_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox32.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub PictureBox35_MouseMove(sender As Object, e As EventArgs) Handles PictureBox35.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Mii's catchphrase"
            Label5.Text = "Catchphrase"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer l'expression favorite des Mii"
            Label5.Text = "Expression favorite"
        End If
        Label17.Visible = True
        Label5.Visible = True
    End Sub

    Private Sub PictureBox35_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox35.MouseLeave
        Label17.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As EventArgs) Handles PictureBox3.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Mii's first name pronunciation"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer la prononciation du prénom des Mii"
        End If
        Label14.Text = Label18.Text
        Label17.Visible = True
        Label14.Visible = True
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Label17.Visible = False
        Label14.Visible = False
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As EventArgs) Handles PictureBox5.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Mii's last name pronunciation"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer la prononciation du nom des Mii"
        End If
        Label15.Text = Label19.Text
        Label17.Visible = True
        Label15.Visible = True
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Label17.Visible = False
        Label15.Visible = False
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As EventArgs) Handles PictureBox4.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Nickname pronunciation can't be edit"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "La prononciation du surnom ne peut être édité"
        End If
        Label17.Visible = True
        Label16.Visible = True
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        Label17.Visible = False
        Label16.Visible = False
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As EventArgs) Handles Panel2.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Mii's gifts"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer les objets des Mii"
        End If
        Label17.Visible = True
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub PictureBox33_MouseMove(sender As Object, e As EventArgs) Handles PictureBox33.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Mii's fullness if they have already eaten"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer l'estomac des Mii si ils ont déjà mangé"
        End If
        Label17.Visible = True
    End Sub

    Private Sub PictureBox33_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox33.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As EventArgs) Handles Panel3.MouseMove, NumericUpDown8.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Edit to change number of items to be unlocked"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Éditez pour changer le nombre d'objets à débloqués"
        End If
        Label17.Visible = True
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave, NumericUpDown8.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub Button4_MouseMove(sender As Object, e As EventArgs) Handles Button4.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for edit Mii's inventory"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour éditer l'inventaire des Mii"
        End If
        Label17.Visible = True
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub RadioButton2_MouseMove(sender As Object, e As EventArgs) Handles RadioButton2.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Check for the selected Mii has not eaten"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cochez pour que le Mii sélectionné n'a pas mangé"
        End If
        Label17.Visible = True
    End Sub

    Private Sub RadioButton2_MouseLeave(sender As Object, e As EventArgs) Handles RadioButton2.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As EventArgs) Handles Label3.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "How to use ''Remove time travel penality''"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Comment utiliser ''Retirer pénalité de voyage dans le temps''"
        End If
        Label17.Visible = True
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub PictureBox34_MouseMove(sender As Object, e As EventArgs) Handles PictureBox34.MouseMove, NumericUpDown19.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Mii's economy"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Economie du Mii"
        End If
        Label17.Visible = True
    End Sub

    Private Sub PictureBox34_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox34.MouseLeave, NumericUpDown19.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub LinkLabel1_MouseMove(sender As Object, e As EventArgs) Handles LinkLabel1.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Click for see credits"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cliquez pour voir les crédits"
        End If
        Label17.Visible = True
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub GroupBox10_MouseMove(sender As Object, e As EventArgs) Handles GroupBox10.MouseMove, CheckBox10.MouseMove, CheckBox11.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Check for repair EU/JP save file"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cochez pour réparer une sauvegarde EU/JP"
        End If
        Label17.Visible = True
    End Sub

    Private Sub GroupeBox10_MouseLeave(sender As Object, e As EventArgs) Handles GroupBox10.MouseLeave, CheckBox10.MouseLeave, CheckBox11.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub GroupBox11_MouseMove(sender As Object, e As EventArgs) Handles GroupBox11.MouseMove, CheckBox12.MouseMove, CheckBox13.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "Check for repair US/JP save file"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Cochez pour réparer une sauvegarde US/JP"
        End If
        Label17.Visible = True
    End Sub

    Private Sub GroupeBox11_MouseLeave(sender As Object, e As EventArgs) Handles GroupBox11.MouseLeave, CheckBox12.MouseLeave, CheckBox13.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub Label27_MouseMove(sender As Object, e As EventArgs) Handles Label27.MouseMove
        If ComboBox11.Text = "EN" Then
            Label17.Text = "How to use ''Reset Tomodachi Life StreetPass/Spotpass''"
        End If
        If ComboBox11.Text = "FR" Then
            Label17.Text = "Comment utiliser ''Réinitialiser StreetPass/Spotpass de Tomodachi Life''"
        End If
        Label17.Visible = True
    End Sub

    Private Sub Label27_MouseLeave(sender As Object, e As EventArgs) Handles Label27.MouseLeave
        Label17.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        If ComboBox11.Text = "EN" Then
            fdialog.Label1.Text = "                    Open savedataArc.txt" & vbNewLine & "                Backup your save before use" & vbNewLine & "                 Tomodachi Life Save Editor"
            fdialog.Label1.Location = New Point(3, 24)
            fdialog.ShowDialog()
        End If
        If ComboBox11.Text = "FR" Then
            fdialog.Label1.Text = "                 Ouvrir savedataArc.txt" & vbNewLine & " Faites une copie de votre sauvegarde avant d'utiliser" & vbNewLine & "               Tomodachi Life Save Editor"
            fdialog.Label1.Location = New Point(3, 24)
            fdialog.ShowDialog()
        End If
        open.Title = "Open save savedataArc.txt"
        open.ShowDialog()
        filepath = open.FileName
        Readfile()
    End Sub
    Private Sub Readfile()
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            Reader.Position = &H1E4BB8
            money = Reader.Position
            NumericUpDown1.Value = Reader.ReadInt32

            Reader.Position = &H1E4BCC
            IslN = Reader.Position
            TextBox2.Text = Reader.ReadUnicodeString(10)

            Reader.Position = &H1E4BF6
            Islp = Reader.Position
            Label11.Text = Reader.ReadUnicodeString(20)

            Reader.Position = &H1E4BC6
            soucis = Reader.Position
            NumericUpDown2.Value = Reader.ReadInt16
            Reader.Position = &H1E4BBE
            vrecu = Reader.Position
            NumericUpDown6.Value = Reader.ReadInt16
            Reader.Position = &H1E4BC0
            weddi = Reader.Position
            NumericUpDown4.Value = Reader.ReadInt16
            Reader.Position = &H1E4BC2
            born = Reader.Position
            NumericUpDown5.Value = Reader.ReadInt16
            Reader.Position = &H1E4BC4
            vsent = Reader.Position
            NumericUpDown7.Value = Reader.ReadInt16
            Reader.Position = &H1E4BBC
            stpass = Reader.Position
            NumericUpDown3.Value = Reader.ReadInt16

            Reader.Position = &H1E4C20
            appart = Reader.Position
            NumericUpDown27.Value = Reader.ReadInt8
            Reader.Position = &H1E4C21
            mair = Reader.Position
            NumericUpDown28.Value = Reader.ReadInt8
            Reader.Position = &H1E4C22
            info = Reader.Position
            NumericUpDown25.Value = Reader.ReadInt8
            Reader.Position = &H1E4C23
            classem = Reader.Position
            NumericUpDown34.Value = Reader.ReadInt8
            Reader.Position = &H1E4C24
            vet = Reader.Position
            NumericUpDown10.Value = Reader.ReadInt8
            Reader.Position = &H1E4C25
            chap = Reader.Position
            NumericUpDown31.Value = Reader.ReadInt8
            Reader.Position = &H1E4C26
            epicer = Reader.Position
            NumericUpDown38.Value = Reader.ReadInt8
            Reader.Position = &H1E4C27
            deco = Reader.Position
            NumericUpDown22.Value = Reader.ReadInt8
            Reader.Position = &H1E4C28
            broc = Reader.Position
            NumericUpDown26.Value = Reader.ReadInt8
            Reader.Position = &H1E4C29
            magimport = Reader.Position
            NumericUpDown39.Value = Reader.ReadInt8
            Reader.Position = &H1E4C2A
            Fontai = Reader.Position
            NumericUpDown32.Value = Reader.ReadInt8
            Reader.Position = &H1E4C2B
            mais = Reader.Position
            NumericUpDown29.Value = Reader.ReadInt8
            Reader.Position = &H1E4C2C
            port = Reader.Position
            NumericUpDown42.Value = Reader.ReadInt8
            Reader.Position = &H1E4C2D
            tervague = Reader.Position
            NumericUpDown41.Value = Reader.ReadInt8
            Reader.Position = &H1E4C2E
            conc = Reader.Position
            NumericUpDown33.Value = Reader.ReadInt8
            Reader.Position = &H1E4C2F
            test = Reader.Position
            NumericUpDown35.Value = Reader.ReadInt8
            Reader.Position = &H1E4C30
            stud = Reader.Position
            NumericUpDown36.Value = Reader.ReadInt8
            Reader.Position = &H1E4C31
            plage = Reader.Position
            NumericUpDown40.Value = Reader.ReadInt8
            Reader.Position = &H1E4C32
            parc1 = Reader.Position
            NumericUpDown24.Value = Reader.ReadInt8
            Reader.Position = &H1E4C33
            cafe = Reader.Position
            NumericUpDown37.Value = Reader.ReadInt8
            Reader.Position = &H1E4C34
            parc = Reader.Position
            NumericUpDown30.Value = Reader.ReadInt8
            Reader.Position = &H1E4C35
            tour = Reader.Position
            NumericUpDown23.Value = Reader.ReadInt8
            Reader.Position = &H1E4C36
            part = Reader.Position
            NumericUpDown43.Value = Reader.ReadInt8
            ComboBox12.Enabled = False
        Catch ex As Exception
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                  savedataArc.txt not load," & vbNewLine & "  Save game is corrupted or not a Tomodachi Life Save"
                fdialog.Label1.Location = New Point(3, 30)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "         L'ouverture de savedataArc.txt a échoué," & vbNewLine & "               La sauvegarde est corrompu ou" & vbNewLine & "        n'est pas une sauvegarde de Tomodachi Life"
                fdialog.Label1.Location = New Point(3, 22)
                fdialog.ShowDialog()
            End If
            ComboBox12.Enabled = True
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim open As New OpenFileDialog
        If ComboBox11.Text = "EN" Then
            fdialog.Label1.Text = "                    Open savedataArc.txt" & vbNewLine & "                Backup your save before use" & vbNewLine & "                 Tomodachi Life Save Editor"
            fdialog.Label1.Location = New Point(3, 24)
            fdialog.ShowDialog()
        End If
        If ComboBox11.Text = "FR" Then
            fdialog.Label1.Text = "                 Ouvrir savedataArc.txt" & vbNewLine & " Faites une copie de votre sauvegarde avant d'utiliser" & vbNewLine & "               Tomodachi Life Save Editor"
            fdialog.Label1.Location = New Point(3, 24)
            fdialog.ShowDialog()
        End If
        open.Title = "Open save savedataArc.txt"
        open.ShowDialog()
        filepath = open.FileName
        ReadfileJP()
    End Sub
    Private Sub ReadfileJP()
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            Reader.Position = &H14BCA8
            money = Reader.Position
            NumericUpDown1.Value = Reader.ReadInt32
            Reader.Position = &H14BCBC
            IslN = Reader.Position
            TextBox2.Text = Reader.ReadUnicodeString(10)

            Reader.Position = &H14BCB6
            soucis = Reader.Position
            NumericUpDown2.Value = Reader.ReadInt16
            Reader.Position = &H14BCAE
            vrecu = Reader.Position
            NumericUpDown6.Value = Reader.ReadInt16
            Reader.Position = &H14BCB0
            weddi = Reader.Position
            NumericUpDown4.Value = Reader.ReadInt16
            Reader.Position = &H14BCB2
            born = Reader.Position
            NumericUpDown5.Value = Reader.ReadInt16
            Reader.Position = &H14BCB4
            vsent = Reader.Position
            NumericUpDown7.Value = Reader.ReadInt16
            Reader.Position = &H14BCAC
            stpass = Reader.Position
            NumericUpDown3.Value = Reader.ReadInt16

            Reader.Position = &H14BCF0
            appart = Reader.Position
            NumericUpDown27.Value = Reader.ReadInt8
            Reader.Position = &H14BCF1
            mair = Reader.Position
            NumericUpDown28.Value = Reader.ReadInt8
            Reader.Position = &H14BCF2
            info = Reader.Position
            NumericUpDown25.Value = Reader.ReadInt8
            Reader.Position = &H14BCF3
            classem = Reader.Position
            NumericUpDown34.Value = Reader.ReadInt8
            Reader.Position = &H14BCF4
            vet = Reader.Position
            NumericUpDown10.Value = Reader.ReadInt8
            Reader.Position = &H14BCF5
            chap = Reader.Position
            NumericUpDown31.Value = Reader.ReadInt8
            Reader.Position = &H14BCF6
            epicer = Reader.Position
            NumericUpDown38.Value = Reader.ReadInt8
            Reader.Position = &H14BCF7
            deco = Reader.Position
            NumericUpDown22.Value = Reader.ReadInt8
            Reader.Position = &H14BCF8
            broc = Reader.Position
            NumericUpDown26.Value = Reader.ReadInt8
            Reader.Position = &H14BCF9
            magimport = Reader.Position
            NumericUpDown39.Value = Reader.ReadInt8
            Reader.Position = &H14BCFA
            fontai = Reader.Position
            NumericUpDown32.Value = Reader.ReadInt8
            Reader.Position = &H14BCFB
            mais = Reader.Position
            NumericUpDown29.Value = Reader.ReadInt8
            Reader.Position = &H14BCFC
            port = Reader.Position
            NumericUpDown42.Value = Reader.ReadInt8
            Reader.Position = &H14BCFD
            tervague = Reader.Position
            NumericUpDown41.Value = Reader.ReadInt8
            Reader.Position = &H14BCFE
            conc = Reader.Position
            NumericUpDown33.Value = Reader.ReadInt8
            Reader.Position = &H14BCFF
            test = Reader.Position
            NumericUpDown35.Value = Reader.ReadInt8
            Reader.Position = &H14BD00
            stud = Reader.Position
            NumericUpDown36.Value = Reader.ReadInt8
            Reader.Position = &H14BD01
            plage = Reader.Position
            NumericUpDown40.Value = Reader.ReadInt8
            Reader.Position = &H14BD02
            parc1 = Reader.Position
            NumericUpDown24.Value = Reader.ReadInt8
            Reader.Position = &H14BD03
            cafe = Reader.Position
            NumericUpDown37.Value = Reader.ReadInt8
            Reader.Position = &H14BD04
            parc = Reader.Position
            NumericUpDown30.Value = Reader.ReadInt8
            ComboBox12.Enabled = False
        Catch ex As Exception
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                  savedataArc.txt not load," & vbNewLine & "  Save game is corrupted or not a Tomodachi Life Save"
                fdialog.Label1.Location = New Point(3, 30)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "         L'ouverture de savedataArc.txt a échoué," & vbNewLine & "              La sauvegarde est corrompue ou" & vbNewLine & "        n'est pas une sauvegarde de Tomodachi Life"
                fdialog.Label1.Location = New Point(3, 22)
                fdialog.ShowDialog()
            End If
            ComboBox12.Enabled = True
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WriteFile()
    End Sub
    Private Sub WriteFile()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = money
            Writer.WriteInt32(NumericUpDown1.Value)
            For i As Integer = 0 To 19
                Writer.Position = IslN + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IslN
            Writer.WriteUnicodeString(TextBox2.Text)
            For i As Integer = 0 To 39
                Writer.Position = Islp + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Islp
            Writer.WriteUnicodeString(Label11.Text)
            Writer.Position = soucis
            Writer.WriteInt16(NumericUpDown2.Value)
            Writer.Position = vrecu
            Writer.WriteInt16(NumericUpDown6.Value)
            Writer.Position = weddi
            Writer.WriteInt16(NumericUpDown4.Value)
            Writer.Position = born
            Writer.WriteInt16(NumericUpDown5.Value)
            Writer.Position = vsent
            Writer.WriteInt16(NumericUpDown7.Value)
            Writer.Position = stpass
            Writer.WriteInt16(NumericUpDown3.Value)
            Writer.Position = appart
            Writer.WriteInt8(NumericUpDown27.Value)
            Writer.Position = mair
            Writer.WriteInt8(NumericUpDown28.Value)
            Writer.Position = info
            Writer.WriteInt8(NumericUpDown25.Value)
            Writer.Position = classem
            Writer.WriteInt8(NumericUpDown34.Value)
            Writer.Position = vet
            Writer.WriteInt8(NumericUpDown10.Value)
            Writer.Position = chap
            Writer.WriteInt8(NumericUpDown31.Value)
            Writer.Position = epicer
            Writer.WriteInt8(NumericUpDown38.Value)
            Writer.Position = deco
            Writer.WriteInt8(NumericUpDown22.Value)
            Writer.Position = broc
            Writer.WriteInt8(NumericUpDown26.Value)
            Writer.Position = magimport
            Writer.WriteInt8(NumericUpDown39.Value)
            Writer.Position = fontai
            Writer.WriteInt8(NumericUpDown32.Value)
            Writer.Position = mais
            Writer.WriteInt8(NumericUpDown29.Value)
            Writer.Position = port
            Writer.WriteInt8(NumericUpDown42.Value)
            Writer.Position = tervague
            Writer.WriteInt8(NumericUpDown41.Value)
            Writer.Position = conc
            Writer.WriteInt8(NumericUpDown33.Value)
            Writer.Position = test
            Writer.WriteInt8(NumericUpDown35.Value)
            Writer.Position = stud
            Writer.WriteInt8(NumericUpDown36.Value)
            Writer.Position = plage
            Writer.WriteInt8(NumericUpDown40.Value)
            Writer.Position = parc1
            Writer.WriteInt8(NumericUpDown24.Value)
            Writer.Position = cafe
            Writer.WriteInt8(NumericUpDown37.Value)
            Writer.Position = parc
            Writer.WriteInt8(NumericUpDown30.Value)
            Writer.Position = tour
            Writer.WriteInt8(NumericUpDown23.Value)
            Writer.Position = part
            Writer.WriteInt8(NumericUpDown43.Value)

            Writer.Position = &H0
            Writer.WriteInt8(17)
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                   Sauvegarde enregistré"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                          File Save"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                  Une erreur est survenue"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                   An error has occurred"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        End Try
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WriteFileJP()
    End Sub
    Private Sub WriteFileJP()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = money
            Writer.WriteInt32(NumericUpDown1.Value)
            For i As Integer = 0 To 19
                Writer.Position = IslN + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IslN
            Writer.WriteUnicodeString(TextBox2.Text)
            Writer.Position = soucis
            Writer.WriteInt16(NumericUpDown2.Value)
            Writer.Position = vrecu
            Writer.WriteInt16(NumericUpDown6.Value)
            Writer.Position = weddi
            Writer.WriteInt16(NumericUpDown4.Value)
            Writer.Position = born
            Writer.WriteInt16(NumericUpDown5.Value)
            Writer.Position = vsent
            Writer.WriteInt16(NumericUpDown7.Value)
            Writer.Position = stpass
            Writer.WriteInt16(NumericUpDown3.Value)

            Writer.Position = appart
            Writer.WriteInt8(NumericUpDown27.Value)
            Writer.Position = mair
            Writer.WriteInt8(NumericUpDown28.Value)
            Writer.Position = info
            Writer.WriteInt8(NumericUpDown25.Value)
            Writer.Position = classem
            Writer.WriteInt8(NumericUpDown34.Value)
            Writer.Position = vet
            Writer.WriteInt8(NumericUpDown10.Value)
            Writer.Position = chap
            Writer.WriteInt8(NumericUpDown31.Value)
            Writer.Position = epicer
            Writer.WriteInt8(NumericUpDown38.Value)
            Writer.Position = deco
            Writer.WriteInt8(NumericUpDown22.Value)
            Writer.Position = broc
            Writer.WriteInt8(NumericUpDown26.Value)
            Writer.Position = magimport
            Writer.WriteInt8(NumericUpDown39.Value)
            Writer.Position = fontai
            Writer.WriteInt8(NumericUpDown32.Value)
            Writer.Position = mais
            Writer.WriteInt8(NumericUpDown29.Value)
            Writer.Position = port
            Writer.WriteInt8(NumericUpDown42.Value)
            Writer.Position = tervague
            Writer.WriteInt8(NumericUpDown41.Value)
            Writer.Position = conc
            Writer.WriteInt8(NumericUpDown33.Value)
            Writer.Position = test
            Writer.WriteInt8(NumericUpDown35.Value)
            Writer.Position = stud
            Writer.WriteInt8(NumericUpDown36.Value)
            Writer.Position = plage
            Writer.WriteInt8(NumericUpDown40.Value)
            Writer.Position = parc1
            Writer.WriteInt8(NumericUpDown24.Value)
            Writer.Position = cafe
            Writer.WriteInt8(NumericUpDown37.Value)
            Writer.Position = parc
            Writer.WriteInt8(NumericUpDown30.Value)
            Writer.Position = &H0
            Writer.WriteInt8(17)

            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                   Sauvegarde enregistré"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                          File Save"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                  Une erreur est survenue"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                   An error has occurred"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form4.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form5.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 102
                    Writer.Position = &H1778 + i
                    Writer.WriteInt8(NumericUpDown8.Value)
                Next
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox1.Checked = False
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Try
            If CheckBox2.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 17
                    Writer.Position = &H18F0 + i
                    Writer.WriteInt8(NumericUpDown8.Value)
                Next
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox2.Checked = False
        End Try
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Try
            If CheckBox5.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 165
                    Writer.Position = &H1902 + i
                    Writer.WriteInt8(NumericUpDown8.Value)
                Next
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox5.Checked = False
        End Try
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox8.CheckedChanged
        Try
            If CheckBox8.Checked = True Then
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H1A14
                    Writer.WriteInt8(NumericUpDown8.Value)
                    For i As Integer = 0 To 46
                        Writer.Position = &H1A16 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H19E2
                    Writer.WriteInt8(NumericUpDown8.Value)
                    For i As Integer = 0 To 46
                        Writer.Position = &H19E4 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox8.Checked = False
        End Try
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Try
            If CheckBox3.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 230
                    Writer.Position = &H17F0 + i
                    Writer.WriteInt8(NumericUpDown8.Value)
                Next
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox3.Checked = False
        End Try
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Try
            If CheckBox6.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 3575
                    Writer.Position = &H30 + i
                    Writer.WriteInt8(NumericUpDown8.Value)
                Next
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox6.Checked = False
        End Try
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        Try
            If CheckBox9.Checked = True Then
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 38
                        Writer.Position = &HFF8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1020 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 13
                        Writer.Position = &H1030 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1040 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1058 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1060 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1088 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 15
                        Writer.Position = &H10C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H10F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1100 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1120 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 29
                        Writer.Position = &H1130 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1150 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1158 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 3
                        Writer.Position = &H1160 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1168 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 13
                        Writer.Position = &H1170 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 31
                        Writer.Position = &H1180 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 29
                        Writer.Position = &H1130 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 38
                        Writer.Position = &H11A8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 22
                        Writer.Position = &H11D0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H11E8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 12
                        Writer.Position = &H11F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 14
                        Writer.Position = &H1200 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1210 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 31
                        Writer.Position = &H1218 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 29
                        Writer.Position = &H1240 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    Writer.Position = &H1260
                    Writer.WriteInt8(NumericUpDown8.Value)

                    For i As Integer = 0 To 46
                        Writer.Position = &H1268 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1298 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 14
                        Writer.Position = &H12A0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 70
                        Writer.Position = &H12B0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H12F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 29
                        Writer.Position = &H1300 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1320 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 46
                        Writer.Position = &H1328 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1358 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 12
                        Writer.Position = &H1360 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 13
                        Writer.Position = &H1370 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1390 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 30
                        Writer.Position = &H1398 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 13
                        Writer.Position = &H13B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 30
                        Writer.Position = &H13C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H13E8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H13F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 14
                        Writer.Position = &H13F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1410 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1418 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1420 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 12
                        Writer.Position = &H1430 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 3
                        Writer.Position = &H1440 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 11
                        Writer.Position = &H1448 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1458 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1460 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1468 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 47
                        Writer.Position = &H1490 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H14D0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 11
                        Writer.Position = &H14E0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H14F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H14F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1508 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1510 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1518 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 8
                        Writer.Position = &H1530 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 21
                        Writer.Position = &H1550 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1568 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1570 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1578 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1580 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1588 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1598 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H15B0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H15C0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H15C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 15
                        Writer.Position = &H15D8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H15F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1618 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1618 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1650 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1668 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1670 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1678 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1680 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1688 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1698 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H16A0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H16A8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H16B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H16C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 47
                        Writer.Position = &HFF8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 13
                        Writer.Position = &H1030 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1040 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1058 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1060 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1080 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 15
                        Writer.Position = &H10C0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H10F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1108 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1128 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 29
                        Writer.Position = &H1138 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1158 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1160 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 3
                        Writer.Position = &H1168 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1170 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 39
                        Writer.Position = &H1178 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 38
                        Writer.Position = &H11A8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 22
                        Writer.Position = &H11D0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H11E8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 12
                        Writer.Position = &H11F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 14
                        Writer.Position = &H1200 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1210 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 31
                        Writer.Position = &H1218 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 29
                        Writer.Position = &H1240 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    Writer.Position = &H1260
                    Writer.WriteInt8(NumericUpDown8.Value)

                    For i As Integer = 0 To 46
                        Writer.Position = &H1268 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1298 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 14
                        Writer.Position = &H12A0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 70
                        Writer.Position = &H12B0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H12F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 29
                        Writer.Position = &H1300 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1320 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 46
                        Writer.Position = &H1328 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1358 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 12
                        Writer.Position = &H1360 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 13
                        Writer.Position = &H1370 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1390 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 30
                        Writer.Position = &H1398 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 13
                        Writer.Position = &H13B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 30
                        Writer.Position = &H13C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H13E8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H13F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 14
                        Writer.Position = &H13F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1410 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1418 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1420 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 12
                        Writer.Position = &H1430 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 3
                        Writer.Position = &H1440 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 11
                        Writer.Position = &H1448 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1458 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1460 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H1468 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 47
                        Writer.Position = &H1490 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H14D0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 11
                        Writer.Position = &H14E0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H14F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H14F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1508 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1510 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1518 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 8
                        Writer.Position = &H1530 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 21
                        Writer.Position = &H1550 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1568 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 14
                        Writer.Position = &H1570 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1580 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1588 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H1598 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H15B0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H15C0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H15C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H15D8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H15E0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H15F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1618 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1650 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H1668 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1670 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1678 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1680 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1688 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 5
                        Writer.Position = &H1698 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H16A0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 4
                        Writer.Position = &H16A8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 6
                        Writer.Position = &H16B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next

                    For i As Integer = 0 To 7
                        Writer.Position = &H16C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox9.Checked = False
        End Try
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        Try
            If CheckBox17.Checked = True Then
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 7
                        Writer.Position = &HFF8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1020 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1088 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 5
                        Writer.Position = &H1178 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H11B0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H11F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H1228 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1270 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H12C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H12D8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H12F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H12F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1300 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H1358 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 5
                        Writer.Position = &H1378 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 3
                        Writer.Position = &H1440 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 5
                        Writer.Position = &H1458 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H1578 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 7
                        Writer.Position = &H1020 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1080 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 5
                        Writer.Position = &H1180 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H11F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1228 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H12C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H12D8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H12F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H12F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H1358 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 5
                        Writer.Position = &H1378 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 5
                        Writer.Position = &H13C0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 3
                        Writer.Position = &H1440 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1468 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H1578 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H1588 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &H1668 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox17.Checked = False
        End Try
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        Try
            If CheckBox15.Checked = True Then
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 7
                        Writer.Position = &H60 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HC8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H100 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H138 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H160 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H180 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H190 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1D8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H250 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H280 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H2B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H2F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 4
                        Writer.Position = &H328 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H60 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H460 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H478 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 4
                        Writer.Position = &H490 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H500 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H518 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 4
                        Writer.Position = &H5A0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H5B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H650 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H660 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H6E0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H720 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H7A0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H7B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H848 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H868 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H8E0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H8F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H918 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H968 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H988 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H9B0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H9C0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H9F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HA08 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HA38 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 31
                        Writer.Position = &HA70 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 4
                        Writer.Position = &HAF8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &HB08 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HB68 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &HCA0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HD28 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HE18 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
                If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 7
                        Writer.Position = &H40 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H80 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    Writer.Position = &HC8
                    Writer.WriteInt8(NumericUpDown8.Value)
                    Writer.Position = &HC9
                    Writer.WriteInt8(NumericUpDown8.Value)
                    For i As Integer = 0 To 7
                        Writer.Position = &HD0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H108 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H168 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H188 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H198 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H1E0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H258 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H288 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H2C8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H2D8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H308 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H480 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 4
                        Writer.Position = &H498 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H4C0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H4F8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H508 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H520 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H538 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H568 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 4
                        Writer.Position = &H5A0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H5B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H660 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H670 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &H6F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H730 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 5
                        Writer.Position = &H7B0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H7B8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H7D0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H860 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H880 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H8F0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H900 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H928 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H978 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H998 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H9C0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &H9D0 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HA00 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HA10 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HA40 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 31
                        Writer.Position = &HA78 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 4
                        Writer.Position = &HB00 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &HB10 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HB70 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 15
                        Writer.Position = &HD88 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 6
                        Writer.Position = &HDA8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                    For i As Integer = 0 To 7
                        Writer.Position = &HDD8 + i
                        Writer.WriteInt8(NumericUpDown8.Value)
                    Next
                End If
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            CheckBox15.Checked = False
        End Try
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 46
                Writer.Position = &HFF8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 12
                Writer.Position = &H1030 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1040 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1058 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1060 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1080 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 14
                Writer.Position = &H10C0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H10F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1108 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1128 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 28
                Writer.Position = &H1138 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1158 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1160 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1168 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1170 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 38
                Writer.Position = &H1178 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 37
                Writer.Position = &H11A8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 21
                Writer.Position = &H11D0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H11E8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 11
                Writer.Position = &H11F0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H1200 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1210 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 30
                Writer.Position = &H1218 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 28
                Writer.Position = &H1240 + i
                Writer.WriteUInt16(65021)
            Next

            Writer.Position = &H1260
            Writer.WriteUInt16(65021)

            For i As Integer = 0 To 45
                Writer.Position = &H1268 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1298 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H12A0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 69
                Writer.Position = &H12B0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H12F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 28
                Writer.Position = &H1300 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1320 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 45
                Writer.Position = &H1328 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1358 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 11
                Writer.Position = &H1360 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H1370 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1390 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 29
                Writer.Position = &H1398 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 12
                Writer.Position = &H13B8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 29
                Writer.Position = &H13C8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H13E8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H13F0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H13F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1410 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1418 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1420 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 11
                Writer.Position = &H1430 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1440 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 10
                Writer.Position = &H1448 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1458 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1460 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 7
                Writer.Position = &H1468 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 46
                Writer.Position = &H1490 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H14D0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 10
                Writer.Position = &H14E0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H14F0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H14F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1508 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1510 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1518 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 7
                Writer.Position = &H1530 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 20
                Writer.Position = &H1550 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1568 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H1570 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1580 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1588 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1598 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H15B0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H15C0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H15C8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H15D8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H15E0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H15F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1618 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1650 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1668 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1670 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1678 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1680 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1688 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1698 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H16A0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H16A8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H16B8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H16C8 + i
                Writer.WriteUInt16(65021)
            Next
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                  Some headgears were lost" & vbNewLine & "       Try to unlock all with ''EU save file'' setting"
                fdialog.Label1.Location = New Point(3, 30)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "            Certains chapeaux ont été perdus" & vbNewLine & "             Essayez de tout débloquer avec" & vbNewLine & "             les paramètres ''Sauvegarde EU''"
                fdialog.Label1.Location = New Point(3, 24)
                fdialog.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H19E2
            Writer.WriteUInt16(65021)
            For i As Integer = 0 To 45
                Writer.Position = &H19E4 + i
                Writer.WriteUInt16(65021)
            Next
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 37
                Writer.Position = &HFF8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1020 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 12
                Writer.Position = &H1030 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1040 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1058 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1060 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1088 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 14
                Writer.Position = &H10C8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H10F0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1100 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1120 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 28
                Writer.Position = &H1130 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1150 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1158 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 2
                Writer.Position = &H1160 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1168 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 12
                Writer.Position = &H1170 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 30
                Writer.Position = &H1180 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 28
                Writer.Position = &H1130 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 37
                Writer.Position = &H11A8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 21
                Writer.Position = &H11D0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H11E8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 11
                Writer.Position = &H11F0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H1200 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1210 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 30
                Writer.Position = &H1218 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 28
                Writer.Position = &H1240 + i
                Writer.WriteUInt16(65021)
            Next

            Writer.Position = &H1260
            Writer.WriteUInt16(65021)

            For i As Integer = 0 To 45
                Writer.Position = &H1268 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1298 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H12A0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 69
                Writer.Position = &H12B0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H12F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 28
                Writer.Position = &H1300 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1320 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 45
                Writer.Position = &H1328 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1358 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 11
                Writer.Position = &H1360 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 12
                Writer.Position = &H1370 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1390 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 29
                Writer.Position = &H1398 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 12
                Writer.Position = &H13B8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 29
                Writer.Position = &H13C8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H13E8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H13F0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 13
                Writer.Position = &H13F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1410 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1418 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1420 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 11
                Writer.Position = &H1430 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 2
                Writer.Position = &H1440 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 10
                Writer.Position = &H1448 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1458 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1460 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H1468 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 46
                Writer.Position = &H1490 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H14D0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 10
                Writer.Position = &H14E0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H14F0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H14F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1508 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1510 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1518 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 7
                Writer.Position = &H1530 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 20
                Writer.Position = &H1550 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1568 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1570 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1578 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1580 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1588 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H1598 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H15B0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H15C0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H15C8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 14
                Writer.Position = &H15D8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H15F8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1618 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1618 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1650 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H1668 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1670 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1678 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1680 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1688 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 4
                Writer.Position = &H1698 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H16A0 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 3
                Writer.Position = &H16A8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 5
                Writer.Position = &H16B8 + i
                Writer.WriteUInt16(65021)
            Next

            For i As Integer = 0 To 6
                Writer.Position = &H16C8 + i
                Writer.WriteUInt16(65021)
            Next
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                  Some headgears were lost" & vbNewLine & "       Try to unlock all with ''US save file'' setting"
                fdialog.Label1.Location = New Point(3, 30)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "            Certains chapeaux ont été perdus" & vbNewLine & "             Essayez de tout débloquer avec" & vbNewLine & "             les paramètres ''Sauvegarde US''"
                fdialog.Label1.Location = New Point(3, 24)
                fdialog.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H1A14
            Writer.WriteUInt16(65021)
            For i As Integer = 0 To 45
                Writer.Position = &H1A16 + i
                Writer.WriteUInt16(65021)
            Next
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H1E4C70
                Writer.WriteInt8(64)
                If ComboBox11.Text = "EN" Then
                    fdialog.Label1.Text = "           Time travel penality has been removed"
                    fdialog.Label1.Location = New Point(3, 35)
                    fdialog.ShowDialog()
                End If
                    If ComboBox11.Text = "FR" Then
                        fdialog.Label1.Text = "     La pénalité de voyage dans le temps a été retiré"
                        fdialog.Label1.Location = New Point(3, 35)
                        fdialog.ShowDialog()
                    End If
                End If

            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H1E4C70
                Writer.WriteInt8(64)
                If ComboBox11.Text = "EN" Then
                    fdialog.Label1.Text = "           Time travel penality has been removed"
                    fdialog.Label1.Location = New Point(3, 35)
                    fdialog.ShowDialog()
                End If
                If ComboBox11.Text = "FR" Then
                    fdialog.Label1.Text = "     La pénalité de voyage dans le temps a été retiré"
                    fdialog.Label1.Location = New Point(3, 35)
                    fdialog.ShowDialog()
                End If
            End If

            If ComboBox12.SelectedItem = ComboBox12.Items.Item(2) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H14BD40
                Writer.WriteInt8(64)
                If ComboBox11.Text = "EN" Then
                    fdialog.Label1.Text = "           Time travel penality has been removed"
                    fdialog.Label1.Location = New Point(3, 35)
                    fdialog.ShowDialog()
                End If
                If ComboBox11.Text = "FR" Then
                    fdialog.Label1.Text = "     La pénalité de voyage dans le temps a été retiré"
                    fdialog.Label1.Location = New Point(3, 35)
                    fdialog.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(0) Then
            NumericUpDown9.Value = 0
        End If
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(1) Then
            NumericUpDown9.Value = 1
        End If
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(2) Then
            NumericUpDown9.Value = 2
        End If
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(3) Then
            NumericUpDown9.Value = 3
        End If
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(4) Then
            NumericUpDown9.Value = 4
        End If
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(5) Then
            NumericUpDown9.Value = 5
        End If
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(6) Then
            NumericUpDown9.Value = 6
        End If
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        If NumericUpDown9.Value = 0 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(0)
        End If
        If NumericUpDown9.Value = 1 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(1)
        End If
        If NumericUpDown9.Value = 2 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(2)
        End If
        If NumericUpDown9.Value = 3 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(3)
        End If
        If NumericUpDown9.Value = 4 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(4)
        End If
        If NumericUpDown9.Value = 5 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(5)
        End If
        If NumericUpDown9.Value = 6 Then
            ComboBox2.SelectedItem = ComboBox2.Items.Item(6)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
        Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
        If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
        If ComboBox1.Text = "Mii 1" Then
            Reader.Position = &H1CD0
            Mii1P = Reader.Position
            TextBox3.Text = Reader.ReadUnicodeString(15)
            Reader.Position = &H1CF0
            Mii1N = Reader.Position
            TextBox4.Text = Reader.ReadUnicodeString(15)
            Reader.Position = &H1C8A
            Mii1S = Reader.Position
            TextBox5.Text = Reader.ReadUnicodeString(10)
            Reader.Position = &H1F23
            Mii1L = Reader.Position
            NumericUpDown102.Value = Reader.ReadInt8
            Reader.Position = &H1E92
            Mii1PP = Reader.Position
            Label18.Text = Reader.ReadUnicodeString(30)
            Reader.Position = &H1ED4
            Mii1NP = Reader.Position
            Label19.Text = Reader.ReadUnicodeString(30)
            Reader.Position = &H1E50
            Mii1SP = Reader.Position
            Label16.Text = Reader.ReadUnicodeString(20)
            Reader.Position = &H1F2D
            Mii1R = Reader.Position
            NumericUpDown9.Value = Reader.ReadInt8
            Reader.Position = &H1CB8
            Mii1C = Reader.Position
            TextBox9.Text = Reader.ReadUnicodeString(10)

            Reader.Position = &H1D20
            bull1 = Reader.Position
            Label20.Text = Reader.ReadUnicodeString(16)
            Reader.Position = &H1DC4
            bull2 = Reader.Position
            Label21.Text = Reader.ReadUnicodeString(16)
            Reader.Position = &H1DE6
            bull3 = Reader.Position
            Label22.Text = Reader.ReadUnicodeString(16)
            Reader.Position = &H1E08
            bull4 = Reader.Position
            Label23.Text = Reader.ReadUnicodeString(16)
            Reader.Position = &H1E2A
            bull5 = Reader.Position
            Label24.Text = Reader.ReadUnicodeString(16)

            Reader.Position = &H2258
            objet1 = Reader.Position
            NumericUpDown11.Value = Reader.ReadUInt16
            Reader.Position = &H225A
            objet2 = Reader.Position
            NumericUpDown12.Value = Reader.ReadUInt16
            Reader.Position = &H225C
            objet3 = Reader.Position
            NumericUpDown13.Value = Reader.ReadUInt16
            Reader.Position = &H225E
            objet4 = Reader.Position
            NumericUpDown14.Value = Reader.ReadUInt16
            Reader.Position = &H2260
            objet5 = Reader.Position
            NumericUpDown18.Value = Reader.ReadUInt16
            Reader.Position = &H2262
            objet6 = Reader.Position
            NumericUpDown17.Value = Reader.ReadUInt16
            Reader.Position = &H2264
            objet7 = Reader.Position
            NumericUpDown16.Value = Reader.ReadUInt16
            Reader.Position = &H2266
            objet8 = Reader.Position
            NumericUpDown15.Value = Reader.ReadUInt16

            Reader.Position = &H1F22
            exp = Reader.Position
            NumericUpDown20.Value = Reader.ReadInt8
            Reader.Position = &H1F28
            econom = Reader.Position
            NumericUpDown19.Value = Reader.ReadInt32

            Reader.Position = &H2272
            eat = Reader.Position
            Reader.Position = &H2293
            fullness = Reader.Position
            NumericUpDown21.Value = Reader.ReadInt8
            Reader.Position = &H1F59
            interieur = Reader.Position
            Reader.Position = &H1F64
            interieur1 = Reader.Position
            Reader.Position = &H1F68
            Sfoods = Reader.Position
            Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1F50
            objdiv = Reader.Position
            Label26.Text = "Label26"
        End If

            If ComboBox1.Text = "Mii 2" Then
                Reader.Position = &H2330
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2350
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H22EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H2583
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H24F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H2534
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H24B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H258D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H2318
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H2380
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2424
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2446
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2468
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H248A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H28B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H28BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H28BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H28BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H28C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H28C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H28C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H28C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H2582
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H2588
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H28D2
                eat = Reader.Position
                Reader.Position = &H28F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H25B9
                interieur = Reader.Position
                Reader.Position = &H25C4
                interieur1 = Reader.Position
                Reader.Position = &H25C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H25B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 3" Then

                Reader.Position = &H2990
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H29B0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H294A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H2BE3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H2B52
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H2B94
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H2B10
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2BED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H2978
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H29E0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2A84
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2AA6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2AC8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2AEA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H2F18
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2F1A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2F1C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2F1E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2F20
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2F22
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2F24
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2F26
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H2BE2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H2BE8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H2F32
                eat = Reader.Position
                Reader.Position = &H2F53
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H2C19
                interieur = Reader.Position
                Reader.Position = &H2C24
                interieur1 = Reader.Position
                Reader.Position = &H2C28
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H2C10
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 4" Then

                Reader.Position = &H2FF0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H3010
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2FAA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H3243
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H31B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H31F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H3170
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H324D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H2FD8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H3040
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H30E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3106
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3128
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H314A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H3578
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H357A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H357C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H357E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H3580
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H3582
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H3584
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H3586
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H3242
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H3248
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H3592
                eat = Reader.Position
                Reader.Position = &H35B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H3279
                interieur = Reader.Position
                Reader.Position = &H3284
                interieur1 = Reader.Position
                Reader.Position = &H3288
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H3270
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 5" Then

                Reader.Position = &H3650
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H3670
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H360A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H38A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H3812
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H3854
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H37D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H38AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H3638
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H36A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3744
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3766
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3788
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H37AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H3BD8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H3BDA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H3BDC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H3BDE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H3BE0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H3BE2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H3BE4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H3BE6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H38A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H38A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H3BF2
                eat = Reader.Position
                Reader.Position = &H3C13
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H38D9
                interieur = Reader.Position
                Reader.Position = &H38E4
                interieur1 = Reader.Position
                Reader.Position = &H38E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H38D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 6" Then

                Reader.Position = &H3CB0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H3CD0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H3C6A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H3F03
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H3E72
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H3EB4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H3E30
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H3F0D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H3C98
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H3D00
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3DA4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3DC6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3DE8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H3E0A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H4238
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H423A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H423C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H423E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H4240
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H4242
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H4244
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H4246
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H3F02
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H3F08
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H4252
                eat = Reader.Position
                Reader.Position = &H4273
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H3F39
                interieur = Reader.Position
                Reader.Position = &H3F44
                interieur1 = Reader.Position
                Reader.Position = &H3F48
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H3F30
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 7" Then

                Reader.Position = &H4310
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H4330
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H42CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H4563
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H44D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H4514
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H4490
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H456D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H42F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H4360
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H4404
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H4426
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H4448
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H446A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H4898
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H489A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H489C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H489E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H48A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H48A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H48A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H48A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H4562
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H4568
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H48B2
                eat = Reader.Position
                Reader.Position = &H48D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H4599
                interieur = Reader.Position
                Reader.Position = &H45A4
                interieur1 = Reader.Position
                Reader.Position = &H45A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H4590
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 8" Then

                Reader.Position = &H4970
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H4990
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H492A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H4BC3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H4B32
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H4B74
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H4AF0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H4BCD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H4958
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H49C0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H4A64
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H4A86
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H4AA8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H4ACA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H4EF8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H4EFA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H4EFC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H4EFE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H4F00
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H4F02
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H4F04
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H4F06
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H4BC2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H4BC8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H4F12
                eat = Reader.Position
                Reader.Position = &H4F33
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H4BF9
                interieur = Reader.Position
                Reader.Position = &H4C04
                interieur1 = Reader.Position
                Reader.Position = &H4C08
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H4BF0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 9" Then

                Reader.Position = &H4FD0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H4FF0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H4F8A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H5223
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H5192
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H51D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H5150
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H522D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H4FB8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H5020
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H50C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H50E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5108
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H512A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H5558
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H555A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H555C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H555E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H5560
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H5562
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H5564
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H5566
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H5222
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H5228
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H5572
                eat = Reader.Position
                Reader.Position = &H5593
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H5259
                interieur = Reader.Position
                Reader.Position = &H5264
                interieur1 = Reader.Position
                Reader.Position = &H5268
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H5250
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 10" Then

                Reader.Position = &H5630
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H5650
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H55EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H5883
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H57F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H5834
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H57B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H588D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H5618
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H5680
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5724
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5746
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5768
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H578A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H5BB8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H5BBA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H5BBC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H5BBE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H5BC0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H5BC2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H5BC4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H5BC6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H5882
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H5888
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H5BD2
                eat = Reader.Position
                Reader.Position = &H5BF3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H58B9
                interieur = Reader.Position
                Reader.Position = &H58C4
                interieur1 = Reader.Position
                Reader.Position = &H58C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H58B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 11" Then

                Reader.Position = &H5C90
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H5CB0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H5C4A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H5EE3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H5E52
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H5E94
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H5E10
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H5EED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H5C78
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H5CE0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5D84
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5DA6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5DD8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H5DFA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H6218
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H621A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H621C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H621E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H6220
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H6222
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H6224
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H6226
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H5EE2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H5EE8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H6232
                eat = Reader.Position
                Reader.Position = &H6253
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H5F19
                interieur = Reader.Position
                Reader.Position = &H5F24
                interieur1 = Reader.Position
                Reader.Position = &H5F28
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H5F10
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 12" Then

                Reader.Position = &H62F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H6310
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H62AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H6543
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H64B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H64F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H6470
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H654D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H62D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H6340
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H63E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H6406
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H6428
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H644A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H6878
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H687A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H687C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H687E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H6880
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H6882
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H6884
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H6886
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H6542
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H6548
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H6892
                eat = Reader.Position
                Reader.Position = &H68B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H6579
                interieur = Reader.Position
                Reader.Position = &H6584
                interieur1 = Reader.Position
                Reader.Position = &H6588
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H6570
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 13" Then

                Reader.Position = &H6950
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H6970
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H690A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H6BA3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H6B12
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H6B54
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H6AD0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H6BAD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H6938
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H69A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H6A44
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H6A66
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H6A88
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H6AAA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H6ED8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H6EDA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H6EDC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H6EDE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H6EE0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H6EE2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H6EE4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H6EE6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H6BA2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H6BA8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H6EF2
                eat = Reader.Position
                Reader.Position = &H6F13
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H6BD9
                interieur = Reader.Position
                Reader.Position = &H6BE4
                interieur1 = Reader.Position
                Reader.Position = &H6BE8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H6BD0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 14" Then

                Reader.Position = &H6FB0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H6FD0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H6F6A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H7203
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H7172
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H71B4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H7130
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H720D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H6F98
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H7000
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H70A4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H70C6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H70E8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H710A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H7538
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H753A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H753C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H753E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H7540
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H7542
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H7544
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H7546
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H7202
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H7208
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H7552
                eat = Reader.Position
                Reader.Position = &H7573
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H7229
                interieur = Reader.Position
                Reader.Position = &H7234
                interieur1 = Reader.Position
                Reader.Position = &H7238
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H7220
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 15" Then

                Reader.Position = &H7610
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H7630
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H75CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H7863
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H77D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H7814
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H7790
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H786D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H75F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H7660
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H7704
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H7726
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H7748
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H776A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H7B98
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H7B9A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H7B9C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H7B9E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H7BA0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H7BA2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H7BA4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H7BA6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H7862
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H7868
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H7BB2
                eat = Reader.Position
                Reader.Position = &H7BD3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H7899
                interieur = Reader.Position
                Reader.Position = &H78A4
                interieur1 = Reader.Position
                Reader.Position = &H78A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H7890
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 16" Then

                Reader.Position = &H7C70
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H7C90
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H7C2A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H7EC3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H7E32
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H7E74
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H7DF0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H7ECD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H7C58
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H7CC0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H7D64
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H7D86
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H7DA8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H7DCA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H81F8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H81FA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H81FC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H81FE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H8200
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H8202
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H8204
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H8206
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H7EC2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H7EC8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H8212
                eat = Reader.Position
                Reader.Position = &H8233
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H7EF9
                interieur = Reader.Position
                Reader.Position = &H7F04
                interieur1 = Reader.Position
                Reader.Position = &H7F08
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H7EF0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 17" Then

                Reader.Position = &H82D0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H82F0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H828A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H8523
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H8492
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H84D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H8450
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H852D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H82B8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H8320
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H83C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H83E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H8408
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H842A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H8858
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H885A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H885C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H885E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H8860
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H8862
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H8864
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H8866
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H8522
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H8528
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H8872
                eat = Reader.Position
                Reader.Position = &H8893
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H8559
                interieur = Reader.Position
                Reader.Position = &H8564
                interieur1 = Reader.Position
                Reader.Position = &H8568
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H8550
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 18" Then

                Reader.Position = &H8930
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H8950
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H88EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H8B83
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H8AF2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H8B34
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H8AB0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H8B8D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H8918
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H8980
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H8A24
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H8A46
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H8A68
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H8A8A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H8EB8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H8EBA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H8EBC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H8EBE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H8EC0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H8EC2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H8EC4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H8EC6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H8B82
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H8B88
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H8ED2
                eat = Reader.Position
                Reader.Position = &H8EF3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H8BB9
                interieur = Reader.Position
                Reader.Position = &H8BC4
                interieur1 = Reader.Position
                Reader.Position = &H8BC8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H8BB0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 19" Then

                Reader.Position = &H8F90
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H8FB0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H8F4A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H91E3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H9152
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H9194
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H9110
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H91ED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H8F78
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H8FE0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H9084
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H90A6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H90C8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H90EA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H9518
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H951A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H951C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H951E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H9520
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H9522
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H9524
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H9526
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H91E2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H91E8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H9532
                eat = Reader.Position
                Reader.Position = &H9553
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H9219
                interieur = Reader.Position
                Reader.Position = &H9224
                interieur1 = Reader.Position
                Reader.Position = &H9228
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H9210
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 20" Then

                Reader.Position = &H95F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H9610
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H95AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H9843
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H97B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H97F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H9770
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H984D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H95D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H9640
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H96E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H9706
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H9728
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H974A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H9B78
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H9B7A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H9B7C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H9B7E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H9B80
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H9B82
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H9B84
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H9B86
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H9842
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H9848
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H9B92
                eat = Reader.Position
                Reader.Position = &H9BB3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H9879
                interieur = Reader.Position
                Reader.Position = &H9884
                interieur1 = Reader.Position
                Reader.Position = &H9888
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H9870
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 21" Then

                Reader.Position = &H9C50
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H9C70
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H9C0A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H9EA3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H9E12
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H9E54
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H9DD0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H9EAD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H9C38
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H9CA0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H9D44
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H9D66
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H9D88
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H9DAA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HA1D8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HA1DA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HA1DC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HA1DE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HA1E0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HA1E2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HA1E4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HA1E6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H9EA2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H9EA8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HA1F82
                eat = Reader.Position
                Reader.Position = &HA1FA3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H9ED9
                interieur = Reader.Position
                Reader.Position = &H9EE4
                interieur1 = Reader.Position
                Reader.Position = &H9EE8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H9ED0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 22" Then

                Reader.Position = &HA2B0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HA2D0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HA26A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HA503
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HA472
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HA4B4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HA430
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HA50D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HA298
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HA300
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HA3A4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HA3C6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HA3E8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HA40A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HA838
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HA83A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HA83C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HA83E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HA840
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HA842
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HA844
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HA846
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HA502
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HA508
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HA852
                eat = Reader.Position
                Reader.Position = &HA873
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HA539
                interieur = Reader.Position
                Reader.Position = &HA544
                interieur1 = Reader.Position
                Reader.Position = &HA548
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HA530
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 23" Then

                Reader.Position = &HA910
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HA930
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HA8CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HAB63
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HAAD2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HAB14
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HAA90
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HAB6D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HA8F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HA960
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HAA04
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HAA26
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HAA48
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HAA6A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HAE98
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HAE9A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HAE9C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HAE9E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HAEA0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HAEA2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HAEA4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HAEA6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HAB62
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HAB68
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HAEB2
                eat = Reader.Position
                Reader.Position = &HAED3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HAB99
                interieur = Reader.Position
                Reader.Position = &HABA4
                interieur1 = Reader.Position
                Reader.Position = &HABA8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HAB90
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 24" Then

                Reader.Position = &HAF70
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HAF90
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HAF2A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HB1C3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HB132
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HB174
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HB0F0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HB1CD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HAF58
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HAFC0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB064
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB086
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB0A8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB0CA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HB4F8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HB4FA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HB4FC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HB4FE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HB500
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HB502
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HB504
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HB506
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HB1C2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HB1C8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HB512
                eat = Reader.Position
                Reader.Position = &HB533
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HB1F9
                interieur = Reader.Position
                Reader.Position = &HB204
                interieur1 = Reader.Position
                Reader.Position = &HB208
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HB1F0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 25" Then

                Reader.Position = &HB5D0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HB5F0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HB58A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HB823
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HB792
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HB7D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HB750
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HB82D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HB5B8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HB620
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB6C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB6E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB708
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HB72A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HBB58
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HBB5A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HBB5C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HBB5E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HBB60
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HBB62
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HBB64
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HBB66
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HB822
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HB828
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HBB72
                eat = Reader.Position
                Reader.Position = &HBB93
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HB859
                interieur = Reader.Position
                Reader.Position = &HB864
                interieur1 = Reader.Position
                Reader.Position = &HB868
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HB850
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 26" Then

                Reader.Position = &HBC30
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HBC50
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HBBEA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HBE83
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HBDF2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HBE34
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HBDB0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HBE8D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HBC18
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HBC80
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HBD24
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HBD46
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HBD68
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HBD8A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HC1B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HC1BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HC1BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HC1BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HC1C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HC1C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HC1C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HC1C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HBE82
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HBE88
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HC1D2
                eat = Reader.Position
                Reader.Position = &HC1F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HBEB9
                interieur = Reader.Position
                Reader.Position = &HBEC4
                interieur1 = Reader.Position
                Reader.Position = &HBEC8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HBEB0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 27" Then

                Reader.Position = &HC290
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HC2B0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HC24A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HC4E3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HC452
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HC494
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HC410
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HC4ED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HC278
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HC2E0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HC384
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HC3A6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HC3C8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HC3EA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HC818
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HC81A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HC81C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HC81E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HC820
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HC822
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HC824
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HC826
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HC4E2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HC4E8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HC832
                eat = Reader.Position
                Reader.Position = &HC853
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HC519
                interieur = Reader.Position
                Reader.Position = &HC524
                interieur1 = Reader.Position
                Reader.Position = &HC528
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HC510
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 28" Then

                Reader.Position = &HC8F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HC910
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HC8AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HCB43
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HCAB2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HCAF4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HCA70
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HCB4D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HC8D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HC940
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HC9E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HCA06
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HCA28
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HCA4A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HCE78
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HCE7A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HCE7C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HCE7E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HCE80
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HCE82
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HCE84
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HCE86
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HCB42
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HCB48
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HCE92
                eat = Reader.Position
                Reader.Position = &HCEB3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HCB79
                interieur = Reader.Position
                Reader.Position = &HCB84
                interieur1 = Reader.Position
                Reader.Position = &HCB88
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HCB70
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 29" Then

                Reader.Position = &HCF50
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HCF70
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HCF0A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HD1A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HD112
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HD154
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HD0D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HD1AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HCF38
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HCFA0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD044
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD066
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD088
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD0AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HD4D8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HD4DA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HD4DC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HD4DE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HD4E0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HD4E2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HD4E4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HD4E6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HD1A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HD1A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HD4F2
                eat = Reader.Position
                Reader.Position = &HD513
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HD1D9
                interieur = Reader.Position
                Reader.Position = &HD1E4
                interieur1 = Reader.Position
                Reader.Position = &HD1E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HD1D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 30" Then

                Reader.Position = &HD5B0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HD5D0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HD56A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HD803
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HD772
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HD7B4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HD730
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HD80D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HD598
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HD600
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD6A4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD6C6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD6E8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HD70A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HDB38
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HDB3A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HDB3C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HDB3E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HDB40
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HDB42
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HDB44
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HDB46
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HD802
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HD808
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HDB52
                eat = Reader.Position
                Reader.Position = &HDB73
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HD839
                interieur = Reader.Position
                Reader.Position = &HD844
                interieur1 = Reader.Position
                Reader.Position = &HD848
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HD830
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 31" Then

                Reader.Position = &HDC10
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HDC30
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HDBCA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HDE63
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HDDD2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HDE14
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HDD90
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HDE6D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HDBF8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HDC60
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HDD04
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HDD26
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HDD48
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HDD6A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HE198
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HE19A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HE19C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HE19E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HE1A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HE1A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HE1A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HE1A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HDE62
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HDE68
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HE1B2
                eat = Reader.Position
                Reader.Position = &HE1D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HDE99
                interieur = Reader.Position
                Reader.Position = &HDEA4
                interieur1 = Reader.Position
                Reader.Position = &HDEA8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HDE90
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 32" Then

                Reader.Position = &HE270
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HE290
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HE22A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HE4C3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HE432
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HE474
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HE3F0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HE4CD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HE258
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HE2C0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HE364
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HE386
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HE3A8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HE3CA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HE7F8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HE7FA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HE7FC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HE7FE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HE800
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HE802
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HE804
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HE806
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HE4C2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HE4C8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HE812
                eat = Reader.Position
                Reader.Position = &HE833
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HE4F9
                interieur = Reader.Position
                Reader.Position = &HE504
                interieur1 = Reader.Position
                Reader.Position = &HE508
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HE4F0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 33" Then

                Reader.Position = &HE8D0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HE8F0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HE88A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HEB23
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HEA92
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HEAD4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HEA50
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HEB2D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HE8B8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HE920
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HE9C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HE9E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HEA08
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HEA2A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HEE58
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HEE5A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HEE5C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HEE5E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HEE60
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HEE62
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HEE64
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HEE66
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HEB22
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HEB28
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HEE72
                eat = Reader.Position
                Reader.Position = &HEE93
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HEB59
                interieur = Reader.Position
                Reader.Position = &HEB64
                interieur1 = Reader.Position
                Reader.Position = &HEB68
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HEB50
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 34" Then

                Reader.Position = &HEF30
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HEF50
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HEEEA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HF183
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HF0F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HF134
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HF0B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HF18D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HEF18
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HEF80
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF024
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF046
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF068
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF08A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HF4B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HF4BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HF4BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HF4BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HF4C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HF4C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HF4C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HF4C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HF182
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HF188
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HF4D2
                eat = Reader.Position
                Reader.Position = &HF4F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HF1B9
                interieur = Reader.Position
                Reader.Position = &HF1C4
                interieur1 = Reader.Position
                Reader.Position = &HF1C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HF1B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 35" Then

                Reader.Position = &HF590
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HF5B0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HF54A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HF7E3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HF752
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HF794
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HF710
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HF7ED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HF578
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HF5E0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF684
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF6A6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF6C8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HF6EA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &HFB18
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &HFB1A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &HFB1C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &HFB1E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &HFB20
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &HFB22
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &HFB24
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &HFB26
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HF7E2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HF7E8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &HFB32
                eat = Reader.Position
                Reader.Position = &HFB53
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HF819
                interieur = Reader.Position
                Reader.Position = &HF824
                interieur1 = Reader.Position
                Reader.Position = &HF828
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HF810
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 36" Then

                Reader.Position = &HFBF0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HFC10
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &HFBAA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &HFE43
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &HFDB2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HFDF4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &HFD70
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &HFE4D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &HFBD8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &HFC40
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HFCE4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HFD06
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HFD28
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &HFD4A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H10178
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1017A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1017C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1017E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H10180
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H10182
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H10184
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H10186
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &HFE42
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &HFE48
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H10192
                eat = Reader.Position
                Reader.Position = &H101B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &HFE79
                interieur = Reader.Position
                Reader.Position = &HFE84
                interieur1 = Reader.Position
                Reader.Position = &HFE88
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &HFE70
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 37" Then

                Reader.Position = &H10250
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H10270
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1020A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H104A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H10412
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H10454
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H103D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H104AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H10238
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H102A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H10344
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H10366
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H10388
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H103AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H107D8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H107DA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H107DC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H107DE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H107E0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H107E2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H107E4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H107E6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H104A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H104A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H107F2
                eat = Reader.Position
                Reader.Position = &H10813
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H104D9
                interieur = Reader.Position
                Reader.Position = &H104E4
                interieur1 = Reader.Position
                Reader.Position = &H104E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H104D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 38" Then

                Reader.Position = &H108B0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H108D0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1086A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H10B03
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H10A72
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H10AB4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H10A30
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H10B0D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H10898
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H10900
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H109A4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H109C6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H109E8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H10A0A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H10E38
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H10E3A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H10E3C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H10E3E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H10E40
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H10E42
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H10E44
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H10E46
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H10B02
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H10B08
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H10E52
                eat = Reader.Position
                Reader.Position = &H10E73
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H10B39
                interieur = Reader.Position
                Reader.Position = &H10B44
                interieur1 = Reader.Position
                Reader.Position = &H10B48
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H10B30
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 39" Then

                Reader.Position = &H10F10
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H10F30
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H10ECA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H11163
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H110D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H11114
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H11090
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1116D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H10EF8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H10F60
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11004
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11026
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11048
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1106A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H11498
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1149A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1149C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1149E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H114A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H114A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H114A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H114A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H11162
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H11168
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H114B2
                eat = Reader.Position
                Reader.Position = &H114D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H11199
                interieur = Reader.Position
                Reader.Position = &H111A4
                interieur1 = Reader.Position
                Reader.Position = &H111A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H11190
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 40" Then

                Reader.Position = &H11570
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H11590
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1152A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H117C3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H11732
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H11774
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H116F0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H117CD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H11558
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H115C0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11664
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11686
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H116A8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H116CA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H11AF8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H11AFA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H11AFC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H11AFE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H11B00
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H11B02
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H11B04
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H11B06
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H117C2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H117C8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H11B12
                eat = Reader.Position
                Reader.Position = &H11B33
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H117F9
                interieur = Reader.Position
                Reader.Position = &H11804
                interieur1 = Reader.Position
                Reader.Position = &H11808
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H117F0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 41" Then

                Reader.Position = &H11BD0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H11BF0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H11B8A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H11E23
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H11D92
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H11DD4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H11D50
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H11E2D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H11BB8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H11C20
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11CC4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11CE6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11D08
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H11D2A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H12158
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1215A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1215C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1215E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H12160
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H12162
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H12164
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H12166
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H11E22
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H11E28
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H12172
                eat = Reader.Position
                Reader.Position = &H12193
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H11E59
                interieur = Reader.Position
                Reader.Position = &H11E64
                interieur1 = Reader.Position
                Reader.Position = &H11E68
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H11E50
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 42" Then

                Reader.Position = &H12230
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H12250
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H121EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H12483
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H123F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H12434
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H123B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1248D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H12218
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H12280
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H12324
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H12346
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H12368
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1238A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H127B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H127BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H127BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H127BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H127C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H127C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H127C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H127C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H12482
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H12488
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H127D2
                eat = Reader.Position
                Reader.Position = &H127F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H124B9
                interieur = Reader.Position
                Reader.Position = &H124C4
                interieur1 = Reader.Position
                Reader.Position = &H124C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H124B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 43" Then

                Reader.Position = &H12890
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H128B0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1284A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H12AE3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H12A52
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H12A94
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H12A10
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H12AED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H12878
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H128E0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H12984
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H129A6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H129C8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H129EA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H12E18
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H12E1A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H12E1C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H12E1E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H12E20
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H12E22
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H12E24
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H12E26
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H12AE2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H12AE8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H12E32
                eat = Reader.Position
                Reader.Position = &H12E53
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H12B19
                interieur = Reader.Position
                Reader.Position = &H12B24
                interieur1 = Reader.Position
                Reader.Position = &H12B28
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H12B10
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 44" Then

                Reader.Position = &H12EF0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H12F10
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H12EAA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H13143
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H130B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H130F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H13070
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1314D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H12ED8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H12F40
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H12FE4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13006
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13028
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1304A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H13478
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1347A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1347C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1347E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H13480
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H13482
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H13484
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H13486
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H13142
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H13148
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H13492
                eat = Reader.Position
                Reader.Position = &H134B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H13179
                interieur = Reader.Position
                Reader.Position = &H13184
                interieur1 = Reader.Position
                Reader.Position = &H13188
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H13170
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 45" Then

                Reader.Position = &H13550
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H13570
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1350A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H137A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H13712
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H13754
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H136D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H137AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H13538
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H135A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13644
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13666
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13688
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H136AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H13AD8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H13ADA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H13ADC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H13ADE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H13AE0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H13AE2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H13AE4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H13AE6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H137A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H137A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H13AF2
                eat = Reader.Position
                Reader.Position = &H13B03
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H137D9
                interieur = Reader.Position
                Reader.Position = &H137E4
                interieur1 = Reader.Position
                Reader.Position = &H137E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H137D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 46" Then

                Reader.Position = &H13BB0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H13BD0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H13B6A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H13E03
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H13D72
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H13DB4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H13D30
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H13E0D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H13B98
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H13C00
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13CA4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13CC6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13CE8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H13D0A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H14138
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1413A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1413C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1413E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H14140
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H14142
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H14144
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H14146
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H13E02
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H13E08
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H14152
                eat = Reader.Position
                Reader.Position = &H14173
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H13E39
                interieur = Reader.Position
                Reader.Position = &H13E44
                interieur1 = Reader.Position
                Reader.Position = &H13E48
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H13E30
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 47" Then

                Reader.Position = &H14210
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H14230
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H141CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H14463
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H143D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H14414
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H14390
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1446D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H141F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H14260
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H14304
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H14326
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H14348
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1436A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H14798
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1479A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1479C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1479E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H147A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H147A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H147A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H147A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H14462
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H14468
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H147B2
                eat = Reader.Position
                Reader.Position = &H147D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H14499
                interieur = Reader.Position
                Reader.Position = &H144A4
                interieur1 = Reader.Position
                Reader.Position = &H144A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H14490
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 48" Then

                Reader.Position = &H14870
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H14890
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1482A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H14AC3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H14A32
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H14A74
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H149F0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H14ACD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H14858
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H148C0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H14964
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H14986
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H149A8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H149CA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H14DF8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H14DFA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H14DFC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H14DFE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H14E00
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H14E02
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H14E04
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H14E06
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H14AC2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H14AC8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H14E12
                eat = Reader.Position
                Reader.Position = &H14E33
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H14AF9
                interieur = Reader.Position
                Reader.Position = &H14B04
                interieur1 = Reader.Position
                Reader.Position = &H14B08
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H14AF0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 49" Then

                Reader.Position = &H14ED0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H14EF0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H14E8A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H15123
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H15092
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H150D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H15050
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1512D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H14EB8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H14F20
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H14FC4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H14FE6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15008
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1502A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H15458
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1545A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1545C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1545E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H15460
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H15462
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H15464
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H15466
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H15122
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H15128
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H15472
                eat = Reader.Position
                Reader.Position = &H15493
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H15159
                interieur = Reader.Position
                Reader.Position = &H15164
                interieur1 = Reader.Position
                Reader.Position = &H15168
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H15150
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 50" Then

                Reader.Position = &H15530
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H15550
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H154EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H15783
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H156F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H15734
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H156B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1578D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H15518
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H15580
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15624
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15646
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15668
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1568A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H15AB8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H15ABA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H15ABC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H15ABE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H15AC0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H15AC2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H15AC4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H15AC6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H15782
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H15788
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H15AD2
                eat = Reader.Position
                Reader.Position = &H15AF3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H157B9
                interieur = Reader.Position
                Reader.Position = &H157C4
                interieur1 = Reader.Position
                Reader.Position = &H157C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H157B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 51" Then

                Reader.Position = &H15B90
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H15BB0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H15B4A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H15DE3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H15D52
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H15D94
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H15D10
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H15DED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H15B78
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H15BE0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15C84
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15CA6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15CC8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H15CEA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H16118
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1611A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1611C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1611E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H16120
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H16122
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H16124
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H16126
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H15DE2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H15DE8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H16132
                eat = Reader.Position
                Reader.Position = &H16153
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H15E19
                interieur = Reader.Position
                Reader.Position = &H15E24
                interieur1 = Reader.Position
                Reader.Position = &H15E28
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H15E10
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 52" Then

                Reader.Position = &H161F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H16210
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H161AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H16443
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H163B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H163F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H16370
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1644D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H161D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H16240
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H162E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16306
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16328
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1634A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H16778
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1677A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1677C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1677E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H16780
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H16782
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H16784
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H16786
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H16442
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H16448
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H16792
                eat = Reader.Position
                Reader.Position = &H167B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H16479
                interieur = Reader.Position
                Reader.Position = &H16484
                interieur1 = Reader.Position
                Reader.Position = &H16488
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H16470
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 53" Then

                Reader.Position = &H16850
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H16870
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1680A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H16AA3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H16A12
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H16A54
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H169D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H16AAD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H16838
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H168A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16944
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16966
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16988
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H169AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H16DD8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H16DDA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H16DDC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H16DDE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H16DE0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H16DE2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H16DE4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H16DE6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H16AA2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H16AA8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H16DF2
                eat = Reader.Position
                Reader.Position = &H16E13
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H16AD9
                interieur = Reader.Position
                Reader.Position = &H16AE4
                interieur1 = Reader.Position
                Reader.Position = &H16AE8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H16AD0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 54" Then

                Reader.Position = &H16EB0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H16ED0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H16E6A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H17103
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H17072
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H170B4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H17030
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1710D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H16E98
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H16F00
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16FA4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16FC6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H16FE8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1700A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H17438
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1743A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1743C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1743E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H17440
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H17442
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H17444
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H17446
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H17102
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H17108
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H17452
                eat = Reader.Position
                Reader.Position = &H17473
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H17139
                interieur = Reader.Position
                Reader.Position = &H17144
                interieur1 = Reader.Position
                Reader.Position = &H17148
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H17130
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 55" Then

                Reader.Position = &H17510
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H17530
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H174CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H17763
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H176D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H17714
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H17690
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1776D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H174F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H17560
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H17604
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H17626
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H17648
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1766A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H17A98
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H17A9A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H17A9C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H17A9E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H17AA0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H17AA2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H17AA4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H17AA6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H17762
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H17768
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H17AB2
                eat = Reader.Position
                Reader.Position = &H17AD3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H17799
                interieur = Reader.Position
                Reader.Position = &H177A4
                interieur1 = Reader.Position
                Reader.Position = &H177A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H17790
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 56" Then

                Reader.Position = &H17B70
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H17B90
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H17B2A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H17DC3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H17D32
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H17D74
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H17CF0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H17DCD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B58
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H17BC0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H17C64
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H17C86
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H17CA8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H17CCA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H180F8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H180FA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H180FC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H180FE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H18100
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H18102
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H18104
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H18106
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H17DC2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H17DC8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H18112
                eat = Reader.Position
                Reader.Position = &H18133
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H17DF9
                interieur = Reader.Position
            Reader.Position = &H17E04
                interieur1 = Reader.Position
            Reader.Position = &H17E08
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H17DF0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 57" Then

                Reader.Position = &H181D0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H181F0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1818A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H18423
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H18392
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H183D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H18350
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1842D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H181B8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H18220
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H182C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H182E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18308
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1832A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H18758
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1875A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1875C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1875E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H18760
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H18762
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H18764
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H18766
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H18422
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H18428
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H18772
                eat = Reader.Position
                Reader.Position = &H18793
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H18459
                interieur = Reader.Position
                Reader.Position = &H18464
                interieur1 = Reader.Position
                Reader.Position = &H18468
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H18450
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 58" Then

                Reader.Position = &H18830
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H18850
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H187EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H18A83
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H189F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H18A34
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H189B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H18A8D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H18818
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H18880
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18924
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18946
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18968
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1898A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H18DB8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H18DBA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H18DBC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H18DBE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H18DC0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H18DC2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H18DC4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H18DC6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H18A82
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H18A88
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H18DD2
                eat = Reader.Position
                Reader.Position = &H18DF3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H18AB9
                interieur = Reader.Position
                Reader.Position = &H18AC4
                interieur1 = Reader.Position
                Reader.Position = &H18AC8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H18AB0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 59" Then

                Reader.Position = &H18E90
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H18EB0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H18E4A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H190E3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H19052
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H19094
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H19010
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H190ED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H18E78
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H18EE0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18F84
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18FA6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18FC8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H18FEA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H19418
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1941A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1941C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1941E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H19420
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H19422
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H19424
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H19426
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H190E2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H190E8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H19432
                eat = Reader.Position
                Reader.Position = &H19453
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H19119
                interieur = Reader.Position
                Reader.Position = &H19124
                interieur1 = Reader.Position
                Reader.Position = &H19128
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H19110
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 60" Then

                Reader.Position = &H194F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H19510
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H194AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H19743
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H196B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H196F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H19670
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1974D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H194D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H19540
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H195E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H19606
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H19628
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1964A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H19A78
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H19A7A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H19A7C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H19A7E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H19A80
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H19A82
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H19A84
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H19A86
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H19742
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H19748
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H19A92
                eat = Reader.Position
                Reader.Position = &H19AB3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H19779
                interieur = Reader.Position
                Reader.Position = &H19784
                interieur1 = Reader.Position
                Reader.Position = &H19788
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H19770
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 61" Then

                Reader.Position = &H19B50
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H19B70
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H19B0A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H19DA3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H19D12
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H19D54
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H19CD0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H19DAD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H19B38
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H19BA0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H19C44
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H19C66
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H19C88
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H19CAA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1A0D8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1A0DA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1A0DC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1A0DE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1A0E0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1A0E2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1A0E4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1A0E6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H19DA2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H19DA8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1A0F2
                eat = Reader.Position
                Reader.Position = &H1A113
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H19DD9
                interieur = Reader.Position
                Reader.Position = &H19DE4
                interieur1 = Reader.Position
                Reader.Position = &H19DE8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H19DD0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 62" Then

                Reader.Position = &H1A1B0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1A1D0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1A16A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1A403
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1A372
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1A3B4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1A330
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1A40D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1A198
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1A200
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A2A4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A2C6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A2E8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A30A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1A738
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1A73A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1A73C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1A73E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1A740
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1A742
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1A744
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1A746
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1A402
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1A408
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1A752
                eat = Reader.Position
                Reader.Position = &H1A773
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1A439
                interieur = Reader.Position
                Reader.Position = &H1A444
                interieur1 = Reader.Position
                Reader.Position = &H1A448
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1A430
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 63" Then

                Reader.Position = &H1A810
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1A830
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1A7CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1AA63
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1A9D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1AA14
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1A990
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1AA6D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1A7F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1A860
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A904
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A926
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A948
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1A96A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1AD98
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1AD9A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1AD9C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1AD9E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1ADA0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1ADA2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1ADA4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1ADA6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1AA62
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1AA68
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1ADB2
                eat = Reader.Position
                Reader.Position = &H1ADD3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1AA99
                interieur = Reader.Position
                Reader.Position = &H1AAA4
                interieur1 = Reader.Position
                Reader.Position = &H1AAA8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1AA90
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 64" Then

                Reader.Position = &H1AE70
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1AE90
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1AE2A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1B0C3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1B032
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1B074
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1AFF0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1B0CD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1AE58
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1AEC0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1AF64
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1AF86
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1AFA8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1AFCA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1B3F8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1B3FA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1B3FC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1B3FE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1B400
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1B402
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1B404
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1B406
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1B0C2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1B0C8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1B412
                eat = Reader.Position
                Reader.Position = &H1B433
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1B0F9
                interieur = Reader.Position
                Reader.Position = &H1B104
                interieur1 = Reader.Position
                Reader.Position = &H1B108
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1B0F0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 65" Then

                Reader.Position = &H1B4D0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1B4F0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1B48A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1B723
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1B692
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1B6D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1B650
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1B72D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1B4B8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1B520
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1B5C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1B5E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1B608
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1B62A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1BA58
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1BA5A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1BA5C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1BA5E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1BA60
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1BA62
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1BA64
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1BA66
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1B722
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1B728
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1BA72
                eat = Reader.Position
                Reader.Position = &H1BA93
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1B759
                interieur = Reader.Position
                Reader.Position = &H1B764
                interieur1 = Reader.Position
                Reader.Position = &H1B768
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1B750
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 66" Then

                Reader.Position = &H1BB30
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1BB50
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1BAEA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1BD83
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1BCF2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1BD34
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1BCB0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1BD8D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1BB18
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1BB80
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1BC24
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1BC46
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1BC68
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1BC8A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1C0B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1C0BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1C0BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1C0BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1C0C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1C0C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1C0C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1C0C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1BD82
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1BD88
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1C0D2
                eat = Reader.Position
                Reader.Position = &H1C0F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1BDB9
                interieur = Reader.Position
                Reader.Position = &H1BDC4
                interieur1 = Reader.Position
                Reader.Position = &H1BDC8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1BDB0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 67" Then

                Reader.Position = &H1C190
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C1B0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C14A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C3E3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1C352
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1C394
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1C310
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1C3ED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1C178
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1C1E0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C284
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C2A6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C2C8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C2EA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1C718
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1C71A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1C71C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1C71E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1C720
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1C722
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1C724
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1C726
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1C3E2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1C3E8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1C732
                eat = Reader.Position
                Reader.Position = &H1C753
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1C419
                interieur = Reader.Position
                Reader.Position = &H1C424
                interieur1 = Reader.Position
                Reader.Position = &H1C428
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1C410
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 68" Then

                Reader.Position = &H1C7F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C810
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C7AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1CA43
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1C9B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1C9F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1C970
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1CA4D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1C7D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1C840
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C8E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C906
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C928
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1C94A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1CD78
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1CD7A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1CD7C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1CD7E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1CD80
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1CD82
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1CD84
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1CD86
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1CA42
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1CA48
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1CD92
                eat = Reader.Position
                Reader.Position = &H1CDB3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1CA79
                interieur = Reader.Position
                Reader.Position = &H1CA84
                interieur1 = Reader.Position
                Reader.Position = &H1CA88
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1CA70
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 69" Then

                Reader.Position = &H1CE50
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CE70
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CE0A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1D0A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1D012
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1D054
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1CFD0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1D0AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1CE38
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1CEA0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1CF44
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1CF66
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1CF88
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1CFAA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1D3D8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1D3DA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1D3DC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1D3DE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1D3E0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1D3E2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1D3E4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1D3E6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1D0A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1D0A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1D3F2
                eat = Reader.Position
                Reader.Position = &H1D413
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1D0D9
                interieur = Reader.Position
                Reader.Position = &H1D0E4
                interieur1 = Reader.Position
                Reader.Position = &H1D0E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1D0D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 70" Then

                Reader.Position = &H1D4B0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1D4D0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1D46A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1D703
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1D672
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1D6B4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1D630
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1D70D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1D498
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1D500
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1D5A4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1D5C6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1D5E8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1D60A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1DA38
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1DA3A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1DA3C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1DA3E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1DA40
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1DA42
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1DA44
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1DA46
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1D702
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1D708
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1DA52
                eat = Reader.Position
                Reader.Position = &H1DA73
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1D739
                interieur = Reader.Position
                Reader.Position = &H1D744
                interieur1 = Reader.Position
                Reader.Position = &H1D748
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1D730
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 71" Then

                Reader.Position = &H1DB10
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1DB30
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1DACA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1DD63
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1DCD2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1DD14
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1DC90
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1DD6D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1DAF8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1DB60
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DC04
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DC26
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DC48
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1DC6A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1E098
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1E09A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1E09C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1E09E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1E0A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1E0A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1E0A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1E0A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1DD62
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1DD68
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1E0B2
                eat = Reader.Position
                Reader.Position = &H1E0D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1DD99
                interieur = Reader.Position
                Reader.Position = &H1DDA4
                interieur1 = Reader.Position
                Reader.Position = &H1DDA8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1DD90
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 72" Then

                Reader.Position = &H1E170
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1E190
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1E12A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1E3C3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1E332
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1E374
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1E2F0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1E3CD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1E158
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E1C0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E264
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E286
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E2A8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E2CA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1E6F8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1E6FA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1E6FC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1E6FE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1E700
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1E702
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1E704
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1E706
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1E3C2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E3C8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1E712
                eat = Reader.Position
                Reader.Position = &H1E733
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1E3F9
                interieur = Reader.Position
                Reader.Position = &H1E404
                interieur1 = Reader.Position
                Reader.Position = &H1E408
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1E3F0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 73" Then

                Reader.Position = &H1E7D0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1E7F0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1E78A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1EA23
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1E992
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1E9D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1E950
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1EA2D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1E7B8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E820
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E8C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E8E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E908
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1E92A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1ED58
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1ED5A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1ED5C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1ED5E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1ED60
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1ED62
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1ED64
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1ED66
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1EA22
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1EA28
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1ED72
                eat = Reader.Position
                Reader.Position = &H1ED93
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1EA59
                interieur = Reader.Position
                Reader.Position = &H1EA64
                interieur1 = Reader.Position
                Reader.Position = &H1EA68
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1EA50
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 74" Then

                Reader.Position = &H1EE30
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1EE50
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1EDEA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1F083
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1EFF2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1F034
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1EFB0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1F08D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1EE18
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1EE80
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1EF24
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1EF46
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1EF68
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1EF8A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1F3B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1F3BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1F3BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1F3BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1F3C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1F3C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1F3C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1F3C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1F082
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1F088
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1F3D2
                eat = Reader.Position
                Reader.Position = &H1F3F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1F0B9
                interieur = Reader.Position
                Reader.Position = &H1F0C4
                interieur1 = Reader.Position
                Reader.Position = &H1F0C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1F0B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 75" Then

                Reader.Position = &H1F490
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1F4B0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1F44A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1F6E3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1F652
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1F694
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1F610
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1F6ED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1F478
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1F4E0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1F584
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1F5A6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1F5C8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1F5EA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H1FA18
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H1FA1A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H1FA1C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H1FA1E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H1FA20
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H1FA22
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H1FA24
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H1FA26
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1F6E2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1F6E8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H1FA32
                eat = Reader.Position
                Reader.Position = &H1FA53
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1F719
                interieur = Reader.Position
                Reader.Position = &H1F724
                interieur1 = Reader.Position
                Reader.Position = &H1F728
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1F710
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 76" Then

                Reader.Position = &H1FAF0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1FB10
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1FAAA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1FD43
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H1FCB2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1FCF4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H1FC70
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1FD4D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H1FAD8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1FB40
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1FBE4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1FC06
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1FC28
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H1FC4A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H20078
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2007A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2007C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2007E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H20080
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H20082
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H20084
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H20086
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H1FD42
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1FD48
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H20092
                eat = Reader.Position
                Reader.Position = &H200B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H1FD79
                interieur = Reader.Position
                Reader.Position = &H1FD84
                interieur1 = Reader.Position
                Reader.Position = &H1FD88
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H1FD70
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 77" Then

                Reader.Position = &H20150
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H20170
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2010A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H203A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H20312
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H20354
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H202D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H203AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H20138
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H201A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H20244
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H20266
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H20288
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H202AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H206D8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H206DA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H206DC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H206DE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H206E0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H206E2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H206E4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H206E6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H203A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H203A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H206F2
                eat = Reader.Position
                Reader.Position = &H20713
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H203D9
                interieur = Reader.Position
                Reader.Position = &H203E4
                interieur1 = Reader.Position
                Reader.Position = &H203E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H203D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 78" Then

                Reader.Position = &H207B0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H207D0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2076A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H20A03
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H20972
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H209B4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H20930
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H20A0D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H20798
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H20800
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H208A4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H208C6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H208E8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2090A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H20D38
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H20D3A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H20D3C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H20D3E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H20D40
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H20D42
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H20D44
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H20D46
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H20A02
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H20A08
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H20D52
                eat = Reader.Position
                Reader.Position = &H20D73
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H20A39
                interieur = Reader.Position
                Reader.Position = &H20A44
                interieur1 = Reader.Position
                Reader.Position = &H20A48
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H20A30
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 79" Then

                Reader.Position = &H20E10
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H20E30
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H20DCA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H21063
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H20FD2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H21014
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H20F90
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2106D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H20DF8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H20E60
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H20F04
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H20F26
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H20F48
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H20F6A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H21398
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2139A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2139C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2139E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H213A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H213A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H213A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H213A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H21062
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H21068
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H213B2
                eat = Reader.Position
                Reader.Position = &H213D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H21099
                interieur = Reader.Position
                Reader.Position = &H210A4
                interieur1 = Reader.Position
                Reader.Position = &H210A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H21090
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 80" Then

                Reader.Position = &H21470
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H21490
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2142A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H216C3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H21632
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H21674
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H215F0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H216CD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H21458
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H214C0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H21564
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H21586
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H215A8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H215CA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H219F8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H219FA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H219FC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H219FE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H21A00
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H21A02
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H21A04
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H21A06
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H216C2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H216C8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H21A12
                eat = Reader.Position
                Reader.Position = &H21A33
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H216F9
                interieur = Reader.Position
                Reader.Position = &H21704
                interieur1 = Reader.Position
                Reader.Position = &H21708
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H216F0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 81" Then

                Reader.Position = &H21AD0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H21AF0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H21A8A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H21D23
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H21C92
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H21CD4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H21C50
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H21D2D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H21AB8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H21B20
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H21BC4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H21BE6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H21C08
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H21C2A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H22058
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2205A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2205C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2205E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H22060
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H22062
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H22064
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H22066
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H21D22
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H21D28
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H22072
                eat = Reader.Position
                Reader.Position = &H22093
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H21D59
                interieur = Reader.Position
                Reader.Position = &H21D64
                interieur1 = Reader.Position
                Reader.Position = &H21D68
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H21D50
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 82" Then

                Reader.Position = &H22130
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H22150
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H220EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H22383
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H222F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H22334
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H222B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2238D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H22118
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H22180
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22224
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22246
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22268
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2228A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H226B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H226BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H226BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H226BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H226C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H226C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H226C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H226C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H22382
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H22388
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H226D2
                eat = Reader.Position
                Reader.Position = &H226F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H223B9
                interieur = Reader.Position
                Reader.Position = &H223C4
                interieur1 = Reader.Position
                Reader.Position = &H223C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H223B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 83" Then

                Reader.Position = &H22790
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H227B0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2274A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H229E3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H22952
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H22994
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H22910
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H229ED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H22778
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H227E0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22884
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H228A6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H228C8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H228EA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H22D18
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H22D1A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H22D1C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H22D1E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H22D20
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H22D22
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H22D24
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H22D26
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H229E2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H229E8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H22D32
                eat = Reader.Position
                Reader.Position = &H22D53
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H22A19
                interieur = Reader.Position
                Reader.Position = &H22A24
                interieur1 = Reader.Position
                Reader.Position = &H22A28
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H22A10
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 84" Then

                Reader.Position = &H22DF0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H22E10
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H22DAA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H23043
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H22FB2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H22FF4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H22F70
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2304D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H22DD8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H22E40
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22EE4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22F06
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22F28
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H22F4A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H23378
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2337A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2337C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2337E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H23380
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H23382
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H23384
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H23386
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H23042
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H23048
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H23392
                eat = Reader.Position
                Reader.Position = &H233B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H23079
                interieur = Reader.Position
                Reader.Position = &H23084
                interieur1 = Reader.Position
                Reader.Position = &H23088
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H23070
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 85" Then

                Reader.Position = &H23450
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H23470
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2340A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H236A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H23612
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H23654
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H235D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H236AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H23438
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H234A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H23544
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H23566
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H23588
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H235AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H239D8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H239DA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H239DC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H239DE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H239E0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H239E2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H239E4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H239E6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H236A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H236A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H239F2
                eat = Reader.Position
                Reader.Position = &H23A13
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H236D9
                interieur = Reader.Position
                Reader.Position = &H236E4
                interieur1 = Reader.Position
                Reader.Position = &H236E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H236D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 86" Then

                Reader.Position = &H23AB0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H23AD0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H23A6A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H23D03
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H23C72
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H23CB4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H23C30
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H23D0D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H23A98
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H23B00
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H23BA4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H23BC6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H23BE8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H23C0A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H24038
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2403A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2403C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2403E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H24040
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H24042
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H24044
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H24046
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H23D02
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H23D08
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H24052
                eat = Reader.Position
                Reader.Position = &H24073
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H23D39
                interieur = Reader.Position
                Reader.Position = &H23D44
                interieur1 = Reader.Position
                Reader.Position = &H23D48
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H23D30
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 87" Then

                Reader.Position = &H24110
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H24130
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H240CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H24363
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H242D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H24314
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H24290
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2436D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H240F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H24160
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24204
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24226
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24248
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2426A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H24698
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2469A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2469C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2469E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H246A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H246A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H246A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H246A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H24362
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H24368
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H246B2
                eat = Reader.Position
                Reader.Position = &H246D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H24399
                interieur = Reader.Position
                Reader.Position = &H243A4
                interieur1 = Reader.Position
                Reader.Position = &H243A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H24390
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 88" Then

                Reader.Position = &H24770
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H24790
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2472A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H249C3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H24932
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H24974
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H248F0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H249CD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H24758
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H247C0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24864
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24886
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H248A8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H248CA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H24CF8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H24CFA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H24CFC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H24CFE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H24D00
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H24D02
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H24D04
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H24D06
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H249C2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H249C8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H24D12
                eat = Reader.Position
                Reader.Position = &H24D33
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H249F9
                interieur = Reader.Position
                Reader.Position = &H24A04
                interieur1 = Reader.Position
                Reader.Position = &H24A08
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H249F0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 89" Then

                Reader.Position = &H24DD0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H24DF0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H24D8A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H25023
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H24F92
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H24FD4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H24F50
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2502D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H24DB8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H24E20
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24EC4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24EE6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24F08
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H24F2A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H25358
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2535A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2535C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2535E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H25360
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H25362
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H25364
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H25366
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H25022
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H25028
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H25372
                eat = Reader.Position
                Reader.Position = &H25393
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H25059
                interieur = Reader.Position
                Reader.Position = &H25064
                interieur1 = Reader.Position
                Reader.Position = &H25068
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H25050
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 90" Then

                Reader.Position = &H25430
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H25450
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H253EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H25683
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H255F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H25634
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H255B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2568D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H25418
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H25480
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H25524
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H25546
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H25568
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2558A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H259B8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H259BA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H259BC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H259BE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H259C0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H259C2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H259C4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H259C6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H25682
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H25688
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H259D2
                eat = Reader.Position
                Reader.Position = &H259F3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H256B9
                interieur = Reader.Position
                Reader.Position = &H256C4
                interieur1 = Reader.Position
                Reader.Position = &H256C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H256B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 91" Then

                Reader.Position = &H25A90
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H25AB0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H25A4A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H25CE3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H25C52
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H25C94
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H25C10
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H25CED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H25A78
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H24AE0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H25B84
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H25BA6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H25BC8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H25BEA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H26018
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2601A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2601C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2601E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H26020
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H26022
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H26024
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H26026
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H25CE2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H25CE8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H26032
                eat = Reader.Position
                Reader.Position = &H26053
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H25D19
                interieur = Reader.Position
                Reader.Position = &H25D24
                interieur1 = Reader.Position
                Reader.Position = &H25D28
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H25D10
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 92" Then

                Reader.Position = &H260F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H26110
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H260AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H26343
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H262B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H262F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H26270
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2634D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H260D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H26140
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H261E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26206
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26228
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2624A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H26678
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2667A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2667C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2667E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H26680
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H26682
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H26684
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H26686
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H26342
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H26348
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H26692
                eat = Reader.Position
                Reader.Position = &H266B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H26379
                interieur = Reader.Position
                Reader.Position = &H26384
                interieur1 = Reader.Position
                Reader.Position = &H26388
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H26370
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 93" Then

                Reader.Position = &H26750
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H26770
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2670A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H269A3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H26912
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H26954
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H268D0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H269AD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H26738
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H267A0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26844
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26866
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26888
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H268AA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H26CD8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H26CDA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H26CDC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H26CDE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H26CE0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H26CE2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H26CE4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H26CE6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H269A2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H269A8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H26CF2
                eat = Reader.Position
                Reader.Position = &H26D13
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H269D9
                interieur = Reader.Position
                Reader.Position = &H269E4
                interieur1 = Reader.Position
                Reader.Position = &H269E8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H269D0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 94" Then

                Reader.Position = &H26DB0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H26DD0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H26D6A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H27003
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H26F72
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H26FB4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H26F30
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2700D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H26D98
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H26E00
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26EA4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26EC6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26EE8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H26F0A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H27338
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2733A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2733C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2733E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H27340
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H27342
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H27344
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H27346
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H27002
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H27008
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H27352
                eat = Reader.Position
                Reader.Position = &H27373
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H27039
                interieur = Reader.Position
                Reader.Position = &H27044
                interieur1 = Reader.Position
                Reader.Position = &H27048
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H27030
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 95" Then

                Reader.Position = &H27410
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H27430
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H273CA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H27663
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H275D2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H27614
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H27590
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2766D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H273F8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H27460
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H27504
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H27526
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H27548
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2756A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H27998
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2799A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2799C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2799E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H279A0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H279A2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H279A4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H279A6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H27662
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H27668
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H279B2
                eat = Reader.Position
                Reader.Position = &H279D3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H27699
                interieur = Reader.Position
                Reader.Position = &H276A4
                interieur1 = Reader.Position
                Reader.Position = &H276A8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H27690
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 96" Then

                Reader.Position = &H27A70
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H27A90
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H27A2A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H27CC3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H27C32
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H27C74
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H27BF0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H27CCD
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H27A58
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H27AC0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H27B64
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H27B86
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H27BA8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H27BCA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H27FF8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H27FFA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H27FFC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H27FFE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H28000
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H28002
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H28004
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H28006
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H27CC2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H27CC8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H28012
                eat = Reader.Position
                Reader.Position = &H28033
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H27CF9
                interieur = Reader.Position
                Reader.Position = &H27D04
                interieur1 = Reader.Position
                Reader.Position = &H27D08
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H27CF0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 97" Then

                Reader.Position = &H280D0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H280F0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H2808A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H28323
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H28292
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H282D4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H28250
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2832D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H280B8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H28120
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H281C4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H281E6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28208
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2822A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H28658
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2865A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2865C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2865E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H28660
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H28662
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H28664
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H28666
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H28322
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H28328
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H28672
                eat = Reader.Position
                Reader.Position = &H28693
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H28359
                interieur = Reader.Position
                Reader.Position = &H28364
                interieur1 = Reader.Position
                Reader.Position = &H28368
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H28350
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 98" Then

                Reader.Position = &H28730
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H28750
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H286EA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H28983
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H288F2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H28934
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H288B0
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2898D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H28718
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H28780
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28824
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28846
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28868
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2888A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H28CB8
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H28CBA
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H28CBC
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H28CBE
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H28CC0
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H28CC2
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H28CC4
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H28CC6
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H28982
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H28988
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H28CD2
                eat = Reader.Position
                Reader.Position = &H28CF3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H289B9
                interieur = Reader.Position
                Reader.Position = &H289C4
                interieur1 = Reader.Position
                Reader.Position = &H289C8
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H289B0
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 99" Then

                Reader.Position = &H28D90
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H28DB0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H28D4A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H28FE3
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H28F52
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H28F94
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H28F10
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H28FED
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H28D78
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H28DE0
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28E84
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28EA6
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28EC8
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H28EEA
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H29318
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2931A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2931C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2931E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H29320
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H29322
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H29324
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H29326
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H28FE2
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H28FE8
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H29332
                eat = Reader.Position
                Reader.Position = &H29353
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H29019
                interieur = Reader.Position
                Reader.Position = &H29024
                interieur1 = Reader.Position
                Reader.Position = &H29028
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H29010
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
            If ComboBox1.Text = "Mii 100" Then

                Reader.Position = &H293F0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H29410
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H293AA
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H29643
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8

                Reader.Position = &H295B2
                Mii1PP = Reader.Position
                Label18.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H295F4
                Mii1NP = Reader.Position
                Label19.Text = Reader.ReadUnicodeString(30)
                Reader.Position = &H29570
                Mii1SP = Reader.Position
                Label16.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H2964D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H293D8
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H29440
                bull1 = Reader.Position
                Label20.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H294E4
                bull2 = Reader.Position
                Label21.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H29506
                bull3 = Reader.Position
                Label22.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H29528
                bull4 = Reader.Position
                Label23.Text = Reader.ReadUnicodeString(16)
                Reader.Position = &H2954A
                bull5 = Reader.Position
                Label24.Text = Reader.ReadUnicodeString(16)

                Reader.Position = &H29978
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H2997A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H2997C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H2997E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H29980
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H29982
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H29984
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H29986
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16

                Reader.Position = &H29642
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H29648
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32

                Reader.Position = &H29992
                eat = Reader.Position
                Reader.Position = &H299B3
                fullness = Reader.Position
                NumericUpDown21.Value = Reader.ReadInt8
                Reader.Position = &H29679
                interieur = Reader.Position
                Reader.Position = &H29684
                interieur1 = Reader.Position
                Reader.Position = &H29688
                Sfoods = Reader.Position
                Label7.Text = "Label7"
            Label25.Text = "Label25"
            Reader.Position = &H29670
            objdiv = Reader.Position
            Label26.Text = "Label26"
            End If
        End If
        If ComboBox12.SelectedItem = ComboBox12.Items.Item(2) Then
            If ComboBox1.Text = "Mii 1" Then
                Reader.Position = &H1CA0
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 2" Then
                Reader.Position = &H1CA0 + &H590
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + &H590
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + &H590
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + &H590
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + &H590
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + &H590
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + &H590
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + &H590
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + &H590
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + &H590
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + &H590
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + &H590
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + &H590
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + &H590
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + &H590
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + &H590
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 3" Then
                Reader.Position = &H1CA0 + (&H590 * 2)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 2)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 2)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 2)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 2)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 2)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 2)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 2)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 2)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 2)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 2)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 2)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 2)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 2)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 2)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 2)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 4" Then
                Reader.Position = &H1CA0 + (&H590 * 3)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 3)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 3)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 3)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 3)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 3)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 3)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 3)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 3)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 3)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 3)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 3)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 3)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 3)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 3)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 3)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 5" Then
                Reader.Position = &H1CA0 + (&H590 * 4)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 4)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 4)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 4)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 4)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 4)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 4)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 4)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 4)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 4)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 4)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 4)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 4)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 4)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 4)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 4)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 6" Then
                Reader.Position = &H1CA0 + (&H590 * 5)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 5)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 5)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 5)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 5)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 5)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 5)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 5)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 5)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 5)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 5)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 5)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 5)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 5)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 5)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 5)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 7" Then
                Reader.Position = &H1CA0 + (&H590 * 6)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 6)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 6)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 6)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 6)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 6)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 6)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 6)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 6)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 6)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 6)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 6)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 6)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 6)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 6)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 6)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 8" Then
                Reader.Position = &H1CA0 + (&H590 * 7)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 7)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 7)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 7)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 7)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 7)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 7)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 7)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 7)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 7)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 7)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 7)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 7)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 7)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 7)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 7)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 9" Then
                Reader.Position = &H1CA0 + (&H590 * 8)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 8)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 8)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 8)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 8)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 8)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 8)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 8)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 8)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 8)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 8)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 8)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 8)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 8)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 8)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 8)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 10" Then
                Reader.Position = &H1CA0 + (&H590 * 9)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 9)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 9)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 9)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 9)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 9)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 9)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 9)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 9)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 9)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 9)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 9)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 9)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 9)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 9)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 9)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 11" Then
                Reader.Position = &H1CA0 + (&H590 * 10)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 10)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 10)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 10)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 10)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 10)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 10)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 10)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 10)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 10)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 10)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 10)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 10)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 10)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 10)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 10)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 12" Then
                Reader.Position = &H1CA0 + (&H590 * 11)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 11)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 11)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 11)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 11)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 11)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 11)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 11)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 11)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 11)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 11)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 11)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 11)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 11)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 11)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 11)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 13" Then
                Reader.Position = &H1CA0 + (&H590 * 12)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 12)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 12)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 12)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 12)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 12)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 12)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 12)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 12)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 12)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 12)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 12)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 12)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 12)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 12)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 12)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 14" Then
                Reader.Position = &H1CA0 + (&H590 * 13)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 13)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 13)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 13)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 13)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 13)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 13)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 13)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 13)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 13)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 13)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 13)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 13)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 13)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 13)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 13)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 15" Then
                Reader.Position = &H1CA0 + (&H590 * 14)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 14)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 14)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 14)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 14)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 14)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 14)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 14)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 14)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 14)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 14)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 14)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 14)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 14)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 14)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 14)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 16" Then
                Reader.Position = &H1CA0 + (&H590 * 15)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 15)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 15)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 15)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 15)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 15)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 15)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 15)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 15)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 15)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 15)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 15)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 15)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 15)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 15)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 15)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 17" Then
                Reader.Position = &H1CA0 + (&H590 * 16)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 16)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 16)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 16)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 16)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 16)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 16)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 16)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 16)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 16)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 16)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 16)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 16)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 16)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 16)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 16)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 18" Then
                Reader.Position = &H1CA0 + (&H590 * 17)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 17)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 17)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 17)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 17)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 17)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 17)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 17)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 17)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 17)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 17)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 17)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 17)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 17)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 17)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 17)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 19" Then
                Reader.Position = &H1CA0 + (&H590 * 18)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 18)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 18)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 18)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 18)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 18)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 18)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 18)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 18)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 18)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 18)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 18)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 18)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 18)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 18)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 18)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 20" Then
                Reader.Position = &H1CA0 + (&H590 * 19)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 19)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 19)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 19)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 19)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 19)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 19)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 19)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 19)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 19)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 19)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 19)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 19)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 19)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 19)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 19)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 21" Then
                Reader.Position = &H1CA0 + (&H590 * 20)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 20)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 20)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 20)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 20)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 20)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 20)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 20)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 20)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 20)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 20)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 20)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 20)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 20)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 20)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 20)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 22" Then
                Reader.Position = &H1CA0 + (&H590 * 21)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 21)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 21)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 21)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 21)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 21)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 21)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 21)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 21)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 21)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 21)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 21)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 21)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 21)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 21)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 21)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 23" Then
                Reader.Position = &H1CA0 + (&H590 * 22)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 22)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 22)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 22)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 22)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 22)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 22)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 22)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 22)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 22)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 22)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 22)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 22)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 22)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 22)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 22)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 24" Then
                Reader.Position = &H1CA0 + (&H590 * 23)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 23)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 23)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 23)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 23)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 23)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 23)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 23)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 23)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 23)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 23)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 23)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 23)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 23)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 23)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 23)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 25" Then
                Reader.Position = &H1CA0 + (&H590 * 24)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 24)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 24)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 24)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 24)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 24)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 24)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 24)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 24)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 24)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 24)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 24)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 24)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 24)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 24)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 24)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 26" Then
                Reader.Position = &H1CA0 + (&H590 * 25)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 25)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 25)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 25)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 25)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 25)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 25)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 25)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 25)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 25)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 25)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 25)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 25)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 25)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 25)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 25)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 27" Then
                Reader.Position = &H1CA0 + (&H590 * 26)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 26)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 26)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 26)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 26)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 26)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 26)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 26)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 26)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 26)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 26)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 26)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 26)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 26)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 26)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 26)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 28" Then
                Reader.Position = &H1CA0 + (&H590 * 27)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 27)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 27)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 27)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 27)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 27)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 27)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 27)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 27)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 27)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 27)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 27)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 27)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 27)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 27)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 27)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 29" Then
                Reader.Position = &H1CA0 + (&H590 * 28)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 28)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 28)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 28)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 28)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 28)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 28)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 28)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 28)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 28)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 28)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 28)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 28)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 28)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 28)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 28)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 30" Then
                Reader.Position = &H1CA0 + (&H590 * 29)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 29)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 29)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 29)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 29)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 29)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 29)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 29)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 29)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 29)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 29)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 29)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 29)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 29)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 29)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 29)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 31" Then
                Reader.Position = &H1CA0 + (&H590 * 30)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 30)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 30)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 30)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 30)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 30)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 30)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 30)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 30)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 30)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 30)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 30)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 30)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 30)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 30)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 30)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 32" Then
                Reader.Position = &H1CA0 + (&H590 * 31)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 31)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 31)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 31)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 31)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 31)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 31)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 31)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 31)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 31)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 31)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 31)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 31)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 31)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 31)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 31)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 33" Then
                Reader.Position = &H1CA0 + (&H590 * 32)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 32)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 32)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 32)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 32)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 32)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 32)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 32)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 32)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 32)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 32)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 32)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 32)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 32)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 32)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 32)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 34" Then
                Reader.Position = &H1CA0 + (&H590 * 33)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 33)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 33)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 33)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 33)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 33)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 33)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 33)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 33)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 33)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 33)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 33)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 33)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 33)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 33)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 33)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 35" Then
                Reader.Position = &H1CA0 + (&H590 * 34)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 34)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 34)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 34)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 34)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 34)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 34)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 34)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 34)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 34)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 34)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 34)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 34)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 34)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 34)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 34)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 36" Then
                Reader.Position = &H1CA0 + (&H590 * 35)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 35)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 35)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 35)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 35)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 35)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 35)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 35)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 35)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 35)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 35)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 35)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 35)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 35)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 35)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 35)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 37" Then
                Reader.Position = &H1CA0 + (&H590 * 36)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 36)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 36)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 36)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 36)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 36)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 36)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 36)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 36)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 36)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 36)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 36)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 36)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 36)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 36)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 36)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 38" Then
                Reader.Position = &H1CA0 + (&H590 * 37)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 37)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 37)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 37)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 37)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 37)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 37)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 37)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 37)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 37)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 37)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 37)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 37)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 37)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 37)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 37)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 39" Then
                Reader.Position = &H1CA0 + (&H590 * 38)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 38)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 38)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 38)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 38)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 38)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 38)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 38)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 38)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 38)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 38)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 38)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 38)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 38)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 38)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 38)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 40" Then
                Reader.Position = &H1CA0 + (&H590 * 39)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 39)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 39)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 39)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 39)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 39)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 39)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 39)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 39)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 39)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 39)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 39)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 39)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 39)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 39)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 39)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 41" Then
                Reader.Position = &H1CA0 + (&H590 * 40)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 40)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 40)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 40)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 40)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 40)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 40)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 40)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 40)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 40)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 40)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 40)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 40)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 40)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 40)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 40)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 42" Then
                Reader.Position = &H1CA0 + (&H590 * 41)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 41)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 41)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 41)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 41)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 41)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 41)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 41)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 41)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 41)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 41)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 41)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 41)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 41)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 41)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 41)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 43" Then
                Reader.Position = &H1CA0 + (&H590 * 42)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 42)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 42)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 42)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 42)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 42)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 42)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 42)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 42)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 42)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 42)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 42)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 42)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 42)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 42)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 42)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 44" Then
                Reader.Position = &H1CA0 + (&H590 * 43)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 43)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 43)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 43)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 43)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 43)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 43)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 43)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 43)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 43)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 43)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 43)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 43)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 43)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 43)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 43)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 45" Then
                Reader.Position = &H1CA0 + (&H590 * 44)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 44)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 44)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 44)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 44)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 44)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 44)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 44)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 44)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 44)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 44)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 44)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 44)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 44)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 44)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 44)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 46" Then
                Reader.Position = &H1CA0 + (&H590 * 45)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 45)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 45)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 45)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 45)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 45)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 45)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 45)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 45)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 45)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 45)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 45)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 45)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 45)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 45)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 45)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 47" Then
                Reader.Position = &H1CA0 + (&H590 * 46)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 46)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 46)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 46)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 46)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 46)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 46)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 46)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 46)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 46)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 46)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 46)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 46)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 46)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 46)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 46)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 48" Then
                Reader.Position = &H1CA0 + (&H590 * 47)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 47)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 47)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 47)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 47)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 47)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 47)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 47)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 47)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 47)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 47)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 47)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 47)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 47)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 47)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 47)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 49" Then
                Reader.Position = &H1CA0 + (&H590 * 48)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 48)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 48)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 48)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 48)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 48)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 48)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 48)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 48)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 48)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 48)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 48)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 48)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 48)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 48)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 48)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 50" Then
                Reader.Position = &H1CA0 + (&H590 * 49)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 49)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 49)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 49)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 49)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 49)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 49)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 49)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 49)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 49)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 49)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 49)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 49)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 49)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 49)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 49)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 51" Then
                Reader.Position = &H1CA0 + (&H590 * 50)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 50)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 50)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 50)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 50)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 50)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 50)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 50)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 50)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 50)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 50)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 50)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 50)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 50)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 50)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 50)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 52" Then
                Reader.Position = &H1CA0 + (&H590 * 51)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 51)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 51)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 51)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 51)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 51)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 51)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 51)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 51)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 51)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 51)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 51)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 51)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 51)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 51)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 51)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 53" Then
                Reader.Position = &H1CA0 + (&H590 * 52)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 52)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 52)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 52)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 52)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 52)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 52)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 52)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 52)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 52)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 52)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 52)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 52)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 52)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 52)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 52)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 54" Then
                Reader.Position = &H1CA0 + (&H590 * 53)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 53)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 53)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 53)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 53)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 53)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 53)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 53)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 53)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 53)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 53)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 53)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 53)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 53)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 53)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 53)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 55" Then
                Reader.Position = &H1CA0 + (&H590 * 54)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 54)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 54)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 54)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 54)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 54)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 54)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 54)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 54)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 54)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 54)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 54)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 54)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 54)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 54)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 54)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 56" Then
                Reader.Position = &H1CA0 + (&H590 * 55)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 55)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 55)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 55)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 55)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 55)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 55)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 55)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 55)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 55)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 55)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 55)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 55)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 55)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 55)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 55)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 57" Then
                Reader.Position = &H1CA0 + (&H590 * 56)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 56)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 56)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 56)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 56)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 56)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 56)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 56)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 56)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 56)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 56)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 56)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 56)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 56)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 56)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 56)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 58" Then
                Reader.Position = &H1CA0 + (&H590 * 57)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 57)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 57)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 57)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 57)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 57)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 57)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 57)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 57)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 57)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 57)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 57)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 57)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 57)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 57)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 57)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 59" Then
                Reader.Position = &H1CA0 + (&H590 * 58)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 58)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 58)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 58)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 58)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 58)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 58)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 58)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 58)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 58)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 58)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 58)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 58)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 58)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 58)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 58)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 60" Then
                Reader.Position = &H1CA0 + (&H590 * 59)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 59)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 59)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 59)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 59)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 59)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 59)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 59)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 59)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 59)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 59)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 59)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 59)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 59)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 59)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 59)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 61" Then
                Reader.Position = &H1CA0 + (&H590 * 60)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 60)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 60)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 60)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 60)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 60)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 60)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 60)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 60)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 60)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 60)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 60)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 60)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 60)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 60)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 60)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 62" Then
                Reader.Position = &H1CA0 + (&H590 * 61)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 61)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 61)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 61)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 61)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 61)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 61)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 61)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 61)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 61)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 61)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 61)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 61)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 61)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 61)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 61)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 63" Then
                Reader.Position = &H1CA0 + (&H590 * 62)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 62)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 62)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 62)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 62)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 62)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 62)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 62)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 62)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 62)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 62)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 62)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 62)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 62)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 62)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 62)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 64" Then
                Reader.Position = &H1CA0 + (&H590 * 63)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 63)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 63)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 63)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 63)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 63)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 63)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 63)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 63)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 63)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 63)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 63)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 63)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 63)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 63)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 63)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 65" Then
                Reader.Position = &H1CA0 + (&H590 * 64)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 64)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 64)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 64)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 64)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 64)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 64)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 64)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 64)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 64)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 64)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 64)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 64)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 64)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 64)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 64)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 66" Then
                Reader.Position = &H1CA0 + (&H590 * 65)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 65)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 65)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 65)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 65)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 65)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 65)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 65)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 65)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 65)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 65)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 65)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 65)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 65)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 65)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 65)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 67" Then
                Reader.Position = &H1CA0 + (&H590 * 66)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 66)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 66)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 66)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 66)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 66)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 66)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 66)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 66)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 66)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 66)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 66)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 66)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 66)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 66)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 66)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 68" Then
                Reader.Position = &H1CA0 + (&H590 * 67)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 67)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 67)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 67)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 67)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 67)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 67)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 67)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 67)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 67)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 67)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 67)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 67)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 67)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 67)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 67)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 69" Then
                Reader.Position = &H1CA0 + (&H590 * 68)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 68)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 68)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 68)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 68)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 68)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 68)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 68)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 68)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 68)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 68)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 68)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 68)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 68)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 68)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 68)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 70" Then
                Reader.Position = &H1CA0 + (&H590 * 69)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 69)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 69)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 69)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 69)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 69)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 69)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 69)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 69)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 69)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 69)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 69)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 69)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 69)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 69)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 69)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 71" Then
                Reader.Position = &H1CA0 + (&H590 * 70)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 70)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 70)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 70)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 70)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 70)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 70)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 70)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 70)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 70)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 70)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 70)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 70)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 70)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 70)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 70)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 72" Then
                Reader.Position = &H1CA0 + (&H590 * 71)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 71)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 71)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 71)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 71)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 71)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 71)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 71)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 71)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 71)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 71)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 71)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 71)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 71)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 71)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 71)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 73" Then
                Reader.Position = &H1CA0 + (&H590 * 72)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 72)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 72)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 72)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 72)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 72)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 72)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 72)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 72)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 72)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 72)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 72)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 72)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 72)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 72)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 72)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 74" Then
                Reader.Position = &H1CA0 + (&H590 * 73)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 73)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 73)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 73)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 73)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 73)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 73)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 73)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 73)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 73)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 73)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 73)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 73)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 73)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 73)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 73)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 75" Then
                Reader.Position = &H1CA0 + (&H590 * 74)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 74)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 74)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 74)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 74)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 74)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 74)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 74)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 74)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 74)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 74)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 74)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 74)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 74)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 74)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 74)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 76" Then
                Reader.Position = &H1CA0 + (&H590 * 75)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 75)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 75)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 75)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 75)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 75)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 75)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 75)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 75)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 75)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 75)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 75)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 75)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 75)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 75)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 75)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 77" Then
                Reader.Position = &H1CA0 + (&H590 * 76)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 76)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 76)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 76)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 76)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 76)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 76)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 76)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 76)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 76)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 76)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 76)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 76)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 76)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 76)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 76)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 78" Then
                Reader.Position = &H1CA0 + (&H590 * 77)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 77)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 77)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 77)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 77)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 77)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 77)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 77)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 77)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 77)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 77)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 77)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 77)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 77)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 77)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 77)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 79" Then
                Reader.Position = &H1CA0 + (&H590 * 78)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 78)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 78)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 78)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 78)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 78)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 78)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 78)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 78)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 78)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 78)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 78)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 78)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 78)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 78)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 78)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 80" Then
                Reader.Position = &H1CA0 + (&H590 * 79)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 79)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 79)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 79)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 79)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 79)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 79)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 79)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 79)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 79)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 79)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 79)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 79)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 79)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 79)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 79)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 81" Then
                Reader.Position = &H1CA0 + (&H590 * 80)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 80)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 80)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 80)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 80)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 80)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 80)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 80)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 80)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 80)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 80)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 80)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 80)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 80)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 80)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 80)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 82" Then
                Reader.Position = &H1CA0 + (&H590 * 81)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 81)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 81)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 81)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 81)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 81)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 81)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 81)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 81)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 81)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 81)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 81)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 81)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 81)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 81)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 81)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 83" Then
                Reader.Position = &H1CA0 + (&H590 * 82)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 82)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 82)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 82)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 82)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 82)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 82)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 82)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 82)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 82)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 82)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 82)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 82)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 82)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 82)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 82)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 84" Then
                Reader.Position = &H1CA0 + (&H590 * 83)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 83)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 83)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 83)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 83)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 83)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 83)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 83)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 83)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 83)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 83)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 83)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 83)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 83)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 83)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 83)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 85" Then
                Reader.Position = &H1CA0 + (&H590 * 84)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 84)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 84)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 84)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 84)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 84)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 84)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 84)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 84)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 84)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 84)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 84)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 84)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 84)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 84)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 84)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 86" Then
                Reader.Position = &H1CA0 + (&H590 * 85)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 85)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 85)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 85)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 85)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 85)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 85)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 85)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 85)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 85)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 85)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 85)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 85)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 85)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 85)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 85)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 87" Then
                Reader.Position = &H1CA0 + (&H590 * 86)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 86)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 86)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 86)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 86)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 86)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 86)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 86)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 86)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 86)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 86)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 86)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 86)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 86)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 86)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 86)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 88" Then
                Reader.Position = &H1CA0 + (&H590 * 87)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 87)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 87)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 87)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 87)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 87)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 87)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 87)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 87)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 87)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 87)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 87)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 87)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 87)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 87)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 87)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 89" Then
                Reader.Position = &H1CA0 + (&H590 * 88)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 88)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 88)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 88)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 88)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 88)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 88)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 88)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 88)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 88)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 88)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 88)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 88)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 88)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 88)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 88)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 90" Then
                Reader.Position = &H1CA0 + (&H590 * 89)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 89)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 89)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 89)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 89)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 89)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 89)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 89)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 89)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 89)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 89)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 89)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 89)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 89)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 89)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 89)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 91" Then
                Reader.Position = &H1CA0 + (&H590 * 90)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 90)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 90)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 90)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 90)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 90)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 90)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 90)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 90)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 90)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 90)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 90)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 90)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 90)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 90)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 90)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 92" Then
                Reader.Position = &H1CA0 + (&H590 * 91)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 91)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 91)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 91)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 91)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 91)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 91)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 91)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 91)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 91)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 91)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 91)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 91)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 91)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 91)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 91)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 93" Then
                Reader.Position = &H1CA0 + (&H590 * 92)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 92)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 92)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 92)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 92)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 92)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 92)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 92)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 92)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 92)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 92)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 92)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 92)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 92)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 92)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 92)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 94" Then
                Reader.Position = &H1CA0 + (&H590 * 93)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 93)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 93)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 93)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 93)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 93)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 93)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 93)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 93)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 93)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 93)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 93)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 93)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 93)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 93)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 93)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 95" Then
                Reader.Position = &H1CA0 + (&H590 * 94)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 94)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 94)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 94)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 94)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 94)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 94)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 94)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 94)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 94)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 94)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 94)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 94)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 94)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 94)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 94)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 96" Then
                Reader.Position = &H1CA0 + (&H590 * 95)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 95)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 95)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 95)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 95)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 95)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 95)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 95)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 95)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 95)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 95)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 95)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 95)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 95)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 95)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 95)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 97" Then
                Reader.Position = &H1CA0 + (&H590 * 96)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 96)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 96)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 96)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 96)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 96)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 96)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 96)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 96)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 96)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 96)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 96)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 96)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 96)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 96)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 96)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 98" Then
                Reader.Position = &H1CA0 + (&H590 * 97)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 97)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 97)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 97)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 97)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 97)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 97)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 97)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 97)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 97)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 97)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 97)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 97)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 97)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 97)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 97)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 99" Then
                Reader.Position = &H1CA0 + (&H590 * 98)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 98)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 98)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 98)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 98)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 98)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 98)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 98)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 98)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 98)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 98)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 98)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 98)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 98)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 98)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 98)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            If ComboBox1.Text = "Mii 100" Then
                Reader.Position = &H1CA0 + (&H590 * 99)
                Mii1P = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1CC0 + (&H590 * 99)
                Mii1N = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(15)
                Reader.Position = &H1C5A + (&H590 * 99)
                Mii1S = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1C88 + (&H590 * 99)
                Mii1C = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(10)

                Reader.Position = &H1E22 + (&H590 * 99)
                exp = Reader.Position
                NumericUpDown20.Value = Reader.ReadInt8
                Reader.Position = &H1E23 + (&H590 * 99)
                Mii1L = Reader.Position
                NumericUpDown102.Value = Reader.ReadInt8
                Reader.Position = &H1E28 + (&H590 * 99)
                econom = Reader.Position
                NumericUpDown19.Value = Reader.ReadInt32
                Reader.Position = &H1E2D + (&H590 * 99)
                Mii1R = Reader.Position
                NumericUpDown9.Value = Reader.ReadInt8

                Reader.Position = &H2158 + (&H590 * 99)
                objet1 = Reader.Position
                NumericUpDown11.Value = Reader.ReadUInt16
                Reader.Position = &H215A + (&H590 * 99)
                objet2 = Reader.Position
                NumericUpDown12.Value = Reader.ReadUInt16
                Reader.Position = &H215C + (&H590 * 99)
                objet3 = Reader.Position
                NumericUpDown13.Value = Reader.ReadUInt16
                Reader.Position = &H215E + (&H590 * 99)
                objet4 = Reader.Position
                NumericUpDown14.Value = Reader.ReadUInt16
                Reader.Position = &H2160 + (&H590 * 99)
                objet5 = Reader.Position
                NumericUpDown18.Value = Reader.ReadUInt16
                Reader.Position = &H2162 + (&H590 * 99)
                objet6 = Reader.Position
                NumericUpDown17.Value = Reader.ReadUInt16
                Reader.Position = &H2164 + (&H590 * 99)
                objet7 = Reader.Position
                NumericUpDown16.Value = Reader.ReadUInt16
                Reader.Position = &H2166 + (&H590 * 99)
                objet8 = Reader.Position
                NumericUpDown15.Value = Reader.ReadUInt16
            End If
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = " Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "       An error has occurred, load a save before"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WriteFile1()
    End Sub
    Private Sub WriteFile1()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = Mii1L
            Writer.WriteInt8(NumericUpDown102.Value)
            For i As Integer = 0 To 29
                Writer.Position = Mii1P + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1P
            Writer.WriteUnicodeString(TextBox3.Text)
            For i As Integer = 0 To 29
                Writer.Position = Mii1N + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1N
            Writer.WriteUnicodeString(TextBox4.Text)

            For i As Integer = 0 To 59
                Writer.Position = Mii1PP + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1PP
            Writer.WriteUnicodeString(Label18.Text)
            For i As Integer = 0 To 59
                Writer.Position = Mii1NP + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1NP
            Writer.WriteUnicodeString(Label19.Text)

            Writer.Position = Mii1R
            Writer.WriteInt8(NumericUpDown9.Value)

            For i As Integer = 0 To 31
                Writer.Position = bull1 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull1
            Writer.WriteUnicodeString(Label20.Text)
            For i As Integer = 0 To 31
                Writer.Position = bull2 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull2
            Writer.WriteUnicodeString(Label21.Text)
            For i As Integer = 0 To 31
                Writer.Position = bull3 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull3
            Writer.WriteUnicodeString(Label22.Text)
            For i As Integer = 0 To 31
                Writer.Position = bull4 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull4
            Writer.WriteUnicodeString(Label23.Text)
            For i As Integer = 0 To 31
                Writer.Position = bull5 + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = bull5
            Writer.WriteUnicodeString(Label24.Text)
            Writer.Position = objet1
            Writer.WriteUInt16(NumericUpDown11.Value)
            Writer.Position = objet2
            Writer.WriteUInt16(NumericUpDown12.Value)
            Writer.Position = objet3
            Writer.WriteUInt16(NumericUpDown13.Value)
            Writer.Position = objet4
            Writer.WriteUInt16(NumericUpDown14.Value)
            Writer.Position = objet5
            Writer.WriteUInt16(NumericUpDown18.Value)
            Writer.Position = objet6
            Writer.WriteUInt16(NumericUpDown17.Value)
            Writer.Position = objet7
            Writer.WriteUInt16(NumericUpDown16.Value)
            Writer.Position = objet8
            Writer.WriteUInt16(NumericUpDown15.Value)
            Writer.Position = exp
            Writer.WriteInt8(NumericUpDown20.Value)
            Writer.Position = econom
            Writer.WriteInt32(NumericUpDown19.Value)
            Writer.Position = fullness
            Writer.WriteInt8(NumericUpDown21.Value)
            If Label7.Text = "All" Then
                For i As Integer = 0 To 10
                    Writer.Position = interieur + i
                    Writer.WriteUInt16(65535)
                Next
                Writer.Position = interieur1
                Writer.WriteUInt16(16383)
            End If
            If Label7.Text = "None" Then
                For i As Integer = 0 To 11
                    Writer.Position = interieur + i
                    Writer.WriteUInt16(0)
                Next
            End If

            If Label25.Text = "All" Then
                For i As Integer = 0 To 4
                    Writer.Position = Sfoods + i
                    Writer.WriteUInt16(65535)
                Next
            End If
            If Label25.Text = "None" Then
                For i As Integer = 0 To 4
                    Writer.Position = Sfoods + i
                    Writer.WriteUInt16(0)
                Next
            End If

            If Label26.Text = "All" Then
                Writer.Position = objdiv
                Writer.WriteUInt24(262143)
            End If
            If Label26.Text = "None" Then
                Writer.Position = objdiv
                Writer.WriteUInt24(0)
            End If

            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                        Changes Mii Save"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If

            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                Changements Mii Sauvegardé"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                  Une erreur est survenue"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                   An error has occurred"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
            PictureBox30.Image = My.Resources.tomoF1
            PictureBox3.Visible = True
            PictureBox5.Visible = True
            PictureBox4.Visible = True
            PictureBox6.Visible = True
            Button1.Visible = True
            Button4.Enabled = True
            Button2.Visible = True
            Button5.Visible = False
            Button6.Visible = False
            CheckBox17.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox15.Enabled = True
            CheckBox18.Enabled = True
            CheckBox19.Enabled = True
            CheckBox20.Enabled = True
            CheckBox21.Enabled = True
            CheckBox22.Enabled = True
            CheckBox23.Enabled = True
            CheckBox24.Enabled = True
            RadioButton2.Enabled = True
            PictureBox33.Enabled = True
            PictureBox35.Enabled = True
            Button3.Visible = True
            Button7.Visible = False
            PictureBox55.Image = Nothing
            PictureBox55.Enabled = True
            PictureBox54.Image = Nothing
            PictureBox54.Enabled = True
        End If
        If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
            PictureBox30.Image = My.Resources.tomoF
            PictureBox3.Visible = True
            PictureBox5.Visible = True
            PictureBox4.Visible = True
            PictureBox6.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Button4.Enabled = True
            Button5.Visible = False
            Button6.Visible = False
            CheckBox17.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            CheckBox15.Enabled = True
            CheckBox18.Enabled = True
            CheckBox19.Enabled = True
            CheckBox20.Enabled = True
            CheckBox21.Enabled = True
            CheckBox22.Enabled = True
            CheckBox23.Enabled = True
            CheckBox24.Enabled = True
            RadioButton2.Enabled = True
            PictureBox33.Enabled = True
            PictureBox35.Enabled = True
            Button3.Visible = True
            Button7.Visible = False
            PictureBox55.Image = Nothing
            PictureBox55.Enabled = True
            PictureBox54.Image = Nothing
            PictureBox54.Enabled = True
        End If
        If ComboBox12.SelectedItem = ComboBox12.Items.Item(2) Then
            PictureBox30.Image = My.Resources.tomoJ
            PictureBox3.Visible = False
            PictureBox5.Visible = False
            PictureBox4.Visible = False
            PictureBox6.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button4.Enabled = False
            Button5.Visible = True
            Button6.Visible = True
            CheckBox17.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox15.Enabled = False
            CheckBox18.Enabled = False
            CheckBox19.Enabled = False
            CheckBox20.Enabled = False
            CheckBox21.Enabled = False
            CheckBox22.Enabled = False
            CheckBox23.Enabled = False
            CheckBox24.Enabled = False
            RadioButton2.Enabled = False
            PictureBox33.Enabled = False
            PictureBox35.Enabled = False
            Button3.Visible = False
            Button7.Visible = True
            PictureBox55.Image = My.Resources.touri
            PictureBox55.Enabled = False
            PictureBox54.Image = My.Resources.parti
            PictureBox54.Enabled = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If ComboBox11.Text = "EN" Then
            fdialog.Label1.Text = "           For use Remove time travel penality," & vbNewLine & "Change time in Tomodachi life or in 3ds, play and save" & vbNewLine & "       Export your save with Time travel penality" & vbNewLine & "                 import your save file here" & vbNewLine & " Check and re-import your save in Tomodachi Life"
            fdialog.Label1.Location = New Point(3, 3)
            fdialog.ShowDialog()
        End If
        If ComboBox11.Text = "FR" Then
            fdialog.Label1.Text = "    Pour retirer la pénalité de voyage dans le temps," & vbNewLine & "  Changer le temps dans Tomodachi life ou sur la 3ds" & vbNewLine & "   jouez, sauvegardez et exportez votre sauvegarde." & vbNewLine & "          Cochez et re-importez votre sauvegarde" & vbNewLine & "                     dans Tomodachi Life"
            fdialog.Label1.Location = New Point(3, 5)
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub Panel2_click(sender As Object, e As EventArgs) Handles Panel2.Click
        Form7.Show()
    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        If NumericUpDown11.Value = 65535 Then
            PictureBox17.Image = Nothing
        End If
        If NumericUpDown11.Value = 0 Then
            PictureBox17.Image = My.Resources._0000
        End If
        If NumericUpDown11.Value = 1 Then
            PictureBox17.Image = My.Resources._0100
        End If
        If NumericUpDown11.Value = 2 Then
            PictureBox17.Image = My.Resources._0200
        End If
        If NumericUpDown11.Value = 3 Then
            PictureBox17.Image = My.Resources._0300
        End If
        If NumericUpDown11.Value = 4 Then
            PictureBox17.Image = My.Resources._0400
        End If
        If NumericUpDown11.Value = 5 Then
            PictureBox17.Image = My.Resources._0500
        End If
        If NumericUpDown11.Value = 6 Then
            PictureBox17.Image = My.Resources._0600
        End If
        If NumericUpDown11.Value = 7 Then
            PictureBox17.Image = My.Resources._0700
        End If
        If NumericUpDown11.Value = 8 Then
            PictureBox17.Image = My.Resources._0800
        End If
        If NumericUpDown11.Value = 9 Then
            PictureBox17.Image = My.Resources._0900
        End If
        If NumericUpDown11.Value = 10 Then
            PictureBox17.Image = My.Resources._0a00
        End If
        If NumericUpDown11.Value = 11 Then
            PictureBox17.Image = My.Resources._0b00
        End If
        If NumericUpDown11.Value = 12 Then
            PictureBox17.Image = My.Resources._0c00
        End If
        If NumericUpDown11.Value = 13 Then
            PictureBox17.Image = My.Resources._0d00
        End If
        If NumericUpDown11.Value = 14 Then
            PictureBox17.Image = My.Resources._0e00
        End If
        If NumericUpDown11.Value = 15 Then
            PictureBox17.Image = My.Resources._0f00
        End If
        If NumericUpDown11.Value = 16 Then
            PictureBox17.Image = My.Resources._1000
        End If
        If NumericUpDown11.Value = 17 Then
            PictureBox17.Image = My.Resources._1100
        End If
        If NumericUpDown11.Value = 18 Then
            PictureBox17.Image = My.Resources._1200
        End If
        If NumericUpDown11.Value = 19 Then
            PictureBox17.Image = My.Resources._1300
        End If
        If NumericUpDown11.Value = 20 Then
            PictureBox17.Image = My.Resources._1400
        End If
        If NumericUpDown11.Value = 21 Then
            PictureBox17.Image = My.Resources._1500
        End If
        If NumericUpDown11.Value = 22 Then
            PictureBox17.Image = My.Resources._1600
        End If
        If NumericUpDown11.Value = 23 Then
            PictureBox17.Image = My.Resources._1700
        End If
        If NumericUpDown11.Value = 24 Then
            PictureBox17.Image = My.Resources._1800
        End If
        If NumericUpDown11.Value = 25 Then
            PictureBox17.Image = My.Resources._1900
        End If
        If NumericUpDown11.Value = 26 Then
            PictureBox17.Image = My.Resources._1a00
        End If
        If NumericUpDown11.Value = 27 Then
            PictureBox17.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        If NumericUpDown12.Value = 65535 Then
            PictureBox23.Image = Nothing
        End If
        If NumericUpDown12.Value = 0 Then
            PictureBox23.Image = My.Resources._0000
        End If
        If NumericUpDown12.Value = 1 Then
            PictureBox23.Image = My.Resources._0100
        End If
        If NumericUpDown12.Value = 2 Then
            PictureBox23.Image = My.Resources._0200
        End If
        If NumericUpDown12.Value = 3 Then
            PictureBox23.Image = My.Resources._0300
        End If
        If NumericUpDown12.Value = 4 Then
            PictureBox23.Image = My.Resources._0400
        End If
        If NumericUpDown12.Value = 5 Then
            PictureBox23.Image = My.Resources._0500
        End If
        If NumericUpDown12.Value = 6 Then
            PictureBox23.Image = My.Resources._0600
        End If
        If NumericUpDown12.Value = 7 Then
            PictureBox23.Image = My.Resources._0700
        End If
        If NumericUpDown12.Value = 8 Then
            PictureBox23.Image = My.Resources._0800
        End If
        If NumericUpDown12.Value = 9 Then
            PictureBox23.Image = My.Resources._0900
        End If
        If NumericUpDown12.Value = 10 Then
            PictureBox23.Image = My.Resources._0a00
        End If
        If NumericUpDown12.Value = 11 Then
            PictureBox23.Image = My.Resources._0b00
        End If
        If NumericUpDown12.Value = 12 Then
            PictureBox23.Image = My.Resources._0c00
        End If
        If NumericUpDown12.Value = 13 Then
            PictureBox23.Image = My.Resources._0d00
        End If
        If NumericUpDown12.Value = 14 Then
            PictureBox23.Image = My.Resources._0e00
        End If
        If NumericUpDown12.Value = 15 Then
            PictureBox23.Image = My.Resources._0f00
        End If
        If NumericUpDown12.Value = 16 Then
            PictureBox23.Image = My.Resources._1000
        End If
        If NumericUpDown12.Value = 17 Then
            PictureBox23.Image = My.Resources._1100
        End If
        If NumericUpDown12.Value = 18 Then
            PictureBox23.Image = My.Resources._1200
        End If
        If NumericUpDown12.Value = 19 Then
            PictureBox23.Image = My.Resources._1300
        End If
        If NumericUpDown12.Value = 20 Then
            PictureBox23.Image = My.Resources._1400
        End If
        If NumericUpDown12.Value = 21 Then
            PictureBox23.Image = My.Resources._1500
        End If
        If NumericUpDown12.Value = 22 Then
            PictureBox23.Image = My.Resources._1600
        End If
        If NumericUpDown12.Value = 23 Then
            PictureBox23.Image = My.Resources._1700
        End If
        If NumericUpDown12.Value = 24 Then
            PictureBox23.Image = My.Resources._1800
        End If
        If NumericUpDown12.Value = 25 Then
            PictureBox23.Image = My.Resources._1900
        End If
        If NumericUpDown12.Value = 26 Then
            PictureBox23.Image = My.Resources._1a00
        End If
        If NumericUpDown12.Value = 27 Then
            PictureBox23.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown13_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown13.ValueChanged
        If NumericUpDown13.Value = 65535 Then
            PictureBox24.Image = Nothing
        End If
        If NumericUpDown13.Value = 0 Then
            PictureBox24.Image = My.Resources._0000
        End If
        If NumericUpDown13.Value = 1 Then
            PictureBox24.Image = My.Resources._0100
        End If
        If NumericUpDown13.Value = 2 Then
            PictureBox24.Image = My.Resources._0200
        End If
        If NumericUpDown13.Value = 3 Then
            PictureBox24.Image = My.Resources._0300
        End If
        If NumericUpDown13.Value = 4 Then
            PictureBox24.Image = My.Resources._0400
        End If
        If NumericUpDown13.Value = 5 Then
            PictureBox24.Image = My.Resources._0500
        End If
        If NumericUpDown13.Value = 6 Then
            PictureBox24.Image = My.Resources._0600
        End If
        If NumericUpDown13.Value = 7 Then
            PictureBox24.Image = My.Resources._0700
        End If
        If NumericUpDown13.Value = 8 Then
            PictureBox24.Image = My.Resources._0800
        End If
        If NumericUpDown13.Value = 9 Then
            PictureBox24.Image = My.Resources._0900
        End If
        If NumericUpDown13.Value = 10 Then
            PictureBox24.Image = My.Resources._0a00
        End If
        If NumericUpDown13.Value = 11 Then
            PictureBox24.Image = My.Resources._0b00
        End If
        If NumericUpDown13.Value = 12 Then
            PictureBox24.Image = My.Resources._0c00
        End If
        If NumericUpDown13.Value = 13 Then
            PictureBox24.Image = My.Resources._0d00
        End If
        If NumericUpDown13.Value = 14 Then
            PictureBox24.Image = My.Resources._0e00
        End If
        If NumericUpDown13.Value = 15 Then
            PictureBox24.Image = My.Resources._0f00
        End If
        If NumericUpDown13.Value = 16 Then
            PictureBox24.Image = My.Resources._1000
        End If
        If NumericUpDown13.Value = 17 Then
            PictureBox24.Image = My.Resources._1100
        End If
        If NumericUpDown13.Value = 18 Then
            PictureBox24.Image = My.Resources._1200
        End If
        If NumericUpDown13.Value = 19 Then
            PictureBox24.Image = My.Resources._1300
        End If
        If NumericUpDown13.Value = 20 Then
            PictureBox24.Image = My.Resources._1400
        End If
        If NumericUpDown13.Value = 21 Then
            PictureBox24.Image = My.Resources._1500
        End If
        If NumericUpDown13.Value = 22 Then
            PictureBox24.Image = My.Resources._1600
        End If
        If NumericUpDown13.Value = 23 Then
            PictureBox24.Image = My.Resources._1700
        End If
        If NumericUpDown13.Value = 24 Then
            PictureBox24.Image = My.Resources._1800
        End If
        If NumericUpDown13.Value = 25 Then
            PictureBox24.Image = My.Resources._1900
        End If
        If NumericUpDown13.Value = 26 Then
            PictureBox24.Image = My.Resources._1a00
        End If
        If NumericUpDown13.Value = 27 Then
            PictureBox24.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown14_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown14.ValueChanged
        If NumericUpDown14.Value = 65535 Then
            PictureBox25.Image = Nothing
        End If
        If NumericUpDown14.Value = 0 Then
            PictureBox25.Image = My.Resources._0000
        End If
        If NumericUpDown14.Value = 1 Then
            PictureBox25.Image = My.Resources._0100
        End If
        If NumericUpDown14.Value = 2 Then
            PictureBox25.Image = My.Resources._0200
        End If
        If NumericUpDown14.Value = 3 Then
            PictureBox25.Image = My.Resources._0300
        End If
        If NumericUpDown14.Value = 4 Then
            PictureBox25.Image = My.Resources._0400
        End If
        If NumericUpDown14.Value = 5 Then
            PictureBox25.Image = My.Resources._0500
        End If
        If NumericUpDown14.Value = 6 Then
            PictureBox25.Image = My.Resources._0600
        End If
        If NumericUpDown14.Value = 7 Then
            PictureBox25.Image = My.Resources._0700
        End If
        If NumericUpDown14.Value = 8 Then
            PictureBox25.Image = My.Resources._0800
        End If
        If NumericUpDown14.Value = 9 Then
            PictureBox25.Image = My.Resources._0900
        End If
        If NumericUpDown14.Value = 10 Then
            PictureBox25.Image = My.Resources._0a00
        End If
        If NumericUpDown14.Value = 11 Then
            PictureBox25.Image = My.Resources._0b00
        End If
        If NumericUpDown14.Value = 12 Then
            PictureBox25.Image = My.Resources._0c00
        End If
        If NumericUpDown14.Value = 13 Then
            PictureBox25.Image = My.Resources._0d00
        End If
        If NumericUpDown14.Value = 14 Then
            PictureBox25.Image = My.Resources._0e00
        End If
        If NumericUpDown14.Value = 15 Then
            PictureBox25.Image = My.Resources._0f00
        End If
        If NumericUpDown14.Value = 16 Then
            PictureBox25.Image = My.Resources._1000
        End If
        If NumericUpDown14.Value = 17 Then
            PictureBox25.Image = My.Resources._1100
        End If
        If NumericUpDown14.Value = 18 Then
            PictureBox25.Image = My.Resources._1200
        End If
        If NumericUpDown14.Value = 19 Then
            PictureBox25.Image = My.Resources._1300
        End If
        If NumericUpDown14.Value = 20 Then
            PictureBox25.Image = My.Resources._1400
        End If
        If NumericUpDown14.Value = 21 Then
            PictureBox25.Image = My.Resources._1500
        End If
        If NumericUpDown14.Value = 22 Then
            PictureBox25.Image = My.Resources._1600
        End If
        If NumericUpDown14.Value = 23 Then
            PictureBox25.Image = My.Resources._1700
        End If
        If NumericUpDown14.Value = 24 Then
            PictureBox25.Image = My.Resources._1800
        End If
        If NumericUpDown14.Value = 25 Then
            PictureBox25.Image = My.Resources._1900
        End If
        If NumericUpDown14.Value = 26 Then
            PictureBox25.Image = My.Resources._1a00
        End If
        If NumericUpDown14.Value = 27 Then
            PictureBox25.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown18_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown18.ValueChanged
        If NumericUpDown18.Value = 65535 Then
            PictureBox29.Image = Nothing
        End If
        If NumericUpDown18.Value = 0 Then
            PictureBox29.Image = My.Resources._0000
        End If
        If NumericUpDown18.Value = 1 Then
            PictureBox29.Image = My.Resources._0100
        End If
        If NumericUpDown18.Value = 2 Then
            PictureBox29.Image = My.Resources._0200
        End If
        If NumericUpDown18.Value = 3 Then
            PictureBox29.Image = My.Resources._0300
        End If
        If NumericUpDown18.Value = 4 Then
            PictureBox29.Image = My.Resources._0400
        End If
        If NumericUpDown18.Value = 5 Then
            PictureBox29.Image = My.Resources._0500
        End If
        If NumericUpDown18.Value = 6 Then
            PictureBox29.Image = My.Resources._0600
        End If
        If NumericUpDown18.Value = 7 Then
            PictureBox29.Image = My.Resources._0700
        End If
        If NumericUpDown18.Value = 8 Then
            PictureBox29.Image = My.Resources._0800
        End If
        If NumericUpDown18.Value = 9 Then
            PictureBox29.Image = My.Resources._0900
        End If
        If NumericUpDown18.Value = 10 Then
            PictureBox29.Image = My.Resources._0a00
        End If
        If NumericUpDown18.Value = 11 Then
            PictureBox29.Image = My.Resources._0b00
        End If
        If NumericUpDown18.Value = 12 Then
            PictureBox29.Image = My.Resources._0c00
        End If
        If NumericUpDown18.Value = 13 Then
            PictureBox29.Image = My.Resources._0d00
        End If
        If NumericUpDown18.Value = 14 Then
            PictureBox29.Image = My.Resources._0e00
        End If
        If NumericUpDown18.Value = 15 Then
            PictureBox29.Image = My.Resources._0f00
        End If
        If NumericUpDown18.Value = 16 Then
            PictureBox29.Image = My.Resources._1000
        End If
        If NumericUpDown18.Value = 17 Then
            PictureBox29.Image = My.Resources._1100
        End If
        If NumericUpDown18.Value = 18 Then
            PictureBox29.Image = My.Resources._1200
        End If
        If NumericUpDown18.Value = 19 Then
            PictureBox29.Image = My.Resources._1300
        End If
        If NumericUpDown18.Value = 20 Then
            PictureBox29.Image = My.Resources._1400
        End If
        If NumericUpDown18.Value = 21 Then
            PictureBox29.Image = My.Resources._1500
        End If
        If NumericUpDown18.Value = 22 Then
            PictureBox29.Image = My.Resources._1600
        End If
        If NumericUpDown18.Value = 23 Then
            PictureBox29.Image = My.Resources._1700
        End If
        If NumericUpDown18.Value = 24 Then
            PictureBox29.Image = My.Resources._1800
        End If
        If NumericUpDown18.Value = 25 Then
            PictureBox29.Image = My.Resources._1900
        End If
        If NumericUpDown18.Value = 26 Then
            PictureBox29.Image = My.Resources._1a00
        End If
        If NumericUpDown18.Value = 27 Then
            PictureBox29.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown17_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown17.ValueChanged
        If NumericUpDown17.Value = 65535 Then
            PictureBox28.Image = Nothing
        End If
        If NumericUpDown17.Value = 0 Then
            PictureBox28.Image = My.Resources._0000
        End If
        If NumericUpDown17.Value = 1 Then
            PictureBox28.Image = My.Resources._0100
        End If
        If NumericUpDown17.Value = 2 Then
            PictureBox28.Image = My.Resources._0200
        End If
        If NumericUpDown17.Value = 3 Then
            PictureBox28.Image = My.Resources._0300
        End If
        If NumericUpDown17.Value = 4 Then
            PictureBox28.Image = My.Resources._0400
        End If
        If NumericUpDown17.Value = 5 Then
            PictureBox28.Image = My.Resources._0500
        End If
        If NumericUpDown17.Value = 6 Then
            PictureBox28.Image = My.Resources._0600
        End If
        If NumericUpDown17.Value = 7 Then
            PictureBox28.Image = My.Resources._0700
        End If
        If NumericUpDown17.Value = 8 Then
            PictureBox28.Image = My.Resources._0800
        End If
        If NumericUpDown17.Value = 9 Then
            PictureBox28.Image = My.Resources._0900
        End If
        If NumericUpDown17.Value = 10 Then
            PictureBox28.Image = My.Resources._0a00
        End If
        If NumericUpDown17.Value = 11 Then
            PictureBox28.Image = My.Resources._0b00
        End If
        If NumericUpDown17.Value = 12 Then
            PictureBox28.Image = My.Resources._0c00
        End If
        If NumericUpDown17.Value = 13 Then
            PictureBox28.Image = My.Resources._0d00
        End If
        If NumericUpDown17.Value = 14 Then
            PictureBox28.Image = My.Resources._0e00
        End If
        If NumericUpDown17.Value = 15 Then
            PictureBox28.Image = My.Resources._0f00
        End If
        If NumericUpDown17.Value = 16 Then
            PictureBox28.Image = My.Resources._1000
        End If
        If NumericUpDown17.Value = 17 Then
            PictureBox28.Image = My.Resources._1100
        End If
        If NumericUpDown17.Value = 18 Then
            PictureBox28.Image = My.Resources._1200
        End If
        If NumericUpDown17.Value = 19 Then
            PictureBox28.Image = My.Resources._1300
        End If
        If NumericUpDown17.Value = 20 Then
            PictureBox28.Image = My.Resources._1400
        End If
        If NumericUpDown17.Value = 21 Then
            PictureBox28.Image = My.Resources._1500
        End If
        If NumericUpDown17.Value = 22 Then
            PictureBox28.Image = My.Resources._1600
        End If
        If NumericUpDown17.Value = 23 Then
            PictureBox28.Image = My.Resources._1700
        End If
        If NumericUpDown17.Value = 24 Then
            PictureBox28.Image = My.Resources._1800
        End If
        If NumericUpDown17.Value = 25 Then
            PictureBox28.Image = My.Resources._1900
        End If
        If NumericUpDown17.Value = 26 Then
            PictureBox28.Image = My.Resources._1a00
        End If
        If NumericUpDown17.Value = 27 Then
            PictureBox28.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown16_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown16.ValueChanged
        If NumericUpDown16.Value = 65535 Then
            PictureBox27.Image = Nothing
        End If
        If NumericUpDown16.Value = 0 Then
            PictureBox27.Image = My.Resources._0000
        End If
        If NumericUpDown16.Value = 1 Then
            PictureBox27.Image = My.Resources._0100
        End If
        If NumericUpDown16.Value = 2 Then
            PictureBox27.Image = My.Resources._0200
        End If
        If NumericUpDown16.Value = 3 Then
            PictureBox27.Image = My.Resources._0300
        End If
        If NumericUpDown16.Value = 4 Then
            PictureBox27.Image = My.Resources._0400
        End If
        If NumericUpDown16.Value = 5 Then
            PictureBox27.Image = My.Resources._0500
        End If
        If NumericUpDown16.Value = 6 Then
            PictureBox27.Image = My.Resources._0600
        End If
        If NumericUpDown16.Value = 7 Then
            PictureBox27.Image = My.Resources._0700
        End If
        If NumericUpDown16.Value = 8 Then
            PictureBox27.Image = My.Resources._0800
        End If
        If NumericUpDown16.Value = 9 Then
            PictureBox27.Image = My.Resources._0900
        End If
        If NumericUpDown16.Value = 10 Then
            PictureBox27.Image = My.Resources._0a00
        End If
        If NumericUpDown16.Value = 11 Then
            PictureBox27.Image = My.Resources._0b00
        End If
        If NumericUpDown16.Value = 12 Then
            PictureBox27.Image = My.Resources._0c00
        End If
        If NumericUpDown16.Value = 13 Then
            PictureBox27.Image = My.Resources._0d00
        End If
        If NumericUpDown16.Value = 14 Then
            PictureBox27.Image = My.Resources._0e00
        End If
        If NumericUpDown16.Value = 15 Then
            PictureBox27.Image = My.Resources._0f00
        End If
        If NumericUpDown16.Value = 16 Then
            PictureBox27.Image = My.Resources._1000
        End If
        If NumericUpDown16.Value = 17 Then
            PictureBox27.Image = My.Resources._1100
        End If
        If NumericUpDown16.Value = 18 Then
            PictureBox27.Image = My.Resources._1200
        End If
        If NumericUpDown16.Value = 19 Then
            PictureBox27.Image = My.Resources._1300
        End If
        If NumericUpDown16.Value = 20 Then
            PictureBox27.Image = My.Resources._1400
        End If
        If NumericUpDown16.Value = 21 Then
            PictureBox27.Image = My.Resources._1500
        End If
        If NumericUpDown16.Value = 22 Then
            PictureBox27.Image = My.Resources._1600
        End If
        If NumericUpDown16.Value = 23 Then
            PictureBox27.Image = My.Resources._1700
        End If
        If NumericUpDown16.Value = 24 Then
            PictureBox27.Image = My.Resources._1800
        End If
        If NumericUpDown16.Value = 25 Then
            PictureBox27.Image = My.Resources._1900
        End If
        If NumericUpDown16.Value = 26 Then
            PictureBox27.Image = My.Resources._1a00
        End If
        If NumericUpDown16.Value = 27 Then
            PictureBox27.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown15_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown15.ValueChanged
        If NumericUpDown15.Value = 65535 Then
            PictureBox26.Image = Nothing
        End If
        If NumericUpDown15.Value = 0 Then
            PictureBox26.Image = My.Resources._0000
        End If
        If NumericUpDown15.Value = 1 Then
            PictureBox26.Image = My.Resources._0100
        End If
        If NumericUpDown15.Value = 2 Then
            PictureBox26.Image = My.Resources._0200
        End If
        If NumericUpDown15.Value = 3 Then
            PictureBox26.Image = My.Resources._0300
        End If
        If NumericUpDown15.Value = 4 Then
            PictureBox26.Image = My.Resources._0400
        End If
        If NumericUpDown15.Value = 5 Then
            PictureBox26.Image = My.Resources._0500
        End If
        If NumericUpDown15.Value = 6 Then
            PictureBox26.Image = My.Resources._0600
        End If
        If NumericUpDown15.Value = 7 Then
            PictureBox26.Image = My.Resources._0700
        End If
        If NumericUpDown15.Value = 8 Then
            PictureBox26.Image = My.Resources._0800
        End If
        If NumericUpDown15.Value = 9 Then
            PictureBox26.Image = My.Resources._0900
        End If
        If NumericUpDown15.Value = 10 Then
            PictureBox26.Image = My.Resources._0a00
        End If
        If NumericUpDown15.Value = 11 Then
            PictureBox26.Image = My.Resources._0b00
        End If
        If NumericUpDown15.Value = 12 Then
            PictureBox26.Image = My.Resources._0c00
        End If
        If NumericUpDown15.Value = 13 Then
            PictureBox26.Image = My.Resources._0d00
        End If
        If NumericUpDown15.Value = 14 Then
            PictureBox26.Image = My.Resources._0e00
        End If
        If NumericUpDown15.Value = 15 Then
            PictureBox26.Image = My.Resources._0f00
        End If
        If NumericUpDown15.Value = 16 Then
            PictureBox26.Image = My.Resources._1000
        End If
        If NumericUpDown15.Value = 17 Then
            PictureBox26.Image = My.Resources._1100
        End If
        If NumericUpDown15.Value = 18 Then
            PictureBox26.Image = My.Resources._1200
        End If
        If NumericUpDown15.Value = 19 Then
            PictureBox26.Image = My.Resources._1300
        End If
        If NumericUpDown15.Value = 20 Then
            PictureBox26.Image = My.Resources._1400
        End If
        If NumericUpDown15.Value = 21 Then
            PictureBox26.Image = My.Resources._1500
        End If
        If NumericUpDown15.Value = 22 Then
            PictureBox26.Image = My.Resources._1600
        End If
        If NumericUpDown15.Value = 23 Then
            PictureBox26.Image = My.Resources._1700
        End If
        If NumericUpDown15.Value = 24 Then
            PictureBox26.Image = My.Resources._1800
        End If
        If NumericUpDown15.Value = 25 Then
            PictureBox26.Image = My.Resources._1900
        End If
        If NumericUpDown15.Value = 26 Then
            PictureBox26.Image = My.Resources._1a00
        End If
        If NumericUpDown15.Value = 27 Then
            PictureBox26.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form8.Show()
    End Sub

    Private Sub NumericUpDown20_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown20.ValueChanged
        If NumericUpDown20.Value = 0 Then
            PictureBox32.Image = My.Resources.exp0
        End If
        If NumericUpDown20.Value = 1 Then
            PictureBox32.Image = My.Resources.exp1
        End If
        If NumericUpDown20.Value = 2 Then
            PictureBox32.Image = My.Resources.exp2
        End If
        If NumericUpDown20.Value = 3 Then
            PictureBox32.Image = My.Resources.exp3
        End If
        If NumericUpDown20.Value = 4 Then
            PictureBox32.Image = My.Resources.exp4
        End If
        If NumericUpDown20.Value = 5 Then
            PictureBox32.Image = My.Resources.exp5
        End If
        If NumericUpDown20.Value = 6 Then
            PictureBox32.Image = My.Resources.exp6
        End If
        If NumericUpDown20.Value = 7 Then
            PictureBox32.Image = My.Resources.exp7
        End If
        If NumericUpDown20.Value = 8 Then
            PictureBox32.Image = My.Resources.exp8
        End If
        If NumericUpDown20.Value = 9 Then
            PictureBox32.Image = My.Resources.exp9
        End If
        If NumericUpDown20.Value = 10 Then
            PictureBox32.Image = My.Resources.exp10
        End If
        If NumericUpDown20.Value = 11 Then
            PictureBox32.Image = My.Resources.exp11
        End If
        If NumericUpDown20.Value = 12 Then
            PictureBox32.Image = My.Resources.exp12
        End If
        If NumericUpDown20.Value = 13 Then
            PictureBox32.Image = My.Resources.exp13
        End If
        If NumericUpDown20.Value = 14 Then
            PictureBox32.Image = My.Resources.exp14
        End If
        If NumericUpDown20.Value = 15 Then
            PictureBox32.Image = My.Resources.exp15
        End If
        If NumericUpDown20.Value = 16 Then
            PictureBox32.Image = My.Resources.exp16
        End If
        If NumericUpDown20.Value = 17 Then
            PictureBox32.Image = My.Resources.exp17
        End If
        If NumericUpDown20.Value = 18 Then
            PictureBox32.Image = My.Resources.exp18
        End If
        If NumericUpDown20.Value = 19 Then
            PictureBox32.Image = My.Resources.exp19
        End If
        If NumericUpDown20.Value = 20 Then
            PictureBox32.Image = My.Resources.exp20
        End If
        If NumericUpDown20.Value = 21 Then
            PictureBox32.Image = My.Resources.exp21
        End If
        If NumericUpDown20.Value = 22 Then
            PictureBox32.Image = My.Resources.exp22
        End If
        If NumericUpDown20.Value = 23 Then
            PictureBox32.Image = My.Resources.exp23
        End If
        If NumericUpDown20.Value = 24 Then
            PictureBox32.Image = My.Resources.exp24
        End If
        If NumericUpDown20.Value = 25 Then
            PictureBox32.Image = My.Resources.exp25
        End If
        If NumericUpDown20.Value = 26 Then
            PictureBox32.Image = My.Resources.exp26
        End If
        If NumericUpDown20.Value = 27 Then
            PictureBox32.Image = My.Resources.exp27
        End If
        If NumericUpDown20.Value = 28 Then
            PictureBox32.Image = My.Resources.exp28
        End If
        If NumericUpDown20.Value = 29 Then
            PictureBox32.Image = My.Resources.exp29
        End If
        If NumericUpDown20.Value = 30 Then
            PictureBox32.Image = My.Resources.exp30
        End If
        If NumericUpDown20.Value = 31 Then
            PictureBox32.Image = My.Resources.exp31
        End If
        If NumericUpDown20.Value = 32 Then
            PictureBox32.Image = My.Resources.exp32
        End If
        If NumericUpDown20.Value = 33 Then
            PictureBox32.Image = My.Resources.exp33
        End If
        If NumericUpDown20.Value = 34 Then
            PictureBox32.Image = My.Resources.exp34
        End If
        If NumericUpDown20.Value = 35 Then
            PictureBox32.Image = My.Resources.exp35
        End If
        If NumericUpDown20.Value = 36 Then
            PictureBox32.Image = My.Resources.exp36
        End If
        If NumericUpDown20.Value = 37 Then
            PictureBox32.Image = My.Resources.exp37
        End If
        If NumericUpDown20.Value = 38 Then
            PictureBox32.Image = My.Resources.exp38
        End If
        If NumericUpDown20.Value = 39 Then
            PictureBox32.Image = My.Resources.exp39
        End If
        If NumericUpDown20.Value = 40 Then
            PictureBox32.Image = My.Resources.exp40
        End If
        If NumericUpDown20.Value = 41 Then
            PictureBox32.Image = My.Resources.exp41
        End If
        If NumericUpDown20.Value = 42 Then
            PictureBox32.Image = My.Resources.exp42
        End If
        If NumericUpDown20.Value = 43 Then
            PictureBox32.Image = My.Resources.exp43
        End If
        If NumericUpDown20.Value = 44 Then
            PictureBox32.Image = My.Resources.exp44
        End If
        If NumericUpDown20.Value = 45 Then
            PictureBox32.Image = My.Resources.exp45
        End If
        If NumericUpDown20.Value = 46 Then
            PictureBox32.Image = My.Resources.exp46
        End If
        If NumericUpDown20.Value = 47 Then
            PictureBox32.Image = My.Resources.exp47
        End If
        If NumericUpDown20.Value = 48 Then
            PictureBox32.Image = My.Resources.exp48
        End If
        If NumericUpDown20.Value = 49 Then
            PictureBox32.Image = My.Resources.exp49
        End If
        If NumericUpDown20.Value = 50 Then
            PictureBox32.Image = My.Resources.exp50
        End If
        If NumericUpDown20.Value = 51 Then
            PictureBox32.Image = My.Resources.exp51
        End If
        If NumericUpDown20.Value = 52 Then
            PictureBox32.Image = My.Resources.exp52
        End If
        If NumericUpDown20.Value = 53 Then
            PictureBox32.Image = My.Resources.exp53
        End If
        If NumericUpDown20.Value = 54 Then
            PictureBox32.Image = My.Resources.exp54
        End If
        If NumericUpDown20.Value = 55 Then
            PictureBox32.Image = My.Resources.exp55
        End If
        If NumericUpDown20.Value = 56 Then
            PictureBox32.Image = My.Resources.exp56
        End If
        If NumericUpDown20.Value = 57 Then
            PictureBox32.Image = My.Resources.exp57
        End If
        If NumericUpDown20.Value = 58 Then
            PictureBox32.Image = My.Resources.exp58
        End If
        If NumericUpDown20.Value = 59 Then
            PictureBox32.Image = My.Resources.exp59
        End If
        If NumericUpDown20.Value = 60 Then
            PictureBox32.Image = My.Resources.exp60
        End If
        If NumericUpDown20.Value = 61 Then
            PictureBox32.Image = My.Resources.exp61
        End If
        If NumericUpDown20.Value = 62 Then
            PictureBox32.Image = My.Resources.exp62
        End If
        If NumericUpDown20.Value = 63 Then
            PictureBox32.Image = My.Resources.exp63
        End If
        If NumericUpDown20.Value = 64 Then
            PictureBox32.Image = My.Resources.exp64
        End If
        If NumericUpDown20.Value = 65 Then
            PictureBox32.Image = My.Resources.exp65
        End If
        If NumericUpDown20.Value = 66 Then
            PictureBox32.Image = My.Resources.exp66
        End If
        If NumericUpDown20.Value = 67 Then
            PictureBox32.Image = My.Resources.exp67
        End If
        If NumericUpDown20.Value = 68 Then
            PictureBox32.Image = My.Resources.exp68
        End If
        If NumericUpDown20.Value = 69 Then
            PictureBox32.Image = My.Resources.exp69
        End If
        If NumericUpDown20.Value = 70 Then
            PictureBox32.Image = My.Resources.exp70
        End If
        If NumericUpDown20.Value = 71 Then
            PictureBox32.Image = My.Resources.exp71
        End If
        If NumericUpDown20.Value = 72 Then
            PictureBox32.Image = My.Resources.exp72
        End If
        If NumericUpDown20.Value = 73 Then
            PictureBox32.Image = My.Resources.exp73
        End If
        If NumericUpDown20.Value = 74 Then
            PictureBox32.Image = My.Resources.exp74
        End If
        If NumericUpDown20.Value = 75 Then
            PictureBox32.Image = My.Resources.exp75
        End If
        If NumericUpDown20.Value = 76 Then
            PictureBox32.Image = My.Resources.exp76
        End If
        If NumericUpDown20.Value = 77 Then
            PictureBox32.Image = My.Resources.exp77
        End If
        If NumericUpDown20.Value = 78 Then
            PictureBox32.Image = My.Resources.exp78
        End If
        If NumericUpDown20.Value = 79 Then
            PictureBox32.Image = My.Resources.exp79
        End If
        If NumericUpDown20.Value = 80 Then
            PictureBox32.Image = My.Resources.exp80
        End If
        If NumericUpDown20.Value = 81 Then
            PictureBox32.Image = My.Resources.exp81
        End If
        If NumericUpDown20.Value = 82 Then
            PictureBox32.Image = My.Resources.exp82
        End If
        If NumericUpDown20.Value = 83 Then
            PictureBox32.Image = My.Resources.exp83
        End If
        If NumericUpDown20.Value = 84 Then
            PictureBox32.Image = My.Resources.exp84
        End If
        If NumericUpDown20.Value = 85 Then
            PictureBox32.Image = My.Resources.exp85
        End If
        If NumericUpDown20.Value = 86 Then
            PictureBox32.Image = My.Resources.exp86
        End If
        If NumericUpDown20.Value = 87 Then
            PictureBox32.Image = My.Resources.exp87
        End If
        If NumericUpDown20.Value = 88 Then
            PictureBox32.Image = My.Resources.exp88
        End If
        If NumericUpDown20.Value = 89 Then
            PictureBox32.Image = My.Resources.exp89
        End If
        If NumericUpDown20.Value = 90 Then
            PictureBox32.Image = My.Resources.exp90
        End If
        If NumericUpDown20.Value = 91 Then
            PictureBox32.Image = My.Resources.exp91
        End If
        If NumericUpDown20.Value = 92 Then
            PictureBox32.Image = My.Resources.exp92
        End If
        If NumericUpDown20.Value = 93 Then
            PictureBox32.Image = My.Resources.exp93
        End If
        If NumericUpDown20.Value = 94 Then
            PictureBox32.Image = My.Resources.exp94
        End If
        If NumericUpDown20.Value = 95 Then
            PictureBox32.Image = My.Resources.exp95
        End If
        If NumericUpDown20.Value = 96 Then
            PictureBox32.Image = My.Resources.exp96
        End If
        If NumericUpDown20.Value = 97 Then
            PictureBox32.Image = My.Resources.exp97
        End If
        If NumericUpDown20.Value = 98 Then
            PictureBox32.Image = My.Resources.exp98
        End If
        If NumericUpDown20.Value = 99 Then
            PictureBox32.Image = My.Resources.exp99
        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Form9.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            NumericUpDown21.Value = 0
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = eat
            Writer.WriteInt8(0)
        End If
    End Sub

    Private Sub NumericUpDown21_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown21.ValueChanged
        If NumericUpDown21.Value = 0 Then
            PictureBox33.Image = My.Resources.fullness_estomac
        End If
        If NumericUpDown21.Value = 25 Then
            PictureBox33.Image = My.Resources.fullness_estomac25
        End If
        If NumericUpDown21.Value = 50 Then
            PictureBox33.Image = My.Resources.fullness_estomac50
        End If
        If NumericUpDown21.Value = 75 Then
            PictureBox33.Image = My.Resources.fullness_estomac75
        End If
        If NumericUpDown21.Value = 100 Then
            PictureBox33.Image = My.Resources.fullness_estomac100
        End If
        
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Form10.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form11.Show()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 3574
                Writer.Position = &H30 + i
                Writer.WriteUInt16(65278)
            Next
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 229
                Writer.Position = &H17F0 + i
                Writer.WriteUInt16(65278)
            Next
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 101
                Writer.Position = &H1778 + i
                Writer.WriteUInt16(65278)
            Next
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 37
                    Writer.Position = &HFF8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1020 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1030 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1040 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1058 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1060 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1088 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 14
                    Writer.Position = &H10C8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H10F0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1100 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1120 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1130 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1150 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1158 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1160 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1168 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1170 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 30
                    Writer.Position = &H1180 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1130 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 37
                    Writer.Position = &H11A8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 21
                    Writer.Position = &H11D0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H11E8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H1200 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1210 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 30
                    Writer.Position = &H1218 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1240 + i
                    Writer.WriteUInt16(65278)
                Next

                Writer.Position = &H1260
                Writer.WriteUInt16(65022)

                For i As Integer = 0 To 45
                    Writer.Position = &H1268 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1298 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H12A0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 69
                    Writer.Position = &H12B0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1300 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1320 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 45
                    Writer.Position = &H1328 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1360 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1370 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1390 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H1398 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H13B8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H13C8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H13E8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H13F0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H13F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1410 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1418 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1420 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1430 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H1448 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1458 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1460 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1468 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 46
                    Writer.Position = &H1490 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H14D0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H14E0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1508 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1510 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1518 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 7
                    Writer.Position = &H1530 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 20
                    Writer.Position = &H1550 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1568 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1570 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1578 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1580 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1588 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1598 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15B0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 14
                    Writer.Position = &H15D8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1618 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1618 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1650 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1668 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1670 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1678 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1680 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1688 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1698 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H16B8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H16C8 + i
                    Writer.WriteUInt16(65278)
                Next
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 46
                    Writer.Position = &HFF8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1030 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1040 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1058 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1060 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1080 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 14
                    Writer.Position = &H10C0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H10F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1108 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1128 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1138 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1158 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1160 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1168 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1170 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 38
                    Writer.Position = &H1178 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 37
                    Writer.Position = &H11A8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 21
                    Writer.Position = &H11D0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H11E8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H1200 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1210 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 30
                    Writer.Position = &H1218 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1240 + i
                    Writer.WriteUInt16(65278)
                Next

                Writer.Position = &H1260
                Writer.WriteUInt16(65022)

                For i As Integer = 0 To 45
                    Writer.Position = &H1268 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1298 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H12A0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 69
                    Writer.Position = &H12B0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1300 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1320 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 45
                    Writer.Position = &H1328 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1360 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1370 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1390 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H1398 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H13B8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H13C8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H13E8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H13F0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H13F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1410 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1418 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1420 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1430 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H1448 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1458 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1460 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1468 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 46
                    Writer.Position = &H1490 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H14D0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H14E0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1508 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1510 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1518 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 7
                    Writer.Position = &H1530 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 20
                    Writer.Position = &H1550 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1568 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H1570 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1580 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1588 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1598 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15B0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15D8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15E0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15F8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1618 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1650 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1668 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1670 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1678 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1680 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1688 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1698 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A0 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H16B8 + i
                    Writer.WriteUInt16(65278)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H16C8 + i
                    Writer.WriteUInt16(65278)
                Next
            End If
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &HFF8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1020 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1088 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1178 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H11B0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H1228 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1270 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12C8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12D8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1300 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1378 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1458 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1578 + i
                    Writer.WriteUInt16(65278)
                Next
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &H1020 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1080 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1180 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1228 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12C8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12D8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1378 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H13C0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1468 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1578 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1588 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1668 + i
                    Writer.WriteUInt16(65278)
                Next
            End If
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &H60 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HC8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H100 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H138 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H160 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H180 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H190 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1D8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H250 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H280 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H2B8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H2F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H328 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H60 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H460 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H478 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H490 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H500 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H518 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H5A0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H5B8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H650 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H660 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H6E0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H720 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H7A0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H7B8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H848 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H868 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H8E0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H8F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H918 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H968 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H988 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9B0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9C0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9F8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA08 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA38 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 30
                    Writer.Position = &HA70 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &HAF8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &HB08 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HB68 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &HCA0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HD28 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HE18 + i
                    Writer.WriteUInt16(65278)
                Next
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &H40 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H80 + i
                    Writer.WriteUInt16(65278)
                Next
                Writer.Position = &HC8
                Writer.WriteUInt16(65278)
                For i As Integer = 0 To 6
                    Writer.Position = &HD0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H108 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H168 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H188 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H198 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1E0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H258 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H288 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H2C8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H2D8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H308 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H480 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H498 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H4C0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H4F8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H508 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H520 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H538 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H568 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H5A0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H5B8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H660 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H670 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H6F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H730 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H7B0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H7B8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H7D0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H860 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H880 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H8F0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H900 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H928 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H978 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H998 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9C0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9D0 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA00 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA10 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA40 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 30
                    Writer.Position = &HA78 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &HB00 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &HB10 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HB70 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &HD88 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &HDA8 + i
                    Writer.WriteUInt16(65278)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HDD8 + i
                    Writer.WriteUInt16(65278)
                Next
            End If
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 3574
                Writer.Position = &H30 + i
                Writer.WriteUInt16(65021)
            Next
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 229
                Writer.Position = &H17F0 + i
                Writer.WriteUInt16(65021)
            Next
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 164
                Writer.Position = &H1902 + i
                Writer.WriteUInt16(65021)
            Next
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 16
                Writer.Position = &H18F0 + i
                Writer.WriteUInt16(65021)
            Next
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 101
                Writer.Position = &H1778 + i
                Writer.WriteUInt16(65021)
            Next
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 37
                    Writer.Position = &HFF8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1020 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1030 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1040 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1058 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1060 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1088 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 14
                    Writer.Position = &H10C8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H10F0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1100 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1120 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1130 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1150 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1158 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1160 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1168 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1170 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 30
                    Writer.Position = &H1180 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1130 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 37
                    Writer.Position = &H11A8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 21
                    Writer.Position = &H11D0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H11E8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H1200 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1210 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 30
                    Writer.Position = &H1218 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1240 + i
                    Writer.WriteUInt16(65021)
                Next

                Writer.Position = &H1260
                Writer.WriteUInt16(65021)

                For i As Integer = 0 To 45
                    Writer.Position = &H1268 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1298 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H12A0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 69
                    Writer.Position = &H12B0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1300 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1320 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 45
                    Writer.Position = &H1328 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1360 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1370 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1390 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H1398 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H13B8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H13C8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H13E8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H13F0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H13F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1410 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1418 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1420 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1430 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H1448 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1458 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1460 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1468 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 46
                    Writer.Position = &H1490 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H14D0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H14E0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1508 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1510 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1518 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 7
                    Writer.Position = &H1530 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 20
                    Writer.Position = &H1550 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1568 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1570 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1578 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1580 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1588 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1598 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15B0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 14
                    Writer.Position = &H15D8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1618 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1618 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1650 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1668 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1670 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1678 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1680 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1688 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1698 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H16B8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H16C8 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 46
                    Writer.Position = &HFF8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1030 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1040 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1058 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1060 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1080 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 14
                    Writer.Position = &H10C0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H10F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1108 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1128 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1138 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1158 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1160 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1168 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1170 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 38
                    Writer.Position = &H1178 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 37
                    Writer.Position = &H11A8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 21
                    Writer.Position = &H11D0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H11E8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H1200 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1210 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 30
                    Writer.Position = &H1218 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1240 + i
                    Writer.WriteUInt16(65021)
                Next

                Writer.Position = &H1260
                Writer.WriteUInt16(65021)

                For i As Integer = 0 To 45
                    Writer.Position = &H1268 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1298 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H12A0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 69
                    Writer.Position = &H12B0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 28
                    Writer.Position = &H1300 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1320 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 45
                    Writer.Position = &H1328 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1360 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H1370 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1390 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H1398 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 12
                    Writer.Position = &H13B8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 29
                    Writer.Position = &H13C8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H13E8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H13F0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H13F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1410 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1418 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1420 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 11
                    Writer.Position = &H1430 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H1448 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1458 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1460 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H1468 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 46
                    Writer.Position = &H1490 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H14D0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 10
                    Writer.Position = &H14E0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H14F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1508 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1510 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1518 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 7
                    Writer.Position = &H1530 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 20
                    Writer.Position = &H1550 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1568 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 13
                    Writer.Position = &H1570 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1580 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1588 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H1598 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15B0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H15C8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15D8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15E0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H15F8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1618 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1650 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H1668 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1670 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1678 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1680 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1688 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 4
                    Writer.Position = &H1698 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A0 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 3
                    Writer.Position = &H16A8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 5
                    Writer.Position = &H16B8 + i
                    Writer.WriteUInt16(65021)
                Next

                For i As Integer = 0 To 6
                    Writer.Position = &H16C8 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H1A14
                Writer.WriteUInt16(65021)
                For i As Integer = 0 To 46
                    Writer.Position = &H1A16 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H19E2
                Writer.WriteUInt16(65021)
                For i As Integer = 0 To 46
                    Writer.Position = &H19E4 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &HFF8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1020 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1088 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1178 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H11B0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H1228 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1270 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12C8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12D8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1300 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1378 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1458 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1578 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &H1020 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1080 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1180 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H11F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1228 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12C8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H12D8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H12F8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1358 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H1378 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H13C0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 2
                    Writer.Position = &H1440 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1468 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1578 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1588 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &H1668 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &H60 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HC8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H100 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H138 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H160 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H180 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H190 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1D8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H250 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H280 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H2B8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H2F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H328 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H60 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H460 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H478 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H490 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H500 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H518 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H5A0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H5B8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H650 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H660 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H6E0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H720 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H7A0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H7B8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H848 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H868 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H8E0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H8F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H918 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H968 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H988 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9B0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9C0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9F8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA08 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA38 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 30
                    Writer.Position = &HA70 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &HAF8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &HB08 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HB68 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &HCA0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HD28 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HE18 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 6
                    Writer.Position = &H40 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H80 + i
                    Writer.WriteUInt16(65021)
                Next
                Writer.Position = &HC8
                Writer.WriteUInt16(65278)
                For i As Integer = 0 To 6
                    Writer.Position = &HD0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H108 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H168 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H188 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H198 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H1E0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H258 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H288 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H2C8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H2D8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H308 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H480 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H498 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H4C0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H4F8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H508 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H520 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H538 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H568 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &H5A0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H5B8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H660 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H670 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &H6F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H730 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 4
                    Writer.Position = &H7B0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H7B8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H7D0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H860 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H880 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H8F0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H900 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H928 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H978 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H998 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9C0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &H9D0 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA00 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA10 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HA40 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 30
                    Writer.Position = &HA78 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 3
                    Writer.Position = &HB00 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &HB10 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HB70 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 14
                    Writer.Position = &HD88 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 5
                    Writer.Position = &HDA8 + i
                    Writer.WriteUInt16(65021)
                Next
                For i As Integer = 0 To 6
                    Writer.Position = &HDD8 + i
                    Writer.WriteUInt16(65021)
                Next
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WriteFileJP1()
    End Sub
    Private Sub WriteFileJP1()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = Mii1L
            Writer.WriteInt8(NumericUpDown102.Value)
            For i As Integer = 0 To 29
                Writer.Position = Mii1P + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1P
            Writer.WriteUnicodeString(TextBox3.Text)
            For i As Integer = 0 To 29
                Writer.Position = Mii1N + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Mii1N
            Writer.WriteUnicodeString(TextBox4.Text)
            Writer.Position = Mii1R
            Writer.WriteInt8(NumericUpDown9.Value)
            Writer.Position = objet1
            Writer.WriteUInt16(NumericUpDown11.Value)
            Writer.Position = objet2
            Writer.WriteUInt16(NumericUpDown12.Value)
            Writer.Position = objet3
            Writer.WriteUInt16(NumericUpDown13.Value)
            Writer.Position = objet4
            Writer.WriteUInt16(NumericUpDown14.Value)
            Writer.Position = objet5
            Writer.WriteUInt16(NumericUpDown18.Value)
            Writer.Position = objet6
            Writer.WriteUInt16(NumericUpDown17.Value)
            Writer.Position = objet7
            Writer.WriteUInt16(NumericUpDown16.Value)
            Writer.Position = objet8
            Writer.WriteUInt16(NumericUpDown15.Value)
            Writer.Position = exp
            Writer.WriteInt8(NumericUpDown20.Value)
            Writer.Position = econom
            Writer.WriteInt32(NumericUpDown19.Value)

            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                        Changes Mii Save"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If

            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                Changements Mii Sauvegardé"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "                  Une erreur est survenue"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
            If ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "                   An error has occurred"
                fdialog.Label1.Location = New Point(3, 35)
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked = True Then
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H1E4C71
                Writer.WriteInt8(0)
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H1E4C71
                Writer.WriteInt8(0)
            End If
            If ComboBox12.SelectedItem = ComboBox12.Items.Item(2) Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H14BD41
                Writer.WriteInt8(0)
            End If
        End If
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        If ComboBox11.Text = "EN" Then
            fdialog.Label1.Text = "If ''Reset Tomodachi Life StreetPass/Spotpass''" & vbNewLine & "                         is used  " & vbNewLine & "You will be able to set up StreetPass/SpotPass" & vbNewLine & "         And change item sent to StreetPass"
            fdialog.Label1.Location = New Point(17, 11)
            fdialog.ShowDialog()
        End If
        If ComboBox11.Text = "FR" Then
            fdialog.Label1.Text = "        Si ''Réinitialiser StreetPass/Spotpass de" & vbNewLine & "               Tomodachi Life'' est utilisé" & vbNewLine & "Vous devrez paramétrer de nouveau SteetPass/SpotPass" & vbNewLine & "     Et ainsi changer d'objet envoyé par StreetPass"
            fdialog.Label1.Location = New Point(4, 11)
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        If NumericUpDown10.Value = 0 Then
            NumericUpDown10.Value = 2
        ElseIf NumericUpDown10.Value = 2 Then
            NumericUpDown10.Value = 1
        ElseIf NumericUpDown10.Value = 1 Then
            NumericUpDown10.Value = 0
        End If
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        If NumericUpDown22.Value = 0 Then
            NumericUpDown22.Value = 2
        ElseIf NumericUpDown22.Value = 2 Then
            NumericUpDown22.Value = 1
        ElseIf NumericUpDown22.Value = 1 Then
            NumericUpDown22.Value = 0
        End If
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        If NumericUpDown23.Value = 0 Then
            NumericUpDown23.Value = 2
        ElseIf NumericUpDown23.Value = 2 Then
            NumericUpDown23.Value = 1
        ElseIf NumericUpDown23.Value = 1 Then
            NumericUpDown23.Value = 0
        End If
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        If NumericUpDown24.Value = 0 Then
            NumericUpDown24.Value = 2
        ElseIf NumericUpDown24.Value = 2 Then
            NumericUpDown24.Value = 1
        ElseIf NumericUpDown24.Value = 1 Then
            NumericUpDown24.Value = 0
        End If
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        If NumericUpDown25.Value = 0 Then
            NumericUpDown25.Value = 2
        ElseIf NumericUpDown25.Value = 2 Then
            NumericUpDown25.Value = 1
        ElseIf NumericUpDown25.Value = 1 Then
            NumericUpDown25.Value = 0
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If NumericUpDown26.Value = 0 Then
            NumericUpDown26.Value = 2
        ElseIf NumericUpDown26.Value = 2 Then
            NumericUpDown26.Value = 1
        ElseIf NumericUpDown26.Value = 1 Then
            NumericUpDown26.Value = 0
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If NumericUpDown27.Value = 0 Then
            NumericUpDown27.Value = 2
        ElseIf NumericUpDown27.Value = 2 Then
            NumericUpDown27.Value = 1
        ElseIf NumericUpDown27.Value = 1 Then
            NumericUpDown27.Value = 0
        End If
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        If NumericUpDown28.Value = 0 Then
            NumericUpDown28.Value = 2
        ElseIf NumericUpDown28.Value = 2 Then
            NumericUpDown28.Value = 1
        ElseIf NumericUpDown28.Value = 1 Then
            NumericUpDown28.Value = 0
        End If
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        If NumericUpDown29.Value = 0 Then
            NumericUpDown29.Value = 2
        ElseIf NumericUpDown29.Value = 2 Then
            NumericUpDown29.Value = 1
        ElseIf NumericUpDown29.Value = 1 Then
            NumericUpDown29.Value = 0
        End If
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        If NumericUpDown30.Value = 0 Then
            NumericUpDown30.Value = 2
        ElseIf NumericUpDown30.Value = 2 Then
            NumericUpDown30.Value = 1
        ElseIf NumericUpDown30.Value = 1 Then
            NumericUpDown30.Value = 0
        End If
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        If NumericUpDown31.Value = 0 Then
            NumericUpDown31.Value = 2
        ElseIf NumericUpDown31.Value = 2 Then
            NumericUpDown31.Value = 1
        ElseIf NumericUpDown31.Value = 1 Then
            NumericUpDown31.Value = 0
        End If
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        If NumericUpDown32.Value = 0 Then
            NumericUpDown32.Value = 2
        ElseIf NumericUpDown32.Value = 2 Then
            NumericUpDown32.Value = 1
        ElseIf NumericUpDown32.Value = 1 Then
            NumericUpDown32.Value = 0
        End If
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        If NumericUpDown33.Value = 0 Then
            NumericUpDown33.Value = 2
        ElseIf NumericUpDown33.Value = 2 Then
            NumericUpDown33.Value = 1
        ElseIf NumericUpDown33.Value = 1 Then
            NumericUpDown33.Value = 0
        End If
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        If NumericUpDown34.Value = 0 Then
            NumericUpDown34.Value = 2
        ElseIf NumericUpDown34.Value = 2 Then
            NumericUpDown34.Value = 1
        ElseIf NumericUpDown34.Value = 1 Then
            NumericUpDown34.Value = 0
        End If
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        If NumericUpDown35.Value = 0 Then
            NumericUpDown35.Value = 2
        ElseIf NumericUpDown35.Value = 2 Then
            NumericUpDown35.Value = 1
        ElseIf NumericUpDown35.Value = 1 Then
            NumericUpDown35.Value = 0
        End If
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        If NumericUpDown36.Value = 0 Then
            NumericUpDown36.Value = 2
        ElseIf NumericUpDown36.Value = 2 Then
            NumericUpDown36.Value = 1
        ElseIf NumericUpDown36.Value = 1 Then
            NumericUpDown36.Value = 0
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If NumericUpDown37.Value = 0 Then
            NumericUpDown37.Value = 2
        ElseIf NumericUpDown37.Value = 2 Then
            NumericUpDown37.Value = 1
        ElseIf NumericUpDown37.Value = 1 Then
            NumericUpDown37.Value = 0
        End If
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        If NumericUpDown38.Value = 0 Then
            NumericUpDown38.Value = 2
        ElseIf NumericUpDown38.Value = 2 Then
            NumericUpDown38.Value = 1
        ElseIf NumericUpDown38.Value = 1 Then
            NumericUpDown38.Value = 0
        End If
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        If NumericUpDown39.Value = 0 Then
            NumericUpDown39.Value = 2
        ElseIf NumericUpDown39.Value = 2 Then
            NumericUpDown39.Value = 1
        ElseIf NumericUpDown39.Value = 1 Then
            NumericUpDown39.Value = 0
        End If
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        If NumericUpDown40.Value = 0 Then
            NumericUpDown40.Value = 2
        ElseIf NumericUpDown40.Value = 2 Then
            NumericUpDown40.Value = 1
        ElseIf NumericUpDown40.Value = 1 Then
            NumericUpDown40.Value = 0
        End If
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        If NumericUpDown41.Value = 0 Then
            NumericUpDown41.Value = 2
        ElseIf NumericUpDown41.Value = 2 Then
            NumericUpDown41.Value = 1
        ElseIf NumericUpDown41.Value = 1 Then
            NumericUpDown41.Value = 0
        End If
    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        If NumericUpDown42.Value = 0 Then
            NumericUpDown42.Value = 2
        ElseIf NumericUpDown42.Value = 2 Then
            NumericUpDown42.Value = 1
        ElseIf NumericUpDown42.Value = 1 Then
            NumericUpDown42.Value = 0
        End If
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        If NumericUpDown43.Value = 0 Then
            NumericUpDown43.Value = 2
        ElseIf NumericUpDown43.Value = 2 Then
            NumericUpDown43.Value = 1
        ElseIf NumericUpDown43.Value = 1 Then
            NumericUpDown43.Value = 0
        End If
    End Sub

    Private Sub NumericUpDown10_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.ValueChanged
        If NumericUpDown10.Value = 0 Then
            PictureBox56.Image = Nothing
        End If
        If NumericUpDown10.Value = 1 Then
            PictureBox56.Image = My.Resources.vet
        End If
        If NumericUpDown10.Value = 2 Then
            PictureBox56.Image = My.Resources.vetn
        End If
    End Sub

    Private Sub NumericUpDown22_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown22.ValueChanged
        If NumericUpDown22.Value = 0 Then
            PictureBox40.Image = Nothing
        End If
        If NumericUpDown22.Value = 1 Then
            PictureBox40.Image = My.Resources.deco
        End If
        If NumericUpDown22.Value = 2 Then
            PictureBox40.Image = My.Resources.decon
        End If
    End Sub

    Private Sub NumericUpDown23_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown23.ValueChanged
        If NumericUpDown23.Value = 0 Then
            PictureBox55.Image = Nothing
        End If
        If NumericUpDown23.Value = 1 Then
            PictureBox55.Image = My.Resources.tour
        End If
        If NumericUpDown23.Value = 2 Then
            PictureBox55.Image = My.Resources.tourn
        End If
    End Sub

    Private Sub NumericUpDown24_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown24.ValueChanged
        If NumericUpDown24.Value = 0 Then
            PictureBox47.Image = Nothing
        End If
        If NumericUpDown24.Value = 1 Then
            PictureBox47.Image = My.Resources.parc1
        End If
        If NumericUpDown24.Value = 2 Then
            PictureBox47.Image = My.Resources.parc1n
        End If
    End Sub

    Private Sub NumericUpDown25_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown25.ValueChanged
        If NumericUpDown25.Value = 0 Then
            PictureBox43.Image = Nothing
        End If
        If NumericUpDown25.Value = 1 Then
            PictureBox43.Image = My.Resources.info
        End If
        If NumericUpDown25.Value = 2 Then
            PictureBox43.Image = My.Resources.infon
        End If
    End Sub

    Private Sub NumericUpDown26_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown26.ValueChanged
        If NumericUpDown26.Value = 0 Then
            PictureBox21.Image = Nothing
        End If
        If NumericUpDown26.Value = 1 Then
            PictureBox21.Image = My.Resources.broc
        End If
        If NumericUpDown26.Value = 2 Then
            PictureBox21.Image = My.Resources.brocn
        End If
    End Sub

    Private Sub NumericUpDown27_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown27.ValueChanged
        If NumericUpDown27.Value = 0 Then
            PictureBox20.Image = Nothing
        End If
        If NumericUpDown27.Value = 1 Then
            PictureBox20.Image = My.Resources.appart
        End If
        If NumericUpDown27.Value = 2 Then
            PictureBox20.Image = My.Resources.appartn
        End If
    End Sub

    Private Sub NumericUpDown28_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown28.ValueChanged
        If NumericUpDown28.Value = 0 Then
            PictureBox45.Image = Nothing
        End If
        If NumericUpDown28.Value = 1 Then
            PictureBox45.Image = My.Resources.mair
        End If
        If NumericUpDown28.Value = 2 Then
            PictureBox45.Image = My.Resources.mairn
        End If
    End Sub

    Private Sub NumericUpDown29_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown29.ValueChanged
        If NumericUpDown29.Value = 0 Then
            PictureBox46.Image = Nothing
        End If
        If NumericUpDown29.Value = 1 Then
            PictureBox46.Image = My.Resources.mais
        End If
        If NumericUpDown29.Value = 2 Then
            PictureBox46.Image = My.Resources.maisn
        End If
    End Sub

    Private Sub NumericUpDown30_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown30.ValueChanged
        If NumericUpDown30.Value = 0 Then
            PictureBox48.Image = Nothing
        End If
        If NumericUpDown30.Value = 1 Then
            PictureBox48.Image = My.Resources.parc
        End If
        If NumericUpDown30.Value = 2 Then
            PictureBox48.Image = My.Resources.parcn
        End If
    End Sub

    Private Sub NumericUpDown31_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown31.ValueChanged
        If NumericUpDown31.Value = 0 Then
            PictureBox37.Image = Nothing
        End If
        If NumericUpDown31.Value = 1 Then
            PictureBox37.Image = My.Resources.chap
        End If
        If NumericUpDown31.Value = 2 Then
            PictureBox37.Image = My.Resources.chapn
        End If
    End Sub

    Private Sub NumericUpDown32_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown32.ValueChanged
        If NumericUpDown32.Value = 0 Then
            PictureBox42.Image = Nothing
        End If
        If NumericUpDown32.Value = 1 Then
            PictureBox42.Image = My.Resources.font
        End If
        If NumericUpDown32.Value = 2 Then
            PictureBox42.Image = My.Resources.fontn
        End If
    End Sub

    Private Sub NumericUpDown33_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown33.ValueChanged
        If NumericUpDown33.Value = 0 Then
            PictureBox39.Image = Nothing
        End If
        If NumericUpDown33.Value = 1 Then
            PictureBox39.Image = My.Resources.conc
        End If
        If NumericUpDown33.Value = 2 Then
            PictureBox39.Image = My.Resources.concn
        End If
    End Sub

    Private Sub NumericUpDown34_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown34.ValueChanged
        If NumericUpDown34.Value = 0 Then
            PictureBox38.Image = Nothing
        End If
        If NumericUpDown34.Value = 1 Then
            PictureBox38.Image = My.Resources.classem
        End If
        If NumericUpDown34.Value = 2 Then
            PictureBox38.Image = My.Resources.classn
        End If
    End Sub

    Private Sub NumericUpDown35_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown35.ValueChanged
        If NumericUpDown35.Value = 0 Then
            PictureBox53.Image = Nothing
        End If
        If NumericUpDown35.Value = 1 Then
            PictureBox53.Image = My.Resources.test
        End If
        If NumericUpDown35.Value = 2 Then
            PictureBox53.Image = My.Resources.testn
        End If
    End Sub

    Private Sub NumericUpDown36_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown36.ValueChanged
        If NumericUpDown36.Value = 0 Then
            PictureBox51.Image = Nothing
        End If
        If NumericUpDown36.Value = 1 Then
            PictureBox51.Image = My.Resources.stud
        End If
        If NumericUpDown36.Value = 2 Then
            PictureBox51.Image = My.Resources.studn
        End If
    End Sub

    Private Sub NumericUpDown37_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown37.ValueChanged
        If NumericUpDown37.Value = 0 Then
            PictureBox22.Image = Nothing
        End If
        If NumericUpDown37.Value = 1 Then
            PictureBox22.Image = My.Resources.cafe
        End If
        If NumericUpDown37.Value = 2 Then
            PictureBox22.Image = My.Resources.cafen
        End If
    End Sub

    Private Sub NumericUpDown38_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown38.ValueChanged
        If NumericUpDown38.Value = 0 Then
            PictureBox41.Image = Nothing
        End If
        If NumericUpDown38.Value = 1 Then
            PictureBox41.Image = My.Resources.epicer
        End If
        If NumericUpDown38.Value = 2 Then
            PictureBox41.Image = My.Resources.epicern
        End If
    End Sub

    Private Sub NumericUpDown39_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown39.ValueChanged
        If NumericUpDown39.Value = 0 Then
            PictureBox44.Image = Nothing
        End If
        If NumericUpDown39.Value = 1 Then
            PictureBox44.Image = My.Resources.magimport
        End If
        If NumericUpDown39.Value = 2 Then
            PictureBox44.Image = My.Resources.magimportn
        End If
    End Sub

    Private Sub NumericUpDown40_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown40.ValueChanged
        If NumericUpDown40.Value = 0 Then
            PictureBox49.Image = Nothing
        End If
        If NumericUpDown40.Value = 1 Then
            PictureBox49.Image = My.Resources.plage
        End If
        If NumericUpDown40.Value = 2 Then
            PictureBox49.Image = My.Resources.plagen
        End If
    End Sub

    Private Sub NumericUpDown41_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown41.ValueChanged
        If NumericUpDown41.Value = 0 Then
            PictureBox52.Image = Nothing
        End If
        If NumericUpDown41.Value = 1 Then
            PictureBox52.Image = My.Resources.tervague
        End If
        If NumericUpDown41.Value = 2 Then
            PictureBox52.Image = My.Resources.tervaguen
        End If
    End Sub

    Private Sub NumericUpDown42_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown42.ValueChanged
        If NumericUpDown42.Value = 0 Then
            PictureBox50.Image = Nothing
        End If
        If NumericUpDown42.Value = 1 Then
            PictureBox50.Image = My.Resources.port
        End If
        If NumericUpDown42.Value = 2 Then
            PictureBox50.Image = My.Resources.portn
        End If
    End Sub

    Private Sub NumericUpDown43_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown43.ValueChanged
        If NumericUpDown43.Value = 0 Then
            PictureBox54.Image = Nothing
        End If
        If NumericUpDown43.Value = 1 Then
            PictureBox54.Image = My.Resources.part
        End If
        If NumericUpDown43.Value = 2 Then
            PictureBox54.Image = My.Resources.partn
        End If
    End Sub
End Class
