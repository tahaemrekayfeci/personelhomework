
namespace personelhomework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_satma = new System.Windows.Forms.TextBox();
            this.txt_kira = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_maashesap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_b = new System.Windows.Forms.ComboBox();
            this.cbx_ibt = new System.Windows.Forms.ComboBox();
            this.cbx_dy = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.lbl_maashesaplsa = new System.Windows.Forms.Label();
            this.lbl_yillikyazminat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_dgt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(125, 35);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 20);
            this.txt_tc.TabIndex = 1;
            this.txt_tc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(125, 76);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(125, 118);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doğum Yeri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "İşe Başlama Tarihi :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(52, 310);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(97, 50);
            this.btn_ekle.TabIndex = 14;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 395);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(539, 43);
            this.listBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Satılan Ev Sayısı :";
            // 
            // txt_satma
            // 
            this.txt_satma.Location = new System.Drawing.Point(406, 76);
            this.txt_satma.Name = "txt_satma";
            this.txt_satma.Size = new System.Drawing.Size(100, 20);
            this.txt_satma.TabIndex = 18;
            // 
            // txt_kira
            // 
            this.txt_kira.Location = new System.Drawing.Point(406, 35);
            this.txt_kira.Name = "txt_kira";
            this.txt_kira.Size = new System.Drawing.Size(100, 20);
            this.txt_kira.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kiralanan Ev Sayısı :";
            // 
            // btn_maashesap
            // 
            this.btn_maashesap.Location = new System.Drawing.Point(321, 128);
            this.btn_maashesap.Name = "btn_maashesap";
            this.btn_maashesap.Size = new System.Drawing.Size(138, 29);
            this.btn_maashesap.TabIndex = 20;
            this.btn_maashesap.Text = "Primli Maaşı Hesapla";
            this.btn_maashesap.UseVisualStyleBackColor = true;
            this.btn_maashesap.Click += new System.EventHandler(this.btn_maashesap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Primli Maaşı Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "İşe Başlama Tarihi :";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(406, 177);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Yıl :";
            // 
            // cbx_b
            // 
            this.cbx_b.FormattingEnabled = true;
            this.cbx_b.Items.AddRange(new object[] {
            "Yönetici",
            "Kurucu",
            "Kurucu Yardımcısı",
            "Yönetici Yardımcısı",
            "Üye"});
            this.cbx_b.Location = new System.Drawing.Point(125, 158);
            this.cbx_b.Name = "cbx_b";
            this.cbx_b.Size = new System.Drawing.Size(100, 21);
            this.cbx_b.TabIndex = 26;
            // 
            // cbx_ibt
            // 
            this.cbx_ibt.FormattingEnabled = true;
            this.cbx_ibt.Location = new System.Drawing.Point(125, 194);
            this.cbx_ibt.Name = "cbx_ibt";
            this.cbx_ibt.Size = new System.Drawing.Size(100, 21);
            this.cbx_ibt.TabIndex = 27;
            // 
            // cbx_dy
            // 
            this.cbx_dy.FormattingEnabled = true;
            this.cbx_dy.Items.AddRange(new object[] {
            "Adana",
            "Sivas",
            "İstanbul",
            "Ankara"});
            this.cbx_dy.Location = new System.Drawing.Point(125, 231);
            this.cbx_dy.Name = "cbx_dy";
            this.cbx_dy.Size = new System.Drawing.Size(100, 21);
            this.cbx_dy.TabIndex = 28;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(406, 221);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 30;
            // 
            // lbl_maashesaplsa
            // 
            this.lbl_maashesaplsa.AutoSize = true;
            this.lbl_maashesaplsa.Location = new System.Drawing.Point(483, 125);
            this.lbl_maashesaplsa.Name = "lbl_maashesaplsa";
            this.lbl_maashesaplsa.Size = new System.Drawing.Size(31, 13);
            this.lbl_maashesaplsa.TabIndex = 31;
            this.lbl_maashesaplsa.Text = "........";
            // 
            // lbl_yillikyazminat
            // 
            this.lbl_yillikyazminat.AutoSize = true;
            this.lbl_yillikyazminat.Location = new System.Drawing.Point(475, 270);
            this.lbl_yillikyazminat.Name = "lbl_yillikyazminat";
            this.lbl_yillikyazminat.Size = new System.Drawing.Size(31, 13);
            this.lbl_yillikyazminat.TabIndex = 32;
            this.lbl_yillikyazminat.Text = "........";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Maaş Hesapla";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Yıllık Tazminat Hesapla";
            // 
            // cbx_dgt
            // 
            this.cbx_dgt.FormattingEnabled = true;
            this.cbx_dgt.Location = new System.Drawing.Point(125, 270);
            this.cbx_dgt.Name = "cbx_dgt";
            this.cbx_dgt.Size = new System.Drawing.Size(100, 21);
            this.cbx_dgt.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_dgt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_yillikyazminat);
            this.Controls.Add(this.lbl_maashesaplsa);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.cbx_dy);
            this.Controls.Add(this.cbx_ibt);
            this.Controls.Add(this.cbx_b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_maashesap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_satma);
            this.Controls.Add(this.txt_kira);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_satma;
        private System.Windows.Forms.TextBox txt_kira;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_maashesap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_b;
        private System.Windows.Forms.ComboBox cbx_ibt;
        private System.Windows.Forms.ComboBox cbx_dy;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label lbl_maashesaplsa;
        private System.Windows.Forms.Label lbl_yillikyazminat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_dgt;
    }
}

