using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richtxtMetin.Text = "Göktürk imparatorluğunun ünlü hükümdarı Bilge Kağan dönemine ait 6 adet yazılı ve dikili anıtlardır. Bu önemli eserlerden 3 tanesi çok önemlidir. Kül Tigin, Bilge Kağan ve Tonyukuk. Bu eserler Türk dili, edebiyatı, tarihi ve sanatı konusunda birçok bilgiyi bizlere sunmaktadır. Türkçe adı ilk kez bu eserlerde yer almış ve bu anlamda da tarih açısından önemli değerler arasına girmeyi başarmıştır. ";
        }
        private void btnCountAra_Click(object sender, EventArgs e)
        {
            string metin = richtxtMetin.Text.ToLower();
            string degistir = metin.Replace(txtAranacak.Text.ToLower(), "*");
            int kacTane = degistir.Count(x => x == '*');
            MessageBox.Show(string.Format("Metinde {0} tane {1} bulunmaktadır", kacTane, txtAranacak.Text));
        }

        private void btnLenghtAra_Click(object sender, EventArgs e)
        {
            int arananuzunluk = richtxtMetin.Text.Length;
            int kelimeuzunluk = txtAranacak.Text.Length;
            int degistiruzunluk = richtxtMetin.Text.ToLower().Replace(txtAranacak.Text.ToLower(), "").Length;
            int adet = (arananuzunluk - degistiruzunluk) / kelimeuzunluk;
            MessageBox.Show(string.Format("Metinde {0} tane {1} bulunmaktadır", adet, txtAranacak.Text));
        }
    }
}
