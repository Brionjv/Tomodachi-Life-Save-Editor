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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Text_restoresave = New System.Windows.Forms.Label()
        Me.Text_HtuTLSEold = New System.Windows.Forms.Label()
        Me.Text_extractsave = New System.Windows.Forms.Label()
        Me.Panel_extractsave = New System.Windows.Forms.Panel()
        Me.Info_extractsave_6 = New System.Windows.Forms.Label()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.Info_extractsave_5 = New System.Windows.Forms.Label()
        Me.Info_extractsave_4 = New System.Windows.Forms.Label()
        Me.Info_extractsave_3 = New System.Windows.Forms.Label()
        Me.Info_extractsave_2 = New System.Windows.Forms.Label()
        Me.Info_extractsave_1 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel_restoresave = New System.Windows.Forms.Panel()
        Me.Info_restoresave_5 = New System.Windows.Forms.Label()
        Me.Info_restoresave_4 = New System.Windows.Forms.Label()
        Me.Info_restoresave_3 = New System.Windows.Forms.Label()
        Me.Info_restoresave_2 = New System.Windows.Forms.Label()
        Me.Info_restoresave_1 = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.TLSE_header.SuspendLayout()
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Info_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel_extractsave.SuspendLayout()
        Me.Panel_restoresave.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel_extractsave)
        Me.Panel1.Controls.Add(Me.Panel_restoresave)
        Me.Panel1.Location = New System.Drawing.Point(1, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 612)
        Me.Panel1.TabIndex = 3
        '
        'Info_image
        '
        Me.Info_image.BackColor = System.Drawing.Color.Transparent
        Me.Info_image.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_menu
        Me.Info_image.Location = New System.Drawing.Point(1, 371)
        Me.Info_image.Name = "Info_image"
        Me.Info_image.Size = New System.Drawing.Size(400, 240)
        Me.Info_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Info_image.TabIndex = 5
        Me.Info_image.TabStop = False
        Me.Info_image.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_menu
        Me.Panel2.Controls.Add(Me.Text_restoresave)
        Me.Panel2.Controls.Add(Me.Text_HtuTLSEold)
        Me.Panel2.Controls.Add(Me.Text_extractsave)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 601)
        Me.Panel2.TabIndex = 0
        '
        'Text_restoresave
        '
        Me.Text_restoresave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_restoresave.Location = New System.Drawing.Point(3, 47)
        Me.Text_restoresave.Name = "Text_restoresave"
        Me.Text_restoresave.Size = New System.Drawing.Size(170, 31)
        Me.Text_restoresave.TabIndex = 2
        Me.Text_restoresave.Text = "Restore your save file (with JK's save manager)"
        Me.Text_restoresave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_HtuTLSEold
        '
        Me.Text_HtuTLSEold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_HtuTLSEold.Location = New System.Drawing.Point(3, 94)
        Me.Text_HtuTLSEold.Name = "Text_HtuTLSEold"
        Me.Text_HtuTLSEold.Size = New System.Drawing.Size(170, 31)
        Me.Text_HtuTLSEold.TabIndex = 1
        Me.Text_HtuTLSEold.Text = "How to use Tomodachi Life Save Editor (older versions)"
        Me.Text_HtuTLSEold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_extractsave
        '
        Me.Text_extractsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_extractsave.Location = New System.Drawing.Point(3, 8)
        Me.Text_extractsave.Name = "Text_extractsave"
        Me.Text_extractsave.Size = New System.Drawing.Size(170, 31)
        Me.Text_extractsave.TabIndex = 0
        Me.Text_extractsave.Text = "Extract your save file (with JK's save manager)"
        Me.Text_extractsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_extractsave
        '
        Me.Panel_extractsave.BackColor = System.Drawing.Color.Transparent
        Me.Panel_extractsave.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_mii_status
        Me.Panel_extractsave.Controls.Add(Me.Info_extractsave_6)
        Me.Panel_extractsave.Controls.Add(Me.CheckBox6)
        Me.Panel_extractsave.Controls.Add(Me.Info_extractsave_5)
        Me.Panel_extractsave.Controls.Add(Me.Info_extractsave_4)
        Me.Panel_extractsave.Controls.Add(Me.Info_extractsave_3)
        Me.Panel_extractsave.Controls.Add(Me.Info_extractsave_2)
        Me.Panel_extractsave.Controls.Add(Me.Info_extractsave_1)
        Me.Panel_extractsave.Controls.Add(Me.CheckBox5)
        Me.Panel_extractsave.Controls.Add(Me.CheckBox4)
        Me.Panel_extractsave.Controls.Add(Me.CheckBox3)
        Me.Panel_extractsave.Controls.Add(Me.CheckBox2)
        Me.Panel_extractsave.Controls.Add(Me.CheckBox1)
        Me.Panel_extractsave.Location = New System.Drawing.Point(187, 6)
        Me.Panel_extractsave.Name = "Panel_extractsave"
        Me.Panel_extractsave.Size = New System.Drawing.Size(535, 601)
        Me.Panel_extractsave.TabIndex = 1
        Me.Panel_extractsave.Visible = False
        '
        'Info_extractsave_6
        '
        Me.Info_extractsave_6.AutoSize = True
        Me.Info_extractsave_6.BackColor = System.Drawing.Color.Transparent
        Me.Info_extractsave_6.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_extractsave_6.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_extractsave_6.ForeColor = System.Drawing.Color.Blue
        Me.Info_extractsave_6.Location = New System.Drawing.Point(6, 135)
        Me.Info_extractsave_6.Name = "Info_extractsave_6"
        Me.Info_extractsave_6.Size = New System.Drawing.Size(14, 20)
        Me.Info_extractsave_6.TabIndex = 56
        Me.Info_extractsave_6.Text = "i"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox6.Location = New System.Drawing.Point(26, 136)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(175, 17)
        Me.CheckBox6.TabIndex = 55
        Me.CheckBox6.Text = "Make a ""Backup"" folder in case"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'Info_extractsave_5
        '
        Me.Info_extractsave_5.AutoSize = True
        Me.Info_extractsave_5.BackColor = System.Drawing.Color.Transparent
        Me.Info_extractsave_5.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_extractsave_5.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_extractsave_5.ForeColor = System.Drawing.Color.Blue
        Me.Info_extractsave_5.Location = New System.Drawing.Point(6, 105)
        Me.Info_extractsave_5.Name = "Info_extractsave_5"
        Me.Info_extractsave_5.Size = New System.Drawing.Size(14, 20)
        Me.Info_extractsave_5.TabIndex = 54
        Me.Info_extractsave_5.Text = "i"
        '
        'Info_extractsave_4
        '
        Me.Info_extractsave_4.AutoSize = True
        Me.Info_extractsave_4.BackColor = System.Drawing.Color.Transparent
        Me.Info_extractsave_4.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_extractsave_4.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_extractsave_4.ForeColor = System.Drawing.Color.Blue
        Me.Info_extractsave_4.Location = New System.Drawing.Point(6, 76)
        Me.Info_extractsave_4.Name = "Info_extractsave_4"
        Me.Info_extractsave_4.Size = New System.Drawing.Size(14, 20)
        Me.Info_extractsave_4.TabIndex = 53
        Me.Info_extractsave_4.Text = "i"
        '
        'Info_extractsave_3
        '
        Me.Info_extractsave_3.AutoSize = True
        Me.Info_extractsave_3.BackColor = System.Drawing.Color.Transparent
        Me.Info_extractsave_3.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_extractsave_3.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_extractsave_3.ForeColor = System.Drawing.Color.Blue
        Me.Info_extractsave_3.Location = New System.Drawing.Point(6, 53)
        Me.Info_extractsave_3.Name = "Info_extractsave_3"
        Me.Info_extractsave_3.Size = New System.Drawing.Size(14, 20)
        Me.Info_extractsave_3.TabIndex = 52
        Me.Info_extractsave_3.Text = "i"
        '
        'Info_extractsave_2
        '
        Me.Info_extractsave_2.AutoSize = True
        Me.Info_extractsave_2.BackColor = System.Drawing.Color.Transparent
        Me.Info_extractsave_2.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_extractsave_2.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_extractsave_2.ForeColor = System.Drawing.Color.Blue
        Me.Info_extractsave_2.Location = New System.Drawing.Point(6, 30)
        Me.Info_extractsave_2.Name = "Info_extractsave_2"
        Me.Info_extractsave_2.Size = New System.Drawing.Size(14, 20)
        Me.Info_extractsave_2.TabIndex = 51
        Me.Info_extractsave_2.Text = "i"
        '
        'Info_extractsave_1
        '
        Me.Info_extractsave_1.AutoSize = True
        Me.Info_extractsave_1.BackColor = System.Drawing.Color.Transparent
        Me.Info_extractsave_1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_extractsave_1.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_extractsave_1.ForeColor = System.Drawing.Color.Blue
        Me.Info_extractsave_1.Location = New System.Drawing.Point(6, 7)
        Me.Info_extractsave_1.Name = "Info_extractsave_1"
        Me.Info_extractsave_1.Size = New System.Drawing.Size(14, 20)
        Me.Info_extractsave_1.TabIndex = 50
        Me.Info_extractsave_1.Text = "i"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox5.Location = New System.Drawing.Point(26, 100)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(203, 30)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Select ""New"" if you don't have folders" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press A and confirme with A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Location = New System.Drawing.Point(26, 77)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(117, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Select ""Save Data"""
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Location = New System.Drawing.Point(26, 54)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(181, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Select your Tomodachi Life game"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Location = New System.Drawing.Point(26, 31)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Select ""Titles"""
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
        'Panel_restoresave
        '
        Me.Panel_restoresave.BackColor = System.Drawing.Color.Transparent
        Me.Panel_restoresave.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_mii_status
        Me.Panel_restoresave.Controls.Add(Me.Info_restoresave_5)
        Me.Panel_restoresave.Controls.Add(Me.Info_restoresave_4)
        Me.Panel_restoresave.Controls.Add(Me.Info_restoresave_3)
        Me.Panel_restoresave.Controls.Add(Me.Info_restoresave_2)
        Me.Panel_restoresave.Controls.Add(Me.Info_restoresave_1)
        Me.Panel_restoresave.Controls.Add(Me.CheckBox8)
        Me.Panel_restoresave.Controls.Add(Me.CheckBox9)
        Me.Panel_restoresave.Controls.Add(Me.CheckBox10)
        Me.Panel_restoresave.Controls.Add(Me.CheckBox11)
        Me.Panel_restoresave.Controls.Add(Me.CheckBox12)
        Me.Panel_restoresave.Location = New System.Drawing.Point(187, 6)
        Me.Panel_restoresave.Name = "Panel_restoresave"
        Me.Panel_restoresave.Size = New System.Drawing.Size(535, 601)
        Me.Panel_restoresave.TabIndex = 6
        Me.Panel_restoresave.Visible = False
        '
        'Info_restoresave_5
        '
        Me.Info_restoresave_5.AutoSize = True
        Me.Info_restoresave_5.BackColor = System.Drawing.Color.Transparent
        Me.Info_restoresave_5.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_restoresave_5.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_restoresave_5.ForeColor = System.Drawing.Color.Blue
        Me.Info_restoresave_5.Location = New System.Drawing.Point(6, 105)
        Me.Info_restoresave_5.Name = "Info_restoresave_5"
        Me.Info_restoresave_5.Size = New System.Drawing.Size(14, 20)
        Me.Info_restoresave_5.TabIndex = 54
        Me.Info_restoresave_5.Text = "i"
        '
        'Info_restoresave_4
        '
        Me.Info_restoresave_4.AutoSize = True
        Me.Info_restoresave_4.BackColor = System.Drawing.Color.Transparent
        Me.Info_restoresave_4.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_restoresave_4.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_restoresave_4.ForeColor = System.Drawing.Color.Blue
        Me.Info_restoresave_4.Location = New System.Drawing.Point(6, 76)
        Me.Info_restoresave_4.Name = "Info_restoresave_4"
        Me.Info_restoresave_4.Size = New System.Drawing.Size(14, 20)
        Me.Info_restoresave_4.TabIndex = 53
        Me.Info_restoresave_4.Text = "i"
        '
        'Info_restoresave_3
        '
        Me.Info_restoresave_3.AutoSize = True
        Me.Info_restoresave_3.BackColor = System.Drawing.Color.Transparent
        Me.Info_restoresave_3.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_restoresave_3.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_restoresave_3.ForeColor = System.Drawing.Color.Blue
        Me.Info_restoresave_3.Location = New System.Drawing.Point(6, 53)
        Me.Info_restoresave_3.Name = "Info_restoresave_3"
        Me.Info_restoresave_3.Size = New System.Drawing.Size(14, 20)
        Me.Info_restoresave_3.TabIndex = 52
        Me.Info_restoresave_3.Text = "i"
        '
        'Info_restoresave_2
        '
        Me.Info_restoresave_2.AutoSize = True
        Me.Info_restoresave_2.BackColor = System.Drawing.Color.Transparent
        Me.Info_restoresave_2.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_restoresave_2.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_restoresave_2.ForeColor = System.Drawing.Color.Blue
        Me.Info_restoresave_2.Location = New System.Drawing.Point(6, 30)
        Me.Info_restoresave_2.Name = "Info_restoresave_2"
        Me.Info_restoresave_2.Size = New System.Drawing.Size(14, 20)
        Me.Info_restoresave_2.TabIndex = 51
        Me.Info_restoresave_2.Text = "i"
        '
        'Info_restoresave_1
        '
        Me.Info_restoresave_1.AutoSize = True
        Me.Info_restoresave_1.BackColor = System.Drawing.Color.Transparent
        Me.Info_restoresave_1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_restoresave_1.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_restoresave_1.ForeColor = System.Drawing.Color.Blue
        Me.Info_restoresave_1.Location = New System.Drawing.Point(6, 7)
        Me.Info_restoresave_1.Name = "Info_restoresave_1"
        Me.Info_restoresave_1.Size = New System.Drawing.Size(14, 20)
        Me.Info_restoresave_1.TabIndex = 50
        Me.Info_restoresave_1.Text = "i"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox8.Location = New System.Drawing.Point(26, 100)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(155, 30)
        Me.CheckBox8.TabIndex = 4
        Me.CheckBox8.Text = "Select your folder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Y and confirme with A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox9.Location = New System.Drawing.Point(26, 77)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(117, 17)
        Me.CheckBox9.TabIndex = 3
        Me.CheckBox9.Text = "Select ""Save Data"""
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox10.Location = New System.Drawing.Point(26, 54)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(181, 17)
        Me.CheckBox10.TabIndex = 2
        Me.CheckBox10.Text = "Select your Tomodachi Life game"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox11.Location = New System.Drawing.Point(26, 31)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox11.TabIndex = 1
        Me.CheckBox11.Text = "Select ""Titles"""
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox12.Location = New System.Drawing.Point(26, 8)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(206, 17)
        Me.CheckBox12.TabIndex = 0
        Me.CheckBox12.Text = "To your 3ds, launch JK's Save Manger"
        Me.CheckBox12.UseVisualStyleBackColor = True
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel_extractsave.ResumeLayout(False)
        Me.Panel_extractsave.PerformLayout()
        Me.Panel_restoresave.ResumeLayout(False)
        Me.Panel_restoresave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLSE_header As System.Windows.Forms.Panel
    Friend WithEvents TLSE_title As System.Windows.Forms.PictureBox
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_extractsave As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Text_extractsave As System.Windows.Forms.Label
    Friend WithEvents Info_image As System.Windows.Forms.PictureBox
    Friend WithEvents Info_extractsave_1 As System.Windows.Forms.Label
    Friend WithEvents Info_extractsave_5 As System.Windows.Forms.Label
    Friend WithEvents Info_extractsave_4 As System.Windows.Forms.Label
    Friend WithEvents Info_extractsave_3 As System.Windows.Forms.Label
    Friend WithEvents Info_extractsave_2 As System.Windows.Forms.Label
    Friend WithEvents Info_extractsave_6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents Text_HtuTLSEold As System.Windows.Forms.Label
    Friend WithEvents Text_restoresave As System.Windows.Forms.Label
    Friend WithEvents Panel_restoresave As System.Windows.Forms.Panel
    Friend WithEvents Info_restoresave_5 As System.Windows.Forms.Label
    Friend WithEvents Info_restoresave_4 As System.Windows.Forms.Label
    Friend WithEvents Info_restoresave_3 As System.Windows.Forms.Label
    Friend WithEvents Info_restoresave_2 As System.Windows.Forms.Label
    Friend WithEvents Info_restoresave_1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
End Class
