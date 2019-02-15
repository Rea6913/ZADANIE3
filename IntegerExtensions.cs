using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            // put your code here
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            int znak = a / Math.Abs(a);
            int znak1 = b / Math.Abs(b);
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            if (a != 0)
                return znak*a;
            else
                return znak1*b;

        }
    }
}
