using BowlingGameKata;
using NUnit.Framework;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {

        [Test]
        public void TestBowlingGameClass()
        {
            var sut = new Game();
            Assert.That(sut, Is.InstanceOf<Game>());
        }

        [Test]
        public void TestGutterGame_ShouldReturn0()
        {
            var sut = new Game();
            const int n = 20;
            const int pins = 0;

            RollMany(sut, n, pins);

            Assert.AreEqual(0, sut.Score());

        }

        [Test]
        public void TestAllOnes_Returns20()
        {
            var sut = new Game();
            const int n = 20;
            const int pins = 1;

            RollMany(sut, n, pins);
            Assert.AreEqual(20, sut.Score());
        }

        [Test]
        public void TestAllTwos_TestAllOnesReturns40()
        {
            var sut = new Game();
            RollMany(sut, 20, 2);

            Assert.AreEqual(40, sut.Score());
        }

        [Test]
        public void TestOneSpare()
        {
            var sut = new Game();
            RollSpare(sut); // we roll spare
            sut.Roll(3);
            RollMany(sut, 17, 0);

            Assert.AreEqual(16, sut.Score());
        }

        [Test]
        public void TestOneStrike_ReturnScore()
        {
            var sut = new Game();
            RollStrike(sut); // we roll strike
            sut.Roll(3);
            sut.Roll(4);
            RollMany(sut, 16, 0);
            Assert.AreEqual(24, sut.Score());
        }

        [Test]
        public void TestPerfectGame()
        {
            var sut = new Game();
            RollMany(sut, 12, 10);
            Assert.AreEqual(300, sut.Score());
        }

        [Test]
        public void TestRandomGameNoExtraRoll()
        {
            var sut = new Game();
            var randomRolls = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 };
            foreach (var randomRoll in randomRolls)
            {
                sut.Roll(randomRoll);
            }
            Assert.AreEqual(131, sut.Score());
        }

        [Test]
        public void TestRandomGameWithSpareThenStrikeAtEnd()
        {
            var sut = new Game();
            var randomRollsWithSpareAndStrike = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 1, 10 };
            foreach (var randomRoll in randomRollsWithSpareAndStrike)
            {
                sut.Roll(randomRoll);
            }
            Assert.AreEqual(143, sut.Score());
        }

        [Test]
        public void TestRandomGameWithThreeStrikesAtEnd()
        {
            var sut = new Game();
            var randomRollsWith3Strike = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 10, 10, 10 };
            foreach (var randomRoll in randomRollsWith3Strike)
            {
                sut.Roll(randomRoll);
            }
            Assert.AreEqual(163, sut.Score());
        }


        private static void RollStrike(Game sut)
        {
            sut.Roll(10);
        }

        private static void RollSpare(Game sut)
        {
            sut.Roll(5);
            sut.Roll(5);
        }


        private static void RollMany(Game sut, int n, int pins)
        {
            for (var i = 0; i < n; i++)
                sut.Roll(pins);
        }
    }
}