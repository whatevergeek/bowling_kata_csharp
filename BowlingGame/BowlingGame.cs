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



        public void Roll(int pinHitCount) => CurrentFrame.Add(pinHitCount);

        public int Score
        {
            get
            {
                var tempScore = 0;
                foreach(var frame in frameList)
                {
                    tempScore += frame.Sum();
                }

                return tempScore;
            }
        }
    }
}
