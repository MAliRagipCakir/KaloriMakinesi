using KaloriUygulama.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriUygulama
{
    public partial class SifremiUnuttumForm : Form
    {
        private readonly Kullanici girisYapan;

        public SifremiUnuttumForm(Kullanici girisYapan)
        {
            this.girisYapan = girisYapan;
            InitializeComponent();
            lblSonuc.Text = $"Şifreniz: '{girisYapan.Parola}' ";
        }

        private void btnGonder_Click_1(object sender, EventArgs e)
        {
            string sifreIpucu = txtSifreIpucu.Text.Trim();
            if (sifreIpucu == girisYapan.SifreIpucu)
            {
                lblSonuc.Visible = true;
            }
            else
            {
                MessageBox.Show("Şifre ipucunu yanlış girdiniz..");
                lblSonuc.Visible = false;
            }
        }
    }
}
