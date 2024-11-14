namespace _05_WF_SayiTahminOyunu
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
            components = new System.ComponentModel.Container();
            btnOyunuBaslat = new Button();
            lblKullanici = new Label();
            panel1 = new Panel();
            lblMesaj = new Label();
            prgbarBilgi = new ProgressBar();
            lblBilgi = new Label();
            btnTahminEt = new Button();
            txtTahmin = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Location = new Point(34, 96);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(485, 67);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(33, 32);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(0, 25);
            lblKullanici.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMesaj);
            panel1.Controls.Add(prgbarBilgi);
            panel1.Controls.Add(lblBilgi);
            panel1.Controls.Add(btnTahminEt);
            panel1.Controls.Add(txtTahmin);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(37, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 427);
            panel1.TabIndex = 2;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(19, 279);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(62, 25);
            lblMesaj.TabIndex = 5;
            lblMesaj.Text = "Mesaj:";
            // 
            // prgbarBilgi
            // 
            prgbarBilgi.Location = new Point(21, 223);
            prgbarBilgi.Name = "prgbarBilgi";
            prgbarBilgi.Size = new Size(445, 34);
            prgbarBilgi.TabIndex = 4;
            prgbarBilgi.Value = 100;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.ForeColor = Color.IndianRed;
            lblBilgi.Location = new Point(11, 166);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(49, 25);
            lblBilgi.TabIndex = 3;
            lblBilgi.Text = "Bilgi:";
            // 
            // btnTahminEt
            // 
            btnTahminEt.Location = new Point(21, 91);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(445, 41);
            btnTahminEt.TabIndex = 2;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(273, 30);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(193, 31);
            txtTahmin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 30);
            label2.Name = "label2";
            label2.Size = new Size(257, 25);
            label2.TabIndex = 0;
            label2.Text = "1 - 100 arasında bir sayı giriniz:";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 654);
            Controls.Add(panel1);
            Controls.Add(lblKullanici);
            Controls.Add(btnOyunuBaslat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOyunuBaslat;
        private Label lblKullanici;
        private Panel panel1;
        private ProgressBar prgbarBilgi;
        private Label lblBilgi;
        private Button btnTahminEt;
        private TextBox txtTahmin;
        private Label label2;
        private Label lblMesaj;
        private System.Windows.Forms.Timer timer1;
    }
}
