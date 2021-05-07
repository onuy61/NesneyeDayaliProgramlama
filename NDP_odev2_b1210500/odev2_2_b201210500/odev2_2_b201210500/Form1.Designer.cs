
namespace odev2_2_b201210500
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.aRixcTxt = new System.Windows.Forms.RichTextBox();
            this.bRichTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sncRichTxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btn_Ters = new System.Windows.Forms.Button();
            this.btnTranspos = new System.Windows.Forms.Button();
            this.btnMatrisIzi = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // aRixcTxt
            // 
            this.aRixcTxt.Location = new System.Drawing.Point(41, 49);
            this.aRixcTxt.Name = "aRixcTxt";
            this.aRixcTxt.Size = new System.Drawing.Size(160, 155);
            this.aRixcTxt.TabIndex = 0;
            this.aRixcTxt.Text = "";
            // 
            // bRichTxt
            // 
            this.bRichTxt.Location = new System.Drawing.Point(244, 49);
            this.bRichTxt.Name = "bRichTxt";
            this.bRichTxt.Size = new System.Drawing.Size(160, 155);
            this.bRichTxt.TabIndex = 1;
            this.bRichTxt.Text = "";
            this.bRichTxt.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MATRİS A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "MATRİS B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "SONUC MATRİSİ";
            // 
            // sncRichTxt
            // 
            this.sncRichTxt.Location = new System.Drawing.Point(469, 49);
            this.sncRichTxt.Name = "sncRichTxt";
            this.sncRichTxt.Size = new System.Drawing.Size(300, 155);
            this.sncRichTxt.TabIndex = 4;
            this.sncRichTxt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(212, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "+";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(429, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "A Matirisi Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "B Matirisi Üret";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(41, 270);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(133, 28);
            this.btnTopla.TabIndex = 10;
            this.btnTopla.Text = "Matris Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(41, 304);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(133, 28);
            this.btnCarpma.TabIndex = 11;
            this.btnCarpma.Text = "Matris Çarp";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Ters
            // 
            this.btn_Ters.Location = new System.Drawing.Point(41, 338);
            this.btn_Ters.Name = "btn_Ters";
            this.btn_Ters.Size = new System.Drawing.Size(133, 28);
            this.btn_Ters.TabIndex = 12;
            this.btn_Ters.Text = "Matris A Tersi";
            this.btn_Ters.UseVisualStyleBackColor = true;
            this.btn_Ters.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnTranspos
            // 
            this.btnTranspos.Location = new System.Drawing.Point(41, 372);
            this.btnTranspos.Name = "btnTranspos";
            this.btnTranspos.Size = new System.Drawing.Size(133, 28);
            this.btnTranspos.TabIndex = 13;
            this.btnTranspos.Text = "Matris A Transpos";
            this.btnTranspos.UseVisualStyleBackColor = true;
            this.btnTranspos.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMatrisIzi
            // 
            this.btnMatrisIzi.Location = new System.Drawing.Point(41, 406);
            this.btnMatrisIzi.Name = "btnMatrisIzi";
            this.btnMatrisIzi.Size = new System.Drawing.Size(133, 28);
            this.btnMatrisIzi.TabIndex = 14;
            this.btnMatrisIzi.Text = "Matris A İzi";
            this.btnMatrisIzi.UseVisualStyleBackColor = true;
            this.btnMatrisIzi.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(244, 270);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 28);
            this.button8.TabIndex = 15;
            this.button8.Text = "Belgeye Yazdır";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(244, 304);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 28);
            this.button9.TabIndex = 16;
            this.button9.Text = "Belgeden Oku";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kaçıncı İşlem Gelsin";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(519, 359);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 127);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = ".";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kayıtlı İslemler";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(247, 366);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(126, 127);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 499);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnMatrisIzi);
            this.Controls.Add(this.btnTranspos);
            this.Controls.Add(this.btn_Ters);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sncRichTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRichTxt);
            this.Controls.Add(this.aRixcTxt);
            this.Name = "Form1";
            this.Text = "Matris İslemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox aRixcTxt;
        private System.Windows.Forms.RichTextBox bRichTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox sncRichTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btn_Ters;
        private System.Windows.Forms.Button btnTranspos;
        private System.Windows.Forms.Button btnMatrisIzi;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

