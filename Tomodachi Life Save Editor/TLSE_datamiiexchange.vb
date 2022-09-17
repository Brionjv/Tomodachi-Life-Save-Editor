Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_datamiiexchange
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Miiexchange_1 As String
    Dim Miiexchange_2 As String
    Dim Miiexchange_3 As String
    Dim Miiexchange_4 As String
    Dim Miiexchange_5 As String
    Dim Miiexchange_6 As String
    Dim Miiexchange_7 As String
    Dim Miiexchange_8 As String
    Dim Miiexchange_9 As String
    Dim Miiexchange_10 As String
    Dim Miiexchange_11 As String
    Dim Miiexchange_12 As String
    Dim Miiexchange_13 As String
    Dim Miiexchange_14 As String
    Dim Miiexchange_15 As String
    Dim Miiexchange_16 As String
    Dim Miiexchange_17 As String
    Dim Miiexchange_18 As String
    Dim Miiexchange_19 As String
    Dim Miiexchange_20 As String
    Dim Miiexchange_21 As String
    Dim Miiexchange_22 As String
    Dim Miiexchange_23 As String
    Dim Miiexchange_24 As String
    Dim Miiexchange_25 As String
    Dim Miiexchange_26 As String
    Dim Miiexchange_27 As String
    Dim Miiexchange_28 As String
    Dim Miiexchange_29 As String
    Dim Miiexchange_30 As String
    Dim Miiexchange_31 As String
    Dim Miiexchange_32 As String
    Dim Miiexchange_33 As String
    Dim Miiexchange_34 As String
    Dim Miiexchange_35 As String
    Dim Miiexchange_36 As String
    Dim Miiexchange_37 As String
    Dim Miiexchange_38 As String
    Dim Miiexchange_39 As String
    Dim Miiexchange_40 As String
    Dim Miiexchange_41 As String
    Dim Miiexchange_42 As String
    Dim Miiexchange_43 As String
    Dim Miiexchange_44 As String
    Dim Miiexchange_45 As String
    Dim Miiexchange_46 As String
    Dim Miiexchange_47 As String
    Dim Miiexchange_48 As String
    Dim Miiexchange_49 As String
    Dim Miiexchange_50 As String
    Dim Miiexchangedetected As String
    Dim TLMII As String

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

    Private Sub TLSE_dataislandranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Readislandrankname()
        Exchangemiidetected()
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

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_datamanagement.Visible = True
        Me.Close()
    End Sub

    Public Sub Readislandrankname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H103CB2
                Select_miiexchange.Items.Item(0) = "Mii exchange 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1047E2
                Select_miiexchange.Items.Item(1) = "Mii exchange 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H105312
                Select_miiexchange.Items.Item(2) = "Mii exchange 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H105E42
                Select_miiexchange.Items.Item(3) = "Mii exchange 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H106972
                Select_miiexchange.Items.Item(4) = "Mii exchange 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1074A2
                Select_miiexchange.Items.Item(5) = "Mii exchange 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H107FD2
                Select_miiexchange.Items.Item(6) = "Mii exchange 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H108B02
                Select_miiexchange.Items.Item(7) = "Mii exchange 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H109632
                Select_miiexchange.Items.Item(8) = "Mii exchange 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10A162
                Select_miiexchange.Items.Item(9) = "Mii exchange 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10AC92
                Select_miiexchange.Items.Item(10) = "Mii exchange 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10B7C2
                Select_miiexchange.Items.Item(11) = "Mii exchange 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10C2F2
                Select_miiexchange.Items.Item(12) = "Mii exchange 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10CE22
                Select_miiexchange.Items.Item(13) = "Mii exchange 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10D952
                Select_miiexchange.Items.Item(14) = "Mii exchange 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10E482
                Select_miiexchange.Items.Item(15) = "Mii exchange 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10EFB2
                Select_miiexchange.Items.Item(16) = "Mii exchange 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H10FAE2
                Select_miiexchange.Items.Item(17) = "Mii exchange 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H110612
                Select_miiexchange.Items.Item(18) = "Mii exchange 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H111142
                Select_miiexchange.Items.Item(19) = "Mii exchange 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H111C72
                Select_miiexchange.Items.Item(20) = "Mii exchange 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1127A2
                Select_miiexchange.Items.Item(21) = "Mii exchange 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1132D2
                Select_miiexchange.Items.Item(22) = "Mii exchange 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H113E02
                Select_miiexchange.Items.Item(23) = "Mii exchange 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H114932
                Select_miiexchange.Items.Item(24) = "Mii exchange 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H115462
                Select_miiexchange.Items.Item(25) = "Mii exchange 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H115F92
                Select_miiexchange.Items.Item(26) = "Mii exchange 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H116AC2
                Select_miiexchange.Items.Item(27) = "Mii exchange 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1175F2
                Select_miiexchange.Items.Item(28) = "Mii exchange 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H118122
                Select_miiexchange.Items.Item(29) = "Mii exchange 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H118C52
                Select_miiexchange.Items.Item(30) = "Mii exchange 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H119782
                Select_miiexchange.Items.Item(31) = "Mii exchange 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11A2B2
                Select_miiexchange.Items.Item(32) = "Mii exchange 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11ADE2
                Select_miiexchange.Items.Item(33) = "Mii exchange 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11B912
                Select_miiexchange.Items.Item(34) = "Mii exchange 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11C442
                Select_miiexchange.Items.Item(35) = "Mii exchange 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11CF72
                Select_miiexchange.Items.Item(36) = "Mii exchange 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11DAA2
                Select_miiexchange.Items.Item(37) = "Mii exchange 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11E5D2
                Select_miiexchange.Items.Item(38) = "Mii exchange 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11F102
                Select_miiexchange.Items.Item(39) = "Mii exchange 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H11FC32
                Select_miiexchange.Items.Item(40) = "Mii exchange 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H120762
                Select_miiexchange.Items.Item(41) = "Mii exchange 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H121292
                Select_miiexchange.Items.Item(42) = "Mii exchange 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H121DC2
                Select_miiexchange.Items.Item(43) = "Mii exchange 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1228F2
                Select_miiexchange.Items.Item(44) = "Mii exchange 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H123422
                Select_miiexchange.Items.Item(45) = "Mii exchange 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H123F52
                Select_miiexchange.Items.Item(46) = "Mii exchange 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H124A82
                Select_miiexchange.Items.Item(47) = "Mii exchange 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1255B2
                Select_miiexchange.Items.Item(48) = "Mii exchange 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1260E2
                Select_miiexchange.Items.Item(49) = "Mii exchange 50 : " & Reader.ReadUnicodeString(10)
            ElseIf Filever_text.Text = "KR" Then
                Reader.Position = &H1A2982
                Select_miiexchange.Items.Item(0) = "Mii exchange 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A3582
                Select_miiexchange.Items.Item(1) = "Mii exchange 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A4182
                Select_miiexchange.Items.Item(2) = "Mii exchange 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A4D82
                Select_miiexchange.Items.Item(3) = "Mii exchange 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A5982
                Select_miiexchange.Items.Item(4) = "Mii exchange 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A6582
                Select_miiexchange.Items.Item(5) = "Mii exchange 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A7182
                Select_miiexchange.Items.Item(6) = "Mii exchange 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A7D82
                Select_miiexchange.Items.Item(7) = "Mii exchange 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A8982
                Select_miiexchange.Items.Item(8) = "Mii exchange 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A9582
                Select_miiexchange.Items.Item(9) = "Mii exchange 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AA182
                Select_miiexchange.Items.Item(10) = "Mii exchange 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AAD82
                Select_miiexchange.Items.Item(11) = "Mii exchange 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AB982
                Select_miiexchange.Items.Item(12) = "Mii exchange 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AC582
                Select_miiexchange.Items.Item(13) = "Mii exchange 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AD182
                Select_miiexchange.Items.Item(14) = "Mii exchange 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1ADD82
                Select_miiexchange.Items.Item(15) = "Mii exchange 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AE982
                Select_miiexchange.Items.Item(16) = "Mii exchange 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AF582
                Select_miiexchange.Items.Item(17) = "Mii exchange 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B0182
                Select_miiexchange.Items.Item(18) = "Mii exchange 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B0D82
                Select_miiexchange.Items.Item(19) = "Mii exchange 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B1982
                Select_miiexchange.Items.Item(20) = "Mii exchange 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B2582
                Select_miiexchange.Items.Item(21) = "Mii exchange 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B3182
                Select_miiexchange.Items.Item(22) = "Mii exchange 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B3D82
                Select_miiexchange.Items.Item(23) = "Mii exchange 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B4982
                Select_miiexchange.Items.Item(24) = "Mii exchange 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B5582
                Select_miiexchange.Items.Item(25) = "Mii exchange 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B6182
                Select_miiexchange.Items.Item(26) = "Mii exchange 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B6D82
                Select_miiexchange.Items.Item(27) = "Mii exchange 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B7982
                Select_miiexchange.Items.Item(28) = "Mii exchange 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B8582
                Select_miiexchange.Items.Item(29) = "Mii exchange 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B9182
                Select_miiexchange.Items.Item(30) = "Mii exchange 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B9D82
                Select_miiexchange.Items.Item(31) = "Mii exchange 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BA982
                Select_miiexchange.Items.Item(32) = "Mii exchange 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BB582
                Select_miiexchange.Items.Item(33) = "Mii exchange 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BC182
                Select_miiexchange.Items.Item(34) = "Mii exchange 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BCD82
                Select_miiexchange.Items.Item(35) = "Mii exchange 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BD982
                Select_miiexchange.Items.Item(36) = "Mii exchange 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BE582
                Select_miiexchange.Items.Item(37) = "Mii exchange 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BF182
                Select_miiexchange.Items.Item(38) = "Mii exchange 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BFD82
                Select_miiexchange.Items.Item(39) = "Mii exchange 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C0982
                Select_miiexchange.Items.Item(40) = "Mii exchange 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C1582
                Select_miiexchange.Items.Item(41) = "Mii exchange 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C2182
                Select_miiexchange.Items.Item(42) = "Mii exchange 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C2D82
                Select_miiexchange.Items.Item(43) = "Mii exchange 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C3982
                Select_miiexchange.Items.Item(44) = "Mii exchange 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C4582
                Select_miiexchange.Items.Item(45) = "Mii exchange 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C5182
                Select_miiexchange.Items.Item(46) = "Mii exchange 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C5D82
                Select_miiexchange.Items.Item(47) = "Mii exchange 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C6982
                Select_miiexchange.Items.Item(48) = "Mii exchange 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1C7582
                Select_miiexchange.Items.Item(49) = "Mii exchange 50 : " & Reader.ReadUnicodeString(10)
            Else
                Reader.Position = &H1975D2
                Select_miiexchange.Items.Item(0) = "Mii exchange 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1981D2
                Select_miiexchange.Items.Item(1) = "Mii exchange 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H198DD2
                Select_miiexchange.Items.Item(2) = "Mii exchange 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1999D2
                Select_miiexchange.Items.Item(3) = "Mii exchange 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19A5D2
                Select_miiexchange.Items.Item(4) = "Mii exchange 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19B1D2
                Select_miiexchange.Items.Item(5) = "Mii exchange 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19BDD2
                Select_miiexchange.Items.Item(6) = "Mii exchange 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19C9D2
                Select_miiexchange.Items.Item(7) = "Mii exchange 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19D5D2
                Select_miiexchange.Items.Item(8) = "Mii exchange 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19E1D2
                Select_miiexchange.Items.Item(9) = "Mii exchange 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19EDD2
                Select_miiexchange.Items.Item(10) = "Mii exchange 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H19F9D2
                Select_miiexchange.Items.Item(11) = "Mii exchange 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A05D2
                Select_miiexchange.Items.Item(12) = "Mii exchange 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A11D2
                Select_miiexchange.Items.Item(13) = "Mii exchange 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A1DD2
                Select_miiexchange.Items.Item(14) = "Mii exchange 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A29D2
                Select_miiexchange.Items.Item(15) = "Mii exchange 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A35D2
                Select_miiexchange.Items.Item(16) = "Mii exchange 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A41D2
                Select_miiexchange.Items.Item(17) = "Mii exchange 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A4DD2
                Select_miiexchange.Items.Item(18) = "Mii exchange 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A59D2
                Select_miiexchange.Items.Item(19) = "Mii exchange 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A65D2
                Select_miiexchange.Items.Item(20) = "Mii exchange 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A71D2
                Select_miiexchange.Items.Item(21) = "Mii exchange 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A7DD2
                Select_miiexchange.Items.Item(22) = "Mii exchange 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A89D2
                Select_miiexchange.Items.Item(23) = "Mii exchange 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1A95D2
                Select_miiexchange.Items.Item(24) = "Mii exchange 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AA1D2
                Select_miiexchange.Items.Item(25) = "Mii exchange 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AADD2
                Select_miiexchange.Items.Item(26) = "Mii exchange 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AB9D2
                Select_miiexchange.Items.Item(27) = "Mii exchange 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AC5D2
                Select_miiexchange.Items.Item(28) = "Mii exchange 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AD1D2
                Select_miiexchange.Items.Item(29) = "Mii exchange 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1ADDD2
                Select_miiexchange.Items.Item(30) = "Mii exchange 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AE9D2
                Select_miiexchange.Items.Item(31) = "Mii exchange 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1AF5D2
                Select_miiexchange.Items.Item(32) = "Mii exchange 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B01D2
                Select_miiexchange.Items.Item(33) = "Mii exchange 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B0DD2
                Select_miiexchange.Items.Item(34) = "Mii exchange 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B19D2
                Select_miiexchange.Items.Item(35) = "Mii exchange 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B25D2
                Select_miiexchange.Items.Item(36) = "Mii exchange 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B31D2
                Select_miiexchange.Items.Item(37) = "Mii exchange 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B3DD2
                Select_miiexchange.Items.Item(38) = "Mii exchange 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B49D2
                Select_miiexchange.Items.Item(39) = "Mii exchange 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B55D2
                Select_miiexchange.Items.Item(40) = "Mii exchange 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B61D2
                Select_miiexchange.Items.Item(41) = "Mii exchange 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B6DD2
                Select_miiexchange.Items.Item(42) = "Mii exchange 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B79D2
                Select_miiexchange.Items.Item(43) = "Mii exchange 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B85D2
                Select_miiexchange.Items.Item(44) = "Mii exchange 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B91D2
                Select_miiexchange.Items.Item(45) = "Mii exchange 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1B9DD2
                Select_miiexchange.Items.Item(46) = "Mii exchange 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BA9D2
                Select_miiexchange.Items.Item(47) = "Mii exchange 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BB5D2
                Select_miiexchange.Items.Item(48) = "Mii exchange 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H1BC1D2
                Select_miiexchange.Items.Item(49) = "Mii exchange 50 : " & Reader.ReadUnicodeString(10)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read island ranking names"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture des noms des îles a échoué"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub Exchangemiidetected()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H1047C0
                Miiexchangedetected = Reader.ReadByte
                Reader.Position = &H1052F0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H105E20
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H106950
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H107480
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H107FB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H108AE0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H109610
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10A140
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10AC70
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10B7A0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10C2D0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10CE00
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10D930
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10E460
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10EF90
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H10FAC0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1105F0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H111120
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H111C50
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H112780
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1132B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H113DE0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H114910
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H115440
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H115F70
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H116AA0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1175D0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H118100
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H118C30
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H119760
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11A290
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11ADC0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11B8F0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11C420
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11CF50
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11DA80
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11E5B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11F0E0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H11FC10
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H120740
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H121270
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H121DA0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1228D0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H123400
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H123F30
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H124A60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H125590
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1260C0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H126BF0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
            ElseIf Filever_text.Text = "KR" Then
                Reader.Position = &H1A3560
                Miiexchangedetected = Reader.ReadByte
                Reader.Position = &H1A4160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A4D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A5960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A6560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A7160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A7D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A8960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A9560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AA160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AAD60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AB960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AC560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AD160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1ADD60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AE960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AF560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B0160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B0D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B1960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B2560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B3160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B3D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B4960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B5560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B6160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B6D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B7960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B8560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B9160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B9D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BA960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BB560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BC160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BCD60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BD960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BE560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BF160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BFD60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C0960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C1560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C2160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C2D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C3960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C4560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C5160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C5D60
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C6960
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C7560
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1C8160
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
            Else
                Reader.Position = &H1981B0
                Miiexchangedetected = Reader.ReadByte
                Reader.Position = &H198DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1999B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19A5B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19B1B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19BDB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19C9B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19D5B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19E1B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19EDB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H19F9B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A05B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A11B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A1DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A29B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A35B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A41B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A4DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A59B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A65B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A71B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A7DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A89B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1A95B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AA1B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AADB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AB9B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AC5B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AD1B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1ADDB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AE9B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1AF5B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B01B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B0DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B19B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B25B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B31B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B3DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B49B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B55B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B61B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B6DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B79B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B85B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B91B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1B9DB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BA9B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BB5B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BC1B0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
                Reader.Position = &H1BCDB0
                Miiexchangedetected = Miiexchangedetected + Reader.ReadByte
            End If
            Text_miidetected.Text = "X " + Miiexchangedetected
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to detect Mii exchange in this save file"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Échec de la détection des échanges Mii dans ce fichier de sauvegarde"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub Setmiiexchange()
        Try
            If Filever_text.Text = "JP" Then
                Miiexchange_1 = &H103C98
                Miiexchange_2 = &H1047C8
                Miiexchange_3 = &H1052F8
                Miiexchange_4 = &H105E28
                Miiexchange_5 = &H106958
                Miiexchange_6 = &H107488
                Miiexchange_7 = &H107FB8
                Miiexchange_8 = &H108AE8
                Miiexchange_9 = &H109618
                Miiexchange_10 = &H10A148
                Miiexchange_11 = &H10AC78
                Miiexchange_12 = &H10B7A8
                Miiexchange_13 = &H10C2D8
                Miiexchange_14 = &H10CE08
                Miiexchange_15 = &H10D938
                Miiexchange_16 = &H10E468
                Miiexchange_17 = &H10EF98
                Miiexchange_18 = &H10FAC8
                Miiexchange_19 = &H1105F8
                Miiexchange_20 = &H111128
                Miiexchange_21 = &H111C58
                Miiexchange_22 = &H112788
                Miiexchange_23 = &H1132B8
                Miiexchange_24 = &H113DE8
                Miiexchange_25 = &H114918
                Miiexchange_26 = &H115448
                Miiexchange_27 = &H115F78
                Miiexchange_28 = &H116AA8
                Miiexchange_29 = &H1175D8
                Miiexchange_30 = &H118108
                Miiexchange_31 = &H118C38
                Miiexchange_32 = &H119768
                Miiexchange_33 = &H11A298
                Miiexchange_34 = &H11ADC8
                Miiexchange_35 = &H11B8F8
                Miiexchange_36 = &H11C428
                Miiexchange_37 = &H11CF58
                Miiexchange_38 = &H11DA88
                Miiexchange_39 = &H11E5B8
                Miiexchange_40 = &H11F0E8
                Miiexchange_41 = &H11FC18
                Miiexchange_42 = &H120748
                Miiexchange_43 = &H121278
                Miiexchange_44 = &H121DA8
                Miiexchange_45 = &H1228D8
                Miiexchange_46 = &H123408
                Miiexchange_47 = &H123F38
                Miiexchange_48 = &H124A68
                Miiexchange_49 = &H125598
                Miiexchange_50 = &H1260C8
            ElseIf Filever_text.Text = "KR" Then
                Miiexchange_1 = &H1A2968
                Miiexchange_2 = &H1A3568
                Miiexchange_3 = &H1A4168
                Miiexchange_4 = &H1A4D68
                Miiexchange_5 = &H1A5968
                Miiexchange_6 = &H1A6568
                Miiexchange_7 = &H1A7168
                Miiexchange_8 = &H1A7D68
                Miiexchange_9 = &H1A8968
                Miiexchange_10 = &H1A9568
                Miiexchange_11 = &H1AA168
                Miiexchange_12 = &H1AAD68
                Miiexchange_13 = &H1AB968
                Miiexchange_14 = &H1AC568
                Miiexchange_15 = &H1AD168
                Miiexchange_16 = &H1ADD68
                Miiexchange_17 = &H1AE968
                Miiexchange_18 = &H1AF568
                Miiexchange_19 = &H1B0168
                Miiexchange_20 = &H1B0D68
                Miiexchange_21 = &H1B1968
                Miiexchange_22 = &H1B2568
                Miiexchange_23 = &H1B3168
                Miiexchange_24 = &H1B3D68
                Miiexchange_25 = &H1B4968
                Miiexchange_26 = &H1B5568
                Miiexchange_27 = &H1B6168
                Miiexchange_28 = &H1B6D68
                Miiexchange_29 = &H1B7968
                Miiexchange_30 = &H1B8568
                Miiexchange_31 = &H1B9168
                Miiexchange_32 = &H1B9D68
                Miiexchange_33 = &H1BA968
                Miiexchange_34 = &H1BB568
                Miiexchange_35 = &H1BC168
                Miiexchange_36 = &H1BCD68
                Miiexchange_37 = &H1BD968
                Miiexchange_38 = &H1BE568
                Miiexchange_39 = &H1BF168
                Miiexchange_40 = &H1BFD68
                Miiexchange_41 = &H1C0968
                Miiexchange_42 = &H1C1568
                Miiexchange_43 = &H1C2168
                Miiexchange_44 = &H1C2D68
                Miiexchange_45 = &H1C3968
                Miiexchange_46 = &H1C4568
                Miiexchange_47 = &H1C5168
                Miiexchange_48 = &H1C5D68
                Miiexchange_49 = &H1C6968
                Miiexchange_50 = &H1C7568
            Else
                Miiexchange_1 = &H1975B8
                Miiexchange_2 = &H1981B8
                Miiexchange_3 = &H198DB8
                Miiexchange_4 = &H1999B8
                Miiexchange_5 = &H19A5B8
                Miiexchange_6 = &H19B1B8
                Miiexchange_7 = &H19BDB8
                Miiexchange_8 = &H19C9B8
                Miiexchange_9 = &H19D5B8
                Miiexchange_10 = &H19E1B8
                Miiexchange_11 = &H19EDB8
                Miiexchange_12 = &H19F9B8
                Miiexchange_13 = &H1A05B8
                Miiexchange_14 = &H1A11B8
                Miiexchange_15 = &H1A1DB8
                Miiexchange_16 = &H1A29B8
                Miiexchange_17 = &H1A35B8
                Miiexchange_18 = &H1A41B8
                Miiexchange_19 = &H1A4DB8
                Miiexchange_20 = &H1A59B8
                Miiexchange_21 = &H1A65B8
                Miiexchange_22 = &H1A71B8
                Miiexchange_23 = &H1A7DB8
                Miiexchange_24 = &H1A89B8
                Miiexchange_25 = &H1A95B8
                Miiexchange_26 = &H1AA1B8
                Miiexchange_27 = &H1AADB8
                Miiexchange_28 = &H1AB9B8
                Miiexchange_29 = &H1AC5B8
                Miiexchange_30 = &H1AD1B8
                Miiexchange_31 = &H1ADDB8
                Miiexchange_32 = &H1AE9B8
                Miiexchange_33 = &H1AF5B8
                Miiexchange_34 = &H1B01B8
                Miiexchange_35 = &H1B0DB8
                Miiexchange_36 = &H1B19B8
                Miiexchange_37 = &H1B25B8
                Miiexchange_38 = &H1B31B8
                Miiexchange_39 = &H1B3DB8
                Miiexchange_40 = &H1B49B8
                Miiexchange_41 = &H1B55B8
                Miiexchange_42 = &H1B61B8
                Miiexchange_43 = &H1B6DB8
                Miiexchange_44 = &H1B79B8
                Miiexchange_45 = &H1B85B8
                Miiexchange_46 = &H1B91B8
                Miiexchange_47 = &H1B9DB8
                Miiexchange_48 = &H1BA9B8
                Miiexchange_49 = &H1BB5B8
                Miiexchange_50 = &H1BC1B8
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Readislandranking()
        Setmiiexchange()
        Try
            Dim ReadexchangeData As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(0) Then
                ReadexchangeData.Position = Miiexchange_1
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(1) Then
                ReadexchangeData.Position = Miiexchange_2
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(2) Then
                ReadexchangeData.Position = Miiexchange_3
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(3) Then
                ReadexchangeData.Position = Miiexchange_4
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(4) Then
                ReadexchangeData.Position = Miiexchange_5
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(5) Then
                ReadexchangeData.Position = Miiexchange_6
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(6) Then
                ReadexchangeData.Position = Miiexchange_7
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(7) Then
                ReadexchangeData.Position = Miiexchange_8
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(8) Then
                ReadexchangeData.Position = Miiexchange_9
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(9) Then
                ReadexchangeData.Position = Miiexchange_10
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(10) Then
                ReadexchangeData.Position = Miiexchange_11
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(11) Then
                ReadexchangeData.Position = Miiexchange_12
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(12) Then
                ReadexchangeData.Position = Miiexchange_13
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(13) Then
                ReadexchangeData.Position = Miiexchange_14
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(14) Then
                ReadexchangeData.Position = Miiexchange_15
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(15) Then
                ReadexchangeData.Position = Miiexchange_16
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(16) Then
                ReadexchangeData.Position = Miiexchange_17
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(17) Then
                ReadexchangeData.Position = Miiexchange_18
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(18) Then
                ReadexchangeData.Position = Miiexchange_19
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(19) Then
                ReadexchangeData.Position = Miiexchange_20
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(20) Then
                ReadexchangeData.Position = Miiexchange_21
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(21) Then
                ReadexchangeData.Position = Miiexchange_22
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(22) Then
                ReadexchangeData.Position = Miiexchange_23
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(23) Then
                ReadexchangeData.Position = Miiexchange_24
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(24) Then
                ReadexchangeData.Position = Miiexchange_25
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(25) Then
                ReadexchangeData.Position = Miiexchange_26
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(26) Then
                ReadexchangeData.Position = Miiexchange_27
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(27) Then
                ReadexchangeData.Position = Miiexchange_28
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(28) Then
                ReadexchangeData.Position = Miiexchange_29
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(29) Then
                ReadexchangeData.Position = Miiexchange_30
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(30) Then
                ReadexchangeData.Position = Miiexchange_31
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(31) Then
                ReadexchangeData.Position = Miiexchange_32
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(32) Then
                ReadexchangeData.Position = Miiexchange_33
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(33) Then
                ReadexchangeData.Position = Miiexchange_34
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(34) Then
                ReadexchangeData.Position = Miiexchange_35
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(35) Then
                ReadexchangeData.Position = Miiexchange_36
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(36) Then
                ReadexchangeData.Position = Miiexchange_37
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(37) Then
                ReadexchangeData.Position = Miiexchange_38
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(38) Then
                ReadexchangeData.Position = Miiexchange_39
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(39) Then
                ReadexchangeData.Position = Miiexchange_40
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(40) Then
                ReadexchangeData.Position = Miiexchange_41
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(41) Then
                ReadexchangeData.Position = Miiexchange_42
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(42) Then
                ReadexchangeData.Position = Miiexchange_43
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(43) Then
                ReadexchangeData.Position = Miiexchange_44
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(44) Then
                ReadexchangeData.Position = Miiexchange_45
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(45) Then
                ReadexchangeData.Position = Miiexchange_46
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(46) Then
                ReadexchangeData.Position = Miiexchange_47
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(47) Then
                ReadexchangeData.Position = Miiexchange_48
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(48) Then
                ReadexchangeData.Position = Miiexchange_49
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
            If Select_miiexchange.SelectedItem = Select_miiexchange.Items.Item(49) Then
                ReadexchangeData.Position = Miiexchange_50
                If Filever_text.Text = "JP" Then
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HB30)
                Else
                    Text_extract_islandranking.Text = ReadexchangeData.ReadHexString(&HC00)
                End If
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this Mii in exchange list, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Select_miiexchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_miiexchange.SelectedIndexChanged
        Readislandranking()
    End Sub

    Private Sub Text_extractmii_Click(sender As Object, e As EventArgs) Handles Text_extractmii.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            If Filever_text.Text = "JP" Then
                SaveFileDialog1.Filter = "Tomodachi Life Island Ranking|*.jmiiexchange"
            Else
                SaveFileDialog1.Filter = "Tomodachi Life Island Ranking|*.miiexchange"
            End If
            SaveFileDialog1.FileName = Select_miiexchange.Text.Replace(":", "") & "_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_extract_islandranking.Text)
                TLSE_dialog.Text_TLSE_dialog.Text = "This Mii has been successfully extracted"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Extraction of this Mii has failed, retry or report this issue"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub
End Class