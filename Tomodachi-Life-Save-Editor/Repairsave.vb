Imports System.IO
Imports PackageIO

Public Class Repairsave
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim savedataArc As String

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

    Private Sub Repairsave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TL_SaveEditor.Filever_text.Text = "US" Then
            TLSE_logo.Image = My.Resources.logo_US
        ElseIf TL_SaveEditor.Filever_text.Text = "EU" Then
            TLSE_logo.Image = My.Resources.logo_EU
        ElseIf TL_SaveEditor.Filever_text.Text = "JP" Then
            TLSE_logo.Image = My.Resources.logo_JP
        ElseIf TL_SaveEditor.Filever_text.Text = "KR" Then
            TLSE_logo.Image = My.Resources.logo_KR
        End If
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Dim open As New OpenFileDialog
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Open savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor will make a backup of your save file before any changes, check ''bak\Tryrepair'' folder" & vbNewLine & vbNewLine & "Make sure you have choose right save file version"
            TLSE_dialog.ShowDialog()
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Ouvrir savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor va faire une copie de votre sauvegarde avant tout changements, vérifiez le dossier ''bak\Tryrepair''" & vbNewLine & vbNewLine & "Soyez sûr d'avoir choisi la bonne version de sauvegarde"
            TLSE_dialog.ShowDialog()
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            open.Filter = "Text files|*.txt"
            open.Title = "Open save savedataArc.txt"
        End If
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            open.Filter = "Fichiers texte|*.txt"
            open.Title = "Ouvrir la sauvegarde savedataArc.txt"
        End If
        open.ShowDialog()
        savedataArc = open.FileName
        readsavedataArc()
        makebak()
    End Sub

    Public Sub readsavedataArc()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H0
            Text_header.Text = Reader.ReadHexString(4)
            Text_menu_open.Visible = False
            Text_menu_save.Visible = True
            Icon_repair_header.Visible = True
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read savedataArc.txt, make sure to have opened a Tomodachi Life save, or report this issue"
                TLSE_dialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'ouverture de savedataArc.txt a échoué, soyez sûr d'avoir ouvert une sauvegarde de Tomodachi Life, ou signalez cet erreur"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub makebak()
        Try
            My.Computer.FileSystem.CopyFile(
                         savedataArc,
                       applicationpath & "\bak\Tryrepair\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub writesavedataArc()
        Try
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writer.Position = &H0
            Writer.WriteHexString(Text_header.Text)
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "savedataArc.txt has been successfully edited"
                TLSE_dialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "savedataArc.txt a été édité avec succès"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to write savedataArc.txt, make sure to have opened a Tomodachi Life save, or report this issue"
                TLSE_dialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'écriture de savedataArc.txt a échoué, soyez sûr d'avoir ouvert une sauvegarde de Tomodachi Life, ou signalez cet erreur"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Text_header_TextChanged(sender As Object, e As EventArgs) Handles Text_header.TextChanged
        If Text_header.Text = "11000000" Then
            Icon_repair_header.Image = My.Resources.repair_somethinggood
        Else
            Icon_repair_header.Image = My.Resources.repair_somethingwrong
            Text_header.BackColor = Color.Red
        End If
    End Sub

    Private Sub Info_repair_MouseMove(sender As Object, e As EventArgs) Handles Info_repair.MouseMove
        Icon_info_repair.Visible = True
    End Sub

    Private Sub Info_repair_MouseLeave(sender As Object, e As EventArgs) Handles Info_repair.MouseLeave
        Icon_info_repair.Visible = False
    End Sub

    Private Sub Icon_repair_header_Click(sender As Object, e As EventArgs) Handles Icon_repair_header.Click
        Text_header.Text = "11000000"
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writesavedataArc()
    End Sub
End Class