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
    public partial class frm_MbrActivities : Form
    {

        public frm_MbrActivities()
        {
            InitializeComponent();
        }
        FitTrack_DataSetTableAdapters.ActivityTableAdapter ObjAct = new FitTrack_DataSetTableAdapters.ActivityTableAdapter();
        DataTable dt = new DataTable();

        //Syst = System-Generated ID
        public void SystID()
        {
            DataTable dtSystID = new DataTable();
            dtSystID = ObjAct.GetData();

            if (dtSystID.Rows.Count == 0)
            {
                lblactid.Text = "A_001";

            }
            else
            {
                int Count = dtSystID.Rows.Count - 1;  // Last Admin ID from dt
                string PastID = dtSystID.Rows[Count][0].ToString();
                int LatestID = Convert.ToInt32(PastID.Substring(2, 3));

                if (LatestID >= 0 && LatestID < 9)
                {
                    lblactid.Text = "A_00" + (LatestID + 1);
                }
                else if (LatestID >= 9 && LatestID < 99)
                {
                    lblactid.Text = "A_0" + (LatestID + 1);
                }
                else if (LatestID >= 99 && LatestID < 999)
                {
                    lblactid.Text = "A_" + (LatestID + 1);
                }

            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string MET = txtMet.Text;
            if (txtactname.Text == null)
            {
                MessageBox.Show("Please input Activity Name!", "Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);       
            }
            else if (txtMet.Text == null)
            {
                MessageBox.Show("Please input MET!", "Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);       
            }
            else if (txtmt1.Text == null)
            {
                MessageBox.Show("Please input metric 1 Name!", "Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            else if (txtmt2.Text == null)
            {
                MessageBox.Show("Please input metric 2 Name!", "Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (txtmt3.Text == null)
            {
                MessageBox.Show("Please input metric 3 Name!", "Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (!MET.Any(char.IsDigit))
            {
                MessageBox.Show("Please input Digit only!", "Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                ObjAct.Insert_Act_Query(lblactid.Text, txtactname.Text, txtmt1.Text, txtmt2.Text, txtmt3.Text, txtMet.Text);
                MessageBox.Show("Successfully Saved your activity!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt = ObjAct.GetData();

                dgvdisplay.DataSource = dt;
                dgvdisplay.Refresh();

                SystID();
            }
        }

        private void frm_MbrActivities_Load(object sender, EventArgs e)
        {
           
            dgvdisplay.DataSource = ObjAct.GetData();
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            SystID();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btnActivities_Click(object sender, EventArgs e)
        {
            frm_MbrActivities MA = new frm_MbrActivities();
            MA.Show();
            this.Hide();
        }

        private void btnMbrReg_Click(object sender, EventArgs e)
        {
            Frm_Mbr_Setup MS = new Frm_Mbr_Setup();
            MS.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ObjAct.Update_Act_Query(lblactid.Text, txtactname .Text ,txtmt1 .Text ,txtmt2.Text,txtmt3.Text,txtMet.Text.ToString ()); 
            MessageBox.Show("You have Successfully Updated!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information); 

            dt = ObjAct.GetData(); 

            dgvdisplay.DataSource = dt;
            dgvdisplay.Refresh(); 
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ObjAct.Delete_Act_Query(lblactid.Text);
            MessageBox.Show("You have Successfully Deleted!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            dt = ObjAct.GetData();

            dgvdisplay.DataSource = dt;
            dgvdisplay.Refresh(); 
        
        }

        private void dgvdisplay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = this.dgvdisplay.Rows[e.RowIndex];

            lblactid.Text = row.Cells[0].Value.ToString();
            txtactname.Text = row.Cells[1].Value.ToString();
            txtmt1.Text = row.Cells[2].Value.ToString();
            txtmt2.Text = row.Cells[3].Value.ToString();
            txtmt3.Text = row.Cells[4].Value.ToString();

            btndelete.Enabled = true;
            btnupdate.Enabled = true;

        }

        private void btnAdmReg_Click(object sender, EventArgs e)
        {


            frm_Adm_Setup AA = new frm_Adm_Setup();
            AA.Show();
            this.Hide();
        }

        private void btnregmbr_Click(object sender, EventArgs e)
        {


            Frm_Mbr_Setup MA = new Frm_Mbr_Setup();
            MA.Show();
            this.Hide();
        }

    }
}
