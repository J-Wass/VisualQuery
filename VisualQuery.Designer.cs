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
            this.bAdd = new System.Windows.Forms.Button();
            this.tDatabases = new System.Windows.Forms.TreeView();
            this.gMenu = new System.Windows.Forms.GroupBox();
            this.gConsole = new System.Windows.Forms.GroupBox();
            this.tInput = new System.Windows.Forms.RichTextBox();
            this.tConsole = new System.Windows.Forms.RichTextBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.gDatabases.Controls.Add(this.bAdd);
            this.gDatabases.Controls.Add(this.tDatabases);
            this.gDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gDatabases.Location = new System.Drawing.Point(-2, 41);
            this.gDatabases.Name = "gDatabases";
            this.gDatabases.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.gDatabases.Size = new System.Drawing.Size(472, 855);
            this.gDatabases.TabIndex = 0;
            this.gDatabases.TabStop = false;
            this.gDatabases.Text = "Databases";
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(349, 30);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 33);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Open";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // tDatabases
            // 
            this.tDatabases.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDatabases.Location = new System.Drawing.Point(20, 73);
            this.tDatabases.Name = "tDatabases";
            this.tDatabases.Size = new System.Drawing.Size(432, 762);
            this.tDatabases.TabIndex = 0;
            this.tDatabases.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tDatabases_AfterSelect);
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
            this.gMenu.Size = new System.Drawing.Size(1374, 69);
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
            this.gConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tConsole.Location = new System.Drawing.Point(20, 43);
            this.tConsole.Name = "tConsole";
            this.tConsole.ReadOnly = true;
            this.tConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tConsole.Size = new System.Drawing.Size(797, 192);
            this.tConsole.TabIndex = 0;
            this.tConsole.Text = "";
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "fileDialog";
            this.FileDialog.Filter = "SQLite Database files|*.sqlite";
            this.FileDialog.Multiselect = true;
            this.FileDialog.Title = "Select SQLite database(s)";
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
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

