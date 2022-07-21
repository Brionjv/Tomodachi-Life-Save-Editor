Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_savefilesettings
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim sound As String
    Dim music As String
    Dim soundeffects As String
    Dim voice As String
    Dim consoleID = &H18
    Dim lastsavedate = &H10
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

    Private Sub TLSE_islandinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Public Sub Hidesoundbuttons()
        Button_surround.BackgroundImage = My.Resources.bg_button_sound_off
        Button_mono.BackgroundImage = My.Resources.bg_button_sound_off
        Button_stereo.BackgroundImage = My.Resources.bg_button_sound_off
    End Sub

    Private Sub valu_sound_ValueChanged(sender As Object, e As EventArgs) Handles valu_sound.ValueChanged
        If valu_sound.Value = 0 Then
            Hidesoundbuttons()
            Button_mono.BackgroundImage = My.Resources.bg_button_sound_on
        ElseIf valu_sound.Value = 1 Then
            Hidesoundbuttons()
            Button_stereo.BackgroundImage = My.Resources.bg_button_sound_on
        ElseIf valu_sound.Value = 2 Then
            Hidesoundbuttons()
            Button_surround.BackgroundImage = My.Resources.bg_button_sound_on
        End If
    End Sub

    Private Sub Text_mono_Click(sender As Object, e As EventArgs) Handles Text_mono.Click
        valu_sound.Value = 0
    End Sub

    Private Sub Text_stereo_Click(sender As Object, e As EventArgs) Handles Text_stereo.Click
        valu_sound.Value = 1
    End Sub

    Private Sub Text_surround_Click(sender As Object, e As EventArgs) Handles Text_surround.Click
        valu_sound.Value = 2
    End Sub

    Private Sub valu_music_ValueChanged(sender As Object, e As EventArgs) Handles valu_music.ValueChanged
        If valu_music.Value = 0 Then
            icon_minus_music.Image = My.Resources.bg_button_minus_off
            icon_sound_music.Image = My.Resources.icon_sound_0
            icon_plus_music.Image = My.Resources.bg_button_plus_on
        ElseIf valu_music.Value = 1 Then
            icon_minus_music.Image = My.Resources.bg_button_minus_on
            icon_sound_music.Image = My.Resources.icon_sound_1
            icon_plus_music.Image = My.Resources.bg_button_plus_on
        ElseIf valu_music.Value = 2 Then
            icon_minus_music.Image = My.Resources.bg_button_minus_on
            icon_sound_music.Image = My.Resources.icon_sound_2
            icon_plus_music.Image = My.Resources.bg_button_plus_on
        ElseIf valu_music.Value = 3 Then
            icon_minus_music.Image = My.Resources.bg_button_minus_on
            icon_sound_music.Image = My.Resources.icon_sound_3
            icon_plus_music.Image = My.Resources.bg_button_plus_off
        End If
    End Sub

    Private Sub icon_minus_music_Click(sender As Object, e As EventArgs) Handles icon_minus_music.Click
        If valu_music.Value = 3 Then
            valu_music.Value = 2
        ElseIf valu_music.Value = 2 Then
            valu_music.Value = 1
        ElseIf valu_music.Value = 1 Then
            valu_music.Value = 0
        End If
    End Sub

    Private Sub icon_plus_music_Click(sender As Object, e As EventArgs) Handles icon_plus_music.Click
        If valu_music.Value = 0 Then
            valu_music.Value = 1
        ElseIf valu_music.Value = 1 Then
            valu_music.Value = 2
        ElseIf valu_music.Value = 2 Then
            valu_music.Value = 3
        End If
    End Sub

    Private Sub valu_soundeffects_ValueChanged(sender As Object, e As EventArgs) Handles valu_soundeffects.ValueChanged
        If valu_soundeffects.Value = 0 Then
            icon_minus_soundeffects.Image = My.Resources.bg_button_minus_off
            icon_sound_soundeffects.Image = My.Resources.icon_sound_0
            icon_plus_soundeffects.Image = My.Resources.bg_button_plus_on
        ElseIf valu_soundeffects.Value = 1 Then
            icon_minus_soundeffects.Image = My.Resources.bg_button_minus_on
            icon_sound_soundeffects.Image = My.Resources.icon_sound_1
            icon_plus_soundeffects.Image = My.Resources.bg_button_plus_on
        ElseIf valu_soundeffects.Value = 2 Then
            icon_minus_soundeffects.Image = My.Resources.bg_button_minus_on
            icon_sound_soundeffects.Image = My.Resources.icon_sound_2
            icon_plus_soundeffects.Image = My.Resources.bg_button_plus_on
        ElseIf valu_soundeffects.Value = 3 Then
            icon_minus_soundeffects.Image = My.Resources.bg_button_minus_on
            icon_sound_soundeffects.Image = My.Resources.icon_sound_3
            icon_plus_soundeffects.Image = My.Resources.bg_button_plus_off
        End If
    End Sub

    Private Sub icon_minus_soundeffects_Click(sender As Object, e As EventArgs) Handles icon_minus_soundeffects.Click
        If valu_soundeffects.Value = 3 Then
            valu_soundeffects.Value = 2
        ElseIf valu_soundeffects.Value = 2 Then
            valu_soundeffects.Value = 1
        ElseIf valu_soundeffects.Value = 1 Then
            valu_soundeffects.Value = 0
        End If
    End Sub

    Private Sub icon_plus_soundeffects_Click(sender As Object, e As EventArgs) Handles icon_plus_soundeffects.Click
        If valu_soundeffects.Value = 0 Then
            valu_soundeffects.Value = 1
        ElseIf valu_soundeffects.Value = 1 Then
            valu_soundeffects.Value = 2
        ElseIf valu_soundeffects.Value = 2 Then
            valu_soundeffects.Value = 3
        End If
    End Sub

    Private Sub valu_voice_ValueChanged(sender As Object, e As EventArgs) Handles valu_voice.ValueChanged
        If valu_voice.Value = 0 Then
            icon_minus_voice.Image = My.Resources.bg_button_minus_off
            icon_sound_voice.Image = My.Resources.icon_sound_0
            icon_plus_voice.Image = My.Resources.bg_button_plus_on
        ElseIf valu_voice.Value = 1 Then
            icon_minus_voice.Image = My.Resources.bg_button_minus_on
            icon_sound_voice.Image = My.Resources.icon_sound_1
            icon_plus_voice.Image = My.Resources.bg_button_plus_on
        ElseIf valu_voice.Value = 2 Then
            icon_minus_voice.Image = My.Resources.bg_button_minus_on
            icon_sound_voice.Image = My.Resources.icon_sound_2
            icon_plus_voice.Image = My.Resources.bg_button_plus_on
        ElseIf valu_voice.Value = 3 Then
            icon_minus_voice.Image = My.Resources.bg_button_minus_on
            icon_sound_voice.Image = My.Resources.icon_sound_3
            icon_plus_voice.Image = My.Resources.bg_button_plus_off
        End If
    End Sub

    Private Sub icon_minus_voice_Click(sender As Object, e As EventArgs) Handles icon_minus_voice.Click
        If valu_voice.Value = 3 Then
            valu_voice.Value = 2
        ElseIf valu_voice.Value = 2 Then
            valu_voice.Value = 1
        ElseIf valu_voice.Value = 1 Then
            valu_voice.Value = 0
        End If
    End Sub

    Private Sub icon_plus_voice_Click(sender As Object, e As EventArgs) Handles icon_plus_voice.Click
        If valu_voice.Value = 0 Then
            valu_voice.Value = 1
        ElseIf valu_voice.Value = 1 Then
            valu_voice.Value = 2
        ElseIf valu_voice.Value = 2 Then
            valu_voice.Value = 3
        End If
    End Sub

    Private Sub Warning_consoleid_Click(sender As Object, e As EventArgs) Handles Warning_consoleid.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "If console ID is not your, you will have ''time travel'' message at Tomodachi Life launch" & vbNewLine & vbNewLine & "Warning : Edit in hexadecimal and enter max characters"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Si l'ID console n'est pas le votre, vous aurez le message du ''voyage dans le temps'' lors du lancement de Tomodachi Life" & vbNewLine & vbNewLine & "Attention : Editez en hexadécimal et entrez un maximum de caractères"
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Private Sub Warning_lastsavedate_Click(sender As Object, e As EventArgs) Handles Warning_lastsavedate.Click
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Editing last save date cause ''time travel penality'' and troubles with Mii interactions"
            TLSE_dialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "L'édition de la dernière date de la sauvegarde provoque la ''pénalité de voyage dans le temps'' et des erreurs avec l'interactions des Mii"
            TLSE_dialog.ShowDialog()
        End If
    End Sub

    Public Sub Savefileregion()
        If Filever_text.Text = "US" Or Filever_text.Text = "EU" Then
            sound = &H1E4C7E
            music = &H1E4C7B
            soundeffects = &H1E4C7C
            voice = &H1E4C7D
        ElseIf Filever_text.Text = "JP" Then
            sound = &H14BD4E
            music = &H14BD4B
            soundeffects = &H14BD4C
            voice = &H14BD4D
        ElseIf Filever_text.Text = "KR" Then
            sound = &H1F002E
            music = &H1F002B
            soundeffects = &H1F002C
            voice = &H1F002D
        End If
    End Sub

    Private Sub TLSE_savefilesettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Readsavefilesettings()
    End Sub

    Public Sub Readsavefilesettings()
        Try
            Dim Readdata As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Readdata.Position = lastsavedate
            valu_lastsavedate.Value = Readdata.ReadUInt32
            Readdata.Position = consoleID
            Text_consoleid.Text = Readdata.ReadHexString(8)
            Readdata.Position = sound
            valu_sound.Value = Readdata.ReadByte
            Readdata.Position = music
            valu_music.Value = Readdata.ReadByte
            Readdata.Position = soundeffects
            valu_soundeffects.Value = Readdata.ReadByte
            Readdata.Position = voice
            valu_voice.Value = Readdata.ReadByte
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read save file settings"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture des paramètres du fichier de sauvegarde a échoué"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Writesavefilesettings()
    End Sub

    Public Sub Writesavefilesettings()
        Try
            Dim Writedata As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writedata.Position = lastsavedate
            Writedata.WriteUInt32(valu_lastsavedate.Value)
            Writedata.Position = consoleID
            Writedata.WriteHexString(Text_consoleid.Text)
            Writedata.Position = sound
            Writedata.WriteInt8(valu_sound.Value)
            Writedata.Position = music
            Writedata.WriteInt8(valu_music.Value)
            Writedata.Position = soundeffects
            Writedata.WriteInt8(valu_soundeffects.Value)
            Writedata.Position = voice
            Writedata.WriteInt8(valu_voice.Value)
            TLSE_dialog.Text_TLSE_dialog.Text = "Save file settings has been successfully edited"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to write save file settings"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_islandedit.Visible = True
        Me.Close()
    End Sub
End Class