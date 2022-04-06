using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HooneLoomine
{
    class EraMaja : Hoone
    {
        string suurus;
        int korrus;
        public EraMaja(int pindala = 50) : base (pindala)
        {
            if (pindala <=100)
            {
                suurus = "vaike maja";
            }
            else if (pindala ==101 && pindala <=200)
            {
                suurus = "keskmine maja";
            }
            else if (pindala ==201 && pindala <=300)
            {
                suurus = "suur maja";
            }
            else
            {
                suurus = "liiga suur maja";
            }
        }
        public int Korrus
        {
            set { korrus = value; }
            get { return korrus; }
        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Eramaja suurus on {suurus}, majal on {korrus} korruseid");
        }
    }
}