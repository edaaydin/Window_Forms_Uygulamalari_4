namespace _03_WF_DinamikButon
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
            btnYeniButonUret = new Button();
            SuspendLayout();
            // 
            // btnYeniButonUret
            // 
            btnYeniButonUret.Location = new Point(275, 362);
            btnYeniButonUret.Name = "btnYeniButonUret";
            btnYeniButonUret.Size = new Size(188, 76);
            btnYeniButonUret.TabIndex = 0;
            btnYeniButonUret.Text = "Yeni Buton Üret";
            btnYeniButonUret.UseVisualStyleBackColor = true;
            btnYeniButonUret.Click += btnYeniButonUret_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYeniButonUret);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYeniButonUret;
    }
}
