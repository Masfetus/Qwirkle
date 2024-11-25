<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlateauJeu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlateauJeu))
        Me.pnl_plateau = New System.Windows.Forms.Panel()
        Me.pnl_playerround = New System.Windows.Forms.Panel()
        Me.lbl_nextplayer = New System.Windows.Forms.Label()
        Me.lbl_nextround = New System.Windows.Forms.Label()
        Me.lbl_currentplayer = New System.Windows.Forms.Label()
        Me.lbl_currentround = New System.Windows.Forms.Label()
        Me.pnl_playerscores = New System.Windows.Forms.Panel()
        Me.lbl_player4 = New System.Windows.Forms.Label()
        Me.lbl_player3 = New System.Windows.Forms.Label()
        Me.lbl_player2 = New System.Windows.Forms.Label()
        Me.lbl_player1 = New System.Windows.Forms.Label()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.lbl_pioche = New System.Windows.Forms.Label()
        Me.btn_giveup = New System.Windows.Forms.Button()
        Me.btn_valid = New System.Windows.Forms.Button()
        Me.pic_tuilepioche = New System.Windows.Forms.PictureBox()
        Me.pic_pioche = New System.Windows.Forms.PictureBox()
        Me.pic_main6 = New System.Windows.Forms.PictureBox()
        Me.pic_main5 = New System.Windows.Forms.PictureBox()
        Me.pic_main4 = New System.Windows.Forms.PictureBox()
        Me.pic_main3 = New System.Windows.Forms.PictureBox()
        Me.pic_main2 = New System.Windows.Forms.PictureBox()
        Me.pic_main1 = New System.Windows.Forms.PictureBox()
        Me.lbl_round = New System.Windows.Forms.Label()
        Me.PicMenuPlateau = New System.Windows.Forms.PictureBox()
        Me.pnl_playerround.SuspendLayout()
        Me.pnl_playerscores.SuspendLayout()
        Me.pnl_main.SuspendLayout()
        CType(Me.pic_tuilepioche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_pioche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_main1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMenuPlateau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_plateau
        '
        resources.ApplyResources(Me.pnl_plateau, "pnl_plateau")
        Me.pnl_plateau.BackColor = System.Drawing.Color.Transparent
        Me.pnl_plateau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_plateau.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnl_plateau.Name = "pnl_plateau"
        '
        'pnl_playerround
        '
        resources.ApplyResources(Me.pnl_playerround, "pnl_playerround")
        Me.pnl_playerround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_playerround.Controls.Add(Me.lbl_nextplayer)
        Me.pnl_playerround.Controls.Add(Me.lbl_nextround)
        Me.pnl_playerround.Controls.Add(Me.lbl_currentplayer)
        Me.pnl_playerround.Controls.Add(Me.lbl_currentround)
        Me.pnl_playerround.Name = "pnl_playerround"
        '
        'lbl_nextplayer
        '
        resources.ApplyResources(Me.lbl_nextplayer, "lbl_nextplayer")
        Me.lbl_nextplayer.Name = "lbl_nextplayer"
        '
        'lbl_nextround
        '
        resources.ApplyResources(Me.lbl_nextround, "lbl_nextround")
        Me.lbl_nextround.Name = "lbl_nextround"
        '
        'lbl_currentplayer
        '
        resources.ApplyResources(Me.lbl_currentplayer, "lbl_currentplayer")
        Me.lbl_currentplayer.Name = "lbl_currentplayer"
        '
        'lbl_currentround
        '
        resources.ApplyResources(Me.lbl_currentround, "lbl_currentround")
        Me.lbl_currentround.Name = "lbl_currentround"
        '
        'pnl_playerscores
        '
        resources.ApplyResources(Me.pnl_playerscores, "pnl_playerscores")
        Me.pnl_playerscores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_playerscores.Controls.Add(Me.lbl_player4)
        Me.pnl_playerscores.Controls.Add(Me.lbl_player3)
        Me.pnl_playerscores.Controls.Add(Me.lbl_player2)
        Me.pnl_playerscores.Controls.Add(Me.lbl_player1)
        Me.pnl_playerscores.Name = "pnl_playerscores"
        '
        'lbl_player4
        '
        resources.ApplyResources(Me.lbl_player4, "lbl_player4")
        Me.lbl_player4.Name = "lbl_player4"
        '
        'lbl_player3
        '
        resources.ApplyResources(Me.lbl_player3, "lbl_player3")
        Me.lbl_player3.Name = "lbl_player3"
        '
        'lbl_player2
        '
        resources.ApplyResources(Me.lbl_player2, "lbl_player2")
        Me.lbl_player2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_player2.Name = "lbl_player2"
        '
        'lbl_player1
        '
        resources.ApplyResources(Me.lbl_player1, "lbl_player1")
        Me.lbl_player1.Name = "lbl_player1"
        '
        'pnl_main
        '
        resources.ApplyResources(Me.pnl_main, "pnl_main")
        Me.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_main.Controls.Add(Me.pic_main6)
        Me.pnl_main.Controls.Add(Me.pic_main5)
        Me.pnl_main.Controls.Add(Me.pic_main4)
        Me.pnl_main.Controls.Add(Me.pic_main3)
        Me.pnl_main.Controls.Add(Me.pic_main2)
        Me.pnl_main.Controls.Add(Me.pic_main1)
        Me.pnl_main.Name = "pnl_main"
        '
        'lbl_pioche
        '
        resources.ApplyResources(Me.lbl_pioche, "lbl_pioche")
        Me.lbl_pioche.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pioche.Name = "lbl_pioche"
        '
        'btn_giveup
        '
        resources.ApplyResources(Me.btn_giveup, "btn_giveup")
        Me.btn_giveup.BackColor = System.Drawing.Color.Firebrick
        Me.btn_giveup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_giveup.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_giveup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btn_giveup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btn_giveup.ForeColor = System.Drawing.Color.OldLace
        Me.btn_giveup.Name = "btn_giveup"
        Me.btn_giveup.UseVisualStyleBackColor = False
        '
        'btn_valid
        '
        resources.ApplyResources(Me.btn_valid, "btn_valid")
        Me.btn_valid.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_valid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_valid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_valid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.btn_valid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btn_valid.ForeColor = System.Drawing.Color.OldLace
        Me.btn_valid.Name = "btn_valid"
        Me.btn_valid.UseVisualStyleBackColor = False
        '
        'pic_tuilepioche
        '
        resources.ApplyResources(Me.pic_tuilepioche, "pic_tuilepioche")
        Me.pic_tuilepioche.Name = "pic_tuilepioche"
        Me.pic_tuilepioche.TabStop = False
        '
        'pic_pioche
        '
        resources.ApplyResources(Me.pic_pioche, "pic_pioche")
        Me.pic_pioche.BackColor = System.Drawing.Color.Transparent
        Me.pic_pioche.BackgroundImage = Global.Qwirkle.My.Resources.Resources.ImgPioche2
        Me.pic_pioche.Name = "pic_pioche"
        Me.pic_pioche.TabStop = False
        '
        'pic_main6
        '
        resources.ApplyResources(Me.pic_main6, "pic_main6")
        Me.pic_main6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_main6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_main6.Name = "pic_main6"
        Me.pic_main6.TabStop = False
        '
        'pic_main5
        '
        resources.ApplyResources(Me.pic_main5, "pic_main5")
        Me.pic_main5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_main5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_main5.Name = "pic_main5"
        Me.pic_main5.TabStop = False
        '
        'pic_main4
        '
        resources.ApplyResources(Me.pic_main4, "pic_main4")
        Me.pic_main4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_main4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_main4.Name = "pic_main4"
        Me.pic_main4.TabStop = False
        '
        'pic_main3
        '
        resources.ApplyResources(Me.pic_main3, "pic_main3")
        Me.pic_main3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_main3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_main3.Name = "pic_main3"
        Me.pic_main3.TabStop = False
        '
        'pic_main2
        '
        resources.ApplyResources(Me.pic_main2, "pic_main2")
        Me.pic_main2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_main2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_main2.Name = "pic_main2"
        Me.pic_main2.TabStop = False
        '
        'pic_main1
        '
        resources.ApplyResources(Me.pic_main1, "pic_main1")
        Me.pic_main1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_main1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_main1.Name = "pic_main1"
        Me.pic_main1.TabStop = False
        '
        'lbl_round
        '
        resources.ApplyResources(Me.lbl_round, "lbl_round")
        Me.lbl_round.BackColor = System.Drawing.Color.Transparent
        Me.lbl_round.ForeColor = System.Drawing.Color.Black
        Me.lbl_round.Image = Global.Qwirkle.My.Resources.Resources.FontMenuPlateau1
        Me.lbl_round.Name = "lbl_round"
        '
        'PicMenuPlateau
        '
        resources.ApplyResources(Me.PicMenuPlateau, "PicMenuPlateau")
        Me.PicMenuPlateau.BackColor = System.Drawing.Color.Transparent
        Me.PicMenuPlateau.BackgroundImage = Global.Qwirkle.My.Resources.Resources.PicMenuPlateau
        Me.PicMenuPlateau.Name = "PicMenuPlateau"
        Me.PicMenuPlateau.TabStop = False
        '
        'PlateauJeu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pic_tuilepioche)
        Me.Controls.Add(Me.lbl_pioche)
        Me.Controls.Add(Me.pic_pioche)
        Me.Controls.Add(Me.btn_giveup)
        Me.Controls.Add(Me.btn_valid)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.pnl_playerscores)
        Me.Controls.Add(Me.pnl_playerround)
        Me.Controls.Add(Me.lbl_round)
        Me.Controls.Add(Me.pnl_plateau)
        Me.Controls.Add(Me.PicMenuPlateau)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PlateauJeu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_playerround.ResumeLayout(False)
        Me.pnl_playerround.PerformLayout()
        Me.pnl_playerscores.ResumeLayout(False)
        Me.pnl_playerscores.PerformLayout()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.pic_tuilepioche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_pioche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_main1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMenuPlateau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl_plateau As Panel
    Friend WithEvents pic_main5 As PictureBox
    Friend WithEvents pic_main4 As PictureBox
    Friend WithEvents pic_main3 As PictureBox
    Friend WithEvents pic_main2 As PictureBox
    Friend WithEvents pic_main1 As PictureBox
    Friend WithEvents lbl_nextplayer As Label
    Friend WithEvents lbl_nextround As Label
    Friend WithEvents lbl_currentplayer As Label
    Friend WithEvents lbl_currentround As Label
    Friend WithEvents lbl_player4 As Label
    Friend WithEvents lbl_player3 As Label
    Friend WithEvents lbl_player2 As Label
    Friend WithEvents lbl_player1 As Label
    Friend WithEvents pic_main6 As PictureBox
    Friend WithEvents lbl_round As Label
    Friend WithEvents pnl_playerround As Panel
    Friend WithEvents pnl_playerscores As Panel
    Friend WithEvents pnl_main As Panel
    Friend WithEvents btn_valid As Button
    Friend WithEvents btn_giveup As Button
    Friend WithEvents lbl_pioche As Label
    Friend WithEvents pic_tuilepioche As PictureBox
    Friend WithEvents pic_pioche As PictureBox
    Friend WithEvents PicMenuPlateau As PictureBox
End Class
