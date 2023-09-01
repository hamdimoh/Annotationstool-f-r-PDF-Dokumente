using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using ceTe.DynamicPDF.Viewer;

namespace WindowsFormsGUI.Forms
{
    public class Mark : PdfFile
    {
        /// <summary>
        /// Gesuchte Texte werden zu Answer gespeichert.
        /// </summary>
        /// <param name="Textbox"></Suchen Text Bereich>
        public void AnswerText(TextBox Textbox)
        {
            Answer = Textbox.Text;
        }
        /// <summary>
        /// Diese Methode sucht auf die abgegebne Texte in TextReader
        /// </summary>
        /// <param name="TextReader"></Suchen Text Bereich>
        public void searchinTextReader(RichTextBox TextReader)
        {
            int startIndex = 0;
            while (startIndex < TextReader.TextLength)
            {
                //Atwort finden & return index 
                int wordStartIndex = TextReader.Find(Answer, startIndex, RichTextBoxFinds.None);
                if (wordStartIndex != -1)
                {
                    TextReader.SelectionStart = wordStartIndex;
                    TextReader.SelectionLength = Answer.Length;
                }
                else
                    break;

                startIndex += wordStartIndex + Answer.Length;
            }
        }
        /// <summary>
        /// Texte Markierung
        /// </summary>
        /// <param name="PdfViewer"></PdfViewer>
        /// <param name="Textbox"></Suchen Text Bereich>
        /// <param name="TextReader"></Text Leser>
        public void AddMark(PdfViewer PdfViewer, TextBox Textbox, RichTextBox TextReader)
        {
            // AnswerText Methode aufrufen
            AnswerText(Textbox);
            // Gesuchte Antwort wird in der PdfViewer markiert
            Color highlightColor = (Color.FromArgb(90, 110, 0, 255));
            PdfViewer.Highlight(Answer, MatchOptions.WholeWordOnly, highlightColor);
            PdfViewer.SearchForward(Answer, MatchOptions.All);

            if (string.IsNullOrEmpty(Textbox.Text))
            {
                // Wenn die TextBox leer ist  
                MessageBox.Show("Keine Eingabe eingeschrieben!");
            }
            if (Textbox.Text != Answer)
            {
                // TextBox ungleich die Texte in der PDF
                MessageBox.Show("Kein Ergebnis!");
            }
            else
            {
                // Suchen Text Methode in der TextReader aufrufen
                searchinTextReader(TextReader);
                //Gesuchte Antwort wird in der Richtextbox markiert
                TextReader.SelectionBackColor = Color.LightBlue;

            }

        }
        /// <summary>
        /// Gefundene Antworten mit der Frage(nich meinen Teil) Zeigen
        /// </summary>
        /// <param name="Textbox"></Suchen Text Bereich>
        /// <param name="TextReader"></Text Leser>
        /// <param name="HighlihtAnswers"></Markierte Texte von der PDF >
        public void TextResult(TextBox Textbox, RichTextBox TextReader, RichTextBox HighlihtAnswers)
        {
            //Json form
            Mark Json = new Mark { Answer = Answer };
            string json = JsonConvert.SerializeObject(Json, Formatting.None);
            // Suchen Text Methode in TextReader aufrufen
            searchinTextReader(TextReader);

            if (string.IsNullOrEmpty(Textbox.Text) || Textbox.Text != Answer)
            {
                // Wenn die TextBox leer ist oder ungleich die Texte in der PDF
                MessageBox.Show("Kein Ergebnis!");
            }
            else
            {
                // Add die gesuchte Texte (Antworten) in der RichTextBox(HighlihtAnswers)
                HighlihtAnswers.AppendText(json);
            }
        }
        /// <summary>
        /// Marker Löschen
        /// </summary>
        /// <param name="Textbox"></Suchen Text Bereich>
        /// <param name="TextReader"></Text Leser>
        /// <param name="PdfViewer"></PdfViewer>
        public void MarkClear(TextBox Textbox, RichTextBox TextReader, PdfViewer PdfViewer)
        {
            // AnswerText Methode aufrufen
            AnswerText(Textbox);
            // Marker vom PdfViewer Löschen 
            PdfViewer.ClearSearchHighlights();
            //Marker von der RichTextbox Löschen(
            TextReader.SelectionStart = 0;
            TextReader.SelectAll();
            TextReader.SelectionBackColor = Color.White;
        }

    }
}


