using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriUygulama.Entities
{
    public class Kullanici
    {
        public Kullanici()
        {
            Ogunler = new List<Ogun>();
        }
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Parola { get; set; }
        public string SifreIpucu { get; set; }
        // public int GunlukKaloriLimit { get; set; }

        // Boy Kilo, Günlük Kalori Limiti vb propertyler eklenebilir
        // Günlük Kalori Limiti Kullanıcı oluşturulurken yapılan seçime göre ayarlanabilir(diyet programlarındaki gibi) Kalori Takip formunda SuDeposu projesindeki gibi % ile dolan görsel ile bir görsel takip uygulanabilir (bu limit ile günlük kalori miktarı arasında)

        public virtual ICollection<Ogun> Ogunler { get; set; }
    }
}
