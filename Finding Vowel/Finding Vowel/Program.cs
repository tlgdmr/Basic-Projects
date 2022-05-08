using System;
using System.Collections.Generic;

namespace Finding_Vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowel = new List<char>();
            vowel.Add('a');
            vowel.Add('e');
            vowel.Add('i');
            vowel.Add('o');
            vowel.Add('u');

            int count = 0;

            Console.WriteLine("Write a sentence or a word");
            string input = Console.ReadLine();

            String[] sentence = input.Split(" ");

            string divideTheSentenceIntoWords;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != null)
                {
                    divideTheSentenceIntoWords = sentence[i];
                    for (int k = 0; k < sentence[i].Length; k++)
                    {
                        char allWords = divideTheSentenceIntoWords[k];
                        for (int l = 0; l < 5; l++)
                        {
                            if (vowel[l] == allWords)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
