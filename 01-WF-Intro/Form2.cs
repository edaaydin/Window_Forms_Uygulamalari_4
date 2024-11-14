using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WF_Intro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKullaniciGirisi_Click(object sender, EventArgs e)
        {
            lblBilgi.Text = string.Empty;
            lblBilgi.Visible = false;
            //MessageBox.Show("Merhaba");

            //MessageBox.Show(txtKullaniciAdi.Text);
            //MessageBox.Show(txtSifre.Text);

            if (txtKullaniciAdi.Text == "")
            {
                lblBilgi.Visible = true;
                lblBilgi.Text = "Kullanıcı Adı Boş Geçilemez!";
            }
            else if (txtSifre.Text == "")
            {
                lblBilgi.Visible = true;
                lblBilgi.Text = "Kullanıcı Şifresi Boş Geçilemez!";
            }
            else
            {
                bool result = Login(txtKullaniciAdi.Text, txtSifre.Text);

                if(result)
                {
                    FrmKullaniciKaydet frmKullaniciKaydet = new FrmKullaniciKaydet(); // FrmKullaniciKaydet tipinde bir form nesnesi oluşturuyoruz.
                    frmKullaniciKaydet.Show(); // oluşturulan nesneyi ekranda görüntülüyoruz.

                    this.Hide(); // Bulunulan formun gizlenmesini sağlar.
                }
            }
        }

        private bool Login(string kullaniciAdi, string kullaniciSifre)
        {
            if (kullaniciAdi == "admin" && kullaniciSifre == "123")
            {
                return true;
            }

            lblBilgi.Visible = true;
            lblBilgi.Text = "Kullanıcı Adı veya Şifre Hatalı!";

            return false;
        }
    }
}
