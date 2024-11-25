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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdm_Login AL = new frmAdm_Login();
            AL.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frm_Mbr_Login ML = new frm_Mbr_Login();
            ML.Show();
            this.Hide();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
