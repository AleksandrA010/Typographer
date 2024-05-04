using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Typographer
{
    internal class Typographer
    {
        public readonly RichTextBox _richTextBox;
        private readonly List<Char> _punctuationMarks = new List<Char>()
        {
            ',', '?', '.', ':', '!'
        };
        private readonly List<Char> _numbers = new List<Char>()
        {
            '2', '3'
        };
        public string CurrentText {  get; private set; }

        public Typographer(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }
        public string GetCorrectText()
        {
            CurrentText = _richTextBox.Text;

            CurrentText = RemoveDoubleSpace();
            CurrentText = CorrectPunctuationMarks();
            CurrentText = CorrectPlusMinusMark();
            CurrentText = CorrectDegreeMark();
            CurrentText = CorrectEllipsisMark();

            CurrentText = UseMyCorrect2();
            CurrentText = UseMyCorrect1();

            return CurrentText;
        }

        private string CorrectDegreeMark()
        {
            string resultText = CurrentText;

            for (int i = 0; i < _numbers.Count; i++)
            {
                resultText = resultText.Replace("^ ", "^");
                resultText = resultText.Replace(" ^" + _numbers[i], "^" + _numbers[i]);
                resultText = resultText.Replace("^" + _numbers[i] + " ", "^" + _numbers[i]);
                resultText = resultText.Replace("^" + _numbers[i], "^" + _numbers[i] + " ");

                if (_numbers[i] == '2')
                    resultText = resultText.Replace("^" + _numbers[i], "²");
                if (_numbers[i] == '3')
                    resultText = resultText.Replace("^" + _numbers[i], "³");

            }

            return resultText;
        }

        private string CorrectEllipsisMark()
        {
            string resultText = CurrentText;

            resultText = resultText.Replace(". . . . ", "… ");
            resultText = resultText.Replace(". . . ", "… ");
            resultText = resultText.Replace(". . ", "… ");

            return resultText;
        }

        public string UseMyCorrect1()
        {
            string resultText = CurrentText;

            resultText = resultText.Replace(". ", "(Точка) ");

            return resultText;
        }

        public string UseMyCorrect2()
        {
            string resultText = CurrentText;

            if (CurrentText.Length < 10)
                resultText = "Слишком короткий текст";

            return resultText;
        }

        private string CorrectPlusMinusMark()
        {
            string resultText = CurrentText;

            resultText = resultText.Replace("(+,-)", "±");
            resultText = resultText.Replace("+ -", "±");
            resultText = resultText.Replace("+-", "±");

            resultText = resultText.Replace(" ±", "±");
            resultText = resultText.Replace("± ", "±");
            resultText = resultText.Replace("±", " ± ");

            return resultText;
        }


        private string CorrectPunctuationMarks()
        {
            string resultText = CurrentText;

            for (int i = 0; i < _punctuationMarks.Count; i++)
            {
                resultText = resultText.Replace(" " + Convert.ToString(_punctuationMarks[i]), Convert.ToString(_punctuationMarks[i]));
                resultText = resultText.Replace(Convert.ToString(_punctuationMarks[i] + " "), Convert.ToString(_punctuationMarks[i]));
                resultText = resultText.Replace(Convert.ToString(_punctuationMarks[i]), Convert.ToString(_punctuationMarks[i]) + " ");
            }

            resultText = resultText.Replace(" " + '"', Convert.ToString('"'));
            resultText = resultText.Replace('"' + " ", Convert.ToString('"'));
            resultText = resultText.Replace(Convert.ToString('"'), " " + '"');

            resultText = resultText.Replace(" " + '—', Convert.ToString('—'));
            resultText = resultText.Replace('—' + " ", Convert.ToString('—'));
            resultText = resultText.Replace(Convert.ToString('—'), " " + '—' + " ");

            resultText = resultText.Replace(" " + '-', Convert.ToString('-'));
            resultText = resultText.Replace('-' + " ", Convert.ToString('-'));

            resultText = resultText.Replace(" " + '(', Convert.ToString('('));
            resultText = resultText.Replace('(' + " ", Convert.ToString('('));
            resultText = resultText.Replace(Convert.ToString('('), " " + '(');

            resultText = resultText.Replace(" " + ')', Convert.ToString(')'));
            resultText = resultText.Replace(')' + " ", Convert.ToString(')'));
            resultText = resultText.Replace(Convert.ToString(')'), ')' + " ");

            return resultText;
        }


        private string RemoveDoubleSpace()
        {
            string resultText = CurrentText;

            resultText = resultText.Replace("  ", " ");
            resultText = resultText.Replace("  ", " ");

            return resultText;
        }


    }
}
