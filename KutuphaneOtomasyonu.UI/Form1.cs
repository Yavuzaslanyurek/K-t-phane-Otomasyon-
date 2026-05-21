using System;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Business;

namespace KutuphaneOtomasyonu.UI
{
    public partial class Form1 : Form
    {
        private KitapService _kitapService;
        private UyeService _uyeService;
        private EmanetService _emanetService;

        public Form1()
        {
            InitializeComponent(); 
            
            _kitapService = new KitapService();
            _uyeService = new UyeService();
            _emanetService = new EmanetService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IstatistikleriGuncelle();
        }

        // Dashboard Canlı İstatistik Veri Çekme Metodu
        private void IstatistikleriGuncelle()
        {
            try
            {
                int toplamKitap = _kitapService.GetAll().Count;
                int toplamUye = _uyeService.GetAll().Count;
                int toplamEmanet = _emanetService.GetAll().Count;
                int aktifEmanet = _emanetService.GetAktifEmanetler().Count;

                lblToplamKitap.Text = toplamKitap.ToString();
                lblToplamUye.Text = toplamUye.ToString();
                lblToplamEmanet.Text = toplamEmanet.ToString();
                lblAktifEmanet.Text = aktifEmanet.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler sunucudan alınırken hata verdi:\n\n" + ex.Message, 
                                "Bağlantı Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKitapIslemleri_Click(object sender, EventArgs e)
        {
            new FrmKitaplar().Show();
        }

        private void BtnUyeIslemleri_Click(object sender, EventArgs e)
        {
            new FrmUyeler().Show();
        }

        private void BtnEmanetIslemleri_Click(object sender, EventArgs e)
        {
            new FrmEmanet().Show();
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            IstatistikleriGuncelle();
        }
    }
}
