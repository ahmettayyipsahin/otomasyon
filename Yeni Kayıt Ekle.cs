using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Globalization;

namespace Veresiye_Otomasyon
{
    public partial class Yeni_Kayıt_Ekle : Form
    {
        public Yeni_Kayıt_Ekle()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yeni_telefon;
            if (telefon.Text.Substring(0, 1) == "0")
            {
                yeni_telefon = telefon.Text.Substring(1, telefon.Text.Length - 1);
            }
            else
            {
                yeni_telefon = telefon.Text;
            }
            yeni_kayit_ekle(adSoyad.Text, yeni_telefon, Convert.ToInt32(emanetBugday.Text));
            tablo_ekle(adSoyad.Text.Trim().Replace(" ", string.Empty), yeni_telefon);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yeni_Kayıt_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void adSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {

        }

        void yeni_kayit_ekle(string ad_soyad, string telefon, int emanet_bugday)
        {
            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "yolla";
            veri["ad_soyad"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ad_soyad);
            veri["telefon"] = telefon;
            veri["emanet_bugday"] = emanet_bugday.ToString();
            veri["toplam_borc"] = "0";
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            webClient.Dispose();
            MessageBox.Show(islem);
        }

        void tablo_ekle(string ad_soyad, string telefon)
        {
            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "tablo";
            veri["ad_soyad"] = ad_soyad;
            veri["telefon"] = telefon;
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            webClient.Dispose();
            MessageBox.Show(islem);
        }
    }
}
