Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_islandconfig
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

    Private Sub TLSE_islandconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Public Sub Savefileregion()
        If Filever_text.Text = "JP" Then
            icon_rooftop.Visible = True
            Fea_tower.Visible = False
            Fea_plane.Visible = False
            Fea_amusementpark.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_beach.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_cafe.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_campground.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_clothingshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_compatibilitytester.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_concerthall.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_foodmart.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_fountain.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_hatsshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_importwear.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_interiorshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_miiapartment.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_miihomes.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_miinews.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_park.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_pawnshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_photostudio.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_plane.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_port.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_rankingboard.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Fea_townhall.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
        Else
            icon_rooftop.Visible = False
        End If
    End Sub

    Private Sub Warning_network_Click(sender As Object, e As EventArgs) Handles Warning_network.Click
        TLSE_dialog.Text_TLSE_dialog.Text = "Don't edit network panel access except if you have already unlock him"
        TLSE_dialog.ShowDialog()
    End Sub

    Private Sub valu_vitality_ValueChanged(sender As Object, e As EventArgs) Handles valu_vitality.ValueChanged
        If valu_vitality.Value = 0 Then
            Fea_vitality.BackgroundImage = My.Resources.ranking_vitalityi
            Iconew_vitality.Visible = False
        ElseIf valu_vitality.Value = 1 Then
            Fea_vitality.BackgroundImage = My.Resources.ranking_vitality
            Iconew_vitality.Visible = False
        ElseIf valu_vitality.Value = 2 Then
            Fea_vitality.BackgroundImage = My.Resources.ranking_vitality
            Iconew_vitality.Visible = True
        End If
    End Sub

    Private Sub Fea_vitality_Click(sender As Object, e As EventArgs) Handles Fea_vitality.Click
        If valu_vitality.Value = 0 Then
            valu_vitality.Value = 1
        ElseIf valu_vitality.Value = 1 Then
            valu_vitality.Value = 2
        ElseIf valu_vitality.Value = 2 Then
            valu_vitality.Value = 0
        End If
    End Sub

    Private Sub valu_popularity_ValueChanged(sender As Object, e As EventArgs) Handles valu_popularity.ValueChanged
        If valu_popularity.Value = 0 Then
            Fea_popularity.BackgroundImage = My.Resources.ranking_popularityi
            Iconew_popularity.Visible = False
        ElseIf valu_popularity.Value = 1 Then
            Fea_popularity.BackgroundImage = My.Resources.ranking_popularity
            Iconew_popularity.Visible = False
        ElseIf valu_popularity.Value = 2 Then
            Fea_popularity.BackgroundImage = My.Resources.ranking_popularity
            Iconew_popularity.Visible = True
        End If
    End Sub

    Private Sub Fea_popularity_Click(sender As Object, e As EventArgs) Handles Fea_popularity.Click
        If valu_popularity.Value = 0 Then
            valu_popularity.Value = 1
        ElseIf valu_popularity.Value = 1 Then
            valu_popularity.Value = 2
        ElseIf valu_popularity.Value = 2 Then
            valu_popularity.Value = 0
        End If
    End Sub

    Private Sub valu_boycharm_ValueChanged(sender As Object, e As EventArgs) Handles valu_boycharm.ValueChanged
        If valu_boycharm.Value = 0 Then
            Fea_boycharm.BackgroundImage = My.Resources.ranking_boycharmi
            Iconew_boycharm.Visible = False
        ElseIf valu_boycharm.Value = 1 Then
            Fea_boycharm.BackgroundImage = My.Resources.ranking_boycharm
            Iconew_boycharm.Visible = False
        ElseIf valu_boycharm.Value = 2 Then
            Fea_boycharm.BackgroundImage = My.Resources.ranking_boycharm
            Iconew_boycharm.Visible = True
        End If
    End Sub

    Private Sub Fea_boycharm_Click(sender As Object, e As EventArgs) Handles Fea_boycharm.Click
        If valu_boycharm.Value = 0 Then
            valu_boycharm.Value = 1
        ElseIf valu_boycharm.Value = 1 Then
            valu_boycharm.Value = 2
        ElseIf valu_boycharm.Value = 2 Then
            valu_boycharm.Value = 0
        End If
    End Sub

    Private Sub valu_girlcharm_ValueChanged(sender As Object, e As EventArgs) Handles valu_girlcharm.ValueChanged
        If valu_girlcharm.Value = 0 Then
            Fea_girlcharm.BackgroundImage = My.Resources.ranking_girlcharmi
            Iconew_girlcharm.Visible = False
        ElseIf valu_girlcharm.Value = 1 Then
            Fea_girlcharm.BackgroundImage = My.Resources.ranking_girlcharm
            Iconew_girlcharm.Visible = False
        ElseIf valu_girlcharm.Value = 2 Then
            Fea_girlcharm.BackgroundImage = My.Resources.ranking_girlcharm
            Iconew_girlcharm.Visible = True
        End If
    End Sub

    Private Sub Fea_girlcharm_Click(sender As Object, e As EventArgs) Handles Fea_girlcharm.Click
        If valu_girlcharm.Value = 0 Then
            valu_girlcharm.Value = 1
        ElseIf valu_girlcharm.Value = 1 Then
            valu_girlcharm.Value = 2
        ElseIf valu_girlcharm.Value = 2 Then
            valu_girlcharm.Value = 0
        End If
    End Sub

    Private Sub valu_pampered_ValueChanged(sender As Object, e As EventArgs) Handles valu_pampered.ValueChanged
        If valu_pampered.Value = 0 Then
            Fea_pampered.BackgroundImage = My.Resources.ranking_pamperedi
            Iconew_pampered.Visible = False
        ElseIf valu_pampered.Value = 1 Then
            Fea_pampered.BackgroundImage = My.Resources.ranking_pampered
            Iconew_pampered.Visible = False
        ElseIf valu_pampered.Value = 2 Then
            Fea_pampered.BackgroundImage = My.Resources.ranking_pampered
            Iconew_pampered.Visible = True
        End If
    End Sub

    Private Sub Fea_pampered_Click(sender As Object, e As EventArgs) Handles Fea_pampered.Click
        If valu_pampered.Value = 0 Then
            valu_pampered.Value = 1
        ElseIf valu_pampered.Value = 1 Then
            valu_pampered.Value = 2
        ElseIf valu_pampered.Value = 2 Then
            valu_pampered.Value = 0
        End If
    End Sub

    Private Sub valu_friendship_ValueChanged(sender As Object, e As EventArgs) Handles valu_friendship.ValueChanged
        If valu_friendship.Value = 0 Then
            Fea_friendship.BackgroundImage = My.Resources.ranking_friendshipi
            Iconew_friendship.Visible = False
        ElseIf valu_friendship.Value = 1 Then
            Fea_friendship.BackgroundImage = My.Resources.ranking_friendship
            Iconew_friendship.Visible = False
        ElseIf valu_friendship.Value = 2 Then
            Fea_friendship.BackgroundImage = My.Resources.ranking_friendship
            Iconew_friendship.Visible = True
        End If
    End Sub

    Private Sub Fea_friendship_Click(sender As Object, e As EventArgs) Handles Fea_friendship.Click
        If valu_friendship.Value = 0 Then
            valu_friendship.Value = 1
        ElseIf valu_friendship.Value = 1 Then
            valu_friendship.Value = 2
        ElseIf valu_friendship.Value = 2 Then
            valu_friendship.Value = 0
        End If
    End Sub

    Private Sub valu_romance_ValueChanged(sender As Object, e As EventArgs) Handles valu_romance.ValueChanged
        If valu_romance.Value = 0 Then
            Fea_romance.BackgroundImage = My.Resources.ranking_romancei
            Iconew_romance.Visible = False
        ElseIf valu_romance.Value = 1 Then
            Fea_romance.BackgroundImage = My.Resources.ranking_romance
            Iconew_romance.Visible = False
        ElseIf valu_romance.Value = 2 Then
            Fea_romance.BackgroundImage = My.Resources.ranking_romance
            Iconew_romance.Visible = True
        End If
    End Sub

    Private Sub Fea_romance_Click(sender As Object, e As EventArgs) Handles Fea_romance.Click
        If valu_romance.Value = 0 Then
            valu_romance.Value = 1
        ElseIf valu_romance.Value = 1 Then
            valu_romance.Value = 2
        ElseIf valu_romance.Value = 2 Then
            valu_romance.Value = 0
        End If
    End Sub

    Private Sub valu_island_ValueChanged(sender As Object, e As EventArgs) Handles valu_island.ValueChanged
        If valu_island.Value = 0 Then
            Fea_island.BackgroundImage = My.Resources.ranking_islandi
            Iconew_island.Visible = False
        ElseIf valu_island.Value = 1 Then
            Fea_island.BackgroundImage = My.Resources.ranking_island
            Iconew_island.Visible = False
        ElseIf valu_island.Value = 2 Then
            Fea_island.BackgroundImage = My.Resources.ranking_island
            Iconew_island.Visible = True
        End If
    End Sub

    Private Sub Fea_island_Click(sender As Object, e As EventArgs) Handles Fea_island.Click
        If valu_island.Value = 0 Then
            valu_island.Value = 1
        ElseIf valu_island.Value = 1 Then
            valu_island.Value = 2
        ElseIf valu_island.Value = 2 Then
            valu_island.Value = 0
        End If
    End Sub

    Private Sub valu_traveler_ValueChanged(sender As Object, e As EventArgs) Handles valu_traveler.ValueChanged
        If valu_traveler.Value = 0 Then
            Fea_traveler.BackgroundImage = My.Resources.ranking_traveleri
            Iconew_traveler.Visible = False
        ElseIf valu_traveler.Value = 1 Then
            Fea_traveler.BackgroundImage = My.Resources.ranking_traveler
            Iconew_traveler.Visible = False
        ElseIf valu_traveler.Value = 2 Then
            Fea_traveler.BackgroundImage = My.Resources.ranking_traveler
            Iconew_traveler.Visible = True
        End If
    End Sub

    Private Sub Fea_traveler_Click(sender As Object, e As EventArgs) Handles Fea_traveler.Click
        If valu_traveler.Value = 0 Then
            valu_traveler.Value = 1
        ElseIf valu_traveler.Value = 1 Then
            valu_traveler.Value = 2
        ElseIf valu_traveler.Value = 2 Then
            valu_traveler.Value = 0
        End If
    End Sub

    Private Sub valu_splurge_ValueChanged(sender As Object, e As EventArgs) Handles valu_splurge.ValueChanged
        If valu_splurge.Value = 0 Then
            Fea_splurge.BackgroundImage = My.Resources.ranking_splurgei
            Iconew_splurge.Visible = False
        ElseIf valu_splurge.Value = 1 Then
            Fea_splurge.BackgroundImage = My.Resources.ranking_splurge
            Iconew_splurge.Visible = False
        ElseIf valu_splurge.Value = 2 Then
            Fea_splurge.BackgroundImage = My.Resources.ranking_splurge
            Iconew_splurge.Visible = True
        End If
    End Sub

    Private Sub Fea_splurge_Click(sender As Object, e As EventArgs) Handles Fea_splurge.Click
        If valu_splurge.Value = 0 Then
            valu_splurge.Value = 1
        ElseIf valu_splurge.Value = 1 Then
            valu_splurge.Value = 2
        ElseIf valu_splurge.Value = 2 Then
            valu_splurge.Value = 0
        End If
    End Sub

    Private Sub Icon_eventfountain_Click(sender As Object, e As EventArgs) Handles Icon_eventfountain.Click
        valu_eventfountain.Value = 0
    End Sub

    Private Sub valu_eventfountain_ValueChanged(sender As Object, e As EventArgs) Handles valu_eventfountain.ValueChanged
        If valu_eventfountain.Value = 0 Then
            Iconew_eventfountain.Visible = True
        Else
            Iconew_eventfountain.Visible = False
        End If
    End Sub

    Private Sub Icon_appartrenov_Click(sender As Object, e As EventArgs) Handles Icon_appartrenov.Click
        If valu_appartrenov.Value = 0 Then
            valu_appartrenov.Value = 1
        ElseIf valu_appartrenov.Value = 1 Then
            valu_appartrenov.Value = 2
        ElseIf valu_appartrenov.Value = 2 Then
            valu_appartrenov.Value = 3
        ElseIf valu_appartrenov.Value = 3 Then
            valu_appartrenov.Value = 0
        End If
    End Sub

    Private Sub valu_appartrenov_ValueChanged(sender As Object, e As EventArgs) Handles valu_appartrenov.ValueChanged
        If valu_appartrenov.Value = 0 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_00
        ElseIf valu_appartrenov.Value = 1 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_01
        ElseIf valu_appartrenov.Value = 2 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_02
        ElseIf valu_appartrenov.Value = 3 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_03
        End If
    End Sub

    Private Sub valu_allownetwork_ValueChanged(sender As Object, e As EventArgs) Handles valu_allownetwork.ValueChanged
        If valu_allownetwork.Value = 2 Then
            Fea_network.Visible = True
            Warning_network.Visible = True
        Else
            Fea_network.Visible = False
            Warning_network.Visible = False
        End If
    End Sub

    Private Sub icon_rooftop_Click(sender As Object, e As EventArgs) Handles icon_rooftop.Click
        If valu_tower.Value = 2 Then
            valu_tower.Value = 0
        ElseIf valu_tower.Value = 0 Then
            valu_tower.Value = 1
        ElseIf valu_tower.Value = 1 Then
            valu_tower.Value = 0
        End If
    End Sub

    Private Sub valu_tower_ValueChanged(sender As Object, e As EventArgs) Handles valu_tower.ValueChanged
        If Filever_text.Text = "JP" Then
            If valu_tower.Value = 0 Then
                icon_rooftop.Image = My.Resources.iconbuilding_rooftop_off
            ElseIf valu_tower.Value = 1 Then
                icon_rooftop.Image = My.Resources.iconbuilding_rooftop_on
            End If
        Else
            If valu_tower.Value = 0 Then
                Fea_tower.BackgroundImage = My.Resources.iconbuilding_tower_off
                Iconew_tower.Visible = False
            ElseIf valu_tower.Value = 1 Then
                Fea_tower.BackgroundImage = My.Resources.iconbuilding_tower_on
                Iconew_tower.Visible = False
            ElseIf valu_tower.Value = 2 Then
                Fea_tower.BackgroundImage = My.Resources.iconbuilding_tower_on
                Iconew_tower.Visible = True
            End If
        End If
    End Sub

    Private Sub Fea_tower_Click(sender As Object, e As EventArgs) Handles Fea_tower.Click
        If valu_tower.Value = 0 Then
            valu_tower.Value = 1
        ElseIf valu_tower.Value = 1 Then
            valu_tower.Value = 2
        ElseIf valu_tower.Value = 2 Then
            valu_tower.Value = 0
        End If
    End Sub

    Private Sub valu_clothingshop_ValueChanged(sender As Object, e As EventArgs) Handles valu_clothingshop.ValueChanged
        If valu_clothingshop.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_clothingshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_clothingshop.BackgroundImage = My.Resources.iconbuilding_clothingshop_off
            End If
            Iconew_clothingshop.Visible = False
        ElseIf valu_clothingshop.Value = 1 Then
            Fea_clothingshop.BackgroundImage = My.Resources.iconbuilding_clothingshop_on
            Iconew_clothingshop.Visible = False
        ElseIf valu_clothingshop.Value = 2 Then
            Fea_clothingshop.BackgroundImage = My.Resources.iconbuilding_clothingshop_on
            Iconew_clothingshop.Visible = True
        End If
    End Sub

    Private Sub Fea_clothingshop_Click(sender As Object, e As EventArgs) Handles Fea_clothingshop.Click
        If valu_clothingshop.Value = 0 Then
            valu_clothingshop.Value = 1
        ElseIf valu_clothingshop.Value = 1 Then
            valu_clothingshop.Value = 2
        ElseIf valu_clothingshop.Value = 2 Then
            valu_clothingshop.Value = 0
        End If
    End Sub

    Private Sub valu_interiorshop_ValueChanged(sender As Object, e As EventArgs) Handles valu_interiorshop.ValueChanged
        If valu_interiorshop.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_interiorshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_interiorshop.BackgroundImage = My.Resources.iconbuilding_interiorshop_off
            End If
            Iconew_interiorshop.Visible = False
        ElseIf valu_interiorshop.Value = 1 Then
            Fea_interiorshop.BackgroundImage = My.Resources.iconbuilding_interiorshop_on
            Iconew_interiorshop.Visible = False
        ElseIf valu_interiorshop.Value = 2 Then
            Fea_interiorshop.BackgroundImage = My.Resources.iconbuilding_interiorshop_on
            Iconew_interiorshop.Visible = True
        End If
    End Sub

    Private Sub Fea_interiorshop_Click(sender As Object, e As EventArgs) Handles Fea_interiorshop.Click
        If valu_interiorshop.Value = 0 Then
            valu_interiorshop.Value = 1
        ElseIf valu_interiorshop.Value = 1 Then
            valu_interiorshop.Value = 2
        ElseIf valu_interiorshop.Value = 2 Then
            valu_interiorshop.Value = 0
        End If
    End Sub

    Private Sub valu_park_ValueChanged(sender As Object, e As EventArgs) Handles valu_park.ValueChanged
        If valu_park.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_park.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_park.BackgroundImage = My.Resources.iconbuilding_park_off
            End If
            Iconew_park.Visible = False
        ElseIf valu_park.Value = 1 Then
            Fea_park.BackgroundImage = My.Resources.iconbuilding_park_on
            Iconew_park.Visible = False
        ElseIf valu_park.Value = 2 Then
            Fea_park.BackgroundImage = My.Resources.iconbuilding_park_on
            Iconew_park.Visible = True
        End If
    End Sub

    Private Sub Fea_park_Click(sender As Object, e As EventArgs) Handles Fea_park.Click
        If valu_park.Value = 0 Then
            valu_park.Value = 1
        ElseIf valu_park.Value = 1 Then
            valu_park.Value = 2
        ElseIf valu_park.Value = 2 Then
            valu_park.Value = 0
        End If
    End Sub

    Private Sub valu_miinews_ValueChanged(sender As Object, e As EventArgs) Handles valu_miinews.ValueChanged
        If valu_miinews.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_miinews.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_miinews.BackgroundImage = My.Resources.iconbuilding_miinews_off
            End If
            Iconew_miinews.Visible = False
        ElseIf valu_miinews.Value = 1 Then
            Fea_miinews.BackgroundImage = My.Resources.iconbuilding_miinews_on
            Iconew_miinews.Visible = False
        ElseIf valu_miinews.Value = 2 Then
            Fea_miinews.BackgroundImage = My.Resources.iconbuilding_miinews_on
            Iconew_miinews.Visible = True
        End If
    End Sub

    Private Sub Fea_miinews_Click(sender As Object, e As EventArgs) Handles Fea_miinews.Click
        If valu_miinews.Value = 0 Then
            valu_miinews.Value = 1
        ElseIf valu_miinews.Value = 1 Then
            valu_miinews.Value = 2
        ElseIf valu_miinews.Value = 2 Then
            valu_miinews.Value = 0
        End If
    End Sub

    Private Sub valu_pawnshop_ValueChanged(sender As Object, e As EventArgs) Handles valu_pawnshop.ValueChanged
        If valu_pawnshop.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_pawnshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_pawnshop.BackgroundImage = My.Resources.iconbuilding_pawnshop_off
            End If
            Iconew_pawnshop.Visible = False
        ElseIf valu_pawnshop.Value = 1 Then
            Fea_pawnshop.BackgroundImage = My.Resources.iconbuilding_pawnshop_on
            Iconew_pawnshop.Visible = False
        ElseIf valu_pawnshop.Value = 2 Then
            Fea_pawnshop.BackgroundImage = My.Resources.iconbuilding_pawnshop_on
            Iconew_pawnshop.Visible = True
        End If
    End Sub

    Private Sub Fea_pawnshop_Click(sender As Object, e As EventArgs) Handles Fea_pawnshop.Click
        If valu_pawnshop.Value = 0 Then
            valu_pawnshop.Value = 1
        ElseIf valu_pawnshop.Value = 1 Then
            valu_pawnshop.Value = 2
        ElseIf valu_pawnshop.Value = 2 Then
            valu_pawnshop.Value = 0
        End If
    End Sub

    Private Sub valu_miiapartment_ValueChanged(sender As Object, e As EventArgs) Handles valu_miiapartment.ValueChanged
        If valu_miiapartment.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_miiapartment.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_miiapartment.BackgroundImage = My.Resources.iconbuilding_miiapartment_off
            End If
            Iconew_miiapartment.Visible = False
        ElseIf valu_miiapartment.Value = 1 Then
            Fea_miiapartment.BackgroundImage = My.Resources.iconbuilding_miiapartment_on
            Iconew_miiapartment.Visible = False
        ElseIf valu_miiapartment.Value = 2 Then
            Fea_miiapartment.BackgroundImage = My.Resources.iconbuilding_miiapartment_on
            Iconew_miiapartment.Visible = True
        End If
    End Sub

    Private Sub Fea_miiapartment_Click(sender As Object, e As EventArgs) Handles Fea_miiapartment.Click
        If valu_miiapartment.Value = 0 Then
            valu_miiapartment.Value = 1
        ElseIf valu_miiapartment.Value = 1 Then
            valu_miiapartment.Value = 2
        ElseIf valu_miiapartment.Value = 2 Then
            valu_miiapartment.Value = 0
        End If
    End Sub

    Private Sub valu_townhall_ValueChanged(sender As Object, e As EventArgs) Handles valu_townhall.ValueChanged
        If valu_townhall.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_townhall.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_townhall.BackgroundImage = My.Resources.iconbuilding_townhall_off
            End If
            Iconew_townhall.Visible = False
        ElseIf valu_townhall.Value = 1 Then
            Fea_townhall.BackgroundImage = My.Resources.iconbuilding_townhall_on
            Iconew_townhall.Visible = False
        ElseIf valu_townhall.Value = 2 Then
            Fea_townhall.BackgroundImage = My.Resources.iconbuilding_townhall_on
            Iconew_townhall.Visible = True
        End If
    End Sub

    Private Sub Fea_townhall_Click(sender As Object, e As EventArgs) Handles Fea_townhall.Click
        If valu_townhall.Value = 0 Then
            valu_townhall.Value = 1
        ElseIf valu_townhall.Value = 1 Then
            valu_townhall.Value = 2
        ElseIf valu_townhall.Value = 2 Then
            valu_townhall.Value = 0
        End If
    End Sub

    Private Sub valu_miihomes_ValueChanged(sender As Object, e As EventArgs) Handles valu_miihomes.ValueChanged
        If valu_miihomes.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_miihomes.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_miihomes.BackgroundImage = My.Resources.iconbuilding_miihomes_off
            End If
            Iconew_miihomes.Visible = False
        ElseIf valu_miihomes.Value = 1 Then
            Fea_miihomes.BackgroundImage = My.Resources.iconbuilding_miihomes_on
            Iconew_miihomes.Visible = False
        ElseIf valu_miihomes.Value = 2 Then
            Fea_miihomes.BackgroundImage = My.Resources.iconbuilding_miihomes_on
            Iconew_miihomes.Visible = True
        End If
    End Sub

    Private Sub Fea_miihomes_Click(sender As Object, e As EventArgs) Handles Fea_miihomes.Click
        If valu_miihomes.Value = 0 Then
            valu_miihomes.Value = 1
        ElseIf valu_miihomes.Value = 1 Then
            valu_miihomes.Value = 2
        ElseIf valu_miihomes.Value = 2 Then
            valu_miihomes.Value = 0
        End If
    End Sub

    Private Sub valu_amusementpark_ValueChanged(sender As Object, e As EventArgs) Handles valu_amusementpark.ValueChanged
        If valu_amusementpark.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_amusementpark.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_amusementpark.BackgroundImage = My.Resources.iconbuilding_amusementpark_off
            End If
            Iconew_amusementpark.Visible = False
        ElseIf valu_amusementpark.Value = 1 Then
            Fea_amusementpark.BackgroundImage = My.Resources.iconbuilding_amusementpark_on
            Iconew_amusementpark.Visible = False
        ElseIf valu_amusementpark.Value = 2 Then
            Fea_amusementpark.BackgroundImage = My.Resources.iconbuilding_amusementpark_on
            Iconew_amusementpark.Visible = True
        End If
    End Sub

    Private Sub Fea_amusementpark_Click(sender As Object, e As EventArgs) Handles Fea_amusementpark.Click
        If valu_amusementpark.Value = 0 Then
            valu_amusementpark.Value = 1
        ElseIf valu_amusementpark.Value = 1 Then
            valu_amusementpark.Value = 2
        ElseIf valu_amusementpark.Value = 2 Then
            valu_amusementpark.Value = 0
        End If
    End Sub

    Private Sub valu_hatsshop_ValueChanged(sender As Object, e As EventArgs) Handles valu_hatsshop.ValueChanged
        If valu_hatsshop.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_hatsshop.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_hatsshop.BackgroundImage = My.Resources.iconbuilding_hatsshop_off
            End If
            Iconew_hatsshop.Visible = False
        ElseIf valu_hatsshop.Value = 1 Then
            Fea_hatsshop.BackgroundImage = My.Resources.iconbuilding_hatsshop_on
            Iconew_hatsshop.Visible = False
        ElseIf valu_hatsshop.Value = 2 Then
            Fea_hatsshop.BackgroundImage = My.Resources.iconbuilding_hatsshop_on
            Iconew_hatsshop.Visible = True
        End If
    End Sub

    Private Sub Fea_hatsshop_Click(sender As Object, e As EventArgs) Handles Fea_hatsshop.Click
        If valu_hatsshop.Value = 0 Then
            valu_hatsshop.Value = 1
        ElseIf valu_hatsshop.Value = 1 Then
            valu_hatsshop.Value = 2
        ElseIf valu_hatsshop.Value = 2 Then
            valu_hatsshop.Value = 0
        End If
    End Sub

    Private Sub valu_fountain_ValueChanged(sender As Object, e As EventArgs) Handles valu_fountain.ValueChanged
        If valu_fountain.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_fountain.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_fountain.BackgroundImage = My.Resources.iconbuilding_fountain_off
            End If
            Iconew_fountain.Visible = False
        ElseIf valu_fountain.Value = 1 Then
            Fea_fountain.BackgroundImage = My.Resources.iconbuilding_fountain_on
            Iconew_fountain.Visible = False
        ElseIf valu_fountain.Value = 2 Then
            Fea_fountain.BackgroundImage = My.Resources.iconbuilding_fountain_on
            Iconew_fountain.Visible = True
        End If
    End Sub

    Private Sub Fea_fountain_Click(sender As Object, e As EventArgs) Handles Fea_fountain.Click
        If valu_fountain.Value = 0 Then
            valu_fountain.Value = 1
        ElseIf valu_fountain.Value = 1 Then
            valu_fountain.Value = 2
        ElseIf valu_fountain.Value = 2 Then
            valu_fountain.Value = 0
        End If
    End Sub

    Private Sub valu_concerthall_ValueChanged(sender As Object, e As EventArgs) Handles valu_concerthall.ValueChanged
        If valu_concerthall.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_concerthall.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_concerthall.BackgroundImage = My.Resources.iconbuilding_concerthall_off
            End If
            Iconew_concerthall.Visible = False
        ElseIf valu_concerthall.Value = 1 Then
            Fea_concerthall.BackgroundImage = My.Resources.iconbuilding_concerthall_on
            Iconew_concerthall.Visible = False
        ElseIf valu_concerthall.Value = 2 Then
            Fea_concerthall.BackgroundImage = My.Resources.iconbuilding_concerthall_on
            Iconew_concerthall.Visible = True
        End If
    End Sub

    Private Sub Fea_concerthall_Click(sender As Object, e As EventArgs) Handles Fea_concerthall.Click
        If valu_concerthall.Value = 0 Then
            valu_concerthall.Value = 1
        ElseIf valu_concerthall.Value = 1 Then
            valu_concerthall.Value = 2
        ElseIf valu_concerthall.Value = 2 Then
            valu_concerthall.Value = 0
        End If
    End Sub

    Private Sub valu_rankingboard_ValueChanged(sender As Object, e As EventArgs) Handles valu_rankingboard.ValueChanged
        If valu_rankingboard.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_rankingboard.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_rankingboard.BackgroundImage = My.Resources.iconbuilding_rankingboard_off
            End If
            Iconew_rankingboard.Visible = False
        ElseIf valu_rankingboard.Value = 1 Then
            Fea_rankingboard.BackgroundImage = My.Resources.iconbuilding_rankingboard_on
            Iconew_rankingboard.Visible = False
        ElseIf valu_rankingboard.Value = 2 Then
            Fea_rankingboard.BackgroundImage = My.Resources.iconbuilding_rankingboard_on
            Iconew_rankingboard.Visible = True
        End If
    End Sub

    Private Sub Fea_rankingboard_Click(sender As Object, e As EventArgs) Handles Fea_rankingboard.Click
        If valu_rankingboard.Value = 0 Then
            valu_rankingboard.Value = 1
        ElseIf valu_rankingboard.Value = 1 Then
            valu_rankingboard.Value = 2
        ElseIf valu_rankingboard.Value = 2 Then
            valu_rankingboard.Value = 0
        End If
    End Sub

    Private Sub valu_compatibilitytester_ValueChanged(sender As Object, e As EventArgs) Handles valu_compatibilitytester.ValueChanged
        If valu_compatibilitytester.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_compatibilitytester.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_compatibilitytester.BackgroundImage = My.Resources.iconbuilding_compatibilitytester_off
            End If
            Iconew_compatibilitytester.Visible = False
        ElseIf valu_compatibilitytester.Value = 1 Then
            Fea_compatibilitytester.BackgroundImage = My.Resources.iconbuilding_compatibilitytester_on
            Iconew_compatibilitytester.Visible = False
        ElseIf valu_compatibilitytester.Value = 2 Then
            Fea_compatibilitytester.BackgroundImage = My.Resources.iconbuilding_compatibilitytester_on
            Iconew_compatibilitytester.Visible = True
        End If
    End Sub

    Private Sub Fea_compatibilitytester_Click(sender As Object, e As EventArgs) Handles Fea_compatibilitytester.Click
        If valu_compatibilitytester.Value = 0 Then
            valu_compatibilitytester.Value = 1
        ElseIf valu_compatibilitytester.Value = 1 Then
            valu_compatibilitytester.Value = 2
        ElseIf valu_compatibilitytester.Value = 2 Then
            valu_compatibilitytester.Value = 0
        End If
    End Sub

    Private Sub valu_photostudio_ValueChanged(sender As Object, e As EventArgs) Handles valu_photostudio.ValueChanged
        If valu_photostudio.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_photostudio.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_photostudio.BackgroundImage = My.Resources.iconbuilding_photostudio_off
            End If
            Iconew_photostudio.Visible = False
        ElseIf valu_photostudio.Value = 1 Then
            Fea_photostudio.BackgroundImage = My.Resources.iconbuilding_photostudio_on
            Iconew_photostudio.Visible = False
        ElseIf valu_photostudio.Value = 2 Then
            Fea_photostudio.BackgroundImage = My.Resources.iconbuilding_photostudio_on
            Iconew_photostudio.Visible = True
        End If
    End Sub

    Private Sub Fea_photostudio_Click(sender As Object, e As EventArgs) Handles Fea_photostudio.Click
        If valu_photostudio.Value = 0 Then
            valu_photostudio.Value = 1
        ElseIf valu_photostudio.Value = 1 Then
            valu_photostudio.Value = 2
        ElseIf valu_photostudio.Value = 2 Then
            valu_photostudio.Value = 0
        End If
    End Sub

    Private Sub valu_cafe_ValueChanged(sender As Object, e As EventArgs) Handles valu_cafe.ValueChanged
        If valu_cafe.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_cafe.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_cafe.BackgroundImage = My.Resources.iconbuilding_cafe_off
            End If
            Iconew_cafe.Visible = False
        ElseIf valu_cafe.Value = 1 Then
            Fea_cafe.BackgroundImage = My.Resources.iconbuilding_cafe_on
            Iconew_cafe.Visible = False
        ElseIf valu_cafe.Value = 2 Then
            Fea_cafe.BackgroundImage = My.Resources.iconbuilding_cafe_on
            Iconew_cafe.Visible = True
        End If
    End Sub

    Private Sub Fea_cafe_Click(sender As Object, e As EventArgs) Handles Fea_cafe.Click
        If valu_cafe.Value = 0 Then
            valu_cafe.Value = 1
        ElseIf valu_cafe.Value = 1 Then
            valu_cafe.Value = 2
        ElseIf valu_cafe.Value = 2 Then
            valu_cafe.Value = 0
        End If
    End Sub

    Private Sub valu_foodmart_ValueChanged(sender As Object, e As EventArgs) Handles valu_foodmart.ValueChanged
        If valu_foodmart.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_foodmart.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_foodmart.BackgroundImage = My.Resources.iconbuilding_foodmart_off
            End If
            Iconew_foodmart.Visible = False
        ElseIf valu_foodmart.Value = 1 Then
            Fea_foodmart.BackgroundImage = My.Resources.iconbuilding_foodmart_on
            Iconew_foodmart.Visible = False
        ElseIf valu_foodmart.Value = 2 Then
            Fea_foodmart.BackgroundImage = My.Resources.iconbuilding_foodmart_on
            Iconew_foodmart.Visible = True
        End If
    End Sub

    Private Sub Fea_foodmart_Click(sender As Object, e As EventArgs) Handles Fea_foodmart.Click
        If valu_foodmart.Value = 0 Then
            valu_foodmart.Value = 1
        ElseIf valu_foodmart.Value = 1 Then
            valu_foodmart.Value = 2
        ElseIf valu_foodmart.Value = 2 Then
            valu_foodmart.Value = 0
        End If
    End Sub

    Private Sub valu_importwear_ValueChanged(sender As Object, e As EventArgs) Handles valu_importwear.ValueChanged
        If valu_importwear.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_importwear.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_importwear.BackgroundImage = My.Resources.iconbuilding_importwear_off
            End If
            Iconew_importwear.Visible = False
        ElseIf valu_importwear.Value = 1 Then
            Fea_importwear.BackgroundImage = My.Resources.iconbuilding_importwear_on
            Iconew_importwear.Visible = False
        ElseIf valu_importwear.Value = 2 Then
            Fea_importwear.BackgroundImage = My.Resources.iconbuilding_importwear_on
            Iconew_importwear.Visible = True
        End If
    End Sub

    Private Sub Fea_importwear_Click(sender As Object, e As EventArgs) Handles Fea_importwear.Click
        If valu_importwear.Value = 0 Then
            valu_importwear.Value = 1
        ElseIf valu_importwear.Value = 1 Then
            valu_importwear.Value = 2
        ElseIf valu_importwear.Value = 2 Then
            valu_importwear.Value = 0
        End If
    End Sub

    Private Sub valu_beach_ValueChanged(sender As Object, e As EventArgs) Handles valu_beach.ValueChanged
        If valu_beach.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_beach.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_beach.BackgroundImage = My.Resources.iconbuilding_beach_off
            End If
            Iconew_beach.Visible = False
        ElseIf valu_beach.Value = 1 Then
            Fea_beach.BackgroundImage = My.Resources.iconbuilding_beach_on
            Iconew_beach.Visible = False
        ElseIf valu_beach.Value = 2 Then
            Fea_beach.BackgroundImage = My.Resources.iconbuilding_beach_on
            Iconew_beach.Visible = True
        End If
    End Sub

    Private Sub Fea_beach_Click(sender As Object, e As EventArgs) Handles Fea_beach.Click
        If valu_beach.Value = 0 Then
            valu_beach.Value = 1
        ElseIf valu_beach.Value = 1 Then
            valu_beach.Value = 2
        ElseIf valu_beach.Value = 2 Then
            valu_beach.Value = 0
        End If
    End Sub

    Private Sub valu_campground_ValueChanged(sender As Object, e As EventArgs) Handles valu_campground.ValueChanged
        If valu_campground.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_campground.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_campground.BackgroundImage = My.Resources.iconbuilding_campground_off
            End If
            Iconew_campground.Visible = False
        ElseIf valu_campground.Value = 1 Then
            Fea_campground.BackgroundImage = My.Resources.iconbuilding_campground_on
            Iconew_campground.Visible = False
        ElseIf valu_campground.Value = 2 Then
            Fea_campground.BackgroundImage = My.Resources.iconbuilding_campground_on
            Iconew_campground.Visible = True
        End If
    End Sub

    Private Sub Fea_campground_Click(sender As Object, e As EventArgs) Handles Fea_campground.Click
        If valu_campground.Value = 0 Then
            valu_campground.Value = 1
        ElseIf valu_campground.Value = 1 Then
            valu_campground.Value = 2
        ElseIf valu_campground.Value = 2 Then
            valu_campground.Value = 0
        End If
    End Sub

    Private Sub valu_port_ValueChanged(sender As Object, e As EventArgs) Handles valu_port.ValueChanged
        If valu_port.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_port.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_port.BackgroundImage = My.Resources.iconbuilding_port_off
            End If
            Iconew_port.Visible = False
        ElseIf valu_port.Value = 1 Then
            Fea_port.BackgroundImage = My.Resources.iconbuilding_port_on
            Iconew_port.Visible = False
        ElseIf valu_port.Value = 2 Then
            Fea_port.BackgroundImage = My.Resources.iconbuilding_port_on
            Iconew_port.Visible = True
        End If
    End Sub

    Private Sub Fea_port_Click(sender As Object, e As EventArgs) Handles Fea_port.Click
        If valu_port.Value = 0 Then
            valu_port.Value = 1
        ElseIf valu_port.Value = 1 Then
            valu_port.Value = 2
        ElseIf valu_port.Value = 2 Then
            valu_port.Value = 0
        End If
    End Sub

    Private Sub valu_plane_ValueChanged(sender As Object, e As EventArgs) Handles valu_plane.ValueChanged
        If valu_plane.Value = 0 Then
            If Filever_text.Text = "JP" Then
                Fea_plane.BackgroundImage = My.Resources.iconbuilding_emptyjbuildings_off
            Else
                Fea_plane.BackgroundImage = My.Resources.iconbuilding_plane_off
            End If
            Iconew_plane.Visible = False
        ElseIf valu_plane.Value = 1 Then
            Fea_plane.BackgroundImage = My.Resources.iconbuilding_plane_on
            Iconew_plane.Visible = False
        ElseIf valu_plane.Value = 2 Then
            Fea_plane.BackgroundImage = My.Resources.iconbuilding_plane_on
            Iconew_plane.Visible = True
        End If
    End Sub

    Private Sub Fea_plane_Click(sender As Object, e As EventArgs) Handles Fea_plane.Click
        If valu_plane.Value = 0 Then
            valu_plane.Value = 1
        ElseIf valu_plane.Value = 1 Then
            valu_plane.Value = 2
        ElseIf valu_plane.Value = 2 Then
            valu_plane.Value = 0
        End If
    End Sub

End Class