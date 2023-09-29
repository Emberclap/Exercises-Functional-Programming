namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Func<int, List<int>, List<int>> calculate = (n, numbers) =>
            {
                List<int> result = new List<int>();
                for (int i = 1; i <= n; i++) 
                {
                    bool isDivider = true;
                    foreach (int divider in numbers)
                    {
                       
                        if (i % divider != 0)
                        {
                            isDivider = false;
                            break;
                        }
                    }
                    if (isDivider)
                    {
                        result.Add(i);
                    }
                }

               return result;
            };
            numbers = calculate(n, numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}