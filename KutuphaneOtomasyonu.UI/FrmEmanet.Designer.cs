namespace KutuphaneOtomasyonu.UI
{
    partial class FrmEmanet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.cmbKitaplar = new System.Windows.Forms.ComboBox();
            this.cmbUyeler = new System.Windows.Forms.ComboBox();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDurumNotu = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelArama = new System.Windows.Forms.Label();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelDurumNotu = new System.Windows.Forms.Label();
            this.labelTeslimTarihi = new System.Windows.Forms.Label();
            this.labelUye = new System.Windows.Forms.Label();
            this.labelKitap = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dgvListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListe.ColumnHeadersHeight = 35;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.EnableHeadersVisualStyles = false;
            this.dgvListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.dgvListe.Location = new System.Drawing.Point(10, 10);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListe.RowHeadersVisible = false;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(630, 510);
            this.dgvListe.TabIndex = 0;
            this.dgvListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellClick);
            // 
            // cmbKitaplar
            // 
            this.cmbKitaplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbKitaplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKitaplar.ForeColor = System.Drawing.Color.White;
            this.cmbKitaplar.FormattingEnabled = true;
            this.cmbKitaplar.Location = new System.Drawing.Point(20, 100);
            this.cmbKitaplar.Name = "cmbKitaplar";
            this.cmbKitaplar.Size = new System.Drawing.Size(260, 25);
            this.cmbKitaplar.TabIndex = 3;
            // 
            // cmbUyeler
            // 
            this.cmbUyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbUyeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUyeler.ForeColor = System.Drawing.Color.White;
            this.cmbUyeler.FormattingEnabled = true;
            this.cmbUyeler.Location = new System.Drawing.Point(20, 160);
            this.cmbUyeler.Name = "cmbUyeler";
            this.cmbUyeler.Size = new System.Drawing.Size(260, 25);
            this.cmbUyeler.TabIndex = 5;
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.CalendarForeColor = System.Drawing.Color.White;
            this.dtpTeslimTarihi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dtpTeslimTarihi.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dtpTeslimTarihi.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(20, 220);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(260, 25);
            this.dtpTeslimTarihi.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(20, 40);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(260, 25);
            this.txtId.TabIndex = 1;
            // 
            // txtDurumNotu
            // 
            this.txtDurumNotu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDurumNotu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDurumNotu.ForeColor = System.Drawing.Color.White;
            this.txtDurumNotu.Location = new System.Drawing.Point(20, 280);
            this.txtDurumNotu.Multiline = true;
            this.txtDurumNotu.Name = "txtDurumNotu";
            this.txtDurumNotu.Size = new System.Drawing.Size(260, 60);
            this.txtDurumNotu.TabIndex = 9;
            // 
            // txtArama
            // 
            this.txtArama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.ForeColor = System.Drawing.Color.White;
            this.txtArama.Location = new System.Drawing.Point(620, 25);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(250, 25);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEmanetVer.FlatAppearance.BorderSize = 0;
            this.btnEmanetVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetVer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVer.ForeColor = System.Drawing.Color.White;
            this.btnEmanetVer.Location = new System.Drawing.Point(20, 360);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(260, 40);
            this.btnEmanetVer.TabIndex = 10;
            this.btnEmanetVer.Text = "Kitabı Emanet Ver";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTeslimAl.FlatAppearance.BorderSize = 0;
            this.btnTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimAl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAl.ForeColor = System.Drawing.Color.White;
            this.btnTeslimAl.Location = new System.Drawing.Point(20, 410);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(260, 40);
            this.btnTeslimAl.TabIndex = 11;
            this.btnTeslimAl.Text = "Kitabı Teslim Al / Kapat";
            this.btnTeslimAl.UseVisualStyleBackColor = false;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(20, 460);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(260, 40);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Seçimleri Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelTop.Controls.Add(this.labelArama);
            this.panelTop.Controls.Add(this.txtArama);
            this.panelTop.Controls.Add(this.labelBaslik);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(950, 70);
            this.panelTop.TabIndex = 0;
            // 
            // labelArama
            // 
            this.labelArama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArama.AutoSize = true;
            this.labelArama.ForeColor = System.Drawing.Color.LightGray;
            this.labelArama.Location = new System.Drawing.Point(540, 27);
            this.labelArama.Name = "labelArama";
            this.labelArama.Size = new System.Drawing.Size(61, 17);
            this.labelArama.TabIndex = 2;
            this.labelArama.Text = "Hızlı Ara:";
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslik.ForeColor = System.Drawing.Color.White;
            this.labelBaslik.Location = new System.Drawing.Point(20, 20);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(185, 30);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "Emanet Kayıtları";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelLeft.Controls.Add(this.btnTemizle);
            this.panelLeft.Controls.Add(this.btnTeslimAl);
            this.panelLeft.Controls.Add(this.btnEmanetVer);
            this.panelLeft.Controls.Add(this.labelDurumNotu);
            this.panelLeft.Controls.Add(this.txtDurumNotu);
            this.panelLeft.Controls.Add(this.labelTeslimTarihi);
            this.panelLeft.Controls.Add(this.dtpTeslimTarihi);
            this.panelLeft.Controls.Add(this.labelUye);
            this.panelLeft.Controls.Add(this.cmbUyeler);
            this.panelLeft.Controls.Add(this.labelKitap);
            this.panelLeft.Controls.Add(this.cmbKitaplar);
            this.panelLeft.Controls.Add(this.labelId);
            this.panelLeft.Controls.Add(this.txtId);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 530);
            this.panelLeft.TabIndex = 1;
            // 
            // labelDurumNotu
            // 
            this.labelDurumNotu.AutoSize = true;
            this.labelDurumNotu.ForeColor = System.Drawing.Color.LightGray;
            this.labelDurumNotu.Location = new System.Drawing.Point(16, 258);
            this.labelDurumNotu.Name = "labelDurumNotu";
            this.labelDurumNotu.Size = new System.Drawing.Size(84, 17);
            this.labelDurumNotu.TabIndex = 8;
            this.labelDurumNotu.Text = "Durum Notu:";
            // 
            // labelTeslimTarihi
            // 
            this.labelTeslimTarihi.AutoSize = true;
            this.labelTeslimTarihi.ForeColor = System.Drawing.Color.LightGray;
            this.labelTeslimTarihi.Location = new System.Drawing.Point(16, 198);
            this.labelTeslimTarihi.Name = "labelTeslimTarihi";
            this.labelTeslimTarihi.Size = new System.Drawing.Size(81, 17);
            this.labelTeslimTarihi.TabIndex = 6;
            this.labelTeslimTarihi.Text = "Teslim Tarihi:";
            // 
            // labelUye
            // 
            this.labelUye.AutoSize = true;
            this.labelUye.ForeColor = System.Drawing.Color.LightGray;
            this.labelUye.Location = new System.Drawing.Point(16, 138);
            this.labelUye.Name = "labelUye";
            this.labelUye.Size = new System.Drawing.Size(33, 17);
            this.labelUye.TabIndex = 4;
            this.labelUye.Text = "Üye:";
            // 
            // labelKitap
            // 
            this.labelKitap.AutoSize = true;
            this.labelKitap.ForeColor = System.Drawing.Color.LightGray;
            this.labelKitap.Location = new System.Drawing.Point(16, 78);
            this.labelKitap.Name = "labelKitap";
            this.labelKitap.Size = new System.Drawing.Size(41, 17);
            this.labelKitap.TabIndex = 2;
            this.labelKitap.Text = "Kitap:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.Color.LightGray;
            this.labelId.Location = new System.Drawing.Point(16, 18);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(71, 17);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Emanet ID:";
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.dgvListe);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(300, 70);
            this.panelFill.Name = "panelFill";
            this.panelFill.Padding = new System.Windows.Forms.Padding(10);
            this.panelFill.Size = new System.Drawing.Size(650, 530);
            this.panelFill.TabIndex = 2;
            // 
            // FrmEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmanet";
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.FrmEmanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.ComboBox cmbKitaplar;
        private System.Windows.Forms.ComboBox cmbUyeler;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDurumNotu;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label labelArama;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelDurumNotu;
        private System.Windows.Forms.Label labelTeslimTarihi;
        private System.Windows.Forms.Label labelUye;
        private System.Windows.Forms.Label labelKitap;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Panel panelFill;
    }
}
