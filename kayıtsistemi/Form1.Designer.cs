
namespace kayıtsistemi
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
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadı = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtpuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbsınıf = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvliste
            // 
            this.dgvliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvliste.Location = new System.Drawing.Point(12, 12);
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.RowHeadersWidth = 51;
            this.dgvliste.RowTemplate.Height = 24;
            this.dgvliste.Size = new System.Drawing.Size(851, 206);
            this.dgvliste.TabIndex = 0;
            this.dgvliste.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvliste_CellEnter);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(125, 241);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(556, 22);
            this.txtara.TabIndex = 1;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "isime göre ara";
            // 
            // txtadı
            // 
            this.txtadı.Location = new System.Drawing.Point(125, 269);
            this.txtadı.Name = "txtadı";
            this.txtadı.Size = new System.Drawing.Size(161, 22);
            this.txtadı.TabIndex = 3;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(125, 297);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(161, 22);
            this.txtsoyad.TabIndex = 4;
            // 
            // txtpuan
            // 
            this.txtpuan.Location = new System.Drawing.Point(125, 381);
            this.txtpuan.Name = "txtpuan";
            this.txtpuan.Size = new System.Drawing.Size(161, 22);
            this.txtpuan.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "sınıf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "puan";
            // 
            // dtdogumtarihi
            // 
            this.dtdogumtarihi.Location = new System.Drawing.Point(125, 325);
            this.dtdogumtarihi.Name = "dtdogumtarihi";
            this.dtdogumtarihi.Size = new System.Drawing.Size(200, 22);
            this.dtdogumtarihi.TabIndex = 14;
            // 
            // cmbsınıf
            // 
            this.cmbsınıf.FormattingEnabled = true;
            this.cmbsınıf.Items.AddRange(new object[] {
            "9A",
            "9B",
            "10A",
            "10B",
            "11A",
            "11B",
            "12A",
            "12B"});
            this.cmbsınıf.Location = new System.Drawing.Point(125, 353);
            this.cmbsınıf.Name = "cmbsınıf";
            this.cmbsınıf.Size = new System.Drawing.Size(121, 24);
            this.cmbsınıf.TabIndex = 15;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Wheat;
            this.btnekle.Location = new System.Drawing.Point(444, 283);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 64);
            this.btnekle.TabIndex = 16;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Wheat;
            this.btnsil.Location = new System.Drawing.Point(525, 283);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(81, 64);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Wheat;
            this.btnguncelle.Location = new System.Drawing.Point(612, 286);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 62);
            this.btnguncelle.TabIndex = 18;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "no";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(125, 416);
            this.txtno.Multiline = true;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(144, 22);
            this.txtno.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.cmbsınıf);
            this.Controls.Add(this.dtdogumtarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpuan);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtadı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.dgvliste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvliste;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadı;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtpuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtdogumtarihi;
        private System.Windows.Forms.ComboBox cmbsınıf;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtno;
    }
}

