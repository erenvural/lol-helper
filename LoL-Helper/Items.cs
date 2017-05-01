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
    public partial class Items : Form
    {
        DB db = new DB();
        Color selectedTabColor = Color.FromArgb(255, 250, 132);
        public void colorizeSelected(object sender)
        {
            foreach (Control p in lvItemList.Controls)
                if (p.GetType() == typeof(PictureBox))
                    p.BackColor = Color.Black;

            PictureBox that = sender as PictureBox;
            that.BackColor = selectedTabColor;
        }

        public void fillItemBlank(string[] item)
        {
            lvRequiredItemList.Clear();
            string path = "../images/items/" + item[1] + ".png";
            if (File.Exists(path))
            {
                pbItemImage.Image = Image.FromFile(@path);
            }

            txtbItemType.Text = db.select("select types_name from item_type where type_id = " + Convert.ToInt32(item[5]));
            txtbItemCost.Text = item[4];
            txtboxItemFeature.Text = item[2];
            txtboxItemProperty.Text = item[3];
            lblItemName.Text = item[1];
            string resultReqItems = db.select_as_multirow_array("Select ITEM from items where item_number in (select ITEMS_required_item_number1 from items_has_required_items where ITEMS_item_number = " + item[0] + ")");

            string[] reqItems = resultReqItems.Split('-')
                            .Select(s => s.Trim())
                            .Where(s => s != "")
                            .ToArray();
            
            foreach (var reqItem in reqItems)
            {
                MessageBox.Show(reqItem);
                if (reqItem != null)
                {
                    lvRequiredItemList.Items.Add(reqItem.ToString());
                    string reqPath = "../images/items/" + reqItem + ".png";
                    if (File.Exists(reqPath))
                    {
                        ilRequiredItems.Images.Add(Image.FromFile(@reqPath));
                    }
                }                
            }
            lvRequiredItemList.LargeImageList = ilRequiredItems;
            lvRequiredItemList.SmallImageList = ilRequiredItems;

        }

        public Items()
        {
            InitializeComponent();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorizeSelected(sender);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fillItemList();   
        }


        private List<string> findCheckedFunctions()
        {
            List<string> checkedFunctions = new List<string>();

            foreach (Control p in pnlItemFunction.Controls)
            {
                if (p.GetType() == typeof(CheckBox))
                {
                    CheckBox c = (CheckBox)p;
                    if (c.Checked == true)
                    {
                        checkedFunctions.Add(c.Text);
                    }
                }
            }

            return checkedFunctions;
        }

        private void Items_Load(object sender, EventArgs e)
        {
            lblPage.Parent = pbHeader;
            lblPage.BackColor = Color.Transparent;
            lvItemList.LargeImageList = imageList1;
            lvItemList.SmallImageList = imageList1;

            fillItemList();

        }

        private void fillItemList()
        {
            List<int> functionIds = new List<int>();
            List<string> checkedFunctions = findCheckedFunctions();
            string query = "SELECT ITEM FROM items";
            foreach (var c in checkedFunctions)
            {
                functionIds.Add(Convert.ToInt32(db.select("SELECT function_id FROM mydb.item_function where functions_name = \"" + c + "\"")));
            }
            for (int i = 0; i < functionIds.Count; i++)
            {
                if (i == 0)
                {
                    query = query + " WHERE ITEM_FUNCTİON_function_id = " + functionIds[i] + " or ";
                }
                else if (i != functionIds.Count - 1)
                {
                    query = query + " ITEM_FUNCTİON_function_id = " + functionIds[i] + " or ";
                }
                else
                {
                    query = query + " ITEM_FUNCTİON_function_id = " + functionIds[i];
                }
            }

            lvItemList.Clear();
            DataTable table = db.dataTable(query);
            string[] items = table.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            int imgIndex = 0;
            foreach (var item in items)
            {
                
                string path = "../images/items/" + item + ".png";
                if (File.Exists(path))
                {
                    //MessageBox.Show(path);
                    imageList1.Images.Add(Image.FromFile(@path));
                }
                else
                {
                    //MessageBox.Show("The Image File is not exist");
                }
                lvItemList.Items.Add(item.ToString());
                foreach (ListViewItem itm in lvItemList.Items)
                {
                    if (lvItemList.Items.IndexOf(itm) == lvItemList.Items.Count - 1)
                    {
                        itm.ImageIndex = imgIndex++;
                    }
                }
             
            }
            

        }

        private void pbMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItemList.SelectedItems.Count > 0)
            {
                string item = lvItemList.SelectedItems[0].ToString().TrimEnd('}').Substring(15);
                string [] result = db.select_as_array("select * from items where ITEM = \"" + item + "\";");
                fillItemBlank(result);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            fillItemList();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            fillItemList();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            fillItemList();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            fillItemList();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            fillItemList();
        }
    }
}
