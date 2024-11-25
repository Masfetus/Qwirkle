<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Classement))
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnRetourMenu = New System.Windows.Forms.Button()
        Me.btnRejouer = New System.Windows.Forms.Button()
        Me.pnlClassement = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Underline)
        Me.lblTitre.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitre.Location = New System.Drawing.Point(279, 66)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(278, 55)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Classement"
        '
        'btnRetourMenu
        '
        Me.btnRetourMenu.AutoSize = True
        Me.btnRetourMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnRetourMenu.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BtnSecondaireAccueil1
        Me.btnRetourMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRetourMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetourMenu.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRetourMenu.Location = New System.Drawing.Point(45, 450)
        Me.btnRetourMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRetourMenu.Name = "btnRetourMenu"
        Me.btnRetourMenu.Size = New System.Drawing.Size(340, 48)
        Me.btnRetourMenu.TabIndex = 27
        Me.btnRetourMenu.Text = "Retour au Menu"
        Me.btnRetourMenu.UseVisualStyleBackColor = False
        '
        'btnRejouer
        '
        Me.btnRejouer.AutoSize = True
        Me.btnRejouer.BackColor = System.Drawing.Color.Transparent
        Me.btnRejouer.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BtnSecondaireAccueil1
        Me.btnRejouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRejouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRejouer.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRejouer.Location = New System.Drawing.Point(408, 450)
        Me.btnRejouer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRejouer.Name = "btnRejouer"
        Me.btnRejouer.Size = New System.Drawing.Size(380, 48)
        Me.btnRejouer.TabIndex = 28
        Me.btnRejouer.Text = "Relancer une partie"
        Me.btnRejouer.UseVisualStyleBackColor = False
        '
        'pnlClassement
        '
        Me.pnlClassement.BackColor = System.Drawing.Color.Transparent
        Me.pnlClassement.Location = New System.Drawing.Point(215, 160)
        Me.pnlClassement.Name = "pnlClassement"
        Me.pnlClassement.Size = New System.Drawing.Size(400, 250)
        Me.pnlClassement.TabIndex = 30
        '
        'Classement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BgChangementJoueur
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 560)
        Me.Controls.Add(Me.pnlClassement)
        Me.Controls.Add(Me.btnRejouer)
        Me.Controls.Add(Me.btnRetourMenu)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Classement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents btnRetourMenu As Button
    Friend WithEvents btnRejouer As Button
    Friend WithEvents pnlClassement As Panel
End Class
