using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VocableTrainer
{
    [TestClass]
    public class Testklasse
    {
    
        [TestMethod]
        public void GUIGameTestetObAntwortRichtigIst()
        {  
            //Arrange
            GUIGame g =GUIGame.GetInstance();
            g.Solution = "korrekt";
            //Act & Assert
            Assert.IsTrue(GUIGame.IsAnswerCorrect("korrekt"));
            Assert.IsFalse(GUIGame.IsAnswerCorrect("falsch"));

        }
        [TestMethod]
        public void GUIGameErstelltNeueAntworten()
        {
            //Arrange
            GUIGame g = GUIGame.GetInstance();
            g.Answer1 = "Anwort1";
            //Act
            GUIGame.Next();
            //Assert
            Assert.IsFalse(g.Answer1.Equals("Antwort1"));
        }
        [TestMethod]
        public void PunkteWerdenGezaehlt()
        {
            //Arrange
            Points punkte = Points.GetInstance();
            //Act
            for (int i = 0; i < 5; i++)
            {
                punkte.AnswerIsRight();
            }
            //Assert
            Assert.AreEqual(5, punkte.Right);

        }
        [TestMethod]
        public void PunkteWerdenZurueckGesetzt()
        {
            //Arrange
            Points punkte = Points.GetInstance();
            //Act
            for (int i = 0; i < 5; i++)
            {
                punkte.AnswerIsRight();
            }
            punkte.Reset();
            //Assert
            Assert.AreEqual(0, punkte.Right);
        }
        [TestMethod]
        public void QuestionGeneratorPrueftAntwortMoeglichkeitenAufDubletten()
        {
            //Arrange
            GUIGame gg = GUIGame.GetInstance();
            gg.Answer1 = "Antwort1";
            gg.Answer2 = "Antwort2";
            gg.Answer3 = "Antwort3";
            gg.Answer4 = "Antwort4";
            //Act
            bool istdoppelt = QuestionGenerator.CheckOnDouble("Antwort1");
           //Assert
           Assert.IsTrue(istdoppelt);
        }

    }
}
