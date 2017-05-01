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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Champions champions_window = new Champions();
            champions_window.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Items items_window = new Items();
            items_window.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SummonerSpells sp_window = new SummonerSpells();
            sp_window.ShowDialog();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Runes runes_window = new Runes();
            runes_window.ShowDialog();
        }

        private void btnMasteries_Click(object sender, EventArgs e)
        {
            Masteries masteries_window = new Masteries();
            masteries_window.ShowDialog();
        }

        private void btnTerminology_Click(object sender, EventArgs e)
        {
            Terminology terminology_window = new Terminology();
            terminology_window.ShowDialog();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GameTips gt = new GameTips();
            gt.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string server = "";
            switch (cbServer.Text)
            {
                case "Turkey":
                    server = "TR";
                    break;
                case "North America":
                    server = "NA";
                    break;
                case "Europe West":
                    server = "EUW";
                    break;
                case "Europe Nordic & East":
                    server = "EUNE";
                    break;
                case "Brazil":
                    server = "BR";
                    break;
                case "Russia":
                    server = "RU";
                    break;
                case "Latin America North":
                    server = "LAN";
                    break;
                case "Latin America South":
                    server = "LAS";
                    break;
                case "Ocenia":
                    server = "OCE";
                    break;
                default:
                    break;
            }
            string url = "http://www.lolnexus.com/" + server + "/search?name=" + tbUsername.Text + "&region=" + server;
            System.Diagnostics.Process.Start(url);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string server = "";
            switch (cbServer.Text)
            {
                case "Turkey":
                    server = "TR";
                    break;
                case "North America":
                    server = "NA";
                    break;
                case "Europe West":
                    server = "EUW";
                    break;
                case "Europe Nordic & East":
                    server = "EUNE";
                    break;
                case "Brazil":
                    server = "BR";
                    break;
                case "Russia":
                    server = "RU";
                    break;
                case "Latin America North":
                    server = "LAN";
                    break;
                case "Latin America South":
                    server = "LAS";
                    break;
                case "Ocenia":
                    server = "OCE";
                    break;
                default:
                    break;
            }
            string url = "http://www.lolking.com/search?name=" + tbUsername.Text + "&region=" + server;
            System.Diagnostics.Process.Start(url);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LauncherSettings launcher = new LauncherSettings();
            launcher.ShowDialog();
        }
    }
}
