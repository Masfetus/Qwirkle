using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle
{
    public class Combinaison
    {
        protected List<Tuile> tuiles;

        public Combinaison()
        {
            this.tuiles = new List<Tuile>();
        }
        public Combinaison(List<Tuile> tuiles)
        {
            this.tuiles = tuiles;
        }
        public void setTuiles(List<Tuile> tuiles)
        {
            this.tuiles = tuiles;
        }
        public List<Tuile> getTuiles()
        {
            return tuiles;
        }
        public int NbTuiles()
        {
            // Récupération du nombre de tuiles (non null) présentes dans la liste de tuiles de la combinaison
            int compt = 0;
            foreach (Tuile tuile in tuiles)
            {
                if (tuile != null)
                    compt++;
            }
            return compt;

        }
        public void addTuile(Tuile tuile)
        {
            // Ajout d'une tuile à la combinaison
            tuiles.Add(tuile);
        }
        public void removeTuile(Tuile tuile)
        {
            // Retrait d'une tuile de la combinaison
            tuiles.Remove(tuile);
        }
    }
}
