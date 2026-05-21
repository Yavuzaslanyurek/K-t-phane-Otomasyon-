namespace KutuphaneOtomasyonu.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKitapIslemleri = new System.Windows.Forms.Button();
            this.btnUyeIslemleri = new System.Windows.Forms.Button();
            this.btnEmanetIslemleri = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.pnlKitap = new System.Windows.Forms.Panel();
            this.lblToplamKitap = new System.Windows.Forms.Label();
            this.lblTitleKitap = new System.Windows.Forms.Label();
            this.pnlBantKitap = new System.Windows.Forms.Panel();
            this.pnlUye = new System.Windows.Forms.Panel();
            this.lblToplamUye = new System.Windows.Forms.Label();
            this.lblTitleUye = new System.Windows.Forms.Label();
            this.pnlBantUye = new System.Windows.Forms.Panel();
            this.pnlEmanet = new System.Windows.Forms.Panel();
            this.lblToplamEmanet = new System.Windows.Forms.Label();
            this.lblTitleEmanet = new System.Windows.Forms.Label();
            this.pnlBantEmanet = new System.Windows.Forms.Panel();
            this.pnlAktifEmanet = new System.Windows.Forms.Panel();
            this.lblAktifEmanet = new System.Windows.Forms.Label();
            this.lblTitleAktif = new System.Windows.Forms.Label();
            this.pnlBantAktif = new System.Windows.Forms.Panel();
            this.pnlKitap.SuspendLayout();
            this.pnlUye.SuspendLayout();
            this.pnlEmanet.SuspendLayout();
            this.pnlAktifEmanet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblBaslik.Location = new System.Drawing.Point(45, 40);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(515, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "DASHBOARD (KONTROL PANELİ)";
            // 
            // btnKitapIslemleri
            // 
            this.btnKitapIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnKitapIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapIslemleri.FlatAppearance.BorderSize = 0;
            this.btnKitapIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitapIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnKitapIslemleri.Location = new System.Drawing.Point(50, 110);
            this.btnKitapIslemleri.Name = "btnKitapIslemleri";
            this.btnKitapIslemleri.Size = new System.Drawing.Size(150, 45);
            this.btnKitapIslemleri.TabIndex = 1;
            this.btnKitapIslemleri.Text = "📚 Kitap İşlemleri";
            this.btnKitapIslemleri.UseVisualStyleBackColor = false;
            this.btnKitapIslemleri.Click += new System.EventHandler(this.BtnKitapIslemleri_Click);
            // 
            // btnUyeIslemleri
            // 
            this.btnUyeIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUyeIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeIslemleri.FlatAppearance.BorderSize = 0;
            this.btnUyeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUyeIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnUyeIslemleri.Location = new System.Drawing.Point(220, 110);
            this.btnUyeIslemleri.Name = "btnUyeIslemleri";
            this.btnUyeIslemleri.Size = new System.Drawing.Size(150, 45);
            this.btnUyeIslemleri.TabIndex = 2;
            this.btnUyeIslemleri.Text = "👥 Üye İşlemleri";
            this.btnUyeIslemleri.UseVisualStyleBackColor = false;
            this.btnUyeIslemleri.Click += new System.EventHandler(this.BtnUyeIslemleri_Click);
            // 
            // btnEmanetIslemleri
            // 
            this.btnEmanetIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnEmanetIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetIslemleri.FlatAppearance.BorderSize = 0;
            this.btnEmanetIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmanetIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnEmanetIslemleri.Location = new System.Drawing.Point(390, 110);
            this.btnEmanetIslemleri.Name = "btnEmanetIslemleri";
            this.btnEmanetIslemleri.Size = new System.Drawing.Size(150, 45);
            this.btnEmanetIslemleri.TabIndex = 3;
            this.btnEmanetIslemleri.Text = "🔄 Emanet İşlemi";
            this.btnEmanetIslemleri.UseVisualStyleBackColor = false;
            this.btnEmanetIslemleri.Click += new System.EventHandler(this.BtnEmanetIslemleri_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(560, 110);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(150, 45);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "⟳ Verileri Güncelle";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.BtnYenile_Click);
            // 
            // pnlKitap
            // 
            this.pnlKitap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pnlKitap.Controls.Add(this.lblToplamKitap);
            this.pnlKitap.Controls.Add(this.lblTitleKitap);
            this.pnlKitap.Controls.Add(this.pnlBantKitap);
            this.pnlKitap.Location = new System.Drawing.Point(50, 190);
            this.pnlKitap.Name = "pnlKitap";
            this.pnlKitap.Size = new System.Drawing.Size(210, 140);
            this.pnlKitap.TabIndex = 5;
            // 
            // lblToplamKitap
            // 
            this.lblToplamKitap.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamKitap.ForeColor = System.Drawing.Color.White;
            this.lblToplamKitap.Location = new System.Drawing.Point(10, 55);
            this.lblToplamKitap.Name = "lblToplamKitap";
            this.lblToplamKitap.Size = new System.Drawing.Size(190, 60);
            this.lblToplamKitap.TabIndex = 2;
            this.lblToplamKitap.Text = "0";
            this.lblToplamKitap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleKitap
            // 
            this.lblTitleKitap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleKitap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTitleKitap.Location = new System.Drawing.Point(10, 20);
            this.lblTitleKitap.Name = "lblTitleKitap";
            this.lblTitleKitap.Size = new System.Drawing.Size(190, 25);
            this.lblTitleKitap.TabIndex = 1;
            this.lblTitleKitap.Text = "Toplam Kitap";
            this.lblTitleKitap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBantKitap
            // 
            this.pnlBantKitap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlBantKitap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBantKitap.Location = new System.Drawing.Point(0, 0);
            this.pnlBantKitap.Name = "pnlBantKitap";
            this.pnlBantKitap.Size = new System.Drawing.Size(210, 6);
            this.pnlBantKitap.TabIndex = 0;
            // 
            // pnlUye
            // 
            this.pnlUye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pnlUye.Controls.Add(this.lblToplamUye);
            this.pnlUye.Controls.Add(this.lblTitleUye);
            this.pnlUye.Controls.Add(this.pnlBantUye);
            this.pnlUye.Location = new System.Drawing.Point(280, 190);
            this.pnlUye.Name = "pnlUye";
            this.pnlUye.Size = new System.Drawing.Size(210, 140);
            this.pnlUye.TabIndex = 6;
            // 
            // lblToplamUye
            // 
            this.lblToplamUye.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamUye.ForeColor = System.Drawing.Color.White;
            this.lblToplamUye.Location = new System.Drawing.Point(10, 55);
            this.lblToplamUye.Name = "lblToplamUye";
            this.lblToplamUye.Size = new System.Drawing.Size(190, 60);
            this.lblToplamUye.TabIndex = 2;
            this.lblToplamUye.Text = "0";
            this.lblToplamUye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleUye
            // 
            this.lblTitleUye.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleUye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTitleUye.Location = new System.Drawing.Point(10, 20);
            this.lblTitleUye.Name = "lblTitleUye";
            this.lblTitleUye.Size = new System.Drawing.Size(190, 25);
            this.lblTitleUye.TabIndex = 1;
            this.lblTitleUye.Text = "Toplam Üye";
            this.lblTitleUye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBantUye
            // 
            this.pnlBantUye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlBantUye.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBantUye.Location = new System.Drawing.Point(0, 0);
            this.pnlBantUye.Name = "pnlBantUye";
            this.pnlBantUye.Size = new System.Drawing.Size(210, 6);
            this.pnlBantUye.TabIndex = 0;
            // 
            // pnlEmanet
            // 
            this.pnlEmanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pnlEmanet.Controls.Add(this.lblToplamEmanet);
            this.pnlEmanet.Controls.Add(this.lblTitleEmanet);
            this.pnlEmanet.Controls.Add(this.pnlBantEmanet);
            this.pnlEmanet.Location = new System.Drawing.Point(510, 190);
            this.pnlEmanet.Name = "pnlEmanet";
            this.pnlEmanet.Size = new System.Drawing.Size(210, 140);
            this.pnlEmanet.TabIndex = 7;
            // 
            // lblToplamEmanet
            // 
            this.lblToplamEmanet.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamEmanet.ForeColor = System.Drawing.Color.White;
            this.lblToplamEmanet.Location = new System.Drawing.Point(10, 55);
            this.lblToplamEmanet.Name = "lblToplamEmanet";
            this.lblToplamEmanet.Size = new System.Drawing.Size(190, 60);
            this.lblToplamEmanet.TabIndex = 2;
            this.lblToplamEmanet.Text = "0";
            this.lblToplamEmanet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleEmanet
            // 
            this.lblTitleEmanet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleEmanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTitleEmanet.Location = new System.Drawing.Point(10, 20);
            this.lblTitleEmanet.Name = "lblTitleEmanet";
            this.lblTitleEmanet.Size = new System.Drawing.Size(190, 25);
            this.lblTitleEmanet.TabIndex = 1;
            this.lblTitleEmanet.Text = "Tüm İşlemler";
            this.lblTitleEmanet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBantEmanet
            // 
            this.pnlBantEmanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnlBantEmanet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBantEmanet.Location = new System.Drawing.Point(0, 0);
            this.pnlBantEmanet.Name = "pnlBantEmanet";
            this.pnlBantEmanet.Size = new System.Drawing.Size(210, 6);
            this.pnlBantEmanet.TabIndex = 0;
            // 
            // pnlAktifEmanet
            // 
            this.pnlAktifEmanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pnlAktifEmanet.Controls.Add(this.lblAktifEmanet);
            this.pnlAktifEmanet.Controls.Add(this.lblTitleAktif);
            this.pnlAktifEmanet.Controls.Add(this.pnlBantAktif);
            this.pnlAktifEmanet.Location = new System.Drawing.Point(740, 190);
            this.pnlAktifEmanet.Name = "pnlAktifEmanet";
            this.pnlAktifEmanet.Size = new System.Drawing.Size(210, 140);
            this.pnlAktifEmanet.TabIndex = 8;
            // 
            // lblAktifEmanet
            // 
            this.lblAktifEmanet.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAktifEmanet.ForeColor = System.Drawing.Color.White;
            this.lblAktifEmanet.Location = new System.Drawing.Point(10, 55);
            this.lblAktifEmanet.Name = "lblAktifEmanet";
            this.lblAktifEmanet.Size = new System.Drawing.Size(190, 60);
            this.lblAktifEmanet.TabIndex = 2;
            this.lblAktifEmanet.Text = "0";
            this.lblAktifEmanet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleAktif
            // 
            this.lblTitleAktif.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleAktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTitleAktif.Location = new System.Drawing.Point(10, 20);
            this.lblTitleAktif.Name = "lblTitleAktif";
            this.lblTitleAktif.Size = new System.Drawing.Size(190, 25);
            this.lblTitleAktif.TabIndex = 1;
            this.lblTitleAktif.Text = "İade Bekleyenler";
            this.lblTitleAktif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBantAktif
            // 
            this.pnlBantAktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pnlBantAktif.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBantAktif.Location = new System.Drawing.Point(0, 0);
            this.pnlBantAktif.Name = "pnlBantAktif";
            this.pnlBantAktif.Size = new System.Drawing.Size(210, 6);
            this.pnlBantAktif.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlAktifEmanet);
            this.Controls.Add(this.pnlEmanet);
            this.Controls.Add(this.pnlUye);
            this.Controls.Add(this.pnlKitap);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnEmanetIslemleri);
            this.Controls.Add(this.btnUyeIslemleri);
            this.Controls.Add(this.btnKitapIslemleri);
            this.Controls.Add(this.lblBaslik);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Yönetim Paneli - Gece Modu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlKitap.ResumeLayout(false);
            this.pnlUye.ResumeLayout(false);
            this.pnlEmanet.ResumeLayout(false);
            this.pnlAktifEmanet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKitapIslemleri;
        private System.Windows.Forms.Button btnUyeIslemleri;
        private System.Windows.Forms.Button btnEmanetIslemleri;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Panel pnlKitap;
        private System.Windows.Forms.Panel pnlBantKitap;
        private System.Windows.Forms.Label lblTitleKitap;
        private System.Windows.Forms.Label lblToplamKitap;
        private System.Windows.Forms.Panel pnlUye;
        private System.Windows.Forms.Panel pnlBantUye;
        private System.Windows.Forms.Label lblTitleUye;
        private System.Windows.Forms.Label lblToplamUye;
        private System.Windows.Forms.Panel pnlEmanet;
        private System.Windows.Forms.Panel pnlBantEmanet;
        private System.Windows.Forms.Label lblTitleEmanet;
        private System.Windows.Forms.Label lblToplamEmanet;
        private System.Windows.Forms.Panel pnlAktifEmanet;
        private System.Windows.Forms.Panel pnlBantAktif;
        private System.Windows.Forms.Label lblTitleAktif;
        private System.Windows.Forms.Label lblAktifEmanet;
    }
}

