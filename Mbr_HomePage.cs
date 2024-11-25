using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitTrack_Assignment_Program
{
    public partial class frm_Mbr_HomePage : Form
    {
        public frm_Mbr_HomePage()
        {
            InitializeComponent();
        }





        private void btnGoals_Click(object sender, EventArgs e)
        {
            frm_Mbr_Goal MG = new frm_Mbr_Goal();
            MG.Show();
            this.Hide();
        }

        private void btnMbrReg_Click(object sender, EventArgs e)
        {

            Frm_Mbr_Setup Mbr = new Frm_Mbr_Setup();
            Mbr.Show();
            this.Hide();
        }

 

        private void btnProgresses_Click(object sender, EventArgs e)
        {

            frm_Mbr_Progress MP = new frm_Mbr_Progress();
            MP.Show();
            this.Hide();
        }

        private void myImage_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            
        }
    }
}
