namespace Son_of_Duo
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 7.8F);
            button1.Location = new Point(26, 13);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 0;
            button1.Text = "< Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 16.2F);
            button2.Location = new Point(26, 104);
            button2.Margin = new Padding(6, 4, 6, 4);
            button2.Name = "button2";
            button2.Size = new Size(309, 58);
            button2.TabIndex = 1;
            button2.Text = "Match Madness";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 16.2F);
            button3.Location = new Point(26, 170);
            button3.Margin = new Padding(6, 4, 6, 4);
            button3.Name = "button3";
            button3.Size = new Size(309, 53);
            button3.TabIndex = 2;
            button3.Text = "Fill In The Blanks";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1009, 112);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(487, 221);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(439, 481);
            label2.TabIndex = 4;
            label2.Text = "MATCH MADNESS IS A GAME WHERE THERE WILL BE 16 TILES AND PLAYER WILL HAVE TO MATCH THE CORRECT TILES BY THE READING THE WORDS ON THE TILES\"";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 293);
            pictureBox1.Margin = new Padding(6, 4, 6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // HowToPlay
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 788);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Stencil", 16.2F);
            Margin = new Padding(6, 4, 6, 4);
            Name = "HowToPlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Howtoplay";
            Load += Howtoplay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}