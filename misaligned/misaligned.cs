using System;
using System.Diagnostics;

namespace MisalignedSpace
{
    class Misaligned
    {
        static string formatColorMapManual()
        {
            string formattedString = "";
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    formattedString += $"{i *5 + j + 1} | {majorColors[i]} {minorColors[j]}\n";
                }
            }
            return formattedString;
        }
        static void printOnConsole(string formattedString)
        {
            Console.WriteLine(formattedString);
        }
        static void Main(string[] args)
        {
            string formattedString = formatColorMapManual();
            printOnConsole(formattedString);
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            string expectedString = "";
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    expectedString += $"{i * 5 + j + 1} | {majorColors[i]} {minorColors[j]}\n";
                }
            }
            printOnConsole(expectedString);
            Debug.Assert(formattedString.Equals(expectedString));
            Console.WriteLine("All is well (maybe!)");
            Console.ReadLine();
        }
    }
}
