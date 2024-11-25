using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle
{
    public class Joueur
    {
        private int scoreTot, scoreTour, noTour, roundplayed; // roundplayed : nb de tours joués
        private static int nbJoueurs;
        private string pseudo;
        private static List<Joueur> PlayerList;
        private static Joueur current_player;
        private Combinaison mainTuile, playing; // Une combinaison pour la main du joueur, l'autre pour les tuiles posées durant son tour
        
        public Joueur()
        {
            this.pseudo = null;
            this.scoreTot = 0;
            this.scoreTour = 0;
            this.noTour = 0;
            roundplayed = 0;
            this.mainTuile = new Combinaison();
            this.playing = new Combinaison();
        }

        public Joueur(string Pseudo, int NoTour = 0)
        {
            this.pseudo = Pseudo;
            this.scoreTot = 0;
            roundplayed = 0;
            this.scoreTour = 0;
            this.noTour = NoTour;
            this.mainTuile = new Combinaison();
            this.playing = new Combinaison();
        }

        public void setPseudo(string nom)
        {
            this.pseudo = nom;
        }

        public void setScoreTot(int score)
        {
            this.scoreTot = score;
        }

        public void setScoreTour(int value)
        {
            this.scoreTour = value;
        }
        public static void setCurrentPlayer(Joueur player)
        {
            if (player != null)
                current_player = player;
        }
        public static Joueur getCurrentPlayer()
        {
            return current_player;
        }
        public static void setPlayerList(List<Joueur> list)
        {
            PlayerList = list;
        }
        public static List<Joueur> getPlayerList()
        {
            return PlayerList;
        }
        public void setNoTour(int number)
        {
            this.noTour = number;
        }

        public void setPlaying(Combinaison tuiles)
        {
            this.playing = tuiles;
        }

        public void setMainTuile(Combinaison tuiles)
        {
            this.mainTuile = tuiles;
        }

        public string getPseudo()
        {
            return this.pseudo;
        }

        public int getScoreTot()
        {
            return this.scoreTot;
        }

        public int getScoreTour()
        {
            return this.scoreTour;
        }

        public int getNoTour()
        {
            return this.noTour;
        }

        public Combinaison getPlaying()
        {
            return this.playing;
        }

        public Combinaison getMainTuile()
        {
            return this.mainTuile;
        }

        public void giveUp(Pioche pioche)
        {
            // Méthode d'abandon du joueur
            List<Joueur> player_list = getPlayerList();
            noTour = -1;
            nbJoueurs--;
            player_list.Remove(this);
            setPlayerList(player_list);
            foreach(Tuile tuile in playing.getTuiles())
            {
                Plateau.removeTuile(tuile.getLine(), tuile.getColumn());
            }
            foreach(Tuile tuile in mainTuile.getTuiles())
            {
                if(tuile != null)
                    tuile.setDetenteur(null);
                pioche.addTuile(tuile);
            }
            /*foreach(Tuile tuile in playing.getTuiles())
            {
                if (tuile != null)
                    Plateau.removeTuile(tuile.)
                
            }*/
        }

        public void play()
        {
            // Méthode débutant le jeu du joueur (en réinitialisant les variables propres au tour)
            roundplayed++;
            setScoreTour(0);
            getPlaying().getTuiles().Clear();
        }
        public void setRoundPlayed(int number)
        {
            if (number >= 0)
                roundplayed = number;
        }
        public int getRoundPlayed()
        {
            return roundplayed;
        }
        public static void setNbJoueurs(int number)
        {
            Joueur.nbJoueurs = number;
        }

        public static int getNbJoueurs()
        {
            return Joueur.nbJoueurs;
        }
        public static List<Joueur> ChooseOrder(List<Joueur> tab_joueur)
        {
            // Méthode déterminant l'ordre de jeu du joueur en fonction des combinaisons tirées au sort
            for(int indice=0; indice < tab_joueur.Count; indice ++)
            {
                List<Tuile> combi_joueur = tab_joueur[indice].getMainTuile().getTuiles();

                List<string> couleur = new List<string>
                { "Bleu", "Jaune", "Orange","Rouge","Vert","Violet" };
                List<string> forme = new List<string>
                { "Carre","Etoile","Losange","Rond","Soleil","Trefle" };
                int nbc = 1, nbs = 1, max = 0;


                foreach (Tuile tuile in combi_joueur)
                {
                    foreach (Tuile tile in combi_joueur)
                    {
                        if (tile != tuile) // Comptage du nombre de tuiles différentes
                        {
                            if (tile.getCouleur() == tuile.getCouleur() && tile.getForme() != tuile.getForme())
                                nbc++;
                            if (tile.getForme() == tuile.getForme() && tile.getCouleur() != tuile.getCouleur())
                                nbs++;
                        }
                    }

                    if (nbs > nbc)
                        max = nbs;
                    else
                        max = nbc;
                    nbc = nbs = 1;
                }
                tab_joueur[indice].setNoTour(max);
            }
            int maxi = 0;
            int i = 0;
            List<Joueur> Ordre = new List<Joueur>();
            while (tab_joueur.Count != 0) // Ordonnancement de la liste en fonction du nombre de tuiles obtenu au préalable
            {
                Joueur player = tab_joueur[0];
                maxi = player.getNoTour();
                i = tab_joueur.IndexOf(player);
                for (int j = tab_joueur.IndexOf(player); j < tab_joueur.Count; j++)
                {
                    Joueur joueur = tab_joueur[j];
                    if (maxi < joueur.getNoTour())
                    {
                        maxi = joueur.getNoTour();
                        i = tab_joueur.IndexOf(joueur);
                    }
                }
                Ordre.Add(tab_joueur[i]);
                tab_joueur.RemoveAt(i);
            }

            return Ordre;
        }
        public static List<Joueur> ChooseRanking(List<Joueur> tab_joueurs)
        {
            // Méthode triant la liste du joueur selon leur nombre de points (pour le classement)
            List <Joueur> Classement = new List<Joueur>();
            int max = 0, i = 0;
            while (tab_joueurs.Count != 0)
            {
                Joueur player = tab_joueurs[0];
                max = player.getScoreTot();
                i = tab_joueurs.IndexOf(player);
                for (int j = 0; j < tab_joueurs.Count; j++)
                {
                    Joueur joueur = tab_joueurs[j];
                    if (max < joueur.getScoreTot())
                    {
                        max = joueur.getScoreTot();
                        i = tab_joueurs.IndexOf(joueur);
                    }
                }
                Classement.Add(tab_joueurs[i]);
                tab_joueurs.RemoveAt(i);
            }

            return Classement;
        }
        public void countGamePoints(Pioche pioche)
        {
            // Méthode comptant le nombre de points gagnés pendant le tour du joueur
            int points = 0;
            Tuile tile = null;
            List<List<Tuile>> plat = Plateau.getGrid();
            if (Plateau.getNbTuiles() == getPlaying().NbTuiles()) // Si le joueur est le premier à poser des tuiles
            {
                points = getPlaying().NbTuiles();
                if (points == 6)
                    points += 6;
                setScoreTour(points);
            }
            else if (getPlaying().NbTuiles() >= 2)
            {
                
                int y1 = getPlaying().getTuiles()[0].getLine();
                int y2 = getPlaying().getTuiles()[1].getLine();
                if (y1 == y2) // alignés horizontalement
                {
                    foreach (Tuile tuile in getPlaying().getTuiles()) // Pour chaque tuile on regarde si elle est liée à un mot vertical
                    {
                        int xi = tuile.getColumn();
                        int yi = tuile.getLine();
                        points = 0;
                        try
                        {
                            while (plat[yi][xi] != tile) // Verif vers le haut
                            {
                                yi++;
                                points++;
                            }
                        }
                        catch { }
                        yi -= points+1;
                        try
                        {
                            while (plat[yi][xi] != tile) // Verif vers le bas
                            {
                                points++;
                                yi--;
                            }
                        }
                        catch { }
                        if (points == 6)
                            points += 6;
                        if (points > 1)
                            setScoreTour(getScoreTour() + points);
                    }
                    // Maintenant on regarde la longueur du mot horizontal
                    points = 0;
                    int x = getPlaying().getTuiles()[0].getColumn();
                    int y = getPlaying().getTuiles()[0].getLine();
                    try
                    {
                        while (plat[y][x] != tile) // Vérif combi droite
                        {
                            x++;
                            points++;
                        }  
                    }
                    catch { } 
                    x -= points+1;
                    try
                    {
                        while (plat[y][x] != tile) // Verif combi gauche
                        {
                            points++;
                            x--;
                        }
                    }
                    catch { }
                    if (points == 6)
                        points += 6;
                    setScoreTour(getScoreTour() + points);
                    points = 0;
                }
                else // alignés verticalement
                {
                    foreach (Tuile tuile in getPlaying().getTuiles()) //Pour chaque tuile on regarde si elle est liée à un mot horizontal
                    {
                        int xi = tuile.getColumn();
                        int yi = tuile.getLine();
                        points = 0;
                        try
                        {
                            while (plat[yi][xi] != tile)
                            {
                                points++;
                                xi++;
                            }
                        }
                        catch { }
                        xi -= points+1;
                        try
                        {
                            while (plat[yi][xi] != tile)
                            {
                                points++;
                                xi--;
                            }
                        }
                        catch { }
                        if (points == 6)
                            points += 6;
                        if (points > 1)
                            setScoreTour(getScoreTour() + points);
                    }
                    // Maintenant on regarde la longueur du mot vertical
                    points = 0;
                    int x = getPlaying().getTuiles()[0].getColumn();
                    int y = getPlaying().getTuiles()[0].getLine();
                    try
                    {
                        while (plat[y][x] != tile)
                        {
                            points++;
                            y++;
                        }
                    }
                    catch { }
                    y -= points+1;
                    try
                    {
                        while (plat[y][x] != tile)
                        {
                            points++;
                            y--;
                        }
                    }
                    catch { }
                    if (points == 6)
                        points += 6;
                    setScoreTour(getScoreTour() + points);
                    points = 0;
                }
            }
            else // une seule tuile
            {
                int xi = getPlaying().getTuiles()[0].getColumn();
                int yi = getPlaying().getTuiles()[0].getLine();
                points = 0;
                try
                {
                    while (plat[yi][xi] != tile) // Si liée à un mot horizontal ( à droite )
                    {
                        points++;
                        xi++;
                    }
                }
                catch { }
                xi -= points+1;
                int save = xi;
                try
                {
                    while (plat[yi][xi] != tile) // (à gauche)
                    {
                        points++;
                        xi--;
                    }
                }
                catch { }
                if (points == 6)
                    points += 6;
                if (points > 1)
                    setScoreTour(getScoreTour() + points);
                if (xi == save)
                    xi++;
                else
                    xi += points;
                points = 0;
                try
                {
                    while (plat[yi][xi] != tile) // Si liée à un mot vertical ( vers le haut )
                    {
                        points++;
                        yi++;
                    }
                }
                catch { }
                yi -= points+1;
                try
                {
                    while (plat[yi][xi] != tile) // (vers le bas)
                    {
                        points++;
                        yi--;
                    }
                }
                catch { }
                if (points == 6)
                    points += 6;
                if (points > 1)
                    setScoreTour(getScoreTour() + points);
                points = 0;
            }

            foreach(Tuile tuile in getPlaying().getTuiles()) // On définit les tuiles comme étant jouées
            {
                if(tuile != null)
                    tuile.setPlacable(false);
            }

            // Ajout des points
            setScoreTot(getScoreTot() + getScoreTour());

            pioche.giveTuilesToPlayer(this, getPlaying().NbTuiles()); // On redonne l'équivalent en tuiles
        }
    }
}
