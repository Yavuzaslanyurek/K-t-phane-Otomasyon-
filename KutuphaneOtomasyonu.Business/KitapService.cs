using System;
using System.Collections.Generic;
using KutuphaneOtomasyonu.DataAccess;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.Business
{
    public class KitapService
    {
        private KitapRepository _kitapRepository;

        public KitapService()
        {
            _kitapRepository = new KitapRepository();
        }

        public List<Kitap> GetAll()
        {
            try
            {
                return _kitapRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Kitaplar listelenirken veritabanı veya bağlantı kaynaklı bir hata oluştu: " + ex.Message);
            }
        }

        public void Add(Kitap kitap)
        {
            try
            {
                // Boş alan kontrolleri
                if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
                    throw new Exception("Kitap adı boş kalamaz. Lütfen kitap adı giriniz.");

                if (string.IsNullOrWhiteSpace(kitap.Yazar))
                    throw new Exception("Yazar adı boş kalamaz. Lütfen bir yazar giriniz.");

                // Kitap ekleneceği zaman sayısal/diğer alanların da mantıksal kontrolü yapılabilir
                if (kitap.SayfaSayisi < 0)
                    throw new Exception("Sayfa sayısı negatif olamaz.");
                
                if (kitap.StokAdedi < 0)
                    throw new Exception("Stok adedi negatif olamaz.");

                _kitapRepository.Add(kitap);
            }
            catch (Exception ex)
            {
                // Yakalanan hatayı UI katmanına fırlatarak kullanıcıya göstereceğiz.
                throw new Exception("Kitap ekleme işlemi başarısız oldu: " + ex.Message);
            }
        }

        public void Update(Kitap kitap)
        {
            try
            {
                // Kimlik (ID) Kontrolü
                if (kitap.Id <= 0)
                    throw new Exception("Güncelleme işlemi için geçerli bir kitap ID'si bulunamadı.");

                // Metin Kontrolleri
                if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
                    throw new Exception("Kitap adı boş kalamaz.");

                if (string.IsNullOrWhiteSpace(kitap.Yazar))
                    throw new Exception("Yazar adı boş kalamaz.");

                if (kitap.SayfaSayisi < 0)
                    throw new Exception("Sayfa sayısı negatif olamaz.");
                
                if (kitap.StokAdedi < 0)
                    throw new Exception("Stok adedi negatif olamaz.");

                _kitapRepository.Update(kitap);
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                // Kimlik (ID) Kontrolü
                if (id <= 0)
                    throw new Exception("Geçersiz veya eksik kayıt seçimi. Silme işlemi yapılamıyor.");

                _kitapRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap silinirken hata oluştu: " + ex.Message);
            }
        }

        public Kitap GetById(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("Geçersiz ID girişi.");

                return _kitapRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap bilgisi getirilirken hata oluştu: " + ex.Message);
            }
        }

        public List<Kitap> SearchByKeyword(string keyword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(keyword))
                    return GetAll(); // Keyword boş ise hepsini getir.

                return _kitapRepository.SearchByKeyword(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Arama işlemi yapılırken hata oluştu: " + ex.Message);
            }
        }
    }
}
