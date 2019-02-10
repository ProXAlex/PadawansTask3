using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            // В статье(https://en.wikipedia.org/wiki/Binary_GCD_algorithm) написано:
            // Similarly, gcd(u, 0) = u. gcd(0, 0) is not typically defined, but it is convenient to set gcd(0, 0) = 0.
            // Поэтому изначально выводил в ответ 0, но после ваших юнит тестов переделал на ArgumentException;
            if (a == 0 && b == 0 )
                throw new ArgumentException("Two Numbers Cannot Be 0 At The Same Time.");


            a = Math.Abs(a);
            b = Math.Abs(b);

            int Greatest = 0;
            int Smallest = 0;
            if (a > b)
            {
                Greatest = a;
                Smallest = b;
            }
            else
            {
                Greatest = b;
                Smallest = a;
            }

            if (Smallest == 0)
                return Greatest;
            

            return Gcd(Smallest, Greatest % Smallest);
        }
    }
}
