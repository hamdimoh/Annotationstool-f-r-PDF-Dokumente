using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUI
{
    //Hinweis zum Code:
    //Das Gerüst wurde mit Hilfe folgendem Tutorial programmiert : https://www.youtube.com/watch?v=BtOEztT1Qzk. Code stellen mit diesem Symbol (*) wurden damit gemacht.

    public partial class MainPage : Form
    {


        //(*)Felder
        private Button currentButton;
        private Form activeForm;
       
        //Constructor
        public MainPage()
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

        //Methoden
        private Color SelectThemeColor()
        {
            return Color.Aqua;
        }

        //Veränderung wenn ein Button gedrückt wird (aktiv ist)
        private void ActivateButton(object btnSender)
        {

            if (btnSender !=null)
            {
                if (currentButton!=(Button)btnSender)
                {
                    DisableButton(); 
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.LightGray;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  
                }
            }

        }
        
        //(*)Grundlage für die verschiedenen Seiten
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelHauptPanel.Controls.Add(childForm);
            this.panelHauptPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //(*)Veränderung wenn ein Button nicht mehr aktiv ist
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()== typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76) ;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

       

        //(*)Funktion des Frage-Buttons
        private void btnQuestionPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuestionPage(), sender);

         
        }

        //Funktion des Start Buttons
        private void btnStart_Click(object sender, EventArgs e)
        {
            Forms.FormWorkingPage formsWorkingPage = new Forms.FormWorkingPage();
            formsWorkingPage.ShowDialog();
        }

        

        // Standard Button-Funktionen für die Button im Panel: (1) btnClose und (2)btnMinimize
        private void panelBtnFunktion_Click(object sender, EventArgs e)
        {

            if (sender != null)
            {

                // (1) ermöglicht das Schließen der Applikation über den X-Button
                if (sender == btnClose)
                {

                    //Überprüft ob ein Dokument schon geladen wurde
                    if (Properties.Settings.Default._DocumentLoad == true)
                    {
                       DialogResult result=  MessageBox.Show("Sie haben Dokumente geladen, möchten Sie die Bearbeitung dennoch beenden? ", "Hinweis zum Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        
                    }
                    else
                    {
                        Application.Exit();
                    }
                      

                    
                }

                //(2) ermöglicht das Minimieren der Applikation über den _- Button
                if (sender == btnMinimize)
                {
                    this.WindowState = FormWindowState.Minimized;
                    
                }

            }

        }

        //(*)Methode für die Drag-Funktion
        private void panelFunktionen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //(*)Import über : using System.Runtime.InteropServices;  für die  Drag-Funktion der Applikation (Berührung) 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //(*)Import über : using System.Runtime.InteropServices; für die  Drag-Funktion der Applikation (Vermittlung) 
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       //Zeigt den Namen der Applikation an, wenn diese minimiert wird 
        private void MainPage_ClientSizeChanged(object sender, EventArgs e)
        {
            if (sender!=null)
            {
                //Applikation ist im Normalen-Zustand
                if (this.WindowState == FormWindowState.Normal)
                {
                    //Setzt den Text auf Empty und stellt die Applikationsgröße wiederher
                    this.Text = string.Empty;
                    this.Width = 859;
                    this.Height = 619;
                }
                else 
                {
                    //Applikation ist im Minimierten-Zustand

                    //Setzt den Text auf: "Annotationstool für PDF-Dokumente"  
                    this.Text = "Annotationstool für PDF-Dokumente";
                }
            }
             
        }

        private void panelHauptPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics mGraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(0, 0, 139), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lGB = new LinearGradientBrush(area, Color.FromArgb(0, 0, 139), Color.FromArgb(205, 16, 118), LinearGradientMode.ForwardDiagonal);
            mGraphics.FillRectangle(lGB, area);
            mGraphics.DrawRectangle(pen, area);
        }
    }
}
