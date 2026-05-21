using System;

namespace KutuphaneOtomasyonu.Entities
{
    public class Emanet
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public DateTime EmanetTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public bool TeslimEdildiMi { get; set; }

        // UI Katmanının doğrudan aradığı eski property isimleri için yönlendirme köprüleri:
        public DateTime VerilisTarihi { get => EmanetTarihi; set => EmanetTarihi = value; }
        public DateTime TeslimEdilmesiGerekenTarih { get; set; } = DateTime.Now.AddDays(15);
        public bool TeslimEdildi { get => TeslimEdildiMi; set => TeslimEdildiMi = value; }
        public string DurumNotu { get; set; } = string.Empty;

        // JOIN sorgularıyla ekranda gösterilecek alanlar
        public string KitapAdi { get; set; } = string.Empty;
        public string UyeAdSoyad { get; set; } = string.Empty;
    }
}