using KaloriUygulama.Data;
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
    public partial class UygulamaAnaForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private readonly Kullanici kullanici;

        private Form activeForm = null;
        public UygulamaAnaForm(KaloriUygulamaDbContext db, Kullanici kullanici)
        {
            this.db = db;
            this.kullanici = kullanici;
            InitializeComponent();
            hideSubMenu();

            if (kullanici.Eposta == "admin")
                btnYemekEkle.Visible = true;
            else
                btnYemekEkle.Visible = false;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void hideSubMenu()
        {
            panelRaporlar.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
            
        private void btnKaloriTakip_Click(object sender, EventArgs e)
        {
            openChildForm(new KaloriTakipForm(db, kullanici));
            hideSubMenu();
        }

        private void btnYemekAra_Click(object sender, EventArgs e)
        {
            openChildForm(new YemekAraForm(db));
            hideSubMenu();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            openChildForm(new YemekOlusturForm(db));
            hideSubMenu();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRaporlar);
        }

        #region RaporlarSubMenu
        private void btnEnCokYenenYemek_Click(object sender, EventArgs e)
        {
            openChildForm(new EnCokYenenYemekRaporForm(db, kullanici));
        }

        private void btnYemekCesidiRapor_Click(object sender, EventArgs e)
        {
            openChildForm(new YemekCesidiRaporForm(db, kullanici));
        }

        private void btnHaftalikKiyas_Click(object sender, EventArgs e)
        {
            openChildForm(new HaftalikKiyasForm(db, kullanici));
        }

        private void btnAylikKiyas_Click(object sender, EventArgs e)
        {
            openChildForm(new AylikKiyasForm(db, kullanici));
        }
        #endregion

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            openChildForm(new HakkindaForm());
            hideSubMenu();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
