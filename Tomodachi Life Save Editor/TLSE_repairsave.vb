Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_repairsave
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String

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

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
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

    Private Sub TLSE_repairsave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Public Sub Checkheader()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H0
            Text_header.Text = Reader.ReadHexString(4)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to check header"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "la vérification de l'entête a échoué"
            End If
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Text_header_TextChanged(sender As Object, e As EventArgs) Handles Text_header.TextChanged
        If Text_header.Text = "11000000" Then
            Text_header.BackColor = DefaultBackColor
            Icon_header.Visible = False
        Else
            Text_header.BackColor = Color.Red
            Icon_header.Visible = True
        End If
    End Sub
    Private Sub Icon_header_Click(sender As Object, e As EventArgs) Handles Icon_header.Click
        Text_header.Text = "11000000"
        Dim xs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        Try
            xs.Position = &H0
            For j As Integer = 0 To Text_header.Text.Length - 1 Step 2
                xs.WriteByte(CByte(Conversion.Val("&H" & Text_header.Text.Substring(j, 2))))
            Next
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Header has been fixed"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'entête a été corrigée"
            End If
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Header', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'écriture de cette fonctionnalité a échoué : 'Header', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub TLSE_repairsave_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Checkheader()
    End Sub

    Private Sub Check_fixunknow_CheckedChanged(sender As Object, e As EventArgs) Handles Check_fixunknow.CheckedChanged
        If Check_fixunknow.Checked = True Then
            Try
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                Writer.Position = &H29AB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000000000000001000000000")
                Writer.Position = &H29BB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000001000100001000000000")
                Writer.Position = &H29CB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000002000200001000000000")
                Writer.Position = &H29DB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000003000300001000000000")
                Writer.Position = &H29EB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000004000400001000000000")
                Writer.Position = &H29FB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000005000500001000000000")
                Writer.Position = &H2A0B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000006000600001000000000")
                Writer.Position = &H2A1B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000007000700001000000000")
                Writer.Position = &H2A2B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000008000800001000000000")
                Writer.Position = &H2A3B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000009000900001000000000")
                Writer.Position = &H2A4B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000000A000A00001000000000")
                Writer.Position = &H2A5B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000000B000B00001000000000")
                Writer.Position = &H2A6B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000000C000C00001000000000")
                Writer.Position = &H2A7B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000000D000D00001000000000")
                Writer.Position = &H2A8B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000000E000E00001000000000")
                Writer.Position = &H2A9B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000000F000F00001000000000")
                Writer.Position = &H2AAB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000010001000001000000000")
                Writer.Position = &H2ABB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000011001100001000000000")
                Writer.Position = &H2ACB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000012001200001000000000")
                Writer.Position = &H2ADB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000013001300001000000000")
                Writer.Position = &H2AEB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000014001400001000000000")
                Writer.Position = &H2AFB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000015001500001000000000")
                Writer.Position = &H2B0B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000016001600001000000000")
                Writer.Position = &H2B1B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000017001700001000000000")
                Writer.Position = &H2B2B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000018001800001000000000")
                Writer.Position = &H2B3B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000019001900001000000000")
                Writer.Position = &H2B4B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000001A001A00001000000000")
                Writer.Position = &H2B5B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000001B001B00001000000000")
                Writer.Position = &H2B6B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000001C001C00001000000000")
                Writer.Position = &H2B7B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000001D001D00001000000000")
                Writer.Position = &H2B8B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000001E001E00001000000000")
                Writer.Position = &H2B9B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000001F001F00001000000000")
                Writer.Position = &H2BAB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000020002000001000000000")
                Writer.Position = &H2BBB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000021002100001000000000")
                Writer.Position = &H2BCB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000022002200001000000000")
                Writer.Position = &H2BDB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000023002300001000000000")
                Writer.Position = &H2BEB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000024002400001000000000")
                Writer.Position = &H2BFB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000025002500001000000000")
                Writer.Position = &H2C0B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000026002600001000000000")
                Writer.Position = &H2C1B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000027002700001000000000")
                Writer.Position = &H2C2B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000028002800001000000000")
                Writer.Position = &H2C3B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000029002900001000000000")
                Writer.Position = &H2C4B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000002A002A00001000000000")
                Writer.Position = &H2C5B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000002B002B00001000000000")
                Writer.Position = &H2C6B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000002C002C00001000000000")
                Writer.Position = &H2C7B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000002D002D00001000000000")
                Writer.Position = &H2C8B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000002E002E00001000000000")
                Writer.Position = &H2C9B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000002F002F00001000000000")
                Writer.Position = &H2CAB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000030003000001000000000")
                Writer.Position = &H2CBB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000031003100001000000000")
                Writer.Position = &H2CCB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000032003200001000000000")
                Writer.Position = &H2CDB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000033003300001000000000")
                Writer.Position = &H2CEB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000034003400001000000000")
                Writer.Position = &H2CFB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000035003500001000000000")
                Writer.Position = &H2D0B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000036003600001000000000")
                Writer.Position = &H2D1B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000037003700001000000000")
                Writer.Position = &H2D2B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000038003800001000000000")
                Writer.Position = &H2D3B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000039003900001000000000")
                Writer.Position = &H2D4B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000003A003A00001000000000")
                Writer.Position = &H2D5B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000003B003B00001000000000")
                Writer.Position = &H2D6B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000003C003C00001000000000")
                Writer.Position = &H2D7B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000003D003D00001000000000")
                Writer.Position = &H2D8B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000003E003E00001000000000")
                Writer.Position = &H2D9B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000003F003F00001000000000")
                Writer.Position = &H2DAB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000040004000001000000000")
                Writer.Position = &H2DBB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000041004100001000000000")
                Writer.Position = &H2DCB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000042004200001000000000")
                Writer.Position = &H2DDB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000043004300001000000000")
                Writer.Position = &H2DEB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000044004400001000000000")
                Writer.Position = &H2DFB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000045004500001000000000")
                Writer.Position = &H2E0B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000046004600001000000000")
                Writer.Position = &H2E1B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000047004700001000000000")
                Writer.Position = &H2E2B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000048004800001000000000")
                Writer.Position = &H2E3B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000049004900001000000000")
                Writer.Position = &H2E4B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000004A004A00001000000000")
                Writer.Position = &H2E5B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000004B004B00001000000000")
                Writer.Position = &H2E6B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000004C004C00001000000000")
                Writer.Position = &H2E7B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000004D004D00001000000000")
                Writer.Position = &H2E8B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000004E004E00001000000000")
                Writer.Position = &H2E9B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000004F004F00001000000000")
                Writer.Position = &H2EAB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000050005000001000000000")
                Writer.Position = &H2EBB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000051005100001000000000")
                Writer.Position = &H2ECB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000052005200001000000000")
                Writer.Position = &H2EDB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000053005300001000000000")
                Writer.Position = &H2EEB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000054005400001000000000")
                Writer.Position = &H2EFB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000055005500001000000000")
                Writer.Position = &H2F0B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000056005600001000000000")
                Writer.Position = &H2F1B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000057005700001000000000")
                Writer.Position = &H2F2B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000058005800001000000000")
                Writer.Position = &H2F3B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000059005900001000000000")
                Writer.Position = &H2F4B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000005A005A00001000000000")
                Writer.Position = &H2F5B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000005B005B00001000000000")
                Writer.Position = &H2F6B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000005C005C00001000000000")
                Writer.Position = &H2F7B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000005D005D00001000000000")
                Writer.Position = &H2F8B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000005E005E00001000000000")
                Writer.Position = &H2F9B8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF0000000000000000000000000000000000000000000000000000000000005F005F00001000000000")
                Writer.Position = &H2FAB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000060006000001000000000")
                Writer.Position = &H2FBB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000061006100001000000000")
                Writer.Position = &H2FCB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000062006200001000000000")
                Writer.Position = &H2FDB8
                Writer.WriteHexString("00000000000000000000000CFFFFFFFF00000000000000000000000000000000000000000000000000000000000063006300001000000000")
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Unknow values has been fixed"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Les valeurs inconnues ont été corrigée"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to fix unknow values"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La correction des valeurs inconnues a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Check_deletetravelersdata_CheckedChanged(sender As Object, e As EventArgs) Handles Check_deletetravelersdata.CheckedChanged
        If Check_deletetravelersdata.Checked = True Then
            Try
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                If Filever_text.Text = "JP" Then
                    Writer.Position = &H316D0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H32228
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H32D80
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H338D8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H34430
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H34F88
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H35AE0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H36638
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H37190
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H37CE8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H38840
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H39398
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H39EF0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3AA48
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3B5A0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3C0F8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3CC50
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3D7A8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3E300
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3EE58
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H3F9B0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H40508
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H41060
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H41BB8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H42710
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H43268
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H43DC0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H44918
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H45470
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H45FC8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H46B20
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H47678
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H481D0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H48D28
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H49880
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4A3D8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4AF30
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4BA88
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4C5E0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4D138
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4DC90
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4E7E8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4F340
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H4FE98
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H509F0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H51548
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H520A0
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H52BF8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H53750
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                    Writer.Position = &H542A8
                    Writer.WriteHexString(Text_deletejtravelersdata.Text)
                Else
                    Writer.Position = &H390E0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H39D08
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3A930
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3B558
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3C180
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3CDA8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3D9D0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3E5F8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3F220
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H3FE48
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H40A70
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H41698
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H422C0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H42EE8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H43B10
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H44738
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H45360
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H45F88
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H46BB0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H477D8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H48400
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H49028
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H49C50
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4A878
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4B4A0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4C0C8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4CCF0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4D918
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4E540
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4F168
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H4FD90
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H509B8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H515E0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H52208
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H52E30
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H53A58
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H54680
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H552A8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H55ED0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H56AF8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H57720
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H58348
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H58F70
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H59B98
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H5A7C0
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H5B3E8
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H5C010
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H5CC38
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H5D860
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                    Writer.Position = &H5E488
                    Writer.WriteHexString(Text_deletetravelersdata.Text)
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Travelers data has been delete"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Les données des voyageurs ont été supprimés"
                End If
                TLSE_dialog.ShowDialog()
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "Failed to delete travelers data"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    TLSE_dialog.Text_TLSE_dialog.Text = "La suppression des données des voyageurs a échoué"
                End If
                TLSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Check_fixunknow_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_fixunknow.MouseMove
        Text_description.Text = "Click to fix ''Mii location ?'' when save file is corrupted"
        Panel_description.Visible = True
    End Sub

    Private Sub Check_fixunknow_MouseLeave(sender As Object, e As EventArgs) Handles Check_fixunknow.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_deletetravelersdata_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_deletetravelersdata.MouseMove
        Text_description.Text = "Click to delete all travelers in island when a wrong file is used"
        Panel_description.Visible = True
    End Sub

    Private Sub Check_deletetravelersdata_MouseLeave(sender As Object, e As EventArgs) Handles Check_deletetravelersdata.MouseLeave
        Panel_description.Visible = False
    End Sub
End Class