namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;

           
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] tokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string criteria = tokens[1];
                string value = tokens[2];
                if (action == "Remove")
                {
                    guests.RemoveAll(GetPredicate(criteria, value));
                }
                else 
                {
                    List<string> peopleToDouble = guests.FindAll(GetPredicate(criteria, value));

                    foreach (string person in peopleToDouble)
                    {
                        int index = guests.FindIndex(p => p == person);
                        guests.Insert(index, person);
                    }
                }
            }
            if (guests.Count > 0)
            {
                Console.WriteLine($"{ string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> GetPredicate(string criteria, string value)
        {
            switch (criteria)
            {
                case "StartsWith":
                    return p => p.StartsWith(value);
                case "EndsWith": 
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                default:
                    return default;
            }
        }
    }
}