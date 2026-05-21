namespace KutuphaneOtomasyonu.UI
{
    partial class FrmUyeler
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
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
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
            this.lblTitle.Text = "Üyeler Yönetimi";
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
            this.lblArama.Text = "Üye Ara :";
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
            this.pnlLeft.Controls.Add(this.lblTcNo);
            this.pnlLeft.Controls.Add(this.txtTcNo);
            this.pnlLeft.Controls.Add(this.lblAdSoyad);
            this.pnlLeft.Controls.Add(this.txtAdSoyad);
            this.pnlLeft.Controls.Add(this.lblTelefon);
            this.pnlLeft.Controls.Add(this.txtTelefon);
            this.pnlLeft.Controls.Add(this.lblEposta);
            this.pnlLeft.Controls.Add(this.txtEposta);
            this.pnlLeft.Controls.Add(this.lblAdres);
            this.pnlLeft.Controls.Add(this.txtAdres);
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
            this.lblId.Size = new System.Drawing.Size(43, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Üye ID";
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
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTcNo.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(78, 15);
            this.lblTcNo.TabIndex = 2;
            this.lblTcNo.Text = "T.C. Kimlik No";
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtTcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTcNo.ForeColor = System.Drawing.Color.White;
            this.txtTcNo.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(260, 23);
            this.txtTcNo.TabIndex = 3;

            currentY += ySpacing;

            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdSoyad.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(89, 15);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Üye Adı Soyadı";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.ForeColor = System.Drawing.Color.White;
            this.txtAdSoyad.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(260, 23);
            this.txtAdSoyad.TabIndex = 5;

            currentY += ySpacing;

            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.ForeColor = System.Drawing.Color.LightGray;
            this.lblTelefon.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(45, 15);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.ForeColor = System.Drawing.Color.White;
            this.txtTelefon.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(260, 23);
            this.txtTelefon.TabIndex = 7;

            currentY += ySpacing;

            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.ForeColor = System.Drawing.Color.LightGray;
            this.lblEposta.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(47, 15);
            this.lblEposta.TabIndex = 8;
            this.lblEposta.Text = "E-posta";
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEposta.ForeColor = System.Drawing.Color.White;
            this.txtEposta.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(260, 23);
            this.txtEposta.TabIndex = 9;

            currentY += ySpacing;
            
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdres.Location = new System.Drawing.Point(leftMargin, currentY);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 15);
            this.lblAdres.TabIndex = 10;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.ForeColor = System.Drawing.Color.White;
            this.txtAdres.Location = new System.Drawing.Point(leftMargin, currentY + 20);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(260, 60);
            this.txtAdres.TabIndex = 11;

            currentY += 95;

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
            this.pnlFill.Controls.Add(this.dgvUyeler);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(320, 70);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFill.Size = new System.Drawing.Size(780, 610);
            this.pnlFill.TabIndex = 2;
            
            // 
            // dgvUyeler 
            // 
            this.dgvUyeler.AllowUserToAddRows = false;
            this.dgvUyeler.AllowUserToDeleteRows = false;
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dgvUyeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUyeler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUyeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUyeler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUyeler.EnableHeadersVisualStyles = false;
            this.dgvUyeler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvUyeler.Location = new System.Drawing.Point(10, 10);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUyeler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUyeler.RowHeadersVisible = false;
            this.dgvUyeler.RowTemplate.Height = 30;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(760, 590);
            this.dgvUyeler.TabIndex = 0;
            this.dgvUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellClick);
            
            // 
            // FrmUyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmUyeler";
            this.Text = "Üyeler Yönetimi";
            this.Load += new System.EventHandler(this.FrmUyeler_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
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
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        
        private System.Windows.Forms.DataGridView dgvUyeler;
    }
}
