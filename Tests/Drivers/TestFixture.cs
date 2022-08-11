using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace Tests.Drivers
{
    public class TestFixture
    {
        public Stopwatch SW = new();
        public long Answer;
        public int ProblemNumber;
        public BigInteger Factorial;
        public List<long> FibonacciSequence;
        public long CollatzLength;
        public long Value;
    }
}
