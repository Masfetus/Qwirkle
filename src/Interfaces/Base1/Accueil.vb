Public Class Accueil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        ChoixNbJoueurs.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnRegle.Click
        Regle.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnCredits.Click
        Credits.ShowDialog()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub
End Class
