<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repairsave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Repairsave))
        Me.TLSE_logo = New System.Windows.Forms.PictureBox()
        Me.TLSE_header = New System.Windows.Forms.Panel()
        Me.TLSE_title = New System.Windows.Forms.PictureBox()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.Text_header = New System.Windows.Forms.TextBox()
        Me.Title_header = New System.Windows.Forms.Label()
        Me.Panel_menu_opensave = New System.Windows.Forms.Panel()
        Me.Text_menu_save = New System.Windows.Forms.Label()
        Me.Text_menu_open = New System.Windows.Forms.Label()
        Me.Icon_repair_header = New System.Windows.Forms.PictureBox()
        Me.Info_repair = New System.Windows.Forms.Label()
        Me.Icon_info_repair = New System.Windows.Forms.PictureBox()
        Me.PictureBox162 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Check_resetrelationship = New System.Windows.Forms.CheckBox()
        CType(Me.TLSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLSE_header.SuspendLayout()
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_menu_opensave.SuspendLayout()
        CType(Me.Icon_repair_header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_info_repair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLSE_logo
        '
        Me.TLSE_logo.BackColor = System.Drawing.Color.White
        Me.TLSE_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TLSE_logo.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.logo_US_update
        Me.TLSE_logo.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo.Name = "TLSE_logo"
        Me.TLSE_logo.Size = New System.Drawing.Size(66, 60)
        Me.TLSE_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_logo.TabIndex = 27
        Me.TLSE_logo.TabStop = False
        '
        'TLSE_header
        '
        Me.TLSE_header.BackColor = System.Drawing.Color.White
        Me.TLSE_header.Controls.Add(Me.TLSE_title)
        Me.TLSE_header.Controls.Add(Me.Closebutton)
        Me.TLSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.TLSE_header.Location = New System.Drawing.Point(65, 0)
        Me.TLSE_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TLSE_header.Name = "TLSE_header"
        Me.TLSE_header.Size = New System.Drawing.Size(440, 30)
        Me.TLSE_header.TabIndex = 26
        '
        'TLSE_title
        '
        Me.TLSE_title.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.TLSE_title
        Me.TLSE_title.Location = New System.Drawing.Point(9, 8)
        Me.TLSE_title.Name = "TLSE_title"
        Me.TLSE_title.Size = New System.Drawing.Size(380, 15)
        Me.TLSE_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_title.TabIndex = 3
        Me.TLSE_title.TabStop = False
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.close
        Me.Closebutton.Location = New System.Drawing.Point(395, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'Text_header
        '
        Me.Text_header.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_header.Location = New System.Drawing.Point(91, 130)
        Me.Text_header.Name = "Text_header"
        Me.Text_header.ReadOnly = True
        Me.Text_header.Size = New System.Drawing.Size(254, 13)
        Me.Text_header.TabIndex = 28
        Me.Text_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Title_header
        '
        Me.Title_header.BackColor = System.Drawing.Color.Transparent
        Me.Title_header.Location = New System.Drawing.Point(90, 115)
        Me.Title_header.Name = "Title_header"
        Me.Title_header.Size = New System.Drawing.Size(257, 13)
        Me.Title_header.TabIndex = 29
        Me.Title_header.Text = "Header"
        Me.Title_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_menu_opensave
        '
        Me.Panel_menu_opensave.BackColor = System.Drawing.Color.Transparent
        Me.Panel_menu_opensave.BackgroundImage = CType(resources.GetObject("Panel_menu_opensave.BackgroundImage"), System.Drawing.Image)
        Me.Panel_menu_opensave.Controls.Add(Me.Text_menu_save)
        Me.Panel_menu_opensave.Controls.Add(Me.Text_menu_open)
        Me.Panel_menu_opensave.Location = New System.Drawing.Point(67, 35)
        Me.Panel_menu_opensave.Name = "Panel_menu_opensave"
        Me.Panel_menu_opensave.Size = New System.Drawing.Size(68, 25)
        Me.Panel_menu_opensave.TabIndex = 30
        '
        'Text_menu_save
        '
        Me.Text_menu_save.BackColor = System.Drawing.Color.Transparent
        Me.Text_menu_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_menu_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_menu_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_menu_save.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Text_menu_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Text_menu_save.Location = New System.Drawing.Point(0, 0)
        Me.Text_menu_save.Name = "Text_menu_save"
        Me.Text_menu_save.Size = New System.Drawing.Size(68, 25)
        Me.Text_menu_save.TabIndex = 1
        Me.Text_menu_save.Text = "Save"
        Me.Text_menu_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Text_menu_save.Visible = False
        '
        'Text_menu_open
        '
        Me.Text_menu_open.BackColor = System.Drawing.Color.Transparent
        Me.Text_menu_open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_menu_open.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_menu_open.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_menu_open.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Text_menu_open.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Text_menu_open.Location = New System.Drawing.Point(0, 0)
        Me.Text_menu_open.Name = "Text_menu_open"
        Me.Text_menu_open.Size = New System.Drawing.Size(68, 25)
        Me.Text_menu_open.TabIndex = 0
        Me.Text_menu_open.Text = "Open"
        Me.Text_menu_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Icon_repair_header
        '
        Me.Icon_repair_header.BackColor = System.Drawing.Color.Transparent
        Me.Icon_repair_header.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_repair_header.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.repair_somethingwrong
        Me.Icon_repair_header.Location = New System.Drawing.Point(351, 73)
        Me.Icon_repair_header.Name = "Icon_repair_header"
        Me.Icon_repair_header.Size = New System.Drawing.Size(63, 70)
        Me.Icon_repair_header.TabIndex = 31
        Me.Icon_repair_header.TabStop = False
        '
        'Info_repair
        '
        Me.Info_repair.AutoSize = True
        Me.Info_repair.BackColor = System.Drawing.Color.Transparent
        Me.Info_repair.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_repair.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_repair.ForeColor = System.Drawing.Color.Blue
        Me.Info_repair.Location = New System.Drawing.Point(479, 35)
        Me.Info_repair.Name = "Info_repair"
        Me.Info_repair.Size = New System.Drawing.Size(14, 20)
        Me.Info_repair.TabIndex = 192
        Me.Info_repair.Text = "i"
        '
        'Icon_info_repair
        '
        Me.Icon_info_repair.BackColor = System.Drawing.Color.Transparent
        Me.Icon_info_repair.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.tomo_bg
        Me.Icon_info_repair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Icon_info_repair.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.info_repair
        Me.Icon_info_repair.Location = New System.Drawing.Point(330, 39)
        Me.Icon_info_repair.Name = "Icon_info_repair"
        Me.Icon_info_repair.Size = New System.Drawing.Size(143, 85)
        Me.Icon_info_repair.TabIndex = 193
        Me.Icon_info_repair.TabStop = False
        Me.Icon_info_repair.Visible = False
        '
        'PictureBox162
        '
        Me.PictureBox162.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox162.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox162.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox162.Location = New System.Drawing.Point(420, 121)
        Me.PictureBox162.Name = "PictureBox162"
        Me.PictureBox162.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox162.TabIndex = 194
        Me.PictureBox162.TabStop = False
        Me.PictureBox162.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox1.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox1.Location = New System.Drawing.Point(141, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 195
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Check_resetrelationship
        '
        Me.Check_resetrelationship.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_resetrelationship.AutoSize = True
        Me.Check_resetrelationship.BackColor = System.Drawing.Color.White
        Me.Check_resetrelationship.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check_resetrelationship.FlatAppearance.BorderSize = 0
        Me.Check_resetrelationship.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.Check_resetrelationship.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Check_resetrelationship.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Check_resetrelationship.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check_resetrelationship.Location = New System.Drawing.Point(12, 192)
        Me.Check_resetrelationship.Name = "Check_resetrelationship"
        Me.Check_resetrelationship.Size = New System.Drawing.Size(198, 23)
        Me.Check_resetrelationship.TabIndex = 196
        Me.Check_resetrelationship.Text = "Reset all items, friendlist, Mii apartment"
        Me.Check_resetrelationship.UseVisualStyleBackColor = False
        '
        'Repairsave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_panel
        Me.ClientSize = New System.Drawing.Size(505, 449)
        Me.Controls.Add(Me.Check_resetrelationship)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox162)
        Me.Controls.Add(Me.Icon_info_repair)
        Me.Controls.Add(Me.Info_repair)
        Me.Controls.Add(Me.Icon_repair_header)
        Me.Controls.Add(Me.Panel_menu_opensave)
        Me.Controls.Add(Me.Title_header)
        Me.Controls.Add(Me.Text_header)
        Me.Controls.Add(Me.TLSE_logo)
        Me.Controls.Add(Me.TLSE_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Repairsave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repairsave"
        CType(Me.TLSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLSE_header.ResumeLayout(False)
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_menu_opensave.ResumeLayout(False)
        CType(Me.Icon_repair_header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_info_repair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TLSE_logo As System.Windows.Forms.PictureBox
    Friend WithEvents TLSE_header As System.Windows.Forms.Panel
    Friend WithEvents TLSE_title As System.Windows.Forms.PictureBox
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Text_header As System.Windows.Forms.TextBox
    Friend WithEvents Title_header As System.Windows.Forms.Label
    Friend WithEvents Panel_menu_opensave As System.Windows.Forms.Panel
    Friend WithEvents Text_menu_save As System.Windows.Forms.Label
    Friend WithEvents Text_menu_open As System.Windows.Forms.Label
    Friend WithEvents Icon_repair_header As System.Windows.Forms.PictureBox
    Friend WithEvents Info_repair As System.Windows.Forms.Label
    Friend WithEvents Icon_info_repair As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox162 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Check_resetrelationship As System.Windows.Forms.CheckBox
End Class
