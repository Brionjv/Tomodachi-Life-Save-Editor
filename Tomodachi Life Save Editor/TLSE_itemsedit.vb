Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_itemsedit
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

    Private Sub TLSE_itemsedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_Itemsedition.Visible = True
        Me.Close()
    End Sub

    Private Sub valu_itemsediticon_foods_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_foods.ValueChanged
        If valu_itemsediticon_foods.Value = 0 Then
            Icon_itemsedit_foods.Image = My.Resources.Icon_unfoods
            Check_delete_foods.Enabled = True
        ElseIf valu_itemsediticon_foods.Value = 1 Then
            Icon_itemsedit_foods.Image = My.Resources.Icon_unfoods_act
            Check_delete_foods.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_clothes_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_clothes.ValueChanged
        If valu_itemsediticon_clothes.Value = 0 Then
            Icon_itemsedit_clothes.Image = My.Resources.Icon_unclothes
            Check_delete_clothes.Enabled = True
        ElseIf valu_itemsediticon_clothes.Value = 1 Then
            Icon_itemsedit_clothes.Image = My.Resources.Icon_unclothes_act
            Check_delete_clothes.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_ssclothes_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_ssclothes.ValueChanged
        If valu_itemsediticon_ssclothes.Value = 0 Then
            Icon_itemsedit_ssclothes.Image = My.Resources.Icon_unclothesstsp
            Check_delete_ssclothes.Enabled = True
            Check_available_ssclothes.Enabled = True
        ElseIf valu_itemsediticon_ssclothes.Value = 1 Then
            Icon_itemsedit_ssclothes.Image = My.Resources.Icon_unclothesstsp_act
            Check_delete_ssclothes.Enabled = False
            Check_available_ssclothes.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_hats_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_hats.ValueChanged
        If valu_itemsediticon_hats.Value = 0 Then
            Icon_itemsedit_hats.Image = My.Resources.Icon_unhats
            Check_delete_hats.Enabled = True
        ElseIf valu_itemsediticon_hats.Value = 1 Then
            Icon_itemsedit_hats.Image = My.Resources.Icon_unhats_act
            Check_delete_hats.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_sshats_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_sshats.ValueChanged
        If valu_itemsediticon_sshats.Value = 0 Then
            Icon_itemsedit_sshats.Image = My.Resources.Icon_unhatsstsp
            Check_delete_sshats.Enabled = True
            Check_available_sshats.Enabled = True
        ElseIf valu_itemsediticon_sshats.Value = 1 Then
            Icon_itemsedit_sshats.Image = My.Resources.Icon_unhatsstsp_act
            Check_delete_sshats.Enabled = False
            Check_available_sshats.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_interiors_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_interiors.ValueChanged
        If valu_itemsediticon_interiors.Value = 0 Then
            Icon_itemsedit_interiors.Image = My.Resources.Icon_uninteriors
            Check_delete_interiors.Enabled = True
        ElseIf valu_itemsediticon_interiors.Value = 1 Then
            Icon_itemsedit_interiors.Image = My.Resources.Icon_uninteriors_act
            Check_delete_interiors.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_goodsitems_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_goodsitems.ValueChanged
        If valu_itemsediticon_goodsitems.Value = 0 Then
            Icon_itemsedit_goodsitems.Image = My.Resources.Icon_ungoods
            Check_delete_goodsitems.Enabled = True
        ElseIf valu_itemsediticon_goodsitems.Value = 1 Then
            Icon_itemsedit_goodsitems.Image = My.Resources.Icon_ungoods_act
            Check_delete_goodsitems.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_treasures_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_treasures.ValueChanged
        If valu_itemsediticon_treasures.Value = 0 Then
            Icon_itemsedit_treasures.Image = My.Resources.Icon_untreasures
            Check_delete_treasures.Enabled = True
        ElseIf valu_itemsediticon_treasures.Value = 1 Then
            Icon_itemsedit_treasures.Image = My.Resources.Icon_untreasures_act
            Check_delete_treasures.Enabled = False
        End If
    End Sub

    Private Sub valu_itemsediticon_spefoods_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemsediticon_spefoods.ValueChanged
        If valu_itemsediticon_spefoods.Value = 0 Then
            Icon_itemsedit_spefoods.Image = My.Resources.Icon_unfoodsspe
            Check_delete_spefoods.Enabled = True
        ElseIf valu_itemsediticon_spefoods.Value = 1 Then
            Icon_itemsedit_spefoods.Image = My.Resources.Icon_unfoodsspe_act
            Check_delete_spefoods.Enabled = False
        End If
    End Sub

    Private Sub Icon_itemsedit_foods_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_foods.Click
        If valu_itemsediticon_foods.Value = 0 Then
            valu_itemsediticon_foods.Value = 1
        ElseIf valu_itemsediticon_foods.Value = 1 Then
            valu_itemsediticon_foods.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_clothes_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_clothes.Click
        If valu_itemsediticon_clothes.Value = 0 Then
            valu_itemsediticon_clothes.Value = 1
        ElseIf valu_itemsediticon_clothes.Value = 1 Then
            valu_itemsediticon_clothes.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_ssclothes_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_ssclothes.Click
        If valu_itemsediticon_ssclothes.Value = 0 Then
            valu_itemsediticon_ssclothes.Value = 1
        ElseIf valu_itemsediticon_ssclothes.Value = 1 Then
            valu_itemsediticon_ssclothes.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_hats_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_hats.Click
        If valu_itemsediticon_hats.Value = 0 Then
            valu_itemsediticon_hats.Value = 1
        ElseIf valu_itemsediticon_hats.Value = 1 Then
            valu_itemsediticon_hats.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_sshats_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_sshats.Click
        If valu_itemsediticon_sshats.Value = 0 Then
            valu_itemsediticon_sshats.Value = 1
        ElseIf valu_itemsediticon_sshats.Value = 1 Then
            valu_itemsediticon_sshats.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_interiors_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_interiors.Click
        If valu_itemsediticon_interiors.Value = 0 Then
            valu_itemsediticon_interiors.Value = 1
        ElseIf valu_itemsediticon_interiors.Value = 1 Then
            valu_itemsediticon_interiors.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_goodsitems_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_goodsitems.Click
        If valu_itemsediticon_goodsitems.Value = 0 Then
            valu_itemsediticon_goodsitems.Value = 1
        ElseIf valu_itemsediticon_goodsitems.Value = 1 Then
            valu_itemsediticon_goodsitems.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_treasures_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_treasures.Click
        If valu_itemsediticon_treasures.Value = 0 Then
            valu_itemsediticon_treasures.Value = 1
        ElseIf valu_itemsediticon_treasures.Value = 1 Then
            valu_itemsediticon_treasures.Value = 0
        End If
    End Sub

    Private Sub Icon_itemsedit_spefoods_Click(sender As Object, e As EventArgs) Handles Icon_itemsedit_spefoods.Click
        If valu_itemsediticon_spefoods.Value = 0 Then
            valu_itemsediticon_spefoods.Value = 1
        ElseIf valu_itemsediticon_spefoods.Value = 1 Then
            valu_itemsediticon_spefoods.Value = 0
        End If
    End Sub

    Private Sub Check_delete_foods_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_foods.CheckedChanged
        If Check_delete_foods.Checked = True Then
            Icon_itemsedit_foods.Enabled = False
            valu_itemsedit_foods.Enabled = False
            valu_itemsedit_foods.Maximum = 255
            valu_itemsedit_foods.Value = 253
        Else
            Icon_itemsedit_foods.Enabled = True
            valu_itemsedit_foods.Enabled = True
            valu_itemsedit_foods.Maximum = 99
            valu_itemsedit_foods.Value = 99
        End If
    End Sub

    Private Sub Check_delete_clothes_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_clothes.CheckedChanged
        If Check_delete_clothes.Checked = True Then
            Icon_itemsedit_clothes.Enabled = False
            valu_itemsedit_clothes.Enabled = False
            valu_itemsedit_clothes.Maximum = 255
            valu_itemsedit_clothes.Value = 253
        Else
            Icon_itemsedit_clothes.Enabled = True
            valu_itemsedit_clothes.Enabled = True
            valu_itemsedit_clothes.Maximum = 99
            valu_itemsedit_clothes.Value = 99
        End If
    End Sub

    Private Sub Check_delete_ssclothes_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_ssclothes.CheckedChanged
        If Check_delete_ssclothes.Checked = True Then
            Icon_itemsedit_ssclothes.Enabled = False
            valu_itemsedit_ssclothes.Enabled = False
            valu_itemsedit_ssclothes.Maximum = 255
            valu_itemsedit_ssclothes.Value = 253
            Check_available_ssclothes.Enabled = False
        Else
            Icon_itemsedit_ssclothes.Enabled = True
            valu_itemsedit_ssclothes.Enabled = True
            valu_itemsedit_ssclothes.Maximum = 99
            valu_itemsedit_ssclothes.Value = 99
            Check_available_ssclothes.Enabled = True
        End If
    End Sub

    Private Sub Check_available_ssclothes_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_ssclothes.CheckedChanged
        If Check_available_ssclothes.Checked = True Then
            Icon_itemsedit_ssclothes.Enabled = False
            valu_itemsedit_ssclothes.Enabled = False
            valu_itemsedit_ssclothes.Maximum = 255
            valu_itemsedit_ssclothes.Value = 254
            Check_delete_ssclothes.Enabled = False
        Else
            Icon_itemsedit_ssclothes.Enabled = True
            valu_itemsedit_ssclothes.Enabled = True
            valu_itemsedit_ssclothes.Maximum = 99
            valu_itemsedit_ssclothes.Value = 99
            Check_delete_ssclothes.Enabled = True
        End If
    End Sub

    Private Sub Check_delete_hats_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_hats.CheckedChanged
        If Check_delete_hats.Checked = True Then
            Icon_itemsedit_hats.Enabled = False
            valu_itemsedit_hats.Enabled = False
            valu_itemsedit_hats.Maximum = 255
            valu_itemsedit_hats.Value = 253
        Else
            Icon_itemsedit_hats.Enabled = True
            valu_itemsedit_hats.Enabled = True
            valu_itemsedit_hats.Maximum = 99
            valu_itemsedit_hats.Value = 99
        End If
    End Sub

    Private Sub Check_delete_sshats_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_sshats.CheckedChanged
        If Check_delete_sshats.Checked = True Then
            Icon_itemsedit_sshats.Enabled = False
            valu_itemsedit_sshats.Enabled = False
            valu_itemsedit_sshats.Maximum = 255
            valu_itemsedit_sshats.Value = 253
            Check_available_sshats.Enabled = False
        Else
            Icon_itemsedit_sshats.Enabled = True
            valu_itemsedit_sshats.Enabled = True
            valu_itemsedit_sshats.Maximum = 99
            valu_itemsedit_sshats.Value = 99
            Check_available_sshats.Enabled = True
        End If
    End Sub

    Private Sub Check_available_sshats_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_sshats.CheckedChanged
        If Check_available_sshats.Checked = True Then
            Icon_itemsedit_sshats.Enabled = False
            valu_itemsedit_sshats.Enabled = False
            valu_itemsedit_sshats.Maximum = 255
            valu_itemsedit_sshats.Value = 254
            Check_delete_sshats.Enabled = False
        Else
            Icon_itemsedit_sshats.Enabled = True
            valu_itemsedit_sshats.Enabled = True
            valu_itemsedit_sshats.Maximum = 99
            valu_itemsedit_sshats.Value = 99
            Check_delete_sshats.Enabled = True
        End If
    End Sub

    Private Sub Check_delete_interiors_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_interiors.CheckedChanged
        If Check_delete_interiors.Checked = True Then
            Icon_itemsedit_interiors.Enabled = False
            valu_itemsedit_interiors.Enabled = False
            valu_itemsedit_interiors.Maximum = 255
            valu_itemsedit_interiors.Value = 253
        Else
            Icon_itemsedit_interiors.Enabled = True
            valu_itemsedit_interiors.Enabled = True
            valu_itemsedit_interiors.Maximum = 99
            valu_itemsedit_interiors.Value = 99
        End If
    End Sub

    Private Sub Check_delete_goodsitems_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_goodsitems.CheckedChanged
        If Check_delete_goodsitems.Checked = True Then
            Icon_itemsedit_goodsitems.Enabled = False
            valu_itemsedit_goodsitems.Enabled = False
            valu_itemsedit_goodsitems.Maximum = 255
            valu_itemsedit_goodsitems.Value = 253
        Else
            Icon_itemsedit_goodsitems.Enabled = True
            valu_itemsedit_goodsitems.Enabled = True
            valu_itemsedit_goodsitems.Maximum = 99
            valu_itemsedit_goodsitems.Value = 99
        End If
    End Sub

    Private Sub Check_delete_treasures_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_treasures.CheckedChanged
        If Check_delete_treasures.Checked = True Then
            Icon_itemsedit_treasures.Enabled = False
            valu_itemsedit_treasures.Enabled = False
            valu_itemsedit_treasures.Maximum = 255
            valu_itemsedit_treasures.Value = 253
        Else
            Icon_itemsedit_treasures.Enabled = True
            valu_itemsedit_treasures.Enabled = True
            valu_itemsedit_treasures.Maximum = 99
            valu_itemsedit_treasures.Value = 99
        End If
    End Sub

    Private Sub Check_delete_spefoods_CheckedChanged(sender As Object, e As EventArgs) Handles Check_delete_spefoods.CheckedChanged
        If Check_delete_spefoods.Checked = True Then
            Icon_itemsedit_spefoods.Enabled = False
            valu_itemsedit_spefoods.Enabled = False
            valu_itemsedit_spefoods.Maximum = 255
            valu_itemsedit_spefoods.Value = 253
        Else
            Icon_itemsedit_spefoods.Enabled = True
            valu_itemsedit_spefoods.Enabled = True
            valu_itemsedit_spefoods.Maximum = 99
            valu_itemsedit_spefoods.Value = 99
        End If
    End Sub

    Public Sub Writefoodsitems()
        If valu_itemsediticon_foods.Value = 1 Or Check_delete_foods.Checked = True Then
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            If Filever_text.Text = "US" Then
                For i As Integer = 0 To 230
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
            If Filever_text.Text = "EU" Then
                For i As Integer = 0 To 230
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
            If Filever_text.Text = "JP" Then
                For i As Integer = 0 To 229
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
            If Filever_text.Text = "KR" Then
                For i As Integer = 0 To 254
                    fs.Position = &H17F0 + i
                    fs.WriteByte(valu_itemsedit_foods.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writeclothesitems()
        If valu_itemsediticon_clothes.Value = 1 Or Check_delete_clothes.Checked = True Then
            If Filever_text.Text = "US" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 3575
                    fs.Position = &H30 + i
                    fs.WriteByte(valu_itemsedit_clothes.Value)
                Next
            End If
            If Filever_text.Text = "EU" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 3575
                    fs.Position = &H30 + i
                    fs.WriteByte(valu_itemsedit_clothes.Value)
                Next
            End If
            If Filever_text.Text = "JP" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 3575
                    fs.Position = &H30 + i
                    fs.WriteByte(valu_itemsedit_clothes.Value)
                Next
            End If
            If Filever_text.Text = "KR" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 3648
                    fs.Position = &H30 + i
                    fs.WriteByte(valu_itemsedit_clothes.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writessclothesitems()
        If valu_itemsediticon_ssclothes.Value = 1 Or Check_delete_ssclothes.Checked = True Or Check_available_ssclothes.Checked = True Then
            If Filever_text.Text = "EU" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 7
                    fs.Position = &H60 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HC8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H100 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H138 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H160 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H180 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H190 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1D8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H250 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H280 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H2B8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2F0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H328 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H60 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H460 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H478 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H490 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H500 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H518 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H5A0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H5B8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H650 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H660 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H6E0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H720 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H7A0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H7B8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H848 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H868 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8E0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8F0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H918 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H968 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H988 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9B0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9C0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA08 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA38 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &HA70 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &HAF8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &HB08 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HB68 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &HCA0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HD28 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HE18 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
            End If
            If Filever_text.Text = "US" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 7
                    fs.Position = &H40 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H80 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                fs.Position = &HC8
                fs.WriteByte(valu_itemsedit_ssclothes.Value)
                fs.Position = &HC9
                fs.WriteByte(valu_itemsedit_ssclothes.Value)
                For i As Integer = 0 To 7
                    fs.Position = &HD0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H108 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H168 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H188 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H198 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1E0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H258 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H288 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2C8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2D8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H308 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H480 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H498 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H4C0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H4F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H508 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H520 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H538 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H568 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H5A0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H5B8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H660 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H670 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H6F0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H730 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H7B0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H7B8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H7D0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H860 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H880 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8F0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H900 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H928 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H978 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H998 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9C0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9D0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA00 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA10 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA40 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &HA78 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &HB00 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &HB10 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HB70 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &HD88 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &HDA8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HDD8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
            End If
            If Filever_text.Text = "JP" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 15
                    fs.Position = &H80 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HE0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H120 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H180 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1B0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H270 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H2A0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2E8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H328 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H4C0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H4D8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H550 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H568 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H5B0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H5D0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H608 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H620 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H680 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H688 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H690 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H698 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H6D0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H6E0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H760 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H7A0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H828 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H830 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H848 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8D8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H970 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H980 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H990 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9B8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA08 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA28 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA58 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA68 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HAA0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HAB0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HAE0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &HB18 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &HBA0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &HBB0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HC10 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HC78 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
            End If
            If Filever_text.Text = "KR" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 7
                    fs.Position = &HC8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H100 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H160 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H180 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H190 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1D8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H250 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H280 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2B8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2C8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H2F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H330 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H460 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H478 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H4E0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H4F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H518 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H530 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H568 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H580 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H5C8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H5D0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H5D8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H5E0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H618 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H628 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H6A8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H6E8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H770 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H778 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H790 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H820 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H840 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8C0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8D0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H8F8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H948 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H968 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H998 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9A8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9D8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H9E8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HA18 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &HA50 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HAC0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &HAD8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &HAE8 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HB48 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HB78 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HBB0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HDF0 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &HE50 + i
                    fs.WriteByte(valu_itemsedit_ssclothes.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writehatsitems()
        If valu_itemsediticon_hats.Value = 1 Or Check_delete_hats.Checked = True Then
            If Filever_text.Text = "EU" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 38
                    fs.Position = &HFF8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1020 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 13
                    fs.Position = &H1030 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1040 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1058 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1060 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1088 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 15
                    fs.Position = &H10C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H10F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1100 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1120 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 29
                    fs.Position = &H1130 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1150 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1158 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 3
                    fs.Position = &H1160 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1168 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 13
                    fs.Position = &H1170 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 31
                    fs.Position = &H1180 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 29
                    fs.Position = &H1130 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 38
                    fs.Position = &H11A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 22
                    fs.Position = &H11D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H11E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 12
                    fs.Position = &H11F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 14
                    fs.Position = &H1200 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1210 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 31
                    fs.Position = &H1218 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 29
                    fs.Position = &H1240 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                fs.Position = &H1260
                fs.WriteByte(valu_itemsedit_hats.Value)

                For i As Integer = 0 To 46
                    fs.Position = &H1268 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1298 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 14
                    fs.Position = &H12A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 70
                    fs.Position = &H12B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H12F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 29
                    fs.Position = &H1300 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1320 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 46
                    fs.Position = &H1328 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1358 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 12
                    fs.Position = &H1360 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 13
                    fs.Position = &H1370 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1390 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 30
                    fs.Position = &H1398 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 13
                    fs.Position = &H13B8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 30
                    fs.Position = &H13C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H13E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H13F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 14
                    fs.Position = &H13F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1410 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1418 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1420 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 12
                    fs.Position = &H1430 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 3
                    fs.Position = &H1440 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 11
                    fs.Position = &H1448 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1458 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1460 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1468 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 47
                    fs.Position = &H1490 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H14D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 11
                    fs.Position = &H14E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H14F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H14F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1508 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1510 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1518 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 8
                    fs.Position = &H1530 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 21
                    fs.Position = &H1550 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1568 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1570 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1578 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1580 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1588 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1598 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H15B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H15C0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H15C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 15
                    fs.Position = &H15D8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H15F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1618 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1618 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1650 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1668 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1670 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1678 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1680 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1688 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1698 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H16A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H16A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H16B8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H16C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
            End If
            If Filever_text.Text = "US" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 47
                    fs.Position = &HFF8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 13
                    fs.Position = &H1030 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1040 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1058 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1060 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1080 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 15
                    fs.Position = &H10C0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H10F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1108 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1128 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 29
                    fs.Position = &H1138 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1158 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1160 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 3
                    fs.Position = &H1168 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1170 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 39
                    fs.Position = &H1178 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 38
                    fs.Position = &H11A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 22
                    fs.Position = &H11D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H11E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 12
                    fs.Position = &H11F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 14
                    fs.Position = &H1200 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1210 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 31
                    fs.Position = &H1218 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 29
                    fs.Position = &H1240 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                fs.Position = &H1260
                fs.WriteByte(valu_itemsedit_hats.Value)

                For i As Integer = 0 To 46
                    fs.Position = &H1268 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1298 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 14
                    fs.Position = &H12A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 70
                    fs.Position = &H12B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H12F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 29
                    fs.Position = &H1300 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1320 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 46
                    fs.Position = &H1328 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1358 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 12
                    fs.Position = &H1360 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 13
                    fs.Position = &H1370 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1390 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 30
                    fs.Position = &H1398 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 13
                    fs.Position = &H13B8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 30
                    fs.Position = &H13C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H13E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H13F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 14
                    fs.Position = &H13F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1410 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1418 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1420 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 12
                    fs.Position = &H1430 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 3
                    fs.Position = &H1440 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 11
                    fs.Position = &H1448 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1458 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1460 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H1468 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 47
                    fs.Position = &H1490 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H14D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 11
                    fs.Position = &H14E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H14F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H14F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1508 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1510 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1518 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 8
                    fs.Position = &H1530 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 21
                    fs.Position = &H1550 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1568 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 14
                    fs.Position = &H1570 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1580 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1588 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H1598 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H15B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H15C0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H15C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H15D8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H15E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H15F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1618 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1650 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H1668 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1670 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1678 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1680 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1688 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1698 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H16A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 4
                    fs.Position = &H16A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 6
                    fs.Position = &H16B8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 7
                    fs.Position = &H16C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
            End If
            If Filever_text.Text = "JP" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 47
                    fs.Position = &HFF8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 13
                    fs.Position = &H1030 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1040 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1058 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1060 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1088 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H10C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1100 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1110 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 45
                    fs.Position = &H1130 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1160 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1168 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H1170 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1178 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 21
                    fs.Position = &H1180 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &H1198 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 38
                    fs.Position = &H11C0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 22
                    fs.Position = &H11E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1200 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 12
                    fs.Position = &H1208 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 14
                    fs.Position = &H1218 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1228 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &H1230 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 29
                    fs.Position = &H1258 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                fs.Position = &H1278
                fs.WriteByte(valu_itemsedit_hats.Value)
                For i As Integer = 0 To 46
                    fs.Position = &H1280 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H12B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 14
                    fs.Position = &H12B8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 70
                    fs.Position = &H12C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 37
                    fs.Position = &H1310 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1338 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 46
                    fs.Position = &H1340 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1370 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 12
                    fs.Position = &H1378 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 13
                    fs.Position = &H1388 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H13A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 30
                    fs.Position = &H13B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 13
                    fs.Position = &H13D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 30
                    fs.Position = &H13E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1400 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1408 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 14
                    fs.Position = &H1410 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 12
                    fs.Position = &H1420 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1430 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1438 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 12
                    fs.Position = &H1448 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H1458 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 11
                    fs.Position = &H1460 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1470 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1478 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1480 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 47
                    fs.Position = &H14A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H14E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 11
                    fs.Position = &H14F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1508 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1510 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1520 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1528 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1530 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 8
                    fs.Position = &H1548 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 21
                    fs.Position = &H1570 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1588 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1590 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1598 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H15A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H15A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H15B8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H15D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H15E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H15E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H15F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1618 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1628 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1630 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1658 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next

                For i As Integer = 0 To 5
                    fs.Position = &H1698 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
            End If
            If Filever_text.Text = "KR" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 47
                    fs.Position = &HFF8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 13
                    fs.Position = &H1030 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1040 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1058 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1070 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H10A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H10D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H10E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1100 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 21
                    fs.Position = &H1110 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1128 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1130 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H1138 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1140 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 21
                    fs.Position = &H1148 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 46
                    fs.Position = &H1160 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 22
                    fs.Position = &H1190 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H11A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 12
                    fs.Position = &H11B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 14
                    fs.Position = &H11C0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H11D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &H11D8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 21
                    fs.Position = &H1200 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                fs.Position = &H1218
                fs.WriteByte(valu_itemsedit_hats.Value)
                For i As Integer = 0 To 46
                    fs.Position = &H1220 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1250 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 14
                    fs.Position = &H1258 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 70
                    fs.Position = &H1268 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 37
                    fs.Position = &H12B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H12D8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 46
                    fs.Position = &H12E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1310 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 12
                    fs.Position = &H1318 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 13
                    fs.Position = &H1328 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1348 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 30
                    fs.Position = &H1350 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 13
                    fs.Position = &H1370 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 30
                    fs.Position = &H1380 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H13A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H13A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 14
                    fs.Position = &H13B0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H13C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H13D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 12
                    fs.Position = &H13E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H13F0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 11
                    fs.Position = &H13F8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1408 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1410 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1418 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 47
                    fs.Position = &H1440 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1480 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 11
                    fs.Position = &H1490 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H14A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H14A8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H14B8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H14C0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H14C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 8
                    fs.Position = &H14E0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 21
                    fs.Position = &H1508 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1520 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1528 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1530 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1538 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1548 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1560 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1570 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H1580 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H15A0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H15C8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1600 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1618 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1620 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1628 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1630 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1640 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 13
                    fs.Position = &H16D0 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &H16E8 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1710 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &H1718 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
                For i As Integer = 0 To 31
                    fs.Position = &H1740 + i
                    fs.WriteByte(valu_itemsedit_hats.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writesshatsitems()
        If valu_itemsediticon_sshats.Value = 1 Or Check_delete_sshats.Checked = True Or Check_available_sshats.Checked = True Then
            If Filever_text.Text = "EU" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 7
                    fs.Position = &HFF8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1020 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1088 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1178 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H11B0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H11F0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H1228 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1270 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H12C8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H12D8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H12F0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H12F8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1300 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1358 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1378 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H1440 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1458 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1578 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
            End If
            If Filever_text.Text = "US" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 7
                    fs.Position = &H1020 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1080 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1180 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H11F0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1228 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H12C8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H12D8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H12F0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H12F8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1358 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1378 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H13C0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H1440 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1468 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1578 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1588 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1668 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
            End If
            If Filever_text.Text = "JP" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 7
                    fs.Position = &H1020 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1088 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1168 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1190 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1208 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1240 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H12E0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H12F0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1308 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1310 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1330 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1390 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H1458 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1580 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1598 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H15A0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 15
                    fs.Position = &H15F8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
            End If
            If Filever_text.Text = "KR" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 7
                    fs.Position = &H1020 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1070 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1158 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H11B0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H11E8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1280 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H1290 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H12A8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 7
                    fs.Position = &H12B0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H12D0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H12D8 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1330 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 5
                    fs.Position = &H1378 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 3
                    fs.Position = &H13F0 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 6
                    fs.Position = &H1528 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
                For i As Integer = 0 To 4
                    fs.Position = &H1530 + i
                    fs.WriteByte(valu_itemsedit_sshats.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writeinteriorsitems()
        If valu_itemsediticon_interiors.Value = 1 Or Check_delete_interiors.Checked = True Then
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            If Filever_text.Text = "EU" Then
                For i As Integer = 0 To 102
                    fs.Position = &H1778 + i
                    fs.WriteByte(valu_itemsedit_interiors.Value)
                Next
            ElseIf Filever_text.Text = "US" Then
                For i As Integer = 0 To 101
                    fs.Position = &H1778 + i
                    fs.WriteByte(valu_itemsedit_interiors.Value)
                Next
            ElseIf Filever_text.Text = "JP" Then
                For i As Integer = 0 To 99
                    fs.Position = &H1778 + i
                    fs.WriteByte(valu_itemsedit_interiors.Value)
                Next
            ElseIf Filever_text.Text = "KR" Then
                For i As Integer = 0 To 103
                    fs.Position = &H1778 + i
                    fs.WriteByte(valu_itemsedit_interiors.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writegoodsitems()
        If valu_itemsediticon_goodsitems.Value = 1 Or Check_delete_goodsitems.Checked = True Then
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            If Filever_text.Text = "EU" Then
                For i As Integer = 0 To 17
                    fs.Position = &H18F0 + i
                    fs.WriteByte(valu_itemsedit_goodsitems.Value)
                Next
            ElseIf Filever_text.Text = "US" Then
                For i As Integer = 0 To 17
                    fs.Position = &H18F0 + i
                    fs.WriteByte(valu_itemsedit_goodsitems.Value)
                Next
            ElseIf Filever_text.Text = "JP" Then
                For i As Integer = 0 To 16
                    fs.Position = &H18F0 + i
                    fs.WriteByte(valu_itemsedit_goodsitems.Value)
                Next
            ElseIf Filever_text.Text = "KR" Then
                For i As Integer = 0 To 16
                    fs.Position = &H18F0 + i
                    fs.WriteByte(valu_itemsedit_goodsitems.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writetreasuresitems()
        If valu_itemsediticon_treasures.Value = 1 Or Check_delete_treasures.Checked = True Then
            If Filever_text.Text = "US" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 165
                    fs.Position = &H1902 + i
                    fs.WriteByte(valu_itemsedit_treasures.Value)
                Next
            End If
            If Filever_text.Text = "EU" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 165
                    fs.Position = &H1902 + i
                    fs.WriteByte(valu_itemsedit_treasures.Value)
                Next
            End If
            If Filever_text.Text = "JP" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 165
                    fs.Position = &H1902 + i
                    fs.WriteByte(valu_itemsedit_treasures.Value)
                Next
            End If
            If Filever_text.Text = "KR" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 165
                    fs.Position = &H1902 + i
                    fs.WriteByte(valu_itemsedit_treasures.Value)
                Next
            End If
        End If
    End Sub

    Public Sub Writespefoodsitems()
        If valu_itemsediticon_spefoods.Value = 1 Or Check_delete_spefoods.Checked = True Then
            If Filever_text.Text = "US" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 46
                    fs.Position = &H19E4 + i
                    fs.WriteByte(valu_itemsedit_spefoods.Value)
                Next
                fs.Position = &H19E2
                fs.WriteByte(valu_itemsedit_spefoods.Value)
            End If
            If Filever_text.Text = "EU" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 46
                    fs.Position = &H1A16 + i
                    fs.WriteByte(valu_itemsedit_spefoods.Value)
                Next
                fs.Position = &H1A14
                fs.WriteByte(valu_itemsedit_spefoods.Value)
            End If
            If Filever_text.Text = "JP" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 46
                    fs.Position = &H19B2 + i
                    fs.WriteByte(valu_itemsedit_spefoods.Value)
                Next
                fs.Position = &H19B0
                fs.WriteByte(valu_itemsedit_spefoods.Value)
            End If
            If Filever_text.Text = "KR" Then
                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                For i As Integer = 0 To 46
                    fs.Position = &H1A48 + i
                    fs.WriteByte(valu_itemsedit_spefoods.Value)
                Next
                fs.Position = &H1A46
                fs.WriteByte(valu_itemsedit_spefoods.Value)
            End If
        End If
    End Sub

    Private Sub Icon_itemsedit_foods_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_foods.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock foods by number (you have to click on 'Save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les nourritures par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_foods_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_foods.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_clothes_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_clothes.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock clothes by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les vêtements par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_clothes_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_clothes.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_ssclothes_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_ssclothes.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock StreetPass / SpotPass clothes by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les vêtements StreetPass / SpotPass par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_ssclothes_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_ssclothes.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_hats_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_hats.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock hats by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les chapeaux par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_hats_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_hats.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_sshats_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_sshats.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock StreetPass / SpotPass hats by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les chapeaux StreetPass / SpotPass par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_sshats_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_sshats.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_interiors_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_interiors.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock interiors by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les intérieurs par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_interiors_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_interiors.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_goodsitems_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_goodsitems.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock goods items by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les objets divers par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_goodsitems_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_goodsitems.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_treasures_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_treasures.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock treasures by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les trésors par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_treasures_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_treasures.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_itemsedit_spefoods_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_itemsedit_spefoods.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to unlock special foods by number (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l'orange pour débloquer les produits spéciaux par nombre (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_itemsedit_spefoods_MouseLeave(sender As Object, e As EventArgs) Handles Icon_itemsedit_spefoods.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_foods_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_foods.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all foods (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer toutes les nourritures (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_foods_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_foods.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_clothes_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_clothes.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all clothes (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les vêtements (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_clothes_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_clothes.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_ssclothes_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_ssclothes.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all StreetPass / SpotPass clothes (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les vêtements StreetPass / SpotPass (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_ssclothes_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_ssclothes.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_hats_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_hats.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all hats (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les chapeaux (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_hats_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_hats.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_sshats_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_sshats.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all StreetPass / SpotPass hats (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les chapeaux StreetPass / SpotPass (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_sshats_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_sshats.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_interiors_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_interiors.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all interiors (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les intérieurs (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_interiors_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_interiors.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_goodsitems_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_goodsitems.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all goods items (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les objets divers (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_goodsitems_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_goodsitems.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_treasures_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_treasures.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all treasures (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les trésors (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_treasures_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_treasures.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_delete_spefoods_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_delete_spefoods.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to delete all special foods (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour supprimer tout les produits spéciaux (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_delete_spefoods_MouseLeave(sender As Object, e As EventArgs) Handles Check_delete_spefoods.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_available_ssclothes_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_available_ssclothes.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to make all StreetPass / SpotPass clothes available in the shop (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour rendre disponible tout les vêtements StreetPass / SpotPass dans le magasin (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_available_ssclothes_MouseLeave(sender As Object, e As EventArgs) Handles Check_available_ssclothes.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Check_available_sshats_MouseMove(sender As Object, e As MouseEventArgs) Handles Check_available_sshats.MouseMove
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Set as orange to make all StreetPass / SpotPass hats available in the shop (you have to click on 'save' button on top)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Mettre à l’orange pour rendre disponible tout les chapeaux StreetPass / SpotPass dans le magasin (vous devez cliquer sur le bouton 'Enregistrer' en haut)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Check_available_sshats_MouseLeave(sender As Object, e As EventArgs) Handles Check_available_sshats.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Try
            Writefoodsitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit foods', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets nourritures', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writeclothesitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit clothes', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets vêtements', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writessclothesitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit StreetPass / SpotPass clothes', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets vêtements StreetPass / SpotPass', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writehatsitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit hats', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets chapeaux / SpotPass', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writesshatsitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit StreetPass / SpotPass hats', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets chapeaux StreetPass / SpotPass', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writeinteriorsitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit interiors', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets intérieurs / SpotPass', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writegoodsitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit goods items', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets divers', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writetreasuresitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit goods treasures', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets trésors', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        Try
            Writespefoodsitems()
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Writing of this feature has failed : 'Items edit special foods', please report this issue"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "L’écriture de cette fonctionnalité a échoué : 'Édition objets produits spéciaux', veuillez signaler ce problème"
            End If
            TLSE_dialog.ShowDialog()
        End Try
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Items has been successfully edited" & vbNewLine & "You will back to main menu"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Les objets ont été édités avec succès" & vbNewLine & "Vous allez retourner au menu principal"
        End If
        TLSE_dialog.ShowDialog()
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        Me.Close()
    End Sub
End Class