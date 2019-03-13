using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input amount:");
            do
            {
                int input = 0;
                int tens = 0;
                int fives = 0;
                int ones = 0;

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    int amt = input;
                    tens = input / 10;
                    if (tens > 3)
                    {
                        amt = input - 30;
                        tens = 3;
                    }
                    else
                    {
                        amt = input - (tens * 10);
                    }

                    fives = amt % 5;
                    if (fives == 0)
                    {
                        fives = amt / 5;
                    }
                    else
                    {
                        fives = amt / 5;
                        ones = amt % 5;
                    }

                    Console.WriteLine(@"{0} tens, {1} fives, {2} ones", tens, fives, ones);
                }
            }
            while (true);
        }
    }
}
