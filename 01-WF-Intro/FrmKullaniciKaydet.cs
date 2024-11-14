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
    public partial class FrmKullaniciKaydet : Form
    {
        public FrmKullaniciKaydet()
        {
            InitializeComponent();            
        }

        private void MasterDoldur()
        {
            string[] universiteler = { "İTÜ", "YTÜ", "ODTÜ", "İSTÜ", "KATÜ" };

            cmbUniversiteler.Items.Clear();
            cmbxMaster.Items.Clear();

            cmbxMaster.Items.AddRange(universiteler);
            cmbUniversiteler.Items.AddRange(universiteler);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adi = txtAdSoyad.Text;
            string yas = nudYas.Value.ToString();
            string cinsiyet = rdbtnErkek.Checked ? "Erkek" : "Kadın";
            string adres = txtAcikAdres.Text;
            string liseAdi = txtLiseAdi.Text;
            
            string universiteAdi = (cmbUniversiteler.SelectedIndex != -1) ? cmbUniversiteler.SelectedItem.ToString() : "";

            string bilgi = $"Adı: {adi} Yaşı: {yas} Cinsiyeti: {cinsiyet} Adres: {adres} Lise Adı: {liseAdi} Üniversite Adı: {universiteAdi}";

            if (chbxOnay.Checked)
                listBox1.Items.Add(bilgi);
            else
                MessageBox.Show("Lütfen onaylayınız..");
        }

        private void FrmKullaniciKaydet_Load(object sender, EventArgs e)
        {
            MasterDoldur();
        }
    }
}
