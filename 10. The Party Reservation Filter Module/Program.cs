namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Predicate<string>> filters = new();

            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            string command = string.Empty;


            while ((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string criteria = tokens[1];
                string value = tokens[2];

                if (action == "Add filter")
                {
                    if(!filters.ContainsKey(criteria + value))
                    {
                        filters.Add(criteria + value, GetPredicate(criteria, value));
                    }
                }
                else
                {
                    filters.Remove(criteria + value);
                }
            }
            foreach(var filter in filters)
            {
                guests.RemoveAll(filter.Value);
            }

            Console.WriteLine($"{string.Join(" ", guests)}");
        }

        private static Predicate<string> GetPredicate(string criteria, string value)
        {
            switch (criteria)
            {
                case "Starts with":
                    return p => p.StartsWith(value);
                case "Ends with":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                case "Contains":
                    return p => p.Contains(value);
                default:
                    return default;
            }
        }
    }
}