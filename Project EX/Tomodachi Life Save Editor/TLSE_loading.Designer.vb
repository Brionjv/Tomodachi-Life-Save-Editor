<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TLSE_loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TLSE_loading))
        Me.TLSE_loading_starttext = New System.Windows.Forms.Label()
        Me.TLSE_loading_logo = New System.Windows.Forms.PictureBox()
        CType(Me.TLSE_loading_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLSE_loading_starttext
        '
        Me.TLSE_loading_starttext.AutoSize = True
        Me.TLSE_loading_starttext.Location = New System.Drawing.Point(121, 170)
        Me.TLSE_loading_starttext.Name = "TLSE_loading_starttext"
        Me.TLSE_loading_starttext.Size = New System.Drawing.Size(186, 13)
        Me.TLSE_loading_starttext.TabIndex = 0
        Me.TLSE_loading_starttext.Text = "Starting Tomodachi Life Save Editor..."
        '
        'TLSE_loading_logo
        '
        Me.TLSE_loading_logo.BackColor = System.Drawing.Color.Transparent
        Me.TLSE_loading_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_loading_logo.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.TLSE_loading_logo.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.logo_US
        Me.TLSE_loading_logo.Location = New System.Drawing.Point(100, 65)
        Me.TLSE_loading_logo.Name = "TLSE_loading_logo"
        Me.TLSE_loading_logo.Size = New System.Drawing.Size(225, 102)
        Me.TLSE_loading_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TLSE_loading_logo.TabIndex = 29
        Me.TLSE_loading_logo.TabStop = False
        Me.TLSE_loading_logo.UseWaitCursor = True
        '
        'TLSE_loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 274)
        Me.Controls.Add(Me.TLSE_loading_logo)
        Me.Controls.Add(Me.TLSE_loading_starttext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TLSE_loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.TLSE_loading_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TLSE_loading_starttext As Label
    Friend WithEvents TLSE_loading_logo As PictureBox
End Class
