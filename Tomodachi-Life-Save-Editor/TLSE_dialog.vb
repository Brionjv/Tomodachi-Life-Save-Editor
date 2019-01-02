Imports System.Windows.Forms

Public Class TLSE_dialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TLSE_dialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Panel_OK.Visible = False
        Panel_Cancel.Visible = False
        Icon_reference.Image = Nothing
        Icon_reference.Location = New Point(86, 36)
        Panel_dialog.Location = New Point(83, 118)
        Cancel_Button.Text = "Cancel"
        OK_Button.Text = "OK"
    End Sub

    Private Sub Text_TLSE_dialog_Click(sender As Object, e As EventArgs) Handles Text_TLSE_dialog.Click
        If Panel_OK.Visible = False And Panel_Cancel.Visible = False Then
            Me.Close()
        End If
    End Sub

    Private Sub TLSE_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DesktopLocation = TL_SaveEditor.DesktopLocation
    End Sub
End Class