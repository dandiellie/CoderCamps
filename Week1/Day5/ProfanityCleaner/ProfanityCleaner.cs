using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class ProfanityCleaner
    {
        public Dictionary<string, string> library { get; set; }

        public ProfanityCleaner()
        {
            library = new Dictionary<string, string>();
            library.Add("damn", "d**n");
            library.Add("shit", "s**t");
            library.Add("fuck", "f**k");
        }
        
        public string Clean(string s)
        {
            char delimiter = ' ';
            string[] words = s.Split(delimiter);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if(library.ContainsKey(words[i]))
                {
                    words[i] = library[words[i]];
                }
                sb.Append(words[i] + " ");
            }

            return sb.ToString();
        }
    }
}
