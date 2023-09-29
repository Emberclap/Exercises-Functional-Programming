namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printer = (names) =>
            {
                foreach (var name in names)
                {
                    if (name.Length <= n)
                    {
                        Console.WriteLine(name);
                    }
                }
            };
            printer(names);
        }
    }
}