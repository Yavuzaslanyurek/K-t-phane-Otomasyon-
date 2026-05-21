using System;
using System.Collections.Generic;
using KutuphaneOtomasyonu.DataAccess;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.Business
{
    public class UyeService
    {
        private UyeRepository _uyeRepository;

        public UyeService()
        {
            _uyeRepository = new UyeRepository();
        }

        public List<Uye> GetAll()
        {
            try
            {
                return _uyeRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Üyeler listelenirken veritabanı veya bağlantı kaynaklı bir hata oluştu: " + ex.Message);
            }
        }

        public void Add(Uye uye)
        {
            try
            {
                // Zorunlu metin alanları kontrolü
                if (string.IsNullOrWhiteSpace(uye.TcNo))
                    throw new Exception("TC Kimlik numarası alanı boş bırakılamaz.");

                if (uye.TcNo.Trim().Length != 11)
                    throw new Exception("TC Kimlik numarası tam 11 haneli olmalıdır.");

                if (string.IsNullOrWhiteSpace(uye.AdSoyad))
                    throw new Exception("Üye Ad Soyad alanı boş bırakılamaz. Lütfen geçerli bir isim giriniz.");

                _uyeRepository.Add(uye);
            }
            catch (Exception ex)
            {
                throw new Exception("Üye ekleme işlemi başarısız oldu: " + ex.Message);
            }
        }

        public void Update(Uye uye)
        {
            try
            {
                // Kimlik (ID) Kontrolü
                if (uye.Id <= 0)
                    throw new Exception("Güncelleme işlemi için geçerli bir üye ID'si bulunamadı.");

                // Metin Kontrolleri
                if (string.IsNullOrWhiteSpace(uye.TcNo) || uye.TcNo.Trim().Length != 11)
                    throw new Exception("Geçerli bir 11 haneli TC Kimlik numarası girmelisiniz.");

                if (string.IsNullOrWhiteSpace(uye.AdSoyad))
                    throw new Exception("Üye Ad Soyad alanı boş bırakılamaz.");

                _uyeRepository.Update(uye);
            }
            catch (Exception ex)
            {
                throw new Exception("Üye güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                // Kimlik (ID) Kontrolü
                if (id <= 0)
                    throw new Exception("Geçersiz veya eksik kayıt seçimi. Silme işlemi yapılamıyor.");

                _uyeRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Üye silinirken hata oluştu: " + ex.Message);
            }
        }

        public Uye GetById(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("Geçersiz ID girişi.");

                return _uyeRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Üye bilgisi getirilirken hata oluştu: " + ex.Message);
            }
        }

        public List<Uye> SearchByKeyword(string keyword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(keyword))
                    return GetAll(); // Keyword boşsa formdaki gridi yenilemek adına tüm listeyi dön

                return _uyeRepository.SearchByKeyword(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Arama işlemi yapılırken hata oluştu: " + ex.Message);
            }
        }
    }
}
