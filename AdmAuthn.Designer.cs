namespace FitTrack_Assignment_Program
{
    partial class frmAdmAuthn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Login = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtAdmEmail = new System.Windows.Forms.TextBox();
            this.txtAdmPw = new System.Windows.Forms.TextBox();
            this.txtAdmLglName = new System.Windows.Forms.TextBox();
            this.txtAdmUsName = new System.Windows.Forms.TextBox();
            this.lblAdmID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrator Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Administrator Legal Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Administrator Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Administrator Email";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtAdmEmail);
            this.groupBox1.Controls.Add(this.txtAdmPw);
            this.groupBox1.Controls.Add(this.txtAdmLglName);
            this.groupBox1.Controls.Add(this.txtAdmUsName);
            this.groupBox1.Controls.Add(this.lblAdmID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 595);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator Authentication";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(428, 442);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(121, 25);
            this.Login.TabIndex = 15;
            this.Login.TabStop = true;
            this.Login.Text = "Log In here";
            this.Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(192, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "I already have an account?";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(475, 544);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(159, 355);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(369, 45);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create an Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAdmEmail
            // 
            this.txtAdmEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.txtAdmEmail.Location = new System.Drawing.Point(353, 299);
            this.txtAdmEmail.Name = "txtAdmEmail";
            this.txtAdmEmail.Size = new System.Drawing.Size(276, 30);
            this.txtAdmEmail.TabIndex = 10;
            // 
            // txtAdmPw
            // 
            this.txtAdmPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.txtAdmPw.Location = new System.Drawing.Point(353, 233);
            this.txtAdmPw.Name = "txtAdmPw";
            this.txtAdmPw.Size = new System.Drawing.Size(276, 30);
            this.txtAdmPw.TabIndex = 9;
            // 
            // txtAdmLglName
            // 
            this.txtAdmLglName.Location = new System.Drawing.Point(353, 170);
            this.txtAdmLglName.Name = "txtAdmLglName";
            this.txtAdmLglName.Size = new System.Drawing.Size(276, 30);
            this.txtAdmLglName.TabIndex = 8;
            // 
            // txtAdmUsName
            // 
            this.txtAdmUsName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.txtAdmUsName.Location = new System.Drawing.Point(353, 116);
            this.txtAdmUsName.Name = "txtAdmUsName";
            this.txtAdmUsName.Size = new System.Drawing.Size(276, 30);
            this.txtAdmUsName.TabIndex = 7;
            // 
            // lblAdmID
            // 
            this.lblAdmID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.lblAdmID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdmID.Location = new System.Drawing.Point(353, 48);
            this.lblAdmID.Name = "lblAdmID";
            this.lblAdmID.Size = new System.Drawing.Size(276, 37);
            this.lblAdmID.TabIndex = 6;
            // 
            // frmAdmAuthn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(874, 654);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdmAuthn";
            this.Text = "Administrator Authentication Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdmID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtAdmEmail;
        private System.Windows.Forms.TextBox txtAdmPw;
        private System.Windows.Forms.TextBox txtAdmLglName;
        private System.Windows.Forms.TextBox txtAdmUsName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel Login;
    }
}

