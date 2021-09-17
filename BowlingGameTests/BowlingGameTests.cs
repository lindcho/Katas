using BowlingGameKata;
using NUnit.Framework;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        [Test]
        public void TestBowlingGameClass()
        {
            // arrange
            var sut = CreateSut();
            // act
            // assert
            Assert.That(sut, Is.InstanceOf<Game>());
        }

        [Test]
        public void TestGutterGame_ShouldReturn0()
        {
            // arrange
            var sut = CreateSut();
            const int n = 20;
            const int pins = 0;
            // act
            RollMany(sut, n, pins);
            // assert
            Assert.That(0, Is.EqualTo(sut.Score()));

        }

        [Test]
        public void TestKnockingDown1PinEachTime_Returns20()
        {
            // arrange
            var sut = CreateSut();
            // act
            const int n = 20;
            const int pins = 1;
            RollMany(sut, n, pins);
            // assert
            Assert.That(20, Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestKnockingDown2Pins_Returns40()
        {
            // arrange
            var sut = CreateSut();
            // act
            RollMany(sut, 20, 2);
            // assert
            Assert.That(40, Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestOneSpare()
        {
            // arrange
            var sut = CreateSut();
            // act
            RollSpare(sut); // we roll spare
            sut.Roll(3);
            RollMany(sut, 17, 0);
            // assert
            Assert.That(16, Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestOneStrike_ReturnScore()
        {
            // arrange
            var sut = CreateSut();
            // act
            RollStrike(sut); // we roll strike
            sut.Roll(3);
            sut.Roll(4);
            RollMany(sut, 16, 0);
            // assert
            Assert.That(24, Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestPerfectGame()
        {
            // arrange
            var sut = CreateSut();
            // act
            RollMany(sut, 12, 10);
            // assert
            Assert.That(300, Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestRandomGameWithNoExtraRoll()
        {
            // arrange
            var sut = CreateSut();
            // act
            var randomRolls = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 };
            foreach (var randomRoll in randomRolls)
            {
                sut.Roll(randomRoll);
            }
            // assert
            Assert.That(131,Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestRandomGameWithSpareThenStrikeAtEnd()
        {
            // arrange
            var sut = CreateSut();
            // act
            var randomRollsWithSpareAndStrike = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 1, 10 };
            foreach (var randomRoll in randomRollsWithSpareAndStrike)
            {
                sut.Roll(randomRoll);
            }
            // assert
            Assert.That(143,Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestRandomGameWithTwoSparesThenMultipleStrikesAtEnd()
        {
            // arrange
            var sut = CreateSut();
            // act
            var randomRollsWithSpareAndStrike = new int[] { 1, 3, 7, 3, 10, 7, 5, 2, 5, 5, 3, 8, 2, 10, 9, 1, 10, 10, 10, 10, 10 };
            foreach (var randomRoll in randomRollsWithSpareAndStrike)
            {
                sut.Roll(randomRoll);
            }
            // assert
            Assert.That(163,Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestRandomGameWithThreeStrikesAtEnd()
        {
            // arrange
            var sut = CreateSut();
            // act
            var randomRollsWith3Strike = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 10, 10, 10 };
            foreach (var randomRoll in randomRollsWith3Strike)
            {
                sut.Roll(randomRoll);
            }
            // assert
            Assert.That(163,Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestRandomGameWithSparesOnly()
        {
            // arrange
            var sut = CreateSut();
            // act
            var randomRollsWithSparesOnly = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            foreach (var randomRoll in randomRollsWithSparesOnly)
            {
                sut.Roll(randomRoll);
            }
            // assert
            Assert.That(95, Is.EqualTo(sut.Score()));
        }

        [Test]
        public void TestRandomGameWithStrikesOnly()
        {
            // arrange
            var sut = CreateSut();
            // act
            var randomRollsWithStrikesOnly = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            foreach (var randomRoll in randomRollsWithStrikesOnly)
            {
                sut.Roll(randomRoll);
            }
            // assert
            Assert.That(270, Is.EqualTo(sut.Score()));
        }

        private static Game CreateSut()
        {
            return new Game();
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