using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_part2
{
    class user
    {
        public int id;
        public string name;
        public string city;
        public string dateofbirth;

        
        
    }
    internal class program4
    {
        static void Main(String[] args)
        {
            user[] users =
            {
                new user { id = 1,name="john",city="london",dateofbirth="2001-05-1"},
                new user { id = 2,name="jyya",city="jyrc",dateofbirth="2001-05-1"},
                new user { id = 3,name="jwwrsr",city="zsetgejv",dateofbirth="2001-05-1"},
                new user { id = 4,name="johhhetrg",city="sejcygt",dateofbirth="2001-05-1"},
                new user { id = 5,name="crgt",city="szhjt",dateofbirth="2001-05-1"},
                new user { id = 6,name="johxb",city="zsjetk",dateofbirth="2001-05-1"},
                new user { id = 7,name="szbtjc",city="lonzsvdon",dateofbirth="2001-05-1"},
                new user { id = 8,name="zs yct",city="lonfhdon",dateofbirth="2001-05-1"},
                new user { id = 9,name="czzjyt",city="lonreaeaertdon",dateofbirth="2001-05-1"},
                new user { id = 10,name="jzsetrh",city="lontrtdon",dateofbirth="2001-05-1"},
                

            };

            var result = from usr in users where usr.city == "szhjt" select usr;
            foreach(var usr in result)
            {
                Console.WriteLine(usr.name+" "+usr.city);

            }
  

        }
    }
}
