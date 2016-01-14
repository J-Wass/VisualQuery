using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace VisualQuery
{
    public partial class VisualQuery : Form
    {
        public VisualQuery()
        {
            InitializeComponent();
            tInput.KeyPress += new KeyPressEventHandler(tInput_Enter);
            tDatabases.NodeMouseClick += new TreeNodeMouseClickEventHandler(tDatabases_OnSelect);
        }

        public Dictionary<string, SQLiteConnection> DBlist = new Dictionary<string, SQLiteConnection>();
        public string currentDB = "";

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void tInput_Enter(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && tInput.Focused)
            {
                tConsole.AppendText(" " + tInput.Text);
                tInput.Clear();
                tConsole.ScrollToCaret();
                handleConsole(tInput.Text);
            }
        }

        private void handleConsole(string input)
        {
            //todo: go command line af here
        }

       private void bBrowse_Click(object sender, EventArgs e)
        {
            FileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = FileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                foreach(string database in FileDialog.FileNames)
                {
                    TreeNode tn = new TreeNode(Path.GetFileNameWithoutExtension(database));
                    tn = AuthAndExtract(tn);
                    //add each table from the database to the treenode
                    tDatabases.Nodes.Add(tn);
                }
            }
        }

        /// <summary>
        /// Authenticates a connection to a db and extracts the tables
        /// </summary>
        /// <returns></returns>
        private TreeNode AuthAndExtract(TreeNode db)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + db.Text + ".sqlite;Version=3;");
                DBlist.Add(db.Text, conn);
                foreach(string table in getTables(conn))
                {
                    db.Nodes.Add(table);
                }              
            }
            catch(SQLiteException ex)
            {
                //password encryption changes the bytes of a file, so sqlite.dll thinks the db isn't a db
                if( ex.ErrorCode == SQLiteErrorCode.NotADatabase)
                {
                    passPrompt:
                    string password = "";
                    if (InputBox("Password Required", db.Text +
                        " is password protected, please type in the key: ", ref password) == DialogResult.OK)
                    {
                        try
                        {
                            SQLiteConnection conn = new SQLiteConnection("Data Source=" + db.Text + ".sqlite;Version=3;Password=" + password);
                            DBlist[db.Text] = conn;
                            foreach (string table in getTables(conn))
                            {
                                db.Nodes.Add(table);
                            }
                        }
                        catch (SQLiteException e)
                        {
                            if (e.ErrorCode == SQLiteErrorCode.NotADatabase)
                            {
                                if(MessageBox.Show("Password is incorrect. Try again?", "Password Required", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    //no, gotos are not gone :D
                                    goto passPrompt;
                                }
                            }
                            else
                            {
                                MessageBox.Show(db.Name + " is corrupted. Unable to locate tables. " + ex.ErrorCode + " " + e.ErrorCode);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(db.Name + " is corrupted. Unable to locate tables. " + ex.ErrorCode);
                }
            }
            return db;
        }

        /// <summary>
        /// Returns the tables of a db connection as string[]
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        private string[] getTables(SQLiteConnection conn)
        {
            LinkedList<string> ret = new LinkedList<string>();
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type = 'table'", conn);
            SQLiteDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                ret.AddLast(reader.GetString(0));
            }
            return ret.ToArray();
        }

        private void tDatabases_OnSelect(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null) return;
            //if a DB is selected
            if (e.Node.Parent == null)
            {
                currentDB = e.Node.Text;
                gConsole.Text = "Console - " + currentDB;
            }
            //if a table is selected    
            else
            {
                currentDB = e.Node.Parent.Text;
                gConsole.Text = "Console - " + currentDB;
                ShowTable(currentDB, e.Node.Text);
            }
        }

        /// <summary>
        /// Displays a table in the middle of the form
        /// </summary>
        /// <param name="targetDB"></param>
        private void ShowTable(string targetDB, string targetTable)
        {
            SQLiteConnection conn;

            //if we can get the connection that's still open from the targetDB
            if(DBlist.TryGetValue(targetDB, out conn))
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM " + targetTable, conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                DataTable table = new DataTable(targetTable);
                table.Load(reader);
                TableView.DataSource = table;
                TableView.Show();
                TableView.ForeColor = Color.Black;
            }
        }
    }
}
