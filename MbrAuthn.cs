using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FitTrack_Assignment_Program
{
    public partial class FrmMbrAuthn : Form
    {
        public FrmMbrAuthn()
        {
            InitializeComponent();
            SystID();
        }

        FitTrack_DataSetTableAdapters.MbrAuthnTableAdapter objMbrAuthn = new FitTrack_DataSetTableAdapters.MbrAuthnTableAdapter();
        DataTable dtadm = new DataTable();

        //Syst = System-Generated ID
        public void SystID()
        {
            DataTable dtSystID = new DataTable();
            dtSystID = objMbrAuthn.GetData();

            if (dtSystID.Rows.Count == 0)
            {
                lblMbrID.Text = "M_001";

            }
            else
            {
                int Count = dtSystID.Rows.Count - 1;  // Last Admin ID from dt
                string PastID = dtSystID.Rows[Count][0].ToString();
                int LatestID = Convert.ToInt32(PastID.Substring(2, 3));

                if (LatestID >= 0 && LatestID < 9)
                {
                    lblMbrID.Text = "M_00" + (LatestID + 1);
                }
                else if (LatestID >= 9 && LatestID < 99)
                {
                    lblMbrID.Text = "M_0" + (LatestID + 1);
                }
                else if (LatestID >= 99 && LatestID < 999)
                {
                    lblMbrID.Text = "M_" + (LatestID + 1);
                }

            }

        }

        public void Clear_Btn()
        {
            txtMbrEmail.Clear();
            txtMbrAddress.Clear();
            txtMbrHeight.Clear();
            txtMbrLglName.Clear();
            txtMbrPh.Clear();
            txtMbrPw.Clear();
            txtMbrUsName.Clear();
            txtMbrWeight.Clear();
            lblMbrID.Text = "";
            MbrImage.Image = null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear_Btn();
        }

 

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Username = txtMbrUsName.Text;
            string LglName = txtMbrLglName.Text;
            string Password = txtMbrPw.Text;
            string PhNo = txtMbrPh.Text;
            string Gender = null; 
            int weight = Convert.ToInt32(txtMbrWeight.Text.ToString());
            int height = Convert.ToInt32(txtMbrHeight.Text.ToString());

            DateTime TodayDate = dtpMbrBd.Value;
              if (rdoFemale.Checked == true)
            {
                Gender = rdoFemale.Text;
            }
            else
            {
                Gender = rdomale.Text;
            }

            //Controlling of Username Input 
              if (txtMbrUsName.Text == null)
              {
                          MessageBox.Show("Please input your \"Username\"!", "Username Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                          txtMbrUsName.Focus();
               
              }

              else if (!Username.Any(char.IsDigit))
              {
                  MessageBox.Show("Your \"Username\" should include at least 1 number!", "Username Input Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                  txtMbrUsName.Focus();
              }
              else if (!Username.Any(char.IsUpper))
              {
                  MessageBox.Show("Your \"Username\" should include at least  1 Upper Case Letter!", "Username Input Failed", MessageBoxButtons.RetryCancel);
                  txtMbrUsName.Focus();
              }
              else if (!Username.Any(char.IsLower))
              {
                  MessageBox.Show("Your \"Username\" should include at least  1 Lower Case Letter!", "Username Input Failed", MessageBoxButtons.RetryCancel);
                  txtMbrUsName.Focus();
              }

              //Controlling of Legal Name Input 
              else if (txtMbrLglName.Text == "")
              {
                  MessageBox.Show("Please input your \"Legal Name\"!", "Legal Name Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                  txtMbrLglName.Focus();
              }
              else if (LglName.Any(char.IsDigit))
              {
                  MessageBox.Show("Your \"Legal Name\" should be only alphabets", "Legal Name Input Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                  txtMbrLglName.Focus();
              }


              //Controlling of Password Input 
              else if (txtMbrPw.Text == "")
              {
                  MessageBox.Show("Please input your \"Password\"!", "Password Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                  txtMbrPw.Focus();
              }
              else if (Password.Length < 8 || Password.Length > 20)
              {
                  MessageBox.Show("Only 8 to 20 characters are allowed for password!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                  txtMbrPw.Focus();
              }
              else if (!Password.Any(char.IsUpper))
              {
                  MessageBox.Show("Your password should include at least \" 1 Upper Case Letter\"!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                  txtMbrPw.Focus();
              }

              else if (!Password.Any(char.IsLower))
              {
                  MessageBox.Show("Your password should include at least \" 1 Lower Case Letter\"!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                  txtMbrPw.Focus();
              }

              else if (!Password.Any(char.IsDigit))
              {
                  MessageBox.Show("Your password should include at least \" 1 Digit\"!", "Password Input Failed", MessageBoxButtons.RetryCancel);
                  txtMbrPw.Focus();
              }
              //Controlling of Email Input 

              else if (txtMbrEmail.Text == "")
              {
                  MessageBox.Show("Please input your \"Email\"!", "Email Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                  txtMbrEmail.Focus();
              }

             //controlling of Phone Number Input
              else if (txtMbrPh.Text == "")
              {
                  MessageBox.Show("Please input your \"Phone No\"!", "Phone No Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                  txtMbrPh.Focus();
              }
              else if ((PhNo.Any(char.IsLetter)))
              {

                  MessageBox.Show("Your \"Phone No\" should be only integers!", "Phone No Input Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                  txtMbrPh.Focus();
              }

              else
              {
                  //Loc = Location
                  string Loc = "C:\\00000000_Thinzar_DDOOCP_GA\\Program\\FitTrack_Assignment_Program\\FitTrack_Assignment_Program\\bin\\Debug\\Images";

                  string path = Path.Combine(Loc, txtMbrUsName.Text + ".jpg");
                  Image Img = MbrImage.Image;
                  Img.Save(path);

                  objMbrAuthn.Insert_MbrAuthn_Query(lblMbrID.Text, txtMbrUsName.Text, txtMbrLglName.Text, txtMbrPw.Text, txtMbrEmail.Text, txtMbrPh.Text, Gender, TodayDate.ToString(), txtMbrAddress.Text, weight, height, path);
                  MessageBox.Show("Successfully Registered");
                  SystID();
                  Clear_Btn();
                  txtMbrUsName.Focus();
              }
        }


        private void MbrImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            PictureBox pic = sender as PictureBox;

            if (pic != null)
            {
                Open.Filter = "(*.jpg;*jped;*.png) | *.jpg;*jped;*.png";
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(Open.FileName);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
        

  

  


    
