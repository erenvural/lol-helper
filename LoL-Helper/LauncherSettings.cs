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
    public partial class LauncherSettings : Form
    {

        string launcherPath = "";

        public LauncherSettings()
        {
            InitializeComponent();
        }

        public void detectedLauncher() {
            MessageBox.Show("We succesfully detect the launcher location. Please click Start Game", "Launcher Locate Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnStartGame.Enabled = true;
            btnStartGame.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] paths = {"C:\\Riot Games\\League of Legends\\lol.launcher.exe", "G:\\Games\\League of Legends\\lol.launcher.exe"};
            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    launcherPath = path;
                    break;
                }
            }

            if (launcherPath == "")
            {
                DialogResult yes = new DialogResult();
                yes = MessageBox.Show("We can not detect the launcher location. Please browse the launcher location. Do you want browse now?", "Launcher Locate Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (yes == DialogResult.Yes)
                {
                    DialogResult result = file.ShowDialog();
                    if (result.ToString() == "OK")
                    {
                        launcherPath = file.FileName;
                        detectedLauncher();
                    }
                }
            }
            else
            {
                detectedLauncher();
            }

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@launcherPath);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetLanguage_Click(object sender, EventArgs e)
        {
            string[] originalFile = {
                            "na,            na,            en_US,                                                                                                                                                          A",
                            "br,            br,            pt_BR,                                                                                                                                                          A",
                            "tr,            tr,            tr_TR,                                                                                                                                                         A",
                            "euw,           euw,           en_GB|de_DE|es_ES|fr_FR|it_IT,                                                                                                                                  A",
                            "eune,          eune,          en_GB|cs_CZ|el_GR|hu_HU|pl_PL|ro_RO,                                                                                                                            A",
                            "ru,            ru,            ru_RU,                                                                                                                                                          A",
                            "la1,           la1,           es_MX,                                                                                                                                                          A",
                            "la2,           la2,           es_MX,                                                                                                                                                          A",
                            "oc1,           oc1,           en_AU,                                                                                                                                                          A"
                         };
            string[] englishFile = {
                            "na,            na,            en_US,                                                                                                                                                          A",
                            "br,            br,            pt_BR,                                                                                                                                                          A",
                            "tr,            tr,            en_GB,                                                                                                                                                         A",
                            "euw,           euw,           en_GB|de_DE|es_ES|fr_FR|it_IT,                                                                                                                                  A",
                            "eune,          eune,          en_GB|cs_CZ|el_GR|hu_HU|pl_PL|ro_RO,                                                                                                                            A",
                            "ru,            ru,            ru_RU,                                                                                                                                                          A",
                            "la1,           la1,           es_MX,                                                                                                                                                          A",
                            "la2,           la2,           es_MX,                                                                                                                                                          A",
                            "oc1,           oc1,           en_AU,                                                                                                                                                          A"
                         };
            string[] turkishFile = {
                            "na,            na,            en_US,                                                                                                                                                          A",
                            "br,            br,            pt_BR,                                                                                                                                                          A",
                            "tr,            tr,            tr_TR,                                                                                                                                                         A",
                            "euw,           euw,           tr_TR,                                                                                                                                  A",
                            "eune,          eune,          en_GB|cs_CZ|el_GR|hu_HU|pl_PL|ro_RO,                                                                                                                            A",
                            "ru,            ru,            ru_RU,                                                                                                                                                          A",
                            "la1,           la1,           es_MX,                                                                                                                                                          A",
                            "la2,           la2,           es_MX,                                                                                                                                                          A",
                            "oc1,           oc1,           en_AU,                                                                                                                                                          A"
                         };

            // Determine the path
            string path = "";
            string[] pathList = launcherPath.Split('\\');
            for (int i = 0; i < pathList.Length - 1; i++)
            {
                path += pathList[i] + '\\';
            }
            path += "RADS\\projects\\lol_patcher\\managedfiles\\0.0.0.0\\regions.txt";

            if (comboBox1.SelectedIndex == 0)
            {
                System.IO.File.WriteAllLines(@path, englishFile);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                System.IO.File.WriteAllLines(@path, turkishFile);
            }
            else
            {
                System.IO.File.WriteAllLines(@path, originalFile);
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSetLanguage.Visible = true;
            btnSetLanguage.Enabled = true;
        }
    }
}
