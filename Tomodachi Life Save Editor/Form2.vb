Public Class Form2

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Label11.Text = My.Settings.Island
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Label11.Text = My.Settings.Island
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Island = TextBox1.Text
        My.Settings.Save()

        e.Cancel = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.Label11.Text
        If Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Enregistrer"
            Label1.Location = New Point(100, 60)
        End If
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Done"
            Label1.Location = New Point(111, 60)
        End If
        If Form1.ComboBox11.Text = "DE" Then
            Label1.Text = "Fertig"
            Label1.Location = New Point(109, 60)
        End If
    End Sub
End Class