using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PoeOil
{
    public static class EnumExtensions
    {
        public static ConsoleColor GetColor<TEnum>(this TEnum value)
            where TEnum : struct, Enum
        {
            var type = value.GetType();
            var description = value.ToString();
            var memberInfo = type.GetMember(description);
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(ColorAttribute), false).OfType<ColorAttribute>();
                if (attrs.Count() > 0)
                {
                    return attrs.First().Color;
                }
            }
            return ConsoleColor.White;
        }

        public static IEnumerable<TEnum> GetValues<TEnum>(this TEnum value)
        {
            return Enum.GetValues(value.GetType()).Cast<TEnum>();
        }
    }
}
