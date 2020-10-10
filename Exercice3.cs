using System;

namespace learn_csharp_1
{
    public class Exercice3
    {
        public static void ImageOrientation()
        {
            Console.WriteLine("Enter image width");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter image height");
            var height = Convert.ToInt32(Console.ReadLine());

            var result = width > height ? "landscape" : "portrait";
            Console.WriteLine($"The image is {result}");
        }
    }
}