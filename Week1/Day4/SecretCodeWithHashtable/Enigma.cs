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
        public Hashtable encrypter { get; private set; }
        public Hashtable decrypter { get; private set; }

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

            char x;
            char y;
            for (int i = 0; i < 26; i++)
            {
                x = Convert.ToChar(i + 65);
                y = Convert.ToChar(Convert.ToInt32(randomlyOrderedList[i]) + 65);
                encrypter.Add(x,y);
                decrypter.Add(y,x);

                //Console.Write(x + "," + y + " ");                         //included for debugging                              
            }
            //Console.ReadLine();                                           //included for debugging
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
                if (decrypter.ContainsKey(c))
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

