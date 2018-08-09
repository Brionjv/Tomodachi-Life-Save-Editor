Imports PackageIO
Imports System.IO
Public Class Items_edit
    Dim savedataArc As String
    Dim fdialog As New Form2
    Dim Goodsitems As String
    Dim Goodsitems_1 As String
    Dim Goodsitems_2 As String
    Dim Goodsitems_3 As String
    Dim Goodsitems_4 As String
    Dim Goodsitems_5 As String
    Dim Goodsitems_6 As String
    Dim Goodsitems_7 As String
    Dim Goodsitems_8 As String
    Dim Goodsitems_9 As String
    Dim Goodsitems_10 As String
    Dim Goodsitems_11 As String
    Dim Goodsitems_12 As String
    Dim Goodsitems_13 As String
    Dim Goodsitems_14 As String
    Dim Goodsitems_15 As String
    Dim Goodsitems_16 As String
    Dim Goodsitems_17 As String
    Dim Goodsitems_18 As String

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

    Public Sub hidepanels()
        Panel_specialfoods.Visible = False
        Panel_gooditems.Visible = False
        Panel_interiors.Visible = False
        Panel_interiors_1.Visible = False
    End Sub

    Public Sub readgoodsitems()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = Goodsitems
            Goodsitems_1 = Reader.Position
            valu_goodi_1.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 1
            Goodsitems_2 = Reader.Position
            valu_goodi_2.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 2
            Goodsitems_3 = Reader.Position
            valu_goodi_3.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 3
            Goodsitems_4 = Reader.Position
            valu_goodi_4.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 4
            Goodsitems_5 = Reader.Position
            valu_goodi_5.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 5
            Goodsitems_6 = Reader.Position
            valu_goodi_6.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 6
            Goodsitems_7 = Reader.Position
            valu_goodi_7.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 7
            Goodsitems_8 = Reader.Position
            valu_goodi_8.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 8
            Goodsitems_9 = Reader.Position
            valu_goodi_9.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 9
            Goodsitems_10 = Reader.Position
            valu_goodi_10.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 10
            Goodsitems_11 = Reader.Position
            valu_goodi_11.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 11
            Goodsitems_12 = Reader.Position
            valu_goodi_12.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 12
            Goodsitems_13 = Reader.Position
            valu_goodi_13.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 13
            Goodsitems_14 = Reader.Position
            valu_goodi_14.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 14
            Goodsitems_15 = Reader.Position
            valu_goodi_15.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 15
            Goodsitems_16 = Reader.Position
            valu_goodi_16.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 16
            Goodsitems_17 = Reader.Position
            valu_goodi_17.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 17
            Goodsitems_18 = Reader.Position
            valu_goodi_18.Value = Reader.ReadByte
        Catch ex As Exception

        End Try
    End Sub

    Public Sub writegoodsitems()
        Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        fs.Position = Goodsitems_1
        fs.WriteByte(valu_goodi_1.Value)
        fs.Position = Goodsitems_2
        fs.WriteByte(valu_goodi_2.Value)
        fs.Position = Goodsitems_3
        fs.WriteByte(valu_goodi_3.Value)
        fs.Position = Goodsitems_4
        fs.WriteByte(valu_goodi_4.Value)
        fs.Position = Goodsitems_5
        fs.WriteByte(valu_goodi_5.Value)
        fs.Position = Goodsitems_6
        fs.WriteByte(valu_goodi_6.Value)
        fs.Position = Goodsitems_7
        fs.WriteByte(valu_goodi_7.Value)
        fs.Position = Goodsitems_8
        fs.WriteByte(valu_goodi_8.Value)
        fs.Position = Goodsitems_9
        fs.WriteByte(valu_goodi_9.Value)
        fs.Position = Goodsitems_10
        fs.WriteByte(valu_goodi_10.Value)
        fs.Position = Goodsitems_11
        fs.WriteByte(valu_goodi_11.Value)
        fs.Position = Goodsitems_12
        fs.WriteByte(valu_goodi_12.Value)
        fs.Position = Goodsitems_13
        fs.WriteByte(valu_goodi_13.Value)
        fs.Position = Goodsitems_14
        fs.WriteByte(valu_goodi_14.Value)
        fs.Position = Goodsitems_15
        fs.WriteByte(valu_goodi_15.Value)
        fs.Position = Goodsitems_16
        fs.WriteByte(valu_goodi_16.Value)
        fs.Position = Goodsitems_17
        fs.WriteByte(valu_goodi_17.Value)
        fs.Position = Goodsitems_18
        fs.WriteByte(valu_goodi_18.Value)
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
        hidepanels()
        Panel_interiors.Visible = True
    End Sub

    Private Sub Icon_gooditems_Click(sender As Object, e As EventArgs) Handles Icon_gooditems.Click
        hidesub()
        hidepanels()
        Panel_gooditems.Visible = True
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
        savedataArc = TL_SaveEditor.TextBox_fpath.Text
        If TL_SaveEditor.Filever_text.Text = "US" Then
            Goodsitems = &H18F0
        ElseIf TL_SaveEditor.Filever_text.Text = "EU" Then
            Goodsitems = &H18F0
        ElseIf TL_SaveEditor.Filever_text.Text = "JP" Then
            Goodsitems = &H18F0
        ElseIf TL_SaveEditor.Filever_text.Text = "KR" Then
            Goodsitems = &H18F0
        End If
        readgoodsitems()
    End Sub

    Private Sub Text_specialfoods_Click(sender As Object, e As EventArgs) Handles Text_specialfoods.Click
        hidepanels()
        Panel_specialfoods.Visible = True
    End Sub

    Private Sub Icon_interiors_right_Click(sender As Object, e As EventArgs) Handles Icon_interiors_right.Click
        hidepanels()
        Panel_interiors_1.Visible = True
    End Sub

    Private Sub Icon_interiors_left_Click(sender As Object, e As EventArgs) Handles Icon_interiors_left.Click
        hidepanels()
        Panel_interiors.Visible = True
    End Sub

    Private Sub Check_available_goodi_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_1.CheckedChanged
        If Check_available_goodi_1.Checked = True Then
            Check_NA_goodi_1.Enabled = False
            valu_goodi_1.Enabled = False
            valu_goodi_1.Value = 254
        ElseIf Check_available_goodi_1.Checked = False Then
            Check_NA_goodi_1.Enabled = True
            valu_goodi_1.Enabled = True
            valu_goodi_1.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_1.CheckedChanged
        If Check_NA_goodi_1.Checked = True Then
            Check_available_goodi_1.Enabled = False
            valu_goodi_1.Enabled = False
            valu_goodi_1.Value = 253
        ElseIf Check_NA_goodi_1.Checked = False Then
            Check_available_goodi_1.Enabled = True
            valu_goodi_1.Enabled = True
            valu_goodi_1.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_2.CheckedChanged
        If Check_available_goodi_2.Checked = True Then
            Check_NA_goodi_2.Enabled = False
            valu_goodi_2.Enabled = False
            valu_goodi_2.Value = 254
        ElseIf Check_available_goodi_2.Checked = False Then
            Check_NA_goodi_2.Enabled = True
            valu_goodi_2.Enabled = True
            valu_goodi_2.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_2.CheckedChanged
        If Check_NA_goodi_2.Checked = True Then
            Check_available_goodi_2.Enabled = False
            valu_goodi_2.Enabled = False
            valu_goodi_2.Value = 253
        ElseIf Check_NA_goodi_2.Checked = False Then
            Check_available_goodi_2.Enabled = True
            valu_goodi_2.Enabled = True
            valu_goodi_2.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_3.CheckedChanged
        If Check_available_goodi_3.Checked = True Then
            Check_NA_goodi_3.Enabled = False
            valu_goodi_3.Enabled = False
            valu_goodi_3.Value = 254
        ElseIf Check_available_goodi_3.Checked = False Then
            Check_NA_goodi_3.Enabled = True
            valu_goodi_3.Enabled = True
            valu_goodi_3.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_3.CheckedChanged
        If Check_NA_goodi_3.Checked = True Then
            Check_available_goodi_3.Enabled = False
            valu_goodi_3.Enabled = False
            valu_goodi_3.Value = 253
        ElseIf Check_NA_goodi_3.Checked = False Then
            Check_available_goodi_3.Enabled = True
            valu_goodi_3.Enabled = True
            valu_goodi_3.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_4.CheckedChanged
        If Check_available_goodi_4.Checked = True Then
            Check_NA_goodi_4.Enabled = False
            valu_goodi_4.Enabled = False
            valu_goodi_4.Value = 254
        ElseIf Check_available_goodi_4.Checked = False Then
            Check_NA_goodi_4.Enabled = True
            valu_goodi_4.Enabled = True
            valu_goodi_4.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_4.CheckedChanged
        If Check_NA_goodi_4.Checked = True Then
            Check_available_goodi_4.Enabled = False
            valu_goodi_4.Enabled = False
            valu_goodi_4.Value = 253
        ElseIf Check_NA_goodi_4.Checked = False Then
            Check_available_goodi_4.Enabled = True
            valu_goodi_4.Enabled = True
            valu_goodi_4.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_5.CheckedChanged
        If Check_available_goodi_5.Checked = True Then
            Check_NA_goodi_5.Enabled = False
            valu_goodi_5.Enabled = False
            valu_goodi_5.Value = 254
        ElseIf Check_available_goodi_5.Checked = False Then
            Check_NA_goodi_5.Enabled = True
            valu_goodi_5.Enabled = True
            valu_goodi_5.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_5.CheckedChanged
        If Check_NA_goodi_5.Checked = True Then
            Check_available_goodi_5.Enabled = False
            valu_goodi_5.Enabled = False
            valu_goodi_5.Value = 253
        ElseIf Check_NA_goodi_5.Checked = False Then
            Check_available_goodi_5.Enabled = True
            valu_goodi_5.Enabled = True
            valu_goodi_5.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_6.CheckedChanged
        If Check_available_goodi_6.Checked = True Then
            Check_NA_goodi_6.Enabled = False
            valu_goodi_6.Enabled = False
            valu_goodi_6.Value = 254
        ElseIf Check_available_goodi_6.Checked = False Then
            Check_NA_goodi_6.Enabled = True
            valu_goodi_6.Enabled = True
            valu_goodi_6.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_6.CheckedChanged
        If Check_NA_goodi_6.Checked = True Then
            Check_available_goodi_6.Enabled = False
            valu_goodi_6.Enabled = False
            valu_goodi_6.Value = 253
        ElseIf Check_NA_goodi_6.Checked = False Then
            Check_available_goodi_6.Enabled = True
            valu_goodi_6.Enabled = True
            valu_goodi_6.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_7.CheckedChanged
        If Check_available_goodi_7.Checked = True Then
            Check_NA_goodi_7.Enabled = False
            valu_goodi_7.Enabled = False
            valu_goodi_7.Value = 254
        ElseIf Check_available_goodi_7.Checked = False Then
            Check_NA_goodi_7.Enabled = True
            valu_goodi_7.Enabled = True
            valu_goodi_7.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_7.CheckedChanged
        If Check_NA_goodi_7.Checked = True Then
            Check_available_goodi_7.Enabled = False
            valu_goodi_7.Enabled = False
            valu_goodi_7.Value = 253
        ElseIf Check_NA_goodi_7.Checked = False Then
            Check_available_goodi_7.Enabled = True
            valu_goodi_7.Enabled = True
            valu_goodi_7.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_8.CheckedChanged
        If Check_available_goodi_8.Checked = True Then
            Check_NA_goodi_8.Enabled = False
            valu_goodi_8.Enabled = False
            valu_goodi_8.Value = 254
        ElseIf Check_available_goodi_8.Checked = False Then
            Check_NA_goodi_8.Enabled = True
            valu_goodi_8.Enabled = True
            valu_goodi_8.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_8.CheckedChanged
        If Check_NA_goodi_8.Checked = True Then
            Check_available_goodi_8.Enabled = False
            valu_goodi_8.Enabled = False
            valu_goodi_8.Value = 253
        ElseIf Check_NA_goodi_8.Checked = False Then
            Check_available_goodi_8.Enabled = True
            valu_goodi_8.Enabled = True
            valu_goodi_8.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_9_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_9.CheckedChanged
        If Check_available_goodi_9.Checked = True Then
            Check_NA_goodi_9.Enabled = False
            valu_goodi_9.Enabled = False
            valu_goodi_9.Value = 254
        ElseIf Check_available_goodi_9.Checked = False Then
            Check_NA_goodi_9.Enabled = True
            valu_goodi_9.Enabled = True
            valu_goodi_9.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_9_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_9.CheckedChanged
        If Check_NA_goodi_9.Checked = True Then
            Check_available_goodi_9.Enabled = False
            valu_goodi_9.Enabled = False
            valu_goodi_9.Value = 253
        ElseIf Check_NA_goodi_9.Checked = False Then
            Check_available_goodi_9.Enabled = True
            valu_goodi_9.Enabled = True
            valu_goodi_9.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_10_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_10.CheckedChanged
        If Check_available_goodi_10.Checked = True Then
            Check_NA_goodi_10.Enabled = False
            valu_goodi_10.Enabled = False
            valu_goodi_10.Value = 254
        ElseIf Check_available_goodi_10.Checked = False Then
            Check_NA_goodi_10.Enabled = True
            valu_goodi_10.Enabled = True
            valu_goodi_10.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_10_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_10.CheckedChanged
        If Check_NA_goodi_10.Checked = True Then
            Check_available_goodi_10.Enabled = False
            valu_goodi_10.Enabled = False
            valu_goodi_10.Value = 253
        ElseIf Check_NA_goodi_10.Checked = False Then
            Check_available_goodi_10.Enabled = True
            valu_goodi_10.Enabled = True
            valu_goodi_10.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_11_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_11.CheckedChanged
        If Check_available_goodi_11.Checked = True Then
            Check_NA_goodi_11.Enabled = False
            valu_goodi_11.Enabled = False
            valu_goodi_11.Value = 254
        ElseIf Check_available_goodi_11.Checked = False Then
            Check_NA_goodi_11.Enabled = True
            valu_goodi_11.Enabled = True
            valu_goodi_11.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_11_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_11.CheckedChanged
        If Check_NA_goodi_11.Checked = True Then
            Check_available_goodi_11.Enabled = False
            valu_goodi_11.Enabled = False
            valu_goodi_11.Value = 253
        ElseIf Check_NA_goodi_11.Checked = False Then
            Check_available_goodi_11.Enabled = True
            valu_goodi_11.Enabled = True
            valu_goodi_11.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_12_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_12.CheckedChanged
        If Check_available_goodi_12.Checked = True Then
            Check_NA_goodi_12.Enabled = False
            valu_goodi_12.Enabled = False
            valu_goodi_12.Value = 254
        ElseIf Check_available_goodi_12.Checked = False Then
            Check_NA_goodi_12.Enabled = True
            valu_goodi_12.Enabled = True
            valu_goodi_12.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_12_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_12.CheckedChanged
        If Check_NA_goodi_12.Checked = True Then
            Check_available_goodi_12.Enabled = False
            valu_goodi_12.Enabled = False
            valu_goodi_12.Value = 253
        ElseIf Check_NA_goodi_12.Checked = False Then
            Check_available_goodi_12.Enabled = True
            valu_goodi_12.Enabled = True
            valu_goodi_12.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_13_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_13.CheckedChanged
        If Check_available_goodi_13.Checked = True Then
            Check_NA_goodi_13.Enabled = False
            valu_goodi_13.Enabled = False
            valu_goodi_13.Value = 254
        ElseIf Check_available_goodi_13.Checked = False Then
            Check_NA_goodi_13.Enabled = True
            valu_goodi_13.Enabled = True
            valu_goodi_13.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_13_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_13.CheckedChanged
        If Check_NA_goodi_13.Checked = True Then
            Check_available_goodi_13.Enabled = False
            valu_goodi_13.Enabled = False
            valu_goodi_13.Value = 253
        ElseIf Check_NA_goodi_13.Checked = False Then
            Check_available_goodi_13.Enabled = True
            valu_goodi_13.Enabled = True
            valu_goodi_13.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_14_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_14.CheckedChanged
        If Check_available_goodi_14.Checked = True Then
            Check_NA_goodi_14.Enabled = False
            valu_goodi_14.Enabled = False
            valu_goodi_14.Value = 254
        ElseIf Check_available_goodi_14.Checked = False Then
            Check_NA_goodi_14.Enabled = True
            valu_goodi_14.Enabled = True
            valu_goodi_14.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_14_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_14.CheckedChanged
        If Check_NA_goodi_14.Checked = True Then
            Check_available_goodi_14.Enabled = False
            valu_goodi_14.Enabled = False
            valu_goodi_14.Value = 253
        ElseIf Check_NA_goodi_14.Checked = False Then
            Check_available_goodi_14.Enabled = True
            valu_goodi_14.Enabled = True
            valu_goodi_14.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_15_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_15.CheckedChanged
        If Check_available_goodi_15.Checked = True Then
            Check_NA_goodi_15.Enabled = False
            valu_goodi_15.Enabled = False
            valu_goodi_15.Value = 254
        ElseIf Check_available_goodi_15.Checked = False Then
            Check_NA_goodi_15.Enabled = True
            valu_goodi_15.Enabled = True
            valu_goodi_15.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_15_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_15.CheckedChanged
        If Check_NA_goodi_15.Checked = True Then
            Check_available_goodi_15.Enabled = False
            valu_goodi_15.Enabled = False
            valu_goodi_15.Value = 253
        ElseIf Check_NA_goodi_15.Checked = False Then
            Check_available_goodi_15.Enabled = True
            valu_goodi_15.Enabled = True
            valu_goodi_15.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_16_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_16.CheckedChanged
        If Check_available_goodi_16.Checked = True Then
            Check_NA_goodi_16.Enabled = False
            valu_goodi_16.Enabled = False
            valu_goodi_16.Value = 254
        ElseIf Check_available_goodi_16.Checked = False Then
            Check_NA_goodi_16.Enabled = True
            valu_goodi_16.Enabled = True
            valu_goodi_16.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_16_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_16.CheckedChanged
        If Check_NA_goodi_16.Checked = True Then
            Check_available_goodi_16.Enabled = False
            valu_goodi_16.Enabled = False
            valu_goodi_16.Value = 253
        ElseIf Check_NA_goodi_16.Checked = False Then
            Check_available_goodi_16.Enabled = True
            valu_goodi_16.Enabled = True
            valu_goodi_16.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_17_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_17.CheckedChanged
        If Check_available_goodi_17.Checked = True Then
            Check_NA_goodi_17.Enabled = False
            valu_goodi_17.Enabled = False
            valu_goodi_17.Value = 254
        ElseIf Check_available_goodi_17.Checked = False Then
            Check_NA_goodi_17.Enabled = True
            valu_goodi_17.Enabled = True
            valu_goodi_17.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_17_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_17.CheckedChanged
        If Check_NA_goodi_17.Checked = True Then
            Check_available_goodi_17.Enabled = False
            valu_goodi_17.Enabled = False
            valu_goodi_17.Value = 253
        ElseIf Check_NA_goodi_17.Checked = False Then
            Check_available_goodi_17.Enabled = True
            valu_goodi_17.Enabled = True
            valu_goodi_17.Value = 0
        End If
    End Sub

    Private Sub Check_available_goodi_18_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_18.CheckedChanged
        If Check_available_goodi_18.Checked = True Then
            Check_NA_goodi_18.Enabled = False
            valu_goodi_18.Enabled = False
            valu_goodi_18.Value = 254
        ElseIf Check_available_goodi_18.Checked = False Then
            Check_NA_goodi_18.Enabled = True
            valu_goodi_18.Enabled = True
            valu_goodi_18.Value = 0
        End If
    End Sub

    Private Sub Check_NA_goodi_18_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_18.CheckedChanged
        If Check_NA_goodi_18.Checked = True Then
            Check_available_goodi_18.Enabled = False
            valu_goodi_18.Enabled = False
            valu_goodi_18.Value = 253
        ElseIf Check_NA_goodi_18.Checked = False Then
            Check_available_goodi_18.Enabled = True
            valu_goodi_18.Enabled = True
            valu_goodi_18.Value = 0
        End If
    End Sub
End Class