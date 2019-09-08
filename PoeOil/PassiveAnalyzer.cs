using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoeOil
{
    public class PassiveAnalyzer
    {
        public void Analyze(List<Oil> oils, bool upConvert)
        {
            var dict = Passive.BuildOilDictionary(oils);

            Terminal.Green($"\nNodes Available:");

            var available = PassiveList.AllPassives.Where(x => x.MeetsRequirements(dict)).ToList();

            if (upConvert)
            {
                var remaining = PassiveList.AllPassives.Except(available);
                var extraAvailable = remaining.Where(x => x.MeetsRequirementsWithUpconversion(oils));
                available.AddRange(extraAvailable);
                available = available.OrderBy(x => x.Index).Distinct().ToList();
            }


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
        }
    }
}
