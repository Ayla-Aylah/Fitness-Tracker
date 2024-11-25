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
    public partial class  frm_Mbr_Login : Form
    {
        public frm_Mbr_Login()
        {
            InitializeComponent();
        }
        FitTrack_DataSetTableAdapters.Mbr_SetupTableAdapter MA = new FitTrack_DataSetTableAdapters.Mbr_SetupTableAdapter();

        private int LoginAttempt = 0;
        public static string MbrUsname, MbrID;

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Frm_Mbr_Setup Mbr = new Frm_Mbr_Setup();
            Mbr.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (LoginAttempt == 3)
            {
                MessageBox.Show("Login Failed ! Your Login Attempt Limit has been reached.", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtMbrPw == null)
            {

                MessageBox.Show("Please enter your Password", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }
            else if (txtMbrUsname == null)
            {

                MessageBox.Show("Please enter your Username", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {

                DataTable dt = new DataTable();

                dt = MA.Get_Mbr_data(txtMbrUsname.Text, txtMbrPw.Text);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    dvgmbr.DataSource = dt;
                
                    MbrID = dvgmbr[0, 0].Value.ToString();
                    MbrUsname = dvgmbr[1, 0].Value.ToString();

                    frm_Mbr_HomePage SH = new frm_Mbr_HomePage();
                    SH.Show();
                    this.Hide();
                }
                else
                {
                    LoginAttempt += 1;
                    MessageBox.Show(" Login Failed! You have tried" + LoginAttempt + " Login Attempt");
                }
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtMbrPw.Text = null;
            txtMbrUsname.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
