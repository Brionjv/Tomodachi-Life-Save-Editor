Imports PackageIO
Public Class Concert_edit
    Dim savedataArc As String
    Dim fdialog As New Form2
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

    Private Sub Concert_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedataArc = TL_SaveEditor.TextBox_fpath.Text
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Text_title.Text = "Concert room"
            Text_save.Text = "Save"
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Text_title.Text = "Salle de concert"
            Text_save.Text = "Enregistrer"
        End If
    End Sub

    Private Sub Icon_return_Click(sender As Object, e As EventArgs) Handles Icon_return.Click
        Me.Close()
    End Sub

    Private Sub Select_musics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_musics.SelectedIndexChanged
        If Select_musics.SelectedItem = Select_musics.Items.Item(0) Then
            Accesspagh = &H0
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(1) Then
            Accesspagh = &H5C4
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(2) Then
            Accesspagh = &H5C4 * 2
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(3) Then
            Accesspagh = &H5C4 * 3
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(4) Then
            Accesspagh = &H5C4 * 4
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(5) Then
            Accesspagh = &H5C4 * 5
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(6) Then
            Accesspagh = &H5C4 * 6
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(7) Then
            Accesspagh = &H5C4 * 7
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(8) Then
            Accesspagh = &H5C4 * 8
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(9) Then
            Accesspagh = &H5C4 * 9
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(10) Then
            Accesspagh = &H5C4 * 10
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(11) Then
            Accesspagh = &H5C4 * 11
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(12) Then
            Accesspagh = &H5C4 * 12
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(13) Then
            Accesspagh = &H5C4 * 13
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(14) Then
            Accesspagh = &H5C4 * 14
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(15) Then
            Accesspagh = &H5C4 * 15
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(16) Then
            Accesspagh = &H5C4 * 16
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(17) Then
            Accesspagh = &H5C4 * 17
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(18) Then
            Accesspagh = &H5C4 * 18
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(19) Then
            Accesspagh = &H5C4 * 19
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(20) Then
            Accesspagh = &H5C4 * 20
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(21) Then
            Accesspagh = &H5C4 * 21
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(22) Then
            Accesspagh = &H5C4 * 22
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(23) Then
            Accesspagh = &H5C4 * 23
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(24) Then
            Accesspagh = &H5C4 * 24
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(25) Then
            Accesspagh = &H5C4 * 25
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(26) Then
            Accesspagh = &H5C4 * 26
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(27) Then
            Accesspagh = &H5C4 * 27
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(28) Then
            Accesspagh = &H5C4 * 28
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(29) Then
            Accesspagh = &H5C4 * 29
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(30) Then
            Accesspagh = &H5C4 * 30
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(31) Then
            Accesspagh = &H5C4 * 31
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(32) Then
            Accesspagh = &H5C4 * 32
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(33) Then
            Accesspagh = &H5C4 * 33
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(34) Then
            Accesspagh = &H5C4 * 34
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(35) Then
            Accesspagh = &H5C4 * 35
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(36) Then
            Accesspagh = &H5C4 * 36
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(37) Then
            Accesspagh = &H5C4 * 37
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(38) Then
            Accesspagh = &H5C4 * 38
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(39) Then
            Accesspagh = &H5C4 * 39
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(40) Then
            Accesspagh = &H5C4 * 40
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(41) Then
            Accesspagh = &H5C4 * 41
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(42) Then
            Accesspagh = &H5C4 * 42
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(43) Then
            Accesspagh = &H5C4 * 43
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(44) Then
            Accesspagh = &H5C4 * 44
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(45) Then
            Accesspagh = &H5C4 * 45
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(46) Then
            Accesspagh = &H5C4 * 46
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(47) Then
            Accesspagh = &H5C4 * 47
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(48) Then
            Accesspagh = &H5C4 * 48
        ElseIf Select_musics.SelectedItem = Select_musics.Items.Item(49) Then
            Accesspagh = &H5C4 * 49
        End If
        readmusic()
    End Sub

    Public Sub readmusic()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H17B6E4 + Accesspagh
            valu_pagh_1.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh
            Pagh1 = Reader.Position
            Text_pagh_1.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + &H68
            valu_pagh_2.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + &H68
            Pagh2 = Reader.Position
            Text_pagh_2.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 2)
            valu_pagh_3.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 2)
            Pagh3 = Reader.Position
            Text_pagh_3.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 3)
            valu_pagh_4.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 3)
            Pagh4 = Reader.Position
            Text_pagh_4.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 4)
            valu_pagh_5.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 4)
            Pagh5 = Reader.Position
            Text_pagh_5.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 5)
            valu_pagh_6.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 5)
            Pagh6 = Reader.Position
            Text_pagh_6.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 6)
            valu_pagh_7.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 6)
            Pagh7 = Reader.Position
            Text_pagh_7.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 7)
            valu_pagh_8.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 7)
            Pagh8 = Reader.Position
            Text_pagh_8.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 8)
            valu_pagh_9.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 8)
            Pagh9 = Reader.Position
            Text_pagh_9.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 9)
            valu_pagh_10.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 9)
            Pagh10 = Reader.Position
            Text_pagh_10.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 10)
            valu_pagh_11.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 10)
            Pagh11 = Reader.Position
            Text_pagh_11.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 11)
            valu_pagh_12.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 11)
            Pagh12 = Reader.Position
            Text_pagh_12.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 12)
            valu_pagh_13.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 12)
            Pagh13 = Reader.Position
            Text_pagh_13.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17BC2C + Accesspagh
            Tmusc = Reader.Position
            Text_titlemusic.Text = Reader.ReadUnicodeString(32)
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to read savedataArc.txt, make sure you choose right save file version and to have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "La lecture de savedataArc.txt a échoué, soyez sûr d'avoir choisi la bonne version de sauvegarde et d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
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

    Private Sub Text_save_Click(sender As Object, e As EventArgs) Handles Text_save.Click
        Try
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
            Writer.WriteUnicodeString(Text_titlemusic.Text)
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Editing of this song has been saved"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "Les modifications de cette musique ont été enregistrées"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to write savedataArc.txt, make sure you choose right save file version and to have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'écriture de savedataArc.txt a échoué, soyez sûr d'avoir choisi la bonne version de sauvegarde et d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub
End Class