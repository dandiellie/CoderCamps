using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrisonersDilemma.Tests
{
    [TestClass]
    public class PrisonersDilemmaTests
    {
        [TestMethod]
        public void TestCompareStrategiesCC()
        {
            //Assign
            Cooperator p1 = new Cooperator();
            Cooperator p2 = new Cooperator();
            Game playGame = new Game();

            //Act
            playGame.CompareStrategies(p1, p2);

            //Assert
            Assert.AreEqual(1, p1.Years);
            Assert.AreEqual(1, p2.Years);
        }

        [TestMethod]
        public void TestCompareStrategiesCD()
        {
            //Assign
            Cooperator p1 = new Cooperator();
            Defector p2 = new Defector();
            Game playGame = new Game();

            //Act
            playGame.CompareStrategies(p1, p2);

            //Assert
            Assert.AreEqual(3, p1.Years);
            Assert.AreEqual(0, p2.Years);
        }

        [TestMethod]
        public void TestCompareStrategiesDC()
        {
            //Assign
            Defector p1 = new Defector();
            Cooperator p2 = new Cooperator();
            Game playGame = new Game();

            //Act
            playGame.CompareStrategies(p1, p2);

            //Assert
            Assert.AreEqual(0, p1.Years);
            Assert.AreEqual(3, p2.Years);
        }
        
        [TestMethod]
        public void TestCompareStrategiesDD()
        {
            //Assign
            Defector p1 = new Defector();
            Defector p2 = new Defector();
            Game playGame = new Game();

            //Act
            playGame.CompareStrategies(p1, p2);

            //Assert
            Assert.AreEqual(2, p1.Years);
            Assert.AreEqual(2, p2.Years);
        }
    }
}
