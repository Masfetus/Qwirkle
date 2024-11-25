using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qwirkle;
using System.Collections.Generic;

namespace TestProjet
{
    [TestClass]
    public class TestCombinaison
    {
        [TestMethod]
        public void TestNbTuiles()
        {
            List<Tuile> tuiles = new List<Tuile>();

            tuiles.Add(new Tuile("Rouge","Carre",true, null));
            tuiles.Add(new Tuile("Rouge", "Rond", true, null));
            tuiles.Add(new Tuile("Bleu", "Etoile", true, null));

            Combinaison ensemble_tuile = new Combinaison(tuiles);

            Assert.AreEqual(3, ensemble_tuile.NbTuiles());

        }

        [TestMethod]
        public void TestsetAgetTuiles()
        {
            Combinaison ensemble_tuile = new Combinaison();

            List<Tuile> list_tuiles = new List<Tuile>();
            list_tuiles.Add(new Tuile("Rouge", "Carre", true, null));
            list_tuiles.Add(new Tuile("Rouge", "Rond", true, null));
            list_tuiles.Add(new Tuile("Bleu", "Etoile", true, null));
            ensemble_tuile.setTuiles(list_tuiles);
            Assert.AreEqual(list_tuiles, ensemble_tuile.getTuiles());
        }

        [TestMethod]
        public void TestaddTuile()
        {
            List<Tuile> tuiles = new List<Tuile>();
            tuiles.Add(new Tuile("Rouge", "Carre", true, null));
            tuiles.Add(new Tuile("Rouge", "Rond", true, null));
            tuiles.Add(new Tuile("Bleu", "Etoile", true, null));

            Combinaison ensemble_tuile = new Combinaison(tuiles);

            Tuile VertRond = new Tuile("Vert", "Rond", true,null);
            ensemble_tuile.addTuile(VertRond);

            Assert.AreEqual(4, ensemble_tuile.NbTuiles());
        }

        [TestMethod]
        public void TestremoveTuile()
        {
            Tuile RougeCarre = new Tuile("Rouge", "Carre", true,null);
            Tuile RougeRond = new Tuile("Rouge", "Rond", true,null);
            Tuile BleuEtoile = new Tuile("Bleu", "Etoile", true,null);
            Tuile VertEtoile = new Tuile("Vert", "Etoile", true, null);

            Combinaison ensemble_tuile = new Combinaison();
            ensemble_tuile.addTuile(RougeCarre);
            ensemble_tuile.addTuile(RougeRond);
            ensemble_tuile.addTuile(BleuEtoile);

            ensemble_tuile.removeTuile(RougeRond);
            Assert.AreEqual(2, ensemble_tuile.NbTuiles());

            ensemble_tuile.removeTuile(VertEtoile);
            Assert.AreEqual(2, ensemble_tuile.NbTuiles());
        }
    }
}
