using System;

namespace reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str=Console.ReadLine();
            String revStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
                revStr += str[i];
                Console.WriteLine(revStr);
            Console.ReadKey();
        }
    }
}
//http://www.csharpstar.com/c-program-to-reverse-a-string/