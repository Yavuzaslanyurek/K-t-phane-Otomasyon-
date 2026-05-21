using KutuphaneOtomasyonu.DataAccess;
using KutuphaneOtomasyonu.Entities;

using System;
using System.Collections.Generic;
using KutuphaneOtomasyonu.DataAccess;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.Business
{
    public class EmanetService
    {
        private EmanetRepository _emanetRepository;
        private KitapRepository _kitapRepository;

        public EmanetService()
        {
            _emanetRepository = new EmanetRepository();
            _kitapRepository = new KitapRepository();
        }

        public List<Emanet> GetAll()
        {
            try { return _emanetRepository.GetAll(); }
            catch (Exception ex) { throw new Exception("Emanet listesi alınamadı: " + ex.Message); }
        }

        public List<Emanet> GetTeslimEdilmeyenler()
        {
            try { return _emanetRepository.GetTeslimEdilmeyenler(); }
            catch (Exception ex) { throw new Exception("Aktif emanetler alınamadı: " + ex.Message); }
        }

        public List<Emanet> GetAktifEmanetler()
        {
            return GetTeslimEdilmeyenler();
        }

        public List<Emanet> SearchByKeyword(string keyword)
        {
            try
            {
                return _emanetRepository.GetAll().FindAll(e =>
                    e.KitapAdi.ToLower().Contains(keyword.ToLower()) ||
                    e.UyeAdSoyad.ToLower().Contains(keyword.ToLower()));
            }
            catch (Exception ex) { throw new Exception("Arama yapılırken hata: " + ex.Message); }
        }

        public void EmanetVer(Emanet emanet)
        {
            try
            {
                Kitap kitap = _kitapRepository.GetById(emanet.KitapId);
                if (kitap == null) throw new Exception("Kitap bulunamadı!");
                if (kitap.StokAdedi < 1) throw new Exception($"'{kitap.KitapAdi}' stokta yok!");

                emanet.EmanetTarihi = DateTime.Now;
                emanet.TeslimEdildiMi = false;
                _emanetRepository.Add(emanet);

                kitap.StokAdedi--;
                _kitapRepository.Update(kitap);
            }
            catch (Exception ex) { throw new Exception("Emanet verilirken hata: " + ex.Message); }
        }

        public void TeslimAl(int emanetId, DateTime teslimTarihi)
        {
            try
            {
                Emanet emanet = _emanetRepository.GetById(emanetId);
                if (emanet == null) throw new Exception("Emanet kaydı bulunamadı!");
                if (emanet.TeslimEdildiMi) throw new Exception("Bu kitap zaten teslim alınmış!");

                emanet.TeslimTarihi = teslimTarihi == DateTime.MinValue ? DateTime.Now : teslimTarihi;
                emanet.TeslimEdildiMi = true;
                _emanetRepository.Update(emanet);

                Kitap kitap = _kitapRepository.GetById(emanet.KitapId);
                if (kitap != null)
                {
                    kitap.StokAdedi++;
                    _kitapRepository.Update(kitap);
                }
            }
            catch (Exception ex) { throw new Exception("Teslim alınırken hata: " + ex.Message); }
        }
    }
}
