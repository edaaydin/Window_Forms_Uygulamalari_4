namespace _01_WF_Intro
{
    partial class FrmKullaniciKaydet
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
            groupBox1 = new GroupBox();
            rdbtnKadin = new RadioButton();
            rdbtnErkek = new RadioButton();
            lblCinsiyet = new Label();
            nudYas = new NumericUpDown();
            lblYas = new Label();
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            groupBox2 = new GroupBox();
            txtAcikAdres = new TextBox();
            lblAcikAdres = new Label();
            btnKaydet = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtLiseAdi = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            cmbUniversiteler = new ComboBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            label3 = new Label();
            cmbxMaster = new ComboBox();
            chbxOnay = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbtnKadin);
            groupBox1.Controls.Add(rdbtnErkek);
            groupBox1.Controls.Add(lblCinsiyet);
            groupBox1.Controls.Add(nudYas);
            groupBox1.Controls.Add(lblYas);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kisisel Bilgiler";
            // 
            // rdbtnKadin
            // 
            rdbtnKadin.AutoSize = true;
            rdbtnKadin.Location = new Point(268, 115);
            rdbtnKadin.Name = "rdbtnKadin";
            rdbtnKadin.Size = new Size(81, 29);
            rdbtnKadin.TabIndex = 5;
            rdbtnKadin.Text = "Kadın";
            rdbtnKadin.UseVisualStyleBackColor = true;
            // 
            // rdbtnErkek
            // 
            rdbtnErkek.AutoSize = true;
            rdbtnErkek.Checked = true;
            rdbtnErkek.Location = new Point(121, 113);
            rdbtnErkek.Name = "rdbtnErkek";
            rdbtnErkek.Size = new Size(79, 29);
            rdbtnErkek.TabIndex = 5;
            rdbtnErkek.TabStop = true;
            rdbtnErkek.Text = "Erkek";
            rdbtnErkek.UseVisualStyleBackColor = true;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(20, 115);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(77, 25);
            lblCinsiyet.TabIndex = 4;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // nudYas
            // 
            nudYas.Location = new Point(121, 75);
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(138, 31);
            nudYas.TabIndex = 3;
            nudYas.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(23, 81);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(41, 25);
            lblYas.TabIndex = 2;
            lblYas.Text = "Yaş:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(13, 39);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(102, 25);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "Adı Soyadı:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(121, 39);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(279, 31);
            txtAdSoyad.TabIndex = 0;
            txtAdSoyad.Text = "zafer";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAcikAdres);
            groupBox2.Controls.Add(lblAcikAdres);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adres Bilgileri";
            // 
            // txtAcikAdres
            // 
            txtAcikAdres.Location = new Point(119, 33);
            txtAcikAdres.Multiline = true;
            txtAcikAdres.Name = "txtAcikAdres";
            txtAcikAdres.Size = new Size(277, 90);
            txtAcikAdres.TabIndex = 1;
            txtAcikAdres.Text = "Bakırköy";
            // 
            // lblAcikAdres
            // 
            lblAcikAdres.AutoSize = true;
            lblAcikAdres.Location = new Point(11, 36);
            lblAcikAdres.Name = "lblAcikAdres";
            lblAcikAdres.Size = new Size(100, 25);
            lblAcikAdres.TabIndex = 0;
            lblAcikAdres.Text = "Açık Adres:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(108, 524);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(263, 38);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(451, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 489);
            panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 454);
            listBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(19, 302);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(389, 129);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 255, 128);
            tabPage1.Controls.Add(txtLiseAdi);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(381, 91);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lise Bilgileri";
            // 
            // txtLiseAdi
            // 
            txtLiseAdi.Location = new Point(122, 31);
            txtLiseAdi.Name = "txtLiseAdi";
            txtLiseAdi.Size = new Size(226, 31);
            txtLiseAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Lise Adı:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Red;
            tabPage2.Controls.Add(cmbUniversiteler);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(381, 91);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Üniversite";
            // 
            // cmbUniversiteler
            // 
            cmbUniversiteler.FormattingEnabled = true;
            cmbUniversiteler.Items.AddRange(new object[] { "İstanbul Teknik Üniversitesi", "ODTÜ", "YTÜ", "Işık", "Nişantaşı", "Beykent", "Atlas" });
            cmbUniversiteler.Location = new Point(145, 32);
            cmbUniversiteler.Name = "cmbUniversiteler";
            cmbUniversiteler.Size = new Size(230, 33);
            cmbUniversiteler.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 35);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 0;
            label2.Text = "Üniversite Adı:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(cmbxMaster);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(381, 91);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Master";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 27);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 1;
            label3.Text = "Üniversite";
            // 
            // cmbxMaster
            // 
            cmbxMaster.FormattingEnabled = true;
            cmbxMaster.Location = new Point(132, 27);
            cmbxMaster.Name = "cmbxMaster";
            cmbxMaster.Size = new Size(233, 33);
            cmbxMaster.TabIndex = 0;
            // 
            // chbxOnay
            // 
            chbxOnay.AutoSize = true;
            chbxOnay.Location = new Point(25, 451);
            chbxOnay.Name = "chbxOnay";
            chbxOnay.Size = new Size(408, 29);
            chbxOnay.TabIndex = 5;
            chbxOnay.Text = "Yukarıdaki bilgilerin doğruluğunu onaylıyorum.";
            chbxOnay.UseVisualStyleBackColor = true;
            // 
            // FrmKullaniciKaydet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 578);
            Controls.Add(chbxOnay);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmKullaniciKaydet";
            Text = "FrmKullaniciKaydet";
            Load += FrmKullaniciKaydet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Label lblYas;
        private NumericUpDown nudYas;
        private RadioButton rdbtnKadin;
        private RadioButton rdbtnErkek;
        private Label lblCinsiyet;
        private GroupBox groupBox2;
        private TextBox txtAcikAdres;
        private Label lblAcikAdres;
        private Button btnKaydet;
        private Panel panel1;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtLiseAdi;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cmbUniversiteler;
        private Label label2;
        private CheckBox chbxOnay;
        private Label label3;
        private ComboBox cmbxMaster;
    }
}