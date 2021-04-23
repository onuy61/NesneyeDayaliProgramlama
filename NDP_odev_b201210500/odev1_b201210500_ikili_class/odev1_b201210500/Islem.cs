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

namespace odev1_b201210500
{
    class Islem
    {

        public Islem() {
            
        }

        public bool satirkontrolyap(int[,] dizi, int a)    //yerleseceği satırda kale var mı kontrol eder
        {
            bool sonuc = false;
            for (int i = 0; i < 8; i++)
            {
                if (dizi[a, i] == 1)
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        public bool sutunkontrolyap(int[,] dizi, int b)  //yerleseceği sutunda kale var mı kontrol eder 
        {
            bool sonuc = false;
            for (int i = 0; i < 8; i++)
            {
                if (dizi[i, b] == 1)
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        public void hucreRenklendir(int a, int b)
        {
            if ((a + b) % 2 == 0) Console.BackgroundColor = ConsoleColor.Blue;   //hucreler satranç tahtası şeklinde renklenir
            if ((a + b) % 2 == 1) Console.BackgroundColor = ConsoleColor.Red;
        }

        public void kaleRenklendir(int[,] dizi, int a,int b) {
            if (dizi[a, b] == 1)
            {
                Console.ForegroundColor = ConsoleColor.Black;    // kale olan hucre içeriği siyah rengine dönüşür
                Console.Write(dizi[a, b] + " ");
            }
            // Console.ResetColor();
            if (dizi[a, b] == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(dizi[a, b] + " ");
            }
            Console.ResetColor();
        }
    }
}
