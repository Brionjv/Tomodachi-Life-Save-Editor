Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_extras
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Miidetected As String
    Dim accessrelationship As String

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

    Private Sub TLSE_extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Switchfilever()
    End Sub

    Public Sub Switchfilever()
        If Filever_text.Text = "EU" Then
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
        End If
        If Filever_text.Text = "US" Then
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
        End If
        If Filever_text.Text = "JP" Then
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
        End If
        If Filever_text.Text = "KR" Then
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
        End If
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub Check_timetravel_CheckedChanged(sender As Object, e As EventArgs) Handles Check_timetravel.CheckedChanged
        If Check_timetravel.Checked = True Then
            Try
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Did you allow birth of babies in Tomodachi Life ?"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Avez vous activer la naissance des bébés dans Tomodachi Life ?"
                End If
                TLSE_dialog.Panel_Cancel.Visible = True
                TLSE_dialog.Panel_OK.Visible = True
                TLSE_dialog.OK_Button.Text = "Yes"
                TLSE_dialog.Cancel_Button.Text = "No"
                TLSE_dialog.ShowDialog()
                If TLSE_dialog.DialogResult = DialogResult.OK Then
                    Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                        If Check_timetravel.Checked = True Then
                            ws.Position = &H1E4C70
                            ws.WriteByte(64)
                        End If
                    ElseIf Filever_text.Text = "JP" Then
                        If Check_timetravel.Checked = True Then
                            ws.Position = &H14BD40
                            ws.WriteByte(64)
                        End If
                    ElseIf Filever_text.Text = "KR" Then
                        If Check_timetravel.Checked = True Then
                            ws.Position = &H1F0020
                            ws.WriteByte(64)
                        End If
                    End If
                ElseIf TLSE_dialog.DialogResult = DialogResult.Cancel Then
                    Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                        If Check_timetravel.Checked = True Then
                            ws.Position = &H1E4C70
                            ws.WriteByte(0)
                        End If
                    ElseIf Filever_text.Text = "JP" Then
                        If Check_timetravel.Checked = True Then
                            ws.Position = &H14BD40
                            ws.WriteByte(0)
                        End If
                    ElseIf Filever_text.Text = "KR" Then
                        If Check_timetravel.Checked = True Then
                            ws.Position = &H1F0020
                            ws.WriteByte(0)
                        End If
                    End If
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Time travel penality has been remove"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La pénalité de voyage dans le temps a été supprimée"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to remove time travel penality"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "la suppression de la pénalité de voyage dans le temps a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Check_resetstpspp_CheckedChanged(sender As Object, e As EventArgs) Handles Check_resetstpspp.CheckedChanged
        If Check_resetstpspp.Checked = True Then
            Try
                Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
                    If Check_resetstpspp.Checked = True Then
                        ws.Position = &H1E4C71
                        ws.WriteByte(0)
                    End If
                ElseIf Filever_text.Text = "JP" Then
                    If Check_resetstpspp.Checked = True Then
                        ws.Position = &H14BD41
                        ws.WriteByte(0)
                    End If
                ElseIf Filever_text.Text = "KR" Then
                    If Check_resetstpspp.Checked = True Then
                        ws.Position = &H1F0021
                        ws.WriteByte(0)
                    End If
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "StreetPass / SpotPass has been reset"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "StreetPass / SpotPass a été réinitialisé"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to reset StreetPass / SpotPass"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La réinitialisation de StreetPass / SpotPass a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Check_resetmiiapart_CheckedChanged(sender As Object, e As EventArgs) Handles Check_resetmiiapart.CheckedChanged
        If Check_resetmiiapart.Checked = True Then
            Try
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                If Check_resetmiiapart.Checked = True Then
                    If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                        If valu_lastmii.Value >= 1 Then
                            fs.Position = &H22A8
                            fs.WriteByte(0)
                        End If
                        If valu_lastmii.Value >= 2 Then
                            fs.Position = &H22A8 + &H660
                            fs.WriteByte(1)
                        End If
                        If valu_lastmii.Value >= 3 Then
                            fs.Position = &H22A8 + (&H660 * 2)
                            fs.WriteByte(2)
                        End If
                        If valu_lastmii.Value >= 4 Then
                            fs.Position = &H22A8 + (&H660 * 3)
                            fs.WriteByte(3)
                        End If
                        If valu_lastmii.Value >= 5 Then
                            fs.Position = &H22A8 + (&H660 * 4)
                            fs.WriteByte(4)
                        End If
                        If valu_lastmii.Value >= 6 Then
                            fs.Position = &H22A8 + (&H660 * 5)
                            fs.WriteByte(5)
                        End If
                        If valu_lastmii.Value >= 7 Then
                            fs.Position = &H22A8 + (&H660 * 6)
                            fs.WriteByte(6)
                        End If
                        If valu_lastmii.Value >= 8 Then
                            fs.Position = &H22A8 + (&H660 * 7)
                            fs.WriteByte(7)
                        End If
                        If valu_lastmii.Value >= 9 Then
                            fs.Position = &H22A8 + (&H660 * 8)
                            fs.WriteByte(8)
                        End If
                        If valu_lastmii.Value >= 10 Then
                            fs.Position = &H22A8 + (&H660 * 9)
                            fs.WriteByte(9)
                        End If
                        If valu_lastmii.Value >= 11 Then
                            fs.Position = &H22A8 + (&H660 * 10)
                            fs.WriteByte(10)
                        End If
                        If valu_lastmii.Value >= 12 Then
                            fs.Position = &H22A8 + (&H660 * 11)
                            fs.WriteByte(11)
                        End If
                        If valu_lastmii.Value >= 13 Then
                            fs.Position = &H22A8 + (&H660 * 12)
                            fs.WriteByte(12)
                        End If
                        If valu_lastmii.Value >= 14 Then
                            fs.Position = &H22A8 + (&H660 * 13)
                            fs.WriteByte(13)
                        End If
                        If valu_lastmii.Value >= 15 Then
                            fs.Position = &H22A8 + (&H660 * 14)
                            fs.WriteByte(14)
                        End If
                        If valu_lastmii.Value >= 16 Then
                            fs.Position = &H22A8 + (&H660 * 15)
                            fs.WriteByte(15)
                        End If
                        If valu_lastmii.Value >= 17 Then
                            fs.Position = &H22A8 + (&H660 * 16)
                            fs.WriteByte(16)
                        End If
                        If valu_lastmii.Value >= 18 Then
                            fs.Position = &H22A8 + (&H660 * 17)
                            fs.WriteByte(17)
                        End If
                        If valu_lastmii.Value >= 19 Then
                            fs.Position = &H22A8 + (&H660 * 18)
                            fs.WriteByte(18)
                        End If
                        If valu_lastmii.Value >= 20 Then
                            fs.Position = &H22A8 + (&H660 * 19)
                            fs.WriteByte(19)
                        End If
                        If valu_lastmii.Value >= 21 Then
                            fs.Position = &H22A8 + (&H660 * 20)
                            fs.WriteByte(20)
                        End If
                        If valu_lastmii.Value >= 22 Then
                            fs.Position = &H22A8 + (&H660 * 21)
                            fs.WriteByte(21)
                        End If
                        If valu_lastmii.Value >= 23 Then
                            fs.Position = &H22A8 + (&H660 * 22)
                            fs.WriteByte(22)
                        End If
                        If valu_lastmii.Value >= 24 Then
                            fs.Position = &H22A8 + (&H660 * 23)
                            fs.WriteByte(23)
                        End If
                        If valu_lastmii.Value >= 25 Then
                            fs.Position = &H22A8 + (&H660 * 24)
                            fs.WriteByte(24)
                        End If
                        If valu_lastmii.Value >= 26 Then
                            fs.Position = &H22A8 + (&H660 * 25)
                            fs.WriteByte(25)
                        End If
                        If valu_lastmii.Value >= 27 Then
                            fs.Position = &H22A8 + (&H660 * 26)
                            fs.WriteByte(26)
                        End If
                        If valu_lastmii.Value >= 28 Then
                            fs.Position = &H22A8 + (&H660 * 27)
                            fs.WriteByte(27)
                        End If
                        If valu_lastmii.Value >= 29 Then
                            fs.Position = &H22A8 + (&H660 * 28)
                            fs.WriteByte(28)
                        End If
                        If valu_lastmii.Value >= 30 Then
                            fs.Position = &H22A8 + (&H660 * 29)
                            fs.WriteByte(29)
                        End If
                        If valu_lastmii.Value >= 31 Then
                            fs.Position = &H22A8 + (&H660 * 30)
                            fs.WriteByte(30)
                        End If
                        If valu_lastmii.Value >= 32 Then
                            fs.Position = &H22A8 + (&H660 * 31)
                            fs.WriteByte(31)
                        End If
                        If valu_lastmii.Value >= 33 Then
                            fs.Position = &H22A8 + (&H660 * 32)
                            fs.WriteByte(32)
                        End If
                        If valu_lastmii.Value >= 34 Then
                            fs.Position = &H22A8 + (&H660 * 33)
                            fs.WriteByte(33)
                        End If
                        If valu_lastmii.Value >= 35 Then
                            fs.Position = &H22A8 + (&H660 * 34)
                            fs.WriteByte(34)
                        End If
                        If valu_lastmii.Value >= 36 Then
                            fs.Position = &H22A8 + (&H660 * 35)
                            fs.WriteByte(35)
                        End If
                        If valu_lastmii.Value >= 37 Then
                            fs.Position = &H22A8 + (&H660 * 36)
                            fs.WriteByte(36)
                        End If
                        If valu_lastmii.Value >= 38 Then
                            fs.Position = &H22A8 + (&H660 * 37)
                            fs.WriteByte(37)
                        End If
                        If valu_lastmii.Value >= 39 Then
                            fs.Position = &H22A8 + (&H660 * 38)
                            fs.WriteByte(38)
                        End If
                        If valu_lastmii.Value >= 40 Then
                            fs.Position = &H22A8 + (&H660 * 39)
                            fs.WriteByte(39)
                        End If
                        If valu_lastmii.Value >= 41 Then
                            fs.Position = &H22A8 + (&H660 * 40)
                            fs.WriteByte(40)
                        End If
                        If valu_lastmii.Value >= 42 Then
                            fs.Position = &H22A8 + (&H660 * 41)
                            fs.WriteByte(41)
                        End If
                        If valu_lastmii.Value >= 43 Then
                            fs.Position = &H22A8 + (&H660 * 42)
                            fs.WriteByte(42)
                        End If
                        If valu_lastmii.Value >= 44 Then
                            fs.Position = &H22A8 + (&H660 * 43)
                            fs.WriteByte(43)
                        End If
                        If valu_lastmii.Value >= 45 Then
                            fs.Position = &H22A8 + (&H660 * 44)
                            fs.WriteByte(44)
                        End If
                        If valu_lastmii.Value >= 46 Then
                            fs.Position = &H22A8 + (&H660 * 45)
                            fs.WriteByte(45)
                        End If
                        If valu_lastmii.Value >= 47 Then
                            fs.Position = &H22A8 + (&H660 * 46)
                            fs.WriteByte(46)
                        End If
                        If valu_lastmii.Value >= 48 Then
                            fs.Position = &H22A8 + (&H660 * 47)
                            fs.WriteByte(47)
                        End If
                        If valu_lastmii.Value >= 49 Then
                            fs.Position = &H22A8 + (&H660 * 48)
                            fs.WriteByte(48)
                        End If
                        If valu_lastmii.Value >= 50 Then
                            fs.Position = &H22A8 + (&H660 * 49)
                            fs.WriteByte(49)
                        End If
                        If valu_lastmii.Value >= 51 Then
                            fs.Position = &H22A8 + (&H660 * 50)
                            fs.WriteByte(50)
                        End If
                        If valu_lastmii.Value >= 52 Then
                            fs.Position = &H22A8 + (&H660 * 51)
                            fs.WriteByte(51)
                        End If
                        If valu_lastmii.Value >= 53 Then
                            fs.Position = &H22A8 + (&H660 * 52)
                            fs.WriteByte(52)
                        End If
                        If valu_lastmii.Value >= 54 Then
                            fs.Position = &H22A8 + (&H660 * 53)
                            fs.WriteByte(53)
                        End If
                        If valu_lastmii.Value >= 55 Then
                            fs.Position = &H22A8 + (&H660 * 54)
                            fs.WriteByte(54)
                        End If
                        If valu_lastmii.Value >= 56 Then
                            fs.Position = &H22A8 + (&H660 * 55)
                            fs.WriteByte(55)
                        End If
                        If valu_lastmii.Value >= 57 Then
                            fs.Position = &H22A8 + (&H660 * 56)
                            fs.WriteByte(56)
                        End If
                        If valu_lastmii.Value >= 58 Then
                            fs.Position = &H22A8 + (&H660 * 57)
                            fs.WriteByte(57)
                        End If
                        If valu_lastmii.Value >= 59 Then
                            fs.Position = &H22A8 + (&H660 * 58)
                            fs.WriteByte(58)
                        End If
                        If valu_lastmii.Value >= 60 Then
                            fs.Position = &H22A8 + (&H660 * 59)
                            fs.WriteByte(59)
                        End If
                        If valu_lastmii.Value >= 61 Then
                            fs.Position = &H22A8 + (&H660 * 60)
                            fs.WriteByte(60)
                        End If
                        If valu_lastmii.Value >= 62 Then
                            fs.Position = &H22A8 + (&H660 * 61)
                            fs.WriteByte(61)
                        End If
                        If valu_lastmii.Value >= 63 Then
                            fs.Position = &H22A8 + (&H660 * 62)
                            fs.WriteByte(62)
                        End If
                        If valu_lastmii.Value >= 64 Then
                            fs.Position = &H22A8 + (&H660 * 63)
                            fs.WriteByte(63)
                        End If
                        If valu_lastmii.Value >= 65 Then
                            fs.Position = &H22A8 + (&H660 * 64)
                            fs.WriteByte(64)
                        End If
                        If valu_lastmii.Value >= 66 Then
                            fs.Position = &H22A8 + (&H660 * 65)
                            fs.WriteByte(65)
                        End If
                        If valu_lastmii.Value >= 67 Then
                            fs.Position = &H22A8 + (&H660 * 66)
                            fs.WriteByte(66)
                        End If
                        If valu_lastmii.Value >= 68 Then
                            fs.Position = &H22A8 + (&H660 * 67)
                            fs.WriteByte(67)
                        End If
                        If valu_lastmii.Value >= 69 Then
                            fs.Position = &H22A8 + (&H660 * 68)
                            fs.WriteByte(68)
                        End If
                        If valu_lastmii.Value >= 70 Then
                            fs.Position = &H22A8 + (&H660 * 69)
                            fs.WriteByte(69)
                        End If
                        If valu_lastmii.Value >= 71 Then
                            fs.Position = &H22A8 + (&H660 * 70)
                            fs.WriteByte(70)
                        End If
                        If valu_lastmii.Value >= 72 Then
                            fs.Position = &H22A8 + (&H660 * 71)
                            fs.WriteByte(71)
                        End If
                        If valu_lastmii.Value >= 73 Then
                            fs.Position = &H22A8 + (&H660 * 72)
                            fs.WriteByte(72)
                        End If
                        If valu_lastmii.Value >= 74 Then
                            fs.Position = &H22A8 + (&H660 * 73)
                            fs.WriteByte(73)
                        End If
                        If valu_lastmii.Value >= 75 Then
                            fs.Position = &H22A8 + (&H660 * 74)
                            fs.WriteByte(74)
                        End If
                        If valu_lastmii.Value >= 76 Then
                            fs.Position = &H22A8 + (&H660 * 75)
                            fs.WriteByte(75)
                        End If
                        If valu_lastmii.Value >= 77 Then
                            fs.Position = &H22A8 + (&H660 * 76)
                            fs.WriteByte(76)
                        End If
                        If valu_lastmii.Value >= 78 Then
                            fs.Position = &H22A8 + (&H660 * 77)
                            fs.WriteByte(77)
                        End If
                        If valu_lastmii.Value >= 79 Then
                            fs.Position = &H22A8 + (&H660 * 78)
                            fs.WriteByte(78)
                        End If
                        If valu_lastmii.Value >= 80 Then
                            fs.Position = &H22A8 + (&H660 * 79)
                            fs.WriteByte(79)
                        End If
                        If valu_lastmii.Value >= 81 Then
                            fs.Position = &H22A8 + (&H660 * 80)
                            fs.WriteByte(80)
                        End If
                        If valu_lastmii.Value >= 82 Then
                            fs.Position = &H22A8 + (&H660 * 81)
                            fs.WriteByte(81)
                        End If
                        If valu_lastmii.Value >= 83 Then
                            fs.Position = &H22A8 + (&H660 * 82)
                            fs.WriteByte(82)
                        End If
                        If valu_lastmii.Value >= 84 Then
                            fs.Position = &H22A8 + (&H660 * 83)
                            fs.WriteByte(83)
                        End If
                        If valu_lastmii.Value >= 85 Then
                            fs.Position = &H22A8 + (&H660 * 84)
                            fs.WriteByte(84)
                        End If
                        If valu_lastmii.Value >= 86 Then
                            fs.Position = &H22A8 + (&H660 * 85)
                            fs.WriteByte(85)
                        End If
                        If valu_lastmii.Value >= 87 Then
                            fs.Position = &H22A8 + (&H660 * 86)
                            fs.WriteByte(86)
                        End If
                        If valu_lastmii.Value >= 88 Then
                            fs.Position = &H22A8 + (&H660 * 87)
                            fs.WriteByte(87)
                        End If
                        If valu_lastmii.Value >= 89 Then
                            fs.Position = &H22A8 + (&H660 * 88)
                            fs.WriteByte(88)
                        End If
                        If valu_lastmii.Value >= 90 Then
                            fs.Position = &H22A8 + (&H660 * 89)
                            fs.WriteByte(89)
                        End If
                        If valu_lastmii.Value >= 91 Then
                            fs.Position = &H22A8 + (&H660 * 90)
                            fs.WriteByte(90)
                        End If
                        If valu_lastmii.Value >= 92 Then
                            fs.Position = &H22A8 + (&H660 * 91)
                            fs.WriteByte(91)
                        End If
                        If valu_lastmii.Value >= 93 Then
                            fs.Position = &H22A8 + (&H660 * 92)
                            fs.WriteByte(92)
                        End If
                        If valu_lastmii.Value >= 94 Then
                            fs.Position = &H22A8 + (&H660 * 93)
                            fs.WriteByte(93)
                        End If
                        If valu_lastmii.Value >= 95 Then
                            fs.Position = &H22A8 + (&H660 * 94)
                            fs.WriteByte(94)
                        End If
                        If valu_lastmii.Value >= 96 Then
                            fs.Position = &H22A8 + (&H660 * 95)
                            fs.WriteByte(95)
                        End If
                        If valu_lastmii.Value >= 97 Then
                            fs.Position = &H22A8 + (&H660 * 96)
                            fs.WriteByte(96)
                        End If
                        If valu_lastmii.Value >= 98 Then
                            fs.Position = &H22A8 + (&H660 * 97)
                            fs.WriteByte(97)
                        End If
                        If valu_lastmii.Value >= 99 Then
                            fs.Position = &H22A8 + (&H660 * 98)
                            fs.WriteByte(98)
                        End If
                        If valu_lastmii.Value >= 100 Then
                            fs.Position = &H22A8 + (&H660 * 99)
                            fs.WriteByte(99)
                        End If
                        fs.Close()
                    ElseIf Filever_text.Text = "JP" Then
                        If valu_lastmii.Value >= 1 Then
                            fs.Position = &H21A8
                            fs.WriteByte(0)
                        End If
                        If valu_lastmii.Value >= 2 Then
                            fs.Position = &H21A8 + &H590
                            fs.WriteByte(1)
                        End If
                        If valu_lastmii.Value >= 3 Then
                            fs.Position = &H21A8 + (&H590 * 2)
                            fs.WriteByte(2)
                        End If
                        If valu_lastmii.Value >= 4 Then
                            fs.Position = &H21A8 + (&H590 * 3)
                            fs.WriteByte(3)
                        End If
                        If valu_lastmii.Value >= 5 Then
                            fs.Position = &H21A8 + (&H590 * 4)
                            fs.WriteByte(4)
                        End If
                        If valu_lastmii.Value >= 6 Then
                            fs.Position = &H21A8 + (&H590 * 5)
                            fs.WriteByte(5)
                        End If
                        If valu_lastmii.Value >= 7 Then
                            fs.Position = &H21A8 + (&H590 * 6)
                            fs.WriteByte(6)
                        End If
                        If valu_lastmii.Value >= 8 Then
                            fs.Position = &H21A8 + (&H590 * 7)
                            fs.WriteByte(7)
                        End If
                        If valu_lastmii.Value >= 9 Then
                            fs.Position = &H21A8 + (&H590 * 8)
                            fs.WriteByte(8)
                        End If
                        If valu_lastmii.Value >= 10 Then
                            fs.Position = &H21A8 + (&H590 * 9)
                            fs.WriteByte(9)
                        End If
                        If valu_lastmii.Value >= 11 Then
                            fs.Position = &H21A8 + (&H590 * 10)
                            fs.WriteByte(10)
                        End If
                        If valu_lastmii.Value >= 12 Then
                            fs.Position = &H21A8 + (&H590 * 11)
                            fs.WriteByte(11)
                        End If
                        If valu_lastmii.Value >= 13 Then
                            fs.Position = &H21A8 + (&H590 * 12)
                            fs.WriteByte(12)
                        End If
                        If valu_lastmii.Value >= 14 Then
                            fs.Position = &H21A8 + (&H590 * 13)
                            fs.WriteByte(13)
                        End If
                        If valu_lastmii.Value >= 15 Then
                            fs.Position = &H21A8 + (&H590 * 14)
                            fs.WriteByte(14)
                        End If
                        If valu_lastmii.Value >= 16 Then
                            fs.Position = &H21A8 + (&H590 * 15)
                            fs.WriteByte(15)
                        End If
                        If valu_lastmii.Value >= 17 Then
                            fs.Position = &H21A8 + (&H590 * 16)
                            fs.WriteByte(16)
                        End If
                        If valu_lastmii.Value >= 18 Then
                            fs.Position = &H21A8 + (&H590 * 17)
                            fs.WriteByte(17)
                        End If
                        If valu_lastmii.Value >= 19 Then
                            fs.Position = &H21A8 + (&H590 * 18)
                            fs.WriteByte(18)
                        End If
                        If valu_lastmii.Value >= 20 Then
                            fs.Position = &H21A8 + (&H590 * 19)
                            fs.WriteByte(19)
                        End If
                        If valu_lastmii.Value >= 21 Then
                            fs.Position = &H21A8 + (&H590 * 20)
                            fs.WriteByte(20)
                        End If
                        If valu_lastmii.Value >= 22 Then
                            fs.Position = &H21A8 + (&H590 * 21)
                            fs.WriteByte(21)
                        End If
                        If valu_lastmii.Value >= 23 Then
                            fs.Position = &H21A8 + (&H590 * 22)
                            fs.WriteByte(22)
                        End If
                        If valu_lastmii.Value >= 24 Then
                            fs.Position = &H21A8 + (&H590 * 23)
                            fs.WriteByte(23)
                        End If
                        If valu_lastmii.Value >= 25 Then
                            fs.Position = &H21A8 + (&H590 * 24)
                            fs.WriteByte(24)
                        End If
                        If valu_lastmii.Value >= 26 Then
                            fs.Position = &H21A8 + (&H590 * 25)
                            fs.WriteByte(25)
                        End If
                        If valu_lastmii.Value >= 27 Then
                            fs.Position = &H21A8 + (&H590 * 26)
                            fs.WriteByte(26)
                        End If
                        If valu_lastmii.Value >= 28 Then
                            fs.Position = &H21A8 + (&H590 * 27)
                            fs.WriteByte(27)
                        End If
                        If valu_lastmii.Value >= 29 Then
                            fs.Position = &H21A8 + (&H590 * 28)
                            fs.WriteByte(28)
                        End If
                        If valu_lastmii.Value >= 30 Then
                            fs.Position = &H21A8 + (&H590 * 29)
                            fs.WriteByte(29)
                        End If
                        If valu_lastmii.Value >= 31 Then
                            fs.Position = &H21A8 + (&H590 * 30)
                            fs.WriteByte(30)
                        End If
                        If valu_lastmii.Value >= 32 Then
                            fs.Position = &H21A8 + (&H590 * 31)
                            fs.WriteByte(31)
                        End If
                        If valu_lastmii.Value >= 33 Then
                            fs.Position = &H21A8 + (&H590 * 32)
                            fs.WriteByte(32)
                        End If
                        If valu_lastmii.Value >= 34 Then
                            fs.Position = &H21A8 + (&H590 * 33)
                            fs.WriteByte(33)
                        End If
                        If valu_lastmii.Value >= 35 Then
                            fs.Position = &H21A8 + (&H590 * 34)
                            fs.WriteByte(34)
                        End If
                        If valu_lastmii.Value >= 36 Then
                            fs.Position = &H21A8 + (&H590 * 35)
                            fs.WriteByte(35)
                        End If
                        If valu_lastmii.Value >= 37 Then
                            fs.Position = &H21A8 + (&H590 * 36)
                            fs.WriteByte(36)
                        End If
                        If valu_lastmii.Value >= 38 Then
                            fs.Position = &H21A8 + (&H590 * 37)
                            fs.WriteByte(37)
                        End If
                        If valu_lastmii.Value >= 39 Then
                            fs.Position = &H21A8 + (&H590 * 38)
                            fs.WriteByte(38)
                        End If
                        If valu_lastmii.Value >= 40 Then
                            fs.Position = &H21A8 + (&H590 * 39)
                            fs.WriteByte(39)
                        End If
                        If valu_lastmii.Value >= 41 Then
                            fs.Position = &H21A8 + (&H590 * 40)
                            fs.WriteByte(40)
                        End If
                        If valu_lastmii.Value >= 42 Then
                            fs.Position = &H21A8 + (&H590 * 41)
                            fs.WriteByte(41)
                        End If
                        If valu_lastmii.Value >= 43 Then
                            fs.Position = &H21A8 + (&H590 * 42)
                            fs.WriteByte(42)
                        End If
                        If valu_lastmii.Value >= 44 Then
                            fs.Position = &H21A8 + (&H590 * 43)
                            fs.WriteByte(43)
                        End If
                        If valu_lastmii.Value >= 45 Then
                            fs.Position = &H21A8 + (&H590 * 44)
                            fs.WriteByte(44)
                        End If
                        If valu_lastmii.Value >= 46 Then
                            fs.Position = &H21A8 + (&H590 * 45)
                            fs.WriteByte(45)
                        End If
                        If valu_lastmii.Value >= 47 Then
                            fs.Position = &H21A8 + (&H590 * 46)
                            fs.WriteByte(46)
                        End If
                        If valu_lastmii.Value >= 48 Then
                            fs.Position = &H21A8 + (&H590 * 47)
                            fs.WriteByte(47)
                        End If
                        If valu_lastmii.Value >= 49 Then
                            fs.Position = &H21A8 + (&H590 * 48)
                            fs.WriteByte(48)
                        End If
                        If valu_lastmii.Value >= 50 Then
                            fs.Position = &H21A8 + (&H590 * 49)
                            fs.WriteByte(49)
                        End If
                        If valu_lastmii.Value >= 51 Then
                            fs.Position = &H21A8 + (&H590 * 50)
                            fs.WriteByte(50)
                        End If
                        If valu_lastmii.Value >= 52 Then
                            fs.Position = &H21A8 + (&H590 * 51)
                            fs.WriteByte(51)
                        End If
                        If valu_lastmii.Value >= 53 Then
                            fs.Position = &H21A8 + (&H590 * 52)
                            fs.WriteByte(52)
                        End If
                        If valu_lastmii.Value >= 54 Then
                            fs.Position = &H21A8 + (&H590 * 53)
                            fs.WriteByte(53)
                        End If
                        If valu_lastmii.Value >= 55 Then
                            fs.Position = &H21A8 + (&H590 * 54)
                            fs.WriteByte(54)
                        End If
                        If valu_lastmii.Value >= 56 Then
                            fs.Position = &H21A8 + (&H590 * 55)
                            fs.WriteByte(55)
                        End If
                        If valu_lastmii.Value >= 57 Then
                            fs.Position = &H21A8 + (&H590 * 56)
                            fs.WriteByte(56)
                        End If
                        If valu_lastmii.Value >= 58 Then
                            fs.Position = &H21A8 + (&H590 * 57)
                            fs.WriteByte(57)
                        End If
                        If valu_lastmii.Value >= 59 Then
                            fs.Position = &H21A8 + (&H590 * 58)
                            fs.WriteByte(58)
                        End If
                        If valu_lastmii.Value >= 60 Then
                            fs.Position = &H21A8 + (&H590 * 59)
                            fs.WriteByte(59)
                        End If
                        If valu_lastmii.Value >= 61 Then
                            fs.Position = &H21A8 + (&H590 * 60)
                            fs.WriteByte(60)
                        End If
                        If valu_lastmii.Value >= 62 Then
                            fs.Position = &H21A8 + (&H590 * 61)
                            fs.WriteByte(61)
                        End If
                        If valu_lastmii.Value >= 63 Then
                            fs.Position = &H21A8 + (&H590 * 62)
                            fs.WriteByte(62)
                        End If
                        If valu_lastmii.Value >= 64 Then
                            fs.Position = &H21A8 + (&H590 * 63)
                            fs.WriteByte(63)
                        End If
                        If valu_lastmii.Value >= 65 Then
                            fs.Position = &H21A8 + (&H590 * 64)
                            fs.WriteByte(64)
                        End If
                        If valu_lastmii.Value >= 66 Then
                            fs.Position = &H21A8 + (&H590 * 65)
                            fs.WriteByte(65)
                        End If
                        If valu_lastmii.Value >= 67 Then
                            fs.Position = &H21A8 + (&H590 * 66)
                            fs.WriteByte(66)
                        End If
                        If valu_lastmii.Value >= 68 Then
                            fs.Position = &H21A8 + (&H590 * 67)
                            fs.WriteByte(67)
                        End If
                        If valu_lastmii.Value >= 69 Then
                            fs.Position = &H21A8 + (&H590 * 68)
                            fs.WriteByte(68)
                        End If
                        If valu_lastmii.Value >= 70 Then
                            fs.Position = &H21A8 + (&H590 * 69)
                            fs.WriteByte(69)
                        End If
                        If valu_lastmii.Value >= 71 Then
                            fs.Position = &H21A8 + (&H590 * 70)
                            fs.WriteByte(70)
                        End If
                        If valu_lastmii.Value >= 72 Then
                            fs.Position = &H21A8 + (&H590 * 71)
                            fs.WriteByte(71)
                        End If
                        If valu_lastmii.Value >= 73 Then
                            fs.Position = &H21A8 + (&H590 * 72)
                            fs.WriteByte(72)
                        End If
                        If valu_lastmii.Value >= 74 Then
                            fs.Position = &H21A8 + (&H590 * 73)
                            fs.WriteByte(73)
                        End If
                        If valu_lastmii.Value >= 75 Then
                            fs.Position = &H21A8 + (&H590 * 74)
                            fs.WriteByte(74)
                        End If
                        If valu_lastmii.Value >= 76 Then
                            fs.Position = &H21A8 + (&H590 * 75)
                            fs.WriteByte(75)
                        End If
                        If valu_lastmii.Value >= 77 Then
                            fs.Position = &H21A8 + (&H590 * 76)
                            fs.WriteByte(76)
                        End If
                        If valu_lastmii.Value >= 78 Then
                            fs.Position = &H21A8 + (&H590 * 77)
                            fs.WriteByte(77)
                        End If
                        If valu_lastmii.Value >= 79 Then
                            fs.Position = &H21A8 + (&H590 * 78)
                            fs.WriteByte(78)
                        End If
                        If valu_lastmii.Value >= 80 Then
                            fs.Position = &H21A8 + (&H590 * 79)
                            fs.WriteByte(79)
                        End If
                        If valu_lastmii.Value >= 81 Then
                            fs.Position = &H21A8 + (&H590 * 80)
                            fs.WriteByte(80)
                        End If
                        If valu_lastmii.Value >= 82 Then
                            fs.Position = &H21A8 + (&H590 * 81)
                            fs.WriteByte(81)
                        End If
                        If valu_lastmii.Value >= 83 Then
                            fs.Position = &H21A8 + (&H590 * 82)
                            fs.WriteByte(82)
                        End If
                        If valu_lastmii.Value >= 84 Then
                            fs.Position = &H21A8 + (&H590 * 83)
                            fs.WriteByte(83)
                        End If
                        If valu_lastmii.Value >= 85 Then
                            fs.Position = &H21A8 + (&H590 * 84)
                            fs.WriteByte(84)
                        End If
                        If valu_lastmii.Value >= 86 Then
                            fs.Position = &H21A8 + (&H590 * 85)
                            fs.WriteByte(85)
                        End If
                        If valu_lastmii.Value >= 87 Then
                            fs.Position = &H21A8 + (&H590 * 86)
                            fs.WriteByte(86)
                        End If
                        If valu_lastmii.Value >= 88 Then
                            fs.Position = &H21A8 + (&H590 * 87)
                            fs.WriteByte(87)
                        End If
                        If valu_lastmii.Value >= 89 Then
                            fs.Position = &H21A8 + (&H590 * 88)
                            fs.WriteByte(88)
                        End If
                        If valu_lastmii.Value >= 90 Then
                            fs.Position = &H21A8 + (&H590 * 89)
                            fs.WriteByte(89)
                        End If
                        If valu_lastmii.Value >= 91 Then
                            fs.Position = &H21A8 + (&H590 * 90)
                            fs.WriteByte(90)
                        End If
                        If valu_lastmii.Value >= 92 Then
                            fs.Position = &H21A8 + (&H590 * 91)
                            fs.WriteByte(91)
                        End If
                        If valu_lastmii.Value >= 93 Then
                            fs.Position = &H21A8 + (&H590 * 92)
                            fs.WriteByte(92)
                        End If
                        If valu_lastmii.Value >= 94 Then
                            fs.Position = &H21A8 + (&H590 * 93)
                            fs.WriteByte(93)
                        End If
                        If valu_lastmii.Value >= 95 Then
                            fs.Position = &H21A8 + (&H590 * 94)
                            fs.WriteByte(94)
                        End If
                        If valu_lastmii.Value >= 96 Then
                            fs.Position = &H21A8 + (&H590 * 95)
                            fs.WriteByte(95)
                        End If
                        If valu_lastmii.Value >= 97 Then
                            fs.Position = &H21A8 + (&H590 * 96)
                            fs.WriteByte(96)
                        End If
                        If valu_lastmii.Value >= 98 Then
                            fs.Position = &H21A8 + (&H590 * 97)
                            fs.WriteByte(97)
                        End If
                        If valu_lastmii.Value >= 99 Then
                            fs.Position = &H21A8 + (&H590 * 98)
                            fs.WriteByte(98)
                        End If
                        If valu_lastmii.Value >= 100 Then
                            fs.Position = &H21A8 + (&H590 * 99)
                            fs.WriteByte(99)
                        End If
                        fs.Close()
                    End If
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Mii apartments has been reset"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Les appartements des Mii ont été réinitialisé"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to reset Mii apartments"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La réinitialisation des appartements des Mii a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub TLSE_extras_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DetectMiiregistered()
    End Sub

    Public Sub DetectMiiregistered()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Or Filever_text.Text = "KR" Then
                Reader.Position = &H22C8
                Miidetected = Reader.ReadByte
                Reader.Position = &H22C8 + &H660
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 2)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 3)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 4)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 5)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 6)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 7)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 8)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 9)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 10)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 11)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 12)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 13)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 14)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 15)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 16)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 17)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 18)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 19)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 20)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 21)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 22)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 23)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 24)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 25)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 26)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 27)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 28)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 29)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 30)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 31)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 32)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 33)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 34)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 35)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 36)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 37)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 38)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 39)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 40)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 41)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 42)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 43)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 44)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 45)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 46)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 47)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 48)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 49)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 50)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 51)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 52)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 53)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 54)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 55)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 56)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 57)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 58)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 59)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 60)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 61)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 62)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 63)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 64)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 65)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 66)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 67)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 68)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 69)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 70)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 71)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 72)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 73)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 74)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 75)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 76)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 77)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 78)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 79)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 80)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 81)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 82)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 83)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 84)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 85)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 86)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 87)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 88)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 89)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 90)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 91)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 92)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 93)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 94)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 95)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 96)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 97)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 98)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H22C8 + (&H660 * 99)
                Miidetected = Miidetected + Reader.ReadByte
                valu_lastmii.Value = Miidetected
            End If
            If Filever_text.Text = "JP" Then
                Reader.Position = &H21C8
                Miidetected = Reader.ReadByte
                Reader.Position = &H21C8 + &H590
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 2)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 3)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 4)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 5)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 6)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 7)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 8)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 9)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 10)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 11)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 12)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 13)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 14)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 15)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 16)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 17)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 18)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 19)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 20)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 21)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 22)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 23)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 24)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 25)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 26)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 27)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 28)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 29)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 30)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 31)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 32)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 33)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 34)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 35)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 36)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 37)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 38)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 39)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 40)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 41)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 42)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 43)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 44)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 45)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 46)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 47)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 48)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 49)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 50)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 51)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 52)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 53)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 54)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 55)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 56)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 57)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 58)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 59)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 60)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 61)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 62)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 63)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 64)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 65)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 66)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 67)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 68)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 69)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 70)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 71)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 72)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 73)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 74)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 75)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 76)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 77)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 78)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 79)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 80)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 81)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 82)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 83)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 84)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 85)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 86)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 87)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 88)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 89)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 90)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 91)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 92)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 93)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 94)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 95)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 96)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 97)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 98)
                Miidetected = Miidetected + Reader.ReadByte
                Reader.Position = &H21C8 + (&H590 * 99)
                Miidetected = Miidetected + Reader.ReadByte
                valu_lastmii.Value = Miidetected
            End If
            Text_miidetected.Text = "X " + Miidetected
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to detect Mii in this save file"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Échec de la détection des Mii dans ce fichier de sauvegarde"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Check_resetnewsflash_CheckedChanged(sender As Object, e As EventArgs) Handles Check_resetnewsflash.CheckedChanged
        If Check_resetnewsflash.Checked = True Then
            Try
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
                    If Check_resetnewsflash.Checked = True Then
                        For i As Integer = 0 To 4
                            Writer.Position = &H1E4C48 + i
                            Writer.WriteInt8(0)
                        Next
                    End If
                ElseIf Filever_text.Text = "JP" Then
                    If Check_resetnewsflash.Checked = True Then
                        For i As Integer = 0 To 4
                            Writer.Position = &H14BD18 + i
                            Writer.WriteInt8(0)
                        Next
                    End If
                ElseIf Filever_text.Text = "KR" Then
                    If Check_resetnewsflash.Checked = True Then
                        For i As Integer = 0 To 4
                            Writer.Position = &H1EFFF8 + i
                            Writer.WriteInt8(0)
                        Next
                    End If
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "News flash has been reset"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Les nouvelles ont été réinitialisée"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to reset news flash"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La réinitialisation des nouvelles a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Check_resetitems_CheckedChanged(sender As Object, e As EventArgs) Handles Check_resetitems.CheckedChanged
        If Check_resetitems.Checked = True Then
            Try
                If Check_resetitems.Checked = True Then
                    Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    For i As Integer = 0 To &H1A47
                        fs.Position = &H30 + i
                        fs.WriteByte(253)
                    Next
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Items has been reset"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Les objets ont été supprimés"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to reset items"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La suppression des objets a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Check_resetrelationship_CheckedChanged(sender As Object, e As EventArgs) Handles Check_resetrelationship.CheckedChanged
        If Check_resetrelationship.Checked = True Then
            Try
                If Check_resetrelationship.Checked = True Then
                    If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                        accessrelationship = &H299F0
                    ElseIf Filever_text.Text = "JP" Then
                        accessrelationship = &H24880
                    End If
                    Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + &H100
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + &H100
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 2)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 2)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 3)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 3)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 4)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 4)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 5)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 5)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 6)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 6)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 7)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 7)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 8)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 8)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 9)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 9)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 10)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 10)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 11)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 11)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 12)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 12)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 13)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 13)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 14)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 14)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 15)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 15)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 16)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 16)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 17)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 17)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 18)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 18)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 19)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 19)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 20)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 20)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 21)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 21)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 22)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 22)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 23)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 23)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 24)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 24)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 25)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 25)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 26)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 26)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 27)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 27)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 28)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 28)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 29)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 29)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 30)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 30)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 31)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 31)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 32)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 32)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 33)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 33)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 34)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 34)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 35)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 35)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 36)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 36)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 37)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 37)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 38)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 38)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 39)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 39)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 40)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 40)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 41)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 41)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 42)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 42)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 43)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 43)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 44)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 44)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 45)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 45)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 46)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 46)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 47)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 47)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 48)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 48)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 49)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 49)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 50)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 50)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 51)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 51)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 52)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 52)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 53)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 53)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 54)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 54)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 55)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 55)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 56)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 56)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 57)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 57)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 58)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 58)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 59)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 59)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 60)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 60)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 61)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 61)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 62)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 62)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 63)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 63)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 64)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 64)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 65)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 65)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 66)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 66)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 67)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 67)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 68)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 68)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 69)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 69)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 70)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 70)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 71)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 71)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 72)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 72)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 73)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 73)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 74)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 74)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 75)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 75)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 76)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 76)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 77)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 77)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 78)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 78)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 79)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 79)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 80)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 80)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 81)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 81)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 82)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 82)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 83)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 83)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 84)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 84)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 85)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 85)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 86)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 86)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 87)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 87)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 88)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 88)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 89)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 89)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 90)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 90)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 91)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 91)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 92)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 92)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 93)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 93)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 94)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 94)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 95)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 95)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 96)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 96)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 97)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 97)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 98)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 98)
                        fs.WriteByte(0)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = accessrelationship + i + (&H100 * 99)
                        fs.WriteByte(100)
                    Next
                    For i As Integer = 0 To &H63
                        fs.Position = (accessrelationship + &H64) + i + (&H100 * 99)
                        fs.WriteByte(0)
                    Next
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Relationships has been reset"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Les relations ont été réinitialisé"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to reset relationships"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La réinitialisation des relations a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Check_timetravel_MouseLeave(sender As Object, e As EventArgs) Handles Check_timetravel.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_timetravel_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_timetravel.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to remove time travel penality"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour retirer la pénalité de voyage dans le temps"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetstpspp_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetstpspp.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetstpspp_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetstpspp.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset Tomodachi Life Streetpass/Spotpass"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser Streetpass/Spotpass de Tomodachi Life"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetmiiapart_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetmiiapart.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetmiiapart_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetmiiapart.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset Mii apartments"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser les appartements des Mii"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetnewsflash_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetnewsflash.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetnewsflasht_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetnewsflash.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset News flash"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser les infos Mii"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetitems_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetitems.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetitems_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetitems.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset all items"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser tout les objets"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_resetrelationship_MouseLeave(sender As Object, e As EventArgs) Handles Check_resetrelationship.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_resetrelationship_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_resetrelationship.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to reset Mii's relationship"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour réinitialiser les relations des Mii"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub valu_setalltummy_ValueChanged(sender As Object, e As EventArgs) Handles valu_setalltummy.ValueChanged
        If valu_setalltummy.Value = 0 Then
            Icon_setalltummy.Image = My.Resources.icon_checktummy_empty
        ElseIf valu_setalltummy.Value = 1 Then
            Icon_setalltummy.Image = My.Resources.icon_checktummy_full
        End If
    End Sub

    Private Sub Icon_setalltummy_Click(sender As Object, e As EventArgs) Handles Icon_setalltummy.Click
        If valu_setalltummy.Value = 0 Then
            valu_setalltummy.Value = 1
        ElseIf valu_setalltummy.Value = 1 Then
            valu_setalltummy.Value = 0
        End If
    End Sub

    Private Sub Icon_setalltummy_MouseMove(sender As Object, e As EventArgs) Handles Icon_setalltummy.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to set as empty or full"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour mettre vide ou plein"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_setalltummy_MouseLeave(sender As Object, e As EventArgs) Handles Icon_setalltummy.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_setalltummy_MouseMove(sender As Object, e As EventArgs) Handles Check_setalltummy.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to set all Mii's tummy to empty or full"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour mettre l'estomac des Mii vide ou plein"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_setalltummy_MouseLeave(sender As Object, e As EventArgs) Handles Check_setalltummy.MouseLeave
        Panel_description.Visible = False
    End Sub

    Public Sub settummyfullempt()
        Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        If Check_setalltummy.Checked = True Then
            If Filever_text.Text = "US" Or Filever_text.Text = "EU" Or Filever_text.Text = "KR" Then
                If valu_lastmii.Value >= 1 Then
                    ws.Position = &H2293
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 2 Then
                    ws.Position = &H2293 + &H660
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 3 Then
                    ws.Position = &H2293 + (&H660 * 2)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 4 Then
                    ws.Position = &H2293 + (&H660 * 3)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 5 Then
                    ws.Position = &H2293 + (&H660 * 4)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 6 Then
                    ws.Position = &H2293 + (&H660 * 5)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 7 Then
                    ws.Position = &H2293 + (&H660 * 6)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 8 Then
                    ws.Position = &H2293 + (&H660 * 7)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 9 Then
                    ws.Position = &H2293 + (&H660 * 8)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 10 Then
                    ws.Position = &H2293 + (&H660 * 9)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 11 Then
                    ws.Position = &H2293 + (&H660 * 10)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 12 Then
                    ws.Position = &H2293 + (&H660 * 11)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 13 Then
                    ws.Position = &H2293 + (&H660 * 12)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 14 Then
                    ws.Position = &H2293 + (&H660 * 13)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 15 Then
                    ws.Position = &H2293 + (&H660 * 14)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 16 Then
                    ws.Position = &H2293 + (&H660 * 15)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 17 Then
                    ws.Position = &H2293 + (&H660 * 16)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 18 Then
                    ws.Position = &H2293 + (&H660 * 17)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 19 Then
                    ws.Position = &H2293 + (&H660 * 18)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 20 Then
                    ws.Position = &H2293 + (&H660 * 19)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 21 Then
                    ws.Position = &H2293 + (&H660 * 20)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 22 Then
                    ws.Position = &H2293 + (&H660 * 21)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 23 Then
                    ws.Position = &H2293 + (&H660 * 22)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 24 Then
                    ws.Position = &H2293 + (&H660 * 23)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 25 Then
                    ws.Position = &H2293 + (&H660 * 24)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 26 Then
                    ws.Position = &H2293 + (&H660 * 25)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 27 Then
                    ws.Position = &H2293 + (&H660 * 26)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 28 Then
                    ws.Position = &H2293 + (&H660 * 27)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 29 Then
                    ws.Position = &H2293 + (&H660 * 28)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 30 Then
                    ws.Position = &H2293 + (&H660 * 29)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 31 Then
                    ws.Position = &H2293 + (&H660 * 30)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 32 Then
                    ws.Position = &H2293 + (&H660 * 31)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 33 Then
                    ws.Position = &H2293 + (&H660 * 32)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 34 Then
                    ws.Position = &H2293 + (&H660 * 33)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 35 Then
                    ws.Position = &H2293 + (&H660 * 34)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 36 Then
                    ws.Position = &H2293 + (&H660 * 35)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 37 Then
                    ws.Position = &H2293 + (&H660 * 36)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 38 Then
                    ws.Position = &H2293 + (&H660 * 37)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 39 Then
                    ws.Position = &H2293 + (&H660 * 38)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 40 Then
                    ws.Position = &H2293 + (&H660 * 39)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 41 Then
                    ws.Position = &H2293 + (&H660 * 40)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 42 Then
                    ws.Position = &H2293 + (&H660 * 41)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 43 Then
                    ws.Position = &H2293 + (&H660 * 42)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 44 Then
                    ws.Position = &H2293 + (&H660 * 43)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 45 Then
                    ws.Position = &H2293 + (&H660 * 44)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 46 Then
                    ws.Position = &H2293 + (&H660 * 45)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 47 Then
                    ws.Position = &H2293 + (&H660 * 46)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 48 Then
                    ws.Position = &H2293 + (&H660 * 47)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 49 Then
                    ws.Position = &H2293 + (&H660 * 48)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 50 Then
                    ws.Position = &H2293 + (&H660 * 49)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 51 Then
                    ws.Position = &H2293 + (&H660 * 50)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 52 Then
                    ws.Position = &H2293 + (&H660 * 51)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 53 Then
                    ws.Position = &H2293 + (&H660 * 52)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 54 Then
                    ws.Position = &H2293 + (&H660 * 53)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 55 Then
                    ws.Position = &H2293 + (&H660 * 54)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 56 Then
                    ws.Position = &H2293 + (&H660 * 55)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 57 Then
                    ws.Position = &H2293 + (&H660 * 56)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 58 Then
                    ws.Position = &H2293 + (&H660 * 57)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 59 Then
                    ws.Position = &H2293 + (&H660 * 58)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 60 Then
                    ws.Position = &H2293 + (&H660 * 59)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 61 Then
                    ws.Position = &H2293 + (&H660 * 60)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 62 Then
                    ws.Position = &H2293 + (&H660 * 61)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 63 Then
                    ws.Position = &H2293 + (&H660 * 62)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 64 Then
                    ws.Position = &H2293 + (&H660 * 63)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 65 Then
                    ws.Position = &H2293 + (&H660 * 64)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 66 Then
                    ws.Position = &H2293 + (&H660 * 65)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 67 Then
                    ws.Position = &H2293 + (&H660 * 66)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 68 Then
                    ws.Position = &H2293 + (&H660 * 67)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 69 Then
                    ws.Position = &H2293 + (&H660 * 68)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 70 Then
                    ws.Position = &H2293 + (&H660 * 69)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 71 Then
                    ws.Position = &H2293 + (&H660 * 70)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 72 Then
                    ws.Position = &H2293 + (&H660 * 71)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 73 Then
                    ws.Position = &H2293 + (&H660 * 72)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 74 Then
                    ws.Position = &H2293 + (&H660 * 73)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 75 Then
                    ws.Position = &H2293 + (&H660 * 74)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 76 Then
                    ws.Position = &H2293 + (&H660 * 75)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 77 Then
                    ws.Position = &H2293 + (&H660 * 76)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 78 Then
                    ws.Position = &H2293 + (&H660 * 77)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 79 Then
                    ws.Position = &H2293 + (&H660 * 78)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 80 Then
                    ws.Position = &H2293 + (&H660 * 79)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 81 Then
                    ws.Position = &H2293 + (&H660 * 80)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 82 Then
                    ws.Position = &H2293 + (&H660 * 81)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 83 Then
                    ws.Position = &H2293 + (&H660 * 82)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 84 Then
                    ws.Position = &H2293 + (&H660 * 83)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 85 Then
                    ws.Position = &H2293 + (&H660 * 84)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 86 Then
                    ws.Position = &H2293 + (&H660 * 85)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 87 Then
                    ws.Position = &H2293 + (&H660 * 86)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 88 Then
                    ws.Position = &H2293 + (&H660 * 87)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 89 Then
                    ws.Position = &H2293 + (&H660 * 88)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 90 Then
                    ws.Position = &H2293 + (&H660 * 89)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 91 Then
                    ws.Position = &H2293 + (&H660 * 90)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 92 Then
                    ws.Position = &H2293 + (&H660 * 91)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 93 Then
                    ws.Position = &H2293 + (&H660 * 92)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 94 Then
                    ws.Position = &H2293 + (&H660 * 93)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 95 Then
                    ws.Position = &H2293 + (&H660 * 94)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 96 Then
                    ws.Position = &H2293 + (&H660 * 95)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 97 Then
                    ws.Position = &H2293 + (&H660 * 96)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 98 Then
                    ws.Position = &H2293 + (&H660 * 97)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 99 Then
                    ws.Position = &H2293 + (&H660 * 98)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 100 Then
                    ws.Position = &H2293 + (&H660 * 99)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                ws.Close()
            ElseIf Filever_text.Text = "JP" Then
                If valu_lastmii.Value >= 1 Then
                    ws.Position = &H2193
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 2 Then
                    ws.Position = &H2193 + &H590
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 3 Then
                    ws.Position = &H2193 + (&H590 * 2)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 4 Then
                    ws.Position = &H2193 + (&H590 * 3)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 5 Then
                    ws.Position = &H2193 + (&H590 * 4)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 6 Then
                    ws.Position = &H2193 + (&H590 * 5)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 7 Then
                    ws.Position = &H2193 + (&H590 * 6)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 8 Then
                    ws.Position = &H2193 + (&H590 * 7)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 9 Then
                    ws.Position = &H2193 + (&H590 * 8)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 10 Then
                    ws.Position = &H2193 + (&H590 * 9)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 11 Then
                    ws.Position = &H2193 + (&H590 * 10)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 12 Then
                    ws.Position = &H2193 + (&H590 * 11)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 13 Then
                    ws.Position = &H2193 + (&H590 * 12)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 14 Then
                    ws.Position = &H2193 + (&H590 * 13)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 15 Then
                    ws.Position = &H2193 + (&H590 * 14)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 16 Then
                    ws.Position = &H2193 + (&H590 * 15)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 17 Then
                    ws.Position = &H2193 + (&H590 * 16)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 18 Then
                    ws.Position = &H2193 + (&H590 * 17)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 19 Then
                    ws.Position = &H2193 + (&H590 * 18)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 20 Then
                    ws.Position = &H2193 + (&H590 * 19)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 21 Then
                    ws.Position = &H2193 + (&H590 * 20)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 22 Then
                    ws.Position = &H2193 + (&H590 * 21)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 23 Then
                    ws.Position = &H2193 + (&H590 * 22)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 24 Then
                    ws.Position = &H2193 + (&H590 * 23)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 25 Then
                    ws.Position = &H2193 + (&H590 * 24)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 26 Then
                    ws.Position = &H2193 + (&H590 * 25)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 27 Then
                    ws.Position = &H2193 + (&H590 * 26)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 28 Then
                    ws.Position = &H2193 + (&H590 * 27)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 29 Then
                    ws.Position = &H2193 + (&H590 * 28)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 30 Then
                    ws.Position = &H2193 + (&H590 * 29)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 31 Then
                    ws.Position = &H2193 + (&H590 * 30)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 32 Then
                    ws.Position = &H2193 + (&H590 * 31)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 33 Then
                    ws.Position = &H2193 + (&H590 * 32)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 34 Then
                    ws.Position = &H2193 + (&H590 * 33)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 35 Then
                    ws.Position = &H2193 + (&H590 * 34)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 36 Then
                    ws.Position = &H2193 + (&H590 * 35)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 37 Then
                    ws.Position = &H2193 + (&H590 * 36)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 38 Then
                    ws.Position = &H2193 + (&H590 * 37)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 39 Then
                    ws.Position = &H2193 + (&H590 * 38)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 40 Then
                    ws.Position = &H2193 + (&H590 * 39)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 41 Then
                    ws.Position = &H2193 + (&H590 * 40)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 42 Then
                    ws.Position = &H2193 + (&H590 * 41)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 43 Then
                    ws.Position = &H2193 + (&H590 * 42)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 44 Then
                    ws.Position = &H2193 + (&H590 * 43)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 45 Then
                    ws.Position = &H2193 + (&H590 * 44)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 46 Then
                    ws.Position = &H2193 + (&H590 * 45)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 47 Then
                    ws.Position = &H2193 + (&H590 * 46)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 48 Then
                    ws.Position = &H2193 + (&H590 * 47)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 49 Then
                    ws.Position = &H2193 + (&H590 * 48)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 50 Then
                    ws.Position = &H2193 + (&H590 * 49)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 51 Then
                    ws.Position = &H2193 + (&H590 * 50)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 52 Then
                    ws.Position = &H2193 + (&H590 * 51)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 53 Then
                    ws.Position = &H2193 + (&H590 * 52)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 54 Then
                    ws.Position = &H2193 + (&H590 * 53)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 55 Then
                    ws.Position = &H2193 + (&H590 * 54)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 56 Then
                    ws.Position = &H2193 + (&H590 * 55)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 57 Then
                    ws.Position = &H2193 + (&H590 * 56)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 58 Then
                    ws.Position = &H2193 + (&H590 * 57)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 59 Then
                    ws.Position = &H2193 + (&H590 * 58)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 60 Then
                    ws.Position = &H2193 + (&H590 * 59)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 61 Then
                    ws.Position = &H2193 + (&H590 * 60)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 62 Then
                    ws.Position = &H2193 + (&H590 * 61)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 63 Then
                    ws.Position = &H2193 + (&H590 * 62)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 64 Then
                    ws.Position = &H2193 + (&H590 * 63)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 65 Then
                    ws.Position = &H2193 + (&H590 * 64)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 66 Then
                    ws.Position = &H2193 + (&H590 * 65)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 67 Then
                    ws.Position = &H2193 + (&H590 * 66)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 68 Then
                    ws.Position = &H2193 + (&H590 * 67)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 69 Then
                    ws.Position = &H2193 + (&H590 * 68)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 70 Then
                    ws.Position = &H2193 + (&H590 * 69)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 71 Then
                    ws.Position = &H2193 + (&H590 * 70)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 72 Then
                    ws.Position = &H2193 + (&H590 * 71)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 73 Then
                    ws.Position = &H2193 + (&H590 * 72)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 74 Then
                    ws.Position = &H2193 + (&H590 * 73)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 75 Then
                    ws.Position = &H2193 + (&H590 * 74)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 76 Then
                    ws.Position = &H2193 + (&H590 * 75)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 77 Then
                    ws.Position = &H2193 + (&H590 * 76)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 78 Then
                    ws.Position = &H2193 + (&H590 * 77)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 79 Then
                    ws.Position = &H2193 + (&H590 * 78)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 80 Then
                    ws.Position = &H2193 + (&H590 * 79)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 81 Then
                    ws.Position = &H2193 + (&H590 * 80)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 82 Then
                    ws.Position = &H2193 + (&H590 * 81)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 83 Then
                    ws.Position = &H2193 + (&H590 * 82)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 84 Then
                    ws.Position = &H2193 + (&H590 * 83)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 85 Then
                    ws.Position = &H2193 + (&H590 * 84)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 86 Then
                    ws.Position = &H2193 + (&H590 * 85)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 87 Then
                    ws.Position = &H2193 + (&H590 * 86)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 88 Then
                    ws.Position = &H2193 + (&H590 * 87)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 89 Then
                    ws.Position = &H2193 + (&H590 * 88)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 90 Then
                    ws.Position = &H2193 + (&H590 * 89)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 91 Then
                    ws.Position = &H2193 + (&H590 * 90)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 92 Then
                    ws.Position = &H2193 + (&H590 * 91)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 93 Then
                    ws.Position = &H2193 + (&H590 * 92)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 94 Then
                    ws.Position = &H2193 + (&H590 * 93)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 95 Then
                    ws.Position = &H2193 + (&H590 * 94)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 96 Then
                    ws.Position = &H2193 + (&H590 * 95)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 97 Then
                    ws.Position = &H2193 + (&H590 * 96)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 98 Then
                    ws.Position = &H2193 + (&H590 * 97)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 99 Then
                    ws.Position = &H2193 + (&H590 * 98)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                If valu_lastmii.Value >= 100 Then
                    ws.Position = &H2193 + (&H590 * 99)
                    If valu_setalltummy.Value = 0 Then
                        ws.WriteByte(0)
                    ElseIf valu_setalltummy.Value = 1 Then
                        ws.WriteByte(100)
                    End If
                End If
                ws.Close()
            End If
        End If
    End Sub

    Private Sub Check_setalltummy_CheckedChanged(sender As Object, e As EventArgs) Handles Check_setalltummy.CheckedChanged
        If Check_setalltummy.Checked = True Then
            Try
                settummyfullempt()
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Tummies has been edited"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Les estomacs ont été édités"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to edit tummies"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "L'édition des estomacs a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub
End Class