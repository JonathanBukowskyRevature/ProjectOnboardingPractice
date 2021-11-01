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


        /// <summary>
        /// Consider the following operation on an arbitrary positive integer:

        /// - If n is even -> n / 2
        /// - If n is odd -> n * 3 + 1

        /// Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Collatz(int n)
        {
            if (n < 1) throw new System.ArgumentException("Must be called with a positive integer");
            int steps = 0;
            while (n > 1)
            {
                steps++;
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
            }
            return steps;
        }
    }
}