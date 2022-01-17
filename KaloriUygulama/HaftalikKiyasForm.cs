using KaloriUygulama.Data;
using KaloriUygulama.Entities;
using KaloriUygulama.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriUygulama
{
    public partial class HaftalikKiyasForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private readonly Kullanici kullanici;

        DateTime baslangicTarih;
        DateTime bitisTarih;

        public HaftalikKiyasForm(KaloriUygulamaDbContext db, Kullanici kullanici)
        {
            this.db = db;
            this.kullanici = kullanici;
            InitializeComponent();
            dtpBitis.Value = dtpBaslangic.Value.AddDays(6);
            baslangicTarih = dtpBaslangic.Value;
            bitisTarih = dtpBitis.Value;
            HaftalikBesinDegerleriRaporu();
        }

        private void HaftalikBesinDegerleriRaporu()
        {
            if (kullanici.Ogunler.Any())
            {
                // (Ekstra) kullanıcının haftalık toplam besin değerleri
                var kalori = kullanici.Ogunler.Where(k => k.YenmeTarihi.Date >= baslangicTarih.Date && k.YenmeTarihi.Date <= bitisTarih.Date).Sum(y => y.ToplamKalori).ToString("N2");
                var protein = kullanici.Ogunler.Where(k => k.YenmeTarihi.Date >= baslangicTarih.Date && k.YenmeTarihi.Date <= bitisTarih.Date).Sum(y => y.ToplamProtein).ToString("N2");
                var karbonhidrat = kullanici.Ogunler.Where(k => k.YenmeTarihi.Date >= baslangicTarih.Date && k.YenmeTarihi.Date <= bitisTarih.Date).Sum(y => y.ToplamKarbonhidrat).ToString("N2");
                var yağ = kullanici.Ogunler.Where(k => k.YenmeTarihi.Date >= baslangicTarih.Date && k.YenmeTarihi.Date <= bitisTarih.Date).Sum(y => y.ToplamYag).ToString("N2");
                lblHaftalikKalori.Text = kalori;
                lblHaftalikProtein.Text = protein;
                lblHaftalikKarbonhidrat.Text = karbonhidrat;
                lblHaftalikYag.Text = yağ;

                // (Ekstra) Seçili haftanın günlük ortalama besin değerleri
                var günlükOrtalamaKalori = decimal.Parse(kalori) / 7;
                var günlükOrtalamaProtein = decimal.Parse(protein) / 7;
                var günlükOrtalamaKarbonhidrat = decimal.Parse(karbonhidrat) / 7;
                var günlükOrtalamaYag = decimal.Parse(yağ) / 7;
                lblGunlukOrtKalori.Text = günlükOrtalamaKalori.ToString("N2");
                lblGunlukOrtProtein.Text = günlükOrtalamaProtein.ToString("N2");
                lblGunlukOrtKarbonhidrat.Text = günlükOrtalamaKarbonhidrat.ToString("N2");
                lblGunlukOrtYag.Text = günlükOrtalamaYag.ToString("N2");
            }

            // Öğün bazlı tüm kişilerin kim hangi öğünden kaç sefer yedi *********************************
            //dgvOgunBazli.DataSource = db.Kullanicilar.Select(x => new
            //{
            //    KullanıcıId = x.Id,
            //    Sabah = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Count(y => y.Ad == OgunAdi.Sabah),
            //    Oğlen = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Count(y => y.Ad == OgunAdi.Ogle),
            //    Akşam = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Count(y => y.Ad == OgunAdi.Aksam),
            //    AraÖğün = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Count(y => y.Ad == OgunAdi.AraOgun),
            //}).ToList();

            //dgvOgunBazli.Columns[0].HeaderText = "Kullanıcı Id";

            // Öğün bazlı tüm kişilerin kim hangi öğünde kaç kalori almış *********************************
            dgvOgunBazli.DataSource = db.Kullanicilar.Select(x => new
            {
                KullanıcıId = x.Id,
                Sabah = x.Ogunler.ToList().Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date && k.Ad == OgunAdi.Sabah).Sum(y => (decimal?)y.OgunDetaylar.Sum(z => z.OgunDetayKalori)) ?? 0,
                Oğlen = x.Ogunler.ToList().Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date && k.Ad == OgunAdi.Ogle).Sum(y => (decimal?)y.OgunDetaylar.Sum(z => z.OgunDetayKalori)) ?? 0,
                Akşam = x.Ogunler.ToList().Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date && k.Ad == OgunAdi.Aksam).Sum(y => (decimal?)y.OgunDetaylar.Sum(z => z.OgunDetayKalori)) ?? 0,
                AraÖğün = x.Ogunler.ToList().Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date && k.Ad == OgunAdi.AraOgun).Sum(y => (decimal?)y.OgunDetaylar.Sum(z => z.OgunDetayKalori)) ?? 0,
            }).ToList();

            dgvOgunBazli.Columns[0].HeaderText = "Kullanıcı Id";

            // Kategori Bazlı tüm kişiler haftalık ; kim hangi kategoriden kaç sefer yemiş*********************************
            //dgvKategoriBazli.DataSource = db.Kullanicilar.Select(x => new
            //{
            //    KullanıcıId = x.Id,
            //    Mezeler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Mezeler")) ?? 0,
            //    Çorbalar = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Çorbalar")) ?? 0,
            //    AnaYemekler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Ana Yemekler")) ?? 0,
            //    YanÖğünler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Yan Öğünler")) ?? 0,
            //    EkmeklerVeUnluMamuller = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Ekmekler ve Unlu Mamuller")) ?? 0,
            //    SalatalarVeSalataSosları = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Salatalar ve Salata Sosları")) ?? 0,
            //    SoslarVeÇeşniler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Soslar ve Çeşniler")) ?? 0,
            //    Tatlılar = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Tatlılar")) ?? 0,
            //    Aperatifler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Aperatifler")) ?? 0,
            //    İçecekler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "İçecekler")) ?? 0,
            //    Kahvaltı = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Kahvaltı")) ?? 0,
            //    ÖğleYemeği = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Öğle Yemeği")) ?? 0,
            //    Diğer = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (int?)y.OgunDetaylar.Count(z => z.Besin.Kategori.KategoriAd == "Diğer")) ?? 0
            //}).ToList();

            //dgvKategoriBazli.Columns[0].HeaderText = "Kullanıcı Id";

            // Kategori Bazlı tüm kişiler haftalık ; kim hangi kategoriden kaç kalori almış *********************************
            dgvKategoriBazli.DataSource = db.Kullanicilar.Select(x => new
            {
                KullanıcıId = x.Id,
                Mezeler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Mezeler").Sum(p=> (decimal?)p.OgunDetayKalori)) ?? 0,
                Çorbalar = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Çorbalar").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                AnaYemekler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Ana Yemekler").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                YanÖğünler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Yan Öğünler").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                EkmeklerVeUnluMamuller = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Ekmekler ve Unlu Mamuller").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                SalatalarVeSalataSosları = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Salatalar ve Salata Sosları").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                SoslarVeÇeşniler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Soslar ve Çeşniler").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                Tatlılar = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Tatlılar").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                Aperatifler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Aperatifler").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                İçecekler = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "İçecekler").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                Kahvaltı = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Kahvaltı").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                ÖğleYemeği = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Öğle Yemeği").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0,
                Diğer = x.Ogunler.Where(k => DbFunctions.TruncateTime(k.YenmeTarihi) >= baslangicTarih.Date && DbFunctions.TruncateTime(k.YenmeTarihi) <= bitisTarih.Date).Sum(y => (decimal?)y.OgunDetaylar.Where(z => z.Besin.Kategori.KategoriAd == "Diğer").Sum(p => (decimal?)p.OgunDetayKalori)) ?? 0
            }).ToList();

            dgvKategoriBazli.Columns[0].HeaderText = "Kullanıcı Id";
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            dtpBitis.Value = dtpBaslangic.Value.AddDays(6);
            baslangicTarih = dtpBaslangic.Value;
            bitisTarih = dtpBitis.Value;
            HaftalikBesinDegerleriRaporu();
        }

        private void btnHaftalikKiyasCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
