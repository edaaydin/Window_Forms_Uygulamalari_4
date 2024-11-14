namespace _04_WF_RuntimeControl
{
    partial class SayfaForm
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
            pnlAlinacaklar = new Panel();
            pnlAlinanlar = new Panel();
            label1 = new Label();
            pnlAlinacaklar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAlinacaklar
            // 
            pnlAlinacaklar.AllowDrop = true;
            pnlAlinacaklar.Controls.Add(label1);
            pnlAlinacaklar.Location = new Point(21, 31);
            pnlAlinacaklar.Name = "pnlAlinacaklar";
            pnlAlinacaklar.Size = new Size(332, 407);
            pnlAlinacaklar.TabIndex = 0;
            pnlAlinacaklar.DragDrop += pnlAlinacaklar_DragDrop;
            pnlAlinacaklar.DragOver += pnlAlinacaklar_DragOver;
            // 
            // pnlAlinanlar
            // 
            pnlAlinanlar.AllowDrop = true;
            pnlAlinanlar.Location = new Point(384, 31);
            pnlAlinanlar.Name = "pnlAlinanlar";
            pnlAlinanlar.Size = new Size(331, 407);
            pnlAlinanlar.TabIndex = 1;
            pnlAlinanlar.DragEnter += pnlAlinanlar_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // SayfaForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(pnlAlinanlar);
            Controls.Add(pnlAlinacaklar);
            Name = "SayfaForm";
            Text = "SayfaForm";
            pnlAlinacaklar.ResumeLayout(false);
            pnlAlinacaklar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAlinacaklar;
        private Panel pnlAlinanlar;
        private Label label1;
    }
}