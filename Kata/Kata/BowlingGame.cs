using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class BowlingGame
    {
        private readonly List<Frame> frames = new List<Frame>();

        public void Roll(int pins)
        {
            if (CurrentFrame == null || CurrentFrame.IsComplete)
            {
                frames.Add(new Frame(pins));
            }
            else
            {
                CurrentFrame.Roll(pins);
            }
        }

        private Frame CurrentFrame
        {
            get { return frames.LastOrDefault(); }
        }

        public int GetScore()
        {
            var total = 0;

            for (var frame = 0; frame < 10; frame++)
            {
                total += ScoreFor(frame);
            }
            return total;
        }

        private int ScoreFor(int frameNumber)
        {
            var frame = GetFrame(frameNumber);
            if (frame.IsStrike())
            {
                return frame.PinsDown() + StrikeBonusFor(frameNumber);
            }
            if (frame.IsSpare())
            {
                return frame.PinsDown() + SpareBonusFor(frameNumber);
            }
            return frame.PinsDown();
        }

        private Frame GetFrame(int frame)
        {
            if (frames.Count > frame)
                return frames[frame];

            return new Frame(0);
        }

        private int SpareBonusFor(int frame)
        {
            return GetFrame(frame +1).FirstRoll;
        }

        private int StrikeBonusFor(int frameNumber)
        {
            var frame = GetFrame(frameNumber + 1);
            if (frame.IsStrike())
            {
                return frame.FirstRoll + GetFrame(frameNumber +2).FirstRoll;
            }
            return frame.PinsDown();
        }
    }

    internal class Frame
    {
        private readonly List<int> worpen;

        public Frame(int pins)
        {
            worpen = new List<int> {pins};
        }

        public bool IsComplete
        {
            get { return PinsDown() == 10 || worpen.Count == 2; }
        }

        public int FirstRoll
        {
            get { return worpen[0]; }
        }

        public int PinsDown()
        {
            return worpen.Sum();
        }

        public void Roll(int pins)
        {
            worpen.Add(pins);
        }

        public bool IsStrike()
        {
            return worpen[0] == 10;
        }

        internal bool IsSpare()
        {
            return !IsStrike() && PinsDown() == 10;
        }
    }
}