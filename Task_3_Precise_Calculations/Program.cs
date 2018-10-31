using System;

namespace Task_3_Precise_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 5.25745243896m;
            decimal y = 9.8544531763m;
            x += y;
            Console.WriteLine(x.ToString("#.######"));
        }
    }
}
