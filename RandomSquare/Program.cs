using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> firstList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int interest = random.Next(1, 50);
                firstList.Add(interest);
                // to console a list out and ensure each indexed spot, use this sort of setup: Console.WriteLine($"{firstList[i]} at {i}");
            }

            List<int> newList = new List<int>();

            foreach (int first in firstList)
            {
                // ensure each item is coming into the foreach: Console.WriteLine(first);
                newList.Add(first * first);
            }

            var finalList = newList.Where(number => number % 2 == 0);

            Console.WriteLine(finalList);
            Console.ReadLine();

        }
    }
}
