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
    public partial class Masteries : Form
    {
        Color selectedTabColor = Color.FromArgb(255, 250, 132);
        public void colorizeSelected(object sender)
        {
            foreach (Control p in pnlItemList.Controls)
                if (p.GetType() == typeof(PictureBox))
                    p.BackColor = Color.Black;

            PictureBox that = sender as PictureBox;
            that.BackColor = selectedTabColor;
        }

        public Masteries()
        {
            InitializeComponent();
        }

        private void Masteries_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
            txtbMasteryRank.Text = "1";
            txtbMasterRPO.Text = "12";
            txtbMasterRPC.Text = "13";
            txtbMasterDesc.Text = "Reduces the total damage taken from critical strikes by 10%";


        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbItemCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MasteriesTreePlanner mTp_window = new MasteriesTreePlanner();
            mTp_window.ShowDialog();
        }

        private void pnlItemList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
