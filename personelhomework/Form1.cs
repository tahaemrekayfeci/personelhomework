using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace personelhomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosya_yolu = @"C:\isyeri.txt";
        int satma, kira, toplam,tazminat, dgyeri,a=1;
        string ad, soyad, tckimlik,isyeri,dgzamani;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            tazminat = 2021- dgyeri ;
            if (tazminat > 5)
            {
                toplam = toplam + 7000;
                lbl_yillikyazminat.Text = toplam.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1990; i < 2022; i++)
            {
                cbx_dgt.Items.Add(i);
                cbx_dy.Items.Add(i);
                comboBox5.Items.Add(i);
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            StreamReader sf = new StreamReader(fs);
            if (a==1)
            {
                listBox1.Text = sf.ReadLine();
                a--;
            }
            
            ad = txt_ad.Text;
            soyad = txt_soyad.Text;
            tckimlik = txt_tc.Text;
            dgyeri = int.Parse(cbx_dgt.Text);
            isyeri = cbx_b.Text;
            dgzamani = cbx_dy.Text;
            sw.WriteLine(ad + " " + soyad + " " + isyeri + " " + dgyeri + " " + dgzamani);
            sw.Close();
            listBox1.Items.Add(ad + " "+soyad + " " + isyeri + " " + dgyeri + " " + dgzamani);
        }

        private void btn_maashesap_Click(object sender, EventArgs e)
        {
            
            satma = int.Parse(txt_satma.Text);
            kira = int.Parse(txt_kira.Text);
            satma = satma * 500;
            kira = kira * 250;
            toplam = satma + kira;
            lbl_maashesaplsa.Text = toplam.ToString();
        }
    }
}
