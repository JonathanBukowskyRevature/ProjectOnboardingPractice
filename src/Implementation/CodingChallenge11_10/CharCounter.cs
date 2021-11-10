using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation.CodingChallenge11_10
{
    public class CharCounter
    {
        public static int Count_OneLine(string S)
        {
            return (from c in S group c by c into chars select chars.Count()).Aggregate(1, (prod, count) => prod * count);
        }

        public static int Count_Submitted(string S)
        {
            //string S = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var c in S)
            {
                if (!counts.ContainsKey(c))
                {
                    counts[c] = 0;
                }
                counts[c]++;
            }

            //Console.WriteLine(counts.Values.Aggregate<int, int>(1, (int prod, int count) => prod * count));
            return counts.Values.Aggregate<int, int>(1, (int prod, int count) => prod * count);
        }
    }
}