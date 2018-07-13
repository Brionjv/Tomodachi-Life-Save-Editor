Public Class Miimusic_edit
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
    Dim Miirmusic As String
    Dim Miirtitlemusic As String
    Dim Accessmiimusic As String
    Dim Accessrmusic As String

    Public Sub readmusic()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6
            valu_pagh_1.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic
            Pagh1 = Reader.Position
            Text_pagh_1.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + &H68
            valu_pagh_2.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + &H68
            Pagh2 = Reader.Position
            Text_pagh_2.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 2)
            valu_pagh_3.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 2)
            Pagh3 = Reader.Position
            Text_pagh_3.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 3)
            valu_pagh_4.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 3)
            Pagh4 = Reader.Position
            Text_pagh_4.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 4)
            valu_pagh_5.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 4)
            Pagh5 = Reader.Position
            Text_pagh_5.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 5)
            valu_pagh_6.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 5)
            Pagh6 = Reader.Position
            Text_pagh_6.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 6)
            valu_pagh_7.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 6)
            Pagh7 = Reader.Position
            Text_pagh_7.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 7)
            valu_pagh_8.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 7)
            Pagh8 = Reader.Position
            Text_pagh_8.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 8)
            valu_pagh_9.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 8)
            Pagh9 = Reader.Position
            Text_pagh_9.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 9)
            valu_pagh_10.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 9)
            Pagh10 = Reader.Position
            Text_pagh_10.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 10)
            valu_pagh_11.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 10)
            Pagh11 = Reader.Position
            Text_pagh_11.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 11)
            valu_pagh_12.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 11)
            Pagh12 = Reader.Position
            Text_pagh_12.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic - 6 + (&H68 * 12)
            valu_pagh_13.Value = Reader.ReadByte
            Reader.Position = &H63802 + Accessrmusic + Accessmiimusic + (&H68 * 12)
            Pagh13 = Reader.Position
            Text_pagh_13.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H63D44 + Accessrmusic + Accessmiimusic
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

    Private Sub Miimusic_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedataArc = TL_SaveEditor.TextBox_fpath.Text
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Text_save.Text = "Save"
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Text_save.Text = "Enregistrer"
        End If
        If TL_SaveEditor.Filever_text.Text = "EU" Or TL_SaveEditor.Filever_text.Text = "US" Then
            If TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(0) Then
                Accessmiimusic = &H0
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(1) Then
                Accessmiimusic = &H2CA0
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(2) Then
                Accessmiimusic = &H2CA0 * 2
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(3) Then
                Accessmiimusic = &H2CA0 * 3
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(4) Then
                Accessmiimusic = &H2CA0 * 4
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(5) Then
                Accessmiimusic = &H2CA0 * 5
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(6) Then
                Accessmiimusic = &H2CA0 * 6
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(7) Then
                Accessmiimusic = &H2CA0 * 7
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(8) Then
                Accessmiimusic = &H2CA0 * 8
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(9) Then
                Accessmiimusic = &H2CA0 * 9
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(10) Then
                Accessmiimusic = &H2CA0 * 10
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(11) Then
                Accessmiimusic = &H2CA0 * 11
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(12) Then
                Accessmiimusic = &H2CA0 * 12
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(13) Then
                Accessmiimusic = &H2CA0 * 13
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(14) Then
                Accessmiimusic = &H2CA0 * 14
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(15) Then
                Accessmiimusic = &H2CA0 * 15
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(16) Then
                Accessmiimusic = &H2CA0 * 16
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(17) Then
                Accessmiimusic = &H2CA0 * 17
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(18) Then
                Accessmiimusic = &H2CA0 * 18
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(19) Then
                Accessmiimusic = &H2CA0 * 19
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(20) Then
                Accessmiimusic = &H2CA0 * 20
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(21) Then
                Accessmiimusic = &H2CA0 * 21
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(22) Then
                Accessmiimusic = &H2CA0 * 22
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(23) Then
                Accessmiimusic = &H2CA0 * 23
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(24) Then
                Accessmiimusic = &H2CA0 * 24
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(25) Then
                Accessmiimusic = &H2CA0 * 25
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(26) Then
                Accessmiimusic = &H2CA0 * 26
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(27) Then
                Accessmiimusic = &H2CA0 * 27
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(28) Then
                Accessmiimusic = &H2CA0 * 28
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(29) Then
                Accessmiimusic = &H2CA0 * 29
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(30) Then
                Accessmiimusic = &H2CA0 * 30
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(31) Then
                Accessmiimusic = &H2CA0 * 31
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(32) Then
                Accessmiimusic = &H2CA0 * 32
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(33) Then
                Accessmiimusic = &H2CA0 * 33
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(34) Then
                Accessmiimusic = &H2CA0 * 34
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(35) Then
                Accessmiimusic = &H2CA0 * 35
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(36) Then
                Accessmiimusic = &H2CA0 * 36
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(37) Then
                Accessmiimusic = &H2CA0 * 37
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(38) Then
                Accessmiimusic = &H2CA0 * 38
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(39) Then
                Accessmiimusic = &H2CA0 * 39
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(40) Then
                Accessmiimusic = &H2CA0 * 40
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(41) Then
                Accessmiimusic = &H2CA0 * 41
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(42) Then
                Accessmiimusic = &H2CA0 * 42
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(43) Then
                Accessmiimusic = &H2CA0 * 43
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(44) Then
                Accessmiimusic = &H2CA0 * 44
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(45) Then
                Accessmiimusic = &H2CA0 * 45
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(46) Then
                Accessmiimusic = &H2CA0 * 46
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(47) Then
                Accessmiimusic = &H2CA0 * 47
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(48) Then
                Accessmiimusic = &H2CA0 * 48
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(49) Then
                Accessmiimusic = &H2CA0 * 49
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(50) Then
                Accessmiimusic = &H2CA0 * 50
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(51) Then
                Accessmiimusic = &H2CA0 * 51
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(52) Then
                Accessmiimusic = &H2CA0 * 52
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(53) Then
                Accessmiimusic = &H2CA0 * 53
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(54) Then
                Accessmiimusic = &H2CA0 * 54
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(55) Then
                Accessmiimusic = &H2CA0 * 55
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(56) Then
                Accessmiimusic = &H2CA0 * 56
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(57) Then
                Accessmiimusic = &H2CA0 * 57
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(58) Then
                Accessmiimusic = &H2CA0 * 58
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(59) Then
                Accessmiimusic = &H2CA0 * 59
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(60) Then
                Accessmiimusic = &H2CA0 * 60
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(61) Then
                Accessmiimusic = &H2CA0 * 61
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(62) Then
                Accessmiimusic = &H2CA0 * 62
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(63) Then
                Accessmiimusic = &H2CA0 * 63
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(64) Then
                Accessmiimusic = &H2CA0 * 64
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(65) Then
                Accessmiimusic = &H2CA0 * 65
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(66) Then
                Accessmiimusic = &H2CA0 * 66
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(67) Then
                Accessmiimusic = &H2CA0 * 67
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(68) Then
                Accessmiimusic = &H2CA0 * 68
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(69) Then
                Accessmiimusic = &H2CA0 * 69
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(70) Then
                Accessmiimusic = &H2CA0 * 70
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(71) Then
                Accessmiimusic = &H2CA0 * 71
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(72) Then
                Accessmiimusic = &H2CA0 * 72
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(73) Then
                Accessmiimusic = &H2CA0 * 73
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(74) Then
                Accessmiimusic = &H2CA0 * 74
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(75) Then
                Accessmiimusic = &H2CA0 * 75
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(76) Then
                Accessmiimusic = &H2CA0 * 76
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(77) Then
                Accessmiimusic = &H2CA0 * 77
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(78) Then
                Accessmiimusic = &H2CA0 * 78
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(79) Then
                Accessmiimusic = &H2CA0 * 79
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(80) Then
                Accessmiimusic = &H2CA0 * 80
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(81) Then
                Accessmiimusic = &H2CA0 * 81
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(82) Then
                Accessmiimusic = &H2CA0 * 82
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(83) Then
                Accessmiimusic = &H2CA0 * 83
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(84) Then
                Accessmiimusic = &H2CA0 * 84
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(85) Then
                Accessmiimusic = &H2CA0 * 85
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(86) Then
                Accessmiimusic = &H2CA0 * 86
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(87) Then
                Accessmiimusic = &H2CA0 * 87
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(88) Then
                Accessmiimusic = &H2CA0 * 88
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(89) Then
                Accessmiimusic = &H2CA0 * 89
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(90) Then
                Accessmiimusic = &H2CA0 * 90
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(91) Then
                Accessmiimusic = &H2CA0 * 91
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(92) Then
                Accessmiimusic = &H2CA0 * 92
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(93) Then
                Accessmiimusic = &H2CA0 * 93
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(94) Then
                Accessmiimusic = &H2CA0 * 94
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(95) Then
                Accessmiimusic = &H2CA0 * 95
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(96) Then
                Accessmiimusic = &H2CA0 * 96
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(97) Then
                Accessmiimusic = &H2CA0 * 97
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(98) Then
                Accessmiimusic = &H2CA0 * 98
            ElseIf TL_SaveEditor.Select_mii.SelectedItem = TL_SaveEditor.Select_mii.Items.Item(99) Then
                Accessmiimusic = &H2CA0 * 99
            End If
        End If
    End Sub

    Private Sub Icon_return_Click(sender As Object, e As EventArgs) Handles Icon_return.Click
        Me.Close()
    End Sub

    Public Sub unselectmusic()
        Fea_musics_ballad.BackColor = Color.Transparent
        Fea_musics_metal.BackColor = Color.Transparent
        Fea_musics_musical.BackColor = Color.Transparent
        Fea_musics_opera.BackColor = Color.Transparent
        Fea_musics_pop.BackColor = Color.Transparent
        Fea_musics_rap.BackColor = Color.Transparent
        Fea_musics_rockroll.BackColor = Color.Transparent
        Fea_musics_techno.BackColor = Color.Transparent
    End Sub

    Private Sub valu_selected_music_ValueChanged(sender As Object, e As EventArgs) Handles valu_selected_music.ValueChanged
        unselectmusic()
        If valu_selected_music.Value = 1 Then
            Accessrmusic = &H0
            Fea_musics_metal.BackColor = Color.Orange
        ElseIf valu_selected_music.Value = 2 Then
            Accessrmusic = &H594
            Fea_musics_pop.BackColor = Color.Orange
        ElseIf valu_selected_music.Value = 3 Then
            Accessrmusic = &H594 * 2
            Fea_musics_rockroll.BackColor = Color.Orange
        ElseIf valu_selected_music.Value = 4 Then
            Accessrmusic = &H594 * 3
            Fea_musics_rap.BackColor = Color.Orange
        ElseIf valu_selected_music.Value = 5 Then
            Accessrmusic = &H594 * 4
            Fea_musics_ballad.BackColor = Color.Orange
        ElseIf valu_selected_music.Value = 6 Then
            Accessrmusic = &H594 * 5
            Fea_musics_opera.BackColor = Color.Orange
        ElseIf valu_selected_music.Value = 7 Then
            Accessrmusic = &H594 * 6
            Fea_musics_techno.BackColor = Color.Orange
        ElseIf valu_selected_music.Value = 8 Then
            Accessrmusic = &H594 * 7
            Fea_musics_musical.BackColor = Color.Orange
        End If
        savedataArc = TL_SaveEditor.TextBox_fpath.Text
        readmusic()
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

    Private Sub Text_edit_metal_Click(sender As Object, e As EventArgs) Handles Text_edit_metal.Click
        valu_selected_music.Value = 1
    End Sub

    Private Sub Text_edit_pop_Click(sender As Object, e As EventArgs) Handles Text_edit_pop.Click
        valu_selected_music.Value = 2
    End Sub

    Private Sub Text_edit_rockroll_Click(sender As Object, e As EventArgs) Handles Text_edit_rockroll.Click
        valu_selected_music.Value = 3
    End Sub

    Private Sub Text_edit_rap_Click(sender As Object, e As EventArgs) Handles Text_edit_rap.Click
        valu_selected_music.Value = 4
    End Sub

    Private Sub Text_edit_ballad_Click(sender As Object, e As EventArgs) Handles Text_edit_ballad.Click
        valu_selected_music.Value = 5
    End Sub

    Private Sub Text_edit_opera_Click(sender As Object, e As EventArgs) Handles Text_edit_opera.Click
        valu_selected_music.Value = 6
    End Sub

    Private Sub Text_edit_techno_Click(sender As Object, e As EventArgs) Handles Text_edit_techno.Click
        valu_selected_music.Value = 7
    End Sub

    Private Sub Text_edit_musical_Click(sender As Object, e As EventArgs) Handles Text_edit_musical.Click
        valu_selected_music.Value = 8
    End Sub

    Private Sub Miimusic_edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        valu_selected_music.Value = TL_SaveEditor.valu_selected_music.Value
        Timer1.Stop()
    End Sub
End Class