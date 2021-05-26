/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:PROJE1
**				ÖĞRENCİ ADI............:Onur KAHVECİ
**				ÖĞRENCİ NUMARASI.......:B201210500
**              DERSİN ALINDIĞI GRUP...:1B
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_b201210500
{
    abstract class Fruit : IFood
    {
       

        abstract public int Vitamina { get; set; }
       abstract public  string Tur { get; set; }
       abstract public int Vitaminc { get; set; }
        abstract public int Agirlik { get; set; }

         public Image Image { get; set; }

        public void agirlikHesapla(int verim_oran)
        {
            Agirlik=(Agirlik * verim_oran)/100;
           // return s;
        }

        public string name()
        {
            return "Fruit";
        }

        public void vitaminHesapla(int verim_oran)
        {
            Vitamina = (Agirlik * Vitamina )/100;
            Vitaminc = (Agirlik * Vitaminc )/100;
        }
        //public Fruit(int agirlik, Image image)
        //{
        //    Agirlik = agirlik;
        //    Image = image;
        //    Vitamina = 30;
        //}
    }
}
