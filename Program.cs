using System;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator");

            Console.WriteLine("Please Enter a Statment to be Translated into Pig Latin:");
            string userInput = Console.ReadLine();

            Console.WriteLine(VowelMethod(userInput.ToLower()));
        }

        public static string VowelMethod(string wordPig)
        {
            string wordWay = "way";
            string wordAy = "ay";
            char[] mainVowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char letters in mainVowels)
            {
                if (wordPig[0] == letters)
                {
                    return wordPig + wordWay;
                }
            }

            int startervowel = wordPig.IndexOfAny(mainVowels);
            string sentChunk = wordPig.Substring(startervowel);
            string sentChunk2 = wordPig.Substring(0, startervowel);

            return sentChunk + sentChunk2 + wordAy;
        }
    }
}
