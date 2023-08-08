using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_part2
{
    internal class program3
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            var result = numbers.Select(x => x * x);
            foreach(int i in result)
            {
                Console.WriteLine(i);

            }
        }
    }
}
