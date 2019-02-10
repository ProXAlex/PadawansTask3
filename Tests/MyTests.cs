using System;
using NUnit.Framework;
using static PadawansTask3.IntegerExtensions;

namespace PadawansTask3
{
    public class MyTests
    {

        [TestCase(-28, -16, ExpectedResult = 4)]
        [TestCase(-16, -28, ExpectedResult = 4)]
        [TestCase(28, -16, ExpectedResult = 4)]
        [TestCase(-28, 16, ExpectedResult = 4)]
        [TestCase(0, 9, ExpectedResult = 9)]
        [TestCase(9, 0, ExpectedResult = 9)]
        public int GcdTests(int a, int b) => Gcd(a, b);
    }
}
