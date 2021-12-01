using System.Collections.Generic;

namespace Implementation.InfiniteStream
{
    public class Infinite
    {

        public static IEnumerable<int> Naturals()
        {
            int i = 0;
            while (true)
            {
                yield return i++;
            }
        }
    }
}