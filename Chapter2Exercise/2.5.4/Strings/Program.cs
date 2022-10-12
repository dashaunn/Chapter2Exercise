using System;
using System.Diagnostics;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string input;
            string searchTerm;
            string searchSentence;
            //string finalSentence;

            Console.WriteLine(sentence + "\n");
            Console.WriteLine("Please enter a word to search for from the sentence above.");
            input = Console.ReadLine();
            searchTerm = input.ToLower();
            searchSentence = sentence.ToLower();


            if (searchSentence.IndexOf(searchTerm, 0) != -1)
            {
                Console.WriteLine("true");
                Console.WriteLine("Index of match: " + "[" + (searchSentence.IndexOf(searchTerm)) + "]");
                Console.WriteLine("Length of match: " + (searchTerm.Length));
                string finalSentence = sentence.Substring(3,sentence.Length);
                Console.WriteLine(finalSentence);
            } else
            {
                Console.WriteLine("false");
            }
           
        }
    }
}

