using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_b201210500
{
    interface IFood
    {
         
        void vitaminHesapla(int verim_oran);
        void  agirlikHesapla(int verim_oran);
        string name();
        Image Image { get; set; }
    }
}
