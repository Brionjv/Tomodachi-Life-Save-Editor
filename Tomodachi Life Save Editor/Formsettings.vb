Public Class Formsettings
    Private Sub Formsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Form1.PictureBox30.Image
        CheckBox1.Checked = Form1.CheckBox35.Checked
        CheckBox2.Checked = Form1.CheckBox36.Checked
        If Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Fermer"
            Label1.Location = New Point(151, 381)
            Label4.Text = "Version 2.1.3"
            TabPage1.Text = "Paramètres"
            TabPage2.Text = "Changelog"
            CheckBox1.Text = "Voir les choses cachées"
            CheckBox2.Text = "Activer la musique de fond"
            Label7.Visible = False
            Label6.Visible = True
            Label5.Visible = False
            Label3.Visible = False
            Label8.Visible = False
        End If
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Close"
            Label1.Location = New Point(152, 381)
            Label4.Text = "Version 2.1.3"
            TabPage1.Text = "Settings"
            TabPage2.Text = "Changelog"
            CheckBox1.Text = "See hidden things"
            CheckBox2.Text = "Active background music"
            Label7.Visible = False
            Label6.Visible = False
            Label5.Visible = False
            Label3.Visible = True
            Label8.Visible = False
        End If
        If Form1.ComboBox11.Text = "DE" Then
            Label1.Text = "schließen"
            Label1.Location = New Point(147, 381)
            Label4.Text = "Version 2.1.3"
            TabPage1.Text = "Einstellungen"
            TabPage2.Text = "Änderungsprotokoll"
            CheckBox1.Text = "Siehe versteckte Dinge"
            CheckBox2.Text = "Aktive Hintergrundmusik"
            Label7.Visible = True
            Label6.Visible = False
            Label5.Visible = False
            Label3.Visible = False
            Label8.Visible = False
        End If
        If Form1.ComboBox11.Text = "ES" Then
            Label1.Text = "Cerrar"
            Label1.Location = New Point(152, 381)
            Label4.Text = "Versión 2.1.3"
            TabPage1.Text = "Ajustes"
            TabPage2.Text = "Changelog"
            CheckBox1.Text = "Ver cosas ocultas"
            CheckBox2.Text = "Música de fondo activa"
            Label7.Visible = False
            Label6.Visible = False
            Label5.Visible = False
            Label3.Visible = False
            Label8.Visible = True
        End If
        If Form1.ComboBox11.Text = "PT" Then
            Label1.Text = "Fechar"
            Label1.Location = New Point(150, 381)
            Label4.Text = "Versão 2.1.3"
            TabPage1.Text = "Configurações"
            TabPage2.Text = "Changelog"
            CheckBox1.Text = "Veja coisas escondidas"
            CheckBox2.Text = "Música de fundo ativa"
            Label7.Visible = False
            Label6.Visible = False
            Label5.Visible = True
            Label3.Visible = False
            Label8.Visible = False
        End If
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://gbatemp.net/threads/wip-tomodachi-life-save-editor.399006/")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://www.paypal.me/Brionjv")
    End Sub
End Class