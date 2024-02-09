using System.Windows.Forms;

namespace JapaneseQuiz
{
    public partial class QuizForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        int CaseNum = 0;
        int QuestionNum = 1;
        int CorrectAns = 0;
        String? FuriAnswer = "";
        string filePath = @"C:\Projects\C# Projects\JapaneseQuiz\JapaneseQuiz\VocabularyList.xlsx";

        public QuizForm()
        {
            InitializeComponent();
            Icon = new Icon("C:\\Projects\\C# Projects\\JapaneseQuiz\\JapaneseQuiz\\Properties\\Symbol.ico");
            QuestionLabel.Hide();
            AnswerBox.Hide();
            AnswerLabel.Hide();
            ScoreLabel.Hide();
            ResultText.Text = string.Empty;
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void EnterKey_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { NextQuestion(); }
            else if (e.KeyCode == Keys.E) { this.Close(); }
        }

        private void ExitButton_Click(object sender, EventArgs e) { this.Close(); }

        private void NextButton_Click(object sender, EventArgs e) { NextQuestion(); }

        private void NextQuestion()
        {
            JapaneseVocabulary randomVocabulary = GetRandomVocabulary(Vocabulary.ImportFromExcel(filePath));

            switch (CaseNum)
            {
                // Start Quiz.
                case 0:
                    IntroLabel.Hide();
                    IntroLabel2.Hide();
                    QuestionLabel.Show();
                    AnswerBox.Show();
                    AnswerLabel.Show();
                    NextButton.Show();
                    ScoreLabel.Show();
                    AnswerBox.Focus();

                    NextButton.Text = "Submit";
                    QuestionLabel.Text = QuestionNum.ToString() + ". What is the pronounciation for the word " + randomVocabulary.Kanji + "(" + randomVocabulary.Meaning + ")?";
                    FuriAnswer = randomVocabulary.Furigana;
                    ScoreLabel.Text = "Score : " + CorrectAns.ToString() + "/" + (QuestionNum - 1).ToString() + " (" + (CorrectAns / QuestionNum).ToString() + "%)";
                    CaseNum += 1;
                    break;

                // Submit Answer.
                case 1:
                    if (AnswerBox.Text == FuriAnswer)
                    {
                        ResultText.ForeColor = Color.Green;
                        ResultText.Text = "Correct";
                        CorrectAns += 1;
                    }
                    else
                    {
                        ResultText.ForeColor = Color.Red;
                        ResultText.Text = "Wrong, answer is " + FuriAnswer;
                    }
                    NextButton.Text = "Next";
                    CaseNum += 1;
                    break;

                // Next Question
                case 2:
                    QuestionNum += 1;
                    QuestionLabel.Text = QuestionNum.ToString() + ". What is the pronounciation for the word " + randomVocabulary.Kanji + "(" + randomVocabulary.Meaning + ")?";
                    AnswerBox.Focus();
                    FuriAnswer = randomVocabulary.Furigana;
                    NextButton.Text = "Submit";
                    ResultText.Text = string.Empty;
                    AnswerBox.Text = string.Empty;
                    ScoreLabel.Text = "Score : " + CorrectAns.ToString() + "/" + (QuestionNum - 1).ToString() + " (" + ((CorrectAns * 100) / (QuestionNum - 1)).ToString() + "%)";
                    CaseNum = 1;
                    break;
            }
        }

        public static JapaneseVocabulary GetRandomVocabulary(List<JapaneseVocabulary> vocabularyList)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, vocabularyList.Count);
            return vocabularyList[randomIndex];
        }

        #region Movable program.
        private void QuizForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void QuizForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void QuizForm_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }
        #endregion
    }
}
