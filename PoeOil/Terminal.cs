using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using C = System.Console;
using Newtonsoft.Json;

namespace PoeOil
{
    /// <summary>
    /// Helper class to more easily access frequently-used user IO
    /// </summary>
    public static class Terminal
    {
        public static void Green(string fmt, params object[] args)
        {
            PrintLineColor(ConsoleColor.Green, fmt, args);
        }
        public static void Red(string fmt, params object[] args)
        {
            PrintLineColor(ConsoleColor.Red, fmt, args);
        }
        public static void Blue(string fmt, params object[] args)
        {
            PrintLineColor(ConsoleColor.Blue, fmt, args);
        }
        public static void White(string fmt = null, params object[] args)
        {
            PrintLineColor(ConsoleColor.White, fmt, args);
        }
        public static void Cyan(string fmt, params object[] args)
        {
            PrintLineColor(ConsoleColor.DarkCyan, fmt, args);
        }
        public static void Yellow(string fmt, params object[] args)
        {
            PrintLineColor(ConsoleColor.DarkYellow, fmt, args);
        }
        public static void Magenta(string fmt, params object[] args)
        {
            PrintLineColor(ConsoleColor.Magenta, fmt, args);
        }
        public static void Gray(string fmt, params object[] args)
        {
            PrintLineColor(ConsoleColor.DarkGray, fmt, args);
        }
        public static void Line()
        {
            C.WriteLine();
        }

        public static void GoodBad(string good, string bad, bool result)
        {
            if (result)
                Green(good);
            else
                Red(bad);
        }

        public static object locker = new object();
        public static void PrintColor(ConsoleColor color, string fmt, params object[] args)
        {
            lock (locker)
            {
                ConsoleColor currentColor = C.ForegroundColor;
                C.ForegroundColor = color;
                if (args?.Any() ?? false)
                    C.Write(fmt, args);
                else
                    C.Write(fmt);
                C.ForegroundColor = currentColor;
            }
        }

        public static void PrintLineColor(ConsoleColor color, string fmt, params object[] args)
        {
            PrintColor(color, fmt, args);
            C.WriteLine();
        }

        //overload without args needed for printing strings with {}s in them.
        public static void PrintColor(ConsoleColor color, string message)
        {
            lock (locker)
            {
                ConsoleColor currentColor = C.ForegroundColor;
                C.ForegroundColor = color;
                C.Write(message);
                C.ForegroundColor = currentColor;
            }
        }

        public static string ReadUntilProvided(string prompt)
        {
            string res = "";
            while (string.IsNullOrWhiteSpace(res))
            {
                Yellow(prompt);
                res = C.ReadLine();
            }
            return res;
        }
        public static string ReadUntilProvidedProtected(string prompt)
        {
            string res = "";
            while (string.IsNullOrWhiteSpace(res))
            {
                Yellow(prompt);
                ConsoleKeyInfo key;
                do
                {
                    key = C.ReadKey(true);

                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace)
                    {
                        res += key.KeyChar;
                        C.Write("*");
                    }
                    else
                    {
                        C.Write("\b");
                    }
                }
                // Stops Receving Keys Once Enter is Pressed
                while (key.Key != ConsoleKey.Enter);
            }
            C.WriteLine();
            return res.Trim();
        }

        //for printing things as json objects. Makes it easy to see what an object contains when debugging
        public static class Json
        {
            static string Serialize(object obj)  => JsonConvert.SerializeObject(obj);

            public static void PrintColor(ConsoleColor color, object obj)
            {
                var serialized = Serialize(obj);
                Terminal.PrintColor(color, serialized);
            }

            public static void PrintLineColor(ConsoleColor color, object obj)
            {
                PrintColor(color, obj);
                C.WriteLine();
            }

            public static void Green(object obj)
            {
                PrintLineColor(ConsoleColor.Green, obj);
            }
            public static void Red(object obj)
            {
                PrintLineColor(ConsoleColor.Red, obj);
            }
            public static void Blue(object obj)
            {
                PrintLineColor(ConsoleColor.Blue, obj);
            }
            public static void Cyan(object obj)
            {
                PrintLineColor(ConsoleColor.DarkCyan, obj);
            }
            public static void White(object obj)
            {
                PrintLineColor(ConsoleColor.White, obj);
            }
        }
    }
}
