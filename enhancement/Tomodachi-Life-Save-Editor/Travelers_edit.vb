Imports System.IO
Imports PackageIO
Public Class Travelers_edit
    Dim Accesstravelers As String
    Dim fdialog As New Form2
    Dim savedataArc As String
    Dim stmexp As String
    Dim stmlv As String

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
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to read this traveler, load a save file first or report this issue"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "La lecture de ce voyageur a échoué, ouvrez une savegarde avant ou signalez cet erreur"
                fdialog.ShowDialog()
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
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "This traveler has been edited"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "Ce voyageur a été édité"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Editing of this traveler has failed, load a save file first or report this issue"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'édition de ce voyageur a échoué, ouvrez une savegarde avant ou signalez cet erreur"
                fdialog.ShowDialog()
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
        End If
        readtravelers()
    End Sub

    Private Sub Travelers_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedataArc = TL_SaveEditor.TextBox_fpath.Text
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Text_save.Text = "Save"
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Text_save.Text = "Enregistrer"
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
End Class