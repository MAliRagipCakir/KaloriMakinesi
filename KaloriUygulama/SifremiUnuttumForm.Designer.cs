
namespace KaloriUygulama
{
    partial class SifremiUnuttumForm
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtSifreIpucu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(130, 98);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(64, 25);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "label2";
            this.lblSonuc.Visible = false;
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGonder.Location = new System.Drawing.Point(349, 18);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(6);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(174, 44);
            this.btnGonder.TabIndex = 10;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click_1);
            // 
            // txtSifreIpucu
            // 
            this.txtSifreIpucu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifreIpucu.Location = new System.Drawing.Point(86, 25);
            this.txtSifreIpucu.Margin = new System.Windows.Forms.Padding(6);
            this.txtSifreIpucu.Name = "txtSifreIpucu";
            this.txtSifreIpucu.Size = new System.Drawing.Size(251, 30);
            this.txtSifreIpucu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "İpucu:";
            // 
            // SifremiUnuttumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 171);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtSifreIpucu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(565, 210);
            this.Name = "SifremiUnuttumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtSifreIpucu;
        private System.Windows.Forms.Label label1;
    }
}