namespace Son_of_Duo
{
    partial class FillBlanks
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
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            lblMessage = new Label();
            btnSubmit = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(214, 122);
            lblQuestion.Margin = new Padding(2, 0, 2, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(561, 90);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question appears here";
            lblQuestion.Click += label1_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.Location = new Point(207, 279);
            txtAnswer.Margin = new Padding(2);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(534, 39);
            txtAnswer.TabIndex = 1;
            txtAnswer.KeyDown += txtAnswer_KeyDown;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(115, 489);
            lblMessage.Margin = new Padding(2, 0, 2, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(738, 72);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Feedback appears heressss\r\n\r\n\r\n\r\n";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.BurlyWood;
            btnSubmit.Location = new Point(344, 579);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(272, 93);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBack.Location = new Point(11, 11);
            BtnBack.Margin = new Padding(2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(83, 30);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += button1_Click;
            // 
            // FillBlanks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(978, 788);
            ControlBox = false;
            Controls.Add(BtnBack);
            Controls.Add(btnSubmit);
            Controls.Add(lblMessage);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2);
            Name = "FillBlanks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtAnswer;
        private Label lblMessage;
        private Button btnSubmit;
        private Button BtnBack;
    }
}