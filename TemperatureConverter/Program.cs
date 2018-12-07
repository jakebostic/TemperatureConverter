using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine();

            Console.Write("Enter degrees in Farenheit: ");
            if (double.TryParse(Console.ReadLine(), out double f))
            {
                double c = (f - 32) * 5 / 9;
                Console.Write($"\nDegrees in Celsius: {c}");
                Console.WriteLine();
            }
            
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
