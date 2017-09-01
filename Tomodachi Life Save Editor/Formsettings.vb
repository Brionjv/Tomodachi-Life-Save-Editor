Public Class Formsettings
    Private Sub Formsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Form1.PictureBox30.Image
        CheckBox1.Checked = Form1.CheckBox35.Checked
        CheckBox2.Checked = Form1.CheckBox36.Checked
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Formsettings_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.CheckBox35.Checked = CheckBox1.Checked
        Form1.CheckBox36.Checked = CheckBox2.Checked
    End Sub
End Class