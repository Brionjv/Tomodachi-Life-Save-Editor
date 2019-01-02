Public Class Specialcharacter
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseDown, TLSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TLSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseUp, TLSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TLSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseMove, TLSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Public Sub hidepanels()
        Panelsymbol_3ds.Visible = False
        Panelsymbol_ds.Visible = False
        Panelsymbol_dsi.Visible = False
        Panelsymbol_pictochat.Visible = False
        Panelsymbol_wii.Visible = False
    End Sub

    Private Sub Text_ds_Click(sender As Object, e As EventArgs) Handles Text_ds.Click
        hidepanels()
        Panelsymbol_ds.Visible = True
    End Sub

    Private Sub Text_dsi_Click(sender As Object, e As EventArgs) Handles Text_dsi.Click
        hidepanels()
        Panelsymbol_dsi.Visible = True
    End Sub

    Private Sub Text_3ds_Click(sender As Object, e As EventArgs) Handles Text_3ds.Click
        hidepanels()
        Panelsymbol_3ds.Visible = True
    End Sub

    Private Sub Text_pictochat_Click(sender As Object, e As EventArgs) Handles Text_pictochat.Click
        hidepanels()
        Panelsymbol_pictochat.Visible = True
    End Sub

    Private Sub Text_wii_Click(sender As Object, e As EventArgs) Handles Text_wii.Click
        hidepanels()
        Panelsymbol_wii.Visible = True
    End Sub
End Class