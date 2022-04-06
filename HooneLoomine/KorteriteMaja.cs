using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HooneLoomine
{
    public class KorteriteMaja : Hoone
    {
        string trepikoda;
        public KorteriteMaja(int pindala = 100): base (pindala)
        {
            if (pindala <= 300)
            {
                trepikoda = "1 trepikoda";
            }
            else if (pindala == 301 && pindala <=600)
            {
                trepikoda = "2 trepikoda";
            }
            else if (pindala ==601 && pindala <=900)
            {
                trepikoda = "3 trepikoda";
            }
            else
            {
                trepikoda = "4 või rohkem trepikoda";
            }
        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Korterite majal on {trepikoda}");
        }
    }
}
