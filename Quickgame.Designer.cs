namespace Son_of_Duo
{
    partial class Quickgame
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "< Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources._5cb78e957ff3656569c8cec0;
            pictureBox1.Location = new Point(-3, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 387);
            label1.Name = "label1";
            label1.Size = new Size(482, 87);
            label1.TabIndex = 4;
            label1.Text = "Hi , i think You Know my Name Already\r\n\r\nWhat is my name?\r\n";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(351, 494);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 36);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(351, 536);
            button2.Name = "button2";
            button2.Size = new Size(137, 43);
            button2.TabIndex = 6;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Showcard Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(351, 539);
            button3.Name = "button3";
            button3.Size = new Size(137, 40);
            button3.TabIndex = 8;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Font = new Font("Showcard Gothic", 10.8F);
            button5.Location = new Point(477, 505);
            button5.Name = "button5";
            button5.Size = new Size(210, 53);
            button5.TabIndex = 10;
            button5.Text = "Match Madness";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(477, 564);
            button6.Name = "button6";
            button6.Size = new Size(210, 49);
            button6.TabIndex = 11;
            button6.Text = "Fill the Blanks";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(351, 536);
            button7.Name = "button7";
            button7.Size = new Size(137, 43);
            button7.TabIndex = 12;
            button7.Text = "Submit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Quickgame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 788);
            ControlBox = false;
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Quickgame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quickgame";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;

        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}