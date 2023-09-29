namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printer = (names) =>
            {
                foreach (string name in names)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };
            printer(names);
        }
    }
}