﻿using System.ComponentModel;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> printer = (numbers) =>
               Console.WriteLine(string.Join(" ", numbers));
            Func<string, List<int>, List<int>> calculate = (command, numbers) =>
            {
                List<int> result = new List<int>();

                foreach (var number in numbers)
                {
                    switch (command)
                    {
                        case "add":
                            result.Add(number + 1);
                            break;
                        case "multiply":
                            result.Add(number * 2);
                            break;
                        case "subtract":
                            result.Add(number - 1);
                            break;
                    }
                }
                return result;

            };
            
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = "";
          
           
                
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    printer(numbers);
                }
                else
                {
                   numbers = calculate(command, numbers);

                }
            }
            

        } 
    }
}