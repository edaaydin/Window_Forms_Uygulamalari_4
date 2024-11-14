namespace _03_WF_DinamikButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // btnYeniButonUret ismindeki Buton tipindeki nesnenin Click event'ine týkladýðýmda bir metot tetikleniyor. btnYeniButonUret Butonuna Click'lendiðinde çalýþtýrýlan metot btnYeniButonUret_Click. 

        int sayac = 1; // global tanýmlama field
        private void btnYeniButonUret_Click(object sender, EventArgs e)
        {
            //int sayac = 1; // local variable
            // Yapýlacak iþler buraya yazýlýr.
            //MessageBox.Show("Selam Sana Ey Güzel Ýnsan!");

            //new Button(); // Button sýnfýndan bir nesne üretiyorum.
            // Button sýnýfýndan bir nesne üretmek için new keywordü ile birlikte sýnýfýn bir constructor metodunu çaðýrýyoruz.

            //new Console(); // static sýnýflarýn instance'ý çýkarýlamaz.

            //new MarshalByRefObject(); // Abstract sýnýflarýn ya da interface'lerin instance'ý oluþturulamaz.

            //new IList<int>(); // Abstract sýnýflarýn ya da interface'lerin instance'ý oluþturulamaz.

            Button btn = new Button(); // bir nesne oluþturabilmek için o sýnýfýn constructer'ýný çaðýrmak gerekiyor.

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

            btn.Click += Btn_Click; // btn nesnesinin Click event'ine Metot baðladýk.

            btn.MouseMove += Btn_MouseMove;

            btn.MouseEnter += Btn_MouseEnter;
                
            this.Controls.Add(btn);
        }

        private void Btn_MouseEnter(object? sender, EventArgs e)
        {
            // butonu bul.
            // butonun lokasyonunu deðiþtir.
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
