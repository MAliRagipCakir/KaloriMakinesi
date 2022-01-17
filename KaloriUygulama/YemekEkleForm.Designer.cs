
namespace KaloriUygulama
{
    partial class YemekEkleForm
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
            this.dgvArananYemekler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYag = new System.Windows.Forms.Label();
            this.lblKarbonhidrat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblGram = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
            this.lblBesinAd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboYemekResim = new System.Windows.Forms.PictureBox();
            this.cmbPorsiyonlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYemekAra = new System.Windows.Forms.TextBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblKontrol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArananYemekler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYemekResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArananYemekler
            // 
            this.dgvArananYemekler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvArananYemekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArananYemekler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArananYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArananYemekler.Location = new System.Drawing.Point(16, 77);
            this.dgvArananYemekler.MultiSelect = false;
            this.dgvArananYemekler.Name = "dgvArananYemekler";
            this.dgvArananYemekler.RowHeadersVisible = false;
            this.dgvArananYemekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArananYemekler.Size = new System.Drawing.Size(543, 526);
            this.dgvArananYemekler.TabIndex = 73;
            this.dgvArananYemekler.SelectionChanged += new System.EventHandler(this.dgvArananYemekler_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblYag);
            this.groupBox1.Controls.Add(this.lblKarbonhidrat);
            this.groupBox1.Controls.Add(this.lblProtein);
            this.groupBox1.Controls.Add(this.lblGram);
            this.groupBox1.Controls.Add(this.lblKalori);
            this.groupBox1.Controls.Add(this.lblBesinAd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(592, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 238);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Besin Değerleri";
            // 
            // lblYag
            // 
            this.lblYag.AutoSize = true;
            this.lblYag.Location = new System.Drawing.Point(174, 201);
            this.lblYag.Name = "lblYag";
            this.lblYag.Size = new System.Drawing.Size(23, 25);
            this.lblYag.TabIndex = 11;
            this.lblYag.Text = "0";
            // 
            // lblKarbonhidrat
            // 
            this.lblKarbonhidrat.AutoSize = true;
            this.lblKarbonhidrat.Location = new System.Drawing.Point(174, 170);
            this.lblKarbonhidrat.Name = "lblKarbonhidrat";
            this.lblKarbonhidrat.Size = new System.Drawing.Size(23, 25);
            this.lblKarbonhidrat.TabIndex = 10;
            this.lblKarbonhidrat.Text = "0";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(174, 139);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(23, 25);
            this.lblProtein.TabIndex = 9;
            this.lblProtein.Text = "0";
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.Location = new System.Drawing.Point(174, 108);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(23, 25);
            this.lblGram.TabIndex = 8;
            this.lblGram.Text = "0";
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Location = new System.Drawing.Point(174, 77);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(23, 25);
            this.lblKalori.TabIndex = 7;
            this.lblKalori.Text = "0";
            // 
            // lblBesinAd
            // 
            this.lblBesinAd.AutoSize = true;
            this.lblBesinAd.Location = new System.Drawing.Point(174, 46);
            this.lblBesinAd.Name = "lblBesinAd";
            this.lblBesinAd.Size = new System.Drawing.Size(27, 25);
            this.lblBesinAd.TabIndex = 6;
            this.lblBesinAd.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Yağ (g):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Karbonhidrat (g):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Protein (g):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gram (g):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kalori (kcal):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Besin Adı:";
            // 
            // pboYemekResim
            // 
            this.pboYemekResim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboYemekResim.Location = new System.Drawing.Point(592, 414);
            this.pboYemekResim.Name = "pboYemekResim";
            this.pboYemekResim.Size = new System.Drawing.Size(330, 189);
            this.pboYemekResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboYemekResim.TabIndex = 71;
            this.pboYemekResim.TabStop = false;
            // 
            // cmbPorsiyonlar
            // 
            this.cmbPorsiyonlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPorsiyonlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorsiyonlar.FormattingEnabled = true;
            this.cmbPorsiyonlar.Location = new System.Drawing.Point(694, 115);
            this.cmbPorsiyonlar.Name = "cmbPorsiyonlar";
            this.cmbPorsiyonlar.Size = new System.Drawing.Size(228, 33);
            this.cmbPorsiyonlar.TabIndex = 70;
            this.cmbPorsiyonlar.SelectedIndexChanged += new System.EventHandler(this.cmbPorsiyonlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Yemek Ara";
            // 
            // txtYemekAra
            // 
            this.txtYemekAra.Location = new System.Drawing.Point(141, 41);
            this.txtYemekAra.Name = "txtYemekAra";
            this.txtYemekAra.Size = new System.Drawing.Size(418, 30);
            this.txtYemekAra.TabIndex = 68;
            this.txtYemekAra.TextChanged += new System.EventHandler(this.txtYemekAra_TextChanged);
            // 
            // nudAdet
            // 
            this.nudAdet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAdet.DecimalPlaces = 2;
            this.nudAdet.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAdet.Location = new System.Drawing.Point(694, 79);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(228, 30);
            this.nudAdet.TabIndex = 76;
            this.nudAdet.ValueChanged += new System.EventHandler(this.nudAdet_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(587, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 77;
            this.label8.Text = "Porsiyon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(587, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 78;
            this.label9.Text = "Adet";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(750, 609);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 40);
            this.btnEkle.TabIndex = 79;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(839, 609);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(83, 40);
            this.btnIptal.TabIndex = 80;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKontrol.Location = new System.Drawing.Point(138, 21);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(154, 17);
            this.lblKontrol.TabIndex = 81;
            this.lblKontrol.Text = "En az 3 harf yazmalısın";
            this.lblKontrol.Visible = false;
            // 
            // YemekEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.lblKontrol);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.dgvArananYemekler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pboYemekResim);
            this.Controls.Add(this.cmbPorsiyonlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYemekAra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YemekEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YemekEkleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArananYemekler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYemekResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArananYemekler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblYag;
        private System.Windows.Forms.Label lblKarbonhidrat;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblGram;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.Label lblBesinAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboYemekResim;
        private System.Windows.Forms.ComboBox cmbPorsiyonlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYemekAra;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblKontrol;
    }
}