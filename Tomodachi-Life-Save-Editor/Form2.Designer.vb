<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Text_fdialog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Text_fdialog
        '
        Me.Text_fdialog.BackColor = System.Drawing.Color.Transparent
        Me.Text_fdialog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_fdialog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_fdialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_fdialog.Location = New System.Drawing.Point(0, 0)
        Me.Text_fdialog.Name = "Text_fdialog"
        Me.Text_fdialog.Size = New System.Drawing.Size(295, 218)
        Me.Text_fdialog.TabIndex = 0
        Me.Text_fdialog.Text = "Tomodachi Life"
        Me.Text_fdialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.message2
        Me.ClientSize = New System.Drawing.Size(295, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.Text_fdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Text_fdialog As System.Windows.Forms.Label
End Class
