using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace Tests.Drivers
{
    public class TestFixture
    {
        public bool BoolResult = false;
        public Stopwatch SW = new();
        public long Answer;
        public int ProblemNumber;
        public BigInteger BigIntegerAnswer;
        public List<BigInteger> FibonacciSequence = new();
    }
}
