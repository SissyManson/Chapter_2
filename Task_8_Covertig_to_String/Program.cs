using System;

namespace Task_8_Covertig_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World is boring, I'll change it
            string str1 = "Good";
            string str2 = "Evening!";
            object obj = str1 + " " + str2;
            string str3 = obj.ToString();

            Console.WriteLine(str3);
        }
    }
}
