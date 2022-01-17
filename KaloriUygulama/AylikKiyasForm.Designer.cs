
namespace KaloriUygulama
{
    partial class AylikKiyasForm
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
            this.btnAylikKiyasCikis = new System.Windows.Forms.Button();
            this.dgvOgunBazli = new System.Windows.Forms.DataGridView();
            this.lblGunlukOrtYag = new System.Windows.Forms.Label();
            this.lblGunlukOrtKarbonhidrat = new System.Windows.Forms.Label();
            this.lblGunlukOrtProtein = new System.Windows.Forms.Label();
            this.lblGunlukOrtKalori = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAylikYag = new System.Windows.Forms.Label();
            this.lblAylikKarbonhidrat = new System.Windows.Forms.Label();
            this.lblAylikProtein = new System.Windows.Forms.Label();
            this.lblAylikKalori = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dgvKategoriBazli = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunBazli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriBazli)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAylikKiyasCikis
            // 
            this.btnAylikKiyasCikis.FlatAppearance.BorderSize = 0;
            this.btnAylikKiyasCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnAylikKiyasCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAylikKiyasCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAylikKiyasCikis.ForeColor = System.Drawing.Color.Black;
            this.btnAylikKiyasCikis.Location = new System.Drawing.Point(0, 0);
            this.btnAylikKiyasCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAylikKiyasCikis.Name = "btnAylikKiyasCikis";
            this.btnAylikKiyasCikis.Size = new System.Drawing.Size(33, 31);
            this.btnAylikKiyasCikis.TabIndex = 89;
            this.btnAylikKiyasCikis.Text = "X";
            this.btnAylikKiyasCikis.UseVisualStyleBackColor = true;
            this.btnAylikKiyasCikis.Click += new System.EventHandler(this.btnAylikKiyasCikis_Click);
            // 
            // dgvOgunBazli
            // 
            this.dgvOgunBazli.AllowUserToAddRows = false;
            this.dgvOgunBazli.AllowUserToDeleteRows = false;
            this.dgvOgunBazli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunBazli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOgunBazli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunBazli.Location = new System.Drawing.Point(12, 100);
            this.dgvOgunBazli.Name = "dgvOgunBazli";
            this.dgvOgunBazli.ReadOnly = true;
            this.dgvOgunBazli.RowHeadersVisible = false;
            this.dgvOgunBazli.Size = new System.Drawing.Size(374, 193);
            this.dgvOgunBazli.TabIndex = 88;
            // 
            // lblGunlukOrtYag
            // 
            this.lblGunlukOrtYag.AutoSize = true;
            this.lblGunlukOrtYag.Location = new System.Drawing.Point(401, 158);
            this.lblGunlukOrtYag.Name = "lblGunlukOrtYag";
            this.lblGunlukOrtYag.Size = new System.Drawing.Size(16, 17);
            this.lblGunlukOrtYag.TabIndex = 87;
            this.lblGunlukOrtYag.Text = "0";
            // 
            // lblGunlukOrtKarbonhidrat
            // 
            this.lblGunlukOrtKarbonhidrat.AutoSize = true;
            this.lblGunlukOrtKarbonhidrat.Location = new System.Drawing.Point(401, 141);
            this.lblGunlukOrtKarbonhidrat.Name = "lblGunlukOrtKarbonhidrat";
            this.lblGunlukOrtKarbonhidrat.Size = new System.Drawing.Size(16, 17);
            this.lblGunlukOrtKarbonhidrat.TabIndex = 86;
            this.lblGunlukOrtKarbonhidrat.Text = "0";
            // 
            // lblGunlukOrtProtein
            // 
            this.lblGunlukOrtProtein.AutoSize = true;
            this.lblGunlukOrtProtein.Location = new System.Drawing.Point(401, 124);
            this.lblGunlukOrtProtein.Name = "lblGunlukOrtProtein";
            this.lblGunlukOrtProtein.Size = new System.Drawing.Size(16, 17);
            this.lblGunlukOrtProtein.TabIndex = 85;
            this.lblGunlukOrtProtein.Text = "0";
            // 
            // lblGunlukOrtKalori
            // 
            this.lblGunlukOrtKalori.AutoSize = true;
            this.lblGunlukOrtKalori.Location = new System.Drawing.Point(401, 107);
            this.lblGunlukOrtKalori.Name = "lblGunlukOrtKalori";
            this.lblGunlukOrtKalori.Size = new System.Drawing.Size(16, 17);
            this.lblGunlukOrtKalori.TabIndex = 84;
            this.lblGunlukOrtKalori.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(321, 17);
            this.label13.TabIndex = 83;
            this.label13.Text = "Seçili Haftanın Günlük Ortalama Yağ Tüketimi (g):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(378, 17);
            this.label14.TabIndex = 82;
            this.label14.Text = "Seçili Haftanın Günlük Ortalama Karbonhidrat Tüketimi (g):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(341, 17);
            this.label15.TabIndex = 81;
            this.label15.Text = "Seçili Haftanın Günlük Ortalama Protein Tüketimi (g):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(349, 17);
            this.label16.TabIndex = 80;
            this.label16.Text = "Seçili Haftanın Günlük Ortalama Kalori Tüketimi (kcal):";
            // 
            // lblAylikYag
            // 
            this.lblAylikYag.AutoSize = true;
            this.lblAylikYag.Location = new System.Drawing.Point(244, 81);
            this.lblAylikYag.Name = "lblAylikYag";
            this.lblAylikYag.Size = new System.Drawing.Size(16, 17);
            this.lblAylikYag.TabIndex = 79;
            this.lblAylikYag.Text = "0";
            // 
            // lblAylikKarbonhidrat
            // 
            this.lblAylikKarbonhidrat.AutoSize = true;
            this.lblAylikKarbonhidrat.Location = new System.Drawing.Point(244, 64);
            this.lblAylikKarbonhidrat.Name = "lblAylikKarbonhidrat";
            this.lblAylikKarbonhidrat.Size = new System.Drawing.Size(16, 17);
            this.lblAylikKarbonhidrat.TabIndex = 78;
            this.lblAylikKarbonhidrat.Text = "0";
            // 
            // lblAylikProtein
            // 
            this.lblAylikProtein.AutoSize = true;
            this.lblAylikProtein.Location = new System.Drawing.Point(244, 47);
            this.lblAylikProtein.Name = "lblAylikProtein";
            this.lblAylikProtein.Size = new System.Drawing.Size(16, 17);
            this.lblAylikProtein.TabIndex = 77;
            this.lblAylikProtein.Text = "0";
            // 
            // lblAylikKalori
            // 
            this.lblAylikKalori.AutoSize = true;
            this.lblAylikKalori.Location = new System.Drawing.Point(244, 30);
            this.lblAylikKalori.Name = "lblAylikKalori";
            this.lblAylikKalori.Size = new System.Drawing.Size(16, 17);
            this.lblAylikKalori.TabIndex = 76;
            this.lblAylikKalori.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Aylık Toplam Yağ (g):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Aylık Toplam Karbonhidrat (g):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Aylık Toplam Protein (g):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Aylık Toplam Kalori (kcal):";
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = "";
            this.dtpBitis.Enabled = false;
            this.dtpBitis.Location = new System.Drawing.Point(410, 36);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 23);
            this.dtpBitis.TabIndex = 71;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(204, 36);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtpBaslangic.TabIndex = 70;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // dgvKategoriBazli
            // 
            this.dgvKategoriBazli.AllowUserToAddRows = false;
            this.dgvKategoriBazli.AllowUserToDeleteRows = false;
            this.dgvKategoriBazli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriBazli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKategoriBazli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriBazli.Location = new System.Drawing.Point(12, 345);
            this.dgvKategoriBazli.Name = "dgvKategoriBazli";
            this.dgvKategoriBazli.ReadOnly = true;
            this.dgvKategoriBazli.RowHeadersVisible = false;
            this.dgvKategoriBazli.Size = new System.Drawing.Size(910, 304);
            this.dgvKategoriBazli.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblGunlukOrtYag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGunlukOrtKarbonhidrat);
            this.groupBox1.Controls.Add(this.lblAylikKalori);
            this.groupBox1.Controls.Add(this.lblGunlukOrtProtein);
            this.groupBox1.Controls.Add(this.lblAylikProtein);
            this.groupBox1.Controls.Add(this.lblGunlukOrtKalori);
            this.groupBox1.Controls.Add(this.lblAylikKarbonhidrat);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblAylikYag);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(401, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 193);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yapan Kullanıcı Seçili Ay Toplam/Ortalama Değerler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 17);
            this.label6.TabIndex = 97;
            this.label6.Text = "Aylık Tüm Kullanıcılar Öğün Bazlı(Örn: Hangi Öğünde Kaç Kalori Almış?)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 17);
            this.label5.TabIndex = 96;
            this.label5.Text = "Aylık Tüm Kullanıcılar Kategori Bazlı(Örn: Hangi Kategoriden Kaç Kalori Almış?)";
            // 
            // AylikKiyasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAylikKiyasCikis);
            this.Controls.Add(this.dgvOgunBazli);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dgvKategoriBazli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AylikKiyasForm";
            this.Text = "Aylık Kıyas Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunBazli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriBazli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAylikKiyasCikis;
        private System.Windows.Forms.DataGridView dgvOgunBazli;
        private System.Windows.Forms.Label lblGunlukOrtYag;
        private System.Windows.Forms.Label lblGunlukOrtKarbonhidrat;
        private System.Windows.Forms.Label lblGunlukOrtProtein;
        private System.Windows.Forms.Label lblGunlukOrtKalori;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAylikYag;
        private System.Windows.Forms.Label lblAylikKarbonhidrat;
        private System.Windows.Forms.Label lblAylikProtein;
        private System.Windows.Forms.Label lblAylikKalori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DataGridView dgvKategoriBazli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}