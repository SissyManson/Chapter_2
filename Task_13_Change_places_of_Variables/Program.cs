using System;

namespace Task_13_Change_places_of_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before the swap \n a={0} b={1}", a, b);
            //without swap a={1} b={0}

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Ater the swap \n a={0} b={1}", a, b);
        }
    }
}
