using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamlet
{
    class WordCounter
    {
        public List<WordsUsed> GetUniqueWords(string s)
        {
            List<WordsUsed> uniqueWords = new List<WordsUsed>();
            
            char[] delimiter = { ' ', '!', '"', '#', '$', '%', '&', '(', ')', '.', '*', '+', ',', '/', '?', ':', ';', '@', '\\', '\n', '\r'};
            string[] words = s.Split(delimiter);
            string word = "";

            for (int j = 0; j < words.Length; j++)
            {
                word = words[j].ToLower();
                if (word == "" || word == "a" || word == "an" || word == "the")
                {
                    continue;
                }
                else if (uniqueWords.Count != 0)
                {
                    for (int i = 0; i < uniqueWords.Count; i++)
                    {
                        if (word == uniqueWords[i].Word)
                        {
                            uniqueWords[i].TimesUsed++;
                        }
                        else
                        {
                            uniqueWords.Add(new WordsUsed { Word = word, TimesUsed = 1 });
                        }
                    }
                }
                else
                {
                    uniqueWords.Add(new WordsUsed { Word = word, TimesUsed = 1 });
                }
            }

            return uniqueWords;
        }

        public Tuple<List<string>, int> MostUsedWordIn(string s)
        {
            List<WordsUsed> uniqueWordLibrary = GetUniqueWords(s);
            int mostUsedTimes = 0;
            List<string> mostUsedWords = new List<string>();
            for (int i = 0; i < uniqueWordLibrary.Count; i++)
            {
                if (uniqueWordLibrary[i].TimesUsed >= mostUsedTimes)
                {
                    mostUsedTimes = uniqueWordLibrary[i].TimesUsed;
                    mostUsedWords.Add(uniqueWordLibrary[i].Word);
                }
            }

            return new Tuple<List<string>, int>(mostUsedWords, mostUsedTimes);
        }
    }
}
