using KaloriUygulama.Data;
using KaloriUygulama.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriUygulama
{
    public partial class KullaniciOlusturForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private bool parolaKontrol;
        private bool gucluParola = false;
        string password;

        public KullaniciOlusturForm(KaloriUygulamaDbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string eposta = txtEposta.Text.Trim();
            string parola = txtParola.Text.Trim();
            string parola2 = txtParolaTekrar.Text.Trim();
            string sifreIpucu = txtSifreIpucu.Text.Trim();

            if (parola == "" || parola2 == "" || ad == "" || soyad == "" || eposta == "" || sifreIpucu == "")
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz");
            }
            else
            {
                if (!parolaKontrol)
                {
                    MessageBox.Show("Parola Eşleşmiyor");
                }
                else if (!gucluParola)
                {
                    MessageBox.Show("Şifre en az 8 haneli,1 büyük harf,1 küçük harf,1 özel karakter(%,$,#,.,@,*,!,-)den ve 1 rakamdan oluşmalıdır.");
                }
                else
                {
                    if (new EmailAddressAttribute().IsValid(eposta))
                    {
                        if (db.Kullanicilar.Any(x => x.Eposta == eposta))
                        {
                            MessageBox.Show("Bu e-posta adı zaten mevcut lütfen farklı bir e-posta girin");
                        }
                        else
                        {
                            db.Kullanicilar.Add(new Kullanici()
                            {
                                Ad = ad,
                                Soyad = soyad,
                                Eposta = eposta,
                                Parola = parola,
                                SifreIpucu = sifreIpucu
                            });
                            MessageBox.Show("Kayıt Başarılı");
                            db.SaveChanges();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir e-posta giriniz");
                    }
                }
            }
        }


        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            password = txtParola.Text.Trim();
            HashSet<char> specialCharacters = new HashSet<char>() { '%', '$', '#', '.', '@', '*', '!', '-' };

            if (password.Any(char.IsLower) && password.Any(char.IsDigit) && (password.Length == 8) && password.Any(specialCharacters.Contains))
            {
                gucluParola = true;
            }
            else
            {
                gucluParola = false;
            }

            ParolaEslesmeKontrol();
        }

        private void txtParolaTekrar_TextChanged(object sender, EventArgs e)
        {
            ParolaEslesmeKontrol();
        }

        private void ParolaEslesmeKontrol()
        {
            if (txtParola.Text == txtParolaTekrar.Text)
            {
                lblKontrol.Text = "parola eşleşiyor";
                lblKontrol.ForeColor = Color.Green;
                parolaKontrol = true;
            }
            else
            {
                lblKontrol.Text = "parola eşleşmiyor";
                lblKontrol.ForeColor = Color.Red;
                parolaKontrol = false;
            }

            if (txtParola.Text == "" && txtParolaTekrar.Text == "")
            {
                lblKontrol.Text = "";
            }
        }

        private void chkParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParolaGoster.Checked)
            {
                txtParola.PasswordChar = '\0';
                txtParolaTekrar.PasswordChar = '\0';
            }
            else
            {
                txtParola.PasswordChar = '*';
                txtParolaTekrar.PasswordChar = '*';
            }
        }
    }
}
