using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nFirst 10 Even Natural Numbers:");
            int evenCounter = 1;
            while (evenCounter <= 20)
            {
                if (evenCounter % 2 == 0)
                {
                    Console.Write($"{evenCounter} ");
                    evenCounter++;
                }
                else
                {
                    evenCounter++;
                }
            }

          
            Console.WriteLine("\n\nFirst 10 Odd Natural Numbers:");
            int oddCounter = 1;
            do
            {
                if (oddCounter % 2 != 0)
                {
                    Console.Write($"{oddCounter} ");
                }
                oddCounter++;
            } 
            while (oddCounter <= 20);

            Console.ReadLine();
        }
    }
}
