namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> myPassportStamps = new List<string> { "Germany", "Holland", "Belgium", "England", "Egypt", "Tanzania", "Costa Rica", "China", "Cambodia", "Thailand", "Nepal", "India", "Israel", "Jordan", "Italy", "Peru", "Chili" };



            var countries = myPassportStamps.OrderBy(x => x.Length);

            Console.WriteLine("The Places I've Travelled To");
            Console.WriteLine("----------------------------");
            foreach (var country in countries) 
            {
                Console.WriteLine(country);
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
