
namespace Veresiye_Otomasyon
{
    partial class Satis_Yap
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
            this.alan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alinan = new System.Windows.Forms.ComboBox();
            this.alinan_sayi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.kisi_ad_soyad = new System.Windows.Forms.Label();
            this.kisi_telefon = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.tutar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alinan_sayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutar)).BeginInit();
            this.SuspendLayout();
            // 
            // alan
            // 
            this.alan.BackColor = System.Drawing.Color.White;
            this.alan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alan.Location = new System.Drawing.Point(315, 104);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(320, 34);
            this.alan.TabIndex = 1;
            this.alan.Text = "Kendisi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alan:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alınan:";
            // 
            // alinan
            // 
            this.alinan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alinan.FormattingEnabled = true;
            this.alinan.Items.AddRange(new object[] {
            "Buğday",
            "Arpa",
            "Yem"});
            this.alinan.Location = new System.Drawing.Point(315, 162);
            this.alinan.Name = "alinan";
            this.alinan.Size = new System.Drawing.Size(320, 33);
            this.alinan.TabIndex = 2;
            // 
            // alinan_sayi
            // 
            this.alinan_sayi.BackColor = System.Drawing.Color.White;
            this.alinan_sayi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alinan_sayi.Location = new System.Drawing.Point(315, 219);
            this.alinan_sayi.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.alinan_sayi.Name = "alinan_sayi";
            this.alinan_sayi.Size = new System.Drawing.Size(320, 34);
            this.alinan_sayi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(86, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alınan Sayısı:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(86, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tarih:";
            // 
            // tarih
            // 
            this.tarih.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarih.Location = new System.Drawing.Point(315, 335);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(320, 34);
            this.tarih.TabIndex = 4;
            // 
            // kisi_ad_soyad
            // 
            this.kisi_ad_soyad.AutoSize = true;
            this.kisi_ad_soyad.Location = new System.Drawing.Point(370, 36);
            this.kisi_ad_soyad.Name = "kisi_ad_soyad";
            this.kisi_ad_soyad.Size = new System.Drawing.Size(98, 20);
            this.kisi_ad_soyad.TabIndex = 14;
            this.kisi_ad_soyad.Text = "kisi_ad_soyad";
            // 
            // kisi_telefon
            // 
            this.kisi_telefon.AutoSize = true;
            this.kisi_telefon.Location = new System.Drawing.Point(552, 36);
            this.kisi_telefon.Name = "kisi_telefon";
            this.kisi_telefon.Size = new System.Drawing.Size(83, 20);
            this.kisi_telefon.TabIndex = 15;
            this.kisi_telefon.Text = "kisi_telefon";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.Location = new System.Drawing.Point(510, 393);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.btnEkle.Size = new System.Drawing.Size(125, 40);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.ImageIndex = 1;
            this.btnIptal.Location = new System.Drawing.Point(370, 393);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Padding = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.btnIptal.Size = new System.Drawing.Size(125, 40);
            this.btnIptal.TabIndex = 18;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // tutar
            // 
            this.tutar.BackColor = System.Drawing.Color.White;
            this.tutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tutar.Location = new System.Drawing.Point(315, 277);
            this.tutar.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(320, 34);
            this.tutar.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tutar (TL):";
            // 
            // Satis_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 481);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.kisi_telefon);
            this.Controls.Add(this.kisi_ad_soyad);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alinan_sayi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alinan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Satis_Yap";
            this.ShowIcon = false;
            this.Text = "Satis_Yap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Satis_Yap_FormClosed);
            this.Load += new System.EventHandler(this.Satis_Yap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alinan_sayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox alinan;
        private System.Windows.Forms.NumericUpDown alinan_sayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label kisi_ad_soyad;
        private System.Windows.Forms.Label kisi_telefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.NumericUpDown tutar;
        private System.Windows.Forms.Label label4;
    }
}