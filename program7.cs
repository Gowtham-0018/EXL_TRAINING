
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace day5_part2
{
    class employees
    {
        public string name;
        public string gender;
    }
    // this explains grouping
    internal class program7
    {
        static void Main(String[] args)
        {
            employees[] employees =
            {
                new employees{name="gowtham" , gender ="male"},
                new employees{name="harsha",gender="male"},
                new employees{name="nani",gender="male"},
                new employees{name="naveen",gender="male"},
                new employees{name="aunty",gender="female"}
            };
            var empgroups = from emp in employees  group emp by emp.gender;
            foreach(var grp in empgroups) 
            {
                Console.WriteLine(grp.Key);
                foreach(var e in grp)
                {
                    Console.WriteLine(e.name+" "+e.gender);
                }
                Console.WriteLine("===================");
            }

        }
    }
}
