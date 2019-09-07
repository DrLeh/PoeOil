using System;
using System.Collections.Generic;
using System.Text;

namespace PoeOil
{
    public enum OilType
    {
        [Color(ConsoleColor.Gray)]
        Clear = 1,
        [Color(ConsoleColor.DarkYellow)]
        Sepia = 2,
        [Color(ConsoleColor.DarkRed)]
        Amber = 3,
        [Color(ConsoleColor.Green)]
        Verdant = 4,
        [Color(ConsoleColor.Blue)]
        Teal = 5,
        [Color(ConsoleColor.Cyan)]
        Azure = 6,
        [Color(ConsoleColor.DarkMagenta)]
        Violet = 7,
        [Color(ConsoleColor.Red)]
        Crimson = 8,
        [Color(ConsoleColor.DarkGray)]
        Black = 9,
        [Color(ConsoleColor.Magenta)]
        Opalescent = 10,
        [Color(ConsoleColor.White)]
        Silver = 11,
        [Color(ConsoleColor.Yellow)]
        Golden = 12,
    }
}
