using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Classes
{
    public class Bowling
    {
        private const int Spare = 10;
        private const int Strike = 10;

        public int ScoreGame(int[] scores)
        {
            int result = 0;

            if (scores.Length != 21)
            {
                throw new Exception("Expected 21 values for scoring a game of bowling.");
            }

            List<int[]> frames = CreateFrames(scores);            

            // Loop through the ten frames
            for (int i = 0; i < frames.Count; i++)
            {
                if (i <= 7)
                {
                    result += ScoreFrame(frames[i], frames[i + 1], frames[i + 2]);
                }
                else if(i == 8)
                {
                    result += ScoreFrame(frames[i], frames[i + 1]);
                }
                else
                {
                    result += ScoreFrame(frames[i]);
                }
            }

            return result;
        }

        private List<int[]> CreateFrames(int[] scores)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < 10; i++)
            {
                int frameIndex = i * 2;
                int[] frameScores = new int[3];
                frameScores[0] = scores[frameIndex];
                frameScores[1] = scores[frameIndex + 1];
                if (i == 9)
                {
                    frameScores[2] = scores[frameIndex + 2];
                }
                result.Add(frameScores);
            }

            return result;
        }

        private int ScoreFrame(int[] frame1, int[] frame2 = null, int[] frame3 = null)
        {
            int result = 0;

            // Check for strike condition
            if (IsStrike(frame1))
            {
                result = ScoreStrikeFrame(frame1, frame2, frame3);
            }
            // Check for spare condition
            else if (IsSpare(frame1)) 
            {
                result = ScoreSpareFrame(frame1, frame2);
            }
            else
            {
                result = frame1[0] + frame1[1];
            }

            return result;
        }

        private int ScoreSpareFrame(int[] currentFrame, int[] nextFrame)
        {
            int result = Spare;

            if (IsTenthFrame(nextFrame))
            {
                result += currentFrame[2];
            }
            else
            {
                result += nextFrame[0];
            }

            return result;
        }

        private int ScoreStrikeFrame(int[] currentFrame, int[] nextFrame1, int[] nextFrame2)
        {
            int result = Strike;

            if (IsTenthFrame(nextFrame1, nextFrame2))
            {
                result += currentFrame[1] + currentFrame[2];
            }
            else if (IsNinthFrame(nextFrame1, nextFrame2))
            {
                result += nextFrame1[0] + nextFrame1[1];
            }
            else
            {
                if (IsStrike(nextFrame1))
                {
                    result += nextFrame1[0] + nextFrame2[0];
                }
                else if (nextFrame1 != null)
                {
                    result += nextFrame1[0] + nextFrame1[1];
                }
            }

            return result;
        }

        private bool IsStrike(int[] frame)
        {
            return frame[0] == Strike;
        }

        private bool IsSpare(int[] frame)
        {
            return frame[0] != Strike && (frame[0] + frame[1]) == Spare;
        }

        private bool IsNinthFrame(int[] nextFrame1, int[] nextFrame2)
        {
            return nextFrame1 != null && nextFrame2 == null;
        }

        private bool IsTenthFrame(int[] nextFrame1, int[] nextFrame2 = null)
        {
            return nextFrame1 == null && nextFrame2 == null;
        }
    }
}
