/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:ÖDEV2
**				ÖĞRENCİ ADI............:Onur KAHVECİ
**				ÖĞRENCİ NUMARASI.......:B201210500
**              DERSİN ALINDIĞI GRUP...:1B
****************************************************************************/
using System;

namespace Proje_soru2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Islem islem = new Islem();
            int secim;
            do
            {
                islem.menuYazdir(); //islem nesnesinden menu fonksiyonu çağırma
                secim = int.Parse(Console.ReadLine());
                if (secim == 1) islem.subsizAra();
                else if (secim == 2) islem.subAra(); //oluştuurlean nesneden fonksyon çağrımı
                else if (secim == 3) islem.karakterGuster();//karakter gösterme fomksiyonu çağrımı .satır satır bilgi almaktadır
                else if (secim == 0) break; //çıkma işlemi
                else Console.WriteLine("Yanlis Secim yaptınız.Lutfen 1,2 ve 3'ü tuşlayınız");
                // else Console.WriteLine("Yanlis giris");

            } while (true);
            
        }
    }
}
