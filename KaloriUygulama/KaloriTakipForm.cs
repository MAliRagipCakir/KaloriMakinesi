using KaloriUygulama.Data;
using KaloriUygulama.Entities;
using KaloriUygulama.Enums;
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
    public partial class KaloriTakipForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private readonly Kullanici kullanici;

        private DateTime tarih;

        public KaloriTakipForm(KaloriUygulamaDbContext db, Kullanici kullanici)
        {
            this.db = db;
            this.kullanici = kullanici;
            InitializeComponent();
            lblAdSoyad.Text = $"{kullanici.Ad} {kullanici.Soyad}";
            tarih = dtpOgunTakipTarih.Value;
            OgunleriListele(tarih);
        }

        /// <summary>
        /// Tarih değişince, kullanıcı'nın öğünü varsa; Bu öğünleri 4 ayrı datagridview'e bölerek listeleme metotlarını çağırır
        /// </summary>
        /// <param name="tarih"></param>
        private void OgunleriListele(DateTime tarih)
        {
            if (kullanici.Ogunler.Count == 0)
            {
                dgvSabah.DataSource = null;
                dgvOglen.DataSource = null;
                dgvAksam.DataSource = null;
                dgvAraOgun.DataSource = null;
            }
            else
            {
                OgunListele(tarih, OgunAdi.Sabah, dgvSabah);
                OgunListele(tarih, OgunAdi.Ogle, dgvOglen);
                OgunListele(tarih, OgunAdi.Aksam, dgvAksam);
                OgunListele(tarih, OgunAdi.AraOgun, dgvAraOgun);
            }
        }

        /// <summary>
        /// Parametre olarak aldığı öğünAdına göre yine parametre olarak aldığı datagridview'a kullanıcının öğünlerini listeler
        /// </summary>
        /// <param name="tarih"></param>
        /// <param name="ogunAdi"></param>
        /// <param name="dgv"></param>
        private void OgunListele(DateTime tarih, OgunAdi ogunAdi, DataGridView dgv)
        {
            if (kullanici.Ogunler.Any(x => x.Ad == ogunAdi))
            {
                var ogun = kullanici.Ogunler.FirstOrDefault(x => x.Ad == ogunAdi && x.YenmeTarihi.ToString("dd/MM/yyyy") == tarih.ToString("dd/MM/yyyy"));
                if (ogun != null)
                {
                    dgv.DataSource = ogun.OgunDetaylar.Select(x => new
                    {
                        x.Id,
                        Besin = x.Besin.BesinAd,
                        Kategori = x.Besin.Kategori.KategoriAd,
                        Miktar = x.Adet,
                        Porsiyon = x.Besin.Porsiyon.PorsiyonAd,
                        Gram = x.OgunDetayGram,
                        Protein = x.OgunDetayProtein,
                        Yağ = x.OgunDetayYag,
                        Karbonhidrat = x.OgunDetayKarbonhidrat,
                        Kalori = x.OgunDetayKalori
                    }).ToList();

                    dgv.Columns[0].Visible = false;//Id yi gizledik, ama erişmek istediğimizde hala 0.cellde duruyor,Öğün düzenlerken 0.Row 0.Cell şeklinde Id çekebiliyoruz

                    dgv.Columns[5].DefaultCellStyle.Format = "N2";//Kolon içlerinde gösterilen değerleri, 0'dan sonra 2 basamak gösterecek şekilde ayarladık
                    dgv.Columns[6].DefaultCellStyle.Format = "N2";
                    dgv.Columns[7].DefaultCellStyle.Format = "N2";
                    dgv.Columns[8].DefaultCellStyle.Format = "N2";
                    dgv.Columns[9].DefaultCellStyle.Format = "N2";
                    DegerleriGuncelle(ogun, ogunAdi);
                }
                else
                {
                    Ogun bosOgun = null;//Label değerleri sıfırlamak için
                    dgv.DataSource = null;
                    DegerleriGuncelle(bosOgun, ogunAdi);
                }
            }
            else
            {
                Ogun bosOgun = null;//Label değerleri sıfırlamak için
                dgv.DataSource = null;
                DegerleriGuncelle(bosOgun, ogunAdi);
            }
        }

        private void DegerleriGuncelle(Ogun ogun, OgunAdi ogunAdi)
        {
            if (ogun != null)
            {
                switch (ogun.Ad)
                {
                    case OgunAdi.Sabah:
                        lblSabahKalori.Text = $"{ogun.ToplamKalori,0:N2} kcal";
                        lblSabahProtein.Text = $"{ogun.ToplamProtein,0:N2} gram";
                        lblSabahKarbonhidrat.Text = $"{ogun.ToplamKarbonhidrat,0:N2} gram";
                        lblSabahYag.Text = $"{ogun.ToplamYag,0:N2} gram";
                        break;
                    case OgunAdi.Ogle:
                        lblOglenKalori.Text = $"{ogun.ToplamKalori,0:N2} kcal";
                        lblOglenProtein.Text = $"{ogun.ToplamProtein,0:N2} gram";
                        lblOglenKarbonhidrat.Text = $"{ogun.ToplamKarbonhidrat,0:N2} gram";
                        lblOglenYag.Text = $"{ogun.ToplamYag,0:N2} gram";
                        break;
                    case OgunAdi.Aksam:
                        lblAksamKalori.Text = $"{ogun.ToplamKalori,0:N2} kcal";
                        lblAksamProtein.Text = $"{ogun.ToplamProtein,0:N2} gram";
                        lblAksamKarbonhidrat.Text = $"{ogun.ToplamKarbonhidrat,0:N2} gram";
                        lblAksamYag.Text = $"{ogun.ToplamYag,0:N2} gram";
                        break;
                    case OgunAdi.AraOgun:
                        lblAraOgunKalori.Text = $"{ogun.ToplamKalori,0:N2} kcal";
                        lblAraOgunProtein.Text = $"{ogun.ToplamProtein,0:N2} gram";
                        lblAraOgunKarbonhidrat.Text = $"{ogun.ToplamKarbonhidrat,0:N2} gram";
                        lblAraOgunYag.Text = $"{ogun.ToplamYag,0:N2} gram";
                        break;
                }
            }
            else
            {
                switch (ogunAdi)
                {
                    case OgunAdi.Sabah:
                        lblSabahKalori.Text = $"0 kcal";
                        lblSabahProtein.Text = $"0 gram";
                        lblSabahKarbonhidrat.Text = $"0 gram";
                        lblSabahYag.Text = $"0 gram";
                        break;
                    case OgunAdi.Ogle:
                        lblOglenKalori.Text = $"0 kcal";
                        lblOglenProtein.Text = $"0 gram";
                        lblOglenKarbonhidrat.Text = $"0 gram";
                        lblOglenYag.Text = $"0 gram";
                        break;
                    case OgunAdi.Aksam:
                        lblAksamKalori.Text = $"0 kcal";
                        lblAksamProtein.Text = $"0 gram";
                        lblAksamKarbonhidrat.Text = $"0 gram";
                        lblAksamYag.Text = $"0 gram";
                        break;
                    case OgunAdi.AraOgun:
                        lblAraOgunKalori.Text = $"0 kcal";
                        lblAraOgunProtein.Text = $"0 gram";
                        lblAraOgunKarbonhidrat.Text = $"0 gram";
                        lblAraOgunYag.Text = $"0 gram";
                        break;
                }
            }
            tarih = dtpOgunTakipTarih.Value;
            lblGunlukKalori.Text = kullanici.Ogunler.Where(x => x.YenmeTarihi.ToString("dd/MM/yyyy") == tarih.ToString("dd/MM/yyyy")).Sum(x => x.ToplamKalori).ToString("N2");
            lblGunlukProtein.Text = kullanici.Ogunler.Where(x => x.YenmeTarihi.ToString("dd/MM/yyyy") == tarih.ToString("dd/MM/yyyy")).Sum(x => x.ToplamProtein).ToString("N2");
            lblGunlukKarbonhidrat.Text = kullanici.Ogunler.Where(x => x.YenmeTarihi.ToString("dd/MM/yyyy") == tarih.ToString("dd/MM/yyyy")).Sum(x => x.ToplamKarbonhidrat).ToString("N2");
            lblGunlukYag.Text = kullanici.Ogunler.Where(x => x.YenmeTarihi.ToString("dd/MM/yyyy") == tarih.ToString("dd/MM/yyyy")).Sum(x => x.ToplamYag).ToString("N2");
        }

        private void dtpOgunTakipTarih_ValueChanged(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            OgunleriListele(tarih);

        }

        private void btnSabahEkle_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            OgunDetayEkle(tarih, OgunAdi.Sabah, dgvSabah);
        }

        private void OgunDetayEkle(DateTime tarih, OgunAdi ogunAdi, DataGridView dgv)
        {
            if (kullanici.Ogunler.Any(x => x.Ad == ogunAdi))
            {
                var ogun = kullanici.Ogunler.FirstOrDefault(x => x.Ad == ogunAdi && x.YenmeTarihi.ToString("dd/MM/yyyy") == tarih.ToString("dd/MM/yyyy"));
                if (ogun != null)
                {
                    DialogResult dr = new YemekEkleForm(db, ogun).ShowDialog();
                }
                else
                {
                    Ogun yeniOgun = new Ogun() { YenmeTarihi = tarih, Ad = ogunAdi };
                    kullanici.Ogunler.Add(yeniOgun);
                    DialogResult dr = new YemekEkleForm(db, yeniOgun).ShowDialog();
                    if (yeniOgun.OgunDetaylar.Count == 0)
                    {
                        kullanici.Ogunler.Remove(yeniOgun);
                    }
                }
            }
            else
            {
                Ogun yeniOgun = new Ogun() { YenmeTarihi = tarih, Ad = ogunAdi };
                kullanici.Ogunler.Add(yeniOgun);
                DialogResult dr = new YemekEkleForm(db, yeniOgun).ShowDialog();
                if (yeniOgun.OgunDetaylar.Count == 0)
                {
                    kullanici.Ogunler.Remove(yeniOgun);
                }
            }
            db.SaveChanges();
            OgunListele(tarih, ogunAdi, dgv);
        }

        private void btnSabahDuzenle_Click(object sender, EventArgs e)
        {
            OgunDuzenle(tarih, OgunAdi.Sabah, dgvSabah);
        }

        private void OgunDuzenle(DateTime tarih, OgunAdi ogunAdi, DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0) return;
            int id = (int)dgv.SelectedRows[0].Cells[0].Value;
            OgunDetay ogunDetay = db.OgunDetaylar.Find(id);
            DialogResult dr = new OgunDuzenleForm(ogunDetay, db).ShowDialog();
            OgunListele(tarih, ogunAdi, dgv);
        }

        private void btnSabahSil_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            SeciliOgunVeDetaySil(tarih, OgunAdi.Sabah, dgvSabah);
        }

        private void SeciliOgunVeDetaySil(DateTime tarih, OgunAdi ogunAdi, DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
                return;
            int id = (int)dgv.SelectedRows[0].Cells[0].Value;
            OgunDetay ogunDetay = db.OgunDetaylar.Find(id);
            db.OgunDetaylar.Remove(ogunDetay);
            Ogun ogun = kullanici.Ogunler.FirstOrDefault(x => x.Ad == ogunAdi && x.YenmeTarihi.ToString("dd/MM/yyyy") == tarih.ToString("dd/MM/yyyy"));
            if (ogun != null)
            {
                if (ogun.OgunDetaylar.Count == 0)
                {
                    db.Ogunler.Remove(ogun);
                }
            }
            db.SaveChanges();
            OgunListele(tarih, ogunAdi, dgv);
        }

        private void btnOglenEkle_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            OgunDetayEkle(tarih, OgunAdi.Ogle, dgvOglen);
        }

        private void btnOglenDuzenle_Click(object sender, EventArgs e)
        {
            OgunDuzenle(tarih, OgunAdi.Ogle, dgvOglen);
        }

        private void btnOglenSil_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            SeciliOgunVeDetaySil(tarih, OgunAdi.Ogle, dgvOglen);
        }

        private void btnAksamEkle_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            OgunDetayEkle(tarih, OgunAdi.Aksam, dgvAksam);
        }

        private void btnAksamDuzenle_Click(object sender, EventArgs e)
        {
            OgunDuzenle(tarih, OgunAdi.Aksam, dgvAksam);
        }

        private void btnAksamSil_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            SeciliOgunVeDetaySil(tarih, OgunAdi.Aksam, dgvAksam);
        }

        private void btnAraOgunEkle_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            OgunDetayEkle(tarih, OgunAdi.AraOgun, dgvAraOgun);
        }

        private void btnAraOgunDuzenle_Click(object sender, EventArgs e)
        {
            OgunDuzenle(tarih, OgunAdi.AraOgun, dgvAraOgun);
        }

        private void btnAraOgunSil_Click(object sender, EventArgs e)
        {
            tarih = dtpOgunTakipTarih.Value;
            SeciliOgunVeDetaySil(tarih, OgunAdi.AraOgun, dgvAraOgun);
        }
        private void btnKaloriTakipCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" '+' Tuşu ile öğüne besin eklenebilir.\r\n '...' Tuşu ile seçili Öğün Öğesi düzenlenebilir.\r\n '-' Tuşu ile seçili Öğün Öğesi silinebilir.");
        }
    }
}
