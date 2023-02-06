using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        // Create Music sounds using Console.Beep
        static int[] DO = new int[] { 131, 262, 523, 1046 };
        static int[] RE = new int[] { 147, 294, 587, 1174 };
        static int[] MI = new int[] { 165, 330, 659, 1318 };
        static int[] FA = new int[] { 175, 349, 698, 1396 };
        static int[] SO = new int[] { 196, 392, 784, 1568 };
        static int[] LA = new int[] { 220, 440, 880, 1760 };
        static int[] TI = new int[] { 247, 494, 988, 1976 };

        static void Main(string[] args)
        {
            char key = '1';
            while (key != ((char)ConsoleKey.Escape))
            {
                key = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(36, 12);
                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (key)
                {
                    case 'q':
                        Console.Beep(DO[2], 200);
                        Console.Write("DO");
                        break;
                    case 'w':
                        Console.Beep(RE[2], 200);
                        Console.Write("RE");
                        break;
                    case 'e':
                        Console.Beep(MI[2], 200);
                        Console.Write("MI");
                        break;
                    case 'r':
                        Console.Beep(FA[2], 200);
                        Console.Write("FA");
                        break;
                    case 't':
                        Console.Beep(SO[2], 200);
                        Console.Write("SO");
                        break;
                    case 'y':
                        Console.Beep(LA[2], 200);
                        Console.Write("LA");
                        break;
                    case 'u':
                        Console.Beep(TI[2], 200);
                        Console.Write("TI");
                        break;
                    case 'i':
                        Console.Beep(DO[3], 200);
                        Console.Write("DO");
                        break;
                }
            }
        }
    }
}