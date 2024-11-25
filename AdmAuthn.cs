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
    public partial class frmAdmAuthn : Form
    {
        public frmAdmAuthn()
        {
            InitializeComponent();
            SystID();
        }

        FitTrack_DataSetTableAdapters.AdmAuthnTableAdapter objAdmAuthn = new FitTrack_DataSetTableAdapters.AdmAuthnTableAdapter();
        DataTable dtadm = new DataTable();

        //Syst = System-Generated ID
        public void SystID()
        {
            DataTable dtSystID = new DataTable();
            dtSystID = objAdmAuthn.GetData();

            if (dtSystID.Rows.Count == 0)
            {
                lblAdmID.Text = "A_001";

            }
            else
            {
                int Count = dtSystID.Rows.Count - 1;  // Last Admin ID from dt
                string PastID = dtSystID.Rows[Count][0].ToString(); 
                int LatestID = Convert.ToInt32(PastID.Substring(2,3));
                
                 if (LatestID >= 0 && LatestID < 9)
                {
                    lblAdmID.Text = "A_00" + (LatestID + 1);
                }
                else if (LatestID >= 9 && LatestID < 99)
                {
                    lblAdmID.Text = "A_0" +(LatestID + 1);
                }
                else if (LatestID >= 99 && LatestID < 999)
                {
                    lblAdmID.Text = "A_" + (LatestID + 1);
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdmEmail.Clear();
            txtAdmLglName.Clear();
            txtAdmPw.Clear();
            txtAdmUsName.Clear();
            lblAdmID.Text = "";
            SystID();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Username = txtAdmUsName.Text;
            string LglName = txtAdmLglName.Text;
            string Password = txtAdmPw.Text;

            //Controlling of Username Input 
            if (txtAdmUsName.Text == "")
            {
                MessageBox.Show("Please input your \"Username\"!", "Username Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txtAdmUsName.Focus();
            }
            else if (!Username.Any(char.IsDigit))
            {
                MessageBox.Show("Your \"Username\" should include at least 1 number!", "Username Input Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txtAdmUsName.Focus();
            }
            else if (!Username.Any(char.IsUpper))
            {
                MessageBox.Show("Your \"Username\" should include at least  1 Upper Case Letter!", "Username Input Failed", MessageBoxButtons.RetryCancel);
                txtAdmUsName.Focus();
            }
            else if (!Username.Any(char.IsLower))
            {
                MessageBox.Show("Your \"Username\" should include at least  1 Lower Case Letter!", "Username Input Failed", MessageBoxButtons.RetryCancel);
                txtAdmUsName.Focus();
            }

            //Controlling of Legal Name Input 
            else if (txtAdmLglName.Text == "")
            {
                MessageBox.Show("Please input your \"Legal Name\"!", "Legal Name Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txtAdmLglName.Focus();
            }
            else if (LglName.Any(char.IsDigit))
            {
                MessageBox.Show("Your \"Legal Name\" should be only alphabets", "Legal Name Input Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txtAdmLglName.Focus();
            }


            //Controlling of Password Input 
            else if (txtAdmPw.Text == "")
            {
                MessageBox.Show("Please input your \"Password\"!", "Password Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txtAdmPw.Focus();
            }
            else if (Password.Length < 8 || Password.Length > 20)
            {
                MessageBox.Show("Only 8 to 20 characters are allowed for password!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                txtAdmPw.Focus();
            }
            else if (!Password.Any(char.IsUpper))
            {
                MessageBox.Show("Your password should include at least \" 1 Upper Case Letter\"!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                txtAdmPw.Focus();
            }

            else if (!Password.Any(char.IsLower))
            {
                MessageBox.Show("Your password should include at least \" 1 Lower Case Letter\"!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                txtAdmPw.Focus();
            }

            else if (!Password.Any(char.IsDigit))
            {
                MessageBox.Show("Your password should include at least \" 1 Digit\"!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                txtAdmPw.Focus();
            }
            else
            {
                Adm_Class objAdmC = new Adm_Class();
                objAdmC.AdmID = lblAdmID.Text;
                objAdmC.AdmUsName = txtAdmUsName.Text;
                objAdmC.AdmLglName = txtAdmLglName.Text;
                objAdmC.AdmPw = txtAdmPw.Text;
                objAdmC.AdmEmail = txtAdmEmail.Text;

                objAdmAuthn.Insert_AdmAuthn_Query(objAdmC.AdmID, objAdmC.AdmUsName, objAdmC.AdmLglName, objAdmC.AdmPw, objAdmC.AdmEmail);


                //  objAdmAuthn.Insert(lblAdmID.Text, txtAdmUsName.Text, txtAdmLglName.Text, txtAdmPw.Text, txtAdmEmail.Text);
                MessageBox.Show("Successfully Registered");

            }


        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
