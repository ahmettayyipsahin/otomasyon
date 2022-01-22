using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veresiye_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yeni_Kayıt_Ekle yeniKayit = new Yeni_Kayıt_Ekle();
            yeniKayit.Show();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            Kayıt_Listele listele = new Kayıt_Listele();
            listele.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            Depo_Stok stok = new Depo_Stok();
            stok.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Satis_Yap satis = new Satis_Yap();
            satis.Show();
        }
    }
}
