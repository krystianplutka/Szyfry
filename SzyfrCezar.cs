using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSzyfryPlutka
{
    class SzyfrCezar
    {
        public string SzyfrujCezar(string tekst, int przesuniecie)
        {
            char[] szyfr = tekst.ToCharArray();

            for (int i = 0; i < szyfr.Length; i++)
            {
                char znak = szyfr[i];
                if ((znak >= 65) && (znak <= 90))

                {
                    znak = (char)(znak - 65);
                    znak = (char)(znak -3);
                        znak = (char)(znak % przesuniecie); 
                    znak = (char)(znak + 65);
                    szyfr[i] = znak;
                }
                else if ((znak >= 97) && (znak <= 122))
                {
                    znak = (char)(znak - 97);
                    znak = (char)(znak + 3);
                    znak = (char)(znak % przesuniecie);
                    znak = (char)(znak + 97);
                    szyfr[i] = znak;

                }
                else if ((znak >= 48) && (znak <= 57))
                {
                    znak = (char)(znak - 48);
                    znak = (char)(znak + 3);
                    znak = (char)(znak % przesuniecie);
                    znak = (char)(znak + 48);
                    szyfr[i] = znak;
                }
            }
            return new string(szyfr);
        }

        
        
    }
}