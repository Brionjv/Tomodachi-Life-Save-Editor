Public Class Form8
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Fermer"
        End If
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Close"
        End If
        If Form1.ComboBox11.Text = "DE" Then
            Label1.Text = "schließen"
        End If
        If Form1.ComboBox11.Text = "ES" Then
            Label1.Text = "Cerrar"
        End If
        If Form1.ComboBox11.Text = "PT" Then
            Label1.Text = "Fechar"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class