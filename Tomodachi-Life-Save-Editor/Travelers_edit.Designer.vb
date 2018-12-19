<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Travelers_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Travelers_edit))
        Me.valu_level = New System.Windows.Forms.NumericUpDown()
        Me.Text_level = New System.Windows.Forms.Label()
        Me.Select_travelers = New System.Windows.Forms.ComboBox()
        Me.valu_happiness2 = New System.Windows.Forms.NumericUpDown()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Title_gratitude = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Title_happiness = New System.Windows.Forms.Label()
        Me.Icon_happiness = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Text_home = New System.Windows.Forms.Label()
        Me.Title_home = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Text_region = New System.Windows.Forms.Label()
        Me.Title_region = New System.Windows.Forms.Label()
        Me.Icon_travelers = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Text_travelers = New System.Windows.Forms.Label()
        Me.Button_save = New System.Windows.Forms.Panel()
        Me.Text_save = New System.Windows.Forms.Label()
        Me.Icon_return = New System.Windows.Forms.PictureBox()
        Me.valu_happiness = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox162 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.valu_level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valu_happiness2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Icon_happiness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Icon_travelers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Button_save.SuspendLayout()
        CType(Me.Icon_return, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valu_happiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'valu_level
        '
        Me.valu_level.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_level.Location = New System.Drawing.Point(293, 80)
        Me.valu_level.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.valu_level.Name = "valu_level"
        Me.valu_level.Size = New System.Drawing.Size(33, 16)
        Me.valu_level.TabIndex = 79
        '
        'Text_level
        '
        Me.Text_level.AutoSize = True
        Me.Text_level.BackColor = System.Drawing.Color.Transparent
        Me.Text_level.Location = New System.Drawing.Point(265, 81)
        Me.Text_level.Name = "Text_level"
        Me.Text_level.Size = New System.Drawing.Size(22, 13)
        Me.Text_level.TabIndex = 75
        Me.Text_level.Text = "Lv."
        '
        'Select_travelers
        '
        Me.Select_travelers.BackColor = System.Drawing.Color.White
        Me.Select_travelers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_travelers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_travelers.FormattingEnabled = True
        Me.Select_travelers.Items.AddRange(New Object() {"Mii 1", "Mii 2", "Mii 3", "Mii 4", "Mii 5", "Mii 6", "Mii 7", "Mii 8", "Mii 9", "Mii 10"})
        Me.Select_travelers.Location = New System.Drawing.Point(65, 119)
        Me.Select_travelers.Name = "Select_travelers"
        Me.Select_travelers.Size = New System.Drawing.Size(80, 21)
        Me.Select_travelers.TabIndex = 70
        '
        'valu_happiness2
        '
        Me.valu_happiness2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_happiness2.Location = New System.Drawing.Point(197, 82)
        Me.valu_happiness2.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.valu_happiness2.Name = "valu_happiness2"
        Me.valu_happiness2.Size = New System.Drawing.Size(33, 16)
        Me.valu_happiness2.TabIndex = 80
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.Controls.Add(Me.Title_gratitude)
        Me.Panel6.Location = New System.Drawing.Point(262, 64)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(118, 14)
        Me.Panel6.TabIndex = 78
        '
        'Title_gratitude
        '
        Me.Title_gratitude.AutoSize = True
        Me.Title_gratitude.BackColor = System.Drawing.Color.Transparent
        Me.Title_gratitude.ForeColor = System.Drawing.Color.White
        Me.Title_gratitude.Location = New System.Drawing.Point(3, 0)
        Me.Title_gratitude.Name = "Title_gratitude"
        Me.Title_gratitude.Size = New System.Drawing.Size(50, 13)
        Me.Title_gratitude.TabIndex = 1
        Me.Title_gratitude.Text = "Gratitude"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.Controls.Add(Me.Title_happiness)
        Me.Panel5.Location = New System.Drawing.Point(55, 64)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(118, 14)
        Me.Panel5.TabIndex = 77
        '
        'Title_happiness
        '
        Me.Title_happiness.AutoSize = True
        Me.Title_happiness.BackColor = System.Drawing.Color.Transparent
        Me.Title_happiness.ForeColor = System.Drawing.Color.White
        Me.Title_happiness.Location = New System.Drawing.Point(2, 0)
        Me.Title_happiness.Name = "Title_happiness"
        Me.Title_happiness.Size = New System.Drawing.Size(57, 13)
        Me.Title_happiness.TabIndex = 0
        Me.Title_happiness.Text = "Happiness"
        '
        'Icon_happiness
        '
        Me.Icon_happiness.BackColor = System.Drawing.Color.Transparent
        Me.Icon_happiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_happiness.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.exp0
        Me.Icon_happiness.Location = New System.Drawing.Point(55, 79)
        Me.Icon_happiness.Name = "Icon_happiness"
        Me.Icon_happiness.Size = New System.Drawing.Size(160, 22)
        Me.Icon_happiness.TabIndex = 74
        Me.Icon_happiness.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Text_home)
        Me.Panel3.Controls.Add(Me.Title_home)
        Me.Panel3.Location = New System.Drawing.Point(167, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(208, 48)
        Me.Panel3.TabIndex = 73
        '
        'Text_home
        '
        Me.Text_home.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Text_home.Location = New System.Drawing.Point(3, 30)
        Me.Text_home.Name = "Text_home"
        Me.Text_home.Size = New System.Drawing.Size(202, 15)
        Me.Text_home.TabIndex = 2
        Me.Text_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Title_home
        '
        Me.Title_home.ForeColor = System.Drawing.Color.White
        Me.Title_home.Location = New System.Drawing.Point(3, 6)
        Me.Title_home.Name = "Title_home"
        Me.Title_home.Size = New System.Drawing.Size(202, 15)
        Me.Title_home.TabIndex = 1
        Me.Title_home.Text = "Home"
        Me.Title_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Text_region)
        Me.Panel2.Controls.Add(Me.Title_region)
        Me.Panel2.Location = New System.Drawing.Point(167, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 48)
        Me.Panel2.TabIndex = 72
        '
        'Text_region
        '
        Me.Text_region.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Text_region.Location = New System.Drawing.Point(3, 30)
        Me.Text_region.Name = "Text_region"
        Me.Text_region.Size = New System.Drawing.Size(202, 15)
        Me.Text_region.TabIndex = 1
        Me.Text_region.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Title_region
        '
        Me.Title_region.ForeColor = System.Drawing.Color.White
        Me.Title_region.Location = New System.Drawing.Point(3, 6)
        Me.Title_region.Name = "Title_region"
        Me.Title_region.Size = New System.Drawing.Size(202, 15)
        Me.Title_region.TabIndex = 0
        Me.Title_region.Text = "Region"
        Me.Title_region.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Icon_travelers
        '
        Me.Icon_travelers.BackColor = System.Drawing.Color.Transparent
        Me.Icon_travelers.Image = CType(resources.GetObject("Icon_travelers.Image"), System.Drawing.Image)
        Me.Icon_travelers.Location = New System.Drawing.Point(62, 142)
        Me.Icon_travelers.Name = "Icon_travelers"
        Me.Icon_travelers.Size = New System.Drawing.Size(86, 86)
        Me.Icon_travelers.TabIndex = 71
        Me.Icon_travelers.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.Text_travelers)
        Me.Panel4.Location = New System.Drawing.Point(55, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(325, 28)
        Me.Panel4.TabIndex = 76
        '
        'Text_travelers
        '
        Me.Text_travelers.BackColor = System.Drawing.Color.Transparent
        Me.Text_travelers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_travelers.Location = New System.Drawing.Point(0, 0)
        Me.Text_travelers.Name = "Text_travelers"
        Me.Text_travelers.Size = New System.Drawing.Size(325, 28)
        Me.Text_travelers.TabIndex = 0
        Me.Text_travelers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_save
        '
        Me.Button_save.BackColor = System.Drawing.Color.Transparent
        Me.Button_save.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_buttons_large
        Me.Button_save.Controls.Add(Me.Text_save)
        Me.Button_save.Location = New System.Drawing.Point(6, 264)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(150, 32)
        Me.Button_save.TabIndex = 82
        '
        'Text_save
        '
        Me.Text_save.BackColor = System.Drawing.Color.Transparent
        Me.Text_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_save.Location = New System.Drawing.Point(0, 0)
        Me.Text_save.Name = "Text_save"
        Me.Text_save.Size = New System.Drawing.Size(150, 32)
        Me.Text_save.TabIndex = 0
        Me.Text_save.Text = "Save"
        Me.Text_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Icon_return
        '
        Me.Icon_return.BackColor = System.Drawing.Color.Transparent
        Me.Icon_return.Image = CType(resources.GetObject("Icon_return.Image"), System.Drawing.Image)
        Me.Icon_return.Location = New System.Drawing.Point(394, 267)
        Me.Icon_return.Name = "Icon_return"
        Me.Icon_return.Size = New System.Drawing.Size(40, 30)
        Me.Icon_return.TabIndex = 81
        Me.Icon_return.TabStop = False
        '
        'valu_happiness
        '
        Me.valu_happiness.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_happiness.Location = New System.Drawing.Point(58, 81)
        Me.valu_happiness.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.valu_happiness.Name = "valu_happiness"
        Me.valu_happiness.Size = New System.Drawing.Size(33, 16)
        Me.valu_happiness.TabIndex = 83
        Me.valu_happiness.Visible = False
        '
        'PictureBox162
        '
        Me.PictureBox162.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox162.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox162.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox162.Location = New System.Drawing.Point(236, 79)
        Me.PictureBox162.Name = "PictureBox162"
        Me.PictureBox162.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox162.TabIndex = 84
        Me.PictureBox162.TabStop = False
        Me.PictureBox162.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox1.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox1.Location = New System.Drawing.Point(332, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox2.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox2.Location = New System.Drawing.Point(36, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox3.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox3.Location = New System.Drawing.Point(378, 145)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox3.TabIndex = 87
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox4.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox4.Location = New System.Drawing.Point(378, 201)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox4.TabIndex = 88
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox5.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox5.Location = New System.Drawing.Point(162, 267)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox5.TabIndex = 89
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox6.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.Icon_advhelp
        Me.PictureBox6.Location = New System.Drawing.Point(365, 264)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox6.TabIndex = 90
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'Travelers_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_travelers
        Me.ClientSize = New System.Drawing.Size(434, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox162)
        Me.Controls.Add(Me.valu_happiness)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.Icon_return)
        Me.Controls.Add(Me.valu_level)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Text_level)
        Me.Controls.Add(Me.Icon_happiness)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Icon_travelers)
        Me.Controls.Add(Me.Select_travelers)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.valu_happiness2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Travelers_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Travelers_edit"
        CType(Me.valu_level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valu_happiness2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Icon_happiness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Icon_travelers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Button_save.ResumeLayout(False)
        CType(Me.Icon_return, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valu_happiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents valu_level As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Title_gratitude As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Title_happiness As System.Windows.Forms.Label
    Friend WithEvents Text_level As System.Windows.Forms.Label
    Friend WithEvents Icon_happiness As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Text_home As System.Windows.Forms.Label
    Friend WithEvents Title_home As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Text_region As System.Windows.Forms.Label
    Friend WithEvents Title_region As System.Windows.Forms.Label
    Friend WithEvents Icon_travelers As System.Windows.Forms.PictureBox
    Friend WithEvents Select_travelers As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Text_travelers As System.Windows.Forms.Label
    Friend WithEvents valu_happiness2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button_save As System.Windows.Forms.Panel
    Friend WithEvents Text_save As System.Windows.Forms.Label
    Friend WithEvents Icon_return As System.Windows.Forms.PictureBox
    Friend WithEvents valu_happiness As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox162 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
End Class
