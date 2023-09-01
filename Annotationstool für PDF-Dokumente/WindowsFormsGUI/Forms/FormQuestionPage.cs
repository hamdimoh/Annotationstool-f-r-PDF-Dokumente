using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUI.Forms
{
    // Der Hintergrund wurde mit Hilfe von : https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-a-linear-gradient?view=netframeworkdesktop-4.8 programmiert. Symbol (+)
    public partial class FormQuestionPage : System.Windows.Forms.Form
    {
        public FormQuestionPage()
        {
            InitializeComponent();
            DoubleBuffered = true; 
        }


        //(+)Hintergrundfarbe(Farbverlauf)
        private void FormQuestionPage_Paint(object sender, PaintEventArgs e)
        {
            Graphics mGraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(0, 0, 139), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lGB = new LinearGradientBrush(area, Color.FromArgb(0, 0, 139), Color.FromArgb(205, 16, 118), LinearGradientMode.ForwardDiagonal);
            mGraphics.FillRectangle(lGB, area);
            mGraphics.DrawRectangle(pen, area);
        }


        //Button-Funktionen
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                //Button1
                if (sender == btnAnswer1)
                {
                    if (labelAnswerFor1.Visible == false)
                    {
                        labelAnswerFor1.Visible = true;
                        labelAnswerFor2.Visible = false;
                        labelAnswerFor3.Visible = false;
                        labelAnswerFor4.Visible = false;

                    }
                    else
                    {
                        labelAnswerFor1.Visible = false;
                    }
                }
                //Button2
                if (sender == btnAnswer2)
                {
                    if (labelAnswerFor2.Visible == false)
                    {
                        labelAnswerFor2.Visible = true;
                    }
                    else
                    {
                        labelAnswerFor2.Visible = false;
                    }
                }
                //Button3
                if (sender == btnAnswer3)
                {
                    if (labelAnswerFor3.Visible == false)
                    {
                        labelAnswerFor3.Visible = true;
                    }
                    else
                    {
                        labelAnswerFor3.Visible = false;
                    }
                }
                //Button4
                if (sender == btnAnswer4)
                {
                    if (labelAnswerFor4.Visible == false)
                    {
                        labelAnswerFor4.Visible = true;
                    }
                    else
                    {
                        labelAnswerFor4.Visible = false;
                    }
                }

            }
        }

        
    }
}
