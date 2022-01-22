
namespace Veresiye_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnListe = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.baslik = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            resources.ApplyResources(this.btnKayit, "btnKayit");
            this.btnKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.ImageList = this.ımageList1;
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kayıt-ekle.png.png");
            this.ımageList1.Images.SetKeyName(1, "kayıt-listele.png.png");
            this.ımageList1.Images.SetKeyName(2, "stok.png.png");
            this.ımageList1.Images.SetKeyName(3, "satis-yap.png");
            // 
            // btnListe
            // 
            resources.ApplyResources(this.btnListe, "btnListe");
            this.btnListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListe.ForeColor = System.Drawing.Color.Black;
            this.btnListe.ImageList = this.ımageList1;
            this.btnListe.Name = "btnListe";
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnStok
            // 
            resources.ApplyResources(this.btnStok, "btnStok");
            this.btnStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStok.ForeColor = System.Drawing.Color.Black;
            this.btnStok.ImageList = this.ımageList1;
            this.btnStok.Name = "btnStok";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // baslik
            // 
            resources.ApplyResources(this.baslik, "baslik");
            this.baslik.BackColor = System.Drawing.Color.Transparent;
            this.baslik.ForeColor = System.Drawing.Color.SlateBlue;
            this.baslik.Name = "baslik";
            // 
            // btnSatis
            // 
            resources.ApplyResources(this.btnSatis, "btnSatis");
            this.btnSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSatis.ForeColor = System.Drawing.Color.Black;
            this.btnSatis.ImageList = this.ımageList1;
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.btnKayit);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Button btnSatis;
    }
}

