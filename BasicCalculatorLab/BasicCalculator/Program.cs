using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            //DECLARE VARAIBLES
            string input;
            double temp;
            double relhumidity;
            double dewpoint;
            double windspeed;
            double windchill;

            //ASK USER FOR THE TEMP
            Console.WriteLine("Enter the tempeture.");
            input = Console.ReadLine();
            temp = int.Parse(input);


            //ASK FOR REL HUMIDITY
            Console.WriteLine("Enter relitive humidity.");
            input = Console.ReadLine();
            relhumidity = int.Parse(input);

            //CALCUATE DEW POINT
            dewpoint = temp - 9 * (100 - relhumidity) / 25;

            //PRINT DEW POINT
            Console.WriteLine("Dew point = " + dewpoint);

            //ASK FOR WINDSPEED
            Console.WriteLine("Enter the windspeed.");
            input = Console.ReadLine();
            windspeed = int.Parse(input);

            //CALCULATE WIND CHILL
            double windpow; 
               windpow = Math.Pow(windspeed, .16);
            windchill = 35.74 + (.6215 * temp) - (37.75 * windpow) + (.4275 * temp * windpow);
           
            //PRINT WIND CHILL
            Console.WriteLine("Wind chill = " + windchill);

        }
    }
}
