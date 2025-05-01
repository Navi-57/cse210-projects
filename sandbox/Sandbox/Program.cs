using System;

class Program
{
    static double AddNumbers(double a)
    {
        return a + a;
    }

    static void DisplayGreeting()
    {
        Console.WriteLine("Hello.");
    }

    static void Main(string[] args)
    {
        // Console.WriteLine(AddNumbers(3, 4));
        List<int> myNumbers = new List<int>();
        myNumbers.Add(7);
        myNumbers.Add(44);
        myNumbers.Add(27);

        foreach(int i in myNumbers)
        {
            Console.WriteLine(AddNumbers(i));
        }
        DisplayGreeting();
    }
}