namespace JapaneseQuiz
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
            NextButton = new Button();
            QuestionLabel = new Label();
            AnswerLabel = new Label();
            AnswerBox = new TextBox();
            ResultText = new Label();
            SuspendLayout();
            // 
            // NextButton
            // 
            NextButton.Location = new Point(391, 331);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(75, 23);
            NextButton.TabIndex = 1;
            NextButton.Text = "Start";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += Nextbutton_Click;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionLabel.Location = new Point(75, 86);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.RightToLeft = RightToLeft.No;
            QuestionLabel.Size = new Size(730, 21);
            QuestionLabel.TabIndex = 2;
            QuestionLabel.Text = "1. What is the pronounciation for the word  Kanji (Meaning)?";
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnswerLabel.Location = new Point(102, 157);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.RightToLeft = RightToLeft.No;
            AnswerLabel.Size = new Size(94, 21);
            AnswerLabel.TabIndex = 3;
            AnswerLabel.Text = "Answer:";
            AnswerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerBox
            // 
            AnswerBox.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerBox.Location = new Point(208, 157);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(100, 23);
            AnswerBox.TabIndex = 4;
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultText.Location = new Point(276, 266);
            ResultText.Name = "ResultText";
            ResultText.RightToLeft = RightToLeft.No;
            ResultText.Size = new Size(58, 21);
            ResultText.TabIndex = 5;
            ResultText.Text = "text";
            ResultText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 240, 255);
            ClientSize = new Size(881, 478);
            Controls.Add(ResultText);
            Controls.Add(AnswerBox);
            Controls.Add(AnswerLabel);
            Controls.Add(QuestionLabel);
            Controls.Add(NextButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button NextButton;
        private Label QuestionLabel;
        private Label AnswerLabel;
        private TextBox AnswerBox;
        private Label ResultText;
    }
}
