using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HooneLoomine
{
    static class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja();
            KorteriteMaja korterike = new KorteriteMaja();
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            mees.hoone = majake;
            mees.NaitaInfo();
            majake.NaitaInfo();
            korterike.NaitaInfo();
            Console.ReadKey();
        }

    }
}