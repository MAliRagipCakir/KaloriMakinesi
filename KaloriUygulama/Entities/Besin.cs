using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriUygulama.Entities
{
    public class Besin
    {
        public Besin()
        {
            OgunDetaylar = new List<OgunDetay>();
            BesinResimYolu = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\Besin\\" + "default.jpg";
        }
        public int Id { get; set; }
        public string BesinAd { get; set; }
        public decimal Gram { get; set; }
        public decimal Kalori { get; set; }
        public decimal Yag { get; set; }
        public decimal Protein { get; set; }
        public decimal Karbonhidrat { get; set; }
        public string BesinResimYolu { get; set; }

        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<OgunDetay> OgunDetaylar { get; set; }

        public int PorsiyonId { get; set; }
        public virtual Porsiyon Porsiyon { get; set; }
    }
}
