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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2_form_uygulamasi
{
    public partial class Form1 : Form
    {
        BenimString nesne1 = new BenimString();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Text=nesne1.elemanSayisi(txt1.Text).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Text = nesne1.birlestir(textBox1.Text, textBox2.Text);
           
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label5.Text= nesne1.arayaGir(textBox4.Text, int.Parse(textBox5.Text), textBox3.Text);
            
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            textBox8.Text = "";
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
           label7.Text= nesne1.degerAl(textBox8.Text, int.Parse(textBox7.Text), int.Parse(textBox6.Text));
        }

        private void textBox10_MouseClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = "";
        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox9.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label10.Visible = true;
            
           string [] gelen= nesne1.diziyeAyir(textBox10.Text, char.Parse(textBox9.Text));
            foreach (var item in gelen)
                label9.Text = label9.Text + item +"\n";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {
            textBox11.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Visible = true;
            char[] dizi = nesne1.charDizi(textBox11.Text);
            foreach (var item in dizi)
                label11.Text = label11.Text + item + "\n";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label21.Visible = true;
            int indis=nesne1.degerIndis(textBox13.Text,textBox12.Text);
            if (indis == -1)
                label20.Text = " Aranan karakter cumlede yok";
            else
                label20.Text = indis.ToString();

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_MouseClick(object sender, MouseEventArgs e)
        {
            textBox13.Text = "";
        }

        private void textBox12_MouseClick(object sender, MouseEventArgs e)
        {
            textBox12.Text = "";
        }

        private void textBox16_MouseClick(object sender, MouseEventArgs e)
        {
            textBox16.Text = "";
            label27.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label28.Text = nesne1.TersCevir(textBox16.Text);
        }

        private void textBox14_MouseClick(object sender, MouseEventArgs e)
        {
            textBox14.Text = "";
        }

        private void textBox15_MouseClick(object sender, MouseEventArgs e)
        {
            textBox15.Text = "";
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label29.Text = "";
            char[] dizi = nesne1.charDizi(textBox14.Text);
            char[] siraliDizi = nesne1.siralaAz(dizi);
            foreach (var item in siraliDizi)
                label29.Text = label29.Text + item +" ";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label30.Text = "";
            char[] dizi = nesne1.charDizi(textBox15.Text);
            char[] siraliDizi = nesne1.siralaZa(dizi);
            foreach (var item in siraliDizi)
                label30.Text = label30.Text + item + " ";
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a = textBox17.Text;
            string k = "";
            string [] b=nesne1.siralama(a);
            foreach (var item in b)
                k = k + item+" ";
            label32.Text = k;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox17_MouseClick(object sender, MouseEventArgs e)
        {
            textBox17.Text = "";
        }
    }
}
