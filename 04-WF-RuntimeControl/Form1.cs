namespace _04_WF_RuntimeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniFormEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SayfaForm sayfaForm = new SayfaForm();
            sayfaForm.MdiParent = this; // MdiParent property'sine Form1 veriyorum.
            sayfaForm.Show();

            yeniNotEkleToolStripMenuItem.Enabled = true;
        }

        private void yeniNotEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotForm notForm = new NotForm();
            notForm.Owner = this;  // senin sahibin Form1 nesnesi arkadaþým.
            notForm.ShowDialog(); // sadece 1 kere açýyor. arka tarafa ulaþamýyoruz.
        }
    }
}
