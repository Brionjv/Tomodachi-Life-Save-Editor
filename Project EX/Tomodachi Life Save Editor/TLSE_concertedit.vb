Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_concertedit
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Pagh1 As String
    Dim Pagh2 As String
    Dim Pagh3 As String
    Dim Pagh4 As String
    Dim Pagh5 As String
    Dim Pagh6 As String
    Dim Pagh7 As String
    Dim Pagh8 As String
    Dim Pagh9 As String
    Dim Pagh10 As String
    Dim Pagh11 As String
    Dim Pagh12 As String
    Dim Pagh13 As String
    Dim Tmusc As String
    Dim Accesspagh As String
    Dim ValPagh1 As String
    Dim ValPagh2 As String
    Dim ValPagh3 As String
    Dim ValPagh4 As String
    Dim ValPagh5 As String
    Dim ValPagh6 As String
    Dim ValPagh7 As String
    Dim ValPagh8 As String
    Dim ValPagh9 As String
    Dim ValPagh10 As String
    Dim ValPagh11 As String
    Dim ValPagh12 As String
    Dim ValPagh13 As String
    Dim Typesong As String

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

    Private Sub TLSE_concertedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub Select_songs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_songs.SelectedIndexChanged
        If Select_songs.SelectedItem = Select_songs.Items.Item(0) Then
            Accesspagh = &H0
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(1) Then
            Accesspagh = &H5C4
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(2) Then
            Accesspagh = &H5C4 * 2
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(3) Then
            Accesspagh = &H5C4 * 3
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(4) Then
            Accesspagh = &H5C4 * 4
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(5) Then
            Accesspagh = &H5C4 * 5
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(6) Then
            Accesspagh = &H5C4 * 6
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(7) Then
            Accesspagh = &H5C4 * 7
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(8) Then
            Accesspagh = &H5C4 * 8
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(9) Then
            Accesspagh = &H5C4 * 9
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(10) Then
            Accesspagh = &H5C4 * 10
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(11) Then
            Accesspagh = &H5C4 * 11
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(12) Then
            Accesspagh = &H5C4 * 12
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(13) Then
            Accesspagh = &H5C4 * 13
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(14) Then
            Accesspagh = &H5C4 * 14
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(15) Then
            Accesspagh = &H5C4 * 15
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(16) Then
            Accesspagh = &H5C4 * 16
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(17) Then
            Accesspagh = &H5C4 * 17
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(18) Then
            Accesspagh = &H5C4 * 18
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(19) Then
            Accesspagh = &H5C4 * 19
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(20) Then
            Accesspagh = &H5C4 * 20
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(21) Then
            Accesspagh = &H5C4 * 21
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(22) Then
            Accesspagh = &H5C4 * 22
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(23) Then
            Accesspagh = &H5C4 * 23
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(24) Then
            Accesspagh = &H5C4 * 24
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(25) Then
            Accesspagh = &H5C4 * 25
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(26) Then
            Accesspagh = &H5C4 * 26
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(27) Then
            Accesspagh = &H5C4 * 27
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(28) Then
            Accesspagh = &H5C4 * 28
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(29) Then
            Accesspagh = &H5C4 * 29
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(30) Then
            Accesspagh = &H5C4 * 30
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(31) Then
            Accesspagh = &H5C4 * 31
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(32) Then
            Accesspagh = &H5C4 * 32
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(33) Then
            Accesspagh = &H5C4 * 33
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(34) Then
            Accesspagh = &H5C4 * 34
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(35) Then
            Accesspagh = &H5C4 * 35
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(36) Then
            Accesspagh = &H5C4 * 36
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(37) Then
            Accesspagh = &H5C4 * 37
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(38) Then
            Accesspagh = &H5C4 * 38
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(39) Then
            Accesspagh = &H5C4 * 39
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(40) Then
            Accesspagh = &H5C4 * 40
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(41) Then
            Accesspagh = &H5C4 * 41
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(42) Then
            Accesspagh = &H5C4 * 42
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(43) Then
            Accesspagh = &H5C4 * 43
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(44) Then
            Accesspagh = &H5C4 * 44
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(45) Then
            Accesspagh = &H5C4 * 45
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(46) Then
            Accesspagh = &H5C4 * 46
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(47) Then
            Accesspagh = &H5C4 * 47
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(48) Then
            Accesspagh = &H5C4 * 48
        ElseIf Select_songs.SelectedItem = Select_songs.Items.Item(49) Then
            Accesspagh = &H5C4 * 49
        End If
        readmusic()
    End Sub

    Public Sub readmusic()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = &H17B6E4 + Accesspagh
            ValPagh1 = Reader.Position
            valu_pagh_1.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh
            Pagh1 = Reader.Position
            Text_pagh_1.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + &H68
            ValPagh2 = Reader.Position
            valu_pagh_2.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + &H68
            Pagh2 = Reader.Position
            Text_pagh_2.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 2)
            ValPagh3 = Reader.Position
            valu_pagh_3.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 2)
            Pagh3 = Reader.Position
            Text_pagh_3.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 3)
            ValPagh4 = Reader.Position
            valu_pagh_4.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 3)
            Pagh4 = Reader.Position
            Text_pagh_4.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 4)
            ValPagh5 = Reader.Position
            valu_pagh_5.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 4)
            Pagh5 = Reader.Position
            Text_pagh_5.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 5)
            ValPagh6 = Reader.Position
            valu_pagh_6.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 5)
            Pagh6 = Reader.Position
            Text_pagh_6.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 6)
            ValPagh7 = Reader.Position
            valu_pagh_7.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 6)
            Pagh7 = Reader.Position
            Text_pagh_7.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 7)
            ValPagh8 = Reader.Position
            valu_pagh_8.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 7)
            Pagh8 = Reader.Position
            Text_pagh_8.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 8)
            ValPagh9 = Reader.Position
            valu_pagh_9.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 8)
            Pagh9 = Reader.Position
            Text_pagh_9.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 9)
            ValPagh10 = Reader.Position
            valu_pagh_10.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 9)
            Pagh10 = Reader.Position
            Text_pagh_10.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 10)
            ValPagh11 = Reader.Position
            valu_pagh_11.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 10)
            Pagh11 = Reader.Position
            Text_pagh_11.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 11)
            ValPagh12 = Reader.Position
            valu_pagh_12.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 11)
            Pagh12 = Reader.Position
            Text_pagh_12.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17B6E4 + Accesspagh + (&H68 * 12)
            ValPagh13 = Reader.Position
            valu_pagh_13.Value = Reader.ReadByte
            Reader.Position = &H17B6EA + Accesspagh + (&H68 * 12)
            Pagh13 = Reader.Position
            Text_pagh_13.Text = Reader.ReadUnicodeString(48)
            Reader.Position = &H17BC2C + Accesspagh
            Tmusc = Reader.Position
            Text_titlesong.Text = Reader.ReadUnicodeString(32)
            Reader.Position = &H17BC71 + Accesspagh
            Typesong = Reader.Position
            valu_typesong.Value = Reader.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this music, please report this issue"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de cette musique a échoué, veuilleez signaler cet erreur"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub valu_pagh_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_1.ValueChanged
        If valu_pagh_1.Value = 14 Then
            Text_pagh_1.Enabled = True
        Else
            Text_pagh_1.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_2.ValueChanged
        If valu_pagh_2.Value = 14 Then
            Text_pagh_2.Enabled = True
        Else
            Text_pagh_2.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_3.ValueChanged
        If valu_pagh_3.Value = 14 Then
            Text_pagh_3.Enabled = True
        Else
            Text_pagh_3.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_4.ValueChanged
        If valu_pagh_4.Value = 14 Then
            Text_pagh_4.Enabled = True
        Else
            Text_pagh_4.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_5.ValueChanged
        If valu_pagh_5.Value = 14 Then
            Text_pagh_5.Enabled = True
        Else
            Text_pagh_5.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_6.ValueChanged
        If valu_pagh_6.Value = 14 Then
            Text_pagh_6.Enabled = True
        Else
            Text_pagh_6.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_7.ValueChanged
        If valu_pagh_7.Value = 14 Then
            Text_pagh_7.Enabled = True
        Else
            Text_pagh_7.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_8.ValueChanged
        If valu_pagh_8.Value = 14 Then
            Text_pagh_8.Enabled = True
        Else
            Text_pagh_8.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_9.ValueChanged
        If valu_pagh_9.Value = 14 Then
            Text_pagh_9.Enabled = True
        Else
            Text_pagh_9.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_10.ValueChanged
        If valu_pagh_10.Value = 14 Then
            Text_pagh_10.Enabled = True
        Else
            Text_pagh_10.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_11.ValueChanged
        If valu_pagh_11.Value = 14 Then
            Text_pagh_11.Enabled = True
        Else
            Text_pagh_11.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_12.ValueChanged
        If valu_pagh_12.Value = 14 Then
            Text_pagh_12.Enabled = True
        Else
            Text_pagh_12.Enabled = False
        End If
    End Sub

    Private Sub valu_pagh_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_pagh_13.ValueChanged
        If valu_pagh_13.Value = 14 Then
            Text_pagh_13.Enabled = True
        Else
            Text_pagh_13.Enabled = False
        End If
    End Sub

    Private Sub Text_save_editsongs_Click(sender As Object, e As EventArgs) Handles Text_save_editsongs.Click
        Try
            'package.IO
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            If valu_pagh_1.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh1 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh1
                Writer.WriteUnicodeString(Text_pagh_1.Text)
            End If
            If valu_pagh_2.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh2 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh2
                Writer.WriteUnicodeString(Text_pagh_2.Text)
            End If
            If valu_pagh_3.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh3 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh3
                Writer.WriteUnicodeString(Text_pagh_3.Text)
            End If
            If valu_pagh_4.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh4 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh4
                Writer.WriteUnicodeString(Text_pagh_4.Text)
            End If
            If valu_pagh_5.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh5 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh5
                Writer.WriteUnicodeString(Text_pagh_5.Text)
            End If
            If valu_pagh_6.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh6 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh6
                Writer.WriteUnicodeString(Text_pagh_6.Text)
            End If
            If valu_pagh_7.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh7 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh7
                Writer.WriteUnicodeString(Text_pagh_7.Text)
            End If
            If valu_pagh_8.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh8 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh8
                Writer.WriteUnicodeString(Text_pagh_8.Text)
            End If
            If valu_pagh_9.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh9 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh9
                Writer.WriteUnicodeString(Text_pagh_9.Text)
            End If
            If valu_pagh_10.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh10 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh10
                Writer.WriteUnicodeString(Text_pagh_10.Text)
            End If
            If valu_pagh_11.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh11 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh11
                Writer.WriteUnicodeString(Text_pagh_11.Text)
            End If
            If valu_pagh_12.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh12 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh12
                Writer.WriteUnicodeString(Text_pagh_12.Text)
            End If
            If valu_pagh_13.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh13 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh13
                Writer.WriteUnicodeString(Text_pagh_13.Text)
            End If
            For i As Integer = 0 To 63
                Writer.Position = Tmusc + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Tmusc
            Writer.WriteUnicodeString(Text_titlesong.Text)
            Writer.Close()
            'end package.IO
            'filestream save songs
            Dim ws As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            ws.Position = ValPagh1
            ws.WriteByte(valu_pagh_1.Value)
            ws.Position = ValPagh2
            ws.WriteByte(valu_pagh_2.Value)
            ws.Position = ValPagh3
            ws.WriteByte(valu_pagh_3.Value)
            ws.Position = ValPagh4
            ws.WriteByte(valu_pagh_4.Value)
            ws.Position = ValPagh5
            ws.WriteByte(valu_pagh_5.Value)
            ws.Position = ValPagh6
            ws.WriteByte(valu_pagh_6.Value)
            ws.Position = ValPagh7
            ws.WriteByte(valu_pagh_7.Value)
            ws.Position = ValPagh8
            ws.WriteByte(valu_pagh_8.Value)
            ws.Position = ValPagh9
            ws.WriteByte(valu_pagh_9.Value)
            ws.Position = ValPagh10
            ws.WriteByte(valu_pagh_10.Value)
            ws.Position = ValPagh11
            ws.WriteByte(valu_pagh_11.Value)
            ws.Position = ValPagh12
            ws.WriteByte(valu_pagh_12.Value)
            ws.Position = ValPagh13
            ws.WriteByte(valu_pagh_13.Value)
            ws.Position = Typesong
            ws.WriteByte(valu_typesong.Value)
            'end filestream save songs
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Editing of this song has been saved"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Les modifications de cette musique ont été enregistrées"
                TLSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to edit this song, please report this issue"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L'édition de cette musique a échoué, veuillez signalez cet erreur"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub valu_typesong_ValueChanged(sender As Object, e As EventArgs) Handles valu_typesong.ValueChanged
        If valu_typesong.Value = 0 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_metal
        ElseIf valu_typesong.Value = 1 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_pop
        ElseIf valu_typesong.Value = 2 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_rockroll
        ElseIf valu_typesong.Value = 3 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_rap
        ElseIf valu_typesong.Value = 4 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_ballad
        ElseIf valu_typesong.Value = 5 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_opera
        ElseIf valu_typesong.Value = 6 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_techno
        ElseIf valu_typesong.Value = 7 Then
            Icon_crthall_music.Image = My.Resources.icon_crthall_musical
        End If
    End Sub

    Private Sub Icon_crthall_music_Click(sender As Object, e As EventArgs) Handles Icon_crthall_music.Click
        If valu_typesong.Value >= 7 Then
            valu_typesong.Value = 0
        Else
            valu_typesong.Value = valu_typesong.Value + 1
        End If
        Locklignpagh()
        If valu_typesong.Value = 0 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
        ElseIf valu_typesong.Value = 1 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
        ElseIf valu_typesong.Value = 2 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
        ElseIf valu_typesong.Value = 3 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
            valu_pagh_12.Value = 14
            valu_pagh_13.Value = 14
        ElseIf valu_typesong.Value = 4 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
            valu_pagh_12.Value = 14
            valu_pagh_13.Value = 14
        ElseIf valu_typesong.Value = 5 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
        ElseIf valu_typesong.Value = 6 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
            valu_pagh_11.Value = 14
        ElseIf valu_typesong.Value = 7 Then
            valu_pagh_1.Value = 14
            valu_pagh_2.Value = 14
            valu_pagh_3.Value = 14
            valu_pagh_4.Value = 14
            valu_pagh_5.Value = 14
            valu_pagh_6.Value = 14
            valu_pagh_7.Value = 14
            valu_pagh_8.Value = 14
            valu_pagh_9.Value = 14
            valu_pagh_10.Value = 14
        End If
    End Sub

    Private Sub Icon_crthall_music_MouseMove(sender As Object, e As EventArgs) Handles Icon_crthall_music.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to change song's type"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour changer le type de la chansons"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_crthall_music_MouseLeave(sender As Object, e As EventArgs) Handles Icon_crthall_music.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Plus_pagh_1_Click(sender As Object, e As EventArgs) Handles Plus_pagh_1.Click
        valu_pagh_1.Value = 14
    End Sub

    Private Sub Minus_pagh_1_Click(sender As Object, e As EventArgs) Handles Minus_pagh_1.Click
        Text_pagh_1.Text = ""
        valu_pagh_1.Value = 0
    End Sub

    Private Sub Plus_pagh_2_Click(sender As Object, e As EventArgs) Handles Plus_pagh_2.Click
        valu_pagh_2.Value = 14
    End Sub

    Private Sub Minus_pagh_2_Click(sender As Object, e As EventArgs) Handles Minus_pagh_2.Click
        Text_pagh_2.Text = ""
        valu_pagh_2.Value = 0
    End Sub

    Private Sub Plus_pagh_3_Click(sender As Object, e As EventArgs) Handles Plus_pagh_3.Click
        valu_pagh_3.Value = 14
    End Sub

    Private Sub Minus_pagh_3_Click(sender As Object, e As EventArgs) Handles Minus_pagh_3.Click
        Text_pagh_3.Text = ""
        valu_pagh_3.Value = 0
    End Sub

    Private Sub Plus_pagh_4_Click(sender As Object, e As EventArgs) Handles Plus_pagh_4.Click
        valu_pagh_4.Value = 14
    End Sub

    Private Sub Minus_pagh_4_Click(sender As Object, e As EventArgs) Handles Minus_pagh_4.Click
        Text_pagh_4.Text = ""
        valu_pagh_4.Value = 0
    End Sub

    Private Sub Plus_pagh_5_Click(sender As Object, e As EventArgs) Handles Plus_pagh_5.Click
        valu_pagh_5.Value = 14
    End Sub

    Private Sub Minus_pagh_5_Click(sender As Object, e As EventArgs) Handles Minus_pagh_5.Click
        Text_pagh_5.Text = ""
        valu_pagh_5.Value = 0
    End Sub

    Private Sub Plus_pagh_6_Click(sender As Object, e As EventArgs) Handles Plus_pagh_6.Click
        valu_pagh_6.Value = 14
    End Sub

    Private Sub Minus_pagh_6_Click(sender As Object, e As EventArgs) Handles Minus_pagh_6.Click
        Text_pagh_6.Text = ""
        valu_pagh_6.Value = 0
    End Sub

    Private Sub Plus_pagh_7_Click(sender As Object, e As EventArgs) Handles Plus_pagh_7.Click
        valu_pagh_7.Value = 14
    End Sub

    Private Sub Minus_pagh_7_Click(sender As Object, e As EventArgs) Handles Minus_pagh_7.Click
        Text_pagh_7.Text = ""
        valu_pagh_7.Value = 0
    End Sub

    Private Sub Plus_pagh_8_Click(sender As Object, e As EventArgs) Handles Plus_pagh_8.Click
        valu_pagh_8.Value = 14
    End Sub

    Private Sub Minus_pagh_8_Click(sender As Object, e As EventArgs) Handles Minus_pagh_8.Click
        Text_pagh_8.Text = ""
        valu_pagh_8.Value = 0
    End Sub

    Private Sub Plus_pagh_9_Click(sender As Object, e As EventArgs) Handles Plus_pagh_9.Click
        valu_pagh_9.Value = 14
    End Sub

    Private Sub Minus_pagh_9_Click(sender As Object, e As EventArgs) Handles Minus_pagh_9.Click
        Text_pagh_9.Text = ""
        valu_pagh_9.Value = 0
    End Sub

    Private Sub Plus_pagh_10_Click(sender As Object, e As EventArgs) Handles Plus_pagh_10.Click
        valu_pagh_10.Value = 14
    End Sub

    Private Sub Minus_pagh_10_Click(sender As Object, e As EventArgs) Handles Minus_pagh_10.Click
        Text_pagh_10.Text = ""
        valu_pagh_10.Value = 0
    End Sub

    Private Sub Plus_pagh_11_Click(sender As Object, e As EventArgs) Handles Plus_pagh_11.Click
        valu_pagh_11.Value = 14
    End Sub

    Private Sub Minus_pagh_11_Click(sender As Object, e As EventArgs) Handles Minus_pagh_11.Click
        Text_pagh_11.Text = ""
        valu_pagh_11.Value = 0
    End Sub

    Private Sub Plus_pagh_12_Click(sender As Object, e As EventArgs) Handles Plus_pagh_12.Click
        valu_pagh_12.Value = 14
    End Sub

    Private Sub Minus_pagh_12_Click(sender As Object, e As EventArgs) Handles Minus_pagh_12.Click
        Text_pagh_12.Text = ""
        valu_pagh_12.Value = 0
    End Sub

    Private Sub Plus_pagh_13_Click(sender As Object, e As EventArgs) Handles Plus_pagh_13.Click
        valu_pagh_13.Value = 14
    End Sub

    Private Sub Minus_pagh_13_Click(sender As Object, e As EventArgs) Handles Minus_pagh_13.Click
        Text_pagh_13.Text = ""
        valu_pagh_13.Value = 0
    End Sub

    Public Sub Locklignpagh()
        valu_pagh_1.Value = 0
        valu_pagh_2.Value = 0
        valu_pagh_3.Value = 0
        valu_pagh_4.Value = 0
        valu_pagh_5.Value = 0
        valu_pagh_6.Value = 0
        valu_pagh_7.Value = 0
        valu_pagh_8.Value = 0
        valu_pagh_9.Value = 0
        valu_pagh_10.Value = 0
        valu_pagh_11.Value = 0
        valu_pagh_12.Value = 0
        valu_pagh_13.Value = 0
    End Sub
End Class