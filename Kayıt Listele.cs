using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace Veresiye_Otomasyon
{
    public partial class Kayıt_Listele : Form
    {
        public Kayıt_Listele()
        {
            InitializeComponent();
        }

        private void Kayıt_Listele_Load(object sender, EventArgs e)
        {
            veriCek();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text;
            data.Rows.Clear();
            kisi_ara(isim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            veriCek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veriSil();
        }
        void kayitSil(string adSoyad, string telefon)
        {

        }

        public void veriCek()
        {
            int k = 0;

            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "al";
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            string[] sonuc = islem.Split(";");
            webClient.Dispose();

            for (int i = 0; i < sonuc.Length / 5; i++)
            {
                data.Rows.Add();

                for (int j = 0; j < 5; j++)
                {
                    data.Rows[i].Cells[j].Value = sonuc[k];
                    k++;
                }
            }

            kisi_sayisi.Text = $"{(sonuc.Length / 5).ToString()} kişi listeleniyor.";
        }

        void veriSil()
        {
            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "sil";
            veri["id"] = data.CurrentRow.Cells[0].Value.ToString();
            veri["ad_soyad"] = data.CurrentRow.Cells[1].Value.ToString();
            veri["telefon"] = data.CurrentRow.Cells[2].Value.ToString();
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            MessageBox.Show(islem);

            if (islem == "Kayıt silindi.")
            {
                data.Rows.Clear();
                veriCek();
            }
        }

        void kisi_ara(string isim)
        {
            int k = 0;

            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "ara";
            veri["isim"] = isim;
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            string[] sonuc = islem.Split(";");
            webClient.Dispose();

            for (int i = 0; i < sonuc.Length / 5; i++)
            {
                data.Rows.Add();

                for (int j = 0; j < 5; j++)
                {
                    data.Rows[i].Cells[j].Value = sonuc[k];
                    k++;
                }
            }

            kisi_sayisi.Text = $"{(sonuc.Length / 5).ToString()} kişi listeleniyor.";
        }

        void button4_Click(object sender, EventArgs e)
        {
            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "isim_telefon";
            veri["id"] = data.CurrentRow.Cells[0].Value.ToString();
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            string[] sonuc = islem.Split(";");
            webClient.Dispose();
            MessageBox.Show(islem);

            Satis_Yap satis_yap = new Satis_Yap();
            satis_yap.id = sonuc[0];
            satis_yap.ad_soyad = sonuc[1];
            satis_yap.telefon = sonuc[2];

            satis_yap.ShowDialog();

            this.Close();
        }
    }
}
