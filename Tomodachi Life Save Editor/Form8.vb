Public Class Form8
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
End Class