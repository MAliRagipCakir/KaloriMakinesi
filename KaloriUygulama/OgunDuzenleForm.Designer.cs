
namespace KaloriUygulama
{
    partial class OgunDuzenleForm
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
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
            this.cmbPorsiyonlar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(331, 479);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(83, 40);
            this.btnIptal.TabIndex = 92;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(196, 479);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(129, 40);
            this.btnDuzenle.TabIndex = 91;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 90;
            this.label9.Text = "Adet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 89;
            this.label8.Text = "Porsiyon";
            // 
            // nudAdet
            // 
            this.nudAdet.DecimalPlaces = 2;
            this.nudAdet.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAdet.Location = new System.Drawing.Point(115, 7);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(222, 30);
            this.nudAdet.TabIndex = 88;
            this.nudAdet.ValueChanged += new System.EventHandler(this.nudAdet_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.groupBox1.Location = new System.Drawing.Point(15, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(399, 369);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Besin Değerleri";
            // 
            // lblYag
            // 
            this.lblYag.AutoSize = true;
            this.lblYag.Location = new System.Drawing.Point(197, 323);
            this.lblYag.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYag.Name = "lblYag";
            this.lblYag.Size = new System.Drawing.Size(23, 25);
            this.lblYag.TabIndex = 11;
            this.lblYag.Text = "0";
            // 
            // lblKarbonhidrat
            // 
            this.lblKarbonhidrat.AutoSize = true;
            this.lblKarbonhidrat.Location = new System.Drawing.Point(197, 267);
            this.lblKarbonhidrat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKarbonhidrat.Name = "lblKarbonhidrat";
            this.lblKarbonhidrat.Size = new System.Drawing.Size(23, 25);
            this.lblKarbonhidrat.TabIndex = 10;
            this.lblKarbonhidrat.Text = "0";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(197, 210);
            this.lblProtein.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(23, 25);
            this.lblProtein.TabIndex = 9;
            this.lblProtein.Text = "0";
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.Location = new System.Drawing.Point(197, 154);
            this.lblGram.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(23, 25);
            this.lblGram.TabIndex = 8;
            this.lblGram.Text = "0";
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Location = new System.Drawing.Point(197, 98);
            this.lblKalori.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(23, 25);
            this.lblKalori.TabIndex = 7;
            this.lblKalori.Text = "0";
            // 
            // lblBesinAd
            // 
            this.lblBesinAd.AutoSize = true;
            this.lblBesinAd.Location = new System.Drawing.Point(197, 42);
            this.lblBesinAd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBesinAd.Name = "lblBesinAd";
            this.lblBesinAd.Size = new System.Drawing.Size(27, 25);
            this.lblBesinAd.TabIndex = 6;
            this.lblBesinAd.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Yağ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Karbonhidrat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Protein:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gram:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kalori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Besin Adı:";
            // 
            // cmbPorsiyonlar
            // 
            this.cmbPorsiyonlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorsiyonlar.FormattingEnabled = true;
            this.cmbPorsiyonlar.Location = new System.Drawing.Point(110, 49);
            this.cmbPorsiyonlar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbPorsiyonlar.Name = "cmbPorsiyonlar";
            this.cmbPorsiyonlar.Size = new System.Drawing.Size(302, 33);
            this.cmbPorsiyonlar.TabIndex = 86;
            this.cmbPorsiyonlar.SelectedIndexChanged += new System.EventHandler(this.cmbPorsiyonlar_SelectedIndexChanged);
            // 
            // OgunDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 531);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPorsiyonlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(445, 570);
            this.Name = "OgunDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OgunDuzenleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAdet;
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
        private System.Windows.Forms.ComboBox cmbPorsiyonlar;
    }
}