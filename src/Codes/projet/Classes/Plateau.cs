using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle
{
    public static class Plateau
    {
        private static int nbLines = 29, nbColumns = 29, nbTuiles = 0;
        private static List<List<Tuile>> grid = initGrid();


        public static void setNbLines(int number)
        {
            if (number > 0)
                nbLines = number;
        }
        public static void setNbColumns(int number)
        {
            if (number > 0)
                nbColumns = number;
        }
        public static void setNbTuiles(int number)
        {
            if (number >= 0)
            {
                nbTuiles = number;
            }

        }
        
        
        private static List<List<Tuile>> initGrid()
        {
            /* Méthode initialisant la liste statique du plateau */

            List<List<Tuile>> res = new List<List<Tuile>>();
            for (int id_line = 0; id_line < 30; id_line++) // On fait une itération de plus car le constructeur de List<List<Tuile>>() fournit déjà un élément
            {
                List<Tuile> line_to_add = new List<Tuile>();
                for (int id_column = 0; id_column < 29; id_column++)
                {
                    line_to_add.Add(null); // De base, toutes les tuiles sont initialisées à null
                }
                res.Add(line_to_add);
            }
            res.RemoveAt(0); // On retire le premier élément fourni par le constructeur
            return res;
        }
        public static void setGrid(List<List<Tuile>> gridPlat)
        {

            if (gridPlat != null)
            {
                grid = gridPlat;
                nbLines = 0;
                nbColumns = 0;
                nbTuiles = 0;
                foreach (List<Tuile> line in grid)
                {
                    foreach (Tuile tuile in line)
                    {
                        if (tuile != null)
                            setNbTuiles(getNbTuiles() + 1);
                        setNbColumns(getNbColumns() + 1);
                    }
                    setNbLines(getNbLines() + 1);
                }
            }
        }
        public static int getNbLines()
        {
            return nbLines;
        }
        public static int getNbColumns()
        {
            return nbColumns;
        }
        public static int getNbTuiles()
        {
            return nbTuiles;
        }
        public static List<List<Tuile>> getGrid()
        {
            return grid;
        }
        public static void addLine(int index)
        {
            /* Méthode solicitée pour une gestion du plateau dynamique ajoutant une ligne à l'index donné */

            if (index >= 0 && index < nbLines)
            {
                grid.Insert(index, new List<Tuile>());
                for (int column_index = 0; column_index < getNbColumns(); column_index++)
                    getGrid()[index].Add(null);
                setNbLines(getNbLines() + 1);
            }
        }
        public static void removeLine(int index)
        {
            /* Méthode solicitée pour une gestion du plateau dynamique retirant la ligne d'index donné*/

            if (((index >= 0 && getNbLines() > 1) || (index > 0)) && index < getNbLines())
            {
                if (getGrid()[index] != null)
                {
                    grid.RemoveAt(index);
                    setNbLines(getNbLines() - 1);
                }
            }
        }
        public static void addColumn(int index)
        {
            /* Méthode solicitée pour une gestion du plateau dynamique ajoutant une colonne à l'index donné */

            if (index >= 0 && index < nbColumns)
            {
                foreach (List<Tuile> line in grid)
                {
                    if (line != null)
                        line.Insert(index, null);
                }
                setNbColumns(getNbColumns() + 1);
            }
        }
        public static void removeColumn(int index)
        {
            /* Méthode solicitée pour une gestion du plateau dynamique retirant une colonne de l'index donné */

            if (((index >= 0 && getNbColumns() > 1) || (index > 0)) && index < getNbColumns())
            {
                foreach (List<Tuile> line in grid)
                {
                    if (line != null)
                    {
                        line.RemoveAt(index);
                    }
                }
                setNbColumns(getNbColumns() - 1);
            }
        }
        public static void addTuile(Tuile tuile, int Line, int Column)
        {
            // Méthode ajoutant une tuile au plateau de jeu
            if (Line >= 0 && Line < getNbLines() && Column >= 0 && Column < getNbColumns()) // Vérification si nous sommes bien dans le tableau
            {
                List<Tuile> player_main = tuile.getDetenteur().getMainTuile().getTuiles(); // Main du joueur qui joue (en List<Tuile>)

                tuile.getDetenteur().getPlaying().addTuile(tuile); // On rajoute à la combinaison de jeu du joueur, la tuile qu'il vient de jouer
                tuile.getDetenteur().getMainTuile().getTuiles()[player_main.IndexOf(tuile)] = null;
                grid[Line][Column] = tuile;
                setNbTuiles(getNbTuiles() + 1);
                tuile.setColumn(Column);
                tuile.setLine(Line);
            }
        }
        public static int removeTuile(int Line, int Column)
        {
            // Méthode retirant une tuile du plateau de jeu
            int res = -1;
            if (Line < nbLines && Line >= 0 && Column >= 0 && Column < nbColumns)
            {
                Tuile tuile_to_delete = grid[Line][Column];
                if (tuile_to_delete != null && tuile_to_delete.getPlacable() == true)
                {
                    setNbTuiles(getNbTuiles() - 1);

                    do // Recherche du premier indice libre dans la main du joueur
                        res++;
                    while (tuile_to_delete.getDetenteur().getMainTuile().getTuiles()[res] != null && res < 6);
                    tuile_to_delete.getDetenteur().getMainTuile().getTuiles()[res] = tuile_to_delete; // On rajoute la tuile qui vient d'être retirée
                    grid[Line][Column] = null;
                }
            }
            return res;
        }
        public static void reset()
        {
            // Méthode réinitialisant le plateau de jeu
            grid.Clear();
            grid = initGrid();
            nbTuiles = 0;
        }
        public static bool VerifMot(int id_line, int id_column, Tuile tuile_to_add)
        {
            // Méthode vérifiant la validité d'un mot sur le plateau de jeu (on 
            bool placable = false;
            int indice, incr,here,there;
            int combi_to_check = 0, combi_ok = 0;
            List<Combinaison> ensemble_combinaison = new List<Combinaison>(); 
            // Remonter le(s) mot(s) en ligne et/ou en colonne jusqu'a null, verif une caract commune par mot sans doublon / récupération de l'ensemble des combinaisons adjacentes
            for(int i =0; i<2;i++)
            {
                if (i == 0)
                {
                    here = 0;
                    there = 1;
                }
                else
                {
                    here = 1;
                    there = 0;
                }
                Combinaison mot = new Combinaison();
                for (int j =0; j<2;j++)
                {
                    if (j == 0)
                        incr = 1;
                    else
                        incr = -1;
                    indice = 1;
                    try
                    {
                        while (grid[id_line + incr * indice * here][id_column + incr * indice * there] != null)
                        {
                            mot.addTuile(grid[id_line + incr * indice * here][id_column + incr * indice * there]);
                            indice++;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    ensemble_combinaison.Add(mot);

                }
            }
            // Analyse de l'ensemble de combinaisons
            foreach ( Combinaison combi in ensemble_combinaison)
            {
                if(combi.NbTuiles() != 0) // Pour chaque combinaison non vide
                {
                    combi_to_check++;
                    List<Tuile> tuiles_combi = combi.getTuiles();
                    int id_tuile = 0;
                    bool stop_loop = false;
                    if(tuiles_combi[0].getCouleur() == tuile_to_add.getCouleur()) // S'il y a cohérence de couleur entre la tuile adjacente à la tuile à ajouter
                    {
                        while (id_tuile < tuiles_combi.Count && !stop_loop) // On vérifie chacune des autres tuiles de combinaison pour éviter les doublons
                        {
                            if (tuiles_combi[id_tuile].getCouleur() == tuile_to_add.getCouleur() && tuiles_combi[id_tuile].getForme() != tuile_to_add.getForme())
                            {
                                id_tuile++;
                            }
                            else
                                stop_loop = true;
                        }
                    }
                    else // Sinon on se focalise sur la forme de la tuile
                    {
                        while (id_tuile < tuiles_combi.Count && !stop_loop)
                        {
                            if (tuiles_combi[id_tuile].getForme() == tuile_to_add.getForme() && tuiles_combi[id_tuile].getCouleur() != tuile_to_add.getCouleur())
                            {
                                id_tuile++;
                            }
                            else
                                stop_loop = true;
                        }
                    }
                    if (!stop_loop) // Si la boucle ne s'est pas arrêtée c'est qu'il y a eu cohérence entre chacune des tuiles de la combinaison
                        combi_ok++;
                }
            }

            if (combi_ok == combi_to_check && checkAlignment(id_line, id_column, tuile_to_add)) // On renvoie vrai si la combinaison est bonne et si les tuiles sont bien alignées
                placable = true;

            return placable;
        }
        public static List<Tuile> tuile_adja(int id_line, int id_column)
        {
            // Méthode retournant l'ensemble des tuiles adjacentes
            List<Tuile> res = new List<Tuile>();
            int nb_tuiles_adja = 0;

            // Ici on va essayer de récupérer les valeurs des tuiles adjacentes, si on y parvient alors on ajoute l'élément à la liste.
            try
            {
                if (getGrid()[id_line - 1][id_column] != null)
                {
                    nb_tuiles_adja++;
                    res.Add(getGrid()[id_line - 1][id_column]);
                }
                    
            }
            catch { }
            try
            {
                if (getGrid()[id_line + 1][id_column] != null)
                {
                    nb_tuiles_adja++;
                    res.Add(getGrid()[id_line + 1][id_column]);
                }
            }
            catch { }

            try
            {
                if (getGrid()[id_line][id_column - 1] != null)
                {
                    nb_tuiles_adja++;
                    res.Add(getGrid()[id_line][id_column - 1]);
                }
            }
            catch { }

            try
            {
                if (getGrid()[id_line][id_column + 1] != null)
                {
                    nb_tuiles_adja++;
                    res.Add(getGrid()[id_line][id_column + 1]);
                }
            }
            catch { }
            return res;
        }
        private static bool checkAlignment(int id_line, int id_column, Tuile tuile_to_add)
        {
            // Méthode vérifiant l'alignement d'une tuile
            bool res = false, stop_loop = false;
            int maximum = 0, minimum = 0, indice_tuile = 0;
            Joueur current_player = Joueur.getCurrentPlayer();
            if (current_player.getPlaying().NbTuiles() == 1) // S'il n'y a qu'une seule tuile de posée par le joueur, il faut déterminer si elle est alignée avec les tuiles adjacentes
            {
                if (id_line == current_player.getPlaying().getTuiles()[0].getLine()) // Alignement en ligne
                {

                    maximum = Math.Max(id_column, current_player.getPlaying().getTuiles()[0].getColumn()); // On récupère le maximum de l'id de colonnes
                    minimum = Math.Min(id_column, current_player.getPlaying().getTuiles()[0].getColumn()); // Idem pour le minimum
                    indice_tuile = minimum + 1;
                    while (indice_tuile <= maximum && !stop_loop) // Vérification vers la droite
                    {
                        if (getGrid()[id_line][indice_tuile] == null)
                            stop_loop = true;
                        else
                            indice_tuile++;
                    }
                    if(stop_loop)
                    {
                        indice_tuile = maximum - 1;
                        stop_loop = false;
                        while (indice_tuile >= minimum && !stop_loop) // Vérification vers la gauche
                        {
                            if (getGrid()[id_line][indice_tuile] == null)
                                stop_loop = true;
                            else
                                indice_tuile--;
                        }
                    }
                }
                else if (id_column == current_player.getPlaying().getTuiles()[0].getColumn()) // Alignement en colonne
                {

                    maximum = Math.Max(id_line, current_player.getPlaying().getTuiles()[0].getLine());
                    minimum = Math.Min(id_line, current_player.getPlaying().getTuiles()[0].getLine());
                    indice_tuile = minimum + 1;
                    while (indice_tuile <= maximum && !stop_loop) // Vérif vers le bas
                    {
                        if (getGrid()[indice_tuile][id_column] == null)
                            stop_loop = true;
                        else
                            indice_tuile++;
                    }
                    if (stop_loop)
                    {
                        indice_tuile = maximum - 1;
                        stop_loop = false;
                        while (indice_tuile >= minimum && !stop_loop) // Vérif vers le haut
                        {
                            if (getGrid()[indice_tuile][id_column] == null)
                                stop_loop = true;
                            else
                                indice_tuile--;
                        }
                    }
                }
                else
                    stop_loop = true;
                res = !stop_loop;


            }
            else if(current_player.getPlaying().NbTuiles() > 1) // Sinon on vérifie l'alignement de la combinaison jouée
            {
                int line_firsttuile = current_player.getPlaying().getTuiles()[0].getLine(), column_firsttuile = current_player.getPlaying().getTuiles()[0].getColumn(); // Sinon on stocke l'id de la première tuile de colonne et ligne
                Tuile tuile = current_player.getPlaying().getTuiles()[1]; // On stocke la deuxième tuile

                if ((tuile.getLine() == line_firsttuile && id_line == line_firsttuile) || (tuile.getColumn() == column_firsttuile && column_firsttuile == id_column)) // Et on vérifie l'alignement  entre ces numéros de colonnes et lignes avec ceux passés en paramètres
                    res = true;
                else
                    res = false;
            }
            else
                res = true;
            return res;
        }
    }
}
