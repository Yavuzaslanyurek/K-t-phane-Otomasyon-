namespace KutuphaneOtomasyonu.UI
{
    partial class FrmKitaplar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.lblYayinYili = new System.Windows.Forms.Label();
            this.txtYayinYili = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.dgvListe = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblArama);
            this.pnlTop.Controls.Add(this.txtArama);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kitaplar Yönetimi";
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArama.ForeColor = System.Drawing.Color.LightGray;
            this.lblArama.Location = new System.Drawing.Point(400, 26);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(83, 19);
            this.lblArama.TabIndex = 1;
            this.lblArama.Text = "Kitap Ara :";
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArama.ForeColor = System.Drawing.Color.White;
            this.txtArama.Location = new System.Drawing.Point(490, 22);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(400, 27);
            this.txtArama.TabIndex = 2;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.pnlLeft.Controls.Add(this.lblId);
            this.pnlLeft.Controls.Add(this.txtId);
            this.pnlLeft.Controls.Add(this.lblIsbn);
            this.pnlLeft.Controls.Add(this.txtIsbn);
            this.pnlLeft.Controls.Add(this.lblKitapAdi);
            this.pnlLeft.Controls.Add(this.txtKitapAdi);
            this.pnlLeft.Controls.Add(this.lblYazar);
            this.pnlLeft.Controls.Add(this.txtYazar);
            this.pnlLeft.Controls.Add(this.lblYayinevi);
            this.pnlLeft.Controls.Add(this.txtYayinevi);
            this.pnlLeft.Controls.Add(this.lblSayfaSayisi);
            this.pnlLeft.Controls.Add(this.txtSayfaSayisi);
            this.pnlLeft.Controls.Add(this.lblYayinYili);
            this.pnlLeft.Controls.Add(this.txtYayinYili);
            this.pnlLeft.Controls.Add(this.lblStok);
            this.pnlLeft.Controls.Add(this.txtStok);
            this.pnlLeft.Controls.Add(this.btnKaydet);
            this.pnlLeft.Controls.Add(this.btnGuncelle);
            this.pnlLeft.Controls.Add(this.btnSil);
            this.pnlLeft.Controls.Add(this.btnTemizle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 70);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Size = new System.Drawing.Size(320, 610);
            this.pnlLeft.TabIndex = 1;

            int leftMargin = 20;
            int currentY = 20;
            int ySpacing = 60;
            
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.LightGray;
            this.lblId.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Kitap ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(260, 23);
            this.txtId.TabIndex = 1;
            
            currentY += ySpacing;
            
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.ForeColor = System.Drawing.Color.LightGray;
            this.lblIsbn.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(32, 15);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIsbn.ForeColor = System.Drawing.Color.White;
            this.txtIsbn.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(260, 23);
            this.txtIsbn.TabIndex = 3;

            currentY += ySpacing;

            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.ForeColor = System.Drawing.Color.LightGray;
            this.lblKitapAdi.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(55, 15);
            this.lblKitapAdi.TabIndex = 4;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapAdi.ForeColor = System.Drawing.Color.White;
            this.txtKitapAdi.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(260, 23);
            this.txtKitapAdi.TabIndex = 5;

            currentY += ySpacing;

            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.ForeColor = System.Drawing.Color.LightGray;
            this.lblYazar.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(34, 15);
            this.lblYazar.TabIndex = 6;
            this.lblYazar.Text = "Yazar";
            // 
            // txtYazar
            // 
            this.txtYazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtYazar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazar.ForeColor = System.Drawing.Color.White;
            this.txtYazar.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(260, 23);
            this.txtYazar.TabIndex = 7;

            currentY += ySpacing;

            // 
            // lblYayinevi
            // 
            this.lblYayinevi.AutoSize = true;
            this.lblYayinevi.ForeColor = System.Drawing.Color.LightGray;
            this.lblYayinevi.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblYayinevi.Name = "lblYayinevi";
            this.lblYayinevi.Size = new System.Drawing.Size(53, 15);
            this.lblYayinevi.TabIndex = 8;
            this.lblYayinevi.Text = "Yayın Evi";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtYayinevi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYayinevi.ForeColor = System.Drawing.Color.White;
            this.txtYayinevi.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(260, 23);
            this.txtYayinevi.TabIndex = 9;

            currentY += ySpacing;
            
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.ForeColor = System.Drawing.Color.LightGray;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(67, 15);
            this.lblSayfaSayisi.TabIndex = 10;
            this.lblSayfaSayisi.Text = "Sayfa Sayısı";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSayfaSayisi.ForeColor = System.Drawing.Color.White;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(260, 23);
            this.txtSayfaSayisi.TabIndex = 11;

            currentY += ySpacing;

            // 
            // lblYayinYili
            // 
            this.lblYayinYili.AutoSize = true;
            this.lblYayinYili.ForeColor = System.Drawing.Color.LightGray;
            this.lblYayinYili.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblYayinYili.Name = "lblYayinYili";
            this.lblYayinYili.Size = new System.Drawing.Size(55, 15);
            this.lblYayinYili.TabIndex = 12;
            this.lblYayinYili.Text = "Yayın Yılı";
            // 
            // txtYayinYili
            // 
            this.txtYayinYili.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtYayinYili.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYayinYili.ForeColor = System.Drawing.Color.White;
            this.txtYayinYili.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtYayinYili.Name = "txtYayinYili";
            this.txtYayinYili.Size = new System.Drawing.Size(260, 23);
            this.txtYayinYili.TabIndex = 13;

            currentY += ySpacing;

            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.ForeColor = System.Drawing.Color.LightGray;
            this.lblStok.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(65, 15);
            this.lblStok.TabIndex = 14;
            this.lblStok.Text = "Stok Adedi";
            // 
            // txtStok
            // 
            this.txtStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStok.ForeColor = System.Drawing.Color.White;
            this.txtStok.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(260, 23);
            this.txtStok.TabIndex = 15;

            currentY += ySpacing - 5;

            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(20, currentY);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(125, 35);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(155, currentY);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(125, 35);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // Both Save and Update use the same logic in Business/UI for now.
            this.btnGuncelle.Click += new System.EventHandler(this.btnKaydet_Click);

            currentY += 45;

            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(20, currentY);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 35);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(155, currentY);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(125, 35);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dgvListe);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(320, 70);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFill.Size = new System.Drawing.Size(780, 610);
            this.pnlFill.TabIndex = 2;
            
            // 
            // dgvListe (also matches requested dgvKitaplar function)
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.EnableHeadersVisualStyles = false;
            this.dgvListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvListe.Location = new System.Drawing.Point(10, 10);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListe.RowHeadersVisible = false;
            this.dgvListe.RowTemplate.Height = 30;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(760, 590);
            this.dgvListe.TabIndex = 0;
            this.dgvListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellClick);
            
            // 
            // FrmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmKitaplar";
            this.Text = "Kitaplar Yönetimi";
            this.Load += new System.EventHandler(this.FrmKitaplar_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlFill;
        
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label lblYayinevi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label lblYayinYili;
        private System.Windows.Forms.TextBox txtYayinYili;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        
        private System.Windows.Forms.DataGridView dgvListe;
    }
}
