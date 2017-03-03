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

        private void courseDirectorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CouDirReg cr = new CouDirReg();
            cr.Show();
            this.Hide();
        }

        private void newTradeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTrade nt = new newTrade();
            nt.Show();
            this.Hide();
        }

        private void newOnTheJobTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_onjbtrreg oj = new frm_onjbtrreg();
            oj.Show();
            this.Hide();

        }

        private void newCourseDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CouDirAss cd = new CouDirAss();
            cd.Show();
            this.Hide();

        }

        private void tradeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trdtstregcs ttr = new trdtstregcs();
            ttr.Show();
            this.Hide();
        }

        private void onTheJobTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_onjbtrregnavi ojn = new frm_onjbtrregnavi();
            ojn.Show();
            this.Hide();

        }

        private void internalTrainingRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_itregnavi itn = new frm_itregnavi();
            itn.Show();
            this.Hide();

        }

        private void resourcePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResPerDetNvi rpn = new ResPerDetNvi();
            rpn.Show();
            this.Hide();

        }

        private void assessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssessorDetNavi adn = new AssessorDetNavi();
            adn.Show();
            this.Hide();

        }

        private void courseDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CouDirRegNavi crn = new CouDirRegNavi();
            crn.Show();
            this.Hide();

        }

        private void externalTrainingInsitituteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extrnltrinsnavi etn = new extrnltrinsnavi();
            etn.Show();
            this.Hide();

        }

        private void externalTrainingRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extrtraregnavi etrn = new extrtraregnavi();
            etrn.Show();
            this.Hide();


        }

        private void assessorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssessorDet ass = new AssessorDet();
            ass.Show();
            this.Hide();

        }

        private void internalTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_itreg it = new frm_itreg();
            it.Show();
            this.Hide();


        }

        private void externalTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_comdate etr = new txt_comdate();
            etr.Show();
            this.Hide();


        }

        private void resourcePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResPerDet rpd = new ResPerDet();
            rpd.Show();
            this.Hide();

        }

        private void externalInstituteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extrnltrinsreg etr = new extrnltrinsreg();
            etr.Show();
            this.Hide();

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CouPayment cp = new CouPayment();
            cp.Show();
            this.Hide();

        }

        private void assessorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AssPay ap = new AssPay();
            ap.Show();
            this.Hide();

        }

        private void resourcePersonToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
