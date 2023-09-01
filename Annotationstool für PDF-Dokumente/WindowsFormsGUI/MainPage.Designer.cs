
namespace WindowsFormsGUI
{
    partial class MainPage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuestionPage = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.panelHauptPanel = new System.Windows.Forms.Panel();
            this.panelFunktionen = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHauptPanel.SuspendLayout();
            this.panelFunktionen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnQuestionPage);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 580);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(54, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 56);
            this.panel1.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 56);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuestionPage
            // 
            this.btnQuestionPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuestionPage.FlatAppearance.BorderSize = 0;
            this.btnQuestionPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionPage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuestionPage.Location = new System.Drawing.Point(0, 80);
            this.btnQuestionPage.Name = "btnQuestionPage";
            this.btnQuestionPage.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuestionPage.Size = new System.Drawing.Size(220, 60);
            this.btnQuestionPage.TabIndex = 2;
            this.btnQuestionPage.Text = "Fragen?";
            this.btnQuestionPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestionPage.UseVisualStyleBackColor = true;
            this.btnQuestionPage.Click += new System.EventHandler(this.btnQuestionPage_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelHeading);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // labelHeading
            // 
            this.labelHeading.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.White;
            this.labelHeading.Location = new System.Drawing.Point(3, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(214, 80);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Gruppe 6: Annotationstool für PDF-Dokumente";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHauptPanel
            // 
            this.panelHauptPanel.Controls.Add(this.pictureBox1);
            this.panelHauptPanel.Controls.Add(this.panelFunktionen);
            this.panelHauptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHauptPanel.Location = new System.Drawing.Point(220, 0);
            this.panelHauptPanel.Name = "panelHauptPanel";
            this.panelHauptPanel.Size = new System.Drawing.Size(623, 580);
            this.panelHauptPanel.TabIndex = 1;
            this.panelHauptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHauptPanel_Paint);
            // 
            // panelFunktionen
            // 
            this.panelFunktionen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelFunktionen.Controls.Add(this.btnMinimize);
            this.panelFunktionen.Controls.Add(this.btnClose);
            this.panelFunktionen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunktionen.Location = new System.Drawing.Point(0, 0);
            this.panelFunktionen.Name = "panelFunktionen";
            this.panelFunktionen.Size = new System.Drawing.Size(623, 29);
            this.panelFunktionen.TabIndex = 0;
            this.panelFunktionen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFunktionen_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(566, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.panelBtnFunktion_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(593, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.panelBtnFunktion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsGUI.Properties.Resources.Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(145, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 305);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 580);
            this.Controls.Add(this.panelHauptPanel);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Annotationstool für PDF-Dokumente";
            this.ClientSizeChanged += new System.EventHandler(this.MainPage_ClientSizeChanged);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelHauptPanel.ResumeLayout(false);
            this.panelFunktionen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnQuestionPage;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Panel panelHauptPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelFunktionen;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

