using System;
using System.Collections.Generic;
using System.Text;

namespace PoeOil
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class ColorAttribute : Attribute
    {
        public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }

        public ConsoleColor Color { get; }
    }
}
