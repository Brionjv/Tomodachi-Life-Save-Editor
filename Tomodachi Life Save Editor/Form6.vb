Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(0) Then
            PictureBox2.BackgroundImage = My.Resources.tomoF1
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(1) Then
            PictureBox2.BackgroundImage = My.Resources.tomoF
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(2) Then
            PictureBox2.BackgroundImage = My.Resources.tomoJ
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(3) Then
            PictureBox2.BackgroundImage = My.Resources.tomoK
        End If
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Done"
            Label1.Location = New Point(174, 170)
            Label2.Text = "Catchphrase"
            Label2.Location = New Point(157, 56)
        End If
        If Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Enregistrer"
            Label1.Location = New Point(162, 170)
            Label2.Text = "Expression favorite"
            Label2.Location = New Point(142, 56)
        End If
        TextBox10.Text = Form1.Label20.Text
        TextBox11.Text = Form1.Label21.Text
        TextBox12.Text = Form1.Label22.Text
        TextBox13.Text = Form1.Label23.Text
        TextBox14.Text = Form1.Label24.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Label20.Text = My.Settings.catch1
        Form1.Label21.Text = My.Settings.catch2
        Form1.Label22.Text = My.Settings.catch3
        Form1.Label23.Text = My.Settings.catch4
        Form1.Label24.Text = My.Settings.catch5
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Label20.Text = My.Settings.catch1
        Form1.Label21.Text = My.Settings.catch2
        Form1.Label22.Text = My.Settings.catch3
        Form1.Label23.Text = My.Settings.catch4
        Form1.Label24.Text = My.Settings.catch5
    End Sub

    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.catch1 = TextBox10.Text
        My.Settings.catch2 = TextBox11.Text
        My.Settings.catch3 = TextBox12.Text
        My.Settings.catch4 = TextBox13.Text
        My.Settings.catch5 = TextBox14.Text
        My.Settings.Save()

        e.Cancel = False
    End Sub
End Class