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
            IntroLabel = new Label();
            ScoreLabel = new Label();
            ExitButton = new Button();
            IntroLabel2 = new Label();
            SuspendLayout();
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.FromArgb(255, 224, 192);
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("UD Digi Kyokasho NK-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            NextButton.Location = new Point(561, 408);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(75, 23);
            NextButton.TabIndex = 1;
            NextButton.Text = "Start Quiz";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            NextButton.KeyDown += EnterKey_Down;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.BackColor = Color.Transparent;
            QuestionLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionLabel.Location = new Point(248, 135);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.RightToLeft = RightToLeft.No;
            QuestionLabel.Size = new Size(738, 31);
            QuestionLabel.TabIndex = 2;
            QuestionLabel.Text = "1. What is the pronounciation for the word  Kanji (Meaning)?";
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.BackColor = Color.Transparent;
            AnswerLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            AnswerLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AnswerLabel.Location = new Point(248, 193);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.RightToLeft = RightToLeft.No;
            AnswerLabel.Size = new Size(84, 24);
            AnswerLabel.TabIndex = 3;
            AnswerLabel.Text = "Answer:";
            AnswerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerBox
            // 
            AnswerBox.BorderStyle = BorderStyle.None;
            AnswerBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnswerBox.ForeColor = Color.FromArgb(64, 64, 64);
            AnswerBox.Location = new Point(338, 192);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(100, 25);
            AnswerBox.TabIndex = 4;
            AnswerBox.KeyDown += EnterKey_Down;
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.BackColor = Color.Transparent;
            ResultText.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            ResultText.Location = new Point(503, 361);
            ResultText.Name = "ResultText";
            ResultText.RightToLeft = RightToLeft.No;
            ResultText.Size = new Size(77, 24);
            ResultText.TabIndex = 5;
            ResultText.Text = "Answer";
            ResultText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IntroLabel
            // 
            IntroLabel.AutoSize = true;
            IntroLabel.BackColor = Color.Transparent;
            IntroLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IntroLabel.Location = new Point(518, 228);
            IntroLabel.Name = "IntroLabel";
            IntroLabel.RightToLeft = RightToLeft.No;
            IntroLabel.Size = new Size(170, 31);
            IntroLabel.TabIndex = 6;
            IntroLabel.Text = "Japanese 404";
            IntroLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = Color.Transparent;
            ScoreLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            ScoreLabel.Location = new Point(248, 449);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.RightToLeft = RightToLeft.No;
            ScoreLabel.Size = new Size(61, 24);
            ScoreLabel.TabIndex = 8;
            ScoreLabel.Text = "Score";
            ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(255, 224, 192);
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            ExitButton.Location = new Point(1151, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(30, 30);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // IntroLabel2
            // 
            IntroLabel2.AutoSize = true;
            IntroLabel2.BackColor = Color.Transparent;
            IntroLabel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IntroLabel2.ForeColor = SystemColors.WindowFrame;
            IntroLabel2.Location = new Point(561, 269);
            IntroLabel2.Name = "IntroLabel2";
            IntroLabel2.RightToLeft = RightToLeft.No;
            IntroLabel2.Size = new Size(75, 19);
            IntroLabel2.TabIndex = 10;
            IntroLabel2.Text = "By Harris";
            IntroLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1197, 562);
            ControlBox = false;
            Controls.Add(IntroLabel2);
            Controls.Add(IntroLabel);
            Controls.Add(ExitButton);
            Controls.Add(ScoreLabel);
            Controls.Add(ResultText);
            Controls.Add(AnswerBox);
            Controls.Add(AnswerLabel);
            Controls.Add(QuestionLabel);
            Controls.Add(NextButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuizForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += QuizForm_MouseDown;
            MouseMove += QuizForm_MouseMove;
            MouseUp += QuizForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button NextButton;
        private Label QuestionLabel;
        private Label AnswerLabel;
        private TextBox AnswerBox;
        private Label ResultText;
        private Label IntroLabel;
        private Label ScoreLabel;
        private Button ExitButton;
        private Label IntroLabel2;
    }
}
