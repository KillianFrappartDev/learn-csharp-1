using System;

namespace learn_csharp_1
{
    public class Exercice2
    {
        public static void MaxNumber()
        {
            Console.WriteLine("Enter a number");
            var userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            var userInput2 = Convert.ToInt32(Console.ReadLine());

            var maxNum = userInput1 > userInput2 ? userInput1 : userInput2;
            Console.WriteLine($"The maximum is {maxNum}");
        }
    }
}