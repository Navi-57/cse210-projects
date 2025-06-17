using System;

class Program
{
    static void Main(string[] Args)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);

        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Thread.Sleep(500);
            Console.Write(animationString[0..5]);
            Console.Write("\b\b\b\b\b\b");
            Thread.Sleep(500);
            Console.Write(animationString[5..]);
            Console.Write("\b\b\b\b\b\b\b");
        }
    }

}