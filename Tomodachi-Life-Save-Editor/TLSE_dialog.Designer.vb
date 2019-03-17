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
        Me.Text_TLSE_dialog = New System.Windows.Forms.Label()
        Me.Panel_OK = New System.Windows.Forms.Panel()
        Me.OK_Button = New System.Windows.Forms.Label()
        Me.Panel_Cancel = New System.Windows.Forms.Panel()
        Me.Cancel_Button = New System.Windows.Forms.Label()
        Me.Panel_dialog = New System.Windows.Forms.Panel()
        Me.Icon_reference = New System.Windows.Forms.PictureBox()
        Me.Panel_OK.SuspendLayout()
        Me.Panel_Cancel.SuspendLayout()
        Me.Panel_dialog.SuspendLayout()
        CType(Me.Icon_reference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel_dialog
        '
        Me.Panel_dialog.BackColor = System.Drawing.Color.Transparent
        Me.Panel_dialog.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.message2
        Me.Panel_dialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_dialog.Controls.Add(Me.Text_TLSE_dialog)
        Me.Panel_dialog.Controls.Add(Me.Panel_Cancel)
        Me.Panel_dialog.Controls.Add(Me.Panel_OK)
        Me.Panel_dialog.Location = New System.Drawing.Point(108, 143)
        Me.Panel_dialog.Name = "Panel_dialog"
        Me.Panel_dialog.Size = New System.Drawing.Size(435, 315)
        Me.Panel_dialog.TabIndex = 4
        '
        'Icon_reference
        '
        Me.Icon_reference.BackColor = System.Drawing.Color.Transparent
        Me.Icon_reference.Location = New System.Drawing.Point(86, 36)
        Me.Icon_reference.Name = "Icon_reference"
        Me.Icon_reference.Size = New System.Drawing.Size(54, 50)
        Me.Icon_reference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Icon_reference.TabIndex = 5
        Me.Icon_reference.TabStop = False
        '
        'TLSE_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(650, 600)
        Me.Controls.Add(Me.Icon_reference)
        Me.Controls.Add(Me.Panel_dialog)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TLSE_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TLSE_dialog"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel_OK.ResumeLayout(False)
        Me.Panel_Cancel.ResumeLayout(False)
        Me.Panel_dialog.ResumeLayout(False)
        CType(Me.Icon_reference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text_TLSE_dialog As System.Windows.Forms.Label
    Friend WithEvents Panel_OK As System.Windows.Forms.Panel
    Friend WithEvents OK_Button As System.Windows.Forms.Label
    Friend WithEvents Panel_Cancel As System.Windows.Forms.Panel
    Friend WithEvents Panel_dialog As System.Windows.Forms.Panel
    Friend WithEvents Icon_reference As System.Windows.Forms.PictureBox
    Friend WithEvents Cancel_Button As System.Windows.Forms.Label

End Class
