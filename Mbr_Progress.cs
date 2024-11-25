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
    public partial class frm_Mbr_Progress : Form
    {
        public frm_Mbr_Progress()
        {
            InitializeComponent();
        }
        FitTrack_DataSetTableAdapters.ActivityTableAdapter ObjAct = new FitTrack_DataSetTableAdapters.ActivityTableAdapter();
        FitTrack_DataSetTableAdapters.Member_DataTableAdapter ObjMbrData = new FitTrack_DataSetTableAdapters.Member_DataTableAdapter();
        FitTrack_DataSetTableAdapters.ProgressTableAdapter ObjP = new FitTrack_DataSetTableAdapters.ProgressTableAdapter();
        FitTrack_DataSetTableAdapters.Detailed_ProgressTableAdapter ObjPD = new FitTrack_DataSetTableAdapters.Detailed_ProgressTableAdapter();

        DataTable DTDatagrid = new DataTable();
        DataRow DR;

        public static string ProgressID;
        int Remove;

        public void SystID()
        {
            DataTable dt = new DataTable();
            dt = ObjP.GetData();

            if (dt.Rows.Count == 0)
            {
                ProgressID = "P_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                // Get the last ID from Progress Table
                string PastID = dt.Rows[size][0].ToString();
                int LatestID = Convert.ToInt32(PastID.Substring(2, 3));

                if (LatestID >= 1 && LatestID < 9)
                {
                    ProgressID = "P_00" + (LatestID + 1);
                }
                else if (LatestID >= 9 && LatestID < 99)
                {
                    ProgressID = "P_0" + (LatestID + 1);
                }
                else if (LatestID >= 99 && LatestID < 999)
                {
                    ProgressID = "P_" + (LatestID + 1);
                }
            }
        }

        private void PgDisplay()
        {
            DR = DTDatagrid.NewRow();

            DTDatagrid.Columns.Add("Activity Name").ToString();
            DTDatagrid.Columns.Add("Weight").ToString();
            DTDatagrid.Columns.Add("Pound").ToString();
            DTDatagrid.Columns.Add("Time Frame").ToString();
            DTDatagrid.Columns.Add("Calories Burned").ToString();
            DTDatagrid.Columns.Add("MET").ToString();
            dgvdisplay.DataSource = DTDatagrid;
            dgvdisplay.Refresh();
        }



        private void frm_Mbr_Progress_Load(object sender, EventArgs e)
        {
            SystID();
            BtnRemove.Enabled = false;

            PgDisplay();
            // Member Table
            DataTable Dt = new DataTable();
            string MbrId = frm_Mbr_Login.MbrID;
            Dt = ObjMbrData.CheckData(MbrId);

            if (Dt.Rows.Count > 0)
            {
                lblUsname.Text = Dt.Rows[0][1].ToString();
                lblWeight.Text = Dt.Rows[0][2].ToString();
                lblStart.Text = Dt.Rows[0][3].ToString();
                lblOverallDay.Text = Dt.Rows[0][4].ToString();
                lblTarget.Text = Dt.Rows[0][5].ToString();
                lblPound.Text = Convert.ToString(Convert.ToInt32(lblWeight.Text) * 2.20442); // 1kg is equaivalent to 2.20442
            }

            //Activities Table
            DataTable dtAct = new DataTable();
            dtAct = ObjAct.GetData();
            if (dtAct.Rows.Count > 0)
            {
                for (int i = 0; i < dtAct.Rows.Count; i++)
                {
                    cboact.Items.Add(dtAct.Rows[i][1].ToString());
                }
            }

        }

        private void btnProgresses_Click(object sender, EventArgs e)
        {
            frm_Mbr_Progress MP = new frm_Mbr_Progress();
            MP.Show();
            this.Hide();
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            frm_Mbr_Goal MG = new frm_Mbr_Goal();
            MG.Show();
            this.Hide();
        }

        private void btnMbrReg_Click(object sender, EventArgs e)
        {
            Frm_Mbr_Setup MS = new Frm_Mbr_Setup();
            MS.Show();
            this.Hide();
        }

        private void Btnadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cboact.SelectedIndex == -1)
                { 
                    MessageBox.Show("Please Choose Activity Name ");
                    cboact.Focus(); 
                }
                else if (txtTimeFrame.Text == "")
                {
                    MessageBox.Show("Please Enter Time Frame ");
                    txtTimeFrame.Focus();
                }
                else
                { 
                    int TimeFrame, OverallAct = 0;
                    decimal Weight, Met, TCB;
                    string MbrID, MbrUsName, ActName;
                                  
                    MbrID = frm_Mbr_Login.MbrID;
                    MbrUsName = lblUsname.Text;
                    ActName = cboact.SelectedItem.ToString();
                    TimeFrame = Convert.ToInt32(lblOverallDay.Text);
                    Weight = Convert.ToDecimal(lblWeight.Text);
                    Met = Convert.ToDecimal(lblmet.Text);

                    TCB = (Met * Weight * TimeFrame) / 60; //Calory Burned Formula 

                    DR = DTDatagrid.NewRow();

                    int Fg = -1;
                    for (int i = 0; i < dgvdisplay.Rows.Count; i++)
                    {
                        if (Convert.ToString(dgvdisplay.Rows[i].Cells["Activity Name"].Value) == cboact.Text)
                        {
                            MessageBox.Show("Your Progress is duplicated Entry");
                            Fg = i;
                            break;
                        }

                    }
                    if (Fg == -1)
                    {


                        DR[0] = ActName;
                        DR[1] = Weight;
                        DR[2] = lblPound.Text;
                        DR[3] = TimeFrame;
                        DR[4] = Met;
                        DR[5] = TCB;

                        DTDatagrid.Rows.Add(DR);
                        dgvdisplay.DataSource = DTDatagrid;
                        dgvdisplay.Refresh();

                        for (int i = 0; i < dgvdisplay.Rows.Count; i++)
                        {
                            TCB += Convert.ToDecimal(dgvdisplay.Rows[i].Cells[5].Value);
                            OverallAct += 1;
                        }
                        lblTcb.Text = Convert.ToString(TCB);
                        lblOverallAct.Text = Convert.ToString(OverallAct);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Input");
            }

        }

        private void cboact_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable Dtactivity = new DataTable();
            string Act;
            Act = cboact.SelectedItem.ToString();
            Dtactivity = ObjAct.CheckData(Act);
            if (Dtactivity.Rows.Count > 0)
            {
                lblmet.Text = Dtactivity.Rows[0]["MET"].ToString();
            }
        }
        private void BtnRemove_Click_1(object sender, EventArgs e)
        {
            int i = dgvdisplay.CurrentRow.Index;
            decimal RecentData = Convert.ToDecimal(dgvdisplay["Calories Burned", i].Value.ToString());
            decimal Tempo = Convert.ToDecimal(lblTcb.Text);

            lblTcb.Text = Convert.ToString(Tempo - RecentData);
            lblOverallAct.Text = Convert.ToString(Convert.ToDecimal(lblOverallAct.Text) - 1);

            this.dgvdisplay.Rows.RemoveAt(Remove);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (dgvdisplay.Rows.Count < 0)
            {
                MessageBox.Show("None of the activities has done yet! ");
            }
            else
            { 
                string Status = "Progress";
                string TCB;
                DateTime ProgressDate;             
                int OverallActivity;
                TCB = lblTcb.Text;
                
                OverallActivity = Convert.ToInt32(lblOverallDay.Text);
                ProgressDate = Convert.ToDateTime(lblStart.Text);

                ObjP.Insert_Progress_Query(ProgressID, ProgressDate.ToString(),frm_Mbr_Login.MbrID, OverallActivity, TCB, Status);

                MessageBox.Show("Your Progress is saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                      

            }
        }
        private void dgvdisplay_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            BtnRemove.Enabled = true;
            Remove = dgvdisplay.CurrentRow.Index;
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            decimal TargetWeight = Convert.ToDecimal(lblTarget.Text.ToString());

            decimal tcb = Convert.ToDecimal(lblTcb.Text.ToString());
            decimal Weight_Loss = tcb / (3850 * 2) ;

            if (Weight_Loss >= TargetWeight)
            {
                MessageBox.Show("You have achieved your goal Successfully!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else 
            {
                MessageBox.Show("Sorry,You still need to reach your goal", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
