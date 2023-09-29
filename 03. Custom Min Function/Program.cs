namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> smallestNUmber = n =>
            {
                int smallest = int.MaxValue;
                foreach (int num in numbers)
                {
                    if (smallest > num)
                    {
                        smallest = num;
                    }
                }
                return smallest;
            };
            Console.WriteLine(smallestNUmber(numbers));
        }
    }
}