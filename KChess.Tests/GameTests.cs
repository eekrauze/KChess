using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KChess.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestGetSquareColor()
        {
            Assert.AreEqual(1, Game.GetSquareColor("a1"));
            Assert.AreEqual(1, Game.GetSquareColor("d4"));
            Assert.AreEqual(1, Game.GetSquareColor("f6"));
            Assert.AreEqual(0, Game.GetSquareColor("b7"));
            Assert.AreEqual(0, Game.GetSquareColor("h3"));
            Assert.AreEqual(0, Game.GetSquareColor("c4"));

            Assert.AreEqual(1, Game.GetSquareColor("A1"));
            Assert.AreEqual(1, Game.GetSquareColor("D4"));
            Assert.AreEqual(1, Game.GetSquareColor("F6"));
            Assert.AreEqual(0, Game.GetSquareColor("B7"));
            Assert.AreEqual(0, Game.GetSquareColor("H3"));
            Assert.AreEqual(0, Game.GetSquareColor("C4"));
        }

        [TestMethod]
        public void TestIsBlack()
        {
            Assert.AreEqual(true, Game.IsBlack("a1"));
            Assert.AreEqual(false, Game.IsBlack("a8"));

            Assert.AreEqual(false, Game.IsBlack("B1"));
            Assert.AreEqual(true, Game.IsBlack("B8"));
        }

        [TestMethod]
        public void TestIsWhite()
        {
            Assert.AreEqual(true, Game.IsWhite("d1"));
            Assert.AreEqual(false, Game.IsWhite("d8"));

            Assert.AreEqual(true, Game.IsWhite("E2"));
            Assert.AreEqual(false, Game.IsWhite("E7"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareColorForInvalidCoordinate1()
        {
            Game.GetSquareColor("x1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareColorForInvalidCoordinate2()
        {
            Game.GetSquareColor("a9");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareColorForInvalidCoordinate3()
        {
            Game.GetSquareColor("x9");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareColorForInvalidCoordinate4()
        {
            Game.GetSquareColor("x-1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIsWhiterForInvalidCoordinate()
        {
            Game.IsWhite("x1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIsBlackForInvalidCoordinate()
        {
            Game.IsBlack("a9");
        }
    }
}