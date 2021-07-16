using System;

namespace LoteryNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            var limit = 6;
            var loteryNumberGenerator = new LoteryNumberGenerator();

            for (int i = 0; i < 200; i++)
            {
                var result = loteryNumberGenerator.NumberGenerator(limit);
                loteryNumberGenerator.Show(result);
            }
            
            Console.ReadLine();
        }
    }
}
