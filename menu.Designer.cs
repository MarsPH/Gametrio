namespace Son_of_Duo;

partial class menu
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.Transparent;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.ForeColor = Color.Black;
        button1.Location = new Point(450, 575);
        button1.Margin = new Padding(0);
        button1.Name = "button1";
        button1.Size = new Size(120, 49);
        button1.TabIndex = 0;
        button1.Text = "Exit";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.Transparent;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button2.Location = new Point(420, 207);
        button2.Name = "button2";
        button2.Size = new Size(174, 70);
        button2.TabIndex = 4;
        button2.Text = "Play Game";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.BackColor = Color.Transparent;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button3.Location = new Point(420, 296);
        button3.Name = "button3";
        button3.Size = new Size(174, 70);
        button3.TabIndex = 5;
        button3.Text = "Settings";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.BackColor = Color.Transparent;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button4.Location = new Point(420, 383);
        button4.Name = "button4";
        button4.Size = new Size(174, 61);
        button4.TabIndex = 6;
        button4.Text = "How to Play";
        button4.UseVisualStyleBackColor = false;
        button4.Click += button4_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(984, 787);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Ivory;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(982, 788);
        ControlBox = false;
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        DoubleBuffered = true;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Son of Duo";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private PictureBox pictureBox1;
}
