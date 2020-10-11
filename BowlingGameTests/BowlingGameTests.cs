using BowlingGameKata;
using NUnit.Framework;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {

        [Test]
        public void RollMany_ShouldReturn0()
        {
            const int n = 20;
            const int pins = 0;

            var sut = new Game();
            RollMany(sut, n, pins);

            Assert.AreEqual(0, sut.Score());

        }

        [Test]
        public void RollMany_TestAllOnesReturns20()
        {
            var sut = new Game();
            RollMany(sut, 20, 1);

            Assert.AreEqual(20, sut.Score());
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