using System;

namespace remove_duplicate_characters_from_string
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(RemoveDuplicates(Console.ReadLine()));
            Console.WriteLine(RemoveDuplicates("stringstringBuilder"));
            Console.ReadKey();
        }

        static string RemoveDuplicates(string inputStr)
        {
            string input = "";
            string output = "";
            foreach (char val in inputStr)
            {
                if (input.IndexOf(val) == -1)
                {
                    input += val;
                    output += val;
                }
            }
            return output;
        }
        //http://www.csharpstar.com/remove-duplicate-characters-from-string-in-csharp/
        //Console.WriteLine(RemoveDuplicateChars(Console.ReadLine()));
        //Console.WriteLine(RemoveDuplicateChars("Line1\nLine2\nLine3"));
        //static string RemoveDuplicateChars(string key)
        //{
        //    // --- Removes duplicate chars using string concats. ---
        //    // Store encountered letters in this string.
        //    string table = "";

        //    // Store the result in this string.
        //    string result = "";

        //    // Loop over each character.
        //    foreach (char value in key)
        //    {
        //        // See if character is in the table.
        //        if (table.IndexOf(value) == -1)
        //        {
        //            // Append to the table and the result.
        //            table += value;
        //            result += value;
        //        }
        //    }
        //    return result;
        //}
    }
}
