using System;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            Console.WriteLine("Welcome to the Pig Latin Translator");

            while (runProgram == true)
            {
                Console.WriteLine("Please Enter a Statment to be Translated into Pig Latin:");
                string userInput = Console.ReadLine();

                Console.WriteLine(WordMethod(userInput.ToLower()));

                Console.WriteLine("Do you want to translate another word? (y/n)");
                string loopAnswer = Console.ReadLine();
                if (loopAnswer == "n")
                {
                    runProgram = false;
                }
            }
        }

        public static string WordMethod(string wordPig)
        {
            string wordWay = "way";
            string wordAy = "ay";
            char[] mainText = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char letters in mainText)
            {
                if (wordPig[0] == letters)
                {
                    return wordPig + wordWay;
                }
            }

            int starterText = wordPig.IndexOfAny(mainText);
            string sentChunk = wordPig.Substring(starterText);
            string sentChunk2 = wordPig.Substring(0, starterText);

            return sentChunk + sentChunk2 + wordAy;
        }
    }
}
