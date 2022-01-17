using KaloriUygulama.Entities;
using KaloriUygulama.InitialStrategies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriUygulama.Data
{
    public class KaloriUygulamaDbContext : DbContext
    {
        public KaloriUygulamaDbContext() : base("BaglantiCumlesi")
        {
            Database.SetInitializer(new DbInitialStrategy());
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<OgunDetay> OgunDetaylar { get; set; }
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }

    }
}
