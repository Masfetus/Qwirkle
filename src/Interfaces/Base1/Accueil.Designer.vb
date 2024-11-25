<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.BtnJouer = New System.Windows.Forms.Button()
        Me.BtnRegle = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCredits = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnJouer
        '
        Me.BtnJouer.BackColor = System.Drawing.Color.Transparent
        Me.BtnJouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnJouer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnJouer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnJouer.Font = New System.Drawing.Font("Ravie", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJouer.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnJouer.Image = Global.Qwirkle.My.Resources.Resources.BtnJouerImg
        Me.BtnJouer.Location = New System.Drawing.Point(215, 195)
        Me.BtnJouer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnJouer.Name = "BtnJouer"
        Me.BtnJouer.Size = New System.Drawing.Size(135, 70)
        Me.BtnJouer.TabIndex = 0
        Me.BtnJouer.Text = "Jouer"
        Me.BtnJouer.UseVisualStyleBackColor = False
        '
        'BtnRegle
        '
        Me.BtnRegle.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRegle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnRegle.Font = New System.Drawing.Font("Ravie", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnRegle.Image = Global.Qwirkle.My.Resources.Resources.BtnSecondaireAccueil
        Me.BtnRegle.Location = New System.Drawing.Point(206, 289)
        Me.BtnRegle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegle.Name = "BtnRegle"
        Me.BtnRegle.Size = New System.Drawing.Size(149, 36)
        Me.BtnRegle.TabIndex = 5
        Me.BtnRegle.Text = "Règles du jeu"
        Me.BtnRegle.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Qwirkle.My.Resources.Resources.Qwirkle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(546, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnCredits
        '
        Me.BtnCredits.BackColor = System.Drawing.Color.Transparent
        Me.BtnCredits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnCredits.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCredits.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCredits.Image = Global.Qwirkle.My.Resources.Resources.BtnSecondaireAccueil
        Me.BtnCredits.Location = New System.Drawing.Point(217, 330)
        Me.BtnCredits.Name = "BtnCredits"
        Me.BtnCredits.Size = New System.Drawing.Size(130, 36)
        Me.BtnCredits.TabIndex = 7
        Me.BtnCredits.Text = "Crédits"
        Me.BtnCredits.UseVisualStyleBackColor = False
        '
        'BtnQuitter
        '
        Me.BtnQuitter.BackColor = System.Drawing.Color.Transparent
        Me.BtnQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnQuitter.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnQuitter.Image = Global.Qwirkle.My.Resources.Resources.BtnSecondaireAccueil
        Me.BtnQuitter.Location = New System.Drawing.Point(217, 372)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(130, 36)
        Me.BtnQuitter.TabIndex = 8
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BgAccueil2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnCredits)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnRegle)
        Me.Controls.Add(Me.BtnJouer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnJouer As Button
    Friend WithEvents BtnRegle As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCredits As Button
    Friend WithEvents BtnQuitter As Button
End Class
