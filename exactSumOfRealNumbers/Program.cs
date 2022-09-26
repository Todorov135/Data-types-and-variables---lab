using System;

namespace exactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < num; i++)
            {
                decimal addNum = decimal.Parse(Console.ReadLine());
                 
                sum += addNum;
            }
            Console.WriteLine(sum);
        }
    }
}
