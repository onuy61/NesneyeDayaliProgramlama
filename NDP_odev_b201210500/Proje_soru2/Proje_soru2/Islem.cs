/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:ÖDEV1
**				ÖĞRENCİ ADI............:Onur KAHVECİ
**				ÖĞRENCİ NUMARASI.......:B201210500
**              DERSİN ALINDIĞI GRUP...:1B
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje_soru2
{
    class Islem
    {
        public Islem()
        {

        }
        public void menuYazdir() {
            Console.WriteLine("    \nMenu");
            Console.WriteLine("1-string bir değişkende , string deger substring kullanmadan ara");
            Console.WriteLine("2-string bir değişkende , string deger substring kullanarak ara");
            Console.WriteLine("3-Alfabenin karakterlerini bir strring de ara , kaç adet geçiyor bul ve çiz");
            Console.WriteLine("0-Programdan çıkmak icin.");
            Console.Write("Seçiminiz:");
        }
        public void subsizAra()   // substring veya herhangi bir fonksiyon kullanılmadan arama yapar
        {
            bool sonuc = false;
            Console.Write("Aranılacak kelime:");
             string ara = Console.ReadLine();
            Console.Write("Karakter Dizini:");
            string cumle = Console.ReadLine();
            string kelime = "";

            for (int i = 0; i <= cumle.Length - ara.Length; i++)
            {
                for (int k = i; k <ara.Length + i; k++)
                {
                    kelime = kelime + cumle[k];  // aranan kelime boyutunda kelime oluştrulur

                }
                if (kelime.ToUpper() == ara.ToUpper()) // oluşturlan kelime ile aranan kelime eşit mi kontrol edişlir
                {
                    Console.WriteLine("Kelime {0} indis:{1}", ara, i.ToString()); // indeoxf ile de yapılabişlir.Raporda komutlaru var
                    sonuc = true;
                }

                kelime = "";
            }
            if (sonuc == false) Console.WriteLine("Aranan kelime bulunamadı"); // aranana yoksa bulunamadı yazar

        }

        public void subAra()   //substring ile arama yapmak için oluşturulan fonksiyon
        {
            bool sonuc=false;
            Console.Write("Aranılacak kelime:");
            string ara = Console.ReadLine();
            Console.Write("Karakter Dizini:");
            string cumle = Console.ReadLine();
            for (int i = 0; i <=cumle.Length - (ara.Length); i++)
            {
                string bulunan = cumle.Substring(i, ara.Length);  //aranan kelime boyutunda teker teker arama yapar
                if (bulunan.ToUpper() == ara.ToUpper())  //aralnılan kelime ile bulunan eşit ise ekrana indis yazar
                {
                    Console.WriteLine("Kelime {0} indis:{1}", ara, i.ToString());
                    sonuc = true;
                }
               
            }
            if (sonuc == false) Console.WriteLine("Aranan kelime bulunamadı"); // tüm cümlede arama sonucunda bulunana yoksa ekrana bulunamadı yazar
        }


        public  void yildizBas(int miktar)
        {
            
            for (int i = 0; i < miktar; i++)
                Console.Write("* ");
        }
        public void karakterGuster()
        {
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ";
            Console.WriteLine("Karakter Dizini:(Bitirmek için enter'a 2 kere tıklanır)");
            string cumle="", okunan="";
            do
              {

                    okunan= Console.ReadLine();//satır satır okuma yapmak için*****
                    cumle = okunan + cumle; //satır satır almak için******
              } while (okunan != "");  //boş bir satır görene kadar dizine ekleme işlemi yapar
            Console.WriteLine("Karakter Sayısı     Grafik Gösterimi");
            Console.WriteLine("------------------------------------------------");
            for (int a = 0; a < harfler.Length; a++)
            {
                char ch = harfler[a];
                int sayi = 0;
                for (int i = 0; i < cumle.Length; i++)
                {
                    if (char.ToUpper(cumle[i]) == ch)
                    {
                        sayi++; //bulunan karakter sayısnı birer birer arttırır
                    }
                }
                Console.Write("  {0} ,  sayısı:{1}  ", ch.ToString(), sayi.ToString());
                yildizBas(sayi);  //her harakter için fonksiyon çağrılır
                Console.WriteLine();

            }

        }
    }
}
