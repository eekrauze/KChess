using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KChess.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestSquareColor()
        {
            var game = new Game();

            Assert.AreEqual(true, game.GetSquare("a1").IsBlack);
            Assert.AreEqual(true, game.GetSquare("d4").IsBlack);
            Assert.AreEqual(true, game.GetSquare("f6").IsBlack);

            Assert.AreEqual(true, game.GetSquare("b7").IsWhite);
            Assert.AreEqual(true, game.GetSquare("h3").IsWhite);
            Assert.AreEqual(true, game.GetSquare("c4").IsWhite);

            Assert.AreEqual(true, game.GetSquare("A1").IsBlack);
            Assert.AreEqual(true, game.GetSquare("D4").IsBlack);
            Assert.AreEqual(true, game.GetSquare("F6").IsBlack);

            Assert.AreEqual(true, game.GetSquare("B7").IsWhite);
            Assert.AreEqual(true, game.GetSquare("H3").IsWhite);
            Assert.AreEqual(true, game.GetSquare("C4").IsWhite);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareForInvalidCoordinate1()
        {
            var game = new Game();
            game.GetSquare("x-1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareForInvalidCoordinate2()
        {
            var game = new Game();
            game.GetSquare("x1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareForInvalidCoordinate3()
        {
            var game = new Game();
            game.GetSquare("a9");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareForInvalidCoordinate4()
        {
            var game = new Game();
            game.GetSquare(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetSquareForInvalidCoordinate5()
        {
            var game = new Game();
            game.GetSquare("");
        }
    }
}