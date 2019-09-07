using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoeOil
{
    public class Oil
    {
        public Oil(int tier)
        {
            Tier = tier;
        }

        public string Name => Type.ToString();
        public int Tier { get; set; }

        public OilType Type => (OilType)Tier;

        public static Oil Parse(string name)
        {
            if (int.TryParse(name, out int t))
                return new Oil(t);

            if (name.Split(' ').Count() > 1)
                name = name.Split(' ').First();

            if (string.IsNullOrWhiteSpace(name))
                return null;

            try
            {
                var type = (OilType)Enum.Parse(typeof(OilType), name, true);
                return new Oil((int)type);
            }
            catch (Exception)
            {
                return null;
            }
        }


        public static IEnumerable<Oil> ParseMany(string name)
        {
            if (name.Contains(":"))
            {
                var splits = name.Split(':');
                var oil = Parse(splits[0]);
                int count = 1;
                if (splits.Count() > 1)
                    count = int.Parse(splits[1]);
                for (int i = 0; i < count; i++)
                    yield return oil;
            }
            else
            {
                yield return Parse(name);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Oil oil &&
                   Tier == oil.Tier;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Tier);
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
