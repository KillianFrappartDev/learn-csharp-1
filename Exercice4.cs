using System;

namespace learn_csharp_1
{
    public class Exercice4
    {

        public static string CalculateResult(int limit, int speed)
        {
            if (speed < limit) return "ok";
            else
            {
                var result = Math.Abs((limit - speed) / 5);
                if (result < 12) return $"You lost {Convert.ToString(result)} points";
                else return "License Suspended";
            }
        }

        public static void CameraProgram()
        {
            Console.WriteLine("Enter speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car speed");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateResult(speedLimit, carSpeed));

        }
    }
}