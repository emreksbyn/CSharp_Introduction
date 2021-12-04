using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1;
        double sayi2;
        double sonuc;
        string Islem;
        private void IslemleriYap(object sender)
        {
            Button btnIslemler = (Button)sender;
            try
            {
                sayi1 = Convert.ToDouble(txtIslemler.Text);
                txtIslemler.Clear();
                lblIslemler.Text += btnIslemler.Text;
                Islem = btnIslemler.Text;
            }
            catch
            {
                MessageBox.Show("Lütfen sadece sayısal bir değer giriniz!");
                txtIslemler.Focus();
            }

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btnSayilar = (sender as Button);
            txtIslemler.Text += btnSayilar.Text;
            lblIslemler.Text += btnSayilar.Text;
        }

        private void txtIslemler_TextChanged(object sender, EventArgs e)
        {
            txtIslemler.TextAlign = HorizontalAlignment.Right;
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            IslemleriYap(btnToplama);
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            IslemleriYap(btnCikarma);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            IslemleriYap(btnCarpma);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            IslemleriYap(btnBolme);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                sayi2 = Convert.ToDouble(txtIslemler.Text);

                if (Islem == "+")
                {
                    lblIslemler.Text = Convert.ToString(sayi1) + " + " + Convert.ToString(sayi2);
                    sonuc = sayi1 + sayi2;
                    txtIslemler.Text = Convert.ToString(sonuc);
                    sayi1 = sonuc;
                }
                if (Islem == "-")
                {
                    lblIslemler.Text = Convert.ToString(sayi1) + " - " + Convert.ToString(sayi2);
                    sonuc = sayi1 - sayi2;
                    txtIslemler.Text = Convert.ToString(sonuc);
                    sayi1 = sonuc;
                }
                if (Islem == "x")
                {
                    lblIslemler.Text = Convert.ToString(sayi1) + " x " + Convert.ToString(sayi2);
                    sonuc = sayi1 * sayi2;
                    txtIslemler.Text = Convert.ToString(sonuc);
                    sayi1 = sonuc;
                }
                if (Islem == "÷")
                {
                    if (sayi2 != 0)
                    {
                        lblIslemler.Text = Convert.ToString(sayi1) + " ÷ " + Convert.ToString(sayi2);
                        sonuc = sayi1 / sayi2;
                        txtIslemler.Text = Convert.ToString(sonuc);
                        sayi1 = sonuc;
                    }
                    else
                    {
                        MessageBox.Show("Sıfıra bölünemez");
                        txtIslemler.Focus();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sadece sayısal ifadeler giriniz!");
                txtIslemler.Focus();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtIslemler.Clear();
            lblIslemler.Text = string.Empty;
            txtIslemler.Focus();
        }
       
    }

}
