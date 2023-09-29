namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> operations = numbers =>
            {
                List<int> result = new List<int> ();

                foreach (int number in numbers)
                {
                    if (number % n != 0)
                    {
                        result.Add(number);
                    }
                }
                result.Reverse();
                return result;
            };
            numbers = operations(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}