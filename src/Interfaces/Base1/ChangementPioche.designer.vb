<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangementPioche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangementPioche))
        Me.lbl_echange = New System.Windows.Forms.Label()
        Me.Btn_Anul = New System.Windows.Forms.Button()
        Me.Btn_Valid = New System.Windows.Forms.Button()
        Me.pic_main2 = New System.Windows.Forms.PictureBox()
        Me.pic_main4 = New System.Windows.Forms.PictureBox()
        Me.pic_main3 = New System.Windows.Forms.PictureBox()
        Me.pic_main5 = New System.Windows.Forms.PictureBox()
        CType(Me.pic_main2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_echange
        '
        Me.lbl_echange.AutoSize = True
        Me.lbl_echange.BackColor = System.Drawing.Color.Transparent
        Me.lbl_echange.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_echange.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_echange.Location = New System.Drawing.Point(107, 66)
        Me.lbl_echange.Name = "lbl_echange"
        Me.lbl_echange.Size = New System.Drawing.Size(611, 44)
        Me.lbl_echange.TabIndex = 9
        Me.lbl_echange.Text = "Sélectionner les tuiles à échanger :"
        '
        'Btn_Anul
        '
        Me.Btn_Anul.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Anul.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BtnAbandonner
        Me.Btn_Anul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Anul.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Anul.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_Anul.Location = New System.Drawing.Point(409, 350)
        Me.Btn_Anul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Anul.Name = "Btn_Anul"
        Me.Btn_Anul.Size = New System.Drawing.Size(200, 39)
        Me.Btn_Anul.TabIndex = 8
        Me.Btn_Anul.Text = "Annuler l'échange"
        Me.Btn_Anul.UseVisualStyleBackColor = False
        '
        'Btn_Valid
        '
        Me.Btn_Valid.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Valid.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BtnValider
        Me.Btn_Valid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Valid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Valid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Valid.Location = New System.Drawing.Point(203, 350)
        Me.Btn_Valid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Valid.Name = "Btn_Valid"
        Me.Btn_Valid.Size = New System.Drawing.Size(200, 39)
        Me.Btn_Valid.TabIndex = 7
        Me.Btn_Valid.Text = "Valider l'échange"
        Me.Btn_Valid.UseVisualStyleBackColor = False
        '
        'pic_main2
        '
        Me.pic_main2.Location = New System.Drawing.Point(0, 0)
        Me.pic_main2.Name = "pic_main2"
        Me.pic_main2.Size = New System.Drawing.Size(100, 50)
        Me.pic_main2.TabIndex = 0
        Me.pic_main2.TabStop = False
        '
        'pic_main4
        '
        Me.pic_main4.Location = New System.Drawing.Point(0, 0)
        Me.pic_main4.Name = "pic_main4"
        Me.pic_main4.Size = New System.Drawing.Size(100, 50)
        Me.pic_main4.TabIndex = 0
        Me.pic_main4.TabStop = False
        '
        'pic_main3
        '
        Me.pic_main3.Location = New System.Drawing.Point(0, 0)
        Me.pic_main3.Name = "pic_main3"
        Me.pic_main3.Size = New System.Drawing.Size(100, 50)
        Me.pic_main3.TabIndex = 0
        Me.pic_main3.TabStop = False
        '
        'pic_main5
        '
        Me.pic_main5.Location = New System.Drawing.Point(0, 0)
        Me.pic_main5.Name = "pic_main5"
        Me.pic_main5.Size = New System.Drawing.Size(100, 50)
        Me.pic_main5.TabIndex = 0
        Me.pic_main5.TabStop = False
        '
        'ChangementPioche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Qwirkle.My.Resources.Resources.BgChangementJoueur
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 453)
        Me.Controls.Add(Me.lbl_echange)
        Me.Controls.Add(Me.Btn_Anul)
        Me.Controls.Add(Me.Btn_Valid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ChangementPioche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle - Echange"
        CType(Me.pic_main2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Valid As Button
    Friend WithEvents Btn_Anul As Button
    Friend WithEvents lbl_echange As Label
    Friend WithEvents pic_main2 As PictureBox
    Friend WithEvents pic_main4 As PictureBox
    Friend WithEvents pic_main3 As PictureBox
    Friend WithEvents pic_main5 As PictureBox
End Class
