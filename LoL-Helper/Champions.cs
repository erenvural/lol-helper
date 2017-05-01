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
    public partial class Champions : Form
    {
        DB db = new DB();
        Color selectedTabColor = Color.FromArgb(255, 250, 132);
        int firstTwo = 0;
        string[] abilities;

        public void colorizeSelected(object sender)
        {
            foreach (Control p in pnlAbilityList.Controls)
                if (p.GetType() == typeof(PictureBox))
                    p.BackColor = Color.Black;

            PictureBox that = sender as PictureBox;
            that.BackColor = selectedTabColor;
        }

        public void fillChampionBlank() {
            string path = "../images/champions/" + cbChamp.Text.ToString() + ".png";
            if (File.Exists(path))
            {
                pbChampImage.Image = Image.FromFile(@path);
            }

            string[] result = db.select_as_array("SELECT * FROM champions WHERE Champion = \"" + cbChamp.Text + "\";");

            tbChampName.Text = result[1];
            tbChampAlias.Text = result[2];

            health_tb.Text = result[3];
            health_regen_tb.Text = result[4];
            mana_tb.Text = result[5];
            mana_regen_tb.Text = result[6];
            attack_damage_tb.Text = result[7];
            attack_speed_tb.Text = result[8];
            armor_tb.Text = result[9];
            magic_resist_tb.Text = result[10];
            movement_speed_tb.Text = result[11];
            tbIpCost.Text = result[12];
            tbRpCost.Text = result[13];

            tbChampHomeland.Text = db.select("select homeland_name from homeland where homeland_id = " + Convert.ToInt32(result[14]));

            abilities = db.select_as_multirow_array("SELECT ABILITIY FROM abilites WHERE CHAMPIONS_champion_id = " + result[0] + ";")
                            .Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => s.Trim())
                            .Where(s => s != "")
                            .ToArray();

            PictureBox[] abilitiesPictures = { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10 };
            //Clear all pictures
            foreach (var item in abilitiesPictures)
            {
                item.Image = null;
            }

            for (int i = 0; i < abilities.Length; i++)
            {
                if (abilities[i].Contains('/'))
                {
                    int indeks = abilities[i].IndexOf('/');
                    path = "../images/abilities/" + abilities[i].Substring(0, indeks-1) + ".png";
                }
                else if (abilities[i].Contains(':'))
                {
                    int indeks = abilities[i].IndexOf(':');
                    path = "../images/abilities/" + abilities[i].Substring(indeks+2) + ".png";
                }
                else
                {
                    path = "../images/abilities/" + abilities[i] + ".png";
                }
                
                if (File.Exists(path))
                {
                    abilitiesPictures[i].Image = Image.FromFile(@path);
                    abilitiesPictures[i].Enabled = true;
                }
            }

        }

        public void fillAbilityBlank(String[] ability)
        {
            txtAbilityName.Text = ability[1];
            tbAbilityType.Text = db.select("select abilities_type_name from abilities_type where abilities_type_id = " + Convert.ToInt32(ability[6]));
            tbAbilityCost.Text = ability[2];
            tbAbilityCooldown.Text = ability[4];
            tbAbilityRange.Text = ability[5];
            rtbAbilityDesc.Text = ability[2];

        }

        public Champions()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[0] + "\";");
            fillAbilityBlank(result);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[1] + "\";");
            fillAbilityBlank(result);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[2] + "\";");
            fillAbilityBlank(result);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[3] + "\";");
            fillAbilityBlank(result);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[4] + "\";");
            fillAbilityBlank(result);

        }

        private void Champions_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
            cbChamp.SelectedIndex = 0;

            cbChamp.DataSource = db.dataTable("SELECT champion FROM champions");
            cbChamp.DisplayMember = "Champion";
            cbChamp.SelectedIndex = 0;

            fillChampionBlank();

            
        }



        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void range_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlAbilityList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbChamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (firstTwo < 2)
            {
                firstTwo +=1;
            }
            else {
                fillChampionBlank();
            }
            
            

            

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[5] + "\";");
            fillAbilityBlank(result);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[6] + "\";");
            fillAbilityBlank(result);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[7] + "\";");
            fillAbilityBlank(result);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[8] + "\";");
            fillAbilityBlank(result);
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
            string[] result = db.select_as_array("SELECT * FROM abilites WHERE ABILITIY = \"" + abilities[9] + "\";");
            fillAbilityBlank(result);
        }

        private void pbChampImage_Click(object sender, EventArgs e)
        {

        }

        private void btnStory_Click(object sender, EventArgs e)
        {
            string url = "http://gameinfo.eune.leagueoflegends.com/en/game-info/champions/" + cbChamp.Text.ToLower() + "/#champion-lore";
            System.Diagnostics.Process.Start(url);
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
