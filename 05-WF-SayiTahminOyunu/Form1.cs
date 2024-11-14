namespace _05_WF_SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prgbarBilgi.Maximum = 60;
            btnTahminEt.Enabled = false;
            panel1.Visible = false;
        }

        int rastgeleSayi;

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();

            string userName;

            if (frm.GetName(out userName))
            {
                lblKullanici.Text = "Ho�geldin " + userName;
                panel1.Visible = true;

                lblBilgi.Text = "";
                lblMesaj.Text = "";

                Random random = new Random();
                rastgeleSayi = random.Next(1, 101);
                timer1.Start();  // Timer'� ba�lat�yoruz. Art�k her 1000ms / 1 sn'de bir Tick eventi tetiklenecek.
                prgbarBilgi.Value = prgbarBilgi.Maximum;
                btnTahminEt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kullanici Ad� Girmek Zorundas�n");
            }
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int sayi = 0;

            try
            {
                sayi = int.Parse(txtTahmin.Text); // Scope'ta tan�mlanan scope'ta kal�r!
            }
            catch (Exception)
            {
                MessageBox.Show("Say� girmeyi unttun dostum!");
            }

            if (sayi < rastgeleSayi)
                lblBilgi.Text = "K���k Bir Say� Girdin";
            else if (sayi > rastgeleSayi)
                lblBilgi.Text = "B�y�k Bir Say� Girdin";
            else
            {
                lblBilgi.Text = "Tebrikler Kazand�n";
                timer1.Stop();
                btnTahminEt.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgbarBilgi.Value--;

            btnTahminEt.Text = $"Tahmin Et ({prgbarBilgi.Value})";

            switch (prgbarBilgi.Value)
            {
                case 50: lblMesaj.Text = "Galiba Kaybedeceksin"; break;
                case 40: lblMesaj.Text = "Sen kaybetmek i�in yar���yorsun"; break;
                case 30: lblMesaj.Text = "S�ren doluyor art�k"; break;
                case 20: lblMesaj.Text = "Bil art�k"; break;
                case 10: lblMesaj.Text = "Son hakk�n!!"; break;
                case 0:
                    lblMesaj.Text = "Ne demi�tim ben sana?\nBir dahaki sefere art�k dostum!!";
                    timer1.Stop();
                    btnTahminEt.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
