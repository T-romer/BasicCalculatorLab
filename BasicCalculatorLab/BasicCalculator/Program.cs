using System;

namespace BasicWeatherCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            Console.WriteLine("Enter the temperature in Fahrenheit");
            int temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the relative humidity");
            int relativeHumidity = int.Parse(Console.ReadLine());

            int dewPoint = temperature - 9 * (100 - relativeHumidity) / 25;

            Console.WriteLine("The dew point is " + dewPoint);

            Console.WriteLine("Enter the wind speed");
            int windSpeed = int.Parse(Console.ReadLine());

            double windChill = 35.74
                + (0.6125 * temperature)
                - 35.75 * Math.Pow(windSpeed, 0.16)
                + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windChill);

        }
    }
}
