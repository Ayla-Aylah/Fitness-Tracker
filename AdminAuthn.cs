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
    public partial class frmAdminLogReg : Form
    {
        public frmAdminLogReg()
        {
            InitializeComponent();
            SystID();
        }

        FitTrack_DataSetTableAdapters.AdminAuthnTableAdapter objadm = new FitTrack_DataSetTableAdapters.AdminAuthnTableAdapter();
        DataTable dtadm = new DataTable();

        //Syst = System-Generated ID
        public void SystID()
        {
            lblAdmID.Text = "A_001";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdmEmail.Clear();
            txtAdmLglName.Clear();
            txtAdmPw.Clear();
            txtAdmUsName.Clear();
            lblAdmID.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            objadm.Insert(lblAdmID.Text, txtAdmUsName.Text, txtAdmLglName.Text, txtAdmPw.Text, txtAdmEmail.Text);
            MessageBox.Show("Successfully Registered");

        }
    }
}
