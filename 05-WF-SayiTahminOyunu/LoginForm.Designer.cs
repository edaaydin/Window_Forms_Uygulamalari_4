namespace _05_WF_SayiTahminOyunu
{
    partial class LoginForm
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
            txtKullanici = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(99, 34);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.PlaceholderText = "Kullanıcı Adı";
            txtKullanici.Size = new Size(211, 31);
            txtKullanici.TabIndex = 0;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(95, 103);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(215, 40);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 204);
            Controls.Add(btnGirisYap);
            Controls.Add(txtKullanici);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullanici;
        private Button btnGirisYap;
    }
}