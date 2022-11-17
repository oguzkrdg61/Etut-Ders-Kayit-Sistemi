namespace EtutStajProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtutOlstr = new System.Windows.Forms.Button();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbOgrtmen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtogrenciid = new System.Windows.Forms.TextBox();
            this.txtetutid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSınıf = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFotograf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtutOlstr);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.cmbOgrtmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEtutOlstr
            // 
            this.btnEtutOlstr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEtutOlstr.Location = new System.Drawing.Point(120, 234);
            this.btnEtutOlstr.Name = "btnEtutOlstr";
            this.btnEtutOlstr.Size = new System.Drawing.Size(211, 40);
            this.btnEtutOlstr.TabIndex = 9;
            this.btnEtutOlstr.Text = "Etüt Oluştur";
            this.btnEtutOlstr.UseVisualStyleBackColor = false;
            this.btnEtutOlstr.Click += new System.EventHandler(this.btnEtutOlstr_Click);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(120, 134);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(211, 30);
            this.mskTarih.TabIndex = 8;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbOgrtmen
            // 
            this.cmbOgrtmen.FormattingEnabled = true;
            this.cmbOgrtmen.Location = new System.Drawing.Point(120, 85);
            this.cmbOgrtmen.Name = "cmbOgrtmen";
            this.cmbOgrtmen.Size = new System.Drawing.Size(211, 32);
            this.cmbOgrtmen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(43, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(51, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(120, 181);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(211, 30);
            this.mskSaat.TabIndex = 2;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(120, 40);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(211, 32);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtogrenciid);
            this.groupBox2.Controls.Add(this.txtetutid);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(399, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtogrenciid
            // 
            this.txtogrenciid.Location = new System.Drawing.Point(153, 85);
            this.txtogrenciid.Name = "txtogrenciid";
            this.txtogrenciid.Size = new System.Drawing.Size(148, 30);
            this.txtogrenciid.TabIndex = 12;
            // 
            // txtetutid
            // 
            this.txtetutid.Enabled = false;
            this.txtetutid.Location = new System.Drawing.Point(153, 40);
            this.txtetutid.Name = "txtetutid";
            this.txtetutid.Size = new System.Drawing.Size(148, 30);
            this.txtetutid.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(153, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Etüt Ver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(42, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Öğrenci:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(45, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Etüt id:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 381);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mskTel);
            this.groupBox4.Controls.Add(this.btnOgrenciEkle);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtMail);
            this.groupBox4.Controls.Add(this.txtSınıf);
            this.groupBox4.Controls.Add(this.txtSoyad);
            this.groupBox4.Controls.Add(this.txtAd);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(748, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 370);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(115, 181);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(177, 30);
            this.mskTel.TabIndex = 12;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(115, 286);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(177, 40);
            this.btnOgrenciEkle.TabIndex = 11;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(40, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(115, 234);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(177, 30);
            this.txtMail.TabIndex = 9;
            // 
            // txtSınıf
            // 
            this.txtSınıf.Location = new System.Drawing.Point(115, 137);
            this.txtSınıf.Name = "txtSınıf";
            this.txtSınıf.Size = new System.Drawing.Size(177, 30);
            this.txtSınıf.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(115, 88);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(177, 30);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(115, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(177, 30);
            this.txtAd.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(56, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(40, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(40, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sınıf:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(28, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Telefon:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFotograf);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(748, 388);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 311);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // btnFotograf
            // 
            this.btnFotograf.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFotograf.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFotograf.Location = new System.Drawing.Point(19, 234);
            this.btnFotograf.Name = "btnFotograf";
            this.btnFotograf.Size = new System.Drawing.Size(322, 56);
            this.btnFotograf.TabIndex = 1;
            this.btnFotograf.Text = "Fotoğraf Ekle";
            this.btnFotograf.UseVisualStyleBackColor = false;
            this.btnFotograf.Click += new System.EventHandler(this.btnFotograf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1138, 717);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ETÜT KAYIT SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEtutOlstr;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbOgrtmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtogrenciid;
        private System.Windows.Forms.TextBox txtetutid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSınıf;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

