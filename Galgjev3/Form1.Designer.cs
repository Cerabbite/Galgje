namespace Galgjev3
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
            label1 = new Label();
            textBox1 = new TextBox();
            lbl_output = new Label();
            img_galgje = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_galgje).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 97);
            label1.Name = "label1";
            label1.Size = new Size(128, 50);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(361, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbl_output
            // 
            lbl_output.AutoSize = true;
            lbl_output.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_output.Location = new Point(361, 324);
            lbl_output.Name = "lbl_output";
            lbl_output.Size = new Size(65, 28);
            lbl_output.TabIndex = 2;
            lbl_output.Text = "label2";
            lbl_output.Click += lbl_output_Click;
            // 
            // img_galgje
            // 
            img_galgje.ImageLocation = "";
            img_galgje.Location = new Point(28, 72);
            img_galgje.Name = "img_galgje";
            img_galgje.Size = new Size(198, 280);
            img_galgje.SizeMode = PictureBoxSizeMode.StretchImage;
            img_galgje.TabIndex = 3;
            img_galgje.TabStop = false;
            img_galgje.Click += img_galgje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(img_galgje);
            Controls.Add(lbl_output);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)img_galgje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label lbl_output;
        private PictureBox img_galgje;
    }
}