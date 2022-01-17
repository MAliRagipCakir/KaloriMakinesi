using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriUygulama.Entities
{
    public class OgunDetay
    {
        public int Id { get; set; }
        public decimal Adet { get; set; }
        public decimal OgunDetayGram { get; set; }
        public decimal OgunDetayKalori { get; set; }
        public decimal OgunDetayYag { get; set; }
        public decimal OgunDetayProtein { get; set; }
        public decimal OgunDetayKarbonhidrat { get; set; }


        public int BesinId { get; set; }
        public virtual Besin Besin { get; set; }

        public int OgunId { get; set; }
        public virtual Ogun Ogun { get; set; }
    }
}
