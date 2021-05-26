using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_b201210500
{
    interface Sikacak
    {
         bool sikacak(string a);
    }

    class SiviSikacak : Sikacak
    {
        public bool sikacak(string a)
        {
            if (a == "Narenciye") return true;
            else return false;
        }
    }

    class KatiSikacak : Sikacak
    {
        public bool sikacak(string a)
        {
            if (a == "Kati") return true;
            else return false;
        }
    }
}
