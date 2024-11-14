namespace _01_WF_Intro
{
    partial class Form2
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
            lblAd = new Label();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnKullaniciGirisi = new Button();
            lblBilgi = new Label();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(77, 78);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(111, 25);
            lblAd.TabIndex = 0;
            lblAd.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(77, 130);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(119, 25);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Kullanıcı Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(225, 80);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtKullaniciAdi.Size = new Size(164, 31);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(225, 130);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Kullanıcı Şifre";
            txtSifre.Size = new Size(164, 31);
            txtSifre.TabIndex = 3;
            // 
            // btnKullaniciGirisi
            // 
            btnKullaniciGirisi.Location = new Point(226, 187);
            btnKullaniciGirisi.Name = "btnKullaniciGirisi";
            btnKullaniciGirisi.Size = new Size(163, 38);
            btnKullaniciGirisi.TabIndex = 4;
            btnKullaniciGirisi.Text = "Kullanıcı Girişi";
            btnKullaniciGirisi.UseVisualStyleBackColor = true;
            btnKullaniciGirisi.Click += btnKullaniciGirisi_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.ForeColor = Color.IndianRed;
            lblBilgi.Location = new Point(77, 248);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(0, 25);
            lblBilgi.TabIndex = 5;
            lblBilgi.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 311);
            Controls.Add(lblBilgi);
            Controls.Add(btnKullaniciGirisi);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(lblAd);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnKullaniciGirisi;
        private Label lblBilgi;
    }
}