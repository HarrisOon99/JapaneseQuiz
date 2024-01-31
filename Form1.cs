using System.Windows.Forms;

namespace JapaneseQuiz
{
    public partial class Form1 : Form
    {
        int index = 1;
        String FuriAnswer = "";

        public Form1()
        {
            InitializeComponent();
            QuestionLabel.Hide();
            AnswerBox.Hide();
            AnswerLabel.Hide();
            ResultText.Text = string.Empty;
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            JapaneseVocabulary randomVocabulary = GetRandomVocabulary(japaneseVocabularyList);

            if (NextButton.Text == "Start")
            {
                QuestionLabel.Show();
                AnswerBox.Show();
                AnswerLabel.Show();
                NextButton.Show();
                NextButton.Text = "Submit";
                QuestionLabel.Text = index.ToString() + ". What is the pronounciation for the word " + randomVocabulary.Kanji + "(" + randomVocabulary.Meaning + ")?";
                FuriAnswer = randomVocabulary.Furigana;
                AnswerBox.Focus();
            }
            else if (NextButton.Text == "Submit")
            {
                if (AnswerBox.Text == FuriAnswer)
                {
                    ResultText.ForeColor = Color.Green;
                    ResultText.Text = "Correct";
                }
                else
                {
                    ResultText.ForeColor = Color.Red;
                    ResultText.Text = "Wrong, answer is " + FuriAnswer;
                }
                NextButton.Text = "Next";
            }
            else
            {
                index += 1;
                QuestionLabel.Text = index.ToString() + ". What is the pronounciation for the word " + randomVocabulary.Kanji + "(" + randomVocabulary.Meaning + ")?";
                AnswerBox.Focus();
                FuriAnswer = randomVocabulary.Furigana;
                NextButton.Text = "Submit";
                ResultText.Text = string.Empty;
                AnswerBox.Text = string.Empty;
            }
        }

        static JapaneseVocabulary GetRandomVocabulary(List<JapaneseVocabulary> vocabularyList)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, vocabularyList.Count);
            return vocabularyList[randomIndex];
        }

        public class JapaneseVocabulary
        {
            public string Kanji { get; }
            public string Meaning { get; }
            public string Furigana { get; }

            public JapaneseVocabulary(string kanji, string meaning, string furigana)
            {
                Kanji = kanji;
                Meaning = meaning;
                Furigana = furigana;
            }
        }

        List<JapaneseVocabulary> japaneseVocabularyList = new List<JapaneseVocabulary>
        {
            new JapaneseVocabulary("挨拶", "Greetings", "あいさつ"),
            new JapaneseVocabulary("愛情", "affection", "あいじょう"),
            new JapaneseVocabulary("合図", "sign, signal \r\n", "あいず"),
            new JapaneseVocabulary("明かり ", "brightness", "あかり"),
        };
    }
}
