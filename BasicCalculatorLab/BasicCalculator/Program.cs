using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            Console.WriteLine("Enter the temperature in Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the relative humidity");
            int relativehumidity = int.Parse(Console.ReadLine());

            int dewpoint = temperature - 9 * (100 - relativehumidity) / 25;

            Console.WriteLine("The dew point is" + dewpoint);

            Console.WriteLine("Enter the wind speed");
            int windspeed = int.Parse(Console.ReadLine());

            double windChill = 35.74
                + (0.6125 * temperature)
                - 35.75 * Math.Pow(windspeed, 0.16)
                + 0.4275 * temperature * Math.Pow(windspeed, 0.16);

            Console.WriteLine("The wind chill is" + windChill); 
        }
    }
}
