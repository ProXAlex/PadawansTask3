using System;
using NUnit.Framework;
using static PadawansTask3.IntegerExtensions;

namespace PadawansTask3
{
    public class MyTests
    {
        

        [TestCase(0, 60, ExpectedResult = 60)]
        public int GcdTests(int a, int b) => Gcd(a, b);



        [Test]
        public void GcdTests_NegativeArguments()
        {
            Assert.Throws<ArgumentException>(() => Gcd(-28, 20));
        }

        [Test]
        public void GcdTests_ZeroArguments()
        {
            Assert.Throws<ArgumentException>(() => Gcd(0, 0));
        }
    }
}