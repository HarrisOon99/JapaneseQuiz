namespace JapaneseQuiz
{
    partial class QuizForm
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
            StartLabel = new Label();
            ScoreLabel = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // NextButton
            // 
            NextButton.Location = new Point(349, 328);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(75, 23);
            NextButton.TabIndex = 1;
            NextButton.Text = "Start";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            NextButton.KeyDown += EnterKey_Down;
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
            AnswerBox.BorderStyle = BorderStyle.None;
            AnswerBox.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerBox.ForeColor = Color.Black;
            AnswerBox.Location = new Point(202, 161);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(100, 16);
            AnswerBox.TabIndex = 4;
            AnswerBox.KeyDown += EnterKey_Down;
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultText.Location = new Point(276, 266);
            ResultText.Name = "ResultText";
            ResultText.RightToLeft = RightToLeft.No;
            ResultText.Size = new Size(82, 21);
            ResultText.TabIndex = 5;
            ResultText.Text = "Answer";
            ResultText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartLabel.Location = new Point(361, 190);
            StartLabel.Name = "StartLabel";
            StartLabel.RightToLeft = RightToLeft.No;
            StartLabel.Size = new Size(130, 21);
            StartLabel.TabIndex = 6;
            StartLabel.Text = "Start Quiz";
            StartLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreLabel.Location = new Point(102, 371);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.RightToLeft = RightToLeft.No;
            ScoreLabel.Size = new Size(58, 21);
            ScoreLabel.TabIndex = 8;
            ScoreLabel.Text = "Text";
            ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(430, 328);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 240, 255);
            ClientSize = new Size(881, 478);
            ControlBox = false;
            Controls.Add(ExitButton);
            Controls.Add(ScoreLabel);
            Controls.Add(StartLabel);
            Controls.Add(ResultText);
            Controls.Add(AnswerBox);
            Controls.Add(AnswerLabel);
            Controls.Add(QuestionLabel);
            Controls.Add(NextButton);
            Name = "QuizForm";
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
        private Label StartLabel;
        private Label ScoreLabel;
        private Button ExitButton;
    }
}
