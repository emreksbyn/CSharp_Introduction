using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size size = new Size(500, 610);
            this.ClientSize = size;
            this.BackColor = Color.GreenYellow;

            // Rastgele Butonu için
            Button btnRastgele = new Button();
            btnRastgele.Text = "Rastgele";
            btnRastgele.Width = 150;
            btnRastgele.Height = 50;
            btnRastgele.Top = 100;
            btnRastgele.Left = 348;
            btnRastgele.BackColor = Color.White;
            btnRastgele.ForeColor = Color.Blue;
            btnRastgele.Click += new EventHandler(BtnRastgele_Click);
            this.Controls.Add(btnRastgele);
            panel1.Top = 160;
            panel1.Left = 0;

            //Sayılar için
            for (int i = 0; i < 9; i++)
            {
                for (int p = 0; p < 10; p++)
                {
                    Button btnSayilar = new Button();
                    btnSayilar.Width = 50;
                    btnSayilar.Height = 50;
                    btnSayilar.Top = i * 50;
                    btnSayilar.Left = p * 50;
                    btnSayilar.BackColor = Color.White;
                    btnSayilar.ForeColor = Color.Red;
                    if (p == 9)
                    {
                        btnSayilar.Name = (i + 1).ToString() + "0";
                        btnSayilar.Text = (i + 1).ToString() + "0";
                    }
                    else
                    {
                        btnSayilar.Name = i + (p + 1).ToString();
                        btnSayilar.Text = i + (p + 1).ToString();
                    }
                    btnSayilar.Click += new EventHandler(BtnSayilar_Click);
                    btnSayilar.MouseEnter += new EventHandler(BtnSayilar_MouseEnter);
                    btnSayilar.MouseLeave += new EventHandler(BtnSayilar_MouseLeave);
                    panel1.Controls.Add(btnSayilar);
                }
            }
        }
        void BtnRastgele_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[7];
            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                int RastgeleSayi = rnd.Next(1, 91);
                if (sayilar.Contains(RastgeleSayi))
                {
                    continue;
                }
                sayilar[i] = RastgeleSayi;
                txtTahmin1.Text = sayilar[0].ToString();
                txtTahmin2.Text = sayilar[1].ToString();
                txtTahmin3.Text = sayilar[2].ToString();
                txtTahmin4.Text = sayilar[3].ToString();
                txtTahmin5.Text = sayilar[4].ToString();
                txtTahmin6.Text = sayilar[5].ToString();
                txtTahmin7.Text = sayilar[6].ToString();
            }
            foreach (Control item in panel1.Controls)
            {
                if ((item as Button) != null)
                {
                    Control btn = item as Button;
                    string btnText = btn.Text.StartsWith("0") ? btn.Text.Substring(1) : btn.Text;

                    if (btnText == txtTahmin1.Text)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else if (btnText == txtTahmin2.Text)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else if (btnText == txtTahmin3.Text)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else if (btnText == txtTahmin4.Text)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else if (btnText == txtTahmin5.Text)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else if (btnText == txtTahmin6.Text)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else if (btnText == txtTahmin7.Text)
                    {
                        btn.BackColor = Color.Yellow;
                        btn.ForeColor = Color.Black;
                    }
                    else
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Red;
                    }
                }
            }

            txtTahmin1.BackColor = Color.Red;
            txtTahmin1.ForeColor = Color.White;
            txtTahmin2.BackColor = Color.Red;
            txtTahmin2.ForeColor = Color.White;
            txtTahmin3.BackColor = Color.Red;
            txtTahmin3.ForeColor = Color.White;
            txtTahmin4.BackColor = Color.Red;
            txtTahmin4.ForeColor = Color.White;
            txtTahmin5.BackColor = Color.Red;
            txtTahmin5.ForeColor = Color.White;
            txtTahmin6.BackColor = Color.Red;
            txtTahmin6.ForeColor = Color.White;
            txtTahmin7.BackColor = Color.Yellow;
            txtTahmin7.ForeColor = Color.Black;
        }
        void BtnSayilar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Red;
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = item as TextBox;

                        if (txt.Text == btn.Text)
                        {
                            txt.ResetText();
                            txt.Focus();
                            txt.BackColor = Color.White;
                            txt.ForeColor = Color.Red;

                        }
                        else if (txt.Text == "" && txt == txtTahmin7)
                        {
                            txt.Text = btn.Text;
                            txt.BackColor = Color.Yellow;
                            txt.ForeColor = Color.Black;
                        }
                        else if (txt.Text == "")
                        {
                            txt.Text = btn.Text;
                            txt.BackColor = Color.Red;
                            txt.ForeColor = Color.White;
                            break;
                        }
                    }
                }
            }
            else if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Red;
            }
        }
        void BtnSayilar_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.Red)
            {
                (sender as Button).BackColor = Color.White;
                (sender as Button).ForeColor = Color.Red;
            }
            else if ((sender as Button).BackColor == Color.Yellow)
            {
                (sender as Button).BackColor = Color.LightYellow;
                (sender as Button).ForeColor = Color.Red;
            }
            else
            {
                (sender as Button).BackColor = Color.Red;
                (sender as Button).ForeColor = Color.White;
            }
        }
        void BtnSayilar_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.Red)
            {
                (sender as Button).BackColor = Color.White;
                (sender as Button).ForeColor = Color.Red;
            }
            else if ((sender as Button).BackColor == Color.LightYellow)
            {
                (sender as Button).BackColor = Color.Yellow;
                (sender as Button).ForeColor = Color.Black;
            }
            else
            {
                (sender as Button).BackColor = Color.Red;
                (sender as Button).ForeColor = Color.White;
            }
        }
        private void tahminButonTemizle(TextBox txtTahmin)
        {
            foreach (Control item in panel1.Controls)
            {
                if (txtTahmin.Text == ((Button)item).Text)
                {
                    ((Button)item).BackColor = Color.White;
                    ((Button)item).ForeColor = Color.Red;
                }
            }
            txtTahmin.Clear();
            if (txtTahmin != txtTahmin7)
                txtTahmin.BackColor = Color.White;
            else
                txtTahmin.BackColor = Color.Yellow;
        }

        private void txtTahmin1_Click(object sender, EventArgs e)
        {
            tahminButonTemizle(txtTahmin1);
        }

        private void txtTahmin2_Click(object sender, EventArgs e)
        {
            tahminButonTemizle(txtTahmin2);
        }

        private void txtTahmin3_Click(object sender, EventArgs e)
        {
            tahminButonTemizle(txtTahmin3);
        }

        private void txtTahmin4_Click(object sender, EventArgs e)
        {
            tahminButonTemizle(txtTahmin4);
        }

        private void txtTahmin5_Click(object sender, EventArgs e)
        {
            tahminButonTemizle(txtTahmin5);
        }

        private void txtTahmin6_Click(object sender, EventArgs e)
        {
            tahminButonTemizle(txtTahmin6);
        }

        private void txtTahmin7_Click(object sender, EventArgs e)
        {
            tahminButonTemizle(txtTahmin7);
        }
    }
}
