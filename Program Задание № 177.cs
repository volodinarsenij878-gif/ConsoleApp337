using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program177
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Цифра (0–9): ");
            if (!int.TryParse(Console.ReadLine(), out int digit) || digit < 0 || digit > 9)
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string word;
            switch (digit)
            {
                case 0: word = "ноль"; break;
                case 1: word = "один"; break;
                case 2: word = "два"; break;
                case 3: word = "три"; break;
                case 4: word = "четыре"; break;
                case 5: word = "пять"; break;
                case 6: word = "шесть"; break;
                case 7: word = "семь"; break;
                case 8: word = "восемь"; break;
                case 9: word = "девять"; break;
                default: return; // не достижимо из-за проверки выше
            }
            Console.WriteLine(word);
        }
    }
}