<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChoixNomJoueurs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnValidNomJoueurs = New System.Windows.Forms.Button()
        Me.BtnRetourChoixNomJoueur = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlJoueur = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BtnValidNomJoueurs
        '
        Me.BtnValidNomJoueurs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnValidNomJoueurs.Location = New System.Drawing.Point(144, 377)
        Me.BtnValidNomJoueurs.Name = "BtnValidNomJoueurs"
        Me.BtnValidNomJoueurs.Size = New System.Drawing.Size(130, 48)
        Me.BtnValidNomJoueurs.TabIndex = 4
        Me.BtnValidNomJoueurs.Text = "Valider"
        Me.BtnValidNomJoueurs.UseVisualStyleBackColor = True
        '
        'BtnRetourChoixNomJoueur
        '
        Me.BtnRetourChoixNomJoueur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRetourChoixNomJoueur.Location = New System.Drawing.Point(289, 377)
        Me.BtnRetourChoixNomJoueur.Name = "BtnRetourChoixNomJoueur"
        Me.BtnRetourChoixNomJoueur.Size = New System.Drawing.Size(130, 48)
        Me.BtnRetourChoixNomJoueur.TabIndex = 9
        Me.BtnRetourChoixNomJoueur.Text = "Retour"
        Me.BtnRetourChoixNomJoueur.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(112, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(362, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Choix du nom des joueurs"
        '
        'pnlJoueur
        '
        Me.pnlJoueur.BackColor = System.Drawing.Color.Transparent
        Me.pnlJoueur.Location = New System.Drawing.Point(126, 134)
        Me.pnlJoueur.Name = "pnlJoueur"
        Me.pnlJoueur.Size = New System.Drawing.Size(324, 216)
        Me.pnlJoueur.TabIndex = 11
        '
        'ChoixNomJoueurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BgChoixNomJoueur2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlJoueur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnRetourChoixNomJoueur)
        Me.Controls.Add(Me.BtnValidNomJoueurs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChoixNomJoueurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChoixNomJoueurs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnValidNomJoueurs As Button
    Friend WithEvents BtnRetourChoixNomJoueur As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlJoueur As Panel
End Class
