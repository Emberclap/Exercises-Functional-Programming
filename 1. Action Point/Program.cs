namespace _1._Action_Point
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
                    Console.WriteLine(name);
                }
            };
            printer(names);
        }
    }
}
