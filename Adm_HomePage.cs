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
    public partial class frm_Adm_HomePage : Form
    {
        public frm_Adm_HomePage()
        {
            InitializeComponent();
        }

        private void btnMbrList_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmReg_Click(object sender, EventArgs e)
        {

            frm_Adm_Setup AA = new frm_Adm_Setup();
            AA.Show();
            this.Hide();
        }

        private void btnMbrReg_Click(object sender, EventArgs e)
        {

            Frm_Mbr_Setup MA = new Frm_Mbr_Setup();
            MA.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            frm_MbrActivities MA = new frm_MbrActivities();
            MA.Show();
            this.Hide();
        }

 

        
    }
}
