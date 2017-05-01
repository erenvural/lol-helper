using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Helper
{
    public partial class MasteriesTreePlanner : Form
    {
        public MasteriesTreePlanner()
        {
            InitializeComponent();
        }

        private void MasteriesTreePlanner_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Window.ScrollTo(80, 510);
        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
