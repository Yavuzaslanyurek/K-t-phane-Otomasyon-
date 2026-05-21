using System;

namespace KutuphaneOtomasyonu.Entities
{
    public class Uye
    {
        public int Id { get; set; }
        public string TcNo { get; set; } = string.Empty;
        public string AdSoyad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public DateTime KayitTarihi { get; set; }
        public bool Silindi { get; set; }
    }
}
