using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_part2
{
    internal class program2
    {
        static void Main(String[] args)
        {
            // prepend and append 

            int[] luckynumbers = { 47, 57, 658 };
            foreach(int i in luckynumbers)
            {
                Console.WriteLine(i);
            }

            // prepend to add the values at the beginning of array
            var result1 = luckynumbers.Prepend(60);

           
            foreach(int i in result1 ) {
                Console.WriteLine(i);
            }

            //append to add the values at the end

            var result2 = result1.Append(33);
            foreach(int i in result2) {
                Console.WriteLine(i);
            }

            // join() converts arrray into string
            Console.WriteLine(string.Join("-", result2));


        }
    }
}
