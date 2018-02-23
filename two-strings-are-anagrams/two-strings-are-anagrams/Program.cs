using System;

namespace two_strings_are_anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter string2");
            string str2 = Console.ReadLine();
            if (str1 != "" && str2 != "" && str1.Length == str2.Length)
            {
                char[] char1 = str1.ToLower().ToCharArray();
                char[] char2 = str2.ToLower().ToCharArray();
                Array.Sort(char1);
                Array.Sort(char2);
                str1 = new string(char1);
                str2 = new string(char2);
                if (str1 == str2)
                    Console.WriteLine("Two Strings \"{0}\" Are Anagram Words", str1, str2);
                else
                    Console.WriteLine("Strings non Anagram Words");
            }
            else
            Console.WriteLine("Enter Strings Properly");
            Console.ReadKey();
            //http://www.csharpstar.com/csharp-program-to-determine-if-two-words-are-anagrams-of-each-other/
            //        //Receive Words from User  
            //        Console.Write("Enter first word:");
            //    string word1 = Console.ReadLine();
            //    Console.Write("Enter second word:");
            //    string word2 = Console.ReadLine();

            //    //Add optional validation of input words if needed.  
            //    //.....  
            //    if (word1 != "" && word2 != "" && word1.Length == word2.Length)
            //    {

            //        //step 1  
            //        char[] char1 = word1.ToLower().ToCharArray();
            //        char[] char2 = word2.ToLower().ToCharArray();

            //        //Step 2  
            //        Array.Sort(char1);
            //        Array.Sort(char2);

            //        //Step 3  
            //        string NewWord1 = new string(char1);
            //        string NewWord2 = new string(char2);

            //        //Step 4  
            //        //ToLower allows to compare the words in same case, in this case, lower case.  
            //        //ToUpper will also do exact same thing in this context  
            //        if (NewWord1 == NewWord2)
            //        {
            //            Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            //        }

            //        //Hold Console screen alive to view the results.  
            //        Console.ReadLine();
            //    }
        }
    }  
}  
