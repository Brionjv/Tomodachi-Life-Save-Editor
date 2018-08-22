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
    Dim Interiors As String
    Dim Interiors_1 As String
    Dim Interiors_2 As String
    Dim Interiors_3 As String
    Dim Interiors_4 As String
    Dim Interiors_5 As String
    Dim Interiors_6 As String
    Dim Interiors_7 As String
    Dim Interiors_8 As String
    Dim Interiors_9 As String
    Dim Interiors_10 As String
    Dim Interiors_11 As String
    Dim Interiors_12 As String
    Dim Interiors_13 As String
    Dim Interiors_14 As String
    Dim Interiors_15 As String
    Dim Interiors_16 As String
    Dim Interiors_17 As String
    Dim Interiors_18 As String
    Dim Interiors_19 As String
    Dim Interiors_20 As String
    Dim Interiors_21 As String
    Dim Interiors_22 As String
    Dim Interiors_23 As String
    Dim Interiors_24 As String
    Dim Interiors_25 As String
    Dim Interiors_26 As String
    Dim Interiors_27 As String
    Dim Interiors_28 As String
    Dim Interiors_29 As String
    Dim Interiors_30 As String
    Dim Interiors_31 As String
    Dim Interiors_32 As String
    Dim Interiors_33 As String
    Dim Interiors_34 As String
    Dim Interiors_35 As String
    Dim Interiors_36 As String
    Dim Interiors_37 As String
    Dim Interiors_38 As String
    Dim Interiors_39 As String
    Dim Interiors_40 As String
    Dim Interiors_41 As String
    Dim Interiors_42 As String
    Dim Interiors_43 As String
    Dim Interiors_44 As String
    Dim Interiors_45 As String
    Dim Interiors_46 As String
    Dim Interiors_47 As String
    Dim Interiors_48 As String
    Dim Interiors_49 As String
    Dim Interiors_50 As String
    Dim Interiors_51 As String
    Dim Interiors_52 As String
    Dim Interiors_53 As String
    Dim Interiors_54 As String
    Dim Interiors_55 As String
    Dim Interiors_56 As String
    Dim Interiors_57 As String
    Dim Interiors_58 As String
    Dim Interiors_59 As String
    Dim Interiors_60 As String
    Dim Interiors_61 As String
    Dim Interiors_62 As String
    Dim Interiors_63 As String
    Dim Interiors_64 As String
    Dim Interiors_65 As String
    Dim Interiors_66 As String
    Dim Interiors_67 As String
    Dim Interiors_68 As String
    Dim Interiors_69 As String
    Dim Interiors_70 As String
    Dim Interiors_71 As String
    Dim Interiors_72 As String
    Dim Interiors_73 As String
    Dim Interiors_74 As String
    Dim Interiors_75 As String
    Dim Interiors_76 As String
    Dim Interiors_77 As String
    Dim Interiors_78 As String
    Dim Interiors_79 As String
    Dim Interiors_80 As String
    Dim Interiors_81 As String
    Dim Interiors_82 As String
    Dim Interiors_83 As String
    Dim Interiors_84 As String
    Dim Interiors_85 As String
    Dim Interiors_86 As String
    Dim Interiors_87 As String
    Dim Interiors_88 As String
    Dim Interiors_89 As String
    Dim Interiors_90 As String
    Dim Interiors_91 As String
    Dim Interiors_92 As String
    Dim Interiors_93 As String
    Dim Interiors_94 As String
    Dim Interiors_95 As String
    Dim Interiors_96 As String
    Dim Interiors_97 As String
    Dim Interiors_98 As String
    Dim Interiors_99 As String
    Dim Interiors_100 As String
    Dim Interiors_101 As String
    Dim Interiors_102 As String
    Dim Interiors_103 As String
    Dim Interiors_104 As String

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
        Panel_clothing.Visible = False
        Panel_foods.Visible = False
        Panel_hats.Visible = False
        Panel_treasures.Visible = False
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
            If TL_SaveEditor.Filever_text.Text = "EU" Or TL_SaveEditor.Filever_text.Text = "US" Then
                Reader.Position = Goodsitems + 17
                Goodsitems_18 = Reader.Position
                valu_goodi_18.Value = Reader.ReadByte
            End If
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
        If TL_SaveEditor.Filever_text.Text = "EU" Or TL_SaveEditor.Filever_text.Text = "US" Then
            fs.Position = Goodsitems_18
            fs.WriteByte(valu_goodi_18.Value)
        End If
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

    Public Sub readinteriors()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = Interiors
            Interiors_1 = Reader.Position
            valu_interiors_1.Value = Reader.ReadByte
            Reader.Position = Interiors + 1
            Interiors_2 = Reader.Position
            valu_interiors_2.Value = Reader.ReadByte
            Reader.Position = Interiors + 2
            Interiors_3 = Reader.Position
            valu_interiors_3.Value = Reader.ReadByte
            Reader.Position = Interiors + 3
            Interiors_4 = Reader.Position
            valu_interiors_4.Value = Reader.ReadByte
            Reader.Position = Interiors + 4
            Interiors_5 = Reader.Position
            valu_interiors_5.Value = Reader.ReadByte
            Reader.Position = Interiors + 5
            Interiors_6 = Reader.Position
            valu_interiors_6.Value = Reader.ReadByte
            Reader.Position = Interiors + 6
            Interiors_7 = Reader.Position
            valu_interiors_7.Value = Reader.ReadByte
            Reader.Position = Interiors + 7
            Interiors_8 = Reader.Position
            valu_interiors_8.Value = Reader.ReadByte
            Reader.Position = Interiors + 8
            Interiors_9 = Reader.Position
            valu_interiors_9.Value = Reader.ReadByte
            Reader.Position = Interiors + 9
            Interiors_10 = Reader.Position
            valu_interiors_10.Value = Reader.ReadByte
            Reader.Position = Interiors + 10
            Interiors_11 = Reader.Position
            valu_interiors_11.Value = Reader.ReadByte
            Reader.Position = Interiors + 11
            Interiors_12 = Reader.Position
            valu_interiors_12.Value = Reader.ReadByte
            Reader.Position = Interiors + 12
            Interiors_13 = Reader.Position
            valu_interiors_13.Value = Reader.ReadByte
            Reader.Position = Interiors + 13
            Interiors_14 = Reader.Position
            valu_interiors_14.Value = Reader.ReadByte
            Reader.Position = Interiors + 14
            Interiors_15 = Reader.Position
            valu_interiors_15.Value = Reader.ReadByte
            Reader.Position = Interiors + 15
            Interiors_16 = Reader.Position
            valu_interiors_16.Value = Reader.ReadByte
            Reader.Position = Interiors + 16
            Interiors_17 = Reader.Position
            valu_interiors_17.Value = Reader.ReadByte
            Reader.Position = Interiors + 17
            Interiors_18 = Reader.Position
            valu_interiors_18.Value = Reader.ReadByte
            Reader.Position = Interiors + 18
            Interiors_19 = Reader.Position
            valu_interiors_19.Value = Reader.ReadByte
            Reader.Position = Interiors + 19
            Interiors_20 = Reader.Position
            valu_interiors_20.Value = Reader.ReadByte
            Reader.Position = Interiors + 20
            Interiors_21 = Reader.Position
            valu_interiors_21.Value = Reader.ReadByte
            Reader.Position = Interiors + 21
            Interiors_22 = Reader.Position
            valu_interiors_22.Value = Reader.ReadByte
            Reader.Position = Interiors + 22
            Interiors_23 = Reader.Position
            valu_interiors_23.Value = Reader.ReadByte
            Reader.Position = Interiors + 23
            Interiors_24 = Reader.Position
            valu_interiors_24.Value = Reader.ReadByte
            Reader.Position = Interiors + 24
            Interiors_25 = Reader.Position
            valu_interiors_25.Value = Reader.ReadByte
            Reader.Position = Interiors + 25
            Interiors_26 = Reader.Position
            valu_interiors_26.Value = Reader.ReadByte
            Reader.Position = Interiors + 26
            Interiors_27 = Reader.Position
            valu_interiors_27.Value = Reader.ReadByte
            Reader.Position = Interiors + 27
            Interiors_28 = Reader.Position
            valu_interiors_28.Value = Reader.ReadByte
            Reader.Position = Interiors + 28
            Interiors_29 = Reader.Position
            valu_interiors_29.Value = Reader.ReadByte
            Reader.Position = Interiors + 29
            Interiors_30 = Reader.Position
            valu_interiors_30.Value = Reader.ReadByte
            Reader.Position = Interiors + 30
            Interiors_31 = Reader.Position
            valu_interiors_31.Value = Reader.ReadByte
            Reader.Position = Interiors + 31
            Interiors_32 = Reader.Position
            valu_interiors_32.Value = Reader.ReadByte
            Reader.Position = Interiors + 32
            Interiors_33 = Reader.Position
            valu_interiors_33.Value = Reader.ReadByte
            Reader.Position = Interiors + 33
            Interiors_34 = Reader.Position
            valu_interiors_34.Value = Reader.ReadByte
            Reader.Position = Interiors + 34
            Interiors_35 = Reader.Position
            valu_interiors_35.Value = Reader.ReadByte
            Reader.Position = Interiors + 35
            Interiors_36 = Reader.Position
            valu_interiors_36.Value = Reader.ReadByte
            Reader.Position = Interiors + 36
            Interiors_37 = Reader.Position
            valu_interiors_37.Value = Reader.ReadByte
            Reader.Position = Interiors + 37
            Interiors_38 = Reader.Position
            valu_interiors_38.Value = Reader.ReadByte
            Reader.Position = Interiors + 38
            Interiors_39 = Reader.Position
            valu_interiors_39.Value = Reader.ReadByte
            Reader.Position = Interiors + 39
            Interiors_40 = Reader.Position
            valu_interiors_40.Value = Reader.ReadByte
            Reader.Position = Interiors + 40
            Interiors_41 = Reader.Position
            valu_interiors_41.Value = Reader.ReadByte
            Reader.Position = Interiors + 41
            Interiors_42 = Reader.Position
            valu_interiors_42.Value = Reader.ReadByte
            Reader.Position = Interiors + 42
            Interiors_43 = Reader.Position
            valu_interiors_43.Value = Reader.ReadByte
            Reader.Position = Interiors + 43
            Interiors_44 = Reader.Position
            valu_interiors_44.Value = Reader.ReadByte
            Reader.Position = Interiors + 44
            Interiors_45 = Reader.Position
            valu_interiors_45.Value = Reader.ReadByte
            Reader.Position = Interiors + 45
            Interiors_46 = Reader.Position
            valu_interiors_46.Value = Reader.ReadByte
            Reader.Position = Interiors + 46
            Interiors_47 = Reader.Position
            valu_interiors_47.Value = Reader.ReadByte
            Reader.Position = Interiors + 47
            Interiors_48 = Reader.Position
            valu_interiors_48.Value = Reader.ReadByte
            Reader.Position = Interiors + 48
            Interiors_49 = Reader.Position
            valu_interiors_49.Value = Reader.ReadByte
            Reader.Position = Interiors + 49
            Interiors_50 = Reader.Position
            valu_interiors_50.Value = Reader.ReadByte
            Reader.Position = Interiors + 50
            Interiors_51 = Reader.Position
            valu_interiors_51.Value = Reader.ReadByte
            Reader.Position = Interiors + 51
            Interiors_52 = Reader.Position
            valu_interiors_52.Value = Reader.ReadByte
            Reader.Position = Interiors + 52
            Interiors_53 = Reader.Position
            valu_interiors_53.Value = Reader.ReadByte
            Reader.Position = Interiors + 53
            Interiors_54 = Reader.Position
            valu_interiors_54.Value = Reader.ReadByte
            Reader.Position = Interiors + 54
            Interiors_55 = Reader.Position
            valu_interiors_55.Value = Reader.ReadByte
            Reader.Position = Interiors + 55
            Interiors_56 = Reader.Position
            valu_interiors_56.Value = Reader.ReadByte
            Reader.Position = Interiors + 56
            Interiors_57 = Reader.Position
            valu_interiors_57.Value = Reader.ReadByte
            Reader.Position = Interiors + 57
            Interiors_58 = Reader.Position
            valu_interiors_58.Value = Reader.ReadByte
            Reader.Position = Interiors + 58
            Interiors_59 = Reader.Position
            valu_interiors_59.Value = Reader.ReadByte
            Reader.Position = Interiors + 59
            Interiors_60 = Reader.Position
            valu_interiors_60.Value = Reader.ReadByte
            Reader.Position = Interiors + 60
            Interiors_61 = Reader.Position
            valu_interiors_61.Value = Reader.ReadByte
            Reader.Position = Interiors + 61
            Interiors_62 = Reader.Position
            valu_interiors_62.Value = Reader.ReadByte
            Reader.Position = Interiors + 62
            Interiors_63 = Reader.Position
            valu_interiors_63.Value = Reader.ReadByte
            Reader.Position = Interiors + 63
            Interiors_64 = Reader.Position
            valu_interiors_64.Value = Reader.ReadByte
            Reader.Position = Interiors + 64
            Interiors_65 = Reader.Position
            valu_interiors_65.Value = Reader.ReadByte
            Reader.Position = Interiors + 65
            Interiors_66 = Reader.Position
            valu_interiors_66.Value = Reader.ReadByte
            Reader.Position = Interiors + 66
            Interiors_67 = Reader.Position
            valu_interiors_67.Value = Reader.ReadByte
            Reader.Position = Interiors + 67
            Interiors_68 = Reader.Position
            valu_interiors_68.Value = Reader.ReadByte
            Reader.Position = Interiors + 68
            Interiors_69 = Reader.Position
            valu_interiors_69.Value = Reader.ReadByte
            Reader.Position = Interiors + 69
            Interiors_70 = Reader.Position
            valu_interiors_70.Value = Reader.ReadByte
            Reader.Position = Interiors + 70
            Interiors_71 = Reader.Position
            valu_interiors_71.Value = Reader.ReadByte
            Reader.Position = Interiors + 71
            Interiors_72 = Reader.Position
            valu_interiors_72.Value = Reader.ReadByte
            Reader.Position = Interiors + 72
            Interiors_73 = Reader.Position
            valu_interiors_73.Value = Reader.ReadByte
            Reader.Position = Interiors + 73
            Interiors_74 = Reader.Position
            valu_interiors_74.Value = Reader.ReadByte
            Reader.Position = Interiors + 74
            Interiors_75 = Reader.Position
            valu_interiors_75.Value = Reader.ReadByte
            Reader.Position = Interiors + 75
            Interiors_76 = Reader.Position
            valu_interiors_76.Value = Reader.ReadByte
            Reader.Position = Interiors + 76
            Interiors_77 = Reader.Position
            valu_interiors_77.Value = Reader.ReadByte
            Reader.Position = Interiors + 77
            Interiors_78 = Reader.Position
            valu_interiors_78.Value = Reader.ReadByte
            Reader.Position = Interiors + 78
            Interiors_79 = Reader.Position
            valu_interiors_79.Value = Reader.ReadByte
            Reader.Position = Interiors + 79
            Interiors_80 = Reader.Position
            valu_interiors_80.Value = Reader.ReadByte
            Reader.Position = Interiors + 80
            Interiors_81 = Reader.Position
            valu_interiors_81.Value = Reader.ReadByte
            Reader.Position = Interiors + 81
            Interiors_82 = Reader.Position
            valu_interiors_82.Value = Reader.ReadByte
            Reader.Position = Interiors + 82
            Interiors_83 = Reader.Position
            valu_interiors_83.Value = Reader.ReadByte
            Reader.Position = Interiors + 83
            Interiors_84 = Reader.Position
            valu_interiors_84.Value = Reader.ReadByte
            Reader.Position = Interiors + 84
            Interiors_85 = Reader.Position
            valu_interiors_85.Value = Reader.ReadByte
            Reader.Position = Interiors + 85
            Interiors_86 = Reader.Position
            valu_interiors_86.Value = Reader.ReadByte
            Reader.Position = Interiors + 86
            Interiors_87 = Reader.Position
            valu_interiors_87.Value = Reader.ReadByte
            Reader.Position = Interiors + 87
            Interiors_88 = Reader.Position
            valu_interiors_88.Value = Reader.ReadByte
            Reader.Position = Interiors + 88
            Interiors_89 = Reader.Position
            valu_interiors_89.Value = Reader.ReadByte
            Reader.Position = Interiors + 89
            Interiors_90 = Reader.Position
            valu_interiors_90.Value = Reader.ReadByte
            Reader.Position = Interiors + 90
            Interiors_91 = Reader.Position
            valu_interiors_91.Value = Reader.ReadByte
            Reader.Position = Interiors + 91
            Interiors_92 = Reader.Position
            valu_interiors_92.Value = Reader.ReadByte
            Reader.Position = Interiors + 92
            Interiors_93 = Reader.Position
            valu_interiors_93.Value = Reader.ReadByte
            Reader.Position = Interiors + 93
            Interiors_94 = Reader.Position
            valu_interiors_94.Value = Reader.ReadByte
            Reader.Position = Interiors + 94
            Interiors_95 = Reader.Position
            valu_interiors_95.Value = Reader.ReadByte
            Reader.Position = Interiors + 95
            Interiors_96 = Reader.Position
            valu_interiors_96.Value = Reader.ReadByte
            Reader.Position = Interiors + 96
            Interiors_97 = Reader.Position
            valu_interiors_97.Value = Reader.ReadByte
            Reader.Position = Interiors + 97
            Interiors_98 = Reader.Position
            valu_interiors_98.Value = Reader.ReadByte
            Reader.Position = Interiors + 98
            Interiors_99 = Reader.Position
            valu_interiors_99.Value = Reader.ReadByte
            Reader.Position = Interiors + 99
            Interiors_100 = Reader.Position
            valu_interiors_100.Value = Reader.ReadByte
            If TL_SaveEditor.Filever_text.Text = "KR" Or TL_SaveEditor.Filever_text.Text = "EU" Or TL_SaveEditor.Filever_text.Text = "US" Then
                Reader.Position = Interiors + 100
                Interiors_101 = Reader.Position
                valu_interiors_101.Value = Reader.ReadByte
            End If
            If TL_SaveEditor.Filever_text.Text = "KR" Or TL_SaveEditor.Filever_text.Text = "EU" Or TL_SaveEditor.Filever_text.Text = "US" Then
                Reader.Position = Interiors + 101
                Interiors_102 = Reader.Position
                valu_interiors_102.Value = Reader.ReadByte
            End If
            If TL_SaveEditor.Filever_text.Text = "KR" Or TL_SaveEditor.Filever_text.Text = "EU" Then
                Reader.Position = Interiors + 102
                Interiors_103 = Reader.Position
                valu_interiors_103.Value = Reader.ReadByte
            End If
            If TL_SaveEditor.Filever_text.Text = "KR" Then
                Reader.Position = Interiors + 103
                Interiors_104 = Reader.Position
                valu_interiors_104.Value = Reader.ReadByte
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub writeinteriors()
        Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        fs.Position = Interiors_1
        fs.WriteByte(valu_interiors_1.Value)
        fs.Position = Interiors_2
        fs.WriteByte(valu_interiors_2.Value)
        fs.Position = Interiors_3
        fs.WriteByte(valu_interiors_3.Value)
        fs.Position = Interiors_4
        fs.WriteByte(valu_interiors_4.Value)
        fs.Position = Interiors_5
        fs.WriteByte(valu_interiors_5.Value)
        fs.Position = Interiors_6
        fs.WriteByte(valu_interiors_6.Value)
        fs.Position = Interiors_7
        fs.WriteByte(valu_interiors_7.Value)
        fs.Position = Interiors_8
        fs.WriteByte(valu_interiors_8.Value)
        fs.Position = Interiors_9
        fs.WriteByte(valu_interiors_9.Value)
        fs.Position = Interiors_10
        fs.WriteByte(valu_interiors_10.Value)
        fs.Position = Interiors_11
        fs.WriteByte(valu_interiors_11.Value)
        fs.Position = Interiors_12
        fs.WriteByte(valu_interiors_12.Value)
        fs.Position = Interiors_13
        fs.WriteByte(valu_interiors_13.Value)
        fs.Position = Interiors_14
        fs.WriteByte(valu_interiors_14.Value)
        fs.Position = Interiors_15
        fs.WriteByte(valu_interiors_15.Value)
        fs.Position = Interiors_16
        fs.WriteByte(valu_interiors_16.Value)
        fs.Position = Interiors_17
        fs.WriteByte(valu_interiors_17.Value)
        fs.Position = Interiors_18
        fs.WriteByte(valu_interiors_18.Value)
        fs.Position = Interiors_19
        fs.WriteByte(valu_interiors_19.Value)
        fs.Position = Interiors_20
        fs.WriteByte(valu_interiors_20.Value)
        fs.Position = Interiors_21
        fs.WriteByte(valu_interiors_21.Value)
        fs.Position = Interiors_22
        fs.WriteByte(valu_interiors_22.Value)
        fs.Position = Interiors_23
        fs.WriteByte(valu_interiors_23.Value)
        fs.Position = Interiors_24
        fs.WriteByte(valu_interiors_24.Value)
        fs.Position = Interiors_25
        fs.WriteByte(valu_interiors_25.Value)
        fs.Position = Interiors_26
        fs.WriteByte(valu_interiors_26.Value)
        fs.Position = Interiors_27
        fs.WriteByte(valu_interiors_27.Value)
        fs.Position = Interiors_28
        fs.WriteByte(valu_interiors_28.Value)
        fs.Position = Interiors_29
        fs.WriteByte(valu_interiors_29.Value)
        fs.Position = Interiors_30
        fs.WriteByte(valu_interiors_30.Value)
        fs.Position = Interiors_31
        fs.WriteByte(valu_interiors_31.Value)
        fs.Position = Interiors_32
        fs.WriteByte(valu_interiors_32.Value)
        fs.Position = Interiors_33
        fs.WriteByte(valu_interiors_33.Value)
        fs.Position = Interiors_34
        fs.WriteByte(valu_interiors_34.Value)
        fs.Position = Interiors_35
        fs.WriteByte(valu_interiors_35.Value)
        fs.Position = Interiors_36
        fs.WriteByte(valu_interiors_36.Value)
        fs.Position = Interiors_37
        fs.WriteByte(valu_interiors_37.Value)
        fs.Position = Interiors_38
        fs.WriteByte(valu_interiors_38.Value)
        fs.Position = Interiors_39
        fs.WriteByte(valu_interiors_39.Value)
        fs.Position = Interiors_40
        fs.WriteByte(valu_interiors_40.Value)
        fs.Position = Interiors_41
        fs.WriteByte(valu_interiors_41.Value)
        fs.Position = Interiors_42
        fs.WriteByte(valu_interiors_42.Value)
        fs.Position = Interiors_43
        fs.WriteByte(valu_interiors_43.Value)
        fs.Position = Interiors_44
        fs.WriteByte(valu_interiors_44.Value)
        fs.Position = Interiors_45
        fs.WriteByte(valu_interiors_45.Value)
        fs.Position = Interiors_46
        fs.WriteByte(valu_interiors_46.Value)
        fs.Position = Interiors_47
        fs.WriteByte(valu_interiors_47.Value)
        fs.Position = Interiors_48
        fs.WriteByte(valu_interiors_48.Value)
        fs.Position = Interiors_49
        fs.WriteByte(valu_interiors_49.Value)
        fs.Position = Interiors_50
        fs.WriteByte(valu_interiors_50.Value)
        fs.Position = Interiors_51
        fs.WriteByte(valu_interiors_51.Value)
        fs.Position = Interiors_52
        fs.WriteByte(valu_interiors_52.Value)
        fs.Position = Interiors_53
        fs.WriteByte(valu_interiors_53.Value)
        fs.Position = Interiors_54
        fs.WriteByte(valu_interiors_54.Value)
        fs.Position = Interiors_55
        fs.WriteByte(valu_interiors_55.Value)
        fs.Position = Interiors_56
        fs.WriteByte(valu_interiors_56.Value)
        fs.Position = Interiors_57
        fs.WriteByte(valu_interiors_57.Value)
        fs.Position = Interiors_58
        fs.WriteByte(valu_interiors_58.Value)
        fs.Position = Interiors_59
        fs.WriteByte(valu_interiors_59.Value)
        fs.Position = Interiors_60
        fs.WriteByte(valu_interiors_60.Value)
        fs.Position = Interiors_61
        fs.WriteByte(valu_interiors_61.Value)
        fs.Position = Interiors_62
        fs.WriteByte(valu_interiors_62.Value)
        fs.Position = Interiors_63
        fs.WriteByte(valu_interiors_63.Value)
        fs.Position = Interiors_64
        fs.WriteByte(valu_interiors_64.Value)
        fs.Position = Interiors_65
        fs.WriteByte(valu_interiors_65.Value)
        fs.Position = Interiors_66
        fs.WriteByte(valu_interiors_66.Value)
        fs.Position = Interiors_67
        fs.WriteByte(valu_interiors_67.Value)
        fs.Position = Interiors_68
        fs.WriteByte(valu_interiors_68.Value)
        fs.Position = Interiors_69
        fs.WriteByte(valu_interiors_69.Value)
        fs.Position = Interiors_70
        fs.WriteByte(valu_interiors_70.Value)
        fs.Position = Interiors_71
        fs.WriteByte(valu_interiors_71.Value)
        fs.Position = Interiors_72
        fs.WriteByte(valu_interiors_72.Value)
        fs.Position = Interiors_73
        fs.WriteByte(valu_interiors_73.Value)
        fs.Position = Interiors_74
        fs.WriteByte(valu_interiors_74.Value)
        fs.Position = Interiors_75
        fs.WriteByte(valu_interiors_75.Value)
        fs.Position = Interiors_76
        fs.WriteByte(valu_interiors_76.Value)
        fs.Position = Interiors_77
        fs.WriteByte(valu_interiors_77.Value)
        fs.Position = Interiors_78
        fs.WriteByte(valu_interiors_78.Value)
        fs.Position = Interiors_79
        fs.WriteByte(valu_interiors_79.Value)
        fs.Position = Interiors_80
        fs.WriteByte(valu_interiors_80.Value)
        fs.Position = Interiors_81
        fs.WriteByte(valu_interiors_81.Value)
        fs.Position = Interiors_82
        fs.WriteByte(valu_interiors_82.Value)
        fs.Position = Interiors_83
        fs.WriteByte(valu_interiors_83.Value)
        fs.Position = Interiors_84
        fs.WriteByte(valu_interiors_84.Value)
        fs.Position = Interiors_85
        fs.WriteByte(valu_interiors_85.Value)
        fs.Position = Interiors_86
        fs.WriteByte(valu_interiors_86.Value)
        fs.Position = Interiors_87
        fs.WriteByte(valu_interiors_87.Value)
        fs.Position = Interiors_88
        fs.WriteByte(valu_interiors_88.Value)
        fs.Position = Interiors_89
        fs.WriteByte(valu_interiors_89.Value)
        fs.Position = Interiors_90
        fs.WriteByte(valu_interiors_90.Value)
        fs.Position = Interiors_91
        fs.WriteByte(valu_interiors_91.Value)
        fs.Position = Interiors_92
        fs.WriteByte(valu_interiors_92.Value)
        fs.Position = Interiors_93
        fs.WriteByte(valu_interiors_93.Value)
        fs.Position = Interiors_94
        fs.WriteByte(valu_interiors_94.Value)
        fs.Position = Interiors_95
        fs.WriteByte(valu_interiors_95.Value)
        fs.Position = Interiors_96
        fs.WriteByte(valu_interiors_96.Value)
        fs.Position = Interiors_97
        fs.WriteByte(valu_interiors_97.Value)
        fs.Position = Interiors_98
        fs.WriteByte(valu_interiors_98.Value)
        fs.Position = Interiors_99
        fs.WriteByte(valu_interiors_99.Value)
        If TL_SaveEditor.Filever_text.Text = "KR" Or TL_SaveEditor.Filever_text.Text = "EU" Or TL_SaveEditor.Filever_text.Text = "US" Then
            fs.Position = Interiors_100
            fs.WriteByte(valu_interiors_100.Value)
        End If
        If TL_SaveEditor.Filever_text.Text = "KR" Or TL_SaveEditor.Filever_text.Text = "EU" Or TL_SaveEditor.Filever_text.Text = "US" Then
            fs.Position = Interiors_101
            fs.WriteByte(valu_interiors_101.Value)
        End If
        If TL_SaveEditor.Filever_text.Text = "KR" Or TL_SaveEditor.Filever_text.Text = "EU" Then
            fs.Position = Interiors_102
            fs.WriteByte(valu_interiors_102.Value)
        End If
        If TL_SaveEditor.Filever_text.Text = "KR" Then
            fs.Position = Interiors_103
            fs.WriteByte(valu_interiors_103.Value)
        End If
    End Sub

    Public Sub writeunitems()
        Try
            If Check_clothingstp_bynumbers.Checked = True Or Check_clothingstp_available.Checked = True Or Check_clothingstp_notavailable.Checked = True Then
                If TL_SaveEditor.Filever_text.Text = "EU" Then
                    Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    For i As Integer = 0 To 7
                        fs.Position = &H60 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HC8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H100 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H138 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H160 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H180 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H190 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H1D8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H250 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H280 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H2B8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2F0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H328 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H60 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H460 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H478 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H490 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H500 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H518 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H5A0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H5B8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H650 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H660 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H6E0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H720 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H7A0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H7B8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H848 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H868 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8E0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8F0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H918 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H968 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H988 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9B0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9C0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA08 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA38 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 31
                        fs.Position = &HA70 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &HAF8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &HB08 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HB68 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 6
                        fs.Position = &HCA0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HD28 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HE18 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                End If
                If TL_SaveEditor.Filever_text.Text = "US" Then
                    Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    For i As Integer = 0 To 7
                        fs.Position = &H40 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H80 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    fs.Position = &HC8
                    fs.WriteByte(valu_clothing_bynumbers.Value)
                    fs.Position = &HC9
                    fs.WriteByte(valu_clothing_bynumbers.Value)
                    For i As Integer = 0 To 7
                        fs.Position = &HD0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H108 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H168 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H188 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H198 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H1E0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H258 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H288 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2C8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2D8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H308 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H480 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H498 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H4C0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H4F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H508 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H520 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H538 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H568 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H5A0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H5B8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H660 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H670 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H6F0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H730 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H7B0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H7B8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H7D0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H860 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H880 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8F0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H900 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H928 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H978 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H998 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9C0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9D0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA00 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA10 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA40 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 31
                        fs.Position = &HA78 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &HB00 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &HB10 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HB70 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &HD88 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 6
                        fs.Position = &HDA8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HDD8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                End If
                If TL_SaveEditor.Filever_text.Text = "JP" Then
                    Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    For i As Integer = 0 To 15
                        fs.Position = &H80 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HE0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H120 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H180 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H1B0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H1F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H270 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H2A0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2E8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H328 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H4C0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H4D8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H550 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H568 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H5B0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H5D0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H608 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H620 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H680 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H688 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H690 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H698 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H6D0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H6E0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H760 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H7A0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H828 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H830 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H848 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8D8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H970 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H980 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H990 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9B8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA08 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA28 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA58 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA68 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HAA0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HAB0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HAE0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 31
                        fs.Position = &HB18 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &HBA0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &HBB0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HC10 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HC78 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                End If
                If TL_SaveEditor.Filever_text.Text = "KR" Then
                    Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    For i As Integer = 0 To 7
                        fs.Position = &HC8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H100 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H160 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H180 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H190 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H1D8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H250 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H280 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2B8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2C8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H2F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H330 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H460 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H478 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H4E0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H4F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H518 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H530 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &H568 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H580 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H5C8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H5D0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H5D8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H5E0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H618 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H628 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &H6A8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H6E8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 5
                        fs.Position = &H770 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H778 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H790 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H820 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H840 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8C0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8D0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H8F8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H948 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H968 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H998 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9A8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9D8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &H9E8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HA18 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 31
                        fs.Position = &HA50 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HAC0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 4
                        fs.Position = &HAD8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 15
                        fs.Position = &HAE8 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HB48 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HB78 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HBB0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HDF0 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                    For i As Integer = 0 To 7
                        fs.Position = &HE50 + i
                        fs.WriteByte(valu_clothing_bynumbers.Value)
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Icon_normalfoods_Click(sender As Object, e As EventArgs) Handles Icon_normalfoods.Click
        hidesub()
        hidepanels()
        Icon_normalfoods_01.Visible = True
        Icon_normalfoods_02.Visible = True
        Icon_normalfoods_03.Visible = True
        Icon_normalfoods_04.Visible = True
        Panel_foods.Visible = True
    End Sub

    Private Sub Icon_clothes_Click(sender As Object, e As EventArgs) Handles Icon_clothes.Click
        hidesub()
        hidepanels()
        Icon_clothes_01.Visible = True
        Icon_clothes_02.Visible = True
        Icon_clothes_03.Visible = True
        Icon_clothes_04.Visible = True
        Icon_clothes_05.Visible = True
        Panel_clothing.Visible = True
    End Sub

    Private Sub Icon_hats_Click(sender As Object, e As EventArgs) Handles Icon_hats.Click
        hidesub()
        hidepanels()
        Icon_hats_01.Visible = True
        Icon_hats_02.Visible = True
        Icon_hats_03.Visible = True
        Panel_hats.Visible = True
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
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            Info_text_available.Text = "Check to set as available"
            Info_text_notavailable.Text = "Check to set as not available"
        ElseIf TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            Info_text_available.Text = "Cochez pour rendre disponible"
            Info_text_notavailable.Text = "Cochez pour rendre indisponible"
        End If
        If TL_SaveEditor.Filever_text.Text = "US" Then
            Goodsitems = &H18F0
            Specialfoods = &H19E2
            Interiors = &H1778
            Icon_interiors_101.Visible = True
            Icon_interiors_102.Visible = True
            Icon_interiors_103.Visible = False
            Icon_interiors_104.Visible = False
            Icon_goodi_18.Visible = True
            valu_interiors_101.Visible = True
            valu_interiors_102.Visible = True
            valu_interiors_103.Visible = False
            valu_interiors_104.Visible = False
            valu_goodi_18.Visible = True
            Check_available_interiors_101.Visible = True
            Check_available_interiors_102.Visible = True
            Check_available_interiors_103.Visible = False
            Check_available_interiors_104.Visible = False
            Check_available_goodi_18.Visible = True
            Check_NA_interiors_101.Visible = True
            Check_NA_interiors_102.Visible = True
            Check_NA_interiors_103.Visible = False
            Check_NA_interiors_104.Visible = False
            Check_NA_goodi_18.Visible = True
        ElseIf TL_SaveEditor.Filever_text.Text = "EU" Then
            Goodsitems = &H18F0
            Specialfoods = &H1A14
            Interiors = &H1778
            Icon_interiors_101.Visible = True
            Icon_interiors_102.Visible = True
            Icon_interiors_103.Visible = True
            Icon_interiors_104.Visible = False
            Icon_goodi_18.Visible = True
            valu_interiors_101.Visible = True
            valu_interiors_102.Visible = True
            valu_interiors_103.Visible = True
            valu_interiors_104.Visible = False
            valu_goodi_18.Visible = True
            Check_available_interiors_101.Visible = True
            Check_available_interiors_102.Visible = True
            Check_available_interiors_103.Visible = True
            Check_available_interiors_104.Visible = False
            Check_available_goodi_18.Visible = True
            Check_NA_interiors_101.Visible = True
            Check_NA_interiors_102.Visible = True
            Check_NA_interiors_103.Visible = True
            Check_NA_interiors_104.Visible = False
            Check_NA_goodi_18.Visible = True
        ElseIf TL_SaveEditor.Filever_text.Text = "JP" Then
            Goodsitems = &H18F0
            Specialfoods = &H19B0
            Interiors = &H1778
            Icon_interiors_101.Visible = False
            Icon_interiors_102.Visible = False
            Icon_interiors_103.Visible = False
            Icon_interiors_104.Visible = False
            Icon_goodi_18.Visible = False
            valu_interiors_101.Visible = False
            valu_interiors_102.Visible = False
            valu_interiors_103.Visible = False
            valu_interiors_104.Visible = False
            valu_goodi_18.Visible = False
            Check_available_interiors_101.Visible = False
            Check_available_interiors_102.Visible = False
            Check_available_interiors_103.Visible = False
            Check_available_interiors_104.Visible = False
            Check_available_goodi_18.Visible = False
            Check_NA_interiors_101.Visible = False
            Check_NA_interiors_102.Visible = False
            Check_NA_interiors_103.Visible = False
            Check_NA_interiors_104.Visible = False
            Check_NA_goodi_18.Visible = False
        ElseIf TL_SaveEditor.Filever_text.Text = "KR" Then
            Goodsitems = &H18F0
            Specialfoods = &H1A46
            Interiors = &H1778
            Icon_interiors_101.Visible = True
            Icon_interiors_102.Visible = True
            Icon_interiors_103.Visible = True
            Icon_interiors_104.Visible = True
            Icon_goodi_18.Visible = False
            valu_interiors_101.Visible = True
            valu_interiors_102.Visible = True
            valu_interiors_103.Visible = True
            valu_interiors_104.Visible = True
            valu_goodi_18.Visible = False
            Check_available_interiors_101.Visible = True
            Check_available_interiors_102.Visible = True
            Check_available_interiors_103.Visible = True
            Check_available_interiors_104.Visible = True
            Check_available_goodi_18.Visible = False
            Check_NA_interiors_101.Visible = True
            Check_NA_interiors_102.Visible = True
            Check_NA_interiors_103.Visible = True
            Check_NA_interiors_104.Visible = True
            Check_NA_goodi_18.Visible = False
        End If
        readgoodsitems()
        readspecialfoods()
        readinteriors()
    End Sub

    Private Sub Text_specialfoods_Click(sender As Object, e As EventArgs) Handles Text_specialfoods.Click
        hidepanels()
        Panel_specialfoods.Visible = True
    End Sub

    Private Sub Text_treasures_01_Click(sender As Object, e As EventArgs) Handles Text_treasures_01.Click
        hidepanels()
        Panel_treasures.Visible = True
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

    Private Sub Check_available_interiors_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_interiors_1.CheckedChanged
        If Check_available_interiors_1.Checked = True Then
            Check_NA_interiors_1.Enabled = False
            valu_interiors_1.Enabled = False
            valu_interiors_1.Value = 254
        ElseIf Check_available_interiors_1.Checked = False Then
            Check_NA_interiors_1.Enabled = True
            valu_interiors_1.Enabled = True
            valu_interiors_1.Value = 0
        End If
    End Sub

    Private Sub Check_NA_interiors_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_interiors_1.CheckedChanged
        If Check_NA_interiors_1.Checked = True Then
            Check_available_interiors_1.Enabled = False
            valu_interiors_1.Enabled = False
            valu_interiors_1.Value = 253
        ElseIf Check_NA_interiors_1.Checked = False Then
            Check_available_interiors_1.Enabled = True
            valu_interiors_1.Enabled = True
            valu_interiors_1.Value = 0
        End If
    End Sub

    Private Sub Icon_closesave_Click(sender As Object, e As EventArgs) Handles Icon_closesave.Click
        Try
            writegoodsitems()
            writespecialfoods()
            writeinteriors()
            writeunitems()
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

    Private Sub Check_foods_bynumbers_CheckedChanged(sender As Object, e As EventArgs) Handles Check_foods_bynumbers.CheckedChanged
        If Check_foods_bynumbers.Checked = True Then
            If valu_foods_bynumbers.Value > 99 Then
                valu_foods_bynumbers.Value = 99
            End If
            Check_foods_available.Checked = False
            Check_foods_available.Enabled = False
            Check_foods_notavailable.Checked = False
            Check_foods_notavailable.Enabled = False
        ElseIf Check_foods_bynumbers.Checked = False Then
            Check_foods_available.Enabled = True
            Check_foods_notavailable.Enabled = True
        End If
    End Sub

    Private Sub Check_foods_available_CheckedChanged(sender As Object, e As EventArgs) Handles Check_foods_available.CheckedChanged
        If Check_foods_available.Checked = True Then
            Check_foods_bynumbers.Checked = False
            Check_foods_bynumbers.Enabled = False
            Check_foods_notavailable.Checked = False
            Check_foods_notavailable.Enabled = False
        ElseIf Check_foods_available.Checked = False Then
            Check_foods_bynumbers.Enabled = True
            Check_foods_notavailable.Enabled = True
        End If
    End Sub

    Private Sub Check_foods_notavailable_CheckedChanged(sender As Object, e As EventArgs) Handles Check_foods_notavailable.CheckedChanged
        If Check_foods_notavailable.Checked = True Then
            Check_foods_bynumbers.Checked = False
            Check_foods_bynumbers.Enabled = False
            Check_foods_available.Checked = False
            Check_foods_available.Enabled = False
        ElseIf Check_foods_notavailable.Checked = False Then
            Check_foods_bynumbers.Enabled = True
            Check_foods_available.Enabled = True
        End If
    End Sub

End Class