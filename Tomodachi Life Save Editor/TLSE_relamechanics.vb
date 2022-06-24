Imports System.IO
Imports PackageIO
Public Class TLSE_relamechanics
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    'form settings
    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red_tl
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close_tl
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

    Private Sub Minimizebutton_Click(sender As Object, e As EventArgs) Handles Minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimizebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Minimizebutton.MouseMove
        Minimizebutton.Image = My.Resources.minimize_gray
    End Sub

    Private Sub Minimizebutton_MouseLeave(sender As Object, e As EventArgs) Handles Minimizebutton.MouseLeave
        Minimizebutton.Image = My.Resources.minimize
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
            Text_left_1.Text = "Can replace other relationships, some conditions is needed some times" & vbNewLine & "Example : if Spouse is set as Unknow " & vbNewLine & "Mii house need to be set as default, if they have babies can cause troubles"
            Text_left_2.Text = ""
            Text_mid_1.Text = "Mii 1 and Mii 2 can have other ''Unknow'' relationships"
            Text_mid_2.Text = ""
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_unknow
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
            Text_left_1.Text = "Can replace other relationships, some conditions is needed some times" & vbNewLine & "features link to relationships need to set as default"
            Text_left_2.Text = ""
            Text_mid_1.Text = "Mii 1 and Mii 2 can have other ''Friend'' relationships" & vbNewLine & "Can be ''Friend (in conflict)''"
            Text_mid_2.Text = ""
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_friends
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
            Text_left_1.Text = "" & vbNewLine & ""
            Text_left_2.Text = ""
            Text_mid_1.Text = "Can set as ''Unknow'', ''Friend'', ..."
            Text_mid_2.Text = "Mii 1 and Mii 2 can't have other ''Lover'' and ''Spouse'' relationships"
            Text_right_1.Text = "Can have same sex lover"
            Text_right_2.Text = "Can cause troubles in some case"
            Icon_mid.Image = My.Resources.icon_meca_lover
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
            Text_left_1.Text = "" & vbNewLine & ""
            Text_left_2.Text = ""
            Text_mid_1.Text = "Can replace relationships (except Parent/Child, Sibling)"
            Text_mid_2.Text = ""
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_ex
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
            Text_left_1.Text = "Must have same Mii house (default is value 1)"
            Text_left_2.Text = "Cause troubles if couple have same Mii house than other couple"
            Text_mid_1.Text = "Can have babies"
            Text_mid_2.Text = "Mii 1 and Mii 2 can't have other ''Lover'' and ''Spouse'' relationships"
            Text_right_1.Text = ""
            Text_right_2.Text = "Same sex couples can cause troubles"
            Icon_mid.Image = My.Resources.icon_meca_spouse
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
            Text_left_1.Text = "Must be a spouse, or ex, ex-spouse and be an adult to be Parent"
            Text_left_2.Text = ""
            Text_mid_1.Text = ""
            Text_mid_2.Text = ""
            Text_right_1.Text = "Must be a kid to be Child"
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_parentchild
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
            Text_left_1.Text = "" & vbNewLine & ""
            Text_left_2.Text = ""
            Text_mid_1.Text = "Can have other sibling"
            Text_mid_2.Text = ""
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_sibling
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
            Text_left_1.Text = "Replace only Friend status temporarily"
            Text_left_2.Text = ""
            Text_mid_1.Text = ""
            Text_mid_2.Text = ""
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_inconflict
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
            Text_left_1.Text = "Replace only Lover status temporarily"
            Text_left_2.Text = ""
            Text_mid_1.Text = ""
            Text_mid_2.Text = ""
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_inconflict
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
            Text_left_1.Text = "Replace only Spouse status temporarily"
            Text_left_2.Text = ""
            Text_mid_1.Text = ""
            Text_mid_2.Text = ""
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_inconflict
        End If
        If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
            Text_left_1.Text = ""
            Text_left_2.Text = ""
            Text_mid_1.Text = ""
            Text_mid_2.Text = "Can't have more than one best friend"
            Text_right_1.Text = ""
            Text_right_2.Text = ""
            Icon_mid.Image = My.Resources.icon_meca_bestfriends
        End If
    End Sub
    'end form settings
End Class