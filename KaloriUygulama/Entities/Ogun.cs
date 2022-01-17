using KaloriUygulama.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriUygulama.Entities
{
    public class Ogun
    {
        public Ogun()
        {
            OgunDetaylar = new List<OgunDetay>();
        }
        public int Id { get; set; }
        public OgunAdi Ad { get; set; }
        public DateTime YenmeTarihi { get; set; }
        public decimal ToplamGram => OgunDetaylar.Sum(x => x.OgunDetayGram);
        public decimal ToplamKalori => OgunDetaylar.Sum(x => x.OgunDetayKalori);
        public decimal ToplamYag => OgunDetaylar.Sum(x => x.OgunDetayYag);
        public decimal ToplamProtein => OgunDetaylar.Sum(x => x.OgunDetayProtein);
        public decimal ToplamKarbonhidrat => OgunDetaylar.Sum(x => x.OgunDetayKarbonhidrat);

        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public virtual ICollection<OgunDetay> OgunDetaylar { get; set; }
    }
}
