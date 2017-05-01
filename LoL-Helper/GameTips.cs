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
    public partial class GameTips : Form
    {
        DB db = new DB();
        int firstTwo = 0;
        
        public GameTips()
      
        {
            InitializeComponent();
        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameTips_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
            
            cbChamp.DataSource = db.dataTable("SELECT mydb.lanetip.Champion FROM mydb.lanetip");
            cbChamp.DisplayMember = "Champion";
            cbChamp.SelectedIndex = 0;

        }

        private void cbChamp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (firstTwo < 1)
            {
                firstTwo += 1;
            }
            else
            {
                fillAllBlank();
            }

        }

        public void fillAllBlank()
        {
            string path = "../images/champions/" + cbChamp.Text.ToString() + ".png";
            if (File.Exists(path))
            {
                pbChamp.Image = Image.FromFile(@path);
            }

            
            string[] result1 = db.select_as_array("SELECT * FROM mydb.lanetip WHERE mydb.lanetip.Champion =\"" + cbChamp.Text.ToString() + "\";");
            tbLaneTip.Text = result1[1];


            counters = db.select_as_multirow_array("select mydb.counter.counter from mydb.counter where mydb.counter.Champion= \"" + cbChamp.Text.ToString() + "\";")
                            .Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => s.Trim())
                            .Where(s => s != "")
                            .ToArray();

            tbC1.Text = counters[0];
            tbC2.Text = counters[1];

            string path1 = "../images/champions/" + tbC1.Text.ToString() + ".png";

            try
            {

                if (File.Exists(path1))
            {
                pbCounterChamp1.Image = Image.FromFile(@path1);
            }


            }
            catch (Exception problem)
            {

               // MessageBox.Show(problem.Message.ToString());
            }
            
          

            string path2 = "../images/champions/" + tbC2.Text.ToString() + ".png";

            if (File.Exists(path2))
                {
                    pbCounterChamp2.Image = Image.FromFile(@path2);
                }


            string[] result3 = db.select_as_array("SELECT * FROM mydb.itemtips WHERE mydb.itemtips.Champion =\"" + cbChamp.Text.ToString() + "\";");
            tbItem.Text = result3[1];

            string path3 = "../images/items/" + tbItem.Text.ToString() + ".png";

            if (File.Exists(path3))
            {
                pbItem.Image = Image.FromFile(@path3);
            }


      

        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public string[] counters { get; set; }
    }
}
