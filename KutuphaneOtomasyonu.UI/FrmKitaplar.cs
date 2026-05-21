using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Business;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.UI
{
    public partial class FrmKitaplar : Form
    {
        private KitapService _kitapService;

        /* 
         * Lütfen Form (Designer) tarafında aşağıdaki arayüz elemanlarını oluşturduğunuzdan emin olun (veya isimlerini tasarımdakine göre revize edin):
         * - DataGridView : dgvListe
         * - TextBox      : txtId, txtIsbn, txtKitapAdi, txtYazar, txtYayinevi, txtSayfaSayisi, txtYayinYili, txtStok, txtArama
         * - Button       : btnKaydet, btnSil, btnTemizle
         */

        public FrmKitaplar()
        {
            InitializeComponent();
            _kitapService = new KitapService();
        }

        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            // Enter tuşuna basıldığında Kaydet işleminin çalışması desteği
            this.AcceptButton = btnKaydet; 
            
            Listele();
        }

        private void Listele()
        {
            try
            {
                dgvListe.DataSource = _kitapService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar veritabanından çekilirken bir hata oluştu: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Live Search (Canlı Arama) İşlevi - (TextBox formda TextChanged olayına bağlanmalıdır)
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı her klavye vuruşu yaptığında live-search devreye girer
                dgvListe.DataSource = _kitapService.SearchByKeyword(txtArama.Text);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Arama esnasında hata oluştu: " + ex.Message, "Arama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Grid'e tıklanılan verinin otomatik olarak TextBox nesnelerine doldurulması
        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Tıklanan satır başlığı (-1) dışında geçerli bir hücre mi diye kontrol ediyoruz
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvListe.Rows[e.RowIndex];
                    
                    txtId.Text = row.Cells["Id"].Value?.ToString();
                    txtIsbn.Text = row.Cells["ISBN"].Value?.ToString();
                    txtKitapAdi.Text = row.Cells["KitapAdi"].Value?.ToString();
                    txtYazar.Text = row.Cells["Yazar"].Value?.ToString();
                    txtYayinevi.Text = row.Cells["Yayinevi"].Value?.ToString();
                    txtSayfaSayisi.Text = row.Cells["SayfaSayisi"].Value?.ToString();
                    txtYayinYili.Text = row.Cells["YayinYili"].Value?.ToString();
                    txtStok.Text = row.Cells["StokAdedi"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satır detayları form alanlarına çekilemedi: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kaydet / Güncelle Butonu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Form alanlarından nesne modeli oluşturuyoruz (Boxing)
                Kitap kitap = new Kitap
                {
                    ISBN = txtIsbn.Text,
                    KitapAdi = txtKitapAdi.Text,
                    Yazar = txtYazar.Text,
                    Yayinevi = txtYayinevi.Text,
                    SayfaSayisi = string.IsNullOrWhiteSpace(txtSayfaSayisi.Text) ? 0 : Convert.ToInt32(txtSayfaSayisi.Text),
                    YayinYili = string.IsNullOrWhiteSpace(txtYayinYili.Text) ? 0 : Convert.ToInt32(txtYayinYili.Text),
                    StokAdedi = string.IsNullOrWhiteSpace(txtStok.Text) ? 0 : Convert.ToInt32(txtStok.Text)
                };

                // ID kutusu boş değilse veya "0" değilse bu bir GÜNCELLEME talebidir
                if (!string.IsNullOrWhiteSpace(txtId.Text) && txtId.Text != "0")
                {
                    kitap.Id = Convert.ToInt32(txtId.Text);
                    _kitapService.Update(kitap);
                    MessageBox.Show("Kitap bilgileri başarıyla revize edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // ID kutusu boş ise DB yeni kayıt EKLEMEKTİR
                else
                {
                    _kitapService.Add(kitap);
                    MessageBox.Show("Sisteme kitap yeni bir kayıt olarak eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Temizle();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme işlemi başarısız. Lütfen bilgileri kontrol edin.\nEk: " + ex.Message, "İşlem Durduruldu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Silme Butonu ve Geri Getirilemez İşlem Onayı
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) || txtId.Text == "0")
                {
                    MessageBox.Show("Lütfen önce listeden silmek istediğiniz bir kayda tıklayınız.", "Bilgi Eksikliği", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kritik Uyarı İş Kuralı - MessageBox Seçeneği
                DialogResult cevap = MessageBox.Show("DiKKAT: Bu kaydı tamamen silmek istediğinize çok emin misiniz?\n(Bu işlem kitabı soft-delete yöntemiyle sistemden kaldırır)", 
                                                     "Geri Dönülemez İşlem Onayı", 
                                                     MessageBoxButtons.YesNo, 
                                                     MessageBoxIcon.Question);
                
                if (cevap == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    _kitapService.Delete(id);
                    MessageBox.Show("Kayıt güvenle sistemden temizlendi.", "Silinme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Temizle();
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap silinirken sunucu kaynaklı bir sorun gerçekleşti: " + ex.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ekranı temizleme tuşu arayüz operasyonu
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtId.Clear();
            txtIsbn.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayinevi.Clear();
            txtSayfaSayisi.Clear();
            txtYayinYili.Clear();
            txtStok.Clear();
            txtArama.Clear();
        }
    }
}
