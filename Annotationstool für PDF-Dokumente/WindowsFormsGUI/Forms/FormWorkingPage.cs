using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUI.Forms
{
    public partial class FormWorkingPage : System.Windows.Forms.Form
    {
        private Mark _mark = new Mark();
        private PdfFile pdf = new PdfFile();

        //Constructor
        public FormWorkingPage()
        {
            InitializeComponent();


            //Veränderungen der Programmdarstellung:

            //(1) Programmname wird nicht angezeigt

            this.Text = string.Empty;

            //(2) keine Controlbox 
            this.ControlBox = false;

            //(3) keine Vergößerung oder Verkleinerung möglich 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        //die vier Button Funktionen zum Bearbeiten und Speichern 
        private void topPanelButtons_Click(object sender, EventArgs e)
        {

            if (sender != null)
            {
                //Funktion des Speichern-Buttons
                if (sender == btnSave)
                {
                    pdf.Jsonform(HighlihtAnswers);
                }//Funktion des Text-Hinzufügen-Buttons
                else if (sender == btnAddText)
                {
                    _mark.TextResult(Textbox, Textreader, HighlihtAnswers);
                }//Funktion des Markieren-Buttons
                else if (sender == btnMark)
                {
                    _mark.AddMark(pdfViewer1, Textbox, Textreader);
                }//Funktion des Markieren-Löschen-Buttons
                else if (sender == btnDeleteMark)
                {
                    _mark.MarkClear(Textbox, Textreader, pdfViewer1);
                }

            }
        }

        //Import für die  Drag-Funktion der Applikation (Berührung) 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //Import für die  Drag-Funktion der Applikation (Vermittlung) 
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methode für die Drag-Funktion
        private void topPanelFunction_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Standard Button-Funktionen für die Button im Panel: (1) btnClose und (2)btnMaximize
        private void panelBtnFunction_Click(object sender, EventArgs e)
        {

            if (sender != null)
            {

                // (1) ermöglicht das Schließen der Applikation über den X-Button
                if (sender == btnClose)
                {

                    //Sicherung falls ausversehen der btnClose gedrückt wurde
                    DialogResult result = MessageBox.Show("Nicht gespeicherte Arbeitsschritte gehen verloren. Möchten Sie den Bereich dennoch verlassen?", "Sie verlassen den Bearbeitungsbereich", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }

                }
                //(2) ermöglicht das Maximieren der Applikation, sowie wieder auf den Nomralen-Zustand zurückzukommen

                if (sender == btnMaximize && this.WindowState == FormWindowState.Normal)
                {
                    //Zustand Maximiert
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    //Zustand Normal
                    this.WindowState = FormWindowState.Normal;
                }


            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pdf.Load(pdfViewer1, Textreader);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputquestions.Text))
            {
                MessageBox.Show("Keine Frage eingeschrieben");
            }
            else
            {


                // Zu die fragen liste hinzufügen.
                HighlihtAnswers.AppendText($"Frage: [{inputquestions.Text}]");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = HighlihtAnswers.SelectionLength;
            HighlihtAnswers.Text = HighlihtAnswers.Text.Remove(HighlihtAnswers.SelectionStart, a);
        }
    }
    
}