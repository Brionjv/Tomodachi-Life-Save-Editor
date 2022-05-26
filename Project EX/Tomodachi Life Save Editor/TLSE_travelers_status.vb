Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_travelers_status
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

    Private Sub TLSE_travelers_status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Readmiiname()
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Public Sub Readmiiname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H318B0
                Select_mii.Items.Item(0) = "Traveler 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H324D8
                Select_mii.Items.Item(1) = "Traveler 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H33100
                Select_mii.Items.Item(2) = "Traveler 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H33D28
                Select_mii.Items.Item(3) = "Traveler 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H34950
                Select_mii.Items.Item(4) = "Traveler 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H35578
                Select_mii.Items.Item(5) = "Traveler 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H361A0
                Select_mii.Items.Item(6) = "Traveler 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H36DC8
                Select_mii.Items.Item(7) = "Traveler 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H379F0
                Select_mii.Items.Item(8) = "Traveler 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H38618
                Select_mii.Items.Item(9) = "Traveler 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39240
                Select_mii.Items.Item(10) = "Traveler 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39E68
                Select_mii.Items.Item(11) = "Traveler 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3AA90
                Select_mii.Items.Item(12) = "Traveler 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3B6B8
                Select_mii.Items.Item(13) = "Traveler 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C2E0
                Select_mii.Items.Item(14) = "Traveler 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3CF08
                Select_mii.Items.Item(15) = "Traveler 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DB30
                Select_mii.Items.Item(16) = "Traveler 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3E758
                Select_mii.Items.Item(17) = "Traveler 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3F380
                Select_mii.Items.Item(18) = "Traveler 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3FFA8
                Select_mii.Items.Item(19) = "Traveler 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40BD0
                Select_mii.Items.Item(20) = "Traveler 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H417F8
                Select_mii.Items.Item(21) = "Traveler 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H42420
                Select_mii.Items.Item(22) = "Traveler 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43048
                Select_mii.Items.Item(23) = "Traveler 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43C70
                Select_mii.Items.Item(24) = "Traveler 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H44898
                Select_mii.Items.Item(25) = "Traveler 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H454C0
                Select_mii.Items.Item(26) = "Traveler 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H460E8
                Select_mii.Items.Item(27) = "Traveler 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46D10
                Select_mii.Items.Item(28) = "Traveler 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H47938
                Select_mii.Items.Item(29) = "Traveler 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H48560
                Select_mii.Items.Item(30) = "Traveler 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49188
                Select_mii.Items.Item(31) = "Traveler 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49DB0
                Select_mii.Items.Item(32) = "Traveler 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4A9D8
                Select_mii.Items.Item(33) = "Traveler 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4B600
                Select_mii.Items.Item(34) = "Traveler 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4C228
                Select_mii.Items.Item(35) = "Traveler 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4CE50
                Select_mii.Items.Item(36) = "Traveler 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4DA78
                Select_mii.Items.Item(37) = "Traveler 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E6A0
                Select_mii.Items.Item(38) = "Traveler 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F2C8
                Select_mii.Items.Item(39) = "Traveler 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4FEF0
                Select_mii.Items.Item(40) = "Traveler 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H50B18
                Select_mii.Items.Item(41) = "Traveler 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H51740
                Select_mii.Items.Item(42) = "Traveler 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H52368
                Select_mii.Items.Item(43) = "Traveler 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H52F90
                Select_mii.Items.Item(44) = "Traveler 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53BB8
                Select_mii.Items.Item(45) = "Traveler 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H547E0
                Select_mii.Items.Item(46) = "Traveler 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55408
                Select_mii.Items.Item(47) = "Traveler 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56030
                Select_mii.Items.Item(48) = "Traveler 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56C58
                Select_mii.Items.Item(49) = "Traveler 50 : " & Reader.ReadUnicodeString(10)
            Else
                Reader.Position = &H392C0
                Select_mii.Items.Item(0) = "Traveler 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39EE8
                Select_mii.Items.Item(1) = "Traveler 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3AB10
                Select_mii.Items.Item(2) = "Traveler 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3B738
                Select_mii.Items.Item(3) = "Traveler 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C360
                Select_mii.Items.Item(4) = "Traveler 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3CF88
                Select_mii.Items.Item(5) = "Traveler 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DBB0
                Select_mii.Items.Item(6) = "Traveler 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3E7D8
                Select_mii.Items.Item(7) = "Traveler 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3F400
                Select_mii.Items.Item(8) = "Traveler 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40028
                Select_mii.Items.Item(9) = "Traveler 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40C50
                Select_mii.Items.Item(10) = "Traveler 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H41878
                Select_mii.Items.Item(11) = "Traveler 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H424A0
                Select_mii.Items.Item(12) = "Traveler 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H430C8
                Select_mii.Items.Item(13) = "Traveler 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43CF0
                Select_mii.Items.Item(14) = "Traveler 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H44918
                Select_mii.Items.Item(15) = "Traveler 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H45540
                Select_mii.Items.Item(16) = "Traveler 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46168
                Select_mii.Items.Item(17) = "Traveler 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46D90
                Select_mii.Items.Item(18) = "Traveler 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H479B8
                Select_mii.Items.Item(19) = "Traveler 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H485E0
                Select_mii.Items.Item(20) = "Traveler 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49208
                Select_mii.Items.Item(21) = "Traveler 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49E30
                Select_mii.Items.Item(22) = "Traveler 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4AA58
                Select_mii.Items.Item(23) = "Traveler 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4B680
                Select_mii.Items.Item(24) = "Traveler 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4C2A8
                Select_mii.Items.Item(25) = "Traveler 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4CED0
                Select_mii.Items.Item(26) = "Traveler 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4DAF8
                Select_mii.Items.Item(27) = "Traveler 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E720
                Select_mii.Items.Item(28) = "Traveler 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F348
                Select_mii.Items.Item(29) = "Traveler 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4FF70
                Select_mii.Items.Item(30) = "Traveler 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H50B98
                Select_mii.Items.Item(31) = "Traveler 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H517C0
                Select_mii.Items.Item(32) = "Traveler 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H523E8
                Select_mii.Items.Item(33) = "Traveler 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53010
                Select_mii.Items.Item(34) = "Traveler 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53C38
                Select_mii.Items.Item(35) = "Traveler 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H54860
                Select_mii.Items.Item(36) = "Traveler 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55488
                Select_mii.Items.Item(37) = "Traveler 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H560B0
                Select_mii.Items.Item(38) = "Traveler 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56CD8
                Select_mii.Items.Item(39) = "Traveler 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H57900
                Select_mii.Items.Item(40) = "Traveler 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H58528
                Select_mii.Items.Item(41) = "Traveler 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H59150
                Select_mii.Items.Item(42) = "Traveler 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H59D78
                Select_mii.Items.Item(43) = "Traveler 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5A9A0
                Select_mii.Items.Item(44) = "Traveler 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5B5C8
                Select_mii.Items.Item(45) = "Traveler 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5C1F0
                Select_mii.Items.Item(46) = "Traveler 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5CE18
                Select_mii.Items.Item(47) = "Traveler 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5DA40
                Select_mii.Items.Item(48) = "Traveler 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5E668
                Select_mii.Items.Item(49) = "Traveler 50 : " & Reader.ReadUnicodeString(10)
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