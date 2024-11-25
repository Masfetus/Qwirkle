Imports Qwirkle

Public Class PlateauJeu
    Dim PlayerList As List(Of Joueur)
    Dim pioche As Pioche = New Pioche()
    Dim plat As List(Of List(Of Tuile)) = Plateau.getGrid()
    Dim tuile_main_dragged As String = ""
    Dim last_focus As PictureBox

    Public Function getPioche()
        Return pioche
    End Function

    Private Sub PlateauJeu_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible = True Then
            Dim indice_tuile As Integer = 0
            Dim current_player As Joueur = Nothing
            Dim tooltip As ToolTip = New ToolTip
            Dim str As String
            str = String.Format("{0} tuiles restantes dans la pioche", pioche.NbTuiles())
            tooltip.SetToolTip(pic_pioche, str)
            If Joueur.getPlayerList() Is Nothing Then
                Joueur.setPlayerList(ChoixNomJoueurs.getListPlayers())
            End If
            PlayerList = Joueur.getPlayerList()

            If Plateau.getNbTuiles() = 0 Then 'Détermination de la tuile du milieu
                Dim pic_middle As PictureBox = pnl_plateau.Controls(String.Format("pic_{0}_{1}", Int(Plateau.getNbLines() / 2), Int(Plateau.getNbColumns() / 2)))
                pic_middle.BackColor = Color.Silver
                pic_middle.AllowDrop = True
            Else ' Pour les tours ou des tuiles sont posées
                For a = 0 To Plateau.getNbLines() - 1
                    For b = 0 To Plateau.getNbColumns() - 1
                        If plat(a)(b) IsNot Nothing Then
                            Dim pic As PictureBox = pnl_plateau.Controls(String.Format("pic_{0}_{1}", a, b))
                            tile_to_pic(a, b)
                            pic.BorderStyle = BorderStyle.FixedSingle
                        End If
                    Next
                Next
            End If

            current_player = Joueur.getCurrentPlayer()

            showPlayerScore() 'Affichage du score de chaque joueur
            showPlayerCombi() 'Affichage de la combinaison du joueur
            Actualise()

            pnl_playerscores.Height = (Joueur.getNbJoueurs() * 30) 'Redimensionnement du panel d'affichage de scores

            'Affichage des noms du joueur actuel et prochain
            lbl_currentplayer.Text = current_player.getPseudo()
            Try
                lbl_nextplayer.Text = PlayerList(PlayerList.IndexOf(current_player) + 1).getPseudo()
            Catch ex As Exception
                lbl_nextplayer.Text = PlayerList(0).getPseudo()
            End Try

            current_player.play()
            lbl_round.Text = String.Format("Tour n°{0}", current_player.getRoundPlayed())
            lbl_pioche.Text = pioche.getTuiles().Count
            'Drag & drop main joueur
            For i = 1 To 6
                Dim pic As PictureBox = pnl_main.Controls("pic_main" & i)
                pic.AllowDrop = False
                AddHandler pic.MouseMove, AddressOf tuile_MouseMove
            Next
        End If
    End Sub

    Private Sub tile_to_pic(id_line, id_column)
        'Allowdrop des picture box adjacentes a la tuile posé
        Dim here As Byte
        Dim increment As New Integer
        For i = 0 To 1
            here = (i + 1) Mod 2
            For j = 0 To 1
                If j = 0 Then
                    increment = 1
                Else
                    increment = -1
                End If
                Dim picAllow As New PictureBox
                picAllow = pnl_plateau.Controls(String.Format("pic_{0}_{1}", id_line + increment * i, id_column + increment * here))
                If picAllow IsNot Nothing Then
                    If picAllow.BackgroundImage Is Nothing Then
                        picAllow.AllowDrop = True
                        picAllow.BackColor = Color.Silver
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub showPlayerScore()
        'Affichage du score de chaque joueur
        For indice_joueur = 0 To Joueur.getNbJoueurs() - 1
            Dim current_label = pnl_playerscores.Controls("lbl_player" & indice_joueur + 1)
            If PlayerList(indice_joueur) Is Joueur.getCurrentPlayer() Then 'Coloration du joueur en train de jouer
                current_label.BackColor = Color.Gainsboro
            Else
                current_label.BackColor = Color.Transparent
            End If
            current_label.Text = String.Format("{0} : {1} pt", PlayerList(indice_joueur).getPseudo(), PlayerList(indice_joueur).getScoreTot())
            current_label.Visible = True
        Next
    End Sub

    Private Sub showPlayerCombi()
        'Affichage de la combinaison du joueur dans sa main
        Dim indice_tuile As Integer = 0
        For Each tuile As Tuile In Joueur.getCurrentPlayer().getMainTuile().getTuiles()
            indice_tuile = indice_tuile + 1
            Try
                pnl_main.Controls("pic_main" & indice_tuile).BackgroundImage = My.Resources.ResourceManager.GetObject(tuile.getCouleur(0) & tuile.getForme(0))
            Catch exception As Exception
                pnl_main.Controls("pic_main" & indice_tuile).BackgroundImage = Nothing
            End Try
        Next
    End Sub

    Public Sub createPlat()
        'Création du plateau initial
        Dim pic_width As Integer = 25
        Dim pic_height As Integer = 25


        For id_line = 0 To 28
            Dim current_line = plat(id_line)
            For id_column = 0 To 28
                Dim pic_to_add = New PictureBox()
                Dim tooltip_tuile As ToolTip = New ToolTip()
                Dim current_tuile As Tuile = current_line(id_column)
                pic_to_add.Height = pic_height
                pic_to_add.Width = pic_width
                pnl_plateau.Controls().Add(pic_to_add)
                pic_to_add.Location = New Point(pic_to_add.Location.X + (id_column) * pic_width, pic_to_add.Location.Y + (id_line) * pic_height) 'Ajout de n fois la taille d'une picturebox (hauteur ou longueur) pour le décalage
                Try
                    pic_to_add.BackgroundImage = My.Resources.ResourceManager.GetObject(current_tuile.getCouleur(0) & current_tuile.getForme(0))
                Catch ex As Exception
                    pic_to_add.BackgroundImage = Nothing
                End Try

                pic_to_add.BorderStyle = BorderStyle.FixedSingle
                pic_to_add.AllowDrop = False
                pic_to_add.Name = String.Format("pic_{0}_{1}", id_line, id_column)
                pic_to_add.Tag = pic_to_add.BackColor
                tooltip_tuile.SetToolTip(pic_to_add, "Double-cliquer sur la tuile à retirer")
                'Ajout des handles pour les picturebox du plateau
                AddHandler pic_to_add.DoubleClick, AddressOf tuile_plat_DoubleClick
                AddHandler pic_to_add.DragEnter, AddressOf tuile_DragEnter
                AddHandler pic_to_add.DragDrop, AddressOf tuile_DragDrop
                pic_to_add.BackgroundImageLayout = ImageLayout.Stretch
            Next
        Next

    End Sub

    Private Sub tuile_plat_DoubleClick(sender As Object, e As EventArgs)
        'Retrait de la tuile
        Dim pic As PictureBox = sender
        Dim id_line, id_column, id_main As Integer
        Dim increment As Integer

        If pic.BackgroundImage IsNot Nothing Then
            getTuileIndexByName(pic.Name, id_line, id_column)
            Dim is_middle_pic As Boolean = (id_line = Int(Plateau.getNbLines() / 2) And id_column = Int(Plateau.getNbColumns() / 2))
            Dim list_adja As List(Of Tuile) = Plateau.tuile_adja(id_line, id_column)
            Dim nb_tuiles_adja As Integer = 0

            For Each tuile As Tuile In list_adja 'Recherche des tuiles adjacentes (placées par le joueur donc getplacable = true)
                If tuile.getPlacable() = True Then
                    nb_tuiles_adja = nb_tuiles_adja + 1
                End If
            Next
            If (Plateau.getGrid(id_line)(id_column).getPlacable() = True And ((is_middle_pic = False And nb_tuiles_adja <= 1) Or (is_middle_pic = True And nb_tuiles_adja = 0))) Then
                'S'il s'agit d'une tuile que l'on a placée deux cas : Si c'est la tuile du milieu on attend que toutes les tuiles adjacentes placées soient retirées, sinon on retire que s'il ne reste qu'une seule tuile adjacente (pas entre 2 tuiles)

                Joueur.getCurrentPlayer().getPlaying().getTuiles().Remove(Plateau.getGrid(id_line)(id_column)) 'Retrait de la tuile de la combinaison jouée
                id_main = Plateau.removeTuile(id_line, id_column) 'Retrait de la tuile du plateau

                pnl_main.Controls("pic_main" & (id_main + 1)).BackgroundImage = pic.BackgroundImage
                Actualise()


                pic.BackgroundImage = Nothing
                increment = 1
                'Redéfinition des allowdrop des tuiles adjacentes
                If pic.BackgroundImage Is Nothing Then
                    Dim here As Byte
                    For i = 0 To 1
                        here = (i + 1) Mod 2
                        For j = 0 To 1
                            If j = 0 Then
                                increment = 1
                            Else
                                increment = -1
                            End If
                            Dim picAllow As PictureBox = pnl_plateau.Controls(String.Format("pic_{0}_{1}", id_line + increment * i, id_column + increment * here))

                            Try
                                If picAllow IsNot Nothing Then
                                    If picAllow.AllowDrop = True Then
                                        picAllow.AllowDrop = False
                                        picAllow.BackColor = Color.Transparent
                                    End If
                                End If
                            Catch ex As Exception
                            End Try
                        Next
                    Next
                    Dim picAllowCentre As New PictureBox
                    picAllowCentre = pnl_plateau.Controls(String.Format("pic_{0}_{1}", id_line, id_column))
                    If picAllowCentre.AllowDrop = True Then
                        If picAllowCentre.AllowDrop = False Then
                            picAllowCentre.AllowDrop = True
                        Else
                            picAllowCentre.AllowDrop = False
                            picAllowCentre.BackColor = Color.Transparent
                        End If
                    End If
                End If
                '''''''''''''''''''''''''''''''''''''''
                Dim pic_middle As PictureBox = pnl_plateau.Controls(String.Format("pic_{0}_{1}", Int(Plateau.getNbLines() / 2), Int(Plateau.getNbColumns() / 2)))
                pic_middle.BackColor = Color.Silver
                pic_middle.AllowDrop = True

                'Redéfinition des allowdrop pour celles qui ont été retirées
                For a = 0 To Plateau.getNbLines() - 1
                    For b = 0 To Plateau.getNbColumns() - 1
                        If plat(a)(b) IsNot Nothing Then
                            tile_to_pic(a, b)
                        End If
                    Next
                Next
                pic.BorderStyle = BorderStyle.FixedSingle
            End If

        End If
    End Sub

    Private Sub btn_giveup_Click(sender As Object, e As EventArgs) Handles btn_giveup.Click
        Dim response = MsgBox("Êtes-vous sûr de vouloir abandonner ?", vbYesNo, "Abandon")
        Dim current_player As Joueur = Nothing
        current_player = Joueur.getCurrentPlayer()
        If (response = vbYes) Then 'Si abandon

            For Each tuile As Tuile In current_player.getPlaying().getTuiles() 'Retrait des tuiles posées par le joueur précédant l'abandon (durant le même tour)
                If tuile IsNot Nothing Then
                    pnl_plateau.Controls(String.Format("pic_{0}_{1}", tuile.getLine(), tuile.getColumn())).BackgroundImage = Nothing
                End If
            Next

            endGame()
            current_player.giveUp(pioche)

            If Joueur.getNbJoueurs() > 1 Then 'Affichage du classement s'il ne reste qu'un seul joueur
                Me.Hide()
                TransitionJoueur.Show()
            Else
                Classement.Show()
                Plateau.reset()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub endGame()
        'Passage au joueur suivant
        Try
            Joueur.setCurrentPlayer(PlayerList(PlayerList.IndexOf(Joueur.getCurrentPlayer()) + 1))
        Catch ex As Exception
            Joueur.setCurrentPlayer(PlayerList(0))
        End Try
    End Sub

    Private Sub getTuileIndexByName(Name As String, ByRef line As Integer, ByRef column As Integer)
        'Découpage d'une chaîne de caractères suivant le caractère _  => utile pour les noms des picturebox du plateau
        Dim string_list As String() = Name.Split("_")
        Integer.TryParse(string_list(1), line)
        Integer.TryParse(string_list(2), column)
    End Sub

    'Début Drag&Drop
    Private Sub tuile_MouseMove(sender As Object, e As MouseEventArgs)
        Dim effecRealise As DragDropEffects
        Dim pic As PictureBox = sender
        If e.Button = MouseButtons.Left Then
            If (pic.BackgroundImage IsNot Nothing) Then
                tuile_main_dragged = pic.Name
                effecRealise = pic.DoDragDrop(pic.BackgroundImage, DragDropEffects.Move) 'Déclenchement du drag'n'drop au clic gauche d'un bouton sur une tuile de la main du joueur
                Actualise()
                If effecRealise = DragDropEffects.Move Then
                    pic.BackgroundImage = Nothing
                    pic.AllowDrop = True

                Else
                    If last_focus IsNot Nothing Then
                        last_focus.BackColor = last_focus.Tag
                        last_focus = Nothing
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub tuile_DragDrop(sender As Object, e As DragEventArgs)
        Dim pic As PictureBox = sender
        Dim string_list As String() = pic.Name.Split("_") 'On découpe le nom de la picturebox de la tuile en 3 suivant le caractère : _
        Dim id_tuile_main As Integer
        Dim id_ligne, id_column As Integer
        Dim player_hand = Joueur.getCurrentPlayer().getMainTuile().getTuiles()

        'Récupération des id de ligne / colonne et main du joueur à partir de leur Name
        id_ligne = Integer.Parse(string_list(1))
        id_column = Integer.Parse(string_list(2))
        id_tuile_main = Integer.Parse(tuile_main_dragged(8)) - 1

        pic.BackgroundImage = e.Data.GetData(DataFormats.Bitmap) 'Récupération de la donnée image
        Plateau.addTuile(player_hand(id_tuile_main), id_ligne, id_column) 'Le second élément (d'indice 1) correspond au n° de ligne, le troisième (indice 2) au numéro de colonne
        pic.AllowDrop = False
        last_focus.BackColor = last_focus.Tag
        last_focus = Nothing
        pic.BorderStyle = BorderStyle.Fixed3D
        tile_to_pic(id_ligne, id_column) 'Redéfinition des allowdrop des pics environnants
        Actualise()
    End Sub

    Private Sub tuile_DragEnter(sender As Object, e As DragEventArgs)
        Dim pic As PictureBox = sender
        Dim string_list As String() = pic.Name.Split("_") 'De même, on découpe le nom de la picturebox pour récupérer les n° de ligne et colonne
        Dim id_line, id_column As Integer
        Dim possible As Boolean
        Dim col As Color = New Color
        Dim player_hand As List(Of Tuile) = Joueur.getCurrentPlayer().getMainTuile().getTuiles()
        Dim id_tuile_main As Integer = Integer.Parse(tuile_main_dragged(8)) - 1 'On récupère le numéro de tuile de la main du joueur grâce au dernier caractère du composant sur lequel on effectue le drag'n'drop (on commence à 0 donc on retire 1)
        id_line = Integer.Parse(string_list(1))
        id_column = Integer.Parse(string_list(2))
        possible = (Plateau.getNbTuiles() = 0) 'Si il n'y a aucune tuile sur le plateau, alors le déplacement est forcément possible (sur la case du milieu)
        If possible = False Then 'Si jamais il y a d'autres tuiles, alors la valeur finale de possible sera le retour de la vérification du mot
            possible = Plateau.VerifMot(id_line, id_column, player_hand(id_tuile_main)) 'Nothing car on a pas besoin de l'ensemble des combinaisons trouv"
        End If
        If e.Data.GetDataPresent(DataFormats.Bitmap) = True And Plateau.getGrid(id_line)(id_column) Is Nothing And possible = True Then
            e.Effect = DragDropEffects.Move
            col = Color.FromArgb(1426111232)
        Else
            e.Effect = DragDropEffects.None
            col = Color.FromArgb(1442775040)
        End If
        If last_focus IsNot Nothing Then
            last_focus.BackColor = last_focus.Tag

        End If
        pic.Tag = pic.BackColor
        pic.BackColor = col
        last_focus = pic
    End Sub
    'Fin Drag&Drop

    Public Function getCurrentPlayer()
        'Retourne le Joueur entrain de Jouer
        Return Joueur.getCurrentPlayer()
    End Function

    Private Sub btn_valid_Click(sender As Object, e As EventArgs) Handles btn_valid.Click
        Dim current_player As Joueur = Nothing
        current_player = Joueur.getCurrentPlayer()

        If (current_player.getMainTuile.NbTuiles = 6) And pioche.NbTuiles() <> 0 Then 'si il y a 6 tuiles dans la main et que la pioche n'est pas vide'
            ChangementPioche.ShowDialog()
            If ChangementPioche.ValiderEchange() Then
                endGame()
                TransitionJoueur.Show()
                current_player.setScoreTour(0)
            End If
        Else
            Me.Hide()
            If pioche.NbTuiles() = 0 Then 'si la pioche est vide'
                Dim sum As Integer = 0
                If current_player.getPlaying().NbTuiles <> 0 Then ' On compte le nombre de tuile posé et on compte le nombre de point qu'il a inscrit durant le tour
                    current_player.countGamePoints(pioche)
                Else                                              'Sinon on lui affecte 0 point marque (passer son tour sans poser de tuiles) 
                    current_player.setScoreTour(0)
                End If
                For Each player As Joueur In PlayerList           'On compte le score que tout les joueurs on obtenue en 1 tour
                    sum = sum + player.getScoreTour()
                Next

                endGame()                                        'Le joueur passe
                If current_player.getMainTuile.NbTuiles = 0 Then
                    current_player.setScoreTot(current_player.getScoreTot + 6)
                    Classement.Show()
                    Me.Close()
                    Plateau.reset()

                Else
                    If sum = 0 Then                                  'Si aucun joueur na marque de point en 1 tour de jeux -> Fin de partie                  
                        Classement.Show()
                        Me.Close()
                        Plateau.reset()
                    Else
                        TransitionJoueur.Show()                      'Sinon prochain joueur
                    End If
                End If
            Else
                If current_player.getPlaying().NbTuiles <> 0 Then 'Si le joueur a pose des tuiles et que la pioche n'est pas vide
                    current_player.countGamePoints(pioche)
                Else
                    current_player.setScoreTour(0)
                End If
                endGame()
                TransitionJoueur.Show()
            End If

        End If

    End Sub

    Private Sub Actualise()
        'Actualisation du bouton de validation en fonction de comment joue le joueur
        Dim current_player As Joueur = Nothing
        current_player = Joueur.getCurrentPlayer()
        If (current_player.getMainTuile.NbTuiles = 6) And pioche.NbTuiles() <> 0 Then 'Le joueur à 6 tuiles et il reste des tuiles dans la pioche
            btn_valid.Text = "Changer tuiles"
        End If
        If (current_player.getMainTuile.NbTuiles <> 6) And pioche.NbTuiles() <> 0 Then 'Le joueur n'a plus 6 tuile et il reste des tuiles dans la pioche
            btn_valid.Text = "Valider"
        End If

        If (current_player.getMainTuile.NbTuiles = 6) And pioche.NbTuiles() = 0 Then 'Le joueur à 6 tuiles et la pioche est vide
            btn_valid.Text = "Passer"
        End If
        If (current_player.getMainTuile.NbTuiles <> 6) And pioche.NbTuiles() = 0 Then 'Le joueur n'a pas 6 tuiles et lqa pioche est vide
            btn_valid.Text = "Valider"
        End If
        If (current_player.getMainTuile.NbTuiles() = 0) And pioche.NbTuiles() = 0 Then 'Le joueur n'a plus de tuiles et la pioche est vide
            btn_valid.Text = "Fin de partie"
        End If
    End Sub

    Private Sub PlateauJeu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tooltip_main As ToolTip = New ToolTip()
        Dim str As String = "Glisser-déposer la tuile sur une case grisée du plateau"
        ChoixNomJoueurs.Close()
        tooltip_main.SetToolTip(pnl_main, str)
        For Each control As Control In pnl_main.Controls()
            tooltip_main.SetToolTip(control, str)
        Next
    End Sub
End Class