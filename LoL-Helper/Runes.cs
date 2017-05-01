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
    public partial class Runes : Form
    {
        Color selectedTabColor = Color.FromArgb(255, 250, 132);
        public void colorizeSelected(object sender)
        {
            foreach (Control p in pnlRunesList.Controls)
                if (p.GetType() == typeof(PictureBox))
                    p.BackColor = Color.Black;

            PictureBox that = sender as PictureBox;
            that.BackColor = selectedTabColor;
        }
        public Runes()
        {
            InitializeComponent();
        }

        private void pbMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Runes_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
            cmbBoxEffect.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
