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
    Dim Specialfoods As String
    Dim Specialfoods_1 As String
    Dim Specialfoods_2 As String
    Dim Specialfoods_3 As String
    Dim Specialfoods_4 As String
    Dim Specialfoods_5 As String
    Dim Specialfoods_6 As String
    Dim Specialfoods_7 As String
    Dim Specialfoods_8 As String
    Dim Specialfoods_9 As String
    Dim Specialfoods_10 As String
    Dim Specialfoods_11 As String
    Dim Specialfoods_12 As String
    Dim Specialfoods_13 As String
    Dim Specialfoods_14 As String
    Dim Specialfoods_15 As String
    Dim Specialfoods_16 As String
    Dim Specialfoods_17 As String
    Dim Specialfoods_18 As String
    Dim Specialfoods_19 As String
    Dim Specialfoods_20 As String
    Dim Specialfoods_21 As String
    Dim Specialfoods_22 As String
    Dim Specialfoods_23 As String
    Dim Specialfoods_24 As String
    Dim Specialfoods_25 As String
    Dim Specialfoods_26 As String
    Dim Specialfoods_27 As String
    Dim Specialfoods_28 As String
    Dim Specialfoods_29 As String
    Dim Specialfoods_30 As String
    Dim Specialfoods_31 As String
    Dim Specialfoods_32 As String
    Dim Specialfoods_33 As String
    Dim Specialfoods_34 As String
    Dim Specialfoods_35 As String
    Dim Specialfoods_36 As String
    Dim Specialfoods_37 As String
    Dim Specialfoods_38 As String
    Dim Specialfoods_39 As String
    Dim Specialfoods_40 As String
    Dim Specialfoods_41 As String
    Dim Specialfoods_42 As String
    Dim Specialfoods_43 As String
    Dim Specialfoods_44 As String
    Dim Specialfoods_45 As String
    Dim Specialfoods_46 As String
    Dim Specialfoods_47 As String
    Dim Specialfoods_48 As String

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

    Public Sub readspecialfoods()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = Goodsitems
            Specialfoods_1 = Reader.Position
            valu_sfoods_1.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 2
            Specialfoods_2 = Reader.Position
            valu_sfoods_2.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 3
            Specialfoods_3 = Reader.Position
            valu_sfoods_3.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 4
            Specialfoods_4 = Reader.Position
            valu_sfoods_4.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 5
            Specialfoods_5 = Reader.Position
            valu_sfoods_5.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 6
            Specialfoods_6 = Reader.Position
            valu_sfoods_6.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 7
            Specialfoods_7 = Reader.Position
            valu_sfoods_7.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 8
            Specialfoods_8 = Reader.Position
            valu_sfoods_8.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 9
            Specialfoods_9 = Reader.Position
            valu_sfoods_9.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 10
            Specialfoods_10 = Reader.Position
            valu_sfoods_10.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 11
            Specialfoods_11 = Reader.Position
            valu_sfoods_11.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 12
            Specialfoods_12 = Reader.Position
            valu_sfoods_12.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 13
            Specialfoods_13 = Reader.Position
            valu_sfoods_13.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 14
            Specialfoods_14 = Reader.Position
            valu_sfoods_14.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 15
            Specialfoods_15 = Reader.Position
            valu_sfoods_15.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 16
            Specialfoods_16 = Reader.Position
            valu_sfoods_16.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 17
            Specialfoods_17 = Reader.Position
            valu_sfoods_17.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 18
            Specialfoods_18 = Reader.Position
            valu_sfoods_18.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 19
            Specialfoods_19 = Reader.Position
            valu_sfoods_19.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 20
            Specialfoods_20 = Reader.Position
            valu_sfoods_20.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 21
            Specialfoods_21 = Reader.Position
            valu_sfoods_21.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 22
            Specialfoods_22 = Reader.Position
            valu_sfoods_22.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 23
            Specialfoods_23 = Reader.Position
            valu_sfoods_23.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 24
            Specialfoods_24 = Reader.Position
            valu_sfoods_24.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 25
            Specialfoods_25 = Reader.Position
            valu_sfoods_25.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 26
            Specialfoods_26 = Reader.Position
            valu_sfoods_26.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 27
            Specialfoods_27 = Reader.Position
            valu_sfoods_27.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 28
            Specialfoods_28 = Reader.Position
            valu_sfoods_28.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 29
            Specialfoods_29 = Reader.Position
            valu_sfoods_29.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 30
            Specialfoods_30 = Reader.Position
            valu_sfoods_30.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 31
            Specialfoods_31 = Reader.Position
            valu_sfoods_31.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 32
            Specialfoods_32 = Reader.Position
            valu_sfoods_32.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 33
            Specialfoods_33 = Reader.Position
            valu_sfoods_33.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 34
            Specialfoods_34 = Reader.Position
            valu_sfoods_34.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 35
            Specialfoods_35 = Reader.Position
            valu_sfoods_35.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 36
            Specialfoods_36 = Reader.Position
            valu_sfoods_36.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 37
            Specialfoods_37 = Reader.Position
            valu_sfoods_37.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 38
            Specialfoods_38 = Reader.Position
            valu_sfoods_38.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 39
            Specialfoods_39 = Reader.Position
            valu_sfoods_39.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 40
            Specialfoods_40 = Reader.Position
            valu_sfoods_40.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 41
            Specialfoods_41 = Reader.Position
            valu_sfoods_41.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 42
            Specialfoods_42 = Reader.Position
            valu_sfoods_42.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 43
            Specialfoods_43 = Reader.Position
            valu_sfoods_43.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 44
            Specialfoods_44 = Reader.Position
            valu_sfoods_44.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 45
            Specialfoods_45 = Reader.Position
            valu_sfoods_45.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 46
            Specialfoods_46 = Reader.Position
            valu_sfoods_46.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 47
            Specialfoods_47 = Reader.Position
            valu_sfoods_47.Value = Reader.ReadByte
            Reader.Position = Goodsitems + 48
            Specialfoods_48 = Reader.Position
            valu_sfoods_48.Value = Reader.ReadByte
        Catch ex As Exception
        End Try
    End Sub

    Public Sub writespecialfoods()
        Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        fs.Position = Specialfoods_1
        fs.WriteByte(valu_sfoods_1.Value)
        fs.Position = Specialfoods_2
        fs.WriteByte(valu_sfoods_2.Value)
        fs.Position = Specialfoods_3
        fs.WriteByte(valu_sfoods_3.Value)
        fs.Position = Specialfoods_4
        fs.WriteByte(valu_sfoods_4.Value)
        fs.Position = Specialfoods_5
        fs.WriteByte(valu_sfoods_5.Value)
        fs.Position = Specialfoods_6
        fs.WriteByte(valu_sfoods_6.Value)
        fs.Position = Specialfoods_7
        fs.WriteByte(valu_sfoods_7.Value)
        fs.Position = Specialfoods_8
        fs.WriteByte(valu_sfoods_8.Value)
        fs.Position = Specialfoods_9
        fs.WriteByte(valu_sfoods_9.Value)
        fs.Position = Specialfoods_10
        fs.WriteByte(valu_sfoods_10.Value)
        fs.Position = Specialfoods_11
        fs.WriteByte(valu_sfoods_11.Value)
        fs.Position = Specialfoods_12
        fs.WriteByte(valu_sfoods_12.Value)
        fs.Position = Specialfoods_13
        fs.WriteByte(valu_sfoods_13.Value)
        fs.Position = Specialfoods_14
        fs.WriteByte(valu_sfoods_14.Value)
        fs.Position = Specialfoods_15
        fs.WriteByte(valu_sfoods_15.Value)
        fs.Position = Specialfoods_16
        fs.WriteByte(valu_sfoods_16.Value)
        fs.Position = Specialfoods_17
        fs.WriteByte(valu_sfoods_17.Value)
        fs.Position = Specialfoods_18
        fs.WriteByte(valu_sfoods_18.Value)
        fs.Position = Specialfoods_19
        fs.WriteByte(valu_sfoods_19.Value)
        fs.Position = Specialfoods_20
        fs.WriteByte(valu_sfoods_20.Value)
        fs.Position = Specialfoods_21
        fs.WriteByte(valu_sfoods_21.Value)
        fs.Position = Specialfoods_22
        fs.WriteByte(valu_sfoods_22.Value)
        fs.Position = Specialfoods_23
        fs.WriteByte(valu_sfoods_23.Value)
        fs.Position = Specialfoods_24
        fs.WriteByte(valu_sfoods_24.Value)
        fs.Position = Specialfoods_25
        fs.WriteByte(valu_sfoods_25.Value)
        fs.Position = Specialfoods_26
        fs.WriteByte(valu_sfoods_26.Value)
        fs.Position = Specialfoods_27
        fs.WriteByte(valu_sfoods_27.Value)
        fs.Position = Specialfoods_28
        fs.WriteByte(valu_sfoods_28.Value)
        fs.Position = Specialfoods_29
        fs.WriteByte(valu_sfoods_29.Value)
        fs.Position = Specialfoods_30
        fs.WriteByte(valu_sfoods_30.Value)
        fs.Position = Specialfoods_31
        fs.WriteByte(valu_sfoods_31.Value)
        fs.Position = Specialfoods_32
        fs.WriteByte(valu_sfoods_32.Value)
        fs.Position = Specialfoods_33
        fs.WriteByte(valu_sfoods_33.Value)
        fs.Position = Specialfoods_34
        fs.WriteByte(valu_sfoods_34.Value)
        fs.Position = Specialfoods_35
        fs.WriteByte(valu_sfoods_35.Value)
        fs.Position = Specialfoods_36
        fs.WriteByte(valu_sfoods_36.Value)
        fs.Position = Specialfoods_37
        fs.WriteByte(valu_sfoods_37.Value)
        fs.Position = Specialfoods_38
        fs.WriteByte(valu_sfoods_38.Value)
        fs.Position = Specialfoods_39
        fs.WriteByte(valu_sfoods_39.Value)
        fs.Position = Specialfoods_40
        fs.WriteByte(valu_sfoods_40.Value)
        fs.Position = Specialfoods_41
        fs.WriteByte(valu_sfoods_41.Value)
        fs.Position = Specialfoods_42
        fs.WriteByte(valu_sfoods_42.Value)
        fs.Position = Specialfoods_43
        fs.WriteByte(valu_sfoods_43.Value)
        fs.Position = Specialfoods_44
        fs.WriteByte(valu_sfoods_44.Value)
        fs.Position = Specialfoods_45
        fs.WriteByte(valu_sfoods_45.Value)
        fs.Position = Specialfoods_46
        fs.WriteByte(valu_sfoods_46.Value)
        fs.Position = Specialfoods_47
        fs.WriteByte(valu_sfoods_47.Value)
        fs.Position = Specialfoods_48
        fs.WriteByte(valu_sfoods_48.Value)
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
            Specialfoods = &H19E2
        ElseIf TL_SaveEditor.Filever_text.Text = "EU" Then
            Goodsitems = &H18F0
            Specialfoods = &H1A14
        ElseIf TL_SaveEditor.Filever_text.Text = "JP" Then
            Goodsitems = &H18F0
            Specialfoods = &H19B0
        ElseIf TL_SaveEditor.Filever_text.Text = "KR" Then
            Goodsitems = &H18F0
            Specialfoods = &H1A46
        End If
        readgoodsitems()
        readspecialfoods()
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

    Private Sub Check_available_sfoods_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_1.CheckedChanged
        If Check_available_sfoods_1.Checked = True Then
            Check_NA_sfoods_1.Enabled = False
            valu_sfoods_1.Enabled = False
            valu_sfoods_1.Value = 254
        ElseIf Check_available_sfoods_1.Checked = False Then
            Check_NA_sfoods_1.Enabled = True
            valu_sfoods_1.Enabled = True
            valu_sfoods_1.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_1.CheckedChanged
        If Check_NA_sfoods_1.Checked = True Then
            Check_available_sfoods_1.Enabled = False
            valu_sfoods_1.Enabled = False
            valu_sfoods_1.Value = 253
        ElseIf Check_NA_sfoods_1.Checked = False Then
            Check_available_sfoods_1.Enabled = True
            valu_sfoods_1.Enabled = True
            valu_sfoods_1.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_2.CheckedChanged
        If Check_available_sfoods_2.Checked = True Then
            Check_NA_sfoods_2.Enabled = False
            valu_sfoods_2.Enabled = False
            valu_sfoods_2.Value = 254
        ElseIf Check_available_sfoods_2.Checked = False Then
            Check_NA_sfoods_2.Enabled = True
            valu_sfoods_2.Enabled = True
            valu_sfoods_2.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_2.CheckedChanged
        If Check_NA_sfoods_2.Checked = True Then
            Check_available_sfoods_2.Enabled = False
            valu_sfoods_2.Enabled = False
            valu_sfoods_2.Value = 253
        ElseIf Check_NA_sfoods_2.Checked = False Then
            Check_available_sfoods_2.Enabled = True
            valu_sfoods_2.Enabled = True
            valu_sfoods_2.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_3.CheckedChanged
        If Check_available_sfoods_3.Checked = True Then
            Check_NA_sfoods_3.Enabled = False
            valu_sfoods_3.Enabled = False
            valu_sfoods_3.Value = 254
        ElseIf Check_available_sfoods_3.Checked = False Then
            Check_NA_sfoods_3.Enabled = True
            valu_sfoods_3.Enabled = True
            valu_sfoods_3.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_3.CheckedChanged
        If Check_NA_sfoods_3.Checked = True Then
            Check_available_sfoods_3.Enabled = False
            valu_sfoods_3.Enabled = False
            valu_sfoods_3.Value = 253
        ElseIf Check_NA_sfoods_3.Checked = False Then
            Check_available_sfoods_3.Enabled = True
            valu_sfoods_3.Enabled = True
            valu_sfoods_3.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_4.CheckedChanged
        If Check_available_sfoods_4.Checked = True Then
            Check_NA_sfoods_4.Enabled = False
            valu_sfoods_4.Enabled = False
            valu_sfoods_4.Value = 254
        ElseIf Check_available_sfoods_4.Checked = False Then
            Check_NA_sfoods_4.Enabled = True
            valu_sfoods_4.Enabled = True
            valu_sfoods_4.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_4.CheckedChanged
        If Check_NA_sfoods_4.Checked = True Then
            Check_available_sfoods_4.Enabled = False
            valu_sfoods_4.Enabled = False
            valu_sfoods_4.Value = 253
        ElseIf Check_NA_sfoods_4.Checked = False Then
            Check_available_sfoods_4.Enabled = True
            valu_sfoods_4.Enabled = True
            valu_sfoods_4.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_5.CheckedChanged
        If Check_available_sfoods_5.Checked = True Then
            Check_NA_sfoods_5.Enabled = False
            valu_sfoods_5.Enabled = False
            valu_sfoods_5.Value = 254
        ElseIf Check_available_sfoods_5.Checked = False Then
            Check_NA_sfoods_5.Enabled = True
            valu_sfoods_5.Enabled = True
            valu_sfoods_5.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_5.CheckedChanged
        If Check_NA_sfoods_5.Checked = True Then
            Check_available_sfoods_5.Enabled = False
            valu_sfoods_5.Enabled = False
            valu_sfoods_5.Value = 253
        ElseIf Check_NA_sfoods_5.Checked = False Then
            Check_available_sfoods_5.Enabled = True
            valu_sfoods_5.Enabled = True
            valu_sfoods_5.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_6.CheckedChanged
        If Check_available_sfoods_6.Checked = True Then
            Check_NA_sfoods_6.Enabled = False
            valu_sfoods_6.Enabled = False
            valu_sfoods_6.Value = 254
        ElseIf Check_available_sfoods_6.Checked = False Then
            Check_NA_sfoods_6.Enabled = True
            valu_sfoods_6.Enabled = True
            valu_sfoods_6.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_6.CheckedChanged
        If Check_NA_sfoods_6.Checked = True Then
            Check_available_sfoods_6.Enabled = False
            valu_sfoods_6.Enabled = False
            valu_sfoods_6.Value = 253
        ElseIf Check_NA_sfoods_6.Checked = False Then
            Check_available_sfoods_6.Enabled = True
            valu_sfoods_6.Enabled = True
            valu_sfoods_6.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_7.CheckedChanged
        If Check_available_sfoods_7.Checked = True Then
            Check_NA_sfoods_7.Enabled = False
            valu_sfoods_7.Enabled = False
            valu_sfoods_7.Value = 254
        ElseIf Check_available_sfoods_7.Checked = False Then
            Check_NA_sfoods_7.Enabled = True
            valu_sfoods_7.Enabled = True
            valu_sfoods_7.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_7.CheckedChanged
        If Check_NA_sfoods_7.Checked = True Then
            Check_available_sfoods_7.Enabled = False
            valu_sfoods_7.Enabled = False
            valu_sfoods_7.Value = 253
        ElseIf Check_NA_sfoods_7.Checked = False Then
            Check_available_sfoods_7.Enabled = True
            valu_sfoods_7.Enabled = True
            valu_sfoods_7.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_8.CheckedChanged
        If Check_available_sfoods_8.Checked = True Then
            Check_NA_sfoods_8.Enabled = False
            valu_sfoods_8.Enabled = False
            valu_sfoods_8.Value = 254
        ElseIf Check_available_sfoods_8.Checked = False Then
            Check_NA_sfoods_8.Enabled = True
            valu_sfoods_8.Enabled = True
            valu_sfoods_8.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_8.CheckedChanged
        If Check_NA_sfoods_8.Checked = True Then
            Check_available_sfoods_8.Enabled = False
            valu_sfoods_8.Enabled = False
            valu_sfoods_8.Value = 253
        ElseIf Check_NA_sfoods_8.Checked = False Then
            Check_available_sfoods_8.Enabled = True
            valu_sfoods_8.Enabled = True
            valu_sfoods_8.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_9_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_9.CheckedChanged
        If Check_available_sfoods_9.Checked = True Then
            Check_NA_sfoods_9.Enabled = False
            valu_sfoods_9.Enabled = False
            valu_sfoods_9.Value = 254
        ElseIf Check_available_sfoods_9.Checked = False Then
            Check_NA_sfoods_9.Enabled = True
            valu_sfoods_9.Enabled = True
            valu_sfoods_9.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_9_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_9.CheckedChanged
        If Check_NA_sfoods_9.Checked = True Then
            Check_available_sfoods_9.Enabled = False
            valu_sfoods_9.Enabled = False
            valu_sfoods_9.Value = 253
        ElseIf Check_NA_sfoods_9.Checked = False Then
            Check_available_sfoods_9.Enabled = True
            valu_sfoods_9.Enabled = True
            valu_sfoods_9.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_10_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_10.CheckedChanged
        If Check_available_sfoods_10.Checked = True Then
            Check_NA_sfoods_10.Enabled = False
            valu_sfoods_10.Enabled = False
            valu_sfoods_10.Value = 254
        ElseIf Check_available_sfoods_10.Checked = False Then
            Check_NA_sfoods_10.Enabled = True
            valu_sfoods_10.Enabled = True
            valu_sfoods_10.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_10_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_10.CheckedChanged
        If Check_NA_sfoods_10.Checked = True Then
            Check_available_sfoods_10.Enabled = False
            valu_sfoods_10.Enabled = False
            valu_sfoods_10.Value = 253
        ElseIf Check_NA_sfoods_10.Checked = False Then
            Check_available_sfoods_10.Enabled = True
            valu_sfoods_10.Enabled = True
            valu_sfoods_10.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_11_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_11.CheckedChanged
        If Check_available_sfoods_11.Checked = True Then
            Check_NA_sfoods_11.Enabled = False
            valu_sfoods_11.Enabled = False
            valu_sfoods_11.Value = 254
        ElseIf Check_available_sfoods_11.Checked = False Then
            Check_NA_sfoods_11.Enabled = True
            valu_sfoods_11.Enabled = True
            valu_sfoods_11.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_11_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_11.CheckedChanged
        If Check_NA_sfoods_11.Checked = True Then
            Check_available_sfoods_11.Enabled = False
            valu_sfoods_11.Enabled = False
            valu_sfoods_11.Value = 253
        ElseIf Check_NA_sfoods_11.Checked = False Then
            Check_available_sfoods_11.Enabled = True
            valu_sfoods_11.Enabled = True
            valu_sfoods_11.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_12_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_12.CheckedChanged
        If Check_available_sfoods_12.Checked = True Then
            Check_NA_sfoods_12.Enabled = False
            valu_sfoods_12.Enabled = False
            valu_sfoods_12.Value = 254
        ElseIf Check_available_sfoods_12.Checked = False Then
            Check_NA_sfoods_12.Enabled = True
            valu_sfoods_12.Enabled = True
            valu_sfoods_12.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_12_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_12.CheckedChanged
        If Check_NA_sfoods_12.Checked = True Then
            Check_available_sfoods_12.Enabled = False
            valu_sfoods_12.Enabled = False
            valu_sfoods_12.Value = 253
        ElseIf Check_NA_sfoods_12.Checked = False Then
            Check_available_sfoods_12.Enabled = True
            valu_sfoods_12.Enabled = True
            valu_sfoods_12.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_13_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_13.CheckedChanged
        If Check_available_sfoods_13.Checked = True Then
            Check_NA_sfoods_13.Enabled = False
            valu_sfoods_13.Enabled = False
            valu_sfoods_13.Value = 254
        ElseIf Check_available_sfoods_13.Checked = False Then
            Check_NA_sfoods_13.Enabled = True
            valu_sfoods_13.Enabled = True
            valu_sfoods_13.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_13_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_13.CheckedChanged
        If Check_NA_sfoods_13.Checked = True Then
            Check_available_sfoods_13.Enabled = False
            valu_sfoods_13.Enabled = False
            valu_sfoods_13.Value = 253
        ElseIf Check_NA_sfoods_13.Checked = False Then
            Check_available_sfoods_13.Enabled = True
            valu_sfoods_13.Enabled = True
            valu_sfoods_13.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_14_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_14.CheckedChanged
        If Check_available_sfoods_14.Checked = True Then
            Check_NA_sfoods_14.Enabled = False
            valu_sfoods_14.Enabled = False
            valu_sfoods_14.Value = 254
        ElseIf Check_available_sfoods_14.Checked = False Then
            Check_NA_sfoods_14.Enabled = True
            valu_sfoods_14.Enabled = True
            valu_sfoods_14.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_14_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_14.CheckedChanged
        If Check_NA_sfoods_14.Checked = True Then
            Check_available_sfoods_14.Enabled = False
            valu_sfoods_14.Enabled = False
            valu_sfoods_14.Value = 253
        ElseIf Check_NA_sfoods_14.Checked = False Then
            Check_available_sfoods_14.Enabled = True
            valu_sfoods_14.Enabled = True
            valu_sfoods_14.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_15_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_15.CheckedChanged
        If Check_available_sfoods_15.Checked = True Then
            Check_NA_sfoods_15.Enabled = False
            valu_sfoods_15.Enabled = False
            valu_sfoods_15.Value = 254
        ElseIf Check_available_sfoods_15.Checked = False Then
            Check_NA_sfoods_15.Enabled = True
            valu_sfoods_15.Enabled = True
            valu_sfoods_15.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_15_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_15.CheckedChanged
        If Check_NA_sfoods_15.Checked = True Then
            Check_available_sfoods_15.Enabled = False
            valu_sfoods_15.Enabled = False
            valu_sfoods_15.Value = 253
        ElseIf Check_NA_sfoods_15.Checked = False Then
            Check_available_sfoods_15.Enabled = True
            valu_sfoods_15.Enabled = True
            valu_sfoods_15.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_16_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_16.CheckedChanged
        If Check_available_sfoods_16.Checked = True Then
            Check_NA_sfoods_16.Enabled = False
            valu_sfoods_16.Enabled = False
            valu_sfoods_16.Value = 254
        ElseIf Check_available_sfoods_16.Checked = False Then
            Check_NA_sfoods_16.Enabled = True
            valu_sfoods_16.Enabled = True
            valu_sfoods_16.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_16_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_16.CheckedChanged
        If Check_NA_sfoods_16.Checked = True Then
            Check_available_sfoods_16.Enabled = False
            valu_sfoods_16.Enabled = False
            valu_sfoods_16.Value = 253
        ElseIf Check_NA_sfoods_16.Checked = False Then
            Check_available_sfoods_16.Enabled = True
            valu_sfoods_16.Enabled = True
            valu_sfoods_16.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_17_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_17.CheckedChanged
        If Check_available_sfoods_17.Checked = True Then
            Check_NA_sfoods_17.Enabled = False
            valu_sfoods_17.Enabled = False
            valu_sfoods_17.Value = 254
        ElseIf Check_available_sfoods_17.Checked = False Then
            Check_NA_sfoods_17.Enabled = True
            valu_sfoods_17.Enabled = True
            valu_sfoods_17.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_17_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_17.CheckedChanged
        If Check_NA_sfoods_17.Checked = True Then
            Check_available_sfoods_17.Enabled = False
            valu_sfoods_17.Enabled = False
            valu_sfoods_17.Value = 253
        ElseIf Check_NA_sfoods_17.Checked = False Then
            Check_available_sfoods_17.Enabled = True
            valu_sfoods_17.Enabled = True
            valu_sfoods_17.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_18_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_18.CheckedChanged
        If Check_available_sfoods_18.Checked = True Then
            Check_NA_sfoods_18.Enabled = False
            valu_sfoods_18.Enabled = False
            valu_sfoods_18.Value = 254
        ElseIf Check_available_sfoods_18.Checked = False Then
            Check_NA_sfoods_18.Enabled = True
            valu_sfoods_18.Enabled = True
            valu_sfoods_18.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_18_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_18.CheckedChanged
        If Check_NA_sfoods_18.Checked = True Then
            Check_available_sfoods_18.Enabled = False
            valu_sfoods_18.Enabled = False
            valu_sfoods_18.Value = 253
        ElseIf Check_NA_sfoods_18.Checked = False Then
            Check_available_sfoods_18.Enabled = True
            valu_sfoods_18.Enabled = True
            valu_sfoods_18.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_19_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_19.CheckedChanged
        If Check_available_sfoods_19.Checked = True Then
            Check_NA_sfoods_19.Enabled = False
            valu_sfoods_19.Enabled = False
            valu_sfoods_19.Value = 254
        ElseIf Check_available_sfoods_19.Checked = False Then
            Check_NA_sfoods_19.Enabled = True
            valu_sfoods_19.Enabled = True
            valu_sfoods_19.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_19_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_19.CheckedChanged
        If Check_NA_sfoods_19.Checked = True Then
            Check_available_sfoods_19.Enabled = False
            valu_sfoods_19.Enabled = False
            valu_sfoods_19.Value = 253
        ElseIf Check_NA_sfoods_19.Checked = False Then
            Check_available_sfoods_19.Enabled = True
            valu_sfoods_19.Enabled = True
            valu_sfoods_19.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_20_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_20.CheckedChanged
        If Check_available_sfoods_20.Checked = True Then
            Check_NA_sfoods_20.Enabled = False
            valu_sfoods_20.Enabled = False
            valu_sfoods_20.Value = 254
        ElseIf Check_available_sfoods_20.Checked = False Then
            Check_NA_sfoods_20.Enabled = True
            valu_sfoods_20.Enabled = True
            valu_sfoods_20.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_20_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_20.CheckedChanged
        If Check_NA_sfoods_20.Checked = True Then
            Check_available_sfoods_20.Enabled = False
            valu_sfoods_20.Enabled = False
            valu_sfoods_20.Value = 253
        ElseIf Check_NA_sfoods_20.Checked = False Then
            Check_available_sfoods_20.Enabled = True
            valu_sfoods_20.Enabled = True
            valu_sfoods_20.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_21_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_21.CheckedChanged
        If Check_available_sfoods_21.Checked = True Then
            Check_NA_sfoods_21.Enabled = False
            valu_sfoods_21.Enabled = False
            valu_sfoods_21.Value = 254
        ElseIf Check_available_sfoods_21.Checked = False Then
            Check_NA_sfoods_21.Enabled = True
            valu_sfoods_21.Enabled = True
            valu_sfoods_21.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_21_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_21.CheckedChanged
        If Check_NA_sfoods_21.Checked = True Then
            Check_available_sfoods_21.Enabled = False
            valu_sfoods_21.Enabled = False
            valu_sfoods_21.Value = 253
        ElseIf Check_NA_sfoods_21.Checked = False Then
            Check_available_sfoods_21.Enabled = True
            valu_sfoods_21.Enabled = True
            valu_sfoods_21.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_22_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_22.CheckedChanged
        If Check_available_sfoods_22.Checked = True Then
            Check_NA_sfoods_22.Enabled = False
            valu_sfoods_22.Enabled = False
            valu_sfoods_22.Value = 254
        ElseIf Check_available_sfoods_22.Checked = False Then
            Check_NA_sfoods_22.Enabled = True
            valu_sfoods_22.Enabled = True
            valu_sfoods_22.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_22_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_22.CheckedChanged
        If Check_NA_sfoods_22.Checked = True Then
            Check_available_sfoods_22.Enabled = False
            valu_sfoods_22.Enabled = False
            valu_sfoods_22.Value = 253
        ElseIf Check_NA_sfoods_22.Checked = False Then
            Check_available_sfoods_22.Enabled = True
            valu_sfoods_22.Enabled = True
            valu_sfoods_22.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_23_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_23.CheckedChanged
        If Check_available_sfoods_23.Checked = True Then
            Check_NA_sfoods_23.Enabled = False
            valu_sfoods_23.Enabled = False
            valu_sfoods_23.Value = 254
        ElseIf Check_available_sfoods_23.Checked = False Then
            Check_NA_sfoods_23.Enabled = True
            valu_sfoods_23.Enabled = True
            valu_sfoods_23.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_23_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_23.CheckedChanged
        If Check_NA_sfoods_23.Checked = True Then
            Check_available_sfoods_23.Enabled = False
            valu_sfoods_23.Enabled = False
            valu_sfoods_23.Value = 253
        ElseIf Check_NA_sfoods_23.Checked = False Then
            Check_available_sfoods_23.Enabled = True
            valu_sfoods_23.Enabled = True
            valu_sfoods_23.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_24_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_24.CheckedChanged
        If Check_available_sfoods_24.Checked = True Then
            Check_NA_sfoods_24.Enabled = False
            valu_sfoods_24.Enabled = False
            valu_sfoods_24.Value = 254
        ElseIf Check_available_sfoods_24.Checked = False Then
            Check_NA_sfoods_24.Enabled = True
            valu_sfoods_24.Enabled = True
            valu_sfoods_24.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_24_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_24.CheckedChanged
        If Check_NA_sfoods_24.Checked = True Then
            Check_available_sfoods_24.Enabled = False
            valu_sfoods_24.Enabled = False
            valu_sfoods_24.Value = 253
        ElseIf Check_NA_sfoods_24.Checked = False Then
            Check_available_sfoods_24.Enabled = True
            valu_sfoods_24.Enabled = True
            valu_sfoods_24.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_25_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_25.CheckedChanged
        If Check_available_sfoods_25.Checked = True Then
            Check_NA_sfoods_25.Enabled = False
            valu_sfoods_25.Enabled = False
            valu_sfoods_25.Value = 254
        ElseIf Check_available_sfoods_25.Checked = False Then
            Check_NA_sfoods_25.Enabled = True
            valu_sfoods_25.Enabled = True
            valu_sfoods_25.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_25_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_25.CheckedChanged
        If Check_NA_sfoods_25.Checked = True Then
            Check_available_sfoods_25.Enabled = False
            valu_sfoods_25.Enabled = False
            valu_sfoods_25.Value = 253
        ElseIf Check_NA_sfoods_25.Checked = False Then
            Check_available_sfoods_25.Enabled = True
            valu_sfoods_25.Enabled = True
            valu_sfoods_25.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_26_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_26.CheckedChanged
        If Check_available_sfoods_26.Checked = True Then
            Check_NA_sfoods_26.Enabled = False
            valu_sfoods_26.Enabled = False
            valu_sfoods_26.Value = 254
        ElseIf Check_available_sfoods_26.Checked = False Then
            Check_NA_sfoods_26.Enabled = True
            valu_sfoods_26.Enabled = True
            valu_sfoods_26.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_26_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_26.CheckedChanged
        If Check_NA_sfoods_26.Checked = True Then
            Check_available_sfoods_26.Enabled = False
            valu_sfoods_26.Enabled = False
            valu_sfoods_26.Value = 253
        ElseIf Check_NA_sfoods_26.Checked = False Then
            Check_available_sfoods_26.Enabled = True
            valu_sfoods_26.Enabled = True
            valu_sfoods_26.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_27_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_27.CheckedChanged
        If Check_available_sfoods_27.Checked = True Then
            Check_NA_sfoods_27.Enabled = False
            valu_sfoods_27.Enabled = False
            valu_sfoods_27.Value = 254
        ElseIf Check_available_sfoods_27.Checked = False Then
            Check_NA_sfoods_27.Enabled = True
            valu_sfoods_27.Enabled = True
            valu_sfoods_27.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_27_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_27.CheckedChanged
        If Check_NA_sfoods_27.Checked = True Then
            Check_available_sfoods_27.Enabled = False
            valu_sfoods_27.Enabled = False
            valu_sfoods_27.Value = 253
        ElseIf Check_NA_sfoods_27.Checked = False Then
            Check_available_sfoods_27.Enabled = True
            valu_sfoods_27.Enabled = True
            valu_sfoods_27.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_28_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_28.CheckedChanged
        If Check_available_sfoods_28.Checked = True Then
            Check_NA_sfoods_28.Enabled = False
            valu_sfoods_28.Enabled = False
            valu_sfoods_28.Value = 254
        ElseIf Check_available_sfoods_28.Checked = False Then
            Check_NA_sfoods_28.Enabled = True
            valu_sfoods_28.Enabled = True
            valu_sfoods_28.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_28_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_28.CheckedChanged
        If Check_NA_sfoods_28.Checked = True Then
            Check_available_sfoods_28.Enabled = False
            valu_sfoods_28.Enabled = False
            valu_sfoods_28.Value = 253
        ElseIf Check_NA_sfoods_28.Checked = False Then
            Check_available_sfoods_28.Enabled = True
            valu_sfoods_28.Enabled = True
            valu_sfoods_28.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_29_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_29.CheckedChanged
        If Check_available_sfoods_29.Checked = True Then
            Check_NA_sfoods_29.Enabled = False
            valu_sfoods_29.Enabled = False
            valu_sfoods_29.Value = 254
        ElseIf Check_available_sfoods_29.Checked = False Then
            Check_NA_sfoods_29.Enabled = True
            valu_sfoods_29.Enabled = True
            valu_sfoods_29.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_29_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_29.CheckedChanged
        If Check_NA_sfoods_29.Checked = True Then
            Check_available_sfoods_29.Enabled = False
            valu_sfoods_29.Enabled = False
            valu_sfoods_29.Value = 253
        ElseIf Check_NA_sfoods_29.Checked = False Then
            Check_available_sfoods_29.Enabled = True
            valu_sfoods_29.Enabled = True
            valu_sfoods_29.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_30_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_30.CheckedChanged
        If Check_available_sfoods_30.Checked = True Then
            Check_NA_sfoods_30.Enabled = False
            valu_sfoods_30.Enabled = False
            valu_sfoods_30.Value = 254
        ElseIf Check_available_sfoods_30.Checked = False Then
            Check_NA_sfoods_30.Enabled = True
            valu_sfoods_30.Enabled = True
            valu_sfoods_30.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_30_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_30.CheckedChanged
        If Check_NA_sfoods_30.Checked = True Then
            Check_available_sfoods_30.Enabled = False
            valu_sfoods_30.Enabled = False
            valu_sfoods_30.Value = 253
        ElseIf Check_NA_sfoods_30.Checked = False Then
            Check_available_sfoods_30.Enabled = True
            valu_sfoods_30.Enabled = True
            valu_sfoods_30.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_31_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_31.CheckedChanged
        If Check_available_sfoods_31.Checked = True Then
            Check_NA_sfoods_31.Enabled = False
            valu_sfoods_31.Enabled = False
            valu_sfoods_31.Value = 254
        ElseIf Check_available_sfoods_31.Checked = False Then
            Check_NA_sfoods_31.Enabled = True
            valu_sfoods_31.Enabled = True
            valu_sfoods_31.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_31_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_31.CheckedChanged
        If Check_NA_sfoods_31.Checked = True Then
            Check_available_sfoods_31.Enabled = False
            valu_sfoods_31.Enabled = False
            valu_sfoods_31.Value = 253
        ElseIf Check_NA_sfoods_31.Checked = False Then
            Check_available_sfoods_31.Enabled = True
            valu_sfoods_31.Enabled = True
            valu_sfoods_31.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_32_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_32.CheckedChanged
        If Check_available_sfoods_32.Checked = True Then
            Check_NA_sfoods_32.Enabled = False
            valu_sfoods_32.Enabled = False
            valu_sfoods_32.Value = 254
        ElseIf Check_available_sfoods_32.Checked = False Then
            Check_NA_sfoods_32.Enabled = True
            valu_sfoods_32.Enabled = True
            valu_sfoods_32.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_32_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_32.CheckedChanged
        If Check_NA_sfoods_32.Checked = True Then
            Check_available_sfoods_32.Enabled = False
            valu_sfoods_32.Enabled = False
            valu_sfoods_32.Value = 253
        ElseIf Check_NA_sfoods_32.Checked = False Then
            Check_available_sfoods_32.Enabled = True
            valu_sfoods_32.Enabled = True
            valu_sfoods_32.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_33_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_33.CheckedChanged
        If Check_available_sfoods_33.Checked = True Then
            Check_NA_sfoods_33.Enabled = False
            valu_sfoods_33.Enabled = False
            valu_sfoods_33.Value = 254
        ElseIf Check_available_sfoods_33.Checked = False Then
            Check_NA_sfoods_33.Enabled = True
            valu_sfoods_33.Enabled = True
            valu_sfoods_33.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_33_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_33.CheckedChanged
        If Check_NA_sfoods_33.Checked = True Then
            Check_available_sfoods_33.Enabled = False
            valu_sfoods_33.Enabled = False
            valu_sfoods_33.Value = 253
        ElseIf Check_NA_sfoods_33.Checked = False Then
            Check_available_sfoods_33.Enabled = True
            valu_sfoods_33.Enabled = True
            valu_sfoods_33.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_34_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_34.CheckedChanged
        If Check_available_sfoods_34.Checked = True Then
            Check_NA_sfoods_34.Enabled = False
            valu_sfoods_34.Enabled = False
            valu_sfoods_34.Value = 254
        ElseIf Check_available_sfoods_34.Checked = False Then
            Check_NA_sfoods_34.Enabled = True
            valu_sfoods_34.Enabled = True
            valu_sfoods_34.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_34_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_34.CheckedChanged
        If Check_NA_sfoods_34.Checked = True Then
            Check_available_sfoods_34.Enabled = False
            valu_sfoods_34.Enabled = False
            valu_sfoods_34.Value = 253
        ElseIf Check_NA_sfoods_34.Checked = False Then
            Check_available_sfoods_34.Enabled = True
            valu_sfoods_34.Enabled = True
            valu_sfoods_34.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_35_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_35.CheckedChanged
        If Check_available_sfoods_35.Checked = True Then
            Check_NA_sfoods_35.Enabled = False
            valu_sfoods_35.Enabled = False
            valu_sfoods_35.Value = 254
        ElseIf Check_available_sfoods_35.Checked = False Then
            Check_NA_sfoods_35.Enabled = True
            valu_sfoods_35.Enabled = True
            valu_sfoods_35.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_35_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_35.CheckedChanged
        If Check_NA_sfoods_35.Checked = True Then
            Check_available_sfoods_35.Enabled = False
            valu_sfoods_35.Enabled = False
            valu_sfoods_35.Value = 253
        ElseIf Check_NA_sfoods_35.Checked = False Then
            Check_available_sfoods_35.Enabled = True
            valu_sfoods_35.Enabled = True
            valu_sfoods_35.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_36_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_36.CheckedChanged
        If Check_available_sfoods_36.Checked = True Then
            Check_NA_sfoods_36.Enabled = False
            valu_sfoods_36.Enabled = False
            valu_sfoods_36.Value = 254
        ElseIf Check_available_sfoods_36.Checked = False Then
            Check_NA_sfoods_36.Enabled = True
            valu_sfoods_36.Enabled = True
            valu_sfoods_36.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_36_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_36.CheckedChanged
        If Check_NA_sfoods_36.Checked = True Then
            Check_available_sfoods_36.Enabled = False
            valu_sfoods_36.Enabled = False
            valu_sfoods_36.Value = 253
        ElseIf Check_NA_sfoods_36.Checked = False Then
            Check_available_sfoods_36.Enabled = True
            valu_sfoods_36.Enabled = True
            valu_sfoods_36.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_37_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_37.CheckedChanged
        If Check_available_sfoods_37.Checked = True Then
            Check_NA_sfoods_37.Enabled = False
            valu_sfoods_37.Enabled = False
            valu_sfoods_37.Value = 254
        ElseIf Check_available_sfoods_37.Checked = False Then
            Check_NA_sfoods_37.Enabled = True
            valu_sfoods_37.Enabled = True
            valu_sfoods_37.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_37_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_37.CheckedChanged
        If Check_NA_sfoods_37.Checked = True Then
            Check_available_sfoods_37.Enabled = False
            valu_sfoods_37.Enabled = False
            valu_sfoods_37.Value = 253
        ElseIf Check_NA_sfoods_37.Checked = False Then
            Check_available_sfoods_37.Enabled = True
            valu_sfoods_37.Enabled = True
            valu_sfoods_37.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_38_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_38.CheckedChanged
        If Check_available_sfoods_38.Checked = True Then
            Check_NA_sfoods_38.Enabled = False
            valu_sfoods_38.Enabled = False
            valu_sfoods_38.Value = 254
        ElseIf Check_available_sfoods_38.Checked = False Then
            Check_NA_sfoods_38.Enabled = True
            valu_sfoods_38.Enabled = True
            valu_sfoods_38.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_38_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_38.CheckedChanged
        If Check_NA_sfoods_38.Checked = True Then
            Check_available_sfoods_38.Enabled = False
            valu_sfoods_38.Enabled = False
            valu_sfoods_38.Value = 253
        ElseIf Check_NA_sfoods_38.Checked = False Then
            Check_available_sfoods_38.Enabled = True
            valu_sfoods_38.Enabled = True
            valu_sfoods_38.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_39_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_39.CheckedChanged
        If Check_available_sfoods_39.Checked = True Then
            Check_NA_sfoods_39.Enabled = False
            valu_sfoods_39.Enabled = False
            valu_sfoods_39.Value = 254
        ElseIf Check_available_sfoods_39.Checked = False Then
            Check_NA_sfoods_39.Enabled = True
            valu_sfoods_39.Enabled = True
            valu_sfoods_39.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_39_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_39.CheckedChanged
        If Check_NA_sfoods_39.Checked = True Then
            Check_available_sfoods_39.Enabled = False
            valu_sfoods_39.Enabled = False
            valu_sfoods_39.Value = 253
        ElseIf Check_NA_sfoods_39.Checked = False Then
            Check_available_sfoods_39.Enabled = True
            valu_sfoods_39.Enabled = True
            valu_sfoods_39.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_40_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_40.CheckedChanged
        If Check_available_sfoods_40.Checked = True Then
            Check_NA_sfoods_40.Enabled = False
            valu_sfoods_40.Enabled = False
            valu_sfoods_40.Value = 254
        ElseIf Check_available_sfoods_40.Checked = False Then
            Check_NA_sfoods_40.Enabled = True
            valu_sfoods_40.Enabled = True
            valu_sfoods_40.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_40_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_40.CheckedChanged
        If Check_NA_sfoods_40.Checked = True Then
            Check_available_sfoods_40.Enabled = False
            valu_sfoods_40.Enabled = False
            valu_sfoods_40.Value = 253
        ElseIf Check_NA_sfoods_40.Checked = False Then
            Check_available_sfoods_40.Enabled = True
            valu_sfoods_40.Enabled = True
            valu_sfoods_40.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_41_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_41.CheckedChanged
        If Check_available_sfoods_41.Checked = True Then
            Check_NA_sfoods_41.Enabled = False
            valu_sfoods_41.Enabled = False
            valu_sfoods_41.Value = 254
        ElseIf Check_available_sfoods_41.Checked = False Then
            Check_NA_sfoods_41.Enabled = True
            valu_sfoods_41.Enabled = True
            valu_sfoods_41.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_41_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_41.CheckedChanged
        If Check_NA_sfoods_41.Checked = True Then
            Check_available_sfoods_41.Enabled = False
            valu_sfoods_41.Enabled = False
            valu_sfoods_41.Value = 253
        ElseIf Check_NA_sfoods_41.Checked = False Then
            Check_available_sfoods_41.Enabled = True
            valu_sfoods_41.Enabled = True
            valu_sfoods_41.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_42_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_42.CheckedChanged
        If Check_available_sfoods_42.Checked = True Then
            Check_NA_sfoods_42.Enabled = False
            valu_sfoods_42.Enabled = False
            valu_sfoods_42.Value = 254
        ElseIf Check_available_sfoods_42.Checked = False Then
            Check_NA_sfoods_42.Enabled = True
            valu_sfoods_42.Enabled = True
            valu_sfoods_42.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_42_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_42.CheckedChanged
        If Check_NA_sfoods_42.Checked = True Then
            Check_available_sfoods_42.Enabled = False
            valu_sfoods_42.Enabled = False
            valu_sfoods_42.Value = 253
        ElseIf Check_NA_sfoods_42.Checked = False Then
            Check_available_sfoods_42.Enabled = True
            valu_sfoods_42.Enabled = True
            valu_sfoods_42.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_43_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_43.CheckedChanged
        If Check_available_sfoods_43.Checked = True Then
            Check_NA_sfoods_43.Enabled = False
            valu_sfoods_43.Enabled = False
            valu_sfoods_43.Value = 254
        ElseIf Check_available_sfoods_43.Checked = False Then
            Check_NA_sfoods_43.Enabled = True
            valu_sfoods_43.Enabled = True
            valu_sfoods_43.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_43_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_43.CheckedChanged
        If Check_NA_sfoods_43.Checked = True Then
            Check_available_sfoods_43.Enabled = False
            valu_sfoods_43.Enabled = False
            valu_sfoods_43.Value = 253
        ElseIf Check_NA_sfoods_43.Checked = False Then
            Check_available_sfoods_43.Enabled = True
            valu_sfoods_43.Enabled = True
            valu_sfoods_43.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_44_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_44.CheckedChanged
        If Check_available_sfoods_44.Checked = True Then
            Check_NA_sfoods_44.Enabled = False
            valu_sfoods_44.Enabled = False
            valu_sfoods_44.Value = 254
        ElseIf Check_available_sfoods_44.Checked = False Then
            Check_NA_sfoods_44.Enabled = True
            valu_sfoods_44.Enabled = True
            valu_sfoods_44.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_44_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_44.CheckedChanged
        If Check_NA_sfoods_44.Checked = True Then
            Check_available_sfoods_44.Enabled = False
            valu_sfoods_44.Enabled = False
            valu_sfoods_44.Value = 253
        ElseIf Check_NA_sfoods_44.Checked = False Then
            Check_available_sfoods_44.Enabled = True
            valu_sfoods_44.Enabled = True
            valu_sfoods_44.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_45_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_45.CheckedChanged
        If Check_available_sfoods_45.Checked = True Then
            Check_NA_sfoods_45.Enabled = False
            valu_sfoods_45.Enabled = False
            valu_sfoods_45.Value = 254
        ElseIf Check_available_sfoods_45.Checked = False Then
            Check_NA_sfoods_45.Enabled = True
            valu_sfoods_45.Enabled = True
            valu_sfoods_45.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_45_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_45.CheckedChanged
        If Check_NA_sfoods_45.Checked = True Then
            Check_available_sfoods_45.Enabled = False
            valu_sfoods_45.Enabled = False
            valu_sfoods_45.Value = 253
        ElseIf Check_NA_sfoods_45.Checked = False Then
            Check_available_sfoods_45.Enabled = True
            valu_sfoods_45.Enabled = True
            valu_sfoods_45.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_46_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_46.CheckedChanged
        If Check_available_sfoods_46.Checked = True Then
            Check_NA_sfoods_46.Enabled = False
            valu_sfoods_46.Enabled = False
            valu_sfoods_46.Value = 254
        ElseIf Check_available_sfoods_46.Checked = False Then
            Check_NA_sfoods_46.Enabled = True
            valu_sfoods_46.Enabled = True
            valu_sfoods_46.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_46_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_46.CheckedChanged
        If Check_NA_sfoods_46.Checked = True Then
            Check_available_sfoods_46.Enabled = False
            valu_sfoods_46.Enabled = False
            valu_sfoods_46.Value = 253
        ElseIf Check_NA_sfoods_46.Checked = False Then
            Check_available_sfoods_46.Enabled = True
            valu_sfoods_46.Enabled = True
            valu_sfoods_46.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_47_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_47.CheckedChanged
        If Check_available_sfoods_47.Checked = True Then
            Check_NA_sfoods_47.Enabled = False
            valu_sfoods_47.Enabled = False
            valu_sfoods_47.Value = 254
        ElseIf Check_available_sfoods_47.Checked = False Then
            Check_NA_sfoods_47.Enabled = True
            valu_sfoods_47.Enabled = True
            valu_sfoods_47.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_47_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_47.CheckedChanged
        If Check_NA_sfoods_47.Checked = True Then
            Check_available_sfoods_47.Enabled = False
            valu_sfoods_47.Enabled = False
            valu_sfoods_47.Value = 253
        ElseIf Check_NA_sfoods_47.Checked = False Then
            Check_available_sfoods_47.Enabled = True
            valu_sfoods_47.Enabled = True
            valu_sfoods_47.Value = 0
        End If
    End Sub

    Private Sub Check_available_sfoods_48_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sfoods_48.CheckedChanged
        If Check_available_sfoods_48.Checked = True Then
            Check_NA_sfoods_48.Enabled = False
            valu_sfoods_48.Enabled = False
            valu_sfoods_48.Value = 254
        ElseIf Check_available_sfoods_48.Checked = False Then
            Check_NA_sfoods_48.Enabled = True
            valu_sfoods_48.Enabled = True
            valu_sfoods_48.Value = 0
        End If
    End Sub

    Private Sub Check_NA_sfoods_48_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_sfoods_48.CheckedChanged
        If Check_NA_sfoods_48.Checked = True Then
            Check_available_sfoods_48.Enabled = False
            valu_sfoods_48.Enabled = False
            valu_sfoods_48.Value = 253
        ElseIf Check_NA_sfoods_48.Checked = False Then
            Check_available_sfoods_48.Enabled = True
            valu_sfoods_48.Enabled = True
            valu_sfoods_48.Value = 0
        End If
    End Sub

    Private Sub Icon_closesave_Click(sender As Object, e As EventArgs) Handles Icon_closesave.Click
        Try
            writegoodsitems()
            writespecialfoods()
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Editing of items has been successfully saved"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'édition des objets a été sauvegardé avec succès"
                fdialog.ShowDialog()
            End If
            Me.Close()
            TL_SaveEditor.Show()
        Catch ex As Exception
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "An error has occured when writing editing of items, please report this issue"
                fdialog.ShowDialog()
            End If
            If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "Une erreur est survenue lors de l'écriture de l'édition des objets, veuillez signaler cet erreur s'il vous plaît"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Info_itemsedit_MouseMove(sender As Object, e As EventArgs) Handles Info_itemsedit.MouseMove
        Panel_info_itemsedit.Visible = True
    End Sub

    Private Sub Info_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Info_itemsedit.MouseLeave
        Panel_info_itemsedit.Visible = False
    End Sub
End Class