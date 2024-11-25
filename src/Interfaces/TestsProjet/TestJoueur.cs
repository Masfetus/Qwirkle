using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Qwirkle;

namespace TestProjet
{
    [TestClass]
    public class TestJoueur
    {
        [TestMethod]
        public void TestSetAGetPseudo()
        {
            Joueur joueur = new Joueur();
            Assert.AreEqual(null, joueur.getPseudo());
            joueur.setPseudo("Maurice");
            Assert.AreEqual("Maurice", joueur.getPseudo());
        }

        [TestMethod]
        public void TestSetScoreTot()
        {
            Joueur joueur = new Joueur();
            Assert.AreEqual(0, joueur.getScoreTot());
            joueur.setScoreTot(10);
            Assert.AreEqual(10, joueur.getScoreTot());
        }

        [TestMethod]
        public void TestSetNoTour()
        {
            Joueur joueur = new Joueur();
            joueur.setNoTour(1);
            Assert.AreEqual(1, joueur.getNoTour());
        }
        
        [TestMethod]
        public void TestSetMainTuile()
        {
            Joueur joueur = new Joueur();
            List<Tuile> tuiles = new List<Tuile>();
            tuiles.Add(new Tuile("Rouge", "Carre", true,null));
            tuiles.Add(new Tuile("Rouge", "Rond", true,null));
            tuiles.Add(new Tuile("Bleu", "Etoile", true,null));

            Combinaison combinaison = new Combinaison(tuiles);
            joueur.setMainTuile(combinaison);

            Assert.AreEqual(combinaison, joueur.getMainTuile());
        }
        
        [TestMethod]
        public void TestSetPlaying()
        {
            Joueur joueur = new Joueur();
            List<Tuile> tuiles = new List<Tuile>();
            tuiles.Add(new Tuile("Rouge", "Carre", true, null));
            tuiles.Add(new Tuile("Rouge", "Rond", true,null));
            tuiles.Add(new Tuile("Bleu", "Etoile", true,null));

            Combinaison combinaison = new Combinaison(tuiles);
            joueur.setPlaying(combinaison);
            Assert.AreEqual(combinaison, joueur.getPlaying());
        }

        [TestMethod]
        public void TestSetNbJoueurs()
        {
            Joueur.setNbJoueurs(1);
            Assert.AreEqual(1, Joueur.getNbJoueurs());
        }

        [TestMethod]
        public void TestGiveUp()
        {
            List<Joueur> lst = new List<Joueur>();
            Pioche pio = new Pioche();
            Joueur joueur = new Joueur("Maurice", 0);
            Joueur.setNbJoueurs(1);
            pio.giveTuilesToPlayer(joueur, 6);
            lst.Add(joueur);
            Joueur.setPlayerList(lst);
            Assert.AreEqual(0, joueur.getNoTour());
            Assert.AreEqual(1, Joueur.getNbJoueurs());
            Assert.AreEqual(6, joueur.getMainTuile().NbTuiles());
            Assert.AreEqual(102, pio.NbTuiles());
            joueur.giveUp(pio);
            lst.Remove(joueur);
            Assert.AreEqual(-1, joueur.getNoTour());
            Assert.AreEqual(0, Joueur.getNbJoueurs());
            Assert.AreEqual(108, pio.NbTuiles());
        }

        [TestMethod]
        public void TestChooseOrder()
        {
            Combinaison mainPaul = new Combinaison(); // Combi max = 2
            mainPaul.addTuile(new Tuile("Rouge", "Carre"));
            mainPaul.addTuile(new Tuile("Rouge", "Rond"));
            mainPaul.addTuile(new Tuile("Violet", "Etoile"));
            mainPaul.addTuile(new Tuile("Vert", "Soleil"));
            mainPaul.addTuile(new Tuile("Bleu", "Carre"));
            mainPaul.addTuile(new Tuile("Jaune", "Trefle"));
            Combinaison mainAlex = new Combinaison(); // Combi max = 4
            mainAlex.addTuile(new Tuile("Rouge", "Carre"));
            mainAlex.addTuile(new Tuile("Rouge", "Rond"));
            mainAlex.addTuile(new Tuile("Violet", "Carre"));
            mainAlex.addTuile(new Tuile("Vert", "Carre"));
            mainAlex.addTuile(new Tuile("Bleu", "Carre"));
            mainAlex.addTuile(new Tuile("Jaune", "Trefle"));
            Combinaison mainTheo = new Combinaison(); // Combi max = 3
            mainTheo.addTuile(new Tuile("Rouge", "Carre"));
            mainTheo.addTuile(new Tuile("Rouge", "Rond"));
            mainTheo.addTuile(new Tuile("Violet", "Etoile"));
            mainTheo.addTuile(new Tuile("Vert", "Soleil"));
            mainTheo.addTuile(new Tuile("Bleu", "Carre"));
            mainTheo.addTuile(new Tuile("Rouge", "Trefle"));
            Joueur Paul = new Joueur("Paul");
            Paul.setMainTuile(mainPaul);
            Joueur Alex = new Joueur("Alex");
            Alex.setMainTuile(mainAlex);
            Joueur Theo = new Joueur("Theo");
            Theo.setMainTuile(mainTheo);
            List<Joueur> PlayerList = new List<Joueur>(); // 3 joueurs
            PlayerList.Add(Paul);
            PlayerList.Add(Alex);
            PlayerList.Add(Theo);
            List<Joueur> Ordonne = new List<Joueur>();
            Ordonne.Add(Alex);
            Ordonne.Add(Theo);
            Ordonne.Add(Paul);

            List<Joueur> Test = Joueur.ChooseOrder(PlayerList);
            for (int indice = 0, indice2 = 0; indice <Ordonne.Count; indice++)
            {
                indice2 = 0;
                while (Test[indice2] != Ordonne[indice] && indice2 < Ordonne.Count)
                {
                    indice2++;
                }
                Assert.AreEqual(Ordonne[indice], Test[indice2]);
            }
        }
        [TestMethod]
        public void TestChooseRanking()
        {
            Joueur Paul = new Joueur();
            Paul.setScoreTot(20);
            Joueur Alex = new Joueur();
            Alex.setScoreTot(40);
            Joueur Theo = new Joueur();
            Theo.setScoreTot(30);
            List<Joueur> tab_joueurs = new List<Joueur>();
            tab_joueurs.Add(Paul);
            tab_joueurs.Add(Alex);
            tab_joueurs.Add(Theo);
            List<Joueur> Ordonne = new List<Joueur>();
            Ordonne.Add(Alex);
            Ordonne.Add(Theo);
            Ordonne.Add(Paul);
            List<Joueur> Test = Joueur.ChooseRanking(tab_joueurs);
            for (int indice = 0, indice2 = 0; indice < Ordonne.Count; indice++)
            {
                indice2 = 0;
                while (Test[indice2] != Ordonne[indice] && indice2 < Ordonne.Count)
                {
                    indice2++;
                }
                Assert.AreEqual(Ordonne[indice], Test[indice2]);
            }
        }
    }
}
