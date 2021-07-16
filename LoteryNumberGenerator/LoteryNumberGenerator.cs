using System;
using System.Collections.Generic;

namespace LoteryNumberGenerator
{
    public class LoteryNumberGenerator
    {
        public SortedSet<int> NumberGenerator(int limit)
        {
            var count = limit;

            var collection = new SortedSet<int>();

            while (count > 0)
            {
                Random rnd = new Random();
                var number = rnd.Next(1, 50);

                if (!collection.Contains(number))
                {
                    collection.Add(number);
                    count--;
                }
            }

            return collection;
        }

        public void Show(SortedSet<int> collection)
        {
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.ForegroundColor = GetColour(item);
                Console.Write($"{item} ");
            }
        }

        private  ConsoleColor GetColour(int number)
        {
            switch (number)
            {
                case int n when (n < 10):
                    return ConsoleColor.Magenta;
                case int n when (n > 9 && n < 20):
                    return ConsoleColor.Blue;
                case int n when (n > 19 && n < 30):
                    return ConsoleColor.Red;
                case int n when (n > 29 && n < 40):
                    return ConsoleColor.Green;
                case int n when (n > 39 && n < 50):
                    return ConsoleColor.Yellow;
                default:
                    return ConsoleColor.White;
            }
        }
    }
}
