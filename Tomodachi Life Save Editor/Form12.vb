Imports PackageIO
Public Class Form12
    Dim filepath As String
    Dim fdialog As New Form3
    Dim stmname As String
    Dim stmisland As String
    Dim stmexp As String
    Dim stmlv As String
    Dim stmregion As String
    Dim MonFichier As PackageIO.Reader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Form1.PictureBox30.Image
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Lv."
            Label3.Text = "Home"
            Label4.Text = "Happiness"
            Button1.Text = "Save"
        ElseIf Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Niv."
            Label3.Text = "Île d'origine"
            Label4.Text = "Détente"
            Button1.Text = "Enregistrer"
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                Reader.Position = &H392C0
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            End If
        Catch ex As Exception
            MsgBox("erreur")
        End Try
    End Sub
End Class