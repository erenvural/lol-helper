namespace LoL_Helper
{
    partial class MasteriesTreePlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasteriesTreePlanner));
            this.lblPage = new System.Windows.Forms.Label();
            this.pbAboutIcon = new System.Windows.Forms.PictureBox();
            this.pbSettingsIcon = new System.Windows.Forms.PictureBox();
            this.pbMinimizeIcon = new System.Windows.Forms.PictureBox();
            this.pbCloseIcon = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.SystemColors.Control;
            this.lblPage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPage.Location = new System.Drawing.Point(498, 20);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(285, 29);
            this.lblPage.TabIndex = 24;
            this.lblPage.Text = "Masteries Tree Planner";
            // 
            // pbAboutIcon
            // 
            this.pbAboutIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbAboutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAboutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutIcon.Image")));
            this.pbAboutIcon.Location = new System.Drawing.Point(247, 39);
            this.pbAboutIcon.Name = "pbAboutIcon";
            this.pbAboutIcon.Size = new System.Drawing.Size(18, 18);
            this.pbAboutIcon.TabIndex = 23;
            this.pbAboutIcon.TabStop = false;
            // 
            // pbSettingsIcon
            // 
            this.pbSettingsIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbSettingsIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettingsIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbSettingsIcon.Image")));
            this.pbSettingsIcon.Location = new System.Drawing.Point(1210, 4);
            this.pbSettingsIcon.Name = "pbSettingsIcon";
            this.pbSettingsIcon.Size = new System.Drawing.Size(18, 18);
            this.pbSettingsIcon.TabIndex = 22;
            this.pbSettingsIcon.TabStop = false;
            // 
            // pbMinimizeIcon
            // 
            this.pbMinimizeIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbMinimizeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizeIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizeIcon.Image")));
            this.pbMinimizeIcon.Location = new System.Drawing.Point(1234, 4);
            this.pbMinimizeIcon.Name = "pbMinimizeIcon";
            this.pbMinimizeIcon.Size = new System.Drawing.Size(18, 18);
            this.pbMinimizeIcon.TabIndex = 21;
            this.pbMinimizeIcon.TabStop = false;
            // 
            // pbCloseIcon
            // 
            this.pbCloseIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbCloseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseIcon.Image")));
            this.pbCloseIcon.Location = new System.Drawing.Point(1258, 4);
            this.pbCloseIcon.Name = "pbCloseIcon";
            this.pbCloseIcon.Size = new System.Drawing.Size(18, 18);
            this.pbCloseIcon.TabIndex = 20;
            this.pbCloseIcon.TabStop = false;
            this.pbCloseIcon.Click += new System.EventHandler(this.pbCloseIcon_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbHeader.Image = ((System.Drawing.Image)(resources.GetObject("pbHeader.Image")));
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1280, 63);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHeader.TabIndex = 19;
            this.pbHeader.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 63);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1280, 610);
            this.webBrowser1.TabIndex = 25;
            this.webBrowser1.Url = new System.Uri("http://www.mobafire.com/league-of-legends/mastery-tree-planner", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // MasteriesTreePlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 673);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.pbAboutIcon);
            this.Controls.Add(this.pbSettingsIcon);
            this.Controls.Add(this.pbMinimizeIcon);
            this.Controls.Add(this.pbCloseIcon);
            this.Controls.Add(this.pbHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasteriesTreePlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasteriesTreePlaner";
            this.Load += new System.EventHandler(this.MasteriesTreePlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.PictureBox pbAboutIcon;
        private System.Windows.Forms.PictureBox pbSettingsIcon;
        private System.Windows.Forms.PictureBox pbMinimizeIcon;
        private System.Windows.Forms.PictureBox pbCloseIcon;
        internal System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}