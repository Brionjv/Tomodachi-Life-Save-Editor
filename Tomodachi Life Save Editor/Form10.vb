Public Class Form10

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 0 Then
            PictureBox1.Image = My.Resources.fullness_estomac
            ComboBox1.SelectedItem = ComboBox1.Items.Item(0)
        End If
        If NumericUpDown1.Value = 25 Then
            PictureBox1.Image = My.Resources.fullness_estomac25
            ComboBox1.SelectedItem = ComboBox1.Items.Item(1)
        End If
        If NumericUpDown1.Value = 50 Then
            PictureBox1.Image = My.Resources.fullness_estomac50
            ComboBox1.SelectedItem = ComboBox1.Items.Item(2)
        End If
        If NumericUpDown1.Value = 75 Then
            PictureBox1.Image = My.Resources.fullness_estomac75
            ComboBox1.SelectedItem = ComboBox1.Items.Item(3)
        End If
        If NumericUpDown1.Value = 100 Then
            PictureBox1.Image = My.Resources.fullness_estomac100
            ComboBox1.SelectedItem = ComboBox1.Items.Item(4)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            NumericUpDown1.Value = 0
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            NumericUpDown1.Value = 25
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(2) Then
            NumericUpDown1.Value = 50
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(3) Then
            NumericUpDown1.Value = 75
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(4) Then
            NumericUpDown1.Value = 100
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.NumericUpDown21.Value = My.Settings.estomac
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form1.NumericUpDown21.Value = My.Settings.estomac
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Done"
            Label1.Location = New Point(112, 98)
            ComboBox1.Items.Item(0) = "Empty"
            ComboBox1.Items.Item(4) = "Full"
        End If
        If Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Enregistrer"
            Label1.Location = New Point(100, 98)
            ComboBox1.Items.Item(0) = "Vide"
            ComboBox1.Items.Item(4) = "Plein"
        End If
        If Form1.ComboBox11.Text = "DE" Then
            Label1.Text = "Fertig"
            Label1.Location = New Point(110, 98)
            ComboBox1.Items.Item(0) = "leer"
            ComboBox1.Items.Item(4) = "voll"
        End If
        If Form1.ComboBox11.Text = "PT" Then
            Label1.Text = "Feito"
            Label1.Location = New Point(111, 98)
            ComboBox1.Items.Item(0) = "Vazio"
            ComboBox1.Items.Item(4) = "Cheio"
        End If
        NumericUpDown1.Value = Form1.NumericUpDown21.Value
    End Sub
    Private Sub Form10_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.estomac = NumericUpDown1.Value
        My.Settings.Save()

        e.Cancel = False
    End Sub
End Class