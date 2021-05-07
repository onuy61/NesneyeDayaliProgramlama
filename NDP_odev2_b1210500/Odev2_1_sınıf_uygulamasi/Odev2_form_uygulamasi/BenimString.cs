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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_form_uygulamasi
{
    class BenimString
    {
         public  int elemanSayisi(string veri)
        {
            int size = 0;
            foreach (char c in veri)
            {
                //if (c == '\n') { break; }
                size++;
            }
            return size;
        }
        public  string  birlestir(string kelime1, string kelime2)
        {
            string birlesmis;
            birlesmis = kelime1 + kelime2;
            //Console.WriteLine(birlesmis);
            return birlesmis;

        }

        public  string arayaGir(string kelime1, int s, string b)
        {
            string word = "";
            for (int i = 0; i < elemanSayisi(kelime1); i++)
            {
                word = word + kelime1[i];
                if (i == s)
                {
                    word = word + b;
                }
            }
            return word;
        }


        public string degerAl(string kelime1, int s, int m)
        {
            string word = "";
            for (int i = s; i < m + s; i++)
            {
                word = word + kelime1[i];
            }
            return word;
        }


        public  string[]diziyeAyir(string kelime1, char c)
        {
            int kelimesayisi = 0, a = 0;
            for (int k = 0; k <elemanSayisi(kelime1); k++)
                if (kelime1[k] == c)
                    kelimesayisi++;
            string[] word = new string[kelimesayisi+1];
            string kelime = "";
            for (int i = 0; i < elemanSayisi(kelime1); i++)
            {


                if (kelime1[i] != c)
                {
                    kelime = kelime + kelime1[i];

                }
                else
                {
                    word[a] = kelime;
                    kelime = "";
                    a++;
                }

            }
            word[a] = kelime;
            return word;
        }


        public  char[] charDizi(string kelime1)
        {
            char[] word = new char[elemanSayisi(kelime1)];
            for (int i = 0; i < elemanSayisi(kelime1); i++)
            {
                word[i] = kelime1[i];
            }
            return word;
        }

        public  int degerIndis(string kelime1, string aranan)
        {
            int indis = -1;
            for (int i = 0; i <= elemanSayisi(kelime1)- elemanSayisi(aranan); i++)
            {
                string bulunan = degerAl(kelime1, i, elemanSayisi(aranan));
                if (buyukCevir(bulunan)== buyukCevir(aranan))  
                {
                    indis = i;
                    break;
                }

            }

            return indis;
        }

        public  char[] siralaAz(char[] dizi)
        {
            char temp;
            int size = 0;
            foreach (char c in dizi)
            {
                size++;
            }
            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        temp = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
            return dizi;
        }

        public  char[] siralaZa(char[] dizi)
        {
            char temp;
            int size = 0;
            foreach (char c in dizi)
            {
                size++;
            }
            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        temp = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
            return dizi;
        }

        public  string TersCevir(string gelen)
        {
            string tersString = "";
            for (int i = elemanSayisi(gelen) - 1; i >= 0; i--)
            {
                tersString = tersString + gelen[i];
            }

            return tersString;
        }


        public string buyukCevir(string kelime)
        {
            string output = "";
            for (int i = 0; i < elemanSayisi(kelime); i++)
            {
                if (kelime[i] >= 'a' && kelime[i] <= 'z')
                {
                    output += (char)(kelime[i] - 'a' + 'A');
                }
                else
                    output += kelime[i];
            }
            return output;
           
        }
        public  int karsilastirma(string a, string b)
        {
            int sonuc = -1;
            int dongu;
            int flag = 1;
            //int i = 0;
            if (a.Length > b.Length) dongu = b.Length;
            else dongu = a.Length;
            for (int i = 0; i < dongu; i++)
            {
                if (a[i] > b[i])
                {
                    sonuc = 1;
                    flag = 1;
                    break;
                }
                else if (a[i] < b[i])
                {
                    sonuc = -1;
                    flag = 1;
                    break;
                }
                flag = 0;
            }
            if (flag == 0) sonuc = a.Length - b.Length;
            return sonuc;
        }

        public string[] siralama(string k)
        {
            string temp;
            int n, i, j, l;
            string[] arr1 = new string[20];
            arr1 = diziyeAyir(k,' ');
            l = arr1.Length;
            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l - 1; j++)
                {

                    if (karsilastirma(arr1[j], arr1[j + 1]) > 0)
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            return arr1;
        }
    }
}
