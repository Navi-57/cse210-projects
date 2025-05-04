using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Read input from the user
        do
        {
            Console.Write("Enter number: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out input))
            {
                if (input != 0)
                {
                    numbers.Add(input);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
                input = -1; // Force loop continuation
            }

        } while (input != 0);

        // Ensure there are numbers before proceeding
        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge: Find the smallest positive number
            var smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
            if (smallestPositive > 0)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers.");
            }

            // Sort and display the sorted list
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}