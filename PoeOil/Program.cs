using System;
using System.Collections.Generic;
using System.Linq;

namespace PoeOil
{
    class Program
    {
        static void Main(string[] args)
        {
            bool upConvert = true;
            while (true)
            {
                Console.Clear();
                if (upConvert)
                    Terminal.Yellow($"Upconversion ON - Processing might be slow. Disable to improve performance but see less advanced options");
                else
                    Terminal.Green($"Upconversion OFF");

                Terminal.Blue($"Oil tiers:");
                foreach (OilType x in Enum.GetValues(typeof(OilType)))
                    Terminal.Cyan($"{(int)x} - {x}");

                Terminal.Green("Input your available oils as name or tier. 'q' to quit. 'u' to toggle upconversion");
                Terminal.Gray("Example: sepia:5,amber,verdant:3,clear:2,teal,11:1,12:2");

                var input = Console.ReadLine().Trim().ToLower();
                if (input == "q")
                    return;
                if (input == "u")
                {
                    upConvert = !upConvert;
                }


                var oils = input.Split(',')
                    .Select(x => x.Trim())
                    .SelectMany(x => Oil.ParseMany(x))
                    .Where(x => x != null)
                    .ToList();

                var analyzer = new PassiveAnalyzer();
                analyzer.Analyze(oils, upConvert);

                Terminal.Gray($"\nPress enter to go again");
                Console.ReadLine();
            }
        }
    }
}
