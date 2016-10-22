Public Class Form9

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.NumericUpDown20.Value = My.Settings.experience
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.NumericUpDown20.Value = My.Settings.experience
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Done"
            Label1.Location = New Point(98, 107)
        End If
        If Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Enregistrer"
            Label1.Location = New Point(86, 107)
        End If
        NumericUpDown20.Value = Form1.NumericUpDown20.Value
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

    Private Sub Form9_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.experience = NumericUpDown20.Value
        My.Settings.Save()

        e.Cancel = False
    End Sub
End Class