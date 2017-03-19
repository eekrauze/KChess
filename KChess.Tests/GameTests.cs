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
        }

        [TestMethod]
        public void TestIsBlack()
        {
            Assert.AreEqual(true, Game.IsBlack("a1"));
            Assert.AreEqual(false, Game.IsBlack("a8"));
        }

        [TestMethod]
        public void TestIsWhite()
        {
            Assert.AreEqual(true, Game.IsWhite("d1"));
            Assert.AreEqual(false, Game.IsWhite("d8"));
        }
    }
}
