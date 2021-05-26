using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_b201210500
{
    abstract class Vegatable : IFood // sebze soyut sınıfı sadece deneme amaçlı yapılmıştır.İlerde ekleme 
                                     //yapılmak istenirse bu sınıf üzeerinden işlemler yapılabilir.
    {
        public Image Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void agirlikHesapla(int verim_oran)
        {
            throw new NotImplementedException();
        }

        public string name()
        {
            return "Vegetable";
        }

        public void vitaminHesapla(int verim_oran)
        {
            throw new NotImplementedException();
        }
    }
}
