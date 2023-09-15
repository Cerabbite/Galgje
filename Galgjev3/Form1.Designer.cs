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
            popup_panel = new Panel();
            lbl_word_was_txt = new Label();
            lbl_word_was = new Label();
            btn_restart = new Button();
            lbl_game_state = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)img_galgje).BeginInit();
            popup_panel.SuspendLayout();
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
            // popup_panel
            // 
            popup_panel.BackColor = SystemColors.ActiveBorder;
            popup_panel.Controls.Add(lbl_word_was_txt);
            popup_panel.Controls.Add(lbl_word_was);
            popup_panel.Controls.Add(btn_restart);
            popup_panel.Controls.Add(lbl_game_state);
            popup_panel.Controls.Add(label2);
            popup_panel.Location = new Point(147, 30);
            popup_panel.Name = "popup_panel";
            popup_panel.Size = new Size(489, 372);
            popup_panel.TabIndex = 4;
            popup_panel.Paint += game_over_panel_Paint;
            // 
            // lbl_word_was_txt
            // 
            lbl_word_was_txt.AutoSize = true;
            lbl_word_was_txt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_word_was_txt.Location = new Point(131, 136);
            lbl_word_was_txt.Name = "lbl_word_was_txt";
            lbl_word_was_txt.Size = new Size(109, 30);
            lbl_word_was_txt.TabIndex = 4;
            lbl_word_was_txt.Text = "Word was:";
            lbl_word_was_txt.Click += lbl_word_was_txt_Click;
            // 
            // lbl_word_was
            // 
            lbl_word_was.AutoSize = true;
            lbl_word_was.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_word_was.Location = new Point(246, 136);
            lbl_word_was.Name = "lbl_word_was";
            lbl_word_was.Size = new Size(68, 30);
            lbl_word_was.TabIndex = 3;
            lbl_word_was.Text = "label3";
            lbl_word_was.Click += lbl_word_was_Click;
            // 
            // btn_restart
            // 
            btn_restart.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_restart.Location = new Point(161, 289);
            btn_restart.Name = "btn_restart";
            btn_restart.Size = new Size(195, 63);
            btn_restart.TabIndex = 2;
            btn_restart.Text = "Restart";
            btn_restart.UseVisualStyleBackColor = true;
            btn_restart.Click += btn_restart_Click;
            // 
            // lbl_game_state
            // 
            lbl_game_state.AutoSize = true;
            lbl_game_state.Font = new Font("Segoe UI", 68.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_game_state.Location = new Point(-13, -3);
            lbl_game_state.Name = "lbl_game_state";
            lbl_game_state.Size = new Size(523, 120);
            lbl_game_state.TabIndex = 1;
            lbl_game_state.Text = "Game Over";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(popup_panel);
            Controls.Add(img_galgje);
            Controls.Add(lbl_output);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)img_galgje).EndInit();
            popup_panel.ResumeLayout(false);
            popup_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label lbl_output;
        private PictureBox img_galgje;
        private Panel popup_panel;
        private Label label2;
        private Label lbl_game_state;
        private Button btn_restart;
        private Label lbl_word_was;
        private Label lbl_word_was_txt;
    }
}