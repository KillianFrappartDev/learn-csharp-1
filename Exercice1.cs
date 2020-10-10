using System;

namespace learn_csharp_1
{
    public class Exercice1
    {
        public static void ValidNumber()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput > 10 || userInput <= 0) Console.WriteLine("Invalid");
            else Console.WriteLine("Valid");
        }
    }
}