using System;
using System.Collections.Generic;
using System.Linq;

namespace PoeOil
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Terminal.Green($"Oil tiers:");
                foreach (OilType x in Enum.GetValues(typeof(OilType)))
                    Terminal.Cyan($"{(int)x} - {x}");

                Terminal.Green("Input your available oils as name or tier q to quit.");
                Terminal.Gray("Example 1: sepia:5,amber,verdant:3,clear:2,teal,11:1,12:2");

                var input = Console.ReadLine().Trim();
                if (input == "q")
                    return;


                var oils = input.Split(',')
                    .Select(x => x.Trim())
                    .SelectMany(x => Oil.ParseMany(x))
                    .Where(x => x != null)
                    .ToList();

                var dict = Passive.BuildOilDictionary(oils);

                Terminal.Green($"\nNodes Available:");
                var available = PassiveList.AllPassives.Where(x => x.MeetsRequirements(dict));


                foreach (var p in available)
                {
                    Terminal.PrintColor(p.A.Type.GetColor(), $"{p.A}");
                    Terminal.PrintColor(ConsoleColor.White, $" + ");
                    Terminal.PrintColor(p.B.Type.GetColor(), $"{p.B}");
                    Terminal.PrintColor(ConsoleColor.White, $" + ");
                    Terminal.PrintColor(p.C.Type.GetColor(), $"{p.C}");
                    Terminal.PrintColor(ConsoleColor.White, $" => ");
                    Terminal.PrintColor(ConsoleColor.White, $"{p.Name}");
                    Terminal.Gray($"\n{p.Effect}\n\n");
                }

                Terminal.Gray($"\nPress enter to go again");
                Console.ReadLine();
            }
        }
    }
}
