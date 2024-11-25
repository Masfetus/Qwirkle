Imports Qwirkle

Public Class ChoixNomJoueurs
    Dim OrdreJeu As New List(Of Joueur)
    Dim nb As Byte = Joueur.getNbJoueurs()
    Dim indiceJoue As Byte = 0

    Private Sub ChoixNomJoueurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Mise en forme au lancement, avec si 2, 3 ou 4 joueurs'
        Dim fBrit As New Font("Britannic", 12, FontStyle.Bold)

        For i = 1 To nb
            Dim lbl As New Label
            Dim txt As New TextBox

            lbl.Name = "lbl" & i
            lbl.Text = "Joueur " & i
            lbl.Font = fBrit
            lbl.ForeColor = System.Drawing.Color.White
            lbl.Size = New Size(88, 22)
            lbl.BackColor = Color.Transparent
            txt.Name = "txt" & i
            txt.Size = New Size(120, 28)

            If i = 1 Then
                lbl.Location = New Point(10, 90 - 20 * nb)
                txt.Location = New Point(100, 90 - 20 * nb)
            Else
                Dim lblTemp As New Label
                Dim txtTemp As New TextBox
                lblTemp = pnlJoueur.Controls("lbl" & (i - 1))
                txtTemp = pnlJoueur.Controls("txt" & (i - 1))
                lbl.Location = New Point(10, lblTemp.Location.Y + 40)
                txt.Location = New Point(100, txtTemp.Location.Y + 40)
            End If
            AddHandler txt.KeyDown, AddressOf onEnterKeyPressed
            pnlJoueur.Controls.Add(lbl)
            pnlJoueur.Controls.Add(txt)
        Next
    End Sub

    Private Sub onEnterKeyPressed(sender As Object, e As KeyEventArgs) 'Gestion de la touche entrée, si entrée alors comme valider'
        If (Keys.Enter = e.KeyCode) Then
            BtnValidNomJoueurs_Click(sender, e)
        End If
    End Sub

    Private Sub BtnRetourChoixNomJoueur_Click(sender As Object, e As EventArgs) Handles BtnRetourChoixNomJoueur.Click 'Retour au choix du nb de joueurs'
        ChoixNbJoueurs.Show()
        Me.Close() 'Ferme bien le ChoixNomJoueur pour qu'au prochain Show, Load s'exécute'
    End Sub

    Private Sub BtnValidNomJoueurs_Click(sender As Object, e As EventArgs) Handles BtnValidNomJoueurs.Click
        Dim Verif As New Byte 'Vérifie si tout les nom des joueur sont saisis'
        For indice = 1 To nb
            If Not String.IsNullOrWhiteSpace(pnlJoueur.Controls("txt" & indice).Text) Then 'Si le champ pour entrer ton nom n'est pas vide
                Verif += 1
            End If
        Next
        If Verif = nb Then 'Si tous les pseudos sont saisis'
            Dim tab_joueur As New List(Of Joueur)
            For i = 1 To nb 'Instanciation de la liste de joueurs avec les pseudos saisis'
                Dim joueur As New Joueur
                joueur.setPseudo(pnlJoueur.Controls("txt" & i).Text.TrimStart(" "))
                joueur.setMainTuile(PlateauJeu.getPioche().giveTuilesToPlayer(joueur, 6))
                tab_joueur.Add(joueur)
            Next
            OrdreJeu = Joueur.ChooseOrder(tab_joueur) 'Classement des joueur dans l'ordre jeu
            Cursor = Cursors.AppStarting
            PlateauJeu.createPlat()
            Joueur.setCurrentPlayer(OrdreJeu.Item(0))
            TransitionJoueur.Show()
            Me.Hide()
        Else
            MessageBox.Show("Veuillez saisir le nom de tous les joueurs")
        End If
    End Sub

    Public Function getNbplayers()
        Return nb
    End Function

    Public Function getListPlayers()
        Return OrdreJeu
    End Function

    Public Function getIndice()
        Return indiceJoue
    End Function
End Class