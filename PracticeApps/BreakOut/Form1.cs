using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    public partial class Form1 : Form
    {
        bool OyuncuSagaGit;
        bool OyuncuSolaGit;
        int hiz = 10;

        int TopYatayHareket = 5;
        int TopDikeyHareket = 5;

        int skor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BreakOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && btnOyuncu.Left > 0)
            {
                OyuncuSolaGit = true;

            }
            if (e.KeyCode == Keys.Right && btnOyuncu.Left + btnOyuncu.Width < 920)
            {
                OyuncuSagaGit = true;

            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void BreakOut_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                OyuncuSolaGit = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                OyuncuSagaGit = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBall.Left += TopYatayHareket;
            pictureBall.Top += TopDikeyHareket;

            lblSkor.Text = "Puan : " + skor;

            if (OyuncuSolaGit)
            {
                btnOyuncu.Left -= hiz;
            }
            if (OyuncuSagaGit)
            {
                btnOyuncu.Left += hiz;
            }

            if (btnOyuncu.Left < 1)
            {
                OyuncuSolaGit = false;
            }
            else if (btnOyuncu.Left + btnOyuncu.Width > 920)
            {
                OyuncuSagaGit = false;
            }
            if (pictureBall.Left + pictureBall.Width > ClientSize.Width || pictureBall.Left < 0)
            {
                TopYatayHareket = -TopYatayHareket;
            }
            if (pictureBall.Top < 0 || pictureBall.Bounds.IntersectsWith(btnOyuncu.Bounds))
            {
                TopDikeyHareket = -TopDikeyHareket;
            }
            if (pictureBall.Top + pictureBall.Height > ClientSize.Height)
            {
                OyunuBitir();
            }
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && item.BackColor == Color.Yellow)
                {
                    if (pictureBall.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                        TopDikeyHareket = -TopDikeyHareket;
                        skor++;
                    }
                }
                if (item is PictureBox && item.BackColor == Color.Orange)
                {
                    if (pictureBall.Bounds.IntersectsWith(item.Bounds))
                    {
                        item.BackColor = Color.Yellow;
                        TopDikeyHareket = -TopDikeyHareket;
                        skor += 2;
                    }
                }
                if (item is PictureBox && item.BackColor == Color.Red)
                {
                    if (pictureBall.Bounds.IntersectsWith(item.Bounds))
                    {
                        item.BackColor = Color.Orange;
                        TopDikeyHareket = -TopDikeyHareket;
                        skor += 3;
                    }
                }
                if (item is PictureBox && item.BackColor == Color.DarkRed)
                {
                    if (pictureBall.Bounds.IntersectsWith(item.Bounds))
                    {
                        item.BackColor = Color.Red;
                        TopDikeyHareket = -TopDikeyHareket;
                        skor += 4;
                    }
                }


            }
            if (skor == 50)
            {
                OyunuBitir();
            }

        }
        private void OyunuBitir()
        {
            timer1.Stop();
        }


       
    }
}
