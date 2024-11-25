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
    public partial class frmAdm_Login : Form
    {
        public frmAdm_Login()
        {
            InitializeComponent();
        }

        FitTrack_DataSetTableAdapters.Adm_SetupTableAdapter AA = new FitTrack_DataSetTableAdapters.Adm_SetupTableAdapter();


        private int LoginAttempt = 0;
        public static string AdmUsName,AdmID;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //restricting the login attempt if user does over 3 times
            if (LoginAttempt == 3)
            {
                MessageBox.Show("Login Failed ! Your Login Attempt Limit has been reached.", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }      
            else if (txtAdmUsname.Text == "")
            {
                MessageBox.Show("Please enter your Username", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtAdmPw.Text == "")
            {
                MessageBox.Show("Please enter your Password", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            else
            {

                DataTable dt = new DataTable();

                dt = AA.Get_Adm_Data(txtAdmUsname.Text, txtAdmPw.Text);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    dgvadm.DataSource = dt;
                    AdmID = dgvadm[0, 0].Value.ToString();
                    AdmUsName = dgvadm[1, 0].Value.ToString();

                    frm_Adm_HomePage SH = new frm_Adm_HomePage();
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

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Adm_Setup Adm = new frm_Adm_Setup();
            Adm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdmPw.Text = null;
            txtAdmUsname.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
