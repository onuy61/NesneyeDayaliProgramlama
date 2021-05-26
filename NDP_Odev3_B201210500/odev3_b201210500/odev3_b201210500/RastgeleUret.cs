using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_b201210500
{
    static class  RastgeleUret
    {
        static Random rnd=new Random();

        public static int Uret(int min ,int max)
        {
            return rnd.Next(min, max);
        }

    }
}
