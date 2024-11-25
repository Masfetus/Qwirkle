Imports Qwirkle

Public Class ChoixNbJoueurs
    Private Sub BtnRetourNbJoueur_Click(sender As Object, e As EventArgs) Handles BtnRetourNbJoueur.Click
        Accueil.Show()
        Close()
    End Sub
    Private Sub BtnValidNbJoueur_Click(sender As Object, e As EventArgs) Handles BtnValidNbjoueur.Click
        Dim rbChecked As Boolean = True
        If rb_2.Checked = True Then
            Joueur.setNbJoueurs(2)
        ElseIf rb_3.Checked = True Then
            Joueur.setNbJoueurs(3)
        ElseIf rb_4.Checked = True Then
            Joueur.setNbJoueurs(4)
        Else
            rbChecked = False
        End If
        If rbChecked Then
            ChoixNomJoueurs.Show()
            Me.Close()
        End If
    End Sub

    Private Sub pnl_4_Click(sender As Object, e As EventArgs) Handles pnl_4.Click, pnl_3.Click, pnl_2.Click
        Dim nbjoueurs As String
        Dim panel As Panel = sender
        nbjoueurs = panel.Name.Split("_")(1)
        Dim rb As RadioButton = pnl_rb.Controls("rb_" & nbjoueurs)
        rb.Checked = Not rb.Checked
    End Sub

    Private Sub ChoixNbJoueurs_KeyDown(sender As Object, e As KeyEventArgs) Handles rb_2.KeyDown, rb_3.KeyDown, rb_4.KeyDown
        If (e.KeyValue = Keys.Enter) Then
            BtnValidNbJoueur_Click(sender, e)
        ElseIf (e.KeyValue = Keys.Return) Then
            BtnRetourNbJoueur_Click(sender, e)
        End If
    End Sub
End Class