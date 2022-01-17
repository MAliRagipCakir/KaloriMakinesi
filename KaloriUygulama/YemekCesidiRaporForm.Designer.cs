
namespace KaloriUygulama
{
    partial class YemekCesidiRaporForm
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
            this.btnYemekKategoriRaporCikis = new System.Windows.Forms.Button();
            this.dgvYemekCesidiBazli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekCesidiBazli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYemekKategoriRaporCikis
            // 
            this.btnYemekKategoriRaporCikis.FlatAppearance.BorderSize = 0;
            this.btnYemekKategoriRaporCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnYemekKategoriRaporCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYemekKategoriRaporCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYemekKategoriRaporCikis.ForeColor = System.Drawing.Color.Black;
            this.btnYemekKategoriRaporCikis.Location = new System.Drawing.Point(0, 0);
            this.btnYemekKategoriRaporCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnYemekKategoriRaporCikis.Name = "btnYemekKategoriRaporCikis";
            this.btnYemekKategoriRaporCikis.Size = new System.Drawing.Size(33, 31);
            this.btnYemekKategoriRaporCikis.TabIndex = 69;
            this.btnYemekKategoriRaporCikis.Text = "X";
            this.btnYemekKategoriRaporCikis.UseVisualStyleBackColor = true;
            this.btnYemekKategoriRaporCikis.Click += new System.EventHandler(this.btnYemekKategoriRaporCikis_Click);
            // 
            // dgvYemekCesidiBazli
            // 
            this.dgvYemekCesidiBazli.AllowUserToAddRows = false;
            this.dgvYemekCesidiBazli.AllowUserToDeleteRows = false;
            this.dgvYemekCesidiBazli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvYemekCesidiBazli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYemekCesidiBazli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYemekCesidiBazli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekCesidiBazli.Location = new System.Drawing.Point(12, 83);
            this.dgvYemekCesidiBazli.Name = "dgvYemekCesidiBazli";
            this.dgvYemekCesidiBazli.ReadOnly = true;
            this.dgvYemekCesidiBazli.RowHeadersVisible = false;
            this.dgvYemekCesidiBazli.Size = new System.Drawing.Size(910, 566);
            this.dgvYemekCesidiBazli.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Öğün Bazlı Gram Ölçülü Yemek Çeşidi Raporu";
            // 
            // YemekCesidiRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvYemekCesidiBazli);
            this.Controls.Add(this.btnYemekKategoriRaporCikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YemekCesidiRaporForm";
            this.Text = "YemekKategoriRaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekCesidiBazli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYemekKategoriRaporCikis;
        private System.Windows.Forms.DataGridView dgvYemekCesidiBazli;
        private System.Windows.Forms.Label label1;
    }
}