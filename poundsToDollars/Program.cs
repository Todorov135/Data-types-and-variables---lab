using System;

namespace poundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
           double britishPounds = double.Parse(Console.ReadLine());
            const double rate = 1.31;
            double dollars = britishPounds * rate;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
