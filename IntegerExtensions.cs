using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {

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
