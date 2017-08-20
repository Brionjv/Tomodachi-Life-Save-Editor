Public Class Form11

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Form1.PictureBox30.Image
        RadioButton5.Checked = True
        RadioButton6.Checked = True
        RadioButton7.Checked = True
        TextBox1.Text = Form1.TextBox5.Text
        If Form1.ComboBox11.Text = "FR" Then
            RadioButton1.Text = "Tous"
            RadioButton2.Text = "Aucun"
            RadioButton3.Text = "Aucun"
            RadioButton4.Text = "Tous"
            GroupBox1.Text = "Intérieurs"
            GroupBox2.Text = "Produits spéciaux"
            Label1.Text = "Fermer"
            Label1.Location = New Point(170, 276)
            GroupBox3.Text = "Objets divers"
            RadioButton9.Text = "Tous"
            RadioButton8.Text = "Aucun"
        End If
        If Form1.ComboBox11.Text = "EN" Then
            RadioButton1.Text = "All"
            RadioButton2.Text = "None"
            RadioButton3.Text = "None"
            RadioButton4.Text = "All"
            GroupBox1.Text = "Interiors"
            GroupBox2.Text = "Special foods"
            Label1.Text = "Close"
            Label1.Location = New Point(173, 276)
            GroupBox3.Text = "Goods items"
            RadioButton9.Text = "All"
            RadioButton8.Text = "None"
        End If
        If Form1.ComboBox11.Text = "DE" Then
            RadioButton1.Text = "alle"
            RadioButton2.Text = "nichts"
            RadioButton3.Text = "nichts"
            RadioButton4.Text = "alle"
            GroupBox1.Text = "Innenräume"
            GroupBox2.Text = "spezielle Gerichte"
            Label1.Text = "schließen"
            Label1.Location = New Point(166, 276)
            GroupBox3.Text = "gute Items"
            RadioButton9.Text = "alle"
            RadioButton8.Text = "nichts"
        End If
        If Form1.ComboBox11.Text = "PT" Then
            RadioButton1.Text = "Tudo"
            RadioButton2.Text = "Nenhum"
            RadioButton3.Text = "Nenhum"
            RadioButton4.Text = "Tudo"
            GroupBox1.Text = "Interiores"
            GroupBox2.Text = "Comidas Especiais"
            Label1.Text = "Fechar"
            Label1.Location = New Point(171, 276)
            GroupBox3.Text = "Artigos"
            RadioButton9.Text = "Tudo"
            RadioButton8.Text = "Nenhum"
        End If
        If Form1.Label7.Text = "All" Then
            RadioButton1.Checked = True
        End If
        If Form1.Label7.Text = "None" Then
            RadioButton2.Checked = True
        End If
        If Form1.Label25.Text = "All" Then
            RadioButton4.Checked = True
        End If
        If Form1.Label25.Text = "None" Then
            RadioButton3.Checked = True
        End If
        If Form1.Label26.Text = "All" Then
            RadioButton9.Checked = True
        End If
        If Form1.Label26.Text = "None" Then
            RadioButton8.Checked = True
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Form1.Label7.Text = "All"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Form1.Label7.Text = "None"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Form1.Label25.Text = "All"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Form1.Label25.Text = "None"
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Form1.Label26.Text = "All"
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Form1.Label26.Text = "None"
        End If
    End Sub
End Class