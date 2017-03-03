using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    public partial class WelCome : Form
    {
        public WelCome()
        {
            InitializeComponent();
        }

        private void newStreamUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       /* private void traineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }*/

        private void traineeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_newtraregnav ntr = new frm_newtraregnav();
            ntr.Show();
            this.Hide();
        }
    }
}
