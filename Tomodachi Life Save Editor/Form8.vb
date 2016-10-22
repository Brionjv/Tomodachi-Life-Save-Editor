Public Class Form8

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox11.Text = "EN" Then
            Label2.Visible = True
            Label3.Visible = False
            Label1.Text = "Close"
            Label1.Location = New Point(164, 213)
        End If
        If Form1.ComboBox11.Text = "FR" Then
            Label2.Visible = False
            Label3.Visible = True
            Label1.Text = "Fermer"
            Label1.Location = New Point(161, 213)
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(0) Then
            PictureBox2.BackgroundImage = My.Resources.tomoF1
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(1) Then
            PictureBox2.BackgroundImage = My.Resources.tomoF
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(2) Then
            PictureBox2.BackgroundImage = My.Resources.tomoJ
        End If
    End Sub
End Class