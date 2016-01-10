using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualQuery
{
    public partial class VisualQuery : Form
    {

        public VisualQuery()
        {
            InitializeComponent();
            tInput.KeyPress += new KeyPressEventHandler(tInput_Enter);
        }

        private void tInput_Enter(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && tInput.Focused)
            {
                tConsole.AppendText(" " + tInput.Text);
                tInput.Clear();
                tConsole.ScrollToCaret();
            }
        }


    }
}
