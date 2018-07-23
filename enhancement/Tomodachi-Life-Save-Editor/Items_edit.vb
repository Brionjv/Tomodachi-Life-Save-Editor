Imports PackageIO
Public Class Items_edit
    Dim savedataArc As String
    Dim fdialog As New Form2

    Public Sub hidesub()
        Icon_clothes_01.Visible = False
        Icon_clothes_02.Visible = False
        Icon_clothes_03.Visible = False
        Icon_clothes_04.Visible = False
        Icon_clothes_05.Visible = False
        Icon_normalfoods_01.Visible = False
        Icon_normalfoods_02.Visible = False
        Icon_normalfoods_03.Visible = False
        Icon_normalfoods_04.Visible = False
        Icon_hats_01.Visible = False
        Icon_hats_02.Visible = False
        Icon_hats_03.Visible = False
        Icon_treasures_01.Visible = False
        Icon_specialfoods.Visible = False
    End Sub

    Private Sub Icon_normalfoods_Click(sender As Object, e As EventArgs) Handles Icon_normalfoods.Click
        hidesub()
        Icon_normalfoods_01.Visible = True
        Icon_normalfoods_02.Visible = True
        Icon_normalfoods_03.Visible = True
        Icon_normalfoods_04.Visible = True
    End Sub

    Private Sub Icon_clothes_Click(sender As Object, e As EventArgs) Handles Icon_clothes.Click
        hidesub()
        Icon_clothes_01.Visible = True
        Icon_clothes_02.Visible = True
        Icon_clothes_03.Visible = True
        Icon_clothes_04.Visible = True
        Icon_clothes_05.Visible = True
    End Sub

    Private Sub Icon_hats_Click(sender As Object, e As EventArgs) Handles Icon_hats.Click
        hidesub()
        Icon_hats_01.Visible = True
        Icon_hats_02.Visible = True
        Icon_hats_03.Visible = True
    End Sub

    Private Sub Icon_interiors_Click(sender As Object, e As EventArgs) Handles Icon_interiors.Click
        hidesub()
    End Sub

    Private Sub Icon_gooditems_Click(sender As Object, e As EventArgs) Handles Icon_gooditems.Click
        hidesub()
    End Sub

    Private Sub Icon_treasures_Click(sender As Object, e As EventArgs) Handles Icon_treasures.Click
        hidesub()
        Icon_treasures_01.Visible = True
        Icon_specialfoods.Visible = True
    End Sub

    Private Sub Icon_return_Click(sender As Object, e As EventArgs) Handles Icon_return.Click
        Me.Close()
        TL_SaveEditor.Show()
    End Sub

    Private Sub Items_edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Loading.Close()
    End Sub

    Private Sub Items_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SavedataArc = TL_SaveEditor.TextBox_fpath.Text
    End Sub

    Private Sub Text_specialfoods_Click(sender As Object, e As EventArgs) Handles Text_specialfoods.Click
        Panel_specialfoods.Visible = True
    End Sub
End Class