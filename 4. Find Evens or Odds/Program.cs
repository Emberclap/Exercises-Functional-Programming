namespace _4._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            List<int> numbers = new List<int>();
            

            Predicate <int> oddOrEven = (i) =>
            {
                if (i % 2 == 0)
                {
                   return true;
                }
                else 
                {
                   return false;
                }
                
            };
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (oddOrEven(i) && command == "even")
                {
                    numbers.Add(i);
                }
                else if (!oddOrEven(i) && command == "odd")
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}