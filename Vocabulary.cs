using System;
using System.Collections.Generic;
using OfficeOpenXml;


namespace JapaneseQuiz
{
    public static class Vocabulary
    {
        public static List<JapaneseVocabulary> ImportFromExcel(string filepath)
        {
            List<JapaneseVocabulary> VocabularyList = new List<JapaneseVocabulary>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filepath)))
            {
                // Get the first worksheet in the Excel package
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Read data from the worksheet
                int rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount; row++) // Assuming the first row is headers
                {
                    string? kanji = worksheet.Cells[row, 1].Value.ToString();
                    string? meaning = worksheet.Cells[row, 3].Value.ToString();
                    string? furigana = worksheet.Cells[row, 2].Value.ToString();

                    VocabularyList.Add(new JapaneseVocabulary(kanji, meaning, furigana));
                }
            }
            return VocabularyList;
        }
    }

    public class JapaneseVocabulary
    {
        public string? Kanji { get; }
        public string? Meaning { get; }
        public string? Furigana { get; }

        public JapaneseVocabulary(string? kanji, string? meaning, string? furigana)
        {
            Kanji = kanji;
            Meaning = meaning;
            Furigana = furigana;
        }
    }
}
