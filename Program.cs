namespace day5_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here is a sample LINQ demo
            var words = new string[] { "flower", "elephant", "sugar", "tree", "waffer" };
            // what is var : var is a keyword in c# that automatically determines the datatype of the object
            // using var u dont have to sepcify datatype of object eplicitly 
            // u can use var for alllll datatypes

            //linq query syntax
            //from <variable> in <collection > select <variable>;

            // var result = from element in words where element.Contains("a") select element;
            var result = words.Where(element => element.Contains("a"));

            //var age = 50;
            //var name = "gowtham";
            //Console.WriteLine(age);
            //Console.WriteLine(name);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}