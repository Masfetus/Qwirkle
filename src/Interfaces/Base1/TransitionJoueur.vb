Public Class TransitionJoueur
    Private Sub TransitionJoueur_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Afichage de l'interface pour le joueur suivant avec son pseudo 
        Dim pseudo As String = Nothing
        Try
            pseudo = PlateauJeu.getCurrentPlayer().getPseudo()
        Catch ex As NullReferenceException
            pseudo = ChoixNomJoueurs.getListPlayers(ChoixNomJoueurs.getIndice()).getPseudo()
        End Try
        lbl_tourDe.Text = String.Format("Au tour de {0}", pseudo)
        btnTransitionJoueur.Text = String.Format("Je suis {0}", pseudo)
    End Sub


    Private Sub btnTransitionJoueur_Click(sender As Object, e As EventArgs) Handles btnTransitionJoueur.Click
        PlateauJeu.Show()
        Me.Close() 'Bien ferme le form pour relance Load à la prochaine ouverture et mettre à jour le nom du joueur'
    End Sub
End Class