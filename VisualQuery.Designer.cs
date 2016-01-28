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
            this.TableView = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCurrentTable = new System.Windows.Forms.Label();
            this.bRefresh = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bDetach = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.gDatabases.SuspendLayout();
            this.gConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.MainMenu.SuspendLayout();
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
            this.gDatabases.Size = new System.Drawing.Size(472, 889);
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
            this.tDatabases.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tDatabases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDatabases.Location = new System.Drawing.Point(20, 73);
            this.tDatabases.Name = "tDatabases";
            this.tDatabases.Size = new System.Drawing.Size(432, 796);
            this.tDatabases.TabIndex = 0;
            this.tDatabases.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tDatabases_NodeMouseDoubleClick);
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
            this.gMenu.Size = new System.Drawing.Size(1524, 69);
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
            this.gConsole.Location = new System.Drawing.Point(488, 563);
            this.gConsole.Name = "gConsole";
            this.gConsole.Padding = new System.Windows.Forms.Padding(20);
            this.gConsole.Size = new System.Drawing.Size(978, 367);
            this.gConsole.TabIndex = 2;
            this.gConsole.TabStop = false;
            this.gConsole.Text = "Console";
            // 
            // tInput
            // 
            this.tInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tInput.Location = new System.Drawing.Point(20, 312);
            this.tInput.Name = "tInput";
            this.tInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tInput.Size = new System.Drawing.Size(938, 35);
            this.tInput.TabIndex = 0;
            this.tInput.Text = "";
            // 
            // tConsole
            // 
            this.tConsole.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tConsole.Cursor = System.Windows.Forms.Cursors.Default;
            this.tConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.tConsole.Location = new System.Drawing.Point(20, 43);
            this.tConsole.Name = "tConsole";
            this.tConsole.ReadOnly = true;
            this.tConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tConsole.Size = new System.Drawing.Size(938, 252);
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
            // TableView
            // 
            this.TableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableView.BackgroundColor = System.Drawing.Color.White;
            this.TableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(537, 114);
            this.TableView.Name = "TableView";
            this.TableView.RowTemplate.Height = 28;
            this.TableView.Size = new System.Drawing.Size(850, 423);
            this.TableView.TabIndex = 3;
            //this.TableView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableView_Changed);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1478, 33);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(203, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TutorialToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // TutorialToolStripMenuItem
            // 
            this.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem";
            this.TutorialToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.TutorialToolStripMenuItem.Text = "&Tutorial";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // lCurrentTable
            // 
            this.lCurrentTable.AutoSize = true;
            this.lCurrentTable.Location = new System.Drawing.Point(825, 77);
            this.lCurrentTable.Name = "lCurrentTable";
            this.lCurrentTable.Size = new System.Drawing.Size(127, 20);
            this.lCurrentTable.TabIndex = 5;
            this.lCurrentTable.Text = "DataBase Name";
            this.lCurrentTable.Visible = false;
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(537, 71);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(90, 33);
            this.bRefresh.TabIndex = 6;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Visible = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(12, 933);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(55, 20);
            this.lStatus.TabIndex = 7;
            this.lStatus.Text = "Ready";
            // 
            // bDetach
            // 
            this.bDetach.Location = new System.Drawing.Point(633, 71);
            this.bDetach.Name = "bDetach";
            this.bDetach.Size = new System.Drawing.Size(90, 33);
            this.bDetach.TabIndex = 6;
            this.bDetach.Text = "Detach";
            this.bDetach.UseVisualStyleBackColor = true;
            this.bDetach.Visible = false;
            this.bDetach.Click += new System.EventHandler(this.bDetach_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(729, 71);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(90, 33);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Visible = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // VisualQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 962);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDetach);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.lCurrentTable);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.gDatabases);
            this.Controls.Add(this.gConsole);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.gMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(1500, 1018);
            this.Name = "VisualQuery";
            this.Text = "Visual Query";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gDatabases.ResumeLayout(false);
            this.gConsole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
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
        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.Label lCurrentTable;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bDetach;
        private System.Windows.Forms.Button bSave;
    }
}

