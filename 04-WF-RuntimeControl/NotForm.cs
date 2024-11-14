namespace _04_WF_RuntimeControl
{
    public partial class NotForm : Form
    {
        public NotForm()
        {
            InitializeComponent();
        }

        private void NotForm_Load(object sender, EventArgs e)
        {

        }

        public Form1 anaForm;
        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            anaForm = (Form1)this.Owner;  // Yeni not eklendiğinde benim sahibimi bulmam gerekiyor.
            // Form1 'e cast ettim.

            ((SayfaForm)(anaForm.ActiveMdiChild)).YeniMaddeEkle(txtNot.Text);
        }
    }
}
