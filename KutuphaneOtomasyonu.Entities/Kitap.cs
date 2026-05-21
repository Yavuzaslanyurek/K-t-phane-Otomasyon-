namespace KutuphaneOtomasyonu.Entities
{
    public class Kitap
    {
        public int Id { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public string KitapAdi { get; set; } = string.Empty;
        public string Yazar { get; set; } = string.Empty;
        public string Yayinevi { get; set; } = string.Empty;
        public int SayfaSayisi { get; set; }
        public int YayinYili { get; set; }
        public int StokAdedi { get; set; }
        public bool Silindi { get; set; }
    }
}
