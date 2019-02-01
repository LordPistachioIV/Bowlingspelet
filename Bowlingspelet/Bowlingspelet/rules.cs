using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowlingspelet
{
    public partial class rules : Form
    {
        public rules()
        {
            InitializeComponent();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            mainMenu openMain = new mainMenu();
            this.Close();
            openMain.Show();
        }
    }
}
