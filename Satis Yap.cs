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
    public partial class Satis_Yap : Form
    {
        public Satis_Yap()
        {
            InitializeComponent();
        }
        public string id { get; set; }
        public string ad_soyad { get; set; }
        public string telefon { get; set; }
        private void Satis_Yap_Load(object sender, EventArgs e)
        {
            kisi_ad_soyad.Text = ad_soyad;
            kisi_telefon.Text = telefon;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ad_soyad);
            veri_yolla();
        }

        void veri_yolla()
        {
            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "ekle";
            veri["ad_soyad"] = ad_soyad.Trim().Replace(" ", string.Empty).ToLower();
            veri["telefon"] = telefon;
            veri["alan"] = alan.Text;
            veri["alinan"] = alinan.Text;
            veri["alinan_sayi"] = alinan_sayi.Value.ToString();
            veri["tutar"] = tutar.Value.ToString();
            veri["tarih"] = tarih.Text;
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            webClient.Dispose();
            MessageBox.Show(islem);
        }

        void toplam_borc_hesaplama()
        {
            int toplam_borc = 0;

            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "borc";
            veri["ad_soyad"] = ad_soyad.Trim().Replace(" ", string.Empty).ToLower();
            veri["telefon"] = telefon;
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            string[] sonuc = islem.Split(";");
            int[] tutar = new int[sonuc.Length];

            for (int i = 0; i < sonuc.Length-1; i++)
            {
                string strData = sonuc[i];
                tutar[i] = Convert.ToInt32(strData);
            }

            webClient.Dispose();

            for (int i = 0; i < sonuc.Length; i++)
            {
                toplam_borc += tutar[i];
            }

            toplam_borc_yolla(toplam_borc);
        }

        void toplam_borc_yolla(int tBorc)
        {
            string URL = "http://localhost/deneme/veresiye.php";
            WebClient webClient = new WebClient();
            NameValueCollection veri = new NameValueCollection();
            veri["komut"] = "borc_yolla";
            veri["id"] = id;
            veri["toplam_borc"] = tBorc.ToString();
            byte[] gonder = webClient.UploadValues(URL, veri);
            string islem = Encoding.UTF8.GetString(gonder);
            webClient.Dispose();
        }

        private void Satis_Yap_FormClosed(object sender, FormClosedEventArgs e)
        {
            toplam_borc_hesaplama();
            Kayıt_Listele kayıt_Listele = new Kayıt_Listele();
            kayıt_Listele.Show();
        }
    }
}
