using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JapaneseQuiz.QuizForm;

namespace JapaneseQuiz
{
    public static class Vocabulary
    {
        public static class VocabularyList
        {
            public static List<JapaneseVocabulary> Vocabulary = new List<JapaneseVocabulary>
            {
                new JapaneseVocabulary("往復", "Round　Trip", "おうふく"),
                new JapaneseVocabulary("選挙", "Election", "せんきょ"),
                new JapaneseVocabulary("薬局", "Pharmacy", "やっきょく"),
                new JapaneseVocabulary("太い", "Thick", "ふとい"),
                new JapaneseVocabulary("厚い", "Thick", "あつい"),
                new JapaneseVocabulary("凍る", "Freeze", "こおる"),
                new JapaneseVocabulary("割れる", "Break", "われる"),
                new JapaneseVocabulary("破れる", "Destroy", "やぶれる"),
                new JapaneseVocabulary("遅刻", "Late", "ちこく"),
                new JapaneseVocabulary("届いた", "Arrive", "とどいた"),
                new JapaneseVocabulary("雨戸", "Shutter", "あまど"),
                new JapaneseVocabulary("移される", "Transfer", "うつされる"),
                new JapaneseVocabulary("広告", "Advertisement", "こうこく"),
                new JapaneseVocabulary("原料", "Material", "げんりょ"),
                new JapaneseVocabulary("危ない", "Dangerous", "あぶない"),
                new JapaneseVocabulary("防げる", "Can be prevented", "ふせげる"),
                new JapaneseVocabulary("防ぐ", "Prevention", "ふせぐ"),
            };
        }
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
}
