using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_part2
{
    internal class program6
    {
        static void Main(String[] args)
        {
            var numbers = new List<int> { 6, 2, -3, 4, -5, 9, 7, 8 };
            int length = numbers.Count();
            Console.WriteLine($"total elements {length}");
            // count even numbers 
            int length2 = numbers.Count(e => e % 2 == 0);
            Console.WriteLine($"even numbrs length = {length2}");

            // find sum
            int total = numbers.Sum();
            Console.WriteLine($"total sum = {total}");

            // find sum of even numbers 
            int evensum = numbers.Sum(e => e % 2 == 0 ? e : 0);
            Console.WriteLine($"even sum = {evensum}");

            // find average 
            double mean = numbers.Average();
            Console.WriteLine($"average = {mean}");

            // find max
            Console.WriteLine($"largest value = {numbers.Max()}");
            Console.WriteLine($"smallest value = {numbers.Min()} ");


            // sorting 
            var result = from num in numbers orderby num ascending select num;
            foreach (int num in result)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
