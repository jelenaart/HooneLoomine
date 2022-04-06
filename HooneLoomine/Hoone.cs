using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HooneLoomine
{
    public abstract class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
        public Uks GetUks()
        {
            return uks;
        }

        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }

        public int HooneKorrus { get; set; }
        public Uks(int korrus = 3)
        {
            HooneKorrus = korrus;
        }


        public override void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");

        }

    }

}
