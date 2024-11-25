using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qwirkle;

namespace TestProjet
{
    [TestClass]
    public class TestPlateau
    {
        /*
         Classe de méthodes testant la classe Plateau
         */
        [TestMethod]
        public void TestAccessNbLines()
        {
            /*
             Tests des accesseurs du nombre de lignes
                - setNbLines(int) : void
                - getNbLines() : int
             */
            Assert.AreEqual(29, Plateau.getNbLines());
            Plateau.setNbLines(8);
            Assert.AreEqual(8, Plateau.getNbLines());
            Plateau.setNbLines(-1);
            Assert.AreEqual(8, Plateau.getNbLines());
            Plateau.setNbLines(0);
            Assert.AreEqual(8, Plateau.getNbLines());
            Plateau.setNbLines(10);
            Assert.AreEqual(10, Plateau.getNbLines());
            Plateau.setNbLines(1);
        }
        [TestMethod]
        public void TestAccessNbColumns()
        {
            /*
             Tests des accesseurs du nombre de colonnes
                - setNbColumns(int) : void
                - getNbColumns() : int
             */
            Assert.AreEqual(29, Plateau.getNbColumns());
            Plateau.setNbColumns(8);
            Assert.AreEqual(8, Plateau.getNbColumns());
            Plateau.setNbColumns(-1);
            Assert.AreEqual(8, Plateau.getNbColumns());
            Plateau.setNbColumns(0);
            Assert.AreEqual(8, Plateau.getNbColumns());
            Plateau.setNbColumns(10);
            Assert.AreEqual(10, Plateau.getNbColumns());
            Plateau.setNbColumns(1);
        }
        [TestMethod]
        public void TestResetGrid()
        {
            List<List<Tuile>> test_list = new List<List<Tuile>>();
            List<List<Tuile>> liste_initiale = new List<List<Tuile>>(1) { new List<Tuile>(1) { new Tuile() } };
            List<Tuile> line_1 = new List<Tuile>(), line_2 = new List<Tuile>();
            line_1.Add(new Tuile("rouge", "rond"));
            line_1.Add(new Tuile("bleu", "carré"));
            line_1.Add(new Tuile("vert", "triangle"));
            line_2.Add(new Tuile("bleu", "carré"));
            line_2.Add(new Tuile("noir", "rond"));

            test_list.Add(line_1);
            test_list.Add(line_2);

            Plateau.setGrid(test_list);
            Assert.AreEqual(test_list, Plateau.getGrid());
            //Plateau.reset();
            Assert.AreEqual(liste_initiale.Count, Plateau.getGrid().Count);
            Assert.AreEqual(liste_initiale[0].Count, Plateau.getGrid().Count);
            Assert.AreEqual(1, Plateau.getNbColumns());
            Assert.AreEqual(1, Plateau.getNbLines());
            Assert.AreEqual(0, Plateau.getNbTuiles());
            Assert.AreEqual(null, Plateau.getGrid()[0][0]);
        }
        [TestMethod]
        public void TestAccessGrid()
        {
            /*
             Tests des accesseurs de la grille du plateau (contenant les tuiles)
                - setGrid(List<List<Tuile>>) : void
                - getGrid() : List<List<Tuile>>
             */
            //Plateau.reset();
            List<List<Tuile>> test_list = new List<List<Tuile>>();
            List<List<Tuile>> list_initiale = new List<List<Tuile>>();
            list_initiale.Add(new List<Tuile>());
            list_initiale[0].Add(null);
            List<Tuile> line_1 = new List<Tuile>(), line_2 = new List<Tuile>();

            line_1.Add(new Tuile("rouge", "rond"));
            line_1.Add(new Tuile("bleu", "carré"));
            line_1.Add(new Tuile("vert", "triangle"));
            line_2.Add(new Tuile("bleu", "carré"));
            line_2.Add(new Tuile("noir", "rond"));

            test_list.Add(line_1);
            test_list.Add(line_2);

            Assert.AreEqual(null, Plateau.getGrid()[0][0]);
            Plateau.setGrid(test_list);
            Assert.AreEqual(2, Plateau.getGrid().Count);
            Assert.AreEqual(0, Plateau.getGrid().IndexOf(line_1));
            Assert.AreEqual(1, Plateau.getGrid().IndexOf(line_2));
            Plateau.setGrid(list_initiale);
        }
        [TestMethod]
        public void TestGetNbTuiles()
        {
            /*
             Tests du getter du nombre de tuiles posées sur le plateau :
                - getNbTuiles() : int
             */
            //Plateau.reset();
            List<List<Tuile>> test_list = new List<List<Tuile>>();
            
            List<Tuile> line_1 = new List<Tuile>(), line_2 = new List<Tuile>();
            line_1.Add(new Tuile("rouge", "rond"));
            line_1.Add(new Tuile("bleu", "carré"));
            line_1.Add(new Tuile("vert", "triangle"));
            line_2.Add(new Tuile("bleu", "carré"));
            line_2.Add(new Tuile("noir", "rond"));

            test_list.Add(line_1);
            test_list.Add(line_2);

            Plateau.setGrid(test_list);
            Assert.AreEqual(5, Plateau.getNbTuiles());
            test_list.Clear();
            test_list.Add(line_2);
            Plateau.setGrid(test_list);
            Assert.AreEqual(2, Plateau.getNbTuiles());
            test_list.Clear();
            line_1.Clear();
            line_1.Add(null);
            test_list.Add(line_1);
            Plateau.setGrid(test_list);
            Assert.AreEqual(0, Plateau.getNbTuiles());
            //Plateau.reset();
        }
        [TestMethod]
        public void TestSetNbTuiles()
        {
            /*
             Tests du setter du nombre de tuiles posées sur le plateau
                - setNbTuiles(int) : void
                - getNbTuiles() : int
             */
            //Plateau.reset();
            Assert.AreEqual(0, Plateau.getNbTuiles());
            Plateau.setNbTuiles(-9);
            Assert.AreEqual(0, Plateau.getNbTuiles());
            Plateau.setNbTuiles(10);
            Assert.AreEqual(10, Plateau.getNbTuiles());
            Plateau.setNbTuiles(109);
            Assert.AreEqual(109, Plateau.getNbTuiles());
            Plateau.setNbTuiles(0);
        }
        [TestMethod]
        public void TestControlLines()
        {
            /*
             Tests des contrôleurs de lignes du plateau :
                - addLine(int) : void
                - removeLine(int) : void
             */
            //Plateau.reset();
            Assert.AreEqual(1, Plateau.getGrid().Count);
            Plateau.addLine(5);
            Assert.AreEqual(1, Plateau.getGrid().Count);
            Plateau.removeLine(5);
            Assert.AreEqual(1, Plateau.getGrid().Count);
            Plateau.addLine(0);
            Assert.AreEqual(2, Plateau.getGrid().Count);
            Plateau.addLine(-8);
            Plateau.removeLine(3);
            Assert.AreEqual(2, Plateau.getGrid().Count);
            Plateau.addLine(1);
            Assert.AreEqual(3, Plateau.getGrid().Count);
            Plateau.removeLine(0);
            Assert.AreEqual(2, Plateau.getGrid().Count);
            Plateau.removeLine(0);
            Assert.AreEqual(1, Plateau.getGrid().Count);
            Plateau.removeLine(0);
            Assert.AreEqual(1, Plateau.getGrid().Count);
        }
        [TestMethod]
        public void TestControlColumns()
        {
            /*
             Tests des contrôleurs de colonnes du plateau : 
                - addColumn(int) : void
                - removeColumn(int) : void
             */
            //Plateau.reset();
            Assert.AreEqual(1, Plateau.getGrid()[0].Count);
            Plateau.addColumn(5);
            Assert.AreEqual(1, Plateau.getGrid()[0].Count);
            Plateau.removeColumn(5);
            Assert.AreEqual(1, Plateau.getGrid()[0].Count);
            Plateau.addColumn(0);
            Assert.AreEqual(2, Plateau.getGrid()[0].Count);
            Plateau.addColumn(-8);
            Plateau.removeColumn(3);
            Assert.AreEqual(2, Plateau.getGrid()[0].Count);
            Plateau.addColumn(1);
            Assert.AreEqual(3, Plateau.getGrid()[0].Count);
            Plateau.removeColumn(0);
            Assert.AreEqual(2, Plateau.getGrid()[0].Count);
            Plateau.removeColumn(0);
            Assert.AreEqual(1, Plateau.getGrid()[0].Count);
            Plateau.removeColumn(0);
            Assert.AreEqual(1, Plateau.getGrid()[0].Count);
        }
        [TestMethod]
        public void TestControlTuiles()
        {
            /*
             Tests des contrôleurs de tuiles sur le plateau :
                - addTuile(Tuile, int, int) : void
                - removeTuile(int, int) : void
             */
            Tuile tuile1 = new Tuile("Rouge", "Rond");
            Tuile tuile2 = new Tuile("Bleu", "Carré");
            Assert.AreEqual(null, Plateau.getGrid()[0][0]);
            Plateau.addTuile(tuile1, 0, 0);
            Assert.AreEqual(tuile1, Plateau.getGrid()[0][0]);
            Plateau.addTuile(tuile1, 5, 8);
            Assert.AreEqual(1, Plateau.getNbTuiles());
            Plateau.removeTuile(0, 0);
            Assert.AreEqual(0, Plateau.getNbTuiles());
            Plateau.addTuile(tuile2, 0, 0);
            Assert.AreNotEqual(tuile1, Plateau.getGrid()[0][0]);
            Assert.AreEqual(tuile2, Plateau.getGrid()[0][0]);
            Plateau.addTuile(tuile1, 0, 1);
            Assert.AreEqual(tuile1, Plateau.getGrid()[0][1]);
            Plateau.removeTuile(0, 0);
            Assert.AreEqual(tuile1, Plateau.getGrid()[0][0]);
            Plateau.removeTuile(0, 0);
            Assert.AreEqual(null, Plateau.getGrid()[0][0]);
        }
    }
}
