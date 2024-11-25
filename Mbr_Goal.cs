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
    public partial class frm_Mbr_Goal : Form
    {
        public frm_Mbr_Goal()
        {
            InitializeComponent();
        }

        FitTrack_DataSetTableAdapters.Mbr_GoalTableAdapter ObjGoal = new FitTrack_DataSetTableAdapters.Mbr_GoalTableAdapter();
        DataTable dt = new DataTable();

        public static string GId;
        //Syst = System-Generated ID
        public void SystID()
        {
            DataTable dtSystID = new DataTable();
            dtSystID = ObjGoal.GetData();

            if (dtSystID.Rows.Count == 0)
            {
                lblGoalId.Text = "G_001";

            }
            else
            {
                int Count = dtSystID.Rows.Count - 1;  // Last Admin ID from dt
                string PastID = dtSystID.Rows[Count][0].ToString();
                int LatestID = Convert.ToInt32(PastID.Substring(2, 3));

                if (LatestID >= 0 && LatestID < 9)
                {
                    lblGoalId.Text = "G_00" + (LatestID + 1);
                }
                else if (LatestID >= 9 && LatestID < 99)
                {
                    lblGoalId.Text = "G_0" + (LatestID + 1);
                }
                else if (LatestID >= 99 && LatestID < 999)
                {
                    lblGoalId.Text = "G_" + (LatestID + 1);
                }

            }

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtTW.Text = null;
            txtTimeFrame.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Mbr_HomePage MH = new frm_Mbr_HomePage();
            MH.Show();
            this.Hide();
        }
        private void lblusname_Click(object sender, EventArgs e)
        {
        }
        public static string MId;
        private void frm_Mbr_Goal_Load(object sender, EventArgs e)
        {
            lblusname.Text = frm_Mbr_Login.MbrUsname;
            MId = frm_Mbr_Login.MbrID;
            SystID();

        }
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan Dif;
            DateTime StartDate = dtpStart.Value;
            DateTime EndDate = dtpEnd.Value;

            Dif = EndDate - StartDate;

            txtTimeFrame.Text = Dif.TotalDays.ToString();
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
           
            if (Convert.ToInt32(txtTW.Text) >= 2 && Convert.ToInt32(txtTW.Text) <= 8)
            {
                int GoalInfo = ObjGoal.Insert_Goal_Query(lblGoalId.Text.ToString(), lblusname.Text, Convert.ToString(dtpStart.Value), Convert.ToString(dtpEnd.Value), Convert.ToInt32(txtTimeFrame.Text), Convert.ToInt32(txtTW.Text));
               
                if (GoalInfo > 0)
                {
                    MessageBox.Show("You have set your \"Goal\" successfully.","Success!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Make sure Your inputs are correct!");
            }      
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            frm_Mbr_Goal MG = new frm_Mbr_Goal();
            MG.Show();
            this.Hide();
        }

        private void btnProgresses_Click(object sender, EventArgs e)
        {
            frm_Mbr_Progress MP = new frm_Mbr_Progress();
            MP.Show();
            this.Hide();
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

    }
}
