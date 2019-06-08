using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class BowlingGame
    {
        List<List<int>> frameList = new List<List<int>>();

        List<int> CurrentFrame
        {
            get
            {
                if (frameList.Count < 1
                    || frameList[frameList.Count - 1].Sum() > 9
                    || frameList[frameList.Count - 1].Count > 1)
                {
                    frameList.Add(new List<int>());
                }

                return frameList[frameList.Count - 1];
            }
        }

        int GetFrameScore(int index)
        {
            int bonus = 0;
            if(frameList[index].Sum() > 9)
            {
                if (frameList[index].Count > 1)
                {
                    bonus += frameList[index + 1][0];
                }
                else
                {
                    bonus += frameList[index + 1][0];
                    bonus += frameList[index + 1][0] > 9 ?
                        frameList[index + 2][0] : frameList[index + 1][1];
                }
            }

            return frameList[index].Sum() + bonus;
        }

        public void Roll(int rollScore) => CurrentFrame.Add(rollScore);

        public int Score
        {
            get
            {
                var tempScore = 0;
                for (int i = 0; i < 10; i++)
                    tempScore += GetFrameScore(i);

                return tempScore;
            }
        }
    }
}
