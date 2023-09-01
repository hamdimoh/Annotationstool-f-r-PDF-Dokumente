using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ceTe.DynamicPDF.Viewer;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using Newtonsoft.Json;




namespace WindowsFormsGUI.Forms
{
    public class PdfFile
    {


        [JsonProperty(PropertyName = "Antwort", Order = 2)]
        protected string Answer = "";
        
        /// <summary>
        /// PDF vom Speicher Laden und in PdfViewer Zeigen auch in Richtextbox lesen
        /// </summary>
        /// <param name="pdfViewer"></pdfViewer>
        /// <param name="TextReader"></Texte von PDF lesen>
        public void Load(PdfViewer pdfViewer, RichTextBox TextReader)
        {
            // Pdfs vom Speicher Laden Mithilfe von der OpenFileDialog-Klasse 
            OpenFileDialog dialog = new OpenFileDialog();
            // Dateifilter PDF
            dialog.Filter = "PDF document (*.pdf)|*.pdf";
            DialogResult ergibnis = dialog.ShowDialog();
            if (ergibnis == DialogResult.OK)
            {
                try
                {
                    string pdfFile = dialog.FileName;
                    // Pdf in PdfViewer Zeigen 
                    pdfViewer.Open(pdfFile);
                    // Pdf in der Richtextbox lesen
                    PdfReader reader = new PdfReader(pdfFile);
                    // Stellen ein new StringBuilder für die Texte
                    StringBuilder sb = new StringBuilder();
                    // Lesen alle seiten in der PDF
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        // Fügen die PDF Texte in der (sb) string ein
                        sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                    // Fügen die PDF Texte in der TextReader ein
                    TextReader.Text = sb.ToString();
                    reader.Close();
                }

                catch (Exception exe)
                {

                    MessageBox.Show(exe.Message, "Diese Extanion ist nich Erlaubt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Gefundene Texte als Json form Speichern
        /// </summary>
        /// <param name="HighlihtAnswers"></Markierte Texte von der PDF  >
        public void Jsonform(RichTextBox HighlihtAnswers)
        {

            // Die Gefundene Antworten von der RichTextBox als Json.txt im Speicher speichern
            SaveFileDialog sfd = new SaveFileDialog();
            // Dateifilter json.txt
            sfd.Filter = "(*.json.txt)|*.json.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    // Die Gefundene Antworten von der RichTextBox als Json.txt speichern
                    HighlihtAnswers.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception e)
                {
                    MessageBox.Show(String.Concat("Problem bei der Ladung: ", e.Message));
                }
            }
            // Nachricht wird nach der Speicheirung gezeigt 
            MessageBox.Show("Das Ergebnis wurde als Json.text gespeichert");
        }
    }
}

