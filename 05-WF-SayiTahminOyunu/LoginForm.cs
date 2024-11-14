using System.Xml.Linq;

namespace _05_WF_SayiTahminOyunu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string _name;  // field tanımlama

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            _name = txtKullanici.Text;  // field'a değer atıyorum.
            if(_name != null)
                this.Hide();
        }

        public bool GetName(out string name)
        {
            name = _name; // Field değerini değişkene atıyorum.
            return _name != null && _name != ""; // Boş değilse true döner.
        }
    }
}
