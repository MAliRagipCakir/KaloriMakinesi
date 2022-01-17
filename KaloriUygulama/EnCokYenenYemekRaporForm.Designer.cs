
namespace KaloriUygulama
{
    partial class EnCokYenenYemekRaporForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnEnCokYenenYemekCikis = new System.Windows.Forms.Button();
            this.chartEnCokYenenGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvEnCokYenenListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnCokYenenGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokYenenListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnCokYenenYemekCikis
            // 
            this.btnEnCokYenenYemekCikis.FlatAppearance.BorderSize = 0;
            this.btnEnCokYenenYemekCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnEnCokYenenYemekCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnCokYenenYemekCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnCokYenenYemekCikis.ForeColor = System.Drawing.Color.Black;
            this.btnEnCokYenenYemekCikis.Location = new System.Drawing.Point(0, 0);
            this.btnEnCokYenenYemekCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnCokYenenYemekCikis.Name = "btnEnCokYenenYemekCikis";
            this.btnEnCokYenenYemekCikis.Size = new System.Drawing.Size(33, 31);
            this.btnEnCokYenenYemekCikis.TabIndex = 11;
            this.btnEnCokYenenYemekCikis.Text = "X";
            this.btnEnCokYenenYemekCikis.UseVisualStyleBackColor = true;
            this.btnEnCokYenenYemekCikis.Click += new System.EventHandler(this.btnEnCokYenenYemekCikis_Click);
            // 
            // chartEnCokYenenGrafik
            // 
            this.chartEnCokYenenGrafik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartEnCokYenenGrafik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEnCokYenenGrafik.Legends.Add(legend1);
            this.chartEnCokYenenGrafik.Location = new System.Drawing.Point(440, 90);
            this.chartEnCokYenenGrafik.Name = "chartEnCokYenenGrafik";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEnCokYenenGrafik.Series.Add(series1);
            this.chartEnCokYenenGrafik.Size = new System.Drawing.Size(482, 559);
            this.chartEnCokYenenGrafik.TabIndex = 71;
            this.chartEnCokYenenGrafik.Text = "chart1";
            // 
            // dgvEnCokYenenListe
            // 
            this.dgvEnCokYenenListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEnCokYenenListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnCokYenenListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnCokYenenListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnCokYenenListe.Location = new System.Drawing.Point(12, 90);
            this.dgvEnCokYenenListe.Name = "dgvEnCokYenenListe";
            this.dgvEnCokYenenListe.RowHeadersVisible = false;
            this.dgvEnCokYenenListe.Size = new System.Drawing.Size(422, 559);
            this.dgvEnCokYenenListe.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "En Çok Yenen Yemeklerin Gram Bazlı Liste ve Grafiği";
            // 
            // EnCokYenenYemekRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEnCokYenenListe);
            this.Controls.Add(this.chartEnCokYenenGrafik);
            this.Controls.Add(this.btnEnCokYenenYemekCikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnCokYenenYemekRaporForm";
            this.Text = "En Çok Yenen Yemek Rapor";
            ((System.ComponentModel.ISupportInitialize)(this.chartEnCokYenenGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokYenenListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnCokYenenYemekCikis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnCokYenenGrafik;
        private System.Windows.Forms.DataGridView dgvEnCokYenenListe;
        private System.Windows.Forms.Label label1;
    }
}