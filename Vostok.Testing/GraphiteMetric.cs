using System;

namespace Vostok.Testing
{
    public class GraphiteMetric
    {
        public readonly DateTime Time;
        public readonly double Value;

        public GraphiteMetric(DateTime time, double value)
        {
            Time = time;
            Value = value;
        }
    }
}