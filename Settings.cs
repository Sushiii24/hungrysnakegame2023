using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hungry_Snake2._0
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void bar1_Click(object sender, EventArgs e)
        {

        }

        private void settings_btn_Click(object sender, EventArgs e)
        {

        }

        private void homebtn3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard=new Dashboard();
            dashboard.Show();

            Settings settings=new Settings();
            settings.Hide();
        }

       
    }
}
