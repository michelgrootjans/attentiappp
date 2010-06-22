using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class BowlingGameTests
    {
        private BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void NewBowlingGameHasScore0()
        {
            Assert.That(game.GetScore(), Is.EqualTo(0));
        }

        [Test]
        public void Roll0Scores0()
        {
            game.Roll(0);
            Assert.That(game.GetScore(), Is.EqualTo(0));
        }

        [Test]
        public void Roll1Scores1()
        {
            game.Roll(1);
            Assert.That(game.GetScore(), Is.EqualTo(1));
        }

        [Test]
        public void Roll1TwiceScores2()
        {
            game.Roll(1);
            game.Roll(1);
            Assert.That(game.GetScore(), Is.EqualTo(2));
        }

        [Test]
        public void RollSpareCountsNextRollDouble()
        {
            game.Roll(3);
            game.Roll(7);
            game.Roll(4);
            Assert.That(game.GetScore(), Is.EqualTo(18));
        }

        [Test]
        public void Roll6_4_3_6()
        {
            game.Roll(6);
            game.Roll(4);
            game.Roll(3);
            game.Roll(6);
            Assert.That(game.GetScore(), Is.EqualTo(22));
        }

        [Test]
        public void Roll2_6_4_2()
        {
            game.Roll(2);
            game.Roll(6);
            game.Roll(4);
            game.Roll(2);
            Assert.That(game.GetScore(), Is.EqualTo(14));
        }

        [Test]
        public void RollStrike()
        {
            game.Roll(10);
            game.Roll(2);
            game.Roll(4);
            Assert.That(game.GetScore(), Is.EqualTo(22));
        }

        [Test]
        public void PerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Roll(10);
            }
            Assert.That(game.GetScore(), Is.EqualTo(300));
        }



    }
}