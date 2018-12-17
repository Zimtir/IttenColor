using System;
using System.Drawing;

namespace IttenCircle
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // For Yellow - > Violet
            // More information here http://www.huevaluechroma.com/113.php

            Console.WriteLine(GetIttenColor(Color.Yellow));
            Console.ReadKey();
        }

        public static Color GetIttenColor(Color color)
        {
            return Color.FromArgb(
                (byte)(256 - color.R),
                (byte)(256 - color.G),
                (byte)(256 - color.B)
            );
        }
    }
}
