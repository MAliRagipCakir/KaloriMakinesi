
namespace KaloriUygulama
{
    partial class KullaniciGirisForm
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
            //if (disposing)
            //    db.Dispose();

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
            this.components = new System.ComponentModel.Container();
            this.liblKayitOl = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkParolaGoster = new System.Windows.Forms.CheckBox();
            this.liblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbGirisResim = new System.Windows.Forms.PictureBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.tmrResimler = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisResim)).BeginInit();
            this.SuspendLayout();
            // 
            // liblKayitOl
            // 
            this.liblKayitOl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.liblKayitOl.AutoSize = true;
            this.liblKayitOl.Location = new System.Drawing.Point(16, 456);
            this.liblKayitOl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liblKayitOl.Name = "liblKayitOl";
            this.liblKayitOl.Size = new System.Drawing.Size(57, 17);
            this.liblKayitOl.TabIndex = 10;
            this.liblKayitOl.TabStop = true;
            this.liblKayitOl.Text = "Kayıt Ol";
            this.liblKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liblKayitOl_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGiris.Location = new System.Drawing.Point(161, 383);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(149, 47);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtParola
            // 
            this.txtParola.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtParola.Location = new System.Drawing.Point(103, 307);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(207, 23);
            this.txtParola.TabIndex = 8;
            // 
            // txtEposta
            // 
            this.txtEposta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEposta.Location = new System.Drawing.Point(103, 256);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(207, 23);
            this.txtEposta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-posta:";
            // 
            // chkParolaGoster
            // 
            this.chkParolaGoster.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkParolaGoster.AutoSize = true;
            this.chkParolaGoster.Location = new System.Drawing.Point(197, 346);
            this.chkParolaGoster.Name = "chkParolaGoster";
            this.chkParolaGoster.Size = new System.Drawing.Size(113, 21);
            this.chkParolaGoster.TabIndex = 11;
            this.chkParolaGoster.Text = "Şifreyi Göster";
            this.chkParolaGoster.UseVisualStyleBackColor = true;
            this.chkParolaGoster.CheckedChanged += new System.EventHandler(this.chkParolaGoster_CheckedChanged);
            // 
            // liblSifremiUnuttum
            // 
            this.liblSifremiUnuttum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.liblSifremiUnuttum.AutoSize = true;
            this.liblSifremiUnuttum.Location = new System.Drawing.Point(81, 456);
            this.liblSifremiUnuttum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liblSifremiUnuttum.Name = "liblSifremiUnuttum";
            this.liblSifremiUnuttum.Size = new System.Drawing.Size(108, 17);
            this.liblSifremiUnuttum.TabIndex = 12;
            this.liblSifremiUnuttum.TabStop = true;
            this.liblSifremiUnuttum.Text = "Şifremi Unuttum";
            this.liblSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liblSifremiUnuttum_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pbGirisResim);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 204);
            this.panel1.TabIndex = 13;
            // 
            // pbGirisResim
            // 
            this.pbGirisResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGirisResim.Location = new System.Drawing.Point(0, 0);
            this.pbGirisResim.Name = "pbGirisResim";
            this.pbGirisResim.Size = new System.Drawing.Size(290, 204);
            this.pbGirisResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGirisResim.TabIndex = 2;
            this.pbGirisResim.TabStop = false;
            // 
            // rdb1
            // 
            this.rdb1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdb1.AutoSize = true;
            this.rdb1.Checked = true;
            this.rdb1.Enabled = false;
            this.rdb1.Location = new System.Drawing.Point(130, 222);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(14, 13);
            this.rdb1.TabIndex = 14;
            this.rdb1.TabStop = true;
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdb2.AutoSize = true;
            this.rdb2.Enabled = false;
            this.rdb2.Location = new System.Drawing.Point(150, 222);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(14, 13);
            this.rdb2.TabIndex = 15;
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdb3.AutoSize = true;
            this.rdb3.Enabled = false;
            this.rdb3.Location = new System.Drawing.Point(170, 222);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(14, 13);
            this.rdb3.TabIndex = 16;
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // tmrResimler
            // 
            this.tmrResimler.Interval = 3000;
            this.tmrResimler.Tick += new System.EventHandler(this.tmrResimler_Tick);
            // 
            // KullaniciGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(329, 501);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liblSifremiUnuttum);
            this.Controls.Add(this.chkParolaGoster);
            this.Controls.Add(this.liblKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(345, 540);
            this.Name = "KullaniciGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel liblKayitOl;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkParolaGoster;
        private System.Windows.Forms.LinkLabel liblSifremiUnuttum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbGirisResim;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.Timer tmrResimler;
    }
}