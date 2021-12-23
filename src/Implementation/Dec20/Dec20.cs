using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation.Dec20
{
    public static class Dec20
    {
        private static long SumDigits(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        private static long Step(long n)
        {
            var s = SumDigits(n);
            if (n % s == 0)
            {
                return n / s;
            }
            else
            {
                return n * s;
            }
        }

        public static List<long> DeadEnd(long n)
        {
            long cur = n;
            long next = Step(n);
            long last = n;
            /*
            if (Step(next) == cur)
            {
                return new List<long> { 2, next };
            }
            */
            long count = 1;
            while (next != last && next != cur)
            {
                count++;
                last = cur;
                cur = next;
                next = Step(next);
            }
            return new List<long> { count, cur };
        }

        public static bool IsMagicSquare(List<List<int>> square)
        {
            var goalSum = (Math.Pow(square.Count, 2) + 1) / 2 * square.Count;
            var leftDiag = 0;
            var rightDiag = 0;
            for (int i = 0; i < square.Count; i++)
            {
                var rowSum = square[i].Sum();
                var colSum = square.Select(x => x[i]).Sum();
                if (rowSum != goalSum || colSum != goalSum)
                {
                    return false;
                }
                leftDiag += square[i][i];
                rightDiag += square[i][square.Count - 1 - i];
            }
            if (leftDiag != goalSum || rightDiag != goalSum)
            {
                return false;
            }
            return true;
        }
    }
}