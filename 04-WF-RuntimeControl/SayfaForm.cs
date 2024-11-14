namespace _04_WF_RuntimeControl
{
    public partial class SayfaForm : Form
    {
        public SayfaForm()
        {
            InitializeComponent();
        }

        public void YeniMaddeEkle(string mesaj)
        {
            Label yeniNot = new Label();
            yeniNot.AutoSize = true;
            yeniNot.Text = mesaj;
            yeniNot.BorderStyle = BorderStyle.FixedSingle;

            yeniNot.MouseDown += YeniNot_MouseDown;
            yeniNot.Top = EklenecegiYer(pnlAlinacaklar);
            pnlAlinacaklar.Controls.Add(yeniNot);
        }

        private int EklenecegiYer(Panel pnlAlinacaklar)
        {
            int toplam = 25;
            foreach (Control item in pnlAlinacaklar.Controls)
            {
                toplam += item.Height;
            }

            return toplam;
        }

        private void YeniNot_MouseDown(object? sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void pnlAlinacaklar_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = (Label)e.Data.GetData(typeof(Label));
            lbl.Top = EklenecegiYer((Panel)sender);
            ((Panel)lbl.Parent).Controls.Remove(lbl);
            ((Panel)sender).Controls.Add(lbl);
        }

        private void pnlAlinacaklar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pnlAlinanlar_DragEnter(object sender, DragEventArgs e)
        {
            Label lbl = (Label)e.Data.GetData(typeof(Label));
            lbl.Top = EklenecegiYer((Panel)sender);
            ((Panel)sender).Controls.Add(lbl);
        }
    }
}
