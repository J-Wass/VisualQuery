namespace VisualQuery
{
    partial class VisualQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualQuery));
            this.gDatabases = new System.Windows.Forms.GroupBox();
            this.tDatabases = new System.Windows.Forms.TreeView();
            this.gMenu = new System.Windows.Forms.GroupBox();
            this.gConsole = new System.Windows.Forms.GroupBox();
            this.tInput = new System.Windows.Forms.RichTextBox();
            this.tConsole = new System.Windows.Forms.RichTextBox();
            this.browserDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.bBrowse = new System.Windows.Forms.Button();
            this.gDatabases.SuspendLayout();
            this.gConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // gDatabases
            // 
            this.gDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gDatabases.AutoSize = true;
            this.gDatabases.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gDatabases.Controls.Add(this.bBrowse);
            this.gDatabases.Controls.Add(this.tDatabases);
            this.gDatabases.Location = new System.Drawing.Point(-2, 34);
            this.gDatabases.Name = "gDatabases";
            this.gDatabases.Padding = new System.Windows.Forms.Padding(20);
            this.gDatabases.Size = new System.Drawing.Size(469, 848);
            this.gDatabases.TabIndex = 0;
            this.gDatabases.TabStop = false;
            this.gDatabases.Text = "Databases";
            // 
            // tDatabases
            // 
            this.tDatabases.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDatabases.Location = new System.Drawing.Point(20, 39);
            this.tDatabases.Name = "tDatabases";
            this.tDatabases.Size = new System.Drawing.Size(429, 789);
            this.tDatabases.TabIndex = 0;
            // 
            // gMenu
            // 
            this.gMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMenu.AutoSize = true;
            this.gMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gMenu.Location = new System.Drawing.Point(-24, -16);
            this.gMenu.Name = "gMenu";
            this.gMenu.Size = new System.Drawing.Size(1374, 61);
            this.gMenu.TabIndex = 1;
            this.gMenu.TabStop = false;
            // 
            // gConsole
            // 
            this.gConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gConsole.AutoSize = true;
            this.gConsole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gConsole.Controls.Add(this.tInput);
            this.gConsole.Controls.Add(this.tConsole);
            this.gConsole.Location = new System.Drawing.Point(488, 627);
            this.gConsole.Name = "gConsole";
            this.gConsole.Padding = new System.Windows.Forms.Padding(20);
            this.gConsole.Size = new System.Drawing.Size(837, 255);
            this.gConsole.TabIndex = 2;
            this.gConsole.TabStop = false;
            this.gConsole.Text = "Console";
            // 
            // tInput
            // 
            this.tInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tInput.Location = new System.Drawing.Point(20, 200);
            this.tInput.Name = "tInput";
            this.tInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tInput.Size = new System.Drawing.Size(797, 35);
            this.tInput.TabIndex = 0;
            this.tInput.Text = "";
            // 
            // tConsole
            // 
            this.tConsole.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tConsole.Cursor = System.Windows.Forms.Cursors.Default;
            this.tConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tConsole.Location = new System.Drawing.Point(20, 39);
            this.tConsole.Name = "tConsole";
            this.tConsole.ReadOnly = true;
            this.tConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tConsole.Size = new System.Drawing.Size(797, 196);
            this.tConsole.TabIndex = 0;
            this.tConsole.Text = "";
            // 
            // browserDiag
            // 
            this.browserDiag.ShowNewFolderButton = false;
            // 
            // bBrowse
            // 
            this.bBrowse.AutoSize = true;
            this.bBrowse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBrowse.Location = new System.Drawing.Point(20, 788);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(429, 40);
            this.bBrowse.TabIndex = 1;
            this.bBrowse.Text = "Browse Directory for Databases";
            this.bBrowse.UseVisualStyleBackColor = true;
            // 
            // VisualQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1328, 894);
            this.Controls.Add(this.gDatabases);
            this.Controls.Add(this.gConsole);
            this.Controls.Add(this.gMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1350, 950);
            this.Name = "VisualQuery";
            this.Text = "Visual Query";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gDatabases.ResumeLayout(false);
            this.gDatabases.PerformLayout();
            this.gConsole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gDatabases;
        private System.Windows.Forms.GroupBox gMenu;
        private System.Windows.Forms.GroupBox gConsole;
        private System.Windows.Forms.TreeView tDatabases;
        private System.Windows.Forms.RichTextBox tConsole;
        private System.Windows.Forms.RichTextBox tInput;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.FolderBrowserDialog browserDiag;
    }
}

