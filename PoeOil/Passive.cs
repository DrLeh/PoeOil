using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PoeOil
{
    public class Passive
    {
        public string Name { get; set; }
        public string Effect { get; set; }

        public Oil A { get; set; }
        public Oil B { get; set; }
        public Oil C { get; set; }

        public List<int> AllOils => new[] { A.Tier, B.Tier, C.Tier }.ToList();


        //tier / count
        public Dictionary<int, int> GetRequirements() => BuildOilDictionary(new[] { A, B, C });

        public static Dictionary<int, int> BuildOilDictionary(IEnumerable<Oil> oils)
        {
            var dict = new Dictionary<int, int>();

            void Add(int tier)
            {
                if (dict.ContainsKey(tier))
                    dict[tier] = dict[tier] + 1;
                else
                    dict[tier] = 1;
            }

            foreach(var oil in oils)
            {
                Add(oil.Tier);
            }

            return dict;
        }


        public bool MeetsRequirements(Dictionary<int, int> owned)
        {
            var reqs = GetRequirements();


            foreach (var req in reqs)
            {
                if (owned.GetValueOrDefault(req.Key) < req.Value)
                    return false;
            }

            return true;
        }



        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }

        public override bool Equals(object obj)
        {
            return obj is Passive passive &&
                   EqualityComparer<Oil>.Default.Equals(A, passive.A) &&
                   EqualityComparer<Oil>.Default.Equals(B, passive.B) &&
                   EqualityComparer<Oil>.Default.Equals(C, passive.C);
        }
    }
}
