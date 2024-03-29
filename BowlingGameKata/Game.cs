﻿namespace BowlingGameKata
{
    public class Game
    {
        private int _score = 0;
        private readonly int[] _rolls = new int[21];
        private int _currentRoll = 0;


        public void Roll(int pins)
        {
            _score += pins;
            _rolls[_currentRoll++] = pins;

        }

        public int Score()
        {
            var score = 0;
            var frameIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex)) // check for strike
                {
                    score += 10 +
                             _rolls[frameIndex + 1] +
                             _rolls[frameIndex + 2];
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += _rolls[frameIndex] +
                             _rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;

        }

        private bool IsStrike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }


        public bool IsSpare(int frameIndex)
        {
            return _rolls[frameIndex] +
                _rolls[frameIndex + 1] == 10;
        }

    }
}
