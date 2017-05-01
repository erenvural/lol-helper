using League_of_Legends_2;
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
    public partial class Terminology : Form
    {
        DB db = new DB();
        int firstTwo = 0;
        public Terminology()
        {
            InitializeComponent();
        }


        private void Terminology_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
            lbDictionary.DataSource = db.dataTable("select terminology from mydb.terminology");
            lbDictionary.DisplayMember = "terminology";
            lbDictionary.SelectedIndex = 0;

            tbSearch.Text = "Write word...";
            this.ActiveControl = lbDictionary;
            tbSearch.GotFocus += new EventHandler(this.TextGotFocus);
            tbSearch.LostFocus += new EventHandler(this.TextLostFocus);
           
        }

        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Write word...")
            {
                tb.Text = "";
                tb.ForeColor= Color.Black;

            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text=="")
            {
                tb.Text = "Write word...";
                tb.ForeColor = Color.LightGray;
            }
        }


        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (firstTwo < 1)
            {
                firstTwo += 1;
            }
            else
            {
                fillDescBlank();
            }

            
        }

        private void fillDescBlank()
        {
             string[] result = db.select_as_array("SELECT * FROM mydb.terminology WHERE terminology = \"" + lbDictionary.Text + "\";");
             tbDesc.Text = result[1];
             lblWord.Text = result[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text=="Write word...")
            {
                lbDictionary.DataSource = db.dataTable("select terminology from mydb.terminology");
                lbDictionary.DisplayMember = "terminology";
                lbDictionary.SelectedIndex = 0;
            }
            else
            {
                lbDictionary.DataSource = db.dataTable("select mydb.terminology.terminology from mydb.terminology where mydb.terminology.terminology like '" + tbSearch.Text.ToString() + "%'");
                lbDictionary.DisplayMember = "terminology";

            }
           
            

        }
    }
}
