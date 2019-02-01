using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Classes;

namespace TDD.Tests.Classes
{
    [TestClass]
    public class BowlingTest
    {
        private Bowling _bowling = new Bowling();

        // All Frames Gutter Ball
        [TestMethod]
        public void AllFramesGutterBall()
        {
            int[] scores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Assert.AreEqual(0, _bowling.ScoreGame(scores), "All frames were gutter balls.");
        }

        // All Frames One Pin
        [TestMethod]
        public void AllFramesOnePin()
        {
            int[] scores = { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0 };
            Assert.AreEqual(10, _bowling.ScoreGame(scores), "All frames were one pin.");
        }

        // One Spare
        [TestMethod]
        public void OneSpare()
        {
            int[] scores = { 1, 9, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0 };
            Assert.AreEqual(20, _bowling.ScoreGame(scores), "One spare.");
        }

        // One Strike
        [TestMethod]
        public void OneStrike()
        {
            int[] scores = { 10, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Assert.AreEqual(16, _bowling.ScoreGame(scores), "One strike.");
        }

        // Two Consecutive Strikes
        [TestMethod]
        public void TwoStrike()
        {
            int[] scores = { 10, 0, 10, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Assert.AreEqual(33, _bowling.ScoreGame(scores), "Two consecutive strikes.");
        }

        // Tenth Frame Strike/Spare
        [TestMethod]
        public void TenthFrameStrikeAndSpare()
        {
            int[] scores = { 10, 0, 10, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 5, 5 };
            Assert.AreEqual(53, _bowling.ScoreGame(scores), "Tenth frame strike and spare.");
        }

        // Tenth Frame Spare
        [TestMethod]
        public void TenthFrameSpare()
        {
            int[] scores = { 10, 0, 10, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5 };
            Assert.AreEqual(48, _bowling.ScoreGame(scores), "Tenth frame spare.");
        }

        // Tenth Frame Strike/Strike
        [TestMethod]
        public void TenthFrameTwoStrikes()
        {
            int[] scores = { 10, 0, 10, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 5 };
            Assert.AreEqual(58, _bowling.ScoreGame(scores), "Tenth frame two strikes.");
        }

        // Perfect Game 
        [TestMethod]
        public void PerfectGame()
        {
            int[] scores = { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 10, 10 };
            Assert.AreEqual(300, _bowling.ScoreGame(scores), "Perfect game.");
        }
    }
}
