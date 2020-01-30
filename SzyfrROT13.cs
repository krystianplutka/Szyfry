using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSzyfryPlutka
{
    class SzyfrROT13
    {
        public string ROT13(string tekst)
        {
            char[] tekstChar = tekst.ToCharArray();
            for (int i = 0; i < tekstChar.Length; i++)
            {
                int znak = (int)tekstChar[i];

                if (znak >= 'a' && znak <= 'z')
                {
                    if (znak > 'm')
                    {
                        znak -= 13;
                    }
                    else
                    {
                        znak += 13;
                    }
                }
                else if (znak >= 'A' && znak <= 'Z')
                {
                    if (znak > 'M')
                    {
                        znak -= 13;
                    }
                    else
                    {
                        znak += 13;
                    }
                }
                tekstChar[i] = (char)znak;
            }
            return new string(tekstChar);
        }
    }
}
