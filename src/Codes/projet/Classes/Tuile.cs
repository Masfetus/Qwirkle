using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle
{
    public class Tuile
    {
        private string couleur, forme;
        private bool placable;
        private int line, column;
        private Joueur detenteur;

        public Tuile()
        {
            this.couleur = null;
            this.forme = null;
            this.placable = false;
            line = -1;
            column = -1;
            this.detenteur = null;
        }
        public Tuile(string couleur, string forme, bool placable = true, Joueur player = null)
        {
            this.couleur = couleur;
            this.forme = forme;
            this.placable = placable;
            this.detenteur = player;
            line = -1;
            column = -1;
        }
        public void setCouleur(string color)
        {
            this.couleur = color;
        }
        public void setForme(string style)
        {
            this.forme = style;
        }
        public void setPlacable(bool value)
        {
            this.placable = value;
        }
        public void setDetenteur(Joueur player)
        {
            this.detenteur = player;
        }
        public void setLine(int id_line)
        {
            line = id_line;
        }
        public int getLine()
        {
            return line;
        }
        public void setColumn(int id_column)
        {
            column = id_column;
        }
        public int getColumn()
        {
            return column;
        }
        public string getCouleur()
        {
            return couleur;
        }
        public string getForme()
        {
            return forme;
        }
        public bool getPlacable()
        {
            return placable;
        }
        public Joueur getDetenteur()
        {
            return detenteur;
        }
    }
}
