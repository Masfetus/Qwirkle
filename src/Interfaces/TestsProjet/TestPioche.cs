using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Qwirkle;

namespace TestProjet
{
    [TestClass]
    public class TestPioche
    {
        [TestMethod]
        public void TestgiveTuilesToPlayer()
        {
            Tuile RougeCarre = new Tuile("Rouge", "Carre", true,null);
            Tuile RougeRond = new Tuile("Rouge", "Rond", true,null);
            Tuile BleuEtoile = new Tuile("Bleu", "Etoile", true,null);

            Combinaison main_joueur = new Combinaison();
            main_joueur.addTuile(RougeCarre);
            main_joueur.addTuile(RougeRond);
            main_joueur.addTuile(BleuEtoile);
            Joueur Paul = new Joueur();
            Paul.setMainTuile(main_joueur);

            Pioche pioche = new Pioche();

            pioche.giveTuilesToPlayer(Paul, 3);
            Assert.AreEqual(6, Paul.getMainTuile().NbTuiles());
            Assert.AreEqual(105, pioche.NbTuiles());

        }

        [TestMethod]
        public void TestechangeTuiles()
        {
            Tuile RougeCarre = new Tuile("Rouge", "Carre", true,null);
            Tuile RougeRond = new Tuile("Rouge", "Rond", true,null);
            Tuile BleuEtoile = new Tuile("Bleu", "Etoile", true,null);
            Tuile VertLosange = new Tuile("Vert", "Losange", true,null);
            Tuile VioletEtoile = new Tuile("Violet", "Etoile", true,null);
            Tuile JauneRond = new Tuile("Jaune", "Rond", true,null);
            
            Combinaison Aechanger = new Combinaison();
            Aechanger.addTuile(RougeCarre);
            Aechanger.addTuile(RougeRond);
            Aechanger.addTuile(BleuEtoile);

            List<Tuile> pioche_init = new List<Tuile>();
            pioche_init.Add(VertLosange);
            pioche_init.Add(VioletEtoile);
            pioche_init.Add(JauneRond);

            Pioche pioche = new Pioche(pioche_init);

            List<Tuile> pioche_final = new List<Tuile>();
            pioche_final.Add(RougeCarre);
            pioche_final.Add(RougeRond);
            pioche_final.Add(BleuEtoile);

            Pioche pioche_finale = new Pioche(pioche_final);
            

            Assert.AreEqual(pioche_init, pioche.getTuiles());
            pioche.echangeTuiles(Aechanger);
            
            for(int indice = 0; indice < pioche.getTuiles().Count; indice ++)
                Assert.AreEqual(pioche_finale.getTuiles()[indice], pioche.getTuiles()[indice]);

            Combinaison Aechanger2 = new Combinaison();
            Aechanger2.addTuile(RougeCarre);
            Aechanger2.addTuile(RougeRond);

            Pioche pioche2 = new Pioche();
            pioche2.addTuile(VertLosange);
            pioche2.addTuile(VioletEtoile);
            pioche2.addTuile(JauneRond);

            pioche2.echangeTuiles(Aechanger2);
            for(int indice = 0, indice2=0; indice < Aechanger2.getTuiles().Count; indice ++)
            {
                while(Aechanger2.getTuiles()[indice]!=pioche2.getTuiles()[indice2] && indice2 < pioche2.getTuiles().Count)
                {
                    indice2++;
                }
                Assert.AreEqual(Aechanger2.getTuiles()[indice], pioche2.getTuiles()[indice2]);
            }

            Combinaison Aechanger3 = new Combinaison();
            Aechanger3.addTuile(RougeCarre);
            Aechanger3.addTuile(RougeRond);
            Aechanger3.addTuile(VertLosange);

            List<Tuile> Lpioche = new List<Tuile>();
            Lpioche.Add(VioletEtoile);
            Pioche pioche3 = new Pioche(Lpioche);

            Assert.AreEqual(Aechanger3, pioche3.echangeTuiles(Aechanger3));


        }
    }
}
