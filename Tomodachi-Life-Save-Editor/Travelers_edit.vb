Imports System.IO
Imports PackageIO
Public Class Travelers_edit
    Dim Accesstravelers As String
    Dim savedataArc As String
    Dim stmexp As String
    Dim stmlv As String
    Dim stptravelers As String
    Dim TLexplorer As String
    Dim Datetraveler As String
    Dim Tent As String
    Dim interaction As String
    Dim unknow_1 As String
    Dim unknow_2 As String
    Dim unknow_3 As String
    Dim unknow_4 As String
    Dim unknow_5 As String
    Dim unknow_6 As String
    Dim unknow_7 As String
    Dim lastdatestp As String
    Dim target1 As String
    Dim target2 As String

    Public Sub readtravelers()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H392C0 + Accesstravelers
            Text_travelers.Text = Reader.ReadUnicodeString(10)
            Reader.Position = &H39500 + Accesstravelers
            Text_home.Text = Reader.ReadUnicodeString(10)
            Reader.Position = &H39C7C + Accesstravelers
            Text_region.Text = Reader.ReadUnicodeString(64)
            Reader.Position = &H394FD + Accesstravelers
            stmlv = Reader.Position
            valu_level.Value = Reader.ReadByte
            Reader.Position = &H394FC + Accesstravelers
            stmexp = Reader.Position
            valu_happiness.Value = Reader.ReadByte
            Reader.Position = &H390E0 + Accesstravelers
            stptravelers = Reader.Position
            Text_globaltravelers.Text = Reader.ReadHexString(&HC28)
            Reader.Position = &H39390 + Accesstravelers
            Datetraveler = Reader.Position
            valu_lastdatetraveler.Value = Reader.ReadUInt32
            Reader.Position = &H3939A + Accesstravelers
            Tent = Reader.Position
            valu_tent.Value = Reader.ReadUInt16
            Reader.Position = &H393A2 + Accesstravelers
            interaction = Reader.Position
            valu_interaction.Value = Reader.ReadUInt16
            Reader.Position = &H393A4 + Accesstravelers
            target1 = Reader.Position
            valu_target1.Value = Reader.ReadUInt16
            Reader.Position = &H393A6 + Accesstravelers
            target2 = Reader.Position
            valu_target2.Value = Reader.ReadUInt16
            Reader.Position = &H39394 + Accesstravelers
            unknow_1 = Reader.Position
            valu_unknow_1.Value = Reader.ReadUInt32
            Reader.Position = &H39398 + Accesstravelers
            unknow_2 = Reader.Position
            valu_unknow_2.Value = Reader.ReadByte
            Reader.Position = &H39399 + Accesstravelers
            unknow_3 = Reader.Position
            valu_unknow_3.Value = Reader.ReadByte
            Reader.Position = &H3939C + Accesstravelers
            unknow_4 = Reader.Position
            valu_unknow_4.Value = Reader.ReadUInt16
            Reader.Position = &H3939E + Accesstravelers
            unknow_5 = Reader.Position
            valu_unknow_5.Value = Reader.ReadUInt16
            Reader.Position = &H393A0 + Accesstravelers
            unknow_6 = Reader.Position
            valu_unknow_6.Value = Reader.ReadByte
            Reader.Position = &H393A1 + Accesstravelers
            unknow_7 = Reader.Position
            valu_unknow_7.Value = Reader.ReadByte
            Reader.Position = &H390D0
            lastdatestp = Reader.Position
            valu_lastdatestp.Value = Reader.ReadUInt32
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this traveler, load a save file first or report this issue"
                TLSE_dialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de ce voyageur a échoué, ouvrez une savegarde avant ou signalez cet erreur"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub writetravelers()
        Try
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = stmlv
            fs.WriteByte(valu_level.Value)
            fs.Position = stmexp
            fs.WriteByte(valu_happiness.Value)
            fs.Position = unknow_2
            fs.WriteByte(valu_unknow_2.Value)
            fs.Position = unknow_3
            fs.WriteByte(valu_unknow_3.Value)
            fs.Position = unknow_6
            fs.WriteByte(valu_unknow_6.Value)
            fs.Position = unknow_7
            fs.WriteByte(valu_unknow_7.Value)
            fs.Close()
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writer.Position = Datetraveler
            Writer.WriteUInt32(valu_lastdatetraveler.Value)
            Writer.Position = Tent
            Writer.WriteUInt16(valu_tent.Value)
            Writer.Position = interaction
            Writer.WriteUInt16(valu_interaction.Value)
            Writer.Position = target1
            Writer.WriteUInt16(valu_target1.Value)
            Writer.Position = target2
            Writer.WriteUInt16(valu_target2.Value)
            Writer.Position = unknow_1
            Writer.WriteUInt32(valu_unknow_1.Value)
            Writer.Position = unknow_4
            Writer.WriteUInt16(valu_unknow_4.Value)
            Writer.Position = unknow_5
            Writer.WriteUInt16(valu_unknow_5.Value)
            Writer.Position = lastdatestp
            Writer.WriteUInt32(valu_lastdatestp.Value)
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "This traveler has been edited"
                TLSE_dialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Ce voyageur a été édité"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Editing of this traveler has failed, load a save file first or report this issue"
                TLSE_dialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'édition de ce voyageur a échoué, ouvrez une savegarde avant ou signalez cet erreur"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Select_travelers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_travelers.SelectedIndexChanged
        If Select_travelers.SelectedItem = Select_travelers.Items.Item(0) Then
            Accesstravelers = &H0
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(1) Then
            Accesstravelers = &HC28
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(2) Then
            Accesstravelers = &HC28 * 2
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(3) Then
            Accesstravelers = &HC28 * 3
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(4) Then
            Accesstravelers = &HC28 * 4
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(5) Then
            Accesstravelers = &HC28 * 5
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(6) Then
            Accesstravelers = &HC28 * 6
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(7) Then
            Accesstravelers = &HC28 * 7
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(8) Then
            Accesstravelers = &HC28 * 8
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(9) Then
            Accesstravelers = &HC28 * 9
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(10) Then
            Accesstravelers = &HC28 * 10
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(11) Then
            Accesstravelers = &HC28 * 11
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(12) Then
            Accesstravelers = &HC28 * 12
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(13) Then
            Accesstravelers = &HC28 * 13
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(14) Then
            Accesstravelers = &HC28 * 14
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(15) Then
            Accesstravelers = &HC28 * 15
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(16) Then
            Accesstravelers = &HC28 * 16
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(17) Then
            Accesstravelers = &HC28 * 17
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(18) Then
            Accesstravelers = &HC28 * 18
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(19) Then
            Accesstravelers = &HC28 * 19
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(20) Then
            Accesstravelers = &HC28 * 20
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(21) Then
            Accesstravelers = &HC28 * 21
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(22) Then
            Accesstravelers = &HC28 * 22
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(23) Then
            Accesstravelers = &HC28 * 23
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(24) Then
            Accesstravelers = &HC28 * 24
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(25) Then
            Accesstravelers = &HC28 * 25
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(26) Then
            Accesstravelers = &HC28 * 26
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(27) Then
            Accesstravelers = &HC28 * 27
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(28) Then
            Accesstravelers = &HC28 * 28
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(29) Then
            Accesstravelers = &HC28 * 29
        ElseIf Select_travelers.SelectedItem = Select_travelers.Items.Item(30) Then
            Accesstravelers = &HC28 * 30
        End If
        readtravelers()
    End Sub

    Private Sub Travelers_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedataArc = TL_SaveEditor.TextBox_fpath.Text
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Text_save.Text = "Save"
            Title_happiness.Text = "Happiness"
            Title_gratitude.Text = "Gratitude"
            Title_region.Text = "Region"
            Title_home.Text = "Home"
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Text_save.Text = "Enregistrer"
            Title_happiness.Text = "Détente"
            Title_gratitude.Text = "Gratitude"
            Title_region.Text = "Région"
            Title_home.Text = "Île d'origine"
        End If
    End Sub

    Private Sub Icon_return_Click(sender As Object, e As EventArgs) Handles Icon_return.Click
        Me.Close()
    End Sub


    Private Sub valu_happiness_ValueChanged(sender As Object, e As EventArgs) Handles valu_happiness.ValueChanged
        valu_happiness2.Value = valu_happiness.Value
        If valu_happiness.Value = 0 Then
            Icon_happiness.Image = My.Resources.exp0
        End If
        If valu_happiness.Value = 1 Then
            Icon_happiness.Image = My.Resources.exp1
        End If
        If valu_happiness.Value = 2 Then
            Icon_happiness.Image = My.Resources.exp2
        End If
        If valu_happiness.Value = 3 Then
            Icon_happiness.Image = My.Resources.exp3
        End If
        If valu_happiness.Value = 4 Then
            Icon_happiness.Image = My.Resources.exp4
        End If
        If valu_happiness.Value = 5 Then
            Icon_happiness.Image = My.Resources.exp5
        End If
        If valu_happiness.Value = 6 Then
            Icon_happiness.Image = My.Resources.exp6
        End If
        If valu_happiness.Value = 7 Then
            Icon_happiness.Image = My.Resources.exp7
        End If
        If valu_happiness.Value = 8 Then
            Icon_happiness.Image = My.Resources.exp8
        End If
        If valu_happiness.Value = 9 Then
            Icon_happiness.Image = My.Resources.exp9
        End If
        If valu_happiness.Value = 10 Then
            Icon_happiness.Image = My.Resources.exp10
        End If
        If valu_happiness.Value = 11 Then
            Icon_happiness.Image = My.Resources.exp11
        End If
        If valu_happiness.Value = 12 Then
            Icon_happiness.Image = My.Resources.exp12
        End If
        If valu_happiness.Value = 13 Then
            Icon_happiness.Image = My.Resources.exp13
        End If
        If valu_happiness.Value = 14 Then
            Icon_happiness.Image = My.Resources.exp14
        End If
        If valu_happiness.Value = 15 Then
            Icon_happiness.Image = My.Resources.exp15
        End If
        If valu_happiness.Value = 16 Then
            Icon_happiness.Image = My.Resources.exp16
        End If
        If valu_happiness.Value = 17 Then
            Icon_happiness.Image = My.Resources.exp17
        End If
        If valu_happiness.Value = 18 Then
            Icon_happiness.Image = My.Resources.exp18
        End If
        If valu_happiness.Value = 19 Then
            Icon_happiness.Image = My.Resources.exp19
        End If
        If valu_happiness.Value = 20 Then
            Icon_happiness.Image = My.Resources.exp20
        End If
        If valu_happiness.Value = 21 Then
            Icon_happiness.Image = My.Resources.exp21
        End If
        If valu_happiness.Value = 22 Then
            Icon_happiness.Image = My.Resources.exp22
        End If
        If valu_happiness.Value = 23 Then
            Icon_happiness.Image = My.Resources.exp23
        End If
        If valu_happiness.Value = 24 Then
            Icon_happiness.Image = My.Resources.exp24
        End If
        If valu_happiness.Value = 25 Then
            Icon_happiness.Image = My.Resources.exp25
        End If
        If valu_happiness.Value = 26 Then
            Icon_happiness.Image = My.Resources.exp26
        End If
        If valu_happiness.Value = 27 Then
            Icon_happiness.Image = My.Resources.exp27
        End If
        If valu_happiness.Value = 28 Then
            Icon_happiness.Image = My.Resources.exp28
        End If
        If valu_happiness.Value = 29 Then
            Icon_happiness.Image = My.Resources.exp29
        End If
        If valu_happiness.Value = 30 Then
            Icon_happiness.Image = My.Resources.exp30
        End If
        If valu_happiness.Value = 31 Then
            Icon_happiness.Image = My.Resources.exp31
        End If
        If valu_happiness.Value = 32 Then
            Icon_happiness.Image = My.Resources.exp32
        End If
        If valu_happiness.Value = 33 Then
            Icon_happiness.Image = My.Resources.exp33
        End If
        If valu_happiness.Value = 34 Then
            Icon_happiness.Image = My.Resources.exp34
        End If
        If valu_happiness.Value = 35 Then
            Icon_happiness.Image = My.Resources.exp35
        End If
        If valu_happiness.Value = 36 Then
            Icon_happiness.Image = My.Resources.exp36
        End If
        If valu_happiness.Value = 37 Then
            Icon_happiness.Image = My.Resources.exp37
        End If
        If valu_happiness.Value = 38 Then
            Icon_happiness.Image = My.Resources.exp38
        End If
        If valu_happiness.Value = 39 Then
            Icon_happiness.Image = My.Resources.exp39
        End If
        If valu_happiness.Value = 40 Then
            Icon_happiness.Image = My.Resources.exp40
        End If
        If valu_happiness.Value = 41 Then
            Icon_happiness.Image = My.Resources.exp41
        End If
        If valu_happiness.Value = 42 Then
            Icon_happiness.Image = My.Resources.exp42
        End If
        If valu_happiness.Value = 43 Then
            Icon_happiness.Image = My.Resources.exp43
        End If
        If valu_happiness.Value = 44 Then
            Icon_happiness.Image = My.Resources.exp44
        End If
        If valu_happiness.Value = 45 Then
            Icon_happiness.Image = My.Resources.exp45
        End If
        If valu_happiness.Value = 46 Then
            Icon_happiness.Image = My.Resources.exp46
        End If
        If valu_happiness.Value = 47 Then
            Icon_happiness.Image = My.Resources.exp47
        End If
        If valu_happiness.Value = 48 Then
            Icon_happiness.Image = My.Resources.exp48
        End If
        If valu_happiness.Value = 49 Then
            Icon_happiness.Image = My.Resources.exp49
        End If
        If valu_happiness.Value = 50 Then
            Icon_happiness.Image = My.Resources.exp50
        End If
        If valu_happiness.Value = 51 Then
            Icon_happiness.Image = My.Resources.exp51
        End If
        If valu_happiness.Value = 52 Then
            Icon_happiness.Image = My.Resources.exp52
        End If
        If valu_happiness.Value = 53 Then
            Icon_happiness.Image = My.Resources.exp53
        End If
        If valu_happiness.Value = 54 Then
            Icon_happiness.Image = My.Resources.exp54
        End If
        If valu_happiness.Value = 55 Then
            Icon_happiness.Image = My.Resources.exp55
        End If
        If valu_happiness.Value = 56 Then
            Icon_happiness.Image = My.Resources.exp56
        End If
        If valu_happiness.Value = 57 Then
            Icon_happiness.Image = My.Resources.exp57
        End If
        If valu_happiness.Value = 58 Then
            Icon_happiness.Image = My.Resources.exp58
        End If
        If valu_happiness.Value = 59 Then
            Icon_happiness.Image = My.Resources.exp59
        End If
        If valu_happiness.Value = 60 Then
            Icon_happiness.Image = My.Resources.exp60
        End If
        If valu_happiness.Value = 61 Then
            Icon_happiness.Image = My.Resources.exp61
        End If
        If valu_happiness.Value = 62 Then
            Icon_happiness.Image = My.Resources.exp62
        End If
        If valu_happiness.Value = 63 Then
            Icon_happiness.Image = My.Resources.exp63
        End If
        If valu_happiness.Value = 64 Then
            Icon_happiness.Image = My.Resources.exp64
        End If
        If valu_happiness.Value = 65 Then
            Icon_happiness.Image = My.Resources.exp65
        End If
        If valu_happiness.Value = 66 Then
            Icon_happiness.Image = My.Resources.exp66
        End If
        If valu_happiness.Value = 67 Then
            Icon_happiness.Image = My.Resources.exp67
        End If
        If valu_happiness.Value = 68 Then
            Icon_happiness.Image = My.Resources.exp68
        End If
        If valu_happiness.Value = 69 Then
            Icon_happiness.Image = My.Resources.exp69
        End If
        If valu_happiness.Value = 70 Then
            Icon_happiness.Image = My.Resources.exp70
        End If
        If valu_happiness.Value = 71 Then
            Icon_happiness.Image = My.Resources.exp71
        End If
        If valu_happiness.Value = 72 Then
            Icon_happiness.Image = My.Resources.exp72
        End If
        If valu_happiness.Value = 73 Then
            Icon_happiness.Image = My.Resources.exp73
        End If
        If valu_happiness.Value = 74 Then
            Icon_happiness.Image = My.Resources.exp74
        End If
        If valu_happiness.Value = 75 Then
            Icon_happiness.Image = My.Resources.exp75
        End If
        If valu_happiness.Value = 76 Then
            Icon_happiness.Image = My.Resources.exp76
        End If
        If valu_happiness.Value = 77 Then
            Icon_happiness.Image = My.Resources.exp77
        End If
        If valu_happiness.Value = 78 Then
            Icon_happiness.Image = My.Resources.exp78
        End If
        If valu_happiness.Value = 79 Then
            Icon_happiness.Image = My.Resources.exp79
        End If
        If valu_happiness.Value = 80 Then
            Icon_happiness.Image = My.Resources.exp80
        End If
        If valu_happiness.Value = 81 Then
            Icon_happiness.Image = My.Resources.exp81
        End If
        If valu_happiness.Value = 82 Then
            Icon_happiness.Image = My.Resources.exp82
        End If
        If valu_happiness.Value = 83 Then
            Icon_happiness.Image = My.Resources.exp83
        End If
        If valu_happiness.Value = 84 Then
            Icon_happiness.Image = My.Resources.exp84
        End If
        If valu_happiness.Value = 85 Then
            Icon_happiness.Image = My.Resources.exp85
        End If
        If valu_happiness.Value = 86 Then
            Icon_happiness.Image = My.Resources.exp86
        End If
        If valu_happiness.Value = 87 Then
            Icon_happiness.Image = My.Resources.exp87
        End If
        If valu_happiness.Value = 88 Then
            Icon_happiness.Image = My.Resources.exp88
        End If
        If valu_happiness.Value = 89 Then
            Icon_happiness.Image = My.Resources.exp89
        End If
        If valu_happiness.Value = 90 Then
            Icon_happiness.Image = My.Resources.exp90
        End If
        If valu_happiness.Value = 91 Then
            Icon_happiness.Image = My.Resources.exp91
        End If
        If valu_happiness.Value = 92 Then
            Icon_happiness.Image = My.Resources.exp92
        End If
        If valu_happiness.Value = 93 Then
            Icon_happiness.Image = My.Resources.exp93
        End If
        If valu_happiness.Value = 94 Then
            Icon_happiness.Image = My.Resources.exp94
        End If
        If valu_happiness.Value = 95 Then
            Icon_happiness.Image = My.Resources.exp95
        End If
        If valu_happiness.Value = 96 Then
            Icon_happiness.Image = My.Resources.exp96
        End If
        If valu_happiness.Value = 97 Then
            Icon_happiness.Image = My.Resources.exp97
        End If
        If valu_happiness.Value = 98 Then
            Icon_happiness.Image = My.Resources.exp98
        End If
        If valu_happiness.Value = 99 Then
            Icon_happiness.Image = My.Resources.exp99
        End If
    End Sub

    Private Sub valu_happiness2_ValueChanged(sender As Object, e As EventArgs) Handles valu_happiness2.ValueChanged
        valu_happiness.Value = valu_happiness2.Value
    End Sub

    Private Sub Text_save_Click(sender As Object, e As EventArgs) Handles Text_save.Click
        writetravelers()
    End Sub

    Private Sub Fea_extractravelers_Click(sender As Object, e As EventArgs) Handles Fea_extractravelers.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Tomodachi Life traveler|*.TLtraveler"
            SaveFileDialog1.FileName = "Explorer_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_globaltravelers.Text)
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "This traveler has been successfully extracted"
                    TLSE_dialog.ShowDialog()
                End If
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Ce voyageur a été extrait avec succès"
                    TLSE_dialog.ShowDialog()
                End If
            End If
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Extraction of this traveler has failed, retry or report this issue"
                TLSE_dialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'extraction de ce voyageur a échoué, réessayez ou signalez cet erreur"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Fea_importravelers_Click(sender As Object, e As EventArgs) Handles Fea_importravelers.Click
        Dim open As New OpenFileDialog
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Open a Tomodachi Life traveler file" & vbNewLine & "Current traveler will be replace by traveler in Tomodachi Life traveler file" & vbNewLine & vbNewLine & "Do you want to continue ?"
            TLSE_dialog.Panel_Cancel.Visible = True
            TLSE_dialog.Panel_OK.Visible = True
            TLSE_dialog.ShowDialog()
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Ouvrir un fichier Tomodachi Life traveler" & vbNewLine & "Le voyageur actuel va être remplacé par le voyageur du fichier Tomodachi Life traveler" & vbNewLine & vbNewLine & "Voulez-vous continuer ?"
            TLSE_dialog.Panel_Cancel.Visible = True
            TLSE_dialog.Panel_OK.Visible = True
            TLSE_dialog.Cancel_Button.Text = "Annuler"
            TLSE_dialog.ShowDialog()
        End If
        If TLSE_dialog.DialogResult = Windows.Forms.DialogResult.OK Then
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                open.Filter = "Tomodachi Life traveler|*.TLtraveler"
                open.Title = "Open a Tomodachi Life traveler file"
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                open.Filter = "Tomodachi Life traveler|*.TLtraveler"
                open.Title = "Ouvrir un fichier Tomodachi Life traveler"
            End If
            open.ShowDialog()
            TLexplorer = open.FileName
            Try
                Dim Readexplo As New PackageIO.Reader(TLexplorer, PackageIO.Endian.Little)
                Readexplo.Position = &H0
                Text_globaltravelers.Text = Readexplo.ReadHexString(&HC28)
                Readexplo.Close()
            Catch ex As Exception
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read Tomodachi Life traveler file" & vbNewLine & "Select a valid Tomodachi Life traveler file or report this issue"
                    TLSE_dialog.ShowDialog()
                End If
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La lecture du fichier Tomodachi Life traveler a échoué" & vbNewLine & "Sélectionnez un fichier Tomodachi Life traveler valide ou signalez cet erreur"
                    TLSE_dialog.ShowDialog()
                End If
            End Try
            Try
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                Writer.Position = stptravelers
                Writer.WriteHexString(Text_globaltravelers.Text)
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "This traveler has been successfully replaced, you need to set him as new traveler"
                    TLSE_dialog.ShowDialog()
                End If
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Ce voyageur a été remplacé avec succès, vous devrez le mettre comme nouveau voyageur"
                    TLSE_dialog.ShowDialog()
                End If
                readtravelers()
            Catch ex As Exception
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to write Tomodachi Life traveler file" & vbNewLine & "Make sure you have opened a Tomodachi Life save file before or report this issue"
                    TLSE_dialog.ShowDialog()
                End If
                If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "L'écriture du fichier Tomodachi Life traveler a échoué" & vbNewLine & "Soyez sûr d'avoir ouvert une sauvegarde de Tomodachi Life ou signalez cet erreur"
                    TLSE_dialog.ShowDialog()
                End If
            End Try
        End If
    End Sub

    Private Sub Fea_reusetravelers_Click(sender As Object, e As EventArgs) Handles Fea_reusetravelers.Click
        valu_lastdatestp.Value = TL_SaveEditor.valu_lastdatesave.Value
        valu_lastdatetraveler.Value = TL_SaveEditor.valu_lastdatesave.Value
        valu_interaction.Value = &H17E
        valu_unknow_1.Value = 0
        valu_unknow_2.Value = &HA
        valu_unknow_3.Value = 1
        valu_unknow_4.Value = 1
        valu_unknow_5.Value = 2
        valu_unknow_6.Value = 0
        valu_unknow_7.Value = 0
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Select a Tent value (not same value as an other traveler) and an interaction before save changes on this travelers"
            TLSE_dialog.ShowDialog()
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Sélectionnez une valeur pour la Tente (pas la même valeur qu'un autre voyageur) et une interaction avant de sauvegarder les changements pour ce voyageur"
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Private Sub Fea_importravelers_MouseLeave(sender As Object, e As EventArgs) Handles Fea_importravelers.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_importravelers_MouseMove(sender As Object, e As EventArgs) Handles Fea_importravelers.MouseMove
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Text_description.Text = "Click to replace current traveler by a traveler in ''Tomodachi Life traveler'' file"
        ElseIf TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour remplacer le voyageur actuel par un voyageur dans un fichier ''Tomodachi Life traveler''"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_extractravelers_MouseLeave(sender As Object, e As EventArgs) Handles Fea_extractravelers.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_extractravelers_MouseMove(sender As Object, e As EventArgs) Handles Fea_extractravelers.MouseMove
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Text_description.Text = "Click to extract current traveler"
        ElseIf TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour extraire le voyageur actuel"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_reusetravelers_MouseLeave(sender As Object, e As EventArgs) Handles Fea_reusetravelers.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_reusetravelers_MouseMove(sender As Object, e As EventArgs) Handles Fea_reusetravelers.MouseMove
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Text_description.Text = "Click to set current traveler as new traveler"
        ElseIf TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour mettre le voyageur actuel comme nouveau voyageur"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Select_interaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_interaction.SelectedIndexChanged
        Select_target1.Visible = False
        valu_target1.Visible = True
        Danger_interaction.Visible = False
        If Select_interaction.SelectedItem = Select_interaction.Items.Item(0) Then
            valu_interaction.Value = &H17E
            valu_target1.Value = 65535
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(1) Then
            valu_interaction.Value = &H17F
            valu_target1.Value = 65535
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(2) Then
            valu_interaction.Value = &H180
            valu_target1.Value = 65535
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(3) Then
            valu_interaction.Value = &H181
            valu_target1.Value = 65535
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(4) Then
            valu_interaction.Value = &H182
            valu_target1.Value = 65535
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(5) Then
            valu_interaction.Value = &H183
            valu_target1.Value = 0
            Select_target1.Visible = True
            valu_target1.Visible = False
            Danger_interaction.Visible = True
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(6) Then
            valu_interaction.Value = &H184
            valu_target1.Value = 65535
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(7) Then
            valu_interaction.Value = &H185
            valu_target1.Value = 65535
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(8) Then
            valu_interaction.Value = &H186
            valu_target1.Value = 65535
        End If
    End Sub

    Private Sub valu_interaction_ValueChanged(sender As Object, e As EventArgs) Handles valu_interaction.ValueChanged
        If valu_interaction.Value = &H17E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(0)
        ElseIf valu_interaction.Value = &H17F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(1)
        ElseIf valu_interaction.Value = &H180 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(2)
        ElseIf valu_interaction.Value = &H181 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(3)
        ElseIf valu_interaction.Value = &H182 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(4)
        ElseIf valu_interaction.Value = &H183 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(5)
        ElseIf valu_interaction.Value = &H184 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(6)
        ElseIf valu_interaction.Value = &H185 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(7)
        ElseIf valu_interaction.Value = &H186 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(8)
        End If
    End Sub

    Private Sub Select_target1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_target1.SelectedIndexChanged
        If Select_target1.SelectedItem = Select_target1.Items.Item(0) Then
            valu_target1.Value = 65535
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(1) Then
            valu_target1.Value = 0
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(2) Then
            valu_target1.Value = 1
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(3) Then
            valu_target1.Value = 2
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(4) Then
            valu_target1.Value = 3
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(5) Then
            valu_target1.Value = 4
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(6) Then
            valu_target1.Value = 5
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(7) Then
            valu_target1.Value = 6
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(8) Then
            valu_target1.Value = 7
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(9) Then
            valu_target1.Value = 8
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(10) Then
            valu_target1.Value = 9
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(11) Then
            valu_target1.Value = 10
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(12) Then
            valu_target1.Value = 11
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(13) Then
            valu_target1.Value = 12
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(14) Then
            valu_target1.Value = 13
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(15) Then
            valu_target1.Value = 14
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(16) Then
            valu_target1.Value = 15
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(17) Then
            valu_target1.Value = 16
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(18) Then
            valu_target1.Value = 17
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(19) Then
            valu_target1.Value = 18
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(20) Then
            valu_target1.Value = 19
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(21) Then
            valu_target1.Value = 20
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(22) Then
            valu_target1.Value = 21
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(23) Then
            valu_target1.Value = 22
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(24) Then
            valu_target1.Value = 23
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(25) Then
            valu_target1.Value = 24
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(26) Then
            valu_target1.Value = 25
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(27) Then
            valu_target1.Value = 26
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(28) Then
            valu_target1.Value = 27
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(29) Then
            valu_target1.Value = 28
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(30) Then
            valu_target1.Value = 29
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(31) Then
            valu_target1.Value = 30
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(32) Then
            valu_target1.Value = 31
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(33) Then
            valu_target1.Value = 32
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(34) Then
            valu_target1.Value = 33
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(35) Then
            valu_target1.Value = 34
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(36) Then
            valu_target1.Value = 35
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(37) Then
            valu_target1.Value = 36
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(38) Then
            valu_target1.Value = 37
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(39) Then
            valu_target1.Value = 38
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(40) Then
            valu_target1.Value = 39
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(41) Then
            valu_target1.Value = 40
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(42) Then
            valu_target1.Value = 41
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(43) Then
            valu_target1.Value = 42
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(44) Then
            valu_target1.Value = 43
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(45) Then
            valu_target1.Value = 44
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(46) Then
            valu_target1.Value = 45
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(47) Then
            valu_target1.Value = 46
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(48) Then
            valu_target1.Value = 47
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(49) Then
            valu_target1.Value = 48
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(50) Then
            valu_target1.Value = 49
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(51) Then
            valu_target1.Value = 50
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(52) Then
            valu_target1.Value = 51
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(53) Then
            valu_target1.Value = 52
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(54) Then
            valu_target1.Value = 53
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(55) Then
            valu_target1.Value = 54
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(56) Then
            valu_target1.Value = 55
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(57) Then
            valu_target1.Value = 56
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(58) Then
            valu_target1.Value = 57
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(59) Then
            valu_target1.Value = 58
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(60) Then
            valu_target1.Value = 59
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(61) Then
            valu_target1.Value = 60
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(62) Then
            valu_target1.Value = 61
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(63) Then
            valu_target1.Value = 62
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(64) Then
            valu_target1.Value = 63
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(65) Then
            valu_target1.Value = 64
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(66) Then
            valu_target1.Value = 65
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(67) Then
            valu_target1.Value = 66
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(68) Then
            valu_target1.Value = 67
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(69) Then
            valu_target1.Value = 68
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(70) Then
            valu_target1.Value = 69
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(71) Then
            valu_target1.Value = 70
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(72) Then
            valu_target1.Value = 71
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(73) Then
            valu_target1.Value = 72
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(74) Then
            valu_target1.Value = 73
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(75) Then
            valu_target1.Value = 74
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(76) Then
            valu_target1.Value = 75
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(77) Then
            valu_target1.Value = 76
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(78) Then
            valu_target1.Value = 77
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(79) Then
            valu_target1.Value = 78
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(80) Then
            valu_target1.Value = 79
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(81) Then
            valu_target1.Value = 80
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(82) Then
            valu_target1.Value = 81
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(83) Then
            valu_target1.Value = 82
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(84) Then
            valu_target1.Value = 83
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(85) Then
            valu_target1.Value = 84
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(86) Then
            valu_target1.Value = 85
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(87) Then
            valu_target1.Value = 86
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(88) Then
            valu_target1.Value = 87
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(89) Then
            valu_target1.Value = 88
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(90) Then
            valu_target1.Value = 89
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(91) Then
            valu_target1.Value = 90
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(92) Then
            valu_target1.Value = 91
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(93) Then
            valu_target1.Value = 92
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(94) Then
            valu_target1.Value = 93
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(95) Then
            valu_target1.Value = 94
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(96) Then
            valu_target1.Value = 95
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(97) Then
            valu_target1.Value = 96
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(98) Then
            valu_target1.Value = 97
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(99) Then
            valu_target1.Value = 98
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(100) Then
            valu_target1.Value = 99
        End If
    End Sub

    Private Sub valu_target1_ValueChanged(sender As Object, e As EventArgs) Handles valu_target1.ValueChanged
        If valu_target1.Value = 65535 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(0)
        ElseIf valu_target1.Value = 0 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(1)
        ElseIf valu_target1.Value = 1 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(2)
        ElseIf valu_target1.Value = 2 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(3)
        ElseIf valu_target1.Value = 3 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(4)
        ElseIf valu_target1.Value = 4 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(5)
        ElseIf valu_target1.Value = 5 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(6)
        ElseIf valu_target1.Value = 6 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(7)
        ElseIf valu_target1.Value = 7 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(8)
        ElseIf valu_target1.Value = 8 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(9)
        ElseIf valu_target1.Value = 9 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(10)
        ElseIf valu_target1.Value = 10 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(11)
        ElseIf valu_target1.Value = 11 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(12)
        ElseIf valu_target1.Value = 12 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(13)
        ElseIf valu_target1.Value = 13 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(14)
        ElseIf valu_target1.Value = 14 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(15)
        ElseIf valu_target1.Value = 15 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(16)
        ElseIf valu_target1.Value = 16 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(17)
        ElseIf valu_target1.Value = 17 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(18)
        ElseIf valu_target1.Value = 18 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(19)
        ElseIf valu_target1.Value = 19 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(20)
        ElseIf valu_target1.Value = 20 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(21)
        ElseIf valu_target1.Value = 21 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(22)
        ElseIf valu_target1.Value = 22 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(23)
        ElseIf valu_target1.Value = 23 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(24)
        ElseIf valu_target1.Value = 24 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(25)
        ElseIf valu_target1.Value = 25 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(26)
        ElseIf valu_target1.Value = 26 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(27)
        ElseIf valu_target1.Value = 27 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(28)
        ElseIf valu_target1.Value = 28 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(29)
        ElseIf valu_target1.Value = 29 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(30)
        ElseIf valu_target1.Value = 30 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(31)
        ElseIf valu_target1.Value = 31 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(32)
        ElseIf valu_target1.Value = 32 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(33)
        ElseIf valu_target1.Value = 33 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(34)
        ElseIf valu_target1.Value = 34 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(35)
        ElseIf valu_target1.Value = 35 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(36)
        ElseIf valu_target1.Value = 36 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(37)
        ElseIf valu_target1.Value = 37 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(38)
        ElseIf valu_target1.Value = 38 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(39)
        ElseIf valu_target1.Value = 39 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(40)
        ElseIf valu_target1.Value = 40 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(41)
        ElseIf valu_target1.Value = 41 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(42)
        ElseIf valu_target1.Value = 42 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(43)
        ElseIf valu_target1.Value = 43 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(44)
        ElseIf valu_target1.Value = 44 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(45)
        ElseIf valu_target1.Value = 45 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(46)
        ElseIf valu_target1.Value = 46 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(47)
        ElseIf valu_target1.Value = 47 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(48)
        ElseIf valu_target1.Value = 48 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(49)
        ElseIf valu_target1.Value = 49 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(50)
        ElseIf valu_target1.Value = 50 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(51)
        ElseIf valu_target1.Value = 51 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(52)
        ElseIf valu_target1.Value = 52 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(53)
        ElseIf valu_target1.Value = 53 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(54)
        ElseIf valu_target1.Value = 54 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(55)
        ElseIf valu_target1.Value = 55 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(56)
        ElseIf valu_target1.Value = 56 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(57)
        ElseIf valu_target1.Value = 57 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(58)
        ElseIf valu_target1.Value = 58 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(59)
        ElseIf valu_target1.Value = 59 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(60)
        ElseIf valu_target1.Value = 60 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(61)
        ElseIf valu_target1.Value = 61 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(62)
        ElseIf valu_target1.Value = 62 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(63)
        ElseIf valu_target1.Value = 63 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(64)
        ElseIf valu_target1.Value = 64 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(65)
        ElseIf valu_target1.Value = 65 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(66)
        ElseIf valu_target1.Value = 66 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(67)
        ElseIf valu_target1.Value = 67 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(68)
        ElseIf valu_target1.Value = 68 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(69)
        ElseIf valu_target1.Value = 69 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(70)
        ElseIf valu_target1.Value = 70 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(71)
        ElseIf valu_target1.Value = 71 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(72)
        ElseIf valu_target1.Value = 72 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(73)
        ElseIf valu_target1.Value = 73 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(74)
        ElseIf valu_target1.Value = 74 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(75)
        ElseIf valu_target1.Value = 75 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(76)
        ElseIf valu_target1.Value = 76 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(77)
        ElseIf valu_target1.Value = 77 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(78)
        ElseIf valu_target1.Value = 78 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(79)
        ElseIf valu_target1.Value = 79 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(80)
        ElseIf valu_target1.Value = 80 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(81)
        ElseIf valu_target1.Value = 81 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(82)
        ElseIf valu_target1.Value = 82 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(83)
        ElseIf valu_target1.Value = 83 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(84)
        ElseIf valu_target1.Value = 84 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(85)
        ElseIf valu_target1.Value = 85 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(86)
        ElseIf valu_target1.Value = 86 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(87)
        ElseIf valu_target1.Value = 87 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(88)
        ElseIf valu_target1.Value = 88 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(89)
        ElseIf valu_target1.Value = 89 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(90)
        ElseIf valu_target1.Value = 90 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(91)
        ElseIf valu_target1.Value = 91 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(92)
        ElseIf valu_target1.Value = 92 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(93)
        ElseIf valu_target1.Value = 93 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(94)
        ElseIf valu_target1.Value = 94 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(95)
        ElseIf valu_target1.Value = 95 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(96)
        ElseIf valu_target1.Value = 96 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(97)
        ElseIf valu_target1.Value = 97 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(98)
        ElseIf valu_target1.Value = 98 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(99)
        ElseIf valu_target1.Value = 99 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(100)
        End If
        If valu_target1.Value = 65535 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(0)
        ElseIf valu_target1.Value = 2 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(1)
        ElseIf valu_target1.Value = 5 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(2)
        ElseIf valu_target1.Value = 10 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(3)
        ElseIf valu_target1.Value = 16 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(4)
        ElseIf valu_target1.Value = 20 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(5)
        ElseIf valu_target1.Value = 23 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(6)
        ElseIf valu_target1.Value = 26 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(7)
        ElseIf valu_target1.Value = 27 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(8)
        ElseIf valu_target1.Value = 29 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(9)
        ElseIf valu_target1.Value = 31 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(10)
        ElseIf valu_target1.Value = 32 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(11)
        ElseIf valu_target1.Value = 34 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(12)
        ElseIf valu_target1.Value = 36 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(13)
        ElseIf valu_target1.Value = 38 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(14)
        ElseIf valu_target1.Value = 40 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(15)
        ElseIf valu_target1.Value = 42 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(16)
        ElseIf valu_target1.Value = 44 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(17)
        ElseIf valu_target1.Value = 45 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(18)
        ElseIf valu_target1.Value = 46 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(19)
        ElseIf valu_target1.Value = 47 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(20)
        ElseIf valu_target1.Value = 48 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(21)
        ElseIf valu_target1.Value = 49 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(22)
        ElseIf valu_target1.Value = 50 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(23)
        ElseIf valu_target1.Value = 51 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(24)
        ElseIf valu_target1.Value = 53 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(25)
        ElseIf valu_target1.Value = 54 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(26)
        ElseIf valu_target1.Value = 56 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(27)
        ElseIf valu_target1.Value = 58 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(28)
        ElseIf valu_target1.Value = 61 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(29)
        ElseIf valu_target1.Value = 62 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(30)
        ElseIf valu_target1.Value = 63 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(31)
        ElseIf valu_target1.Value = 66 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(32)
        ElseIf valu_target1.Value = 67 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(33)
        ElseIf valu_target1.Value = 69 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(34)
        ElseIf valu_target1.Value = 70 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(35)
        ElseIf valu_target1.Value = 73 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(36)
        ElseIf valu_target1.Value = 76 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(37)
        ElseIf valu_target1.Value = 77 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(38)
        ElseIf valu_target1.Value = 80 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(39)
        ElseIf valu_target1.Value = 86 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(40)
        ElseIf valu_target1.Value = 87 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(41)
        ElseIf valu_target1.Value = 89 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(42)
        ElseIf valu_target1.Value = 90 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(43)
        ElseIf valu_target1.Value = 91 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(44)
        ElseIf valu_target1.Value = 92 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(45)
        ElseIf valu_target1.Value = 96 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(46)
        ElseIf valu_target1.Value = 97 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(47)
        ElseIf valu_target1.Value = 98 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(48)
        ElseIf valu_target1.Value = 99 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(49)
        ElseIf valu_target1.Value = 100 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(50)
        ElseIf valu_target1.Value = 101 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(51)
        ElseIf valu_target1.Value = 102 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(52)
        ElseIf valu_target1.Value = 103 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(53)
        ElseIf valu_target1.Value = 104 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(54)
        ElseIf valu_target1.Value = 105 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(55)
        ElseIf valu_target1.Value = 106 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(56)
        ElseIf valu_target1.Value = 107 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(57)
        ElseIf valu_target1.Value = 108 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(58)
        ElseIf valu_target1.Value = 109 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(59)
        ElseIf valu_target1.Value = 110 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(60)
        ElseIf valu_target1.Value = 112 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(61)
        ElseIf valu_target1.Value = 114 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(62)
        ElseIf valu_target1.Value = 115 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(63)
        ElseIf valu_target1.Value = 117 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(64)
        ElseIf valu_target1.Value = 119 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(65)
        ElseIf valu_target1.Value = 122 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(66)
        ElseIf valu_target1.Value = 123 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(67)
        ElseIf valu_target1.Value = 126 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(68)
        ElseIf valu_target1.Value = 132 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(69)
        ElseIf valu_target1.Value = 135 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(70)
        ElseIf valu_target1.Value = 136 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(71)
        ElseIf valu_target1.Value = 137 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(72)
        ElseIf valu_target1.Value = 138 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(73)
        ElseIf valu_target1.Value = 139 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(74)
        ElseIf valu_target1.Value = 140 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(75)
        ElseIf valu_target1.Value = 141 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(76)
        ElseIf valu_target1.Value = 142 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(77)
        ElseIf valu_target1.Value = 143 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(78)
        ElseIf valu_target1.Value = 144 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(79)
        ElseIf valu_target1.Value = 146 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(80)
        ElseIf valu_target1.Value = 147 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(81)
        ElseIf valu_target1.Value = 148 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(82)
        ElseIf valu_target1.Value = 149 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(83)
        ElseIf valu_target1.Value = 150 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(84)
        ElseIf valu_target1.Value = 151 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(85)
        ElseIf valu_target1.Value = 152 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(86)
        ElseIf valu_target1.Value = 153 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(87)
        ElseIf valu_target1.Value = 154 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(88)
        ElseIf valu_target1.Value = 155 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(89)
        ElseIf valu_target1.Value = 156 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(90)
        ElseIf valu_target1.Value = 157 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(91)
        ElseIf valu_target1.Value = 158 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(92)
        ElseIf valu_target1.Value = 159 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(93)
        ElseIf valu_target1.Value = 160 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(94)
        ElseIf valu_target1.Value = 161 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(95)
        ElseIf valu_target1.Value = 162 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(96)
        ElseIf valu_target1.Value = 163 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(97)
        ElseIf valu_target1.Value = 164 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(98)
        ElseIf valu_target1.Value = 165 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(99)
        ElseIf valu_target1.Value = 166 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(100)
        ElseIf valu_target1.Value = 167 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(101)
        ElseIf valu_target1.Value = 168 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(102)
        ElseIf valu_target1.Value = 169 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(103)
        ElseIf valu_target1.Value = 170 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(104)
        ElseIf valu_target1.Value = 171 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(105)
        ElseIf valu_target1.Value = 172 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(106)
        ElseIf valu_target1.Value = 173 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(107)
        ElseIf valu_target1.Value = 174 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(108)
        ElseIf valu_target1.Value = 175 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(109)
        ElseIf valu_target1.Value = 178 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(110)
        ElseIf valu_target1.Value = 180 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(111)
        ElseIf valu_target1.Value = 182 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(112)
        ElseIf valu_target1.Value = 183 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(113)
        ElseIf valu_target1.Value = 185 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(114)
        ElseIf valu_target1.Value = 186 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(115)
        ElseIf valu_target1.Value = 187 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(116)
        ElseIf valu_target1.Value = 188 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(117)
        ElseIf valu_target1.Value = 189 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(118)
        ElseIf valu_target1.Value = 190 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(119)
        ElseIf valu_target1.Value = 191 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(120)
        ElseIf valu_target1.Value = 192 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(121)
        ElseIf valu_target1.Value = 193 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(122)
        ElseIf valu_target1.Value = 194 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(123)
        ElseIf valu_target1.Value = 195 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(124)
        ElseIf valu_target1.Value = 197 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(125)
        ElseIf valu_target1.Value = 198 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(126)
        ElseIf valu_target1.Value = 199 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(127)
        ElseIf valu_target1.Value = 200 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(128)
        ElseIf valu_target1.Value = 201 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(129)
        ElseIf valu_target1.Value = 202 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(130)
        ElseIf valu_target1.Value = 205 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(131)
        ElseIf valu_target1.Value = 210 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(132)
        ElseIf valu_target1.Value = 216 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(133)
        ElseIf valu_target1.Value = 218 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(134)
        ElseIf valu_target1.Value = 222 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(135)
        ElseIf valu_target1.Value = 229 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(136)
        ElseIf valu_target1.Value = 230 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(137)
        ElseIf valu_target1.Value = 231 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(138)
        ElseIf valu_target1.Value = 232 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(139)
        ElseIf valu_target1.Value = 233 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(140)
        ElseIf valu_target1.Value = 234 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(141)
        ElseIf valu_target1.Value = 235 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(142)
        ElseIf valu_target1.Value = 236 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(143)
        ElseIf valu_target1.Value = 237 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(144)
        ElseIf valu_target1.Value = 238 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(145)
        ElseIf valu_target1.Value = 239 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(146)
        ElseIf valu_target1.Value = 240 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(147)
        ElseIf valu_target1.Value = 241 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(148)
        ElseIf valu_target1.Value = 242 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(149)
        ElseIf valu_target1.Value = 243 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(150)
        ElseIf valu_target1.Value = 244 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(151)
        ElseIf valu_target1.Value = 245 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(152)
        ElseIf valu_target1.Value = 246 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(153)
        ElseIf valu_target1.Value = 247 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(154)
        ElseIf valu_target1.Value = 248 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(155)
        ElseIf valu_target1.Value = 249 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(156)
        ElseIf valu_target1.Value = 250 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(157)
        ElseIf valu_target1.Value = 251 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(158)
        ElseIf valu_target1.Value = 252 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(159)
        ElseIf valu_target1.Value = 253 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(160)
        ElseIf valu_target1.Value = 297 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(161)
        ElseIf valu_target1.Value = 298 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(162)
        ElseIf valu_target1.Value = 299 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(163)
        ElseIf valu_target1.Value = 300 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(164)
        ElseIf valu_target1.Value = 301 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(165)
        ElseIf valu_target1.Value = 302 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(166)
        ElseIf valu_target1.Value = 303 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(167)
        ElseIf valu_target1.Value = 304 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(168)
        ElseIf valu_target1.Value = 305 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(169)
        ElseIf valu_target1.Value = 306 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(170)
        ElseIf valu_target1.Value = 307 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(171)
        ElseIf valu_target1.Value = 308 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(172)
        ElseIf valu_target1.Value = 309 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(173)
        ElseIf valu_target1.Value = 310 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(174)
        ElseIf valu_target1.Value = 311 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(175)
        ElseIf valu_target1.Value = 312 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(176)
        ElseIf valu_target1.Value = 314 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(177)
        ElseIf valu_target1.Value = 315 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(178)
        ElseIf valu_target1.Value = 316 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(179)
        ElseIf valu_target1.Value = 317 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(180)
        ElseIf valu_target1.Value = 318 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(181)
        ElseIf valu_target1.Value = 319 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(182)
        ElseIf valu_target1.Value = 320 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(183)
        ElseIf valu_target1.Value = 321 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(184)
        ElseIf valu_target1.Value = 322 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(185)
        ElseIf valu_target1.Value = 323 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(186)
        ElseIf valu_target1.Value = 324 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(187)
        ElseIf valu_target1.Value = 325 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(188)
        ElseIf valu_target1.Value = 326 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(189)
        ElseIf valu_target1.Value = 327 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(190)
        ElseIf valu_target1.Value = 328 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(191)
        ElseIf valu_target1.Value = 329 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(192)
        ElseIf valu_target1.Value = 330 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(193)
        ElseIf valu_target1.Value = 331 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(194)
        ElseIf valu_target1.Value = 332 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(195)
        ElseIf valu_target1.Value = 333 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(196)
        ElseIf valu_target1.Value = 334 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(197)
        ElseIf valu_target1.Value = 335 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(198)
        ElseIf valu_target1.Value = 336 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(199)
        ElseIf valu_target1.Value = 337 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(200)
        ElseIf valu_target1.Value = 338 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(201)
        ElseIf valu_target1.Value = 340 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(202)
        ElseIf valu_target1.Value = 342 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(203)
        ElseIf valu_target1.Value = 343 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(204)
        ElseIf valu_target1.Value = 344 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(205)
        ElseIf valu_target1.Value = 345 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(206)
        ElseIf valu_target1.Value = 346 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(207)
        ElseIf valu_target1.Value = 347 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(208)
        ElseIf valu_target1.Value = 348 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(209)
        ElseIf valu_target1.Value = 349 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(210)
        ElseIf valu_target1.Value = 350 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(211)
        ElseIf valu_target1.Value = 354 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(212)
        ElseIf valu_target1.Value = 355 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(213)
        ElseIf valu_target1.Value = 356 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(214)
        ElseIf valu_target1.Value = 357 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(215)
        ElseIf valu_target1.Value = 358 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(216)
        ElseIf valu_target1.Value = 359 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(217)
        ElseIf valu_target1.Value = 360 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(218)
        ElseIf valu_target1.Value = 361 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(219)
        ElseIf valu_target1.Value = 362 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(220)
        ElseIf valu_target1.Value = 363 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(221)
        ElseIf valu_target1.Value = 364 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(222)
        ElseIf valu_target1.Value = 365 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(223)
        ElseIf valu_target1.Value = 366 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(224)
        ElseIf valu_target1.Value = 367 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(225)
        ElseIf valu_target1.Value = 368 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(226)
        ElseIf valu_target1.Value = 369 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(227)
        ElseIf valu_target1.Value = 370 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(228)
        ElseIf valu_target1.Value = 371 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(229)
        ElseIf valu_target1.Value = 381 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(230)
        ElseIf valu_target1.Value = 0 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(231)
        End If

        If valu_target1.Value = 65535 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(0)
        ElseIf valu_target1.Value = 0 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(1)
        ElseIf valu_target1.Value = 1 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(2)
        ElseIf valu_target1.Value = 2 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(3)
        ElseIf valu_target1.Value = 5 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(4)
        ElseIf valu_target1.Value = 14 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(5)
        ElseIf valu_target1.Value = 23 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(6)
        ElseIf valu_target1.Value = 27 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(7)
        ElseIf valu_target1.Value = 28 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(8)
        ElseIf valu_target1.Value = 29 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(9)
        ElseIf valu_target1.Value = 30 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(10)
        ElseIf valu_target1.Value = 31 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(11)
        ElseIf valu_target1.Value = 34 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(12)
        ElseIf valu_target1.Value = 36 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(13)
        ElseIf valu_target1.Value = 37 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(14)
        ElseIf valu_target1.Value = 38 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(15)
        ElseIf valu_target1.Value = 40 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(16)
        ElseIf valu_target1.Value = 41 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(17)
        ElseIf valu_target1.Value = 42 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(18)
        ElseIf valu_target1.Value = 43 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(19)
        ElseIf valu_target1.Value = 44 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(20)
        ElseIf valu_target1.Value = 45 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(21)
        ElseIf valu_target1.Value = 46 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(22)
        ElseIf valu_target1.Value = 47 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(23)
        ElseIf valu_target1.Value = 48 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(24)
        ElseIf valu_target1.Value = 49 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(25)
        ElseIf valu_target1.Value = 50 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(26)
        ElseIf valu_target1.Value = 51 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(27)
        ElseIf valu_target1.Value = 52 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(28)
        ElseIf valu_target1.Value = 53 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(29)
        ElseIf valu_target1.Value = 56 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(30)
        ElseIf valu_target1.Value = 58 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(31)
        ElseIf valu_target1.Value = 61 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(32)
        ElseIf valu_target1.Value = 63 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(33)
        ElseIf valu_target1.Value = 64 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(34)
        ElseIf valu_target1.Value = 66 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(35)
        ElseIf valu_target1.Value = 67 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(36)
        ElseIf valu_target1.Value = 69 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(37)
        ElseIf valu_target1.Value = 70 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(38)
        ElseIf valu_target1.Value = 73 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(39)
        ElseIf valu_target1.Value = 74 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(40)
        ElseIf valu_target1.Value = 76 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(41)
        ElseIf valu_target1.Value = 77 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(42)
        ElseIf valu_target1.Value = 80 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(43)
        ElseIf valu_target1.Value = 84 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(44)
        ElseIf valu_target1.Value = 86 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(45)
        ElseIf valu_target1.Value = 87 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(46)
        ElseIf valu_target1.Value = 88 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(47)
        ElseIf valu_target1.Value = 89 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(48)
        ElseIf valu_target1.Value = 91 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(49)
        ElseIf valu_target1.Value = 92 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(50)
        ElseIf valu_target1.Value = 95 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(51)
        ElseIf valu_target1.Value = 96 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(52)
        ElseIf valu_target1.Value = 97 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(53)
        ElseIf valu_target1.Value = 98 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(54)
        ElseIf valu_target1.Value = 99 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(55)
        ElseIf valu_target1.Value = 100 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(56)
        ElseIf valu_target1.Value = 101 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(57)
        ElseIf valu_target1.Value = 102 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(58)
        ElseIf valu_target1.Value = 103 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(59)
        ElseIf valu_target1.Value = 104 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(60)
        ElseIf valu_target1.Value = 105 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(61)
        ElseIf valu_target1.Value = 106 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(62)
        ElseIf valu_target1.Value = 107 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(63)
        ElseIf valu_target1.Value = 108 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(64)
        ElseIf valu_target1.Value = 109 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(65)
        ElseIf valu_target1.Value = 110 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(66)
        ElseIf valu_target1.Value = 112 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(67)
        ElseIf valu_target1.Value = 114 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(68)
        ElseIf valu_target1.Value = 115 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(69)
        ElseIf valu_target1.Value = 117 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(70)
        ElseIf valu_target1.Value = 119 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(71)
        ElseIf valu_target1.Value = 121 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(72)
        ElseIf valu_target1.Value = 122 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(73)
        ElseIf valu_target1.Value = 123 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(74)
        ElseIf valu_target1.Value = 125 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(75)
        ElseIf valu_target1.Value = 126 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(76)
        ElseIf valu_target1.Value = 132 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(77)
        ElseIf valu_target1.Value = 135 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(78)
        ElseIf valu_target1.Value = 136 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(79)
        ElseIf valu_target1.Value = 137 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(80)
        ElseIf valu_target1.Value = 138 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(81)
        ElseIf valu_target1.Value = 139 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(82)
        ElseIf valu_target1.Value = 140 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(83)
        ElseIf valu_target1.Value = 141 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(84)
        ElseIf valu_target1.Value = 142 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(85)
        ElseIf valu_target1.Value = 143 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(86)
        ElseIf valu_target1.Value = 144 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(87)
        ElseIf valu_target1.Value = 146 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(88)
        ElseIf valu_target1.Value = 147 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(89)
        ElseIf valu_target1.Value = 148 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(90)
        ElseIf valu_target1.Value = 149 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(91)
        ElseIf valu_target1.Value = 150 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(92)
        ElseIf valu_target1.Value = 151 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(93)
        ElseIf valu_target1.Value = 152 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(94)
        ElseIf valu_target1.Value = 153 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(95)
        ElseIf valu_target1.Value = 154 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(96)
        ElseIf valu_target1.Value = 155 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(97)
        ElseIf valu_target1.Value = 156 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(98)
        ElseIf valu_target1.Value = 157 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(99)
        ElseIf valu_target1.Value = 158 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(100)
        ElseIf valu_target1.Value = 159 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(101)
        ElseIf valu_target1.Value = 160 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(102)
        ElseIf valu_target1.Value = 161 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(103)
        ElseIf valu_target1.Value = 162 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(104)
        ElseIf valu_target1.Value = 163 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(105)
        ElseIf valu_target1.Value = 164 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(106)
        ElseIf valu_target1.Value = 165 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(107)
        ElseIf valu_target1.Value = 166 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(108)
        ElseIf valu_target1.Value = 167 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(109)
        ElseIf valu_target1.Value = 168 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(110)
        ElseIf valu_target1.Value = 169 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(111)
        ElseIf valu_target1.Value = 170 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(112)
        ElseIf valu_target1.Value = 171 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(113)
        ElseIf valu_target1.Value = 172 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(114)
        ElseIf valu_target1.Value = 173 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(115)
        ElseIf valu_target1.Value = 174 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(116)
        ElseIf valu_target1.Value = 175 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(117)
        ElseIf valu_target1.Value = 178 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(118)
        ElseIf valu_target1.Value = 180 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(119)
        ElseIf valu_target1.Value = 181 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(120)
        ElseIf valu_target1.Value = 182 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(121)
        ElseIf valu_target1.Value = 183 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(122)
        ElseIf valu_target1.Value = 185 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(123)
        ElseIf valu_target1.Value = 186 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(124)
        ElseIf valu_target1.Value = 187 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(125)
        ElseIf valu_target1.Value = 188 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(126)
        ElseIf valu_target1.Value = 189 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(127)
        ElseIf valu_target1.Value = 190 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(128)
        ElseIf valu_target1.Value = 191 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(129)
        ElseIf valu_target1.Value = 192 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(130)
        ElseIf valu_target1.Value = 193 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(131)
        ElseIf valu_target1.Value = 194 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(132)
        ElseIf valu_target1.Value = 195 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(133)
        ElseIf valu_target1.Value = 197 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(134)
        ElseIf valu_target1.Value = 198 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(135)
        ElseIf valu_target1.Value = 199 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(136)
        ElseIf valu_target1.Value = 201 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(137)
        ElseIf valu_target1.Value = 202 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(138)
        ElseIf valu_target1.Value = 210 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(139)
        ElseIf valu_target1.Value = 214 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(140)
        ElseIf valu_target1.Value = 216 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(141)
        ElseIf valu_target1.Value = 218 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(142)
        ElseIf valu_target1.Value = 229 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(143)
        ElseIf valu_target1.Value = 230 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(144)
        ElseIf valu_target1.Value = 231 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(145)
        ElseIf valu_target1.Value = 232 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(146)
        ElseIf valu_target1.Value = 233 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(147)
        ElseIf valu_target1.Value = 234 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(148)
        ElseIf valu_target1.Value = 235 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(149)
        ElseIf valu_target1.Value = 236 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(150)
        ElseIf valu_target1.Value = 237 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(151)
        ElseIf valu_target1.Value = 238 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(152)
        ElseIf valu_target1.Value = 239 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(153)
        ElseIf valu_target1.Value = 240 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(154)
        ElseIf valu_target1.Value = 241 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(155)
        ElseIf valu_target1.Value = 242 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(156)
        ElseIf valu_target1.Value = 243 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(157)
        ElseIf valu_target1.Value = 244 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(158)
        ElseIf valu_target1.Value = 245 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(159)
        ElseIf valu_target1.Value = 246 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(160)
        ElseIf valu_target1.Value = 247 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(161)
        ElseIf valu_target1.Value = 248 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(162)
        ElseIf valu_target1.Value = 249 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(163)
        ElseIf valu_target1.Value = 250 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(164)
        ElseIf valu_target1.Value = 251 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(165)
        ElseIf valu_target1.Value = 252 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(166)
        ElseIf valu_target1.Value = 253 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(167)
        ElseIf valu_target1.Value = 254 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(168)
        ElseIf valu_target1.Value = 255 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(169)
        ElseIf valu_target1.Value = 256 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(170)
        ElseIf valu_target1.Value = 257 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(171)
        ElseIf valu_target1.Value = 258 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(172)
        ElseIf valu_target1.Value = 259 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(173)
        ElseIf valu_target1.Value = 260 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(174)
        ElseIf valu_target1.Value = 261 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(175)
        ElseIf valu_target1.Value = 262 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(176)
        ElseIf valu_target1.Value = 263 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(177)
        ElseIf valu_target1.Value = 264 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(178)
        ElseIf valu_target1.Value = 265 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(179)
        ElseIf valu_target1.Value = 266 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(180)
        ElseIf valu_target1.Value = 267 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(181)
        ElseIf valu_target1.Value = 268 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(182)
        ElseIf valu_target1.Value = 269 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(183)
        ElseIf valu_target1.Value = 270 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(184)
        ElseIf valu_target1.Value = 271 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(185)
        ElseIf valu_target1.Value = 272 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(186)
        ElseIf valu_target1.Value = 273 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(187)
        ElseIf valu_target1.Value = 274 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(188)
        ElseIf valu_target1.Value = 275 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(189)
        ElseIf valu_target1.Value = 276 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(190)
        ElseIf valu_target1.Value = 277 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(191)
        ElseIf valu_target1.Value = 278 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(192)
        ElseIf valu_target1.Value = 279 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(193)
        ElseIf valu_target1.Value = 280 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(194)
        ElseIf valu_target1.Value = 281 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(195)
        ElseIf valu_target1.Value = 282 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(196)
        ElseIf valu_target1.Value = 283 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(197)
        ElseIf valu_target1.Value = 284 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(198)
        ElseIf valu_target1.Value = 285 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(199)
        ElseIf valu_target1.Value = 286 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(200)
        ElseIf valu_target1.Value = 287 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(201)
        ElseIf valu_target1.Value = 288 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(202)
        ElseIf valu_target1.Value = 289 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(203)
        ElseIf valu_target1.Value = 290 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(204)
        ElseIf valu_target1.Value = 291 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(205)
        ElseIf valu_target1.Value = 292 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(206)
        ElseIf valu_target1.Value = 293 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(207)
        ElseIf valu_target1.Value = 294 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(208)
        ElseIf valu_target1.Value = 295 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(209)
        ElseIf valu_target1.Value = 296 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(210)
        ElseIf valu_target1.Value = 297 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(211)
        ElseIf valu_target1.Value = 298 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(212)
        ElseIf valu_target1.Value = 299 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(213)
        ElseIf valu_target1.Value = 300 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(214)
        ElseIf valu_target1.Value = 301 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(215)
        ElseIf valu_target1.Value = 302 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(216)
        ElseIf valu_target1.Value = 303 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(217)
        ElseIf valu_target1.Value = 351 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(218)
        ElseIf valu_target1.Value = 352 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(219)
        ElseIf valu_target1.Value = 353 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(220)
        ElseIf valu_target1.Value = 369 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(221)
        ElseIf valu_target1.Value = 372 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(222)
        ElseIf valu_target1.Value = 373 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(223)
        ElseIf valu_target1.Value = 374 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(224)
        ElseIf valu_target1.Value = 375 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(225)
        ElseIf valu_target1.Value = 376 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(226)
        ElseIf valu_target1.Value = 377 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(227)
        ElseIf valu_target1.Value = 378 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(228)
        ElseIf valu_target1.Value = 379 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(229)
        ElseIf valu_target1.Value = 380 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(230)
        ElseIf valu_target1.Value = 72 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(231)
        End If
    End Sub
End Class