Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_interactions
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Miidetected As String

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red_tl
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close_tl
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

    Private Sub Minimizebutton_Click(sender As Object, e As EventArgs) Handles Minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimizebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Minimizebutton.MouseMove
        Minimizebutton.Image = My.Resources.minimize_gray
    End Sub

    Private Sub Minimizebutton_MouseLeave(sender As Object, e As EventArgs) Handles Minimizebutton.MouseLeave
        Minimizebutton.Image = My.Resources.minimize
    End Sub

    'form menu
    Private Sub Icon_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu.MouseMove
        Icon_menu.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu.MouseLeave
        Icon_menu.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_Click(sender As Object, e As EventArgs) Handles Icon_menu.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        Me.Close()
    End Sub

    Private Sub TLSE_interactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Setting_Advhelp.Checked = My.Settings.Para_AdvH
            Setting_ckupdate.Checked = My.Settings.Para_chkupdate
            Setting_hidden.Checked = My.Settings.Para_hidden
            Setting_music.Checked = My.Settings.Para_music
            Setting_filepath.Checked = My.Settings.Para_path
            Setting_spesymb.Checked = My.Settings.Para_spesymb
            Select_language.SelectedItem = My.Settings.Para_language
            Select_music.SelectedItem = My.Settings.Para_selmusic
        Catch ex As Exception
        End Try
        TLSE_filepath.Text = TLSE_hub.TLSE_filepath.Text
        Filever_text.Text = TLSE_hub.Filever_text.Text
        savedataArc = TLSE_filepath.Text
        'Savefileregion()
        Readmiiname()
    End Sub

    Private Sub Icon_apartmentmii_1_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_1.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(0)
    End Sub

    Private Sub Icon_apartmentmii_2_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_2.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(1)
    End Sub

    Private Sub Icon_apartmentmii_3_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_3.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(2)
    End Sub

    Private Sub Icon_apartmentmii_4_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_4.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(3)
    End Sub

    Private Sub Icon_apartmentmii_5_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_5.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(4)
    End Sub

    Private Sub Icon_apartmentmii_6_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_6.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(5)
    End Sub

    Private Sub Icon_apartmentmii_7_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_7.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(6)
    End Sub

    Private Sub Icon_apartmentmii_8_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_8.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(7)
    End Sub

    Private Sub Icon_apartmentmii_9_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_9.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(8)
    End Sub

    Private Sub Icon_apartmentmii_10_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_10.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(9)
    End Sub

    Private Sub Icon_apartmentmii_11_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_11.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(10)
    End Sub

    Private Sub Icon_apartmentmii_12_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_12.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(11)
    End Sub

    Private Sub Icon_apartmentmii_13_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_13.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(12)
    End Sub

    Private Sub Icon_apartmentmii_14_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_14.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(13)
    End Sub

    Private Sub Icon_apartmentmii_15_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_15.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(14)
    End Sub

    Private Sub Icon_apartmentmii_16_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_16.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(15)
    End Sub

    Private Sub Icon_apartmentmii_17_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_17.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(16)
    End Sub

    Private Sub Icon_apartmentmii_18_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_18.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(17)
    End Sub

    Private Sub Icon_apartmentmii_19_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_19.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(18)
    End Sub

    Private Sub Icon_apartmentmii_20_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_20.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(19)
    End Sub

    Private Sub Icon_apartmentmii_21_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_21.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(20)
    End Sub

    Private Sub Icon_apartmentmii_22_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_22.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(21)
    End Sub

    Private Sub Icon_apartmentmii_23_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_23.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(22)
    End Sub

    Private Sub Icon_apartmentmii_24_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_24.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(23)
    End Sub

    Private Sub Icon_apartmentmii_25_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_25.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(24)
    End Sub

    Private Sub Icon_apartmentmii_26_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_26.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(25)
    End Sub

    Private Sub Icon_apartmentmii_27_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_27.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(26)
    End Sub

    Private Sub Icon_apartmentmii_28_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_28.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(27)
    End Sub

    Private Sub Icon_apartmentmii_29_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_29.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(28)
    End Sub

    Private Sub Icon_apartmentmii_30_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_30.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(29)
    End Sub

    Private Sub Icon_apartmentmii_31_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_31.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(30)
    End Sub

    Private Sub Icon_apartmentmii_32_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_32.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(31)
    End Sub

    Private Sub Icon_apartmentmii_33_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_33.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(32)
    End Sub

    Private Sub Icon_apartmentmii_34_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_34.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(33)
    End Sub

    Private Sub Icon_apartmentmii_35_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_35.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(34)
    End Sub

    Private Sub Icon_apartmentmii_36_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_36.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(35)
    End Sub

    Private Sub Icon_apartmentmii_37_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_37.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(36)
    End Sub

    Private Sub Icon_apartmentmii_38_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_38.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(37)
    End Sub

    Private Sub Icon_apartmentmii_39_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_39.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(38)
    End Sub

    Private Sub Icon_apartmentmii_40_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_40.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(39)
    End Sub

    Private Sub Icon_apartmentmii_41_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_41.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(40)
    End Sub

    Private Sub Icon_apartmentmii_42_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_42.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(41)
    End Sub

    Private Sub Icon_apartmentmii_43_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_43.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(42)
    End Sub

    Private Sub Icon_apartmentmii_44_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_44.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(43)
    End Sub

    Private Sub Icon_apartmentmii_45_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_45.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(44)
    End Sub

    Private Sub Icon_apartmentmii_46_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_46.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(45)
    End Sub

    Private Sub Icon_apartmentmii_47_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_47.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(46)
    End Sub

    Private Sub Icon_apartmentmii_48_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_48.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(47)
    End Sub

    Private Sub Icon_apartmentmii_49_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_49.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(48)
    End Sub

    Private Sub Icon_apartmentmii_50_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_50.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(49)
    End Sub

    Private Sub Icon_apartmentmii_51_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_51.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(50)
    End Sub

    Private Sub Icon_apartmentmii_52_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_52.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(51)
    End Sub

    Private Sub Icon_apartmentmii_53_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_53.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(52)
    End Sub

    Private Sub Icon_apartmentmii_54_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_54.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(53)
    End Sub

    Private Sub Icon_apartmentmii_55_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_55.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(54)
    End Sub

    Private Sub Icon_apartmentmii_56_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_56.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(55)
    End Sub

    Private Sub Icon_apartmentmii_57_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_57.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(56)
    End Sub

    Private Sub Icon_apartmentmii_58_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_58.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(57)
    End Sub

    Private Sub Icon_apartmentmii_59_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_59.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(58)
    End Sub

    Private Sub Icon_apartmentmii_60_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_60.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(59)
    End Sub

    Private Sub Icon_apartmentmii_61_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_61.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(60)
    End Sub

    Private Sub Icon_apartmentmii_62_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_62.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(61)
    End Sub

    Private Sub Icon_apartmentmii_63_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_63.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(62)
    End Sub

    Private Sub Icon_apartmentmii_64_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_64.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(63)
    End Sub

    Private Sub Icon_apartmentmii_65_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_65.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(64)
    End Sub

    Private Sub Icon_apartmentmii_66_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_66.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(65)
    End Sub

    Private Sub Icon_apartmentmii_67_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_67.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(66)
    End Sub

    Private Sub Icon_apartmentmii_68_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_68.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(67)
    End Sub

    Private Sub Icon_apartmentmii_69_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_69.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(68)
    End Sub

    Private Sub Icon_apartmentmii_70_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_70.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(69)
    End Sub

    Private Sub Icon_apartmentmii_71_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_71.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(70)
    End Sub

    Private Sub Icon_apartmentmii_72_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_72.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(71)
    End Sub

    Private Sub Icon_apartmentmii_73_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_73.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(72)
    End Sub

    Private Sub Icon_apartmentmii_74_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_74.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(73)
    End Sub

    Private Sub Icon_apartmentmii_75_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_75.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(74)
    End Sub

    Private Sub Icon_apartmentmii_76_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_76.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(75)
    End Sub

    Private Sub Icon_apartmentmii_77_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_77.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(76)
    End Sub

    Private Sub Icon_apartmentmii_78_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_78.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(77)
    End Sub

    Private Sub Icon_apartmentmii_79_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_79.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(78)
    End Sub

    Private Sub Icon_apartmentmii_80_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_80.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(79)
    End Sub

    Private Sub Icon_apartmentmii_81_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_81.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(80)
    End Sub

    Private Sub Icon_apartmentmii_82_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_82.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(81)
    End Sub

    Private Sub Icon_apartmentmii_83_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_83.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(82)
    End Sub

    Private Sub Icon_apartmentmii_84_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_84.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(83)
    End Sub

    Private Sub Icon_apartmentmii_85_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_85.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(84)
    End Sub

    Private Sub Icon_apartmentmii_86_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_86.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(85)
    End Sub

    Private Sub Icon_apartmentmii_87_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_87.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(86)
    End Sub

    Private Sub Icon_apartmentmii_88_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_88.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(87)
    End Sub

    Private Sub Icon_apartmentmii_89_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_89.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(88)
    End Sub

    Private Sub Icon_apartmentmii_90_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_90.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(89)
    End Sub

    Private Sub Icon_apartmentmii_91_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_91.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(90)
    End Sub

    Private Sub Icon_apartmentmii_92_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_92.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(91)
    End Sub

    Private Sub Icon_apartmentmii_93_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_93.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(92)
    End Sub

    Private Sub Icon_apartmentmii_94_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_94.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(93)
    End Sub

    Private Sub Icon_apartmentmii_95_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_95.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(94)
    End Sub

    Private Sub Icon_apartmentmii_96_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_96.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(95)
    End Sub

    Private Sub Icon_apartmentmii_97_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_97.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(96)
    End Sub

    Private Sub Icon_apartmentmii_98_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_98.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(97)
    End Sub

    Private Sub Icon_apartmentmii_99_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_99.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(98)
    End Sub

    Private Sub Icon_apartmentmii_100_Click(sender As Object, e As EventArgs) Handles Icon_apartmentmii_100.Click
        Select_mii.SelectedItem = Select_mii.Items.Item(99)
    End Sub

    Private Sub valu_apartmentmii_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_1.ValueChanged
        Select Case valu_apartmentmii_1.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_1.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_1.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_1.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_1.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_1.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_1.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_1.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_1.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_1.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_1.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_2.ValueChanged
        Select Case valu_apartmentmii_2.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_2.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_2.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_2.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_2.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_2.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_2.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_2.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_2.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_2.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_2.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_3.ValueChanged
        Select Case valu_apartmentmii_3.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_3.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_3.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_3.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_3.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_3.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_3.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_3.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_3.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_3.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_3.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_4.ValueChanged
        Select Case valu_apartmentmii_4.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_4.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_4.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_4.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_4.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_4.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_4.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_4.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_4.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_4.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_4.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_5.ValueChanged
        Select Case valu_apartmentmii_5.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_5.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_5.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_5.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_5.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_5.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_5.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_5.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_5.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_5.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_5.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_6.ValueChanged
        Select Case valu_apartmentmii_6.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_6.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_6.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_6.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_6.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_6.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_6.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_6.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_6.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_6.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_6.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_7.ValueChanged
        Select Case valu_apartmentmii_7.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_7.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_7.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_7.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_7.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_7.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_7.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_7.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_7.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_7.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_7.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_8.ValueChanged
        Select Case valu_apartmentmii_8.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_8.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_8.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_8.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_8.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_8.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_8.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_8.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_8.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_8.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_8.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_9.ValueChanged
        Select Case valu_apartmentmii_9.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_9.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_9.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_9.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_9.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_9.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_9.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_9.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_9.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_9.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_9.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_10.ValueChanged
        Select Case valu_apartmentmii_10.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_10.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_10.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_10.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_10.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_10.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_10.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_10.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_10.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_10.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_10.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_11.ValueChanged
        Select Case valu_apartmentmii_11.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_11.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_11.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_11.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_11.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_11.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_11.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_11.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_11.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_11.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_11.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_12.ValueChanged
        Select Case valu_apartmentmii_12.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_12.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_12.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_12.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_12.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_12.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_12.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_12.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_12.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_12.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_12.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_13.ValueChanged
        Select Case valu_apartmentmii_13.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_13.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_13.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_13.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_13.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_13.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_13.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_13.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_13.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_13.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_13.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_14.ValueChanged
        Select Case valu_apartmentmii_14.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_14.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_14.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_14.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_14.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_14.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_14.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_14.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_14.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_14.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_14.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_15.ValueChanged
        Select Case valu_apartmentmii_15.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_15.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_15.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_15.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_15.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_15.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_15.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_15.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_15.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_15.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_15.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_16.ValueChanged
        Select Case valu_apartmentmii_16.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_16.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_16.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_16.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_16.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_16.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_16.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_16.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_16.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_16.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_16.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_17.ValueChanged
        Select Case valu_apartmentmii_17.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_17.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_17.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_17.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_17.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_17.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_17.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_17.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_17.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_17.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_17.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_18.ValueChanged
        Select Case valu_apartmentmii_18.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_18.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_18.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_18.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_18.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_18.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_18.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_18.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_18.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_18.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_18.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_19.ValueChanged
        Select Case valu_apartmentmii_19.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_19.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_19.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_19.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_19.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_19.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_19.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_19.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_19.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_19.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_19.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_20.ValueChanged
        Select Case valu_apartmentmii_20.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_20.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_20.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_20.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_20.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_20.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_20.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_20.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_20.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_20.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_20.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_21.ValueChanged
        Select Case valu_apartmentmii_21.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_21.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_21.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_21.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_21.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_21.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_21.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_21.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_21.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_21.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_21.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_22.ValueChanged
        Select Case valu_apartmentmii_22.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_22.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_22.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_22.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_22.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_22.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_22.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_22.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_22.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_22.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_22.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_23_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_23.ValueChanged
        Select Case valu_apartmentmii_23.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_23.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_23.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_23.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_23.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_23.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_23.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_23.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_23.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_23.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_23.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_24_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_24.ValueChanged
        Select Case valu_apartmentmii_24.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_24.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_24.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_24.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_24.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_24.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_24.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_24.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_24.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_24.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_24.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_25_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_25.ValueChanged
        Select Case valu_apartmentmii_25.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_25.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_25.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_25.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_25.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_25.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_25.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_25.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_25.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_25.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_25.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_26_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_26.ValueChanged
        Select Case valu_apartmentmii_26.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_26.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_26.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_26.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_26.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_26.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_26.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_26.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_26.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_26.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_26.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_27_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_27.ValueChanged
        Select Case valu_apartmentmii_27.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_27.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_27.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_27.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_27.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_27.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_27.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_27.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_27.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_27.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_27.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_28_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_28.ValueChanged
        Select Case valu_apartmentmii_28.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_28.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_28.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_28.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_28.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_28.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_28.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_28.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_28.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_28.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_28.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_29_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_29.ValueChanged
        Select Case valu_apartmentmii_29.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_29.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_29.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_29.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_29.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_29.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_29.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_29.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_29.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_29.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_29.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_30_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_30.ValueChanged
        Select Case valu_apartmentmii_30.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_30.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_30.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_30.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_30.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_30.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_30.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_30.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_30.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_30.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_30.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_31_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_31.ValueChanged
        Select Case valu_apartmentmii_31.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_31.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_31.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_31.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_31.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_31.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_31.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_31.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_31.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_31.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_31.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_32_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_32.ValueChanged
        Select Case valu_apartmentmii_32.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_32.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_32.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_32.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_32.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_32.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_32.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_32.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_32.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_32.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_32.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_33_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_33.ValueChanged
        Select Case valu_apartmentmii_33.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_33.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_33.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_33.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_33.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_33.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_33.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_33.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_33.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_33.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_33.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_34_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_34.ValueChanged
        Select Case valu_apartmentmii_34.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_34.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_34.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_34.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_34.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_34.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_34.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_34.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_34.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_34.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_34.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_35_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_35.ValueChanged
        Select Case valu_apartmentmii_35.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_35.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_35.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_35.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_35.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_35.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_35.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_35.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_35.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_35.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_35.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_36_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_36.ValueChanged
        Select Case valu_apartmentmii_36.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_36.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_36.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_36.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_36.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_36.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_36.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_36.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_36.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_36.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_36.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_37_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_37.ValueChanged
        Select Case valu_apartmentmii_37.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_37.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_37.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_37.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_37.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_37.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_37.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_37.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_37.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_37.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_37.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_38_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_38.ValueChanged
        Select Case valu_apartmentmii_38.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_38.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_38.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_38.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_38.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_38.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_38.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_38.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_38.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_38.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_38.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_39_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_39.ValueChanged
        Select Case valu_apartmentmii_39.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_39.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_39.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_39.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_39.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_39.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_39.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_39.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_39.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_39.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_39.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_40_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_40.ValueChanged
        Select Case valu_apartmentmii_40.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_40.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_40.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_40.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_40.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_40.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_40.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_40.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_40.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_40.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_40.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_41_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_41.ValueChanged
        Select Case valu_apartmentmii_41.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_41.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_41.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_41.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_41.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_41.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_41.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_41.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_41.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_41.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_41.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_42_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_42.ValueChanged
        Select Case valu_apartmentmii_42.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_42.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_42.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_42.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_42.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_42.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_42.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_42.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_42.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_42.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_42.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_43_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_43.ValueChanged
        Select Case valu_apartmentmii_43.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_43.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_43.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_43.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_43.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_43.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_43.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_43.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_43.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_43.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_43.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_44_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_44.ValueChanged
        Select Case valu_apartmentmii_44.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_44.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_44.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_44.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_44.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_44.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_44.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_44.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_44.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_44.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_44.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_45_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_45.ValueChanged
        Select Case valu_apartmentmii_45.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_45.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_45.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_45.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_45.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_45.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_45.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_45.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_45.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_45.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_45.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_46_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_46.ValueChanged
        Select Case valu_apartmentmii_46.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_46.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_46.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_46.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_46.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_46.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_46.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_46.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_46.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_46.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_46.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_47_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_47.ValueChanged
        Select Case valu_apartmentmii_47.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_47.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_47.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_47.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_47.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_47.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_47.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_47.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_47.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_47.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_47.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_48_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_48.ValueChanged
        Select Case valu_apartmentmii_48.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_48.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_48.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_48.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_48.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_48.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_48.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_48.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_48.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_48.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_48.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_49_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_49.ValueChanged
        Select Case valu_apartmentmii_49.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_49.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_49.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_49.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_49.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_49.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_49.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_49.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_49.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_49.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_49.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_50_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_50.ValueChanged
        Select Case valu_apartmentmii_50.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_50.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_50.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_50.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_50.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_50.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_50.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_50.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_50.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_50.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_50.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_51_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_51.ValueChanged
        Select Case valu_apartmentmii_51.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_51.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_51.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_51.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_51.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_51.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_51.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_51.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_51.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_51.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_51.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_52_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_52.ValueChanged
        Select Case valu_apartmentmii_52.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_52.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_52.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_52.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_52.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_52.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_52.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_52.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_52.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_52.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_52.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_53_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_53.ValueChanged
        Select Case valu_apartmentmii_53.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_53.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_53.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_53.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_53.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_53.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_53.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_53.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_53.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_53.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_53.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_54_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_54.ValueChanged
        Select Case valu_apartmentmii_54.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_54.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_54.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_54.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_54.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_54.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_54.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_54.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_54.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_54.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_54.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_55_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_55.ValueChanged
        Select Case valu_apartmentmii_55.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_55.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_55.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_55.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_55.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_55.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_55.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_55.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_55.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_55.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_55.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_56_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_56.ValueChanged
        Select Case valu_apartmentmii_56.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_56.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_56.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_56.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_56.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_56.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_56.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_56.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_56.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_56.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_56.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_57_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_57.ValueChanged
        Select Case valu_apartmentmii_57.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_57.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_57.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_57.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_57.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_57.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_57.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_57.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_57.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_57.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_57.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_58_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_58.ValueChanged
        Select Case valu_apartmentmii_58.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_58.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_58.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_58.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_58.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_58.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_58.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_58.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_58.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_58.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_58.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_59_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_59.ValueChanged
        Select Case valu_apartmentmii_59.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_59.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_59.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_59.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_59.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_59.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_59.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_59.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_59.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_59.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_59.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_60_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_60.ValueChanged
        Select Case valu_apartmentmii_60.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_60.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_60.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_60.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_60.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_60.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_60.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_60.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_60.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_60.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_60.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_61_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_61.ValueChanged
        Select Case valu_apartmentmii_61.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_61.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_61.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_61.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_61.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_61.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_61.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_61.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_61.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_61.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_61.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_62_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_62.ValueChanged
        Select Case valu_apartmentmii_62.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_62.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_62.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_62.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_62.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_62.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_62.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_62.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_62.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_62.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_62.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_63_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_63.ValueChanged
        Select Case valu_apartmentmii_63.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_63.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_63.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_63.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_63.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_63.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_63.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_63.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_63.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_63.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_63.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_64_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_64.ValueChanged
        Select Case valu_apartmentmii_64.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_64.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_64.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_64.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_64.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_64.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_64.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_64.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_64.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_64.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_64.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_65_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_65.ValueChanged
        Select Case valu_apartmentmii_65.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_65.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_65.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_65.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_65.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_65.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_65.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_65.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_65.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_65.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_65.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_66_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_66.ValueChanged
        Select Case valu_apartmentmii_66.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_66.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_66.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_66.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_66.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_66.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_66.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_66.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_66.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_66.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_66.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_67_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_67.ValueChanged
        Select Case valu_apartmentmii_67.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_67.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_67.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_67.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_67.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_67.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_67.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_67.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_67.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_67.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_67.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_68_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_68.ValueChanged
        Select Case valu_apartmentmii_68.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_68.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_68.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_68.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_68.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_68.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_68.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_68.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_68.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_68.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_68.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_69_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_69.ValueChanged
        Select Case valu_apartmentmii_69.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_69.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_69.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_69.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_69.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_69.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_69.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_69.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_69.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_69.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_69.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_70_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_70.ValueChanged
        Select Case valu_apartmentmii_70.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_70.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_70.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_70.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_70.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_70.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_70.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_70.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_70.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_70.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_70.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_71_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_71.ValueChanged
        Select Case valu_apartmentmii_71.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_71.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_71.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_71.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_71.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_71.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_71.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_71.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_71.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_71.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_71.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_72_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_72.ValueChanged
        Select Case valu_apartmentmii_72.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_72.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_72.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_72.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_72.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_72.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_72.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_72.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_72.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_72.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_72.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_73_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_73.ValueChanged
        Select Case valu_apartmentmii_73.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_73.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_73.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_73.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_73.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_73.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_73.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_73.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_73.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_73.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_73.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_74_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_74.ValueChanged
        Select Case valu_apartmentmii_74.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_74.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_74.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_74.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_74.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_74.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_74.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_74.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_74.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_74.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_74.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_75_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_75.ValueChanged
        Select Case valu_apartmentmii_75.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_75.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_75.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_75.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_75.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_75.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_75.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_75.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_75.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_75.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_75.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_76_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_76.ValueChanged
        Select Case valu_apartmentmii_76.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_76.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_76.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_76.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_76.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_76.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_76.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_76.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_76.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_76.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_76.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_77_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_77.ValueChanged
        Select Case valu_apartmentmii_77.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_77.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_77.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_77.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_77.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_77.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_77.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_77.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_77.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_77.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_77.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_78_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_78.ValueChanged
        Select Case valu_apartmentmii_78.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_78.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_78.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_78.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_78.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_78.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_78.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_78.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_78.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_78.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_78.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_79_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_79.ValueChanged
        Select Case valu_apartmentmii_79.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_79.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_79.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_79.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_79.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_79.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_79.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_79.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_79.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_79.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_79.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_80_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_80.ValueChanged
        Select Case valu_apartmentmii_80.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_80.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_80.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_80.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_80.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_80.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_80.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_80.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_80.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_80.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_80.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_81_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_81.ValueChanged
        Select Case valu_apartmentmii_81.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_81.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_81.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_81.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_81.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_81.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_81.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_81.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_81.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_81.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_81.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_82_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_82.ValueChanged
        Select Case valu_apartmentmii_82.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_82.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_82.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_82.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_82.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_82.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_82.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_82.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_82.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_82.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_82.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_83_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_83.ValueChanged
        Select Case valu_apartmentmii_83.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_83.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_83.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_83.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_83.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_83.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_83.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_83.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_83.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_83.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_83.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_84_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_84.ValueChanged
        Select Case valu_apartmentmii_84.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_84.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_84.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_84.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_84.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_84.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_84.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_84.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_84.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_84.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_84.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_85_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_85.ValueChanged
        Select Case valu_apartmentmii_85.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_85.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_85.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_85.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_85.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_85.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_85.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_85.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_85.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_85.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_85.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_86_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_86.ValueChanged
        Select Case valu_apartmentmii_86.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_86.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_86.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_86.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_86.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_86.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_86.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_86.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_86.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_86.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_86.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_87_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_87.ValueChanged
        Select Case valu_apartmentmii_87.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_87.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_87.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_87.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_87.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_87.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_87.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_87.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_87.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_87.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_87.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_88_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_88.ValueChanged
        Select Case valu_apartmentmii_88.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_88.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_88.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_88.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_88.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_88.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_88.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_88.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_88.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_88.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_88.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_89_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_89.ValueChanged
        Select Case valu_apartmentmii_89.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_89.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_89.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_89.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_89.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_89.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_89.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_89.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_89.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_89.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_89.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_90_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_90.ValueChanged
        Select Case valu_apartmentmii_90.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_90.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_90.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_90.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_90.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_90.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_90.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_90.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_90.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_90.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_90.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_91_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_91.ValueChanged
        Select Case valu_apartmentmii_91.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_91.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_91.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_91.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_91.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_91.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_91.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_91.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_91.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_91.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_91.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_92_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_92.ValueChanged
        Select Case valu_apartmentmii_92.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_92.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_92.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_92.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_92.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_92.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_92.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_92.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_92.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_92.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_92.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_93_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_93.ValueChanged
        Select Case valu_apartmentmii_93.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_93.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_93.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_93.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_93.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_93.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_93.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_93.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_93.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_93.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_93.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_94_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_94.ValueChanged
        Select Case valu_apartmentmii_94.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_94.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_94.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_94.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_94.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_94.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_94.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_94.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_94.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_94.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_94.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_95_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_95.ValueChanged
        Select Case valu_apartmentmii_95.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_95.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_95.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_95.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_95.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_95.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_95.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_95.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_95.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_95.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_95.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_96_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_96.ValueChanged
        Select Case valu_apartmentmii_96.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_96.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_96.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_96.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_96.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_96.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_96.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_96.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_96.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_96.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_96.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_97_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_97.ValueChanged
        Select Case valu_apartmentmii_97.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_97.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_97.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_97.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_97.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_97.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_97.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_97.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_97.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_97.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_97.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_98_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_98.ValueChanged
        Select Case valu_apartmentmii_98.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_98.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_98.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_98.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_98.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_98.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_98.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_98.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_98.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_98.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_98.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_99_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_99.ValueChanged
        Select Case valu_apartmentmii_99.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_99.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_99.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_99.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_99.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_99.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_99.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_99.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_99.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_99.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_99.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Private Sub valu_apartmentmii_100_ValueChanged(sender As Object, e As EventArgs) Handles valu_apartmentmii_100.ValueChanged
        Select Case valu_apartmentmii_100.Value
            Case &H100 To &H148, &H167 To &H16F, &H171 To &H175, &H17B To &H17D, &H187, &H188, &H18B To &H18F
                Icon_apartmentmii_100.Image = My.Resources.icon_interaction_black
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A
                Icon_apartmentmii_100.Image = My.Resources.icon_interaction_orange
            Case &H14C, &H14F To &H151, &H154, &H155
                Icon_apartmentmii_100.Image = My.Resources.icon_interaction_pink
            Case &H156, &H157
                Icon_apartmentmii_100.Image = My.Resources.icon_interaction_phone
            Case &H15F To &H166, &H15D
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_100.Image = My.Resources.icon_interaction_bluej
                Else
                    Icon_apartmentmii_100.Image = My.Resources.icon_interaction_blue
                End If
            Case &H15E
                If Filever_text.Text = "JP" Then
                    Icon_apartmentmii_100.Image = My.Resources.icon_interaction_tbluej
                Else
                    Icon_apartmentmii_100.Image = My.Resources.icon_interaction_tblue
                End If
            Case &H15C, &H17E To &H186, &H0
                Icon_apartmentmii_100.Image = My.Resources.icon_interaction_none
            Case Else
                Icon_apartmentmii_100.Image = My.Resources.icon_interaction_unknow
        End Select
    End Sub

    Public Sub Readallinteractions()
        Try
            Dim Readinterac As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Readinterac.Position = &H24950
                valu_apartmentmii_1.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H24950
                valu_apartmentmii_1.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H24A50
                valu_apartmentmii_2.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H24B50
                valu_apartmentmii_3.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H24C50
                valu_apartmentmii_4.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H24D50
                valu_apartmentmii_5.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H24E50
                valu_apartmentmii_6.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H24F50
                valu_apartmentmii_7.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25050
                valu_apartmentmii_8.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25150
                valu_apartmentmii_9.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25250
                valu_apartmentmii_10.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25350
                valu_apartmentmii_11.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25450
                valu_apartmentmii_12.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25550
                valu_apartmentmii_13.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25650
                valu_apartmentmii_14.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25750
                valu_apartmentmii_15.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25850
                valu_apartmentmii_16.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25950
                valu_apartmentmii_17.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25A50
                valu_apartmentmii_18.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25B50
                valu_apartmentmii_19.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25C50
                valu_apartmentmii_20.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25D50
                valu_apartmentmii_21.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25E50
                valu_apartmentmii_22.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H25F50
                valu_apartmentmii_23.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26050
                valu_apartmentmii_24.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26150
                valu_apartmentmii_25.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26250
                valu_apartmentmii_26.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26350
                valu_apartmentmii_27.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26450
                valu_apartmentmii_28.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26550
                valu_apartmentmii_29.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26650
                valu_apartmentmii_30.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26750
                valu_apartmentmii_31.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26850
                valu_apartmentmii_32.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26950
                valu_apartmentmii_33.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26A50
                valu_apartmentmii_34.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26B50
                valu_apartmentmii_35.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26C50
                valu_apartmentmii_36.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26D50
                valu_apartmentmii_37.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26E50
                valu_apartmentmii_38.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H26F50
                valu_apartmentmii_39.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27050
                valu_apartmentmii_40.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27150
                valu_apartmentmii_41.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27250
                valu_apartmentmii_42.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27350
                valu_apartmentmii_43.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27450
                valu_apartmentmii_44.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27550
                valu_apartmentmii_45.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27650
                valu_apartmentmii_46.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27750
                valu_apartmentmii_47.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27850
                valu_apartmentmii_48.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27950
                valu_apartmentmii_49.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27A50
                valu_apartmentmii_50.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27B50
                valu_apartmentmii_51.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27C50
                valu_apartmentmii_52.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27D50
                valu_apartmentmii_53.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27E50
                valu_apartmentmii_54.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H27F50
                valu_apartmentmii_55.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28050
                valu_apartmentmii_56.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28150
                valu_apartmentmii_57.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28250
                valu_apartmentmii_58.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28350
                valu_apartmentmii_59.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28450
                valu_apartmentmii_60.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28550
                valu_apartmentmii_61.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28650
                valu_apartmentmii_62.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28750
                valu_apartmentmii_63.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28850
                valu_apartmentmii_64.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28950
                valu_apartmentmii_65.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28A50
                valu_apartmentmii_66.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28B50
                valu_apartmentmii_67.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28C50
                valu_apartmentmii_68.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28D50
                valu_apartmentmii_69.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28E50
                valu_apartmentmii_70.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H28F50
                valu_apartmentmii_71.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29050
                valu_apartmentmii_72.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29150
                valu_apartmentmii_73.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29250
                valu_apartmentmii_74.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29350
                valu_apartmentmii_75.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29450
                valu_apartmentmii_76.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29550
                valu_apartmentmii_77.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29650
                valu_apartmentmii_78.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29750
                valu_apartmentmii_79.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29850
                valu_apartmentmii_80.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29950
                valu_apartmentmii_81.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29A50
                valu_apartmentmii_82.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29B50
                valu_apartmentmii_83.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29C50
                valu_apartmentmii_84.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29D50
                valu_apartmentmii_85.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29E50
                valu_apartmentmii_86.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29F50
                valu_apartmentmii_87.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A050
                valu_apartmentmii_88.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A150
                valu_apartmentmii_89.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A250
                valu_apartmentmii_90.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A350
                valu_apartmentmii_91.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A450
                valu_apartmentmii_92.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A550
                valu_apartmentmii_93.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A650
                valu_apartmentmii_94.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A750
                valu_apartmentmii_95.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A850
                valu_apartmentmii_96.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A950
                valu_apartmentmii_97.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2AA50
                valu_apartmentmii_98.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2AB50
                valu_apartmentmii_99.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2AC50
                valu_apartmentmii_100.Value = Readinterac.ReadUInt16
            Else
                Readinterac.Position = &H29AC0
                valu_apartmentmii_1.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29BC0
                valu_apartmentmii_2.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29CC0
                valu_apartmentmii_3.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29DC0
                valu_apartmentmii_4.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29EC0
                valu_apartmentmii_5.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H29FC0
                valu_apartmentmii_6.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A0C0
                valu_apartmentmii_7.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A1C0
                valu_apartmentmii_8.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A2C0
                valu_apartmentmii_9.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A3C0
                valu_apartmentmii_10.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A4C0
                valu_apartmentmii_11.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A5C0
                valu_apartmentmii_12.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A6C0
                valu_apartmentmii_13.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A7C0
                valu_apartmentmii_14.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A8C0
                valu_apartmentmii_15.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2A9C0
                valu_apartmentmii_16.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2AAC0
                valu_apartmentmii_17.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2ABC0
                valu_apartmentmii_18.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2ACC0
                valu_apartmentmii_19.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2ADC0
                valu_apartmentmii_20.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2AEC0
                valu_apartmentmii_21.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2AFC0
                valu_apartmentmii_22.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B0C0
                valu_apartmentmii_23.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B1C0
                valu_apartmentmii_24.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B2C0
                valu_apartmentmii_25.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B3C0
                valu_apartmentmii_26.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B4C0
                valu_apartmentmii_27.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B5C0
                valu_apartmentmii_28.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B6C0
                valu_apartmentmii_29.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B7C0
                valu_apartmentmii_30.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B8C0
                valu_apartmentmii_31.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2B9C0
                valu_apartmentmii_32.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2BAC0
                valu_apartmentmii_33.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2BBC0
                valu_apartmentmii_34.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2BCC0
                valu_apartmentmii_35.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2BDC0
                valu_apartmentmii_36.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2BEC0
                valu_apartmentmii_37.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2BFC0
                valu_apartmentmii_38.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C0C0
                valu_apartmentmii_39.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C1C0
                valu_apartmentmii_40.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C2C0
                valu_apartmentmii_41.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C3C0
                valu_apartmentmii_42.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C4C0
                valu_apartmentmii_43.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C5C0
                valu_apartmentmii_44.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C6C0
                valu_apartmentmii_45.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C7C0
                valu_apartmentmii_46.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C8C0
                valu_apartmentmii_47.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2C9C0
                valu_apartmentmii_48.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2CAC0
                valu_apartmentmii_49.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2CBC0
                valu_apartmentmii_50.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2CCC0
                valu_apartmentmii_51.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2CDC0
                valu_apartmentmii_52.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2CEC0
                valu_apartmentmii_53.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2CFC0
                valu_apartmentmii_54.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D0C0
                valu_apartmentmii_55.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D1C0
                valu_apartmentmii_56.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D2C0
                valu_apartmentmii_57.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D3C0
                valu_apartmentmii_58.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D4C0
                valu_apartmentmii_59.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D5C0
                valu_apartmentmii_60.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D6C0
                valu_apartmentmii_61.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D7C0
                valu_apartmentmii_62.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D8C0
                valu_apartmentmii_63.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2D9C0
                valu_apartmentmii_64.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2DAC0
                valu_apartmentmii_65.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2DBC0
                valu_apartmentmii_66.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2DCC0
                valu_apartmentmii_67.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2DDC0
                valu_apartmentmii_68.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2DEC0
                valu_apartmentmii_69.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2DFC0
                valu_apartmentmii_70.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E0C0
                valu_apartmentmii_71.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E1C0
                valu_apartmentmii_72.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E2C0
                valu_apartmentmii_73.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E3C0
                valu_apartmentmii_74.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E4C0
                valu_apartmentmii_75.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E5C0
                valu_apartmentmii_76.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E6C0
                valu_apartmentmii_77.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E7C0
                valu_apartmentmii_78.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E8C0
                valu_apartmentmii_79.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2E9C0
                valu_apartmentmii_80.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2EAC0
                valu_apartmentmii_81.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2EBC0
                valu_apartmentmii_82.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2ECC0
                valu_apartmentmii_83.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2EDC0
                valu_apartmentmii_84.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2EEC0
                valu_apartmentmii_85.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2EFC0
                valu_apartmentmii_86.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F0C0
                valu_apartmentmii_87.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F1C0
                valu_apartmentmii_88.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F2C0
                valu_apartmentmii_89.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F3C0
                valu_apartmentmii_90.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F4C0
                valu_apartmentmii_91.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F5C0
                valu_apartmentmii_92.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F6C0
                valu_apartmentmii_93.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F7C0
                valu_apartmentmii_94.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F8C0
                valu_apartmentmii_95.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2F9C0
                valu_apartmentmii_96.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2FAC0
                valu_apartmentmii_97.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2FBC0
                valu_apartmentmii_98.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2FCC0
                valu_apartmentmii_99.Value = Readinterac.ReadUInt16
                Readinterac.Position = &H2FDC0
                valu_apartmentmii_100.Value = Readinterac.ReadUInt16
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read all interactions"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub TLSE_interactions_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Readallinteractions()
    End Sub

    Private Sub Warning_miiapartment_Click(sender As Object, e As EventArgs) Handles Warning_miiapartment.Click
        TLSE_dialog.Text_TLSE_dialog.Text = "This not corresponding to mii apartments diposition (as default)"
        TLSE_dialog.ShowDialog()
    End Sub

    Public Sub Readmiiname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H1C5A
                Select_mii.Items.Item(0) = "Mii 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H21EA
                Select_mii.Items.Item(1) = "Mii 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H277A
                Select_mii.Items.Item(2) = "Mii 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2D0A
                Select_mii.Items.Item(3) = "Mii 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H329A
                Select_mii.Items.Item(4) = "Mii 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H382A
                Select_mii.Items.Item(5) = "Mii 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DBA
                Select_mii.Items.Item(6) = "Mii 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H434A
                Select_mii.Items.Item(7) = "Mii 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H48DA
                Select_mii.Items.Item(8) = "Mii 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E6A
                Select_mii.Items.Item(9) = "Mii 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53FA
                Select_mii.Items.Item(10) = "Mii 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H598A
                Select_mii.Items.Item(11) = "Mii 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5F1A
                Select_mii.Items.Item(12) = "Mii 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H64AA
                Select_mii.Items.Item(13) = "Mii 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H6A3A
                Select_mii.Items.Item(14) = "Mii 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H6FCA
                Select_mii.Items.Item(15) = "Mii 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H755A
                Select_mii.Items.Item(16) = "Mii 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H7AEA
                Select_mii.Items.Item(17) = "Mii 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H807A
                Select_mii.Items.Item(18) = "Mii 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H860A
                Select_mii.Items.Item(19) = "Mii 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H8B9A
                Select_mii.Items.Item(20) = "Mii 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H912A
                Select_mii.Items.Item(21) = "Mii 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H96BA
                Select_mii.Items.Item(22) = "Mii 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H9C4A
                Select_mii.Items.Item(23) = "Mii 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA1DA
                Select_mii.Items.Item(24) = "Mii 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA76A
                Select_mii.Items.Item(25) = "Mii 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HACFA
                Select_mii.Items.Item(26) = "Mii 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HB28A
                Select_mii.Items.Item(27) = "Mii 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HB81A
                Select_mii.Items.Item(28) = "Mii 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HBDAA
                Select_mii.Items.Item(29) = "Mii 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC33A
                Select_mii.Items.Item(30) = "Mii 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC8CA
                Select_mii.Items.Item(31) = "Mii 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HCE5A
                Select_mii.Items.Item(32) = "Mii 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HD3EA
                Select_mii.Items.Item(33) = "Mii 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HD97A
                Select_mii.Items.Item(34) = "Mii 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HDF0A
                Select_mii.Items.Item(35) = "Mii 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HE49A
                Select_mii.Items.Item(36) = "Mii 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HEA2A
                Select_mii.Items.Item(37) = "Mii 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HEFBA
                Select_mii.Items.Item(38) = "Mii 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HF54A
                Select_mii.Items.Item(39) = "Mii 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HFADA
                Select_mii.Items.Item(40) = "Mii 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1006A
                Select_mii.Items.Item(41) = "Mii 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H105FA
                Select_mii.Items.Item(42) = "Mii 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10B8A
                Select_mii.Items.Item(43) = "Mii 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1111A
                Select_mii.Items.Item(44) = "Mii 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H116AA
                Select_mii.Items.Item(45) = "Mii 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11C3A
                Select_mii.Items.Item(46) = "Mii 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H121CA
                Select_mii.Items.Item(47) = "Mii 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1275A
                Select_mii.Items.Item(48) = "Mii 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H12CEA
                Select_mii.Items.Item(49) = "Mii 50 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1327A
                Select_mii.Items.Item(50) = "Mii 51 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1380A
                Select_mii.Items.Item(51) = "Mii 52 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H13D9A
                Select_mii.Items.Item(52) = "Mii 53 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1432A
                Select_mii.Items.Item(53) = "Mii 54 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H148BA
                Select_mii.Items.Item(54) = "Mii 55 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H14E4A
                Select_mii.Items.Item(55) = "Mii 56 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H153DA
                Select_mii.Items.Item(56) = "Mii 57 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1596A
                Select_mii.Items.Item(57) = "Mii 58 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H15EFA
                Select_mii.Items.Item(58) = "Mii 59 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1648A
                Select_mii.Items.Item(59) = "Mii 60 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H16A1A
                Select_mii.Items.Item(60) = "Mii 61 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H16FAA
                Select_mii.Items.Item(61) = "Mii 62 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1753A
                Select_mii.Items.Item(62) = "Mii 63 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H17ACA
                Select_mii.Items.Item(63) = "Mii 64 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1805A
                Select_mii.Items.Item(64) = "Mii 65 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H185EA
                Select_mii.Items.Item(65) = "Mii 66 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H18B7A
                Select_mii.Items.Item(66) = "Mii 67 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1910A
                Select_mii.Items.Item(67) = "Mii 68 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1969A
                Select_mii.Items.Item(68) = "Mii 69 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19C2A
                Select_mii.Items.Item(69) = "Mii 70 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A1BA
                Select_mii.Items.Item(70) = "Mii 71 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A74A
                Select_mii.Items.Item(71) = "Mii 72 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1ACDA
                Select_mii.Items.Item(72) = "Mii 73 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B26A
                Select_mii.Items.Item(73) = "Mii 74 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B7FA
                Select_mii.Items.Item(74) = "Mii 75 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BD8A
                Select_mii.Items.Item(75) = "Mii 76 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C31A
                Select_mii.Items.Item(76) = "Mii 77 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C8AA
                Select_mii.Items.Item(77) = "Mii 78 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1CE3A
                Select_mii.Items.Item(78) = "Mii 79 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1D3CA
                Select_mii.Items.Item(79) = "Mii 80 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1D95A
                Select_mii.Items.Item(80) = "Mii 81 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DEEA
                Select_mii.Items.Item(81) = "Mii 82 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E47A
                Select_mii.Items.Item(82) = "Mii 83 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EA0A
                Select_mii.Items.Item(83) = "Mii 84 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EF9A
                Select_mii.Items.Item(84) = "Mii 85 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1F52A
                Select_mii.Items.Item(85) = "Mii 86 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1FABA
                Select_mii.Items.Item(86) = "Mii 87 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2004A
                Select_mii.Items.Item(87) = "Mii 88 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H205DA
                Select_mii.Items.Item(88) = "Mii 89 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H20B6A
                Select_mii.Items.Item(89) = "Mii 90 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H210FA
                Select_mii.Items.Item(90) = "Mii 91 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2168A
                Select_mii.Items.Item(91) = "Mii 92 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H21C1A
                Select_mii.Items.Item(92) = "Mii 93 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H221AA
                Select_mii.Items.Item(93) = "Mii 94 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2273A
                Select_mii.Items.Item(94) = "Mii 95 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H22CCA
                Select_mii.Items.Item(95) = "Mii 96 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2325A
                Select_mii.Items.Item(96) = "Mii 97 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H237EA
                Select_mii.Items.Item(97) = "Mii 98 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H23D7A
                Select_mii.Items.Item(98) = "Mii 99 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2430A
                Select_mii.Items.Item(99) = "Mii 100 : " & Reader.ReadUnicodeString(10)
            Else
                Reader.Position = &H1C8A
                Select_mii.Items.Item(0) = "Mii 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H22EA
                Select_mii.Items.Item(1) = "Mii 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H294A
                Select_mii.Items.Item(2) = "Mii 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2FAA
                Select_mii.Items.Item(3) = "Mii 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H360A
                Select_mii.Items.Item(4) = "Mii 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C6A
                Select_mii.Items.Item(5) = "Mii 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H42CA
                Select_mii.Items.Item(6) = "Mii 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H492A
                Select_mii.Items.Item(7) = "Mii 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F8A
                Select_mii.Items.Item(8) = "Mii 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55EA
                Select_mii.Items.Item(9) = "Mii 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5C4A
                Select_mii.Items.Item(10) = "Mii 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H62AA
                Select_mii.Items.Item(11) = "Mii 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H690A
                Select_mii.Items.Item(12) = "Mii 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H6F6A
                Select_mii.Items.Item(13) = "Mii 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H75CA
                Select_mii.Items.Item(14) = "Mii 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H7C2A
                Select_mii.Items.Item(15) = "Mii 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H828A
                Select_mii.Items.Item(16) = "Mii 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H88EA
                Select_mii.Items.Item(17) = "Mii 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H8F4A
                Select_mii.Items.Item(18) = "Mii 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H95AA
                Select_mii.Items.Item(19) = "Mii 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H9C0A
                Select_mii.Items.Item(20) = "Mii 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA26A
                Select_mii.Items.Item(21) = "Mii 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HA8CA
                Select_mii.Items.Item(22) = "Mii 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HAF2A
                Select_mii.Items.Item(23) = "Mii 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HB58A
                Select_mii.Items.Item(24) = "Mii 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HBBEA
                Select_mii.Items.Item(25) = "Mii 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC24A
                Select_mii.Items.Item(26) = "Mii 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HC8AA
                Select_mii.Items.Item(27) = "Mii 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HCF0A
                Select_mii.Items.Item(28) = "Mii 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HD56A
                Select_mii.Items.Item(29) = "Mii 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HDBCA
                Select_mii.Items.Item(30) = "Mii 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HE22A
                Select_mii.Items.Item(31) = "Mii 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HE88A
                Select_mii.Items.Item(32) = "Mii 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HEEEA
                Select_mii.Items.Item(33) = "Mii 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HF54A
                Select_mii.Items.Item(34) = "Mii 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &HFBAA
                Select_mii.Items.Item(35) = "Mii 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1020A
                Select_mii.Items.Item(36) = "Mii 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1086A
                Select_mii.Items.Item(37) = "Mii 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10ECA
                Select_mii.Items.Item(38) = "Mii 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1152A
                Select_mii.Items.Item(39) = "Mii 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11B8A
                Select_mii.Items.Item(40) = "Mii 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H121EA
                Select_mii.Items.Item(41) = "Mii 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1284A
                Select_mii.Items.Item(42) = "Mii 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H12EAA
                Select_mii.Items.Item(43) = "Mii 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1350A
                Select_mii.Items.Item(44) = "Mii 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H13B6A
                Select_mii.Items.Item(45) = "Mii 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H141CA
                Select_mii.Items.Item(46) = "Mii 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1482A
                Select_mii.Items.Item(47) = "Mii 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H14E8A
                Select_mii.Items.Item(48) = "Mii 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H154EA
                Select_mii.Items.Item(49) = "Mii 50 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H15B4A
                Select_mii.Items.Item(50) = "Mii 51 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H161AA
                Select_mii.Items.Item(51) = "Mii 52 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1680A
                Select_mii.Items.Item(52) = "Mii 53 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H16E6A
                Select_mii.Items.Item(53) = "Mii 54 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H174CA
                Select_mii.Items.Item(54) = "Mii 55 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H17B2A
                Select_mii.Items.Item(55) = "Mii 56 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1818A
                Select_mii.Items.Item(56) = "Mii 57 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H187EA
                Select_mii.Items.Item(57) = "Mii 58 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H18E4A
                Select_mii.Items.Item(58) = "Mii 59 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H194AA
                Select_mii.Items.Item(59) = "Mii 60 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19B0A
                Select_mii.Items.Item(60) = "Mii 61 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A16A
                Select_mii.Items.Item(61) = "Mii 62 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A7CA
                Select_mii.Items.Item(62) = "Mii 63 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AE2A
                Select_mii.Items.Item(63) = "Mii 64 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B48A
                Select_mii.Items.Item(64) = "Mii 65 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BAEA
                Select_mii.Items.Item(65) = "Mii 66 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C14A
                Select_mii.Items.Item(66) = "Mii 67 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C7AA
                Select_mii.Items.Item(67) = "Mii 68 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1CE0A
                Select_mii.Items.Item(68) = "Mii 69 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1D46A
                Select_mii.Items.Item(69) = "Mii 70 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1DACA
                Select_mii.Items.Item(70) = "Mii 71 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E12A
                Select_mii.Items.Item(71) = "Mii 72 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1E78A
                Select_mii.Items.Item(72) = "Mii 73 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1EDEA
                Select_mii.Items.Item(73) = "Mii 74 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1F44A
                Select_mii.Items.Item(74) = "Mii 75 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1FAAA
                Select_mii.Items.Item(75) = "Mii 76 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2010A
                Select_mii.Items.Item(76) = "Mii 77 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2076A
                Select_mii.Items.Item(77) = "Mii 78 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H20DCA
                Select_mii.Items.Item(78) = "Mii 79 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2142A
                Select_mii.Items.Item(79) = "Mii 80 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H21A8A
                Select_mii.Items.Item(80) = "Mii 81 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H220EA
                Select_mii.Items.Item(81) = "Mii 82 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2274A
                Select_mii.Items.Item(82) = "Mii 83 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H22DAA
                Select_mii.Items.Item(83) = "Mii 84 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2340A
                Select_mii.Items.Item(84) = "Mii 85 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H23A6A
                Select_mii.Items.Item(85) = "Mii 86 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H240CA
                Select_mii.Items.Item(86) = "Mii 87 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2472A
                Select_mii.Items.Item(87) = "Mii 88 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H24D8A
                Select_mii.Items.Item(88) = "Mii 89 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H253EA
                Select_mii.Items.Item(89) = "Mii 90 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H25A4A
                Select_mii.Items.Item(90) = "Mii 91 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H260AA
                Select_mii.Items.Item(91) = "Mii 92 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2670A
                Select_mii.Items.Item(92) = "Mii 93 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H26D6A
                Select_mii.Items.Item(93) = "Mii 94 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H273CA
                Select_mii.Items.Item(94) = "Mii 95 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H27A2A
                Select_mii.Items.Item(95) = "Mii 96 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H2808A
                Select_mii.Items.Item(96) = "Mii 97 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H286EA
                Select_mii.Items.Item(97) = "Mii 98 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H28D4A
                Select_mii.Items.Item(98) = "Mii 99 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H293AA
                Select_mii.Items.Item(99) = "Mii 100 : " & Reader.ReadUnicodeString(10)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read Mii names"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture des noms des Mii a échoué"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub
End Class