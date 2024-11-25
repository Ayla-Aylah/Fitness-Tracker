namespace FitTrack_Assignment_Program
{
    partial class frm_Mbr_Goal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblusname = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnrecord = new System.Windows.Forms.Button();
            this.txtTW = new System.Windows.Forms.TextBox();
            this.txtTimeFrame = new System.Windows.Forms.TextBox();
            this.lblGoalId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMbrReg = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGoals = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProgresses = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.lblusname);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnrecord);
            this.groupBox1.Controls.Add(this.txtTW);
            this.groupBox1.Controls.Add(this.txtTimeFrame);
            this.groupBox1.Controls.Add(this.lblGoalId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 152);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(532, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Goal Details";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(273, 204);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(219, 31);
            this.dtpEnd.TabIndex = 28;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(26, 204);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(219, 31);
            this.dtpStart.TabIndex = 27;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // lblusname
            // 
            this.lblusname.BackColor = System.Drawing.Color.White;
            this.lblusname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.lblusname.Location = new System.Drawing.Point(273, 91);
            this.lblusname.Name = "lblusname";
            this.lblusname.Size = new System.Drawing.Size(219, 36);
            this.lblusname.TabIndex = 26;
            this.lblusname.Click += new System.EventHandler(this.lblusname_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(456, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 26);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(210, 396);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 25);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(376, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnrecord
            // 
            this.btnrecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.btnrecord.Location = new System.Drawing.Point(144, 332);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(216, 38);
            this.btnrecord.TabIndex = 13;
            this.btnrecord.Text = "Record Your Goal";
            this.btnrecord.UseVisualStyleBackColor = true;
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // txtTW
            // 
            this.txtTW.BackColor = System.Drawing.Color.White;
            this.txtTW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.txtTW.Location = new System.Drawing.Point(273, 279);
            this.txtTW.Name = "txtTW";
            this.txtTW.Size = new System.Drawing.Size(219, 31);
            this.txtTW.TabIndex = 12;
            // 
            // txtTimeFrame
            // 
            this.txtTimeFrame.BackColor = System.Drawing.Color.White;
            this.txtTimeFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.txtTimeFrame.Location = new System.Drawing.Point(273, 242);
            this.txtTimeFrame.Name = "txtTimeFrame";
            this.txtTimeFrame.Size = new System.Drawing.Size(219, 31);
            this.txtTimeFrame.TabIndex = 9;
            // 
            // lblGoalId
            // 
            this.lblGoalId.BackColor = System.Drawing.Color.White;
            this.lblGoalId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.lblGoalId.Location = new System.Drawing.Point(273, 39);
            this.lblGoalId.Name = "lblGoalId";
            this.lblGoalId.Size = new System.Drawing.Size(219, 37);
            this.lblGoalId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Goal Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time Frame";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Target Weight";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnMbrReg);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnGoals);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnProgresses);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 150);
            this.panel2.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Goals";
            // 
            // btnMbrReg
            // 
            this.btnMbrReg.BackgroundImage = global::FitTrack_Assignment_Program.Properties.Resources.login;
            this.btnMbrReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMbrReg.Location = new System.Drawing.Point(10, 4);
            this.btnMbrReg.Name = "btnMbrReg";
            this.btnMbrReg.Size = new System.Drawing.Size(116, 107);
            this.btnMbrReg.TabIndex = 2;
            this.btnMbrReg.UseVisualStyleBackColor = true;
            this.btnMbrReg.Click += new System.EventHandler(this.btnMbrReg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Progresses";
            // 
            // btnGoals
            // 
            this.btnGoals.BackgroundImage = global::FitTrack_Assignment_Program.Properties.Resources.Goal_icon_by_back1design11;
            this.btnGoals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoals.Location = new System.Drawing.Point(241, 4);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(119, 107);
            this.btnGoals.TabIndex = 5;
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Register  ";
            // 
            // btnProgresses
            // 
            this.btnProgresses.BackgroundImage = global::FitTrack_Assignment_Program.Properties.Resources.stretching_exercise_3488535_2922390;
            this.btnProgresses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProgresses.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgresses.Location = new System.Drawing.Point(125, 3);
            this.btnProgresses.Name = "btnProgresses";
            this.btnProgresses.Size = new System.Drawing.Size(116, 107);
            this.btnProgresses.TabIndex = 14;
            this.btnProgresses.UseVisualStyleBackColor = true;
            this.btnProgresses.Click += new System.EventHandler(this.btnProgresses_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitTrack_Assignment_Program.Properties.Resources.pngwing_com_3_;
            this.pictureBox1.Location = new System.Drawing.Point(539, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Mbr_Goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(896, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Mbr_Goal";
            this.Text = "Member Goal";
            this.Load += new System.EventHandler(this.frm_Mbr_Goal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTW;
        private System.Windows.Forms.TextBox txtTimeFrame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnrecord;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMbrReg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnProgresses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblusname;
        private System.Windows.Forms.Label lblGoalId;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}