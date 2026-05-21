using System;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Business;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.UI
{
    public partial class FrmEmanet : Form
    {
        private EmanetService _emanetService;
        private KitapService _kitapService;
        private UyeService _uyeService;

        /*
         * UI Tarafında (Designer) olmasını beklediğimiz standart kontroller:
         * DataGridView : dgvListe
         * ComboBox     : cmbKitaplar, cmbUyeler
         * DateTimePicker: dtpTeslimTarihi
         * TextBox      : txtId, txtDurumNotu, txtArama
         * Button       : btnEmanetVer, btnTeslimAl, btnTemizle
         */

        public FrmEmanet()
        {
            InitializeComponent();
            _emanetService = new EmanetService();
            _kitapService = new KitapService();
            _uyeService = new UyeService();
        }

        private void FrmEmanet_Load(object sender, EventArgs e)
        {
            try
            {
                // Kitap ve Üye ComboboX'ların Servis Üzerinden Beslenmesi (ValueMember -> ID, DisplayMember -> İsimler)
                cmbKitaplar.DataSource = _kitapService.GetAll();
                cmbKitaplar.DisplayMember = "KitapAdi";
                cmbKitaplar.ValueMember = "Id";

                cmbUyeler.DataSource = _uyeService.GetAll();
                cmbUyeler.DisplayMember = "AdSoyad";
                cmbUyeler.ValueMember = "Id";

                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıtlar listelenirken kritik hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listele()
        {
            try
            {
                dgvListe.DataSource = _emanetService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Emanet tablosu yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Arama alanına veri girildiğinde Live Search (Canlı Filtreleme) 
                dgvListe.DataSource = _emanetService.SearchByKeyword(txtArama.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama motoru hata verdi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvListe.Rows[e.RowIndex];
                    
                    txtId.Text = row.Cells["Id"].Value?.ToString();
                    
                    // ComboBox'ların İlgili Foreign Key ile Doldurulması
                    cmbKitaplar.SelectedValue = row.Cells["KitapId"].Value;
                    cmbUyeler.SelectedValue = row.Cells["UyeId"].Value;
                    
                    // Tarih Alanı
                    if (row.Cells["TeslimEdilmesiGerekenTarih"].Value != DBNull.Value)
                    {
                        dtpTeslimTarihi.Value = Convert.ToDateTime(row.Cells["TeslimEdilmesiGerekenTarih"].Value);
                    }
                    
                    txtDurumNotu.Text = row.Cells["DurumNotu"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hücre bilgisi okunamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Kural 2: Kitap Ödünç Verildiğinde Çağrılan Metot
        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş Seçim Engellemesi
                if (cmbKitaplar.SelectedValue == null || cmbUyeler.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen Ödünç Verilecek Kitap ve Üye kayıtlarını seçiniz.", "Seçim Bekleniyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Emanet emanet = new Emanet
                {
                    KitapId = Convert.ToInt32(cmbKitaplar.SelectedValue),
                    UyeId = Convert.ToInt32(cmbUyeler.SelectedValue),
                    VerilisTarihi = DateTime.Now,
                    TeslimEdilmesiGerekenTarih = dtpTeslimTarihi.Value,
                    DurumNotu = txtDurumNotu.Text
                };

                // Business Katmanı Metodu Çağrılır (Stok yeterlilik kontrolü bu metot içerisinde çalışır)
                _emanetService.EmanetVer(emanet);
                
                MessageBox.Show("Kitap üyeye başarıyla emanet edildi. Kitabın toplam stoku sistemde 1 düşürüldü.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Temizle();
                Listele();
            }
            catch (Exception ex)
            {
                // Business katmanından stok kalmaması vb durumlarda fırlatılan hata uyarıları buraya düşerek MessageBox ile gösterilir!
                MessageBox.Show(ex.Message, "İşlem Durduruldu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kural 3: Kitap Teslim Alındığında (Emanetin Kapatılması ve Stoğa Ekleme)
        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) || txtId.Text == "0")
                {
                    MessageBox.Show("Lütfen işlemi kapatmak (,teslim almak) istediğiniz emanet kaydına tıklayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Seçili emanet ID'sini alıyoruz (Formundaki değişken adına göre kontrol et)
                int emanetId = Convert.ToInt32(dgvListe.CurrentRow.Cells["Id"].Value);

                // Ekranda gördüğüm DateTimePicker bileşeninin değerini doğrudan alıyoruz
                DateTime teslimTarihi = dtpTeslimTarihi.Value;

                // Servise tertemiz DateTime olarak gönderiyoruz
                _emanetService.TeslimAl(emanetId, teslimTarihi);

                MessageBox.Show("Kitap başarıyla teslim alındı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kapatma / Teslim alma işlemi başarısız: \n" + ex.Message, "Onay Verilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtId.Clear();
            txtDurumNotu.Clear();
            cmbKitaplar.SelectedIndex = -1;
            cmbUyeler.SelectedIndex = -1;
            // Sıradaki varsayılan teslim tarihi bugünden 15 gün sonrası olarak ayarlanıyor
            dtpTeslimTarihi.Value = DateTime.Now.AddDays(15); 
        }
    }
}
