<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TLSE_relamechanics
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TLSE_relamechanics))
        Me.TLSE_header = New System.Windows.Forms.Panel()
        Me.TLSE_filepath = New System.Windows.Forms.TextBox()
        Me.Select_language = New System.Windows.Forms.ComboBox()
        Me.Panel_bspesymb = New System.Windows.Forms.Panel()
        Me.Setting_spesymb = New System.Windows.Forms.CheckBox()
        Me.Icon_bspesymb = New System.Windows.Forms.PictureBox()
        Me.Panel_Advhelp = New System.Windows.Forms.Panel()
        Me.Setting_Advhelp = New System.Windows.Forms.CheckBox()
        Me.Icon_Advhelp = New System.Windows.Forms.PictureBox()
        Me.Panel_chkupdate = New System.Windows.Forms.Panel()
        Me.Setting_ckupdate = New System.Windows.Forms.CheckBox()
        Me.Icon_chkupdate = New System.Windows.Forms.PictureBox()
        Me.Panel_filepath = New System.Windows.Forms.Panel()
        Me.Setting_filepath = New System.Windows.Forms.CheckBox()
        Me.Icon_filepath = New System.Windows.Forms.PictureBox()
        Me.Panel_hiddenthings = New System.Windows.Forms.Panel()
        Me.Setting_hidden = New System.Windows.Forms.CheckBox()
        Me.Icon_hiddenthings = New System.Windows.Forms.PictureBox()
        Me.Panel_bgmusic = New System.Windows.Forms.Panel()
        Me.Select_music = New System.Windows.Forms.ComboBox()
        Me.Setting_music = New System.Windows.Forms.CheckBox()
        Me.Icon_bgmusic = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Filever_text = New System.Windows.Forms.Label()
        Me.Title_filever = New System.Windows.Forms.Label()
        Me.Panel_menu_opensave = New System.Windows.Forms.Panel()
        Me.Text_menu_save = New System.Windows.Forms.Label()
        Me.Minimizebutton = New System.Windows.Forms.PictureBox()
        Me.TLSE_title = New System.Windows.Forms.PictureBox()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.TLSE_logo_update = New System.Windows.Forms.PictureBox()
        Me.TLSE_logo = New System.Windows.Forms.PictureBox()
        Me.Select_mii = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Text_mid_2 = New System.Windows.Forms.Label()
        Me.Text_mid_1 = New System.Windows.Forms.Label()
        Me.Text_right_2 = New System.Windows.Forms.Label()
        Me.Text_left_2 = New System.Windows.Forms.Label()
        Me.Text_right_1 = New System.Windows.Forms.Label()
        Me.Text_left_1 = New System.Windows.Forms.Label()
        Me.Icon_mid = New System.Windows.Forms.PictureBox()
        Me.TLSE_header.SuspendLayout()
        Me.Panel_bspesymb.SuspendLayout()
        CType(Me.Icon_bspesymb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Advhelp.SuspendLayout()
        CType(Me.Icon_Advhelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_chkupdate.SuspendLayout()
        CType(Me.Icon_chkupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_filepath.SuspendLayout()
        CType(Me.Icon_filepath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_hiddenthings.SuspendLayout()
        CType(Me.Icon_hiddenthings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_bgmusic.SuspendLayout()
        CType(Me.Icon_bgmusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel_menu_opensave.SuspendLayout()
        CType(Me.Minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_mid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLSE_header
        '
        Me.TLSE_header.BackColor = System.Drawing.Color.White
        Me.TLSE_header.Controls.Add(Me.TLSE_filepath)
        Me.TLSE_header.Controls.Add(Me.Select_language)
        Me.TLSE_header.Controls.Add(Me.Panel_bspesymb)
        Me.TLSE_header.Controls.Add(Me.Panel_Advhelp)
        Me.TLSE_header.Controls.Add(Me.Panel_chkupdate)
        Me.TLSE_header.Controls.Add(Me.Panel_filepath)
        Me.TLSE_header.Controls.Add(Me.Panel_hiddenthings)
        Me.TLSE_header.Controls.Add(Me.Panel_bgmusic)
        Me.TLSE_header.Controls.Add(Me.Panel2)
        Me.TLSE_header.Controls.Add(Me.Panel_menu_opensave)
        Me.TLSE_header.Controls.Add(Me.Minimizebutton)
        Me.TLSE_header.Controls.Add(Me.TLSE_title)
        Me.TLSE_header.Controls.Add(Me.Closebutton)
        Me.TLSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.TLSE_header.Location = New System.Drawing.Point(150, 0)
        Me.TLSE_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TLSE_header.Name = "TLSE_header"
        Me.TLSE_header.Size = New System.Drawing.Size(764, 75)
        Me.TLSE_header.TabIndex = 331
        '
        'TLSE_filepath
        '
        Me.TLSE_filepath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLSE_filepath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TLSE_filepath.Location = New System.Drawing.Point(439, 57)
        Me.TLSE_filepath.Name = "TLSE_filepath"
        Me.TLSE_filepath.Size = New System.Drawing.Size(280, 13)
        Me.TLSE_filepath.TabIndex = 19
        Me.TLSE_filepath.Visible = False
        '
        'Select_language
        '
        Me.Select_language.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Select_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_language.FormattingEnabled = True
        Me.Select_language.Items.AddRange(New Object() {"ENG", "FRA"})
        Me.Select_language.Location = New System.Drawing.Point(440, 40)
        Me.Select_language.Name = "Select_language"
        Me.Select_language.Size = New System.Drawing.Size(51, 21)
        Me.Select_language.TabIndex = 17
        Me.Select_language.Visible = False
        '
        'Panel_bspesymb
        '
        Me.Panel_bspesymb.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_bspesymb.Controls.Add(Me.Setting_spesymb)
        Me.Panel_bspesymb.Controls.Add(Me.Icon_bspesymb)
        Me.Panel_bspesymb.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_bspesymb.Location = New System.Drawing.Point(401, 38)
        Me.Panel_bspesymb.Name = "Panel_bspesymb"
        Me.Panel_bspesymb.Size = New System.Drawing.Size(34, 34)
        Me.Panel_bspesymb.TabIndex = 15
        Me.Panel_bspesymb.Visible = False
        '
        'Setting_spesymb
        '
        Me.Setting_spesymb.AutoSize = True
        Me.Setting_spesymb.Location = New System.Drawing.Point(0, 20)
        Me.Setting_spesymb.Name = "Setting_spesymb"
        Me.Setting_spesymb.Size = New System.Drawing.Size(15, 14)
        Me.Setting_spesymb.TabIndex = 6
        Me.Setting_spesymb.UseVisualStyleBackColor = True
        Me.Setting_spesymb.Visible = False
        '
        'Icon_bspesymb
        '
        Me.Icon_bspesymb.BackColor = System.Drawing.Color.Transparent
        Me.Icon_bspesymb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_bspesymb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_bspesymb.Enabled = False
        Me.Icon_bspesymb.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bsymb
        Me.Icon_bspesymb.Location = New System.Drawing.Point(0, 0)
        Me.Icon_bspesymb.Name = "Icon_bspesymb"
        Me.Icon_bspesymb.Size = New System.Drawing.Size(34, 34)
        Me.Icon_bspesymb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_bspesymb.TabIndex = 2
        Me.Icon_bspesymb.TabStop = False
        '
        'Panel_Advhelp
        '
        Me.Panel_Advhelp.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_Advhelp.Controls.Add(Me.Setting_Advhelp)
        Me.Panel_Advhelp.Controls.Add(Me.Icon_Advhelp)
        Me.Panel_Advhelp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_Advhelp.Location = New System.Drawing.Point(364, 38)
        Me.Panel_Advhelp.Name = "Panel_Advhelp"
        Me.Panel_Advhelp.Size = New System.Drawing.Size(34, 34)
        Me.Panel_Advhelp.TabIndex = 14
        Me.Panel_Advhelp.Visible = False
        '
        'Setting_Advhelp
        '
        Me.Setting_Advhelp.AutoSize = True
        Me.Setting_Advhelp.Location = New System.Drawing.Point(0, 20)
        Me.Setting_Advhelp.Name = "Setting_Advhelp"
        Me.Setting_Advhelp.Size = New System.Drawing.Size(15, 14)
        Me.Setting_Advhelp.TabIndex = 6
        Me.Setting_Advhelp.UseVisualStyleBackColor = True
        Me.Setting_Advhelp.Visible = False
        '
        'Icon_Advhelp
        '
        Me.Icon_Advhelp.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Advhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_Advhelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_Advhelp.Enabled = False
        Me.Icon_Advhelp.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_badvh
        Me.Icon_Advhelp.Location = New System.Drawing.Point(0, 0)
        Me.Icon_Advhelp.Name = "Icon_Advhelp"
        Me.Icon_Advhelp.Size = New System.Drawing.Size(34, 34)
        Me.Icon_Advhelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_Advhelp.TabIndex = 2
        Me.Icon_Advhelp.TabStop = False
        '
        'Panel_chkupdate
        '
        Me.Panel_chkupdate.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_chkupdate.Controls.Add(Me.Setting_ckupdate)
        Me.Panel_chkupdate.Controls.Add(Me.Icon_chkupdate)
        Me.Panel_chkupdate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_chkupdate.Location = New System.Drawing.Point(327, 38)
        Me.Panel_chkupdate.Name = "Panel_chkupdate"
        Me.Panel_chkupdate.Size = New System.Drawing.Size(34, 34)
        Me.Panel_chkupdate.TabIndex = 13
        Me.Panel_chkupdate.Visible = False
        '
        'Setting_ckupdate
        '
        Me.Setting_ckupdate.AutoSize = True
        Me.Setting_ckupdate.Location = New System.Drawing.Point(0, 20)
        Me.Setting_ckupdate.Name = "Setting_ckupdate"
        Me.Setting_ckupdate.Size = New System.Drawing.Size(15, 14)
        Me.Setting_ckupdate.TabIndex = 6
        Me.Setting_ckupdate.UseVisualStyleBackColor = True
        Me.Setting_ckupdate.Visible = False
        '
        'Icon_chkupdate
        '
        Me.Icon_chkupdate.BackColor = System.Drawing.Color.Transparent
        Me.Icon_chkupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_chkupdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_chkupdate.Enabled = False
        Me.Icon_chkupdate.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bnoupdate
        Me.Icon_chkupdate.Location = New System.Drawing.Point(0, 0)
        Me.Icon_chkupdate.Name = "Icon_chkupdate"
        Me.Icon_chkupdate.Size = New System.Drawing.Size(34, 34)
        Me.Icon_chkupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_chkupdate.TabIndex = 2
        Me.Icon_chkupdate.TabStop = False
        '
        'Panel_filepath
        '
        Me.Panel_filepath.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_filepath.Controls.Add(Me.Setting_filepath)
        Me.Panel_filepath.Controls.Add(Me.Icon_filepath)
        Me.Panel_filepath.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_filepath.Location = New System.Drawing.Point(290, 38)
        Me.Panel_filepath.Name = "Panel_filepath"
        Me.Panel_filepath.Size = New System.Drawing.Size(34, 34)
        Me.Panel_filepath.TabIndex = 12
        Me.Panel_filepath.Visible = False
        '
        'Setting_filepath
        '
        Me.Setting_filepath.AutoSize = True
        Me.Setting_filepath.Location = New System.Drawing.Point(0, 20)
        Me.Setting_filepath.Name = "Setting_filepath"
        Me.Setting_filepath.Size = New System.Drawing.Size(15, 14)
        Me.Setting_filepath.TabIndex = 6
        Me.Setting_filepath.UseVisualStyleBackColor = True
        Me.Setting_filepath.Visible = False
        '
        'Icon_filepath
        '
        Me.Icon_filepath.BackColor = System.Drawing.Color.Transparent
        Me.Icon_filepath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_filepath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_filepath.Enabled = False
        Me.Icon_filepath.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bfilepath
        Me.Icon_filepath.Location = New System.Drawing.Point(0, 0)
        Me.Icon_filepath.Name = "Icon_filepath"
        Me.Icon_filepath.Size = New System.Drawing.Size(34, 34)
        Me.Icon_filepath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_filepath.TabIndex = 2
        Me.Icon_filepath.TabStop = False
        '
        'Panel_hiddenthings
        '
        Me.Panel_hiddenthings.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_hiddenthings.Controls.Add(Me.Setting_hidden)
        Me.Panel_hiddenthings.Controls.Add(Me.Icon_hiddenthings)
        Me.Panel_hiddenthings.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_hiddenthings.Location = New System.Drawing.Point(253, 38)
        Me.Panel_hiddenthings.Name = "Panel_hiddenthings"
        Me.Panel_hiddenthings.Size = New System.Drawing.Size(34, 34)
        Me.Panel_hiddenthings.TabIndex = 11
        Me.Panel_hiddenthings.Visible = False
        '
        'Setting_hidden
        '
        Me.Setting_hidden.AutoSize = True
        Me.Setting_hidden.Location = New System.Drawing.Point(0, 20)
        Me.Setting_hidden.Name = "Setting_hidden"
        Me.Setting_hidden.Size = New System.Drawing.Size(15, 14)
        Me.Setting_hidden.TabIndex = 6
        Me.Setting_hidden.UseVisualStyleBackColor = True
        Me.Setting_hidden.Visible = False
        '
        'Icon_hiddenthings
        '
        Me.Icon_hiddenthings.BackColor = System.Drawing.Color.Transparent
        Me.Icon_hiddenthings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_hiddenthings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_hiddenthings.Enabled = False
        Me.Icon_hiddenthings.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bhidden
        Me.Icon_hiddenthings.Location = New System.Drawing.Point(0, 0)
        Me.Icon_hiddenthings.Name = "Icon_hiddenthings"
        Me.Icon_hiddenthings.Size = New System.Drawing.Size(34, 34)
        Me.Icon_hiddenthings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_hiddenthings.TabIndex = 2
        Me.Icon_hiddenthings.TabStop = False
        '
        'Panel_bgmusic
        '
        Me.Panel_bgmusic.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_bgmusic.Controls.Add(Me.Select_music)
        Me.Panel_bgmusic.Controls.Add(Me.Setting_music)
        Me.Panel_bgmusic.Controls.Add(Me.Icon_bgmusic)
        Me.Panel_bgmusic.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_bgmusic.Location = New System.Drawing.Point(216, 38)
        Me.Panel_bgmusic.Name = "Panel_bgmusic"
        Me.Panel_bgmusic.Size = New System.Drawing.Size(34, 34)
        Me.Panel_bgmusic.TabIndex = 10
        Me.Panel_bgmusic.Visible = False
        '
        'Select_music
        '
        Me.Select_music.BackColor = System.Drawing.Color.White
        Me.Select_music.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_music.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_music.FormattingEnabled = True
        Me.Select_music.Items.AddRange(New Object() {"1", "2", "3"})
        Me.Select_music.Location = New System.Drawing.Point(2, 11)
        Me.Select_music.Name = "Select_music"
        Me.Select_music.Size = New System.Drawing.Size(31, 21)
        Me.Select_music.TabIndex = 17
        Me.Select_music.Visible = False
        '
        'Setting_music
        '
        Me.Setting_music.AutoSize = True
        Me.Setting_music.Location = New System.Drawing.Point(0, 0)
        Me.Setting_music.Name = "Setting_music"
        Me.Setting_music.Size = New System.Drawing.Size(15, 14)
        Me.Setting_music.TabIndex = 16
        Me.Setting_music.UseVisualStyleBackColor = True
        Me.Setting_music.Visible = False
        '
        'Icon_bgmusic
        '
        Me.Icon_bgmusic.BackColor = System.Drawing.Color.Transparent
        Me.Icon_bgmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_bgmusic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_bgmusic.Enabled = False
        Me.Icon_bgmusic.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bgmusic
        Me.Icon_bgmusic.Location = New System.Drawing.Point(0, 0)
        Me.Icon_bgmusic.Name = "Icon_bgmusic"
        Me.Icon_bgmusic.Size = New System.Drawing.Size(34, 34)
        Me.Icon_bgmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_bgmusic.TabIndex = 2
        Me.Icon_bgmusic.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_largex4
        Me.Panel2.Controls.Add(Me.Filever_text)
        Me.Panel2.Controls.Add(Me.Title_filever)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel2.Location = New System.Drawing.Point(78, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 34)
        Me.Panel2.TabIndex = 9
        Me.Panel2.Visible = False
        '
        'Filever_text
        '
        Me.Filever_text.BackColor = System.Drawing.Color.Transparent
        Me.Filever_text.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Filever_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filever_text.Location = New System.Drawing.Point(101, 0)
        Me.Filever_text.Name = "Filever_text"
        Me.Filever_text.Size = New System.Drawing.Size(34, 34)
        Me.Filever_text.TabIndex = 1
        Me.Filever_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Title_filever
        '
        Me.Title_filever.BackColor = System.Drawing.Color.Transparent
        Me.Title_filever.Cursor = System.Windows.Forms.Cursors.Default
        Me.Title_filever.Location = New System.Drawing.Point(3, 0)
        Me.Title_filever.Name = "Title_filever"
        Me.Title_filever.Size = New System.Drawing.Size(100, 34)
        Me.Title_filever.TabIndex = 0
        Me.Title_filever.Text = "Save file region :"
        Me.Title_filever.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_menu_opensave
        '
        Me.Panel_menu_opensave.BackColor = System.Drawing.Color.Transparent
        Me.Panel_menu_opensave.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_largex2
        Me.Panel_menu_opensave.Controls.Add(Me.Text_menu_save)
        Me.Panel_menu_opensave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_menu_opensave.Location = New System.Drawing.Point(6, 38)
        Me.Panel_menu_opensave.Name = "Panel_menu_opensave"
        Me.Panel_menu_opensave.Size = New System.Drawing.Size(69, 34)
        Me.Panel_menu_opensave.TabIndex = 8
        Me.Panel_menu_opensave.Visible = False
        '
        'Text_menu_save
        '
        Me.Text_menu_save.BackColor = System.Drawing.Color.Transparent
        Me.Text_menu_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_menu_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_menu_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_menu_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Text_menu_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Text_menu_save.ImageKey = "icon_menusave.png"
        Me.Text_menu_save.Location = New System.Drawing.Point(0, 0)
        Me.Text_menu_save.Name = "Text_menu_save"
        Me.Text_menu_save.Size = New System.Drawing.Size(69, 34)
        Me.Text_menu_save.TabIndex = 2
        Me.Text_menu_save.Text = "Save"
        Me.Text_menu_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Minimizebutton
        '
        Me.Minimizebutton.BackColor = System.Drawing.Color.Transparent
        Me.Minimizebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Minimizebutton.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.minimize
        Me.Minimizebutton.Location = New System.Drawing.Point(674, 0)
        Me.Minimizebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Minimizebutton.Name = "Minimizebutton"
        Me.Minimizebutton.Size = New System.Drawing.Size(45, 35)
        Me.Minimizebutton.TabIndex = 4
        Me.Minimizebutton.TabStop = False
        '
        'TLSE_title
        '
        Me.TLSE_title.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.tlse_title_ex
        Me.TLSE_title.Location = New System.Drawing.Point(90, 3)
        Me.TLSE_title.Name = "TLSE_title"
        Me.TLSE_title.Size = New System.Drawing.Size(533, 32)
        Me.TLSE_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_title.TabIndex = 3
        Me.TLSE_title.TabStop = False
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.close_tl
        Me.Closebutton.Location = New System.Drawing.Point(719, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 35)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'TLSE_logo_update
        '
        Me.TLSE_logo_update.BackColor = System.Drawing.Color.White
        Me.TLSE_logo_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLSE_logo_update.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.logo_US_update
        Me.TLSE_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo_update.Name = "TLSE_logo_update"
        Me.TLSE_logo_update.Size = New System.Drawing.Size(150, 75)
        Me.TLSE_logo_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_logo_update.TabIndex = 330
        Me.TLSE_logo_update.TabStop = False
        Me.TLSE_logo_update.Visible = False
        '
        'TLSE_logo
        '
        Me.TLSE_logo.BackColor = System.Drawing.Color.White
        Me.TLSE_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TLSE_logo.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.logo_US
        Me.TLSE_logo.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo.Name = "TLSE_logo"
        Me.TLSE_logo.Size = New System.Drawing.Size(150, 75)
        Me.TLSE_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_logo.TabIndex = 329
        Me.TLSE_logo.TabStop = False
        '
        'Select_mii
        '
        Me.Select_mii.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_mii.DisplayMember = "0"
        Me.Select_mii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_mii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_mii.FormattingEnabled = True
        Me.Select_mii.Items.AddRange(New Object() {"Unknow", "Friend", "Lover", "Ex / Ex-spouse", "Spouse / Spouse (1)", "Parent/Child", "Sibling", "Friend (in conflict)", "Lover (in conflict)", "Spouse (in conflict)", "Best friend"})
        Me.Select_mii.Location = New System.Drawing.Point(73, 41)
        Me.Select_mii.Name = "Select_mii"
        Me.Select_mii.Size = New System.Drawing.Size(150, 21)
        Me.Select_mii.TabIndex = 332
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_relamechanics
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Text_mid_2)
        Me.Panel1.Controls.Add(Me.Text_mid_1)
        Me.Panel1.Controls.Add(Me.Text_right_2)
        Me.Panel1.Controls.Add(Me.Text_left_2)
        Me.Panel1.Controls.Add(Me.Text_right_1)
        Me.Panel1.Controls.Add(Me.Text_left_1)
        Me.Panel1.Controls.Add(Me.Icon_mid)
        Me.Panel1.Controls.Add(Me.Select_mii)
        Me.Panel1.Location = New System.Drawing.Point(19, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 615)
        Me.Panel1.TabIndex = 333
        '
        'Text_mid_2
        '
        Me.Text_mid_2.BackColor = System.Drawing.Color.Transparent
        Me.Text_mid_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text_mid_2.Location = New System.Drawing.Point(373, 445)
        Me.Text_mid_2.Name = "Text_mid_2"
        Me.Text_mid_2.Size = New System.Drawing.Size(217, 125)
        Me.Text_mid_2.TabIndex = 339
        Me.Text_mid_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_mid_1
        '
        Me.Text_mid_1.BackColor = System.Drawing.Color.Transparent
        Me.Text_mid_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text_mid_1.Location = New System.Drawing.Point(373, 136)
        Me.Text_mid_1.Name = "Text_mid_1"
        Me.Text_mid_1.Size = New System.Drawing.Size(217, 125)
        Me.Text_mid_1.TabIndex = 338
        Me.Text_mid_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_right_2
        '
        Me.Text_right_2.BackColor = System.Drawing.Color.Transparent
        Me.Text_right_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text_right_2.Location = New System.Drawing.Point(632, 365)
        Me.Text_right_2.Name = "Text_right_2"
        Me.Text_right_2.Size = New System.Drawing.Size(214, 204)
        Me.Text_right_2.TabIndex = 337
        Me.Text_right_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_left_2
        '
        Me.Text_left_2.BackColor = System.Drawing.Color.Transparent
        Me.Text_left_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text_left_2.Location = New System.Drawing.Point(116, 365)
        Me.Text_left_2.Name = "Text_left_2"
        Me.Text_left_2.Size = New System.Drawing.Size(214, 204)
        Me.Text_left_2.TabIndex = 336
        Me.Text_left_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_right_1
        '
        Me.Text_right_1.BackColor = System.Drawing.Color.Transparent
        Me.Text_right_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text_right_1.Location = New System.Drawing.Point(632, 137)
        Me.Text_right_1.Name = "Text_right_1"
        Me.Text_right_1.Size = New System.Drawing.Size(214, 212)
        Me.Text_right_1.TabIndex = 335
        Me.Text_right_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_left_1
        '
        Me.Text_left_1.BackColor = System.Drawing.Color.Transparent
        Me.Text_left_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text_left_1.Location = New System.Drawing.Point(116, 137)
        Me.Text_left_1.Name = "Text_left_1"
        Me.Text_left_1.Size = New System.Drawing.Size(214, 212)
        Me.Text_left_1.TabIndex = 334
        Me.Text_left_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Icon_mid
        '
        Me.Icon_mid.Location = New System.Drawing.Point(374, 291)
        Me.Icon_mid.Name = "Icon_mid"
        Me.Icon_mid.Size = New System.Drawing.Size(217, 125)
        Me.Icon_mid.TabIndex = 333
        Me.Icon_mid.TabStop = False
        '
        'TLSE_relamechanics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_friendship
        Me.ClientSize = New System.Drawing.Size(914, 705)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TLSE_header)
        Me.Controls.Add(Me.TLSE_logo_update)
        Me.Controls.Add(Me.TLSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TLSE_relamechanics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TLSE_relamechanics"
        Me.TLSE_header.ResumeLayout(False)
        Me.TLSE_header.PerformLayout()
        Me.Panel_bspesymb.ResumeLayout(False)
        Me.Panel_bspesymb.PerformLayout()
        CType(Me.Icon_bspesymb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Advhelp.ResumeLayout(False)
        Me.Panel_Advhelp.PerformLayout()
        CType(Me.Icon_Advhelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_chkupdate.ResumeLayout(False)
        Me.Panel_chkupdate.PerformLayout()
        CType(Me.Icon_chkupdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_filepath.ResumeLayout(False)
        Me.Panel_filepath.PerformLayout()
        CType(Me.Icon_filepath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hiddenthings.ResumeLayout(False)
        Me.Panel_hiddenthings.PerformLayout()
        CType(Me.Icon_hiddenthings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_bgmusic.ResumeLayout(False)
        Me.Panel_bgmusic.PerformLayout()
        CType(Me.Icon_bgmusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_menu_opensave.ResumeLayout(False)
        CType(Me.Minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Icon_mid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLSE_header As Panel
    Friend WithEvents TLSE_filepath As TextBox
    Friend WithEvents Select_language As ComboBox
    Friend WithEvents Panel_bspesymb As Panel
    Friend WithEvents Setting_spesymb As CheckBox
    Friend WithEvents Icon_bspesymb As PictureBox
    Friend WithEvents Panel_Advhelp As Panel
    Friend WithEvents Setting_Advhelp As CheckBox
    Friend WithEvents Icon_Advhelp As PictureBox
    Friend WithEvents Panel_chkupdate As Panel
    Friend WithEvents Setting_ckupdate As CheckBox
    Friend WithEvents Icon_chkupdate As PictureBox
    Friend WithEvents Panel_filepath As Panel
    Friend WithEvents Setting_filepath As CheckBox
    Friend WithEvents Icon_filepath As PictureBox
    Friend WithEvents Panel_hiddenthings As Panel
    Friend WithEvents Setting_hidden As CheckBox
    Friend WithEvents Icon_hiddenthings As PictureBox
    Friend WithEvents Panel_bgmusic As Panel
    Friend WithEvents Select_music As ComboBox
    Friend WithEvents Setting_music As CheckBox
    Friend WithEvents Icon_bgmusic As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Filever_text As Label
    Friend WithEvents Title_filever As Label
    Friend WithEvents Panel_menu_opensave As Panel
    Friend WithEvents Text_menu_save As Label
    Friend WithEvents Minimizebutton As PictureBox
    Friend WithEvents TLSE_title As PictureBox
    Friend WithEvents Closebutton As PictureBox
    Friend WithEvents TLSE_logo_update As PictureBox
    Friend WithEvents TLSE_logo As PictureBox
    Friend WithEvents Select_mii As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Text_mid_2 As Label
    Friend WithEvents Text_mid_1 As Label
    Friend WithEvents Text_right_2 As Label
    Friend WithEvents Text_left_2 As Label
    Friend WithEvents Text_right_1 As Label
    Friend WithEvents Text_left_1 As Label
    Friend WithEvents Icon_mid As PictureBox
End Class
