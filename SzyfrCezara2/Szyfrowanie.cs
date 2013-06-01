using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrCezara2
{
    class Szyfrowanie
    {

        private string x;

        public string szyfr(string wiadomosc, int n)
        {
            x = "";

            for (int i = 0; i < wiadomosc.Length; i++)
            {
                if (Convert.ToInt32(wiadomosc[i]) > 64 && Convert.ToInt32(wiadomosc[i])<91 && Convert.ToInt32(wiadomosc[i])+n>90)
                {
                    x = x+Convert.ToChar((Convert.ToInt32(wiadomosc[i]) + n) - 26);
                }
                else if (Convert.ToInt32(wiadomosc[i]) > 96 && Convert.ToInt32(wiadomosc[i]) < 123 && Convert.ToInt32(wiadomosc[i]) + n > 122)
                {
                    x = x + Convert.ToChar((Convert.ToInt32(wiadomosc[i]) + n) - 26);
                }
                else if (Convert.ToInt32(wiadomosc[i]) > 47 && Convert.ToInt32(wiadomosc[i]) < 58 && Convert.ToInt32(wiadomosc[i]) + n > 57)
                {
                    x = x + Convert.ToChar((Convert.ToInt32(wiadomosc[i]) + n) - 26);
                }
                else
                x = x+Convert.ToChar((Convert.ToInt32(wiadomosc[i])+n));
            }

                return x; 
        }
        public string deszyfr(string wiadomosc, int n)
        {
            x = "";

            for (int i = 0; i < wiadomosc.Length; i++)
            {
                if (Convert.ToInt32(wiadomosc[i]) > 64 && Convert.ToInt32(wiadomosc[i]) < 91 && Convert.ToInt32(wiadomosc[i]) - n < 65)
                {
                    x = x + Convert.ToChar((Convert.ToInt32(wiadomosc[i]) - n) + 26);
                }
                else if (Convert.ToInt32(wiadomosc[i]) > 96 && Convert.ToInt32(wiadomosc[i]) < 123 && Convert.ToInt32(wiadomosc[i]) - n < 97)
                {
                    x = x + Convert.ToChar((Convert.ToInt32(wiadomosc[i]) - n) + 26);
                }
                else if (Convert.ToInt32(wiadomosc[i]) > 47 && Convert.ToInt32(wiadomosc[i]) < 58 && Convert.ToInt32(wiadomosc[i]) - n < 57)
                {
                    x = x + Convert.ToChar((Convert.ToInt32(wiadomosc[i]) - n) + 26);
                }
                else
                    x = x + Convert.ToChar((Convert.ToInt32(wiadomosc[i]) - n));
            }

            return x;
        }

    }
}
