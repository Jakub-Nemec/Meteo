using System;
using System.Linq;

namespace Meteo_OOP
{
    public class Meteora
    {
        public void meteoWork()
        {
            int[] temps = new int[7];
            int temporary = 0;

            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Son" };


            for (int i = 0; i < temps.Length; i++)
            {
                do
                {
                    Console.Write("What was the temperature on {0}?: ", days[i]);
                    temporary = 0;
                    while (!int.TryParse(Console.ReadLine(), out temporary))
                    {
                        Console.Write("Invalid input. Try again: ");
                    }
                } while (temporary < -50 || temporary > 60);
                temps[i] = temporary;
            }

            Console.WriteLine("==========================");

            for (int i = 0; i < temps.Length; i++)
            {
                Console.Write("{0}: ", days[i]);

                if (temps[i] > 0)
                {
                    for (int x = 0; x < temps.Min() * -1; x++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");

                    for (int y = 0; y < temps[i]; y++)
                    {
                        Console.Write("+");
                    }
                }

                if (temps[i] < 0)
                {
                    for (int x = 0; x < temps.Min() * -1 - temps[i] * -1; x++)
                    {
                        Console.Write(" ");
                    }

                    for (int y = 0; y < temps[i] * -1; y++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("|");
                }

                if (temps[i] == 0)
                {
                    for (int z = 0; z < temps.Min() * -1; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                }

                Console.WriteLine(" {0}", temps[i]);
            }
            Console.WriteLine("==========================");

            int maxInd = temps.Max();
            int minInd = temps.Min();

            int counter = 0;

            string maxTempsDays = "";
            string minTempsDays = "";


            foreach (var i in temps)
            {
                if (i == minInd)
                {
                    minTempsDays += String.Format(" {0} ", days[counter]);
                }

                if (i == maxInd)
                {
                    maxTempsDays += String.Format(" {0} ", days[counter]);
                }

                counter++;
            }

            //int maxi = Array.IndexOf(temps, temps.Max());
            //int mini = Array.IndexOf(temps, temps.Min());

            Console.WriteLine("Maximum temperature: {0} (in days: {1})", temps.Max(), maxTempsDays);
            Console.WriteLine("Minimum temperature: {0} (in days: {1})", temps.Min(), minTempsDays);
            Console.WriteLine("Avarage temperature: {0}", Math.Round(temps.Average(), 2));
            Console.ReadKey();
        }
    }
}
