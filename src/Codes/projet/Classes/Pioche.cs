using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle
{
    public class Pioche : Combinaison
    {

        public Pioche()
        {
            List<Tuile> pioche = new List<Tuile>();
            string[] couleur = new string[6]
            { "bleu", "jaune", "orange","rouge","vert","mauve" }; // minuscule pour pouvoir faire le lien avec les ressources images
            string[] forme = new string[6]
            { "carre","etoile","losange","rond","soleil","trefle" };

            for(int indice = 0; indice < 3; indice ++) // 3 Tuiles identiques dans la pioche (au total 3 x 6 x 6 = 108 tuiles)
            {
                for(int Icouleur = 0; Icouleur < 6; Icouleur++) // 6 couleurs
                {
                    for (int Iforme = 0; Iforme < 6; Iforme++) // 6 formes
                    {
                        Tuile tuile_to_create = new Tuile(couleur[Icouleur], forme[Iforme]);
                        pioche.Add(tuile_to_create);
                    }
                }
            }

            this.tuiles = pioche;
        }
        public Pioche(List<Tuile> tuiles) : base (tuiles)
        {
            this.tuiles = tuiles;
        }
        public Combinaison giveTuilesToPlayer(Joueur player, int amount)
        {
            // Méthode donnant des tuiles de la pioche au joueur passé en paramètre
            Random random = new Random();
            Tuile tuile = new Tuile();
            if (amount > this.NbTuiles()) // On ne donne pas plus qu'il n'y a de tuiles dans la pioche
            {
                amount = this.NbTuiles();
            }
            for (int indice = 0; indice < amount; indice++)
            {
                int taille_pioche = NbTuiles();
                tuile = tuiles[random.Next(taille_pioche)];
                int index = 0;
                try
                {
                    while (player.getMainTuile().getTuiles()[index] != null) // On cherche la première case vide de la main du joueur
                        index++;
                    player.getMainTuile().getTuiles()[index] = tuile;
                }
                catch
                {
                    player.getMainTuile().addTuile(tuile); // En cas de main pleine, on ajoute tout de même la tuile bien que le joueur doit en avoir que 6
                }
                tuile.setDetenteur(player); // On assigne le nouveau détenteur
                removeTuile(tuile);
            }


            return player.getMainTuile();
        }
        public Combinaison echangeTuiles(Combinaison echange)
        {
            // Méthode échangeant la combinaison passée en paramètre avec les tuiles de la pioche (retourne la nouvelle combinaison)
            Combinaison newMain = new Combinaison();
            Random random = new Random();
            Tuile tuile = new Tuile();
            
            int compt = echange.getTuiles().Count;

            if (compt > this.NbTuiles())
            {
                return echange;
            }
            for (int indice =0; indice < compt ; indice++) // Retrait des tuiles de la pioche
            {
                tuile = tuiles[random.Next(NbTuiles())];
                newMain.addTuile(tuile);
                tuile.setDetenteur(Joueur.getCurrentPlayer());
                removeTuile(tuile);
            }
            for (int indice =0; indice < compt; indice ++) // On remet les tuiles du joueur dans la pioche
            {
                addTuile(echange.getTuiles()[indice]);
                echange.getTuiles()[indice].setDetenteur(null);
            } 
            return newMain;
        }

    }
}
