using System;

namespace number_of_words_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a  Sentance");
            Console.WriteLine(Count(Console.ReadLine()));
            Console.ReadKey();
        }
        public static int Count(string inputStr)
        {
            int result = 0;
            if (inputStr == "")
                return result;
            inputStr = inputStr.Trim();
            while (inputStr.Contains("  "))
                inputStr = inputStr.Replace("  ", " ");
            foreach (string str in inputStr.Split(' '))
                result++;
            return result;
        }
    }
}
