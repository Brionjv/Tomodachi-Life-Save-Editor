Public Class Loading
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TL_SaveEditor.Filever_text.Text = "US" Then
            Icon_loading.Image = My.Resources.logo_US
        ElseIf TL_SaveEditor.Filever_text.Text = "EU" Then
            Icon_loading.Image = My.Resources.logo_EU
        ElseIf TL_SaveEditor.Filever_text.Text = "JP" Then
            Icon_loading.Image = My.Resources.logo_JP
        ElseIf TL_SaveEditor.Filever_text.Text = "KR" Then
            Icon_loading.Image = My.Resources.logo_KR
        End If
    End Sub
End Class