<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.Icon_loading = New System.Windows.Forms.PictureBox()
        Me.Text_loading = New System.Windows.Forms.Label()
        CType(Me.Icon_loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Icon_loading
        '
        Me.Icon_loading.BackColor = System.Drawing.Color.Transparent
        Me.Icon_loading.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.logo_US
        Me.Icon_loading.Location = New System.Drawing.Point(84, 67)
        Me.Icon_loading.Name = "Icon_loading"
        Me.Icon_loading.Size = New System.Drawing.Size(117, 100)
        Me.Icon_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Icon_loading.TabIndex = 3
        Me.Icon_loading.TabStop = False
        '
        'Text_loading
        '
        Me.Text_loading.BackColor = System.Drawing.SystemColors.Info
        Me.Text_loading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_loading.Location = New System.Drawing.Point(76, 170)
        Me.Text_loading.Name = "Text_loading"
        Me.Text_loading.Size = New System.Drawing.Size(133, 23)
        Me.Text_loading.TabIndex = 4
        Me.Text_loading.Text = "Loading resources ..."
        Me.Text_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.Icon_loading)
        Me.Controls.Add(Me.Text_loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.Icon_loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Icon_loading As System.Windows.Forms.PictureBox
    Friend WithEvents Text_loading As System.Windows.Forms.Label
End Class
