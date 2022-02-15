using Newtonsoft.Json;
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

namespace Fnaf99
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            aes.Text = Program.settings.AESKey;
            exeName.Text = Program.settings.gameName;
            pakPath.Text = Program.settings.pakFolder;
            unrealVersion.Text = Program.settings.ue4version;
        }

        private void aes_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Program.settings.AESKey = aes.Text;
            Program.settings.gameName = exeName.Text;
            Program.settings.pakFolder = pakPath.Text;
            Program.settings.ue4version = unrealVersion.Text;
            var newSettings = JsonConvert.SerializeObject(Program.settings);
            File.WriteAllText("settings.json", newSettings);
            Application.Restart();

        }
    }
}
