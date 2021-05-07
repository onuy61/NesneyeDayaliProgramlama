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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_2_b201210500
{
    public static class Matris_S 
    {
        public static string islem;
        public static int[,] matrisA = new int[4, 4];
        public static int[,] matrisB = new int[4, 4];
        public static float[,] matrisC = new float[4, 4];
        public static float[,] matrisToplama(int [,]matrisA , int[,]matrisB)
        {
            int satir = 4;
            int sutun = 4;
            // int[,] matrisC = new int[satir, sutun];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrisC[i, j] = matrisA[i, j] + matrisB[i, j];
                }
            }
            return matrisC;
        }

        public static float [,] matrisTanspoz(int [,] matrisA)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    matrisC[j, i] = matrisA[i, j];
                }

            }
            return matrisC;
        }
        public static float[,] matrisCarpma(int[,] matrisA, int[,] matrisB)
        {
            int satir = 4;
            int sutun = 4;
            // int[,] matrisC = new int[satir, sutun];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        matrisC[i, j] += matrisA[i, k] * matrisB[k, j];
                    }
                }
            }

            return matrisC;
        }

        public static int matrisIzi(int [,] matrisA)
        {
            int kosegen = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) kosegen = kosegen + matrisA[i, j];
                }
            }

            return kosegen;

        }
        public static string islemOku()
        {

            string m = "";
            string textFile = "deneme.txt";
            using (StreamReader file = new StreamReader(textFile))
            {

                string ln;


                while ((ln = file.ReadLine()) != null)
                {
                    string[] dizi = ln.Split(' ');
                    m = m + dizi[0] + "\n";

                }
                file.Close();

            }
            return m;
        }
        public static int[,] matrisUret()
        {
            Random rnd = new Random();
            string m = "";
            int[,] matris = new int[4, 4];
            int sayi;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    sayi = rnd.Next(1, 10);
                    matris[i, k] = sayi;
                    m = m + string.Format("{0,5}", sayi.ToString());

                }

            }

            return matris;
        }
        public static string[] dosyaOku(int islem)
        {
            string[] dizi = new string[17];
            string m = "";
            string textFile = "deneme.txt";
            using (StreamReader file = new StreamReader(textFile))
            {
                int counter = 1;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    dizi = ln.Split(' ');
                    if (islem == counter) break;
                    counter++;
                }

                file.Close();

            }

            return dizi;

        }
    }
}
