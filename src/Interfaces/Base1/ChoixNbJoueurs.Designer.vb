<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoixNbJoueurs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChoixNbJoueurs))
        Me.RdNbJoueur4 = New System.Windows.Forms.RadioButton()
        Me.RdNbJoueur3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnValidNbjoueur = New System.Windows.Forms.Button()
        Me.BtnRetourNbJoueur = New System.Windows.Forms.Button()
        Me.pnl_2 = New System.Windows.Forms.Panel()
        Me.pnl_3 = New System.Windows.Forms.Panel()
        Me.rb_3 = New System.Windows.Forms.RadioButton()
        Me.pnl_4 = New System.Windows.Forms.Panel()
        Me.rb_4 = New System.Windows.Forms.RadioButton()
        Me.rb_2 = New System.Windows.Forms.RadioButton()
        Me.pnl_rb = New System.Windows.Forms.Panel()
        Me.pnl_rb.SuspendLayout()
        Me.SuspendLayout()
        '
        'RdNbJoueur4
        '
        Me.RdNbJoueur4.AutoSize = True
        Me.RdNbJoueur4.BackColor = System.Drawing.Color.Transparent
        Me.RdNbJoueur4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RdNbJoueur4.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdNbJoueur4.ForeColor = System.Drawing.Color.Transparent
        Me.RdNbJoueur4.Location = New System.Drawing.Point(278, 103)
        Me.RdNbJoueur4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdNbJoueur4.Name = "RdNbJoueur4"
        Me.RdNbJoueur4.Size = New System.Drawing.Size(17, 16)
        Me.RdNbJoueur4.TabIndex = 7
        Me.RdNbJoueur4.TabStop = True
        Me.RdNbJoueur4.UseVisualStyleBackColor = False
        '
        'RdNbJoueur3
        '
        Me.RdNbJoueur3.AutoSize = True
        Me.RdNbJoueur3.BackColor = System.Drawing.Color.Transparent
        Me.RdNbJoueur3.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdNbJoueur3.Location = New System.Drawing.Point(163, 103)
        Me.RdNbJoueur3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdNbJoueur3.Name = "RdNbJoueur3"
        Me.RdNbJoueur3.Size = New System.Drawing.Size(17, 16)
        Me.RdNbJoueur3.TabIndex = 6
        Me.RdNbJoueur3.TabStop = True
        Me.RdNbJoueur3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 19.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(59, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre de joueurs"
        '
        'BtnValidNbjoueur
        '
        Me.BtnValidNbjoueur.BackColor = System.Drawing.Color.Transparent
        Me.BtnValidNbjoueur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnValidNbjoueur.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidNbjoueur.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BtnValidNbjoueur.Location = New System.Drawing.Point(85, 161)
        Me.BtnValidNbjoueur.Name = "BtnValidNbjoueur"
        Me.BtnValidNbjoueur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnValidNbjoueur.Size = New System.Drawing.Size(95, 30)
        Me.BtnValidNbjoueur.TabIndex = 9
        Me.BtnValidNbjoueur.Text = "Valider"
        Me.BtnValidNbjoueur.UseVisualStyleBackColor = False
        '
        'BtnRetourNbJoueur
        '
        Me.BtnRetourNbJoueur.BackColor = System.Drawing.Color.Transparent
        Me.BtnRetourNbJoueur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRetourNbJoueur.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRetourNbJoueur.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetourNbJoueur.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BtnRetourNbJoueur.Location = New System.Drawing.Point(186, 161)
        Me.BtnRetourNbJoueur.Name = "BtnRetourNbJoueur"
        Me.BtnRetourNbJoueur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRetourNbJoueur.Size = New System.Drawing.Size(95, 30)
        Me.BtnRetourNbJoueur.TabIndex = 10
        Me.BtnRetourNbJoueur.Text = "Retour"
        Me.BtnRetourNbJoueur.UseVisualStyleBackColor = False
        '
        'pnl_2
        '
        Me.pnl_2.BackColor = System.Drawing.Color.Transparent
        Me.pnl_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnl_2.Location = New System.Drawing.Point(35, 77)
        Me.pnl_2.Name = "pnl_2"
        Me.pnl_2.Size = New System.Drawing.Size(65, 72)
        Me.pnl_2.TabIndex = 11
        '
        'pnl_3
        '
        Me.pnl_3.BackColor = System.Drawing.Color.Transparent
        Me.pnl_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnl_3.Location = New System.Drawing.Point(129, 77)
        Me.pnl_3.Name = "pnl_3"
        Me.pnl_3.Size = New System.Drawing.Size(86, 72)
        Me.pnl_3.TabIndex = 12
        '
        'rb_3
        '
        Me.rb_3.AutoSize = True
        Me.rb_3.BackColor = System.Drawing.Color.Transparent
        Me.rb_3.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_3.Location = New System.Drawing.Point(105, 4)
        Me.rb_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_3.Name = "rb_3"
        Me.rb_3.Size = New System.Drawing.Size(17, 16)
        Me.rb_3.TabIndex = 5
        Me.rb_3.UseVisualStyleBackColor = False
        '
        'pnl_4
        '
        Me.pnl_4.BackColor = System.Drawing.Color.Transparent
        Me.pnl_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnl_4.Location = New System.Drawing.Point(254, 77)
        Me.pnl_4.Name = "pnl_4"
        Me.pnl_4.Size = New System.Drawing.Size(74, 72)
        Me.pnl_4.TabIndex = 13
        '
        'rb_4
        '
        Me.rb_4.AutoSize = True
        Me.rb_4.BackColor = System.Drawing.Color.Transparent
        Me.rb_4.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_4.Location = New System.Drawing.Point(229, 4)
        Me.rb_4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_4.Name = "rb_4"
        Me.rb_4.Size = New System.Drawing.Size(17, 16)
        Me.rb_4.TabIndex = 5
        Me.rb_4.UseVisualStyleBackColor = False
        '
        'rb_2
        '
        Me.rb_2.AutoSize = True
        Me.rb_2.BackColor = System.Drawing.Color.Transparent
        Me.rb_2.Checked = True
        Me.rb_2.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_2.Location = New System.Drawing.Point(17, 4)
        Me.rb_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_2.Name = "rb_2"
        Me.rb_2.Size = New System.Drawing.Size(17, 16)
        Me.rb_2.TabIndex = 5
        Me.rb_2.TabStop = True
        Me.rb_2.UseVisualStyleBackColor = False
        '
        'pnl_rb
        '
        Me.pnl_rb.BackColor = System.Drawing.Color.Transparent
        Me.pnl_rb.Controls.Add(Me.rb_4)
        Me.pnl_rb.Controls.Add(Me.rb_3)
        Me.pnl_rb.Controls.Add(Me.rb_2)
        Me.pnl_rb.Location = New System.Drawing.Point(35, 102)
        Me.pnl_rb.Name = "pnl_rb"
        Me.pnl_rb.Size = New System.Drawing.Size(274, 28)
        Me.pnl_rb.TabIndex = 6
        '
        'ChoixNbJoueurs
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BgChoixNbJoueur1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnRetourNbJoueur
        Me.ClientSize = New System.Drawing.Size(362, 203)
        Me.Controls.Add(Me.pnl_rb)
        Me.Controls.Add(Me.pnl_4)
        Me.Controls.Add(Me.pnl_3)
        Me.Controls.Add(Me.pnl_2)
        Me.Controls.Add(Me.BtnRetourNbJoueur)
        Me.Controls.Add(Me.BtnValidNbjoueur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RdNbJoueur4)
        Me.Controls.Add(Me.RdNbJoueur3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChoixNbJoueurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.pnl_rb.ResumeLayout(False)
        Me.pnl_rb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RdNbJoueur4 As RadioButton
    Friend WithEvents RdNbJoueur3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnValidNbjoueur As Button
    Friend WithEvents BtnRetourNbJoueur As Button
    Friend WithEvents pnl_2 As Panel
    Friend WithEvents pnl_3 As Panel
    Friend WithEvents rb_3 As RadioButton
    Friend WithEvents pnl_4 As Panel
    Friend WithEvents rb_4 As RadioButton
    Friend WithEvents rb_2 As RadioButton
    Friend WithEvents pnl_rb As Panel
End Class
