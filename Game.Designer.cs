namespace Son_of_Duo
{
    partial class Game
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
            SuspendLayout();
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 788);
            ControlBox = false;
            Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            ResumeLayout(false);
        }

        #endregion
    }
}