Imports Qwirkle

Public Class ChangementPioche
    Dim Echange As New Combinaison 'Conbinaison de tuile contenant la liste de tuiles qui vont être échangées'
    Dim Valider As Boolean
    Private Sub Btn_Valid_Click(sender As Object, e As EventArgs) Handles Btn_Valid.Click
        Dim pioche As Pioche = PlateauJeu.getPioche()
        Dim joueur As Joueur = PlateauJeu.getCurrentPlayer()
        Dim reserve As New Combinaison
        For Each tuile As Tuile In Echange.getTuiles()
            reserve.addTuile(tuile)
        Next
        Dim to_add As Combinaison = pioche.echangeTuiles(Echange)
        Dim nbtuile As Byte = 0
        Dim Sortie As Byte = 0
        While nbtuile < joueur.getMainTuile().NbTuiles() And Sortie <> 2
            Dim tile As Tuile = joueur.getMainTuile().getTuiles().Item(nbtuile)
            Dim j As Byte = 0
            While Echange.NbTuiles() <> 0 And j < Echange.NbTuiles() And Sortie = 0
                If tile.getForme() = Echange.getTuiles().Item(j).getForme() And tile.getCouleur() = Echange.getTuiles().Item(j).getCouleur() Then
                    joueur.getMainTuile().getTuiles().Remove(tile)
                    Echange.getTuiles().RemoveAt(j)
                    j = 0
                    Sortie = 1
                Else
                    j += 1
                End If
            End While
            If j = 0 Then
                nbtuile = j
                Sortie = 0
            Else
                nbtuile += 1
            End If
            If Echange.NbTuiles() = 0 Then
                Sortie = 2
            End If
        End While
        Try
            For k = 0 To 5 - joueur.getMainTuile().NbTuiles()
                joueur.getMainTuile().addTuile(to_add.getTuiles().Item(k))
            Next
        Catch ex As Exception
            For Each tuile In reserve.getTuiles()
                joueur.getMainTuile().addTuile(tuile)
            Next
            MessageBox.Show("Pas assez de tuile dans la pioche.")
        End Try

        ' Dynamisme
        Dim indice As Byte = 0
        For Each tuile As Tuile In joueur.getMainTuile().getTuiles()
            indice += 1
            Dim pic As PictureBox = Me.Controls("pnl_main").Controls("PicMain" & indice)
            pic.Size = New Size(50, 50)
            pic.Margin = New Padding(10, 20, 10, 20)
            pic.Cursor = Cursors.Default
            If indice = 1 Then
                pic.Location = New Point(10, 30)
            Else
                Dim Lastpic As New PictureBox
                Lastpic = Me.Controls("pnl_main").Controls("PicMain" & (indice - 1))
                pic.Location = New Point(Lastpic.Width + Lastpic.Location.X + 10, 30)
            End If
            pic.Tag = Nothing
            Try
                Me.Controls("pnl_main").Controls("PicMain" & indice).BackgroundImage = My.Resources.ResourceManager.GetObject(tuile.getCouleur(0) & tuile.getForme(0))
            Catch exception As Exception
                Me.Controls("pnl_main").Controls("PicMain" & indice).BackgroundImage = Nothing
            End Try
            pic.BackgroundImageLayout = ImageLayout.Stretch
            RemoveHandler pic.Click, AddressOf PicMain_Click
        Next
        Btn_Valid.Visible = False
        Btn_Anul.Visible = False
        lbl_echange.Text = "Voici votre nouveau jeu :"
        Dim btn As New Button
        btn.Name = "btn_ok"
        btn.AutoSize = True
        btn.Location = New Point(260, 300)
        btn.Text = "Ok"
        Me.Controls.Add(btn)
        AddHandler btn.Click, AddressOf btn_click

    End Sub

    Private Sub btn_click(sender As Object, e As EventArgs)
        For i = 1 To 6
            Dim pic As PictureBox = Me.Controls("pnl_main").Controls("PicMain" & i)
            AddHandler pic.Click, AddressOf PicMain_Click
        Next
        Dim btn As Button = Me.Controls("btn_ok")
        Me.Controls.Remove(btn)
        Btn_Anul.Visible = True
        Btn_Valid.Visible = True
        lbl_echange.Text = "Sélectionner les tuiles à échanger :"
        PlateauJeu.Hide()
        Reload()
        Valider = True
        Me.Close()

    End Sub

    Private Sub Btn_Anul_Click(sender As Object, e As EventArgs) Handles Btn_Anul.Click
        Dim i As Byte
        Echange.getTuiles().Clear()

        For i = 1 To 6
            Dim pic As PictureBox = Me.Controls("pnl_main").Controls("PicMain" & i)
            pic.Tag = Nothing
            pic.Size = New Size(50, 50)
            If i = 1 Then
                pic.Location = New Point(10, 30)
            Else
                Dim Lastpic As New PictureBox
                Lastpic = Me.Controls("pnl_main").Controls("PicMain" & (i - 1))
                pic.Location = New Point(Lastpic.Width + Lastpic.Location.X + 10, 30)
            End If
        Next
        Valider = False
        Me.Close()
    End Sub

    Private Sub ChangementPioche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pnl As New Panel
        pnl.Name = "pnl_main"
        pnl.Location = New Point(Me.Width / 7, Me.Height / 3)
        pnl.AutoSize = True
        pnl.Padding = New Padding(10, 10, 10, 10)
        pnl.BackgroundImage = My.Resources.ResourceManager.GetObject("PicEchangeTuile")
        pnl.BackgroundImageLayout = ImageLayout.Stretch
        pnl.BackColor = Color.Transparent
        Me.Controls.Add(pnl)
        Reload()
    End Sub

    Private Sub Reload()
        Dim i As Byte = 0
        Dim joueur As Joueur = PlateauJeu.getCurrentPlayer()
        For Each tuile As Tuile In joueur.getMainTuile().getTuiles()
            Dim pic As New PictureBox
            i += 1
            pic.Name = "PicMain" & i
            pic.Size = New Size(50, 50)
            pic.Margin = New Padding(10, 20, 10, 20)
            pic.Cursor = Cursors.Hand
            If i = 1 Then
                pic.Location = New Point(10, 30)
            Else
                Dim Lastpic As New PictureBox
                Lastpic = Me.Controls("pnl_main").Controls("PicMain" & (i - 1))
                pic.Location = New Point(Lastpic.Width + Lastpic.Location.X + 10, 30)
            End If
            Me.Controls("pnl_main").Controls.Add(pic)
            pic.Tag = ""
            Try
                Me.Controls("pnl_main").Controls("PicMain" & i).BackgroundImage = My.Resources.ResourceManager.GetObject(tuile.getCouleur(0) & tuile.getForme(0))
            Catch exception As Exception
                Me.Controls("pnl_main").Controls("PicMain" & i).BackgroundImage = Nothing
            End Try
            pic.BackgroundImageLayout = ImageLayout.Stretch
            AddHandler pic.Click, AddressOf PicMain_Click
        Next
        Dim pioche As Pioche = PlateauJeu.getPioche()
        If pioche.NbTuiles() < 6 Then
            Dim lbl As New Label
            lbl_echange.Font = New Font("Britania", 10)
            lbl_echange.ForeColor = Color.Red
            lbl_echange.Text = String.Format("Attention il reste actuellement {0} tuiles dans la pioche,", pioche.NbTuiles())
            lbl.Font = New Font("Britania", 10)
            lbl.Text = "si vous en sélectionnez plus alors votre tour sera passé sans échange ."
            lbl.ForeColor = Color.Red
            lbl.BackColor = Color.Transparent
            lbl.AutoSize = True
            lbl.Location = New Point(75, 80)
            Me.Controls.Add(lbl)
        End If
    End Sub

    Private Sub PicMain_Click(sender As Object, e As EventArgs)
        Dim pic As PictureBox = sender
        Dim id_main = Integer.Parse(pic.Name(7)) - 1
        'A chaque clique sur une image, on lui attribut ou non un tag suivant s'il le possède déjà ou non. Cela va permettre de repérer les tuiles à échanger.
        If pic.Tag IsNot "Take" Then
            pic.Tag = "Take"
            pic.Size = New Size(60, 60) 'Redimentionnement de la picture box pour montrer qu'elle est ou non sélectionnée'
            Dim joueur As Joueur = PlateauJeu.getCurrentPlayer()
            Dim tuile = joueur.getMainTuile().getTuiles().Item(id_main)
            Echange.addTuile(tuile)
        Else
            pic.Tag = Nothing
            pic.Size = New Size(50, 50)
            Dim joueur As Joueur = PlateauJeu.getCurrentPlayer()
            Dim tuile = joueur.getMainTuile().getTuiles().Item(id_main)
            Echange.removeTuile(tuile)
        End If
        'Mise en forme'
        Dim deplace As Byte = 0
        Dim i As Byte = 0
        For Each pict As PictureBox In Me.Controls("pnl_main").Controls
            i += 1
            If i >= 7 Then
                i = 1
            End If
            If pict.Tag = "Take" Then
                deplace = 10
            ElseIf pict.Tag = "" Then
                deplace = 0
            End If
            If i = 1 Then
                pict.Location = New Point(10, 30 - deplace)
            Else
                Dim Lastpic As New PictureBox
                Lastpic = Me.Controls("pnl_main").Controls("PicMain" & (i - 1))
                pict.Location = New Point(Lastpic.Width + Lastpic.Location.X + 10, 30 - deplace)
            End If
        Next
    End Sub
    Public Function ValiderEchange()
        Return Valider
    End Function
End Class