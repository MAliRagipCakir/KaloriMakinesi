using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriUygulama.Entities
{
    public class Porsiyon
    {
        public Porsiyon()
        {
            Besinler = new List<Besin>();
        }
        public int Id { get; set; }
        public string PorsiyonAd { get; set; }

        public virtual ICollection<Besin> Besinler { get; set; }
    }
}
