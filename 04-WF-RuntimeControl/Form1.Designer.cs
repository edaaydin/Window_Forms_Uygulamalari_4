namespace _04_WF_RuntimeControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dosyaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            formİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yeniFormEkleToolStripMenuItem = new ToolStripMenuItem();
            yeniNotEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaİşlemleriToolStripMenuItem, formİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { açToolStripMenuItem, kaydetToolStripMenuItem, farklıKaydetToolStripMenuItem });
            dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            dosyaİşlemleriToolStripMenuItem.Size = new Size(148, 29);
            dosyaİşlemleriToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(213, 34);
            açToolStripMenuItem.Text = "Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.Size = new Size(213, 34);
            kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            farklıKaydetToolStripMenuItem.Size = new Size(213, 34);
            farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // formİşlemleriToolStripMenuItem
            // 
            formİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniFormEkleToolStripMenuItem, yeniNotEkleToolStripMenuItem });
            formİşlemleriToolStripMenuItem.Name = "formİşlemleriToolStripMenuItem";
            formİşlemleriToolStripMenuItem.Size = new Size(140, 29);
            formİşlemleriToolStripMenuItem.Text = "Form İşlemleri";
            // 
            // yeniFormEkleToolStripMenuItem
            // 
            yeniFormEkleToolStripMenuItem.Name = "yeniFormEkleToolStripMenuItem";
            yeniFormEkleToolStripMenuItem.Size = new Size(270, 34);
            yeniFormEkleToolStripMenuItem.Text = "Yeni Form Ekle";
            yeniFormEkleToolStripMenuItem.Click += yeniFormEkleToolStripMenuItem_Click;
            // 
            // yeniNotEkleToolStripMenuItem
            // 
            yeniNotEkleToolStripMenuItem.Enabled = false;
            yeniNotEkleToolStripMenuItem.Name = "yeniNotEkleToolStripMenuItem";
            yeniNotEkleToolStripMenuItem.Size = new Size(270, 34);
            yeniNotEkleToolStripMenuItem.Text = "Yeni Not Ekle";
            yeniNotEkleToolStripMenuItem.Click += yeniNotEkleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ToolStripMenuItem formİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yeniFormEkleToolStripMenuItem;
        private ToolStripMenuItem yeniNotEkleToolStripMenuItem;
    }
}
