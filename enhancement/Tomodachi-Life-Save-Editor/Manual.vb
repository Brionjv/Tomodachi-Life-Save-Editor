Public Class Manual
    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
        TL_SaveEditor.Show()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_islandbuild_MouseMove(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseMove
        Info_image.Visible = True
    End Sub

    Private Sub Info_islandbuild_MouseLeave(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseLeave
        Info_image.Visible = False
    End Sub
End Class