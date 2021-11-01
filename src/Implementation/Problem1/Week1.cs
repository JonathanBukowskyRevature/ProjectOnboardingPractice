namespace Implementation.Problem1
{
    public static class Week1
    {
        public static int GCD(int a, int b)
        {
            if (a <= 0)
            {
                return b;
            }
            else if (b <= 0)
            {
                return a;
            }
            else if (a < b)
            {
                return GCD(b, a);
            }
            else
            {
                var r = a % b;
                return GCD(b, r);
            }
        }

        /// <summary>
        /// Create a function double UniqueFract(), which should sum all irreducible regular fractions between 0 and 1, in the numerator and denominator of which there are only single-digit numbers: 1/2, 1/3, 1/4, ... 2/3, 2/4, ... 8/9.

        /// Task
        /// UniqueFract() --> sum

        /// Notes:
        /// -Of the fractions 1/2 2/4 3/6 4/8, only 1/2 is included in the sum.
        /// -Don't include any values >= 1.
        /// -Both the numerator and denominator are single digit.
        /// </summary>
        /// <returns></returns>
        public static double UniqueFract()
        {
            double sum = 0d;
            for (int denominator = 2; denominator < 10; denominator++)
            {
                for (int numerator = 1; numerator < denominator; numerator++)
                {
                    if (GCD(numerator, denominator) == 1)
                    {
                        sum += ((double)numerator / (double)denominator);
                    }
                    else
                    {
                        System.Console.WriteLine($"{numerator}/{denominator}");
                    }
                }
            }
            return sum;
        }
    }
}