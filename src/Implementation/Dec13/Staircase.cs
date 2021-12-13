using System.Collections.Generic;

namespace Implementation.Dec13
{
    public static class Staircase
    {
        // memoization for waysToClimb
        private static Dictionary<int, int> _cache;

        // return number of ways to climb a staircase with n steps, either 1 or 2 steps at a time
        public static int waysToClimb(int n)
        {
            if (_cache == null)
            {
                _cache = new Dictionary<int, int>();
            }
            if (_cache.ContainsKey(n))
            {
                return _cache[n];
            }
            var result = 1;
            if (n > 1)
            {
                result = waysToClimb(n - 1) + waysToClimb(n - 2);
            }
            _cache[n] = result;
            return result;
        }
    }
}