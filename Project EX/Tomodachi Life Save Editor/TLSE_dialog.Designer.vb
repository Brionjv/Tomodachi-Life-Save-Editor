<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TLSE_dialog
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
        Me.valu_pandialogpos = New System.Windows.Forms.NumericUpDown()
        Me.Panel_tlse = New System.Windows.Forms.Panel()
        Me.Icon_reference_panel = New System.Windows.Forms.PictureBox()
        Me.Icon_reference = New System.Windows.Forms.PictureBox()
        Me.Panel_dialog = New System.Windows.Forms.Panel()
        Me.Text_TLSE_dialog = New System.Windows.Forms.Label()
        Me.Panel_Cancel = New System.Windows.Forms.Panel()
        Me.Cancel_Button = New System.Windows.Forms.Label()
        Me.Panel_OK = New System.Windows.Forms.Panel()
        Me.OK_Button = New System.Windows.Forms.Label()
        CType(Me.valu_pandialogpos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_tlse.SuspendLayout()
        CType(Me.Icon_reference_panel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_reference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_dialog.SuspendLayout()
        Me.Panel_Cancel.SuspendLayout()
        Me.Panel_OK.SuspendLayout()
        Me.SuspendLayout()
        '
        'valu_pandialogpos
        '
        Me.valu_pandialogpos.Location = New System.Drawing.Point(12, 588)
        Me.valu_pandialogpos.Name = "valu_pandialogpos"
        Me.valu_pandialogpos.Size = New System.Drawing.Size(80, 20)
        Me.valu_pandialogpos.TabIndex = 99
        Me.valu_pandialogpos.Visible = False
        '
        'Panel_tlse
        '
        Me.Panel_tlse.BackColor = System.Drawing.Color.Transparent
        Me.Panel_tlse.Controls.Add(Me.Icon_reference_panel)
        Me.Panel_tlse.Location = New System.Drawing.Point(106, 33)
        Me.Panel_tlse.Name = "Panel_tlse"
        Me.Panel_tlse.Size = New System.Drawing.Size(676, 540)
        Me.Panel_tlse.TabIndex = 98
        '
        'Icon_reference_panel
        '
        Me.Icon_reference_panel.BackColor = System.Drawing.Color.Transparent
        Me.Icon_reference_panel.Location = New System.Drawing.Point(18, 17)
        Me.Icon_reference_panel.Name = "Icon_reference_panel"
        Me.Icon_reference_panel.Size = New System.Drawing.Size(54, 50)
        Me.Icon_reference_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Icon_reference_panel.TabIndex = 8
        Me.Icon_reference_panel.TabStop = False
        Me.Icon_reference_panel.Visible = False
        '
        'Icon_reference
        '
        Me.Icon_reference.BackColor = System.Drawing.Color.Transparent
        Me.Icon_reference.Location = New System.Drawing.Point(38, 50)
        Me.Icon_reference.Name = "Icon_reference"
        Me.Icon_reference.Size = New System.Drawing.Size(54, 50)
        Me.Icon_reference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Icon_reference.TabIndex = 97
        Me.Icon_reference.TabStop = False
        Me.Icon_reference.Visible = False
        '
        'Panel_dialog
        '
        Me.Panel_dialog.BackColor = System.Drawing.Color.Transparent
        Me.Panel_dialog.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_dialog
        Me.Panel_dialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_dialog.Controls.Add(Me.Text_TLSE_dialog)
        Me.Panel_dialog.Controls.Add(Me.Panel_Cancel)
        Me.Panel_dialog.Controls.Add(Me.Panel_OK)
        Me.Panel_dialog.Location = New System.Drawing.Point(190, 124)
        Me.Panel_dialog.Name = "Panel_dialog"
        Me.Panel_dialog.Size = New System.Drawing.Size(435, 315)
        Me.Panel_dialog.TabIndex = 96
        '
        'Text_TLSE_dialog
        '
        Me.Text_TLSE_dialog.BackColor = System.Drawing.Color.Transparent
        Me.Text_TLSE_dialog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_TLSE_dialog.Dock = System.Windows.Forms.DockStyle.Top
        Me.Text_TLSE_dialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_TLSE_dialog.Location = New System.Drawing.Point(0, 0)
        Me.Text_TLSE_dialog.Name = "Text_TLSE_dialog"
        Me.Text_TLSE_dialog.Size = New System.Drawing.Size(435, 271)
        Me.Text_TLSE_dialog.TabIndex = 1
        Me.Text_TLSE_dialog.Text = "Tomodachi Life"
        Me.Text_TLSE_dialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Cancel
        '
        Me.Panel_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Cancel.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_buttons_large
        Me.Panel_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Cancel.Controls.Add(Me.Cancel_Button)
        Me.Panel_Cancel.Location = New System.Drawing.Point(266, 274)
        Me.Panel_Cancel.Name = "Panel_Cancel"
        Me.Panel_Cancel.Size = New System.Drawing.Size(80, 23)
        Me.Panel_Cancel.TabIndex = 3
        Me.Panel_Cancel.Visible = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(0, 0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(80, 23)
        Me.Cancel_Button.TabIndex = 0
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_OK
        '
        Me.Panel_OK.BackColor = System.Drawing.Color.Transparent
        Me.Panel_OK.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_buttons_large
        Me.Panel_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_OK.Controls.Add(Me.OK_Button)
        Me.Panel_OK.Location = New System.Drawing.Point(89, 274)
        Me.Panel_OK.Name = "Panel_OK"
        Me.Panel_OK.Size = New System.Drawing.Size(80, 23)
        Me.Panel_OK.TabIndex = 2
        Me.Panel_OK.Visible = False
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(0, 0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(80, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TLSE_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 654)
        Me.Controls.Add(Me.valu_pandialogpos)
        Me.Controls.Add(Me.Icon_reference)
        Me.Controls.Add(Me.Panel_dialog)
        Me.Controls.Add(Me.Panel_tlse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TLSE_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TLSE_dialog"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.valu_pandialogpos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_tlse.ResumeLayout(False)
        Me.Panel_tlse.PerformLayout()
        CType(Me.Icon_reference_panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_reference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_dialog.ResumeLayout(False)
        Me.Panel_Cancel.ResumeLayout(False)
        Me.Panel_OK.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents valu_pandialogpos As NumericUpDown
    Friend WithEvents Icon_reference As PictureBox
    Friend WithEvents Panel_dialog As Panel
    Friend WithEvents Text_TLSE_dialog As Label
    Friend WithEvents Panel_Cancel As Panel
    Friend WithEvents Cancel_Button As Label
    Friend WithEvents Panel_OK As Panel
    Friend WithEvents OK_Button As Label
    Friend WithEvents Panel_tlse As Panel
    Friend WithEvents Icon_reference_panel As PictureBox
End Class
