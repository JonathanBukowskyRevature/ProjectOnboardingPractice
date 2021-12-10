using System.Collections.Generic;

namespace Implementation.Dec7
{
    public static class Overtime
    {
        public static string OverTime(List<double> data)
        {
            double start, end, rate, overtimeMult;
            start = data[0];
            end = data[1];
            rate = data[2];
            overtimeMult = data[3];
            // after 5 pm (17) is overtime
            if (start < 17)
            {
                if (end <= 17)
                {
                    return $"${(end - start) * rate:F2}";
                }
                else
                {
                    var ot = (end - 17) * rate * overtimeMult;
                    return $"${(17 - start) * rate + ot:F2}";
                }
            }
            else
            {
                return $"${(end - start) * rate * overtimeMult:F2}";
            }
        }
    }

    public static class Fractions
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