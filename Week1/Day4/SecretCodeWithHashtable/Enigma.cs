using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretCodeWithHashtable
{
    class Enigma
    {
        private Hashtable encrypter { get; set; }
        private Hashtable decrypter { get; set; }

        public Enigma(Random r)
        {
            Hashtable encrypter = new Hashtable();
            Hashtable decrypter = new Hashtable();
            ArrayList randomlyOrderedList = new ArrayList();

            int randNum = 0;

            for (int i = 0; i < 26; i++)
            {
                do
                {
                    randNum = r.Next(26);
                } while (randomlyOrderedList.Contains(randNum) == true);

                randomlyOrderedList.Add(randNum);

                // Console.Write(randNum + " ");                            //included for debugging
            }
            // Console.ReadLine();                                          //included for debugging

            for (int i = 0; i < 26; i++)
            {
                encrypter.Add(i + 65, Convert.ToInt32(randomlyOrderedList[i]) + 65);
                decrypter.Add(Convert.ToInt32(randomlyOrderedList[i]) + 65, i + 65);
            }
        }

        public string Encrypt(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (encrypter.ContainsKey(c))
                {
                    sb.Append(encrypter[c]);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return Convert.ToString(sb);
        }

        public string Decrypt(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (decrypter.ContainsValue(Convert.ToInt32(c)))
                {
                    sb.Append(decrypter[c]);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return Convert.ToString(sb);
        }
    }
}

