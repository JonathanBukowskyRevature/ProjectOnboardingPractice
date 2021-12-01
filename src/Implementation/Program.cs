using System;
using System.Linq;

using Implementation.Problem1;
using Implementation.InfiniteStream;

namespace Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Week1.UniqueFract());

            var count = 0;
            foreach (var item in Infinite.Naturals())
            {
                if (count++ > 1000)
                {
                    break;
                }
                Console.WriteLine(item);
            }
        }
    }
}
