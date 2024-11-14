namespace _03_WF_DinamikButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // btnYeniButonUret ismindeki Buton tipindeki nesnenin Click event'ine t�klad���mda bir metot tetikleniyor. btnYeniButonUret Butonuna Click'lendi�inde �al��t�r�lan metot btnYeniButonUret_Click. 

        int sayac = 1; // global tan�mlama field
        private void btnYeniButonUret_Click(object sender, EventArgs e)
        {
            //int sayac = 1; // local variable
            // Yap�lacak i�ler buraya yaz�l�r.
            //MessageBox.Show("Selam Sana Ey G�zel �nsan!");

            //new Button(); // Button s�nf�ndan bir nesne �retiyorum.
            // Button s�n�f�ndan bir nesne �retmek i�in new keyword� ile birlikte s�n�f�n bir constructor metodunu �a��r�yoruz.

            //new Console(); // static s�n�flar�n instance'� ��kar�lamaz.

            //new MarshalByRefObject(); // Abstract s�n�flar�n ya da interface'lerin instance'� olu�turulamaz.

            //new IList<int>(); // Abstract s�n�flar�n ya da interface'lerin instance'� olu�turulamaz.

            Button btn = new Button(); // bir nesne olu�turabilmek i�in o s�n�f�n constructer'�n� �a��rmak gerekiyor.

            btn.Width = btn.Height = 50;

            btn.Text = sayac.ToString();
            sayac++;

            Random random = new Random();

            btn.Location = new Point(random.Next(0, ClientSize.Width - btn.Width), random.Next(0, ClientSize.Height - btn.Height));

            btn.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            // R    G   B
            // 255  0   0
            // 0   255  0
            // 0    0  255

            btn.Click += Btn_Click; // btn nesnesinin Click event'ine Metot ba�lad�k.

            btn.MouseMove += Btn_MouseMove;

            btn.MouseEnter += Btn_MouseEnter;
                
            this.Controls.Add(btn);
        }

        private void Btn_MouseEnter(object? sender, EventArgs e)
        {
            // butonu bul.
            // butonun lokasyonunu de�i�tir.
        }

        private void Btn_MouseMove(object? sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            (sender as Button).BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            MessageBox.Show($"Ben {btn.Text}. butonum");
        }
    }
}
