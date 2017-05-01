using League_of_Legends_2;
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

namespace LoL_Helper
{
    public partial class SummonerSpells : Form

    {
        DB db = new DB();
        Color selectedTabColor = Color.FromArgb(255, 250, 132);
        public void colorizeSelected(object sender)
        {
            foreach (Control p in this.Controls)
                if (p.GetType() == typeof(PictureBox))
                    p.BackColor = Color.Black;

            PictureBox that = sender as PictureBox;
            that.BackColor = selectedTabColor;
        }

        public void fillSummonerSpells(String[] spells)
        {
            lblItemName.Text = spells[0];
            string path = "../images/summoner_spells/" + lblItemName.Text.ToString() + ".png";
            if (File.Exists(path))
            {
                pbSpells.Image = Image.FromFile(@path);
            }
            tbSpCd.Text = spells[3];
            tbSpRSL.Text = spells[1];
            rtbSpDesc.Text = spells[2];
            tbSpType.Text = db.select("select summoner_type_name from summoner_spell_type where summoner_type_id = " + Convert.ToInt32(spells[4]));
        }

        public SummonerSpells()
        {
            InitializeComponent();
        }

        private void SummonerSpells_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
            tbSpType.Text = "Defensive";
            tbSpCd.Text = "210 Seconds";
            tbSpRSL.Text = "6";
            rtbSpDesc.Text = "Shields your champion for 115-455 (depending on champion level) for 2 seconds";

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Barrier\"");
            fillSummonerSpells(result);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Clairvoyance\"");
            fillSummonerSpells(result);
        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Clarity\"");
            fillSummonerSpells(result);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Cleanse\"");
            fillSummonerSpells(result);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Exhaust\"");
            fillSummonerSpells(result);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Flash\"");
            fillSummonerSpells(result);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Ghost\"");
            fillSummonerSpells(result);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Heal\"");
            fillSummonerSpells(result);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Ignite\"");
            fillSummonerSpells(result);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Recall\"");
            fillSummonerSpells(result);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Smite\"");
            fillSummonerSpells(result);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM Summoner_Spells WHERE Summoner_Spell = \"Teleport\"");
            fillSummonerSpells(result);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
