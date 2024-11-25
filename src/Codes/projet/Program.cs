using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qwirkle;

namespace projet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programme de test console avant liaison interface graphique

            // Saisie du nombre de joueur
            while(Joueur.getNbJoueurs()<2 || Joueur.getNbJoueurs() >4)
            {
                Console.WriteLine("Hello, veuillez saisir le nombre de joueur ( Compris entre 2 et 4 )");
                try
                {
                    Joueur.setNbJoueurs(int.Parse(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Erreur veuillez saisir un entier");
                }
            }
            // Définition de la pioche
            Pioche pioche = new Pioche();
            // Définition nom des joueurs
            List<Joueur> playerList = new List<Joueur>();
            for (int indice = 0; indice < Joueur.getNbJoueurs(); indice ++)
            {
                string name;
                Console.WriteLine("Saisir le nom du joueur {0}", indice+1);
                name = Console.ReadLine();
                playerList.Add(new Joueur(name));
                playerList[indice].setMainTuile(pioche.giveTuilesToPlayer(playerList[indice], 6));
            }
            // Définition des mains des joueurs
            for (int indice = 0; indice < Joueur.getNbJoueurs(); indice++)
            {
                Console.WriteLine("\nJoueur {0} : {1}", indice + 1, playerList[indice].getPseudo());
                Console.WriteLine("Tuiles en Main : ");

                List<Tuile> combi_joueur = playerList[indice].getMainTuile().getTuiles();

                List<string> couleur = new List<string>
                { "Bleu", "Jaune", "Orange","Rouge","Vert","Violet" };
                List<string> forme = new List<string>
                { "Carre","Etoile","Losange","Rond","Soleil","Trefle" };
                int nbc = 1, nbs = 1, max =0;

                foreach(Tuile tuile in combi_joueur)
                {
                    Console.Write("|{0} {1}|", tuile.getCouleur(), tuile.getForme());
                    foreach(Tuile tile in combi_joueur)
                    {
                        if(tile != tuile)
                        {
                            if (tile.getCouleur() == tuile.getCouleur() && tile.getForme() != tuile.getForme()) nbc++;
                            if (tile.getForme() == tuile.getForme() && tile.getCouleur() != tuile.getCouleur()) nbs++;
                        }
                    }

                    if (nbs > nbc)
                        max = nbs;
                    else
                        max = nbc;
                    nbc = nbs = 1;
                }
                playerList[indice].setNoTour(max);
            }
            // Définition de l'ordre de jeu
            int maxi = 0;
            int i = 0;
            List<Joueur> Ordre = new List<Joueur>();
            while(playerList.Count !=0)
            {
                Joueur player = playerList[0];
                maxi = player.getNoTour();
                i = playerList.IndexOf(player);
                for (int j = playerList.IndexOf(player); j < playerList.Count; j++)
                {
                    Joueur joueur = playerList[j];
                    if (maxi < joueur.getNoTour())
                    {
                        maxi = joueur.getNoTour();
                        i = playerList.IndexOf(joueur);
                    }
                }
                Ordre.Add(playerList[i]);
                playerList.RemoveAt(i);
            }
            // Affichage 
            Console.WriteLine("\nOrdre de jeu : ");
            foreach(Joueur joueur in Ordre)
            {
                joueur.setNoTour(i);
                Console.WriteLine("Joueur {0} : {1} ", i+1, joueur.getPseudo());
                i++;
            }
            Console.WriteLine("{0}",pioche.NbTuiles());
                


            Console.ReadKey();
        }
    }
}
