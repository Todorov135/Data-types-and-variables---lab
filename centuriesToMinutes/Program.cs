using System;

namespace centuriesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int ceturies = int.Parse(Console.ReadLine());
            int years = ceturies * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{ceturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
