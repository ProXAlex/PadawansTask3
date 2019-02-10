using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {

            if(a < 0 || b < 0)
                throw new ArgumentException("Input can't be negative");

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Both argument can't be zero");
            }

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
