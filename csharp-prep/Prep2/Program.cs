using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int number = int.Parse(percent);
        string letter = "";
        string passed = "";
        if (number >= 90)
        {
            letter = "A";
            passed = "you passed!";
        }
        else if (number >= 80)
        {
            letter = "B";
            passed = "you Passed!";
        }
        else if (number >= 70)
        {
            letter = "C";
            passed = "you passed!";
        }
        else if (number >= 60)
        {
            letter = "D";
            passed = "you did not pass.";
        }
        else
        {
            letter = "F";
            passed = "you did not pass.";
        }
        if (letter == "A")
        {
            Console.WriteLine($"Your grade is an {letter} and {passed}");
        }
        else if (letter == "F")
        {
            Console.WriteLine($"Your grade is an {letter} and {passed}");
        }
        else 
        {
            Console.WriteLine($"Your grade is a {letter} and {passed}");
        }
    }
}
