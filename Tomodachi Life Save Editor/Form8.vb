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
            Label4.Visible = False
            Label5.Visible = False
            Label1.Text = "Close"
            Label1.Location = New Point(164, 213)
        End If
        If Form1.ComboBox11.Text = "FR" Then
            Label2.Visible = False
            Label3.Visible = True
            Label4.Visible = False
            Label5.Visible = False
            Label1.Text = "Fermer"
            Label1.Location = New Point(161, 213)
        End If
        If Form1.ComboBox11.Text = "DE" Then
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = True
            Label5.Visible = False
            Label1.Text = "schließen"
            Label1.Location = New Point(160, 213)
        End If
        If Form1.ComboBox11.Text = "PT" Then
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = True
            Label1.Text = "Fechar"
            Label1.Location = New Point(162, 213)
        End If
        PictureBox2.BackgroundImage = Form1.PictureBox30.Image
    End Sub
End Class