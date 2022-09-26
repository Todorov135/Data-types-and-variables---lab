using System;

namespace labDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int merters = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(merters/1000.0):f2}");
        }
    }
}
