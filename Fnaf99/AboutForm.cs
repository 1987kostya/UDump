using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fnaf99
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.donationalerts.com/r/1987kostya");
        }

        private void youtubeBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCZIXxTGxnemIujXCXOKjs7g");
        
        }
    }
}
