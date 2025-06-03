using System;

class Program
{
   static void Main()
    {
        string referenceInput = "Proverbs 3:5-6";
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Reference reference = new Reference(referenceInput);
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will now end.");
                break;
            }

            Console.Write("\nPress Enter to continue or type 'quit' to end: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}