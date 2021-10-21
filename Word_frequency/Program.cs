using System;
using System.Collections.Generic;

namespace Word_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Black red black";
            Dictionary<string, int> wordFrequency = numberWordsInText(text);
            PrintWordFrequency(wordFrequency);
        }
        static void PrintWordFrequency(Dictionary<string, int> wordFrequency)
        {
            foreach (var word in wordFrequency)
            {
                System.Console.WriteLine($"{word.Key}: {word.Value}");
            }
        }
        static Dictionary<string, int> numberWordsInText(string text)
        {
            List<string> words = new List<string>(text.ToLower().Split(' '));
            Dictionary<string, int> wordsNumber = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!wordsNumber.ContainsKey(word))
                    wordsNumber.Add(word, 1);
                else
                    wordsNumber[word] = wordsNumber[word] + 1;
            }
            return wordsNumber;
        }
    }
}
