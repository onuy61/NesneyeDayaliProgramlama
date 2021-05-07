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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2_2_b201210500
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string islem;
        public static int[,] matrisA = new int[4, 4];
        public static int[,] matrisB = new int[4, 4];
        public static float[,] matrisC = new float[4, 4];
      /*
        static void matrisToplama()
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

        }
      */
      /*
        static void matrisTanspoz()
        {
            for (int j = 0; j <4; j++)
            {
                for (int i = 0; i <4; i++)
                {
                    matrisC[j,i]=matrisA[i,j];
                }
  
            }

        }
      */
        /*
        static void matrisCarpma()
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


        }
        */
        /*
        public  static int matrisIzi()
        {
            int kosegen = 0;
            for (int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++)
                {
                    if(i==j) kosegen = kosegen + matrisA[i, j];
                }
            }

            return kosegen;

        }
        */
        /*
        public string islemOku()
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
        */
        /*
        static string[] dosyaOku(int islem)
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
        */
        static void dosyaYazdir()
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            richTextBox2.Text = Matris_S.islemOku();
        }
        /*
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
                    sayi = rnd.Next(1,10);
                    matris[i, k] = sayi;
                    m = m + string.Format("{0,5}", sayi.ToString());

                }
 
            }
           
            return matris;
        }
        */
        private void button1_Click_1(object sender, EventArgs e)
        {
            matrisA= Matris_S.matrisUret();
            string m = "";
            //int[,] matrisA = new int[4, 4];
            int sayi;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {

                    m = m + string.Format("{0,5}", matrisA[i, k].ToString());

                }
                m = m + "\n";
            }
            aRixcTxt.Text = m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matrisB = Matris_S.matrisUret();
            string m = "";
            //int[,] matrisA = new int[4, 4];
            int sayi;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {

                    m = m + string.Format("{0,5}", matrisB[i, k].ToString());

                }
                m = m + "\n";
            }
            bRichTxt.Text = m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "+";
            string m = "";
            matrisC= Matris_S.matrisToplama(matrisA,matrisB);
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    m = m + string.Format(" {0,-5}", matrisC[i, k].ToString());
                }
                m = m + "\n";
            }
            sncRichTxt.Text = m;
            islem = "Toplama";
            MessageBox.Show("Kaydetme İşlemleri için -Belgeye Yazdır - butonunu kullanınız");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "X";
            string m = "";
            matrisC = Matris_S.matrisCarpma(matrisA, matrisB);
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    m = m + string.Format(" {0,-5}", matrisC[i, k].ToString());
                }
                m = m + "\n";
            }
            sncRichTxt.Text = m;
            islem = "carpma";
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string m = "";
            string x = "";
            string y = "";
            FileStream fs = new FileStream("deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            if (islem == "MatrisIzi") m = sncRichTxt.Text;
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (islem == "MatrisTersi")
                        {
                            x = x + string.Format("{0:0.0}", matrisA[i, k]) + " ";
                            y = y + string.Format("{0:0.0}", matrisB[i, k]) + " ";
                            m = m + string.Format("{0:0.0}", matrisC[i, k]) + " ";
                        }
                        else
                        {
                            x = x + string.Format("{0}", matrisA[i, k]) + " ";
                            y = y + string.Format("{0}", matrisB[i, k]) + " ";
                            m = m + string.Format("{0}", matrisC[i, k]) + " ";
                        }

                    }
                }
            }
            //islem = "toplam";
            m = islem + "|" +x+ "|" +y+"|"+m;
            MessageBox.Show(islem+" islemi kaydedildi");
            sw.WriteLine(m);
            sw.Close();
            richTextBox2.Text = Matris_S.islemOku();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
            string m = "";
            string textFile = "deneme.txt";
            using (StreamReader file = new StreamReader(textFile))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    m = m + ln;
                    m = m + "\n";
                    counter++;
                }
                file.Close();
               
            }
            sncRichTxt.Text = m;
            */
            string m = "";
            if (textBox1.Text == "") MessageBox.Show("Cağrılmasını istediğiniz islemin numrasını giriniz!");
            else
            {
                string[] dizi = Matris_S.dosyaOku(int.Parse(textBox1.Text));
                label7.Text = dizi[0] + " İsleminin Sonucu";
                if (dizi[0] == "MatrisIzi") richTextBox1.Text = dizi[1].ToString();
                else
                {
                    int o = 1;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int k = 0; k < 4; k++)
                        {

                            m = m + string.Format(" {0,-5}", dizi[o].ToString());
                            o++;
                        }
                        m = m + "\n";
                    }
                    richTextBox1.Text = m;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            bRichTxt.Text = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        matrisC[i, j] = 1;
                    else
                        matrisC[i, j] = 0;
                }
            }

           int d, k;
            for (int i = 0; i < 4; i++)
            {
                d = matrisA[i, i];
                for (int j = 0; j < 4; j++)
                {
                    matrisA[i, j] = matrisA[i, j] / d;
                    matrisC[i, j] = matrisC[i, j] / d;
                }
                for (int x = 0; x < 4; x++)
                {
                    if (x != i)
                    {
                        k = matrisA[x, i];
                        for (int j = 0; j < 4; j++)
                        {
                            matrisA[x, j] = matrisA[x, j] - (matrisA[i, j] * k);
                            matrisC[x, j] = matrisC[x, j] - (matrisC[i, j] * k);
                        }
                    }

                }
            }
            string m = "";
            for (int i = 0; i < 4; i++)
            {
                for (int t = 0; t < 4; t++)
                {

                    m = m + string.Format("{0:0.0  }", matrisC[i, t]);

                }
                m = m + "\n";
            }
            sncRichTxt.Text = m;
            islem = "MatrisTersi";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            bRichTxt.Text = "";
            matrisC=Matris_S.matrisTanspoz(matrisA);
            string m = "";
            for (int i = 0; i < 4; i++)
            {
                for (int t = 0; t < 4; t++)
                {

                    m = m + string.Format(" {0,-5}", matrisC[i, t].ToString());

                }
                m = m + "\n";
            }
            sncRichTxt.Text = m;
            islem = "MatrisTranspoz";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int m_izi =Matris_S.matrisIzi(matrisA);
            sncRichTxt.Text = m_izi.ToString();
            islem = "MatrisIzi";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

