using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Business;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.UI
{
    public partial class FrmUyeler : Form
    {
        private UyeService _uyeService;

        /* 
         * Lütfen Form (Designer) tarafında aşağıdaki arayüz elemanlarını oluşturduğunuzdan emin olun (veya isimlerini tasarımdakine göre revize edin):
         * - DataGridView : dgvUyeler
         * - TextBox      : txtId, txtTcNo, txtAdSoyad, txtTelefon, txtEposta, txtAdres, txtArama
         * - Button       : btnKaydet, btnGuncelle, btnSil, btnTemizle
         */
        
        public FrmUyeler()
        {
            InitializeComponent();
            _uyeService = new UyeService();
        }

        private void FrmUyeler_Load(object sender, EventArgs e)
        {
            // İlgili form açıkken 'Enter' tuşuna basılması btnKaydet tetiklenmesini sağlar
            this.AcceptButton = btnKaydet; 
            
            Listele();
        }

        private void Listele()
        {
            try
            {
                dgvUyeler.DataSource = _uyeService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye verileri elde edilirken arıza yaşandı: " + ex.Message, "Ağ veya Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Live Search (Canlı Üye Arama) İşlevi - Her harf basışta tetiklenir
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Canlı Arama motoru sayesinde isim veya TC'den anlık dinamik filtreleme
                dgvUyeler.DataSource = _uyeService.SearchByKeyword(txtArama.Text);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Arama motoru yanıt vermedi: " + ex.Message, "Kesinti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Veri grid'inde satır seçildiğinde ekrana TextBox aracılığıyla o kişinin basılması
        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow satir = dgvUyeler.Rows[e.RowIndex];
                    
                    txtId.Text = satir.Cells["Id"].Value?.ToString();
                    txtTcNo.Text = satir.Cells["TcNo"].Value?.ToString();
                    txtAdSoyad.Text = satir.Cells["AdSoyad"].Value?.ToString();
                    txtTelefon.Text = satir.Cells["Telefon"].Value?.ToString();
                    txtEposta.Text = satir.Cells["Email"].Value?.ToString();
                    txtAdres.Text = satir.Cells["Adres"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satırdaki müşteri bilgileri okunurken hata oluştu: " + ex.Message, "Veri Aktarım Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kayıt ve Düzeltme Butonu Merkezi Bloğu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Uye uye = new Uye
                {
                    TcNo = txtTcNo.Text,
                    AdSoyad = txtAdSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Email = txtEposta.Text,
                    Adres = txtAdres.Text
                };

                // Eğer ekrandaki gizli ya da pasif tutulan Id Textbox'ı doluysa işlem güncellemedir.
                if (!string.IsNullOrWhiteSpace(txtId.Text) && txtId.Text != "0")
                {
                    uye.Id = Convert.ToInt32(txtId.Text);
                    _uyeService.Update(uye);
                    MessageBox.Show("Mevcut üyeye ait bütün kayıtlar sıfır hata ile düzeltildi.", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Boş veya 0 gelirse Yeni Kayıt Algılanır
                else
                {
                    _uyeService.Add(uye);
                    MessageBox.Show("Kütüphane sistemine yepyeni bir üye kazandırıldı.", "Müşteri Kayıt Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Temizle();   // Kayıttan sonra form objelerini rahatlat
                Listele();   // Taze verileri gride yansıt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi durduruldu. Servis cevabı: " + ex.Message, "Geçersiz Girdi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Silmeden önce kullanıcıyı tespit etmek
                if (string.IsNullOrWhiteSpace(txtId.Text) || txtId.Text == "0")
                {
                    MessageBox.Show("Sistem şuan hangi kişiyi sileceğini seçemedi. Listeden silmek istediğiniz isme sol klik ile dokunun.", "Seçim Bekleniyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kaydı fiziksel olmayan soft-delete ile silmek için ekrandan istenen Yes/No Onay Kutusu
                DialogResult cevap = MessageBox.Show("Bu Üyeyi silmek istediğinize emin misiniz? (Tüm kayıt geçmişi arşive alınacaktır)", 
                                                     "Silinme İşlemi Tehlike Onayı", 
                                                     MessageBoxButtons.YesNo, 
                                                     MessageBoxIcon.Question);
                
                if (cevap == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    _uyeService.Delete(id);
                    MessageBox.Show("Seçilen üye pasifize edildi.", "Silme Operasyonu Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Temizle();
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı silme emrini reddetti: " + ex.Message, "Silinemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Yanlış butona basımları kurtarmak için reset metodu
            Temizle();
        }

        private void Temizle()
        {
            txtId.Clear();
            txtTcNo.Clear();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtAdres.Clear();
            txtArama.Clear();
        }
    }
}
