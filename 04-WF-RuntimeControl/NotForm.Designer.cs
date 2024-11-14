namespace _04_WF_RuntimeControl
{
    partial class NotForm
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
            btnNotEkle = new Button();
            lblKalan = new Label();
            txtNot = new TextBox();
            lblNotYaziniz = new Label();
            SuspendLayout();
            // 
            // btnNotEkle
            // 
            btnNotEkle.Location = new Point(284, 229);
            btnNotEkle.Margin = new Padding(4, 5, 4, 5);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(107, 38);
            btnNotEkle.TabIndex = 7;
            btnNotEkle.Text = "Not Ekle";
            btnNotEkle.UseVisualStyleBackColor = true;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // lblKalan
            // 
            lblKalan.AutoSize = true;
            lblKalan.BorderStyle = BorderStyle.FixedSingle;
            lblKalan.ForeColor = Color.Red;
            lblKalan.Location = new Point(65, 236);
            lblKalan.Margin = new Padding(4, 0, 4, 0);
            lblKalan.Name = "lblKalan";
            lblKalan.Size = new Size(56, 27);
            lblKalan.TabIndex = 6;
            lblKalan.Text = "Kalan";
            // 
            // txtNot
            // 
            txtNot.Location = new Point(28, 47);
            txtNot.Margin = new Padding(4, 5, 4, 5);
            txtNot.Multiline = true;
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(403, 149);
            txtNot.TabIndex = 5;
            // 
            // lblNotYaziniz
            // 
            lblNotYaziniz.AutoSize = true;
            lblNotYaziniz.Location = new Point(22, 9);
            lblNotYaziniz.Margin = new Padding(4, 0, 4, 0);
            lblNotYaziniz.Name = "lblNotYaziniz";
            lblNotYaziniz.Size = new Size(102, 25);
            lblNotYaziniz.TabIndex = 4;
            lblNotYaziniz.Text = "Not Yazınız:";
            // 
            // NotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 285);
            Controls.Add(btnNotEkle);
            Controls.Add(lblKalan);
            Controls.Add(txtNot);
            Controls.Add(lblNotYaziniz);
            Name = "NotForm";
            Text = "NotForm";
            Load += NotForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNotEkle;
        private Label lblKalan;
        private TextBox txtNot;
        private Label lblNotYaziniz;
    }
}