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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3_b201210500
{
    
    public partial class Form1 : Form
    {
        

        int sayac = 60;
        public static int gecici,id;
        public static int pure = 0, sivi = 0,toplamAgirlik=0,toplamAVitamin=0,toplamCVitamin=0;
        List<Fruit> meyveler;
        public void meyveOlustur()
        { 
             meyveler = new List<Fruit>();
            meyveler.Add(new Portakal(RastgeleUret.Uret(70, 120), Image.FromFile("portakal.jpg")));
            meyveler.Add(new Mandalina(RastgeleUret.Uret(70, 120), Image.FromFile("mandalina.jpg")));
            meyveler.Add(new Greyfurt(RastgeleUret.Uret(70, 120), Image.FromFile("greyfurt.jpg")));
            meyveler.Add(new Elma(RastgeleUret.Uret(70, 120), Image.FromFile("elma.jpg")));
            meyveler.Add(new Armut(RastgeleUret.Uret(70, 120), Image.FromFile("armut.jpeg")));
            meyveler.Add(new Cilek(RastgeleUret.Uret(70, 120), Image.FromFile("cilek.jpg")));
        }
        public void meyveBilgiGoster()
        {
            label3.Text = meyveler[id].GetType().Name;
            // label3.Text = meyveler[id].GetType().Name;
            groupBox1.Text = meyveler[id].Tur;
            label21.Text = meyveler[id].Agirlik.ToString();
            label7.Text = meyveler[id].Vitamina.ToString();
            label8.Text = meyveler[id].Vitaminc.ToString();
        }

        public void islemgormusMeyveBilgi(int verim)
        {
            
            meyveler[id].agirlikHesapla(verim);
            meyveler[id].vitaminHesapla(verim);
            toplamAgirlik = toplamAgirlik + meyveler[id].Agirlik;
            toplamAVitamin = toplamAVitamin + meyveler[id].Vitamina;
            toplamCVitamin = toplamCVitamin + meyveler[id].Vitaminc;
            label33.Text = toplamAVitamin.ToString();
            label31.Text = toplamCVitamin.ToString();
            label35.Text = toplamAgirlik.ToString();
           // MessageBox.Show(verim.ToString());
        }

        public void temizle() {
            label35.Text = "0";
            label33.Text = "0";
            label31.Text = "0";
            toplamAgirlik = 0;
            toplamAVitamin = 0;
            toplamCVitamin = 0;

        }
        public Form1()
        {
            InitializeComponent();
        }
        //string[] dosyalar = Directory.GetFiles(@"./resim", "*.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            groupBox1.Visible = false;
            grpBoxSivi.Visible = false;

        }
       
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sayac >=0) {
                label1.Text = sayac.ToString();
                progressBar1.Value = sayac;
                sayac = sayac - 1;
       
                btnBaslat.Enabled = false;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                //Random r = new Random();
                //pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];

            }
            else
            {
                btnBaslat.Enabled = true;
                progressBar1.Enabled = false;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                timer1.Stop();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            SiviSikacak s = new SiviSikacak();
            int gecici;
            int verim = RastgeleUret.Uret(30, 70);
           // MessageBox.Show(verim.ToString());
            if (s.sikacak(meyveler[id].Tur))
            {
                islemgormusMeyveBilgi(verim);
                meyveOlustur();
               // id = RastgeleUret.Uret(0, 6); ardara aynı ürün gelmesini istersen 4 satır yerine bunu kullanıuz
                do
                {
                    gecici = RastgeleUret.Uret(0, 6);       //bu komut satırı ile aynı meyve gelmemiş oluyor
                }
                while (gecici == id);                       //tabi bu benim senaryom için geçerli
                id = gecici;
                meyve_pBox.Image = meyveler[id].Image;
                meyveBilgiGoster();

            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int gecici;
            int verim = RastgeleUret.Uret(80, 95);
            KatiSikacak s = new KatiSikacak();
            //MessageBox.Show(verim.ToString());
            // id = RastgeleUret.Uret(0, 5); ardara aynı ürün gelmesini istersen 4 satır yerine bunu kullanıuz
            if (s.sikacak(meyveler[id].Tur))
            {
                islemgormusMeyveBilgi(verim);
                meyveOlustur();

                do
                {
                    gecici = RastgeleUret.Uret(0, 6);
                }
                while (gecici == id);
                id = gecici;
                meyve_pBox.Image = meyveler[id].Image;
                meyveBilgiGoster();

            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
               temizle();
                groupBox1.Visible = true;
                grpBoxSivi.Visible = true;
                meyveOlustur();
                id = RastgeleUret.Uret(0, 6);
                meyve_pBox.Image = meyveler[id].Image;
                sayac = 60;      // saniye 60 getiriliyor
                timer1.Interval = 1000;    //1 sn ayarlanıyor       
                timer1.Start();
                meyveBilgiGoster();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

     

       

       
    }
}
