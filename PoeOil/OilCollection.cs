using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoeOil
{
    public class OilCollection
    {
        public OilCollection(List<Oil> oils)
        {
            Oils = oils;
        }

        public List<Oil> Oils { get; set; }


        public bool TryUpconvertTo(Oil target)
        {
            var oils = Oils
                .Where(x => x.Tier < target.Tier)
                .OrderBy(x => x.Tier)
                ;
            //DO NOT tolist this so it re-groups each time

            var tiers = Enumerable.Range(1, target.Tier - 1);

            foreach (var tier in tiers)
            {
                var countAtTier = Oils.Count(x => x.Tier == tier);
                var toRemove = (countAtTier / 3) * 3;

                for (int i = 0; i < toRemove; i++)
                    Oils.Remove(tier);

                var toAdd = toRemove / 3;
                for (int i = 0; i < toAdd; i++)
                    Oils.Add(tier + 1);
            }

            if (Oils.Contains(target))
                return true;
            return false;
        }


    }
}
