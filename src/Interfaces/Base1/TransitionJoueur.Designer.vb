<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransitionJoueur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransitionJoueur))
        Me.lbl_tourDe = New System.Windows.Forms.Label()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.btnTransitionJoueur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_tourDe
        '
        Me.lbl_tourDe.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tourDe.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tourDe.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_tourDe.Location = New System.Drawing.Point(97, 67)
        Me.lbl_tourDe.Name = "lbl_tourDe"
        Me.lbl_tourDe.Size = New System.Drawing.Size(427, 136)
        Me.lbl_tourDe.TabIndex = 0
        Me.lbl_tourDe.Text = "Au tour de "
        Me.lbl_tourDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_instruction.Location = New System.Drawing.Point(193, 220)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(224, 27)
        Me.lbl_instruction.TabIndex = 1
        Me.lbl_instruction.Text = "Passez lui l'appareil"
        '
        'btnTransitionJoueur
        '
        Me.btnTransitionJoueur.BackColor = System.Drawing.Color.Transparent
        Me.btnTransitionJoueur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransitionJoueur.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransitionJoueur.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnTransitionJoueur.Image = Global.Qwirkle.My.Resources.Resources.BtnTransition
        Me.btnTransitionJoueur.Location = New System.Drawing.Point(15, 350)
        Me.btnTransitionJoueur.Name = "btnTransitionJoueur"
        Me.btnTransitionJoueur.Size = New System.Drawing.Size(590, 50)
        Me.btnTransitionJoueur.TabIndex = 2
        Me.btnTransitionJoueur.Text = "Je suis "
        Me.btnTransitionJoueur.UseVisualStyleBackColor = False
        '
        'TransitionJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BgChangementJoueur
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 440)
        Me.Controls.Add(Me.btnTransitionJoueur)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.lbl_tourDe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransitionJoueur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle - Jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_tourDe As Label
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents btnTransitionJoueur As Button
End Class
