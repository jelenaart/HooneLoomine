﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HooneLoomine
{
    public class Hoone
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

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");

        }
    }

}