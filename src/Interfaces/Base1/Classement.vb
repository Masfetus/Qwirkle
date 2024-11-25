Imports Qwirkle

Public Class Classement

    Private Sub btnRetourMenu_Click(sender As Object, e As EventArgs) Handles btnRetourMenu.Click
        'Raz des paramètres static de Joueur'
        Joueur.setCurrentPlayer(Nothing)
        Joueur.setPlayerList(Nothing)
        Joueur.setNbJoueurs(0)
        'Raz des Forms'
        PlateauJeu.Controls.Clear()
        ChoixNomJoueurs.Controls.Clear()
        ChoixNbJoueurs.Controls.Clear()
        InitializeComponent
        'Fermeture des Form pour qu'au prochain Show l'évènement Load soit exécuté'
        ChoixNbJoueurs.Close()
        ChoixNomJoueurs.Close()
        PlateauJeu.Close()
        'Retour à l'accueil'
        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub btnRejouer_Click(sender As Object, e As EventArgs) Handles btnRejouer.Click
        'Raz des paramètres static de Joueur'
        Joueur.setCurrentPlayer(Nothing)
        Joueur.setPlayerList(Nothing)
        Joueur.setNbJoueurs(0)
        'Raz des Forms'
        PlateauJeu.Controls.Clear()
        ChoixNomJoueurs.Controls.Clear()
        ChoixNbJoueurs.Controls.Clear()
        InitializeComponent()
        'Fermeture des Form pour qu'au prochain Show l'évènement Load soit exécuté'
        ChoixNbJoueurs.Close()
        ChoixNomJoueurs.Close()
        PlateauJeu.Close()
        'Retour au choix du nombre de joueurs'
        ChoixNbJoueurs.Show()
        Me.Close()
    End Sub

    Private Sub Classement_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Affichage du classement'
        Dim Classement As List(Of Joueur)
        Classement = Joueur.ChooseRanking(Joueur.getPlayerList())
        Dim rank As New Byte

        For i = 1 To Joueur.getNbJoueurs()
            Dim pseudo As String
            pseudo = Classement.Item(i - 1).getPseudo()
            Dim score As Byte
            score = Classement(i - 1).getScoreTot()
            Dim lbl As New Label
            Dim fBrit As New Font("Britannic", 14, FontStyle.Bold)

            lbl.Font = fBrit
            lbl.Name = "lbl" & i
            lbl.AutoSize = True
            lbl.ForeColor = System.Drawing.Color.Black

            If i = 1 Then
                lbl.Location = New Point(30, 90 - 20 * Joueur.getNbJoueurs())
                rank = i
            Else
                Dim lblTemp As New Label
                Dim txtTemp As New TextBox
                lblTemp = pnlClassement.Controls("lbl" & (i - 1))
                lbl.Location = New Point(30, lblTemp.Location.Y + 50)
                If score <> Classement.Item(i - 2).getScoreTot() Then
                    rank = i
                End If
            End If
            If rank = 1 Then
                lbl.ForeColor = System.Drawing.Color.Blue
            End If
            lbl.Text = rank & "° : " & pseudo & "   " & score & " Pts"
            pnlClassement.Controls.Add(lbl)

        Next
    End Sub

End Class