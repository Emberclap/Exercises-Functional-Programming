using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> checkNameSum = (name, sum) =>
            {
                int charsSum = name.Sum(x => x);
                return charsSum >= sum;
            };

            Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) =>
            {
                foreach (var name in names)
                {
                    if (match(name, sum))
                    {
                        return name;
                    }
                }
                return default;
            };

            int sum = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foundname = getFirstName(names, sum, checkNameSum);

            Console.WriteLine(foundname);
        }
    }
}