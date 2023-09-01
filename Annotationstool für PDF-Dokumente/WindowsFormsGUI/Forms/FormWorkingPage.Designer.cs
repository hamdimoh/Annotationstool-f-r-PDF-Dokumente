
namespace WindowsFormsGUI.Forms
{
    partial class FormWorkingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkingPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputquestions = new System.Windows.Forms.TextBox();
            this.labelAboveAnswerAndQuestion = new System.Windows.Forms.Label();
            this.HighlihtAnswers = new System.Windows.Forms.RichTextBox();
            this.panelTopButton = new System.Windows.Forms.Panel();
            this.panelButtonContent = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.topPanelFunction = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.pdfViewer1 = new ceTe.DynamicPDF.Viewer.PdfViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.Textreader = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelTopButton.SuspendLayout();
            this.panelButtonContent.SuspendLayout();
            this.topPanelFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Textreader);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Textbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.inputquestions);
            this.panel2.Controls.Add(this.labelAboveAnswerAndQuestion);
            this.panel2.Controls.Add(this.HighlihtAnswers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 797);
            this.panel2.TabIndex = 2;
            // 
            // inputquestions
            // 
            this.inputquestions.Location = new System.Drawing.Point(14, 29);
            this.inputquestions.Name = "inputquestions";
            this.inputquestions.Size = new System.Drawing.Size(178, 20);
            this.inputquestions.TabIndex = 2;
            // 
            // labelAboveAnswerAndQuestion
            // 
            this.labelAboveAnswerAndQuestion.AutoSize = true;
            this.labelAboveAnswerAndQuestion.BackColor = System.Drawing.Color.Black;
            this.labelAboveAnswerAndQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboveAnswerAndQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAboveAnswerAndQuestion.Location = new System.Drawing.Point(3, 155);
            this.labelAboveAnswerAndQuestion.Name = "labelAboveAnswerAndQuestion";
            this.labelAboveAnswerAndQuestion.Size = new System.Drawing.Size(195, 17);
            this.labelAboveAnswerAndQuestion.TabIndex = 1;
            this.labelAboveAnswerAndQuestion.Text = "Gegebene Frage und Antwort";
            // 
            // HighlihtAnswers
            // 
            this.HighlihtAnswers.Location = new System.Drawing.Point(3, 175);
            this.HighlihtAnswers.Name = "HighlihtAnswers";
            this.HighlihtAnswers.Size = new System.Drawing.Size(192, 205);
            this.HighlihtAnswers.TabIndex = 0;
            this.HighlihtAnswers.Text = "";
            // 
            // panelTopButton
            // 
            this.panelTopButton.Controls.Add(this.panelButtonContent);
            this.panelTopButton.Controls.Add(this.topPanelFunction);
            this.panelTopButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButton.Location = new System.Drawing.Point(198, 0);
            this.panelTopButton.Name = "panelTopButton";
            this.panelTopButton.Size = new System.Drawing.Size(481, 110);
            this.panelTopButton.TabIndex = 3;
            // 
            // panelButtonContent
            // 
            this.panelButtonContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelButtonContent.Controls.Add(this.btnSave);
            this.panelButtonContent.Controls.Add(this.btnAddText);
            this.panelButtonContent.Controls.Add(this.btnMark);
            this.panelButtonContent.Controls.Add(this.btnDeleteMark);
            this.panelButtonContent.Location = new System.Drawing.Point(14, 29);
            this.panelButtonContent.Name = "panelButtonContent";
            this.panelButtonContent.Size = new System.Drawing.Size(450, 78);
            this.panelButtonContent.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::WindowsFormsGUI.Properties.Resources.SpeicherSymbol;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(3, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 78);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Speichern";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.topPanelButtons_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddText.Image = global::WindowsFormsGUI.Properties.Resources.AddTextBild3;
            this.btnAddText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddText.Location = new System.Drawing.Point(102, 0);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(110, 78);
            this.btnAddText.TabIndex = 3;
            this.btnAddText.Text = "Text hinzufügen";
            this.btnAddText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.topPanelButtons_Click);
            // 
            // btnMark
            // 
            this.btnMark.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Image = global::WindowsFormsGUI.Properties.Resources.MarkierenBild;
            this.btnMark.Location = new System.Drawing.Point(212, 0);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(101, 78);
            this.btnMark.TabIndex = 2;
            this.btnMark.Text = "Markieren";
            this.btnMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.topPanelButtons_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMark.Image = global::WindowsFormsGUI.Properties.Resources.LöschenBild;
            this.btnDeleteMark.Location = new System.Drawing.Point(313, 0);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(137, 78);
            this.btnDeleteMark.TabIndex = 1;
            this.btnDeleteMark.Text = "Markierung löschen";
            this.btnDeleteMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteMark.UseVisualStyleBackColor = true;
            this.btnDeleteMark.Click += new System.EventHandler(this.topPanelButtons_Click);
            // 
            // topPanelFunction
            // 
            this.topPanelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.topPanelFunction.Controls.Add(this.btnMaximize);
            this.topPanelFunction.Controls.Add(this.btnClose);
            this.topPanelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelFunction.Location = new System.Drawing.Point(0, 0);
            this.topPanelFunction.Name = "topPanelFunction";
            this.topPanelFunction.Size = new System.Drawing.Size(481, 29);
            this.topPanelFunction.TabIndex = 0;
            this.topPanelFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanelFunction_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(424, -8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(31, 40);
            this.btnMaximize.TabIndex = 20;
            this.btnMaximize.Text = "□";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.panelBtnFunction_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(451, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.panelBtnFunction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fragen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Such Antwort";
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(14, 116);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(178, 20);
            this.Textbox.TabIndex = 5;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pdfViewer1.FocusBorderColor = System.Drawing.SystemColors.Highlight;
            this.pdfViewer1.FocusBorderWidth = 3;
            this.pdfViewer1.InitialOrientation = null;
            this.pdfViewer1.InitialPage = null;
            this.pdfViewer1.InitialPageMode = null;
            this.pdfViewer1.InitialVisibleNavigationPane = null;
            this.pdfViewer1.InitialZoomMode = null;
            this.pdfViewer1.InitialZoomPercent = null;
            this.pdfViewer1.Location = new System.Drawing.Point(204, 116);
            this.pdfViewer1.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.NavigationPanelWidth = 245;
            this.pdfViewer1.PageColor = System.Drawing.Color.White;
            this.pdfViewer1.RightToLeftText = null;
            this.pdfViewer1.ShowBookmarkIcon = true;
            this.pdfViewer1.ShowHorizontalScrollbar = true;
            this.pdfViewer1.ShowNavigationPanel = true;
            this.pdfViewer1.ShowThumbnailIcon = true;
            this.pdfViewer1.ShowToolbar = false;
            this.pdfViewer1.ShowToolStrip = false;
            this.pdfViewer1.ShowVerticalScrollbar = true;
            this.pdfViewer1.Size = new System.Drawing.Size(463, 636);
            this.pdfViewer1.TabIndex = 4;
            this.pdfViewer1.TextSelectionColor = System.Drawing.Color.Empty;
            this.pdfViewer1.VisibleNavigationPane = ceTe.DynamicPDF.Viewer.NavigationPane.None;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pdf laden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Textreader
            // 
            this.Textreader.Location = new System.Drawing.Point(3, 386);
            this.Textreader.Name = "Textreader";
            this.Textreader.Size = new System.Drawing.Size(192, 227);
            this.Textreader.TabIndex = 7;
            this.Textreader.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Einfügen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(134, 55);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(58, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Löschen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormWorkingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 797);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.panelTopButton);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorkingPage";
            this.Text = "FormsBearbeitungsSeite";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTopButton.ResumeLayout(false);
            this.panelButtonContent.ResumeLayout(false);
            this.topPanelFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTopButton;
        private System.Windows.Forms.Panel panelButtonContent;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnDeleteMark;
        private System.Windows.Forms.Panel topPanelFunction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox inputquestions;
        private System.Windows.Forms.Label labelAboveAnswerAndQuestion;
        private System.Windows.Forms.RichTextBox HighlihtAnswers;
        private System.Windows.Forms.RichTextBox Textreader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ceTe.DynamicPDF.Viewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}