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

namespace odev1_b201210500
{
    class Program
    {
        static bool satirkontrolyap(int[,] dizi, int a)    //yerleseceği satırda kale var mı kontrol eder
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

        static bool sutunkontrolyap(int[,] dizi, int b)  //yerleseceği sutunda kale var mı kontrol eder 
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
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int x, y;
            bool sonuc = true;
            int[,] matris = new int[8, 8];    //8x8 matris nesnesi oluşturur
           /*
            for (int i = 0; i < 8; i++)     
            {
                for (int k = 0; k < 8; k++) 
                    matris[i, k] = 0;                //8x8'lik matrisin tüm hücrelerine değer ataması yapar.Direk
            }                                        // tanımlama da yapılabilirdi.
           */
            for (int a = 1; a <=8; a++)
            {
                Console.WriteLine("{0}. kale yerlestirildi", a.ToString());
                do
                {
                    x = rastgele.Next(8);         //satır icin rasgele sayı üretir
                    y = rastgele.Next(8);         //sutun için rasgele sayı üretir

                    bool satirKontrol = satirkontrolyap(matris, x);     //satır ve sutun kontrolu yapar
                    bool sutunKontrol = sutunkontrolyap(matris, y);
                    sonuc = satirKontrol || sutunKontrol;

                } while (sonuc);      // satır ve sutunda kale yoksa döngü sonlanır

                /*aşağıdaki yöntem ile de ayrı ayrı kontrol edilebilirdi.Daha stabil çalıştığı görüldü.Her defasında farklı koordinatlar ayrı ayrı kontol edildi
                do
                {
                    x = rastgele.Next(8);         //satır icin rasgele sayı üretir
                    sonuc = satirkontrolyap(matris, x);     //satır kontrolu yapar
                } while (sonuc);      // satır kale yoksa döngü sonlanır
                do
                {
                    y = rastgele.Next(8);         //sutun için rasgele sayı üretir
                    sonuc = sutunkontrolyap(matris, y); //sutun kontrolu yapar
                } while (sonuc);   // sutun kale yoksa döngü sonlanır
                */
                matris[x, y] = 1;     //uygun yere kale yerleştirilir
                Console.WriteLine("Konumu:.....x:{0} , y:{1}\n", y.ToString(), x.ToString());
                Console.WriteLine("  0 1 2 3 4 5 6 7");
                for (int i = 0; i < 8; i++)
                { 
                    Console.Write(i.ToString()+" ");
                    for (int k = 0; k < 8; k++)
                    {
                        if ((i + k) % 2 == 0) Console.BackgroundColor = ConsoleColor.Blue;   //hucreler satranç tahtası şeklinde renklenir
                        if ((i + k) % 2 == 1) Console.BackgroundColor = ConsoleColor.Red;

                        if (matris[i, k] == 1)
                        {
                           Console.ForegroundColor = ConsoleColor.Black;    // kale olan hucre içeriği siyah rengine dönüşür
                            Console.Write(matris[i, k] + " ");
                        }
                        // Console.ResetColor();
                        if (matris[i, k] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(matris[i, k] + " ");
                        }
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                   
                }
                
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
