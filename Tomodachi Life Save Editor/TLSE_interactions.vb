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
    Dim lastsavedate = &H10
    Dim Emotion_1 As String
    Dim Endinteraction_1 As String
    Dim Interaction_1 As String
    Dim Target1_1 As String
    Dim Target2_1 As String
    Dim Emotion_2 As String
    Dim Endinteraction_2 As String
    Dim Interaction_2 As String
    Dim Target1_2 As String
    Dim Target2_2 As String
    Dim Emotion_3 As String
    Dim Endinteraction_3 As String
    Dim Interaction_3 As String
    Dim Target1_3 As String
    Dim Target2_3 As String
    Dim Emotion_4 As String
    Dim Endinteraction_4 As String
    Dim Interaction_4 As String
    Dim Target1_4 As String
    Dim Target2_4 As String
    Dim Emotion_5 As String
    Dim Endinteraction_5 As String
    Dim Interaction_5 As String
    Dim Target1_5 As String
    Dim Target2_5 As String
    Dim Emotion_6 As String
    Dim Endinteraction_6 As String
    Dim Interaction_6 As String
    Dim Target1_6 As String
    Dim Target2_6 As String
    Dim Emotion_7 As String
    Dim Endinteraction_7 As String
    Dim Interaction_7 As String
    Dim Target1_7 As String
    Dim Target2_7 As String
    Dim Emotion_8 As String
    Dim Endinteraction_8 As String
    Dim Interaction_8 As String
    Dim Target1_8 As String
    Dim Target2_8 As String
    Dim Emotion_9 As String
    Dim Endinteraction_9 As String
    Dim Interaction_9 As String
    Dim Target1_9 As String
    Dim Target2_9 As String
    Dim Emotion_10 As String
    Dim Endinteraction_10 As String
    Dim Interaction_10 As String
    Dim Target1_10 As String
    Dim Target2_10 As String
    Dim Emotion_11 As String
    Dim Endinteraction_11 As String
    Dim Interaction_11 As String
    Dim Target1_11 As String
    Dim Target2_11 As String
    Dim Emotion_12 As String
    Dim Endinteraction_12 As String
    Dim Interaction_12 As String
    Dim Target1_12 As String
    Dim Target2_12 As String
    Dim Emotion_13 As String
    Dim Endinteraction_13 As String
    Dim Interaction_13 As String
    Dim Target1_13 As String
    Dim Target2_13 As String
    Dim Emotion_14 As String
    Dim Endinteraction_14 As String
    Dim Interaction_14 As String
    Dim Target1_14 As String
    Dim Target2_14 As String
    Dim Emotion_15 As String
    Dim Endinteraction_15 As String
    Dim Interaction_15 As String
    Dim Target1_15 As String
    Dim Target2_15 As String
    Dim Emotion_16 As String
    Dim Endinteraction_16 As String
    Dim Interaction_16 As String
    Dim Target1_16 As String
    Dim Target2_16 As String
    Dim Emotion_17 As String
    Dim Endinteraction_17 As String
    Dim Interaction_17 As String
    Dim Target1_17 As String
    Dim Target2_17 As String
    Dim Emotion_18 As String
    Dim Endinteraction_18 As String
    Dim Interaction_18 As String
    Dim Target1_18 As String
    Dim Target2_18 As String
    Dim Emotion_19 As String
    Dim Endinteraction_19 As String
    Dim Interaction_19 As String
    Dim Target1_19 As String
    Dim Target2_19 As String
    Dim Emotion_20 As String
    Dim Endinteraction_20 As String
    Dim Interaction_20 As String
    Dim Target1_20 As String
    Dim Target2_20 As String
    Dim Emotion_21 As String
    Dim Endinteraction_21 As String
    Dim Interaction_21 As String
    Dim Target1_21 As String
    Dim Target2_21 As String
    Dim Emotion_22 As String
    Dim Endinteraction_22 As String
    Dim Interaction_22 As String
    Dim Target1_22 As String
    Dim Target2_22 As String
    Dim Emotion_23 As String
    Dim Endinteraction_23 As String
    Dim Interaction_23 As String
    Dim Target1_23 As String
    Dim Target2_23 As String
    Dim Emotion_24 As String
    Dim Endinteraction_24 As String
    Dim Interaction_24 As String
    Dim Target1_24 As String
    Dim Target2_24 As String
    Dim Emotion_25 As String
    Dim Endinteraction_25 As String
    Dim Interaction_25 As String
    Dim Target1_25 As String
    Dim Target2_25 As String
    Dim Emotion_26 As String
    Dim Endinteraction_26 As String
    Dim Interaction_26 As String
    Dim Target1_26 As String
    Dim Target2_26 As String
    Dim Emotion_27 As String
    Dim Endinteraction_27 As String
    Dim Interaction_27 As String
    Dim Target1_27 As String
    Dim Target2_27 As String
    Dim Emotion_28 As String
    Dim Endinteraction_28 As String
    Dim Interaction_28 As String
    Dim Target1_28 As String
    Dim Target2_28 As String
    Dim Emotion_29 As String
    Dim Endinteraction_29 As String
    Dim Interaction_29 As String
    Dim Target1_29 As String
    Dim Target2_29 As String
    Dim Emotion_30 As String
    Dim Endinteraction_30 As String
    Dim Interaction_30 As String
    Dim Target1_30 As String
    Dim Target2_30 As String
    Dim Emotion_31 As String
    Dim Endinteraction_31 As String
    Dim Interaction_31 As String
    Dim Target1_31 As String
    Dim Target2_31 As String
    Dim Emotion_32 As String
    Dim Endinteraction_32 As String
    Dim Interaction_32 As String
    Dim Target1_32 As String
    Dim Target2_32 As String
    Dim Emotion_33 As String
    Dim Endinteraction_33 As String
    Dim Interaction_33 As String
    Dim Target1_33 As String
    Dim Target2_33 As String
    Dim Emotion_34 As String
    Dim Endinteraction_34 As String
    Dim Interaction_34 As String
    Dim Target1_34 As String
    Dim Target2_34 As String
    Dim Emotion_35 As String
    Dim Endinteraction_35 As String
    Dim Interaction_35 As String
    Dim Target1_35 As String
    Dim Target2_35 As String
    Dim Emotion_36 As String
    Dim Endinteraction_36 As String
    Dim Interaction_36 As String
    Dim Target1_36 As String
    Dim Target2_36 As String
    Dim Emotion_37 As String
    Dim Endinteraction_37 As String
    Dim Interaction_37 As String
    Dim Target1_37 As String
    Dim Target2_37 As String
    Dim Emotion_38 As String
    Dim Endinteraction_38 As String
    Dim Interaction_38 As String
    Dim Target1_38 As String
    Dim Target2_38 As String
    Dim Emotion_39 As String
    Dim Endinteraction_39 As String
    Dim Interaction_39 As String
    Dim Target1_39 As String
    Dim Target2_39 As String
    Dim Emotion_40 As String
    Dim Endinteraction_40 As String
    Dim Interaction_40 As String
    Dim Target1_40 As String
    Dim Target2_40 As String
    Dim Emotion_41 As String
    Dim Endinteraction_41 As String
    Dim Interaction_41 As String
    Dim Target1_41 As String
    Dim Target2_41 As String
    Dim Emotion_42 As String
    Dim Endinteraction_42 As String
    Dim Interaction_42 As String
    Dim Target1_42 As String
    Dim Target2_42 As String
    Dim Emotion_43 As String
    Dim Endinteraction_43 As String
    Dim Interaction_43 As String
    Dim Target1_43 As String
    Dim Target2_43 As String
    Dim Emotion_44 As String
    Dim Endinteraction_44 As String
    Dim Interaction_44 As String
    Dim Target1_44 As String
    Dim Target2_44 As String
    Dim Emotion_45 As String
    Dim Endinteraction_45 As String
    Dim Interaction_45 As String
    Dim Target1_45 As String
    Dim Target2_45 As String
    Dim Emotion_46 As String
    Dim Endinteraction_46 As String
    Dim Interaction_46 As String
    Dim Target1_46 As String
    Dim Target2_46 As String
    Dim Emotion_47 As String
    Dim Endinteraction_47 As String
    Dim Interaction_47 As String
    Dim Target1_47 As String
    Dim Target2_47 As String
    Dim Emotion_48 As String
    Dim Endinteraction_48 As String
    Dim Interaction_48 As String
    Dim Target1_48 As String
    Dim Target2_48 As String
    Dim Emotion_49 As String
    Dim Endinteraction_49 As String
    Dim Interaction_49 As String
    Dim Target1_49 As String
    Dim Target2_49 As String
    Dim Emotion_50 As String
    Dim Endinteraction_50 As String
    Dim Interaction_50 As String
    Dim Target1_50 As String
    Dim Target2_50 As String
    Dim Emotion_51 As String
    Dim Endinteraction_51 As String
    Dim Interaction_51 As String
    Dim Target1_51 As String
    Dim Target2_51 As String
    Dim Emotion_52 As String
    Dim Endinteraction_52 As String
    Dim Interaction_52 As String
    Dim Target1_52 As String
    Dim Target2_52 As String
    Dim Emotion_53 As String
    Dim Endinteraction_53 As String
    Dim Interaction_53 As String
    Dim Target1_53 As String
    Dim Target2_53 As String
    Dim Emotion_54 As String
    Dim Endinteraction_54 As String
    Dim Interaction_54 As String
    Dim Target1_54 As String
    Dim Target2_54 As String
    Dim Emotion_55 As String
    Dim Endinteraction_55 As String
    Dim Interaction_55 As String
    Dim Target1_55 As String
    Dim Target2_55 As String
    Dim Emotion_56 As String
    Dim Endinteraction_56 As String
    Dim Interaction_56 As String
    Dim Target1_56 As String
    Dim Target2_56 As String
    Dim Emotion_57 As String
    Dim Endinteraction_57 As String
    Dim Interaction_57 As String
    Dim Target1_57 As String
    Dim Target2_57 As String
    Dim Emotion_58 As String
    Dim Endinteraction_58 As String
    Dim Interaction_58 As String
    Dim Target1_58 As String
    Dim Target2_58 As String
    Dim Emotion_59 As String
    Dim Endinteraction_59 As String
    Dim Interaction_59 As String
    Dim Target1_59 As String
    Dim Target2_59 As String
    Dim Emotion_60 As String
    Dim Endinteraction_60 As String
    Dim Interaction_60 As String
    Dim Target1_60 As String
    Dim Target2_60 As String
    Dim Emotion_61 As String
    Dim Endinteraction_61 As String
    Dim Interaction_61 As String
    Dim Target1_61 As String
    Dim Target2_61 As String
    Dim Emotion_62 As String
    Dim Endinteraction_62 As String
    Dim Interaction_62 As String
    Dim Target1_62 As String
    Dim Target2_62 As String
    Dim Emotion_63 As String
    Dim Endinteraction_63 As String
    Dim Interaction_63 As String
    Dim Target1_63 As String
    Dim Target2_63 As String
    Dim Emotion_64 As String
    Dim Endinteraction_64 As String
    Dim Interaction_64 As String
    Dim Target1_64 As String
    Dim Target2_64 As String
    Dim Emotion_65 As String
    Dim Endinteraction_65 As String
    Dim Interaction_65 As String
    Dim Target1_65 As String
    Dim Target2_65 As String
    Dim Emotion_66 As String
    Dim Endinteraction_66 As String
    Dim Interaction_66 As String
    Dim Target1_66 As String
    Dim Target2_66 As String
    Dim Emotion_67 As String
    Dim Endinteraction_67 As String
    Dim Interaction_67 As String
    Dim Target1_67 As String
    Dim Target2_67 As String
    Dim Emotion_68 As String
    Dim Endinteraction_68 As String
    Dim Interaction_68 As String
    Dim Target1_68 As String
    Dim Target2_68 As String
    Dim Emotion_69 As String
    Dim Endinteraction_69 As String
    Dim Interaction_69 As String
    Dim Target1_69 As String
    Dim Target2_69 As String
    Dim Emotion_70 As String
    Dim Endinteraction_70 As String
    Dim Interaction_70 As String
    Dim Target1_70 As String
    Dim Target2_70 As String
    Dim Emotion_71 As String
    Dim Endinteraction_71 As String
    Dim Interaction_71 As String
    Dim Target1_71 As String
    Dim Target2_71 As String
    Dim Emotion_72 As String
    Dim Endinteraction_72 As String
    Dim Interaction_72 As String
    Dim Target1_72 As String
    Dim Target2_72 As String
    Dim Emotion_73 As String
    Dim Endinteraction_73 As String
    Dim Interaction_73 As String
    Dim Target1_73 As String
    Dim Target2_73 As String
    Dim Emotion_74 As String
    Dim Endinteraction_74 As String
    Dim Interaction_74 As String
    Dim Target1_74 As String
    Dim Target2_74 As String
    Dim Emotion_75 As String
    Dim Endinteraction_75 As String
    Dim Interaction_75 As String
    Dim Target1_75 As String
    Dim Target2_75 As String
    Dim Emotion_76 As String
    Dim Endinteraction_76 As String
    Dim Interaction_76 As String
    Dim Target1_76 As String
    Dim Target2_76 As String
    Dim Emotion_77 As String
    Dim Endinteraction_77 As String
    Dim Interaction_77 As String
    Dim Target1_77 As String
    Dim Target2_77 As String
    Dim Emotion_78 As String
    Dim Endinteraction_78 As String
    Dim Interaction_78 As String
    Dim Target1_78 As String
    Dim Target2_78 As String
    Dim Emotion_79 As String
    Dim Endinteraction_79 As String
    Dim Interaction_79 As String
    Dim Target1_79 As String
    Dim Target2_79 As String
    Dim Emotion_80 As String
    Dim Endinteraction_80 As String
    Dim Interaction_80 As String
    Dim Target1_80 As String
    Dim Target2_80 As String
    Dim Emotion_81 As String
    Dim Endinteraction_81 As String
    Dim Interaction_81 As String
    Dim Target1_81 As String
    Dim Target2_81 As String
    Dim Emotion_82 As String
    Dim Endinteraction_82 As String
    Dim Interaction_82 As String
    Dim Target1_82 As String
    Dim Target2_82 As String
    Dim Emotion_83 As String
    Dim Endinteraction_83 As String
    Dim Interaction_83 As String
    Dim Target1_83 As String
    Dim Target2_83 As String
    Dim Emotion_84 As String
    Dim Endinteraction_84 As String
    Dim Interaction_84 As String
    Dim Target1_84 As String
    Dim Target2_84 As String
    Dim Emotion_85 As String
    Dim Endinteraction_85 As String
    Dim Interaction_85 As String
    Dim Target1_85 As String
    Dim Target2_85 As String
    Dim Emotion_86 As String
    Dim Endinteraction_86 As String
    Dim Interaction_86 As String
    Dim Target1_86 As String
    Dim Target2_86 As String
    Dim Emotion_87 As String
    Dim Endinteraction_87 As String
    Dim Interaction_87 As String
    Dim Target1_87 As String
    Dim Target2_87 As String
    Dim Emotion_88 As String
    Dim Endinteraction_88 As String
    Dim Interaction_88 As String
    Dim Target1_88 As String
    Dim Target2_88 As String
    Dim Emotion_89 As String
    Dim Endinteraction_89 As String
    Dim Interaction_89 As String
    Dim Target1_89 As String
    Dim Target2_89 As String
    Dim Emotion_90 As String
    Dim Endinteraction_90 As String
    Dim Interaction_90 As String
    Dim Target1_90 As String
    Dim Target2_90 As String
    Dim Emotion_91 As String
    Dim Endinteraction_91 As String
    Dim Interaction_91 As String
    Dim Target1_91 As String
    Dim Target2_91 As String
    Dim Emotion_92 As String
    Dim Endinteraction_92 As String
    Dim Interaction_92 As String
    Dim Target1_92 As String
    Dim Target2_92 As String
    Dim Emotion_93 As String
    Dim Endinteraction_93 As String
    Dim Interaction_93 As String
    Dim Target1_93 As String
    Dim Target2_93 As String
    Dim Emotion_94 As String
    Dim Endinteraction_94 As String
    Dim Interaction_94 As String
    Dim Target1_94 As String
    Dim Target2_94 As String
    Dim Emotion_95 As String
    Dim Endinteraction_95 As String
    Dim Interaction_95 As String
    Dim Target1_95 As String
    Dim Target2_95 As String
    Dim Emotion_96 As String
    Dim Endinteraction_96 As String
    Dim Interaction_96 As String
    Dim Target1_96 As String
    Dim Target2_96 As String
    Dim Emotion_97 As String
    Dim Endinteraction_97 As String
    Dim Interaction_97 As String
    Dim Target1_97 As String
    Dim Target2_97 As String
    Dim Emotion_98 As String
    Dim Endinteraction_98 As String
    Dim Interaction_98 As String
    Dim Target1_98 As String
    Dim Target2_98 As String
    Dim Emotion_99 As String
    Dim Endinteraction_99 As String
    Dim Interaction_99 As String
    Dim Target1_99 As String
    Dim Target2_99 As String
    Dim Emotion_100 As String
    Dim Endinteraction_100 As String
    Dim Interaction_100 As String
    Dim Target1_100 As String
    Dim Target2_100 As String

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
        Savefileregion()
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Case &H149 To &H14B, &H14D, &H14E, &H153, &H158 To &H15B, &H176 To &H17A, &H170
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
            Select_target1.Items.Item(1) = Select_mii.Items.Item(0)
            Select_target1.Items.Item(2) = Select_mii.Items.Item(1)
            Select_target1.Items.Item(3) = Select_mii.Items.Item(2)
            Select_target1.Items.Item(4) = Select_mii.Items.Item(3)
            Select_target1.Items.Item(5) = Select_mii.Items.Item(4)
            Select_target1.Items.Item(6) = Select_mii.Items.Item(5)
            Select_target1.Items.Item(7) = Select_mii.Items.Item(6)
            Select_target1.Items.Item(8) = Select_mii.Items.Item(7)
            Select_target1.Items.Item(9) = Select_mii.Items.Item(8)
            Select_target1.Items.Item(10) = Select_mii.Items.Item(9)
            Select_target1.Items.Item(11) = Select_mii.Items.Item(10)
            Select_target1.Items.Item(12) = Select_mii.Items.Item(11)
            Select_target1.Items.Item(13) = Select_mii.Items.Item(12)
            Select_target1.Items.Item(14) = Select_mii.Items.Item(13)
            Select_target1.Items.Item(15) = Select_mii.Items.Item(14)
            Select_target1.Items.Item(16) = Select_mii.Items.Item(15)
            Select_target1.Items.Item(17) = Select_mii.Items.Item(16)
            Select_target1.Items.Item(18) = Select_mii.Items.Item(17)
            Select_target1.Items.Item(19) = Select_mii.Items.Item(18)
            Select_target1.Items.Item(20) = Select_mii.Items.Item(19)
            Select_target1.Items.Item(21) = Select_mii.Items.Item(20)
            Select_target1.Items.Item(22) = Select_mii.Items.Item(21)
            Select_target1.Items.Item(23) = Select_mii.Items.Item(22)
            Select_target1.Items.Item(24) = Select_mii.Items.Item(23)
            Select_target1.Items.Item(25) = Select_mii.Items.Item(24)
            Select_target1.Items.Item(26) = Select_mii.Items.Item(25)
            Select_target1.Items.Item(27) = Select_mii.Items.Item(26)
            Select_target1.Items.Item(28) = Select_mii.Items.Item(27)
            Select_target1.Items.Item(29) = Select_mii.Items.Item(28)
            Select_target1.Items.Item(30) = Select_mii.Items.Item(29)
            Select_target1.Items.Item(31) = Select_mii.Items.Item(30)
            Select_target1.Items.Item(32) = Select_mii.Items.Item(31)
            Select_target1.Items.Item(33) = Select_mii.Items.Item(32)
            Select_target1.Items.Item(34) = Select_mii.Items.Item(33)
            Select_target1.Items.Item(35) = Select_mii.Items.Item(34)
            Select_target1.Items.Item(36) = Select_mii.Items.Item(35)
            Select_target1.Items.Item(37) = Select_mii.Items.Item(36)
            Select_target1.Items.Item(38) = Select_mii.Items.Item(37)
            Select_target1.Items.Item(39) = Select_mii.Items.Item(38)
            Select_target1.Items.Item(40) = Select_mii.Items.Item(39)
            Select_target1.Items.Item(41) = Select_mii.Items.Item(40)
            Select_target1.Items.Item(42) = Select_mii.Items.Item(41)
            Select_target1.Items.Item(43) = Select_mii.Items.Item(42)
            Select_target1.Items.Item(44) = Select_mii.Items.Item(43)
            Select_target1.Items.Item(45) = Select_mii.Items.Item(44)
            Select_target1.Items.Item(46) = Select_mii.Items.Item(45)
            Select_target1.Items.Item(47) = Select_mii.Items.Item(46)
            Select_target1.Items.Item(48) = Select_mii.Items.Item(47)
            Select_target1.Items.Item(49) = Select_mii.Items.Item(48)
            Select_target1.Items.Item(50) = Select_mii.Items.Item(49)
            Select_target1.Items.Item(51) = Select_mii.Items.Item(50)
            Select_target1.Items.Item(52) = Select_mii.Items.Item(51)
            Select_target1.Items.Item(53) = Select_mii.Items.Item(52)
            Select_target1.Items.Item(54) = Select_mii.Items.Item(53)
            Select_target1.Items.Item(55) = Select_mii.Items.Item(54)
            Select_target1.Items.Item(56) = Select_mii.Items.Item(55)
            Select_target1.Items.Item(57) = Select_mii.Items.Item(56)
            Select_target1.Items.Item(58) = Select_mii.Items.Item(57)
            Select_target1.Items.Item(59) = Select_mii.Items.Item(58)
            Select_target1.Items.Item(60) = Select_mii.Items.Item(59)
            Select_target1.Items.Item(61) = Select_mii.Items.Item(60)
            Select_target1.Items.Item(62) = Select_mii.Items.Item(61)
            Select_target1.Items.Item(63) = Select_mii.Items.Item(62)
            Select_target1.Items.Item(64) = Select_mii.Items.Item(63)
            Select_target1.Items.Item(65) = Select_mii.Items.Item(64)
            Select_target1.Items.Item(66) = Select_mii.Items.Item(65)
            Select_target1.Items.Item(67) = Select_mii.Items.Item(66)
            Select_target1.Items.Item(68) = Select_mii.Items.Item(67)
            Select_target1.Items.Item(69) = Select_mii.Items.Item(68)
            Select_target1.Items.Item(70) = Select_mii.Items.Item(69)
            Select_target1.Items.Item(71) = Select_mii.Items.Item(70)
            Select_target1.Items.Item(72) = Select_mii.Items.Item(71)
            Select_target1.Items.Item(73) = Select_mii.Items.Item(72)
            Select_target1.Items.Item(74) = Select_mii.Items.Item(73)
            Select_target1.Items.Item(75) = Select_mii.Items.Item(74)
            Select_target1.Items.Item(76) = Select_mii.Items.Item(75)
            Select_target1.Items.Item(77) = Select_mii.Items.Item(76)
            Select_target1.Items.Item(78) = Select_mii.Items.Item(77)
            Select_target1.Items.Item(79) = Select_mii.Items.Item(78)
            Select_target1.Items.Item(80) = Select_mii.Items.Item(79)
            Select_target1.Items.Item(81) = Select_mii.Items.Item(80)
            Select_target1.Items.Item(82) = Select_mii.Items.Item(81)
            Select_target1.Items.Item(83) = Select_mii.Items.Item(82)
            Select_target1.Items.Item(84) = Select_mii.Items.Item(83)
            Select_target1.Items.Item(85) = Select_mii.Items.Item(84)
            Select_target1.Items.Item(86) = Select_mii.Items.Item(85)
            Select_target1.Items.Item(87) = Select_mii.Items.Item(86)
            Select_target1.Items.Item(88) = Select_mii.Items.Item(87)
            Select_target1.Items.Item(89) = Select_mii.Items.Item(88)
            Select_target1.Items.Item(90) = Select_mii.Items.Item(89)
            Select_target1.Items.Item(91) = Select_mii.Items.Item(90)
            Select_target1.Items.Item(92) = Select_mii.Items.Item(91)
            Select_target1.Items.Item(93) = Select_mii.Items.Item(92)
            Select_target1.Items.Item(94) = Select_mii.Items.Item(93)
            Select_target1.Items.Item(95) = Select_mii.Items.Item(94)
            Select_target1.Items.Item(96) = Select_mii.Items.Item(95)
            Select_target1.Items.Item(97) = Select_mii.Items.Item(96)
            Select_target1.Items.Item(98) = Select_mii.Items.Item(97)
            Select_target1.Items.Item(99) = Select_mii.Items.Item(98)
            Select_target1.Items.Item(100) = Select_mii.Items.Item(99)
            Select_target2.Items.Item(1) = Select_mii.Items.Item(0)
            Select_target2.Items.Item(2) = Select_mii.Items.Item(1)
            Select_target2.Items.Item(3) = Select_mii.Items.Item(2)
            Select_target2.Items.Item(4) = Select_mii.Items.Item(3)
            Select_target2.Items.Item(5) = Select_mii.Items.Item(4)
            Select_target2.Items.Item(6) = Select_mii.Items.Item(5)
            Select_target2.Items.Item(7) = Select_mii.Items.Item(6)
            Select_target2.Items.Item(8) = Select_mii.Items.Item(7)
            Select_target2.Items.Item(9) = Select_mii.Items.Item(8)
            Select_target2.Items.Item(10) = Select_mii.Items.Item(9)
            Select_target2.Items.Item(11) = Select_mii.Items.Item(10)
            Select_target2.Items.Item(12) = Select_mii.Items.Item(11)
            Select_target2.Items.Item(13) = Select_mii.Items.Item(12)
            Select_target2.Items.Item(14) = Select_mii.Items.Item(13)
            Select_target2.Items.Item(15) = Select_mii.Items.Item(14)
            Select_target2.Items.Item(16) = Select_mii.Items.Item(15)
            Select_target2.Items.Item(17) = Select_mii.Items.Item(16)
            Select_target2.Items.Item(18) = Select_mii.Items.Item(17)
            Select_target2.Items.Item(19) = Select_mii.Items.Item(18)
            Select_target2.Items.Item(20) = Select_mii.Items.Item(19)
            Select_target2.Items.Item(21) = Select_mii.Items.Item(20)
            Select_target2.Items.Item(22) = Select_mii.Items.Item(21)
            Select_target2.Items.Item(23) = Select_mii.Items.Item(22)
            Select_target2.Items.Item(24) = Select_mii.Items.Item(23)
            Select_target2.Items.Item(25) = Select_mii.Items.Item(24)
            Select_target2.Items.Item(26) = Select_mii.Items.Item(25)
            Select_target2.Items.Item(27) = Select_mii.Items.Item(26)
            Select_target2.Items.Item(28) = Select_mii.Items.Item(27)
            Select_target2.Items.Item(29) = Select_mii.Items.Item(28)
            Select_target2.Items.Item(30) = Select_mii.Items.Item(29)
            Select_target2.Items.Item(31) = Select_mii.Items.Item(30)
            Select_target2.Items.Item(32) = Select_mii.Items.Item(31)
            Select_target2.Items.Item(33) = Select_mii.Items.Item(32)
            Select_target2.Items.Item(34) = Select_mii.Items.Item(33)
            Select_target2.Items.Item(35) = Select_mii.Items.Item(34)
            Select_target2.Items.Item(36) = Select_mii.Items.Item(35)
            Select_target2.Items.Item(37) = Select_mii.Items.Item(36)
            Select_target2.Items.Item(38) = Select_mii.Items.Item(37)
            Select_target2.Items.Item(39) = Select_mii.Items.Item(38)
            Select_target2.Items.Item(40) = Select_mii.Items.Item(39)
            Select_target2.Items.Item(41) = Select_mii.Items.Item(40)
            Select_target2.Items.Item(42) = Select_mii.Items.Item(41)
            Select_target2.Items.Item(43) = Select_mii.Items.Item(42)
            Select_target2.Items.Item(44) = Select_mii.Items.Item(43)
            Select_target2.Items.Item(45) = Select_mii.Items.Item(44)
            Select_target2.Items.Item(46) = Select_mii.Items.Item(45)
            Select_target2.Items.Item(47) = Select_mii.Items.Item(46)
            Select_target2.Items.Item(48) = Select_mii.Items.Item(47)
            Select_target2.Items.Item(49) = Select_mii.Items.Item(48)
            Select_target2.Items.Item(50) = Select_mii.Items.Item(49)
            Select_target2.Items.Item(51) = Select_mii.Items.Item(50)
            Select_target2.Items.Item(52) = Select_mii.Items.Item(51)
            Select_target2.Items.Item(53) = Select_mii.Items.Item(52)
            Select_target2.Items.Item(54) = Select_mii.Items.Item(53)
            Select_target2.Items.Item(55) = Select_mii.Items.Item(54)
            Select_target2.Items.Item(56) = Select_mii.Items.Item(55)
            Select_target2.Items.Item(57) = Select_mii.Items.Item(56)
            Select_target2.Items.Item(58) = Select_mii.Items.Item(57)
            Select_target2.Items.Item(59) = Select_mii.Items.Item(58)
            Select_target2.Items.Item(60) = Select_mii.Items.Item(59)
            Select_target2.Items.Item(61) = Select_mii.Items.Item(60)
            Select_target2.Items.Item(62) = Select_mii.Items.Item(61)
            Select_target2.Items.Item(63) = Select_mii.Items.Item(62)
            Select_target2.Items.Item(64) = Select_mii.Items.Item(63)
            Select_target2.Items.Item(65) = Select_mii.Items.Item(64)
            Select_target2.Items.Item(66) = Select_mii.Items.Item(65)
            Select_target2.Items.Item(67) = Select_mii.Items.Item(66)
            Select_target2.Items.Item(68) = Select_mii.Items.Item(67)
            Select_target2.Items.Item(69) = Select_mii.Items.Item(68)
            Select_target2.Items.Item(70) = Select_mii.Items.Item(69)
            Select_target2.Items.Item(71) = Select_mii.Items.Item(70)
            Select_target2.Items.Item(72) = Select_mii.Items.Item(71)
            Select_target2.Items.Item(73) = Select_mii.Items.Item(72)
            Select_target2.Items.Item(74) = Select_mii.Items.Item(73)
            Select_target2.Items.Item(75) = Select_mii.Items.Item(74)
            Select_target2.Items.Item(76) = Select_mii.Items.Item(75)
            Select_target2.Items.Item(77) = Select_mii.Items.Item(76)
            Select_target2.Items.Item(78) = Select_mii.Items.Item(77)
            Select_target2.Items.Item(79) = Select_mii.Items.Item(78)
            Select_target2.Items.Item(80) = Select_mii.Items.Item(79)
            Select_target2.Items.Item(81) = Select_mii.Items.Item(80)
            Select_target2.Items.Item(82) = Select_mii.Items.Item(81)
            Select_target2.Items.Item(83) = Select_mii.Items.Item(82)
            Select_target2.Items.Item(84) = Select_mii.Items.Item(83)
            Select_target2.Items.Item(85) = Select_mii.Items.Item(84)
            Select_target2.Items.Item(86) = Select_mii.Items.Item(85)
            Select_target2.Items.Item(87) = Select_mii.Items.Item(86)
            Select_target2.Items.Item(88) = Select_mii.Items.Item(87)
            Select_target2.Items.Item(89) = Select_mii.Items.Item(88)
            Select_target2.Items.Item(90) = Select_mii.Items.Item(89)
            Select_target2.Items.Item(91) = Select_mii.Items.Item(90)
            Select_target2.Items.Item(92) = Select_mii.Items.Item(91)
            Select_target2.Items.Item(93) = Select_mii.Items.Item(92)
            Select_target2.Items.Item(94) = Select_mii.Items.Item(93)
            Select_target2.Items.Item(95) = Select_mii.Items.Item(94)
            Select_target2.Items.Item(96) = Select_mii.Items.Item(95)
            Select_target2.Items.Item(97) = Select_mii.Items.Item(96)
            Select_target2.Items.Item(98) = Select_mii.Items.Item(97)
            Select_target2.Items.Item(99) = Select_mii.Items.Item(98)
            Select_target2.Items.Item(100) = Select_mii.Items.Item(99)
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

    Private Sub valu_interaction_ValueChanged(sender As Object, e As EventArgs) Handles valu_interaction.ValueChanged
        If Filever_text.Text = "EU" Then
            InteractionlistEUR()
            InteractionlistEUR()
        ElseIf Filever_text.Text = "US" Then
            'InteractionlistUSA()
            InteractionlistEUR()
            InteractionlistEUR()
        ElseIf Filever_text.Text = "JP" Then
            InteractionlistJPN()
        ElseIf Filever_text.Text = "KR" Then
            InteractionlistKOR()
        End If
    End Sub

    Public Sub InteractionlistEUR()
        infobubble_interaction.Visible = False
        infobubble_target1.Visible = False
        infobubble_target2.Visible = False
        Select_target1.Visible = False
        Select_target2.Visible = False
        valu_target1.Visible = True
        valu_target2.Visible = True
        If valu_interaction.Value = &H0 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(0)
            Icon_interaction.Image = My.Resources.icon_interaction_none
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H100 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(1)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H101 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(2)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a food"
            Text_infobubble_target1.Text = "If foods aren't listed in your region, edit as you want"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H102 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(3)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H103 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(4)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H104 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(5)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H105 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(6)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H106 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(7)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H107 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(8)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H108 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(9)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H109 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(10)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H10A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(11)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H10B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(12)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H10C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(13)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H10D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(14)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H10E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(15)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H10F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(16)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H110 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(17)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H111 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(18)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H112 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(19)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H113 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(20)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H114 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(21)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H115 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(22)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H116 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(23)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H117 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(24)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H118 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(25)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H119 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(26)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Mii want to eat something but say nothing"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H11A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(27)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Mii want to eat something but say nothing"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H11B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(28)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H11C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(29)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H11D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(30)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H11E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(31)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H11F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(32)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Mii want to eat something but say nothing"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H120 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(33)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H121 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(34)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H122 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(35)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H123 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(36)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H124 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(37)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H125 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(38)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H126 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(39)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a clothe"
            Text_infobubble_target1.Text = "If clothes aren't listed in your region, edit as you want"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H127 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(40)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H128 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(41)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H129 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(42)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H12A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(43)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H12B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(44)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H12C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(45)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H12D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(46)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H12E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(47)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H12F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(48)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H130 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(49)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H131 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(50)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H132 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(51)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H133 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(52)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H134 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(53)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H135 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(54)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H136 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(55)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H137 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(56)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a hat"
            Text_infobubble_target1.Text = "If hats aren't listed in your region, edit as you want"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H138 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(57)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H139 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(58)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H13A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(59)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H13B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(60)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H13C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(61)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H13D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(62)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H13E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(63)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H13F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(64)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H140 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(65)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H141 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(66)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H142 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(67)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H143 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(68)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H144 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(69)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H145 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(70)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H146 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(71)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H147 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(72)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H148 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(73)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H149 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(74)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "Select a 'unknow' Mii"
            Text_infobubble_target1.Text = "Must be 'unknow' with this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "Interaction not show if : target 1 is not a 'unknow' Mii" & vbNewLine & vbNewLine & "Tricks : Mii can be friend with himself or with a not existed Mii"
        ElseIf valu_interaction.Value = &H14A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(75)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "Select a 'unknow' Mii"
            Text_infobubble_target1.Text = "Must be 'unknow' with this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "Interaction not show if : target 1 is not a 'unknow' Mii" & vbNewLine & vbNewLine & "Tricks : Mii can be friend with himself or with a not existed Mii"
        ElseIf valu_interaction.Value = &H14B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(76)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 1
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            infobubble_target2.Visible = True
            Text_infobubble_interaction.Text = "Select 2 'friend' Mii"
            Text_infobubble_target1.Text = "Must be 'unknow' with target 2 and 'friend' with this Mii"
            Text_infobubble_target2.Text = "Must be 'unknow' with target 1 and 'friend' with this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Select_target2.Visible = True
            valu_target2.Visible = False
            Text_interacconditions.Text = "Interaction not show if : target 1 and target 2 are 'unknow' and this Mii are friend with target 1 and target 2" & vbNewLine & vbNewLine & "Tricks : if this Mii have a not existed Mii in friend, you can select him as target"
        ElseIf valu_interaction.Value = &H14C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(77)
            Icon_interaction.Image = My.Resources.icon_interaction_pink
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Text_infobubble_target1.Text = "Must don't have special someone"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "Interaction not show if : this Mii or target have a special someone" & vbNewLine & "target have don't same age group (EUR and USA version)" & vbNewLine & "this Mii and target have same gender"
        ElseIf valu_interaction.Value = &H14D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(78)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Text_infobubble_target1.Text = "Must don't have special someone ?"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H14E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(79)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 0
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            infobubble_target2.Visible = True
            Text_infobubble_interaction.Text = "You must select 2 'friend' Mii"
            Text_infobubble_target1.Text = "Must be friend with target 2"
            Text_infobubble_target2.Text = "Must be friend with target 1"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Select_target2.Visible = True
            valu_target2.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H14F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(80)
            Icon_interaction.Image = My.Resources.icon_interaction_pink
            valu_target1.Value = 0
            valu_target2.Value = 0
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            infobubble_target2.Visible = True
            Text_infobubble_interaction.Text = "You must select 2 'friend' Mii"
            Text_infobubble_target1.Text = "Must be friend with target 2"
            Text_infobubble_target2.Text = "Must be friend with target 1"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Select_target2.Visible = True
            valu_target2.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H150 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(81)
            Icon_interaction.Image = My.Resources.icon_interaction_pink
            valu_target1.Value = 0
            valu_target2.Value = 0
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            infobubble_target2.Visible = True
            Text_infobubble_interaction.Text = "You must select 2 'friend' Mii"
            Text_infobubble_target1.Text = "Must be opposite sex  with this Mii"
            Text_infobubble_target2.Text = "Must be opposite sex  with this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Select_target2.Visible = True
            valu_target2.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H151 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(82)
            Icon_interaction.Image = My.Resources.icon_interaction_pink
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "If this interaction is detected and worked, extract and share him on Tomodachi Life Save Editor page"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H152 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(83)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "If this interaction is detected and worked, extract and share him on Tomodachi Life Save Editor page"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H153 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(84)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'special someone' Mii"
            Text_infobubble_target1.Text = "Must have this Mii in special someone"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H154 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(85)
            Icon_interaction.Image = My.Resources.icon_interaction_pink
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'lover' Mii"
            Text_infobubble_target1.Text = "Must don't have special someone"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H155 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(86)
            Icon_interaction.Image = My.Resources.icon_interaction_pink
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'spouse' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H156 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(87)
            Icon_interaction.Image = My.Resources.icon_interaction_phone
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "Select a 'spouse' Mii / Babies must be enabled in Tomodachi Life"
            Text_infobubble_target1.Text = "Must have same interaction, target this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "Can work or not for unknown reason, can cause infinite baby born"
        ElseIf valu_interaction.Value = &H157 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(88)
            Icon_interaction.Image = My.Resources.icon_interaction_phone
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "Select a 'spouse' Mii / Babies must be enabled in Tomodachi Life"
            Text_infobubble_target1.Text = "Must have same interaction, target this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "This interaction can cause infinite baby grown"
        ElseIf valu_interaction.Value = &H158 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(89)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Text_infobubble_target1.Text = "Need to have same interaction, target this Mii / can not have interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H159 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(90)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Text_infobubble_target1.Text = "Need to have same interaction, target this Mii / can not have interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H15A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(91)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 0
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            infobubble_target2.Visible = True
            Text_infobubble_interaction.Text = "You must select a 2 'friend' Mii"
            Text_infobubble_target1.Text = "Need to be friend in conflict with target 2"
            Text_infobubble_target2.Text = "Need to be friend in conflict with target 1"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Select_target2.Visible = True
            valu_target2.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H15B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(92)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend in conflict' Mii"
            Text_infobubble_target1.Text = "Need to have friend in conflict interaction, target this Mii / can not have interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H15C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(93)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend in conflict' Mii"
            Text_infobubble_target1.Text = "Need to have interaction 'Life is tougher than I expected…', target this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H15D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(94)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a Mii / can select 'spouse'"
            Text_infobubble_target1.Text = "Can have interaction 'Divorce and break target's heart', target this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H15E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(95)
            Icon_interaction.Image = My.Resources.icon_interaction_tblue
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a Mii / can select 'spouse'"
            Text_infobubble_target1.Text = "Can have interaction 'Target : I'll never be able to get those happy times back again', target this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H15F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(96)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H160 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(97)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H161 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(98)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H162 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(99)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H163 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(100)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H164 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(101)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend in conflict' Mii"
            Text_infobubble_target1.Text = "Need to have interaction '_Won't make up with friend in conflict_', target this Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H165 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(102)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H166 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(103)
            Icon_interaction.Image = My.Resources.icon_interaction_blue
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H167 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(104)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H168 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(105)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H169 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(106)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H16A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(107)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H16B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(108)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H16C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(109)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 5
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H16D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(110)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 2
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H16E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(111)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 1
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H16F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(112)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 1
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H170 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(113)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 2
            valu_target2.Value = 65535
            infobubble_target1.Visible = True
            infobubble_target2.Visible = True
            Text_infobubble_target1.Text = "???"
            Text_infobubble_target2.Text = "Must be 'best friend' with this Mii"
            Select_target2.Visible = True
            valu_target2.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H171 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(114)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 1
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H172 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(115)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 1
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H173 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(116)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H174 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(117)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H175 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(118)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H176 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(119)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a Mii (a 'unknow' Mii ?)"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H177 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(120)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'friend' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H178 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(121)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'best friend' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H179 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(122)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'lover' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H17A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(123)
            Icon_interaction.Image = My.Resources.icon_interaction_orange
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'special someone' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H17B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(124)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H17C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(125)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H17D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(126)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H17E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(127)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H17F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(128)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H180 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(129)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H181 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(130)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H182 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(131)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H183 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(132)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H184 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(133)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H185 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(134)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H186 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(135)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "Travelers interaction, can cause infinite interaction"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H187 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(136)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H188 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(137)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 0
            valu_target2.Value = 0
            infobubble_interaction.Visible = True
            infobubble_target1.Visible = True
            infobubble_target2.Visible = True
            Text_infobubble_interaction.Text = "You must select a Mii (not unknow ?) and select an item lost"
            Text_infobubble_target1.Text = "Need to have same interaction, target this Mii"
            Text_infobubble_target2.Text = "You must select an item, if items aren't listed in your region, edit as you want"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H189 Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(138)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "If this interaction is detected and worked, extract and share him on Tomodachi Life Save Editor page"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H18A Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(139)
            Icon_interaction.Image = Nothing
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "If this interaction is detected and worked, extract and share him on Tomodachi Life Save Editor page"
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H18B Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(140)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H18C Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(141)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H18D Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(142)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'best friend' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H18E Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(143)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 0
            valu_target2.Value = 65535
            infobubble_interaction.Visible = True
            Text_infobubble_interaction.Text = "You must select a 'special someone' Mii"
            Select_target1.Visible = True
            valu_target1.Visible = False
            Text_interacconditions.Text = "-"
        ElseIf valu_interaction.Value = &H18F Then
            Select_interaction.SelectedItem = Select_interaction.Items.Item(144)
            Icon_interaction.Image = My.Resources.icon_interaction_black
            valu_target1.Value = 65535
            valu_target2.Value = 65535
            Text_interacconditions.Text = "-"
        Else
            Select_interaction.SelectedItem = Select_interaction.Items.Item(145)
            Icon_interaction.Image = My.Resources.icon_interaction_unknow
            Text_interacconditions.Text = "-"
        End If
    End Sub

    Public Sub InteractionlistUSA()

    End Sub
    Public Sub InteractionlistJPN()

    End Sub
    Public Sub InteractionlistKOR()

    End Sub

    Private Sub Select_interaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_interaction.SelectedIndexChanged
        If Select_interaction.SelectedItem = Select_interaction.Items.Item(0) Then
            valu_interaction.Value = &H0
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(1) Then
            valu_interaction.Value = &H100
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(2) Then
            valu_interaction.Value = &H101
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(3) Then
            valu_interaction.Value = &H102
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(4) Then
            valu_interaction.Value = &H103
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(5) Then
            valu_interaction.Value = &H104
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(6) Then
            valu_interaction.Value = &H105
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(7) Then
            valu_interaction.Value = &H106
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(8) Then
            valu_interaction.Value = &H107
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(9) Then
            valu_interaction.Value = &H108
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(10) Then
            valu_interaction.Value = &H109
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(11) Then
            valu_interaction.Value = &H10A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(12) Then
            valu_interaction.Value = &H10B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(13) Then
            valu_interaction.Value = &H10C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(14) Then
            valu_interaction.Value = &H10D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(15) Then
            valu_interaction.Value = &H10E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(16) Then
            valu_interaction.Value = &H10F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(17) Then
            valu_interaction.Value = &H110
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(18) Then
            valu_interaction.Value = &H111
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(19) Then
            valu_interaction.Value = &H112
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(20) Then
            valu_interaction.Value = &H113
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(21) Then
            valu_interaction.Value = &H114
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(22) Then
            valu_interaction.Value = &H115
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(23) Then
            valu_interaction.Value = &H116
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(24) Then
            valu_interaction.Value = &H117
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(25) Then
            valu_interaction.Value = &H118
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(26) Then
            valu_interaction.Value = &H119
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(27) Then
            valu_interaction.Value = &H11A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(28) Then
            valu_interaction.Value = &H11B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(29) Then
            valu_interaction.Value = &H11C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(30) Then
            valu_interaction.Value = &H11D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(31) Then
            valu_interaction.Value = &H11E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(32) Then
            valu_interaction.Value = &H11F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(33) Then
            valu_interaction.Value = &H120
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(34) Then
            valu_interaction.Value = &H121
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(35) Then
            valu_interaction.Value = &H122
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(36) Then
            valu_interaction.Value = &H123
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(37) Then
            valu_interaction.Value = &H124
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(38) Then
            valu_interaction.Value = &H125
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(39) Then
            valu_interaction.Value = &H126
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(40) Then
            valu_interaction.Value = &H127
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(41) Then
            valu_interaction.Value = &H128
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(42) Then
            valu_interaction.Value = &H129
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(43) Then
            valu_interaction.Value = &H12A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(44) Then
            valu_interaction.Value = &H12B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(45) Then
            valu_interaction.Value = &H12C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(46) Then
            valu_interaction.Value = &H12D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(47) Then
            valu_interaction.Value = &H12E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(48) Then
            valu_interaction.Value = &H12F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(49) Then
            valu_interaction.Value = &H130
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(50) Then
            valu_interaction.Value = &H131
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(51) Then
            valu_interaction.Value = &H132
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(52) Then
            valu_interaction.Value = &H133
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(53) Then
            valu_interaction.Value = &H134
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(54) Then
            valu_interaction.Value = &H135
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(55) Then
            valu_interaction.Value = &H136
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(56) Then
            valu_interaction.Value = &H137
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(57) Then
            valu_interaction.Value = &H138
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(58) Then
            valu_interaction.Value = &H139
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(59) Then
            valu_interaction.Value = &H13A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(60) Then
            valu_interaction.Value = &H13B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(61) Then
            valu_interaction.Value = &H13C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(62) Then
            valu_interaction.Value = &H13D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(63) Then
            valu_interaction.Value = &H13E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(64) Then
            valu_interaction.Value = &H13F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(65) Then
            valu_interaction.Value = &H140
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(66) Then
            valu_interaction.Value = &H141
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(67) Then
            valu_interaction.Value = &H142
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(68) Then
            valu_interaction.Value = &H143
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(69) Then
            valu_interaction.Value = &H144
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(70) Then
            valu_interaction.Value = &H145
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(71) Then
            valu_interaction.Value = &H146
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(72) Then
            valu_interaction.Value = &H147
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(73) Then
            valu_interaction.Value = &H148
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(74) Then
            valu_interaction.Value = &H149
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(75) Then
            valu_interaction.Value = &H14A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(76) Then
            valu_interaction.Value = &H14B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(77) Then
            valu_interaction.Value = &H14C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(78) Then
            valu_interaction.Value = &H14D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(79) Then
            valu_interaction.Value = &H14E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(80) Then
            valu_interaction.Value = &H14F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(81) Then
            valu_interaction.Value = &H150
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(82) Then
            valu_interaction.Value = &H151
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(83) Then
            valu_interaction.Value = &H152
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(84) Then
            valu_interaction.Value = &H153
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(85) Then
            valu_interaction.Value = &H154
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(86) Then
            valu_interaction.Value = &H155
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(87) Then
            valu_interaction.Value = &H156
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(88) Then
            valu_interaction.Value = &H157
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(89) Then
            valu_interaction.Value = &H158
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(90) Then
            valu_interaction.Value = &H159
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(91) Then
            valu_interaction.Value = &H15A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(92) Then
            valu_interaction.Value = &H15B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(93) Then
            valu_interaction.Value = &H15C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(94) Then
            valu_interaction.Value = &H15D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(95) Then
            valu_interaction.Value = &H15E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(96) Then
            valu_interaction.Value = &H15F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(97) Then
            valu_interaction.Value = &H160
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(98) Then
            valu_interaction.Value = &H161
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(99) Then
            valu_interaction.Value = &H162
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(100) Then
            valu_interaction.Value = &H163
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(101) Then
            valu_interaction.Value = &H164
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(102) Then
            valu_interaction.Value = &H165
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(103) Then
            valu_interaction.Value = &H166
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(104) Then
            valu_interaction.Value = &H167
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(105) Then
            valu_interaction.Value = &H168
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(106) Then
            valu_interaction.Value = &H169
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(107) Then
            valu_interaction.Value = &H16A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(108) Then
            valu_interaction.Value = &H16B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(109) Then
            valu_interaction.Value = &H16C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(110) Then
            valu_interaction.Value = &H16D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(111) Then
            valu_interaction.Value = &H16E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(112) Then
            valu_interaction.Value = &H16F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(113) Then
            valu_interaction.Value = &H170
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(114) Then
            valu_interaction.Value = &H171
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(115) Then
            valu_interaction.Value = &H172
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(116) Then
            valu_interaction.Value = &H173
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(117) Then
            valu_interaction.Value = &H174
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(118) Then
            valu_interaction.Value = &H175
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(119) Then
            valu_interaction.Value = &H176
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(120) Then
            valu_interaction.Value = &H177
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(121) Then
            valu_interaction.Value = &H178
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(122) Then
            valu_interaction.Value = &H179
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(123) Then
            valu_interaction.Value = &H17A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(124) Then
            valu_interaction.Value = &H17B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(125) Then
            valu_interaction.Value = &H17C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(126) Then
            valu_interaction.Value = &H17D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(127) Then
            valu_interaction.Value = &H17E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(128) Then
            valu_interaction.Value = &H17F
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(129) Then
            valu_interaction.Value = &H180
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(130) Then
            valu_interaction.Value = &H181
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(131) Then
            valu_interaction.Value = &H182
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(132) Then
            valu_interaction.Value = &H183
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(133) Then
            valu_interaction.Value = &H184
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(134) Then
            valu_interaction.Value = &H185
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(135) Then
            valu_interaction.Value = &H186
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(136) Then
            valu_interaction.Value = &H187
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(137) Then
            valu_interaction.Value = &H188
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(138) Then
            valu_interaction.Value = &H189
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(139) Then
            valu_interaction.Value = &H18A
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(140) Then
            valu_interaction.Value = &H18B
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(141) Then
            valu_interaction.Value = &H18C
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(142) Then
            valu_interaction.Value = &H18D
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(143) Then
            valu_interaction.Value = &H18E
        ElseIf Select_interaction.SelectedItem = Select_interaction.Items.Item(144) Then
            valu_interaction.Value = &H18F
        End If
    End Sub

    Public Sub Savefileregion()
        If Filever_text.Text = "JP" Then
            Emotion_1 = &H1E2C
            Endinteraction_1 = &H24948
            Interaction_1 = &H24950
            Target1_1 = &H24954
            Target2_1 = &H24956
            Emotion_2 = &H23BC
            Endinteraction_2 = &H24A48
            Interaction_2 = &H24A50
            Target1_2 = &H24A54
            Target2_2 = &H24A56
            Emotion_3 = &H294C
            Endinteraction_3 = &H24B48
            Interaction_3 = &H24B50
            Target1_3 = &H24B54
            Target2_3 = &H24B56
            Emotion_4 = &H2EDC
            Endinteraction_4 = &H24C48
            Interaction_4 = &H24C50
            Target1_4 = &H24C54
            Target2_4 = &H24C56
            Emotion_5 = &H346C
            Endinteraction_5 = &H24D48
            Interaction_5 = &H24D50
            Target1_5 = &H24D54
            Target2_5 = &H24D56
            Emotion_6 = &H39FC
            Endinteraction_6 = &H24E48
            Interaction_6 = &H24E50
            Target1_6 = &H24E54
            Target2_6 = &H24E56
            Emotion_7 = &H3F8C
            Endinteraction_7 = &H24F48
            Interaction_7 = &H24F50
            Target1_7 = &H24F54
            Target2_7 = &H24F56
            Emotion_8 = &H451C
            Endinteraction_8 = &H25048
            Interaction_8 = &H25050
            Target1_8 = &H25054
            Target2_8 = &H25056
            Emotion_9 = &H4AAC
            Endinteraction_9 = &H25148
            Interaction_9 = &H25150
            Target1_9 = &H25154
            Target2_9 = &H25156
            Emotion_10 = &H503C
            Endinteraction_10 = &H25248
            Interaction_10 = &H25250
            Target1_10 = &H25254
            Target2_10 = &H25256
            Emotion_11 = &H55CC
            Endinteraction_11 = &H25348
            Interaction_11 = &H25350
            Target1_11 = &H25354
            Target2_11 = &H25356
            Emotion_12 = &H5B5C
            Endinteraction_12 = &H25448
            Interaction_12 = &H25450
            Target1_12 = &H25454
            Target2_12 = &H25456
            Emotion_13 = &H60EC
            Endinteraction_13 = &H25548
            Interaction_13 = &H25550
            Target1_13 = &H25554
            Target2_13 = &H25556
            Emotion_14 = &H667C
            Endinteraction_14 = &H25648
            Interaction_14 = &H25650
            Target1_14 = &H25654
            Target2_14 = &H25656
            Emotion_15 = &H6C0C
            Endinteraction_15 = &H25748
            Interaction_15 = &H25750
            Target1_15 = &H25754
            Target2_15 = &H25756
            Emotion_16 = &H719C
            Endinteraction_16 = &H25848
            Interaction_16 = &H25850
            Target1_16 = &H25854
            Target2_16 = &H25856
            Emotion_17 = &H772C
            Endinteraction_17 = &H25948
            Interaction_17 = &H25950
            Target1_17 = &H25954
            Target2_17 = &H25956
            Emotion_18 = &H7CBC
            Endinteraction_18 = &H25A48
            Interaction_18 = &H25A50
            Target1_18 = &H25A54
            Target2_18 = &H25A56
            Emotion_19 = &H824C
            Endinteraction_19 = &H25B48
            Interaction_19 = &H25B50
            Target1_19 = &H25B54
            Target2_19 = &H25B56
            Emotion_20 = &H87DC
            Endinteraction_20 = &H25C48
            Interaction_20 = &H25C50
            Target1_20 = &H25C54
            Target2_20 = &H25C56
            Emotion_21 = &H8D6C
            Endinteraction_21 = &H25D48
            Interaction_21 = &H25D50
            Target1_21 = &H25D54
            Target2_21 = &H25D56
            Emotion_22 = &H92FC
            Endinteraction_22 = &H25E48
            Interaction_22 = &H25E50
            Target1_22 = &H25E54
            Target2_22 = &H25E56
            Emotion_23 = &H988C
            Endinteraction_23 = &H25F48
            Interaction_23 = &H25F50
            Target1_23 = &H25F54
            Target2_23 = &H25F56
            Emotion_24 = &H9E1C
            Endinteraction_24 = &H26048
            Interaction_24 = &H26050
            Target1_24 = &H26054
            Target2_24 = &H26056
            Emotion_25 = &HA3AC
            Endinteraction_25 = &H26148
            Interaction_25 = &H26150
            Target1_25 = &H26154
            Target2_25 = &H26156
            Emotion_26 = &HA93C
            Endinteraction_26 = &H26248
            Interaction_26 = &H26250
            Target1_26 = &H26254
            Target2_26 = &H26256
            Emotion_27 = &HAECC
            Endinteraction_27 = &H26348
            Interaction_27 = &H26350
            Target1_27 = &H26354
            Target2_27 = &H26356
            Emotion_28 = &HB45C
            Endinteraction_28 = &H26448
            Interaction_28 = &H26450
            Target1_28 = &H26454
            Target2_28 = &H26456
            Emotion_29 = &HB9EC
            Endinteraction_29 = &H26548
            Interaction_29 = &H26550
            Target1_29 = &H26554
            Target2_29 = &H26556
            Emotion_30 = &HBF7C
            Endinteraction_30 = &H26648
            Interaction_30 = &H26650
            Target1_30 = &H26654
            Target2_30 = &H26656
            Emotion_31 = &HC50C
            Endinteraction_31 = &H26748
            Interaction_31 = &H26750
            Target1_31 = &H26754
            Target2_31 = &H26756
            Emotion_32 = &HCA9C
            Endinteraction_32 = &H26848
            Interaction_32 = &H26850
            Target1_32 = &H26854
            Target2_32 = &H26856
            Emotion_33 = &HD02C
            Endinteraction_33 = &H26948
            Interaction_33 = &H26950
            Target1_33 = &H26954
            Target2_33 = &H26956
            Emotion_34 = &HD5BC
            Endinteraction_34 = &H26A48
            Interaction_34 = &H26A50
            Target1_34 = &H26A54
            Target2_34 = &H26A56
            Emotion_35 = &HDB4C
            Endinteraction_35 = &H26B48
            Interaction_35 = &H26B50
            Target1_35 = &H26B54
            Target2_35 = &H26B56
            Emotion_36 = &HE0DC
            Endinteraction_36 = &H26C48
            Interaction_36 = &H26C50
            Target1_36 = &H26C54
            Target2_36 = &H26C56
            Emotion_37 = &HE66C
            Endinteraction_37 = &H26D48
            Interaction_37 = &H26D50
            Target1_37 = &H26D54
            Target2_37 = &H26D56
            Emotion_38 = &HEBFC
            Endinteraction_38 = &H26E48
            Interaction_38 = &H26E50
            Target1_38 = &H26E54
            Target2_38 = &H26E56
            Emotion_39 = &HF18C
            Endinteraction_39 = &H26F48
            Interaction_39 = &H26F50
            Target1_39 = &H26F54
            Target2_39 = &H26F56
            Emotion_40 = &HF71C
            Endinteraction_40 = &H27048
            Interaction_40 = &H27050
            Target1_40 = &H27054
            Target2_40 = &H27056
            Emotion_41 = &HFCAC
            Endinteraction_41 = &H27148
            Interaction_41 = &H27150
            Target1_41 = &H27154
            Target2_41 = &H27156
            Emotion_42 = &H1023C
            Endinteraction_42 = &H27248
            Interaction_42 = &H27250
            Target1_42 = &H27254
            Target2_42 = &H27256
            Emotion_43 = &H107CC
            Endinteraction_43 = &H27348
            Interaction_43 = &H27350
            Target1_43 = &H27354
            Target2_43 = &H27356
            Emotion_44 = &H10D5C
            Endinteraction_44 = &H27448
            Interaction_44 = &H27450
            Target1_44 = &H27454
            Target2_44 = &H27456
            Emotion_45 = &H112EC
            Endinteraction_45 = &H27548
            Interaction_45 = &H27550
            Target1_45 = &H27554
            Target2_45 = &H27556
            Emotion_46 = &H1187C
            Endinteraction_46 = &H27648
            Interaction_46 = &H27650
            Target1_46 = &H27654
            Target2_46 = &H27656
            Emotion_47 = &H11E0C
            Endinteraction_47 = &H27748
            Interaction_47 = &H27750
            Target1_47 = &H27754
            Target2_47 = &H27756
            Emotion_48 = &H1239C
            Endinteraction_48 = &H27848
            Interaction_48 = &H27850
            Target1_48 = &H27854
            Target2_48 = &H27856
            Emotion_49 = &H1292C
            Endinteraction_49 = &H27948
            Interaction_49 = &H27950
            Target1_49 = &H27954
            Target2_49 = &H27956
            Emotion_50 = &H12EBC
            Endinteraction_50 = &H27A48
            Interaction_50 = &H27A50
            Target1_50 = &H27A54
            Target2_50 = &H27A56
            Emotion_51 = &H1344C
            Endinteraction_51 = &H27B48
            Interaction_51 = &H27B50
            Target1_51 = &H27B54
            Target2_51 = &H27B56
            Emotion_52 = &H139DC
            Endinteraction_52 = &H27C48
            Interaction_52 = &H27C50
            Target1_52 = &H27C54
            Target2_52 = &H27C56
            Emotion_53 = &H13F6C
            Endinteraction_53 = &H27D48
            Interaction_53 = &H27D50
            Target1_53 = &H27D54
            Target2_53 = &H27D56
            Emotion_54 = &H144FC
            Endinteraction_54 = &H27E48
            Interaction_54 = &H27E50
            Target1_54 = &H27E54
            Target2_54 = &H27E56
            Emotion_55 = &H14A8C
            Endinteraction_55 = &H27F48
            Interaction_55 = &H27F50
            Target1_55 = &H27F54
            Target2_55 = &H27F56
            Emotion_56 = &H1501C
            Endinteraction_56 = &H28048
            Interaction_56 = &H28050
            Target1_56 = &H28054
            Target2_56 = &H28056
            Emotion_57 = &H155AC
            Endinteraction_57 = &H28148
            Interaction_57 = &H28150
            Target1_57 = &H28154
            Target2_57 = &H28156
            Emotion_58 = &H15B3C
            Endinteraction_58 = &H28248
            Interaction_58 = &H28250
            Target1_58 = &H28254
            Target2_58 = &H28256
            Emotion_59 = &H160CC
            Endinteraction_59 = &H28348
            Interaction_59 = &H28350
            Target1_59 = &H28354
            Target2_59 = &H28356
            Emotion_60 = &H1665C
            Endinteraction_60 = &H28448
            Interaction_60 = &H28450
            Target1_60 = &H28454
            Target2_60 = &H28456
            Emotion_61 = &H16BEC
            Endinteraction_61 = &H28548
            Interaction_61 = &H28550
            Target1_61 = &H28554
            Target2_61 = &H28556
            Emotion_62 = &H1717C
            Endinteraction_62 = &H28648
            Interaction_62 = &H28650
            Target1_62 = &H28654
            Target2_62 = &H28656
            Emotion_63 = &H1770C
            Endinteraction_63 = &H28748
            Interaction_63 = &H28750
            Target1_63 = &H28754
            Target2_63 = &H28756
            Emotion_64 = &H17C9C
            Endinteraction_64 = &H28848
            Interaction_64 = &H28850
            Target1_64 = &H28854
            Target2_64 = &H28856
            Emotion_65 = &H1822C
            Endinteraction_65 = &H28948
            Interaction_65 = &H28950
            Target1_65 = &H28954
            Target2_65 = &H28956
            Emotion_66 = &H187BC
            Endinteraction_66 = &H28A48
            Interaction_66 = &H28A50
            Target1_66 = &H28A54
            Target2_66 = &H28A56
            Emotion_67 = &H18D4C
            Endinteraction_67 = &H28B48
            Interaction_67 = &H28B50
            Target1_67 = &H28B54
            Target2_67 = &H28B56
            Emotion_68 = &H192DC
            Endinteraction_68 = &H28C48
            Interaction_68 = &H28C50
            Target1_68 = &H28C54
            Target2_68 = &H28C56
            Emotion_69 = &H1986C
            Endinteraction_69 = &H28D48
            Interaction_69 = &H28D50
            Target1_69 = &H28D54
            Target2_69 = &H28D56
            Emotion_70 = &H19DFC
            Endinteraction_70 = &H28E48
            Interaction_70 = &H28E50
            Target1_70 = &H28E54
            Target2_70 = &H28E56
            Emotion_71 = &H1A38C
            Endinteraction_71 = &H28F48
            Interaction_71 = &H28F50
            Target1_71 = &H28F54
            Target2_71 = &H28F56
            Emotion_72 = &H1A91C
            Endinteraction_72 = &H29048
            Interaction_72 = &H29050
            Target1_72 = &H29054
            Target2_72 = &H29056
            Emotion_73 = &H1AEAC
            Endinteraction_73 = &H29148
            Interaction_73 = &H29150
            Target1_73 = &H29154
            Target2_73 = &H29156
            Emotion_74 = &H1B43C
            Endinteraction_74 = &H29248
            Interaction_74 = &H29250
            Target1_74 = &H29254
            Target2_74 = &H29256
            Emotion_75 = &H1B9CC
            Endinteraction_75 = &H29348
            Interaction_75 = &H29350
            Target1_75 = &H29354
            Target2_75 = &H29356
            Emotion_76 = &H1BF5C
            Endinteraction_76 = &H29448
            Interaction_76 = &H29450
            Target1_76 = &H29454
            Target2_76 = &H29456
            Emotion_77 = &H1C4EC
            Endinteraction_77 = &H29548
            Interaction_77 = &H29550
            Target1_77 = &H29554
            Target2_77 = &H29556
            Emotion_78 = &H1CA7C
            Endinteraction_78 = &H29648
            Interaction_78 = &H29650
            Target1_78 = &H29654
            Target2_78 = &H29656
            Emotion_79 = &H1D00C
            Endinteraction_79 = &H29748
            Interaction_79 = &H29750
            Target1_79 = &H29754
            Target2_79 = &H29756
            Emotion_80 = &H1D59C
            Endinteraction_80 = &H29848
            Interaction_80 = &H29850
            Target1_80 = &H29854
            Target2_80 = &H29856
            Emotion_81 = &H1DB2C
            Endinteraction_81 = &H29948
            Interaction_81 = &H29950
            Target1_81 = &H29954
            Target2_81 = &H29956
            Emotion_82 = &H1E0BC
            Endinteraction_82 = &H29A48
            Interaction_82 = &H29A50
            Target1_82 = &H29A54
            Target2_82 = &H29A56
            Emotion_83 = &H1E64C
            Endinteraction_83 = &H29B48
            Interaction_83 = &H29B50
            Target1_83 = &H29B54
            Target2_83 = &H29B56
            Emotion_84 = &H1EBDC
            Endinteraction_84 = &H29C48
            Interaction_84 = &H29C50
            Target1_84 = &H29C54
            Target2_84 = &H29C56
            Emotion_85 = &H1F16C
            Endinteraction_85 = &H29D48
            Interaction_85 = &H29D50
            Target1_85 = &H29D54
            Target2_85 = &H29D56
            Emotion_86 = &H1F6FC
            Endinteraction_86 = &H29E48
            Interaction_86 = &H29E50
            Target1_86 = &H29E54
            Target2_86 = &H29E56
            Emotion_87 = &H1FC8C
            Endinteraction_87 = &H29F48
            Interaction_87 = &H29F50
            Target1_87 = &H29F54
            Target2_87 = &H29F56
            Emotion_88 = &H2021C
            Endinteraction_88 = &H2A048
            Interaction_88 = &H2A050
            Target1_88 = &H2A054
            Target2_88 = &H2A056
            Emotion_89 = &H207AC
            Endinteraction_89 = &H2A148
            Interaction_89 = &H2A150
            Target1_89 = &H2A154
            Target2_89 = &H2A156
            Emotion_90 = &H20D3C
            Endinteraction_90 = &H2A248
            Interaction_90 = &H2A250
            Target1_90 = &H2A254
            Target2_90 = &H2A256
            Emotion_91 = &H212CC
            Endinteraction_91 = &H2A348
            Interaction_91 = &H2A350
            Target1_91 = &H2A354
            Target2_91 = &H2A356
            Emotion_92 = &H2185C
            Endinteraction_92 = &H2A448
            Interaction_92 = &H2A450
            Target1_92 = &H2A454
            Target2_92 = &H2A456
            Emotion_93 = &H21DEC
            Endinteraction_93 = &H2A548
            Interaction_93 = &H2A550
            Target1_93 = &H2A554
            Target2_93 = &H2A556
            Emotion_94 = &H2237C
            Endinteraction_94 = &H2A648
            Interaction_94 = &H2A650
            Target1_94 = &H2A654
            Target2_94 = &H2A656
            Emotion_95 = &H2290C
            Endinteraction_95 = &H2A748
            Interaction_95 = &H2A750
            Target1_95 = &H2A754
            Target2_95 = &H2A756
            Emotion_96 = &H22E9C
            Endinteraction_96 = &H2A848
            Interaction_96 = &H2A850
            Target1_96 = &H2A854
            Target2_96 = &H2A856
            Emotion_97 = &H2342C
            Endinteraction_97 = &H2A948
            Interaction_97 = &H2A950
            Target1_97 = &H2A954
            Target2_97 = &H2A956
            Emotion_98 = &H239BC
            Endinteraction_98 = &H2AA48
            Interaction_98 = &H2AA50
            Target1_98 = &H2AA54
            Target2_98 = &H2AA56
            Emotion_99 = &H23F4C
            Endinteraction_99 = &H2AB48
            Interaction_99 = &H2AB50
            Target1_99 = &H2AB54
            Target2_99 = &H2AB56
            Emotion_100 = &H244DC
            Endinteraction_100 = &H2AC48
            Interaction_100 = &H2AC50
            Target1_100 = &H2AC54
            Target2_100 = &H2AC56
        Else
            Emotion_1 = &H1F2C
            Endinteraction_1 = &H29AB8
            Interaction_1 = &H29AC0
            Target1_1 = &H29AC4
            Target2_1 = &H29AC6
            Emotion_2 = &H258C
            Endinteraction_2 = &H29BB8
            Interaction_2 = &H29BC0
            Target1_2 = &H29BC4
            Target2_2 = &H29BC6
            Emotion_3 = &H2BEC
            Endinteraction_3 = &H29CB8
            Interaction_3 = &H29CC0
            Target1_3 = &H29CC4
            Target2_3 = &H29CC6
            Emotion_4 = &H324C
            Endinteraction_4 = &H29DB8
            Interaction_4 = &H29DC0
            Target1_4 = &H29DC4
            Target2_4 = &H29DC6
            Emotion_5 = &H38AC
            Endinteraction_5 = &H29EB8
            Interaction_5 = &H29EC0
            Target1_5 = &H29EC4
            Target2_5 = &H29EC6
            Emotion_6 = &H3F0C
            Endinteraction_6 = &H29FB8
            Interaction_6 = &H29FC0
            Target1_6 = &H29FC4
            Target2_6 = &H29FC6
            Emotion_7 = &H456C
            Endinteraction_7 = &H2A0B8
            Interaction_7 = &H2A0C0
            Target1_7 = &H2A0C4
            Target2_7 = &H2A0C6
            Emotion_8 = &H4BCC
            Endinteraction_8 = &H2A1B8
            Interaction_8 = &H2A1C0
            Target1_8 = &H2A1C4
            Target2_8 = &H2A1C6
            Emotion_9 = &H522C
            Endinteraction_9 = &H2A2B8
            Interaction_9 = &H2A2C0
            Target1_9 = &H2A2C4
            Target2_9 = &H2A2C6
            Emotion_10 = &H588C
            Endinteraction_10 = &H2A3B8
            Interaction_10 = &H2A3C0
            Target1_10 = &H2A3C4
            Target2_10 = &H2A3C6
            Emotion_11 = &H5EEC
            Endinteraction_11 = &H2A4B8
            Interaction_11 = &H2A4C0
            Target1_11 = &H2A4C4
            Target2_11 = &H2A4C6
            Emotion_12 = &H654C
            Endinteraction_12 = &H2A5B8
            Interaction_12 = &H2A5C0
            Target1_12 = &H2A5C4
            Target2_12 = &H2A5C6
            Emotion_13 = &H6BAC
            Endinteraction_13 = &H2A6B8
            Interaction_13 = &H2A6C0
            Target1_13 = &H2A6C4
            Target2_13 = &H2A6C6
            Emotion_14 = &H720C
            Endinteraction_14 = &H2A7B8
            Interaction_14 = &H2A7C0
            Target1_14 = &H2A7C4
            Target2_14 = &H2A7C6
            Emotion_15 = &H786C
            Endinteraction_15 = &H2A8B8
            Interaction_15 = &H2A8C0
            Target1_15 = &H2A8C4
            Target2_15 = &H2A8C6
            Emotion_16 = &H7ECC
            Endinteraction_16 = &H2A9B8
            Interaction_16 = &H2A9C0
            Target1_16 = &H2A9C4
            Target2_16 = &H2A9C6
            Emotion_17 = &H852C
            Endinteraction_17 = &H2AAB8
            Interaction_17 = &H2AAC0
            Target1_17 = &H2AAC4
            Target2_17 = &H2AAC6
            Emotion_18 = &H8B8C
            Endinteraction_18 = &H2ABB8
            Interaction_18 = &H2ABC0
            Target1_18 = &H2ABC4
            Target2_18 = &H2ABC6
            Emotion_19 = &H91EC
            Endinteraction_19 = &H2ACB8
            Interaction_19 = &H2ACC0
            Target1_19 = &H2ACC4
            Target2_19 = &H2ACC6
            Emotion_20 = &H984C
            Endinteraction_20 = &H2ADB8
            Interaction_20 = &H2ADC0
            Target1_20 = &H2ADC4
            Target2_20 = &H2ADC6
            Emotion_21 = &H9EAC
            Endinteraction_21 = &H2AEB8
            Interaction_21 = &H2AEC0
            Target1_21 = &H2AEC4
            Target2_21 = &H2AEC6
            Emotion_22 = &HA50C
            Endinteraction_22 = &H2AFB8
            Interaction_22 = &H2AFC0
            Target1_22 = &H2AFC4
            Target2_22 = &H2AFC6
            Emotion_23 = &HAB6C
            Endinteraction_23 = &H2B0B8
            Interaction_23 = &H2B0C0
            Target1_23 = &H2B0C4
            Target2_23 = &H2B0C6
            Emotion_24 = &HB1CC
            Endinteraction_24 = &H2B1B8
            Interaction_24 = &H2B1C0
            Target1_24 = &H2B1C4
            Target2_24 = &H2B1C6
            Emotion_25 = &HB82C
            Endinteraction_25 = &H2B2B8
            Interaction_25 = &H2B2C0
            Target1_25 = &H2B2C4
            Target2_25 = &H2B2C6
            Emotion_26 = &HBE8C
            Endinteraction_26 = &H2B3B8
            Interaction_26 = &H2B3C0
            Target1_26 = &H2B3C4
            Target2_26 = &H2B3C6
            Emotion_27 = &HC4EC
            Endinteraction_27 = &H2B4B8
            Interaction_27 = &H2B4C0
            Target1_27 = &H2B4C4
            Target2_27 = &H2B4C6
            Emotion_28 = &HCB4C
            Endinteraction_28 = &H2B5B8
            Interaction_28 = &H2B5C0
            Target1_28 = &H2B5C4
            Target2_28 = &H2B5C6
            Emotion_29 = &HD1AC
            Endinteraction_29 = &H2B6B8
            Interaction_29 = &H2B6C0
            Target1_29 = &H2B6C4
            Target2_29 = &H2B6C6
            Emotion_30 = &HD80C
            Endinteraction_30 = &H2B7B8
            Interaction_30 = &H2B7C0
            Target1_30 = &H2B7C4
            Target2_30 = &H2B7C6
            Emotion_31 = &HDE6C
            Endinteraction_31 = &H2B8B8
            Interaction_31 = &H2B8C0
            Target1_31 = &H2B8C4
            Target2_31 = &H2B8C6
            Emotion_32 = &HE4CC
            Endinteraction_32 = &H2B9B8
            Interaction_32 = &H2B9C0
            Target1_32 = &H2B9C4
            Target2_32 = &H2B9C6
            Emotion_33 = &HEB2C
            Endinteraction_33 = &H2BAB8
            Interaction_33 = &H2BAC0
            Target1_33 = &H2BAC4
            Target2_33 = &H2BAC6
            Emotion_34 = &HF18C
            Endinteraction_34 = &H2BBB8
            Interaction_34 = &H2BBC0
            Target1_34 = &H2BBC4
            Target2_34 = &H2BBC6
            Emotion_35 = &HF7EC
            Endinteraction_35 = &H2BCB8
            Interaction_35 = &H2BCC0
            Target1_35 = &H2BCC4
            Target2_35 = &H2BCC6
            Emotion_36 = &HFE4C
            Endinteraction_36 = &H2BDB8
            Interaction_36 = &H2BDC0
            Target1_36 = &H2BDC4
            Target2_36 = &H2BDC6
            Emotion_37 = &H104AC
            Endinteraction_37 = &H2BEB8
            Interaction_37 = &H2BEC0
            Target1_37 = &H2BEC4
            Target2_37 = &H2BEC6
            Emotion_38 = &H10B0C
            Endinteraction_38 = &H2BFB8
            Interaction_38 = &H2BFC0
            Target1_38 = &H2BFC4
            Target2_38 = &H2BFC6
            Emotion_39 = &H1116C
            Endinteraction_39 = &H2C0B8
            Interaction_39 = &H2C0C0
            Target1_39 = &H2C0C4
            Target2_39 = &H2C0C6
            Emotion_40 = &H117CC
            Endinteraction_40 = &H2C1B8
            Interaction_40 = &H2C1C0
            Target1_40 = &H2C1C4
            Target2_40 = &H2C1C6
            Emotion_41 = &H11E2C
            Endinteraction_41 = &H2C2B8
            Interaction_41 = &H2C2C0
            Target1_41 = &H2C2C4
            Target2_41 = &H2C2C6
            Emotion_42 = &H1248C
            Endinteraction_42 = &H2C3B8
            Interaction_42 = &H2C3C0
            Target1_42 = &H2C3C4
            Target2_42 = &H2C3C6
            Emotion_43 = &H12AEC
            Endinteraction_43 = &H2C4B8
            Interaction_43 = &H2C4C0
            Target1_43 = &H2C4C4
            Target2_43 = &H2C4C6
            Emotion_44 = &H1314C
            Endinteraction_44 = &H2C5B8
            Interaction_44 = &H2C5C0
            Target1_44 = &H2C5C4
            Target2_44 = &H2C5C6
            Emotion_45 = &H137AC
            Endinteraction_45 = &H2C6B8
            Interaction_45 = &H2C6C0
            Target1_45 = &H2C6C4
            Target2_45 = &H2C6C6
            Emotion_46 = &H13E0C
            Endinteraction_46 = &H2C7B8
            Interaction_46 = &H2C7C0
            Target1_46 = &H2C7C4
            Target2_46 = &H2C7C6
            Emotion_47 = &H1446C
            Endinteraction_47 = &H2C8B8
            Interaction_47 = &H2C8C0
            Target1_47 = &H2C8C4
            Target2_47 = &H2C8C6
            Emotion_48 = &H14ACC
            Endinteraction_48 = &H2C9B8
            Interaction_48 = &H2C9C0
            Target1_48 = &H2C9C4
            Target2_48 = &H2C9C6
            Emotion_49 = &H1512C
            Endinteraction_49 = &H2CAB8
            Interaction_49 = &H2CAC0
            Target1_49 = &H2CAC4
            Target2_49 = &H2CAC6
            Emotion_50 = &H1578C
            Endinteraction_50 = &H2CBB8
            Interaction_50 = &H2CBC0
            Target1_50 = &H2CBC4
            Target2_50 = &H2CBC6
            Emotion_51 = &H15DEC
            Endinteraction_51 = &H2CCB8
            Interaction_51 = &H2CCC0
            Target1_51 = &H2CCC4
            Target2_51 = &H2CCC6
            Emotion_52 = &H1644C
            Endinteraction_52 = &H2CDB8
            Interaction_52 = &H2CDC0
            Target1_52 = &H2CDC4
            Target2_52 = &H2CDC6
            Emotion_53 = &H16AAC
            Endinteraction_53 = &H2CEB8
            Interaction_53 = &H2CEC0
            Target1_53 = &H2CEC4
            Target2_53 = &H2CEC6
            Emotion_54 = &H1710C
            Endinteraction_54 = &H2CFB8
            Interaction_54 = &H2CFC0
            Target1_54 = &H2CFC4
            Target2_54 = &H2CFC6
            Emotion_55 = &H1776C
            Endinteraction_55 = &H2D0B8
            Interaction_55 = &H2D0C0
            Target1_55 = &H2D0C4
            Target2_55 = &H2D0C6
            Emotion_56 = &H17DCC
            Endinteraction_56 = &H2D1B8
            Interaction_56 = &H2D1C0
            Target1_56 = &H2D1C4
            Target2_56 = &H2D1C6
            Emotion_57 = &H1842C
            Endinteraction_57 = &H2D2B8
            Interaction_57 = &H2D2C0
            Target1_57 = &H2D2C4
            Target2_57 = &H2D2C6
            Emotion_58 = &H18A8C
            Endinteraction_58 = &H2D3B8
            Interaction_58 = &H2D3C0
            Target1_58 = &H2D3C4
            Target2_58 = &H2D3C6
            Emotion_59 = &H190EC
            Endinteraction_59 = &H2D4B8
            Interaction_59 = &H2D4C0
            Target1_59 = &H2D4C4
            Target2_59 = &H2D4C6
            Emotion_60 = &H1974C
            Endinteraction_60 = &H2D5B8
            Interaction_60 = &H2D5C0
            Target1_60 = &H2D5C4
            Target2_60 = &H2D5C6
            Emotion_61 = &H19DAC
            Endinteraction_61 = &H2D6B8
            Interaction_61 = &H2D6C0
            Target1_61 = &H2D6C4
            Target2_61 = &H2D6C6
            Emotion_62 = &H1A40C
            Endinteraction_62 = &H2D7B8
            Interaction_62 = &H2D7C0
            Target1_62 = &H2D7C4
            Target2_62 = &H2D7C6
            Emotion_63 = &H1AA6C
            Endinteraction_63 = &H2D8B8
            Interaction_63 = &H2D8C0
            Target1_63 = &H2D8C4
            Target2_63 = &H2D8C6
            Emotion_64 = &H1B0CC
            Endinteraction_64 = &H2D9B8
            Interaction_64 = &H2D9C0
            Target1_64 = &H2D9C4
            Target2_64 = &H2D9C6
            Emotion_65 = &H1B72C
            Endinteraction_65 = &H2DAB8
            Interaction_65 = &H2DAC0
            Target1_65 = &H2DAC4
            Target2_65 = &H2DAC6
            Emotion_66 = &H1BD8C
            Endinteraction_66 = &H2DBB8
            Interaction_66 = &H2DBC0
            Target1_66 = &H2DBC4
            Target2_66 = &H2DBC6
            Emotion_67 = &H1C3EC
            Endinteraction_67 = &H2DCB8
            Interaction_67 = &H2DCC0
            Target1_67 = &H2DCC4
            Target2_67 = &H2DCC6
            Emotion_68 = &H1CA4C
            Endinteraction_68 = &H2DDB8
            Interaction_68 = &H2DDC0
            Target1_68 = &H2DDC4
            Target2_68 = &H2DDC6
            Emotion_69 = &H1D0AC
            Endinteraction_69 = &H2DEB8
            Interaction_69 = &H2DEC0
            Target1_69 = &H2DEC4
            Target2_69 = &H2DEC6
            Emotion_70 = &H1D70C
            Endinteraction_70 = &H2DFB8
            Interaction_70 = &H2DFC0
            Target1_70 = &H2DFC4
            Target2_70 = &H2DFC6
            Emotion_71 = &H1DD6C
            Endinteraction_71 = &H2E0B8
            Interaction_71 = &H2E0C0
            Target1_71 = &H2E0C4
            Target2_71 = &H2E0C6
            Emotion_72 = &H1E3CC
            Endinteraction_72 = &H2E1B8
            Interaction_72 = &H2E1C0
            Target1_72 = &H2E1C4
            Target2_72 = &H2E1C6
            Emotion_73 = &H1EA2C
            Endinteraction_73 = &H2E2B8
            Interaction_73 = &H2E2C0
            Target1_73 = &H2E2C4
            Target2_73 = &H2E2C6
            Emotion_74 = &H1F08C
            Endinteraction_74 = &H2E3B8
            Interaction_74 = &H2E3C0
            Target1_74 = &H2E3C4
            Target2_74 = &H2E3C6
            Emotion_75 = &H1F6EC
            Endinteraction_75 = &H2E4B8
            Interaction_75 = &H2E4C0
            Target1_75 = &H2E4C4
            Target2_75 = &H2E4C6
            Emotion_76 = &H1FD4C
            Endinteraction_76 = &H2E5B8
            Interaction_76 = &H2E5C0
            Target1_76 = &H2E5C4
            Target2_76 = &H2E5C6
            Emotion_77 = &H203AC
            Endinteraction_77 = &H2E6B8
            Interaction_77 = &H2E6C0
            Target1_77 = &H2E6C4
            Target2_77 = &H2E6C6
            Emotion_78 = &H20A0C
            Endinteraction_78 = &H2E7B8
            Interaction_78 = &H2E7C0
            Target1_78 = &H2E7C4
            Target2_78 = &H2E7C6
            Emotion_79 = &H2106C
            Endinteraction_79 = &H2E8B8
            Interaction_79 = &H2E8C0
            Target1_79 = &H2E8C4
            Target2_79 = &H2E8C6
            Emotion_80 = &H216CC
            Endinteraction_80 = &H2E9B8
            Interaction_80 = &H2E9C0
            Target1_80 = &H2E9C4
            Target2_80 = &H2E9C6
            Emotion_81 = &H21D2C
            Endinteraction_81 = &H2EAB8
            Interaction_81 = &H2EAC0
            Target1_81 = &H2EAC4
            Target2_81 = &H2EAC6
            Emotion_82 = &H2238C
            Endinteraction_82 = &H2EBB8
            Interaction_82 = &H2EBC0
            Target1_82 = &H2EBC4
            Target2_82 = &H2EBC6
            Emotion_83 = &H229EC
            Endinteraction_83 = &H2ECB8
            Interaction_83 = &H2ECC0
            Target1_83 = &H2ECC4
            Target2_83 = &H2ECC6
            Emotion_84 = &H2304C
            Endinteraction_84 = &H2EDB8
            Interaction_84 = &H2EDC0
            Target1_84 = &H2EDC4
            Target2_84 = &H2EDC6
            Emotion_85 = &H236AC
            Endinteraction_85 = &H2EEB8
            Interaction_85 = &H2EEC0
            Target1_85 = &H2EEC4
            Target2_85 = &H2EEC6
            Emotion_86 = &H23D0C
            Endinteraction_86 = &H2EFB8
            Interaction_86 = &H2EFC0
            Target1_86 = &H2EFC4
            Target2_86 = &H2EFC6
            Emotion_87 = &H2436C
            Endinteraction_87 = &H2F0B8
            Interaction_87 = &H2F0C0
            Target1_87 = &H2F0C4
            Target2_87 = &H2F0C6
            Emotion_88 = &H249CC
            Endinteraction_88 = &H2F1B8
            Interaction_88 = &H2F1C0
            Target1_88 = &H2F1C4
            Target2_88 = &H2F1C6
            Emotion_89 = &H2502C
            Endinteraction_89 = &H2F2B8
            Interaction_89 = &H2F2C0
            Target1_89 = &H2F2C4
            Target2_89 = &H2F2C6
            Emotion_90 = &H2568C
            Endinteraction_90 = &H2F3B8
            Interaction_90 = &H2F3C0
            Target1_90 = &H2F3C4
            Target2_90 = &H2F3C6
            Emotion_91 = &H25CEC
            Endinteraction_91 = &H2F4B8
            Interaction_91 = &H2F4C0
            Target1_91 = &H2F4C4
            Target2_91 = &H2F4C6
            Emotion_92 = &H2634C
            Endinteraction_92 = &H2F5B8
            Interaction_92 = &H2F5C0
            Target1_92 = &H2F5C4
            Target2_92 = &H2F5C6
            Emotion_93 = &H269AC
            Endinteraction_93 = &H2F6B8
            Interaction_93 = &H2F6C0
            Target1_93 = &H2F6C4
            Target2_93 = &H2F6C6
            Emotion_94 = &H2700C
            Endinteraction_94 = &H2F7B8
            Interaction_94 = &H2F7C0
            Target1_94 = &H2F7C4
            Target2_94 = &H2F7C6
            Emotion_95 = &H2766C
            Endinteraction_95 = &H2F8B8
            Interaction_95 = &H2F8C0
            Target1_95 = &H2F8C4
            Target2_95 = &H2F8C6
            Emotion_96 = &H27CCC
            Endinteraction_96 = &H2F9B8
            Interaction_96 = &H2F9C0
            Target1_96 = &H2F9C4
            Target2_96 = &H2F9C6
            Emotion_97 = &H2832C
            Endinteraction_97 = &H2FAB8
            Interaction_97 = &H2FAC0
            Target1_97 = &H2FAC4
            Target2_97 = &H2FAC6
            Emotion_98 = &H2898C
            Endinteraction_98 = &H2FBB8
            Interaction_98 = &H2FBC0
            Target1_98 = &H2FBC4
            Target2_98 = &H2FBC6
            Emotion_99 = &H28FEC
            Endinteraction_99 = &H2FCB8
            Interaction_99 = &H2FCC0
            Target1_99 = &H2FCC4
            Target2_99 = &H2FCC6
            Emotion_100 = &H2964C
            Endinteraction_100 = &H2FDB8
            Interaction_100 = &H2FDC0
            Target1_100 = &H2FDC4
            Target2_100 = &H2FDC6
        End If
    End Sub

    Public Sub Readinteraction()
        Try
            Dim Readdata As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Readdata.Position = lastsavedate
            valu_lastsavedate.Value = Readdata.ReadUInt32
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Readdata.Position = Emotion_1
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_1
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_1
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_1
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_1
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Readdata.Position = Emotion_2
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_2
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_2
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_2
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_2
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Readdata.Position = Emotion_3
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_3
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_3
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_3
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_3
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Readdata.Position = Emotion_4
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_4
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_4
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_4
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_4
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Readdata.Position = Emotion_5
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_5
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_5
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_5
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_5
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Readdata.Position = Emotion_6
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_6
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_6
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_6
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_6
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Readdata.Position = Emotion_7
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_7
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_7
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_7
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_7
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Readdata.Position = Emotion_8
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_8
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_8
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_8
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_8
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Readdata.Position = Emotion_9
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_9
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_9
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_9
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_9
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Readdata.Position = Emotion_10
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_10
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_10
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_10
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_10
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Readdata.Position = Emotion_11
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_11
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_11
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_11
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_11
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Readdata.Position = Emotion_12
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_12
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_12
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_12
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_12
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Readdata.Position = Emotion_13
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_13
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_13
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_13
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_13
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Readdata.Position = Emotion_14
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_14
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_14
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_14
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_14
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Readdata.Position = Emotion_15
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_15
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_15
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_15
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_15
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Readdata.Position = Emotion_16
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_16
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_16
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_16
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_16
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Readdata.Position = Emotion_17
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_17
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_17
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_17
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_17
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Readdata.Position = Emotion_18
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_18
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_18
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_18
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_18
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Readdata.Position = Emotion_19
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_19
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_19
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_19
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_19
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Readdata.Position = Emotion_20
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_20
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_20
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_20
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_20
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Readdata.Position = Emotion_21
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_21
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_21
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_21
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_21
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Readdata.Position = Emotion_22
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_22
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_22
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_22
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_22
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Readdata.Position = Emotion_23
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_23
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_23
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_23
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_23
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Readdata.Position = Emotion_24
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_24
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_24
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_24
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_24
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Readdata.Position = Emotion_25
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_25
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_25
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_25
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_25
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Readdata.Position = Emotion_26
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_26
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_26
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_26
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_26
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Readdata.Position = Emotion_27
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_27
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_27
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_27
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_27
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Readdata.Position = Emotion_28
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_28
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_28
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_28
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_28
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Readdata.Position = Emotion_29
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_29
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_29
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_29
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_29
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Readdata.Position = Emotion_30
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_30
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_30
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_30
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_30
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Readdata.Position = Emotion_31
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_31
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_31
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_31
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_31
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Readdata.Position = Emotion_32
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_32
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_32
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_32
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_32
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Readdata.Position = Emotion_33
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_33
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_33
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_33
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_33
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Readdata.Position = Emotion_34
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_34
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_34
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_34
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_34
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Readdata.Position = Emotion_35
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_35
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_35
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_35
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_35
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Readdata.Position = Emotion_36
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_36
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_36
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_36
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_36
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Readdata.Position = Emotion_37
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_37
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_37
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_37
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_37
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Readdata.Position = Emotion_38
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_38
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_38
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_38
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_38
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Readdata.Position = Emotion_39
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_39
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_39
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_39
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_39
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Readdata.Position = Emotion_40
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_40
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_40
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_40
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_40
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Readdata.Position = Emotion_41
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_41
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_41
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_41
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_41
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Readdata.Position = Emotion_42
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_42
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_42
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_42
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_42
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Readdata.Position = Emotion_43
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_43
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_43
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_43
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_43
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Readdata.Position = Emotion_44
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_44
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_44
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_44
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_44
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Readdata.Position = Emotion_45
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_45
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_45
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_45
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_45
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Readdata.Position = Emotion_46
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_46
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_46
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_46
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_46
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Readdata.Position = Emotion_47
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_47
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_47
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_47
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_47
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Readdata.Position = Emotion_48
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_48
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_48
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_48
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_48
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Readdata.Position = Emotion_49
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_49
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_49
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_49
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_49
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Readdata.Position = Emotion_50
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_50
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_50
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_50
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_50
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Readdata.Position = Emotion_51
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_51
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_51
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_51
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_51
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Readdata.Position = Emotion_52
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_52
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_52
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_52
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_52
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Readdata.Position = Emotion_53
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_53
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_53
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_53
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_53
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Readdata.Position = Emotion_54
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_54
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_54
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_54
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_54
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Readdata.Position = Emotion_55
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_55
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_55
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_55
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_55
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Readdata.Position = Emotion_56
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_56
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_56
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_56
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_56
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Readdata.Position = Emotion_57
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_57
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_57
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_57
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_57
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Readdata.Position = Emotion_58
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_58
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_58
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_58
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_58
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Readdata.Position = Emotion_59
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_59
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_59
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_59
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_59
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Readdata.Position = Emotion_60
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_60
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_60
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_60
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_60
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Readdata.Position = Emotion_61
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_61
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_61
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_61
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_61
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Readdata.Position = Emotion_62
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_62
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_62
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_62
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_62
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Readdata.Position = Emotion_63
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_63
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_63
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_63
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_63
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Readdata.Position = Emotion_64
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_64
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_64
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_64
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_64
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Readdata.Position = Emotion_65
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_65
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_65
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_65
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_65
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Readdata.Position = Emotion_66
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_66
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_66
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_66
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_66
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Readdata.Position = Emotion_67
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_67
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_67
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_67
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_67
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Readdata.Position = Emotion_68
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_68
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_68
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_68
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_68
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Readdata.Position = Emotion_69
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_69
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_69
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_69
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_69
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Readdata.Position = Emotion_70
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_70
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_70
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_70
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_70
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Readdata.Position = Emotion_71
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_71
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_71
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_71
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_71
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Readdata.Position = Emotion_72
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_72
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_72
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_72
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_72
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Readdata.Position = Emotion_73
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_73
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_73
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_73
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_73
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Readdata.Position = Emotion_74
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_74
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_74
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_74
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_74
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Readdata.Position = Emotion_75
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_75
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_75
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_75
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_75
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Readdata.Position = Emotion_76
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_76
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_76
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_76
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_76
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Readdata.Position = Emotion_77
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_77
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_77
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_77
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_77
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Readdata.Position = Emotion_78
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_78
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_78
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_78
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_78
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Readdata.Position = Emotion_79
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_79
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_79
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_79
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_79
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Readdata.Position = Emotion_80
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_80
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_80
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_80
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_80
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Readdata.Position = Emotion_81
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_81
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_81
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_81
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_81
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Readdata.Position = Emotion_82
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_82
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_82
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_82
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_82
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Readdata.Position = Emotion_83
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_83
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_83
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_83
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_83
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Readdata.Position = Emotion_84
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_84
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_84
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_84
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_84
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Readdata.Position = Emotion_85
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_85
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_85
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_85
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_85
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Readdata.Position = Emotion_86
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_86
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_86
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_86
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_86
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Readdata.Position = Emotion_87
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_87
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_87
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_87
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_87
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Readdata.Position = Emotion_88
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_88
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_88
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_88
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_88
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Readdata.Position = Emotion_89
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_89
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_89
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_89
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_89
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Readdata.Position = Emotion_90
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_90
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_90
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_90
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_90
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Readdata.Position = Emotion_91
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_91
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_91
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_91
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_91
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Readdata.Position = Emotion_92
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_92
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_92
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_92
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_92
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Readdata.Position = Emotion_93
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_93
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_93
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_93
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_93
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Readdata.Position = Emotion_94
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_94
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_94
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_94
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_94
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Readdata.Position = Emotion_95
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_95
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_95
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_95
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_95
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Readdata.Position = Emotion_96
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_96
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_96
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_96
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_96
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Readdata.Position = Emotion_97
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_97
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_97
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_97
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_97
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Readdata.Position = Emotion_98
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_98
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_98
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_98
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_98
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Readdata.Position = Emotion_99
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_99
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_99
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_99
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_99
                valu_target2.Value = Readdata.ReadUInt16
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Readdata.Position = Emotion_100
                valu_emotions.Value = Readdata.ReadByte
                Readdata.Position = Endinteraction_100
                valu_enddateinterac.Value = Readdata.ReadUInt32
                Readdata.Position = Interaction_100
                valu_interaction.Value = Readdata.ReadUInt16
                Readdata.Position = Target1_100
                valu_target1.Value = Readdata.ReadUInt16
                Readdata.Position = Target2_100
                valu_target2.Value = Readdata.ReadUInt16
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read interaction of this Mii"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        Select_interaction.SelectedItem = Select_interaction.Items.Item(0)
        Select_target1.SelectedItem = Select_target1.Items.Item(0)
        Select_target2.SelectedItem = Select_target2.Items.Item(0)
        Select_emotions.SelectedItem = Select_emotions.Items.Item(0)
        Readinteraction()
    End Sub

    Private Sub Select_target1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_target1.SelectedIndexChanged
        If Select_target1.SelectedItem = Select_target1.Items.Item(0) Then
            valu_target1.Value = 65535
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(1) Then
            valu_target1.Value = 0
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(2) Then
            valu_target1.Value = 1
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(3) Then
            valu_target1.Value = 2
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(4) Then
            valu_target1.Value = 3
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(5) Then
            valu_target1.Value = 4
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(6) Then
            valu_target1.Value = 5
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(7) Then
            valu_target1.Value = 6
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(8) Then
            valu_target1.Value = 7
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(9) Then
            valu_target1.Value = 8
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(10) Then
            valu_target1.Value = 9
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(11) Then
            valu_target1.Value = 10
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(12) Then
            valu_target1.Value = 11
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(13) Then
            valu_target1.Value = 12
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(14) Then
            valu_target1.Value = 13
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(15) Then
            valu_target1.Value = 14
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(16) Then
            valu_target1.Value = 15
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(17) Then
            valu_target1.Value = 16
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(18) Then
            valu_target1.Value = 17
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(19) Then
            valu_target1.Value = 18
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(20) Then
            valu_target1.Value = 19
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(21) Then
            valu_target1.Value = 20
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(22) Then
            valu_target1.Value = 21
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(23) Then
            valu_target1.Value = 22
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(24) Then
            valu_target1.Value = 23
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(25) Then
            valu_target1.Value = 24
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(26) Then
            valu_target1.Value = 25
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(27) Then
            valu_target1.Value = 26
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(28) Then
            valu_target1.Value = 27
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(29) Then
            valu_target1.Value = 28
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(30) Then
            valu_target1.Value = 29
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(31) Then
            valu_target1.Value = 30
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(32) Then
            valu_target1.Value = 31
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(33) Then
            valu_target1.Value = 32
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(34) Then
            valu_target1.Value = 33
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(35) Then
            valu_target1.Value = 34
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(36) Then
            valu_target1.Value = 35
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(37) Then
            valu_target1.Value = 36
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(38) Then
            valu_target1.Value = 37
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(39) Then
            valu_target1.Value = 38
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(40) Then
            valu_target1.Value = 39
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(41) Then
            valu_target1.Value = 40
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(42) Then
            valu_target1.Value = 41
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(43) Then
            valu_target1.Value = 42
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(44) Then
            valu_target1.Value = 43
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(45) Then
            valu_target1.Value = 44
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(46) Then
            valu_target1.Value = 45
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(47) Then
            valu_target1.Value = 46
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(48) Then
            valu_target1.Value = 47
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(49) Then
            valu_target1.Value = 48
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(50) Then
            valu_target1.Value = 49
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(51) Then
            valu_target1.Value = 50
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(52) Then
            valu_target1.Value = 51
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(53) Then
            valu_target1.Value = 52
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(54) Then
            valu_target1.Value = 53
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(55) Then
            valu_target1.Value = 54
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(56) Then
            valu_target1.Value = 55
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(57) Then
            valu_target1.Value = 56
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(58) Then
            valu_target1.Value = 57
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(59) Then
            valu_target1.Value = 58
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(60) Then
            valu_target1.Value = 59
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(61) Then
            valu_target1.Value = 60
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(62) Then
            valu_target1.Value = 61
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(63) Then
            valu_target1.Value = 62
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(64) Then
            valu_target1.Value = 63
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(65) Then
            valu_target1.Value = 64
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(66) Then
            valu_target1.Value = 65
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(67) Then
            valu_target1.Value = 66
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(68) Then
            valu_target1.Value = 67
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(69) Then
            valu_target1.Value = 68
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(70) Then
            valu_target1.Value = 69
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(71) Then
            valu_target1.Value = 70
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(72) Then
            valu_target1.Value = 71
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(73) Then
            valu_target1.Value = 72
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(74) Then
            valu_target1.Value = 73
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(75) Then
            valu_target1.Value = 74
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(76) Then
            valu_target1.Value = 75
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(77) Then
            valu_target1.Value = 76
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(78) Then
            valu_target1.Value = 77
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(79) Then
            valu_target1.Value = 78
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(80) Then
            valu_target1.Value = 79
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(81) Then
            valu_target1.Value = 80
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(82) Then
            valu_target1.Value = 81
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(83) Then
            valu_target1.Value = 82
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(84) Then
            valu_target1.Value = 83
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(85) Then
            valu_target1.Value = 84
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(86) Then
            valu_target1.Value = 85
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(87) Then
            valu_target1.Value = 86
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(88) Then
            valu_target1.Value = 87
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(89) Then
            valu_target1.Value = 88
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(90) Then
            valu_target1.Value = 89
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(91) Then
            valu_target1.Value = 90
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(92) Then
            valu_target1.Value = 91
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(93) Then
            valu_target1.Value = 92
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(94) Then
            valu_target1.Value = 93
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(95) Then
            valu_target1.Value = 94
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(96) Then
            valu_target1.Value = 95
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(97) Then
            valu_target1.Value = 96
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(98) Then
            valu_target1.Value = 97
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(99) Then
            valu_target1.Value = 98
        ElseIf Select_target1.SelectedItem = Select_target1.Items.Item(100) Then
            valu_target1.Value = 99
        End If
    End Sub

    Private Sub Select_target2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_target2.SelectedIndexChanged
        If Select_target2.SelectedItem = Select_target2.Items.Item(0) Then
            valu_target2.Value = 65535
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(1) Then
            valu_target2.Value = 0
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(2) Then
            valu_target2.Value = 1
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(3) Then
            valu_target2.Value = 2
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(4) Then
            valu_target2.Value = 3
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(5) Then
            valu_target2.Value = 4
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(6) Then
            valu_target2.Value = 5
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(7) Then
            valu_target2.Value = 6
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(8) Then
            valu_target2.Value = 7
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(9) Then
            valu_target2.Value = 8
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(10) Then
            valu_target2.Value = 9
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(11) Then
            valu_target2.Value = 10
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(12) Then
            valu_target2.Value = 11
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(13) Then
            valu_target2.Value = 12
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(14) Then
            valu_target2.Value = 13
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(15) Then
            valu_target2.Value = 14
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(16) Then
            valu_target2.Value = 15
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(17) Then
            valu_target2.Value = 16
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(18) Then
            valu_target2.Value = 17
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(19) Then
            valu_target2.Value = 18
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(20) Then
            valu_target2.Value = 19
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(21) Then
            valu_target2.Value = 20
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(22) Then
            valu_target2.Value = 21
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(23) Then
            valu_target2.Value = 22
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(24) Then
            valu_target2.Value = 23
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(25) Then
            valu_target2.Value = 24
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(26) Then
            valu_target2.Value = 25
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(27) Then
            valu_target2.Value = 26
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(28) Then
            valu_target2.Value = 27
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(29) Then
            valu_target2.Value = 28
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(30) Then
            valu_target2.Value = 29
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(31) Then
            valu_target2.Value = 30
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(32) Then
            valu_target2.Value = 31
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(33) Then
            valu_target2.Value = 32
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(34) Then
            valu_target2.Value = 33
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(35) Then
            valu_target2.Value = 34
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(36) Then
            valu_target2.Value = 35
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(37) Then
            valu_target2.Value = 36
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(38) Then
            valu_target2.Value = 37
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(39) Then
            valu_target2.Value = 38
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(40) Then
            valu_target2.Value = 39
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(41) Then
            valu_target2.Value = 40
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(42) Then
            valu_target2.Value = 41
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(43) Then
            valu_target2.Value = 42
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(44) Then
            valu_target2.Value = 43
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(45) Then
            valu_target2.Value = 44
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(46) Then
            valu_target2.Value = 45
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(47) Then
            valu_target2.Value = 46
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(48) Then
            valu_target2.Value = 47
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(49) Then
            valu_target2.Value = 48
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(50) Then
            valu_target2.Value = 49
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(51) Then
            valu_target2.Value = 50
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(52) Then
            valu_target2.Value = 51
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(53) Then
            valu_target2.Value = 52
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(54) Then
            valu_target2.Value = 53
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(55) Then
            valu_target2.Value = 54
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(56) Then
            valu_target2.Value = 55
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(57) Then
            valu_target2.Value = 56
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(58) Then
            valu_target2.Value = 57
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(59) Then
            valu_target2.Value = 58
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(60) Then
            valu_target2.Value = 59
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(61) Then
            valu_target2.Value = 60
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(62) Then
            valu_target2.Value = 61
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(63) Then
            valu_target2.Value = 62
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(64) Then
            valu_target2.Value = 63
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(65) Then
            valu_target2.Value = 64
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(66) Then
            valu_target2.Value = 65
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(67) Then
            valu_target2.Value = 66
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(68) Then
            valu_target2.Value = 67
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(69) Then
            valu_target2.Value = 68
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(70) Then
            valu_target2.Value = 69
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(71) Then
            valu_target2.Value = 70
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(72) Then
            valu_target2.Value = 71
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(73) Then
            valu_target2.Value = 72
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(74) Then
            valu_target2.Value = 73
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(75) Then
            valu_target2.Value = 74
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(76) Then
            valu_target2.Value = 75
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(77) Then
            valu_target2.Value = 76
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(78) Then
            valu_target2.Value = 77
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(79) Then
            valu_target2.Value = 78
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(80) Then
            valu_target2.Value = 79
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(81) Then
            valu_target2.Value = 80
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(82) Then
            valu_target2.Value = 81
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(83) Then
            valu_target2.Value = 82
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(84) Then
            valu_target2.Value = 83
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(85) Then
            valu_target2.Value = 84
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(86) Then
            valu_target2.Value = 85
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(87) Then
            valu_target2.Value = 86
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(88) Then
            valu_target2.Value = 87
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(89) Then
            valu_target2.Value = 88
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(90) Then
            valu_target2.Value = 89
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(91) Then
            valu_target2.Value = 90
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(92) Then
            valu_target2.Value = 91
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(93) Then
            valu_target2.Value = 92
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(94) Then
            valu_target2.Value = 93
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(95) Then
            valu_target2.Value = 94
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(96) Then
            valu_target2.Value = 95
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(97) Then
            valu_target2.Value = 96
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(98) Then
            valu_target2.Value = 97
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(99) Then
            valu_target2.Value = 98
        ElseIf Select_target2.SelectedItem = Select_target2.Items.Item(100) Then
            valu_target2.Value = 99
        End If
    End Sub

    Private Sub valu_target1_ValueChanged(sender As Object, e As EventArgs) Handles valu_target1.ValueChanged
        If valu_target1.Value = 65535 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(0)
        ElseIf valu_target1.Value = 0 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(1)
        ElseIf valu_target1.Value = 1 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(2)
        ElseIf valu_target1.Value = 2 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(3)
        ElseIf valu_target1.Value = 3 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(4)
        ElseIf valu_target1.Value = 4 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(5)
        ElseIf valu_target1.Value = 5 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(6)
        ElseIf valu_target1.Value = 6 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(7)
        ElseIf valu_target1.Value = 7 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(8)
        ElseIf valu_target1.Value = 8 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(9)
        ElseIf valu_target1.Value = 9 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(10)
        ElseIf valu_target1.Value = 10 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(11)
        ElseIf valu_target1.Value = 11 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(12)
        ElseIf valu_target1.Value = 12 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(13)
        ElseIf valu_target1.Value = 13 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(14)
        ElseIf valu_target1.Value = 14 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(15)
        ElseIf valu_target1.Value = 15 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(16)
        ElseIf valu_target1.Value = 16 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(17)
        ElseIf valu_target1.Value = 17 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(18)
        ElseIf valu_target1.Value = 18 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(19)
        ElseIf valu_target1.Value = 19 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(20)
        ElseIf valu_target1.Value = 20 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(21)
        ElseIf valu_target1.Value = 21 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(22)
        ElseIf valu_target1.Value = 22 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(23)
        ElseIf valu_target1.Value = 23 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(24)
        ElseIf valu_target1.Value = 24 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(25)
        ElseIf valu_target1.Value = 25 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(26)
        ElseIf valu_target1.Value = 26 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(27)
        ElseIf valu_target1.Value = 27 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(28)
        ElseIf valu_target1.Value = 28 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(29)
        ElseIf valu_target1.Value = 29 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(30)
        ElseIf valu_target1.Value = 30 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(31)
        ElseIf valu_target1.Value = 31 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(32)
        ElseIf valu_target1.Value = 32 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(33)
        ElseIf valu_target1.Value = 33 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(34)
        ElseIf valu_target1.Value = 34 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(35)
        ElseIf valu_target1.Value = 35 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(36)
        ElseIf valu_target1.Value = 36 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(37)
        ElseIf valu_target1.Value = 37 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(38)
        ElseIf valu_target1.Value = 38 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(39)
        ElseIf valu_target1.Value = 39 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(40)
        ElseIf valu_target1.Value = 40 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(41)
        ElseIf valu_target1.Value = 41 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(42)
        ElseIf valu_target1.Value = 42 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(43)
        ElseIf valu_target1.Value = 43 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(44)
        ElseIf valu_target1.Value = 44 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(45)
        ElseIf valu_target1.Value = 45 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(46)
        ElseIf valu_target1.Value = 46 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(47)
        ElseIf valu_target1.Value = 47 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(48)
        ElseIf valu_target1.Value = 48 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(49)
        ElseIf valu_target1.Value = 49 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(50)
        ElseIf valu_target1.Value = 50 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(51)
        ElseIf valu_target1.Value = 51 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(52)
        ElseIf valu_target1.Value = 52 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(53)
        ElseIf valu_target1.Value = 53 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(54)
        ElseIf valu_target1.Value = 54 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(55)
        ElseIf valu_target1.Value = 55 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(56)
        ElseIf valu_target1.Value = 56 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(57)
        ElseIf valu_target1.Value = 57 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(58)
        ElseIf valu_target1.Value = 58 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(59)
        ElseIf valu_target1.Value = 59 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(60)
        ElseIf valu_target1.Value = 60 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(61)
        ElseIf valu_target1.Value = 61 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(62)
        ElseIf valu_target1.Value = 62 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(63)
        ElseIf valu_target1.Value = 63 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(64)
        ElseIf valu_target1.Value = 64 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(65)
        ElseIf valu_target1.Value = 65 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(66)
        ElseIf valu_target1.Value = 66 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(67)
        ElseIf valu_target1.Value = 67 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(68)
        ElseIf valu_target1.Value = 68 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(69)
        ElseIf valu_target1.Value = 69 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(70)
        ElseIf valu_target1.Value = 70 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(71)
        ElseIf valu_target1.Value = 71 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(72)
        ElseIf valu_target1.Value = 72 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(73)
        ElseIf valu_target1.Value = 73 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(74)
        ElseIf valu_target1.Value = 74 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(75)
        ElseIf valu_target1.Value = 75 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(76)
        ElseIf valu_target1.Value = 76 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(77)
        ElseIf valu_target1.Value = 77 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(78)
        ElseIf valu_target1.Value = 78 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(79)
        ElseIf valu_target1.Value = 79 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(80)
        ElseIf valu_target1.Value = 80 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(81)
        ElseIf valu_target1.Value = 81 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(82)
        ElseIf valu_target1.Value = 82 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(83)
        ElseIf valu_target1.Value = 83 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(84)
        ElseIf valu_target1.Value = 84 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(85)
        ElseIf valu_target1.Value = 85 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(86)
        ElseIf valu_target1.Value = 86 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(87)
        ElseIf valu_target1.Value = 87 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(88)
        ElseIf valu_target1.Value = 88 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(89)
        ElseIf valu_target1.Value = 89 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(90)
        ElseIf valu_target1.Value = 90 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(91)
        ElseIf valu_target1.Value = 91 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(92)
        ElseIf valu_target1.Value = 92 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(93)
        ElseIf valu_target1.Value = 93 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(94)
        ElseIf valu_target1.Value = 94 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(95)
        ElseIf valu_target1.Value = 95 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(96)
        ElseIf valu_target1.Value = 96 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(97)
        ElseIf valu_target1.Value = 97 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(98)
        ElseIf valu_target1.Value = 98 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(99)
        ElseIf valu_target1.Value = 99 Then
            Select_target1.SelectedItem = Select_target1.Items.Item(100)
        End If
        If valu_target1.Value = 65535 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(0)
        ElseIf valu_target1.Value = 2 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(1)
        ElseIf valu_target1.Value = 5 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(2)
        ElseIf valu_target1.Value = 10 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(3)
        ElseIf valu_target1.Value = 16 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(4)
        ElseIf valu_target1.Value = 20 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(5)
        ElseIf valu_target1.Value = 23 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(6)
        ElseIf valu_target1.Value = 26 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(7)
        ElseIf valu_target1.Value = 27 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(8)
        ElseIf valu_target1.Value = 29 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(9)
        ElseIf valu_target1.Value = 31 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(10)
        ElseIf valu_target1.Value = 32 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(11)
        ElseIf valu_target1.Value = 34 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(12)
        ElseIf valu_target1.Value = 36 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(13)
        ElseIf valu_target1.Value = 38 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(14)
        ElseIf valu_target1.Value = 40 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(15)
        ElseIf valu_target1.Value = 42 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(16)
        ElseIf valu_target1.Value = 44 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(17)
        ElseIf valu_target1.Value = 45 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(18)
        ElseIf valu_target1.Value = 46 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(19)
        ElseIf valu_target1.Value = 47 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(20)
        ElseIf valu_target1.Value = 48 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(21)
        ElseIf valu_target1.Value = 49 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(22)
        ElseIf valu_target1.Value = 50 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(23)
        ElseIf valu_target1.Value = 51 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(24)
        ElseIf valu_target1.Value = 53 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(25)
        ElseIf valu_target1.Value = 54 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(26)
        ElseIf valu_target1.Value = 56 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(27)
        ElseIf valu_target1.Value = 58 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(28)
        ElseIf valu_target1.Value = 61 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(29)
        ElseIf valu_target1.Value = 62 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(30)
        ElseIf valu_target1.Value = 63 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(31)
        ElseIf valu_target1.Value = 66 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(32)
        ElseIf valu_target1.Value = 67 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(33)
        ElseIf valu_target1.Value = 69 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(34)
        ElseIf valu_target1.Value = 70 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(35)
        ElseIf valu_target1.Value = 73 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(36)
        ElseIf valu_target1.Value = 76 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(37)
        ElseIf valu_target1.Value = 77 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(38)
        ElseIf valu_target1.Value = 80 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(39)
        ElseIf valu_target1.Value = 86 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(40)
        ElseIf valu_target1.Value = 87 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(41)
        ElseIf valu_target1.Value = 89 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(42)
        ElseIf valu_target1.Value = 90 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(43)
        ElseIf valu_target1.Value = 91 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(44)
        ElseIf valu_target1.Value = 92 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(45)
        ElseIf valu_target1.Value = 96 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(46)
        ElseIf valu_target1.Value = 97 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(47)
        ElseIf valu_target1.Value = 98 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(48)
        ElseIf valu_target1.Value = 99 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(49)
        ElseIf valu_target1.Value = 100 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(50)
        ElseIf valu_target1.Value = 101 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(51)
        ElseIf valu_target1.Value = 102 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(52)
        ElseIf valu_target1.Value = 103 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(53)
        ElseIf valu_target1.Value = 104 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(54)
        ElseIf valu_target1.Value = 105 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(55)
        ElseIf valu_target1.Value = 106 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(56)
        ElseIf valu_target1.Value = 107 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(57)
        ElseIf valu_target1.Value = 108 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(58)
        ElseIf valu_target1.Value = 109 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(59)
        ElseIf valu_target1.Value = 110 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(60)
        ElseIf valu_target1.Value = 112 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(61)
        ElseIf valu_target1.Value = 114 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(62)
        ElseIf valu_target1.Value = 115 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(63)
        ElseIf valu_target1.Value = 117 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(64)
        ElseIf valu_target1.Value = 119 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(65)
        ElseIf valu_target1.Value = 122 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(66)
        ElseIf valu_target1.Value = 123 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(67)
        ElseIf valu_target1.Value = 126 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(68)
        ElseIf valu_target1.Value = 132 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(69)
        ElseIf valu_target1.Value = 135 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(70)
        ElseIf valu_target1.Value = 136 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(71)
        ElseIf valu_target1.Value = 137 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(72)
        ElseIf valu_target1.Value = 138 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(73)
        ElseIf valu_target1.Value = 139 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(74)
        ElseIf valu_target1.Value = 140 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(75)
        ElseIf valu_target1.Value = 141 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(76)
        ElseIf valu_target1.Value = 142 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(77)
        ElseIf valu_target1.Value = 143 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(78)
        ElseIf valu_target1.Value = 144 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(79)
        ElseIf valu_target1.Value = 146 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(80)
        ElseIf valu_target1.Value = 147 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(81)
        ElseIf valu_target1.Value = 148 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(82)
        ElseIf valu_target1.Value = 149 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(83)
        ElseIf valu_target1.Value = 150 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(84)
        ElseIf valu_target1.Value = 151 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(85)
        ElseIf valu_target1.Value = 152 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(86)
        ElseIf valu_target1.Value = 153 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(87)
        ElseIf valu_target1.Value = 154 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(88)
        ElseIf valu_target1.Value = 155 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(89)
        ElseIf valu_target1.Value = 156 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(90)
        ElseIf valu_target1.Value = 157 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(91)
        ElseIf valu_target1.Value = 158 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(92)
        ElseIf valu_target1.Value = 159 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(93)
        ElseIf valu_target1.Value = 160 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(94)
        ElseIf valu_target1.Value = 161 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(95)
        ElseIf valu_target1.Value = 162 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(96)
        ElseIf valu_target1.Value = 163 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(97)
        ElseIf valu_target1.Value = 164 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(98)
        ElseIf valu_target1.Value = 165 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(99)
        ElseIf valu_target1.Value = 166 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(100)
        ElseIf valu_target1.Value = 167 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(101)
        ElseIf valu_target1.Value = 168 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(102)
        ElseIf valu_target1.Value = 169 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(103)
        ElseIf valu_target1.Value = 170 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(104)
        ElseIf valu_target1.Value = 171 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(105)
        ElseIf valu_target1.Value = 172 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(106)
        ElseIf valu_target1.Value = 173 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(107)
        ElseIf valu_target1.Value = 174 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(108)
        ElseIf valu_target1.Value = 175 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(109)
        ElseIf valu_target1.Value = 178 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(110)
        ElseIf valu_target1.Value = 180 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(111)
        ElseIf valu_target1.Value = 182 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(112)
        ElseIf valu_target1.Value = 183 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(113)
        ElseIf valu_target1.Value = 185 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(114)
        ElseIf valu_target1.Value = 186 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(115)
        ElseIf valu_target1.Value = 187 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(116)
        ElseIf valu_target1.Value = 188 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(117)
        ElseIf valu_target1.Value = 189 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(118)
        ElseIf valu_target1.Value = 190 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(119)
        ElseIf valu_target1.Value = 191 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(120)
        ElseIf valu_target1.Value = 192 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(121)
        ElseIf valu_target1.Value = 193 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(122)
        ElseIf valu_target1.Value = 194 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(123)
        ElseIf valu_target1.Value = 195 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(124)
        ElseIf valu_target1.Value = 197 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(125)
        ElseIf valu_target1.Value = 198 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(126)
        ElseIf valu_target1.Value = 199 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(127)
        ElseIf valu_target1.Value = 200 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(128)
        ElseIf valu_target1.Value = 201 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(129)
        ElseIf valu_target1.Value = 202 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(130)
        ElseIf valu_target1.Value = 205 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(131)
        ElseIf valu_target1.Value = 210 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(132)
        ElseIf valu_target1.Value = 216 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(133)
        ElseIf valu_target1.Value = 218 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(134)
        ElseIf valu_target1.Value = 222 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(135)
        ElseIf valu_target1.Value = 229 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(136)
        ElseIf valu_target1.Value = 230 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(137)
        ElseIf valu_target1.Value = 231 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(138)
        ElseIf valu_target1.Value = 232 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(139)
        ElseIf valu_target1.Value = 233 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(140)
        ElseIf valu_target1.Value = 234 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(141)
        ElseIf valu_target1.Value = 235 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(142)
        ElseIf valu_target1.Value = 236 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(143)
        ElseIf valu_target1.Value = 237 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(144)
        ElseIf valu_target1.Value = 238 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(145)
        ElseIf valu_target1.Value = 239 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(146)
        ElseIf valu_target1.Value = 240 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(147)
        ElseIf valu_target1.Value = 241 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(148)
        ElseIf valu_target1.Value = 242 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(149)
        ElseIf valu_target1.Value = 243 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(150)
        ElseIf valu_target1.Value = 244 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(151)
        ElseIf valu_target1.Value = 245 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(152)
        ElseIf valu_target1.Value = 246 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(153)
        ElseIf valu_target1.Value = 247 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(154)
        ElseIf valu_target1.Value = 248 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(155)
        ElseIf valu_target1.Value = 249 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(156)
        ElseIf valu_target1.Value = 250 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(157)
        ElseIf valu_target1.Value = 251 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(158)
        ElseIf valu_target1.Value = 252 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(159)
        ElseIf valu_target1.Value = 253 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(160)
        ElseIf valu_target1.Value = 297 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(161)
        ElseIf valu_target1.Value = 298 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(162)
        ElseIf valu_target1.Value = 299 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(163)
        ElseIf valu_target1.Value = 300 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(164)
        ElseIf valu_target1.Value = 301 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(165)
        ElseIf valu_target1.Value = 302 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(166)
        ElseIf valu_target1.Value = 303 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(167)
        ElseIf valu_target1.Value = 304 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(168)
        ElseIf valu_target1.Value = 305 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(169)
        ElseIf valu_target1.Value = 306 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(170)
        ElseIf valu_target1.Value = 307 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(171)
        ElseIf valu_target1.Value = 308 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(172)
        ElseIf valu_target1.Value = 309 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(173)
        ElseIf valu_target1.Value = 310 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(174)
        ElseIf valu_target1.Value = 311 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(175)
        ElseIf valu_target1.Value = 312 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(176)
        ElseIf valu_target1.Value = 314 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(177)
        ElseIf valu_target1.Value = 315 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(178)
        ElseIf valu_target1.Value = 316 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(179)
        ElseIf valu_target1.Value = 317 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(180)
        ElseIf valu_target1.Value = 318 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(181)
        ElseIf valu_target1.Value = 319 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(182)
        ElseIf valu_target1.Value = 320 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(183)
        ElseIf valu_target1.Value = 321 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(184)
        ElseIf valu_target1.Value = 322 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(185)
        ElseIf valu_target1.Value = 323 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(186)
        ElseIf valu_target1.Value = 324 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(187)
        ElseIf valu_target1.Value = 325 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(188)
        ElseIf valu_target1.Value = 326 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(189)
        ElseIf valu_target1.Value = 327 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(190)
        ElseIf valu_target1.Value = 328 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(191)
        ElseIf valu_target1.Value = 329 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(192)
        ElseIf valu_target1.Value = 330 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(193)
        ElseIf valu_target1.Value = 331 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(194)
        ElseIf valu_target1.Value = 332 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(195)
        ElseIf valu_target1.Value = 333 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(196)
        ElseIf valu_target1.Value = 334 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(197)
        ElseIf valu_target1.Value = 335 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(198)
        ElseIf valu_target1.Value = 336 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(199)
        ElseIf valu_target1.Value = 337 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(200)
        ElseIf valu_target1.Value = 338 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(201)
        ElseIf valu_target1.Value = 340 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(202)
        ElseIf valu_target1.Value = 342 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(203)
        ElseIf valu_target1.Value = 343 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(204)
        ElseIf valu_target1.Value = 344 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(205)
        ElseIf valu_target1.Value = 345 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(206)
        ElseIf valu_target1.Value = 346 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(207)
        ElseIf valu_target1.Value = 347 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(208)
        ElseIf valu_target1.Value = 348 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(209)
        ElseIf valu_target1.Value = 349 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(210)
        ElseIf valu_target1.Value = 350 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(211)
        ElseIf valu_target1.Value = 354 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(212)
        ElseIf valu_target1.Value = 355 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(213)
        ElseIf valu_target1.Value = 356 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(214)
        ElseIf valu_target1.Value = 357 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(215)
        ElseIf valu_target1.Value = 358 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(216)
        ElseIf valu_target1.Value = 359 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(217)
        ElseIf valu_target1.Value = 360 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(218)
        ElseIf valu_target1.Value = 361 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(219)
        ElseIf valu_target1.Value = 362 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(220)
        ElseIf valu_target1.Value = 363 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(221)
        ElseIf valu_target1.Value = 364 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(222)
        ElseIf valu_target1.Value = 365 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(223)
        ElseIf valu_target1.Value = 366 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(224)
        ElseIf valu_target1.Value = 367 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(225)
        ElseIf valu_target1.Value = 368 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(226)
        ElseIf valu_target1.Value = 369 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(227)
        ElseIf valu_target1.Value = 370 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(228)
        ElseIf valu_target1.Value = 371 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(229)
        ElseIf valu_target1.Value = 381 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(230)
        ElseIf valu_target1.Value = 0 Then
            Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(231)
        End If

        If valu_target1.Value = 65535 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(0)
        ElseIf valu_target1.Value = 0 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(1)
        ElseIf valu_target1.Value = 1 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(2)
        ElseIf valu_target1.Value = 2 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(3)
        ElseIf valu_target1.Value = 5 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(4)
        ElseIf valu_target1.Value = 14 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(5)
        ElseIf valu_target1.Value = 23 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(6)
        ElseIf valu_target1.Value = 27 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(7)
        ElseIf valu_target1.Value = 28 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(8)
        ElseIf valu_target1.Value = 29 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(9)
        ElseIf valu_target1.Value = 30 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(10)
        ElseIf valu_target1.Value = 31 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(11)
        ElseIf valu_target1.Value = 34 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(12)
        ElseIf valu_target1.Value = 36 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(13)
        ElseIf valu_target1.Value = 37 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(14)
        ElseIf valu_target1.Value = 38 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(15)
        ElseIf valu_target1.Value = 40 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(16)
        ElseIf valu_target1.Value = 41 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(17)
        ElseIf valu_target1.Value = 42 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(18)
        ElseIf valu_target1.Value = 43 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(19)
        ElseIf valu_target1.Value = 44 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(20)
        ElseIf valu_target1.Value = 45 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(21)
        ElseIf valu_target1.Value = 46 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(22)
        ElseIf valu_target1.Value = 47 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(23)
        ElseIf valu_target1.Value = 48 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(24)
        ElseIf valu_target1.Value = 49 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(25)
        ElseIf valu_target1.Value = 50 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(26)
        ElseIf valu_target1.Value = 51 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(27)
        ElseIf valu_target1.Value = 52 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(28)
        ElseIf valu_target1.Value = 53 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(29)
        ElseIf valu_target1.Value = 56 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(30)
        ElseIf valu_target1.Value = 58 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(31)
        ElseIf valu_target1.Value = 61 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(32)
        ElseIf valu_target1.Value = 63 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(33)
        ElseIf valu_target1.Value = 64 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(34)
        ElseIf valu_target1.Value = 66 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(35)
        ElseIf valu_target1.Value = 67 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(36)
        ElseIf valu_target1.Value = 69 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(37)
        ElseIf valu_target1.Value = 70 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(38)
        ElseIf valu_target1.Value = 73 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(39)
        ElseIf valu_target1.Value = 74 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(40)
        ElseIf valu_target1.Value = 76 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(41)
        ElseIf valu_target1.Value = 77 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(42)
        ElseIf valu_target1.Value = 80 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(43)
        ElseIf valu_target1.Value = 84 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(44)
        ElseIf valu_target1.Value = 86 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(45)
        ElseIf valu_target1.Value = 87 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(46)
        ElseIf valu_target1.Value = 88 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(47)
        ElseIf valu_target1.Value = 89 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(48)
        ElseIf valu_target1.Value = 91 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(49)
        ElseIf valu_target1.Value = 92 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(50)
        ElseIf valu_target1.Value = 95 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(51)
        ElseIf valu_target1.Value = 96 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(52)
        ElseIf valu_target1.Value = 97 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(53)
        ElseIf valu_target1.Value = 98 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(54)
        ElseIf valu_target1.Value = 99 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(55)
        ElseIf valu_target1.Value = 100 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(56)
        ElseIf valu_target1.Value = 101 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(57)
        ElseIf valu_target1.Value = 102 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(58)
        ElseIf valu_target1.Value = 103 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(59)
        ElseIf valu_target1.Value = 104 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(60)
        ElseIf valu_target1.Value = 105 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(61)
        ElseIf valu_target1.Value = 106 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(62)
        ElseIf valu_target1.Value = 107 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(63)
        ElseIf valu_target1.Value = 108 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(64)
        ElseIf valu_target1.Value = 109 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(65)
        ElseIf valu_target1.Value = 110 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(66)
        ElseIf valu_target1.Value = 112 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(67)
        ElseIf valu_target1.Value = 114 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(68)
        ElseIf valu_target1.Value = 115 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(69)
        ElseIf valu_target1.Value = 117 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(70)
        ElseIf valu_target1.Value = 119 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(71)
        ElseIf valu_target1.Value = 121 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(72)
        ElseIf valu_target1.Value = 122 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(73)
        ElseIf valu_target1.Value = 123 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(74)
        ElseIf valu_target1.Value = 125 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(75)
        ElseIf valu_target1.Value = 126 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(76)
        ElseIf valu_target1.Value = 132 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(77)
        ElseIf valu_target1.Value = 135 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(78)
        ElseIf valu_target1.Value = 136 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(79)
        ElseIf valu_target1.Value = 137 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(80)
        ElseIf valu_target1.Value = 138 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(81)
        ElseIf valu_target1.Value = 139 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(82)
        ElseIf valu_target1.Value = 140 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(83)
        ElseIf valu_target1.Value = 141 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(84)
        ElseIf valu_target1.Value = 142 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(85)
        ElseIf valu_target1.Value = 143 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(86)
        ElseIf valu_target1.Value = 144 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(87)
        ElseIf valu_target1.Value = 146 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(88)
        ElseIf valu_target1.Value = 147 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(89)
        ElseIf valu_target1.Value = 148 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(90)
        ElseIf valu_target1.Value = 149 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(91)
        ElseIf valu_target1.Value = 150 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(92)
        ElseIf valu_target1.Value = 151 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(93)
        ElseIf valu_target1.Value = 152 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(94)
        ElseIf valu_target1.Value = 153 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(95)
        ElseIf valu_target1.Value = 154 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(96)
        ElseIf valu_target1.Value = 155 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(97)
        ElseIf valu_target1.Value = 156 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(98)
        ElseIf valu_target1.Value = 157 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(99)
        ElseIf valu_target1.Value = 158 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(100)
        ElseIf valu_target1.Value = 159 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(101)
        ElseIf valu_target1.Value = 160 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(102)
        ElseIf valu_target1.Value = 161 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(103)
        ElseIf valu_target1.Value = 162 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(104)
        ElseIf valu_target1.Value = 163 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(105)
        ElseIf valu_target1.Value = 164 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(106)
        ElseIf valu_target1.Value = 165 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(107)
        ElseIf valu_target1.Value = 166 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(108)
        ElseIf valu_target1.Value = 167 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(109)
        ElseIf valu_target1.Value = 168 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(110)
        ElseIf valu_target1.Value = 169 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(111)
        ElseIf valu_target1.Value = 170 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(112)
        ElseIf valu_target1.Value = 171 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(113)
        ElseIf valu_target1.Value = 172 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(114)
        ElseIf valu_target1.Value = 173 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(115)
        ElseIf valu_target1.Value = 174 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(116)
        ElseIf valu_target1.Value = 175 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(117)
        ElseIf valu_target1.Value = 178 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(118)
        ElseIf valu_target1.Value = 180 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(119)
        ElseIf valu_target1.Value = 181 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(120)
        ElseIf valu_target1.Value = 182 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(121)
        ElseIf valu_target1.Value = 183 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(122)
        ElseIf valu_target1.Value = 185 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(123)
        ElseIf valu_target1.Value = 186 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(124)
        ElseIf valu_target1.Value = 187 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(125)
        ElseIf valu_target1.Value = 188 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(126)
        ElseIf valu_target1.Value = 189 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(127)
        ElseIf valu_target1.Value = 190 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(128)
        ElseIf valu_target1.Value = 191 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(129)
        ElseIf valu_target1.Value = 192 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(130)
        ElseIf valu_target1.Value = 193 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(131)
        ElseIf valu_target1.Value = 194 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(132)
        ElseIf valu_target1.Value = 195 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(133)
        ElseIf valu_target1.Value = 197 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(134)
        ElseIf valu_target1.Value = 198 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(135)
        ElseIf valu_target1.Value = 199 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(136)
        ElseIf valu_target1.Value = 201 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(137)
        ElseIf valu_target1.Value = 202 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(138)
        ElseIf valu_target1.Value = 210 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(139)
        ElseIf valu_target1.Value = 214 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(140)
        ElseIf valu_target1.Value = 216 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(141)
        ElseIf valu_target1.Value = 218 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(142)
        ElseIf valu_target1.Value = 229 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(143)
        ElseIf valu_target1.Value = 230 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(144)
        ElseIf valu_target1.Value = 231 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(145)
        ElseIf valu_target1.Value = 232 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(146)
        ElseIf valu_target1.Value = 233 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(147)
        ElseIf valu_target1.Value = 234 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(148)
        ElseIf valu_target1.Value = 235 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(149)
        ElseIf valu_target1.Value = 236 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(150)
        ElseIf valu_target1.Value = 237 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(151)
        ElseIf valu_target1.Value = 238 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(152)
        ElseIf valu_target1.Value = 239 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(153)
        ElseIf valu_target1.Value = 240 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(154)
        ElseIf valu_target1.Value = 241 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(155)
        ElseIf valu_target1.Value = 242 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(156)
        ElseIf valu_target1.Value = 243 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(157)
        ElseIf valu_target1.Value = 244 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(158)
        ElseIf valu_target1.Value = 245 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(159)
        ElseIf valu_target1.Value = 246 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(160)
        ElseIf valu_target1.Value = 247 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(161)
        ElseIf valu_target1.Value = 248 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(162)
        ElseIf valu_target1.Value = 249 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(163)
        ElseIf valu_target1.Value = 250 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(164)
        ElseIf valu_target1.Value = 251 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(165)
        ElseIf valu_target1.Value = 252 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(166)
        ElseIf valu_target1.Value = 253 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(167)
        ElseIf valu_target1.Value = 254 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(168)
        ElseIf valu_target1.Value = 255 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(169)
        ElseIf valu_target1.Value = 256 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(170)
        ElseIf valu_target1.Value = 257 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(171)
        ElseIf valu_target1.Value = 258 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(172)
        ElseIf valu_target1.Value = 259 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(173)
        ElseIf valu_target1.Value = 260 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(174)
        ElseIf valu_target1.Value = 261 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(175)
        ElseIf valu_target1.Value = 262 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(176)
        ElseIf valu_target1.Value = 263 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(177)
        ElseIf valu_target1.Value = 264 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(178)
        ElseIf valu_target1.Value = 265 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(179)
        ElseIf valu_target1.Value = 266 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(180)
        ElseIf valu_target1.Value = 267 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(181)
        ElseIf valu_target1.Value = 268 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(182)
        ElseIf valu_target1.Value = 269 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(183)
        ElseIf valu_target1.Value = 270 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(184)
        ElseIf valu_target1.Value = 271 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(185)
        ElseIf valu_target1.Value = 272 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(186)
        ElseIf valu_target1.Value = 273 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(187)
        ElseIf valu_target1.Value = 274 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(188)
        ElseIf valu_target1.Value = 275 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(189)
        ElseIf valu_target1.Value = 276 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(190)
        ElseIf valu_target1.Value = 277 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(191)
        ElseIf valu_target1.Value = 278 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(192)
        ElseIf valu_target1.Value = 279 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(193)
        ElseIf valu_target1.Value = 280 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(194)
        ElseIf valu_target1.Value = 281 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(195)
        ElseIf valu_target1.Value = 282 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(196)
        ElseIf valu_target1.Value = 283 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(197)
        ElseIf valu_target1.Value = 284 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(198)
        ElseIf valu_target1.Value = 285 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(199)
        ElseIf valu_target1.Value = 286 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(200)
        ElseIf valu_target1.Value = 287 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(201)
        ElseIf valu_target1.Value = 288 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(202)
        ElseIf valu_target1.Value = 289 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(203)
        ElseIf valu_target1.Value = 290 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(204)
        ElseIf valu_target1.Value = 291 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(205)
        ElseIf valu_target1.Value = 292 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(206)
        ElseIf valu_target1.Value = 293 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(207)
        ElseIf valu_target1.Value = 294 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(208)
        ElseIf valu_target1.Value = 295 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(209)
        ElseIf valu_target1.Value = 296 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(210)
        ElseIf valu_target1.Value = 297 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(211)
        ElseIf valu_target1.Value = 298 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(212)
        ElseIf valu_target1.Value = 299 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(213)
        ElseIf valu_target1.Value = 300 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(214)
        ElseIf valu_target1.Value = 301 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(215)
        ElseIf valu_target1.Value = 302 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(216)
        ElseIf valu_target1.Value = 303 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(217)
        ElseIf valu_target1.Value = 351 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(218)
        ElseIf valu_target1.Value = 352 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(219)
        ElseIf valu_target1.Value = 353 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(220)
        ElseIf valu_target1.Value = 369 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(221)
        ElseIf valu_target1.Value = 372 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(222)
        ElseIf valu_target1.Value = 373 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(223)
        ElseIf valu_target1.Value = 374 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(224)
        ElseIf valu_target1.Value = 375 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(225)
        ElseIf valu_target1.Value = 376 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(226)
        ElseIf valu_target1.Value = 377 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(227)
        ElseIf valu_target1.Value = 378 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(228)
        ElseIf valu_target1.Value = 379 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(229)
        ElseIf valu_target1.Value = 380 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(230)
        ElseIf valu_target1.Value = 72 Then
            Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(231)
        End If
    End Sub

    Private Sub valu_target2_ValueChanged(sender As Object, e As EventArgs) Handles valu_target2.ValueChanged
        If valu_target2.Value = 65535 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(0)
        ElseIf valu_target2.Value = 0 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(1)
        ElseIf valu_target2.Value = 1 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(2)
        ElseIf valu_target2.Value = 2 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(3)
        ElseIf valu_target2.Value = 3 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(4)
        ElseIf valu_target2.Value = 4 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(5)
        ElseIf valu_target2.Value = 5 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(6)
        ElseIf valu_target2.Value = 6 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(7)
        ElseIf valu_target2.Value = 7 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(8)
        ElseIf valu_target2.Value = 8 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(9)
        ElseIf valu_target2.Value = 9 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(10)
        ElseIf valu_target2.Value = 10 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(11)
        ElseIf valu_target2.Value = 11 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(12)
        ElseIf valu_target2.Value = 12 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(13)
        ElseIf valu_target2.Value = 13 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(14)
        ElseIf valu_target2.Value = 14 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(15)
        ElseIf valu_target2.Value = 15 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(16)
        ElseIf valu_target2.Value = 16 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(17)
        ElseIf valu_target2.Value = 17 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(18)
        ElseIf valu_target2.Value = 18 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(19)
        ElseIf valu_target2.Value = 19 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(20)
        ElseIf valu_target2.Value = 20 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(21)
        ElseIf valu_target2.Value = 21 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(22)
        ElseIf valu_target2.Value = 22 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(23)
        ElseIf valu_target2.Value = 23 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(24)
        ElseIf valu_target2.Value = 24 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(25)
        ElseIf valu_target2.Value = 25 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(26)
        ElseIf valu_target2.Value = 26 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(27)
        ElseIf valu_target2.Value = 27 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(28)
        ElseIf valu_target2.Value = 28 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(29)
        ElseIf valu_target2.Value = 29 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(30)
        ElseIf valu_target2.Value = 30 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(31)
        ElseIf valu_target2.Value = 31 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(32)
        ElseIf valu_target2.Value = 32 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(33)
        ElseIf valu_target2.Value = 33 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(34)
        ElseIf valu_target2.Value = 34 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(35)
        ElseIf valu_target2.Value = 35 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(36)
        ElseIf valu_target2.Value = 36 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(37)
        ElseIf valu_target2.Value = 37 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(38)
        ElseIf valu_target2.Value = 38 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(39)
        ElseIf valu_target2.Value = 39 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(40)
        ElseIf valu_target2.Value = 40 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(41)
        ElseIf valu_target2.Value = 41 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(42)
        ElseIf valu_target2.Value = 42 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(43)
        ElseIf valu_target2.Value = 43 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(44)
        ElseIf valu_target2.Value = 44 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(45)
        ElseIf valu_target2.Value = 45 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(46)
        ElseIf valu_target2.Value = 46 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(47)
        ElseIf valu_target2.Value = 47 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(48)
        ElseIf valu_target2.Value = 48 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(49)
        ElseIf valu_target2.Value = 49 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(50)
        ElseIf valu_target2.Value = 50 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(51)
        ElseIf valu_target2.Value = 51 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(52)
        ElseIf valu_target2.Value = 52 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(53)
        ElseIf valu_target2.Value = 53 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(54)
        ElseIf valu_target2.Value = 54 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(55)
        ElseIf valu_target2.Value = 55 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(56)
        ElseIf valu_target2.Value = 56 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(57)
        ElseIf valu_target2.Value = 57 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(58)
        ElseIf valu_target2.Value = 58 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(59)
        ElseIf valu_target2.Value = 59 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(60)
        ElseIf valu_target2.Value = 60 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(61)
        ElseIf valu_target2.Value = 61 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(62)
        ElseIf valu_target2.Value = 62 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(63)
        ElseIf valu_target2.Value = 63 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(64)
        ElseIf valu_target2.Value = 64 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(65)
        ElseIf valu_target2.Value = 65 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(66)
        ElseIf valu_target2.Value = 66 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(67)
        ElseIf valu_target2.Value = 67 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(68)
        ElseIf valu_target2.Value = 68 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(69)
        ElseIf valu_target2.Value = 69 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(70)
        ElseIf valu_target2.Value = 70 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(71)
        ElseIf valu_target2.Value = 71 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(72)
        ElseIf valu_target2.Value = 72 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(73)
        ElseIf valu_target2.Value = 73 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(74)
        ElseIf valu_target2.Value = 74 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(75)
        ElseIf valu_target2.Value = 75 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(76)
        ElseIf valu_target2.Value = 76 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(77)
        ElseIf valu_target2.Value = 77 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(78)
        ElseIf valu_target2.Value = 78 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(79)
        ElseIf valu_target2.Value = 79 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(80)
        ElseIf valu_target2.Value = 80 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(81)
        ElseIf valu_target2.Value = 81 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(82)
        ElseIf valu_target2.Value = 82 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(83)
        ElseIf valu_target2.Value = 83 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(84)
        ElseIf valu_target2.Value = 84 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(85)
        ElseIf valu_target2.Value = 85 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(86)
        ElseIf valu_target2.Value = 86 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(87)
        ElseIf valu_target2.Value = 87 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(88)
        ElseIf valu_target2.Value = 88 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(89)
        ElseIf valu_target2.Value = 89 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(90)
        ElseIf valu_target2.Value = 90 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(91)
        ElseIf valu_target2.Value = 91 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(92)
        ElseIf valu_target2.Value = 92 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(93)
        ElseIf valu_target2.Value = 93 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(94)
        ElseIf valu_target2.Value = 94 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(95)
        ElseIf valu_target2.Value = 95 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(96)
        ElseIf valu_target2.Value = 96 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(97)
        ElseIf valu_target2.Value = 97 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(98)
        ElseIf valu_target2.Value = 98 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(99)
        ElseIf valu_target2.Value = 99 Then
            Select_target2.SelectedItem = Select_target2.Items.Item(100)
        End If
    End Sub

    Private Sub Select_target1_foodUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_target1_foodUS.SelectedIndexChanged
        If Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(0) Then
            valu_target1.Value = 65535
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(1) Then
            valu_target1.Value = 0
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(2) Then
            valu_target1.Value = 1
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(3) Then
            valu_target1.Value = 2
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(4) Then
            valu_target1.Value = 5
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(5) Then
            valu_target1.Value = 14
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(6) Then
            valu_target1.Value = 23
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(7) Then
            valu_target1.Value = 27
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(8) Then
            valu_target1.Value = 28
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(9) Then
            valu_target1.Value = 29
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(10) Then
            valu_target1.Value = 30
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(11) Then
            valu_target1.Value = 31
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(12) Then
            valu_target1.Value = 34
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(13) Then
            valu_target1.Value = 36
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(14) Then
            valu_target1.Value = 37
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(15) Then
            valu_target1.Value = 38
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(16) Then
            valu_target1.Value = 40
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(17) Then
            valu_target1.Value = 41
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(18) Then
            valu_target1.Value = 42
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(19) Then
            valu_target1.Value = 43
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(20) Then
            valu_target1.Value = 44
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(21) Then
            valu_target1.Value = 45
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(22) Then
            valu_target1.Value = 46
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(23) Then
            valu_target1.Value = 47
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(24) Then
            valu_target1.Value = 48
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(25) Then
            valu_target1.Value = 49
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(26) Then
            valu_target1.Value = 50
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(27) Then
            valu_target1.Value = 51
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(28) Then
            valu_target1.Value = 52
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(29) Then
            valu_target1.Value = 53
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(30) Then
            valu_target1.Value = 56
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(31) Then
            valu_target1.Value = 58
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(32) Then
            valu_target1.Value = 61
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(33) Then
            valu_target1.Value = 63
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(34) Then
            valu_target1.Value = 64
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(35) Then
            valu_target1.Value = 66
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(36) Then
            valu_target1.Value = 67
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(37) Then
            valu_target1.Value = 69
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(38) Then
            valu_target1.Value = 70
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(39) Then
            valu_target1.Value = 73
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(40) Then
            valu_target1.Value = 74
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(41) Then
            valu_target1.Value = 76
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(42) Then
            valu_target1.Value = 77
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(43) Then
            valu_target1.Value = 80
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(44) Then
            valu_target1.Value = 84
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(45) Then
            valu_target1.Value = 86
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(46) Then
            valu_target1.Value = 87
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(47) Then
            valu_target1.Value = 88
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(48) Then
            valu_target1.Value = 89
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(49) Then
            valu_target1.Value = 91
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(50) Then
            valu_target1.Value = 92
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(51) Then
            valu_target1.Value = 95
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(52) Then
            valu_target1.Value = 96
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(53) Then
            valu_target1.Value = 97
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(54) Then
            valu_target1.Value = 98
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(55) Then
            valu_target1.Value = 99
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(56) Then
            valu_target1.Value = 100
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(57) Then
            valu_target1.Value = 101
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(58) Then
            valu_target1.Value = 102
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(59) Then
            valu_target1.Value = 103
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(60) Then
            valu_target1.Value = 104
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(61) Then
            valu_target1.Value = 105
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(62) Then
            valu_target1.Value = 106
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(63) Then
            valu_target1.Value = 107
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(64) Then
            valu_target1.Value = 108
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(65) Then
            valu_target1.Value = 109
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(66) Then
            valu_target1.Value = 110
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(67) Then
            valu_target1.Value = 112
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(68) Then
            valu_target1.Value = 114
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(69) Then
            valu_target1.Value = 115
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(70) Then
            valu_target1.Value = 117
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(71) Then
            valu_target1.Value = 119
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(72) Then
            valu_target1.Value = 121
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(73) Then
            valu_target1.Value = 122
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(74) Then
            valu_target1.Value = 123
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(75) Then
            valu_target1.Value = 125
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(76) Then
            valu_target1.Value = 126
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(77) Then
            valu_target1.Value = 132
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(78) Then
            valu_target1.Value = 135
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(79) Then
            valu_target1.Value = 136
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(80) Then
            valu_target1.Value = 137
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(81) Then
            valu_target1.Value = 138
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(82) Then
            valu_target1.Value = 139
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(83) Then
            valu_target1.Value = 140
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(84) Then
            valu_target1.Value = 141
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(85) Then
            valu_target1.Value = 142
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(86) Then
            valu_target1.Value = 143
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(87) Then
            valu_target1.Value = 144
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(88) Then
            valu_target1.Value = 146
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(89) Then
            valu_target1.Value = 147
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(90) Then
            valu_target1.Value = 148
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(91) Then
            valu_target1.Value = 149
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(92) Then
            valu_target1.Value = 150
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(93) Then
            valu_target1.Value = 151
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(94) Then
            valu_target1.Value = 152
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(95) Then
            valu_target1.Value = 153
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(96) Then
            valu_target1.Value = 154
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(97) Then
            valu_target1.Value = 155
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(98) Then
            valu_target1.Value = 156
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(99) Then
            valu_target1.Value = 157
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(100) Then
            valu_target1.Value = 158
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(101) Then
            valu_target1.Value = 159
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(102) Then
            valu_target1.Value = 160
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(103) Then
            valu_target1.Value = 161
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(104) Then
            valu_target1.Value = 162
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(105) Then
            valu_target1.Value = 163
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(106) Then
            valu_target1.Value = 164
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(107) Then
            valu_target1.Value = 165
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(108) Then
            valu_target1.Value = 166
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(109) Then
            valu_target1.Value = 167
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(110) Then
            valu_target1.Value = 168
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(111) Then
            valu_target1.Value = 169
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(112) Then
            valu_target1.Value = 170
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(113) Then
            valu_target1.Value = 171
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(114) Then
            valu_target1.Value = 172
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(115) Then
            valu_target1.Value = 173
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(116) Then
            valu_target1.Value = 174
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(117) Then
            valu_target1.Value = 175
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(118) Then
            valu_target1.Value = 178
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(119) Then
            valu_target1.Value = 180
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(120) Then
            valu_target1.Value = 181
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(121) Then
            valu_target1.Value = 182
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(122) Then
            valu_target1.Value = 183
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(123) Then
            valu_target1.Value = 185
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(124) Then
            valu_target1.Value = 186
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(125) Then
            valu_target1.Value = 187
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(126) Then
            valu_target1.Value = 188
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(127) Then
            valu_target1.Value = 189
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(128) Then
            valu_target1.Value = 190
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(129) Then
            valu_target1.Value = 191
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(130) Then
            valu_target1.Value = 192
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(131) Then
            valu_target1.Value = 193
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(132) Then
            valu_target1.Value = 194
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(133) Then
            valu_target1.Value = 195
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(134) Then
            valu_target1.Value = 197
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(135) Then
            valu_target1.Value = 198
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(136) Then
            valu_target1.Value = 199
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(137) Then
            valu_target1.Value = 201
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(138) Then
            valu_target1.Value = 202
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(139) Then
            valu_target1.Value = 210
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(140) Then
            valu_target1.Value = 214
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(141) Then
            valu_target1.Value = 216
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(142) Then
            valu_target1.Value = 218
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(143) Then
            valu_target1.Value = 229
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(144) Then
            valu_target1.Value = 230
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(145) Then
            valu_target1.Value = 231
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(146) Then
            valu_target1.Value = 232
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(147) Then
            valu_target1.Value = 233
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(148) Then
            valu_target1.Value = 234
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(149) Then
            valu_target1.Value = 235
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(150) Then
            valu_target1.Value = 236
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(151) Then
            valu_target1.Value = 237
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(152) Then
            valu_target1.Value = 238
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(153) Then
            valu_target1.Value = 239
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(154) Then
            valu_target1.Value = 240
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(155) Then
            valu_target1.Value = 241
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(156) Then
            valu_target1.Value = 242
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(157) Then
            valu_target1.Value = 243
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(158) Then
            valu_target1.Value = 244
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(159) Then
            valu_target1.Value = 245
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(160) Then
            valu_target1.Value = 246
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(161) Then
            valu_target1.Value = 247
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(162) Then
            valu_target1.Value = 248
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(163) Then
            valu_target1.Value = 249
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(164) Then
            valu_target1.Value = 250
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(165) Then
            valu_target1.Value = 251
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(166) Then
            valu_target1.Value = 252
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(167) Then
            valu_target1.Value = 253
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(168) Then
            valu_target1.Value = 254
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(169) Then
            valu_target1.Value = 255
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(170) Then
            valu_target1.Value = 256
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(171) Then
            valu_target1.Value = 257
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(172) Then
            valu_target1.Value = 258
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(173) Then
            valu_target1.Value = 259
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(174) Then
            valu_target1.Value = 260
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(175) Then
            valu_target1.Value = 261
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(176) Then
            valu_target1.Value = 262
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(177) Then
            valu_target1.Value = 263
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(178) Then
            valu_target1.Value = 264
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(179) Then
            valu_target1.Value = 265
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(180) Then
            valu_target1.Value = 266
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(181) Then
            valu_target1.Value = 267
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(182) Then
            valu_target1.Value = 268
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(183) Then
            valu_target1.Value = 269
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(184) Then
            valu_target1.Value = 270
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(185) Then
            valu_target1.Value = 271
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(186) Then
            valu_target1.Value = 272
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(187) Then
            valu_target1.Value = 273
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(188) Then
            valu_target1.Value = 274
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(189) Then
            valu_target1.Value = 275
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(190) Then
            valu_target1.Value = 276
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(191) Then
            valu_target1.Value = 277
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(192) Then
            valu_target1.Value = 278
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(193) Then
            valu_target1.Value = 279
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(194) Then
            valu_target1.Value = 280
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(195) Then
            valu_target1.Value = 281
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(196) Then
            valu_target1.Value = 282
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(197) Then
            valu_target1.Value = 283
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(198) Then
            valu_target1.Value = 284
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(199) Then
            valu_target1.Value = 285
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(200) Then
            valu_target1.Value = 286
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(201) Then
            valu_target1.Value = 287
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(202) Then
            valu_target1.Value = 288
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(203) Then
            valu_target1.Value = 289
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(204) Then
            valu_target1.Value = 290
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(205) Then
            valu_target1.Value = 291
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(206) Then
            valu_target1.Value = 292
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(207) Then
            valu_target1.Value = 293
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(208) Then
            valu_target1.Value = 294
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(209) Then
            valu_target1.Value = 295
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(210) Then
            valu_target1.Value = 296
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(211) Then
            valu_target1.Value = 297
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(212) Then
            valu_target1.Value = 298
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(213) Then
            valu_target1.Value = 299
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(214) Then
            valu_target1.Value = 300
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(215) Then
            valu_target1.Value = 301
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(216) Then
            valu_target1.Value = 302
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(217) Then
            valu_target1.Value = 303
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(218) Then
            valu_target1.Value = 351
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(219) Then
            valu_target1.Value = 352
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(220) Then
            valu_target1.Value = 353
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(221) Then
            valu_target1.Value = 369
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(222) Then
            valu_target1.Value = 372
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(223) Then
            valu_target1.Value = 373
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(224) Then
            valu_target1.Value = 374
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(225) Then
            valu_target1.Value = 375
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(226) Then
            valu_target1.Value = 376
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(227) Then
            valu_target1.Value = 377
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(228) Then
            valu_target1.Value = 378
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(229) Then
            valu_target1.Value = 379
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(230) Then
            valu_target1.Value = 380
        ElseIf Select_target1_foodUS.SelectedItem = Select_target1_foodUS.Items.Item(231) Then
            valu_target1.Value = 72
        End If
    End Sub

    Private Sub Select_target1_foodEU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_target1_foodEU.SelectedIndexChanged
        If Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(0) Then
            valu_target1.Value = 65535
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(1) Then
            valu_target1.Value = 2
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(2) Then
            valu_target1.Value = 5
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(3) Then
            valu_target1.Value = 10
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(4) Then
            valu_target1.Value = 16
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(5) Then
            valu_target1.Value = 20
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(6) Then
            valu_target1.Value = 23
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(7) Then
            valu_target1.Value = 26
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(8) Then
            valu_target1.Value = 27
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(9) Then
            valu_target1.Value = 29
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(10) Then
            valu_target1.Value = 31
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(11) Then
            valu_target1.Value = 32
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(12) Then
            valu_target1.Value = 34
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(13) Then
            valu_target1.Value = 36
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(14) Then
            valu_target1.Value = 38
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(15) Then
            valu_target1.Value = 40
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(16) Then
            valu_target1.Value = 42
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(17) Then
            valu_target1.Value = 44
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(18) Then
            valu_target1.Value = 45
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(19) Then
            valu_target1.Value = 46
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(20) Then
            valu_target1.Value = 47
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(21) Then
            valu_target1.Value = 48
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(22) Then
            valu_target1.Value = 49
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(23) Then
            valu_target1.Value = 50
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(24) Then
            valu_target1.Value = 51
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(25) Then
            valu_target1.Value = 53
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(26) Then
            valu_target1.Value = 54
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(27) Then
            valu_target1.Value = 56
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(28) Then
            valu_target1.Value = 58
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(29) Then
            valu_target1.Value = 61
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(30) Then
            valu_target1.Value = 62
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(31) Then
            valu_target1.Value = 63
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(32) Then
            valu_target1.Value = 66
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(33) Then
            valu_target1.Value = 67
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(34) Then
            valu_target1.Value = 69
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(35) Then
            valu_target1.Value = 70
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(36) Then
            valu_target1.Value = 73
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(37) Then
            valu_target1.Value = 76
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(38) Then
            valu_target1.Value = 77
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(39) Then
            valu_target1.Value = 80
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(40) Then
            valu_target1.Value = 86
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(41) Then
            valu_target1.Value = 87
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(42) Then
            valu_target1.Value = 89
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(43) Then
            valu_target1.Value = 90
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(44) Then
            valu_target1.Value = 91
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(45) Then
            valu_target1.Value = 92
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(46) Then
            valu_target1.Value = 96
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(47) Then
            valu_target1.Value = 97
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(48) Then
            valu_target1.Value = 98
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(49) Then
            valu_target1.Value = 99
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(50) Then
            valu_target1.Value = 100
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(51) Then
            valu_target1.Value = 101
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(52) Then
            valu_target1.Value = 102
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(53) Then
            valu_target1.Value = 103
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(54) Then
            valu_target1.Value = 104
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(55) Then
            valu_target1.Value = 105
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(56) Then
            valu_target1.Value = 106
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(57) Then
            valu_target1.Value = 107
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(58) Then
            valu_target1.Value = 108
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(59) Then
            valu_target1.Value = 109
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(60) Then
            valu_target1.Value = 110
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(61) Then
            valu_target1.Value = 112
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(62) Then
            valu_target1.Value = 114
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(63) Then
            valu_target1.Value = 115
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(64) Then
            valu_target1.Value = 117
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(65) Then
            valu_target1.Value = 119
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(66) Then
            valu_target1.Value = 122
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(67) Then
            valu_target1.Value = 123
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(68) Then
            valu_target1.Value = 126
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(69) Then
            valu_target1.Value = 132
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(70) Then
            valu_target1.Value = 135
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(71) Then
            valu_target1.Value = 136
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(72) Then
            valu_target1.Value = 137
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(73) Then
            valu_target1.Value = 138
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(74) Then
            valu_target1.Value = 139
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(75) Then
            valu_target1.Value = 140
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(76) Then
            valu_target1.Value = 141
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(77) Then
            valu_target1.Value = 142
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(78) Then
            valu_target1.Value = 143
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(79) Then
            valu_target1.Value = 144
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(80) Then
            valu_target1.Value = 146
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(81) Then
            valu_target1.Value = 147
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(82) Then
            valu_target1.Value = 148
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(83) Then
            valu_target1.Value = 149
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(84) Then
            valu_target1.Value = 150
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(85) Then
            valu_target1.Value = 151
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(86) Then
            valu_target1.Value = 152
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(87) Then
            valu_target1.Value = 153
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(88) Then
            valu_target1.Value = 154
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(89) Then
            valu_target1.Value = 155
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(90) Then
            valu_target1.Value = 156
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(91) Then
            valu_target1.Value = 157
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(92) Then
            valu_target1.Value = 158
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(93) Then
            valu_target1.Value = 159
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(94) Then
            valu_target1.Value = 160
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(95) Then
            valu_target1.Value = 161
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(96) Then
            valu_target1.Value = 162
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(97) Then
            valu_target1.Value = 163
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(98) Then
            valu_target1.Value = 164
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(99) Then
            valu_target1.Value = 165
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(100) Then
            valu_target1.Value = 166
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(101) Then
            valu_target1.Value = 167
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(102) Then
            valu_target1.Value = 168
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(103) Then
            valu_target1.Value = 169
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(104) Then
            valu_target1.Value = 170
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(105) Then
            valu_target1.Value = 171
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(106) Then
            valu_target1.Value = 172
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(107) Then
            valu_target1.Value = 173
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(108) Then
            valu_target1.Value = 174
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(109) Then
            valu_target1.Value = 175
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(110) Then
            valu_target1.Value = 178
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(111) Then
            valu_target1.Value = 180
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(112) Then
            valu_target1.Value = 182
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(113) Then
            valu_target1.Value = 183
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(114) Then
            valu_target1.Value = 185
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(115) Then
            valu_target1.Value = 186
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(116) Then
            valu_target1.Value = 187
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(117) Then
            valu_target1.Value = 188
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(118) Then
            valu_target1.Value = 189
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(119) Then
            valu_target1.Value = 190
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(120) Then
            valu_target1.Value = 191
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(121) Then
            valu_target1.Value = 192
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(122) Then
            valu_target1.Value = 193
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(123) Then
            valu_target1.Value = 194
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(124) Then
            valu_target1.Value = 195
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(125) Then
            valu_target1.Value = 197
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(126) Then
            valu_target1.Value = 198
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(127) Then
            valu_target1.Value = 199
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(128) Then
            valu_target1.Value = 200
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(129) Then
            valu_target1.Value = 201
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(130) Then
            valu_target1.Value = 202
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(131) Then
            valu_target1.Value = 205
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(132) Then
            valu_target1.Value = 210
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(133) Then
            valu_target1.Value = 216
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(134) Then
            valu_target1.Value = 218
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(135) Then
            valu_target1.Value = 222
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(136) Then
            valu_target1.Value = 229
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(137) Then
            valu_target1.Value = 230
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(138) Then
            valu_target1.Value = 231
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(139) Then
            valu_target1.Value = 232
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(140) Then
            valu_target1.Value = 233
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(141) Then
            valu_target1.Value = 234
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(142) Then
            valu_target1.Value = 235
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(143) Then
            valu_target1.Value = 236
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(144) Then
            valu_target1.Value = 237
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(145) Then
            valu_target1.Value = 238
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(146) Then
            valu_target1.Value = 239
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(147) Then
            valu_target1.Value = 240
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(148) Then
            valu_target1.Value = 241
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(149) Then
            valu_target1.Value = 242
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(150) Then
            valu_target1.Value = 243
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(151) Then
            valu_target1.Value = 244
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(152) Then
            valu_target1.Value = 245
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(153) Then
            valu_target1.Value = 246
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(154) Then
            valu_target1.Value = 247
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(155) Then
            valu_target1.Value = 248
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(156) Then
            valu_target1.Value = 249
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(157) Then
            valu_target1.Value = 250
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(158) Then
            valu_target1.Value = 251
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(159) Then
            valu_target1.Value = 252
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(160) Then
            valu_target1.Value = 253
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(161) Then
            valu_target1.Value = 297
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(162) Then
            valu_target1.Value = 298
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(163) Then
            valu_target1.Value = 299
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(164) Then
            valu_target1.Value = 300
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(165) Then
            valu_target1.Value = 301
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(166) Then
            valu_target1.Value = 302
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(167) Then
            valu_target1.Value = 303
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(168) Then
            valu_target1.Value = 304
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(169) Then
            valu_target1.Value = 305
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(170) Then
            valu_target1.Value = 306
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(171) Then
            valu_target1.Value = 307
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(172) Then
            valu_target1.Value = 308
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(173) Then
            valu_target1.Value = 309
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(174) Then
            valu_target1.Value = 310
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(175) Then
            valu_target1.Value = 311
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(176) Then
            valu_target1.Value = 312
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(177) Then
            valu_target1.Value = 314
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(178) Then
            valu_target1.Value = 315
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(179) Then
            valu_target1.Value = 316
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(180) Then
            valu_target1.Value = 317
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(181) Then
            valu_target1.Value = 318
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(182) Then
            valu_target1.Value = 319
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(183) Then
            valu_target1.Value = 320
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(184) Then
            valu_target1.Value = 321
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(185) Then
            valu_target1.Value = 322
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(186) Then
            valu_target1.Value = 323
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(187) Then
            valu_target1.Value = 324
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(188) Then
            valu_target1.Value = 325
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(189) Then
            valu_target1.Value = 326
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(190) Then
            valu_target1.Value = 327
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(191) Then
            valu_target1.Value = 328
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(192) Then
            valu_target1.Value = 329
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(193) Then
            valu_target1.Value = 330
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(194) Then
            valu_target1.Value = 331
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(195) Then
            valu_target1.Value = 332
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(196) Then
            valu_target1.Value = 333
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(197) Then
            valu_target1.Value = 334
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(198) Then
            valu_target1.Value = 335
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(199) Then
            valu_target1.Value = 336
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(200) Then
            valu_target1.Value = 337
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(201) Then
            valu_target1.Value = 338
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(202) Then
            valu_target1.Value = 340
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(203) Then
            valu_target1.Value = 342
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(204) Then
            valu_target1.Value = 343
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(205) Then
            valu_target1.Value = 344
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(206) Then
            valu_target1.Value = 345
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(207) Then
            valu_target1.Value = 346
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(208) Then
            valu_target1.Value = 347
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(209) Then
            valu_target1.Value = 348
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(210) Then
            valu_target1.Value = 349
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(211) Then
            valu_target1.Value = 350
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(212) Then
            valu_target1.Value = 354
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(213) Then
            valu_target1.Value = 355
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(214) Then
            valu_target1.Value = 356
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(215) Then
            valu_target1.Value = 357
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(216) Then
            valu_target1.Value = 358
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(217) Then
            valu_target1.Value = 359
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(218) Then
            valu_target1.Value = 360
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(219) Then
            valu_target1.Value = 361
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(220) Then
            valu_target1.Value = 362
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(221) Then
            valu_target1.Value = 363
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(222) Then
            valu_target1.Value = 364
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(223) Then
            valu_target1.Value = 365
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(224) Then
            valu_target1.Value = 366
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(225) Then
            valu_target1.Value = 367
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(226) Then
            valu_target1.Value = 368
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(227) Then
            valu_target1.Value = 369
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(228) Then
            valu_target1.Value = 370
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(229) Then
            valu_target1.Value = 371
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(230) Then
            valu_target1.Value = 381
        ElseIf Select_target1_foodEU.SelectedItem = Select_target1_foodEU.Items.Item(231) Then
            valu_target1.Value = 0
        End If
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        If Select_interaction.SelectedItem = Select_interaction.Items.Item(0) Then
            valu_enddateinterac.Value = 0
        ElseIf valu_interaction.Value = &H156 Then
            valu_enddateinterac.Value = valu_lastsavedate.Value
        Else
            valu_enddateinterac.Value = valu_lastsavedate.Value + &H30000
        End If
        Writeinteraction()
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_Miiedition.Visible = True
        Me.Close()
    End Sub

    Public Sub Writeinteraction()
        Try
            Dim Writedata As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Writedata.Position = Emotion_1
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_1
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_1
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_1
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_1
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Writedata.Position = Emotion_2
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_2
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_2
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_2
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_2
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Writedata.Position = Emotion_3
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_3
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_3
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_3
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_3
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Writedata.Position = Emotion_4
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_4
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_4
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_4
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_4
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Writedata.Position = Emotion_5
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_5
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_5
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_5
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_5
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Writedata.Position = Emotion_6
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_6
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_6
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_6
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_6
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Writedata.Position = Emotion_7
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_7
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_7
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_7
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_7
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Writedata.Position = Emotion_8
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_8
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_8
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_8
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_8
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Writedata.Position = Emotion_9
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_9
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_9
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_9
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_9
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Writedata.Position = Emotion_10
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_10
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_10
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_10
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_10
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Writedata.Position = Emotion_11
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_11
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_11
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_11
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_11
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Writedata.Position = Emotion_12
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_12
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_12
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_12
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_12
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Writedata.Position = Emotion_13
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_13
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_13
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_13
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_13
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Writedata.Position = Emotion_14
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_14
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_14
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_14
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_14
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Writedata.Position = Emotion_15
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_15
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_15
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_15
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_15
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Writedata.Position = Emotion_16
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_16
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_16
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_16
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_16
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Writedata.Position = Emotion_17
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_17
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_17
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_17
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_17
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Writedata.Position = Emotion_18
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_18
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_18
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_18
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_18
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Writedata.Position = Emotion_19
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_19
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_19
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_19
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_19
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Writedata.Position = Emotion_20
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_20
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_20
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_20
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_20
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Writedata.Position = Emotion_21
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_21
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_21
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_21
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_21
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Writedata.Position = Emotion_22
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_22
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_22
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_22
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_22
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Writedata.Position = Emotion_23
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_23
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_23
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_23
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_23
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Writedata.Position = Emotion_24
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_24
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_24
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_24
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_24
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Writedata.Position = Emotion_25
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_25
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_25
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_25
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_25
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Writedata.Position = Emotion_26
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_26
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_26
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_26
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_26
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Writedata.Position = Emotion_27
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_27
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_27
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_27
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_27
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Writedata.Position = Emotion_28
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_28
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_28
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_28
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_28
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Writedata.Position = Emotion_29
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_29
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_29
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_29
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_29
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Writedata.Position = Emotion_30
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_30
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_30
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_30
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_30
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Writedata.Position = Emotion_31
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_31
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_31
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_31
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_31
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Writedata.Position = Emotion_32
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_32
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_32
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_32
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_32
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Writedata.Position = Emotion_33
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_33
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_33
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_33
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_33
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Writedata.Position = Emotion_34
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_34
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_34
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_34
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_34
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Writedata.Position = Emotion_35
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_35
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_35
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_35
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_35
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Writedata.Position = Emotion_36
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_36
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_36
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_36
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_36
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Writedata.Position = Emotion_37
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_37
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_37
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_37
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_37
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Writedata.Position = Emotion_38
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_38
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_38
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_38
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_38
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Writedata.Position = Emotion_39
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_39
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_39
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_39
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_39
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Writedata.Position = Emotion_40
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_40
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_40
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_40
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_40
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Writedata.Position = Emotion_41
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_41
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_41
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_41
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_41
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Writedata.Position = Emotion_42
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_42
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_42
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_42
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_42
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Writedata.Position = Emotion_43
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_43
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_43
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_43
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_43
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Writedata.Position = Emotion_44
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_44
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_44
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_44
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_44
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Writedata.Position = Emotion_45
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_45
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_45
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_45
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_45
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Writedata.Position = Emotion_46
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_46
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_46
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_46
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_46
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Writedata.Position = Emotion_47
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_47
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_47
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_47
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_47
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Writedata.Position = Emotion_48
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_48
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_48
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_48
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_48
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Writedata.Position = Emotion_49
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_49
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_49
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_49
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_49
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Writedata.Position = Emotion_50
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_50
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_50
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_50
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_50
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(50) Then
                Writedata.Position = Emotion_51
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_51
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_51
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_51
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_51
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(51) Then
                Writedata.Position = Emotion_52
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_52
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_52
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_52
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_52
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(52) Then
                Writedata.Position = Emotion_53
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_53
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_53
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_53
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_53
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(53) Then
                Writedata.Position = Emotion_54
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_54
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_54
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_54
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_54
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(54) Then
                Writedata.Position = Emotion_55
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_55
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_55
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_55
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_55
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(55) Then
                Writedata.Position = Emotion_56
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_56
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_56
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_56
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_56
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(56) Then
                Writedata.Position = Emotion_57
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_57
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_57
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_57
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_57
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(57) Then
                Writedata.Position = Emotion_58
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_58
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_58
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_58
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_58
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(58) Then
                Writedata.Position = Emotion_59
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_59
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_59
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_59
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_59
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(59) Then
                Writedata.Position = Emotion_60
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_60
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_60
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_60
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_60
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(60) Then
                Writedata.Position = Emotion_61
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_61
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_61
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_61
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_61
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(61) Then
                Writedata.Position = Emotion_62
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_62
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_62
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_62
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_62
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(62) Then
                Writedata.Position = Emotion_63
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_63
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_63
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_63
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_63
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(63) Then
                Writedata.Position = Emotion_64
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_64
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_64
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_64
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_64
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(64) Then
                Writedata.Position = Emotion_65
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_65
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_65
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_65
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_65
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(65) Then
                Writedata.Position = Emotion_66
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_66
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_66
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_66
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_66
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(66) Then
                Writedata.Position = Emotion_67
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_67
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_67
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_67
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_67
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(67) Then
                Writedata.Position = Emotion_68
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_68
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_68
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_68
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_68
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(68) Then
                Writedata.Position = Emotion_69
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_69
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_69
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_69
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_69
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(69) Then
                Writedata.Position = Emotion_70
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_70
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_70
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_70
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_70
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(70) Then
                Writedata.Position = Emotion_71
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_71
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_71
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_71
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_71
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(71) Then
                Writedata.Position = Emotion_72
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_72
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_72
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_72
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_72
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(72) Then
                Writedata.Position = Emotion_73
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_73
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_73
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_73
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_73
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(73) Then
                Writedata.Position = Emotion_74
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_74
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_74
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_74
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_74
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(74) Then
                Writedata.Position = Emotion_75
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_75
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_75
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_75
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_75
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(75) Then
                Writedata.Position = Emotion_76
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_76
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_76
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_76
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_76
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(76) Then
                Writedata.Position = Emotion_77
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_77
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_77
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_77
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_77
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(77) Then
                Writedata.Position = Emotion_78
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_78
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_78
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_78
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_78
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(78) Then
                Writedata.Position = Emotion_79
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_79
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_79
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_79
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_79
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(79) Then
                Writedata.Position = Emotion_80
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_80
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_80
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_80
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_80
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(80) Then
                Writedata.Position = Emotion_81
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_81
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_81
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_81
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_81
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(81) Then
                Writedata.Position = Emotion_82
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_82
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_82
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_82
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_82
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(82) Then
                Writedata.Position = Emotion_83
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_83
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_83
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_83
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_83
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(83) Then
                Writedata.Position = Emotion_84
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_84
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_84
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_84
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_84
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(84) Then
                Writedata.Position = Emotion_85
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_85
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_85
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_85
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_85
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(85) Then
                Writedata.Position = Emotion_86
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_86
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_86
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_86
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_86
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(86) Then
                Writedata.Position = Emotion_87
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_87
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_87
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_87
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_87
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(87) Then
                Writedata.Position = Emotion_88
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_88
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_88
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_88
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_88
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(88) Then
                Writedata.Position = Emotion_89
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_89
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_89
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_89
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_89
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(89) Then
                Writedata.Position = Emotion_90
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_90
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_90
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_90
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_90
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(90) Then
                Writedata.Position = Emotion_91
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_91
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_91
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_91
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_91
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(91) Then
                Writedata.Position = Emotion_92
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_92
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_92
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_92
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_92
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(92) Then
                Writedata.Position = Emotion_93
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_93
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_93
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_93
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_93
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(93) Then
                Writedata.Position = Emotion_94
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_94
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_94
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_94
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_94
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(94) Then
                Writedata.Position = Emotion_95
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_95
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_95
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_95
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_95
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(95) Then
                Writedata.Position = Emotion_96
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_96
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_96
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_96
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_96
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(96) Then
                Writedata.Position = Emotion_97
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_97
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_97
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_97
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_97
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(97) Then
                Writedata.Position = Emotion_98
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_98
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_98
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_98
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_98
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(98) Then
                Writedata.Position = Emotion_99
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_99
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_99
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_99
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_99
                Writedata.WriteUInt16(valu_target2.Value)
            ElseIf Select_mii.SelectedItem = Select_mii.Items.Item(99) Then
                Writedata.Position = Emotion_100
                Writedata.WriteInt8(valu_emotions.Value)
                Writedata.Position = Endinteraction_100
                Writedata.WriteUInt32(valu_enddateinterac.Value)
                Writedata.Position = Interaction_100
                Writedata.WriteUInt16(valu_interaction.Value)
                Writedata.Position = Target1_100
                Writedata.WriteUInt16(valu_target1.Value)
                Writedata.Position = Target2_100
                Writedata.WriteUInt16(valu_target2.Value)
            End If
            TLSE_dialog.Text_TLSE_dialog.Text = "This interaction has been successfully edited"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to edit this interaction"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub valu_emotions_ValueChanged(sender As Object, e As EventArgs) Handles valu_emotions.ValueChanged
        If valu_emotions.Value = 0 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(0)
        ElseIf valu_emotions.Value = 1 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(1)
        ElseIf valu_emotions.Value = 2 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(2)
        ElseIf valu_emotions.Value = 3 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(3)
        ElseIf valu_emotions.Value = 4 Then
            Select_emotions.SelectedItem = Select_emotions.Items.Item(4)
        End If
    End Sub

    Private Sub Select_emotions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_emotions.SelectedIndexChanged
        If Select_emotions.SelectedItem = Select_emotions.Items.Item(0) Then
            valu_emotions.Value = 0
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(1) Then
            valu_emotions.Value = 1
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(2) Then
            valu_emotions.Value = 2
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(3) Then
            valu_emotions.Value = 3
        ElseIf Select_emotions.SelectedItem = Select_emotions.Items.Item(4) Then
            valu_emotions.Value = 4
        End If
    End Sub

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_Miiedition.Visible = True
        Me.Close()
    End Sub
End Class