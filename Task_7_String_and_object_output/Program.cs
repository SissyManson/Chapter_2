using System;

namespace Task_7_String_and_object_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World :)";
            object obj = a + " " + b;

            Console.WriteLine(obj);
        }
    }
}