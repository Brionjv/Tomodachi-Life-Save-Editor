<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manual))
        Me.TLSE_header = New System.Windows.Forms.Panel()
        Me.TLSE_title = New System.Windows.Forms.PictureBox()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Info_image = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Info_islandbuild = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TLSE_header.SuspendLayout()
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Info_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLSE_header
        '
        Me.TLSE_header.BackColor = System.Drawing.Color.White
        Me.TLSE_header.Controls.Add(Me.TLSE_title)
        Me.TLSE_header.Controls.Add(Me.Closebutton)
        Me.TLSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.TLSE_header.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TLSE_header.Name = "TLSE_header"
        Me.TLSE_header.Size = New System.Drawing.Size(730, 30)
        Me.TLSE_header.TabIndex = 2
        '
        'TLSE_title
        '
        Me.TLSE_title.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.TLSE_title
        Me.TLSE_title.Location = New System.Drawing.Point(146, 6)
        Me.TLSE_title.Name = "TLSE_title"
        Me.TLSE_title.Size = New System.Drawing.Size(438, 19)
        Me.TLSE_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_title.TabIndex = 3
        Me.TLSE_title.TabStop = False
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.close
        Me.Closebutton.Location = New System.Drawing.Point(685, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_panel
        Me.Panel1.Controls.Add(Me.Info_image)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 612)
        Me.Panel1.TabIndex = 3
        '
        'Info_image
        '
        Me.Info_image.BackColor = System.Drawing.Color.Transparent
        Me.Info_image.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_menu
        Me.Info_image.Image = CType(resources.GetObject("Info_image.Image"), System.Drawing.Image)
        Me.Info_image.Location = New System.Drawing.Point(1, 371)
        Me.Info_image.Name = "Info_image"
        Me.Info_image.Size = New System.Drawing.Size(400, 240)
        Me.Info_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Info_image.TabIndex = 5
        Me.Info_image.TabStop = False
        Me.Info_image.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_mii_status
        Me.Panel3.Controls.Add(Me.Info_islandbuild)
        Me.Panel3.Controls.Add(Me.CheckBox5)
        Me.Panel3.Controls.Add(Me.CheckBox4)
        Me.Panel3.Controls.Add(Me.CheckBox3)
        Me.Panel3.Controls.Add(Me.CheckBox2)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Location = New System.Drawing.Point(187, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(535, 601)
        Me.Panel3.TabIndex = 1
        '
        'Info_islandbuild
        '
        Me.Info_islandbuild.AutoSize = True
        Me.Info_islandbuild.BackColor = System.Drawing.Color.Transparent
        Me.Info_islandbuild.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_islandbuild.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_islandbuild.ForeColor = System.Drawing.Color.Blue
        Me.Info_islandbuild.Location = New System.Drawing.Point(6, 7)
        Me.Info_islandbuild.Name = "Info_islandbuild"
        Me.Info_islandbuild.Size = New System.Drawing.Size(14, 20)
        Me.Info_islandbuild.TabIndex = 50
        Me.Info_islandbuild.Text = "i"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox5.Location = New System.Drawing.Point(26, 113)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(175, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Make a ""Backup"" folder in case"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Location = New System.Drawing.Point(26, 77)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(203, 30)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Select ""New"" if you don't have folders" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press A and confirme with A"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Location = New System.Drawing.Point(26, 54)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(117, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Select ""Save Data"""
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Location = New System.Drawing.Point(26, 31)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(274, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Select ""Titles"", and select your Tomodachi Life game"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(26, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(206, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "To your 3ds, launch JK's Save Manger"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_menu
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 601)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Extract your save file (with JK's save manager)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.tomo_bg
        Me.ClientSize = New System.Drawing.Size(730, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TLSE_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual"
        Me.TLSE_header.ResumeLayout(False)
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Info_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLSE_header As System.Windows.Forms.Panel
    Friend WithEvents TLSE_title As System.Windows.Forms.PictureBox
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Info_image As System.Windows.Forms.PictureBox
    Friend WithEvents Info_islandbuild As System.Windows.Forms.Label
End Class
