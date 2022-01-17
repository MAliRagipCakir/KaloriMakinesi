
namespace KaloriUygulama
{
    partial class HaftalikKiyasForm
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
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHaftalikYag = new System.Windows.Forms.Label();
            this.lblHaftalikKarbonhidrat = new System.Windows.Forms.Label();
            this.lblHaftalikProtein = new System.Windows.Forms.Label();
            this.lblHaftalikKalori = new System.Windows.Forms.Label();
            this.btnHaftalikKiyasCikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGunlukOrtYag = new System.Windows.Forms.Label();
            this.lblGunlukOrtKarbonhidrat = new System.Windows.Forms.Label();
            this.lblGunlukOrtProtein = new System.Windows.Forms.Label();
            this.lblGunlukOrtKalori = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvOgunBazli = new System.Windows.Forms.DataGridView();
            this.dgvKategoriBazli = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunBazli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriBazli)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(204, 36);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtpBaslangic.TabIndex = 1;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = "";
            this.dtpBitis.Enabled = false;
            this.dtpBitis.Location = new System.Drawing.Point(410, 36);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 23);
            this.dtpBitis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Haftalık Toplam Kalori (kcal):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Haftalık Toplam Protein (g):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Haftalık Toplam Karbonhidrat (g):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Haftalık Toplam Yağ (g):";
            // 
            // lblHaftalikYag
            // 
            this.lblHaftalikYag.AutoSize = true;
            this.lblHaftalikYag.Location = new System.Drawing.Point(244, 80);
            this.lblHaftalikYag.Name = "lblHaftalikYag";
            this.lblHaftalikYag.Size = new System.Drawing.Size(16, 17);
            this.lblHaftalikYag.TabIndex = 11;
            this.lblHaftalikYag.Text = "0";
            // 
            // lblHaftalikKarbonhidrat
            // 
            this.lblHaftalikKarbonhidrat.AutoSize = true;
            this.lblHaftalikKarbonhidrat.Location = new System.Drawing.Point(244, 63);
            this.lblHaftalikKarbonhidrat.Name = "lblHaftalikKarbonhidrat";
            this.lblHaftalikKarbonhidrat.Size = new System.Drawing.Size(16, 17);
            this.lblHaftalikKarbonhidrat.TabIndex = 10;
            this.lblHaftalikKarbonhidrat.Text = "0";
            // 
            // lblHaftalikProtein
            // 
            this.lblHaftalikProtein.AutoSize = true;
            this.lblHaftalikProtein.Location = new System.Drawing.Point(244, 46);
            this.lblHaftalikProtein.Name = "lblHaftalikProtein";
            this.lblHaftalikProtein.Size = new System.Drawing.Size(16, 17);
            this.lblHaftalikProtein.TabIndex = 9;
            this.lblHaftalikProtein.Text = "0";
            // 
            // lblHaftalikKalori
            // 
            this.lblHaftalikKalori.AutoSize = true;
            this.lblHaftalikKalori.Location = new System.Drawing.Point(244, 29);
            this.lblHaftalikKalori.Name = "lblHaftalikKalori";
            this.lblHaftalikKalori.Size = new System.Drawing.Size(16, 17);
            this.lblHaftalikKalori.TabIndex = 8;
            this.lblHaftalikKalori.Text = "0";
            // 
            // btnHaftalikKiyasCikis
            // 
            this.btnHaftalikKiyasCikis.FlatAppearance.BorderSize = 0;
            this.btnHaftalikKiyasCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnHaftalikKiyasCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaftalikKiyasCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaftalikKiyasCikis.ForeColor = System.Drawing.Color.Black;
            this.btnHaftalikKiyasCikis.Location = new System.Drawing.Point(0, 0);
            this.btnHaftalikKiyasCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnHaftalikKiyasCikis.Name = "btnHaftalikKiyasCikis";
            this.btnHaftalikKiyasCikis.Size = new System.Drawing.Size(33, 31);
            this.btnHaftalikKiyasCikis.TabIndex = 68;
            this.btnHaftalikKiyasCikis.Text = "X";
            this.btnHaftalikKiyasCikis.UseVisualStyleBackColor = true;
            this.btnHaftalikKiyasCikis.Click += new System.EventHandler(this.btnHaftalikKiyasCikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblGunlukOrtYag);
            this.groupBox1.Controls.Add(this.lblGunlukOrtKarbonhidrat);
            this.groupBox1.Controls.Add(this.lblGunlukOrtProtein);
            this.groupBox1.Controls.Add(this.lblGunlukOrtKalori);
            this.groupBox1.Controls.Add(this.lblHaftalikYag);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblHaftalikKarbonhidrat);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblHaftalikProtein);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblHaftalikKalori);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(401, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 193);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yapan Kullanıcı Seçili Ay Toplam/Ortalama Değerler";
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(349, 17);
            this.label16.TabIndex = 80;
            this.label16.Text = "Seçili Haftanın Günlük Ortalama Kalori Tüketimi (kcal):";
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
            // dgvOgunBazli
            // 
            this.dgvOgunBazli.AllowUserToAddRows = false;
            this.dgvOgunBazli.AllowUserToDeleteRows = false;
            this.dgvOgunBazli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOgunBazli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunBazli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOgunBazli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunBazli.Location = new System.Drawing.Point(12, 100);
            this.dgvOgunBazli.Name = "dgvOgunBazli";
            this.dgvOgunBazli.ReadOnly = true;
            this.dgvOgunBazli.RowHeadersVisible = false;
            this.dgvOgunBazli.Size = new System.Drawing.Size(374, 193);
            this.dgvOgunBazli.TabIndex = 92;
            // 
            // dgvKategoriBazli
            // 
            this.dgvKategoriBazli.AllowUserToAddRows = false;
            this.dgvKategoriBazli.AllowUserToDeleteRows = false;
            this.dgvKategoriBazli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKategoriBazli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriBazli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKategoriBazli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriBazli.Location = new System.Drawing.Point(12, 345);
            this.dgvKategoriBazli.Name = "dgvKategoriBazli";
            this.dgvKategoriBazli.ReadOnly = true;
            this.dgvKategoriBazli.RowHeadersVisible = false;
            this.dgvKategoriBazli.Size = new System.Drawing.Size(910, 304);
            this.dgvKategoriBazli.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(605, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Haftalık Tüm Kullanıcılar Kategori Bazlı(Örn: Hangi Kategoriden Kaç Kalori Almış?" +
    ")";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(552, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Haftalık Tüm Kullanıcılar Öğün Bazlı(Örn: Hangi Öğünde Kaç Kalori Almış?)";
            // 
            // HaftalikKiyasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOgunBazli);
            this.Controls.Add(this.dgvKategoriBazli);
            this.Controls.Add(this.btnHaftalikKiyasCikis);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HaftalikKiyasForm";
            this.Text = "HaftalikKiyasForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunBazli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriBazli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHaftalikYag;
        private System.Windows.Forms.Label lblHaftalikKarbonhidrat;
        private System.Windows.Forms.Label lblHaftalikProtein;
        private System.Windows.Forms.Label lblHaftalikKalori;
        private System.Windows.Forms.Button btnHaftalikKiyasCikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGunlukOrtYag;
        private System.Windows.Forms.Label lblGunlukOrtKarbonhidrat;
        private System.Windows.Forms.Label lblGunlukOrtProtein;
        private System.Windows.Forms.Label lblGunlukOrtKalori;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvOgunBazli;
        private System.Windows.Forms.DataGridView dgvKategoriBazli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}