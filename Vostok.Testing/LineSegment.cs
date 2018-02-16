using System;

namespace Vostok.Testing
{
    public class LineSegment
    {
        public readonly int StartRate;
        public readonly int FinisRate;
        public readonly TimeSpan Duration;

        public LineSegment(int startRate, int finisRate, TimeSpan duration)
        {
            StartRate = startRate;
            FinisRate = finisRate;
            Duration = duration;
        }
    }
}