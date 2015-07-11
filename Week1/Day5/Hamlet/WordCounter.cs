using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamlet
{
    class WordCounter
    {
        public IOrderedEnumerable<WordsUsed> GetUniqueWords(string s)
        {
            char[] delimiter = { ' ', '!', '"', '#', '$', '%', '&', '(', ')', '.', '*', '+', ',', '/', '?', ':', ';', '@', '\\', '\n', '\r' };
            string[] wordsWithNulls = s.Split(delimiter);
            List<string> wordsWithoutNulls = new List<string>();
            List<string> wordsToSkip = new List<string> {"", "a", "an", "and", "the", "to", "of", "you", "i", "my"};
            
            for (int j = 0; j < wordsWithNulls.Length; j++)
            {
                if (wordsToSkip.Contains(wordsWithNulls[j].ToLower())) continue;
                else wordsWithoutNulls.Add(wordsWithNulls[j].ToLower());
            }

            var uniqueWords = wordsWithoutNulls.GroupBy(x => x)
            .Select(x => new WordsUsed
            {
                TimesUsed = x.Count(),
                Word = x.Key,
            })
            .OrderByDescending(x => x.TimesUsed);

            return uniqueWords;
        }

        public Tuple<List<string>, int> MostUsedWordIn(string s)
        {
            IOrderedEnumerable<WordsUsed> uniqueWordLibrary = GetUniqueWords(s);
            List<string> mostUsedWords = new List<string>();
            int mostUsedTime = 0;

            foreach (WordsUsed word in uniqueWordLibrary)
            {
                if (word.TimesUsed >= mostUsedTime)
                {
                    mostUsedWords.Add(word.Word);
                    mostUsedTime = word.TimesUsed;
                }
            }

            return new Tuple<List<string>, int>(mostUsedWords, mostUsedTime);
        }
    }
}
