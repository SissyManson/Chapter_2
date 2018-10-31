using System;

namespace Task_9_Quoted_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The \"use\" of quotations causes difficulties.";
            //Unicode character \u0022 for quotation mark

            string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
            Console.WriteLine("With the escape sequence: \n{0}", str1);
            Console.WriteLine("\nWith the unicode:\n{0}", str2);

        }
    }
}