using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Qwirkle;

namespace TestProjet
{
    [TestClass]
    public class TestTuile
    {
        [TestMethod]
        public void TestSetAGetCouleur()
        {
            Tuile tuile = new Tuile("Vert", "Rond");
            Assert.AreEqual("Vert", tuile.getCouleur());
            tuile.setCouleur("Rouge");
            Assert.AreEqual("Rouge", tuile.getCouleur());
        }
        [TestMethod]
        public void TestSetForme()
        {
            Tuile tuile = new Tuile("Vert", "Rond");
            Assert.AreEqual("Rond", tuile.getForme());
            tuile.setForme("Etoile");
            Assert.AreEqual("Etoile", tuile.getForme());
        }
        [TestMethod]
        public void TestSetPlacable()
        {
            Tuile tuile = new Tuile("Vert", "Rond", true,null);
            Assert.IsTrue(tuile.getPlacable());
            tuile.setPlacable(false);
            Assert.IsFalse(tuile.getPlacable());
        }
        [TestMethod]
        public void TestSetAGetDetenteur()
        {
            Tuile tuile = new Tuile("Vert", "Rond", true, null);
            Joueur Paul = new Joueur();
            Assert.AreEqual(null, tuile.getDetenteur());
            tuile.setDetenteur(Paul);
            Assert.AreEqual(Paul, tuile.getDetenteur());
        }
    }
}
