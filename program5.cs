using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_part2
{
    internal class program5
    {
        static void Main(String[] args)
        {
            String wish = "one day I'll  be a #great #programmer";

            //objective : to extract hashtags
            String[] words = wish.Split(' ');
            var result = words.Where(w => w.StartsWith("#"));
            foreach( var word in result )
            {
                Console.WriteLine(word); 
            }
             
        }
    }
}
