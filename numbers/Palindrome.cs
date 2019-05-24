/* Program for palindrone detection
 * 
 * Author : Saba Fatima
 * 
 */

using System;

namespace codepractice
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            // Initializing a String object `line` to store each line read by the StreamReader
            string line;

            // Opening the file which contains palindrome list
            System.IO.StreamReader file = new System.IO.StreamReader("/Users/appalibharath/Projects/codepractice/codepractice/palindrome-words.txt");

            // Reading the file line by line
            // Each line in the file is a word which may or may not be a palindrome
            while ((line = file.ReadLine()) != null)
            {
                // Calls the function `isPalindrome` which return a boolean
                // Returns True if words are palindrome False if not
                if (isPalindrome(line))
                {
                    System.Console.WriteLine(line + " is a Palindrome");
                }
                else
                {
                    System.Console.WriteLine(line + " is not a Palindrome");
                }
            }
            // Closing the file
            file.Close();
        }

        static bool isPalindrome(string word)
        {
            /* Edit this function to return a boolean 
             * 
             * return true if `word` is palindrome
             * 
             * What are palindrome ?
             * 
             * a word, phrase, or sequence that reads the same backwards as forwards, e.g. `MADAM`, `LEVEL`
             * 
             */
        }
    }
}
